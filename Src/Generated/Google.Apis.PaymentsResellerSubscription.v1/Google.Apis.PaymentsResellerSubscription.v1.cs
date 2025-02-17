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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://paymentsresellersubscription.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://paymentsresellersubscription.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "paymentsresellersubscription";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Payments Reseller Subscription API.</summary>
        public class Scope
        {
            /// <summary>Associate you with your personal info on Google</summary>
            public static string Openid = "openid";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Payments Reseller Subscription API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Associate you with your personal info on Google</summary>
            public const string Openid = "openid";
        }

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
            UserSessions = new UserSessionsResource(service);
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
            /// To retrieve the products that can be resold by the partner. It should be autenticated with a service
            /// account. - This API doesn't apply to YouTube products currently.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, the partner that can resell. Format: partners/{partner}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// To retrieve the products that can be resold by the partner. It should be autenticated with a service
            /// account. - This API doesn't apply to YouTube products currently.
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
                /// Optional. Specifies the filters for the product results. The syntax is defined in
                /// https://google.aip.dev/160 with the following caveats: 1. Only the following features are supported:
                /// - Logical operator `AND` - Comparison operator `=` (no wildcards `*`) - Traversal operator `.` - Has
                /// operator `:` (no wildcards `*`) 2. Only the following fields are supported: - `regionCodes` -
                /// `youtubePayload.partnerEligibilityId` - `youtubePayload.postalCode` 3. Unless explicitly mentioned
                /// above, other features are not supported. Example: `regionCodes:US AND
                /// youtubePayload.postalCode=94043 AND youtubePayload.partnerEligibilityId=eligibility-id`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

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
            /// To find eligible promotions for the current user. The API requires user authorization via OAuth. The
            /// bare minimum oauth scope `openid` is sufficient, which will skip the consent screen.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent, the partner that can resell. Format: partners/{partner}
            /// </param>
            public virtual FindEligibleRequest FindEligible(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1FindEligiblePromotionsRequest body, string parent)
            {
                return new FindEligibleRequest(this.service, body, parent);
            }

            /// <summary>
            /// To find eligible promotions for the current user. The API requires user authorization via OAuth. The
            /// bare minimum oauth scope `openid` is sufficient, which will skip the consent screen.
            /// </summary>
            public class FindEligibleRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1FindEligiblePromotionsResponse>
            {
                /// <summary>Constructs a new FindEligible request.</summary>
                public FindEligibleRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1FindEligiblePromotionsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent, the partner that can resell. Format: partners/{partner}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1FindEligiblePromotionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "findEligible";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/promotions:findEligible";

                /// <summary>Initializes FindEligible parameter list.</summary>
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
                }
            }

            /// <summary>
            /// Retrieves the promotions, such as free trial, that can be used by the partner. - This API doesn't apply
            /// to YouTube promotions currently. It should be autenticated with a service account.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, the partner that can resell. Format: partners/{partner}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Retrieves the promotions, such as free trial, that can be used by the partner. - This API doesn't apply
            /// to YouTube promotions currently. It should be autenticated with a service account.
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
                /// Optional. Specifies the filters for the promotion results. The syntax is defined in
                /// https://google.aip.dev/160 with the following caveats: 1. Only the following features are supported:
                /// - Logical operator `AND` - Comparison operator `=` (no wildcards `*`) - Traversal operator `.` - Has
                /// operator `:` (no wildcards `*`) 2. Only the following fields are supported: - `applicableProducts` -
                /// `regionCodes` - `youtubePayload.partnerEligibilityId` - `youtubePayload.postalCode` 3. Unless
                /// explicitly mentioned above, other features are not supported. Example:
                /// `applicableProducts:partners/partner1/products/product1 AND regionCodes:US AND
                /// youtubePayload.postalCode=94043 AND youtubePayload.partnerEligibilityId=eligibility-id`
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
                return new CancelRequest(this.service, body, name);
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
                return new CreateRequest(this.service, body, parent);
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
                return new EntitleRequest(this.service, body, name);
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
            /// [Opt-in only] Most partners should be on auto-extend by default. Used by partners to extend a
            /// subscription service for their customers on an ongoing basis for the subscription to remain active and
            /// renewable. It should be called directly by the partner using service accounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription resource to be extended. It will have the format of
            /// "partners/{partner_id}/subscriptions/{subscription_id}".
            /// </param>
            public virtual ExtendRequest Extend(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionRequest body, string name)
            {
                return new ExtendRequest(this.service, body, name);
            }

            /// <summary>
            /// [Opt-in only] Most partners should be on auto-extend by default. Used by partners to extend a
            /// subscription service for their customers on an ongoing basis for the subscription to remain active and
            /// renewable. It should be called directly by the partner using service accounts.
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
                return new GetRequest(this.service, name);
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
                return new ProvisionRequest(this.service, body, parent);
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
            /// Revokes the pending cancellation of a subscription, which is currently in `STATE_CANCEL_AT_END_OF_CYCLE`
            /// state. If the subscription is already cancelled, the request will fail. - **This API doesn't apply to
            /// YouTube subscriptions.** It should be called directly by the partner using service accounts.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the subscription resource whose pending cancellation needs to be undone. It will
            /// have the format of "partners/{partner_id}/subscriptions/{subscription_id}"
            /// </param>
            public virtual UndoCancelRequest UndoCancel(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1UndoCancelSubscriptionRequest body, string name)
            {
                return new UndoCancelRequest(this.service, body, name);
            }

            /// <summary>
            /// Revokes the pending cancellation of a subscription, which is currently in `STATE_CANCEL_AT_END_OF_CYCLE`
            /// state. If the subscription is already cancelled, the request will fail. - **This API doesn't apply to
            /// YouTube subscriptions.** It should be called directly by the partner using service accounts.
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

        /// <summary>Gets the UserSessions resource.</summary>
        public virtual UserSessionsResource UserSessions { get; }

        /// <summary>The "userSessions" collection of methods.</summary>
        public class UserSessionsResource
        {
            private const string Resource = "userSessions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserSessionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// This API replaces user authorized OAuth consent based APIs (Create, Entitle). Generates a short-lived
            /// token for a user session based on the user intent. You can use the session token to redirect the user to
            /// Google to finish the signup flow. You can re-generate new session token repeatedly for the same request
            /// if necessary, regardless of the previous tokens being expired or not.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent, the partner that can resell. Format: partners/{partner}
            /// </param>
            public virtual GenerateRequest Generate(Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1GenerateUserSessionRequest body, string parent)
            {
                return new GenerateRequest(this.service, body, parent);
            }

            /// <summary>
            /// This API replaces user authorized OAuth consent based APIs (Create, Entitle). Generates a short-lived
            /// token for a user session based on the user intent. You can use the session token to redirect the user to
            /// Google to finish the signup flow. You can re-generate new session token repeatedly for the same request
            /// if necessary, regardless of the previous tokens being expired or not.
            /// </summary>
            public class GenerateRequest : PaymentsResellerSubscriptionBaseServiceRequest<Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1GenerateUserSessionResponse>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1GenerateUserSessionRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent, the partner that can resell. Format: partners/{partner}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PaymentsResellerSubscription.v1.Data.GoogleCloudPaymentsResellerSubscriptionV1GenerateUserSessionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/userSessions:generate";

                /// <summary>Initializes Generate parameter list.</summary>
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
                }
            }
        }
    }
}
namespace Google.Apis.PaymentsResellerSubscription.v1.Data
{
    /// <summary>Describes the amount unit including the currency code.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Amount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Amount in micros (1_000_000 micros = 1 currency unit)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>
        /// Required. Currency codes in accordance with [ISO-4217 Currency Codes]
        /// (https://en.wikipedia.org/wiki/ISO_4217). For example, USD.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to cancel a subscription.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, Google will cancel the subscription immediately, and may or may not (based on the
        /// contract) issue a prorated refund for the remainder of the billing cycle. Otherwise, Google defers the
        /// cancelation at renewal_time, and will not issue a refund. - YouTube subscriptions must use this option
        /// currently. However, the user will still have access to the subscription until the end of the billing cycle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelImmediately")]
        public virtual System.Nullable<bool> CancelImmediately { get; set; }

