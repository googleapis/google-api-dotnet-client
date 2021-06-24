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

namespace Google.Apis.Reseller.v1
{
    /// <summary>The Reseller Service.</summary>
    public class ResellerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ResellerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ResellerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Customers = new CustomersResource(this);
            Resellernotify = new ResellernotifyResource(this);
            Subscriptions = new SubscriptionsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "reseller";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://reseller.googleapis.com/";
        #else
            "https://reseller.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://reseller.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Workspace Reseller API.</summary>
        public class Scope
        {
            /// <summary>Manage users on your domain</summary>
            public static string AppsOrder = "https://www.googleapis.com/auth/apps.order";

            /// <summary>Manage users on your domain</summary>
            public static string AppsOrderReadonly = "https://www.googleapis.com/auth/apps.order.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Workspace Reseller API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage users on your domain</summary>
            public const string AppsOrder = "https://www.googleapis.com/auth/apps.order";

            /// <summary>Manage users on your domain</summary>
            public const string AppsOrderReadonly = "https://www.googleapis.com/auth/apps.order.readonly";
        }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>Gets the Resellernotify resource.</summary>
        public virtual ResellernotifyResource Resellernotify { get; }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }
    }

    /// <summary>A base abstract class for Reseller requests.</summary>
    public abstract class ResellerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ResellerBaseServiceRequest instance.</summary>
        protected ResellerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Reseller parameter list.</summary>
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
        }

        /// <summary>
        /// Get a customer account. Use this operation to see a customer account already in your reseller management, or
        /// to see the minimal account information for an existing customer that you do not manage. For more information
        /// about the API response for existing customers, see [retrieving a customer
        /// account](/admin-sdk/reseller/v1/how-tos/manage_customers#get_customer).
        /// </summary>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        public virtual GetRequest Get(string customerId)
        {
            return new GetRequest(service, customerId);
        }

        /// <summary>
        /// Get a customer account. Use this operation to see a customer account already in your reseller management, or
        /// to see the minimal account information for an existing customer that you do not manage. For more information
        /// about the API response for existing customers, see [retrieving a customer
        /// account](/admin-sdk/reseller/v1/how-tos/manage_customers#get_customer).
        /// </summary>
        public class GetRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Customer>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId) : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Order a new customer's account. Before ordering a new customer account, establish whether the customer
        /// account already exists using the [`customers.get`](/admin-sdk/reseller/v1/reference/customers/get) If the
        /// customer account exists as a direct Google account or as a resold customer account from another reseller,
        /// use the `customerAuthToken\` as described in [order a resold account for an existing
        /// customer](/admin-sdk/reseller/v1/how-tos/manage_customers#create_existing_customer). For more information
        /// about ordering a new customer account, see [order a new customer
        /// account](/admin-sdk/reseller/v1/how-tos/manage_customers#create_customer). After creating a new customer
        /// account, you must provision a user as an administrator. The customer's administrator is required to sign in
        /// to the Admin console and sign the G Suite via Reseller agreement to activate the account. Resellers are
        /// prohibited from signing the G Suite via Reseller agreement on the customer's behalf. For more information,
        /// see [order a new customer account](/admin-sdk/reseller/v1/how-tos/manage_customers#tos).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Reseller.v1.Data.Customer body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>
        /// Order a new customer's account. Before ordering a new customer account, establish whether the customer
        /// account already exists using the [`customers.get`](/admin-sdk/reseller/v1/reference/customers/get) If the
        /// customer account exists as a direct Google account or as a resold customer account from another reseller,
        /// use the `customerAuthToken\` as described in [order a resold account for an existing
        /// customer](/admin-sdk/reseller/v1/how-tos/manage_customers#create_existing_customer). For more information
        /// about ordering a new customer account, see [order a new customer
        /// account](/admin-sdk/reseller/v1/how-tos/manage_customers#create_customer). After creating a new customer
        /// account, you must provision a user as an administrator. The customer's administrator is required to sign in
        /// to the Admin console and sign the G Suite via Reseller agreement to activate the account. Resellers are
        /// prohibited from signing the G Suite via Reseller agreement on the customer's behalf. For more information,
        /// see [order a new customer account](/admin-sdk/reseller/v1/how-tos/manage_customers#tos).
        /// </summary>
        public class InsertRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Customer>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Reseller.v1.Data.Customer body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The `customerAuthToken` query string is required when creating a resold account that transfers a direct
            /// customer's subscription or transfers another reseller customer's subscription to your reseller
            /// management. This is a hexadecimal authentication token needed to complete the subscription transfer. For
            /// more information, see the administrator help center.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerAuthToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerAuthToken { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Reseller.v1.Data.Customer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerAuthToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerAuthToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Update a customer account's settings. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Reseller.v1.Data.Customer body, string customerId)
        {
            return new PatchRequest(service, body, customerId);
        }

        /// <summary>Update a customer account's settings. This method supports patch semantics.</summary>
        public class PatchRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Customer>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Reseller.v1.Data.Customer body, string customerId) : base(service)
            {
                CustomerId = customerId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Reseller.v1.Data.Customer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update a customer account's settings. For more information, see [update a customer's
        /// settings](/admin-sdk/reseller/v1/how-tos/manage_customers#update_customer).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Reseller.v1.Data.Customer body, string customerId)
        {
            return new UpdateRequest(service, body, customerId);
        }

        /// <summary>
        /// Update a customer account's settings. For more information, see [update a customer's
        /// settings](/admin-sdk/reseller/v1/how-tos/manage_customers#update_customer).
        /// </summary>
        public class UpdateRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Customer>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Reseller.v1.Data.Customer body, string customerId) : base(service)
            {
                CustomerId = customerId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Reseller.v1.Data.Customer Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "resellernotify" collection of methods.</summary>
    public class ResellernotifyResource
    {
        private const string Resource = "resellernotify";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResellernotifyResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns all the details of the watch corresponding to the reseller.</summary>
        public virtual GetwatchdetailsRequest Getwatchdetails()
        {
            return new GetwatchdetailsRequest(service);
        }

        /// <summary>Returns all the details of the watch corresponding to the reseller.</summary>
        public class GetwatchdetailsRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.ResellernotifyGetwatchdetailsResponse>
        {
            /// <summary>Constructs a new Getwatchdetails request.</summary>
            public GetwatchdetailsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getwatchdetails";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/resellernotify/getwatchdetails";

            /// <summary>Initializes Getwatchdetails parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Registers a Reseller for receiving notifications.</summary>
        public virtual RegisterRequest Register()
        {
            return new RegisterRequest(service);
        }

        /// <summary>Registers a Reseller for receiving notifications.</summary>
        public class RegisterRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.ResellernotifyResource>
        {
            /// <summary>Constructs a new Register request.</summary>
            public RegisterRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The service account which will own the created Cloud-PubSub topic.</summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceAccountEmailAddress", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ServiceAccountEmailAddress { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "register";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/resellernotify/register";

            /// <summary>Initializes Register parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceAccountEmailAddress", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceAccountEmailAddress",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Unregisters a Reseller for receiving notifications.</summary>
        public virtual UnregisterRequest Unregister()
        {
            return new UnregisterRequest(service);
        }

        /// <summary>Unregisters a Reseller for receiving notifications.</summary>
        public class UnregisterRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.ResellernotifyResource>
        {
            /// <summary>Constructs a new Unregister request.</summary>
            public UnregisterRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The service account which owns the Cloud-PubSub topic.</summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceAccountEmailAddress", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ServiceAccountEmailAddress { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "unregister";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/resellernotify/unregister";

            /// <summary>Initializes Unregister parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceAccountEmailAddress", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceAccountEmailAddress",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
        /// Activates a subscription previously suspended by the reseller. If you did not suspend the customer
        /// subscription and it is suspended for any other reason, such as for abuse or a pending ToS acceptance, this
        /// call will not reactivate the customer subscription.
        /// </summary>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        public virtual ActivateRequest Activate(string customerId, string subscriptionId)
        {
            return new ActivateRequest(service, customerId, subscriptionId);
        }

        /// <summary>
        /// Activates a subscription previously suspended by the reseller. If you did not suspend the customer
        /// subscription and it is suspended for any other reason, such as for abuse or a pending ToS acceptance, this
        /// call will not reactivate the customer subscription.
        /// </summary>
        public class ActivateRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new Activate request.</summary>
            public ActivateRequest(Google.Apis.Services.IClientService service, string customerId, string subscriptionId) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "activate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}/activate";

            /// <summary>Initializes Activate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update a subscription plan. Use this method to update a plan for a 30-day trial or a flexible plan
        /// subscription to an annual commitment plan with monthly or yearly payments. How a plan is updated differs
        /// depending on the plan and the products. For more information, see the description in [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#update_subscription_plan).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        public virtual ChangePlanRequest ChangePlan(Google.Apis.Reseller.v1.Data.ChangePlanRequest body, string customerId, string subscriptionId)
        {
            return new ChangePlanRequest(service, body, customerId, subscriptionId);
        }

        /// <summary>
        /// Update a subscription plan. Use this method to update a plan for a 30-day trial or a flexible plan
        /// subscription to an annual commitment plan with monthly or yearly payments. How a plan is updated differs
        /// depending on the plan and the products. For more information, see the description in [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#update_subscription_plan).
        /// </summary>
        public class ChangePlanRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new ChangePlan request.</summary>
            public ChangePlanRequest(Google.Apis.Services.IClientService service, Google.Apis.Reseller.v1.Data.ChangePlanRequest body, string customerId, string subscriptionId) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Reseller.v1.Data.ChangePlanRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "changePlan";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}/changePlan";

            /// <summary>Initializes ChangePlan parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update a user license's renewal settings. This is applicable for accounts with annual commitment plans only.
        /// For more information, see the description in [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#update_renewal).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        public virtual ChangeRenewalSettingsRequest ChangeRenewalSettings(Google.Apis.Reseller.v1.Data.RenewalSettings body, string customerId, string subscriptionId)
        {
            return new ChangeRenewalSettingsRequest(service, body, customerId, subscriptionId);
        }

        /// <summary>
        /// Update a user license's renewal settings. This is applicable for accounts with annual commitment plans only.
        /// For more information, see the description in [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#update_renewal).
        /// </summary>
        public class ChangeRenewalSettingsRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new ChangeRenewalSettings request.</summary>
            public ChangeRenewalSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Reseller.v1.Data.RenewalSettings body, string customerId, string subscriptionId) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Reseller.v1.Data.RenewalSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "changeRenewalSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}/changeRenewalSettings";

            /// <summary>Initializes ChangeRenewalSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update a subscription's user license settings. For more information about updating an annual commitment plan
        /// or a flexible plan subscription’s licenses, see [Manage
        /// Subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#update_subscription_seat).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        public virtual ChangeSeatsRequest ChangeSeats(Google.Apis.Reseller.v1.Data.Seats body, string customerId, string subscriptionId)
        {
            return new ChangeSeatsRequest(service, body, customerId, subscriptionId);
        }

        /// <summary>
        /// Update a subscription's user license settings. For more information about updating an annual commitment plan
        /// or a flexible plan subscription’s licenses, see [Manage
        /// Subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#update_subscription_seat).
        /// </summary>
        public class ChangeSeatsRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new ChangeSeats request.</summary>
            public ChangeSeatsRequest(Google.Apis.Services.IClientService service, Google.Apis.Reseller.v1.Data.Seats body, string customerId, string subscriptionId) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Reseller.v1.Data.Seats Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "changeSeats";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}/changeSeats";

            /// <summary>Initializes ChangeSeats parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Cancel, suspend, or transfer a subscription to direct.</summary>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        /// <param name="deletionType">
        /// The `deletionType` query string enables the cancellation, downgrade, or suspension of a subscription.
        /// </param>
        public virtual DeleteRequest Delete(string customerId, string subscriptionId, DeleteRequest.DeletionTypeEnum deletionType)
        {
            return new DeleteRequest(service, customerId, subscriptionId, deletionType);
        }

        /// <summary>Cancel, suspend, or transfer a subscription to direct.</summary>
        public class DeleteRequest : ResellerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customerId, string subscriptionId, DeletionTypeEnum deletionType) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                DeletionType = deletionType;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>
            /// The `deletionType` query string enables the cancellation, downgrade, or suspension of a subscription.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("deletionType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual DeletionTypeEnum DeletionType { get; private set; }

            /// <summary>
            /// The `deletionType` query string enables the cancellation, downgrade, or suspension of a subscription.
            /// </summary>
            public enum DeletionTypeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("deletion_type_undefined")]
                DeletionTypeUndefined = 0,

                /// <summary>
                /// Cancels the subscription immediately. This does not apply to a G Suite subscription.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("cancel")]
                Cancel = 1,

                /// <summary>
                /// Transfers a subscription directly to Google. The customer is immediately transferred to a direct
                /// billing relationship with Google and is given a short amount of time with no service interruption.
                /// The customer can then choose to set up billing directly with Google by using a credit card, or they
                /// can transfer to another reseller.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("transfer_to_direct")]
                TransferToDirect = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deletionType", new Google.Apis.Discovery.Parameter
                {
                    Name = "deletionType",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Get a specific subscription. The `subscriptionId` can be found using the [Retrieve all reseller
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#get_all_subscriptions) method. For more
        /// information about retrieving a specific subscription, see the information descrived in [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#get_subscription).
        /// </summary>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        public virtual GetRequest Get(string customerId, string subscriptionId)
        {
            return new GetRequest(service, customerId, subscriptionId);
        }

        /// <summary>
        /// Get a specific subscription. The `subscriptionId` can be found using the [Retrieve all reseller
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#get_all_subscriptions) method. For more
        /// information about retrieving a specific subscription, see the information descrived in [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#get_subscription).
        /// </summary>
        public class GetRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string subscriptionId) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Create or transfer a subscription. Create a subscription for a customer's account that you ordered using the
        /// [Order a new customer account](/admin-sdk/reseller/v1/reference/customers/insert.html) method. For more
        /// information about creating a subscription for different payment plans, see [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#create_subscription).\ If you did not
        /// order the customer's account using the customer insert method, use the customer's `customerAuthToken` when
        /// creating a subscription for that customer. If transferring a G Suite subscription with an associated Google
        /// Drive or Google Vault subscription, use the [batch operation](/admin-sdk/reseller/v1/how-tos/batch.html) to
        /// transfer all of these subscriptions. For more information, see how to [transfer
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#transfer_a_subscription).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.Reseller.v1.Data.Subscription body, string customerId)
        {
            return new InsertRequest(service, body, customerId);
        }

        /// <summary>
        /// Create or transfer a subscription. Create a subscription for a customer's account that you ordered using the
        /// [Order a new customer account](/admin-sdk/reseller/v1/reference/customers/insert.html) method. For more
        /// information about creating a subscription for different payment plans, see [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#create_subscription).\ If you did not
        /// order the customer's account using the customer insert method, use the customer's `customerAuthToken` when
        /// creating a subscription for that customer. If transferring a G Suite subscription with an associated Google
        /// Drive or Google Vault subscription, use the [batch operation](/admin-sdk/reseller/v1/how-tos/batch.html) to
        /// transfer all of these subscriptions. For more information, see how to [transfer
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#transfer_a_subscription).
        /// </summary>
        public class InsertRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Reseller.v1.Data.Subscription body, string customerId) : base(service)
            {
                CustomerId = customerId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// The `customerAuthToken` query string is required when creating a resold account that transfers a direct
            /// customer's subscription or transfers another reseller customer's subscription to your reseller
            /// management. This is a hexadecimal authentication token needed to complete the subscription transfer. For
            /// more information, see the administrator help center.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerAuthToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerAuthToken { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Reseller.v1.Data.Subscription Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerAuthToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerAuthToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// List of subscriptions managed by the reseller. The list can be all subscriptions, all of a customer's
        /// subscriptions, or all of a customer's transferable subscriptions. Optionally, this method can filter the
        /// response by a `customerNamePrefix`. For more information, see [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions).
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// List of subscriptions managed by the reseller. The list can be all subscriptions, all of a customer's
        /// subscriptions, or all of a customer's transferable subscriptions. Optionally, this method can filter the
        /// response by a `customerNamePrefix`. For more information, see [manage
        /// subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions).
        /// </summary>
        public class ListRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscriptions>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The `customerAuthToken` query string is required when creating a resold account that transfers a direct
            /// customer's subscription or transfers another reseller customer's subscription to your reseller
            /// management. This is a hexadecimal authentication token needed to complete the subscription transfer. For
            /// more information, see the administrator help center.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerAuthToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerAuthToken { get; set; }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// When retrieving all of your subscriptions and filtering for specific customers, you can enter a prefix
            /// for a customer name. Using an example customer group that includes `exam.com`, `example20.com` and
            /// `example.com`: - `exa` -- Returns all customer names that start with 'exa' which could include
            /// `exam.com`, `example20.com`, and `example.com`. A name prefix is similar to using a regular expression's
            /// asterisk, exa*. - `example` -- Returns `example20.com` and `example.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerNamePrefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerNamePrefix { get; set; }

            /// <summary>
            /// When retrieving a large list, the `maxResults` is the maximum number of results per page. The
            /// `nextPageToken` value takes you to the next page. The default is 20.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/subscriptions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerAuthToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerAuthToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerNamePrefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerNamePrefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
        /// Immediately move a 30-day free trial subscription to a paid service subscription. This method is only
        /// applicable if a payment plan has already been set up for the 30-day trial subscription. For more
        /// information, see [manage subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#paid_service).
        /// </summary>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        public virtual StartPaidServiceRequest StartPaidService(string customerId, string subscriptionId)
        {
            return new StartPaidServiceRequest(service, customerId, subscriptionId);
        }

        /// <summary>
        /// Immediately move a 30-day free trial subscription to a paid service subscription. This method is only
        /// applicable if a payment plan has already been set up for the 30-day trial subscription. For more
        /// information, see [manage subscriptions](/admin-sdk/reseller/v1/how-tos/manage_subscriptions#paid_service).
        /// </summary>
        public class StartPaidServiceRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new StartPaidService request.</summary>
            public StartPaidServiceRequest(Google.Apis.Services.IClientService service, string customerId, string subscriptionId) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "startPaidService";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}/startPaidService";

            /// <summary>Initializes StartPaidService parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Suspends an active subscription. You can use this method to suspend a paid subscription that is currently in
        /// the `ACTIVE` state. * For `FLEXIBLE` subscriptions, billing is paused. * For `ANNUAL_MONTHLY_PAY` or
        /// `ANNUAL_YEARLY_PAY` subscriptions: * Suspending the subscription does not change the renewal date that was
        /// originally committed to. * A suspended subscription does not renew. If you activate the subscription after
        /// the original renewal date, a new annual subscription will be created, starting on the day of activation. We
        /// strongly encourage you to suspend subscriptions only for short periods of time as suspensions over 60 days
        /// may result in the subscription being cancelled.
        /// </summary>
        /// <param name="customerId">
        /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we
        /// do not recommend using a `customerId` as a key for persistent data. If the domain name for a `customerId` is
        /// changed, the Google system automatically updates.
        /// </param>
        /// <param name="subscriptionId">
        /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
        /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this ID
        /// as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
        /// subscriptions method.
        /// </param>
        public virtual SuspendRequest Suspend(string customerId, string subscriptionId)
        {
            return new SuspendRequest(service, customerId, subscriptionId);
        }

        /// <summary>
        /// Suspends an active subscription. You can use this method to suspend a paid subscription that is currently in
        /// the `ACTIVE` state. * For `FLEXIBLE` subscriptions, billing is paused. * For `ANNUAL_MONTHLY_PAY` or
        /// `ANNUAL_YEARLY_PAY` subscriptions: * Suspending the subscription does not change the renewal date that was
        /// originally committed to. * A suspended subscription does not renew. If you activate the subscription after
        /// the original renewal date, a new annual subscription will be created, starting on the day of activation. We
        /// strongly encourage you to suspend subscriptions only for short periods of time as suspensions over 60 days
        /// may result in the subscription being cancelled.
        /// </summary>
        public class SuspendRequest : ResellerBaseServiceRequest<Google.Apis.Reseller.v1.Data.Subscription>
        {
            /// <summary>Constructs a new Suspend request.</summary>
            public SuspendRequest(Google.Apis.Services.IClientService service, string customerId, string subscriptionId) : base(service)
            {
                CustomerId = customerId;
                SubscriptionId = subscriptionId;
                InitParameters();
            }

            /// <summary>
            /// Either the customer's primary domain name or the customer's unique identifier. If using the domain name,
            /// we do not recommend using a `customerId` as a key for persistent data. If the domain name for a
            /// `customerId` is changed, the Google system automatically updates.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>
            /// This is a required property. The `subscriptionId` is the subscription identifier and is unique for each
            /// customer. Since a `subscriptionId` changes when a subscription is updated, we recommend to not use this
            /// ID as a key for persistent data. And the `subscriptionId` can be found using the retrieve all reseller
            /// subscriptions method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "suspend";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/reseller/v1/customers/{customerId}/subscriptions/{subscriptionId}/suspend";

            /// <summary>Initializes Suspend parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscriptionId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Reseller.v1.Data
{
    /// <summary>JSON template for address of a customer.</summary>
    public class Address : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A customer's physical address. An address can be composed of one to three lines. The `addressline2` and
        /// `addressLine3` are optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine1")]
        public virtual string AddressLine1 { get; set; }

        /// <summary>Line 2 of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine2")]
        public virtual string AddressLine2 { get; set; }

        /// <summary>Line 3 of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine3")]
        public virtual string AddressLine3 { get; set; }

        /// <summary>The customer contact's name. This is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactName")]
        public virtual string ContactName { get; set; }

        /// <summary>
        /// For `countryCode` information, see the ISO 3166 country code elements. Verify that country is approved for
        /// resale of Google products. This property is required when creating a new customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>Identifies the resource as a customer address. Value: `customers#address`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>An example of a `locality` value is the city of `San Francisco`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>The company or company division name. This is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationName")]
        public virtual string OrganizationName { get; set; }

        /// <summary>
        /// A `postalCode` example is a postal zip code such as `94043`. This property is required when creating a new
        /// customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>An example of a `region` value is `CA` for the state of California.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for the ChangePlan rpc request.</summary>
    public class ChangePlanRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google-issued code (100 char max) for discounted pricing on subscription plans. Deal code must be included
        /// in `changePlan` request in order to receive discounted rate. This property is optional. If a deal code has
        /// already been added to a subscription, this property may be left empty and the existing discounted rate will
        /// still apply (if not empty, only provide the deal code that is already present on the subscription). If a
        /// deal code has never been added to a subscription and this property is left blank, regular pricing will
        /// apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealCode")]
        public virtual string DealCode { get; set; }

        /// <summary>
        /// Identifies the resource as a subscription change plan request. Value: `subscriptions#changePlanRequest`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The `planName` property is required. This is the name of the subscription's payment plan. For more
        /// information about the Google payment plans, see API concepts. Possible values are: - `ANNUAL_MONTHLY_PAY` -
        /// The annual commitment plan with monthly payments *Caution: *`ANNUAL_MONTHLY_PAY` is returned as `ANNUAL` in
        /// all API responses. - `ANNUAL_YEARLY_PAY` - The annual commitment plan with yearly payments - `FLEXIBLE` -
        /// The flexible plan - `TRIAL` - The 30-day free trial plan
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("planName")]
        public virtual string PlanName { get; set; }

        /// <summary>
        /// This is an optional property. This purchase order (PO) information is for resellers to use for their company
        /// tracking usage. If a `purchaseOrderId` value is given it appears in the API responses and shows up in the
        /// invoice. The property accepts up to 80 plain text characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseOrderId")]
        public virtual string PurchaseOrderId { get; set; }

        /// <summary>This is a required property. The seats property is the number of user seat licenses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seats")]
        public virtual Seats Seats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When a Google customer's account is registered with a reseller, the customer's subscriptions for Google services
    /// are managed by this reseller. A customer is described by a primary domain name and a physical address.
    /// </summary>
    public class Customer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Like the "Customer email" in the reseller tools, this email is the secondary contact used if something
        /// happens to the customer's service such as service outage or a security issue. This property is required when
        /// creating a new customer and should not use the same domain as `customerDomain`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateEmail")]
        public virtual string AlternateEmail { get; set; }

        /// <summary>
        /// The customer's primary domain name string. `customerDomain` is required when creating a new customer. Do not
        /// include the `www` prefix in the domain when adding a customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerDomain")]
        public virtual string CustomerDomain { get; set; }

        /// <summary>Whether the customer's primary domain has been verified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerDomainVerified")]
        public virtual System.Nullable<bool> CustomerDomainVerified { get; set; }

        /// <summary>
        /// This property will always be returned in a response as the unique identifier generated by Google. In a
        /// request, this property can be either the primary domain or the unique identifier generated by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>The type of the customer (DOMAIN or TEAM), default is DOMAIN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerType")]
        public virtual string CustomerType { get; set; }

        /// <summary>Identifies the resource as a customer. Value: `reseller#customer`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Customer contact phone number. Must start with "+" followed by the country code. The rest of the number can
        /// be contiguous numbers or respect the phone local format conventions, but it must be a real phone number and
        /// not, for example, "123". This field is silently ignored if invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>A customer's address information. Each field has a limit of 255 charcters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual Address PostalAddress { get; set; }

        /// <summary>The first admin details of the customer, present in case of TEAM customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryAdmin")]
        public virtual PrimaryAdmin PrimaryAdmin { get; set; }

        /// <summary>
        /// URL to customer's Admin console dashboard. The read-only URL is generated by the API service. This is used
        /// if your client application requires the customer to complete a task in the Admin console.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUiUrl")]
        public virtual string ResourceUiUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for primary admin in case of TEAM customers</summary>
    public class PrimaryAdmin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Primary admin's domained email This email's domain will be used to create TEAM customer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a subscription renewal settings.</summary>
    public class RenewalSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies the resource as a subscription renewal setting. Value: `subscriptions#renewalSettings`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Renewal settings for the annual commitment plan. For more detailed information, see renewal options in the
        /// administrator help center. When renewing a subscription, the `renewalType` is a required property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalType")]
        public virtual string RenewalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for resellernotify getwatchdetails response.</summary>
    public class ResellernotifyGetwatchdetailsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of registered service accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> ServiceAccountEmailAddresses { get; set; }

        /// <summary>Topic name of the PubSub</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for resellernotify response.</summary>
    public class ResellernotifyResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Topic name of the PubSub</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for subscription seats.</summary>
    public class Seats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the resource as a subscription seat setting. Value: `subscriptions#seats`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Read-only field containing the current number of users that are assigned a license for the product defined
        /// in `skuId`. This field's value is equivalent to the numerical count of users returned by the Enterprise
        /// License Manager API method:
        /// [`listForProductAndSku`](/admin-sdk/licensing/v1/reference/licenseAssignments/listForProductAndSku).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licensedNumberOfSeats")]
        public virtual System.Nullable<int> LicensedNumberOfSeats { get; set; }

        /// <summary>
        /// This is a required property and is exclusive to subscriptions with `FLEXIBLE` or `TRIAL` plans. This
        /// property sets the maximum number of licensed users allowed on a subscription. This quantity can be increased
        /// up to the maximum limit defined in the reseller's contract. The minimum quantity is the current number of
        /// users in the customer account. *Note: *G Suite subscriptions automatically assign a license to every user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumNumberOfSeats")]
        public virtual System.Nullable<int> MaximumNumberOfSeats { get; set; }

        /// <summary>
        /// This is a required property and is exclusive to subscriptions with `ANNUAL_MONTHLY_PAY` and
        /// `ANNUAL_YEARLY_PAY` plans. This property sets the maximum number of licenses assignable to users on a
        /// subscription. The reseller can add more licenses, but once set, the `numberOfSeats` cannot be reduced until
        /// renewal. The reseller is invoiced based on the `numberOfSeats` value regardless of how many of these user
        /// licenses are assigned. *Note: *G Suite subscriptions automatically assign a license to every user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberOfSeats")]
        public virtual System.Nullable<int> NumberOfSeats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a subscription.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Read-only field that returns the current billing method for a subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingMethod")]
        public virtual string BillingMethod { get; set; }

        /// <summary>
        /// The `creationTime` property is the date when subscription was created. It is in milliseconds using the Epoch
        /// format. See an example Epoch converter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; }

        /// <summary>Primary domain name of the customer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerDomain")]
        public virtual string CustomerDomain { get; set; }

        /// <summary>
        /// This property will always be returned in a response as the unique identifier generated by Google. In a
        /// request, this property can be either the primary domain or the unique identifier generated by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>
        /// Google-issued code (100 char max) for discounted pricing on subscription plans. Deal code must be included
        /// in `insert` requests in order to receive discounted rate. This property is optional, regular pricing applies
        /// if left empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealCode")]
        public virtual string DealCode { get; set; }

        /// <summary>Identifies the resource as a Subscription. Value: `reseller#subscription`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The `plan` property is required. In this version of the API, the G Suite plans are the flexible plan, annual
        /// commitment plan, and the 30-day free trial plan. For more information about the API"s payment plans, see the
        /// API concepts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual PlanData Plan { get; set; }

        /// <summary>
        /// This is an optional property. This purchase order (PO) information is for resellers to use for their company
        /// tracking usage. If a `purchaseOrderId` value is given it appears in the API responses and shows up in the
        /// invoice. The property accepts up to 80 plain text characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseOrderId")]
        public virtual string PurchaseOrderId { get; set; }

        /// <summary>
        /// Renewal settings for the annual commitment plan. For more detailed information, see renewal options in the
        /// administrator help center.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalSettings")]
        public virtual RenewalSettings RenewalSettings { get; set; }

        /// <summary>
        /// URL to customer's Subscriptions page in the Admin console. The read-only URL is generated by the API
        /// service. This is used if your client application requires the customer to complete a task using the
        /// Subscriptions page in the Admin console.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUiUrl")]
        public virtual string ResourceUiUrl { get; set; }

        /// <summary>This is a required property. The number and limit of user seat licenses in the plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seats")]
        public virtual Seats Seats { get; set; }

        /// <summary>
        /// A required property. The `skuId` is a unique system identifier for a product's SKU assigned to a customer in
        /// the subscription. For products and SKUs available in this version of the API, see Product and SKU IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

        /// <summary>
        /// Read-only external display name for a product's SKU assigned to a customer in the subscription. SKU names
        /// are subject to change at Google's discretion. For products and SKUs available in this version of the API,
        /// see Product and SKU IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuName")]
        public virtual string SkuName { get; set; }

        /// <summary>This is an optional property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// The `subscriptionId` is the subscription identifier and is unique for each customer. This is a required
        /// property. Since a `subscriptionId` changes when a subscription is updated, we recommend not using this ID as
        /// a key for persistent data. Use the `subscriptionId` as described in retrieve all reseller subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionId")]
        public virtual string SubscriptionId { get; set; }

        /// <summary>
        /// Read-only field containing an enumerable of all the current suspension reasons for a subscription. It is
        /// possible for a subscription to have many concurrent, overlapping suspension reasons. A subscription's
        /// `STATUS` is `SUSPENDED` until all pending suspensions are removed. Possible options include: -
        /// `PENDING_TOS_ACCEPTANCE` - The customer has not logged in and accepted the G Suite Resold Terms of Services.
        /// - `RENEWAL_WITH_TYPE_CANCEL` - The customer's commitment ended and their service was cancelled at the end of
        /// their term. - `RESELLER_INITIATED` - A manual suspension invoked by a Reseller. - `TRIAL_ENDED` - The
        /// customer's trial expired without a plan selected. - `OTHER` - The customer is suspended for an internal
        /// Google reason (e.g. abuse or otherwise).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReasons")]
        public virtual System.Collections.Generic.IList<string> SuspensionReasons { get; set; }

        /// <summary>
        /// Read-only transfer related information for the subscription. For more information, see retrieve transferable
        /// subscriptions for a customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferInfo")]
        public virtual TransferInfoData TransferInfo { get; set; }

        /// <summary>
        /// The G Suite annual commitment and flexible payment plans can be in a 30-day free trial. For more
        /// information, see the API concepts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialSettings")]
        public virtual TrialSettingsData TrialSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// The `plan` property is required. In this version of the API, the G Suite plans are the flexible plan, annual
        /// commitment plan, and the 30-day free trial plan. For more information about the API"s payment plans, see the
        /// API concepts.
        /// </summary>
        public class PlanData
        {
            /// <summary>
            /// In this version of the API, annual commitment plan's interval is one year. *Note: *When `billingMethod`
            /// value is `OFFLINE`, the subscription property object `plan.commitmentInterval` is omitted in all API
            /// responses.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("commitmentInterval")]
            public virtual CommitmentIntervalData CommitmentInterval { get; set; }

            /// <summary>
            /// The `isCommitmentPlan` property's boolean value identifies the plan as an annual commitment plan: -
            /// `true` — The subscription's plan is an annual commitment plan. - `false` — The plan is not an annual
            /// commitment plan.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isCommitmentPlan")]
            public virtual System.Nullable<bool> IsCommitmentPlan { get; set; }

            /// <summary>
            /// The `planName` property is required. This is the name of the subscription's plan. For more information
            /// about the Google payment plans, see the API concepts. Possible values are: - `ANNUAL_MONTHLY_PAY` — The
            /// annual commitment plan with monthly payments. *Caution: *`ANNUAL_MONTHLY_PAY` is returned as `ANNUAL` in
            /// all API responses. - `ANNUAL_YEARLY_PAY` — The annual commitment plan with yearly payments - `FLEXIBLE`
            /// — The flexible plan - `TRIAL` — The 30-day free trial plan. A subscription in trial will be suspended
            /// after the 30th free day if no payment plan is assigned. Calling `changePlan` will assign a payment plan
            /// to a trial but will not activate the plan. A trial will automatically begin its assigned payment plan
            /// after its 30th free day or immediately after calling `startPaidService`. - `FREE` — The free plan is
            /// exclusive to the Cloud Identity SKU and does not incur any billing.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("planName")]
            public virtual string PlanName { get; set; }

            /// <summary>
            /// In this version of the API, annual commitment plan's interval is one year. *Note: *When `billingMethod`
            /// value is `OFFLINE`, the subscription property object `plan.commitmentInterval` is omitted in all API
            /// responses.
            /// </summary>
            public class CommitmentIntervalData
            {
                /// <summary>
                /// An annual commitment plan's interval's `endTime` in milliseconds using the UNIX Epoch format. See an
                /// example Epoch converter.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
                public virtual System.Nullable<long> EndTime { get; set; }

                /// <summary>
                /// An annual commitment plan's interval's `startTime` in milliseconds using UNIX Epoch format. See an
                /// example Epoch converter.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
                public virtual System.Nullable<long> StartTime { get; set; }
            }
        }

        /// <summary>
        /// Read-only transfer related information for the subscription. For more information, see retrieve transferable
        /// subscriptions for a customer.
        /// </summary>
        public class TransferInfoData
        {
            /// <summary>
            /// Sku id of the current resold subscription. This is populated only when customer has subscription with
            /// legacy sku and the subscription resource is populated with recommeded sku for transfer in.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("currentLegacySkuId")]
            public virtual string CurrentLegacySkuId { get; set; }

            /// <summary>
            /// When inserting a subscription, this is the minimum number of seats listed in the transfer order for this
            /// product. For example, if the customer has 20 users, the reseller cannot place a transfer order of 15
            /// seats. The minimum is 20 seats.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minimumTransferableSeats")]
            public virtual System.Nullable<int> MinimumTransferableSeats { get; set; }

            /// <summary>
            /// The time when transfer token or intent to transfer will expire. The time is in milliseconds using UNIX
            /// Epoch format.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("transferabilityExpirationTime")]
            public virtual System.Nullable<long> TransferabilityExpirationTime { get; set; }
        }

        /// <summary>
        /// The G Suite annual commitment and flexible payment plans can be in a 30-day free trial. For more
        /// information, see the API concepts.
        /// </summary>
        public class TrialSettingsData
        {
            /// <summary>
            /// Determines if a subscription's plan is in a 30-day free trial or not: - `true` — The plan is in trial. -
            /// `false` — The plan is not in trial.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isInTrial")]
            public virtual System.Nullable<bool> IsInTrial { get; set; }

            /// <summary>
            /// Date when the trial ends. The value is in milliseconds using the UNIX Epoch format. See an example Epoch
            /// converter.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("trialEndTime")]
            public virtual System.Nullable<long> TrialEndTime { get; set; }
        }
    }

    /// <summary>
    /// A subscription manages the relationship of a Google customer's payment plan with a product's SKU, user licenses,
    /// 30-day free trial status, and renewal options. A primary role of a reseller is to manage the Google customer's
    /// subscriptions.
    /// </summary>
    public class Subscriptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the resource as a collection of subscriptions. Value: reseller#subscriptions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The subscriptions in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> SubscriptionsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
