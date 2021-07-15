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

namespace Google.Apis.CloudRetail.v2
{
    /// <summary>The CloudRetail Service.</summary>
    public class CloudRetailService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRetailService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRetailService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "retail";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://retail.googleapis.com/";
        #else
            "https://retail.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://retail.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Retail API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Retail API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudRetail requests.</summary>
    public abstract class CloudRetailBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRetailBaseServiceRequest instance.</summary>
        protected CloudRetailBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudRetail parameter list.</summary>
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

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
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
                Catalogs = new CatalogsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Catalogs resource.</summary>
            public virtual CatalogsResource Catalogs { get; }

            /// <summary>The "catalogs" collection of methods.</summary>
            public class CatalogsResource
            {
                private const string Resource = "catalogs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CatalogsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Branches = new BranchesResource(service);
                    Operations = new OperationsResource(service);
                    Placements = new PlacementsResource(service);
                    UserEvents = new UserEventsResource(service);
                }

                /// <summary>Gets the Branches resource.</summary>
                public virtual BranchesResource Branches { get; }

                /// <summary>The "branches" collection of methods.</summary>
                public class BranchesResource
                {
                    private const string Resource = "branches";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BranchesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Operations = new OperationsResource(service);
                        Products = new ProductsResource(service);
                    }

                    /// <summary>Gets the Operations resource.</summary>
                    public virtual OperationsResource Operations { get; }

                    /// <summary>The "operations" collection of methods.</summary>
                    public class OperationsResource
                    {
                        private const string Resource = "operations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public OperationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        /// <param name="name">The name of the operation resource.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the operation resource.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/operations/[^/]+$",
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