        /// <summary>Specifies the reason for the cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellationReason")]
        public virtual string CancellationReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response that contains the cancelled subscription resource.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1CancelSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cancelled subscription resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Subscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Intent message for creating a Subscription resource.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1CreateSubscriptionIntent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The parent resource name, which is the identifier of the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. The Subscription to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Subscription Subscription { get; set; }

        /// <summary>
        /// Required. Identifies the subscription resource on the Partner side. The value is restricted to 63 ASCII
        /// characters at the maximum. If a subscription was previously created with the same subscription_id, we will
        /// directly return that one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionId")]
        public virtual string SubscriptionId { get; set; }

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

    /// <summary>Intent for entitling the previously provisioned subscription to an end user.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionIntent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the subscription resource that is entitled to the current end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Partner request for entitling the previously provisioned subscription to an end user. The end user identity is
    /// inferred from the request OAuth context.
    /// </summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The line items to be entitled. If unspecified, all line items will be entitled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemEntitlementDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionRequestLineItemEntitlementDetails> LineItemEntitlementDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of the line item to be entitled.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionRequestLineItemEntitlementDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The index of the line item to be entitled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemIndex")]
        public virtual System.Nullable<int> LineItemIndex { get; set; }

        /// <summary>
        /// Optional. Only applicable if the line item corresponds to a hard bundle. Product resource names that
        /// identify the bundle elements to be entitled in the line item. If unspecified, all bundle elements will be
        /// entitled. The format is 'partners/{partner_id}/products/{product_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<string> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response that contains the entitled subscription resource.</summary>
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
        /// of the same request. A different request_id must be used for a extension of a different cycle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response that contains the timestamps after the extension.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1ExtendSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _cycleEndTimeRaw;

