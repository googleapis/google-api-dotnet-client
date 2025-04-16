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

namespace Google.Apis.Merchant.inventories_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "inventories_v1beta";

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
            Products = new ProductsResource(service);
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
                LocalInventories = new LocalInventoriesResource(service);
                RegionalInventories = new RegionalInventoriesResource(service);
            }

            /// <summary>Gets the LocalInventories resource.</summary>
            public virtual LocalInventoriesResource LocalInventories { get; }

            /// <summary>The "localInventories" collection of methods.</summary>
            public class LocalInventoriesResource
            {
                private const string Resource = "localInventories";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LocalInventoriesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Deletes the specified `LocalInventory` from the given product in your merchant account. It might
                /// take a up to an hour for the `LocalInventory` to be deleted from the specific product. Once you have
                /// received a successful delete response, wait for that period before attempting a delete again.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the local inventory for the given product to delete. Format:
                /// `accounts/{account}/products/{product}/localInventories/{store_code}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes the specified `LocalInventory` from the given product in your merchant account. It might
                /// take a up to an hour for the `LocalInventory` to be deleted from the specific product. Once you have
                /// received a successful delete response, wait for that period before attempting a delete again.
                /// </summary>
                public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.inventories_v1beta.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the local inventory for the given product to delete. Format:
                    /// `accounts/{account}/products/{product}/localInventories/{store_code}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "inventories/v1beta/{+name}";

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
                            Pattern = @"^accounts/[^/]+/products/[^/]+/localInventories/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Inserts a `LocalInventory` resource to a product in your merchant account. Replaces the full
                /// `LocalInventory` resource if an entry with the same `storeCode` already exists for the product. It
                /// might take up to 30 minutes for the new or updated `LocalInventory` resource to appear in products.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The account and product where this inventory will be inserted. Format:
                /// `accounts/{account}/products/{product}`
                /// </param>
                public virtual InsertRequest Insert(Google.Apis.Merchant.inventories_v1beta.Data.LocalInventory body, string parent)
                {
                    return new InsertRequest(this.service, body, parent);
                }

                /// <summary>
                /// Inserts a `LocalInventory` resource to a product in your merchant account. Replaces the full
                /// `LocalInventory` resource if an entry with the same `storeCode` already exists for the product. It
                /// might take up to 30 minutes for the new or updated `LocalInventory` resource to appear in products.
                /// </summary>
                public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.inventories_v1beta.Data.LocalInventory>
                {
                    /// <summary>Constructs a new Insert request.</summary>
                    public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.inventories_v1beta.Data.LocalInventory body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account and product where this inventory will be inserted. Format:
                    /// `accounts/{account}/products/{product}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Merchant.inventories_v1beta.Data.LocalInventory Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "insert";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "inventories/v1beta/{+parent}/localInventories:insert";

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
                            Pattern = @"^accounts/[^/]+/products/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the `LocalInventory` resources for the given product in your merchant account. The response
                /// might contain fewer items than specified by `pageSize`. If `pageToken` was returned in previous
                /// request, it can be used to obtain additional results. `LocalInventory` resources are listed per
                /// product for a given account.
                /// </summary>
                /// <param name="parent">
                /// Required. The `name` of the parent product to list local inventories for. Format:
                /// `accounts/{account}/products/{product}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the `LocalInventory` resources for the given product in your merchant account. The response
                /// might contain fewer items than specified by `pageSize`. If `pageToken` was returned in previous
                /// request, it can be used to obtain additional results. `LocalInventory` resources are listed per
                /// product for a given account.
                /// </summary>
                public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.inventories_v1beta.Data.ListLocalInventoriesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `name` of the parent product to list local inventories for. Format:
                    /// `accounts/{account}/products/{product}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of `LocalInventory` resources for the given product to return. The service
                    /// returns fewer than this value if the number of inventories for the given product is less that
                    /// than the `pageSize`. The default value is 25000. The maximum value is 25000; If a value higher
                    /// than the maximum is specified, then the `pageSize` will default to the maximum
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListLocalInventories` call. Provide the page token to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListLocalInventories` must match the call that provided the page token. The token returned as
                    /// nextPageToken in the response to the previous request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "inventories/v1beta/{+parent}/localInventories";

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
                            Pattern = @"^accounts/[^/]+/products/[^/]+$",
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

            /// <summary>Gets the RegionalInventories resource.</summary>
            public virtual RegionalInventoriesResource RegionalInventories { get; }

            /// <summary>The "regionalInventories" collection of methods.</summary>
            public class RegionalInventoriesResource
            {
                private const string Resource = "regionalInventories";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RegionalInventoriesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Deletes the specified `RegionalInventory` resource from the given product in your merchant account.
                /// It might take up to an hour for the `RegionalInventory` to be deleted from the specific product.
                /// Once you have received a successful delete response, wait for that period before attempting a delete
                /// again.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the `RegionalInventory` resource to delete. Format:
                /// `accounts/{account}/products/{product}/regionalInventories/{region}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes the specified `RegionalInventory` resource from the given product in your merchant account.
                /// It might take up to an hour for the `RegionalInventory` to be deleted from the specific product.
                /// Once you have received a successful delete response, wait for that period before attempting a delete
                /// again.
                /// </summary>
                public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.inventories_v1beta.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `RegionalInventory` resource to delete. Format:
                    /// `accounts/{account}/products/{product}/regionalInventories/{region}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "inventories/v1beta/{+name}";

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
                            Pattern = @"^accounts/[^/]+/products/[^/]+/regionalInventories/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Inserts a `RegionalInventory` to a given product in your merchant account. Replaces the full
                /// `RegionalInventory` resource if an entry with the same `region` already exists for the product. It
                /// might take up to 30 minutes for the new or updated `RegionalInventory` resource to appear in
                /// products.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The account and product where this inventory will be inserted. Format:
                /// `accounts/{account}/products/{product}`
                /// </param>
                public virtual InsertRequest Insert(Google.Apis.Merchant.inventories_v1beta.Data.RegionalInventory body, string parent)
                {
                    return new InsertRequest(this.service, body, parent);
                }

                /// <summary>
                /// Inserts a `RegionalInventory` to a given product in your merchant account. Replaces the full
                /// `RegionalInventory` resource if an entry with the same `region` already exists for the product. It
                /// might take up to 30 minutes for the new or updated `RegionalInventory` resource to appear in
                /// products.
                /// </summary>
                public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.inventories_v1beta.Data.RegionalInventory>
                {
                    /// <summary>Constructs a new Insert request.</summary>
                    public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.inventories_v1beta.Data.RegionalInventory body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account and product where this inventory will be inserted. Format:
                    /// `accounts/{account}/products/{product}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Merchant.inventories_v1beta.Data.RegionalInventory Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "insert";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "inventories/v1beta/{+parent}/regionalInventories:insert";

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
                            Pattern = @"^accounts/[^/]+/products/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the `RegionalInventory` resources for the given product in your merchant account. The response
                /// might contain fewer items than specified by `pageSize`. If `pageToken` was returned in previous
                /// request, it can be used to obtain additional results. `RegionalInventory` resources are listed per
                /// product for a given account.
                /// </summary>
                /// <param name="parent">
                /// Required. The `name` of the parent product to list `RegionalInventory` resources for. Format:
                /// `accounts/{account}/products/{product}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the `RegionalInventory` resources for the given product in your merchant account. The response
                /// might contain fewer items than specified by `pageSize`. If `pageToken` was returned in previous
                /// request, it can be used to obtain additional results. `RegionalInventory` resources are listed per
                /// product for a given account.
                /// </summary>
                public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.inventories_v1beta.Data.ListRegionalInventoriesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `name` of the parent product to list `RegionalInventory` resources for. Format:
                    /// `accounts/{account}/products/{product}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of `RegionalInventory` resources for the given product to return. The service
                    /// returns fewer than this value if the number of inventories for the given product is less that
                    /// than the `pageSize`. The default value is 25000. The maximum value is 100000; If a value higher
                    /// than the maximum is specified, then the `pageSize` will default to the maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListRegionalInventories` call. Provide the page token to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListRegionalInventories` must match the call that provided the page token. The token returned
                    /// as nextPageToken in the response to the previous request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "inventories/v1beta/{+parent}/regionalInventories";

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
                            Pattern = @"^accounts/[^/]+/products/[^/]+$",
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
}
namespace Google.Apis.Merchant.inventories_v1beta.Data
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

    /// <summary>Response message for the `ListLocalInventories` method.</summary>
    public class ListLocalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `LocalInventory` resources for the given product from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localInventories")]
        public virtual System.Collections.Generic.IList<LocalInventory> LocalInventories { get; set; }

        /// <summary>
        /// A token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListRegionalInventories` method.</summary>
    public class ListRegionalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The `RegionalInventory` resources for the given product from the specified account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalInventories")]
        public virtual System.Collections.Generic.IList<RegionalInventory> RegionalInventories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Local inventory information for the product. Represents in-store information for a specific product at the store
    /// specified by `storeCode`. For a list of all accepted attribute values, see the [local product inventory data
    /// specification](https://support.google.com/merchants/answer/3061342).
    /// </summary>
    public class LocalInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The account that owns the product. This field will be ignored if set by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual System.Nullable<long> Account { get; set; }

        /// <summary>
        /// Availability of the product at this store. For accepted attribute values, see the [local product inventory
        /// data specification](https://support.google.com/merchants/answer/3061342)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>
        /// A list of custom (merchant-provided) attributes. You can also use `CustomAttribute` to submit any attribute
        /// of the data specification in its generic form.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>Location of the product inside the store. Maximum length is 20 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instoreProductLocation")]
        public virtual string InstoreProductLocation { get; set; }

        /// <summary>
        /// Output only. The name of the `LocalInventory` resource. Format:
        /// `accounts/{account}/products/{product}/localInventories/{store_code}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Supported pickup method for this product. Unless the value is `"not supported"`, this field must be
        /// submitted together with `pickupSla`. For accepted attribute values, see the [local product inventory data
        /// specification](https://support.google.com/merchants/answer/3061342)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupMethod")]
        public virtual string PickupMethod { get; set; }

        /// <summary>
        /// Relative time period from the order date for an order for this product, from this store, to be ready for
        /// pickup. Must be submitted with `pickupMethod`. For accepted attribute values, see the [local product
        /// inventory data specification](https://support.google.com/merchants/answer/3061342)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupSla")]
        public virtual string PickupSla { get; set; }

        /// <summary>Price of the product at this store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>Quantity of the product available at this store. Must be greater than or equal to zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>
        /// Sale price of the product at this store. Mandatory if `salePriceEffectiveDate` is defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePrice")]
        public virtual Price SalePrice { get; set; }

        /// <summary>The `TimePeriod` of the sale at this store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePriceEffectiveDate")]
        public virtual Interval SalePriceEffectiveDate { get; set; }

        /// <summary>
        /// Required. Immutable. Store code (the store ID from your Business Profile) of the physical store the product
        /// is sold in. See the [Local product inventory data
        /// specification](https://support.google.com/merchants/answer/3061342) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; }

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

        /// <summary>
        /// The time at which the event was generated. If you want to order the notification messages you receive you
        /// should rely on this field not on the order of receiving the notifications.
        /// </summary>
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

    /// <summary>
    /// Regional inventory information for the product. Represents specific information like price and availability for
    /// a given product in a specific `region`. For a list of all accepted attribute values, see the [regional product
    /// inventory data specification](https://support.google.com/merchants/answer/9698880).
    /// </summary>
    public class RegionalInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The account that owns the product. This field will be ignored if set by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual System.Nullable<long> Account { get; set; }

        /// <summary>
        /// Availability of the product in this region. For accepted attribute values, see the [regional product
        /// inventory data specification](https://support.google.com/merchants/answer/6324448).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>
        /// A list of custom (merchant-provided) attributes. You can also use `CustomAttribute` to submit any attribute
        /// of the data specification in its generic form.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAttributes")]
        public virtual System.Collections.Generic.IList<CustomAttribute> CustomAttributes { get; set; }

        /// <summary>
        /// Output only. The name of the `RegionalInventory` resource. Format:
        /// `{regional_inventory.name=accounts/{account}/products/{product}/regionalInventories/{region}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Price of the product in this region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>
        /// Required. Immutable. ID of the region for this `RegionalInventory` resource. See the [Regional availability
        /// and pricing](https://support.google.com/merchants/answer/9698880) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// Sale price of the product in this region. Mandatory if `salePriceEffectiveDate` is defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePrice")]
        public virtual Price SalePrice { get; set; }

        /// <summary>The `TimePeriod` of the sale price in this region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("salePriceEffectiveDate")]
        public virtual Interval SalePriceEffectiveDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
