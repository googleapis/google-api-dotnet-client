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

namespace Google.Apis.Merchant.reviews_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "reviews_v1beta";

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
            MerchantReviews = new MerchantReviewsResource(service);
            ProductReviews = new ProductReviewsResource(service);
        }

        /// <summary>Gets the MerchantReviews resource.</summary>
        public virtual MerchantReviewsResource MerchantReviews { get; }

        /// <summary>The "merchantReviews" collection of methods.</summary>
        public class MerchantReviewsResource
        {
            private const string Resource = "merchantReviews";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MerchantReviewsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes merchant review.</summary>
            /// <param name="name">
            /// Required. The ID of the merchant review. Format: accounts/{account}/merchantReviews/{merchantReview}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes merchant review.</summary>
            public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ID of the merchant review. Format: accounts/{account}/merchantReviews/{merchantReview}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/merchantReviews/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a merchant review.</summary>
            /// <param name="name">
            /// Required. The ID of the merchant review. Format: accounts/{account}/merchantReviews/{merchantReview}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a merchant review.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.MerchantReview>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ID of the merchant review. Format: accounts/{account}/merchantReviews/{merchantReview}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/merchantReviews/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Inserts a review for your Merchant Center account. If the review already exists, then the review is
            /// replaced with the new instance.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account where the merchant review will be inserted. Format: accounts/{account}
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.reviews_v1beta.Data.MerchantReview body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>
            /// Inserts a review for your Merchant Center account. If the review already exists, then the review is
            /// replaced with the new instance.
            /// </summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.MerchantReview>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.reviews_v1beta.Data.MerchantReview body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account where the merchant review will be inserted. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The data source of the
                /// [merchantreview](https://support.google.com/merchants/answer/7045996?sjid=5253581244217581976-EU)
                /// Format: `accounts/{account}/dataSources/{datasource}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DataSource { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.reviews_v1beta.Data.MerchantReview Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+parent}/merchantReviews:insert";

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

            /// <summary>Lists merchant reviews.</summary>
            /// <param name="parent">
            /// Required. The account to list merchant reviews for. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists merchant reviews.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.ListMerchantReviewsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The account to list merchant reviews for. Format: accounts/{account}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of merchant reviews to return. The service can return fewer than this
                /// value. The maximum value is 1000; values above 1000 are coerced to 1000. If unspecified, the maximum
                /// number of reviews is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListMerchantReviews` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListMerchantReviews` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+parent}/merchantReviews";

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

        /// <summary>Gets the ProductReviews resource.</summary>
        public virtual ProductReviewsResource ProductReviews { get; }

        /// <summary>The "productReviews" collection of methods.</summary>
        public class ProductReviewsResource
        {
            private const string Resource = "productReviews";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductReviewsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a product review.</summary>
            /// <param name="name">
            /// Required. The ID of the Product review. Format: accounts/{account}/productReviews/{productReview}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a product review.</summary>
            public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ID of the Product review. Format: accounts/{account}/productReviews/{productReview}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/productReviews/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a product review.</summary>
            /// <param name="name">
            /// Required. The ID of the merchant review. Format: accounts/{account}/productReviews/{productReview}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a product review.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.ProductReview>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ID of the merchant review. Format: accounts/{account}/productReviews/{productReview}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/productReviews/[^/]+$",
                    });
                }
            }

            /// <summary>Inserts a product review.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The account where the product review will be inserted. Format: accounts/{account}
            /// </param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.reviews_v1beta.Data.ProductReview body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>Inserts a product review.</summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.ProductReview>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.reviews_v1beta.Data.ProductReview body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The account where the product review will be inserted. Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Required. Format: `accounts/{account}/dataSources/{datasource}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DataSource { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.reviews_v1beta.Data.ProductReview Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+parent}/productReviews:insert";

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

            /// <summary>Lists product reviews.</summary>
            /// <param name="parent">
            /// Required. The account to list product reviews for. Format: accounts/{account}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists product reviews.</summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reviews_v1beta.Data.ListProductReviewsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The account to list product reviews for. Format: accounts/{account}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of products to return. The service may return fewer than this value.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListProductReviews` call. Provide this to retrieve
                /// the subsequent page. When paginating, all other parameters provided to `ListProductReviews` must
                /// match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reviews/v1beta/{+parent}/productReviews";

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
namespace Google.Apis.Merchant.reviews_v1beta.Data
{
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

