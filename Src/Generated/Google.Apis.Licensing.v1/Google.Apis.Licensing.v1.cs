// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Licensing.v1
{
    /// <summary>The Licensing Service.</summary>
    public class LicensingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public LicensingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public LicensingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            LicenseAssignments = new LicenseAssignmentsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "licensing";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://licensing.googleapis.com/";
        #else
            "https://licensing.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://licensing.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Enterprise License Manager API.</summary>
        public class Scope
        {
            /// <summary>View and manage G Suite licenses for your domain</summary>
            public static string AppsLicensing = "https://www.googleapis.com/auth/apps.licensing";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Enterprise License Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage G Suite licenses for your domain</summary>
            public const string AppsLicensing = "https://www.googleapis.com/auth/apps.licensing";

        }



        /// <summary>Gets the LicenseAssignments resource.</summary>
        public virtual LicenseAssignmentsResource LicenseAssignments { get; }
    }

    /// <summary>A base abstract class for Licensing requests.</summary>
    public abstract class LicensingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new LicensingBaseServiceRequest instance.</summary>
        protected LicensingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
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
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Licensing parameter list.</summary>
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

    /// <summary>The "licenseAssignments" collection of methods.</summary>
    public class LicenseAssignmentsResource
    {
        private const string Resource = "licenseAssignments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LicenseAssignmentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Revoke a license.</summary>
        /// <param name="productId">A product's unique identifier. For more information about products in this version of the
        /// API, see Products and SKUs.</param>
        /// <param name="skuId">A product SKU's unique identifier. For more
        /// information about available SKUs in this version of the API, see Products and SKUs.</param>
        /// <param
        /// name="userId">The user's current primary email address. If the user's email address changes, use the new email
        /// address in your API requests. Since a `userId` is subject to change, do not use a `userId` value as a key for
        /// persistent data. This key could break if the current user's email address changes. If the `userId` is suspended, the
        /// license status changes.</param>
        public virtual DeleteRequest Delete(string productId, string skuId, string userId)
        {
            return new DeleteRequest(service, productId, skuId, userId);
        }

        /// <summary>Revoke a license.</summary>
        public class DeleteRequest : LicensingBaseServiceRequest<Google.Apis.Licensing.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string productId, string skuId, string userId) : base(service)
            {
                ProductId = productId;
                SkuId = skuId;
                UserId = userId;
                InitParameters();
            }


            /// <summary>A product's unique identifier. For more information about products in this version of the API,
            /// see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>A product SKU's unique identifier. For more information about available SKUs in this version of
            /// the API, see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("skuId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SkuId { get; private set; }

            /// <summary>The user's current primary email address. If the user's email address changes, use the new
            /// email address in your API requests. Since a `userId` is subject to change, do not use a `userId` value
            /// as a key for persistent data. This key could break if the current user's email address changes. If the
            /// `userId` is suspended, the license status changes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/licensing/v1/product/{productId}/sku/{skuId}/user/{userId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("skuId", new Google.Apis.Discovery.Parameter
                {
                    Name = "skuId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Get a specific user's license by product SKU.</summary>
        /// <param name="productId">A product's unique identifier. For more information about products in this version of the
        /// API, see Products and SKUs.</param>
        /// <param name="skuId">A product SKU's unique identifier. For more
        /// information about available SKUs in this version of the API, see Products and SKUs.</param>
        /// <param
        /// name="userId">The user's current primary email address. If the user's email address changes, use the new email
        /// address in your API requests. Since a `userId` is subject to change, do not use a `userId` value as a key for
        /// persistent data. This key could break if the current user's email address changes. If the `userId` is suspended, the
        /// license status changes.</param>
        public virtual GetRequest Get(string productId, string skuId, string userId)
        {
            return new GetRequest(service, productId, skuId, userId);
        }

        /// <summary>Get a specific user's license by product SKU.</summary>
        public class GetRequest : LicensingBaseServiceRequest<Google.Apis.Licensing.v1.Data.LicenseAssignment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string productId, string skuId, string userId) : base(service)
            {
                ProductId = productId;
                SkuId = skuId;
                UserId = userId;
                InitParameters();
            }


            /// <summary>A product's unique identifier. For more information about products in this version of the API,
            /// see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>A product SKU's unique identifier. For more information about available SKUs in this version of
            /// the API, see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("skuId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SkuId { get; private set; }

            /// <summary>The user's current primary email address. If the user's email address changes, use the new
            /// email address in your API requests. Since a `userId` is subject to change, do not use a `userId` value
            /// as a key for persistent data. This key could break if the current user's email address changes. If the
            /// `userId` is suspended, the license status changes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/licensing/v1/product/{productId}/sku/{skuId}/user/{userId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("skuId", new Google.Apis.Discovery.Parameter
                {
                    Name = "skuId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Assign a license.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="productId">A product's unique identifier. For more information about products in this version of the
        /// API, see Products and SKUs.</param>
        /// <param name="skuId">A product SKU's unique identifier. For more
        /// information about available SKUs in this version of the API, see Products and SKUs.</param>
        public virtual InsertRequest Insert(Google.Apis.Licensing.v1.Data.LicenseAssignmentInsert body, string productId, string skuId)
        {
            return new InsertRequest(service, body, productId, skuId);
        }

        /// <summary>Assign a license.</summary>
        public class InsertRequest : LicensingBaseServiceRequest<Google.Apis.Licensing.v1.Data.LicenseAssignment>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Licensing.v1.Data.LicenseAssignmentInsert body, string productId, string skuId) : base(service)
            {
                ProductId = productId;
                SkuId = skuId;
                Body = body;
                InitParameters();
            }


            /// <summary>A product's unique identifier. For more information about products in this version of the API,
            /// see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>A product SKU's unique identifier. For more information about available SKUs in this version of
            /// the API, see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("skuId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SkuId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Licensing.v1.Data.LicenseAssignmentInsert Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/licensing/v1/product/{productId}/sku/{skuId}/user";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("skuId", new Google.Apis.Discovery.Parameter
                {
                    Name = "skuId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>List all users assigned licenses for a specific product SKU.</summary>
        /// <param name="productId">A product's unique identifier. For more information about products in this version of the
        /// API, see Products and SKUs.</param>
        /// <param name="customerId">Customer's `customerId`. A previous version of
        /// this API accepted the primary domain name as a value for this field. If the customer is suspended, the server
        /// returns an error.</param>
        public virtual ListForProductRequest ListForProduct(string productId, string customerId)
        {
            return new ListForProductRequest(service, productId, customerId);
        }

        /// <summary>List all users assigned licenses for a specific product SKU.</summary>
        public class ListForProductRequest : LicensingBaseServiceRequest<Google.Apis.Licensing.v1.Data.LicenseAssignmentList>
        {
            /// <summary>Constructs a new ListForProduct request.</summary>
            public ListForProductRequest(Google.Apis.Services.IClientService service, string productId, string customerId) : base(service)
            {
                ProductId = productId;
                CustomerId = customerId;
                InitParameters();
            }


            /// <summary>A product's unique identifier. For more information about products in this version of the API,
            /// see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>Customer's `customerId`. A previous version of this API accepted the primary domain name as a
            /// value for this field. If the customer is suspended, the server returns an error.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The `maxResults` query string determines how many entries are returned on each page of a large
            /// response. This is an optional parameter. The value must be a positive number.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Token to fetch the next page of data. The `maxResults` query string is related to the
            /// `pageToken` since `maxResults` determines how many entries are returned on each page. This is an
            /// optional query string. If not specified, the server returns the first page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listForProduct";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/licensing/v1/product/{productId}/users";

            /// <summary>Initializes ListForProduct parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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

        /// <summary>List all users assigned licenses for a specific product SKU.</summary>
        /// <param name="productId">A product's unique identifier. For more information about products in this version of the
        /// API, see Products and SKUs.</param>
        /// <param name="skuId">A product SKU's unique identifier. For more
        /// information about available SKUs in this version of the API, see Products and SKUs.</param>
        /// <param
        /// name="customerId">Customer's `customerId`. A previous version of this API accepted the primary domain name as a
        /// value for this field. If the customer is suspended, the server returns an error.</param>
        public virtual ListForProductAndSkuRequest ListForProductAndSku(string productId, string skuId, string customerId)
        {
            return new ListForProductAndSkuRequest(service, productId, skuId, customerId);
        }

        /// <summary>List all users assigned licenses for a specific product SKU.</summary>
        public class ListForProductAndSkuRequest : LicensingBaseServiceRequest<Google.Apis.Licensing.v1.Data.LicenseAssignmentList>
        {
            /// <summary>Constructs a new ListForProductAndSku request.</summary>
            public ListForProductAndSkuRequest(Google.Apis.Services.IClientService service, string productId, string skuId, string customerId) : base(service)
            {
                ProductId = productId;
                SkuId = skuId;
                CustomerId = customerId;
                InitParameters();
            }


            /// <summary>A product's unique identifier. For more information about products in this version of the API,
            /// see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>A product SKU's unique identifier. For more information about available SKUs in this version of
            /// the API, see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("skuId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SkuId { get; private set; }

            /// <summary>Customer's `customerId`. A previous version of this API accepted the primary domain name as a
            /// value for this field. If the customer is suspended, the server returns an error.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; private set; }

            /// <summary>The `maxResults` query string determines how many entries are returned on each page of a large
            /// response. This is an optional parameter. The value must be a positive number.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Token to fetch the next page of data. The `maxResults` query string is related to the
            /// `pageToken` since `maxResults` determines how many entries are returned on each page. This is an
            /// optional query string. If not specified, the server returns the first page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listForProductAndSku";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/licensing/v1/product/{productId}/sku/{skuId}/users";

            /// <summary>Initializes ListForProductAndSku parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("skuId", new Google.Apis.Discovery.Parameter
                {
                    Name = "skuId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "100",
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

        /// <summary>Reassign a user's product SKU with a different SKU in the same product. This method supports patch
        /// semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="productId">A product's unique identifier. For more information about products in this version of the
        /// API, see Products and SKUs.</param>
        /// <param name="skuId">A product SKU's unique identifier. For more
        /// information about available SKUs in this version of the API, see Products and SKUs.</param>
        /// <param
        /// name="userId">The user's current primary email address. If the user's email address changes, use the new email
        /// address in your API requests. Since a `userId` is subject to change, do not use a `userId` value as a key for
        /// persistent data. This key could break if the current user's email address changes. If the `userId` is suspended, the
        /// license status changes.</param>
        public virtual PatchRequest Patch(Google.Apis.Licensing.v1.Data.LicenseAssignment body, string productId, string skuId, string userId)
        {
            return new PatchRequest(service, body, productId, skuId, userId);
        }

        /// <summary>Reassign a user's product SKU with a different SKU in the same product. This method supports patch
        /// semantics.</summary>
        public class PatchRequest : LicensingBaseServiceRequest<Google.Apis.Licensing.v1.Data.LicenseAssignment>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Licensing.v1.Data.LicenseAssignment body, string productId, string skuId, string userId) : base(service)
            {
                ProductId = productId;
                SkuId = skuId;
                UserId = userId;
                Body = body;
                InitParameters();
            }


            /// <summary>A product's unique identifier. For more information about products in this version of the API,
            /// see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>A product SKU's unique identifier. For more information about available SKUs in this version of
            /// the API, see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("skuId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SkuId { get; private set; }

            /// <summary>The user's current primary email address. If the user's email address changes, use the new
            /// email address in your API requests. Since a `userId` is subject to change, do not use a `userId` value
            /// as a key for persistent data. This key could break if the current user's email address changes. If the
            /// `userId` is suspended, the license status changes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Licensing.v1.Data.LicenseAssignment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/licensing/v1/product/{productId}/sku/{skuId}/user/{userId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("skuId", new Google.Apis.Discovery.Parameter
                {
                    Name = "skuId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Reassign a user's product SKU with a different SKU in the same product.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="productId">A product's unique identifier. For more information about products in this version of the
        /// API, see Products and SKUs.</param>
        /// <param name="skuId">A product SKU's unique identifier. For more
        /// information about available SKUs in this version of the API, see Products and SKUs.</param>
        /// <param
        /// name="userId">The user's current primary email address. If the user's email address changes, use the new email
        /// address in your API requests. Since a `userId` is subject to change, do not use a `userId` value as a key for
        /// persistent data. This key could break if the current user's email address changes. If the `userId` is suspended, the
        /// license status changes.</param>
        public virtual UpdateRequest Update(Google.Apis.Licensing.v1.Data.LicenseAssignment body, string productId, string skuId, string userId)
        {
            return new UpdateRequest(service, body, productId, skuId, userId);
        }

        /// <summary>Reassign a user's product SKU with a different SKU in the same product.</summary>
        public class UpdateRequest : LicensingBaseServiceRequest<Google.Apis.Licensing.v1.Data.LicenseAssignment>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Licensing.v1.Data.LicenseAssignment body, string productId, string skuId, string userId) : base(service)
            {
                ProductId = productId;
                SkuId = skuId;
                UserId = userId;
                Body = body;
                InitParameters();
            }


            /// <summary>A product's unique identifier. For more information about products in this version of the API,
            /// see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProductId { get; private set; }

            /// <summary>A product SKU's unique identifier. For more information about available SKUs in this version of
            /// the API, see Products and SKUs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("skuId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SkuId { get; private set; }

            /// <summary>The user's current primary email address. If the user's email address changes, use the new
            /// email address in your API requests. Since a `userId` is subject to change, do not use a `userId` value
            /// as a key for persistent data. This key could break if the current user's email address changes. If the
            /// `userId` is suspended, the license status changes.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Licensing.v1.Data.LicenseAssignment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apps/licensing/v1/product/{productId}/sku/{skuId}/user/{userId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                {
                    Name = "productId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("skuId", new Google.Apis.Discovery.Parameter
                {
                    Name = "skuId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }
}

namespace Google.Apis.Licensing.v1.Data
{    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Representation of a license assignment.</summary>
    public class LicenseAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etags")]
        public virtual string Etags { get; set; }

        /// <summary>Identifies the resource as a LicenseAssignment, which is `licensing#licenseAssignment`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A product's unique identifier. For more information about products in this version of the API, see
        /// Product and SKU IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>Display Name of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productName")]
        public virtual string ProductName { get; set; }

        /// <summary>Link to this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>A product SKU's unique identifier. For more information about available SKUs in this version of the
        /// API, see Products and SKUs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuId")]
        public virtual string SkuId { get; set; }

        /// <summary>Display Name of the sku of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skuName")]
        public virtual string SkuName { get; set; }

        /// <summary>The user's current primary email address. If the user's email address changes, use the new email
        /// address in your API requests. Since a `userId` is subject to change, do not use a `userId` value as a key
        /// for persistent data. This key could break if the current user's email address changes. If the `userId` is
        /// suspended, the license status changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Representation of a license assignment.</summary>
    public class LicenseAssignmentInsert : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email id of the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LicenseAssignmentList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The LicenseAssignments in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<LicenseAssignment> Items { get; set; }

        /// <summary>Identifies the resource as a collection of LicenseAssignments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The token that you must submit in a subsequent request to retrieve additional license results
        /// matching your query parameters. The `maxResults` query string is related to the `nextPageToken` since
        /// `maxResults` determines how many entries are returned on each next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

    }
}
