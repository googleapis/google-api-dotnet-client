// Copyright 2026 Google LLC
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

namespace Google.Apis.CloudProductRegistry.v1
{
    /// <summary>The CloudProductRegistry Service.</summary>
    public class CloudProductRegistryService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudProductRegistryService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudProductRegistryService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            LogicalProducts = new LogicalProductsResource(this);
            ProductSuites = new ProductSuitesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudproductregistry.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudproductregistry.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudproductregistry";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the LogicalProducts resource.</summary>
        public virtual LogicalProductsResource LogicalProducts { get; }

        /// <summary>Gets the ProductSuites resource.</summary>
        public virtual ProductSuitesResource ProductSuites { get; }
    }

    /// <summary>A base abstract class for CloudProductRegistry requests.</summary>
    public abstract class CloudProductRegistryBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudProductRegistryBaseServiceRequest instance.</summary>
        protected CloudProductRegistryBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudProductRegistry parameter list.</summary>
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

    /// <summary>The "logicalProducts" collection of methods.</summary>
    public class LogicalProductsResource
    {
        private const string Resource = "logicalProducts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LogicalProductsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Variants = new VariantsResource(service);
        }

        /// <summary>Gets the Variants resource.</summary>
        public virtual VariantsResource Variants { get; }

        /// <summary>The "variants" collection of methods.</summary>
        public class VariantsResource
        {
            private const string Resource = "variants";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VariantsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get details of a LogicalProductVariant.</summary>
            /// <param name="name">
            /// Required. The name of the LogicalProductVariant to retrieve. Format:
            /// logicalProducts/{logical_product}/variants/{variant}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get details of a LogicalProductVariant.</summary>
            public class GetRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.LogicalProductVariant>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the LogicalProductVariant to retrieve. Format:
                /// logicalProducts/{logical_product}/variants/{variant}
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
                        Pattern = @"^logicalProducts/[^/]+/variants/[^/]+$",
                    });
                }
            }

            /// <summary>Lists LogicalProductVariants matching given criteria.</summary>
            /// <param name="parent">
            /// Required. Parent logical product id. Format: logicalProducts/{logical_product}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists LogicalProductVariants matching given criteria.</summary>
            public class ListRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.ListLogicalProductVariantsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Parent logical product id. Format: logicalProducts/{logical_product}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of logical product variants to return. The service may return fewer
                /// than this value. If unspecified, at most 100 logical product variants will be returned. The maximum
                /// value is 500; values above 500 will be coerced to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListLogicalProductVariants` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListLogicalProductVariants` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/variants";

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
                        Pattern = @"^logicalProducts/[^/]+$",
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

            /// <summary>Look up entities.</summary>
            /// <param name="lookupUri">
            /// Required. Entity uri to look up. Supported Formats: logicalProducts/{logical_product}
            /// logicalProducts/{logical_product}/variants/{variant} productSuites/{product_suite}
            /// </param>
            public virtual LookupEntityRequest LookupEntity(string lookupUri)
            {
                return new LookupEntityRequest(this.service, lookupUri);
            }

            /// <summary>Look up entities.</summary>
            public class LookupEntityRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.LookupEntityResponse>
            {
                /// <summary>Constructs a new LookupEntity request.</summary>
                public LookupEntityRequest(Google.Apis.Services.IClientService service, string lookupUri) : base(service)
                {
                    LookupUri = lookupUri;
                    InitParameters();
                }

                /// <summary>
                /// Required. Entity uri to look up. Supported Formats: logicalProducts/{logical_product}
                /// logicalProducts/{logical_product}/variants/{variant} productSuites/{product_suite}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("lookupUri", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LookupUri { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "lookupEntity";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+lookupUri}:lookupEntity";

                /// <summary>Initializes LookupEntity parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("lookupUri", new Google.Apis.Discovery.Parameter
                    {
                        Name = "lookupUri",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^logicalProducts/[^/]+/variants/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets details of a LogicalProduct.</summary>
        /// <param name="name">
        /// Required. The name of the LogicalProduct to retrieve. Format: logicalProducts/{logical_product}
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets details of a LogicalProduct.</summary>
        public class GetRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.LogicalProduct>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the LogicalProduct to retrieve. Format: logicalProducts/{logical_product}
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
                    Pattern = @"^logicalProducts/[^/]+$",
                });
            }
        }

        /// <summary>Lists LogicalProducts matching given criteria.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists LogicalProducts matching given criteria.</summary>
        public class ListRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.ListLogicalProductsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The filter expression for listing logical products. Filter syntax: https://google.aip.dev/160
            /// Supported fields: suite_id
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The maximum number of logical products to return. The service may return fewer than this
            /// value. If unspecified, at most 100 logical products will be returned. The maximum value is 500; values
            /// above 500 will be coerced to 500.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListLogicalProducts` call. Provide this to retrieve
            /// the subsequent page. When paginating, all other parameters provided to `ListLogicalProducts` must match
            /// the call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/logicalProducts";

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

        /// <summary>Look up entities.</summary>
        /// <param name="lookupUri">
        /// Required. Entity uri to look up. Supported Formats: logicalProducts/{logical_product}
        /// logicalProducts/{logical_product}/variants/{variant} productSuites/{product_suite}
        /// </param>
        public virtual LookupEntityRequest LookupEntity(string lookupUri)
        {
            return new LookupEntityRequest(this.service, lookupUri);
        }

        /// <summary>Look up entities.</summary>
        public class LookupEntityRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.LookupEntityResponse>
        {
            /// <summary>Constructs a new LookupEntity request.</summary>
            public LookupEntityRequest(Google.Apis.Services.IClientService service, string lookupUri) : base(service)
            {
                LookupUri = lookupUri;
                InitParameters();
            }

            /// <summary>
            /// Required. Entity uri to look up. Supported Formats: logicalProducts/{logical_product}
            /// logicalProducts/{logical_product}/variants/{variant} productSuites/{product_suite}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("lookupUri", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LookupUri { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookupEntity";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+lookupUri}:lookupEntity";

            /// <summary>Initializes LookupEntity parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("lookupUri", new Google.Apis.Discovery.Parameter
                {
                    Name = "lookupUri",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^logicalProducts/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "productSuites" collection of methods.</summary>
    public class ProductSuitesResource
    {
        private const string Resource = "productSuites";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProductSuitesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Get details of a ProductSuite.</summary>
        /// <param name="name">
        /// Required. The name of the ProductSuite to retrieve. Format: productSuites/{product_suite}
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Get details of a ProductSuite.</summary>
        public class GetRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.ProductSuite>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the ProductSuite to retrieve. Format: productSuites/{product_suite}
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
                    Pattern = @"^productSuites/[^/]+$",
                });
            }
        }

        /// <summary>Lists ProductSuites.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists ProductSuites.</summary>
        public class ListRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.ListProductSuitesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of suites to return. The service may return fewer than this value. If
            /// unspecified, at most 100 suites will be returned. The maximum value is 500; values above 500 will be
            /// coerced to 500.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListProductSuites` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `ListProductSuites` must match the
            /// call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/productSuites";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary>Look up entities.</summary>
        /// <param name="lookupUri">
        /// Required. Entity uri to look up. Supported Formats: logicalProducts/{logical_product}
        /// logicalProducts/{logical_product}/variants/{variant} productSuites/{product_suite}
        /// </param>
        public virtual LookupEntityRequest LookupEntity(string lookupUri)
        {
            return new LookupEntityRequest(this.service, lookupUri);
        }

        /// <summary>Look up entities.</summary>
        public class LookupEntityRequest : CloudProductRegistryBaseServiceRequest<Google.Apis.CloudProductRegistry.v1.Data.LookupEntityResponse>
        {
            /// <summary>Constructs a new LookupEntity request.</summary>
            public LookupEntityRequest(Google.Apis.Services.IClientService service, string lookupUri) : base(service)
            {
                LookupUri = lookupUri;
                InitParameters();
            }

            /// <summary>
            /// Required. Entity uri to look up. Supported Formats: logicalProducts/{logical_product}
            /// logicalProducts/{logical_product}/variants/{variant} productSuites/{product_suite}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("lookupUri", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string LookupUri { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookupEntity";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+lookupUri}:lookupEntity";

            /// <summary>Initializes LookupEntity parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("lookupUri", new Google.Apis.Discovery.Parameter
                {
                    Name = "lookupUri",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^productSuites/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.CloudProductRegistry.v1.Data
{
    /// <summary>Response message for ListLogicalProductVariants.</summary>
    public class ListLogicalProductVariantsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Matched LogicalProductVariants</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalProductVariants")]
        public virtual System.Collections.Generic.IList<LogicalProductVariant> LogicalProductVariants { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListLogicalProducts.</summary>
    public class ListLogicalProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Matched LogicalProducts</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalProducts")]
        public virtual System.Collections.Generic.IList<LogicalProduct> LogicalProducts { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListProductSuites.</summary>
    public class ListProductSuitesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Matched ProductSuites</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSuites")]
        public virtual System.Collections.Generic.IList<ProductSuite> ProductSuites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an independent service offering that can be provisioned by a customer.</summary>
    public class LogicalProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Current Lifecycle state of the logical product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>
        /// Identifier. The resource name of the LogicalProduct. Format: logicalProducts/{logical_product}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Product suite associated with the logical product. Format: productSuites/{product_suite}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSuite")]
        public virtual string ProductSuite { get; set; }

        /// <summary>
        /// Output only. Indicates whether the logical product has been replaced. If `false`, the product is active. If
        /// `true`, the product has been replaced by another type, and the `replacement` field contains the resource
        /// name of that replacement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaced")]
        public virtual System.Nullable<bool> Replaced { get; set; }

        /// <summary>
        /// Output only. The resource name of the Logical Entity that the logical product is replaced by. This field is
        /// only populated when this logical product is replaced by some other type. Eg:
        /// logicalProducts/{logical_product}/variants/{variant}, productSuites/{product_suite}, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacement")]
        public virtual string Replacement { get; set; }

        /// <summary>Display name of the LogicalProduct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Output only. Child variant resource references. Format: logicalProducts/{logical_product}/variants/{variant}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual System.Collections.Generic.IList<string> Variants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a distinct offering derived from a primary product that retains core functionalities but offers
    /// specialized features for a specific market segment.
    /// </summary>
    public class LogicalProductVariant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Current Lifecycle state of the logical product variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>
        /// Identifier. The resource name of the LogicalProductVariant. Format:
        /// logicalProducts/{logical_product}/variants/{variant}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Indicates whether the logical product variant has been replaced. If `false`, the variant is
        /// active. If `true`, the variant has been replaced by another type, and the `replacement` field contains the
        /// resource name of that replacement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaced")]
        public virtual System.Nullable<bool> Replaced { get; set; }

        /// <summary>
        /// Output only. The resource name of the Logical Entity that the logical product variant is replaced by. This
        /// field is only populated when this logical product variant is replaced by some other type. Eg:
        /// logicalProducts/{logical_product}, productSuites/{product_suite}, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacement")]
        public virtual string Replacement { get; set; }

        /// <summary>Display name of the LogicalProductVariant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for LookupEntity.</summary>
    public class LookupEntityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Matched LogicalProduct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalProduct")]
        public virtual LogicalProduct LogicalProduct { get; set; }

        /// <summary>Matched LogicalProductVariant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalProductVariant")]
        public virtual LogicalProductVariant LogicalProductVariant { get; set; }

        /// <summary>Matched ProductSuite.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productSuite")]
        public virtual ProductSuite ProductSuite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a unified grouping of products sharing a common brand and market positioning.</summary>
    public class ProductSuite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. LogicalProducts under this suite. Format: logicalProducts/{logical_product}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalProducts")]
        public virtual System.Collections.Generic.IList<string> LogicalProducts { get; set; }

        /// <summary>Identifier. The resource name of the ProductSuite. Format: productSuites/{product_suite}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Indicates whether the product suite has been replaced. If `false`, the product suite is active.
        /// If `true`, the product suite has been replaced by another type, and the `replacement` field contains the
        /// resource name of that replacement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaced")]
        public virtual System.Nullable<bool> Replaced { get; set; }

        /// <summary>
        /// Output only. The resource name of the Logical Entity that the product suite is replaced by. This field is
        /// only populated when this product suite is replaced by some other type. Eg:
        /// logicalProducts/{logical_product}, logicalProducts/{logical_product}/variants/{variant}, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacement")]
        public virtual string Replacement { get; set; }

        /// <summary>Title of the ProductSuite.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
