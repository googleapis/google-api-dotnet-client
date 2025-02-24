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

namespace Google.Apis.Merchant.promotions_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "promotions_v1beta";

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
            Promotions = new PromotionsResource(service);
        }

        /// <summary>Gets the Promotions resource.</summary>
        public virtual PromotionsResource Promotions { get; }

        /// <summary>The "promotions" collection of methods.</summary>
        public class PromotionsResource
        {
            private const string Resource = "promotions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PromotionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Retrieves the promotion from your Merchant Center account. After inserting or updating a promotion
            /// input, it may take several minutes before the updated promotion can be retrieved.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the promotion to retrieve. Format: `accounts/{account}/promotions/{promotions}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Retrieves the promotion from your Merchant Center account. After inserting or updating a promotion
            /// input, it may take several minutes before the updated promotion can be retrieved.
            /// </summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.promotions_v1beta.Data.Promotion>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the promotion to retrieve. Format:
                /// `accounts/{account}/promotions/{promotions}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "promotions/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/promotions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Inserts a promotion for your Merchant Center account. If the promotion already exists, then it updates
            /// the promotion instead.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account where the promotion will be inserted. Format: accounts/{account}
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.promotions_v1beta.Data.InsertPromotionRequest body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>
            /// Inserts a promotion for your Merchant Center account. If the promotion already exists, then it updates
            /// the promotion instead.
            /// </summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.promotions_v1beta.Data.Promotion>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.promotions_v1beta.Data.InsertPromotionRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account where the promotion will be inserted. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.promotions_v1beta.Data.InsertPromotionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "promotions/v1beta/{+parent}/promotions:insert";

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
                }
            }

            /// <summary>
            /// Lists the promotions in your Merchant Center account. The response might contain fewer items than
            /// specified by `pageSize`. Rely on `pageToken` to determine if there are more items to be requested. After
            /// inserting or updating a promotion, it may take several minutes before the updated processed promotion
            /// can be retrieved.
            /// </summary>
            /// <param name="parent">
            /// Required. The account to list processed promotions for. Format: `accounts/{account}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the promotions in your Merchant Center account. The response might contain fewer items than
            /// specified by `pageSize`. Rely on `pageToken` to determine if there are more items to be requested. After
            /// inserting or updating a promotion, it may take several minutes before the updated processed promotion
            /// can be retrieved.
            /// </summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.promotions_v1beta.Data.ListPromotionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account to list processed promotions for. Format: `accounts/{account}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Output only. The maximum number of promotions to return. The service may return fewer than this
                /// value. The maximum value is 250; values above 250 will be coerced to 250. If unspecified, the
                /// maximum number of promotions will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Output only. A page token, received from a previous `ListPromotions` call. Provide this to retrieve
                /// the subsequent page. When paginating, all other parameters provided to `ListPromotions` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "promotions/v1beta/{+parent}/promotions";

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
namespace Google.Apis.Merchant.promotions_v1beta.Data
{
    /// <summary>Attributes.</summary>
    public class Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Product filter by [brand
        /// exclusion](https://support.google.com/merchants/answer/13861679?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion. The product filter attributes only applies when the products eligible for promotion
        /// product applicability `product_applicability` attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandExclusion")]
        public virtual System.Collections.Generic.IList<string> BrandExclusion { get; set; }

        /// <summary>
        /// Optional. Product filter by brand for the promotion. The product filter attributes only applies when the
        /// products eligible for promotion product applicability `product_applicability` attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandInclusion")]
        public virtual System.Collections.Generic.IList<string> BrandInclusion { get; set; }

        /// <summary>
        /// Required. The [coupon value type]
        /// (https://support.google.com/merchants/answer/13861986?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// attribute to signal the type of promotion that you are running. Depending on type of the selected coupon
        /// value [some attributes are required](https://support.google.com/merchants/answer/6393006?ref_topic=7322920).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("couponValueType")]
        public virtual string CouponValueType { get; set; }

        /// <summary>
        /// Optional. [Free gift
        /// description](https://support.google.com/merchants/answer/13847245?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeGiftDescription")]
        public virtual string FreeGiftDescription { get; set; }

        /// <summary>
        /// Optional. [Free gift item
        /// ID](https://support.google.com/merchants/answer/13857152?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeGiftItemId")]
        public virtual string FreeGiftItemId { get; set; }

        /// <summary>
        /// Optional. [Free gift
        /// value](https://support.google.com/merchants/answer/13844477?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeGiftValue")]
        public virtual Price FreeGiftValue { get; set; }

        /// <summary>
        /// Optional. Generic redemption code for the promotion. To be used with the `offerType` field and must meet the
        /// [minimum
        /// requirements](https://support.google.com/merchants/answer/13837405?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericRedemptionCode")]
        public virtual string GenericRedemptionCode { get; set; }

        /// <summary>
        /// Optional. The number of items discounted in the promotion. The attribute is set when `couponValueType` is
        /// equal to `buy_m_get_n_money_off` or `buy_m_get_n_percent_off`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("getThisQuantityDiscounted")]
        public virtual System.Nullable<long> GetThisQuantityDiscounted { get; set; }

        /// <summary>
        /// Optional. Product filter by [item group
        /// ID](https://support.google.com/merchants/answer/13837298?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// The product filter attributes only applies when the products eligible for promotion product applicability
        /// `product_applicability` attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// exclusion for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupIdExclusion")]
        public virtual System.Collections.Generic.IList<string> ItemGroupIdExclusion { get; set; }

        /// <summary>
        /// Optional. Product filter by item group ID for the promotion. The product filter attributes only applies when
        /// the products eligible for promotion product applicability [product_applicability] attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupIdInclusion")]
        public virtual System.Collections.Generic.IList<string> ItemGroupIdInclusion { get; set; }

        /// <summary>
        /// Optional. Product filter by [item ID
        /// exclusion](https://support.google.com/merchants/answer/13863524?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion. The product filter attributes only applies when the products eligible for promotion
        /// product applicability `product_applicability` attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemIdExclusion")]
        public virtual System.Collections.Generic.IList<string> ItemIdExclusion { get; set; }

        /// <summary>
        /// Optional. Product filter by [item
        /// ID](https://support.google.com/merchants/answer/13861565?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion. The product filter attributes only applies when the products eligible for promotion
        /// product applicability `product_applicability` attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemIdInclusion")]
        public virtual System.Collections.Generic.IList<string> ItemIdInclusion { get; set; }

        /// <summary>
        /// Optional. [Maximum purchase
        /// quantity](https://support.google.com/merchants/answer/13861564?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitQuantity")]
        public virtual System.Nullable<long> LimitQuantity { get; set; }

        /// <summary>
        /// Optional. [Maximum product price](https://support.google.com/merchants/answer/2906014) for promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitValue")]
        public virtual Price LimitValue { get; set; }

        /// <summary>
        /// Required. [Long
        /// title](https://support.google.com/merchants/answer/13838102?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longTitle")]
        public virtual string LongTitle { get; set; }

        /// <summary>
        /// Optional. [Minimum purchase
        /// amount](https://support.google.com/merchants/answer/13837705?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumPurchaseAmount")]
        public virtual Price MinimumPurchaseAmount { get; set; }

        /// <summary>
        /// Optional. [Minimum purchase
        /// quantity](https://support.google.com/merchants/answer/13838182?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumPurchaseQuantity")]
        public virtual System.Nullable<long> MinimumPurchaseQuantity { get; set; }

        /// <summary>
        /// Optional. The [money off
        /// amount](https://support.google.com/merchants/answer/13838101?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// offered in the promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moneyOffAmount")]
        public virtual Price MoneyOffAmount { get; set; }

        /// <summary>
        /// Required.
        /// [Type](https://support.google.com/merchants/answer/13837405?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// of the promotion. Use this attribute to indicate whether or not customers need a coupon code to redeem your
        /// promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerType")]
        public virtual string OfferType { get; set; }

        /// <summary>
        /// Optional. The [percentage
        /// discount](https://support.google.com/merchants/answer/13837404?sjid=17642868584668136159-NC) offered in the
        /// promotion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentOff")]
        public virtual System.Nullable<long> PercentOff { get; set; }

        /// <summary>
        /// Required. Applicability of the promotion to either all products or [only specific
        /// products](https://support.google.com/merchants/answer/6396257?ref_topic=6396150&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productApplicability")]
        public virtual string ProductApplicability { get; set; }

        /// <summary>
        /// Optional. Product filter by [product type
        /// exclusion](https://support.google.com/merchants/answer/13863746?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion. The product filter attributes only applies when the products eligible for promotion
        /// product applicability `product_applicability` attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeExclusion")]
        public virtual System.Collections.Generic.IList<string> ProductTypeExclusion { get; set; }

        /// <summary>
        /// Optional. Product filter by product type for the promotion. The product filter attributes only applies when
        /// the products eligible for promotion product applicability `product_applicability` attribute is set to
        /// [specific_products](https://support.google.com/merchants/answer/13837299?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeInclusion")]
        public virtual System.Collections.Generic.IList<string> ProductTypeInclusion { get; set; }

        /// <summary>
        /// Required. The list of destinations where the promotion applies to. If you don't specify a destination by
        /// including a supported value in your data source, your promotion will display in Shopping ads and free
        /// listings by default. You may have previously submitted the following values as destinations for your
        /// products: Shopping Actions, Surfaces across Google, Local surfaces across Google. To represent these values
        /// use `FREE_LISTINGS`, `FREE_LOCAL_LISTINGS`, `LOCAL_INVENTORY_ADS`. For more details see [Promotion
        /// destination](https://support.google.com/merchants/answer/13837465?sjid=5155774230887277618-NC)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionDestinations")]
        public virtual System.Collections.Generic.IList<string> PromotionDestinations { get; set; }

        /// <summary>
        /// Optional. `TimePeriod` representation of the promotion's display dates. This attribute specifies the date
        /// and time frame when the promotion will be live on Google.com and Shopping ads. If the display time period
        /// for promotion `promotion_display_time_period` attribute is not specified, the promotion effective time
        /// period `promotion_effective_time_period` determines the date and time frame when the promotion will be live
        /// on Google.com and Shopping ads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionDisplayTimePeriod")]
        public virtual Interval PromotionDisplayTimePeriod { get; set; }

        /// <summary>
        /// Required. `TimePeriod` representation of the promotion's effective dates. This attribute specifies that the
        /// promotion can be tested on your online store during this time period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionEffectiveTimePeriod")]
        public virtual Interval PromotionEffectiveTimePeriod { get; set; }

        /// <summary>
        /// Optional. URL to the page on the merchant's site where the promotion shows. Local Inventory ads promotions
        /// throw an error if no `promotion_url` is included. URL is used to confirm that the promotion is valid and can
        /// be redeemed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionUrl")]
        public virtual string PromotionUrl { get; set; }

        /// <summary>
        /// Optional. Whether the promotion applies to [all stores, or only specified
        /// stores](https://support.google.com/merchants/answer/13857563?sjid=17642868584668136159-NC). Local Inventory
        /// ads promotions throw an error if no store applicability is included. An `INVALID_ARGUMENT` error is thrown
        /// if `store_applicability` is set to `ALL_STORES` and `store_codes_inclusion` or `score_code_exclusion` is set
        /// to a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeApplicability")]
        public virtual string StoreApplicability { get; set; }

        /// <summary>
        /// Optional. [Store codes to
        /// exclude](https://support.google.com/merchants/answer/13859586?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion. The store filter attributes only applies when the `store_applicability` attribute is set
        /// to
        /// [specific_stores](https://support.google.com/merchants/answer/13857563?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCodesExclusion")]
        public virtual System.Collections.Generic.IList<string> StoreCodesExclusion { get; set; }

        /// <summary>
        /// Optional. [Store codes to
        /// include](https://support.google.com/merchants/answer/13857470?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion. The store filter attributes only applies when the `store_applicability` attribute is set
        /// to
        /// [specific_stores](https://support.google.com/merchants/answer/13857563?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC).
        /// Store code (the store ID from your Business Profile) of the physical store the product is sold in. See the
        /// [Local product inventory data specification](https://support.google.com/merchants/answer/3061342) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCodesInclusion")]
        public virtual System.Collections.Generic.IList<string> StoreCodesInclusion { get; set; }

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

    /// <summary>The status for the specified destination.</summary>
    public class DestinationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the promotion destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>Output only. The status for the specified destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the `InsertPromotion` method.</summary>
    public class InsertPromotionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The data source of the
        /// [promotion](https://support.google.com/merchants/answer/6396268?sjid=5155774230887277618-NC) Format:
        /// `accounts/{account}/dataSources/{datasource}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>Required. The promotion to insert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotion")]
        public virtual Promotion Promotion { get; set; }

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

    /// <summary>The issue associated with the promotion.</summary>
    public class ItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of country codes (ISO 3166-1 alpha-2) where issue applies to the offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableCountries")]
        public virtual System.Collections.Generic.IList<string> ApplicableCountries { get; set; }

        /// <summary>Output only. The attribute's name, if the issue is caused by a single attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>Output only. The error code of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Output only. A short issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. A detailed issue description in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>Output only. The URL of a web page to help with resolving this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual string Documentation { get; set; }

        /// <summary>Output only. The destination the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>Output only. Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>Output only. How this issue affects serving of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListPromotions` method.</summary>
    public class ListPromotionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The processed promotions from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<Promotion> Promotions { get; set; }

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
    /// The change that happened to the product including old value, new value, country code as the region code and
    /// reporting context.
    /// </summary>
    public class ProductChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new value of the changed resource or attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>The old value of the changed resource or attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>Countries that have the change (if applicable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Reporting contexts that have the change (if applicable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

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
        /// The product expiration time. This field will not bet set if the notification is sent for a product deletion
        /// event.
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

        /// <summary>The product name. Format: `{product.name=accounts/{account}/products/{product}}`</summary>
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

    /// <summary>
    /// Represents a promotion. See the following articles for more details. Required promotion input attributes to pass
    /// data validation checks are primarily defined below: * [Promotions data
    /// specification](https://support.google.com/merchants/answer/2906014) * [Local promotions data
    /// specification](https://support.google.com/merchants/answer/10146130) After inserting, updating a promotion
    /// input, it may take several minutes before the final promotion can be retrieved.
    /// </summary>
    public class Promotion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of promotion attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// Required. The two-letter [ISO 639-1](http://en.wikipedia.org/wiki/ISO_639-1) language code for the
        /// promotion. Promotions is only for [selected
        /// languages](https://support.google.com/merchants/answer/4588281?ref_topic=6396150&amp;amp;sjid=18314938579342094533-NC#option3&amp;amp;zippy=).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Optional. A list of custom (merchant-provided) attributes. It can also be used for submitting any attribute
        /// of the data specification in its generic form (for example, `{ "name": "size type", "value": "regular" }`).
        /// This is useful for submitting attributes not explicitly exposed by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>Output only. The primary data source of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>
        /// Identifier. The name of the promotion. Format: `accounts/{account}/promotions/{promotion}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The user provided promotion ID to uniquely identify the promotion. Follow [minimum
        /// requirements](https://support.google.com/merchants/answer/7050148?ref_topic=7322920&amp;amp;sjid=871860036916537104-NC#minimum_requirements)
        /// to prevent promotion disapprovals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionId")]
        public virtual string PromotionId { get; set; }

        /// <summary>
        /// Output only. The [status of a
        /// promotion](https://support.google.com/merchants/answer/3398326?ref_topic=7322924&amp;amp;sjid=5155774230887277618-NC),
        /// data validation issues, that is, information about a promotion computed asynchronously.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionStatus")]
        public virtual PromotionStatus PromotionStatus { get; set; }

        /// <summary>
        /// Required. [Redemption
        /// channel](https://support.google.com/merchants/answer/13837674?ref_topic=13773355&amp;amp;sjid=17642868584668136159-NC)
        /// for the promotion. At least one channel is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redemptionChannel")]
        public virtual System.Collections.Generic.IList<string> RedemptionChannel { get; set; }

        /// <summary>
        /// Required. The target country used as part of the unique identifier. Represented as a [CLDR territory
        /// code](https://github.com/unicode-org/cldr/blob/latest/common/main/en.xml). Promotions are only available in
        /// selected countries, [Free Listings and Shopping ads](https://support.google.com/merchants/answer/4588460)
        /// [Local Inventory ads](https://support.google.com/merchants/answer/10146326)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; }

        /// <summary>
        /// Optional. Represents the existing version (freshness) of the promotion, which can be used to preserve the
        /// right order when multiple updates are done at the same time. If set, the insertion is prevented when version
        /// number is lower than the current version number of the existing promotion. Re-insertion (for example,
        /// promotion refresh after 30 days) can be performed with the current `version_number`. If the operation is
        /// prevented, the aborted exception will be thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionNumber")]
        public virtual System.Nullable<long> VersionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the promotion.</summary>
    public class PromotionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _creationDateRaw;

        private object _creationDate;

        /// <summary>
        /// Output only. Date on which the promotion has been created in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format: Date, time, and offset, for example
        /// `2020-01-02T09:00:00+01:00` or `2020-01-02T09:00:00Z`
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

        /// <summary>Output only. The intended destinations for the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStatuses")]
        public virtual System.Collections.Generic.IList<DestinationStatus> DestinationStatuses { get; set; }

        /// <summary>Output only. A list of issues associated with the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<ItemLevelIssue> ItemLevelIssues { get; set; }

        private string _lastUpdateDateRaw;

        private object _lastUpdateDate;

        /// <summary>
        /// Output only. Date on which the promotion status has been last updated in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format: Date, time, and offset, for example
        /// `2020-01-02T09:00:00+01:00` or `2020-01-02T09:00:00Z`
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
}