                        /// <summary>Creates a Product.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent catalog resource name, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a Product.</summary>
                        public class CreateRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent catalog resource name, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the Product, which will become the final component of the
                            /// Product.name. If the caller does not have permission to create the Product, regardless
                            /// of whether or not it exists, a PERMISSION_DENIED error is returned. This field must be
                            /// unique among all Products with the same parent. Otherwise, an ALREADY_EXISTS error is
                            /// returned. This field must be a UTF-8 encoded string with a length limit of 128
                            /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string ProductId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+parent}/products";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+$",
                                });
                                RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "productId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Deletes a Product.</summary>
                        /// <param name="name">
                        /// Required. Full resource name of Product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                        /// If the caller does not have permission to delete the Product, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned. If the Product to delete does not exist, a
                        /// NOT_FOUND error is returned. The Product to delete can neither be a Product.Type.COLLECTION
                        /// Product member nor a Product.Type.PRIMARY Product with more than one variants. Otherwise, an
                        /// INVALID_ARGUMENT error is returned. All inventory information for the named Product will be
                        /// deleted.
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes a Product.</summary>
                        public class DeleteRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                            /// If the caller does not have permission to delete the Product, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned. If the Product to delete does not
                            /// exist, a NOT_FOUND error is returned. The Product to delete can neither be a
                            /// Product.Type.COLLECTION Product member nor a Product.Type.PRIMARY Product with more than
                            /// one variants. Otherwise, an INVALID_ARGUMENT error is returned. All inventory
                            /// information for the named Product will be deleted.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/products/.*$",
                                });
                            }
                        }

                        /// <summary>Gets a Product.</summary>
                        /// <param name="name">
                        /// Required. Full resource name of Product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                        /// If the caller does not have permission to access the Product, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned. If the requested Product does not exist, a
                        /// NOT_FOUND error is returned.
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets a Product.</summary>
                        public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                            /// If the caller does not have permission to access the Product, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned. If the requested Product does not
                            /// exist, a NOT_FOUND error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/products/.*$",
                                });
                            }
                        }

                        /// <summary>
                        /// Bulk import of multiple Products. Request processing may be synchronous. No partial updating
                        /// is supported. Non-existing items are created. Note that it is possible for a subset of the
                        /// Products to be successfully updated.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. `projects/1234/locations/global/catalogs/default_catalog/branches/default_branch`
                        /// If no updateMask is specified, requires products.create permission. If updateMask is
                        /// specified, requires products.update permission.
                        /// </param>
                        public virtual ImportRequest Import(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2ImportProductsRequest body, string parent)
                        {
                            return new ImportRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Bulk import of multiple Products. Request processing may be synchronous. No partial updating
                        /// is supported. Non-existing items are created. Note that it is possible for a subset of the
                        /// Products to be successfully updated.
                        /// </summary>
                        public class ImportRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Import request.</summary>
                            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2ImportProductsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required.
                            /// `projects/1234/locations/global/catalogs/default_catalog/branches/default_branch` If no
                            /// updateMask is specified, requires products.create permission. If updateMask is
                            /// specified, requires products.update permission.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2ImportProductsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "import";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+parent}/products:import";

                            /// <summary>Initializes Import parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Updates a Product.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Immutable. Full resource name of the product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`.
                        /// The branch ID must be "default_branch".
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates a Product.</summary>
                        public class PatchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Immutable. Full resource name of the product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`.
                            /// The branch ID must be "default_branch".
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// If set to true, and the Product is not found, a new Product will be created. In this
                            /// situation, `update_mask` is ignored.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> AllowMissing { get; set; }

                            /// <summary>
                            /// Indicates which fields in the provided Product to update. The immutable and output only
                            /// fields are NOT supported. If not set, all supported fields (the fields that are neither
                            /// immutable nor output only) are updated. If an unsupported or unknown field is provided,
                            /// an INVALID_ARGUMENT error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Product Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/products/.*$",
                                });
                                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "allowMissing",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "updateMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }
                }

                /// <summary>Gets the Operations resource.</summary>
                public virtual OperationsResource Operations { get; }

                /// <summary>The "operations" collection of methods.</summary>
                public class OperationsResource
                {
                    private const string Resource = "operations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OperationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningListOperationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation's parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The standard list filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The standard list page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The standard list page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}/operations";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
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

                /// <summary>Gets the Placements resource.</summary>
                public virtual PlacementsResource Placements { get; }

                /// <summary>The "placements" collection of methods.</summary>
                public class PlacementsResource
                {
                    private const string Resource = "placements";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PlacementsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Makes a recommendation prediction.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="placement">
                    /// Required. Full resource name of the format:
                    /// {name=projects/*/locations/global/catalogs/default_catalog/placements/*} The ID of the
                    /// Recommendations AI placement. Before you can request predictions from your model, you must
                    /// create at least one placement for it. For more information, see [Managing
                    /// placements](https://cloud.google.com/retail/recommendations-ai/docs/manage-placements). The full
                    /// list of available placements can be seen at
                    /// https://console.cloud.google.com/recommendation/catalogs/default_catalog/placements
                    /// </param>
                    public virtual PredictRequest Predict(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2PredictRequest body, string placement)
                    {
                        return new PredictRequest(service, body, placement);
                    }

                    /// <summary>Makes a recommendation prediction.</summary>
                    public class PredictRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2PredictResponse>
                    {
                        /// <summary>Constructs a new Predict request.</summary>
                        public PredictRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2PredictRequest body, string placement) : base(service)
                        {
                            Placement = placement;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of the format:
                        /// {name=projects/*/locations/global/catalogs/default_catalog/placements/*} The ID of the
                        /// Recommendations AI placement. Before you can request predictions from your model, you must
                        /// create at least one placement for it. For more information, see [Managing
                        /// placements](https://cloud.google.com/retail/recommendations-ai/docs/manage-placements). The
                        /// full list of available placements can be seen at
                        /// https://console.cloud.google.com/recommendation/catalogs/default_catalog/placements
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("placement", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Placement { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2PredictRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "predict";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+placement}:predict";

                        /// <summary>Initializes Predict parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("placement", new Google.Apis.Discovery.Parameter
                            {
                                Name = "placement",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/placements/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the UserEvents resource.</summary>
                public virtual UserEventsResource UserEvents { get; }

                /// <summary>The "userEvents" collection of methods.</summary>
                public class UserEventsResource
                {
                    private const string Resource = "userEvents";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UserEventsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Writes a single user event from the browser. This uses a GET request to due to browser
                    /// restriction of POST-ing to a 3rd party domain. This method is used only by the Retail API
                    /// JavaScript pixel and Google Tag Manager. Users should not call this method directly.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent catalog name, such as
                    /// `projects/1234/locations/global/catalogs/default_catalog`.
                    /// </param>
                    public virtual CollectRequest Collect(string parent)
                    {
                        return new CollectRequest(service, parent);
                    }

                    /// <summary>
                    /// Writes a single user event from the browser. This uses a GET request to due to browser
                    /// restriction of POST-ing to a 3rd party domain. This method is used only by the Retail API
                    /// JavaScript pixel and Google Tag Manager. Users should not call this method directly.
                    /// </summary>
                    public class CollectRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleApiHttpBody>
                    {
                        /// <summary>Constructs a new Collect request.</summary>
                        public CollectRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent catalog name, such as
                        /// `projects/1234/locations/global/catalogs/default_catalog`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The event timestamp in milliseconds. This prevents browser caching of otherwise identical
                        /// get requests. The name is abbreviated to reduce the payload bytes.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("ets", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<long> Ets { get; set; }

                        /// <summary>
                        /// The URL including cgi-parameters but excluding the hash fragment with a length limit of
                        /// 5,000 characters. This is often more useful than the referer URL, because many browsers only
                        /// send the domain for 3rd party requests.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("uri", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Uri { get; set; }

                        /// <summary>
                        /// Required. URL encoded UserEvent proto with a length limit of 2,000,000 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userEvent", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UserEvent { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "collect";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/userEvents:collect";

                        /// <summary>Initializes Collect parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                            RequestParameters.Add("ets", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ets",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("uri", new Google.Apis.Discovery.Parameter
                            {
                                Name = "uri",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("userEvent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userEvent",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Bulk import of User events. Request processing might be synchronous. Events that already exist
                    /// are skipped. Use this method for backfilling historical user events. Operation.response is of
                    /// type ImportResponse. Note that it is possible for a subset of the items to be successfully
                    /// inserted. Operation.metadata is of type ImportMetadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. `projects/1234/locations/global/catalogs/default_catalog`</param>
                    public virtual ImportRequest Import(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2ImportUserEventsRequest body, string parent)
                    {
                        return new ImportRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Bulk import of User events. Request processing might be synchronous. Events that already exist
                    /// are skipped. Use this method for backfilling historical user events. Operation.response is of
                    /// type ImportResponse. Note that it is possible for a subset of the items to be successfully
                    /// inserted. Operation.metadata is of type ImportMetadata.
                    /// </summary>
                    public class ImportRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2ImportUserEventsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. `projects/1234/locations/global/catalogs/default_catalog`</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2ImportUserEventsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/userEvents:import";

                        /// <summary>Initializes Import parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes permanently all user events specified by the filter provided. Depending on the number of
                    /// events specified by the filter, this operation could take hours or days to complete. To test a
                    /// filter, use the list command first.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the catalog under which the events are created. The format is
                    /// `projects/${projectId}/locations/global/catalogs/${catalogId}`
                    /// </param>
                    public virtual PurgeRequest Purge(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2PurgeUserEventsRequest body, string parent)
                    {
                        return new PurgeRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Deletes permanently all user events specified by the filter provided. Depending on the number of
                    /// events specified by the filter, this operation could take hours or days to complete. To test a
                    /// filter, use the list command first.
                    /// </summary>
                    public class PurgeRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Purge request.</summary>
                        public PurgeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2PurgeUserEventsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the catalog under which the events are created. The format is
                        /// `projects/${projectId}/locations/global/catalogs/${catalogId}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2PurgeUserEventsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "purge";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/userEvents:purge";

                        /// <summary>Initializes Purge parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Triggers a user event rejoin operation with latest product catalog. Events will not be annotated
                    /// with detailed product information if product is missing from the catalog at the time the user
                    /// event is ingested, and these events are stored as unjoined events with a limited usage on
                    /// training and serving. This API can be used to trigger a 'join' operation on specified events
                    /// with latest version of product catalog. It can also be used to correct events joined with wrong
                    /// product catalog.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent catalog resource name, such as
                    /// `projects/1234/locations/global/catalogs/default_catalog`.
                    /// </param>
                    public virtual RejoinRequest Rejoin(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2RejoinUserEventsRequest body, string parent)
                    {
                        return new RejoinRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Triggers a user event rejoin operation with latest product catalog. Events will not be annotated
                    /// with detailed product information if product is missing from the catalog at the time the user
                    /// event is ingested, and these events are stored as unjoined events with a limited usage on
                    /// training and serving. This API can be used to trigger a 'join' operation on specified events
                    /// with latest version of product catalog. It can also be used to correct events joined with wrong
                    /// product catalog.
                    /// </summary>
                    public class RejoinRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Rejoin request.</summary>
                        public RejoinRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2RejoinUserEventsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent catalog resource name, such as
                        /// `projects/1234/locations/global/catalogs/default_catalog`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2RejoinUserEventsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rejoin";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/userEvents:rejoin";

                        /// <summary>Initializes Rejoin parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Writes a single user event.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent catalog resource name, such as
                    /// `projects/1234/locations/global/catalogs/default_catalog`.
                    /// </param>
                    public virtual WriteRequest Write(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2UserEvent body, string parent)
                    {
                        return new WriteRequest(service, body, parent);
                    }

                    /// <summary>Writes a single user event.</summary>
                    public class WriteRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2UserEvent>
                    {
                        /// <summary>Constructs a new Write request.</summary>
                        public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2UserEvent body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent catalog resource name, such as
                        /// `projects/1234/locations/global/catalogs/default_catalog`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2UserEvent Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "write";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/userEvents:write";

                        /// <summary>Initializes Write parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Lists all the Catalogs associated with the project.</summary>
                /// <param name="parent">
                /// Required. The account resource name with an associated location. If the caller does not have
                /// permission to list Catalogs under this location, regardless of whether or not this location exists,
                /// a PERMISSION_DENIED error is returned.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all the Catalogs associated with the project.</summary>
                public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2ListCatalogsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The account resource name with an associated location. If the caller does not have
                    /// permission to list Catalogs under this location, regardless of whether or not this location
                    /// exists, a PERMISSION_DENIED error is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Maximum number of Catalogs to return. If unspecified, defaults to 50. The maximum allowed value
                    /// is 1000. Values above 1000 will be coerced to 1000. If this field is negative, an
                    /// INVALID_ARGUMENT is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token ListCatalogsResponse.next_page_token, received from a previous
                    /// CatalogService.ListCatalogs call. Provide this to retrieve the subsequent page. When paginating,
                    /// all other parameters provided to CatalogService.ListCatalogs must match the call that provided
                    /// the page token. Otherwise, an INVALID_ARGUMENT error is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/catalogs";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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

                /// <summary>Updates the Catalogs.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Immutable. The fully qualified resource name of the catalog.</param>
                public virtual PatchRequest Patch(Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Catalog body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the Catalogs.</summary>
                public class PatchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Catalog>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Catalog body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Immutable. The fully qualified resource name of the catalog.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Indicates which fields in the provided Catalog to update. If an unsupported or unknown field is
                    /// provided, an INVALID_ARGUMENT error is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRetail.v2.Data.GoogleCloudRetailV2Catalog Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

            /// <summary>The "operations" collection of methods.</summary>
            public class OperationsResource
            {
                private const string Resource = "operations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2.Data.GoogleLongrunningListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation's parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The standard list filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The standard list page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard list page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/operations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
        }
    }
}
namespace Google.Apis.CloudRetail.v2.Data
{
    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class GoogleApiHttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of the context in which an error occurred.</summary>
    public class GoogleCloudRetailLoggingErrorContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP request which was processed when the error was triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual GoogleCloudRetailLoggingHttpRequestContext HttpRequest { get; set; }

        /// <summary>
        /// The location in the source code where the decision was made to report the error, usually the place where it
        /// was logged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportLocation")]
        public virtual GoogleCloudRetailLoggingSourceLocation ReportLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An error log which is reported to the Error Reporting system. This proto a superset of
    /// google.devtools.clouderrorreporting.v1beta1.ReportedErrorEvent.
    /// </summary>
    public class GoogleCloudRetailLoggingErrorLog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A description of the context in which the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudRetailLoggingErrorContext Context { get; set; }

        /// <summary>The error payload that is populated on LRO import APIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importPayload")]
        public virtual GoogleCloudRetailLoggingImportErrorContext ImportPayload { get; set; }

        /// <summary>A message describing the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// The API request payload, represented as a protocol buffer. Most API request types are supported. For
        /// example: "type.googleapis.com/google.cloud.retail.v2.ProductService.CreateProductRequest"
        /// "type.googleapis.com/google.cloud.retail.v2.UserEventService.WriteUserEventRequest"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> RequestPayload { get; set; }

        /// <summary>
        /// The API response payload, represented as a protocol buffer. This is used to log some "soft errors", where
        /// the response is valid but we consider there are some quality issues like unjoined events. The following API
        /// responses are supported and no PII is included: "google.cloud.retail.v2.PredictionService.Predict"
        /// "google.cloud.retail.v2.UserEventService.WriteUserEvent"
        /// "google.cloud.retail.v2.UserEventService.CollectUserEvent"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsePayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> ResponsePayload { get; set; }

        /// <summary>The service context in which this error has occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceContext")]
        public virtual GoogleCloudRetailLoggingServiceContext ServiceContext { get; set; }

        /// <summary>The RPC status associated with the error log.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTP request data that is related to a reported error.</summary>
    public class GoogleCloudRetailLoggingHttpRequestContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP response status code for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseStatusCode")]
        public virtual System.Nullable<int> ResponseStatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The error payload that is populated on LRO import APIs. Including:
    /// "google.cloud.retail.v2.ProductService.ImportProducts" "google.cloud.retail.v2.EventService.ImportUserEvents"
    /// </summary>
    public class GoogleCloudRetailLoggingImportErrorContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed content which caused the error on importing a catalog item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogItem")]
        public virtual string CatalogItem { get; set; }

        /// <summary>Cloud Storage file path of the import source. Can be set for batch operation error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPath")]
        public virtual string GcsPath { get; set; }

        /// <summary>
        /// Line number of the content in file. Should be empty for permission or batch operation error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual string LineNumber { get; set; }

        /// <summary>The operation resource name of the LRO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationName")]
        public virtual string OperationName { get; set; }

        /// <summary>The detailed content which caused the error on importing a product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>The detailed content which caused the error on importing a user event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvent")]
        public virtual string UserEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a running service that sends errors.</summary>
    public class GoogleCloudRetailLoggingServiceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An identifier of the service. For example, "retail.googleapis.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates a location in the source code of the service for which errors are reported.</summary>
    public class GoogleCloudRetailLoggingSourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Human-readable name of a function or method. For example,
        /// "google.cloud.retail.v2.UserEventService.ImportUserEvents".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BigQuery source import data from.</summary>
    public class GoogleCloudRetailV2BigQuerySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for product imports: * `product`
        /// (default): One JSON Product per line. Each product must have a valid Product.id. *
        /// `product_merchant_center`: See [Importing catalog data from Merchant
        /// Center](https://cloud.google.com/retail/recommendations-ai/docs/upload-catalog#mc). Supported values for
        /// user events imports: * `user_event` (default): One JSON UserEvent per line. * `user_event_ga360`: Using
        /// https://support.google.com/analytics/answer/3437719?hl=en.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSchema")]
        public virtual string DataSchema { get; set; }

        /// <summary>
        /// Required. The BigQuery data set to copy the data from with a length limit of 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>
        /// Intermediate Cloud Storage directory used for the import with a length limit of 2,000 characters. Can be
        /// specified if one wants to have the BigQuery export to a specific Cloud Storage directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsStagingDir")]
        public virtual string GcsStagingDir { get; set; }

        /// <summary>
        /// The project ID (can be project # or ID) that the BigQuery source is in with a length limit of 128
        /// characters. If not specified, inherits the project ID from the parent request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Required. The BigQuery table to copy the data from with a length limit of 1,024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The catalog configuration.</summary>
    public class GoogleCloudRetailV2Catalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The catalog display name. This field must be a UTF-8 encoded string with a length limit
        /// of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. Immutable. The fully qualified resource name of the catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The product level configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLevelConfig")]
        public virtual GoogleCloudRetailV2ProductLevelConfig ProductLevelConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom attribute that is not explicitly modeled in Product.</summary>
    public class GoogleCloudRetailV2CustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The numerical values of this custom attribute. For example, `[2.3, 15.4]` when the key is "lengths_cm". At
        /// most 400 values are allowed.Otherwise, an INVALID_ARGUMENT error is returned. Exactly one of text or numbers
        /// should be set. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numbers")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Numbers { get; set; }

        /// <summary>
        /// The textual values of this custom attribute. For example, `["yellow", "green"]` when the key is "color". At
        /// most 400 values are allowed. Empty values are not allowed. Each value must be a UTF-8 encoded string with a
        /// length limit of 256 characters. Otherwise, an INVALID_ARGUMENT error is returned. Exactly one of text or
        /// numbers should be set. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual System.Collections.Generic.IList<string> Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage location for input content. format.</summary>
    public class GoogleCloudRetailV2GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for product imports: * `product`
        /// (default): One JSON Product per line. Each product must have a valid Product.id. *
        /// `product_merchant_center`: See [Importing catalog data from Merchant
        /// Center](https://cloud.google.com/retail/recommendations-ai/docs/upload-catalog#mc). Supported values for
        /// user events imports: * `user_event` (default): One JSON UserEvent per line. * `user_event_ga360`: Using
        /// https://support.google.com/analytics/answer/3437719?hl=en.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSchema")]
        public virtual string DataSchema { get; set; }

        /// <summary>
        /// Required. Google Cloud Storage URIs to input files. URI can be up to 2000 characters long. URIs can match
        /// the full object path (for example, `gs://bucket/directory/object.json`) or a pattern matching one or more
        /// files, such as `gs://bucket/directory/*.json`. A request can contain at most 100 files, and each file can be
        /// up to 2 GB. See [Importing product
        /// information](https://cloud.google.com/retail/recommendations-ai/docs/upload-catalog) for the expected file
        /// format and setup instructions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUris")]
        public virtual System.Collections.Generic.IList<string> InputUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product thumbnail/detail image.</summary>
    public class GoogleCloudRetailV2Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Height of the image in number of pixels. This field must be nonnegative. Otherwise, an INVALID_ARGUMENT
        /// error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>
        /// Required. URI of the image. This field must be a valid UTF-8 encoded URI with a length limit of 5,000
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center property
        /// [image_link](https://support.google.com/merchants/answer/6324350). Schema.org property
        /// [Product.image](https://schema.org/image).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// Width of the image in number of pixels. This field must be nonnegative. Otherwise, an INVALID_ARGUMENT error
        /// is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudRetailV2ImportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage path for import errors. This must be an empty, existing Cloud Storage bucket. Import
        /// errors will be written to a file in this bucket, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Import operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2ImportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Import methods.</summary>
    public class GoogleCloudRetailV2ImportProductsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The desired location of errors incurred during the Import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Required. The desired input location of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudRetailV2ProductInputConfig InputConfig { get; set; }

        /// <summary>
        /// Indicates which fields in the provided imported 'products' to update. If not set, will by default update all
        /// fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportProductsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2ImportProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ImportUserEvents request.</summary>
    public class GoogleCloudRetailV2ImportUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The desired location of errors incurred during the Import. Cannot be set for inline user event imports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Required. The desired input location of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudRetailV2UserEventInputConfig InputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2ImportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Aggregated statistics of user event import status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importSummary")]
        public virtual GoogleCloudRetailV2UserEventImportSummary ImportSummary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for CatalogService.ListCatalogs method.</summary>
    public class GoogleCloudRetailV2ListCatalogsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All the customer's Catalogs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2Catalog> Catalogs { get; set; }

        /// <summary>
        /// A token that can be sent as ListCatalogsRequest.page_token to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Predict method.</summary>
    public class GoogleCloudRetailV2PredictRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Filter for restricting prediction results with a length limit of 5,000 characters. Accepts values for tags
        /// and the `filterOutOfStockItems` flag. * Tag expressions. Restricts predictions to products that match all of
        /// the specified tags. Boolean operators `OR` and `NOT` are supported if the expression is enclosed in
        /// parentheses, and must be separated from the tag values by a space. `-"tagA"` is also supported and is
        /// equivalent to `NOT "tagA"`. Tag values must be double quoted UTF-8 encoded strings with a size limit of
        /// 1,000 characters. Note: "Recently viewed" models don't support tag filtering at the moment. *
        /// filterOutOfStockItems. Restricts predictions to products that do not have a stockState value of
        /// OUT_OF_STOCK. Examples: * tag=("Red" OR "Blue") tag="New-Arrival" tag=(NOT "promotional") *
        /// filterOutOfStockItems tag=(-"promotional") * filterOutOfStockItems If your filter blocks all prediction
        /// results, nothing will be returned. If you want generic (unfiltered) popular products to be returned instead,
        /// set `strictFiltering` to false in `PredictRequest.params`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The labels applied to a resource must meet the following requirements: * Each resource can have multiple
        /// labels, up to a maximum of 64. * Each label must be a key-value pair. * Keys have a minimum length of 1
        /// character and a maximum length of 63 characters, and cannot be empty. Values can be empty, and have a
        /// maximum length of 63 characters. * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. All characters must use UTF-8 encoding, and international characters are allowed. *
        /// The key portion of a label must be unique. However, you can use the same key with multiple resources. * Keys
        /// must start with a lowercase letter or international character. See [Google Cloud
        /// Document](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements) for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Maximum number of results to return per page. Set this property to the number of prediction results needed.
        /// If zero, the service will choose a reasonable default. The maximum allowed value is 100. Values above 100
        /// will be coerced to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>The previous PredictResponse.next_page_token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Additional domain specific parameters for the predictions. Allowed values: * `returnProduct`: Boolean. If
        /// set to true, the associated product object will be returned in the `results.metadata` field in the
        /// prediction response. * `returnScore`: Boolean. If set to true, the prediction 'score' corresponding to each
        /// returned product will be set in the `results.metadata` field in the prediction response. The given 'score'
        /// indicates the probability of an product being clicked/purchased given the user's context and history. *
        /// `strictFiltering`: Boolean. True by default. If set to false, the service will return generic (unfiltered)
        /// popular products instead of empty if your filter blocks all prediction results. * `priceRerankLevel`:
        /// String. Default empty. If set to be non-empty, then it needs to be one of {'no-price-reranking',
        /// 'low-price-reranking', 'medium-price-reranking', 'high-price-reranking'}. This gives request-level control
        /// and adjusts prediction results based on product price. * `diversityLevel`: String. Default empty. If set to
        /// be non-empty, then it needs to be one of {'no-diversity', 'low-diversity', 'medium-diversity',
        /// 'high-diversity', 'auto-diversity'}. This gives request-level control and adjusts prediction results based
        /// on product category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>
        /// Required. Context about the user, what they are looking at and what action they took to trigger the predict
        /// request. Note that this user event detail won't be ingested to userEvent logs. Thus, a separate userEvent
        /// write request is required for event logging.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvent")]
        public virtual GoogleCloudRetailV2UserEvent UserEvent { get; set; }

        /// <summary>
        /// Use validate only mode for this prediction query. If set to true, a dummy model will be used that returns
        /// arbitrary products. Note that the validate only mode should only be used for testing the API, or if the
        /// model is not ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for predict method.</summary>
    public class GoogleCloudRetailV2PredictResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique attribution token. This should be included in the UserEvent logs resulting from this
        /// recommendation, which enables accurate attribution of recommendation model performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>IDs of products in the request that were missing from the inventory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingIds")]
        public virtual System.Collections.Generic.IList<string> MissingIds { get; set; }

        /// <summary>
        /// A list of recommended products. The order represents the ranking (from the most relevant product to the
        /// least).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2PredictResponsePredictionResult> Results { get; set; }

        /// <summary>True if the validateOnly property was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PredictionResult represents the recommendation prediction results.</summary>
    public class GoogleCloudRetailV2PredictResponsePredictionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the recommended product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Additional product metadata / annotations. Possible values: * `product`: JSON representation of the product.
        /// Will be set if `returnProduct` is set to true in `PredictRequest.params`. * `score`: Prediction score in
        /// double value. Will be set if `returnScore` is set to true in `PredictRequest.params`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price information of a Product.</summary>
    public class GoogleCloudRetailV2PriceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The costs associated with the sale of a particular product. Used for gross profit reporting. * Profit =
        /// price - cost Google Merchant Center property
        /// [cost_of_goods_sold](https://support.google.com/merchants/answer/9017895).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cost")]
        public virtual System.Nullable<float> Cost { get; set; }

        /// <summary>
        /// The 3-letter currency code defined in [ISO 4217](https://www.iso.org/iso-4217-currency-codes.html). If this
        /// field is an unrecognizable currency code, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Price of the product without any discount. If zero, by default set to be the price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPrice")]
        public virtual System.Nullable<float> OriginalPrice { get; set; }

        /// <summary>
        /// Price of the product. Google Merchant Center property
        /// [price](https://support.google.com/merchants/answer/6324371). Schema.org property
        /// [Offer.priceSpecification](https://schema.org/priceSpecification).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual System.Nullable<float> Price { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product captures all metadata information of items to be recommended or searched.</summary>
    public class GoogleCloudRetailV2Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Highly encouraged. Extra product attributes to be included. For example, for products, this could include
        /// the store name, vendor, style, color, etc. These are very strong signals for recommendation model, thus we
        /// highly recommend providing the attributes here. Features that can take on one of a limited number of
        /// possible values. Two types of features can be set are: Textual features. some examples would be the
        /// brand/maker of a product, or country of a customer. Numerical features. Some examples would be the
        /// height/weight of a product, or age of a customer. For example: `{ "vendor": {"text": ["vendor123",
        /// "vendor456"]}, "lengths_cm": {"numbers":[2.3, 15.4]}, "heights_cm": {"numbers":[8.1, 6.4]} }`. This field
        /// needs to pass all below criteria, otherwise an INVALID_ARGUMENT error is returned: * Max entries count: 200
        /// by default; 100 for Type.VARIANT. * The key must be a UTF-8 encoded string with a length limit of 128
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRetailV2CustomAttribute> Attributes { get; set; }

        /// <summary>
        /// The online availability of the Product. Default to Availability.IN_STOCK. Google Merchant Center Property
        /// [availability](https://support.google.com/merchants/answer/6324448). Schema.org Property
        /// [Offer.availability](https://schema.org/availability).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>The available quantity of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableQuantity")]
        public virtual System.Nullable<int> AvailableQuantity { get; set; }

        /// <summary>The timestamp when this Product becomes available for recommendation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableTime")]
        public virtual object AvailableTime { get; set; }

        /// <summary>
        /// Product categories. This field is repeated for supporting one product belonging to several parallel
        /// categories. Strongly recommended using the full path for better search / recommendation quality. To
        /// represent full path of category, use '&amp;gt;' sign to separate different hierarchies. If '&amp;gt;' is
        /// part of the category name, please replace it with other character(s). For example, if a shoes product
        /// belongs to both ["Shoes &amp;amp; Accessories" -&amp;gt; "Shoes"] and ["Sports &amp;amp; Fitness" -&amp;gt;
        /// "Athletic Clothing" -&amp;gt; "Shoes"], it could be represented as: "categories": [ "Shoes &amp;amp;
        /// Accessories &amp;gt; Shoes", "Sports &amp;amp; Fitness &amp;gt; Athletic Clothing &amp;gt; Shoes" ] Must be
        /// set for Type.PRIMARY Product otherwise an INVALID_ARGUMENT error is returned. At most 250 values are allowed
        /// per Product. Empty values are not allowed. Each value must be a UTF-8 encoded string with a length limit of
        /// 5,000 characters. Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center property
        /// google_product_category. Schema.org property [Product.category] (https://schema.org/category).
        /// [mc_google_product_category]: https://support.google.com/merchants/answer/6324436
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// Product description. This field must be a UTF-8 encoded string with a length limit of 5,000 characters.
        /// Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center property
        /// [description](https://support.google.com/merchants/answer/6324468). schema.org property
        /// [Product.description](https://schema.org/description).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Immutable. Product identifier, which is the final component of name. For example, this field is "id_1", if
        /// name is `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/id_1`. This
        /// field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT
        /// error is returned. Google Merchant Center property
        /// [id](https://support.google.com/merchants/answer/6324405). Schema.org Property
        /// [Product.sku](https://schema.org/sku).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Product images for the product.Highly recommended to put the main image to the first. A maximum of 300
        /// images are allowed. Google Merchant Center property
        /// [image_link](https://support.google.com/merchants/answer/6324350). Schema.org property
        /// [Product.image](https://schema.org/image).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2Image> Images { get; set; }

        /// <summary>
        /// Immutable. Full resource name of the product, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`. The
        /// branch ID must be "default_branch".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Product price and cost information. Google Merchant Center property
        /// [price](https://support.google.com/merchants/answer/6324371).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceInfo")]
        public virtual GoogleCloudRetailV2PriceInfo PriceInfo { get; set; }

        /// <summary>
        /// Variant group identifier. Must be an id, with the same parent branch with this product. Otherwise, an error
        /// is thrown. For Type.PRIMARY Products, this field can only be empty or set to the same value as id. For
        /// VARIANT Products, this field cannot be empty. A maximum of 2,000 products are allowed to share the same
        /// Type.PRIMARY Product. Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center Property
        /// [item_group_id](https://support.google.com/merchants/answer/6324507). Schema.org Property
        /// [Product.inProductGroupWithID](https://schema.org/inProductGroupWithID). This field must be enabled before
        /// it can be used. [Learn more](/recommendations-ai/docs/catalog#item-group-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryProductId")]
        public virtual string PrimaryProductId { get; set; }

        /// <summary>
        /// Custom tags associated with the product. At most 250 values are allowed per Product. This value must be a
        /// UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error is
        /// returned. This tag can be used for filtering recommendation results by passing the tag as part of the
        /// PredictRequest.filter. Google Merchant Center property
        /// [custom_label_0–4](https://support.google.com/merchants/answer/6324473).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Required. Product title. This field must be a UTF-8 encoded string with a length limit of 1,000 characters.
        /// Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center property
        /// [title](https://support.google.com/merchants/answer/6324415). Schema.org property
        /// [Product.name](https://schema.org/name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Immutable. The type of the product. Default to Catalog.product_level_config.ingestion_product_type if unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Canonical URL directly linking to the product detail page. It is strongly recommended to provide a valid uri
        /// for the product, otherwise the service performance could be significantly degraded. This field must be a
        /// UTF-8 encoded string with a length limit of 5,000 characters. Otherwise, an INVALID_ARGUMENT error is
        /// returned. Google Merchant Center property [link](https://support.google.com/merchants/answer/6324416).
        /// Schema.org property [Offer.url](https://schema.org/url).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed product information associated with a user event.</summary>
    public class GoogleCloudRetailV2ProductDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Product information. Only Product.id field is used when ingesting an event, all other product
        /// fields are ignored as we will look them up from the catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudRetailV2Product Product { get; set; }

        /// <summary>
        /// Quantity of the product associated with the user event. For example, this field will be 2 if two products
        /// are added to the shopping cart for `purchase-complete` event. Required for `add-to-cart` and
        /// `purchase-complete` event types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inline source for the input config for ImportProducts method.</summary>
    public class GoogleCloudRetailV2ProductInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of products to update/create. Each product must have a valid Product.id. Recommended max of
        /// 100 items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2Product> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input config source for products.</summary>
    public class GoogleCloudRetailV2ProductInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQuerySource")]
        public virtual GoogleCloudRetailV2BigQuerySource BigQuerySource { get; set; }

        /// <summary>Google Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudRetailV2GcsSource GcsSource { get; set; }

        /// <summary>The Inline source for the input content for products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productInlineSource")]
        public virtual GoogleCloudRetailV2ProductInlineSource ProductInlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures what level the product should be uploaded with regards to how users will be send events and how
    /// predictions will be made.
    /// </summary>
    public class GoogleCloudRetailV2ProductLevelConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of Products allowed to be ingested into the catalog. Acceptable values are: * `primary` (default):
        /// You can only ingest Product.Type.PRIMARY Products. This means Product.primary_product_id can only be empty
        /// or set to the same value as Product.id. * `variant`: You can only ingest Product.Type.VARIANT Products. This
        /// means Product.primary_product_id cannot be empty. If this field is set to an invalid value other than these,
        /// an INVALID_ARGUMENT error is returned. If this field is `variant` and merchant_center_product_id_field is
        /// `itemGroupId`, an INVALID_ARGUMENT error is returned. See [Using product
        /// levels](https://cloud.google.com/retail/recommendations-ai/docs/catalog#product-levels) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionProductType")]
        public virtual string IngestionProductType { get; set; }

        /// <summary>
        /// Which field of [Merchant Center Product](/bigquery-transfer/docs/merchant-center-products-schema) should be
        /// imported as Product.id. Acceptable values are: * `offerId` (default): Import `offerId` as the product ID. *
        /// `itemGroupId`: Import `itemGroupId` as the product ID. Notice that Retail API will choose one item from the
        /// ones with the same `itemGroupId`, and use it to represent the item group. If this field is set to an invalid
        /// value other than these, an INVALID_ARGUMENT error is returned. If this field is `itemGroupId` and
        /// ingestion_product_type is `variant`, an INVALID_ARGUMENT error is returned. See [Using product
        /// levels](https://cloud.google.com/retail/recommendations-ai/docs/catalog#product-levels) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantCenterProductIdField")]
        public virtual string MerchantCenterProductIdField { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transaction represents the entire purchase transaction.</summary>
    public class GoogleCloudRetailV2PurchaseTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All the costs associated with the products. These can be manufacturing costs, shipping expenses not borne by
        /// the end user, or any other costs, such that: * Profit = revenue - tax - cost
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cost")]
        public virtual System.Nullable<float> Cost { get; set; }

        /// <summary>Required. Currency code. Use three-character ISO-4217 code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The transaction ID with a length limit of 128 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. Total non-zero revenue or grand total associated with the transaction. This value include
        /// shipping, tax, or other adjustments to total revenue that you want to include as part of your revenue
        /// calculations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revenue")]
        public virtual System.Nullable<float> Revenue { get; set; }

        /// <summary>All the taxes associated with the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tax")]
        public virtual System.Nullable<float> Tax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Purge operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2PurgeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PurgeUserEvents method.</summary>
    public class GoogleCloudRetailV2PurgeUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The filter string to specify the events to be deleted with a length limit of 5,000 characters.
        /// Empty string filter is not allowed. The eligible fields for filtering are: * `eventType`: Double quoted
        /// UserEvent.event_type string. * `eventTime`: in ISO 8601 "zulu" format. * `visitorId`: Double quoted string.
        /// Specifying this will delete all events associated with a visitor. * `userId`: Double quoted string.
        /// Specifying this will delete all events associated with a user. Examples: * Deleting all events in a time
        /// range: `eventTime &amp;gt; "2012-04-23T18:25:43.511Z" eventTime &amp;lt; "2012-04-23T18:30:43.511Z"` *
        /// Deleting specific eventType in time range: `eventTime &amp;gt; "2012-04-23T18:25:43.511Z" eventType =
        /// "detail-page-view"` * Deleting all events for a specific visitor: `visitorId = "visitor1024"` The filtering
        /// fields are assumed to have an implicit AND.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Actually perform the purge. If `force` is set to false, the method will return the expected purge count
        /// without deleting any user events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the PurgeUserEventsRequest. If the long running operation is successfully done, then this message is
    /// returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudRetailV2PurgeUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of events purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgedEventsCount")]
        public virtual System.Nullable<long> PurgedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2RejoinUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2RejoinUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of the user event rejoin to define the scope and range of the user events to be rejoined with the
        /// latest product catalog. Defaults to USER_EVENT_REJOIN_SCOPE_UNSPECIFIED if this field is not set, or set to
        /// an invalid integer value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEventRejoinScope")]
        public virtual string UserEventRejoinScope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2RejoinUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest product catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UserEvent captures all metadata information Retail API needs to know about how end users interact with
    /// customers' website.
    /// </summary>
    public class GoogleCloudRetailV2UserEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Extra user event features to include in the recommendation model. The key must be a UTF-8 encoded string
        /// with a length limit of 5,000 characters. Otherwise, an INVALID_ARGUMENT error is returned. For product
        /// recommendation, an example of extra user information is traffic_channel, i.e. how user arrives at the site.
        /// Users can arrive at the site by coming to the site directly, or coming through Google search, and etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRetailV2CustomAttribute> Attributes { get; set; }

        /// <summary>
        /// Highly recommended for user events that are the result of PredictionService.Predict. This field enables
        /// accurate attribution of recommendation model performance. The value must be a valid
        /// PredictResponse.attribution_token for user events that are the result of PredictionService.Predict. This
        /// token enables us to accurately attribute page view or purchase back to the event and the particular predict
        /// response containing this clicked/purchased product. If user clicks on product K in the recommendation
        /// results, pass PredictResponse.attribution_token as a URL parameter to product K's page. When recording
        /// events on product K's page, log the PredictResponse.attribution_token to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>
        /// The id or name of the associated shopping cart. This id is used to associate multiple items added or present
        /// in the cart before purchase. This can only be set for `add-to-cart`, `purchase-complete`, or
        /// `shopping-cart-page-view` events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cartId")]
        public virtual string CartId { get; set; }

        /// <summary>
        /// Only required for UserEventService.ImportUserEvents method. Timestamp of when the user event happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// Required. User event type. Allowed values are: * `add-to-cart`: Products being added to cart. *
        /// `category-page-view`: Special pages such as sale or promotion pages viewed. * `completion`: Completion query
        /// result showed/clicked. * `detail-page-view`: Products detail page viewed. * `home-page-view`: Homepage
        /// viewed. * `promotion-offered`: Promotion is offered to a user. * `promotion-not-offered`: Promotion is not
        /// offered to a user. * `purchase-complete`: User finishing a purchase. * `search`: Product search. *
        /// `shopping-cart-page-view`: User viewing a shopping cart.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// A list of identifiers for the independent experiment groups this user event belongs to. This is used to
        /// distinguish between user events associated with different experiment setups (e.g. using Retail API, using
        /// different recommendation models).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experimentIds")]
        public virtual System.Collections.Generic.IList<string> ExperimentIds { get; set; }

        /// <summary>
        /// The categories associated with a category page. To represent full path of category, use '&amp;gt;' sign to
        /// separate different hierarchies. If '&amp;gt;' is part of the category name, please replace it with other
        /// character(s). Category pages include special pages such as sales or promotions. For instance, a special sale
        /// page may have the category hierarchy: "pageCategories" : ["Sales &amp;gt; 2017 Black Friday Deals"].
        /// Required for `category-page-view` events. At least one of search_query or page_categories is required for
        /// `search` events. Other event types should not set this field. Otherwise, an INVALID_ARGUMENT error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageCategories")]
        public virtual System.Collections.Generic.IList<string> PageCategories { get; set; }

        /// <summary>
        /// A unique id of a web page view. This should be kept the same for all user events triggered from the same
        /// pageview. For example, an item detail page view could trigger multiple events as the user is browsing the
        /// page. The `pageViewId` property should be kept the same for all these events so that they can be grouped
        /// together properly. When using the client side event reporting with JavaScript pixel and Google Tag Manager,
        /// this value is filled in automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageViewId")]
        public virtual string PageViewId { get; set; }

        /// <summary>
        /// The main product details related to the event. This field is required for the following event types: *
        /// `add-to-cart` * `detail-page-view` * `purchase-complete` In a `search` event, this field represents the
        /// products returned to the end user on the current page (the end user may have not finished broswing the whole
        /// page yet). When a new page is returned to the end user, after pagination/filtering/ordering even for the
        /// same query, a new `search` event with different product_details is desired. The end user may have not
        /// finished broswing the whole page yet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2ProductDetail> ProductDetails { get; set; }

        /// <summary>
        /// A transaction represents the entire purchase transaction. Required for `purchase-complete` events. Other
        /// event types should not set this field. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTransaction")]
        public virtual GoogleCloudRetailV2PurchaseTransaction PurchaseTransaction { get; set; }

        /// <summary>
        /// The referrer URL of the current page. When using the client side event reporting with JavaScript pixel and
        /// Google Tag Manager, this value is filled in automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrerUri")]
        public virtual string ReferrerUri { get; set; }

        /// <summary>
        /// The user's search query. The value must be a UTF-8 encoded string with a length limit of 5,000 characters.
        /// Otherwise, an INVALID_ARGUMENT error is returned. At least one of search_query or page_categories is
        /// required for `search` events. Other event types should not set this field. Otherwise, an INVALID_ARGUMENT
        /// error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchQuery")]
        public virtual string SearchQuery { get; set; }

        /// <summary>
        /// Complete URL (window.location.href) of the user's current page. When using the client side event reporting
        /// with JavaScript pixel and Google Tag Manager, this value is filled in automatically. Maximum length 5,000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>User information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudRetailV2UserInfo UserInfo { get; set; }

        /// <summary>
        /// Required. A unique identifier for tracking visitors. For example, this could be implemented with an HTTP
        /// cookie, which should be able to uniquely identify a visitor on a single device. This unique identifier
        /// should not change if the visitor log in/out of the website. The field must be a UTF-8 encoded string with a
        /// length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned. The field should not
        /// contain PII or user-data. We recommend to use Google Analystics [Client
        /// ID](https://developers.google.com/analytics/devguides/collection/analyticsjs/field-reference#clientId) for
        /// this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A summary of import result. The UserEventImportSummary summarizes the import status for user events.
    /// </summary>
    public class GoogleCloudRetailV2UserEventImportSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of user events imported with complete existing catalog information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinedEventsCount")]
        public virtual System.Nullable<long> JoinedEventsCount { get; set; }

        /// <summary>
        /// Count of user events imported, but with catalog information not found in the imported catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unjoinedEventsCount")]
        public virtual System.Nullable<long> UnjoinedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inline source for the input config for ImportUserEvents method.</summary>
    public class GoogleCloudRetailV2UserEventInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of user events to import. Recommended max of 10k items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2UserEvent> UserEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input config source for user events.</summary>
    public class GoogleCloudRetailV2UserEventInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQuerySource")]
        public virtual GoogleCloudRetailV2BigQuerySource BigQuerySource { get; set; }

        /// <summary>Required. Google Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudRetailV2GcsSource GcsSource { get; set; }

        /// <summary>Required. The Inline source for the input content for UserEvents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEventInlineSource")]
        public virtual GoogleCloudRetailV2UserEventInlineSource UserEventInlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information of an end user.</summary>
    public class GoogleCloudRetailV2UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the request is made directly from the end user, in which case the ip_address and user_agent can be
        /// populated from the HTTP request. This flag should be set only if the API request is made directly from the
        /// end user such as a mobile app (and not if a gateway or a server is processing and pushing the user events).
        /// This should not be set when using the JavaScript tag in UserEventService.CollectUserEvent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directUserRequest")]
        public virtual System.Nullable<bool> DirectUserRequest { get; set; }

        /// <summary>
        /// The end user's IP address. Required for getting SearchRespons.sponsored_results. This field is used to
        /// extract location information for personalization. This field must be either an IPv4 address (e.g.
        /// "104.133.9.80") or an IPv6 address (e.g. "2001:0db8:85a3:0000:0000:8a2e:0370:7334"). Otherwise, an
        /// INVALID_ARGUMENT error is returned. This should not be set when using the JavaScript tag in
        /// UserEventService.CollectUserEvent or if direct_user_request is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// User agent as included in the HTTP header. Required for getting SearchRespons.sponsored_results. The field
        /// must be a UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error
        /// is returned. This should not be set when using the client side event reporting with GTM or JavaScript tag in
        /// UserEventService.CollectUserEvent or if direct_user_request is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Highly recommended for logged-in users. Unique identifier for logged-in user, such as a user name. The field
        /// must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error
        /// is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Export related errors.</summary>
    public class GoogleCloudRetailV2alphaExportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage path for import errors. This must be an empty, existing Cloud Storage bucket. Export
        /// errors will be written to a file in this bucket, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Export operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2alphaExportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ExportProductsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2alphaExportProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ExportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2alphaExportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudRetailV2alphaImportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage path for import errors. This must be an empty, existing Cloud Storage bucket. Import
        /// errors will be written to a file in this bucket, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Import operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2alphaImportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportProductsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2alphaImportProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2alphaImportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Aggregated statistics of user event import status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importSummary")]
        public virtual GoogleCloudRetailV2alphaUserEventImportSummary ImportSummary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Purge operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2alphaPurgeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the PurgeUserEventsRequest. If the long running operation is successfully done, then this message is
    /// returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudRetailV2alphaPurgeUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of events purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgedEventsCount")]
        public virtual System.Nullable<long> PurgedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2alphaRejoinUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2alphaRejoinUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest product catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A summary of import result. The UserEventImportSummary summarizes the import status for user events.
    /// </summary>
    public class GoogleCloudRetailV2alphaUserEventImportSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of user events imported with complete existing catalog information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinedEventsCount")]
        public virtual System.Nullable<long> JoinedEventsCount { get; set; }

        /// <summary>
        /// Count of user events imported, but with catalog information not found in the imported catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unjoinedEventsCount")]
        public virtual System.Nullable<long> UnjoinedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Export related errors.</summary>
    public class GoogleCloudRetailV2betaExportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage path for import errors. This must be an empty, existing Cloud Storage bucket. Export
        /// errors will be written to a file in this bucket, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Export operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2betaExportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ExportProductsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2betaExportProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2betaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ExportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2betaExportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2betaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudRetailV2betaImportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage path for import errors. This must be an empty, existing Cloud Storage bucket. Import
        /// errors will be written to a file in this bucket, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Import operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2betaImportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportProductsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2betaImportProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2betaImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRetailV2betaImportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2betaImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Aggregated statistics of user event import status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importSummary")]
        public virtual GoogleCloudRetailV2betaUserEventImportSummary ImportSummary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Purge operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2betaPurgeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the PurgeUserEventsRequest. If the long running operation is successfully done, then this message is
    /// returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudRetailV2betaPurgeUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of events purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgedEventsCount")]
        public virtual System.Nullable<long> PurgedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2betaRejoinUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2betaRejoinUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest product catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A summary of import result. The UserEventImportSummary summarizes the import status for user events.
    /// </summary>
    public class GoogleCloudRetailV2betaUserEventImportSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of user events imported with complete existing catalog information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinedEventsCount")]
        public virtual System.Nullable<long> JoinedEventsCount { get; set; }

        /// <summary>
        /// Count of user events imported, but with catalog information not found in the imported catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unjoinedEventsCount")]
        public virtual System.Nullable<long> UnjoinedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