        private object _cycleEndTime;

        /// <summary>
        /// The time at which the subscription is expected to be extended, in ISO 8061 format. UTC timezone. Example,
        /// "cycleEndTime":"2019-08-31T17:28:54.564Z"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycleEndTime")]
        public virtual string CycleEndTimeRaw
        {
            get => _cycleEndTimeRaw;
            set
            {
                _cycleEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cycleEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CycleEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CycleEndTimeDateTimeOffset instead.")]
        public virtual object CycleEndTime
        {
            get => _cycleEndTime;
            set
            {
                _cycleEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cycleEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CycleEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CycleEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CycleEndTimeRaw);
            set => CycleEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _freeTrialEndTimeRaw;

        private object _freeTrialEndTime;

        /// <summary>
        /// End of the free trial period, in ISO 8061 format. UTC timezone. Example,
        /// "freeTrialEndTime":"2019-08-31T17:28:54.564Z" This time will be set the same as initial subscription
        /// creation time if no free trial period is offered to the partner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTrialEndTime")]
        public virtual string FreeTrialEndTimeRaw
        {
            get => _freeTrialEndTimeRaw;
            set
            {
                _freeTrialEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _freeTrialEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FreeTrialEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FreeTrialEndTimeDateTimeOffset instead.")]
        public virtual object FreeTrialEndTime
        {
            get => _freeTrialEndTime;
            set
            {
                _freeTrialEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _freeTrialEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="FreeTrialEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FreeTrialEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FreeTrialEndTimeRaw);
            set => FreeTrialEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _renewalTimeRaw;

        private object _renewalTime;

        /// <summary>
        /// Output only. The time at which the subscription is expected to be renewed by Google - a new charge will be
        /// incurred and the service entitlement will be renewed. A non-immediate cancellation will take place at this
        /// time too, before which, the service entitlement for the end user will remain valid. UTC timezone in ISO 8061
        /// format. For example: "2019-08-31T17:28:54.564Z"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalTime")]
        public virtual string RenewalTimeRaw
        {
            get => _renewalTimeRaw;
            set
            {
                _renewalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _renewalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RenewalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RenewalTimeDateTimeOffset instead.")]
        public virtual object RenewalTime
        {
            get => _renewalTime;
            set
            {
                _renewalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _renewalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RenewalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RenewalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RenewalTimeRaw);
            set => RenewalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the details of an extension request.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Extension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the period of access the subscription should grant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Duration Duration { get; set; }

        /// <summary>Required. Identifier of the end-user in partner’s system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerUserToken")]
        public virtual string PartnerUserToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to find eligible promotions for the current user.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1FindEligiblePromotionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies the filters for the promotion results. The syntax is defined in
        /// https://google.aip.dev/160 with the following caveats: 1. Only the following features are supported: -
        /// Logical operator `AND` - Comparison operator `=` (no wildcards `*`) - Traversal operator `.` - Has operator
        /// `:` (no wildcards `*`) 2. Only the following fields are supported: - `applicableProducts` - `regionCodes` -
        /// `youtubePayload.partnerEligibilityId` - `youtubePayload.postalCode` 3. Unless explicitly mentioned above,
        /// other features are not supported. Example: `applicableProducts:partners/partner1/products/product1 AND
        /// regionCodes:US AND youtubePayload.postalCode=94043 AND youtubePayload.partnerEligibilityId=eligibility-id`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. The maximum number of promotions to return. The service may return fewer than this value. If
        /// unspecified, at most 50 products will be returned. The maximum value is 1000; values above 1000 will be
        /// coerced to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token, received from a previous `ListPromotions` call. Provide this to retrieve the
        /// subsequent page. When paginating, all other parameters provided to `ListPromotions` must match the call that
        /// provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the found promotions for the current user.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1FindEligiblePromotionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The promotions for the current user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1Promotion> Promotions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for a subscriptiin line item with finite billing cycles.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1FiniteBillingCycleDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The number of a subscription line item billing cycles after which billing will stop automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingCycleCountLimit")]
        public virtual System.Nullable<long> BillingCycleCountLimit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[Preview only] Request to generate a user session.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1GenerateUserSessionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user intent to generate the user session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentPayload")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1IntentPayload IntentPayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[Preview only] Response that contains the details for generated user session.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1GenerateUserSessionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The generated user session. The token size is proportional to the size of the intent payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSession")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1UserSession UserSession { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload specific for Google Home products.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1GoogleHomePayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This identifies the structure ID on partner side that the subscription should be applied to. Only
        /// required when the partner requires structure mapping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerStructureId")]
        public virtual string PartnerStructureId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload specific to Google One products.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1GoogleOnePayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Campaign attributed to sales of this subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("campaigns")]
        public virtual System.Collections.Generic.IList<string> Campaigns { get; set; }

        /// <summary>The type of offering the subscription was sold by the partner. e.g. VAS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offering")]
        public virtual string Offering { get; set; }

        /// <summary>The type of sales channel through which the subscription was sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salesChannel")]
        public virtual string SalesChannel { get; set; }

        /// <summary>The identifier for the partner store where the subscription was sold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeId")]
        public virtual string StoreId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The payload that describes the user intent.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1IntentPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The request to create a subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createIntent")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1CreateSubscriptionIntent CreateIntent { get; set; }

        /// <summary>The request to entitle a subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitleIntent")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1EntitleSubscriptionIntent EntitleIntent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response that contains the products.</summary>
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

    /// <summary>Response that contains the promotions.</summary>
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
        /// <summary>Output only. Output Only. Specifies the details for a bundle product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleDetails")]
        public virtual ProductBundleDetails BundleDetails { get; set; }

        /// <summary>
        /// Optional. Details for a subscription line item with finite billing cycles. If unset, the line item will be
        /// charged indefinitely.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finiteBillingCycleDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1FiniteBillingCycleDetails FiniteBillingCycleDetails { get; set; }

        /// <summary>
        /// Identifier. Response only. Resource name of the product. It will have the format of
        /// "partners/{partner_id}/products/{product_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Price configs for the product in the available regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1ProductPriceConfig> PriceConfigs { get; set; }

        /// <summary>Output only. Output Only. Specifies the type of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productType")]
        public virtual string ProductType { get; set; }

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

    /// <summary>The individual product that is included in the bundle.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1ProductBundleDetailsBundleElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Output only. Product resource name that identifies the bundle element. The format is
        /// 'partners/{partner_id}/products/{product_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies product specific payload.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1ProductPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Payload specific to Google Home products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleHomePayload")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1GoogleHomePayload GoogleHomePayload { get; set; }

        /// <summary>Product-specific payloads. Payload specific to Google One products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleOnePayload")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1GoogleOnePayload GoogleOnePayload { get; set; }

        /// <summary>Payload specific to Youtube products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubePayload")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1YoutubePayload YoutubePayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configs the prices in an available region.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1ProductPriceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The price in the region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Amount Amount { get; set; }

        /// <summary>Output only. 2-letter ISO region code where the product is available in. Ex. "US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Promotion resource that defines a promotion for a subscription that can be resold.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Promotion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The product ids this promotion can be applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableProducts")]
        public virtual System.Collections.Generic.IList<string> ApplicableProducts { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Optional. Specifies the end time (exclusive) of the period that the promotion is available in. If unset, the
        /// promotion is available indefinitely.
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

        /// <summary>
        /// Optional. Specifies the duration of the free trial of the subscription when promotion_type is
        /// PROMOTION_TYPE_FREE_TRIAL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTrialDuration")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Duration FreeTrialDuration { get; set; }

        /// <summary>
        /// Optional. Specifies the introductory pricing details when the promotion_type is
        /// PROMOTION_TYPE_INTRODUCTORY_PRICING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPricingDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1PromotionIntroductoryPricingDetails IntroductoryPricingDetails { get; set; }

        /// <summary>
        /// Identifier. Response only. Resource name of the subscription promotion. It will have the format of
        /// "partners/{partner_id}/promotion/{promotion_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Output Only. Specifies the type of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionType")]
        public virtual string PromotionType { get; set; }

        /// <summary>
        /// Output only. 2-letter ISO region code where the promotion is available in. Ex. "US" Please refers to:
        /// https://en.wikipedia.org/wiki/ISO_3166-1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCodes")]
        public virtual System.Collections.Generic.IList<string> RegionCodes { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Specifies the start time (inclusive) of the period that the promotion is available in.
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

        /// <summary>Output only. Localized human readable name of the promotion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titles")]
        public virtual System.Collections.Generic.IList<GoogleTypeLocalizedText> Titles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a introductory pricing promotion.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1PromotionIntroductoryPricingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specifies the introductory pricing periods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPricingSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1PromotionIntroductoryPricingDetailsIntroductoryPricingSpec> IntroductoryPricingSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The duration of an introductory pricing promotion.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1PromotionIntroductoryPricingDetailsIntroductoryPricingSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The discount amount. The value is positive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountAmount")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Amount DiscountAmount { get; set; }

        /// <summary>Output only. The discount percentage in micros. For example, 50,000 represents 5%.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountRatioMicros")]
        public virtual System.Nullable<long> DiscountRatioMicros { get; set; }

        /// <summary>Output only. Output Only. The duration of an introductory offer in billing cycles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrenceCount")]
        public virtual System.Nullable<int> RecurrenceCount { get; set; }

        /// <summary>Output only. 2-letter ISO region code where the product is available in. Ex. "US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A description of what time period or moment in time the product or service is being delivered over.
    /// </summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1ServicePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Optional. The end time of the service period. Time is exclusive.</summary>
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

        /// <summary>Required. The start time of the service period. Time is inclusive.</summary>
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

    /// <summary>
    /// A subscription serves as a central billing entity between an external partner and Google. The underlying Google
    /// services rely on the subscription state to grant or revoke the user's service entitlement. It's important to
    /// note that the subscription state may not always perfectly align with the user's service entitlement. For
    /// example, some Google services may continue providing access to the user until the current billing cycle ends,
    /// even if the subscription has been immediately canceled. However, other services may not do the same. To fully
    /// understand the specific details, please consult the relevant contract or product policy.
    /// </summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Describes the details of a cancelled subscription. Only applicable to subscription of state
        /// `STATE_CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancellationDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1SubscriptionCancellationDetails CancellationDetails { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. System generated timestamp when the subscription is created. UTC timezone.</summary>
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

        private string _cycleEndTimeRaw;

        private object _cycleEndTime;

        /// <summary>
        /// Output only. The time at which the subscription is expected to be extended, in ISO 8061 format. UTC
        /// timezone. For example: "2019-08-31T17:28:54.564Z"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycleEndTime")]
        public virtual string CycleEndTimeRaw
        {
            get => _cycleEndTimeRaw;
            set
            {
                _cycleEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cycleEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CycleEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CycleEndTimeDateTimeOffset instead.")]
        public virtual object CycleEndTime
        {
            get => _cycleEndTime;
            set
            {
                _cycleEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cycleEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CycleEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CycleEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CycleEndTimeRaw);
            set => CycleEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Indicates if the subscription is entitled to the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUserEntitled")]
        public virtual System.Nullable<bool> EndUserEntitled { get; set; }

        private string _freeTrialEndTimeRaw;

        private object _freeTrialEndTime;

        /// <summary>
        /// Output only. End of the free trial period, in ISO 8061 format. For example, "2019-08-31T17:28:54.564Z". It
        /// will be set the same as createTime if no free trial promotion is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTrialEndTime")]
        public virtual string FreeTrialEndTimeRaw
        {
            get => _freeTrialEndTimeRaw;
            set
            {
                _freeTrialEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _freeTrialEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FreeTrialEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FreeTrialEndTimeDateTimeOffset instead.")]
        public virtual object FreeTrialEndTime
        {
            get => _freeTrialEndTime;
            set
            {
                _freeTrialEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _freeTrialEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="FreeTrialEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FreeTrialEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FreeTrialEndTimeRaw);
            set => FreeTrialEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. The line items of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1SubscriptionLineItem> LineItems { get; set; }

        /// <summary>
        /// Output only. Describes the details of the migrated subscription. Only populated if this subscription is
        /// migrated from another system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1SubscriptionMigrationDetails MigrationDetails { get; set; }

        /// <summary>
        /// Identifier. Resource name of the subscription. It will have the format of
        /// "partners/{partner_id}/subscriptions/{subscription_id}". This is available for authorizeAddon, but otherwise
        /// is response only.
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
        /// Optional. Deprecated: consider using `line_items` as the input. Required. Resource name that identifies the
        /// purchased products. The format will be 'partners/{partner_id}/products/{product_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<string> Products { get; set; }

        /// <summary>
        /// Optional. Subscription-level promotions. Only free trial is supported on this level. It determines the first
        /// renewal time of the subscription to be the end of the free trial period. Specify the promotion resource name
        /// only when used as input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1SubscriptionPromotionSpec> PromotionSpecs { get; set; }

        /// <summary>
        /// Optional. Deprecated: consider using the top-level `promotion_specs` as the input. Optional. Resource name
        /// that identifies one or more promotions that can be applied on the product. A typical promotion for a
        /// subscription is Free trial. The format will be 'partners/{partner_id}/promotions/{promotion_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<string> Promotions { get; set; }

        private string _purchaseTimeRaw;

        private object _purchaseTime;

        /// <summary>
        /// Optional. The timestamp when the user transaction was made with the Partner. Specify for the case of "bundle
        /// with choice", and it must be before the provision_time (when the user makes a selection).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTime")]
        public virtual string PurchaseTimeRaw
        {
            get => _purchaseTimeRaw;
            set
            {
                _purchaseTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _purchaseTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PurchaseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PurchaseTimeDateTimeOffset instead.")]
        public virtual object PurchaseTime
        {
            get => _purchaseTime;
            set
            {
                _purchaseTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _purchaseTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PurchaseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PurchaseTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PurchaseTimeRaw);
            set => PurchaseTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The place where partners should redirect the end-user to after creation. This field might also
        /// be populated when creation failed. However, Partners should always prepare a default URL to redirect the
        /// user in case this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        private string _renewalTimeRaw;

        private object _renewalTime;

        /// <summary>
        /// Output only. The time at which the subscription is expected to be renewed by Google - a new charge will be
        /// incurred and the service entitlement will be renewed. A non-immediate cancellation will take place at this
        /// time too, before which, the service entitlement for the end user will remain valid. UTC timezone in ISO 8061
        /// format. For example: "2019-08-31T17:28:54.564Z"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalTime")]
        public virtual string RenewalTimeRaw
        {
            get => _renewalTimeRaw;
            set
            {
                _renewalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _renewalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RenewalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RenewalTimeDateTimeOffset instead.")]
        public virtual object RenewalTime
        {
            get => _renewalTime;
            set
            {
                _renewalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _renewalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RenewalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RenewalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RenewalTimeRaw);
            set => RenewalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. The location that the service is provided as indicated by the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLocation")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Location ServiceLocation { get; set; }

        /// <summary>
        /// Output only. Describes the state of the subscription. See more details at [the lifecycle of a
        /// subscription](/payments/reseller/subscription/reference/index/Receive.Notifications#payments-subscription-lifecycle).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. System generated timestamp when the subscription is most recently updated. UTC timezone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
        /// <summary>Output only. The reason of the cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Individual line item definition of a subscription.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1SubscriptionLineItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The price of the product/service in this line item. The amount could be the wholesale price, or
        /// it can include a cost of sale based on the contract.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amount")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Amount Amount { get; set; }

        /// <summary>
        /// Output only. The bundle details for the line item. Only populated if the line item corresponds to a hard
        /// bundle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleDetails")]
        public virtual SubscriptionLineItemBundleDetails BundleDetails { get; set; }

        /// <summary>Output only. Description of this line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Details for a subscription line item with finite billing cycles. If unset, the line item will be
        /// charged indefinitely. Used only with LINE_ITEM_RECURRENCE_TYPE_PERIODIC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finiteBillingCycleDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1FiniteBillingCycleDetails FiniteBillingCycleDetails { get; set; }

        private string _lineItemFreeTrialEndTimeRaw;

        private object _lineItemFreeTrialEndTime;

        /// <summary>
        /// Output only. The free trial end time will be populated after the line item is successfully processed. End
        /// time of the line item free trial period, in ISO 8061 format. For example, "2019-08-31T17:28:54.564Z". It
        /// will be set the same as createTime if no free trial promotion is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemFreeTrialEndTime")]
        public virtual string LineItemFreeTrialEndTimeRaw
        {
            get => _lineItemFreeTrialEndTimeRaw;
            set
            {
                _lineItemFreeTrialEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lineItemFreeTrialEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LineItemFreeTrialEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LineItemFreeTrialEndTimeDateTimeOffset instead.")]
        public virtual object LineItemFreeTrialEndTime
        {
            get => _lineItemFreeTrialEndTime;
            set
            {
                _lineItemFreeTrialEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lineItemFreeTrialEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LineItemFreeTrialEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LineItemFreeTrialEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LineItemFreeTrialEndTimeRaw);
            set => LineItemFreeTrialEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. A unique index of the subscription line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemIndex")]
        public virtual System.Nullable<int> LineItemIndex { get; set; }

        /// <summary>
        /// Optional. The promotions applied on the line item. It can be: - an introductory pricing promotion. - a free
        /// trial promotion. This feature is not enabled. If used, the request will be rejected. When used as input in
        /// Create or Provision API, specify its resource name only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItemPromotionSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1SubscriptionPromotionSpec> LineItemPromotionSpecs { get; set; }

        /// <summary>Output only. Details only set for a ONE_TIME recurrence line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeRecurrenceDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1SubscriptionLineItemOneTimeRecurrenceDetails OneTimeRecurrenceDetails { get; set; }

        /// <summary>
        /// Required. Product resource name that identifies one the line item The format is
        /// 'partners/{partner_id}/products/{product_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>Optional. Product specific payload for this line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productPayload")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1ProductPayload ProductPayload { get; set; }

        /// <summary>Output only. The recurrence type of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrenceType")]
        public virtual string RecurrenceType { get; set; }

        /// <summary>Output only. The state of the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details for an element in the hard bundle.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1SubscriptionLineItemBundleDetailsBundleElementDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Product resource name that identifies the bundle element. The format is
        /// 'partners/{partner_id}/products/{product_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        private string _userAccountLinkedTimeRaw;

        private object _userAccountLinkedTime;

        /// <summary>Output only. The time when this product is linked to an end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAccountLinkedTime")]
        public virtual string UserAccountLinkedTimeRaw
        {
            get => _userAccountLinkedTimeRaw;
            set
            {
                _userAccountLinkedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _userAccountLinkedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UserAccountLinkedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UserAccountLinkedTimeDateTimeOffset instead.")]
        public virtual object UserAccountLinkedTime
        {
            get => _userAccountLinkedTime;
            set
            {
                _userAccountLinkedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _userAccountLinkedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="UserAccountLinkedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UserAccountLinkedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UserAccountLinkedTimeRaw);
            set => UserAccountLinkedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for a ONE_TIME recurrence line item.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1SubscriptionLineItemOneTimeRecurrenceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The service period of the ONE_TIME line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePeriod")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1ServicePeriod ServicePeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the details of the migrated subscription.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1SubscriptionMigrationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The migrated subscription id in the legacy system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migratedSubscriptionId")]
        public virtual string MigratedSubscriptionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the spec for one promotion.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1SubscriptionPromotionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The duration of the free trial if the promotion is of type FREE_TRIAL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTrialDuration")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1Duration FreeTrialDuration { get; set; }

        /// <summary>
        /// Output only. The details of the introductory pricing spec if the promotion is of type INTRODUCTORY_PRICING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPricingDetails")]
        public virtual GoogleCloudPaymentsResellerSubscriptionV1PromotionIntroductoryPricingDetails IntroductoryPricingDetails { get; set; }

        /// <summary>
        /// Required. Promotion resource name that identifies a promotion. The format is
        /// 'partners/{partner_id}/promotions/{promotion_id}'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotion")]
        public virtual string Promotion { get; set; }

        /// <summary>Output only. The type of the promotion for the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>
    /// A user session contains a short-lived token that includes information required to interact with Google Payments
    /// Reseller Platform using the following web endpoints. - A user session token should be generated dynamically for
    /// an authenticated user. You should refrain from sharing a token directly with a user in an unauthenticated
    /// context, such as SMS, or email. - You can re-generate new session tokens repeatedly for same `generate` request
    /// if necessary, regardless of the previous tokens being expired or not. You don't need to worry about multiple
    /// sessions resulting in duplicate fulfillments as guaranteed by the same subscription id. Please refer to the
    /// [Google Managed
    /// Signup](/payments/reseller/subscription/reference/index/User.Signup.Integration/Google.Managed.Signup.\(In.Preview\))
    /// documentation for additional integration details.
    /// </summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1UserSession : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. The time at which the user session expires.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The encrypted token of the user session, including the information of the user's intent and
        /// request. This token should be provided when redirecting the user to Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload specific to Youtube products.</summary>
    public class GoogleCloudPaymentsResellerSubscriptionV1YoutubePayload : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _accessEndTimeRaw;

        private object _accessEndTime;

        /// <summary>Output only. The access expiration time for this line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessEndTime")]
        public virtual string AccessEndTimeRaw
        {
            get => _accessEndTimeRaw;
            set
            {
                _accessEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _accessEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AccessEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AccessEndTimeDateTimeOffset instead.")]
        public virtual object AccessEndTime
        {
            get => _accessEndTime;
            set
            {
                _accessEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _accessEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="AccessEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AccessEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AccessEndTimeRaw);
            set => AccessEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The list of eligibility_ids which are applicable for the line item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerEligibilityIds")]
        public virtual System.Collections.Generic.IList<string> PartnerEligibilityIds { get; set; }

        /// <summary>Optional. Specifies the plan type offered to the end user by the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerPlanType")]
        public virtual string PartnerPlanType { get; set; }

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

        /// <summary>Localized string in the language corresponding to language_code below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for a bundle product.</summary>
    public class ProductBundleDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The individual products that are included in the bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleElements")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1ProductBundleDetailsBundleElement> BundleElements { get; set; }

        /// <summary>The entitlement mode of the bundle product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementMode")]
        public virtual string EntitlementMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The bundle details for a line item corresponding to a hard bundle.</summary>
    public class SubscriptionLineItemBundleDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The details for each element in the hard bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleElementDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudPaymentsResellerSubscriptionV1SubscriptionLineItemBundleDetailsBundleElementDetails> BundleElementDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
