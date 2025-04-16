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

namespace Google.Apis.SA360.v0
{
    /// <summary>The SA360 Service.</summary>
    public class SA360Service : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v0";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SA360Service() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SA360Service(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Customers = new CustomersResource(this);
            SearchAds360Fields = new SearchAds360FieldsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://searchads360.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://searchads360.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "searchads360";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Search Ads 360 Reporting API.</summary>
        public class Scope
        {
            /// <summary>View and manage your advertising data in DoubleClick Search</summary>
            public static string Doubleclicksearch = "https://www.googleapis.com/auth/doubleclicksearch";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Search Ads 360 Reporting API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your advertising data in DoubleClick Search</summary>
            public const string Doubleclicksearch = "https://www.googleapis.com/auth/doubleclicksearch";
        }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>Gets the SearchAds360Fields resource.</summary>
        public virtual SearchAds360FieldsResource SearchAds360Fields { get; }
    }

    /// <summary>A base abstract class for SA360 requests.</summary>
    public abstract class SA360BaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SA360BaseServiceRequest instance.</summary>
        protected SA360BaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SA360 parameter list.</summary>
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

    /// <summary>The "customers" collection of methods.</summary>
    public class CustomersResource
    {
        private const string Resource = "customers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            CustomColumns = new CustomColumnsResource(service);
            SearchAds360 = new SearchAds360Resource(service);
        }

        /// <summary>Gets the CustomColumns resource.</summary>
        public virtual CustomColumnsResource CustomColumns { get; }

        /// <summary>The "customColumns" collection of methods.</summary>
        public class CustomColumnsResource
        {
            private const string Resource = "customColumns";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomColumnsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns the requested custom column in full detail.</summary>
            /// <param name="resourceName">Required. The resource name of the custom column to fetch.</param>
            public virtual GetRequest Get(string resourceName)
            {
                return new GetRequest(this.service, resourceName);
            }

            /// <summary>Returns the requested custom column in full detail.</summary>
            public class GetRequest : SA360BaseServiceRequest<Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ResourcesCustomColumn>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
                {
                    ResourceName = resourceName;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the custom column to fetch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ResourceName { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v0/{+resourceName}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+/customColumns/[^/]+$",
                    });
                }
            }

            /// <summary>Returns all the custom columns associated with the customer in full detail.</summary>
            /// <param name="customerId">
            /// Required. The ID of the customer to apply the CustomColumn list operation to.
            /// </param>
            public virtual ListRequest List(string customerId)
            {
                return new ListRequest(this.service, customerId);
            }

            /// <summary>Returns all the custom columns associated with the customer in full detail.</summary>
            public class ListRequest : SA360BaseServiceRequest<Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesListCustomColumnsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string customerId) : base(service)
                {
                    CustomerId = customerId;
                    InitParameters();
                }

                /// <summary>Required. The ID of the customer to apply the CustomColumn list operation to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomerId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v0/customers/{+customerId}/customColumns";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the SearchAds360 resource.</summary>
        public virtual SearchAds360Resource SearchAds360 { get; }

        /// <summary>The "searchAds360" collection of methods.</summary>
        public class SearchAds360Resource
        {
            private const string Resource = "searchAds360";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SearchAds360Resource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns all rows that match the search query. List of thrown errors: [AuthenticationError]()
            /// [AuthorizationError]() [HeaderError]() [InternalError]() [QueryError]() [QuotaError]() [RequestError]()
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customerId">Required. The ID of the customer being queried.</param>
            public virtual SearchRequest Search(Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360Request body, string customerId)
            {
                return new SearchRequest(this.service, body, customerId);
            }

            /// <summary>
            /// Returns all rows that match the search query. List of thrown errors: [AuthenticationError]()
            /// [AuthorizationError]() [HeaderError]() [InternalError]() [QueryError]() [QuotaError]() [RequestError]()
            /// </summary>
            public class SearchRequest : SA360BaseServiceRequest<Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360Response>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360Request body, string customerId) : base(service)
                {
                    CustomerId = customerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the customer being queried.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360Request Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v0/customers/{+customerId}/searchAds360:search";

                /// <summary>Initializes Search parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the user authenticating the call. List of thrown
        /// errors: [AuthenticationError]() [AuthorizationError]() [HeaderError]() [InternalError]() [QuotaError]()
        /// [RequestError]()
        /// </summary>
        public virtual ListAccessibleCustomersRequest ListAccessibleCustomers()
        {
            return new ListAccessibleCustomersRequest(this.service);
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the user authenticating the call. List of thrown
        /// errors: [AuthenticationError]() [AuthorizationError]() [HeaderError]() [InternalError]() [QuotaError]()
        /// [RequestError]()
        /// </summary>
        public class ListAccessibleCustomersRequest : SA360BaseServiceRequest<Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesListAccessibleCustomersResponse>
        {
            /// <summary>Constructs a new ListAccessibleCustomers request.</summary>
            public ListAccessibleCustomersRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listAccessibleCustomers";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v0/customers:listAccessibleCustomers";

            /// <summary>Initializes ListAccessibleCustomers parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "searchAds360Fields" collection of methods.</summary>
    public class SearchAds360FieldsResource
    {
        private const string Resource = "searchAds360Fields";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SearchAds360FieldsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Returns just the requested field. List of thrown errors: [AuthenticationError]() [AuthorizationError]()
        /// [HeaderError]() [InternalError]() [QuotaError]() [RequestError]()
        /// </summary>
        /// <param name="resourceName">Required. The resource name of the field to get.</param>
        public virtual GetRequest Get(string resourceName)
        {
            return new GetRequest(this.service, resourceName);
        }

        /// <summary>
        /// Returns just the requested field. List of thrown errors: [AuthenticationError]() [AuthorizationError]()
        /// [HeaderError]() [InternalError]() [QuotaError]() [RequestError]()
        /// </summary>
        public class GetRequest : SA360BaseServiceRequest<Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ResourcesSearchAds360Field>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                InitParameters();
            }

            /// <summary>Required. The resource name of the field to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v0/{+resourceName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^searchAds360Fields/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns all fields that match the search
        /// [query](/search-ads/reporting/concepts/field-service#use_a_query_to_get_field_details). List of thrown
        /// errors: [AuthenticationError]() [AuthorizationError]() [HeaderError]() [InternalError]() [QueryError]()
        /// [QuotaError]() [RequestError]()
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360FieldsRequest body)
        {
            return new SearchRequest(this.service, body);
        }

        /// <summary>
        /// Returns all fields that match the search
        /// [query](/search-ads/reporting/concepts/field-service#use_a_query_to_get_field_details). List of thrown
        /// errors: [AuthenticationError]() [AuthorizationError]() [HeaderError]() [InternalError]() [QueryError]()
        /// [QuotaError]() [RequestError]()
        /// </summary>
        public class SearchRequest : SA360BaseServiceRequest<Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360FieldsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360FieldsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SA360.v0.Data.GoogleAdsSearchads360V0ServicesSearchSearchAds360FieldsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v0/searchAds360Fields:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.SA360.v0.Data
{
    /// <summary>
    /// Represents an AdSchedule criterion. AdSchedule is specified as the day of the week and a time interval within
    /// which ads will be shown. No more than six AdSchedules can be added for the same day.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonAdScheduleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of the week the schedule applies to. This field is required for CREATE operations and is prohibited on
        /// UPDATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>
        /// Ending hour in 24 hour time; 24 signifies end of the day. This field must be between 0 and 24, inclusive.
        /// This field is required for CREATE operations and is prohibited on UPDATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endHour")]
        public virtual System.Nullable<int> EndHour { get; set; }

        /// <summary>
        /// Minutes after the end hour at which this schedule ends. The schedule is exclusive of the end minute. This
        /// field is required for CREATE operations and is prohibited on UPDATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endMinute")]
        public virtual string EndMinute { get; set; }

        /// <summary>
        /// Starting hour in 24 hour time. This field must be between 0 and 23, inclusive. This field is required for
        /// CREATE operations and is prohibited on UPDATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startHour")]
        public virtual System.Nullable<int> StartHour { get; set; }

        /// <summary>
        /// Minutes after the start hour at which this schedule starts. This field is required for CREATE operations and
        /// is prohibited on UPDATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startMinute")]
        public virtual string StartMinute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A text asset used inside an ad.</summary>
    public class GoogleAdsSearchads360V0CommonAdTextAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Asset text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An age range criterion.</summary>
    public class GoogleAdsSearchads360V0CommonAgeRangeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the age range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An AssetInteractionTarget segment.</summary>
    public class GoogleAdsSearchads360V0CommonAssetInteractionTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The asset resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>
        /// Only used with CustomerAsset, CampaignAsset and AdGroupAsset metrics. Indicates whether the interaction
        /// metrics occurred on the asset itself or a different asset or ad unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactionOnThisAsset")]
        public virtual System.Nullable<bool> InteractionOnThisAsset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the usage information of the asset.</summary>
    public class GoogleAdsSearchads360V0CommonAssetUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>The served field type of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servedAssetFieldType")]
        public virtual string ServedAssetFieldType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An audience criterion.</summary>
    public class GoogleAdsSearchads360V0CommonAudienceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Audience resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Business Profile location data synced from the linked Business Profile account.</summary>
    public class GoogleAdsSearchads360V0CommonBusinessProfileLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Advertiser specified label for the location on the Business Profile account. This is synced from the
        /// Business Profile account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Listing ID of this Business Profile location. This is synced from the linked Business Profile account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listingId")]
        public virtual System.Nullable<long> ListingId { get; set; }

        /// <summary>
        /// Business Profile store code of this location. This is synced from the Business Profile account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A call to action asset.</summary>
    public class GoogleAdsSearchads360V0CommonCallToActionAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Call to action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callToAction")]
        public virtual string CallToAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mapping that can be used by custom parameter tags in a `tracking_url_template`, `final_urls`, or
    /// `mobile_final_urls`.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonCustomParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key matching the parameter tag name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value to be substituted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A device criterion.</summary>
    public class GoogleAdsSearchads360V0CommonDeviceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy that raises bids for clicks that seem more likely to lead to a conversion and
    /// lowers them for clicks where they seem less likely. This bidding strategy is deprecated and cannot be created
    /// anymore. Use ManualCpc with enhanced_cpc_enabled set to true for equivalent functionality.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonEnhancedCpc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rule specifying the maximum number of times an ad (or some set of ads) can be shown to a user over a
    /// particular time period.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonFrequencyCapEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A gender criterion.</summary>
    public class GoogleAdsSearchads360V0CommonGenderInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Image asset.</summary>
    public class GoogleAdsSearchads360V0CommonImageAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>File size of the image asset in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<long> FileSize { get; set; }

        /// <summary>Metadata for this image at its original size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullSize")]
        public virtual GoogleAdsSearchads360V0CommonImageDimension FullSize { get; set; }

        /// <summary>MIME type of the image asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for an image at a certain size, either original or resized.</summary>
    public class GoogleAdsSearchads360V0CommonImageDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Height of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPixels")]
        public virtual System.Nullable<long> HeightPixels { get; set; }

        /// <summary>A URL that returns the image with this height and width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>Width of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPixels")]
        public virtual System.Nullable<long> WidthPixels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Keyword criterion segment.</summary>
    public class GoogleAdsSearchads360V0CommonKeyword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AdGroupCriterion resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupCriterion")]
        public virtual string AdGroupCriterion { get; set; }

        /// <summary>Keyword info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual GoogleAdsSearchads360V0CommonKeywordInfo Info { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A keyword criterion.</summary>
    public class GoogleAdsSearchads360V0CommonKeywordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The match type of the keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>The text of the keyword (at most 80 characters and 10 words).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A language criterion.</summary>
    public class GoogleAdsSearchads360V0CommonLanguageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The language constant resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageConstant")]
        public virtual string LanguageConstant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A listing group criterion.</summary>
    public class GoogleAdsSearchads360V0CommonListingGroupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the listing group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A radius around a list of locations specified through a feed.</summary>
    public class GoogleAdsSearchads360V0CommonLocationGroupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// FeedItemSets whose FeedItems are targeted. If multiple IDs are specified, then all items that appear in at
        /// least one set are targeted. This field cannot be used with geo_target_constants. This is optional and can
        /// only be set in CREATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedItemSets")]
        public virtual System.Collections.Generic.IList<string> FeedItemSets { get; set; }

        /// <summary>
        /// Geo target constant(s) restricting the scope of the geographic area within the feed. Currently only one geo
        /// target constant is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetConstants")]
        public virtual System.Collections.Generic.IList<string> GeoTargetConstants { get; set; }

        /// <summary>
        /// Distance in units specifying the radius around targeted locations. This is required and must be set in
        /// CREATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radius")]
        public virtual System.Nullable<long> Radius { get; set; }

        /// <summary>
        /// Unit of the radius. Miles and meters are supported for geo target constants. Milli miles and meters are
        /// supported for feed item sets. This is required and must be set in CREATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radiusUnits")]
        public virtual string RadiusUnits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A location criterion.</summary>
    public class GoogleAdsSearchads360V0CommonLocationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The geo target constant resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetConstant")]
        public virtual string GeoTargetConstant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Manual bidding strategy that allows advertiser to set the bid per advertiser-specified action.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonManualCpa : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Manual click-based bidding where user pays per click.</summary>
    public class GoogleAdsSearchads360V0CommonManualCpc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether bids are to be enhanced based on conversion optimizer data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enhancedCpcEnabled")]
        public virtual System.Nullable<bool> EnhancedCpcEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Manual impression-based bidding where user pays per thousand impressions.</summary>
    public class GoogleAdsSearchads360V0CommonManualCpm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy to help get the most conversion value for your campaigns while spending your
    /// budget.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonMaximizeConversionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. Mutable for portfolio bidding strategies only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>
        /// Minimum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. Mutable for portfolio bidding strategies only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidFloorMicros")]
        public virtual System.Nullable<long> CpcBidFloorMicros { get; set; }

        /// <summary>
        /// The target return on ad spend (ROAS) option. If set, the bid strategy will maximize revenue while averaging
        /// the target return on ad spend. If the target ROAS is high, the bid strategy may not be able to spend the
        /// full budget. If the target ROAS is not set, the bid strategy will aim to achieve the highest possible ROAS
        /// for the budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRoas")]
        public virtual System.Nullable<double> TargetRoas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy to help get the most conversions for your campaigns while spending your budget.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonMaximizeConversions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. Mutable for portfolio bidding strategies only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>
        /// Minimum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. Mutable for portfolio bidding strategies only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidFloorMicros")]
        public virtual System.Nullable<long> CpcBidFloorMicros { get; set; }

        /// <summary>
        /// The target cost-per-action (CPA) option. This is the average amount that you would like to spend per
        /// conversion action specified in micro units of the bidding strategy's currency. If set, the bid strategy will
        /// get as many conversions as possible at or below the target cost-per-action. If the target CPA is not set,
        /// the bid strategy will aim to achieve the lowest possible CPA given the budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpaMicros")]
        public virtual System.Nullable<long> TargetCpaMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics data.</summary>
    public class GoogleAdsSearchads360V0CommonMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Search absolute top impression share is the percentage of your Search ad impressions that are shown in the
        /// most prominent Search position.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absoluteTopImpressionPercentage")]
        public virtual System.Nullable<double> AbsoluteTopImpressionPercentage { get; set; }

        /// <summary>
        /// The total number of conversions. This includes all conversions regardless of the value of
        /// include_in_conversions_metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversions")]
        public virtual System.Nullable<double> AllConversions { get; set; }

        /// <summary>
        /// The total number of conversions. This includes all conversions regardless of the value of
        /// include_in_conversions_metric. When this column is selected with date, the values in date column means the
        /// conversion date. Details for the by_conversion_date columns are available at
        /// https://support.google.com/sa360/answer/9250611.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsByConversionDate")]
        public virtual System.Nullable<double> AllConversionsByConversionDate { get; set; }

        /// <summary>
        /// The number of times people clicked the "Call" button to call a store during or after clicking an ad. This
        /// number doesn't include whether or not calls were connected, or the duration of any calls. This metric
        /// applies to feed items only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromClickToCall")]
        public virtual System.Nullable<double> AllConversionsFromClickToCall { get; set; }

        /// <summary>
        /// The number of times people clicked a "Get directions" button to navigate to a store after clicking an ad.
        /// This metric applies to feed items only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromDirections")]
        public virtual System.Nullable<double> AllConversionsFromDirections { get; set; }

        /// <summary>
        /// All conversions from interactions (as oppose to view through conversions) divided by the number of ad
        /// interactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromInteractionsRate")]
        public virtual System.Nullable<double> AllConversionsFromInteractionsRate { get; set; }

        /// <summary>
        /// The value of all conversions from interactions divided by the total number of interactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromInteractionsValuePerInteraction")]
        public virtual System.Nullable<double> AllConversionsFromInteractionsValuePerInteraction { get; set; }

        /// <summary>
        /// The number of times people clicked a link to view a store's menu after clicking an ad. This metric applies
        /// to feed items only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromMenu")]
        public virtual System.Nullable<double> AllConversionsFromMenu { get; set; }

        /// <summary>
        /// The number of times people placed an order at a store after clicking an ad. This metric applies to feed
        /// items only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromOrder")]
        public virtual System.Nullable<double> AllConversionsFromOrder { get; set; }

        /// <summary>
        /// The number of other conversions (for example, posting a review or saving a location for a store) that
        /// occurred after people clicked an ad. This metric applies to feed items only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromOtherEngagement")]
        public virtual System.Nullable<double> AllConversionsFromOtherEngagement { get; set; }

        /// <summary>
        /// Estimated number of times people visited a store after clicking an ad. This metric applies to feed items
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromStoreVisit")]
        public virtual System.Nullable<double> AllConversionsFromStoreVisit { get; set; }

        /// <summary>
        /// The number of times that people were taken to a store's URL after clicking an ad. This metric applies to
        /// feed items only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsFromStoreWebsite")]
        public virtual System.Nullable<double> AllConversionsFromStoreWebsite { get; set; }

        /// <summary>The value of all conversions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsValue")]
        public virtual System.Nullable<double> AllConversionsValue { get; set; }

        /// <summary>
        /// The value of all conversions. When this column is selected with date, the values in date column means the
        /// conversion date. Details for the by_conversion_date columns are available at
        /// https://support.google.com/sa360/answer/9250611.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsValueByConversionDate")]
        public virtual System.Nullable<double> AllConversionsValueByConversionDate { get; set; }

        /// <summary>
        /// The value of all conversions divided by the total cost of ad interactions (such as clicks for text ads or
        /// views for video ads).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConversionsValuePerCost")]
        public virtual System.Nullable<double> AllConversionsValuePerCost { get; set; }

        /// <summary>
        /// The average amount you pay per interaction. This amount is the total cost of your ads divided by the total
        /// number of interactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageCost")]
        public virtual System.Nullable<double> AverageCost { get; set; }

        /// <summary>
        /// The total cost of all clicks divided by the total number of clicks received. This metric is a monetary value
        /// and returned in the customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageCpc")]
        public virtual System.Nullable<double> AverageCpc { get; set; }

        /// <summary>
        /// Average cost-per-thousand impressions (CPM). This metric is a monetary value and returned in the customer's
        /// currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageCpm")]
        public virtual System.Nullable<double> AverageCpm { get; set; }

        /// <summary>The average quality score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageQualityScore")]
        public virtual System.Nullable<double> AverageQualityScore { get; set; }

        /// <summary>The number of clicks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clicks")]
        public virtual System.Nullable<long> Clicks { get; set; }

        /// <summary>
        /// The number of client account conversions. This only includes conversion actions which
        /// include_in_client_account_conversions_metric attribute is set to true. If you use conversion-based bidding,
        /// your bid strategies will optimize for these conversions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountConversions")]
        public virtual System.Nullable<double> ClientAccountConversions { get; set; }

        /// <summary>
        /// The value of client account conversions. This only includes conversion actions which
        /// include_in_client_account_conversions_metric attribute is set to true. If you use conversion-based bidding,
        /// your bid strategies will optimize for these conversions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountConversionsValue")]
        public virtual System.Nullable<double> ClientAccountConversionsValue { get; set; }

        /// <summary>
        /// Client account cross-sell cost of goods sold (COGS) is the total cost of products sold as a result of
        /// advertising a different product. How it works: You report conversions with cart data for completed purchases
        /// on your website. If the ad that was interacted with before the purchase has an associated product (see
        /// Shopping Ads) then this product is considered the advertised product. Any product included in the order the
        /// customer places is a sold product. If these products don't match then this is considered cross-sell.
        /// Cross-sell cost of goods sold is the total cost of the products sold that weren't advertised. Example:
        /// Someone clicked on a Shopping ad for a hat then bought the same hat and a shirt. The hat has a cost of goods
        /// sold value of $3, the shirt has a cost of goods sold value of $5. The cross-sell cost of goods sold for this
        /// order is $5. This metric is only available if you report conversions with cart data. This metric is a
        /// monetary value and returned in the customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountCrossSellCostOfGoodsSoldMicros")]
        public virtual System.Nullable<long> ClientAccountCrossSellCostOfGoodsSoldMicros { get; set; }

        /// <summary>
        /// Client account cross-sell gross profit is the profit you made from products sold as a result of advertising
        /// a different product, minus cost of goods sold (COGS). How it works: You report conversions with cart data
        /// for completed purchases on your website. If the ad that was interacted with before the purchase has an
        /// associated product (see Shopping Ads) then this product is considered the advertised product. Any product
        /// included in the purchase is a sold product. If these products don't match then this is considered
        /// cross-sell. Cross-sell gross profit is the revenue you made from cross-sell attributed to your ads minus the
        /// cost of the goods sold. Example: Someone clicked on a Shopping ad for a hat then bought the same hat and a
        /// shirt. The shirt is priced $20 and has a cost of goods sold value of $5. The cross-sell gross profit of this
        /// order is $15 = $20 - $5. This metric is only available if you report conversions with cart data. This metric
        /// is a monetary value and returned in the customer's currency by default. See the metrics_currency parameter
        /// at https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountCrossSellGrossProfitMicros")]
        public virtual System.Nullable<long> ClientAccountCrossSellGrossProfitMicros { get; set; }

        /// <summary>
        /// Client account cross-sell revenue is the total amount you made from products sold as a result of advertising
        /// a different product. How it works: You report conversions with cart data for completed purchases on your
        /// website. If the ad that was interacted with before the purchase has an associated product (see Shopping Ads)
        /// then this product is considered the advertised product. Any product included in the order the customer
        /// places is a sold product. If these products don't match then this is considered cross-sell. Cross-sell
        /// revenue is the total value you made from cross-sell attributed to your ads. Example: Someone clicked on a
        /// Shopping ad for a hat then bought the same hat and a shirt. The hat is priced $10 and the shirt is priced
        /// $20. The cross-sell revenue of this order is $20. This metric is only available if you report conversions
        /// with cart data. This metric is a monetary value and returned in the customer's currency by default. See the
        /// metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountCrossSellRevenueMicros")]
        public virtual System.Nullable<long> ClientAccountCrossSellRevenueMicros { get; set; }

        /// <summary>
        /// Client account cross-sell units sold is the total number of products sold as a result of advertising a
        /// different product. How it works: You report conversions with cart data for completed purchases on your
        /// website. If the ad that was interacted with before the purchase has an associated product (see Shopping Ads)
        /// then this product is considered the advertised product. Any product included in the order the customer
        /// places is a sold product. If these products don't match then this is considered cross-sell. Cross-sell units
        /// sold is the total number of cross-sold products from all orders attributed to your ads. Example: Someone
        /// clicked on a Shopping ad for a hat then bought the same hat, a shirt and a jacket. The cross-sell units sold
        /// in this order is 2. This metric is only available if you report conversions with cart data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountCrossSellUnitsSold")]
        public virtual System.Nullable<double> ClientAccountCrossSellUnitsSold { get; set; }

        /// <summary>
        /// Client account lead cost of goods sold (COGS) is the total cost of products sold as a result of advertising
        /// the same product. How it works: You report conversions with cart data for completed purchases on your
        /// website. If the ad that was interacted with has an associated product (see Shopping Ads) then this product
        /// is considered the advertised product. Any product included in the order the customer places is a sold
        /// product. If the advertised and sold products match, then the cost of these goods is counted under lead cost
        /// of goods sold. Example: Someone clicked on a Shopping ad for a hat then bought the same hat and a shirt. The
        /// hat has a cost of goods sold value of $3, the shirt has a cost of goods sold value of $5. The lead cost of
        /// goods sold for this order is $3. This metric is only available if you report conversions with cart data.
        /// This metric is a monetary value and returned in the customer's currency by default. See the metrics_currency
        /// parameter at https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountLeadCostOfGoodsSoldMicros")]
        public virtual System.Nullable<long> ClientAccountLeadCostOfGoodsSoldMicros { get; set; }

        /// <summary>
        /// Client account lead gross profit is the profit you made from products sold as a result of advertising the
        /// same product, minus cost of goods sold (COGS). How it works: You report conversions with cart data for
        /// completed purchases on your website. If the ad that was interacted with before the purchase has an
        /// associated product (see Shopping Ads) then this product is considered the advertised product. Any product
        /// included in the order the customer places is a sold product. If the advertised and sold products match, then
        /// the revenue you made from these sales minus the cost of goods sold is your lead gross profit. Example:
        /// Someone clicked on a Shopping ad for a hat then bought the same hat and a shirt. The hat is priced $10 and
        /// has a cost of goods sold value of $3. The lead gross profit of this order is $7 = $10 - $3. This metric is
        /// only available if you report conversions with cart data. This metric is a monetary value and returned in the
        /// customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountLeadGrossProfitMicros")]
        public virtual System.Nullable<long> ClientAccountLeadGrossProfitMicros { get; set; }

        /// <summary>
        /// Client account lead revenue is the total amount you made from products sold as a result of advertising the
        /// same product. How it works: You report conversions with cart data for completed purchases on your website.
        /// If the ad that was interacted with before the purchase has an associated product (see Shopping Ads) then
        /// this product is considered the advertised product. Any product included in the order the customer places is
        /// a sold product. If the advertised and sold products match, then the total value you made from the sales of
        /// these products is shown under lead revenue. Example: Someone clicked on a Shopping ad for a hat then bought
        /// the same hat and a shirt. The hat is priced $10 and the shirt is priced $20. The lead revenue of this order
        /// is $10. This metric is only available if you report conversions with cart data. This metric is a monetary
        /// value and returned in the customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountLeadRevenueMicros")]
        public virtual System.Nullable<long> ClientAccountLeadRevenueMicros { get; set; }

        /// <summary>
        /// Client account lead units sold is the total number of products sold as a result of advertising the same
        /// product. How it works: You report conversions with cart data for completed purchases on your website. If the
        /// ad that was interacted with before the purchase has an associated product (see Shopping Ads) then this
        /// product is considered the advertised product. Any product included in the order the customer places is a
        /// sold product. If the advertised and sold products match, then the total number of these products sold is
        /// shown under lead units sold. Example: Someone clicked on a Shopping ad for a hat then bought the same hat, a
        /// shirt and a jacket. The lead units sold in this order is 1. This metric is only available if you report
        /// conversions with cart data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountLeadUnitsSold")]
        public virtual System.Nullable<double> ClientAccountLeadUnitsSold { get; set; }

        /// <summary>
        /// The total number of view-through conversions. These happen when a customer sees an image or rich media ad,
        /// then later completes a conversion on your site without interacting with (for example, clicking on) another
        /// ad.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAccountViewThroughConversions")]
        public virtual System.Nullable<long> ClientAccountViewThroughConversions { get; set; }

        /// <summary>
        /// The estimated percent of times that your ad was eligible to show on the Display Network but didn't because
        /// your budget was too low. Note: Content budget lost impression share is reported in the range of 0 to 0.9.
        /// Any value above 0.9 is reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentBudgetLostImpressionShare")]
        public virtual System.Nullable<double> ContentBudgetLostImpressionShare { get; set; }

        /// <summary>
        /// The impressions you've received on the Display Network divided by the estimated number of impressions you
        /// were eligible to receive. Note: Content impression share is reported in the range of 0.1 to 1. Any value
        /// below 0.1 is reported as 0.0999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentImpressionShare")]
        public virtual System.Nullable<double> ContentImpressionShare { get; set; }

        /// <summary>
        /// The estimated percentage of impressions on the Display Network that your ads didn't receive due to poor Ad
        /// Rank. Note: Content rank lost impression share is reported in the range of 0 to 0.9. Any value above 0.9 is
        /// reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentRankLostImpressionShare")]
        public virtual System.Nullable<double> ContentRankLostImpressionShare { get; set; }

        /// <summary>The conversion custom metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionCustomMetrics")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonValue> ConversionCustomMetrics { get; set; }

        /// <summary>
        /// The number of conversions. This only includes conversion actions which include_in_conversions_metric
        /// attribute is set to true. If you use conversion-based bidding, your bid strategies will optimize for these
        /// conversions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversions")]
        public virtual System.Nullable<double> Conversions { get; set; }

        /// <summary>
        /// The sum of conversions by conversion date for biddable conversion types. Can be fractional due to
        /// attribution modeling. When this column is selected with date, the values in date column means the conversion
        /// date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionsByConversionDate")]
        public virtual System.Nullable<double> ConversionsByConversionDate { get; set; }

        /// <summary>
        /// Average biddable conversions (from interaction) per conversion eligible interaction. Shows how often, on
        /// average, an ad interaction leads to a biddable conversion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionsFromInteractionsRate")]
        public virtual System.Nullable<double> ConversionsFromInteractionsRate { get; set; }

        /// <summary>
        /// The value of conversions from interactions divided by the number of ad interactions. This only includes
        /// conversion actions which include_in_conversions_metric attribute is set to true. If you use conversion-based
        /// bidding, your bid strategies will optimize for these conversions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionsFromInteractionsValuePerInteraction")]
        public virtual System.Nullable<double> ConversionsFromInteractionsValuePerInteraction { get; set; }

        /// <summary>
        /// The sum of conversion values for the conversions included in the "conversions" field. This metric is useful
        /// only if you entered a value for your conversion actions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionsValue")]
        public virtual System.Nullable<double> ConversionsValue { get; set; }

        /// <summary>
        /// The sum of biddable conversions value by conversion date. When this column is selected with date, the values
        /// in date column means the conversion date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionsValueByConversionDate")]
        public virtual System.Nullable<double> ConversionsValueByConversionDate { get; set; }

        /// <summary>
        /// The value of biddable conversion divided by the total cost of conversion eligible interactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionsValuePerCost")]
        public virtual System.Nullable<double> ConversionsValuePerCost { get; set; }

        /// <summary>
        /// The sum of your cost-per-click (CPC) and cost-per-thousand impressions (CPM) costs during this period. This
        /// metric is a monetary value and returned in the customer's currency by default. See the metrics_currency
        /// parameter at https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costMicros")]
        public virtual System.Nullable<long> CostMicros { get; set; }

        /// <summary>The cost of ad interactions divided by all conversions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costPerAllConversions")]
        public virtual System.Nullable<double> CostPerAllConversions { get; set; }

        /// <summary>Average conversion eligible cost per biddable conversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costPerConversion")]
        public virtual System.Nullable<double> CostPerConversion { get; set; }

        /// <summary>
        /// The cost of ad interactions divided by current model attributed conversions. This only includes conversion
        /// actions which include_in_conversions_metric attribute is set to true. If you use conversion-based bidding,
        /// your bid strategies will optimize for these conversions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costPerCurrentModelAttributedConversion")]
        public virtual System.Nullable<double> CostPerCurrentModelAttributedConversion { get; set; }

        /// <summary>
        /// Conversions from when a customer clicks on an ad on one device, then converts on a different device or
        /// browser. Cross-device conversions are already included in all_conversions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossDeviceConversions")]
        public virtual System.Nullable<double> CrossDeviceConversions { get; set; }

        /// <summary>
        /// The number of cross-device conversions by conversion date. Details for the by_conversion_date columns are
        /// available at https://support.google.com/sa360/answer/9250611.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossDeviceConversionsByConversionDate")]
        public virtual System.Nullable<double> CrossDeviceConversionsByConversionDate { get; set; }

        /// <summary>The sum of the value of cross-device conversions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossDeviceConversionsValue")]
        public virtual System.Nullable<double> CrossDeviceConversionsValue { get; set; }

        /// <summary>
        /// The sum of cross-device conversions value by conversion date. Details for the by_conversion_date columns are
        /// available at https://support.google.com/sa360/answer/9250611.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossDeviceConversionsValueByConversionDate")]
        public virtual System.Nullable<double> CrossDeviceConversionsValueByConversionDate { get; set; }

        /// <summary>
        /// Cross-sell cost of goods sold (COGS) is the total cost of products sold as a result of advertising a
        /// different product. How it works: You report conversions with cart data for completed purchases on your
        /// website. If the ad that was interacted with before the purchase has an associated product (see Shopping Ads)
        /// then this product is considered the advertised product. Any product included in the order the customer
        /// places is a sold product. If these products don't match then this is considered cross-sell. Cross-sell cost
        /// of goods sold is the total cost of the products sold that weren't advertised. Example: Someone clicked on a
        /// Shopping ad for a hat then bought the same hat and a shirt. The hat has a cost of goods sold value of $3,
        /// the shirt has a cost of goods sold value of $5. The cross-sell cost of goods sold for this order is $5. This
        /// metric is only available if you report conversions with cart data. This metric is a monetary value and
        /// returned in the customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossSellCostOfGoodsSoldMicros")]
        public virtual System.Nullable<long> CrossSellCostOfGoodsSoldMicros { get; set; }

        /// <summary>
        /// Cross-sell gross profit is the profit you made from products sold as a result of advertising a different
        /// product, minus cost of goods sold (COGS). How it works: You report conversions with cart data for completed
        /// purchases on your website. If the ad that was interacted with before the purchase has an associated product
        /// (see Shopping Ads) then this product is considered the advertised product. Any product included in the
        /// purchase is a sold product. If these products don't match then this is considered cross-sell. Cross-sell
        /// gross profit is the revenue you made from cross-sell attributed to your ads minus the cost of the goods
        /// sold. Example: Someone clicked on a Shopping ad for a hat then bought the same hat and a shirt. The shirt is
        /// priced $20 and has a cost of goods sold value of $5. The cross-sell gross profit of this order is $15 = $20
        /// - $5. This metric is only available if you report conversions with cart data. This metric is a monetary
        /// value and returned in the customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossSellGrossProfitMicros")]
        public virtual System.Nullable<long> CrossSellGrossProfitMicros { get; set; }

        /// <summary>
        /// Cross-sell revenue is the total amount you made from products sold as a result of advertising a different
        /// product. How it works: You report conversions with cart data for completed purchases on your website. If the
        /// ad that was interacted with before the purchase has an associated product (see Shopping Ads) then this
        /// product is considered the advertised product. Any product included in the order the customer places is a
        /// sold product. If these products don't match then this is considered cross-sell. Cross-sell revenue is the
        /// total value you made from cross-sell attributed to your ads. Example: Someone clicked on a Shopping ad for a
        /// hat then bought the same hat and a shirt. The hat is priced $10 and the shirt is priced $20. The cross-sell
        /// revenue of this order is $20. This metric is only available if you report conversions with cart data. This
        /// metric is a monetary value and returned in the customer's currency by default. See the metrics_currency
        /// parameter at https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossSellRevenueMicros")]
        public virtual System.Nullable<long> CrossSellRevenueMicros { get; set; }

        /// <summary>
        /// Cross-sell units sold is the total number of products sold as a result of advertising a different product.
        /// How it works: You report conversions with cart data for completed purchases on your website. If the ad that
        /// was interacted with before the purchase has an associated product (see Shopping Ads) then this product is
        /// considered the advertised product. Any product included in the order the customer places is a sold product.
        /// If these products don't match then this is considered cross-sell. Cross-sell units sold is the total number
        /// of cross-sold products from all orders attributed to your ads. Example: Someone clicked on a Shopping ad for
        /// a hat then bought the same hat, a shirt and a jacket. The cross-sell units sold in this order is 2. This
        /// metric is only available if you report conversions with cart data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossSellUnitsSold")]
        public virtual System.Nullable<double> CrossSellUnitsSold { get; set; }

        /// <summary>
        /// The number of clicks your ad receives (Clicks) divided by the number of times your ad is shown
        /// (Impressions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ctr")]
        public virtual System.Nullable<double> Ctr { get; set; }

        /// <summary>
        /// The percentage of clicks that have been filtered out of your total number of clicks (filtered + non-filtered
        /// clicks) due to being general invalid clicks. These are clicks Google considers illegitimate that are
        /// detected through routine means of filtration (that is, known invalid data-center traffic, bots and spiders
        /// or other crawlers, irregular patterns, etc). You're not charged for them, and they don't affect your account
        /// statistics. See the help page at https://support.google.com/campaignmanager/answer/6076504 for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generalInvalidClickRate")]
        public virtual System.Nullable<double> GeneralInvalidClickRate { get; set; }

        /// <summary>
        /// Number of general invalid clicks. These are a subset of your invalid clicks that are detected through
        /// routine means of filtration (such as known invalid data-center traffic, bots and spiders or other crawlers,
        /// irregular patterns, etc.). You're not charged for them, and they don't affect your account statistics. See
        /// the help page at https://support.google.com/campaignmanager/answer/6076504 for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generalInvalidClicks")]
        public virtual System.Nullable<long> GeneralInvalidClicks { get; set; }

        /// <summary>The creative historical quality score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalCreativeQualityScore")]
        public virtual string HistoricalCreativeQualityScore { get; set; }

        /// <summary>The quality of historical landing page experience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalLandingPageQualityScore")]
        public virtual string HistoricalLandingPageQualityScore { get; set; }

        /// <summary>The historical quality score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalQualityScore")]
        public virtual System.Nullable<long> HistoricalQualityScore { get; set; }

        /// <summary>The historical search predicted click through rate (CTR).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalSearchPredictedCtr")]
        public virtual string HistoricalSearchPredictedCtr { get; set; }

        /// <summary>
        /// Count of how often your ad has appeared on a search results page or website on the Google Network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressions")]
        public virtual System.Nullable<long> Impressions { get; set; }

        /// <summary>The types of payable and free interactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactionEventTypes")]
        public virtual System.Collections.Generic.IList<string> InteractionEventTypes { get; set; }

        /// <summary>
        /// How often people interact with your ad after it is shown to them. This is the number of interactions divided
        /// by the number of times your ad is shown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactionRate")]
        public virtual System.Nullable<double> InteractionRate { get; set; }

        /// <summary>
        /// The number of interactions. An interaction is the main user action associated with an ad format-clicks for
        /// text and shopping ads, views for video ads, and so on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactions")]
        public virtual System.Nullable<long> Interactions { get; set; }

        /// <summary>
        /// The percentage of clicks filtered out of your total number of clicks (filtered + non-filtered clicks) during
        /// the reporting period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidClickRate")]
        public virtual System.Nullable<double> InvalidClickRate { get; set; }

        /// <summary>Number of clicks Google considers illegitimate and doesn't charge you for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidClicks")]
        public virtual System.Nullable<long> InvalidClicks { get; set; }

        /// <summary>
        /// Lead cost of goods sold (COGS) is the total cost of products sold as a result of advertising the same
        /// product. How it works: You report conversions with cart data for completed purchases on your website. If the
        /// ad that was interacted with has an associated product (see Shopping Ads) then this product is considered the
        /// advertised product. Any product included in the order the customer places is a sold product. If the
        /// advertised and sold products match, then the cost of these goods is counted under lead cost of goods sold.
        /// Example: Someone clicked on a Shopping ad for a hat then bought the same hat and a shirt. The hat has a cost
        /// of goods sold value of $3, the shirt has a cost of goods sold value of $5. The lead cost of goods sold for
        /// this order is $3. This metric is only available if you report conversions with cart data. This metric is a
        /// monetary value and returned in the customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadCostOfGoodsSoldMicros")]
        public virtual System.Nullable<long> LeadCostOfGoodsSoldMicros { get; set; }

        /// <summary>
        /// Lead gross profit is the profit you made from products sold as a result of advertising the same product,
        /// minus cost of goods sold (COGS). How it works: You report conversions with cart data for completed purchases
        /// on your website. If the ad that was interacted with before the purchase has an associated product (see
        /// Shopping Ads) then this product is considered the advertised product. Any product included in the order the
        /// customer places is a sold product. If the advertised and sold products match, then the revenue you made from
        /// these sales minus the cost of goods sold is your lead gross profit. Example: Someone clicked on a Shopping
        /// ad for a hat then bought the same hat and a shirt. The hat is priced $10 and has a cost of goods sold value
        /// of $3. The lead gross profit of this order is $7 = $10 - $3. This metric is only available if you report
        /// conversions with cart data. This metric is a monetary value and returned in the customer's currency by
        /// default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadGrossProfitMicros")]
        public virtual System.Nullable<long> LeadGrossProfitMicros { get; set; }

        /// <summary>
        /// Lead revenue is the total amount you made from products sold as a result of advertising the same product.
        /// How it works: You report conversions with cart data for completed purchases on your website. If the ad that
        /// was interacted with before the purchase has an associated product (see Shopping Ads) then this product is
        /// considered the advertised product. Any product included in the order the customer places is a sold product.
        /// If the advertised and sold products match, then the total value you made from the sales of these products is
        /// shown under lead revenue. Example: Someone clicked on a Shopping ad for a hat then bought the same hat and a
        /// shirt. The hat is priced $10 and the shirt is priced $20. The lead revenue of this order is $10. This metric
        /// is only available if you report conversions with cart data. This metric is a monetary value and returned in
        /// the customer's currency by default. See the metrics_currency parameter at
        /// https://developers.google.com/search-ads/reporting/query/query-structure#parameters_clause
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadRevenueMicros")]
        public virtual System.Nullable<long> LeadRevenueMicros { get; set; }

        /// <summary>
        /// Lead units sold is the total number of products sold as a result of advertising the same product. How it
        /// works: You report conversions with cart data for completed purchases on your website. If the ad that was
        /// interacted with before the purchase has an associated product (see Shopping Ads) then this product is
        /// considered the advertised product. Any product included in the order the customer places is a sold product.
        /// If the advertised and sold products match, then the total number of these products sold is shown under lead
        /// units sold. Example: Someone clicked on a Shopping ad for a hat then bought the same hat, a shirt and a
        /// jacket. The lead units sold in this order is 1. This metric is only available if you report conversions with
        /// cart data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadUnitsSold")]
        public virtual System.Nullable<double> LeadUnitsSold { get; set; }

        /// <summary>The percentage of mobile clicks that go to a mobile-friendly page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileFriendlyClicksPercentage")]
        public virtual System.Nullable<double> MobileFriendlyClicksPercentage { get; set; }

        /// <summary>The raw event conversion metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawEventConversionMetrics")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonValue> RawEventConversionMetrics { get; set; }

        /// <summary>
        /// The percentage of the customer's Shopping or Search ad impressions that are shown in the most prominent
        /// Shopping position. See https://support.google.com/sa360/answer/9566729 for details. Any value below 0.1 is
        /// reported as 0.0999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchAbsoluteTopImpressionShare")]
        public virtual System.Nullable<double> SearchAbsoluteTopImpressionShare { get; set; }

        /// <summary>
        /// The number estimating how often your ad wasn't the very first ad among the top ads in the search results due
        /// to a low budget. Note: Search budget lost absolute top impression share is reported in the range of 0 to
        /// 0.9. Any value above 0.9 is reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchBudgetLostAbsoluteTopImpressionShare")]
        public virtual System.Nullable<double> SearchBudgetLostAbsoluteTopImpressionShare { get; set; }

        /// <summary>
        /// The estimated percent of times that your ad was eligible to show on the Search Network but didn't because
        /// your budget was too low. Note: Search budget lost impression share is reported in the range of 0 to 0.9. Any
        /// value above 0.9 is reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchBudgetLostImpressionShare")]
        public virtual System.Nullable<double> SearchBudgetLostImpressionShare { get; set; }

        /// <summary>
        /// The number estimating how often your ad didn't show adjacent to the top organic search results due to a low
        /// budget. Note: Search budget lost top impression share is reported in the range of 0 to 0.9. Any value above
        /// 0.9 is reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchBudgetLostTopImpressionShare")]
        public virtual System.Nullable<double> SearchBudgetLostTopImpressionShare { get; set; }

        /// <summary>
        /// The number of clicks you've received on the Search Network divided by the estimated number of clicks you
        /// were eligible to receive. Note: Search click share is reported in the range of 0.1 to 1. Any value below 0.1
        /// is reported as 0.0999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchClickShare")]
        public virtual System.Nullable<double> SearchClickShare { get; set; }

        /// <summary>
        /// The impressions you've received divided by the estimated number of impressions you were eligible to receive
        /// on the Search Network for search terms that matched your keywords exactly (or were close variants of your
        /// keyword), regardless of your keyword match types. Note: Search exact match impression share is reported in
        /// the range of 0.1 to 1. Any value below 0.1 is reported as 0.0999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchExactMatchImpressionShare")]
        public virtual System.Nullable<double> SearchExactMatchImpressionShare { get; set; }

        /// <summary>
        /// The impressions you've received on the Search Network divided by the estimated number of impressions you
        /// were eligible to receive. Note: Search impression share is reported in the range of 0.1 to 1. Any value
        /// below 0.1 is reported as 0.0999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchImpressionShare")]
        public virtual System.Nullable<double> SearchImpressionShare { get; set; }

        /// <summary>
        /// The number estimating how often your ad wasn't the very first ad among the top ads in the search results due
        /// to poor Ad Rank. Note: Search rank lost absolute top impression share is reported in the range of 0 to 0.9.
        /// Any value above 0.9 is reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchRankLostAbsoluteTopImpressionShare")]
        public virtual System.Nullable<double> SearchRankLostAbsoluteTopImpressionShare { get; set; }

        /// <summary>
        /// The estimated percentage of impressions on the Search Network that your ads didn't receive due to poor Ad
        /// Rank. Note: Search rank lost impression share is reported in the range of 0 to 0.9. Any value above 0.9 is
        /// reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchRankLostImpressionShare")]
        public virtual System.Nullable<double> SearchRankLostImpressionShare { get; set; }

        /// <summary>
        /// The number estimating how often your ad didn't show adjacent to the top organic search results due to poor
        /// Ad Rank. Note: Search rank lost top impression share is reported in the range of 0 to 0.9. Any value above
        /// 0.9 is reported as 0.9001.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchRankLostTopImpressionShare")]
        public virtual System.Nullable<double> SearchRankLostTopImpressionShare { get; set; }

        /// <summary>
        /// The impressions you've received among the top ads compared to the estimated number of impressions you were
        /// eligible to receive among the top ads. Note: Search top impression share is reported in the range of 0.1 to
        /// 1. Any value below 0.1 is reported as 0.0999. Top ads are generally above the top organic results, although
        /// they may show below the top organic results on certain queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchTopImpressionShare")]
        public virtual System.Nullable<double> SearchTopImpressionShare { get; set; }

        /// <summary>
        /// The percent of your ad impressions that are shown adjacent to the top organic search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topImpressionPercentage")]
        public virtual System.Nullable<double> TopImpressionPercentage { get; set; }

        /// <summary>The value of all conversions divided by the number of all conversions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuePerAllConversions")]
        public virtual System.Nullable<double> ValuePerAllConversions { get; set; }

        /// <summary>
        /// The value of all conversions divided by the number of all conversions. When this column is selected with
        /// date, the values in date column means the conversion date. Details for the by_conversion_date columns are
        /// available at https://support.google.com/sa360/answer/9250611.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuePerAllConversionsByConversionDate")]
        public virtual System.Nullable<double> ValuePerAllConversionsByConversionDate { get; set; }

        /// <summary>
        /// The value of biddable conversion divided by the number of biddable conversions. Shows how much, on average,
        /// each of the biddable conversions is worth.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuePerConversion")]
        public virtual System.Nullable<double> ValuePerConversion { get; set; }

        /// <summary>
        /// Biddable conversions value by conversion date divided by biddable conversions by conversion date. Shows how
        /// much, on average, each of the biddable conversions is worth (by conversion date). When this column is
        /// selected with date, the values in date column means the conversion date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuePerConversionsByConversionDate")]
        public virtual System.Nullable<double> ValuePerConversionsByConversionDate { get; set; }

        /// <summary>
        /// Clicks that Search Ads 360 has successfully recorded and forwarded to an advertiser's landing page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visits")]
        public virtual System.Nullable<double> Visits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An asset representing a mobile app.</summary>
    public class GoogleAdsSearchads360V0CommonMobileAppAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A string that uniquely identifies a mobile application. It should just contain the platform native
        /// id, like "com.android.ebay" for Android or "12345689" for iOS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Required. The application store that distributes this specific app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStore")]
        public virtual string AppStore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bidding strategy where bids are a fraction of the advertised price for some good or service.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonPercentCpc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum bid limit that can be set by the bid strategy. This is an optional field entered by the advertiser
        /// and specified in local micros. Note: A zero value is interpreted in the same way as having bid_ceiling
        /// undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>
        /// Adjusts the bid for each auction upward or downward, depending on the likelihood of a conversion. Individual
        /// bids may exceed cpc_bid_ceiling_micros, but the average bid amount for a campaign should not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enhancedCpcEnabled")]
        public virtual System.Nullable<bool> EnhancedCpcEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings for Real-Time Bidding, a feature only available for campaigns targeting the Ad Exchange network.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonRealTimeBiddingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the campaign is opted in to real-time bidding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optIn")]
        public virtual System.Nullable<bool> OptIn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An expanded dynamic search ad.</summary>
    public class GoogleAdsSearchads360V0CommonSearchAds360ExpandedDynamicSearchAdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The tracking id of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTrackingId")]
        public virtual System.Nullable<long> AdTrackingId { get; set; }

        /// <summary>The first line of the ad's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description1")]
        public virtual string Description1 { get; set; }

        /// <summary>The second line of the ad's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description2")]
        public virtual string Description2 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Search Ads 360 expanded text ad.</summary>
    public class GoogleAdsSearchads360V0CommonSearchAds360ExpandedTextAdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The tracking id of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTrackingId")]
        public virtual System.Nullable<long> AdTrackingId { get; set; }

        /// <summary>The first line of the ad's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description1")]
        public virtual string Description1 { get; set; }

        /// <summary>The second line of the ad's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description2")]
        public virtual string Description2 { get; set; }

        /// <summary>The headline of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headline")]
        public virtual string Headline { get; set; }

        /// <summary>The second headline of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headline2")]
        public virtual string Headline2 { get; set; }

        /// <summary>The third headline of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headline3")]
        public virtual string Headline3 { get; set; }

        /// <summary>Text appended to the auto-generated visible URL with a delimiter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path1")]
        public virtual string Path1 { get; set; }

        /// <summary>Text appended to path1 with a delimiter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path2")]
        public virtual string Path2 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Search Ads 360 product ad.</summary>
    public class GoogleAdsSearchads360V0CommonSearchAds360ProductAdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Search Ads 360 responsive search ad.</summary>
    public class GoogleAdsSearchads360V0CommonSearchAds360ResponsiveSearchAdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The tracking id of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTrackingId")]
        public virtual System.Nullable<long> AdTrackingId { get; set; }

        /// <summary>
        /// List of text assets for descriptions. When the ad serves the descriptions will be selected from this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptions")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonAdTextAsset> Descriptions { get; set; }

        /// <summary>
        /// List of text assets for headlines. When the ad serves the headlines will be selected from this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headlines")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonAdTextAsset> Headlines { get; set; }

        /// <summary>Text appended to the auto-generated visible URL with a delimiter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path1")]
        public virtual string Path1 { get; set; }

        /// <summary>Text appended to path1 with a delimiter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path2")]
        public virtual string Path2 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Search Ads 360 text ad.</summary>
    public class GoogleAdsSearchads360V0CommonSearchAds360TextAdInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The tracking id of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adTrackingId")]
        public virtual System.Nullable<long> AdTrackingId { get; set; }

        /// <summary>The first line of the ad's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description1")]
        public virtual string Description1 { get; set; }

        /// <summary>The second line of the ad's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description2")]
        public virtual string Description2 { get; set; }

        /// <summary>The displayed mobile URL of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayMobileUrl")]
        public virtual string DisplayMobileUrl { get; set; }

        /// <summary>The displayed URL of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayUrl")]
        public virtual string DisplayUrl { get; set; }

        /// <summary>The headline of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headline")]
        public virtual string Headline { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Segment only fields.</summary>
    public class GoogleAdsSearchads360V0CommonSegments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ad network type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adNetworkType")]
        public virtual string AdNetworkType { get; set; }

        /// <summary>
        /// Only used with CustomerAsset, CampaignAsset and AdGroupAsset metrics. Indicates whether the interaction
        /// metrics occurred on the asset itself or a different asset or ad unit. Interactions (for example, clicks) are
        /// counted across all the parts of the served ad (for example, Ad itself and other components like Sitelinks)
        /// when they are served together. When interaction_on_this_asset is true, it means the interactions are on this
        /// specific asset and when interaction_on_this_asset is false, it means the interactions is not on this
        /// specific asset but on other parts of the served ad this asset is served with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetInteractionTarget")]
        public virtual GoogleAdsSearchads360V0CommonAssetInteractionTarget AssetInteractionTarget { get; set; }

        /// <summary>Resource name of the conversion action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionAction")]
        public virtual string ConversionAction { get; set; }

        /// <summary>Conversion action category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionActionCategory")]
        public virtual string ConversionActionCategory { get; set; }

        /// <summary>Conversion action name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionActionName")]
        public virtual string ConversionActionName { get; set; }

        /// <summary>The conversion custom dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionCustomDimensions")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonValue> ConversionCustomDimensions { get; set; }

        /// <summary>Date to which metrics apply. yyyy-MM-dd format, for example, 2018-04-17.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string Date { get; set; }

        /// <summary>Day of the week, for example, MONDAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>Device to which metrics apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual string Device { get; set; }

        /// <summary>Resource name of the geo target constant that represents a city.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetCity")]
        public virtual string GeoTargetCity { get; set; }

        /// <summary>Resource name of the geo target constant that represents a country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetCountry")]
        public virtual string GeoTargetCountry { get; set; }

        /// <summary>Resource name of the geo target constant that represents a metro.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetMetro")]
        public virtual string GeoTargetMetro { get; set; }

        /// <summary>Resource name of the geo target constant that represents a region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetRegion")]
        public virtual string GeoTargetRegion { get; set; }

        /// <summary>Hour of day as a number between 0 and 23, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>Keyword criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyword")]
        public virtual GoogleAdsSearchads360V0CommonKeyword Keyword { get; set; }

        /// <summary>Month as represented by the date of the first day of a month. Formatted as yyyy-MM-dd.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual string Month { get; set; }

        /// <summary>Bidding category (level 1) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategoryLevel1")]
        public virtual string ProductBiddingCategoryLevel1 { get; set; }

        /// <summary>Bidding category (level 2) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategoryLevel2")]
        public virtual string ProductBiddingCategoryLevel2 { get; set; }

        /// <summary>Bidding category (level 3) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategoryLevel3")]
        public virtual string ProductBiddingCategoryLevel3 { get; set; }

        /// <summary>Bidding category (level 4) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategoryLevel4")]
        public virtual string ProductBiddingCategoryLevel4 { get; set; }

        /// <summary>Bidding category (level 5) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategoryLevel5")]
        public virtual string ProductBiddingCategoryLevel5 { get; set; }

        /// <summary>Brand of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBrand")]
        public virtual string ProductBrand { get; set; }

        /// <summary>Channel of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productChannel")]
        public virtual string ProductChannel { get; set; }

        /// <summary>Channel exclusivity of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productChannelExclusivity")]
        public virtual string ProductChannelExclusivity { get; set; }

        /// <summary>Condition of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCondition")]
        public virtual string ProductCondition { get; set; }

        /// <summary>Resource name of the geo target constant for the country of sale of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCountry")]
        public virtual string ProductCountry { get; set; }

        /// <summary>Custom attribute 0 of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCustomAttribute0")]
        public virtual string ProductCustomAttribute0 { get; set; }

        /// <summary>Custom attribute 1 of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCustomAttribute1")]
        public virtual string ProductCustomAttribute1 { get; set; }

        /// <summary>Custom attribute 2 of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCustomAttribute2")]
        public virtual string ProductCustomAttribute2 { get; set; }

        /// <summary>Custom attribute 3 of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCustomAttribute3")]
        public virtual string ProductCustomAttribute3 { get; set; }

        /// <summary>Custom attribute 4 of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCustomAttribute4")]
        public virtual string ProductCustomAttribute4 { get; set; }

        /// <summary>Item ID of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productItemId")]
        public virtual string ProductItemId { get; set; }

        /// <summary>Resource name of the language constant for the language of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLanguage")]
        public virtual string ProductLanguage { get; set; }

        /// <summary>Bidding category (level 1) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldBiddingCategoryLevel1")]
        public virtual string ProductSoldBiddingCategoryLevel1 { get; set; }

        /// <summary>Bidding category (level 2) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldBiddingCategoryLevel2")]
        public virtual string ProductSoldBiddingCategoryLevel2 { get; set; }

        /// <summary>Bidding category (level 3) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldBiddingCategoryLevel3")]
        public virtual string ProductSoldBiddingCategoryLevel3 { get; set; }

        /// <summary>Bidding category (level 4) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldBiddingCategoryLevel4")]
        public virtual string ProductSoldBiddingCategoryLevel4 { get; set; }

        /// <summary>Bidding category (level 5) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldBiddingCategoryLevel5")]
        public virtual string ProductSoldBiddingCategoryLevel5 { get; set; }

        /// <summary>Brand of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldBrand")]
        public virtual string ProductSoldBrand { get; set; }

        /// <summary>Condition of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldCondition")]
        public virtual string ProductSoldCondition { get; set; }

        /// <summary>Custom attribute 0 of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldCustomAttribute0")]
        public virtual string ProductSoldCustomAttribute0 { get; set; }

        /// <summary>Custom attribute 1 of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldCustomAttribute1")]
        public virtual string ProductSoldCustomAttribute1 { get; set; }

        /// <summary>Custom attribute 2 of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldCustomAttribute2")]
        public virtual string ProductSoldCustomAttribute2 { get; set; }

        /// <summary>Custom attribute 3 of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldCustomAttribute3")]
        public virtual string ProductSoldCustomAttribute3 { get; set; }

        /// <summary>Custom attribute 4 of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldCustomAttribute4")]
        public virtual string ProductSoldCustomAttribute4 { get; set; }

        /// <summary>Item ID of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldItemId")]
        public virtual string ProductSoldItemId { get; set; }

        /// <summary>Title of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldTitle")]
        public virtual string ProductSoldTitle { get; set; }

        /// <summary>Type (level 1) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldTypeL1")]
        public virtual string ProductSoldTypeL1 { get; set; }

        /// <summary>Type (level 2) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldTypeL2")]
        public virtual string ProductSoldTypeL2 { get; set; }

        /// <summary>Type (level 3) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldTypeL3")]
        public virtual string ProductSoldTypeL3 { get; set; }

        /// <summary>Type (level 4) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldTypeL4")]
        public virtual string ProductSoldTypeL4 { get; set; }

        /// <summary>Type (level 5) of the product sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSoldTypeL5")]
        public virtual string ProductSoldTypeL5 { get; set; }

        /// <summary>Store ID of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productStoreId")]
        public virtual string ProductStoreId { get; set; }

        /// <summary>Title of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTitle")]
        public virtual string ProductTitle { get; set; }

        /// <summary>Type (level 1) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL1")]
        public virtual string ProductTypeL1 { get; set; }

        /// <summary>Type (level 2) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL2")]
        public virtual string ProductTypeL2 { get; set; }

        /// <summary>Type (level 3) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL3")]
        public virtual string ProductTypeL3 { get; set; }

        /// <summary>Type (level 4) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL4")]
        public virtual string ProductTypeL4 { get; set; }

        /// <summary>Type (level 5) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL5")]
        public virtual string ProductTypeL5 { get; set; }

        /// <summary>
        /// Quarter as represented by the date of the first day of a quarter. Uses the calendar year for quarters, for
        /// example, the second quarter of 2018 starts on 2018-04-01. Formatted as yyyy-MM-dd.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quarter")]
        public virtual string Quarter { get; set; }

        /// <summary>The raw event conversion dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawEventConversionDimensions")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonValue> RawEventConversionDimensions { get; set; }

        /// <summary>
        /// Week as defined as Monday through Sunday, and represented by the date of Monday. Formatted as yyyy-MM-dd.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("week")]
        public virtual string Week { get; set; }

        /// <summary>Year, formatted as yyyy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bid strategy that sets bids to help get as many conversions as possible at the target
    /// cost-per-acquisition (CPA) you set.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonTargetCpa : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. This should only be set for portfolio bid strategies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>
        /// Minimum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. This should only be set for portfolio bid strategies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidFloorMicros")]
        public virtual System.Nullable<long> CpcBidFloorMicros { get; set; }

        /// <summary>
        /// Average CPA target. This target should be greater than or equal to minimum billable unit based on the
        /// currency for the account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpaMicros")]
        public virtual System.Nullable<long> TargetCpaMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Target CPM (cost per thousand impressions) is an automated bidding strategy that sets bids to optimize
    /// performance given the target CPM you set.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonTargetCpm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy that sets bids so that a certain percentage of search ads are shown at the top of
    /// the first page (or other targeted location).
    /// </summary>
    public class GoogleAdsSearchads360V0CommonTargetImpressionShare : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The highest CPC bid the automated bidding system is permitted to specify. This is a required field entered
        /// by the advertiser that sets the ceiling and specified in local micros.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>The targeted location on the search results page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The chosen fraction of ads to be shown in the targeted location in micros. For example, 1% equals 10,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationFractionMicros")]
        public virtual System.Nullable<long> LocationFractionMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy that sets bids based on the target fraction of auctions where the advertiser
    /// should outrank a specific competitor. This strategy is deprecated.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonTargetOutrankShare : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The list of per-targeting-dimension targeting settings.</summary>
    public class GoogleAdsSearchads360V0CommonTargetRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether to restrict your ads to show only for the criteria you have selected for this
        /// targeting_dimension, or to target all values for this targeting_dimension and show ads based on your
        /// targeting in other TargetingDimensions. A value of `true` means that these criteria will only apply bid
        /// modifiers, and not affect targeting. A value of `false` means that these criteria will restrict targeting as
        /// well as applying bid modifiers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidOnly")]
        public virtual System.Nullable<bool> BidOnly { get; set; }

        /// <summary>The targeting dimension that these settings apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingDimension")]
        public virtual string TargetingDimension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy that helps you maximize revenue while averaging a specific target return on ad
    /// spend (ROAS).
    /// </summary>
    public class GoogleAdsSearchads360V0CommonTargetRoas : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. This should only be set for portfolio bid strategies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>
        /// Minimum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy. This should only be set for portfolio bid strategies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidFloorMicros")]
        public virtual System.Nullable<long> CpcBidFloorMicros { get; set; }

        /// <summary>
        /// Required. The chosen revenue (based on conversion data) per unit of spend. Value must be between 0.01 and
        /// 1000.0, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRoas")]
        public virtual System.Nullable<double> TargetRoas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bid strategy that sets your bids to help get as many clicks as possible within your budget.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonTargetSpend : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum bid limit that can be set by the bid strategy. The limit applies to all keywords managed by the
        /// strategy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>
        /// Deprecated: The spend target under which to maximize clicks. A TargetSpend bidder will attempt to spend the
        /// smaller of this value or the natural throttling spend amount. If not specified, the budget is used as the
        /// spend target. This field is deprecated and should no longer be used. See
        /// https://ads-developers.googleblog.com/2020/05/reminder-about-sunset-creation-of.html for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSpendMicros")]
        public virtual System.Nullable<long> TargetSpendMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings for the targeting-related features, at the campaign and ad group levels. For more details about the
    /// targeting setting, visit https://support.google.com/google-ads/answer/7365594
    /// </summary>
    public class GoogleAdsSearchads360V0CommonTargetingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The per-targeting-dimension setting to restrict the reach of your campaign or ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRestrictions")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonTargetRestriction> TargetRestrictions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Text asset.</summary>
    public class GoogleAdsSearchads360V0CommonTextAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text content of the text asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A type of label displaying text on a colored background.</summary>
    public class GoogleAdsSearchads360V0CommonTextLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Background color of the label in HEX format. This string must match the regular expression
        /// '^\#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$'. Note: The background color may not be visible for manager accounts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual string BackgroundColor { get; set; }

        /// <summary>A short description of the label. The length must be no more than 200 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unified call asset.</summary>
    public class GoogleAdsSearchads360V0CommonUnifiedCallAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of non-overlapping schedules specifying all time intervals for which the asset may serve. There can be
        /// a maximum of 6 schedules per day, 42 in total.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adScheduleTargets")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonAdScheduleInfo> AdScheduleTargets { get; set; }

        /// <summary>
        /// The conversion action to attribute a call conversion to. If not set, the default conversion action is used.
        /// This field only has effect if call_conversion_reporting_state is set to
        /// USE_RESOURCE_LEVEL_CALL_CONVERSION_ACTION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callConversionAction")]
        public virtual string CallConversionAction { get; set; }

        /// <summary>
        /// Output only. Indicates whether this CallAsset should use its own call conversion setting, follow the account
        /// level setting, or disable call conversion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callConversionReportingState")]
        public virtual string CallConversionReportingState { get; set; }

        /// <summary>
        /// Whether the call only shows the phone number without a link to the website. Applies to Microsoft Ads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callOnly")]
        public virtual System.Nullable<bool> CallOnly { get; set; }

        /// <summary>Whether the call should be enabled on call tracking. Applies to Microsoft Ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callTrackingEnabled")]
        public virtual System.Nullable<bool> CallTrackingEnabled { get; set; }

        /// <summary>Two-letter country code of the phone number. Examples: 'US', 'us'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>Last date of when this asset is effective and still serving, in yyyy-MM-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>The advertiser's raw phone number. Examples: '1234567890', '(123)456-7890'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>Start date of when this asset is effective and can begin serving, in yyyy-MM-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>Whether to show the call extension in search user's time zone. Applies to Microsoft Ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSearcherTimeZone")]
        public virtual System.Nullable<bool> UseSearcherTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unified callout asset.</summary>
    public class GoogleAdsSearchads360V0CommonUnifiedCalloutAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of non-overlapping schedules specifying all time intervals for which the asset may serve. There can be
        /// a maximum of 6 schedules per day, 42 in total.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adScheduleTargets")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonAdScheduleInfo> AdScheduleTargets { get; set; }

        /// <summary>The callout text. The length of this string should be between 1 and 25, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calloutText")]
        public virtual string CalloutText { get; set; }

        /// <summary>Last date of when this asset is effective and still serving, in yyyy-MM-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>Start date of when this asset is effective and can begin serving, in yyyy-MM-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>Whether to show the asset in search user's time zone. Applies to Microsoft Ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSearcherTimeZone")]
        public virtual System.Nullable<bool> UseSearcherTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unified location asset.</summary>
    public class GoogleAdsSearchads360V0CommonUnifiedLocationAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of business locations for the customer. This will only be returned if the Location Asset is syncing
        /// from the Business Profile account. It is possible to have multiple Business Profile listings under the same
        /// account that point to the same Place ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessProfileLocations")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonBusinessProfileLocation> BusinessProfileLocations { get; set; }

        /// <summary>
        /// The type of location ownership. If the type is BUSINESS_OWNER, it will be served as a location extension. If
        /// the type is AFFILIATE, it will be served as an affiliate location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationOwnershipType")]
        public virtual string LocationOwnershipType { get; set; }

        /// <summary>
        /// Place IDs uniquely identify a place in the Google Places database and on Google Maps. This field is unique
        /// for a given customer ID and asset type. See https://developers.google.com/places/web-service/place-id to
        /// learn more about Place ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Unified Page Feed asset.</summary>
    public class GoogleAdsSearchads360V0CommonUnifiedPageFeedAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Labels used to group the page urls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>The webpage that advertisers want to target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageUrl")]
        public virtual string PageUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unified sitelink asset.</summary>
    public class GoogleAdsSearchads360V0CommonUnifiedSitelinkAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of non-overlapping schedules specifying all time intervals for which the asset may serve. There can be
        /// a maximum of 6 schedules per day, 42 in total.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adScheduleTargets")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonAdScheduleInfo> AdScheduleTargets { get; set; }

        /// <summary>
        /// First line of the description for the sitelink. If set, the length should be between 1 and 35, inclusive,
        /// and description2 must also be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description1")]
        public virtual string Description1 { get; set; }

        /// <summary>
        /// Second line of the description for the sitelink. If set, the length should be between 1 and 35, inclusive,
        /// and description1 must also be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description2")]
        public virtual string Description2 { get; set; }

        /// <summary>Last date of when this asset is effective and still serving, in yyyy-MM-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// URL display text for the sitelink. The length of this string should be between 1 and 25, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkText")]
        public virtual string LinkText { get; set; }

        /// <summary>
        /// Whether the preference is for the sitelink asset to be displayed on mobile devices. Applies to Microsoft
        /// Ads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilePreferred")]
        public virtual System.Nullable<bool> MobilePreferred { get; set; }

        /// <summary>Start date of when this asset is effective and can begin serving, in yyyy-MM-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>ID used for tracking clicks for the sitelink asset. This is a Yahoo! Japan only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingId")]
        public virtual System.Nullable<long> TrackingId { get; set; }

        /// <summary>Whether to show the sitelink asset in search user's time zone. Applies to Microsoft Ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSearcherTimeZone")]
        public virtual System.Nullable<bool> UseSearcherTimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A User List criterion. Represents a user list that is defined by the advertiser to be targeted.
    /// </summary>
    public class GoogleAdsSearchads360V0CommonUserListInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The User List resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userList")]
        public virtual string UserList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic data container.</summary>
    public class GoogleAdsSearchads360V0CommonValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>A double.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>A float.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>An int64.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>A string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Logical expression for targeting webpages of an advertiser's website.</summary>
    public class GoogleAdsSearchads360V0CommonWebpageConditionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Argument of webpage targeting condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argument")]
        public virtual string Argument { get; set; }

        /// <summary>Operand of webpage targeting condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operand")]
        public virtual string Operand { get; set; }

        /// <summary>Operator of webpage targeting condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a criterion for targeting webpages of an advertiser's website.</summary>
    public class GoogleAdsSearchads360V0CommonWebpageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Conditions, or logical expressions, for webpage targeting. The list of webpage targeting conditions are
        /// and-ed together when evaluated for targeting. An empty list of conditions indicates all pages of the
        /// campaign's website are targeted. This field is required for CREATE operations and is prohibited on UPDATE
        /// operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonWebpageConditionInfo> Conditions { get; set; }

        /// <summary>
        /// Website criteria coverage percentage. This is the computed percentage of website coverage based on the
        /// website target, negative website target and negative keywords in the ad group and campaign. For instance,
        /// when coverage returns as 1, it indicates it has 100% coverage. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coveragePercentage")]
        public virtual System.Nullable<double> CoveragePercentage { get; set; }

        /// <summary>
        /// The name of the criterion that is defined by this parameter. The name value will be used for identifying,
        /// sorting and filtering criteria with this type of parameters. This field is required for CREATE operations
        /// and is prohibited on UPDATE operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criterionName")]
        public virtual string CriterionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A YouTube asset.</summary>
    public class GoogleAdsSearchads360V0CommonYoutubeVideoAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>YouTube video id. This is the 11 character string value used in the YouTube video URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeVideoId")]
        public virtual string YoutubeVideoId { get; set; }

        /// <summary>YouTube video title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeVideoTitle")]
        public virtual string YoutubeVideoTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The error reason represented by type and enum.</summary>
    public class GoogleAdsSearchads360V0ErrorsErrorCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates failure to properly authenticate user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationError")]
        public virtual string AuthenticationError { get; set; }

        /// <summary>An error encountered when trying to authorize a user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationError")]
        public virtual string AuthorizationError { get; set; }

        /// <summary>The reasons for the custom column error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customColumnError")]
        public virtual string CustomColumnError { get; set; }

        /// <summary>The reasons for the date error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateError")]
        public virtual string DateError { get; set; }

        /// <summary>The reasons for the date range error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRangeError")]
        public virtual string DateRangeError { get; set; }

        /// <summary>The reasons for the distinct error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctError")]
        public virtual string DistinctError { get; set; }

        /// <summary>The reasons for the header error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerError")]
        public virtual string HeaderError { get; set; }

        /// <summary>An unexpected server-side error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalError")]
        public virtual string InternalError { get; set; }

        /// <summary>The reasons for invalid parameter errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidParameterError")]
        public virtual string InvalidParameterError { get; set; }

        /// <summary>An error with the query</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryError")]
        public virtual string QueryError { get; set; }

        /// <summary>An error with the amount of quota remaining.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaError")]
        public virtual string QuotaError { get; set; }

        /// <summary>An error caused by the request</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestError")]
        public virtual string RequestError { get; set; }

        /// <summary>The reasons for the size limit error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeLimitError")]
        public virtual string SizeLimitError { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional error details.</summary>
    public class GoogleAdsSearchads360V0ErrorsErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Details on the quota error, including the scope (account or developer), the rate bucket name and the retry
        /// delay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaErrorDetails")]
        public virtual GoogleAdsSearchads360V0ErrorsQuotaErrorDetails QuotaErrorDetails { get; set; }

        /// <summary>
        /// The error code that should have been returned, but wasn't. This is used when the error code is not published
        /// in the client specified version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unpublishedErrorCode")]
        public virtual string UnpublishedErrorCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the part of the request proto that caused the error.</summary>
    public class GoogleAdsSearchads360V0ErrorsErrorLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A field path that indicates which field was invalid in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPathElements")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ErrorsErrorLocationFieldPathElement> FieldPathElements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A part of a field path.</summary>
    public class GoogleAdsSearchads360V0ErrorsErrorLocationFieldPathElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of a field or a oneof</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>If field_name is a repeated field, this is the element that failed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional quota error details when there is QuotaError.</summary>
    public class GoogleAdsSearchads360V0ErrorsQuotaErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The high level description of the quota bucket. Examples are "Get requests for standard access" or "Requests
        /// per account".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateName")]
        public virtual string RateName { get; set; }

        /// <summary>The rate scope of the quota limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateScope")]
        public virtual string RateScope { get; set; }

        /// <summary>Backoff period that customers should wait before sending next request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryDelay")]
        public virtual object RetryDelay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search Ads 360-specific error.</summary>
    public class GoogleAdsSearchads360V0ErrorsSearchAds360Error : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional error details, which are returned by certain error codes. Most error codes do not include
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual GoogleAdsSearchads360V0ErrorsErrorDetails Details { get; set; }

        /// <summary>An enum value that indicates which error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual GoogleAdsSearchads360V0ErrorsErrorCode ErrorCode { get; set; }

        /// <summary>Describes the part of the request proto that caused the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GoogleAdsSearchads360V0ErrorsErrorLocation Location { get; set; }

        /// <summary>A human-readable description of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The value that triggered the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual GoogleAdsSearchads360V0CommonValue Trigger { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes how a Search Ads 360 API call failed. It's returned inside google.rpc.Status.details when a call
    /// fails.
    /// </summary>
    public class GoogleAdsSearchads360V0ErrorsSearchAds360Failure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of errors that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ErrorsSearchAds360Error> Errors { get; set; }

        /// <summary>The unique ID of the request that is used for debugging purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a view of BiddingStrategies owned by and shared with the customer. In contrast to BiddingStrategy,
    /// this resource includes strategies owned by managers of the customer and shared with this customer - in addition
    /// to strategies owned by this customer. This resource does not provide metrics and only exposes a limited subset
    /// of the BiddingStrategy attributes.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of the bidding strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Output only. An automated bidding strategy to help get the most conversion value for your campaigns while
        /// spending your budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximizeConversionValue")]
        public virtual GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyMaximizeConversionValue MaximizeConversionValue { get; set; }

        /// <summary>
        /// Output only. An automated bidding strategy to help get the most conversions for your campaigns while
        /// spending your budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximizeConversions")]
        public virtual GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyMaximizeConversions MaximizeConversions { get; set; }

        /// <summary>Output only. The name of the bidding strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the bidding strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>Output only. descriptive_name of the Customer which owns the bidding strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDescriptiveName")]
        public virtual string OwnerDescriptiveName { get; set; }

        /// <summary>
        /// Output only. The resource name of the accessible bidding strategy. AccessibleBiddingStrategy resource names
        /// have the form: `customers/{customer_id}/accessibleBiddingStrategies/{bidding_strategy_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. A bidding strategy that sets bids to help get as many conversions as possible at the target
        /// cost-per-acquisition (CPA) you set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpa")]
        public virtual GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetCpa TargetCpa { get; set; }

        /// <summary>
        /// Output only. A bidding strategy that automatically optimizes towards a chosen percentage of impressions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetImpressionShare")]
        public virtual GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetImpressionShare TargetImpressionShare { get; set; }

        /// <summary>
        /// Output only. A bidding strategy that helps you maximize revenue while averaging a specific target Return On
        /// Ad Spend (ROAS).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRoas")]
        public virtual GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetRoas TargetRoas { get; set; }

        /// <summary>
        /// Output only. A bid strategy that sets your bids to help get as many clicks as possible within your budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSpend")]
        public virtual GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetSpend TargetSpend { get; set; }

        /// <summary>Output only. The type of the bidding strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy to help get the most conversion value for your campaigns while spending your
    /// budget.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyMaximizeConversionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The target return on ad spend (ROAS) option. If set, the bid strategy will maximize revenue
        /// while averaging the target return on ad spend. If the target ROAS is high, the bid strategy may not be able
        /// to spend the full budget. If the target ROAS is not set, the bid strategy will aim to achieve the highest
        /// possible ROAS for the budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRoas")]
        public virtual System.Nullable<double> TargetRoas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy to help get the most conversions for your campaigns while spending your budget.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyMaximizeConversions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The target cost per acquisition (CPA) option. This is the average amount that you would like to
        /// spend per acquisition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpa")]
        public virtual System.Nullable<long> TargetCpa { get; set; }

        /// <summary>
        /// Output only. The target cost per acquisition (CPA) option. This is the average amount that you would like to
        /// spend per acquisition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpaMicros")]
        public virtual System.Nullable<long> TargetCpaMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bid strategy that sets bids to help get as many conversions as possible at the target
    /// cost-per-acquisition (CPA) you set.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetCpa : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Average CPA target. This target should be greater than or equal to minimum billable unit based
        /// on the currency for the account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpaMicros")]
        public virtual System.Nullable<long> TargetCpaMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy that sets bids so that a certain percentage of search ads are shown at the top of
    /// the first page (or other targeted location).
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetImpressionShare : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The highest CPC bid the automated bidding system is permitted to specify. This is a required
        /// field entered by the advertiser that sets the ceiling and specified in local micros.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>Output only. The targeted location on the search results page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The chosen fraction of ads to be shown in the targeted location in micros. For example, 1% equals 10,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationFractionMicros")]
        public virtual System.Nullable<long> LocationFractionMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bidding strategy that helps you maximize revenue while averaging a specific target return on ad
    /// spend (ROAS).
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetRoas : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The chosen revenue (based on conversion data) per unit of spend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRoas")]
        public virtual System.Nullable<double> TargetRoas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An automated bid strategy that sets your bids to help get as many clicks as possible within your budget.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategyTargetSpend : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Maximum bid limit that can be set by the bid strategy. The limit applies to all keywords
        /// managed by the strategy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidCeilingMicros")]
        public virtual System.Nullable<long> CpcBidCeilingMicros { get; set; }

        /// <summary>
        /// Output only. The spend target under which to maximize clicks. A TargetSpend bidder will attempt to spend the
        /// smaller of this value or the natural throttling spend amount. If not specified, the budget is used as the
        /// spend target. This field is deprecated and should no longer be used. See
        /// https://ads-developers.googleblog.com/2020/05/reminder-about-sunset-creation-of.html for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSpendMicros")]
        public virtual System.Nullable<long> TargetSpendMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An ad.</summary>
    public class GoogleAdsSearchads360V0ResourcesAd : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL that appears in the ad description for some ad formats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayUrl")]
        public virtual string DisplayUrl { get; set; }

        /// <summary>Immutable. Details pertaining to an expanded dynamic search ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedDynamicSearchAd")]
        public virtual GoogleAdsSearchads360V0CommonSearchAds360ExpandedDynamicSearchAdInfo ExpandedDynamicSearchAd { get; set; }

        /// <summary>Immutable. Details pertaining to an expanded text ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedTextAd")]
        public virtual GoogleAdsSearchads360V0CommonSearchAds360ExpandedTextAdInfo ExpandedTextAd { get; set; }

        /// <summary>The list of possible final URLs after all cross-domain redirects for the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrls")]
        public virtual System.Collections.Generic.IList<string> FinalUrls { get; set; }

        /// <summary>Output only. The ID of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Immutable. The name of the ad. This is only used to be able to identify the ad. It does not need to be
        /// unique and does not affect the served ad. The name field is currently only supported for DisplayUploadAd,
        /// ImageAd, ShoppingComparisonListingAd and VideoAd.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Immutable. Details pertaining to a product ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productAd")]
        public virtual GoogleAdsSearchads360V0CommonSearchAds360ProductAdInfo ProductAd { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad. Ad resource names have the form:
        /// `customers/{customer_id}/ads/{ad_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Immutable. Details pertaining to a responsive search ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsiveSearchAd")]
        public virtual GoogleAdsSearchads360V0CommonSearchAds360ResponsiveSearchAdInfo ResponsiveSearchAd { get; set; }

        /// <summary>Immutable. Details pertaining to a text ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAd")]
        public virtual GoogleAdsSearchads360V0CommonSearchAds360TextAdInfo TextAd { get; set; }

        /// <summary>Output only. The type of ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An ad group.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad rotation mode of the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adRotationMode")]
        public virtual string AdRotationMode { get; set; }

        /// <summary>The maximum CPC (cost-per-click) bid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidMicros")]
        public virtual System.Nullable<long> CpcBidMicros { get; set; }

        /// <summary>
        /// Output only. The timestamp when this ad_group was created. The timestamp is in the customer's time zone and
        /// in "yyyy-MM-dd HH:mm:ss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>
        /// Output only. The resource names of effective labels attached to this ad group. An effective label is a label
        /// inherited or directly assigned to this ad group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveLabels")]
        public virtual System.Collections.Generic.IList<string> EffectiveLabels { get; set; }

        /// <summary>
        /// Output only. Date when the ad group ends serving ads. By default, the ad group ends on the ad group's end
        /// date. If this field is set, then the ad group ends at the end of the specified date in the customer's time
        /// zone. This field is only available for Microsoft Advertising and Facebook gateway accounts. Format:
        /// YYYY-MM-DD Example: 2019-03-14
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// Output only. ID of the ad group in the external engine account. This field is for non-Google Ads account
        /// only, for example, Yahoo Japan, Microsoft, Baidu etc. For Google Ads entity, use "ad_group.id" instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineId")]
        public virtual string EngineId { get; set; }

        /// <summary>Output only. The Engine Status for ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineStatus")]
        public virtual string EngineStatus { get; set; }

        /// <summary>Output only. The ID of the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Output only. The resource names of labels attached to this ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Output only. The language of the ads and keywords in an ad group. This field is only available for Microsoft
        /// Advertising accounts. More details:
        /// https://docs.microsoft.com/en-us/advertising/guides/ad-languages?view=bingads-13#adlanguage
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Output only. The datetime when this ad group was last modified. The datetime is in the customer's time zone
        /// and in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTime { get; set; }

        /// <summary>
        /// The name of the ad group. This field is required and should not be empty when creating new ad groups. It
        /// must contain fewer than 255 UTF-8 full-width characters. It must not contain any null (code point 0x0), NL
        /// line feed (code point 0xA) or carriage return (code point 0xD) characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group. Ad group resource names have the form:
        /// `customers/{customer_id}/adGroups/{ad_group_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. Date when this ad group starts serving ads. By default, the ad group starts now or the ad
        /// group's start date, whichever is later. If this field is set, then the ad group starts at the beginning of
        /// the specified date in the customer's time zone. This field is only available for Microsoft Advertising and
        /// Facebook gateway accounts. Format: YYYY-MM-DD Example: 2019-03-14
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>The status of the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Setting for targeting related features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingSetting")]
        public virtual GoogleAdsSearchads360V0CommonTargetingSetting TargetingSetting { get; set; }

        /// <summary>Immutable. The type of the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An ad group ad.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupAd : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ad")]
        public virtual GoogleAdsSearchads360V0ResourcesAd Ad { get; set; }

        /// <summary>
        /// Output only. The timestamp when this ad_group_ad was created. The datetime is in the customer's time zone
        /// and in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>
        /// Output only. The resource names of effective labels attached to this ad. An effective label is a label
        /// inherited or directly assigned to this ad.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveLabels")]
        public virtual System.Collections.Generic.IList<string> EffectiveLabels { get; set; }

        /// <summary>
        /// Output only. ID of the ad in the external engine account. This field is for Search Ads 360 account only, for
        /// example, Yahoo Japan, Microsoft, Baidu etc. For non-Search Ads 360 entity, use "ad_group_ad.ad.id" instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineId")]
        public virtual string EngineId { get; set; }

        /// <summary>
        /// Output only. Additional status of the ad in the external engine account. Possible statuses (depending on the
        /// type of external account) include active, eligible, pending review, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineStatus")]
        public virtual string EngineStatus { get; set; }

        /// <summary>Output only. The resource names of labels attached to this ad group ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Output only. The datetime when this ad group ad was last modified. The datetime is in the customer's time
        /// zone and in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTime { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad. Ad group ad resource names have the form:
        /// `customers/{customer_id}/adGroupAds/{ad_group_id}~{ad_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The status of the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A relationship between an ad group ad and an effective label. An effective label is a label inherited or
    /// directly assigned to this ad group ad.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupAdEffectiveLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group ad to which the effective label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAd")]
        public virtual string AdGroupAd { get; set; }

        /// <summary>Immutable. The effective label assigned to the ad group ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the effective label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group ad effective label. Ad group ad effective label resource names
        /// have the form: `customers/{customer_id}/adGroupAdEffectiveLabels/{ad_group_id}~{ad_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A relationship between an ad group ad and a label.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupAdLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group ad to which the label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAd")]
        public virtual string AdGroupAd { get; set; }

        /// <summary>Immutable. The label assigned to the ad group ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group ad label. Ad group ad label resource names have the form:
        /// `customers/{customer_id}/adGroupAdLabels/{ad_group_id}~{ad_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between an ad group and an asset.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The ad group to which the asset is linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroup")]
        public virtual string AdGroup { get; set; }

        /// <summary>Required. Immutable. The asset which is linked to the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group asset. AdGroupAsset resource names have the form:
        /// `customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Status of the ad group asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AdGroupAssetSet is the linkage between an ad group and an asset set. Creating an AdGroupAssetSet links an asset
    /// set with an ad group.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupAssetSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group to which this asset set is linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroup")]
        public virtual string AdGroup { get; set; }

        /// <summary>Immutable. The asset set which is linked to the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSet")]
        public virtual string AssetSet { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group asset set. Ad group asset set resource names have the form:
        /// `customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the ad group asset set. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ad group audience view. Includes performance data from interests and remarketing lists for Display Network
    /// and YouTube Network ads, and remarketing lists for search ads (RLSA), aggregated at the audience level.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupAudienceView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the ad group audience view. Ad group audience view resource names have the
        /// form: `customers/{customer_id}/adGroupAudienceViews/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an ad group bid modifier.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupBidModifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The modifier for the bid when the criterion matches. The modifier must be in the range: 0.1 - 10.0. The
        /// range is 1.0 - 6.0 for PreferredContent. Use 0 to opt out of a Device type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidModifier")]
        public virtual System.Nullable<double> BidModifier { get; set; }

        /// <summary>Immutable. A device criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual GoogleAdsSearchads360V0CommonDeviceInfo Device { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group bid modifier. Ad group bid modifier resource names have the
        /// form: `customers/{customer_id}/adGroupBidModifiers/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ad group criterion. The ad_group_criterion report only returns criteria that were explicitly added to the ad
    /// group.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupCriterion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group to which the criterion belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroup")]
        public virtual string AdGroup { get; set; }

        /// <summary>Immutable. Age range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual GoogleAdsSearchads360V0CommonAgeRangeInfo AgeRange { get; set; }

        /// <summary>
        /// The modifier for the bid when the criterion matches. The modifier must be in the range: 0.1 - 10.0. Most
        /// targetable criteria types support modifiers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidModifier")]
        public virtual System.Nullable<double> BidModifier { get; set; }

        /// <summary>The CPC (cost-per-click) bid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpcBidMicros")]
        public virtual System.Nullable<long> CpcBidMicros { get; set; }

        /// <summary>
        /// Output only. The timestamp when this ad group criterion was created. The timestamp is in the customer's time
        /// zone and in "yyyy-MM-dd HH:mm:ss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>Output only. The ID of the criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criterionId")]
        public virtual System.Nullable<long> CriterionId { get; set; }

        /// <summary>Output only. The effective CPC (cost-per-click) bid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveCpcBidMicros")]
        public virtual System.Nullable<long> EffectiveCpcBidMicros { get; set; }

        /// <summary>
        /// Output only. The resource names of effective labels attached to this ad group criterion. An effective label
        /// is a label inherited or directly assigned to this ad group criterion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveLabels")]
        public virtual System.Collections.Generic.IList<string> EffectiveLabels { get; set; }

        /// <summary>
        /// Output only. ID of the ad group criterion in the external engine account. This field is for non-Google Ads
        /// account only, for example, Yahoo Japan, Microsoft, Baidu etc. For Google Ads entity, use
        /// "ad_group_criterion.criterion_id" instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineId")]
        public virtual string EngineId { get; set; }

        /// <summary>Output only. The Engine Status for ad group criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineStatus")]
        public virtual string EngineStatus { get; set; }

        /// <summary>URL template for appending params to final URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrlSuffix")]
        public virtual string FinalUrlSuffix { get; set; }

        /// <summary>The list of possible final URLs after all cross-domain redirects for the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrls")]
        public virtual System.Collections.Generic.IList<string> FinalUrls { get; set; }

        /// <summary>Immutable. Gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual GoogleAdsSearchads360V0CommonGenderInfo Gender { get; set; }

        /// <summary>Immutable. Keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyword")]
        public virtual GoogleAdsSearchads360V0CommonKeywordInfo Keyword { get; set; }

        /// <summary>Output only. The resource names of labels attached to this ad group criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Output only. The datetime when this ad group criterion was last modified. The datetime is in the customer's
        /// time zone and in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTime { get; set; }

        /// <summary>Immutable. Listing group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listingGroup")]
        public virtual GoogleAdsSearchads360V0CommonListingGroupInfo ListingGroup { get; set; }

        /// <summary>Immutable. Location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GoogleAdsSearchads360V0CommonLocationInfo Location { get; set; }

        /// <summary>
        /// Immutable. Whether to target (`false`) or exclude (`true`) the criterion. This field is immutable. To switch
        /// a criterion from positive to negative, remove then re-add it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; }

        /// <summary>Output only. Estimates for criterion bids at various positions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positionEstimates")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupCriterionPositionEstimates PositionEstimates { get; set; }

        /// <summary>Output only. Information regarding the quality of the criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualityInfo")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupCriterionQualityInfo QualityInfo { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group criterion. Ad group criterion resource names have the form:
        /// `customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// The status of the criterion. This is the status of the ad group criterion entity, set by the client. Note:
        /// UI reports may incorporate additional information that affects whether a criterion is eligible to run. In
        /// some cases a criterion that's REMOVED in the API can still show as enabled in the UI. For example, campaigns
        /// by default show to users of all age ranges unless excluded. The UI will show each age range as "enabled",
        /// since they're eligible to see the ads; but AdGroupCriterion.status will show "removed", since no positive
        /// criterion was added.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The URL template for constructing a tracking URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingUrlTemplate")]
        public virtual string TrackingUrlTemplate { get; set; }

        /// <summary>Output only. The type of the criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Immutable. User List.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userList")]
        public virtual GoogleAdsSearchads360V0CommonUserListInfo UserList { get; set; }

        /// <summary>Immutable. Webpage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webpage")]
        public virtual GoogleAdsSearchads360V0CommonWebpageInfo Webpage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A relationship between an ad group criterion and an effective label. An effective label is a label inherited or
    /// directly assigned to this ad group criterion.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupCriterionEffectiveLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group criterion to which the effective label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupCriterion")]
        public virtual string AdGroupCriterion { get; set; }

        /// <summary>Immutable. The effective label assigned to the ad group criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the effective label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group criterion effective label. Ad group criterion effective label
        /// resource names have the form:
        /// `customers/{customer_id}/adGroupCriterionEffectiveLabels/{ad_group_id}~{criterion_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A relationship between an ad group criterion and a label.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupCriterionLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group criterion to which the label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupCriterion")]
        public virtual string AdGroupCriterion { get; set; }

        /// <summary>Immutable. The label assigned to the ad group criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group criterion label. Ad group criterion label resource names have
        /// the form: `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Estimates for criterion bids at various positions.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupCriterionPositionEstimates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The estimate of the CPC bid required for ad to be displayed at the top of the first page of
        /// search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topOfPageCpcMicros")]
        public virtual System.Nullable<long> TopOfPageCpcMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A container for ad group criterion quality information.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupCriterionQualityInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The quality score. This field may not be populated if Google does not have enough information
        /// to determine a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualityScore")]
        public virtual System.Nullable<int> QualityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A relationship between an ad group and an effective label. An effective label is a label inherited or directly
    /// assigned to this ad group.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupEffectiveLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group to which the effective label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroup")]
        public virtual string AdGroup { get; set; }

        /// <summary>Immutable. The effective label assigned to the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the effective label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group effective label. Ad group effective label resource names have
        /// the form: `customers/{customer_id}/adGroupEffectiveLabels/{ad_group_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A relationship between an ad group and a label.</summary>
    public class GoogleAdsSearchads360V0ResourcesAdGroupLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The ad group to which the label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroup")]
        public virtual string AdGroup { get; set; }

        /// <summary>Immutable. The label assigned to the ad group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. The resource name of the ad group label. Ad group label resource names have the form:
        /// `customers/{customer_id}/adGroupLabels/{ad_group_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An age range view.</summary>
    public class GoogleAdsSearchads360V0ResourcesAgeRangeView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the age range view. Age range view resource names have the form:
        /// `customers/{customer_id}/ageRangeViews/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Asset is a part of an ad which can be shared across multiple ads. It can be an image (ImageAsset), a video
    /// (YoutubeVideoAsset), etc. Assets are immutable and cannot be removed. To stop an asset from serving, remove the
    /// asset from the entity that is using it.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A unified call asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callAsset")]
        public virtual GoogleAdsSearchads360V0CommonUnifiedCallAsset CallAsset { get; set; }

        /// <summary>Immutable. A call to action asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callToActionAsset")]
        public virtual GoogleAdsSearchads360V0CommonCallToActionAsset CallToActionAsset { get; set; }

        /// <summary>Output only. A unified callout asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calloutAsset")]
        public virtual GoogleAdsSearchads360V0CommonUnifiedCalloutAsset CalloutAsset { get; set; }

        /// <summary>
        /// Output only. The timestamp when this asset was created. The timestamp is in the customer's time zone and in
        /// "yyyy-MM-dd HH:mm:ss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>Output only. The Engine Status for an asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineStatus")]
        public virtual string EngineStatus { get; set; }

        /// <summary>A list of possible final URLs after all cross domain redirects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrls")]
        public virtual System.Collections.Generic.IList<string> FinalUrls { get; set; }

        /// <summary>Output only. The ID of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Output only. An image asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAsset")]
        public virtual GoogleAdsSearchads360V0CommonImageAsset ImageAsset { get; set; }

        /// <summary>
        /// Output only. The datetime when this asset was last modified. The datetime is in the customer's time zone and
        /// in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTime { get; set; }

        /// <summary>Output only. A unified location asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationAsset")]
        public virtual GoogleAdsSearchads360V0CommonUnifiedLocationAsset LocationAsset { get; set; }

        /// <summary>A mobile app asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileAppAsset")]
        public virtual GoogleAdsSearchads360V0CommonMobileAppAsset MobileAppAsset { get; set; }

        /// <summary>Optional name of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. A unified page feed asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFeedAsset")]
        public virtual GoogleAdsSearchads360V0CommonUnifiedPageFeedAsset PageFeedAsset { get; set; }

        /// <summary>
        /// Immutable. The resource name of the asset. Asset resource names have the form:
        /// `customers/{customer_id}/assets/{asset_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. A unified sitelink asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sitelinkAsset")]
        public virtual GoogleAdsSearchads360V0CommonUnifiedSitelinkAsset SitelinkAsset { get; set; }

        /// <summary>Output only. The status of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. A text asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAsset")]
        public virtual GoogleAdsSearchads360V0CommonTextAsset TextAsset { get; set; }

        /// <summary>URL template for constructing a tracking URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingUrlTemplate")]
        public virtual string TrackingUrlTemplate { get; set; }

        /// <summary>Output only. Type of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Immutable. A YouTube video asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeVideoAsset")]
        public virtual GoogleAdsSearchads360V0CommonYoutubeVideoAsset YoutubeVideoAsset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset group. AssetGroupAsset is used to link an asset to the asset group. AssetGroupSignal is used to
    /// associate a signal to an asset group.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAssetGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Overall ad strength of this asset group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adStrength")]
        public virtual string AdStrength { get; set; }

        /// <summary>
        /// Immutable. The campaign with which this asset group is associated. The asset which is linked to the asset
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaign")]
        public virtual string Campaign { get; set; }

        /// <summary>
        /// A list of final mobile URLs after all cross domain redirects. In performance max, by default, the urls are
        /// eligible for expansion unless opted out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalMobileUrls")]
        public virtual System.Collections.Generic.IList<string> FinalMobileUrls { get; set; }

        /// <summary>
        /// A list of final URLs after all cross domain redirects. In performance max, by default, the urls are eligible
        /// for expansion unless opted out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrls")]
        public virtual System.Collections.Generic.IList<string> FinalUrls { get; set; }

        /// <summary>Output only. The ID of the asset group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Required. Name of the asset group. Required. It must have a minimum length of 1 and maximum length of 128.
        /// It must be unique under a campaign.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>First part of text that may appear appended to the url displayed in the ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path1")]
        public virtual string Path1 { get; set; }

        /// <summary>
        /// Second part of text that may appear appended to the url displayed in the ad. This field can only be set when
        /// path1 is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path2")]
        public virtual string Path2 { get; set; }

        /// <summary>
        /// Immutable. The resource name of the asset group. Asset group resource names have the form:
        /// `customers/{customer_id}/assetGroups/{asset_group_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The status of the asset group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AssetGroupAsset is the link between an asset and an asset group. Adding an AssetGroupAsset links an asset with
    /// an asset group.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAssetGroupAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The asset which this asset group asset is linking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>Immutable. The asset group which this asset group asset is linking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroup")]
        public virtual string AssetGroup { get; set; }

        /// <summary>
        /// The description of the placement of the asset within the asset group. For example: HEADLINE, YOUTUBE_VIDEO
        /// etc
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldType")]
        public virtual string FieldType { get; set; }

        /// <summary>
        /// Immutable. The resource name of the asset group asset. Asset group asset resource name have the form:
        /// `customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The status of the link between an asset and asset group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Asset group asset combination data</summary>
    public class GoogleAdsSearchads360V0ResourcesAssetGroupAssetCombinationData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Served assets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetCombinationServedAssets")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonAssetUsage> AssetCombinationServedAssets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AssetGroupListingGroupFilter represents a listing group filter tree node in an asset group.</summary>
    public class GoogleAdsSearchads360V0ResourcesAssetGroupListingGroupFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The asset group which this asset group listing group filter is part of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroup")]
        public virtual string AssetGroup { get; set; }

        /// <summary>
        /// Dimension value with which this listing group is refining its parent. Undefined for the root group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseValue")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimension CaseValue { get; set; }

        /// <summary>Output only. The ID of the ListingGroupFilter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Immutable. Resource name of the parent listing group subdivision. Null for the root listing group filter
        /// node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentListingGroupFilter")]
        public virtual string ParentListingGroupFilter { get; set; }

        /// <summary>Output only. The path of dimensions defining this listing group filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionPath Path { get; set; }

        /// <summary>
        /// Immutable. The resource name of the asset group listing group filter. Asset group listing group filter
        /// resource name have the form:
        /// `customers/{customer_id}/assetGroupListingGroupFilters/{asset_group_id}~{listing_group_filter_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Immutable. Type of a listing group filter node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Immutable. The vertical the current node tree represents. All nodes in the same tree must belong to the same
        /// vertical.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertical")]
        public virtual string Vertical { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AssetGroupSignal represents a signal in an asset group. The existence of a signal tells the performance max
    /// campaign who's most likely to convert. Performance Max uses the signal to look for new people with similar or
    /// stronger intent to find conversions across Search, Display, Video, and more.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAssetGroupSignal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The asset group which this asset group signal belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroup")]
        public virtual string AssetGroup { get; set; }

        /// <summary>Immutable. The audience signal to be used by the performance max campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual GoogleAdsSearchads360V0CommonAudienceInfo Audience { get; set; }

        /// <summary>
        /// Immutable. The resource name of the asset group signal. Asset group signal resource name have the form:
        /// `customers/{customer_id}/assetGroupSignals/{asset_group_id}~{signal_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A view on the usage of asset group asset top combinations.</summary>
    public class GoogleAdsSearchads360V0ResourcesAssetGroupTopCombinationView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The top combinations of assets that served together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroupTopCombinations")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ResourcesAssetGroupAssetCombinationData> AssetGroupTopCombinations { get; set; }

        /// <summary>
        /// Output only. The resource name of the asset group top combination view. AssetGroup Top Combination view
        /// resource names have the form:
        /// `"customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An asset set representing a collection of assets. Use AssetSetAsset to link an asset to the asset set.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAssetSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of the asset set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Immutable. The resource name of the asset set. Asset set resource names have the form:
        /// `customers/{customer_id}/assetSets/{asset_set_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AssetSetAsset is the link between an asset and an asset set. Adding an AssetSetAsset links an asset with an
    /// asset set.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAssetSetAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The asset which this asset set asset is linking to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>Immutable. The asset set which this asset set asset is linking to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSet")]
        public virtual string AssetSet { get; set; }

        /// <summary>
        /// Immutable. The resource name of the asset set asset. Asset set asset resource names have the form:
        /// `customers/{customer_id}/assetSetAssets/{asset_set_id}~{asset_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the asset set asset. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Audience is an effective targeting option that lets you intersect different segment attributes, such as detailed
    /// demographics and affinities, to create audiences that represent sections of your target segments.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of this audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. ID of the audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Required. Name of the audience. It should be unique across all audiences. It must have a minimum length of 1
        /// and maximum length of 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The resource name of the audience. Audience names have the form:
        /// `customers/{customer_id}/audiences/{audience_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bidding strategy.</summary>
    public class GoogleAdsSearchads360V0ResourcesBiddingStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The number of campaigns attached to this bidding strategy. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignCount")]
        public virtual System.Nullable<long> CampaignCount { get; set; }

        /// <summary>
        /// Immutable. The currency used by the bidding strategy (ISO 4217 three-letter code). For bidding strategies in
        /// manager customers, this currency can be set on creation and defaults to the manager customer's currency. For
        /// serving customers, this field cannot be set; all strategies in a serving customer implicitly use the serving
        /// customer's currency. In all cases the effective_currency_code field returns the currency used by the
        /// strategy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Output only. The currency used by the bidding strategy (ISO 4217 three-letter code). For bidding strategies
        /// in manager customers, this is the currency set by the advertiser when creating the strategy. For serving
        /// customers, this is the customer's currency_code. Bidding strategy metrics are reported in this currency.
        /// This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveCurrencyCode")]
        public virtual string EffectiveCurrencyCode { get; set; }

        /// <summary>
        /// A bidding strategy that raises bids for clicks that seem more likely to lead to a conversion and lowers them
        /// for clicks where they seem less likely.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enhancedCpc")]
        public virtual GoogleAdsSearchads360V0CommonEnhancedCpc EnhancedCpc { get; set; }

        /// <summary>Output only. The ID of the bidding strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// An automated bidding strategy to help get the most conversion value for your campaigns while spending your
        /// budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximizeConversionValue")]
        public virtual GoogleAdsSearchads360V0CommonMaximizeConversionValue MaximizeConversionValue { get; set; }

        /// <summary>
        /// An automated bidding strategy to help get the most conversions for your campaigns while spending your
        /// budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximizeConversions")]
        public virtual GoogleAdsSearchads360V0CommonMaximizeConversions MaximizeConversions { get; set; }

        /// <summary>
        /// The name of the bidding strategy. All bidding strategies within an account must be named distinctly. The
        /// length of this string should be between 1 and 255, inclusive, in UTF-8 bytes, (trimmed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The number of non-removed campaigns attached to this bidding strategy. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonRemovedCampaignCount")]
        public virtual System.Nullable<long> NonRemovedCampaignCount { get; set; }

        /// <summary>
        /// Immutable. The resource name of the bidding strategy. Bidding strategy resource names have the form:
        /// `customers/{customer_id}/biddingStrategies/{bidding_strategy_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the bidding strategy. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// A bidding strategy that sets bids to help get as many conversions as possible at the target
        /// cost-per-acquisition (CPA) you set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpa")]
        public virtual GoogleAdsSearchads360V0CommonTargetCpa TargetCpa { get; set; }

        /// <summary>
        /// A bidding strategy that automatically optimizes towards a chosen percentage of impressions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetImpressionShare")]
        public virtual GoogleAdsSearchads360V0CommonTargetImpressionShare TargetImpressionShare { get; set; }

        /// <summary>
        /// A bidding strategy that sets bids based on the target fraction of auctions where the advertiser should
        /// outrank a specific competitor. This field is deprecated. Creating a new bidding strategy with this field or
        /// attaching bidding strategies with this field to a campaign will fail. Mutates to strategies that already
        /// have this scheme populated are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetOutrankShare")]
        public virtual GoogleAdsSearchads360V0CommonTargetOutrankShare TargetOutrankShare { get; set; }

        /// <summary>
        /// A bidding strategy that helps you maximize revenue while averaging a specific target Return On Ad Spend
        /// (ROAS).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRoas")]
        public virtual GoogleAdsSearchads360V0CommonTargetRoas TargetRoas { get; set; }

        /// <summary>
        /// A bid strategy that sets your bids to help get as many clicks as possible within your budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSpend")]
        public virtual GoogleAdsSearchads360V0CommonTargetSpend TargetSpend { get; set; }

        /// <summary>
        /// Output only. The type of the bidding strategy. Create a bidding strategy by setting the bidding scheme. This
        /// field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A campaign.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaign : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name of AccessibleBiddingStrategy, a read-only view of the unrestricted attributes of
        /// the attached portfolio bidding strategy identified by 'bidding_strategy'. Empty, if the campaign does not
        /// use a portfolio strategy. Unrestricted strategy attributes are available to all customers with whom the
        /// strategy is shared and are read from the AccessibleBiddingStrategy resource. In contrast, restricted
        /// attributes are only available to the owner customer of the strategy and their managers. Restricted
        /// attributes can only be read from the BiddingStrategy resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibleBiddingStrategy")]
        public virtual string AccessibleBiddingStrategy { get; set; }

        /// <summary>The ad serving optimization status of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adServingOptimizationStatus")]
        public virtual string AdServingOptimizationStatus { get; set; }

        /// <summary>
        /// Immutable. Optional refinement to `advertising_channel_type`. Must be a valid sub-type of the parent channel
        /// type. Can be set only when creating campaigns. After campaign is created, the field can not be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertisingChannelSubType")]
        public virtual string AdvertisingChannelSubType { get; set; }

        /// <summary>
        /// Immutable. The primary serving target for ads within the campaign. The targeting options can be refined in
        /// `network_settings`. This field is required and should not be empty when creating new campaigns. Can be set
        /// only when creating campaigns. After the campaign is created, the field can not be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertisingChannelType")]
        public virtual string AdvertisingChannelType { get; set; }

        /// <summary>The resource name of the portfolio bidding strategy used by the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biddingStrategy")]
        public virtual string BiddingStrategy { get; set; }

        /// <summary>Output only. The system status of the campaign's bidding strategy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biddingStrategySystemStatus")]
        public virtual string BiddingStrategySystemStatus { get; set; }

        /// <summary>
        /// Output only. The type of bidding strategy. A bidding strategy can be created by setting either the bidding
        /// scheme to create a standard bidding strategy or the `bidding_strategy` field to create a portfolio bidding
        /// strategy. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biddingStrategyType")]
        public virtual string BiddingStrategyType { get; set; }

        /// <summary>The resource name of the campaign budget of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignBudget")]
        public virtual string CampaignBudget { get; set; }

        /// <summary>
        /// Output only. The timestamp when this campaign was created. The timestamp is in the customer's time zone and
        /// in "yyyy-MM-dd HH:mm:ss" format. create_time will be deprecated in v1. Use creation_time instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTime { get; set; }

        /// <summary>
        /// Output only. The timestamp when this campaign was created. The timestamp is in the customer's time zone and
        /// in "yyyy-MM-dd HH:mm:ss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>The setting for controlling Dynamic Search Ads (DSA).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSearchAdsSetting")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignDynamicSearchAdsSetting DynamicSearchAdsSetting { get; set; }

        /// <summary>
        /// Output only. The resource names of effective labels attached to this campaign. An effective label is a label
        /// inherited or directly assigned to this campaign.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveLabels")]
        public virtual System.Collections.Generic.IList<string> EffectiveLabels { get; set; }

        /// <summary>
        /// The last day of the campaign in serving customer's timezone in YYYY-MM-DD format. On create, defaults to
        /// 2037-12-30, which means the campaign will run indefinitely. To set an existing campaign to run indefinitely,
        /// set this field to 2037-12-30.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// Output only. ID of the campaign in the external engine account. This field is for non-Google Ads account
        /// only, for example, Yahoo Japan, Microsoft, Baidu etc. For Google Ads entity, use "campaign.id" instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineId")]
        public virtual string EngineId { get; set; }

        /// <summary>
        /// The asset field types that should be excluded from this campaign. Asset links with these field types will
        /// not be inherited by this campaign from the upper level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedParentAssetFieldTypes")]
        public virtual System.Collections.Generic.IList<string> ExcludedParentAssetFieldTypes { get; set; }

        /// <summary>
        /// Suffix used to append query parameters to landing pages that are served with parallel tracking.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrlSuffix")]
        public virtual string FinalUrlSuffix { get; set; }

        /// <summary>A list that limits how often each user will see this campaign's ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyCaps")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonFrequencyCapEntry> FrequencyCaps { get; set; }

        /// <summary>The setting for ads geotargeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetTypeSetting")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignGeoTargetTypeSetting GeoTargetTypeSetting { get; set; }

        /// <summary>Output only. The ID of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Output only. The resource names of labels attached to this campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Output only. The datetime when this campaign was last modified. The datetime is in the customer's time zone
        /// and in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTime { get; set; }

        /// <summary>
        /// Standard Manual CPA bidding strategy. Manual bidding strategy that allows advertiser to set the bid per
        /// advertiser-specified action. Supported only for Local Services campaigns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualCpa")]
        public virtual GoogleAdsSearchads360V0CommonManualCpa ManualCpa { get; set; }

        /// <summary>
        /// Standard Manual CPC bidding strategy. Manual click-based bidding where user pays per click.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualCpc")]
        public virtual GoogleAdsSearchads360V0CommonManualCpc ManualCpc { get; set; }

        /// <summary>
        /// Standard Manual CPM bidding strategy. Manual impression-based bidding where user pays per thousand
        /// impressions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualCpm")]
        public virtual GoogleAdsSearchads360V0CommonManualCpm ManualCpm { get; set; }

        /// <summary>
        /// Standard Maximize Conversion Value bidding strategy that automatically sets bids to maximize revenue while
        /// spending your budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximizeConversionValue")]
        public virtual GoogleAdsSearchads360V0CommonMaximizeConversionValue MaximizeConversionValue { get; set; }

        /// <summary>
        /// Standard Maximize Conversions bidding strategy that automatically maximizes number of conversions while
        /// spending your budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximizeConversions")]
        public virtual GoogleAdsSearchads360V0CommonMaximizeConversions MaximizeConversions { get; set; }

        /// <summary>
        /// The name of the campaign. This field is required and should not be empty when creating new campaigns. It
        /// must not contain any null (code point 0x0), NL line feed (code point 0xA) or carriage return (code point
        /// 0xD) characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The network settings for the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkSettings")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignNetworkSettings NetworkSettings { get; set; }

        /// <summary>
        /// Optimization goal setting for this campaign, which includes a set of optimization goal types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationGoalSetting")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignOptimizationGoalSetting OptimizationGoalSetting { get; set; }

        /// <summary>
        /// Standard Percent Cpc bidding strategy where bids are a fraction of the advertised price for some good or
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentCpc")]
        public virtual GoogleAdsSearchads360V0CommonPercentCpc PercentCpc { get; set; }

        /// <summary>
        /// Settings for Real-Time Bidding, a feature only available for campaigns targeting the Ad Exchange network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realTimeBiddingSetting")]
        public virtual GoogleAdsSearchads360V0CommonRealTimeBiddingSetting RealTimeBiddingSetting { get; set; }

        /// <summary>
        /// Immutable. The resource name of the campaign. Campaign resource names have the form:
        /// `customers/{customer_id}/campaigns/{campaign_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Selective optimization setting for this campaign, which includes a set of conversion actions to optimize
        /// this campaign towards. This feature only applies to app campaigns that use MULTI_CHANNEL as
        /// AdvertisingChannelType and APP_CAMPAIGN or APP_CAMPAIGN_FOR_ENGAGEMENT as AdvertisingChannelSubType.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectiveOptimization")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignSelectiveOptimization SelectiveOptimization { get; set; }

        /// <summary>Output only. The ad serving status of the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingStatus")]
        public virtual string ServingStatus { get; set; }

        /// <summary>The setting for controlling Shopping campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shoppingSetting")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignShoppingSetting ShoppingSetting { get; set; }

        /// <summary>The date when campaign started in serving customer's timezone in YYYY-MM-DD format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>The status of the campaign. When a new campaign is added, the status defaults to ENABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Standard Target CPA bidding strategy that automatically sets bids to help get as many conversions as
        /// possible at the target cost-per-acquisition (CPA) you set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpa")]
        public virtual GoogleAdsSearchads360V0CommonTargetCpa TargetCpa { get; set; }

        /// <summary>A bidding strategy that automatically optimizes cost per thousand impressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpm")]
        public virtual GoogleAdsSearchads360V0CommonTargetCpm TargetCpm { get; set; }

        /// <summary>
        /// Target Impression Share bidding strategy. An automated bidding strategy that sets bids to achieve a chosen
        /// percentage of impressions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetImpressionShare")]
        public virtual GoogleAdsSearchads360V0CommonTargetImpressionShare TargetImpressionShare { get; set; }

        /// <summary>
        /// Standard Target ROAS bidding strategy that automatically maximizes revenue while averaging a specific target
        /// return on ad spend (ROAS).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRoas")]
        public virtual GoogleAdsSearchads360V0CommonTargetRoas TargetRoas { get; set; }

        /// <summary>
        /// Standard Target Spend bidding strategy that automatically sets your bids to help get as many clicks as
        /// possible within your budget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSpend")]
        public virtual GoogleAdsSearchads360V0CommonTargetSpend TargetSpend { get; set; }

        /// <summary>Output only. Campaign-level settings for tracking information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingSetting")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignTrackingSetting TrackingSetting { get; set; }

        /// <summary>The URL template for constructing a tracking URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingUrlTemplate")]
        public virtual string TrackingUrlTemplate { get; set; }

        /// <summary>
        /// The list of mappings used to substitute custom parameter tags in a `tracking_url_template`, `final_urls`, or
        /// `mobile_final_urls`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlCustomParameters")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonCustomParameter> UrlCustomParameters { get; set; }

        /// <summary>
        /// Represents opting out of URL expansion to more targeted URLs. If opted out (true), only the final URLs in
        /// the asset group or URLs specified in the advertiser's Google Merchant Center or business data feeds are
        /// targeted. If opted in (false), the entire domain will be targeted. This field can only be set for
        /// Performance Max campaigns, where the default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlExpansionOptOut")]
        public virtual System.Nullable<bool> UrlExpansionOptOut { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a Campaign and an Asset.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The asset which is linked to the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>Immutable. The campaign to which the asset is linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaign")]
        public virtual string Campaign { get; set; }

        /// <summary>
        /// Immutable. The resource name of the campaign asset. CampaignAsset resource names have the form:
        /// `customers/{customer_id}/campaignAssets/{campaign_id}~{asset_id}~{field_type}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. Status of the campaign asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CampaignAssetSet is the linkage between a campaign and an asset set. Adding a CampaignAssetSet links an asset
    /// set with a campaign.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignAssetSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The asset set which is linked to the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSet")]
        public virtual string AssetSet { get; set; }

        /// <summary>Immutable. The campaign to which this asset set is linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaign")]
        public virtual string Campaign { get; set; }

        /// <summary>
        /// Immutable. The resource name of the campaign asset set. Asset set asset resource names have the form:
        /// `customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the campaign asset set asset. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A campaign audience view. Includes performance data from interests and remarketing lists for Display Network and
    /// YouTube Network ads, and remarketing lists for search ads (RLSA), aggregated by campaign and audience criterion.
    /// This view only includes audiences attached at the campaign level.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignAudienceView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the campaign audience view. Campaign audience view resource names have the
        /// form: `customers/{customer_id}/campaignAudienceViews/{campaign_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A campaign budget.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignBudget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of the budget, in the local currency for the account. Amount is specified in micros, where one
        /// million is equivalent to one currency unit. Monthly spend is capped at 30.4 times this amount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>
        /// The delivery method that determines the rate at which the campaign budget is spent. Defaults to STANDARD if
        /// unspecified in a create operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryMethod")]
        public virtual string DeliveryMethod { get; set; }

        /// <summary>Immutable. Period over which to spend the budget. Defaults to DAILY if not specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual string Period { get; set; }

        /// <summary>
        /// Immutable. The resource name of the campaign budget. Campaign budget resource names have the form:
        /// `customers/{customer_id}/campaignBudgets/{campaign_budget_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A campaign criterion.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignCriterion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. Age range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRange")]
        public virtual GoogleAdsSearchads360V0CommonAgeRangeInfo AgeRange { get; set; }

        /// <summary>
        /// The modifier for the bids when the criterion matches. The modifier must be in the range: 0.1 - 10.0. Most
        /// targetable criteria types support modifiers. Use 0 to opt out of a Device type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidModifier")]
        public virtual System.Nullable<float> BidModifier { get; set; }

        /// <summary>Output only. The ID of the criterion. This field is ignored during mutate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criterionId")]
        public virtual System.Nullable<long> CriterionId { get; set; }

        /// <summary>Immutable. Device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual GoogleAdsSearchads360V0CommonDeviceInfo Device { get; set; }

        /// <summary>Output only. The display name of the criterion. This field is ignored for mutates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Immutable. Gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual GoogleAdsSearchads360V0CommonGenderInfo Gender { get; set; }

        /// <summary>Immutable. Keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyword")]
        public virtual GoogleAdsSearchads360V0CommonKeywordInfo Keyword { get; set; }

        /// <summary>Immutable. Language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual GoogleAdsSearchads360V0CommonLanguageInfo Language { get; set; }

        /// <summary>
        /// Output only. The datetime when this campaign criterion was last modified. The datetime is in the customer's
        /// time zone and in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTime { get; set; }

        /// <summary>Immutable. Location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GoogleAdsSearchads360V0CommonLocationInfo Location { get; set; }

        /// <summary>Immutable. Location Group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationGroup")]
        public virtual GoogleAdsSearchads360V0CommonLocationGroupInfo LocationGroup { get; set; }

        /// <summary>Immutable. Whether to target (`false`) or exclude (`true`) the criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negative")]
        public virtual System.Nullable<bool> Negative { get; set; }

        /// <summary>
        /// Immutable. The resource name of the campaign criterion. Campaign criterion resource names have the form:
        /// `customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The status of the criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. The type of the criterion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Immutable. User List.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userList")]
        public virtual GoogleAdsSearchads360V0CommonUserListInfo UserList { get; set; }

        /// <summary>Immutable. Webpage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webpage")]
        public virtual GoogleAdsSearchads360V0CommonWebpageInfo Webpage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The setting for controlling Dynamic Search Ads (DSA).</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignDynamicSearchAdsSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Internet domain name that this setting represents, for example, "google.com" or
        /// "www.google.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>Required. The language code specifying the language of the domain, for example, "en".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Whether the campaign uses advertiser supplied URLs exclusively.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSuppliedUrlsOnly")]
        public virtual System.Nullable<bool> UseSuppliedUrlsOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a relationship between a campaign and an effective label. An effective label is a label inherited or
    /// directly assigned to this campaign.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignEffectiveLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The campaign to which the effective label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaign")]
        public virtual string Campaign { get; set; }

        /// <summary>Immutable. The effective label assigned to the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the effective label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. Name of the resource. CampaignEffectivelabel resource names have the form:
        /// `customers/{customer_id}/campaignEffectiveLabels/{campaign_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a collection of settings related to ads geotargeting.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignGeoTargetTypeSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The setting used for negative geotargeting in this particular campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeGeoTargetType")]
        public virtual string NegativeGeoTargetType { get; set; }

        /// <summary>The setting used for positive geotargeting in this particular campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positiveGeoTargetType")]
        public virtual string PositiveGeoTargetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a relationship between a campaign and a label.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The campaign to which the label is attached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaign")]
        public virtual string Campaign { get; set; }

        /// <summary>Immutable. The label assigned to the campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. The ID of the Customer which owns the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomerId")]
        public virtual System.Nullable<long> OwnerCustomerId { get; set; }

        /// <summary>
        /// Immutable. Name of the resource. Campaign label resource names have the form:
        /// `customers/{customer_id}/campaignLabels/{campaign_id}~{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The network settings for the campaign.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignNetworkSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether ads will be served on specified placements in the Google Display Network. Placements are specified
        /// using the Placement criterion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetContentNetwork")]
        public virtual System.Nullable<bool> TargetContentNetwork { get; set; }

        /// <summary>Whether ads will be served with google.com search results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetGoogleSearch")]
        public virtual System.Nullable<bool> TargetGoogleSearch { get; set; }

        /// <summary>
        /// Whether ads will be served on the Google Partner Network. This is available only to some select Google
        /// partner accounts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetPartnerSearchNetwork")]
        public virtual System.Nullable<bool> TargetPartnerSearchNetwork { get; set; }

        /// <summary>
        /// Whether ads will be served on partner sites in the Google Search Network (requires `target_google_search` to
        /// also be `true`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSearchNetwork")]
        public virtual System.Nullable<bool> TargetSearchNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optimization goal setting for this campaign, which includes a set of optimization goal types.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignOptimizationGoalSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of optimization goal types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationGoalTypes")]
        public virtual System.Collections.Generic.IList<string> OptimizationGoalTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Selective optimization setting for this campaign, which includes a set of conversion actions to optimize this
    /// campaign towards. This feature only applies to app campaigns that use MULTI_CHANNEL as AdvertisingChannelType
    /// and APP_CAMPAIGN or APP_CAMPAIGN_FOR_ENGAGEMENT as AdvertisingChannelSubType.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignSelectiveOptimization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The selected set of resource names for conversion actions for optimizing this campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionActions")]
        public virtual System.Collections.Generic.IList<string> ConversionActions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The setting for Shopping campaigns. Defines the universe of products that can be advertised by the campaign, and
    /// how this campaign interacts with other Shopping campaigns.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignShoppingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Priority of the campaign. Campaigns with numerically higher priorities take precedence over those with lower
        /// priorities. This field is required for Shopping campaigns, with values between 0 and 2, inclusive. This
        /// field is optional for Smart Shopping campaigns, but must be equal to 3 if set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignPriority")]
        public virtual System.Nullable<int> CampaignPriority { get; set; }

        /// <summary>Whether to include local products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableLocal")]
        public virtual System.Nullable<bool> EnableLocal { get; set; }

        /// <summary>
        /// Feed label of products to include in the campaign. Only one of feed_label or sales_country can be set. If
        /// used instead of sales_country, the feed_label field accepts country codes in the same format for example:
        /// 'XX'. Otherwise can be any string used for feed label in Google Merchant Center.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>
        /// Immutable. ID of the Merchant Center account. This field is required for create operations. This field is
        /// immutable for Shopping campaigns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<long> MerchantId { get; set; }

        /// <summary>Sales country of products to include in the campaign. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salesCountry")]
        public virtual string SalesCountry { get; set; }

        /// <summary>Immutable. Whether to target Vehicle Listing inventory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useVehicleInventory")]
        public virtual System.Nullable<bool> UseVehicleInventory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Campaign-level settings for tracking information.</summary>
    public class GoogleAdsSearchads360V0ResourcesCampaignTrackingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The url used for dynamic tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingUrl")]
        public virtual string TrackingUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cart data sales view.</summary>
    public class GoogleAdsSearchads360V0ResourcesCartDataSalesView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the Cart data sales view. Cart data sales view resource names have the
        /// form: `customers/{customer_id}/cartDataSalesView`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A conversion.</summary>
    public class GoogleAdsSearchads360V0ResourcesConversion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Ad ID. A value of 0 indicates that the ad is unattributed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adId")]
        public virtual System.Nullable<long> AdId { get; set; }

        /// <summary>
        /// Output only. For offline conversions, this is an ID provided by advertisers. If an advertiser doesn't
        /// specify such an ID, Search Ads 360 generates one. For online conversions, this is equal to the id column or
        /// the floodlight_order_id column depending on the advertiser's Floodlight instructions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserConversionId")]
        public virtual string AdvertiserConversionId { get; set; }

        /// <summary>Output only. Asset field type of the conversion event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetFieldType")]
        public virtual string AssetFieldType { get; set; }

        /// <summary>Output only. ID of the asset which was interacted with during the conversion event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetId")]
        public virtual System.Nullable<long> AssetId { get; set; }

        /// <summary>Output only. What the conversion is attributed to: Visit or Keyword+Ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionType")]
        public virtual string AttributionType { get; set; }

        /// <summary>
        /// Output only. A unique string, for the visit that the conversion is attributed to, that is passed to the
        /// landing page as the click id URL parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickId")]
        public virtual string ClickId { get; set; }

        /// <summary>Output only. The timestamp of the conversion event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionDateTime")]
        public virtual string ConversionDateTime { get; set; }

        /// <summary>Output only. The timestamp of the last time the conversion was modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionLastModifiedDateTime")]
        public virtual string ConversionLastModifiedDateTime { get; set; }

        /// <summary>
        /// Output only. The quantity of items recorded by the conversion, as determined by the qty url parameter. The
        /// advertiser is responsible for dynamically populating the parameter (such as number of items sold in the
        /// conversion), otherwise it defaults to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionQuantity")]
        public virtual System.Nullable<long> ConversionQuantity { get; set; }

        /// <summary>
        /// Output only. The adjusted revenue in micros for the conversion event. This will always be in the currency of
        /// the serving account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionRevenueMicros")]
        public virtual System.Nullable<long> ConversionRevenueMicros { get; set; }

        /// <summary>Output only. The timestamp of the visit that the conversion is attributed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionVisitDateTime")]
        public virtual string ConversionVisitDateTime { get; set; }

        /// <summary>
        /// Output only. Search Ads 360 criterion ID. A value of 0 indicates that the criterion is unattributed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criterionId")]
        public virtual System.Nullable<long> CriterionId { get; set; }

        /// <summary>Output only. The Floodlight order ID provided by the advertiser for the conversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightOrderId")]
        public virtual string FloodlightOrderId { get; set; }

        /// <summary>
        /// Output only. The original, unchanged revenue associated with the Floodlight event (in the currency of the
        /// current report), before Floodlight currency instruction modifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightOriginalRevenue")]
        public virtual System.Nullable<long> FloodlightOriginalRevenue { get; set; }

        /// <summary>Output only. The ID of the conversion</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Output only. The Search Ads 360 inventory account ID containing the product that was clicked on. Search Ads
        /// 360 generates this ID when you link an inventory account in Search Ads 360.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<long> MerchantId { get; set; }

        /// <summary>Output only. The sales channel of the product that was clicked on: Online or Local.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productChannel")]
        public virtual string ProductChannel { get; set; }

        /// <summary>
        /// Output only. The country (ISO-3166-format) registered for the inventory feed that contains the product
        /// clicked on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCountryCode")]
        public virtual string ProductCountryCode { get; set; }

        /// <summary>Output only. The ID of the product clicked on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Output only. The language (ISO-639-1) that has been set for the Merchant Center feed containing data about
        /// the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLanguageCode")]
        public virtual string ProductLanguageCode { get; set; }

        /// <summary>
        /// Output only. The store in the Local Inventory Ad that was clicked on. This should match the store IDs used
        /// in your local products feed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productStoreId")]
        public virtual string ProductStoreId { get; set; }

        /// <summary>
        /// Output only. The resource name of the conversion. Conversion resource names have the form:
        /// `customers/{customer_id}/conversions/{ad_group_id}~{criterion_id}~{ds_conversion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the conversion, either ENABLED or REMOVED..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. The Search Ads 360 visit ID that the conversion is attributed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitId")]
        public virtual System.Nullable<long> VisitId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A conversion action.</summary>
    public class GoogleAdsSearchads360V0ResourcesConversionAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App ID for an app conversion action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Settings related to this conversion action's attribution model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionModelSettings")]
        public virtual GoogleAdsSearchads360V0ResourcesConversionActionAttributionModelSettings AttributionModelSettings { get; set; }

        /// <summary>The category of conversions reported for this conversion action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// The maximum number of days that may elapse between an interaction (for example, a click) and a conversion
        /// event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughLookbackWindowDays")]
        public virtual System.Nullable<long> ClickThroughLookbackWindowDays { get; set; }

        /// <summary>Output only. Timestamp of the Floodlight activity's creation, formatted in ISO 8601.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>Output only. Floodlight settings for Floodlight conversion types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightSettings")]
        public virtual GoogleAdsSearchads360V0ResourcesConversionActionFloodlightSettings FloodlightSettings { get; set; }

        /// <summary>Output only. The ID of the conversion action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Whether this conversion action should be included in the "client_account_conversions" metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeInClientAccountConversionsMetric")]
        public virtual System.Nullable<bool> IncludeInClientAccountConversionsMetric { get; set; }

        /// <summary>
        /// Output only. Whether this conversion action should be included in the "conversions" metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeInConversionsMetric")]
        public virtual System.Nullable<bool> IncludeInConversionsMetric { get; set; }

        /// <summary>
        /// The name of the conversion action. This field is required and should not be empty when creating new
        /// conversion actions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The resource name of the conversion action owner customer, or null if this is a system-defined
        /// conversion action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomer")]
        public virtual string OwnerCustomer { get; set; }

        /// <summary>
        /// If a conversion action's primary_for_goal bit is false, the conversion action is non-biddable for all
        /// campaigns regardless of their customer conversion goal or campaign conversion goal. However, custom
        /// conversion goals do not respect primary_for_goal, so if a campaign has a custom conversion goal configured
        /// with a primary_for_goal = false conversion action, that conversion action is still biddable. By default,
        /// primary_for_goal will be true if not set. In V9, primary_for_goal can only be set to false after creation
        /// through an 'update' operation because it's not declared as optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryForGoal")]
        public virtual System.Nullable<bool> PrimaryForGoal { get; set; }

        /// <summary>
        /// Immutable. The resource name of the conversion action. Conversion action resource names have the form:
        /// `customers/{customer_id}/conversionActions/{conversion_action_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The status of this conversion action for conversion event accrual.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Immutable. The type of this conversion action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Settings related to the value for conversion events associated with this conversion action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueSettings")]
        public virtual GoogleAdsSearchads360V0ResourcesConversionActionValueSettings ValueSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings related to this conversion action's attribution model.</summary>
    public class GoogleAdsSearchads360V0ResourcesConversionActionAttributionModelSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The attribution model type of this conversion action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionModel")]
        public virtual string AttributionModel { get; set; }

        /// <summary>Output only. The status of the data-driven attribution model for the conversion action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDrivenModelStatus")]
        public virtual string DataDrivenModelStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings related to a Floodlight conversion action.</summary>
    public class GoogleAdsSearchads360V0ResourcesConversionActionFloodlightSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. String used to identify a Floodlight activity group when reporting conversions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityGroupTag")]
        public virtual string ActivityGroupTag { get; set; }

        /// <summary>Output only. ID of the Floodlight activity in DoubleClick Campaign Manager (DCM).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityId")]
        public virtual System.Nullable<long> ActivityId { get; set; }

        /// <summary>Output only. String used to identify a Floodlight activity when reporting conversions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityTag")]
        public virtual string ActivityTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings related to the value for conversion events associated with this conversion action.</summary>
    public class GoogleAdsSearchads360V0ResourcesConversionActionValueSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Controls whether the default value and default currency code are used in place of the value and currency
        /// code specified in conversion events for this conversion action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alwaysUseDefaultValue")]
        public virtual System.Nullable<bool> AlwaysUseDefaultValue { get; set; }

        /// <summary>
        /// The currency code to use when conversion events for this conversion action are sent with an invalid or
        /// missing currency code, or when this conversion action is configured to always use the default value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultCurrencyCode")]
        public virtual string DefaultCurrencyCode { get; set; }

        /// <summary>
        /// The value to use when conversion events for this conversion action are sent with an invalid, disallowed or
        /// missing value, or when this conversion action is configured to always use the default value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual System.Nullable<double> DefaultValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A conversion custom variable. See "About custom Floodlight metrics and dimensions in the new Search Ads 360" at
    /// https://support.google.com/sa360/answer/13567857
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesConversionCustomVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Cardinality of the conversion custom variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardinality")]
        public virtual string Cardinality { get; set; }

        /// <summary>Output only. The IDs of custom columns that use this conversion custom variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customColumnIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CustomColumnIds { get; set; }

        /// <summary>Output only. Family of the conversion custom variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family { get; set; }

        /// <summary>Output only. Fields for Search Ads 360 floodlight conversion custom variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightConversionCustomVariableInfo")]
        public virtual GoogleAdsSearchads360V0ResourcesConversionCustomVariableFloodlightConversionCustomVariableInfo FloodlightConversionCustomVariableInfo { get; set; }

        /// <summary>Output only. The ID of the conversion custom variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Required. The name of the conversion custom variable. Name should be unique. The maximum length of name is
        /// 100 characters. There should not be any extra spaces before and after.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The resource name of the customer that owns the conversion custom variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCustomer")]
        public virtual string OwnerCustomer { get; set; }

        /// <summary>
        /// Immutable. The resource name of the conversion custom variable. Conversion custom variable resource names
        /// have the form: `customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The status of the conversion custom variable for conversion event accrual.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Required. Immutable. The tag of the conversion custom variable. Tag should be unique and consist of a "u"
        /// character directly followed with a number less than ormequal to 100. For example: "u4".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information for Search Ads 360 Floodlight Conversion Custom Variables.</summary>
    public class GoogleAdsSearchads360V0ResourcesConversionCustomVariableFloodlightConversionCustomVariableInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Floodlight variable data type defined in Search Ads 360.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightVariableDataType")]
        public virtual string FloodlightVariableDataType { get; set; }

        /// <summary>Output only. Floodlight variable type defined in Search Ads 360.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floodlightVariableType")]
        public virtual string FloodlightVariableType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of customer-wide settings related to Search Ads 360 Conversion Tracking.</summary>
    public class GoogleAdsSearchads360V0ResourcesConversionTrackingSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the customer has accepted customer data terms. If using cross-account conversion
        /// tracking, this value is inherited from the manager. This field is read-only. For more information, see
        /// https://support.google.com/adspolicy/answer/7475709.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptedCustomerDataTerms")]
        public virtual System.Nullable<bool> AcceptedCustomerDataTerms { get; set; }

        /// <summary>
        /// Output only. The conversion tracking id used for this account. This id doesn't indicate whether the customer
        /// uses conversion tracking (conversion_tracking_status does). This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionTrackingId")]
        public virtual System.Nullable<long> ConversionTrackingId { get; set; }

        /// <summary>
        /// Output only. Conversion tracking status. It indicates whether the customer is using conversion tracking, and
        /// who is the conversion tracking owner of this customer. If this customer is using cross-account conversion
        /// tracking, the value returned will differ based on the `login-customer-id` of the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionTrackingStatus")]
        public virtual string ConversionTrackingStatus { get; set; }

        /// <summary>
        /// Output only. The conversion tracking id of the customer's manager. This is set when the customer is opted
        /// into cross-account conversion tracking, and it overrides conversion_tracking_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossAccountConversionTrackingId")]
        public virtual System.Nullable<long> CrossAccountConversionTrackingId { get; set; }

        /// <summary>
        /// Output only. Whether the customer is opted-in for enhanced conversions for leads. If using cross-account
        /// conversion tracking, this value is inherited from the manager. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enhancedConversionsForLeadsEnabled")]
        public virtual System.Nullable<bool> EnhancedConversionsForLeadsEnabled { get; set; }

        /// <summary>
        /// Output only. The resource name of the customer where conversions are created and managed. This field is
        /// read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsConversionCustomer")]
        public virtual string GoogleAdsConversionCustomer { get; set; }

        /// <summary>
        /// Output only. The conversion tracking id of the customer's manager. This is set when the customer is opted
        /// into conversion tracking, and it overrides conversion_tracking_id. This field can only be managed through
        /// the Google Ads UI. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAdsCrossAccountConversionTrackingId")]
        public virtual System.Nullable<long> GoogleAdsCrossAccountConversionTrackingId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A custom column. See Search Ads 360 custom column at https://support.google.com/sa360/answer/9633916
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCustomColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. User-defined description of the custom column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. ID of the custom column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Output only. User-defined name of the custom column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. True when the custom column is available to be used in the query of SearchAds360Service.Search
        /// and SearchAds360Service.SearchStream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryable")]
        public virtual System.Nullable<bool> Queryable { get; set; }

        /// <summary>
        /// Output only. The list of the referenced system columns of this custom column. For example, A custom column
        /// "sum of impressions and clicks" has referenced system columns of {"metrics.clicks", "metrics.impressions"}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencedSystemColumns")]
        public virtual System.Collections.Generic.IList<string> ReferencedSystemColumns { get; set; }

        /// <summary>Output only. True when the custom column is referring to one or more attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencesAttributes")]
        public virtual System.Nullable<bool> ReferencesAttributes { get; set; }

        /// <summary>Output only. True when the custom column is referring to one or more metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencesMetrics")]
        public virtual System.Nullable<bool> ReferencesMetrics { get; set; }

        /// <summary>Output only. How the result value of the custom column should be interpreted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderType")]
        public virtual string RenderType { get; set; }

        /// <summary>
        /// Immutable. The resource name of the custom column. Custom column resource names have the form:
        /// `customers/{customer_id}/customColumns/{custom_column_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The type of the result value of the custom column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A customer.</summary>
    public class GoogleAdsSearchads360V0ResourcesCustomer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The account level of the customer: Manager, Sub-manager, Associate manager, Service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountLevel")]
        public virtual string AccountLevel { get; set; }

        /// <summary>Output only. Account status, for example, Enabled, Paused, Removed, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountStatus")]
        public virtual string AccountStatus { get; set; }

        /// <summary>
        /// Output only. Engine account type, for example, Google Ads, Microsoft Advertising, Yahoo Japan, Baidu,
        /// Facebook, Engine Track, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountType")]
        public virtual string AccountType { get; set; }

        /// <summary>Output only. The descriptive name of the associate manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associateManagerDescriptiveName")]
        public virtual string AssociateManagerDescriptiveName { get; set; }

        /// <summary>
        /// Output only. The customer ID of the associate manager. A 0 value indicates that the customer has no SA360
        /// associate manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associateManagerId")]
        public virtual System.Nullable<long> AssociateManagerId { get; set; }

        /// <summary>Whether auto-tagging is enabled for the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoTaggingEnabled")]
        public virtual System.Nullable<bool> AutoTaggingEnabled { get; set; }

        /// <summary>Output only. Conversion tracking setting for a customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionTrackingSetting")]
        public virtual GoogleAdsSearchads360V0ResourcesConversionTrackingSetting ConversionTrackingSetting { get; set; }

        /// <summary>
        /// Output only. The timestamp when this customer was created. The timestamp is in the customer's time zone and
        /// in "yyyy-MM-dd HH:mm:ss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTime { get; set; }

        /// <summary>
        /// Immutable. The currency in which the account operates. A subset of the currency codes from the ISO 4217
        /// standard is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Optional, non-unique descriptive name of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptiveName")]
        public virtual string DescriptiveName { get; set; }

        /// <summary>Output only. DoubleClick Campaign Manager (DCM) setting for a manager customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleClickCampaignManagerSetting")]
        public virtual GoogleAdsSearchads360V0ResourcesDoubleClickCampaignManagerSetting DoubleClickCampaignManagerSetting { get; set; }

        /// <summary>Output only. ID of the account in the external engine account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineId")]
        public virtual string EngineId { get; set; }

        /// <summary>The URL template for appending params to the final URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalUrlSuffix")]
        public virtual string FinalUrlSuffix { get; set; }

        /// <summary>Output only. The ID of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Output only. The datetime when this customer was last modified. The datetime is in the customer's time zone
        /// and in "yyyy-MM-dd HH:mm:ss.ssssss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual string LastModifiedTime { get; set; }

        /// <summary>Output only. Whether the customer is a manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manager")]
        public virtual System.Nullable<bool> Manager { get; set; }

        /// <summary>Output only. The descriptive name of the manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managerDescriptiveName")]
        public virtual string ManagerDescriptiveName { get; set; }

        /// <summary>
        /// Output only. The customer ID of the manager. A 0 value indicates that the customer has no SA360 manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managerId")]
        public virtual System.Nullable<long> ManagerId { get; set; }

        /// <summary>
        /// Immutable. The resource name of the customer. Customer resource names have the form:
        /// `customers/{customer_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. The descriptive name of the sub manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subManagerDescriptiveName")]
        public virtual string SubManagerDescriptiveName { get; set; }

        /// <summary>
        /// Output only. The customer ID of the sub manager. A 0 value indicates that the customer has no sub SA360
        /// manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subManagerId")]
        public virtual System.Nullable<long> SubManagerId { get; set; }

        /// <summary>Immutable. The local timezone ID of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The URL template for constructing a tracking URL out of parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingUrlTemplate")]
        public virtual string TrackingUrlTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link between a customer and an asset.</summary>
    public class GoogleAdsSearchads360V0ResourcesCustomerAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The asset which is linked to the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>
        /// Immutable. The resource name of the customer asset. CustomerAsset resource names have the form:
        /// `customers/{customer_id}/customerAssets/{asset_id}~{field_type}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Status of the customer asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CustomerAssetSet is the linkage between a customer and an asset set. Adding a CustomerAssetSet links an asset
    /// set with a customer.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCustomerAssetSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The asset set which is linked to the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSet")]
        public virtual string AssetSet { get; set; }

        /// <summary>Immutable. The customer to which this asset set is linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual string Customer { get; set; }

        /// <summary>
        /// Immutable. The resource name of the customer asset set. Asset set asset resource names have the form:
        /// `customers/{customer_id}/customerAssetSets/{asset_set_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the customer asset set asset. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A link between the given customer and a client customer. CustomerClients only exist for manager customers. All
    /// direct and indirect client customers are included, as well as the manager itself.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesCustomerClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource names of the labels owned by the requesting customer that are applied to the
        /// client customer. Label resource names have the form: `customers/{customer_id}/labels/{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedLabels")]
        public virtual System.Collections.Generic.IList<string> AppliedLabels { get; set; }

        /// <summary>
        /// Output only. The resource name of the client-customer which is linked to the given customer. Read only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCustomer")]
        public virtual string ClientCustomer { get; set; }

        /// <summary>Output only. Currency code (for example, 'USD', 'EUR') for the client. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Output only. Descriptive name for the client. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptiveName")]
        public virtual string DescriptiveName { get; set; }

        /// <summary>Output only. Specifies whether this is a hidden account. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hidden")]
        public virtual System.Nullable<bool> Hidden { get; set; }

        /// <summary>Output only. The ID of the client customer. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Output only. Distance between given customer and client. For self link, the level value will be 0. Read
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual System.Nullable<long> Level { get; set; }

        /// <summary>Output only. Identifies if the client is a manager. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manager")]
        public virtual System.Nullable<bool> Manager { get; set; }

        /// <summary>
        /// Output only. The resource name of the customer client. CustomerClient resource names have the form:
        /// `customers/{customer_id}/customerClients/{client_customer_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. The status of the client customer. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Identifies if the client is a test account. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testAccount")]
        public virtual System.Nullable<bool> TestAccount { get; set; }

        /// <summary>
        /// Output only. Common Locale Data Repository (CLDR) string representation of the time zone of the client, for
        /// example, America/Los_Angeles. Read only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents customer-manager link relationship.</summary>
    public class GoogleAdsSearchads360V0ResourcesCustomerManagerLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The manager customer linked to the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managerCustomer")]
        public virtual string ManagerCustomer { get; set; }

        /// <summary>Output only. ID of the customer-manager link. This field is read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managerLinkId")]
        public virtual System.Nullable<long> ManagerLinkId { get; set; }

        /// <summary>
        /// Immutable. Name of the resource. CustomerManagerLink resource names have the form:
        /// `customers/{customer_id}/customerManagerLinks/{manager_customer_id}~{manager_link_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. The timestamp when the CustomerManagerLink was created. The timestamp is in the customer's time
        /// zone and in "yyyy-MM-dd HH:mm:ss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>Status of the link between the customer and the manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DoubleClick Campaign Manager (DCM) setting for a manager customer.</summary>
    public class GoogleAdsSearchads360V0ResourcesDoubleClickCampaignManagerSetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. ID of the Campaign Manager advertiser associated with this customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Nullable<long> AdvertiserId { get; set; }

        /// <summary>Output only. ID of the Campaign Manager network associated with this customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual System.Nullable<long> NetworkId { get; set; }

        /// <summary>
        /// Output only. Time zone of the Campaign Manager network associated with this customer in IANA Time Zone
        /// Database format, such as America/New_York.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dynamic search ads search term view.</summary>
    public class GoogleAdsSearchads360V0ResourcesDynamicSearchAdsSearchTermView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The dynamically selected landing page URL of the impression. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landingPage")]
        public virtual string LandingPage { get; set; }

        /// <summary>
        /// Output only. The resource name of the dynamic search ads search term view. Dynamic search ads search term
        /// view resource names have the form:
        /// `customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A gender view. The gender_view resource reflects the effective serving state, rather than what criteria were
    /// added. An ad group without gender criteria by default shows to all genders, so all genders appear in gender_view
    /// with stats.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesGenderView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the gender view. Gender view resource names have the form:
        /// `customers/{customer_id}/genderViews/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A geo target constant.</summary>
    public class GoogleAdsSearchads360V0ResourcesGeoTargetConstant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The fully qualified English name, consisting of the target's name and that of its parent and
        /// country.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>Output only. The ISO-3166-1 alpha-2 country code that is associated with the target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>Output only. The ID of the geo target constant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Output only. Geo target constant English name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The resource name of the parent geo target constant. Geo target constant resource names have
        /// the form: `geoTargetConstants/{parent_geo_target_constant_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentGeoTarget")]
        public virtual string ParentGeoTarget { get; set; }

        /// <summary>
        /// Output only. The resource name of the geo target constant. Geo target constant resource names have the form:
        /// `geoTargetConstants/{geo_target_constant_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. Geo target constant status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Geo target constant target type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetType")]
        public virtual string TargetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A keyword view.</summary>
    public class GoogleAdsSearchads360V0ResourcesKeywordView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the keyword view. Keyword view resource names have the form:
        /// `customers/{customer_id}/keywordViews/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A label.</summary>
    public class GoogleAdsSearchads360V0ResourcesLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. ID of the label. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// The name of the label. This field is required and should not be empty when creating a new label. The length
        /// of this string should be between 1 and 80, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. Name of the resource. Label resource names have the form:
        /// `customers/{customer_id}/labels/{label_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. Status of the label. Read only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>A type of label displaying text on a colored background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textLabel")]
        public virtual GoogleAdsSearchads360V0CommonTextLabel TextLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A language.</summary>
    public class GoogleAdsSearchads360V0ResourcesLanguageConstant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The language code, for example, "en_US", "en_AU", "es", "fr", etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Output only. The ID of the language constant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Output only. The full name of the language in English, for example, "English (US)", "Spanish", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The resource name of the language constant. Language constant resource names have the form:
        /// `languageConstants/{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. Whether the language is targetable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetable")]
        public virtual System.Nullable<bool> Targetable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Listing dimensions for the asset group listing group filter.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bidding category of a product offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategory")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductBiddingCategory ProductBiddingCategory { get; set; }

        /// <summary>Brand of a product offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBrand")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductBrand ProductBrand { get; set; }

        /// <summary>Locality of a product offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productChannel")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductChannel ProductChannel { get; set; }

        /// <summary>Condition of a product offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCondition")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductCondition ProductCondition { get; set; }

        /// <summary>Custom attribute of a product offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCustomAttribute")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductCustomAttribute ProductCustomAttribute { get; set; }

        /// <summary>Item id of a product offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productItemId")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductItemId ProductItemId { get; set; }

        /// <summary>Type of a product offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productType")]
        public virtual GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductType ProductType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The path defining of dimensions defining a listing group filter.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The complete path of dimensions through the listing group filter hierarchy (excluding the root
        /// node) to this listing group filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ResourcesListingGroupFilterDimension> Dimensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// One element of a bidding category at a certain level. Top-level categories are at level 1, their children at
    /// level 2, and so on. We currently support up to 5 levels. The user must specify a dimension type that indicates
    /// the level of the category. All cases of the same subdivision must have the same dimension type (category level).
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductBiddingCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ID of the product bidding category. This ID is equivalent to the google_product_category ID as described in
        /// this article: https://support.google.com/merchants/answer/6324436
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Indicates the level of the category in the taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Brand of the product.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductBrand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String value of the product brand.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Locality of a product offer.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value of the locality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Condition of a product offer.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom attribute of a product offer.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductCustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the index of the custom attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual string Index { get; set; }

        /// <summary>String value of the product custom attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Item id of a product offer.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductItemId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value of the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Type of a product offer.</summary>
    public class GoogleAdsSearchads360V0ResourcesListingGroupFilterDimensionProductType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Level of the type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>Value of the type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A location view summarizes the performance of campaigns by a Location criterion.</summary>
    public class GoogleAdsSearchads360V0ResourcesLocationView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the location view. Location view resource names have the form:
        /// `customers/{customer_id}/locationViews/{campaign_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Product Bidding Category.</summary>
    public class GoogleAdsSearchads360V0ResourcesProductBiddingCategoryConstant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Two-letter upper-case country code of the product bidding category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>
        /// Output only. ID of the product bidding category. This ID is equivalent to the google_product_category ID as
        /// described in this article: https://support.google.com/merchants/answer/6324436.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Output only. Language code of the product bidding category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Output only. Level of the product bidding category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>
        /// Output only. Display value of the product bidding category localized according to language_code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedName")]
        public virtual string LocalizedName { get; set; }

        /// <summary>Output only. Resource name of the parent product bidding category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategoryConstantParent")]
        public virtual string ProductBiddingCategoryConstantParent { get; set; }

        /// <summary>
        /// Output only. The resource name of the product bidding category. Product bidding category resource names have
        /// the form: `productBiddingCategoryConstants/{country_code}~{level}~{id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. Status of the product bidding category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product group view.</summary>
    public class GoogleAdsSearchads360V0ResourcesProductGroupView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the product group view. Product group view resource names have the form:
        /// `customers/{customer_id}/productGroupViews/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A field or resource (artifact) used by SearchAds360Service.</summary>
    public class GoogleAdsSearchads360V0ResourcesSearchAds360Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The names of all resources that are selectable with the described artifact. Fields from these
        /// resources do not segment metrics when included in search queries. This field is only set for artifacts whose
        /// category is RESOURCE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeResources")]
        public virtual System.Collections.Generic.IList<string> AttributeResources { get; set; }

        /// <summary>Output only. The category of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Output only. This field determines the operators that can be used with the artifact in WHERE clauses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// Output only. Values the artifact can assume if it is a field of type ENUM. This field is only set for
        /// artifacts of category SEGMENT or ATTRIBUTE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValues")]
        public virtual System.Collections.Generic.IList<string> EnumValues { get; set; }

        /// <summary>Output only. Whether the artifact can be used in a WHERE clause in search queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterable")]
        public virtual System.Nullable<bool> Filterable { get; set; }

        /// <summary>Output only. Whether the field artifact is repeated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRepeated")]
        public virtual System.Nullable<bool> IsRepeated { get; set; }

        /// <summary>
        /// Output only. This field lists the names of all metrics that are selectable with the described artifact when
        /// it is used in the FROM clause. It is only set for artifacts whose category is RESOURCE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>Output only. The name of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The resource name of the artifact. Artifact resource names have the form:
        /// `SearchAds360Fields/{name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. This field lists the names of all artifacts, whether a segment or another resource, that
        /// segment metrics when included in search queries and when the described artifact is used in the FROM clause.
        /// It is only set for artifacts whose category is RESOURCE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<string> Segments { get; set; }

        /// <summary>Output only. Whether the artifact can be used in a SELECT clause in search queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectable")]
        public virtual System.Nullable<bool> Selectable { get; set; }

        /// <summary>
        /// Output only. The names of all resources, segments, and metrics that are selectable with the described
        /// artifact.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectableWith")]
        public virtual System.Collections.Generic.IList<string> SelectableWith { get; set; }

        /// <summary>Output only. Whether the artifact can be used in a ORDER BY clause in search queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortable")]
        public virtual System.Nullable<bool> Sortable { get; set; }

        /// <summary>Output only. The URL of proto describing the artifact's data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeUrl")]
        public virtual string TypeUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Shopping performance view. Provides Shopping campaign statistics aggregated at several product dimension levels.
    /// Product dimension values from Merchant Center such as brand, category, custom attributes, product condition and
    /// product type will reflect the state of each dimension as of the date and time when the corresponding event was
    /// recorded.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesShoppingPerformanceView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the Shopping performance view. Shopping performance view resource names
        /// have the form: `customers/{customer_id}/shoppingPerformanceView`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user list. This is a list of users a customer may target.</summary>
    public class GoogleAdsSearchads360V0ResourcesUserList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Id of the user list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Name of this user list. Depending on its access_reason, the user list name may not be unique (for example,
        /// if access_reason=SHARED)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The resource name of the user list. User list resource names have the form:
        /// `customers/{customer_id}/userLists/{user_list_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. Type of this list. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A user location view. User Location View includes all metrics aggregated at the country level, one row per
    /// country. It reports metrics at the actual physical location of the user by targeted or not targeted location. If
    /// other segment fields are used, you may get more than one row per country.
    /// </summary>
    public class GoogleAdsSearchads360V0ResourcesUserLocationView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Criterion Id for the country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCriterionId")]
        public virtual System.Nullable<long> CountryCriterionId { get; set; }

        /// <summary>
        /// Output only. The resource name of the user location view. UserLocation view resource names have the form:
        /// `customers/{customer_id}/userLocationViews/{country_criterion_id}~{targeting_location}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Output only. Indicates whether location was targeted or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingLocation")]
        public virtual System.Nullable<bool> TargetingLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A visit.</summary>
    public class GoogleAdsSearchads360V0ResourcesVisit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Ad ID. A value of 0 indicates that the ad is unattributed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adId")]
        public virtual System.Nullable<long> AdId { get; set; }

        /// <summary>Output only. Asset field type of the visit event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetFieldType")]
        public virtual string AssetFieldType { get; set; }

        /// <summary>Output only. ID of the asset which was interacted with during the visit event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetId")]
        public virtual System.Nullable<long> AssetId { get; set; }

        /// <summary>
        /// Output only. A unique string for each visit that is passed to the landing page as the click id URL
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickId")]
        public virtual string ClickId { get; set; }

        /// <summary>
        /// Output only. Search Ads 360 keyword ID. A value of 0 indicates that the keyword is unattributed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criterionId")]
        public virtual System.Nullable<long> CriterionId { get; set; }

        /// <summary>Output only. The ID of the visit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// Output only. The Search Ads 360 inventory account ID containing the product that was clicked on. Search Ads
        /// 360 generates this ID when you link an inventory account in Search Ads 360.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual System.Nullable<long> MerchantId { get; set; }

        /// <summary>Output only. The sales channel of the product that was clicked on: Online or Local.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productChannel")]
        public virtual string ProductChannel { get; set; }

        /// <summary>
        /// Output only. The country (ISO-3166 format) registered for the inventory feed that contains the product
        /// clicked on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCountryCode")]
        public virtual string ProductCountryCode { get; set; }

        /// <summary>Output only. The ID of the product clicked on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Output only. The language (ISO-639-1) that has been set for the Merchant Center feed containing data about
        /// the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLanguageCode")]
        public virtual string ProductLanguageCode { get; set; }

        /// <summary>
        /// Output only. The store in the Local Inventory Ad that was clicked on. This should match the store IDs used
        /// in your local products feed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productStoreId")]
        public virtual string ProductStoreId { get; set; }

        /// <summary>
        /// Output only. The resource name of the visit. Visit resource names have the form:
        /// `customers/{customer_id}/visits/{ad_group_id}~{criterion_id}~{ds_visit_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. The timestamp of the visit event. The timestamp is in the customer's time zone and in
        /// "yyyy-MM-dd HH:mm:ss" format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitDateTime")]
        public virtual string VisitDateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A webpage view.</summary>
    public class GoogleAdsSearchads360V0ResourcesWebpageView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the webpage view. Webpage view resource names have the form:
        /// `customers/{customer_id}/webpageViews/{ad_group_id}~{criterion_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for conversion custom dimension header.</summary>
    public class GoogleAdsSearchads360V0ServicesConversionCustomDimensionHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conversion custom dimension ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>The user defined name of the conversion custom dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for conversion custom metric header.</summary>
    public class GoogleAdsSearchads360V0ServicesConversionCustomMetricHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conversion custom metric ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>The user defined name of the conversion custom metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for custom column header.</summary>
    public class GoogleAdsSearchads360V0ServicesCustomColumnHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The custom column ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>The user defined name of the custom column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>True when the custom column references metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencesMetrics")]
        public virtual System.Nullable<bool> ReferencesMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CustomerService.ListAccessibleCustomers.</summary>
    public class GoogleAdsSearchads360V0ServicesListAccessibleCustomersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of customers directly accessible by the user authenticating the call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNames")]
        public virtual System.Collections.Generic.IList<string> ResourceNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for fetching all custom columns associated with a customer.</summary>
    public class GoogleAdsSearchads360V0ServicesListCustomColumnsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CustomColumns owned by the provided customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customColumns")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ResourcesCustomColumn> CustomColumns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for raw event conversion dimension header.</summary>
    public class GoogleAdsSearchads360V0ServicesRawEventConversionDimensionHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conversion custom variable ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>The user defined name of the raw event dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for raw event conversion metric header.</summary>
    public class GoogleAdsSearchads360V0ServicesRawEventConversionMetricHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conversion custom variable ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>The user defined name of the raw event metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A returned row from the query.</summary>
    public class GoogleAdsSearchads360V0ServicesSearchAds360Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accessible bidding strategy referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibleBiddingStrategy")]
        public virtual GoogleAdsSearchads360V0ResourcesAccessibleBiddingStrategy AccessibleBiddingStrategy { get; set; }

        /// <summary>The ad group referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroup")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroup AdGroup { get; set; }

        /// <summary>The ad referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAd")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupAd AdGroupAd { get; set; }

        /// <summary>The ad group ad effective label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAdEffectiveLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupAdEffectiveLabel AdGroupAdEffectiveLabel { get; set; }

        /// <summary>The ad group ad label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAdLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupAdLabel AdGroupAdLabel { get; set; }

        /// <summary>The ad group asset referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAsset")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupAsset AdGroupAsset { get; set; }

        /// <summary>The ad group asset set referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAssetSet")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupAssetSet AdGroupAssetSet { get; set; }

        /// <summary>The ad group audience view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupAudienceView")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupAudienceView AdGroupAudienceView { get; set; }

        /// <summary>The bid modifier referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupBidModifier")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupBidModifier AdGroupBidModifier { get; set; }

        /// <summary>The criterion referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupCriterion")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupCriterion AdGroupCriterion { get; set; }

        /// <summary>The ad group criterion effective label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupCriterionEffectiveLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupCriterionEffectiveLabel AdGroupCriterionEffectiveLabel { get; set; }

        /// <summary>The ad group criterion label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupCriterionLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupCriterionLabel AdGroupCriterionLabel { get; set; }

        /// <summary>The ad group effective label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupEffectiveLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupEffectiveLabel AdGroupEffectiveLabel { get; set; }

        /// <summary>The ad group label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adGroupLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesAdGroupLabel AdGroupLabel { get; set; }

        /// <summary>The age range view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageRangeView")]
        public virtual GoogleAdsSearchads360V0ResourcesAgeRangeView AgeRangeView { get; set; }

        /// <summary>The asset referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual GoogleAdsSearchads360V0ResourcesAsset Asset { get; set; }

        /// <summary>The asset group referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroup")]
        public virtual GoogleAdsSearchads360V0ResourcesAssetGroup AssetGroup { get; set; }

        /// <summary>The asset group asset referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroupAsset")]
        public virtual GoogleAdsSearchads360V0ResourcesAssetGroupAsset AssetGroupAsset { get; set; }

        /// <summary>The asset group listing group filter referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroupListingGroupFilter")]
        public virtual GoogleAdsSearchads360V0ResourcesAssetGroupListingGroupFilter AssetGroupListingGroupFilter { get; set; }

        /// <summary>The asset group signal referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroupSignal")]
        public virtual GoogleAdsSearchads360V0ResourcesAssetGroupSignal AssetGroupSignal { get; set; }

        /// <summary>The asset group top combination view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetGroupTopCombinationView")]
        public virtual GoogleAdsSearchads360V0ResourcesAssetGroupTopCombinationView AssetGroupTopCombinationView { get; set; }

        /// <summary>The asset set referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSet")]
        public virtual GoogleAdsSearchads360V0ResourcesAssetSet AssetSet { get; set; }

        /// <summary>The asset set asset referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSetAsset")]
        public virtual GoogleAdsSearchads360V0ResourcesAssetSetAsset AssetSetAsset { get; set; }

        /// <summary>The Audience referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual GoogleAdsSearchads360V0ResourcesAudience Audience { get; set; }

        /// <summary>The bidding strategy referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biddingStrategy")]
        public virtual GoogleAdsSearchads360V0ResourcesBiddingStrategy BiddingStrategy { get; set; }

        /// <summary>The campaign referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaign")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaign Campaign { get; set; }

        /// <summary>The campaign asset referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignAsset")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignAsset CampaignAsset { get; set; }

        /// <summary>The campaign asset set referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignAssetSet")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignAssetSet CampaignAssetSet { get; set; }

        /// <summary>The campaign audience view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignAudienceView")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignAudienceView CampaignAudienceView { get; set; }

        /// <summary>The campaign budget referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignBudget")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignBudget CampaignBudget { get; set; }

        /// <summary>The campaign criterion referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignCriterion")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignCriterion CampaignCriterion { get; set; }

        /// <summary>The campaign effective label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignEffectiveLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignEffectiveLabel CampaignEffectiveLabel { get; set; }

        /// <summary>The campaign label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaignLabel")]
        public virtual GoogleAdsSearchads360V0ResourcesCampaignLabel CampaignLabel { get; set; }

        /// <summary>The cart data sales view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cartDataSalesView")]
        public virtual GoogleAdsSearchads360V0ResourcesCartDataSalesView CartDataSalesView { get; set; }

        /// <summary>The event level conversion referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversion")]
        public virtual GoogleAdsSearchads360V0ResourcesConversion Conversion { get; set; }

        /// <summary>The conversion action referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionAction")]
        public virtual GoogleAdsSearchads360V0ResourcesConversionAction ConversionAction { get; set; }

        /// <summary>The conversion custom variable referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionCustomVariable")]
        public virtual GoogleAdsSearchads360V0ResourcesConversionCustomVariable ConversionCustomVariable { get; set; }

        /// <summary>The custom columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customColumns")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0CommonValue> CustomColumns { get; set; }

        /// <summary>The customer referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual GoogleAdsSearchads360V0ResourcesCustomer Customer { get; set; }

        /// <summary>The customer asset referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerAsset")]
        public virtual GoogleAdsSearchads360V0ResourcesCustomerAsset CustomerAsset { get; set; }

        /// <summary>The customer asset set referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerAssetSet")]
        public virtual GoogleAdsSearchads360V0ResourcesCustomerAssetSet CustomerAssetSet { get; set; }

        /// <summary>The CustomerClient referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerClient")]
        public virtual GoogleAdsSearchads360V0ResourcesCustomerClient CustomerClient { get; set; }

        /// <summary>The CustomerManagerLink referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerManagerLink")]
        public virtual GoogleAdsSearchads360V0ResourcesCustomerManagerLink CustomerManagerLink { get; set; }

        /// <summary>The dynamic search ads search term view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSearchAdsSearchTermView")]
        public virtual GoogleAdsSearchads360V0ResourcesDynamicSearchAdsSearchTermView DynamicSearchAdsSearchTermView { get; set; }

        /// <summary>The gender view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genderView")]
        public virtual GoogleAdsSearchads360V0ResourcesGenderView GenderView { get; set; }

        /// <summary>The geo target constant referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargetConstant")]
        public virtual GoogleAdsSearchads360V0ResourcesGeoTargetConstant GeoTargetConstant { get; set; }

        /// <summary>The keyword view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywordView")]
        public virtual GoogleAdsSearchads360V0ResourcesKeywordView KeywordView { get; set; }

        /// <summary>The label referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual GoogleAdsSearchads360V0ResourcesLabel Label { get; set; }

        /// <summary>The language constant referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageConstant")]
        public virtual GoogleAdsSearchads360V0ResourcesLanguageConstant LanguageConstant { get; set; }

        /// <summary>The location view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationView")]
        public virtual GoogleAdsSearchads360V0ResourcesLocationView LocationView { get; set; }

        /// <summary>The metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual GoogleAdsSearchads360V0CommonMetrics Metrics { get; set; }

        /// <summary>The Product Bidding Category referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productBiddingCategoryConstant")]
        public virtual GoogleAdsSearchads360V0ResourcesProductBiddingCategoryConstant ProductBiddingCategoryConstant { get; set; }

        /// <summary>The product group view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productGroupView")]
        public virtual GoogleAdsSearchads360V0ResourcesProductGroupView ProductGroupView { get; set; }

        /// <summary>The segments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual GoogleAdsSearchads360V0CommonSegments Segments { get; set; }

        /// <summary>The shopping performance view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shoppingPerformanceView")]
        public virtual GoogleAdsSearchads360V0ResourcesShoppingPerformanceView ShoppingPerformanceView { get; set; }

        /// <summary>The user list referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userList")]
        public virtual GoogleAdsSearchads360V0ResourcesUserList UserList { get; set; }

        /// <summary>The user location view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLocationView")]
        public virtual GoogleAdsSearchads360V0ResourcesUserLocationView UserLocationView { get; set; }

        /// <summary>The event level visit referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visit")]
        public virtual GoogleAdsSearchads360V0ResourcesVisit Visit { get; set; }

        /// <summary>The webpage view referenced in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webpageView")]
        public virtual GoogleAdsSearchads360V0ResourcesWebpageView WebpageView { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchAds360FieldService.SearchSearchAds360Fields.</summary>
    public class GoogleAdsSearchads360V0ServicesSearchSearchAds360FieldsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of elements to retrieve in a single page. When too large a page is requested, the server may decide
        /// to further limit the number of returned resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Token of the page to retrieve. If not specified, the first page of results will be returned. Use the value
        /// obtained from `next_page_token` in the previous response in order to request the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>Required. The query string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchAds360FieldService.SearchSearchAds360Fields.</summary>
    public class GoogleAdsSearchads360V0ServicesSearchSearchAds360FieldsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token used to retrieve the next page of results. Pass the content of this string as the
        /// `page_token` attribute of the next request. `next_page_token` is not returned for the last page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of fields that matched the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ResourcesSearchAds360Field> Results { get; set; }

        /// <summary>Total number of results that match the query ignoring the LIMIT clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResultsCount")]
        public virtual System.Nullable<long> TotalResultsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchAds360Service.Search.</summary>
    public class GoogleAdsSearchads360V0ServicesSearchSearchAds360Request : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of elements to retrieve in a single page. When too large a page is requested, the server may decide
        /// to further limit the number of returned resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Token of the page to retrieve. If not specified, the first page of results will be returned. Use the value
        /// obtained from `next_page_token` in the previous response in order to request the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>Required. The query string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// If true, the total number of results that match the query ignoring the LIMIT clause will be included in the
        /// response. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnTotalResultsCount")]
        public virtual System.Nullable<bool> ReturnTotalResultsCount { get; set; }

        /// <summary>
        /// Determines whether a summary row will be returned. By default, summary row is not returned. If requested,
        /// the summary row will be sent in a response by itself after all other query results are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryRowSetting")]
        public virtual string SummaryRowSetting { get; set; }

        /// <summary>If true, the request is validated but not executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchAds360Service.Search.</summary>
    public class GoogleAdsSearchads360V0ServicesSearchSearchAds360Response : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The headers of the conversion custom dimensions in the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionCustomDimensionHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ServicesConversionCustomDimensionHeader> ConversionCustomDimensionHeaders { get; set; }

        /// <summary>The headers of the conversion custom metrics in the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionCustomMetricHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ServicesConversionCustomMetricHeader> ConversionCustomMetricHeaders { get; set; }

        /// <summary>The headers of the custom columns in the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customColumnHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ServicesCustomColumnHeader> CustomColumnHeaders { get; set; }

        /// <summary>FieldMask that represents what fields were requested by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMask")]
        public virtual object FieldMask { get; set; }

        /// <summary>
        /// Pagination token used to retrieve the next page of results. Pass the content of this string as the
        /// `page_token` attribute of the next request. `next_page_token` is not returned for the last page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The headers of the raw event conversion dimensions in the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawEventConversionDimensionHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ServicesRawEventConversionDimensionHeader> RawEventConversionDimensionHeaders { get; set; }

        /// <summary>The headers of the raw event conversion metrics in the results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawEventConversionMetricHeaders")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ServicesRawEventConversionMetricHeader> RawEventConversionMetricHeaders { get; set; }

        /// <summary>The list of rows that matched the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleAdsSearchads360V0ServicesSearchAds360Row> Results { get; set; }

        /// <summary>
        /// Summary row that contains summary of metrics in results. Summary of metrics means aggregation of metrics
        /// across all results, here aggregation could be sum, average, rate, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryRow")]
        public virtual GoogleAdsSearchads360V0ServicesSearchAds360Row SummaryRow { get; set; }

        /// <summary>Total number of results that match the query ignoring the LIMIT clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResultsCount")]
        public virtual System.Nullable<long> TotalResultsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
