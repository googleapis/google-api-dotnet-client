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

namespace Google.Apis.PaymentsResellerSubscription.v1
{
    /// <summary>The PaymentsResellerSubscription Service.</summary>
    public class PaymentsResellerSubscriptionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PaymentsResellerSubscriptionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PaymentsResellerSubscriptionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Partners = new PartnersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "paymentsresellersubscription";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://paymentsresellersubscription.googleapis.com/";
        #else
            "https://paymentsresellersubscription.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://paymentsresellersubscription.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Partners resource.</summary>
        public virtual PartnersResource Partners { get; }
    }

    /// <summary>A base abstract class for PaymentsResellerSubscription requests.</summary>
    public abstract class PaymentsResellerSubscriptionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PaymentsResellerSubscriptionBaseServiceRequest instance.</summary>
        protected PaymentsResellerSubscriptionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PaymentsResellerSubscription parameter list.</summary>
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

    /// <summary>The "partners" collection of methods.</summary>
    public class PartnersResource
    {
        private const string Resource = "partners";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PartnersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Products = new ProductsResource(service);
            Promotions = new PromotionsResource(service);
            Subscriptions = new SubscriptionsResource(service);
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
            /// Used by partners to list products that can be resold to their customers. It should be called directly by
            /// the partner using service accounts.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, the partner that can resell. Format: partners/{partner}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Used by partners to list products that can be resold to their customers. It should be called directly by
            /// the partner using service accounts.
            /// </summary>
            public class ListRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1ListProductsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent, the partner that can resell. Format: partners/{partner}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of products to return. The service may return fewer than this value. If
                /// unspecified, at most 50 products will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListProducts` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListProducts` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/products";

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
                        Pattern = @"^partners/[^/]+$",
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
            /// Used by partners to list promotions, such as free trial, that can be applied on subscriptions. It should
            /// be called directly by the partner using service accounts.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, the partner that can resell. Format: partners/{partner}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Used by partners to list promotions, such as free trial, that can be applied on subscriptions. It should
            /// be called directly by the partner using service accounts.
            /// </summary>
            public class ListRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1ListPromotionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent, the partner that can resell. Format: partners/{partner}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Specifies the filters for the promotion results. The syntax defined in the EBNF grammar:
                /// https://google.aip.dev/assets/misc/ebnf-filtering.txt. Examples: - applicable_products: "sku1" -
                /// region_codes: "US" - applicable_products: "sku1" AND region_codes: "US"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of promotions to return. The service may return fewer than this value.
                /// If unspecified, at most 50 products will be returned. The maximum value is 1000; values above 1000
                /// will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListPromotions` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListPromotions` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/promotions";

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
                        Pattern = @"^partners/[^/]+$",
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

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

        /// <summary>The "subscriptions" collection of methods.</summary>
        public class SubscriptionsResource
        {
            private const string Resource = "subscriptions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubscriptionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Used by partners to cancel a subscription service either immediately or by the end of the current
            /// billing cycle for their customers. It should be called directly by the partner using service accounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription resource to be cancelled. It will have the format of
            /// "partners/{partner_id}/subscriptions/{subscription_id}"
            /// </param>
            public virtual CancelRequest Cancel(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>
            /// Used by partners to cancel a subscription service either immediately or by the end of the current
            /// billing cycle for their customers. It should be called directly by the partner using service accounts.
            /// </summary>
            public class CancelRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionResponse>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription resource to be cancelled. It will have the format of
                /// "partners/{partner_id}/subscriptions/{subscription_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^partners/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Used by partners to create a subscription for their customers. The created subscription is associated
            /// with the end user inferred from the end user credentials. This API must be authorized by the end user
            /// using OAuth.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource name, which is the identifier of the partner. It will have the format of
            /// "partners/{partner_id}".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Used by partners to create a subscription for their customers. The created subscription is associated
            /// with the end user inferred from the end user credentials. This API must be authorized by the end user
            /// using OAuth.
            /// </summary>
            public class CreateRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name, which is the identifier of the partner. It will have the format
                /// of "partners/{partner_id}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Identifies the subscription resource on the Partner side. The value is restricted to 63
                /// ASCII characters at the maximum. If a subscription was previously created with the same
                /// subscription_id, we will directly return that one.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SubscriptionId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/subscriptions";

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
                        Pattern = @"^partners/[^/]+$",
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Used by partners to entitle a previously provisioned subscription to the current end user. The end user
            /// identity is inferred from the authorized credential of the request. This API must be authorized by the
            /// end user using OAuth.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription resource that is entitled to the current end user. It will have
            /// the format of "partners/{partner_id}/subscriptions/{subscription_id}"
            /// </param>
            public virtual EntitleRequest Entitle(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionRequest body, string name)
            {
                return new EntitleRequest(service, body, name);
            }

            /// <summary>
            /// Used by partners to entitle a previously provisioned subscription to the current end user. The end user
            /// identity is inferred from the authorized credential of the request. This API must be authorized by the
            /// end user using OAuth.
            /// </summary>
            public class EntitleRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionResponse>
            {
                /// <summary>Constructs a new Entitle request.</summary>
                public EntitleRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription resource that is entitled to the current end user. It will
                /// have the format of "partners/{partner_id}/subscriptions/{subscription_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "entitle";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:entitle";

                /// <summary>Initializes Entitle parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^partners/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Used by partners to extend a subscription service for their customers. It should be called directly by
            /// the partner using service accounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription resource to be extended. It will have the format of
            /// "partners/{partner_id}/subscriptions/{subscription_id}".
            /// </param>
            public virtual ExtendRequest Extend(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionRequest body, string name)
            {
                return new ExtendRequest(service, body, name);
            }

            /// <summary>
            /// Used by partners to extend a subscription service for their customers. It should be called directly by
            /// the partner using service accounts.
            /// </summary>
            public class ExtendRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionResponse>
            {
                /// <summary>Constructs a new Extend request.</summary>
                public ExtendRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription resource to be extended. It will have the format of
                /// "partners/{partner_id}/subscriptions/{subscription_id}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "extend";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:extend";

                /// <summary>Initializes Extend parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^partners/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Used by partners to get a subscription by id. It should be called directly by the partner using service
            /// accounts.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the subscription resource to retrieve. It will have the format of
            /// "partners/{partner_id}/subscriptions/{subscription_id}"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Used by partners to get a subscription by id. It should be called directly by the partner using service
            /// accounts.
            /// </summary>
            public class GetRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription resource to retrieve. It will have the format of
                /// "partners/{partner_id}/subscriptions/{subscription_id}"
                /// </summary>
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
                        Pattern = @"^partners/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Used by partners to provision a subscription for their customers. This creates a subscription without
            /// associating it with the end user account. EntitleSubscription must be called separately using OAuth in
            /// order for the end user account to be associated with the subscription. It should be called directly by
            /// the partner using service accounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource name, which is the identifier of the partner. It will have the format of
            /// "partners/{partner_id}".
            /// </param>
            public virtual ProvisionRequest Provision(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription body, string parent)
            {
                return new ProvisionRequest(service, body, parent);
            }

            /// <summary>
            /// Used by partners to provision a subscription for their customers. This creates a subscription without
            /// associating it with the end user account. EntitleSubscription must be called separately using OAuth in
            /// order for the end user account to be associated with the subscription. It should be called directly by
            /// the partner using service accounts.
            /// </summary>
            public class ProvisionRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription>
            {
                /// <summary>Constructs a new Provision request.</summary>
                public ProvisionRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name, which is the identifier of the partner. It will have the format
                /// of "partners/{partner_id}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Identifies the subscription resource on the Partner side. The value is restricted to 63
                /// ASCII characters at the maximum. If a subscription was previously created with the same
                /// subscription_id, we will directly return that one.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SubscriptionId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1Subscription Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "provision";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/subscriptions:provision";

                /// <summary>Initializes Provision parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^partners/[^/]+$",
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Used by partners to revoke the pending cancellation of a subscription, which is currently in
            /// `STATE_CANCEL_AT_END_OF_CYCLE` state. If the subscription is already cancelled, the request will fail.
            /// It should be called directly by the partner using service accounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription resource whose pending cancellation needs to be undone. It will
            /// have the format of "partners/{partner_id}/subscriptions/{subscription_id}"
            /// </param>
            public virtual UndoCancelRequest UndoCancel(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1UndoCancelSubscriptionRequest body, string name)
            {
                return new UndoCancelRequest(service, body, name);
            }

            /// <summary>
            /// Used by partners to revoke the pending cancellation of a subscription, which is currently in
            /// `STATE_CANCEL_AT_END_OF_CYCLE` state. If the subscription is already cancelled, the request will fail.
            /// It should be called directly by the partner using service accounts.
            /// </summary>
            public class UndoCancelRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1UndoCancelSubscriptionResponse>
            {
                /// <summary>Constructs a new UndoCancel request.</summary>
                public UndoCancelRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1UndoCancelSubscriptionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscription resource whose pending cancellation needs to be undone. It
                /// will have the format of "partners/{partner_id}/subscriptions/{subscription_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1UndoCancelSubscriptionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undoCancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:undoCancel";

                /// <summary>Initializes UndoCancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^partners/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.PaymentsResellerSubscription.v1.Data
{
    public class GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, the subscription will be cancelled immediately. Otherwise, the subscription will be
        /// cancelled at the end of the current cycle, and therefore no prorated refund will be issued for the rest of
        /// the cycle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelImmediately")]
        public virtual System.Nullable<bool> CancelImmediately { get; set; }

        /// <summary>Specifies the reason for the cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellationReason")]
        public virtual string CancellationReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cancelled subscription resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Subscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the length of a period of a time.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Duration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>number of duration units to be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>The unit used for the duration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Partner request for entitling the previously provisioned subscription to an end user. The end user identity is
    /// inferred from the request OAuth context.
    /// </summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The subscription that has user linked to it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Subscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request message for extending a Subscription resource. A new recurrence will be made based on the subscription
    /// schedule defined by the original product.
    /// </summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Specifies details of the extension. Currently, the duration of the extension must be exactly one
        /// billing cycle of the original subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extension")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Extension Extension { get; set; }

        /// <summary>
        /// Required. Restricted to 36 ASCII characters. A random UUID is recommended. The idempotency key for the
        /// request. The ID generation logic is controlled by the partner. request_id should be the same as on retries
        /// of the same request. A different request_id must be used for a extension of a different cycle. A random UUID
        /// is recommended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time at which the subscription is expected to be extended, in ISO 8061 format. UTC timezone. Example,
        /// "cycleEndTime":"2019-08-31T17:28:54.564Z"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycleEndTime")]
        public virtual object CycleEndTime { get; set; }

        /// <summary>
        /// End of the free trial period, in ISO 8061 format. UTC timezone. Example,
        /// "freeTrialEndTime":"2019-08-31T17:28:54.564Z" This time will be set the same as initial subscription
        /// creation time if no free trial period is offered to the partner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTrialEndTime")]
        public virtual object FreeTrialEndTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the details of an extension request.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Extension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the period of access the subscription should grant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Duration Duration { get; set; }

        /// <summary>Required. Identifier of the end-user in partner’s system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerUserToken")]
        public virtual string PartnerUserToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudPaymentsResellerSubscriptionV1ListProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The products for the specified partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1Product> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudPaymentsResellerSubscriptionV1ListPromotionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The promotions for the specified partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1Promotion> Promotions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a location of an end user.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The postal code this location refers to. Ex. "94043"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// 2-letter ISO region code for current content region. Ex. “US” Please refers to:
        /// https://en.wikipedia.org/wiki/ISO_3166-1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Product resource that defines a subscription service that can be resold.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Response only. Resource name of the subscription. It will have the format of
        /// "partners/{partner_id}/products/{product_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. 2-letter ISO region code where the product is available in. Ex. "US" Please refers to:
        /// https://en.wikipedia.org/wiki/ISO_3166-1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCodes")]
        public virtual System.Collections.Generic.IList<string> RegionCodes { get; set; }

        /// <summary>Output only. Specifies the length of the billing cycle of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionBillingCycleDuration")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Duration SubscriptionBillingCycleDuration { get; set; }

        /// <summary>Output only. Localized human readable name of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titles")]
        public virtual System.Collections.Generic.IList<GoogleTypeLocalizedText> Titles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Promotion resource that defines a promotion for a subscription that can be resold.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Promotion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The product ids this promotion can be applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableProducts")]
        public virtual System.Collections.Generic.IList<string> ApplicableProducts { get; set; }

        /// <summary>
        /// Optional. Specifies the end time (exclusive) of the period that the promotion is available in. If unset, the
        /// promotion is available indefinitely.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Output only. Specifies the duration of the free trial of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTrialDuration")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Duration FreeTrialDuration { get; set; }

        /// <summary>
        /// Output only. Response only. Resource name of the subscription promotion. It will have the format of
        /// "partners/{partner_id}/promotion/{promotion_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. 2-letter ISO region code where the promotion is available in. Ex. "US" Please refers to:
        /// https://en.wikipedia.org/wiki/ISO_3166-1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCodes")]
        public virtual System.Collections.Generic.IList<string> RegionCodes { get; set; }

        /// <summary>
        /// Optional. Specifies the start time (inclusive) of the period that the promotion is available in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. Localized human readable name of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titles")]
        public virtual System.Collections.Generic.IList<GoogleTypeLocalizedText> Titles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Subscription resource managed by 3P Partners.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Describes the details of a cancelled subscription. Only applicable to subscription of state
        /// `STATE_CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellationDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1SubscriptionCancellationDetails CancellationDetails { get; set; }

        /// <summary>Output only. System generated timestamp when the subscription is created. UTC timezone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The time at which the subscription is expected to be extended, in ISO 8061 format. UTC
        /// timezone. For example: "2019-08-31T17:28:54.564Z"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycleEndTime")]
        public virtual object CycleEndTime { get; set; }

        /// <summary>Output only. Indicates if the subscription is entitled to the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUserEntitled")]
        public virtual System.Nullable<bool> EndUserEntitled { get; set; }

        /// <summary>
        /// Output only. End of the free trial period, in ISO 8061 format. For example, "2019-08-31T17:28:54.564Z". It
        /// will be set the same as createTime if no free trial promotion is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTrialEndTime")]
        public virtual object FreeTrialEndTime { get; set; }

        /// <summary>
        /// Output only. Response only. Resource name of the subscription. It will have the format of
        /// "partners/{partner_id}/subscriptions/{subscription_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Identifier of the end-user in partner’s system. The value is restricted to 63 ASCII characters at
        /// the maximum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerUserToken")]
        public virtual string PartnerUserToken { get; set; }

        /// <summary>
        /// Output only. Describes the processing state of the subscription. See more details at [the lifecycle of a
        /// subscription](/payments/reseller/subscription/reference/index/Receive.Notifications#payments-subscription-lifecycle).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingState")]
        public virtual string ProcessingState { get; set; }

        /// <summary>
        /// Required. Resource name that identifies one or more subscription products. The format will be
        /// 'partners/{partner_id}/products/{product_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<string> Products { get; set; }

        /// <summary>
        /// Optional. Resource name that identifies one or more promotions that can be applied on the product. A typical
        /// promotion for a subscription is Free trial. The format will be
        /// 'partners/{partner_id}/promotions/{promotion_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<string> Promotions { get; set; }

        /// <summary>
        /// Output only. The place where partners should redirect the end-user to after creation. This field might also
        /// be populated when creation failed. However, Partners should always prepare a default URL to redirect the
        /// user in case this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>Required. The location that the service is provided as indicated by the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLocation")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Location ServiceLocation { get; set; }

        /// <summary>
        /// Output only. Describes the state of the subscription. See more details at [the lifecycle of a
        /// subscription](/payments/reseller/subscription/reference/index/Receive.Notifications#payments-subscription-lifecycle).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. System generated timestamp when the subscription is most recently updated. UTC timezone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Optional. Details about the previous subscription that this new subscription upgrades/downgrades from. Only
        /// populated if this subscription is an upgrade/downgrade from another subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeDowngradeDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1SubscriptionUpgradeDowngradeDetails UpgradeDowngradeDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the details of a cancelled or cancelling subscription.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1SubscriptionCancellationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason of the cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the previous subscription that this new subscription upgrades/downgrades from.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1SubscriptionUpgradeDowngradeDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the billing cycle spec for the new upgraded/downgraded subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingCycleSpec")]
        public virtual string BillingCycleSpec { get; set; }

        /// <summary>
        /// Required. The previous subscription id to be replaced. This is not the full resource name, use the
        /// subscription_id segment only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousSubscriptionId")]
        public virtual string PreviousSubscriptionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to revoke a cancellation request.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1UndoCancelSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response that contains the updated subscription resource.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1UndoCancelSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated subscription resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Subscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Localized variant of a text in a particular language.</summary>
    public class GoogleTypeLocalizedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text's BCP-47 language code, such as "en-US" or "sr-Latn". For more information, see
        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Localized string in the language corresponding to `language_code' below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
