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

namespace Google.Apis.Merchant.products_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "products_v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MerchantService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MerchantService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://merchantapi.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://merchantapi.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "merchantapi";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Merchant API.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public static string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Merchant API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public const string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Merchant requests.</summary>
    public abstract class MerchantBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MerchantBaseServiceRequest instance.</summary>
        protected MerchantBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Merchant parameter list.</summary>
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
            ProductInputs = new ProductInputsResource(service);
            Products = new ProductsResource(service);
        }

        /// <summary>Gets the ProductInputs resource.</summary>
        public virtual ProductInputsResource ProductInputs { get; }

        /// <summary>The "productInputs" collection of methods.</summary>
        public class ProductInputsResource
        {
            private const string Resource = "productInputs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductInputsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes a product input from your Merchant Center account. After inserting, updating, or deleting a
            /// product input, it may take several minutes before the processed product can be retrieved.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the product input resource to delete. Format:
            /// accounts/{account}/productInputs/{product} where the last section `product` consists of 4 parts:
            /// channel~content_language~feed_label~offer_id example for product name is
            /// "accounts/123/productInputs/online~en~US~sku123"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a product input from your Merchant Center account. After inserting, updating, or deleting a
            /// product input, it may take several minutes before the processed product can be retrieved.
            /// </summary>
            public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.products_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the product input resource to delete. Format:
                /// accounts/{account}/productInputs/{product} where the last section `product` consists of 4 parts:
                /// channel~content_language~feed_label~offer_id example for product name is
                /// "accounts/123/productInputs/online~en~US~sku123"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The primary or supplemental data source from which the product input should be deleted.
                /// Format: `accounts/{account}/dataSources/{datasource}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DataSource { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "products/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/productInputs/[^/]+$",
                    });
                    RequestParameters.Add("dataSource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dataSource",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Uploads a product input to your Merchant Center account. If an input with the same contentLanguage,
            /// offerId, and dataSource already exists, this method replaces that entry. After inserting, updating, or
            /// deleting a product input, it may take several minutes before the processed product can be retrieved.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account where this product will be inserted. Format: accounts/{account}
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.products_v1beta.Data.ProductInput body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>
            /// Uploads a product input to your Merchant Center account. If an input with the same contentLanguage,
            /// offerId, and dataSource already exists, this method replaces that entry. After inserting, updating, or
            /// deleting a product input, it may take several minutes before the processed product can be retrieved.
            /// </summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.products_v1beta.Data.ProductInput>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.products_v1beta.Data.ProductInput body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account where this product will be inserted. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The primary or supplemental product data source name. If the product already exists and
                /// data source provided is different, then the product will be moved to a new data source. Only API
                /// data sources are supported. Format: `accounts/{account}/dataSources/{datasource}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DataSource { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.products_v1beta.Data.ProductInput Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "products/v1beta/{+parent}/productInputs:insert";

                /// <summary>Initializes Insert parameter list.</summary>
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
                    RequestParameters.Add("dataSource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dataSource",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }

        /// <summary>The "products" collection of methods.</summary>
        public class ProductsResource
        {
            private const string Resource = "products";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Retrieves the processed product from your Merchant Center account. After inserting, updating, or
            /// deleting a product input, it may take several minutes before the updated final product can be retrieved.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the product to retrieve. Format: `accounts/{account}/products/{product}` where the
            /// last section `product` consists of 4 parts: channel~content_language~feed_label~offer_id example for
            /// product name is "accounts/123/products/online~en~US~sku123"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Retrieves the processed product from your Merchant Center account. After inserting, updating, or
            /// deleting a product input, it may take several minutes before the updated final product can be retrieved.
            /// </summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.products_v1beta.Data.Product>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the product to retrieve. Format: `accounts/{account}/products/{product}` where
                /// the last section `product` consists of 4 parts: channel~content_language~feed_label~offer_id example
                /// for product name is "accounts/123/products/online~en~US~sku123"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "products/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/products/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the processed products in your Merchant Center account. The response might contain fewer items
            /// than specified by pageSize. Rely on pageToken to determine if there are more items to be requested.
            /// After inserting, updating, or deleting a product input, it may take several minutes before the updated
            /// processed product can be retrieved.
            /// </summary>
            /// <param name="parent">
            /// Required. The account to list processed products for. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the processed products in your Merchant Center account. The response might contain fewer items
            /// than specified by pageSize. Rely on pageToken to determine if there are more items to be requested.
            /// After inserting, updating, or deleting a product input, it may take several minutes before the updated
            /// processed product can be retrieved.
            /// </summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.products_v1beta.Data.ListProductsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The account to list processed products for. Format: accounts/{account}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of products to return. The service may return fewer than this value. The maximum
                /// value is 250; values above 250 will be coerced to 250. If unspecified, the maximum number of
                /// products will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListProducts` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListProducts` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "products/v1beta/{+parent}/products";

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
namespace Google.Apis.Merchant.products_v1beta.Data
{
    /// <summary>Attributes.</summary>
    public class Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional URLs of images of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalImageLinks")]
        public virtual System.Collections.Generic.IList<string> AdditionalImageLinks { get; set; }

        /// <summary>Used to group items in an arbitrary way. Only for CPA%, discouraged otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsGrouping")]
        public virtual string AdsGrouping { get; set; }

        /// <summary>Similar to ads_grouping, but only works on CPC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsLabels")]
        public virtual System.Collections.Generic.IList<string> AdsLabels { get; set; }

        /// <summary>
        /// Allows advertisers to override the item URL when the product is shown within the context of Product ads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsRedirect")]
        public virtual string AdsRedirect { get; set; }

        /// <summary>Set to true if the item is targeted towards adults.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adult")]
        public virtual System.Nullable<bool> Adult { get; set; }

        /// <summary>Target [age group](https://support.google.com/merchants/answer/6324463) of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageGroup")]
        public virtual string AgeGroup { get; set; }

        /// <summary>
        /// A safeguard in the "Automated Discounts" (https://support.google.com/merchants/answer/10295759) and "Dynamic
        /// Promotions" (https://support.google.com/merchants/answer/13949249) projects, ensuring that discounts on
        /// merchants' offers do not fall below this value, thereby preserving the offer's value and profitability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoPricingMinPrice")]
        public virtual Price AutoPricingMinPrice { get; set; }

        /// <summary>Availability status of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        private string _availabilityDateRaw;

        private object _availabilityDate;

        /// <summary>
        /// The day a pre-ordered product becomes available for delivery, in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityDate")]
        public virtual string AvailabilityDateRaw
        {
            get => _availabilityDateRaw;
            set
            {
                _availabilityDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _availabilityDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AvailabilityDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AvailabilityDateDateTimeOffset instead.")]
        public virtual object AvailabilityDate
        {
            get => _availabilityDate;
            set
            {
                _availabilityDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _availabilityDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AvailabilityDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AvailabilityDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AvailabilityDateRaw);
            set => AvailabilityDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Brand of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>URL for the canonical version of your item's landing page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalLink")]
        public virtual string CanonicalLink { get; set; }

        /// <summary>
        /// Product Certifications, for example for energy efficiency labeling of products recorded in the [EU
        /// EPREL](https://eprel.ec.europa.eu/screen/home) database. See the [Help
        /// Center](https://support.google.com/merchants/answer/13528839) article for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certifications")]
        public virtual System.Collections.Generic.IList<Certification> Certifications { get; set; }

        /// <summary>Extra fields to export to the Cloud Retail program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudExportAdditionalProperties")]
        public virtual System.Collections.Generic.IList<CloudExportAdditionalProperties> CloudExportAdditionalProperties { get; set; }

        /// <summary>Color of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; }

        /// <summary>Condition or state of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>Cost of goods sold. Used for gross profit reporting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costOfGoodsSold")]
        public virtual Price CostOfGoodsSold { get; set; }

        /// <summary>Custom label 0 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel0")]
        public virtual string CustomLabel0 { get; set; }

        /// <summary>Custom label 1 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel1")]
        public virtual string CustomLabel1 { get; set; }

        /// <summary>Custom label 2 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel2")]
        public virtual string CustomLabel2 { get; set; }

        /// <summary>Custom label 3 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel3")]
        public virtual string CustomLabel3 { get; set; }

        /// <summary>Custom label 4 for custom grouping of items in a Shopping campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel4")]
        public virtual string CustomLabel4 { get; set; }

        /// <summary>Description of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _disclosureDateRaw;

        private object _disclosureDate;

        /// <summary>
        /// The date time when an offer becomes visible in search results across Google’s YouTube surfaces, in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format. See [Disclosure date](
        /// https://support.google.com/merchants/answer/13034208) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disclosureDate")]
        public virtual string DisclosureDateRaw
        {
            get => _disclosureDateRaw;
            set
            {
                _disclosureDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _disclosureDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DisclosureDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DisclosureDateDateTimeOffset instead.")]
        public virtual object DisclosureDate
        {
            get => _disclosureDate;
            set
            {
                _disclosureDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _disclosureDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DisclosureDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DisclosureDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DisclosureDateRaw);
            set => DisclosureDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>An identifier for an item for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsId")]
        public virtual string DisplayAdsId { get; set; }

        /// <summary>URL directly to your item's landing page for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsLink")]
        public virtual string DisplayAdsLink { get; set; }

        /// <summary>Advertiser-specified recommendations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsSimilarIds")]
        public virtual System.Collections.Generic.IList<string> DisplayAdsSimilarIds { get; set; }

        /// <summary>Title of an item for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsTitle")]
        public virtual string DisplayAdsTitle { get; set; }

        /// <summary>Offer margin for dynamic remarketing campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayAdsValue")]
        public virtual System.Nullable<double> DisplayAdsValue { get; set; }

        /// <summary>The energy efficiency class as defined in EU directive 2010/30/EU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("energyEfficiencyClass")]
        public virtual string EnergyEfficiencyClass { get; set; }

        /// <summary>
        /// The list of destinations to exclude for this target (corresponds to unchecked check boxes in Merchant
        /// Center).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedDestinations")]
        public virtual System.Collections.Generic.IList<string> ExcludedDestinations { get; set; }

        private string _expirationDateRaw;

        private object _expirationDate;

        /// <summary>
        /// Date on which the item should expire, as specified upon insertion, in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format. The actual expiration date is exposed in
        /// `productstatuses` as [googleExpirationDate](https://support.google.com/merchants/answer/6324499) and might
        /// be earlier if `expirationDate` is too far in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationDate")]
        public virtual string ExpirationDateRaw
        {
            get => _expirationDateRaw;
            set
            {
                _expirationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationDateDateTimeOffset instead.")]
        public virtual object ExpirationDate
        {
            get => _expirationDate;
            set
            {
                _expirationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationDateRaw);
            set => ExpirationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required for multi-seller accounts. Use this attribute if you're a marketplace uploading products for
        /// various sellers to your multi-seller account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSellerId")]
        public virtual string ExternalSellerId { get; set; }

        /// <summary>Conditions to be met for a product to have free shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeShippingThreshold")]
        public virtual System.Collections.Generic.IList<FreeShippingThreshold> FreeShippingThreshold { get; set; }

        /// <summary>Target gender of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        /// <summary>
        /// Google's category of the item (see [Google product
        /// taxonomy](https://support.google.com/merchants/answer/1705911)). When querying products, this field will
        /// contain the user provided value. There is currently no way to get back the auto assigned google product
        /// categories through the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleProductCategory")]
        public virtual string GoogleProductCategory { get; set; }

        /// <summary>
        /// Global Trade Item Numbers ([GTIN](https://support.google.com/merchants/answer/188494#gtin)) of the item. You
        /// can provide up to 10 GTINs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual System.Collections.Generic.IList<string> Gtin { get; set; }

        /// <summary>
        /// Set this value to false when the item does not have unique product identifiers appropriate to its category,
        /// such as GTIN, MPN, and brand. Defaults to true, if not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identifierExists")]
        public virtual System.Nullable<bool> IdentifierExists { get; set; }

        /// <summary>URL of an image of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLink")]
        public virtual string ImageLink { get; set; }

        /// <summary>
        /// The list of destinations to include for this target (corresponds to checked check boxes in Merchant Center).
        /// Default destinations are always included unless provided in `excludedDestinations`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedDestinations")]
        public virtual System.Collections.Generic.IList<string> IncludedDestinations { get; set; }

        /// <summary>Number and amount of installments to pay for an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installment")]
        public virtual Installment Installment { get; set; }

        /// <summary>
        /// Whether the item is a merchant-defined bundle. A bundle is a custom grouping of different products sold by a
        /// merchant for a single price.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isBundle")]
        public virtual System.Nullable<bool> IsBundle { get; set; }

        /// <summary>Shared identifier for all variants of the same product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupId")]
        public virtual string ItemGroupId { get; set; }

        /// <summary>
        /// Additional URLs of lifestyle images of the item, used to explicitly identify images that showcase your item
        /// in a real-world context. See the [Help Center article](https://support.google.com/merchants/answer/9103186)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifestyleImageLinks")]
        public virtual System.Collections.Generic.IList<string> LifestyleImageLinks { get; set; }

        /// <summary>URL directly linking to your item's page on your online store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>Link template for merchant hosted local storefront.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkTemplate")]
        public virtual string LinkTemplate { get; set; }

        /// <summary>Loyalty points that users receive after purchasing the item. Japan only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyPoints")]
        public virtual LoyaltyPoints LoyaltyPoints { get; set; }

        /// <summary>
        /// A list of loyalty program information that is used to surface loyalty benefits (for example, better pricing,
        /// points, etc) to the user of this item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyPrograms")]
        public virtual System.Collections.Generic.IList<LoyaltyProgram> LoyaltyPrograms { get; set; }

        /// <summary>The material of which the item is made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("material")]
        public virtual string Material { get; set; }

        /// <summary>The energy efficiency class as defined in EU directive 2010/30/EU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEnergyEfficiencyClass")]
        public virtual string MaxEnergyEfficiencyClass { get; set; }

        /// <summary>Maximal product handling time (in business days).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxHandlingTime")]
        public virtual System.Nullable<long> MaxHandlingTime { get; set; }

        /// <summary>The energy efficiency class as defined in EU directive 2010/30/EU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minEnergyEfficiencyClass")]
        public virtual string MinEnergyEfficiencyClass { get; set; }

        /// <summary>Minimal product handling time (in business days).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minHandlingTime")]
        public virtual System.Nullable<long> MinHandlingTime { get; set; }

        /// <summary>URL for the mobile-optimized version of your item's landing page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileLink")]
        public virtual string MobileLink { get; set; }

        /// <summary>Link template for merchant hosted local storefront optimized for mobile devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileLinkTemplate")]
        public virtual string MobileLinkTemplate { get; set; }

        /// <summary>
        /// Manufacturer Part Number ([MPN](https://support.google.com/merchants/answer/188494#mpn)) of the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpn")]
        public virtual string Mpn { get; set; }

        /// <summary>The number of identical products in a merchant-defined multipack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipack")]
        public virtual System.Nullable<long> Multipack { get; set; }

        /// <summary>The item's pattern (for example, polka dots).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; }

        /// <summary>
        /// Publication of this item will be temporarily [paused](https://support.google.com/merchants/answer/11909930).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pause")]
        public virtual string Pause { get; set; }

        /// <summary>The pick up option for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupMethod")]
        public virtual string PickupMethod { get; set; }

        /// <summary>Item store pickup timeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupSla")]
        public virtual string PickupSla { get; set; }

        /// <summary>Price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>Technical specification or additional product details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDetails")]
        public virtual System.Collections.Generic.IList<ProductDetail> ProductDetails { get; set; }

        /// <summary>
        /// The height of the product in the units provided. The value must be between 0 (exclusive) and 3000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productHeight")]
        public virtual ProductDimension ProductHeight { get; set; }

        /// <summary>Bullet points describing the most relevant highlights of a product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productHighlights")]
        public virtual System.Collections.Generic.IList<string> ProductHighlights { get; set; }

        /// <summary>
        /// The length of the product in the units provided. The value must be between 0 (exclusive) and 3000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLength")]
        public virtual ProductDimension ProductLength { get; set; }

        /// <summary>
        /// Categories of the item (formatted as in [product data
        /// specification](https://support.google.com/merchants/answer/188494#product_type)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypes")]
        public virtual System.Collections.Generic.IList<string> ProductTypes { get; set; }

        /// <summary>
        /// The weight of the product in the units provided. The value must be between 0 (exclusive) and 2000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productWeight")]
        public virtual ProductWeight ProductWeight { get; set; }

        /// <summary>
        /// The width of the product in the units provided. The value must be between 0 (exclusive) and 3000
        /// (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productWidth")]
        public virtual ProductDimension ProductWidth { get; set; }

        /// <summary>The unique ID of a promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionIds")]
        public virtual System.Collections.Generic.IList<string> PromotionIds { get; set; }

        /// <summary>Advertised sale price of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePrice")]
        public virtual Price SalePrice { get; set; }

        /// <summary>
        /// Date range during which the item is on sale (see [product data
        /// specification](https://support.google.com/merchants/answer/188494#sale_price_effective_date)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePriceEffectiveDate")]
        public virtual Interval SalePriceEffectiveDate { get; set; }

        /// <summary>
        /// The quantity of the product that is available for selling on Google. Supported only for online products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellOnGoogleQuantity")]
        public virtual System.Nullable<long> SellOnGoogleQuantity { get; set; }

        /// <summary>Shipping rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shipping")]
        public virtual System.Collections.Generic.IList<Shipping> Shipping { get; set; }

        /// <summary>Height of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingHeight")]
        public virtual ShippingDimension ShippingHeight { get; set; }

        /// <summary>The shipping label of the product, used to group product in account-level shipping rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingLabel")]
        public virtual string ShippingLabel { get; set; }

        /// <summary>Length of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingLength")]
        public virtual ShippingDimension ShippingLength { get; set; }

        /// <summary>Weight of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingWeight")]
        public virtual ShippingWeight ShippingWeight { get; set; }

        /// <summary>Width of the item for shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingWidth")]
        public virtual ShippingDimension ShippingWidth { get; set; }

        /// <summary>
        /// List of country codes (ISO 3166-1 alpha-2) to exclude the offer from Shopping Ads destination. Countries
        /// from this list are removed from countries configured in data source settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shoppingAdsExcludedCountries")]
        public virtual System.Collections.Generic.IList<string> ShoppingAdsExcludedCountries { get; set; }

        /// <summary>
        /// Size of the item. Only one value is allowed. For variants with different sizes, insert a separate product
        /// for each size with the same `itemGroupId` value (see
        /// [https://support.google.com/merchants/answer/6324492](size definition)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual string Size { get; set; }

        /// <summary>System in which the size is specified. Recommended for apparel items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeSystem")]
        public virtual string SizeSystem { get; set; }

        /// <summary>
        /// The cut of the item. It can be used to represent combined size types for apparel items. Maximum two of size
        /// types can be provided (see [https://support.google.com/merchants/answer/6324497](size type)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeTypes")]
        public virtual System.Collections.Generic.IList<string> SizeTypes { get; set; }

        /// <summary>Structured description, for algorithmically (AI)-generated descriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredDescription")]
        public virtual ProductStructuredDescription StructuredDescription { get; set; }

        /// <summary>Structured title, for algorithmically (AI)-generated titles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredTitle")]
        public virtual ProductStructuredTitle StructuredTitle { get; set; }

        /// <summary>
        /// Number of periods (months or years) and amount of payment per period for an item with an associated
        /// subscription contract.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionCost")]
        public virtual SubscriptionCost SubscriptionCost { get; set; }

        /// <summary>The list of sustainability incentive programs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sustainabilityIncentives")]
        public virtual System.Collections.Generic.IList<ProductSustainabilityIncentive> SustainabilityIncentives { get; set; }

        /// <summary>The tax category of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxCategory")]
        public virtual string TaxCategory { get; set; }

        /// <summary>Tax information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxes")]
        public virtual System.Collections.Generic.IList<Tax> Taxes { get; set; }

        /// <summary>Title of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// The transit time label of the product, used to group product in account-level transit time tables.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitTimeLabel")]
        public virtual string TransitTimeLabel { get; set; }

        /// <summary>The preference of the denominator of the unit price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPricingBaseMeasure")]
        public virtual UnitPricingBaseMeasure UnitPricingBaseMeasure { get; set; }

        /// <summary>The measure and dimension of an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitPricingMeasure")]
        public virtual UnitPricingMeasure UnitPricingMeasure { get; set; }

        /// <summary>
        /// URL of the 3D image of the item. See the [Help Center
        /// article](https://support.google.com/merchants/answer/13674896) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualModelLink")]
        public virtual string VirtualModelLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Product [certification](https://support.google.com/merchants/answer/13528839), initially introduced for EU
    /// energy efficiency labeling compliance using the EU EPREL database.
    /// </summary>
    public class Certification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The certification authority, for example "European_Commission". Maximum length is 2000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificationAuthority")]
        public virtual string CertificationAuthority { get; set; }

        /// <summary>The certification code. Maximum length is 2000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificationCode")]
        public virtual string CertificationCode { get; set; }

        /// <summary>The name of the certification, for example "EPREL". Maximum length is 2000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificationName")]
        public virtual string CertificationName { get; set; }

        /// <summary>
        /// The certification value (also known as class, level or grade), for example "A+", "C", "gold". Maximum length
        /// is 2000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificationValue")]
        public virtual string CertificationValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Product property for the Cloud Retail API. For example, properties for a TV product could be "Screen-Resolution"
    /// or "Screen-Size".
    /// </summary>
    public class CloudExportAdditionalProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Boolean value of the given property. For example for a TV product, "True" or "False" if the screen is UHD.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>
        /// Float values of the given property. For example for a TV product 1.2345. Maximum repeatedness of this value
        /// is 400. Values are stored in an arbitrary but consistent order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> FloatValue { get; set; }

        /// <summary>
        /// Integer values of the given property. For example, 1080 for a TV product's Screen Resolution. Maximum
        /// repeatedness of this value is 400. Values are stored in an arbitrary but consistent order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> IntValue { get; set; }

        /// <summary>Maximum float value of the given property. For example for a TV product 100.00.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<float> MaxValue { get; set; }

        /// <summary>Minimum float value of the given property. For example for a TV product 1.00.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<float> MinValue { get; set; }

        /// <summary>
        /// Name of the given property. For example, "Screen-Resolution" for a TV product. Maximum string size is 256
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyName")]
        public virtual string PropertyName { get; set; }

        /// <summary>
        /// Text value of the given property. For example, "8K(UHD)" could be a text value for a TV product. Maximum
        /// repeatedness of this value is 400. Values are stored in an arbitrary but consistent order. Maximum string
        /// size is 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textValue")]
        public virtual System.Collections.Generic.IList<string> TextValue { get; set; }

        /// <summary>
        /// Unit of the given property. For example, "Pixels" for a TV product. Maximum string size is 256B.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitCode")]
        public virtual string UnitCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that represents custom attributes. Exactly one of `value` or `group_values` must not be empty.
    /// </summary>
    public class CustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Subattributes within this attribute group. If `group_values` is not empty, `value` must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupValues")]
        public virtual System.Collections.Generic.IList<CustomAttribute> GroupValues { get; set; }

        /// <summary>The name of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The value of the attribute. If `value` is not empty, `group_values` must be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The destination status of the product status.</summary>
    public class DestinationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the offer is approved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvedCountries")]
        public virtual System.Collections.Generic.IList<string> ApprovedCountries { get; set; }

        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the offer is disapproved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovedCountries")]
        public virtual System.Collections.Generic.IList<string> DisapprovedCountries { get; set; }

        /// <summary>List of country codes (ISO 3166-1 alpha-2) where the offer is pending approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingCountries")]
        public virtual System.Collections.Generic.IList<string> PendingCountries { get; set; }

        /// <summary>The name of the reporting context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

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

    /// <summary>Conditions to be met for a product to have free shipping.</summary>
    public class FreeShippingThreshold : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [CLDR territory code](http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml) of the country
        /// to which an item will ship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        /// <summary>The minimum product price for the shipping cost to become free. Represented as a number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceThreshold")]
        public virtual Price PriceThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message that represents installment.</summary>
    public class Installment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount the buyer has to pay per month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; }

        /// <summary>Type of installment payments. Supported values are: * "`finance`" * "`lease`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creditType")]
        public virtual string CreditType { get; set; }

        /// <summary>The up-front down payment amount the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downpayment")]
        public virtual Price Downpayment { get; set; }

        /// <summary>The number of installments the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("months")]
        public virtual System.Nullable<long> Months { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class Interval : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be
        /// before the end.
        /// </summary>
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
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be
        /// the same or after the start.
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

    /// <summary>The ItemLevelIssue of the product status.</summary>
    public class ItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of country codes (ISO 3166-1 alpha-2) where issue applies to the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableCountries")]
        public virtual System.Collections.Generic.IList<string> ApplicableCountries { get; set; }

        /// <summary>The attribute's name, if the issue is caused by a single attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>The error code of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A short issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>A detailed issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The URL of a web page to help with resolving this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; }

        /// <summary>The reporting context the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>How this issue affects serving of the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListProducts method.</summary>
    public class ListProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The processed products from the specified account. These are your processed products after applying rules
        /// and supplemental data sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<Product> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message that represents loyalty points.</summary>
    public class LoyaltyPoints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of loyalty points program. It is recommended to limit the name to 12 full-width characters or 24 Roman
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The retailer's loyalty points in absolute value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointsValue")]
        public virtual System.Nullable<long> PointsValue { get; set; }

        /// <summary>
        /// The ratio of a point when converted to currency. Google assumes currency based on Merchant Center settings.
        /// If ratio is left out, it defaults to 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratio")]
        public virtual System.Nullable<double> Ratio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message that represents loyalty program.</summary>
    public class LoyaltyProgram : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cashback that can be used for future purchases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cashbackForFutureUse")]
        public virtual Price CashbackForFutureUse { get; set; }

        /// <summary>The amount of loyalty points earned on a purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loyaltyPoints")]
        public virtual System.Nullable<long> LoyaltyPoints { get; set; }

        /// <summary>
        /// A date range during which the item is eligible for member price. If not specified, the member price is
        /// always applicable. The date range is represented by a pair of ISO 8601 dates separated by a space, comma, or
        /// slash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberPriceEffectiveDate")]
        public virtual Interval MemberPriceEffectiveDate { get; set; }

        /// <summary>
        /// The price for members of the given tier, that is, the instant discount price. Must be smaller or equal to
        /// the regular price.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>
        /// The label of the loyalty program. This is an internal label that uniquely identifies the relationship
        /// between a merchant entity and a loyalty program entity. The label must be provided so that the system can
        /// associate the assets below (for example, price and points) with a merchant. The corresponding program must
        /// be linked to the merchant account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("programLabel")]
        public virtual string ProgramLabel { get; set; }

        /// <summary>
        /// The label of the shipping benefit. If the field has value, this offer has loyalty shipping benefit. If the
        /// field value isn't provided, the item is not eligible for loyalty shipping for the given loyalty tier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingLabel")]
        public virtual string ShippingLabel { get; set; }

        /// <summary>
        /// The label of the tier within the loyalty program. Must match one of the labels within the program.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tierLabel")]
        public virtual string TierLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price represented as a number and currency.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The price represented as a number in micros (1 million micros is an equivalent to one's currency standard
        /// unit, for example, 1 USD = 1000000 micros).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>
        /// The currency of the price using three-letter acronyms according to [ISO
        /// 4217](http://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The processed product, built from multiple product inputs after applying rules and supplemental data sources.
    /// This processed product matches what is shown in your Merchant Center account and in Shopping ads and other
    /// surfaces across Google. Each product is built from exactly one primary data source product input, and multiple
    /// supplemental data source inputs. After inserting, updating, or deleting a product input, it may take several
    /// minutes before the updated processed product can be retrieved. All fields in the processed product and its
    /// sub-messages match the name of their corresponding attribute in the [Product data
    /// specification](https://support.google.com/merchants/answer/7052112) with some exceptions.
    /// </summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A list of product attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// Output only. The [channel](https://support.google.com/merchants/answer/7361332) of the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// Output only. The two-letter [ISO 639-1](http://en.wikipedia.org/wiki/ISO_639-1) language code for the
        /// product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Output only. A list of custom (merchant-provided) attributes. It can also be used to submit any attribute of
        /// the data specification in its generic form (for example, `{ "name": "size type", "value": "regular" }`).
        /// This is useful for submitting attributes not explicitly exposed by the API, such as additional attributes
        /// used for Buy on Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>Output only. The primary data source of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>Output only. The feed label for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>
        /// The name of the product. Format: `"{product.name=accounts/{account}/products/{product}}"` where the last
        /// section `product` consists of 4 parts: channel~content_language~feed_label~offer_id example for product name
        /// is "accounts/123/products/online~en~US~sku123"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Your unique identifier for the product. This is the same for the product input and processed
        /// product. Leading and trailing whitespaces are stripped and multiple whitespaces are replaced by a single
        /// whitespace upon submission. See the [product data
        /// specification](https://support.google.com/merchants/answer/188494#id) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>
        /// Output only. The status of a product, data validation issues, that is, information about a product computed
        /// asynchronously.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productStatus")]
        public virtual ProductStatus ProductStatus { get; set; }

        /// <summary>
        /// Output only. Represents the existing version (freshness) of the product, which can be used to preserve the
        /// right order when multiple updates are done at the same time. If set, the insertion is prevented when version
        /// number is lower than the current version number of the existing product. Re-insertion (for example, product
        /// refresh after 30 days) can be performed with the current `version_number`. Only supported for insertions
        /// into primary data sources. If the operation is prevented, the aborted exception will be thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionNumber")]
        public virtual System.Nullable<long> VersionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The change that happened to the product including old value, new value, country code as the region code and
    /// reporting context.
    /// </summary>
    public class ProductChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new value of the changed resource or attribute. If empty, it means that the product was deleted. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>
        /// The old value of the changed resource or attribute. If empty, it means that the product was created. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>Countries that have the change (if applicable). Represented in the ISO 3166 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Reporting contexts that have the change (if applicable). Currently this field supports only (`SHOPPING_ADS`,
        /// `LOCAL_INVENTORY_ADS`, `YOUTUBE_SHOPPING`, `YOUTUBE_CHECKOUT`, `YOUTUBE_AFFILIATE`) from the enum value
        /// [ReportingContextEnum](/merchant/api/reference/rest/Shared.Types/ReportingContextEnum)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The product details.</summary>
    public class ProductDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the product detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeName")]
        public virtual string AttributeName { get; set; }

        /// <summary>The value of the product detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeValue")]
        public virtual string AttributeValue { get; set; }

        /// <summary>The section header used to group a set of product details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionName")]
        public virtual string SectionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The dimension of the product.</summary>
    public class ProductDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The dimension units. Acceptable values are: * "`in`" * "`cm`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Required. The dimension value represented as a number. The value can have a maximum precision of four
        /// decimal places.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This resource represents input data you submit for a product, not the processed product that you see in Merchant
    /// Center, in Shopping ads, or across Google surfaces. Product inputs, rules and supplemental data source data are
    /// combined to create the processed Product. Required product input attributes to pass data validation checks are
    /// primarily defined in the [Products Data Specification](https://support.google.com/merchants/answer/188494). The
    /// following attributes are required: feedLabel, contentLanguage and offerId. After inserting, updating, or
    /// deleting a product input, it may take several minutes before the processed product can be retrieved. All fields
    /// in the product input and its sub-messages match the English name of their corresponding attribute in the
    /// vertical spec with [some exceptions](https://support.google.com/merchants/answer/7052112).
    /// </summary>
    public class ProductInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of product attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// Immutable. The [channel](https://support.google.com/merchants/answer/7361332) of the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// Required. Immutable. The two-letter [ISO 639-1](http://en.wikipedia.org/wiki/ISO_639-1) language code for
        /// the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Optional. A list of custom (merchant-provided) attributes. It can also be used for submitting any attribute
        /// of the data specification in its generic form (for example, `{ "name": "size type", "value": "regular" }`).
        /// This is useful for submitting attributes not explicitly exposed by the API, such as additional attributes
        /// used for Buy on Google. Maximum allowed number of characters for each custom attribute is 10240 (represents
        /// sum of characters for name and value). Maximum 2500 custom attributes can be set per product, with total
        /// size of 102.4kB. Underscores in custom attribute names are replaced by spaces upon insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>
        /// Required. Immutable. The [feed
        /// label](https://developers.google.com/shopping-content/guides/products/feed-labels) for the product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>
        /// Identifier. The name of the product input. Format:
        /// `"{productinput.name=accounts/{account}/productInputs/{productinput}}"` where the last section
        /// `productinput` consists of 4 parts: channel~content_language~feed_label~offer_id example for product input
        /// name is "accounts/123/productInputs/online~en~US~sku123"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. Your unique identifier for the product. This is the same for the product input and
        /// processed product. Leading and trailing whitespaces are stripped and multiple whitespaces are replaced by a
        /// single whitespace upon submission. See the [products data
        /// specification](https://support.google.com/merchants/answer/188494#id) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>
        /// Output only. The name of the processed product. Format:
        /// `"{product.name=accounts/{account}/products/{product}}"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>
        /// Optional. Represents the existing version (freshness) of the product, which can be used to preserve the
        /// right order when multiple updates are done at the same time. If set, the insertion is prevented when version
        /// number is lower than the current version number of the existing product. Re-insertion (for example, product
        /// refresh after 30 days) can be performed with the current `version_number`. Only supported for insertions
        /// into primary data sources. If the operation is prevented, the aborted exception will be thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionNumber")]
        public virtual System.Nullable<long> VersionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of a product, data validation issues, that is, information about a product computed asynchronously.
    /// </summary>
    public class ProductStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _creationDateRaw;

        private object _creationDate;

        /// <summary>
        /// Date on which the item has been created, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDate")]
        public virtual string CreationDateRaw
        {
            get => _creationDateRaw;
            set
            {
                _creationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationDateDateTimeOffset instead.")]
        public virtual object CreationDate
        {
            get => _creationDate;
            set
            {
                _creationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationDate = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationDateRaw);
            set => CreationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The intended destinations for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStatuses")]
        public virtual System.Collections.Generic.IList<DestinationStatus> DestinationStatuses { get; set; }

        private string _googleExpirationDateRaw;

        private object _googleExpirationDate;

        /// <summary>
        /// Date on which the item expires, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleExpirationDate")]
        public virtual string GoogleExpirationDateRaw
        {
            get => _googleExpirationDateRaw;
            set
            {
                _googleExpirationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _googleExpirationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="GoogleExpirationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use GoogleExpirationDateDateTimeOffset instead.")]
        public virtual object GoogleExpirationDate
        {
            get => _googleExpirationDate;
            set
            {
                _googleExpirationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _googleExpirationDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="GoogleExpirationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? GoogleExpirationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(GoogleExpirationDateRaw);
            set => GoogleExpirationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A list of all issues associated with the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<ItemLevelIssue> ItemLevelIssues { get; set; }

        private string _lastUpdateDateRaw;

        private object _lastUpdateDate;

        /// <summary>
        /// Date on which the item has been last updated, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateDate")]
        public virtual string LastUpdateDateRaw
        {
            get => _lastUpdateDateRaw;
            set
            {
                _lastUpdateDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateDateDateTimeOffset instead.")]
        public virtual object LastUpdateDate
        {
            get => _lastUpdateDate;
            set
            {
                _lastUpdateDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateDateRaw);
            set => LastUpdateDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message that the merchant will receive to notify about product status change event</summary>
    public class ProductStatusChangeMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target account that owns the entity that changed. Format : `accounts/{merchant_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>The attribute in the resource that changed, in this case it will be always `Status`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>A message to describe the change that happened to the product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<ProductChange> Changes { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>The time at which the event was generated.</summary>
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

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// Optional. The product expiration time. This field will not bet set if the notification is sent for a product
        /// deletion event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The account that manages the merchant's account. can be the same as merchant id if it is standalone account.
        /// Format : `accounts/{service_provider_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managingAccount")]
        public virtual string ManagingAccount { get; set; }

        /// <summary>The product name. Format: `accounts/{account}/products/{product}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The product id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The resource that changed, in this case it will always be `Product`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured description, for algorithmically (AI)-generated descriptions.</summary>
    public class ProductStructuredDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description text Maximum length is 5000 characters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The digital source type, for example "trained_algorithmic_media". Following
        /// [IPTC](https://cv.iptc.org/newscodes/digitalsourcetype). Maximum length is 40 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digitalSourceType")]
        public virtual string DigitalSourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured title, for algorithmically (AI)-generated titles.</summary>
    public class ProductStructuredTitle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The title text Maximum length is 150 characters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The digital source type, for example "trained_algorithmic_media". Following
        /// [IPTC](https://cv.iptc.org/newscodes/digitalsourcetype). Maximum length is 40 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digitalSourceType")]
        public virtual string DigitalSourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information regarding sustainability-related incentive programs such as rebates or tax relief.
    /// </summary>
    public class ProductSustainabilityIncentive : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fixed amount of the incentive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; }

        /// <summary>The percentage of the sale price that the incentive is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<double> Percentage { get; set; }

        /// <summary>Sustainability incentive program.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The weight of the product.</summary>
    public class ProductWeight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The weight unit. Acceptable values are: * "`g`" * "`kg`" * "`oz`" * "`lb`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Required. The weight represented as a number. The weight can have a maximum precision of four decimal
        /// places.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Shipping of the product.</summary>
    public class Shipping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [CLDR territory code](http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml) of the country
        /// to which an item will ship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        /// <summary>The location where the shipping is applicable, represented by a location group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationGroupName")]
        public virtual string LocationGroupName { get; set; }

        /// <summary>
        /// The numeric ID of a location that the shipping rate applies to as defined in the [AdWords
        /// API](https://developers.google.com/adwords/api/docs/appendix/geotargeting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual System.Nullable<long> LocationId { get; set; }

        /// <summary>
        /// Maximum handling time (inclusive) between when the order is received and shipped in business days. 0 means
        /// that the order is shipped on the same day as it is received if it happens before the cut-off time. Both
        /// maxHandlingTime and maxTransitTime are required if providing shipping speeds. minHandlingTime is optional if
        /// maxHandlingTime is present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxHandlingTime")]
        public virtual System.Nullable<long> MaxHandlingTime { get; set; }

        /// <summary>
        /// Maximum transit time (inclusive) between when the order has shipped and when it is delivered in business
        /// days. 0 means that the order is delivered on the same day as it ships. Both maxHandlingTime and
        /// maxTransitTime are required if providing shipping speeds. minTransitTime is optional if maxTransitTime is
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTransitTime")]
        public virtual System.Nullable<long> MaxTransitTime { get; set; }

        /// <summary>
        /// Minimum handling time (inclusive) between when the order is received and shipped in business days. 0 means
        /// that the order is shipped on the same day as it is received if it happens before the cut-off time.
        /// minHandlingTime can only be present together with maxHandlingTime; but it is not required if maxHandlingTime
        /// is present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minHandlingTime")]
        public virtual System.Nullable<long> MinHandlingTime { get; set; }

        /// <summary>
        /// Minimum transit time (inclusive) between when the order has shipped and when it is delivered in business
        /// days. 0 means that the order is delivered on the same day as it ships. minTransitTime can only be present
        /// together with maxTransitTime; but it is not required if maxTransitTime is present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTransitTime")]
        public virtual System.Nullable<long> MinTransitTime { get; set; }

        /// <summary>
        /// The postal code range that the shipping rate applies to, represented by a postal code, a postal code prefix
        /// followed by a * wildcard, a range between two postal codes or two postal code prefixes of equal length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>Fixed shipping price, represented as a number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>
        /// The geographic region to which a shipping rate applies. See
        /// [region](https://support.google.com/merchants/answer/6324484) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>A free-form description of the service class or delivery speed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ShippingDimension of the product.</summary>
    public class ShippingDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The dimension of the product used to calculate the shipping cost of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ShippingWeight of the product.</summary>
    public class ShippingWeight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The weight of the product used to calculate the shipping cost of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The SubscriptionCost of the product.</summary>
    public class SubscriptionCost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount the buyer has to pay per subscription period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual Price Amount { get; set; }

        /// <summary>The type of subscription period. Supported values are: * "`month`" * "`year`"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual string Period { get; set; }

        /// <summary>The number of subscription periods the buyer has to pay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodLength")]
        public virtual System.Nullable<long> PeriodLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Tax of the product.</summary>
    public class Tax : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The country within which the item is taxed, specified as a [CLDR territory
        /// code](http://www.unicode.org/repos/cldr/tags/latest/common/main/en.xml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; }

        /// <summary>
        /// The numeric ID of a location that the tax rate applies to as defined in the [AdWords
        /// API](https://developers.google.com/adwords/api/docs/appendix/geotargeting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual System.Nullable<long> LocationId { get; set; }

        /// <summary>
        /// The postal code range that the tax rate applies to, represented by a ZIP code, a ZIP code prefix using *
        /// wildcard, a range between two ZIP codes or two ZIP code prefixes of equal length. Examples: 94114, 94*,
        /// 94002-95460, 94*-95*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>The percentage of tax rate that applies to the item price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual System.Nullable<double> Rate { get; set; }

        /// <summary>The geographic region to which the tax rate applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Set to true if tax is charged on shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxShip")]
        public virtual System.Nullable<bool> TaxShip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The UnitPricingBaseMeasure of the product.</summary>
    public class UnitPricingBaseMeasure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of the denominator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The denominator of the unit price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The UnitPricingMeasure of the product.</summary>
    public class UnitPricingMeasure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unit of the measure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The measure of an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
