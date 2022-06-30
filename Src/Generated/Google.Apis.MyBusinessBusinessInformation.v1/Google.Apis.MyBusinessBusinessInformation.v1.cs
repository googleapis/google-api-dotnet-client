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

namespace Google.Apis.MyBusinessBusinessInformation.v1
{
    /// <summary>The MyBusinessBusinessInformation Service.</summary>
    public class MyBusinessBusinessInformationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MyBusinessBusinessInformationService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MyBusinessBusinessInformationService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Attributes = new AttributesResource(this);
            Categories = new CategoriesResource(this);
            Chains = new ChainsResource(this);
            GoogleLocations = new GoogleLocationsResource(this);
            Locations = new LocationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "mybusinessbusinessinformation";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://mybusinessbusinessinformation.googleapis.com/";
        #else
            "https://mybusinessbusinessinformation.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://mybusinessbusinessinformation.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Attributes resource.</summary>
        public virtual AttributesResource Attributes { get; }

        /// <summary>Gets the Categories resource.</summary>
        public virtual CategoriesResource Categories { get; }

        /// <summary>Gets the Chains resource.</summary>
        public virtual ChainsResource Chains { get; }

        /// <summary>Gets the GoogleLocations resource.</summary>
        public virtual GoogleLocationsResource GoogleLocations { get; }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }
    }

    /// <summary>A base abstract class for MyBusinessBusinessInformation requests.</summary>
    public abstract class MyBusinessBusinessInformationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MyBusinessBusinessInformationBaseServiceRequest instance.</summary>
        protected MyBusinessBusinessInformationBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MyBusinessBusinessInformation parameter list.</summary>
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

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
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
            }

            /// <summary>Creates a new Location that will be owned by the logged in user.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The name of the account in which to create this location.</param>
            public virtual CreateRequest Create(Google.Apis.MyBusinessBusinessInformation.v1.Data.Location body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new Location that will be owned by the logged in user.</summary>
            public class CreateRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Location>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessBusinessInformation.v1.Data.Location body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the account in which to create this location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A unique request ID for the server to detect duplicated requests. We recommend using
                /// UUIDs. Max length is 50 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>
                /// Optional. If true, the request is validated without actually creating the location.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ValidateOnly { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.MyBusinessBusinessInformation.v1.Data.Location Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/locations";

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
                        Pattern = @"^accounts/[^/]+$",
                    });
                    RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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

            /// <summary>Lists the locations for the specified account.</summary>
            /// <param name="parent">
            /// Required. The name of the account to fetch locations from. If the parent Account is of AccountType
            /// PERSONAL, only Locations that are directly owned by the Account are returned, otherwise it will return
            /// all accessible locations from the Account, either directly or indirectly.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the locations for the specified account.</summary>
            public class ListRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the account to fetch locations from. If the parent Account is of AccountType
                /// PERSONAL, only Locations that are directly owned by the Account are returned, otherwise it will
                /// return all accessible locations from the Account, either directly or indirectly.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A filter constraining the locations to return. The response includes only entries that
                /// match the filter. If `filter` is empty, then constraints are applied and all locations (paginated)
                /// are retrieved for the requested account. For more information about valid fields and example usage,
                /// see [Work with Location Data
                /// Guide](https://developers.google.com/my-business/content/location-data#filter_results_when_you_list_locations).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Sorting order for the request. Multiple fields should be comma-separated, following SQL
                /// syntax. The default sorting order is ascending. To specify descending order, a suffix " desc" should
                /// be added. Valid fields to order_by are title and store_code. For example: "title, store_code desc"
                /// or "title" or "store_code desc"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. How many locations to fetch per page. Default value is 10 if not set. Minimum is 1, and
                /// maximum page size is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If specified, it fetches the next `page` of locations. The page token is returned by
                /// previous calls to `ListLocations` when there were more locations than could fit in the requested
                /// page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Required. Read mask to specify what fields will be returned in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadMask { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/locations";

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
                        Pattern = @"^accounts/[^/]+$",
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
                    RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "attributes" collection of methods.</summary>
    public class AttributesResource
    {
        private const string Resource = "attributes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AttributesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Returns the list of attributes that would be available for a location with the given primary category and
        /// country.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Returns the list of attributes that would be available for a location with the given primary category and
        /// country.
        /// </summary>
        public class ListRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.ListAttributeMetadataResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The primary category stable ID to find available attributes. Must be of the format
            /// categories/{category_id}.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("categoryName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CategoryName { get; set; }

            /// <summary>
            /// The BCP 47 code of language to get attribute display names in. If this language is not available, they
            /// will be provided in English.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>How many attributes to include per page. Default is 200, minimum is 1.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>If specified, the next page of attribute metadata is retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Resource name of the location to look up available attributes. If this field is set, category_name,
            /// region_code, language_code and show_all are not required and must not be set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>The ISO 3166-1 alpha-2 country code to find available attributes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>
            /// Metadata for all available attributes are returned when this field is set to true, disregarding parent
            /// and category_name fields. language_code and region_code are required when show_all is set to true.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showAll", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowAll { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/attributes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("categoryName", new Google.Apis.Discovery.Parameter
                {
                    Name = "categoryName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("showAll", new Google.Apis.Discovery.Parameter
                {
                    Name = "showAll",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "categories" collection of methods.</summary>
    public class CategoriesResource
    {
        private const string Resource = "categories";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CategoriesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns a list of business categories for the provided language and GConcept ids.</summary>
        public virtual BatchGetRequest BatchGet()
        {
            return new BatchGetRequest(service);
        }

        /// <summary>Returns a list of business categories for the provided language and GConcept ids.</summary>
        public class BatchGetRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.BatchGetCategoriesResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. The BCP 47 code of language that the category names should be returned in.</summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Required. At least one name must be set. The GConcept ids the localized category names should be
            /// returned for. To return details for more than one category, repeat this parameter in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

            /// <summary>Optional. The ISO 3166-1 alpha-2 country code used to infer non-standard language.</summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>
            /// Required. Specifies which parts to the Category resource should be returned in the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Required. Specifies which parts to the Category resource should be returned in the response.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>Not specified, equivalent to CATEGORY_METADATA_ONLY.</summary>
                [Google.Apis.Util.StringValueAttribute("CATEGORY_VIEW_UNSPECIFIED")]
                CATEGORYVIEWUNSPECIFIED = 0,

                /// <summary>
                /// The server response will only include Category fields display_name, category_id and language_code.
                /// It omits any service type metadata related fields.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 1,

                /// <summary>Returns all the fields in the response.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/categories:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                {
                    Name = "names",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
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
        /// Returns a list of business categories. Search will match the category name but not the category ID. Search
        /// only matches the front of a category name (that is, 'food' may return 'Food Court' but not 'Fast Food
        /// Restaurant').
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Returns a list of business categories. Search will match the category name but not the category ID. Search
        /// only matches the front of a category name (that is, 'food' may return 'Food Court' but not 'Fast Food
        /// Restaurant').
        /// </summary>
        public class ListRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.ListCategoriesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Filter string from user. The only field that supported is `displayName`. Eg:
            /// `filter=displayName=foo`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Required. The BCP 47 code of language.</summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>
            /// Optional. How many categories to fetch per page. Default is 100, minimum is 1, and maximum page size is
            /// 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. If specified, the next page of categories will be fetched.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Required. The ISO 3166-1 alpha-2 country code.</summary>
            [Google.Apis.Util.RequestParameterAttribute("regionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RegionCode { get; set; }

            /// <summary>
            /// Required. Specifies which parts to the Category resource should be returned in the response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Required. Specifies which parts to the Category resource should be returned in the response.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>Not specified, equivalent to CATEGORY_METADATA_ONLY.</summary>
                [Google.Apis.Util.StringValueAttribute("CATEGORY_VIEW_UNSPECIFIED")]
                CATEGORYVIEWUNSPECIFIED = 0,

                /// <summary>
                /// The server response will only include Category fields display_name, category_id and language_code.
                /// It omits any service type metadata related fields.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 1,

                /// <summary>Returns all the fields in the response.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/categories";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
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
                RequestParameters.Add("regionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "regionCode",
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

    /// <summary>The "chains" collection of methods.</summary>
    public class ChainsResource
    {
        private const string Resource = "chains";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChainsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the specified chain. Returns `NOT_FOUND` if the chain does not exist.</summary>
        /// <param name="name">Required. The chain's resource name, in the format `chains/{chain_place_id}`.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets the specified chain. Returns `NOT_FOUND` if the chain does not exist.</summary>
        public class GetRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Chain>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The chain's resource name, in the format `chains/{chain_place_id}`.</summary>
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
                    Pattern = @"^chains/[^/]+$",
                });
            }
        }

        /// <summary>Searches the chain based on chain name.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>Searches the chain based on chain name.</summary>
        public class SearchRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.SearchChainsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. Search for a chain by its name. Exact/partial/fuzzy/related queries are supported. Examples:
            /// "walmart", "wal-mart", "walmmmart", "沃尔玛"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("chainName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ChainName { get; set; }

            /// <summary>
            /// The maximum number of matched chains to return from this query. The default is 10. The maximum possible
            /// value is 500.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/chains:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("chainName", new Google.Apis.Discovery.Parameter
                {
                    Name = "chainName",
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
            }
        }
    }

    /// <summary>The "googleLocations" collection of methods.</summary>
    public class GoogleLocationsResource
    {
        private const string Resource = "googleLocations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GoogleLocationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Search all of the possible locations that are a match to the specified request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.MyBusinessBusinessInformation.v1.Data.SearchGoogleLocationsRequest body)
        {
            return new SearchRequest(service, body);
        }

        /// <summary>Search all of the possible locations that are a match to the specified request.</summary>
        public class SearchRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.SearchGoogleLocationsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessBusinessInformation.v1.Data.SearchGoogleLocationsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessBusinessInformation.v1.Data.SearchGoogleLocationsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/googleLocations:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
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
            Attributes = new AttributesResource(service);
        }

        /// <summary>Gets the Attributes resource.</summary>
        public virtual AttributesResource Attributes { get; }

        /// <summary>The "attributes" collection of methods.</summary>
        public class AttributesResource
        {
            private const string Resource = "attributes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AttributesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets the Google-updated version of the specified location.</summary>
            /// <param name="name">
            /// Required. Google identifier for this location in the form of `locations/{location_id}/attributes`.
            /// </param>
            public virtual GetGoogleUpdatedRequest GetGoogleUpdated(string name)
            {
                return new GetGoogleUpdatedRequest(service, name);
            }

            /// <summary>Gets the Google-updated version of the specified location.</summary>
            public class GetGoogleUpdatedRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Attributes>
            {
                /// <summary>Constructs a new GetGoogleUpdated request.</summary>
                public GetGoogleUpdatedRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Google identifier for this location in the form of `locations/{location_id}/attributes`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getGoogleUpdated";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:getGoogleUpdated";

                /// <summary>Initializes GetGoogleUpdated parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+/attributes$",
                    });
                }
            }
        }

        /// <summary>
        /// Associates a location to a place ID. Any previous association is overwritten. This operation is only valid
        /// if the location is unverified. The association must be valid, that is, it appears in the list of
        /// `SearchGoogleLocations`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The resource name of the location to associate.</param>
        public virtual AssociateRequest Associate(Google.Apis.MyBusinessBusinessInformation.v1.Data.AssociateLocationRequest body, string name)
        {
            return new AssociateRequest(service, body, name);
        }

        /// <summary>
        /// Associates a location to a place ID. Any previous association is overwritten. This operation is only valid
        /// if the location is unverified. The association must be valid, that is, it appears in the list of
        /// `SearchGoogleLocations`.
        /// </summary>
        public class AssociateRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Empty>
        {
            /// <summary>Constructs a new Associate request.</summary>
            public AssociateRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessBusinessInformation.v1.Data.AssociateLocationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the location to associate.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessBusinessInformation.v1.Data.AssociateLocationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "associate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:associate";

            /// <summary>Initializes Associate parameter list.</summary>
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
            }
        }

        /// <summary>
        /// Clears an association between a location and its place ID. This operation is only valid if the location is
        /// unverified.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The resource name of the location to disassociate.</param>
        public virtual ClearLocationAssociationRequest ClearLocationAssociation(Google.Apis.MyBusinessBusinessInformation.v1.Data.ClearLocationAssociationRequest body, string name)
        {
            return new ClearLocationAssociationRequest(service, body, name);
        }

        /// <summary>
        /// Clears an association between a location and its place ID. This operation is only valid if the location is
        /// unverified.
        /// </summary>
        public class ClearLocationAssociationRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Empty>
        {
            /// <summary>Constructs a new ClearLocationAssociation request.</summary>
            public ClearLocationAssociationRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessBusinessInformation.v1.Data.ClearLocationAssociationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the location to disassociate.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessBusinessInformation.v1.Data.ClearLocationAssociationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "clearLocationAssociation";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:clearLocationAssociation";

            /// <summary>Initializes ClearLocationAssociation parameter list.</summary>
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
            }
        }

        /// <summary>
        /// Deletes a location. If this location cannot be deleted using the API and it is marked so in the
        /// `google.mybusiness.businessinformation.v1.LocationState`, use the [Google Business
        /// Profile](https://business.google.com/manage/) website.
        /// </summary>
        /// <param name="name">Required. The name of the location to delete.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Deletes a location. If this location cannot be deleted using the API and it is marked so in the
        /// `google.mybusiness.businessinformation.v1.LocationState`, use the [Google Business
        /// Profile](https://business.google.com/manage/) website.
        /// </summary>
        public class DeleteRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the location to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^locations/[^/]+$",
                });
            }
        }

        /// <summary>Returns the specified location.</summary>
        /// <param name="name">Required. The name of the location to fetch.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Returns the specified location.</summary>
        public class GetRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Location>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the location to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. Read mask to specify what fields will be returned in the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

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
                    Pattern = @"^locations/[^/]+$",
                });
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Looks up all the attributes set for a given location.</summary>
        /// <param name="name">
        /// Required. Google identifier for this location in the form of `locations/{location_id}/attributes`.
        /// </param>
        public virtual GetAttributesRequest GetAttributes(string name)
        {
            return new GetAttributesRequest(service, name);
        }

        /// <summary>Looks up all the attributes set for a given location.</summary>
        public class GetAttributesRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Attributes>
        {
            /// <summary>Constructs a new GetAttributes request.</summary>
            public GetAttributesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Google identifier for this location in the form of `locations/{location_id}/attributes`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAttributes";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetAttributes parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+/attributes$",
                });
            }
        }

        /// <summary>Gets the Google-updated version of the specified location.</summary>
        /// <param name="name">Required. The name of the location to fetch.</param>
        public virtual GetGoogleUpdatedRequest GetGoogleUpdated(string name)
        {
            return new GetGoogleUpdatedRequest(service, name);
        }

        /// <summary>Gets the Google-updated version of the specified location.</summary>
        public class GetGoogleUpdatedRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.GoogleUpdatedLocation>
        {
            /// <summary>Constructs a new GetGoogleUpdated request.</summary>
            public GetGoogleUpdatedRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the location to fetch.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. Read mask to specify what fields will be returned in the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ReadMask { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getGoogleUpdated";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:getGoogleUpdated";

            /// <summary>Initializes GetGoogleUpdated parameter list.</summary>
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
                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "readMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the specified location.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Google identifier for this location in the form: `locations/{location_id}`.</param>
        public virtual PatchRequest Patch(Google.Apis.MyBusinessBusinessInformation.v1.Data.Location body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates the specified location.</summary>
        public class PatchRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Location>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessBusinessInformation.v1.Data.Location body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Google identifier for this location in the form: `locations/{location_id}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. The specific fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>
            /// Optional. If true, the request is validated without actually updating the location. When this field is
            /// set, we will only return validation errors if there were any. The response will be empty if no errors
            /// were found.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessBusinessInformation.v1.Data.Location Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^locations/[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>Update attributes for a given location.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Google identifier for this location in the form of `locations/{location_id}/attributes`.
        /// </param>
        public virtual UpdateAttributesRequest UpdateAttributes(Google.Apis.MyBusinessBusinessInformation.v1.Data.Attributes body, string name)
        {
            return new UpdateAttributesRequest(service, body, name);
        }

        /// <summary>Update attributes for a given location.</summary>
        public class UpdateAttributesRequest : MyBusinessBusinessInformationBaseServiceRequest<Google.Apis.MyBusinessBusinessInformation.v1.Data.Attributes>
        {
            /// <summary>Constructs a new UpdateAttributes request.</summary>
            public UpdateAttributesRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessBusinessInformation.v1.Data.Attributes body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Google identifier for this location in the form of `locations/{location_id}/attributes`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. Attribute name of attributes that you'd like to update. Represented by
            /// `attributes/{attribute}`. Updates: All attributes provided in the attributes field that you would like
            /// to update must be set in the `attribute_mask`. Attributes set in the above list but not in the
            /// `attribute_mask` will be ignored. Deletes: If you'd like to delete certain attributes, they must be
            /// specified in the `attribute_mask` with no matching entry in the attributes list. If you'd like to delete
            /// all attributes set on a location, you should look up all the applicable attributes for the location and
            /// then add them to the `attribute_mask` with an empty attributes field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("attributeMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object AttributeMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessBusinessInformation.v1.Data.Attributes Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateAttributes";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateAttributes parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+/attributes$",
                });
                RequestParameters.Add("attributeMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "attributeMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.MyBusinessBusinessInformation.v1.Data
{
    /// <summary>Additional information that is surfaced in AdWords.</summary>
    public class AdWordsLocationExtensions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. An alternate phone number to display on AdWords location extensions instead of the location's
        /// primary phone number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adPhone")]
        public virtual string AdPhone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Locations.AssociateLocationRequest.</summary>
    public class AssociateLocationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The association to establish. If not set, it indicates no match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A location attribute. Attributes provide additional information about a location. The attributes that can be set
    /// on a location may vary based on the properties of that location (for example, category). Available attributes
    /// are determined by Google and may be added and removed without API changes.
    /// </summary>
    public class Attribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource name for this attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// When the attribute value type is REPEATED_ENUM, this contains the attribute value, and the other values
        /// fields must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeatedEnumValue")]
        public virtual RepeatedEnumAttributeValue RepeatedEnumValue { get; set; }

        /// <summary>
        /// When the attribute value type is URL, this field contains the value(s) for this attribute, and the other
        /// values fields must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriValues")]
        public virtual System.Collections.Generic.IList<UriAttributeValue> UriValues { get; set; }

        /// <summary>
        /// Output only. The type of value that this attribute contains. This should be used to determine how to
        /// interpret the value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>
        /// The values for this attribute. The type of the values supplied must match that expected for that attribute.
        /// This is a repeated field where multiple attribute values may be provided. Attribute types only support one
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<object> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for an attribute. Contains display information for the attribute, including a localized name and a
    /// heading for grouping related attributes together.
    /// </summary>
    public class AttributeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the attribute is deprecated and should no longer be used. If deprecated, updating this attribute
        /// will not result in an error, but updates will not be saved. At some point after being deprecated, the
        /// attribute will be removed entirely and it will become an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecated")]
        public virtual System.Nullable<bool> Deprecated { get; set; }

        /// <summary>
        /// The localized display name for the attribute, if available; otherwise, the English display name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The localized display name of the group that contains this attribute, if available; otherwise, the English
        /// group name. Related attributes are collected into a group and should be displayed together under the heading
        /// given here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupDisplayName")]
        public virtual string GroupDisplayName { get; set; }

        /// <summary>The unique identifier for the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// If true, the attribute supports multiple values. If false, only a single value should be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeatable")]
        public virtual System.Nullable<bool> Repeatable { get; set; }

        /// <summary>
        /// For some types of attributes (for example, enums), a list of supported values and corresponding display
        /// names for those values is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMetadata")]
        public virtual System.Collections.Generic.IList<AttributeValueMetadata> ValueMetadata { get; set; }

        /// <summary>
        /// The value type for the attribute. Values set and retrieved should be expected to be of this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for supported attribute values.</summary>
    public class AttributeValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The display name for this value, localized where available; otherwise, in English. The value display name is
        /// intended to be used in context with the attribute display name. For example, for a "WiFi" enum attribute,
        /// this could contain "Paid" to represent paid Wi-Fi.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The attribute value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A container for all the attributes for a given location.</summary>
    public class Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of attributes that need to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<Attribute> AttributesValue { get; set; }

        /// <summary>
        /// Required. Google identifier for this location in the form of `locations/{location_id}/attributes`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BusinessCategories.BatchGetBusinessCategories.</summary>
    public class BatchGetCategoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Categories that match the GConcept ids provided in the request. They will not come in the same order as
        /// category ids in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<Category> Categories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the time periods that this location is open for business. Holds a collection of TimePeriod instances.
    /// </summary>
    public class BusinessHours : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A collection of times that this location is open for business. Each period represents a range of
        /// hours when the location is open during the week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periods")]
        public virtual System.Collections.Generic.IList<TimePeriod> Periods { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of categories that describes the business. During updates, both fields must be set. Clients are
    /// prohibited from individually updating the primary or additional categories using the update mask.
    /// </summary>
    public class Categories : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional categories to describe your business. Categories help your customers find accurate,
        /// specific results for services they're interested in. To keep your business information accurate and live,
        /// make sure that you use as few categories as possible to describe your overall core business. Choose
        /// categories that are as specific as possible, but representative of your main business.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalCategories")]
        public virtual System.Collections.Generic.IList<Category> AdditionalCategories { get; set; }

        /// <summary>Required. Category that best describes the core business this location engages in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryCategory")]
        public virtual Category PrimaryCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A category describing what this business is (not what it does). For a list of valid category IDs, and the
    /// mappings to their human-readable names, see `categories.list`.
    /// </summary>
    public class Category : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The human-readable name of the category. This is set when reading the location. When modifying
        /// the location, `category_id` must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. More hours types that are available for this business category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moreHoursTypes")]
        public virtual System.Collections.Generic.IList<MoreHoursType> MoreHoursTypes { get; set; }

        /// <summary>
        /// Required. A stable ID (provided by Google) for this category. The value must be specified when modifying the
        /// category (when creating or updating a location).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. A list of all the service types that are available for this business category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceTypes")]
        public virtual System.Collections.Generic.IList<ServiceType> ServiceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A chain is a brand that your business's locations can be affiliated with.</summary>
    public class Chain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Names of the chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chainNames")]
        public virtual System.Collections.Generic.IList<ChainName> ChainNames { get; set; }

        /// <summary>Number of locations that are part of this chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationCount")]
        public virtual System.Nullable<int> LocationCount { get; set; }

        /// <summary>Required. The chain's resource name, in the format `chains/{chain_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Websites of the chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websites")]
        public virtual System.Collections.Generic.IList<ChainUri> Websites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Name to be used when displaying the chain.</summary>
    public class ChainName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name for this chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The BCP 47 code of language of the name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Url to be used when displaying the chain.</summary>
    public class ChainUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uri for this chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Locations.ClearLocationAssociationRequest.</summary>
    public class ClearLocationAssociationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>
    /// Represents a free-form service offered by the merchant. These are services that are not exposed as part of our
    /// structure service data. The merchant manually enters the names for of such services via a geomerchant surface.
    /// </summary>
    public class FreeFormServiceItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This field represents the category name (i.e. the category's stable ID). The `category` and
        /// `service_type_id` should match the possible combinations provided in the `Category` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Required. Language-tagged labels for the item. We recommend that item names be 140 characters or less, and
        /// descriptions 250 characters or less. This field should only be set if the input is a custom service item.
        /// Standardized service types should be updated via service_type_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual Label Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Location that is present on Google. This can be a location that has been claimed by the user,
    /// someone else, or could be unclaimed.
    /// </summary>
    public class GoogleLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The sparsely populated Location information. This field can be re-used in CreateLocation if it is not
        /// currently claimed by a user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>Resource name of this GoogleLocation, in the format `googleLocations/{googleLocationId}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A URL that will redirect the user to the request admin rights UI. This field is only present if the location
        /// has already been claimed by any user, including the current user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAdminRightsUri")]
        public virtual string RequestAdminRightsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a location that was modified by Google.</summary>
    public class GoogleUpdatedLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fields that Google updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffMask")]
        public virtual object DiffMask { get; set; }

        /// <summary>The Google-updated version of this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>The fields that have pending edits that haven't yet been pushed to Maps and Search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingMask")]
        public virtual object PendingMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label to be used when displaying the price list, section, or item.</summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the price list, section, or item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name for the price list, section, or item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The BCP-47 language code that these strings apply for. Only one set of labels may be set per
        /// language.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for AttributesService.ListAttributeMetadata.</summary>
    public class ListAttributeMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of attribute metadata for the available attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMetadata")]
        public virtual System.Collections.Generic.IList<AttributeMetadata> AttributeMetadata { get; set; }

        /// <summary>
        /// If the number of attributes exceeded the requested page size, this field will be populated with a token to
        /// fetch the next page of attributes on a subsequent call to `attributes.list`. If there are no more
        /// attributes, this field will not be present in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BusinessCategories.ListCategories.</summary>
    public class ListCategoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The matching categories based on the requested parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<Category> Categories { get; set; }

        /// <summary>
        /// If the number of categories exceeded the requested page size, this field will be populated with a token to
        /// fetch the next page of categories on a subsequent call to `ListCategories`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>
        /// If the number of locations exceeded the requested page size, this field is populated with a token to fetch
        /// the next page of locations on a subsequent call to `ListLocations`. If there are no more locations, this
        /// field is not present in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The approximate number of Locations in the list irrespective of pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A location. See the [help center article] (https://support.google.com/business/answer/3038177) for a detailed
    /// description of these fields, or the [category endpoint](/my-business/reference/rest/v4/categories) for a list of
    /// valid business categories.
    /// </summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Additional information that is surfaced in AdWords.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adWordsLocationExtensions")]
        public virtual AdWordsLocationExtensions AdWordsLocationExtensions { get; set; }

        /// <summary>Optional. The different categories that describe the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual Categories Categories { get; set; }

        /// <summary>
        /// Optional. A collection of free-form strings to allow you to tag your business. These labels are NOT user
        /// facing; only you can see them. Must be between 1-255 characters per label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>Immutable. The language of the location. Set during creation and not updateable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. User-provided latitude and longitude. When creating a location, this field is ignored if the
        /// provided address geocodes successfully. This field is only returned on get requests if the user-provided
        /// `latlng` value was accepted during create, or the `latlng` value was updated through the Google Business
        /// Profile website. This field can only be updated by approved clients.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latlng")]
        public virtual LatLng Latlng { get; set; }

        /// <summary>Output only. Additional non-user-editable information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual Metadata Metadata { get; set; }

        /// <summary>Optional. More hours for a business's different departments or specific customers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moreHours")]
        public virtual System.Collections.Generic.IList<MoreHours> MoreHours { get; set; }

        /// <summary>Google identifier for this location in the form: `locations/{location_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. A flag that indicates whether the location is currently open for business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openInfo")]
        public virtual OpenInfo OpenInfo { get; set; }

        /// <summary>
        /// Optional. The different phone numbers that customers can use to get in touch with the business.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumbers")]
        public virtual PhoneNumbers PhoneNumbers { get; set; }

        /// <summary>
        /// Optional. Describes your business in your own voice and shares with users the unique story of your business
        /// and offerings. This field is required for all categories except lodging categories (e.g. hotels, motels,
        /// inns).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual Profile Profile { get; set; }

        /// <summary>Optional. Operating hours for the business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regularHours")]
        public virtual BusinessHours RegularHours { get; set; }

        /// <summary>Optional. All locations and chain related to this one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipData")]
        public virtual RelationshipData RelationshipData { get; set; }

        /// <summary>
        /// Optional. Service area businesses provide their service at the customer's location. If this business is a
        /// service area business, this field describes the area(s) serviced by the business.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceArea")]
        public virtual ServiceAreaBusiness ServiceArea { get; set; }

        /// <summary>
        /// Optional. List of services supported by merchants. A service can be haircut, install water heater, etc.
        /// Duplicated service items will be removed automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceItems")]
        public virtual System.Collections.Generic.IList<ServiceItem> ServiceItems { get; set; }

        /// <summary>
        /// Optional. Special hours for the business. This typically includes holiday hours, and other times outside of
        /// regular operating hours. These override regular business hours. This field cannot be set without regular
        /// hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specialHours")]
        public virtual SpecialHours SpecialHours { get; set; }

        /// <summary>
        /// Optional. External identifier for this location, which must be unique within a given account. This is a
        /// means of associating the location with your own records.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; }

        /// <summary>
        /// Optional. A precise, accurate address to describe your business location. PO boxes or mailboxes located at
        /// remote locations are not acceptable. At this time, you can specify a maximum of five `address_lines` values
        /// in the address. This field should only be set for businesses that have a storefront. This field should not
        /// be set for locations of type `CUSTOMER_LOCATION_ONLY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storefrontAddress")]
        public virtual PostalAddress StorefrontAddress { get; set; }

        /// <summary>
        /// Required. Location name should reflect your business's real-world name, as used consistently on your
        /// storefront, website, and stationery, and as known to customers. Any additional information, when relevant,
        /// can be included in other fields of the resource (for example, `Address`, `Categories`). Don't add
        /// unnecessary information to your name (for example, prefer "Google" over "Google Inc. - Mountain View
        /// Corporate Headquarters"). Don't include marketing taglines, store codes, special characters, hours or
        /// closed/open status, phone numbers, website URLs, service/product information, location/address or
        /// directions, or containment information (for example, "Chase ATM in Duane Reade").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Optional. A URL for this business. If possible, use a URL that represents this individual business location
        /// instead of a generic website/URL that represents all locations, or the brand.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUri")]
        public virtual string WebsiteUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional non-user-editable information about the location.</summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates whether the location can be deleted using the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canDelete")]
        public virtual System.Nullable<bool> CanDelete { get; set; }

        /// <summary>Output only. Indicates if the listing is eligible for business calls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canHaveBusinessCalls")]
        public virtual System.Nullable<bool> CanHaveBusinessCalls { get; set; }

        /// <summary>Output only. Indicates if the listing is eligible for food menu.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canHaveFoodMenus")]
        public virtual System.Nullable<bool> CanHaveFoodMenus { get; set; }

        /// <summary>Output only. Indicates if the listing can modify the service list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canModifyServiceList")]
        public virtual System.Nullable<bool> CanModifyServiceList { get; set; }

        /// <summary>Output only. Indicates whether the location can operate on Health data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canOperateHealthData")]
        public virtual System.Nullable<bool> CanOperateHealthData { get; set; }

        /// <summary>Output only. Indicates if the listing can manage local posts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canOperateLocalPost")]
        public virtual System.Nullable<bool> CanOperateLocalPost { get; set; }

        /// <summary>Output only. Indicates whether the location can operate on Lodging data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canOperateLodgingData")]
        public virtual System.Nullable<bool> CanOperateLodgingData { get; set; }

        /// <summary>Output only. The location resource that this location duplicates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateLocation")]
        public virtual string DuplicateLocation { get; set; }

        /// <summary>
        /// Output only. Indicates whether the place ID associated with this location has updates that need to be
        /// updated or rejected by the client. If this boolean is set, you should call the `getGoogleUpdated` method to
        /// lookup information that's needs to be verified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasGoogleUpdated")]
        public virtual System.Nullable<bool> HasGoogleUpdated { get; set; }

        /// <summary>
        /// Output only. Indicates whether any of this Location's properties are in the edit pending state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasPendingEdits")]
        public virtual System.Nullable<bool> HasPendingEdits { get; set; }

        /// <summary>
        /// Output only. Indicates if the listing has Voice of Merchant. If this boolean is false, you should call the
        /// locations.getVoiceOfMerchantState API to get details as to why they do not have Voice of Merchant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasVoiceOfMerchant")]
        public virtual System.Nullable<bool> HasVoiceOfMerchant { get; set; }

        /// <summary>Output only. A link to the location on Maps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapsUri")]
        public virtual string MapsUri { get; set; }

        /// <summary>
        /// Output only. A link to the page on Google Search where a customer can leave a review for the location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newReviewUri")]
        public virtual string NewReviewUri { get; set; }

        /// <summary>
        /// Output only. If this locationappears on Google Maps, this field is populated with the place ID for the
        /// location. This ID can be used in various Places APIs. This field can be set during Create calls, but not for
        /// Update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The time periods during which a location is open for certain types of business.</summary>
    public class MoreHours : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Type of hours. Clients should call {#link businessCategories:BatchGet} to get supported hours
        /// types for categories of their locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hoursTypeId")]
        public virtual string HoursTypeId { get; set; }

        /// <summary>
        /// Required. A collection of times that this location is open. Each period represents a range of hours when the
        /// location is open during the week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periods")]
        public virtual System.Collections.Generic.IList<TimePeriod> Periods { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>More hours types that a business can offers, in addition to its regular hours.</summary>
    public class MoreHoursType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The human-readable English display name for the hours type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. A stable ID provided by Google for this hours type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hoursTypeId")]
        public virtual string HoursTypeId { get; set; }

        /// <summary>Output only. The human-readable localized display name for the hours type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedDisplayName")]
        public virtual string LocalizedDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the opening state of the business.</summary>
    public class OpenInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates whether this business is eligible for re-open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReopen")]
        public virtual System.Nullable<bool> CanReopen { get; set; }

        /// <summary>
        /// Optional. The date on which the location first opened. If the exact day is not known, month and year only
        /// can be provided. The date must be in the past or be no more than one year in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openingDate")]
        public virtual Date OpeningDate { get; set; }

        /// <summary>
        /// Required. Indicates whether or not the Location is currently open for business. All locations are open by
        /// default, unless updated to be closed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of phone numbers for the business. During updates, both fields must be set. Clients may not update
    /// just the primary or additional phone numbers using the update mask. International phone format is preferred,
    /// such as "+1 415 555 0132", see more in
    /// (https://developers.google.com/style/phone-numbers#international-phone-numbers).
    /// </summary>
    public class PhoneNumbers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Up to two phone numbers (mobile or landline, no fax) at which your business can be called, in
        /// addition to your primary phone number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalPhones")]
        public virtual System.Collections.Generic.IList<string> AdditionalPhones { get; set; }

        /// <summary>
        /// Required. A phone number that connects to your individual business location as directly as possible. Use a
        /// local phone number instead of a central, call center helpline number whenever possible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryPhone")]
        public virtual string PrimaryPhone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines an area that's represented by a place ID.</summary>
    public class PlaceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The ID of the place. Must correspond to a region.
        /// (https://developers.google.com/places/web-service/supported_types#table3)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>Required. The localized name of the place. For example, `Scottsdale, AZ`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeName")]
        public virtual string PlaceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the union of areas represented by a set of places.</summary>
    public class Places : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The areas represented by place IDs. Limited to a maximum of 20 places.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeInfos")]
        public virtual System.Collections.Generic.IList<PlaceInfo> PlaceInfos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a postal
    /// service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical locations
    /// (roads, towns, mountains). In typical usage an address would be created via user input or from importing
    /// existing data, depending on the type of process. Advice on address input / editing: - Use an
    /// internationalization-ready address widget such as https://github.com/google/libaddressinput) - Users should not
    /// be presented with UI elements for input or editing of fields outside countries where that field is used. For
    /// more guidance on how to use this schema, please see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (e.g. "Austin, TX"), it is
        /// important that the line order is clear. The order of address lines should be "envelope order" for the
        /// country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make
        /// it explicit (e.g. "ja" for large-to-small ordering and "ja-Latn" or "en" for small-to-large). This way, the
        /// most specific line of an address can be selected based on the language. The minimum permitted structural
        /// representation of an address consists of a region_code with all remaining information placed in the
        /// address_lines. It would be possible to format such an address very approximately without geocoding, but no
        /// semantic reasoning could be made about any of the address components until it was at least partially
        /// resolved. Creating an address only containing a region_code and address_lines, and then geocoding is the
        /// recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the
        /// address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (e.g. "Barcelona" and not "Catalonia"). Many countries don't use
        /// an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use address_lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (e.g. state/zip
        /// validation in the U.S.A.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See https://cldr.unicode.org/ and
        /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH"
        /// for Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (e.g. "CEDEX 7"), or just a
        /// number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (e.g. Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All information pertaining to the location's profile.</summary>
    public class Profile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Description of the location in your own voice, not editable by anyone else.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information of all parent and children locations related to this one.</summary>
    public class RelationshipData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of children locations that this location has relations with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childrenLocations")]
        public virtual System.Collections.Generic.IList<RelevantLocation> ChildrenLocations { get; set; }

        /// <summary>The resource name of the Chain that this location is member of. How to find Chain ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentChain")]
        public virtual string ParentChain { get; set; }

        /// <summary>The parent location that this location has relations with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLocation")]
        public virtual RelevantLocation ParentLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about another location that is related to current one. The relation can be any one of DEPARTMENT_OF
    /// or INDEPENDENT_ESTABLISHMENT_OF, and the location specified here can be on either side (parent/child) of the
    /// location.
    /// </summary>
    public class RelevantLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specify the location that is on the other side of the relation by its placeID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>Required. The type of the relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationType")]
        public virtual string RelationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Values for an attribute with a `value_type` of REPEATED_ENUM. This consists of two lists of value IDs: those
    /// that are set (true) and those that are unset (false). Values absent are considered unknown. At least one value
    /// must be specified.
    /// </summary>
    public class RepeatedEnumAttributeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enum values that are set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setValues")]
        public virtual System.Collections.Generic.IList<string> SetValues { get; set; }

        /// <summary>Enum values that are unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsetValues")]
        public virtual System.Collections.Generic.IList<string> UnsetValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Locations.SearchChains.</summary>
    public class SearchChainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Chains that match the queried chain_display_name in SearchChainsRequest. If there are no matches, this field
        /// will be empty. Results are listed in order of relevance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chains")]
        public virtual System.Collections.Generic.IList<Chain> Chains { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for GoogleLocations.SearchGoogleLocations.</summary>
    public class SearchGoogleLocationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location to search for. If provided, will find locations which match the provided location details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>
        /// The number of matches to return. The default value is 3, with a maximum of 10. Note that latency may
        /// increase if more are requested. There is no pagination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Text query to search for. The search results from a query string will be less accurate than if providing an
        /// exact location, but can provide more inexact matches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GoogleLocations.SearchGoogleLocations.</summary>
    public class SearchGoogleLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A collection of GoogleLocations that are potential matches to the specified request, listed in order from
        /// most to least accuracy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleLocations")]
        public virtual System.Collections.Generic.IList<GoogleLocation> GoogleLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Service area businesses provide their service at the customer's location (for example, a locksmith or plumber).
    /// </summary>
    public class ServiceAreaBusiness : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Indicates the type of the service area business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessType")]
        public virtual string BusinessType { get; set; }

        /// <summary>The area that this business serves defined through a set of places.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("places")]
        public virtual Places Places { get; set; }

        /// <summary>
        /// Immutable. CLDR region code of the country/region that this service area business is based in. See
        /// http://cldr.unicode.org/ and http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html
        /// for details. Example: "CH" for Switzerland. This field is required for CUSTOMER_LOCATION_ONLY businesses,
        /// and is ignored otherwise. The region specified here can be different from regions for the areas that this
        /// business serves (e.g. service area businesses that provide services in regions other than the one that they
        /// are based in). If this location requires verification after creation, the address provided for verification
        /// purposes *must* be located within this region, and the business owner or their authorized representative
        /// *must* be able to receive postal mail at the provided verification address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that describes a single service item. It is used to describe the type of service that the merchant
    /// provides. For example, haircut can be a service.
    /// </summary>
    public class ServiceItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. This field will be set case of free-form services data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeFormServiceItem")]
        public virtual FreeFormServiceItem FreeFormServiceItem { get; set; }

        /// <summary>
        /// Optional. Represents the monetary price of the service item. We recommend that currency_code and units
        /// should be set when including a price. This will be treated as a fixed price for the service item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Money Price { get; set; }

        /// <summary>Optional. This field will be set case of structured services data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredServiceItem")]
        public virtual StructuredServiceItem StructuredServiceItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message describing a service type that the business offers.</summary>
    public class ServiceType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The human-readable display name for the service type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. A stable ID (provided by Google) for this service type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceTypeId")]
        public virtual string ServiceTypeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single time period when a location's operational hours differ from its normal business hours. A
    /// special hour period must represent a range of less than 24 hours. The `open_time` and `start_date` must predate
    /// the `close_time` and `end_date`. The `close_time` and `end_date` can extend to 11:59 a.m. on the day after the
    /// specified `start_date`. For example, the following inputs are valid: start_date=2015-11-23, open_time=08:00,
    /// close_time=18:00 start_date=2015-11-23, end_date=2015-11-23, open_time=08:00, close_time=18:00
    /// start_date=2015-11-23, end_date=2015-11-24, open_time=13:00, close_time=11:59 The following inputs are not
    /// valid: start_date=2015-11-23, open_time=13:00, close_time=11:59 start_date=2015-11-23, end_date=2015-11-24,
    /// open_time=13:00, close_time=12:00 start_date=2015-11-23, end_date=2015-11-25, open_time=08:00, close_time=18:00
    /// </summary>
    public class SpecialHourPeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Valid values are 00:00-24:00, where 24:00 represents midnight at the end of the specified day
        /// field. Must be specified if `closed` is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("closeTime")]
        public virtual TimeOfDay CloseTime { get; set; }

        /// <summary>
        /// Optional. If true, `end_date`, `open_time`, and `close_time` are ignored, and the date specified in
        /// `start_date` is treated as the location being closed for the entire day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("closed")]
        public virtual System.Nullable<bool> Closed { get; set; }

        /// <summary>
        /// Optional. The calendar date this special hour period ends on. If `end_date` field is not set, default to the
        /// date specified in `start_date`. If set, this field must be equal to or at most 1 day after `start_date`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// Optional. Valid values are 00:00-24:00 where 24:00 represents midnight at the end of the specified day
        /// field. Must be specified if `closed` is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openTime")]
        public virtual TimeOfDay OpenTime { get; set; }

        /// <summary>Required. The calendar date this special hour period starts on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a set of time periods when a location's operational hours differ from its normal business hours.
    /// </summary>
    public class SpecialHours : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of exceptions to the business's regular hours.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specialHourPeriods")]
        public virtual System.Collections.Generic.IList<SpecialHourPeriod> SpecialHourPeriods { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a structured service offered by the merchant. For eg: toilet_installation.</summary>
    public class StructuredServiceItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of structured service item. The character limit is 300.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The `service_type_id` field is a Google provided unique ID that can be found in `ServiceType`.
        /// This information is provided by `BatchGetCategories` rpc service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceTypeId")]
        public virtual string ServiceTypeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a span of time that the business is open, starting on the specified open day/time and closing on the
    /// specified close day/time. The closing time must occur after the opening time, for example later in the same day,
    /// or on a subsequent day.
    /// </summary>
    public class TimePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Indicates the day of the week this period ends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("closeDay")]
        public virtual string CloseDay { get; set; }

        /// <summary>
        /// Required. Valid values are 00:00-24:00, where 24:00 represents midnight at the end of the specified day
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("closeTime")]
        public virtual TimeOfDay CloseTime { get; set; }

        /// <summary>Required. Indicates the day of the week this period starts on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openDay")]
        public virtual string OpenDay { get; set; }

        /// <summary>
        /// Required. Valid values are 00:00-24:00, where 24:00 represents midnight at the end of the specified day
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openTime")]
        public virtual TimeOfDay OpenTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Values for an attribute with a `value_type` of URL.</summary>
    public class UriAttributeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The proposed URI value for this attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