    /// <summary>Response message for the `ListMerchantsReview` method.</summary>
    public class ListMerchantReviewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The merchant review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantReviews")]
        public virtual System.Collections.Generic.IList<MerchantReview> MerchantReviews { get; set; }

        /// <summary>The token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>response message for the ListProductReviews method.</summary>
    public class ListProductReviewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The product review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productReviews")]
        public virtual System.Collections.Generic.IList<ProductReview> ProductReviews { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A review for a merchant. For more information, see [Introduction to Merchant Review
    /// Feeds](https://developers.google.com/merchant-review-feeds)
    /// </summary>
    public class MerchantReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of merchant review attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual MerchantReviewAttributes Attributes { get; set; }

        /// <summary>
        /// Required. A list of custom (merchant-provided) attributes. It can also be used for submitting any attribute
        /// of the data specification in its generic form (for example, `{ "name": "size type", "value": "regular" }`).
        /// This is useful for submitting attributes not explicitly exposed by the API, such as experimental attributes.
        /// Maximum allowed number of characters for each custom attribute is 10240 (represents sum of characters for
        /// name and value). Maximum 2500 custom attributes can be set per product, with total size of 102.4kB.
        /// Underscores in custom attribute names are replaced by spaces upon insertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>Output only. The primary data source of the merchant review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>Required. The user provided merchant review ID to uniquely identify the merchant review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantReviewId")]
        public virtual string MerchantReviewId { get; set; }

        /// <summary>
        /// Output only. The status of a merchant review, data validation issues, that is, information about a merchant
        /// review computed asynchronously.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantReviewStatus")]
        public virtual MerchantReviewStatus MerchantReviewStatus { get; set; }

        /// <summary>
        /// Identifier. The name of the merchant review. Format:
        /// `"{merchantreview.name=accounts/{account}/merchantReviews/{merchantReview}}"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Attributes.</summary>
    public class MerchantReviewAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The method used to collect the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionMethod")]
        public virtual string CollectionMethod { get; set; }

        /// <summary>
        /// Required. This should be any freeform text provided by the user and should not be truncated. If multiple
        /// responses to different questions are provided, all responses should be included, with the minimal context
        /// for the responses to make sense. Context should not be provided if questions were left unanswered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Optional. Set to true if the reviewer should remain anonymous.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAnonymous")]
        public virtual System.Nullable<bool> IsAnonymous { get; set; }

        /// <summary>
        /// Optional. The maximum possible number for the rating. The value of the max rating must be greater than the
        /// value of the min rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRating")]
        public virtual System.Nullable<long> MaxRating { get; set; }

        /// <summary>Optional. Human-readable display name for the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantDisplayName")]
        public virtual string MerchantDisplayName { get; set; }

        /// <summary>
        /// Required. Must be unique and stable across all requests. In other words, if a request today and another 90
        /// days ago refer to the same merchant, they must have the same id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantId")]
        public virtual string MerchantId { get; set; }

        /// <summary>
        /// Optional. URL to the merchant's main website. Do not use a redirect URL for this value. In other words, the
        /// value should point directly to the merchant's site.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantLink")]
        public virtual string MerchantLink { get; set; }

        /// <summary>
        /// Optional. URL to the landing page that hosts the reviews for this merchant. Do not use a redirect URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantRatingLink")]
        public virtual string MerchantRatingLink { get; set; }

        /// <summary>
        /// Optional. The minimum possible number for the rating. This should be the worst possible rating and should
        /// not be a value for no rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRating")]
        public virtual System.Nullable<long> MinRating { get; set; }

        /// <summary>Optional. The reviewer's overall rating of the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual System.Nullable<double> Rating { get; set; }

        /// <summary>
        /// Optional. The country where the reviewer made the order defined by ISO 3166-1 Alpha-2 Country Code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewCountry")]
        public virtual string ReviewCountry { get; set; }

        /// <summary>Required. The language of the review defined by BCP-47 language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewLanguage")]
        public virtual string ReviewLanguage { get; set; }

        private string _reviewTimeRaw;

        private object _reviewTime;

        /// <summary>Required. The timestamp indicating when the review was written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewTime")]
        public virtual string ReviewTimeRaw
        {
            get => _reviewTimeRaw;
            set
            {
                _reviewTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _reviewTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReviewTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReviewTimeDateTimeOffset instead.")]
        public virtual object ReviewTime
        {
            get => _reviewTime;
            set
            {
                _reviewTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _reviewTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReviewTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReviewTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReviewTimeRaw);
            set => ReviewTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. A permanent, unique identifier for the author of the review in the publisher's system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerId")]
        public virtual string ReviewerId { get; set; }

        /// <summary>Optional. Display name of the review author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerUsername")]
        public virtual string ReviewerUsername { get; set; }

        /// <summary>Optional. The title of the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The destination status of the merchant review status.</summary>
    public class MerchantReviewDestinationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the reporting context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ItemLevelIssue of the merchant review status.</summary>
    public class MerchantReviewItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Output only. The reporting context the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>Output only. Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>Output only. How this issue affects serving of the merchant review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The status of a merchant review, data validation issues, that is, information about a merchant review computed
    /// asynchronously.
    /// </summary>
    public class MerchantReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. Date on which the item has been created, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601)
        /// format.
        /// </summary>
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

        /// <summary>Output only. The intended destinations for the merchant review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStatuses")]
        public virtual System.Collections.Generic.IList<MerchantReviewDestinationStatus> DestinationStatuses { get; set; }

        /// <summary>Output only. A list of all issues associated with the merchant review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<MerchantReviewItemLevelIssue> ItemLevelIssues { get; set; }

        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>
        /// Output only. Date on which the item has been last updated, in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

    /// <summary>
    /// A review for a product. For more information, see [Introduction to Product Review
    /// Feeds](https://developers.google.com/product-review-feeds)
    /// </summary>
    public class ProductReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of product review attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual ProductReviewAttributes Attributes { get; set; }

        /// <summary>Optional. A list of custom (merchant-provided) attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>Output only. The primary data source of the product review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>
        /// Identifier. The name of the product review. Format:
        /// `"{productreview.name=accounts/{account}/productReviews/{productReview}}"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The permanent, unique identifier for the product review in the publisher’s system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productReviewId")]
        public virtual string ProductReviewId { get; set; }

        /// <summary>
        /// Output only. The status of a product review, data validation issues, that is, information about a product
        /// review computed asynchronously.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productReviewStatus")]
        public virtual ProductReviewStatus ProductReviewStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Attributes.</summary>
    public class ProductReviewAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the aggregator of the product reviews. A publisher may use a reviews aggregator to
        /// manage reviews and provide the feeds. This element indicates the use of an aggregator and contains
        /// information about the aggregator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatorName")]
        public virtual string AggregatorName { get; set; }

        /// <summary>
        /// Optional. Contains ASINs (Amazon Standard Identification Numbers) associated with a product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asins")]
        public virtual System.Collections.Generic.IList<string> Asins { get; set; }

        /// <summary>Optional. Contains brand names associated with a product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brands")]
        public virtual System.Collections.Generic.IList<string> Brands { get; set; }

        /// <summary>Optional. The method used to collect the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionMethod")]
        public virtual string CollectionMethod { get; set; }

        /// <summary>
        /// Optional. Contains the disadvantages based on the opinion of the reviewer. Omit boilerplate text like "con:"
        /// unless it was written by the reviewer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cons")]
        public virtual System.Collections.Generic.IList<string> Cons { get; set; }

        /// <summary>Required. The content of the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// Optional. Contains GTINs (global trade item numbers) associated with a product. Sub-types of GTINs (e.g.
        /// UPC, EAN, ISBN, JAN) are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtins")]
        public virtual System.Collections.Generic.IList<string> Gtins { get; set; }

        /// <summary>Optional. Indicates whether the review is marked as spam in the publisher's system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSpam")]
        public virtual System.Nullable<bool> IsSpam { get; set; }

        /// <summary>
        /// Optional. The maximum possible number for the rating. The value of the max rating must be greater than the
        /// value of the min attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRating")]
        public virtual System.Nullable<long> MaxRating { get; set; }

        /// <summary>
        /// Optional. Contains the ratings associated with the review. The minimum possible number for the rating. This
        /// should be the worst possible rating and should not be a value for no rating.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minRating")]
        public virtual System.Nullable<long> MinRating { get; set; }

        /// <summary>Optional. Contains MPNs (manufacturer part numbers) associated with a product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpns")]
        public virtual System.Collections.Generic.IList<string> Mpns { get; set; }

        /// <summary>
        /// Optional. The URI of the product. This URI can have the same value as the `review_link` element, if the
        /// review URI and the product URI are the same.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLinks")]
        public virtual System.Collections.Generic.IList<string> ProductLinks { get; set; }

        /// <summary>Optional. Descriptive name of a product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productNames")]
        public virtual System.Collections.Generic.IList<string> ProductNames { get; set; }

        /// <summary>
        /// Optional. Contains the advantages based on the opinion of the reviewer. Omit boilerplate text like "pro:"
        /// unless it was written by the reviewer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pros")]
        public virtual System.Collections.Generic.IList<string> Pros { get; set; }

        /// <summary>
        /// Optional. A link to the company favicon of the publisher. The image dimensions should be favicon size: 16x16
        /// pixels. The image format should be GIF, JPG or PNG.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherFavicon")]
        public virtual string PublisherFavicon { get; set; }

        /// <summary>
        /// Optional. The name of the publisher of the product reviews. The information about the publisher, which may
        /// be a retailer, manufacturer, reviews service company, or any entity that publishes product reviews.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherName")]
        public virtual string PublisherName { get; set; }

        /// <summary>Optional. The reviewer's overall rating of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual System.Nullable<double> Rating { get; set; }

        /// <summary>Optional. The country of the review defined by ISO 3166-1 Alpha-2 Country Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewCountry")]
        public virtual string ReviewCountry { get; set; }

        /// <summary>Optional. The language of the review defined by BCP-47 language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewLanguage")]
        public virtual string ReviewLanguage { get; set; }

        /// <summary>Optional. The URI of the review landing page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewLink")]
        public virtual ReviewLink ReviewLink { get; set; }

        private string _reviewTimeRaw;

        private object _reviewTime;

        /// <summary>Required. The timestamp indicating when the review was written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewTime")]
        public virtual string ReviewTimeRaw
        {
            get => _reviewTimeRaw;
            set
            {
                _reviewTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _reviewTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReviewTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReviewTimeDateTimeOffset instead.")]
        public virtual object ReviewTime
        {
            get => _reviewTime;
            set
            {
                _reviewTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _reviewTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReviewTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReviewTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReviewTimeRaw);
            set => ReviewTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The author of the product review. A permanent, unique identifier for the author of the review in
        /// the publisher's system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerId")]
        public virtual string ReviewerId { get; set; }

        /// <summary>
        /// Optional. A URI to an image of the reviewed product created by the review author. The URI does not have to
        /// end with an image file extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerImageLinks")]
        public virtual System.Collections.Generic.IList<string> ReviewerImageLinks { get; set; }

        /// <summary>Optional. Set to true if the reviewer should remain anonymous.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerIsAnonymous")]
        public virtual System.Nullable<bool> ReviewerIsAnonymous { get; set; }

        /// <summary>Optional. The name of the reviewer of the product review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerUsername")]
        public virtual string ReviewerUsername { get; set; }

        /// <summary>
        /// Optional. Contains SKUs (stock keeping units) associated with a product. Often this matches the product
        /// Offer Id in the product feed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skus")]
        public virtual System.Collections.Generic.IList<string> Skus { get; set; }

        /// <summary>
        /// Optional. The name of the subclient of the product reviews. The subclient is an identifier of the product
        /// review source. It should be equivalent to the directory provided in the file data source path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subclientName")]
        public virtual string SubclientName { get; set; }

        /// <summary>Optional. The title of the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Optional. A permanent, unique identifier for the transaction associated with the review in the publisher's
        /// system. This ID can be used to indicate that multiple reviews are associated with the same transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The destination status of the product review status.</summary>
    public class ProductReviewDestinationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the reporting context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ItemLevelIssue of the product review status.</summary>
    public class ProductReviewItemLevelIssue : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Output only. The reporting context the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>Output only. Whether the issue can be resolved by the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>Output only. How this issue affects serving of the product review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product review status.</summary>
    public class ProductReviewStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. Date on which the item has been created, in [ISO 8601](http://en.wikipedia.org/wiki/ISO_8601)
        /// format.
        /// </summary>
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

        /// <summary>Output only. The intended destinations for the product review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStatuses")]
        public virtual System.Collections.Generic.IList<ProductReviewDestinationStatus> DestinationStatuses { get; set; }

        /// <summary>Output only. A list of all issues associated with the product review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemLevelIssues")]
        public virtual System.Collections.Generic.IList<ProductReviewItemLevelIssue> ItemLevelIssues { get; set; }

        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>
        /// Output only. Date on which the item has been last updated, in [ISO
        /// 8601](http://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
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

    /// <summary>The URI of the review landing page.</summary>
    public class ReviewLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The URI of the review landing page. For example: `http://www.example.com/review_5.html`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>Optional. Type of the review URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
