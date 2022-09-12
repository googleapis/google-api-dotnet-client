// Copyright 2022 Google LLC
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

namespace Google.Apis.CloudRetail.v2alpha
{
    /// <summary>The CloudRetail Service.</summary>
    public class CloudRetailService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2alpha";

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
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Retail API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
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
            Operations = new OperationsResource(service);
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
                    AttributesConfig = new AttributesConfigResource(service);
                    Branches = new BranchesResource(service);
                    CompletionData = new CompletionDataResource(service);
                    Controls = new ControlsResource(service);
                    Models = new ModelsResource(service);
                    Operations = new OperationsResource(service);
                    Placements = new PlacementsResource(service);
                    ServingConfigs = new ServingConfigsResource(service);
                    UserEvents = new UserEventsResource(service);
                }

                /// <summary>Gets the AttributesConfig resource.</summary>
                public virtual AttributesConfigResource AttributesConfig { get; }

                /// <summary>The "attributesConfig" collection of methods.</summary>
                public class AttributesConfigResource
                {
                    private const string Resource = "attributesConfig";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AttributesConfigResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Adds the specified CatalogAttribute to the AttributesConfig. If the CatalogAttribute to add
                    /// already exists, an ALREADY_EXISTS error is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="attributesConfig">
                    /// Required. Full AttributesConfig resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                    /// </param>
                    public virtual AddCatalogAttributeRequest AddCatalogAttribute(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddCatalogAttributeRequest body, string attributesConfig)
                    {
                        return new AddCatalogAttributeRequest(service, body, attributesConfig);
                    }

                    /// <summary>
                    /// Adds the specified CatalogAttribute to the AttributesConfig. If the CatalogAttribute to add
                    /// already exists, an ALREADY_EXISTS error is returned.
                    /// </summary>
                    public class AddCatalogAttributeRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig>
                    {
                        /// <summary>Constructs a new AddCatalogAttribute request.</summary>
                        public AddCatalogAttributeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddCatalogAttributeRequest body, string attributesConfig) : base(service)
                        {
                            AttributesConfig = attributesConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full AttributesConfig resource name. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("attributesConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AttributesConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddCatalogAttributeRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "addCatalogAttribute";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+attributesConfig}:addCatalogAttribute";

                        /// <summary>Initializes AddCatalogAttribute parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("attributesConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "attributesConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/attributesConfig$",
                            });
                        }
                    }

                    /// <summary>Removes all specified CatalogAttributes from the AttributesConfig.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="attributesConfig">
                    /// Required. The attributes config resource shared by all catalog attributes being deleted. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                    /// </param>
                    public virtual BatchRemoveCatalogAttributesRequest BatchRemoveCatalogAttributes(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaBatchRemoveCatalogAttributesRequest body, string attributesConfig)
                    {
                        return new BatchRemoveCatalogAttributesRequest(service, body, attributesConfig);
                    }

                    /// <summary>Removes all specified CatalogAttributes from the AttributesConfig.</summary>
                    public class BatchRemoveCatalogAttributesRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaBatchRemoveCatalogAttributesResponse>
                    {
                        /// <summary>Constructs a new BatchRemoveCatalogAttributes request.</summary>
                        public BatchRemoveCatalogAttributesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaBatchRemoveCatalogAttributesRequest body, string attributesConfig) : base(service)
                        {
                            AttributesConfig = attributesConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The attributes config resource shared by all catalog attributes being deleted.
                        /// Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("attributesConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AttributesConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaBatchRemoveCatalogAttributesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchRemoveCatalogAttributes";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+attributesConfig}:batchRemoveCatalogAttributes";

                        /// <summary>Initializes BatchRemoveCatalogAttributes parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("attributesConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "attributesConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/attributesConfig$",
                            });
                        }
                    }

                    /// <summary>
                    /// Removes the specified CatalogAttribute from the AttributesConfig. If the CatalogAttribute to
                    /// remove does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="attributesConfig">
                    /// Required. Full AttributesConfig resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                    /// </param>
                    public virtual RemoveCatalogAttributeRequest RemoveCatalogAttribute(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveCatalogAttributeRequest body, string attributesConfig)
                    {
                        return new RemoveCatalogAttributeRequest(service, body, attributesConfig);
                    }

                    /// <summary>
                    /// Removes the specified CatalogAttribute from the AttributesConfig. If the CatalogAttribute to
                    /// remove does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    public class RemoveCatalogAttributeRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig>
                    {
                        /// <summary>Constructs a new RemoveCatalogAttribute request.</summary>
                        public RemoveCatalogAttributeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveCatalogAttributeRequest body, string attributesConfig) : base(service)
                        {
                            AttributesConfig = attributesConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full AttributesConfig resource name. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("attributesConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AttributesConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveCatalogAttributeRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "removeCatalogAttribute";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+attributesConfig}:removeCatalogAttribute";

                        /// <summary>Initializes RemoveCatalogAttribute parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("attributesConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "attributesConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/attributesConfig$",
                            });
                        }
                    }

                    /// <summary>
                    /// Replaces the specified CatalogAttribute in the AttributesConfig by updating the catalog
                    /// attribute with the same CatalogAttribute.key. If the CatalogAttribute to replace does not exist,
                    /// a NOT_FOUND error is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="attributesConfig">
                    /// Required. Full AttributesConfig resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                    /// </param>
                    public virtual ReplaceCatalogAttributeRequest ReplaceCatalogAttribute(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaReplaceCatalogAttributeRequest body, string attributesConfig)
                    {
                        return new ReplaceCatalogAttributeRequest(service, body, attributesConfig);
                    }

                    /// <summary>
                    /// Replaces the specified CatalogAttribute in the AttributesConfig by updating the catalog
                    /// attribute with the same CatalogAttribute.key. If the CatalogAttribute to replace does not exist,
                    /// a NOT_FOUND error is returned.
                    /// </summary>
                    public class ReplaceCatalogAttributeRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig>
                    {
                        /// <summary>Constructs a new ReplaceCatalogAttribute request.</summary>
                        public ReplaceCatalogAttributeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaReplaceCatalogAttributeRequest body, string attributesConfig) : base(service)
                        {
                            AttributesConfig = attributesConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full AttributesConfig resource name. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("attributesConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AttributesConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaReplaceCatalogAttributeRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "replaceCatalogAttribute";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+attributesConfig}:replaceCatalogAttribute";

                        /// <summary>Initializes ReplaceCatalogAttribute parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("attributesConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "attributesConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/attributesConfig$",
                            });
                        }
                    }
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
                        Places = new PlacesResource(service);
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
                        public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
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
                            public override string RestPath => "v2alpha/{+name}";

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

                    /// <summary>Gets the Places resource.</summary>
                    public virtual PlacesResource Places { get; }

                    /// <summary>The "places" collection of methods.</summary>
                    public class PlacesResource
                    {
                        private const string Resource = "places";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public PlacesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Operations = new OperationsResource(service);
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
                            /// Gets the latest state of a long-running operation. Clients can use this method to poll
                            /// the operation result at intervals as recommended by the API service.
                            /// </summary>
                            /// <param name="name">The name of the operation resource.</param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(service, name);
                            }

                            /// <summary>
                            /// Gets the latest state of a long-running operation. Clients can use this method to poll
                            /// the operation result at intervals as recommended by the API service.
                            /// </summary>
                            public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
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
                                public override string RestPath => "v2alpha/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/places/[^/]+/operations/[^/]+$",
                                    });
                                }
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
                        /// Incrementally adds place IDs to Product.fulfillment_info.place_ids. This process is
                        /// asynchronous and does not require the Product to exist before updating fulfillment
                        /// information. If the request is valid, the update will be enqueued and processed downstream.
                        /// As a consequence, when a response is returned, the added place IDs are not immediately
                        /// manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. The returned Operations will be obsolete after 1 day, and
                        /// GetOperation API will return NOT_FOUND afterwards. If conflicting updates are issued, the
                        /// Operations associated with the stale updates will not be marked as done until being
                        /// obsolete. This feature is only available for users who have Retail Search enabled. Enable
                        /// Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="product">
                        /// Required. Full resource name of Product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                        /// If the caller does not have permission to access the Product, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned.
                        /// </param>
                        public virtual AddFulfillmentPlacesRequest AddFulfillmentPlaces(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddFulfillmentPlacesRequest body, string product)
                        {
                            return new AddFulfillmentPlacesRequest(service, body, product);
                        }

                        /// <summary>
                        /// Incrementally adds place IDs to Product.fulfillment_info.place_ids. This process is
                        /// asynchronous and does not require the Product to exist before updating fulfillment
                        /// information. If the request is valid, the update will be enqueued and processed downstream.
                        /// As a consequence, when a response is returned, the added place IDs are not immediately
                        /// manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. The returned Operations will be obsolete after 1 day, and
                        /// GetOperation API will return NOT_FOUND afterwards. If conflicting updates are issued, the
                        /// Operations associated with the stale updates will not be marked as done until being
                        /// obsolete. This feature is only available for users who have Retail Search enabled. Enable
                        /// Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        public class AddFulfillmentPlacesRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new AddFulfillmentPlaces request.</summary>
                            public AddFulfillmentPlacesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddFulfillmentPlacesRequest body, string product) : base(service)
                            {
                                Product = product;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                            /// If the caller does not have permission to access the Product, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Product { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddFulfillmentPlacesRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "addFulfillmentPlaces";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+product}:addFulfillmentPlaces";

                            /// <summary>Initializes AddFulfillmentPlaces parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "product",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/products/.*$",
                                });
                            }
                        }

                        /// <summary>
                        /// Updates local inventory information for a Product at a list of places, while respecting the
                        /// last update timestamps of each inventory field. This process is asynchronous and does not
                        /// require the Product to exist before updating inventory information. If the request is valid,
                        /// the update will be enqueued and processed downstream. As a consequence, when a response is
                        /// returned, updates are not immediately manifested in the Product queried by
                        /// ProductService.GetProduct or ProductService.ListProducts. Local inventory information can
                        /// only be modified using this method. ProductService.CreateProduct and
                        /// ProductService.UpdateProduct has no effect on local inventories. The returned Operations
                        /// will be obsolete after 1 day, and GetOperation API will return NOT_FOUND afterwards. If
                        /// conflicting updates are issued, the Operations associated with the stale updates will not be
                        /// marked as done until being obsolete. This feature is only available for users who have
                        /// Retail Search enabled. Enable Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="product">
                        /// Required. Full resource name of Product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                        /// If the caller does not have permission to access the Product, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned.
                        /// </param>
                        public virtual AddLocalInventoriesRequest AddLocalInventories(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddLocalInventoriesRequest body, string product)
                        {
                            return new AddLocalInventoriesRequest(service, body, product);
                        }

                        /// <summary>
                        /// Updates local inventory information for a Product at a list of places, while respecting the
                        /// last update timestamps of each inventory field. This process is asynchronous and does not
                        /// require the Product to exist before updating inventory information. If the request is valid,
                        /// the update will be enqueued and processed downstream. As a consequence, when a response is
                        /// returned, updates are not immediately manifested in the Product queried by
                        /// ProductService.GetProduct or ProductService.ListProducts. Local inventory information can
                        /// only be modified using this method. ProductService.CreateProduct and
                        /// ProductService.UpdateProduct has no effect on local inventories. The returned Operations
                        /// will be obsolete after 1 day, and GetOperation API will return NOT_FOUND afterwards. If
                        /// conflicting updates are issued, the Operations associated with the stale updates will not be
                        /// marked as done until being obsolete. This feature is only available for users who have
                        /// Retail Search enabled. Enable Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        public class AddLocalInventoriesRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new AddLocalInventories request.</summary>
                            public AddLocalInventoriesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddLocalInventoriesRequest body, string product) : base(service)
                            {
                                Product = product;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                            /// If the caller does not have permission to access the Product, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Product { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddLocalInventoriesRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "addLocalInventories";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+product}:addLocalInventories";

                            /// <summary>Initializes AddLocalInventories parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "product",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/products/.*$",
                                });
                            }
                        }

                        /// <summary>Creates a Product.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent catalog resource name, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a Product.</summary>
                        public class CreateRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct body, string parent) : base(service)
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
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+parent}/products";

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
                        public class DeleteRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleProtobufEmpty>
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
                            public override string RestPath => "v2alpha/{+name}";

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
                        public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct>
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
                            public override string RestPath => "v2alpha/{+name}";

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
                        /// Bulk import of multiple Products. Request processing may be synchronous. Non-existing items
                        /// are created. Note that it is possible for a subset of the Products to be successfully
                        /// updated.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. `projects/1234/locations/global/catalogs/default_catalog/branches/default_branch`
                        /// If no updateMask is specified, requires products.create permission. If updateMask is
                        /// specified, requires products.update permission.
                        /// </param>
                        public virtual ImportRequest Import(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportProductsRequest body, string parent)
                        {
                            return new ImportRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Bulk import of multiple Products. Request processing may be synchronous. Non-existing items
                        /// are created. Note that it is possible for a subset of the Products to be successfully
                        /// updated.
                        /// </summary>
                        public class ImportRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Import request.</summary>
                            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportProductsRequest body, string parent) : base(service)
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
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportProductsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "import";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+parent}/products:import";

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

                        /// <summary>Gets a list of Products.</summary>
                        /// <param name="parent">
                        /// Required. The parent branch resource name, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/0`. Use `default_branch` as
                        /// the branch ID, to list products under the default branch. If the caller does not have
                        /// permission to list Products under this branch, regardless of whether or not this branch
                        /// exists, a PERMISSION_DENIED error is returned.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Gets a list of Products.</summary>
                        public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaListProductsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent branch resource name, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/0`. Use `default_branch`
                            /// as the branch ID, to list products under the default branch. If the caller does not have
                            /// permission to list Products under this branch, regardless of whether or not this branch
                            /// exists, a PERMISSION_DENIED error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// A filter to apply on the list results. Supported features: * List all the products under
                            /// the parent branch if filter is unset. * List Product.Type.VARIANT Products sharing the
                            /// same Product.Type.PRIMARY Product. For example: `primary_product_id = "some_product_id"`
                            /// * List Products bundled in a Product.Type.COLLECTION Product. For example:
                            /// `collection_product_id = "some_product_id"` * List Products with a partibular type. For
                            /// example: `type = "PRIMARY"` `type = "VARIANT"` `type = "COLLECTION"` If the field is
                            /// unrecognizable, an INVALID_ARGUMENT error is returned. If the specified
                            /// Product.Type.PRIMARY Product or Product.Type.COLLECTION Product does not exist, a
                            /// NOT_FOUND error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Maximum number of Products to return. If unspecified, defaults to 100. The maximum
                            /// allowed value is 1000. Values above 1000 will be coerced to 1000. If this field is
                            /// negative, an INVALID_ARGUMENT error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token ListProductsResponse.next_page_token, received from a previous
                            /// ProductService.ListProducts call. Provide this to retrieve the subsequent page. When
                            /// paginating, all other parameters provided to ProductService.ListProducts must match the
                            /// call that provided the page token. Otherwise, an INVALID_ARGUMENT error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// The fields of Product to return in the responses. If not set or empty, the following
                            /// fields are returned: * Product.name * Product.id * Product.title * Product.uri *
                            /// Product.images * Product.price_info * Product.brands If "*" is provided, all fields are
                            /// returned. Product.name is always returned no matter what mask is set. If an unsupported
                            /// or unknown field is provided, an INVALID_ARGUMENT error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object ReadMask { get; set; }

                            /// <summary>
                            /// If true and page_token is empty, ListProductsResponse.total_size is set to the total
                            /// count of matched items irrespective of pagination. Notice that setting this field to
                            /// true affects the performance.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("requireTotalSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> RequireTotalSize { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+parent}/products";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+$",
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
                                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "readMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("requireTotalSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "requireTotalSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Updates a Product.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Immutable. Full resource name of the product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates a Product.</summary>
                        public class PatchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Immutable. Full resource name of the product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`.
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
                            /// an INVALID_ARGUMENT error is returned. The attribute key can be updated by setting the
                            /// mask path as "attributes.${key_name}". If a key name is present in the mask but not in
                            /// the patching product from the request, this key will be deleted after the update.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaProduct Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+name}";

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

                        /// <summary>
                        /// Permanently deletes all selected Products under a branch. This process is asynchronous. If
                        /// the request is valid, the removal will be enqueued and processed offline. Depending on the
                        /// number of Products, this operation could take hours to complete. Before the operation
                        /// completes, some Products may still be returned by ProductService.GetProduct or
                        /// ProductService.ListProducts. Depending on the number of Products, this operation could take
                        /// hours to complete. To get a sample of Products that would be deleted, set
                        /// PurgeProductsRequest.force to false.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The resource name of the branch under which the products are created. The format
                        /// is `projects/${projectId}/locations/global/catalogs/${catalogId}/branches/${branchId}`
                        /// </param>
                        public virtual PurgeRequest Purge(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPurgeProductsRequest body, string parent)
                        {
                            return new PurgeRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Permanently deletes all selected Products under a branch. This process is asynchronous. If
                        /// the request is valid, the removal will be enqueued and processed offline. Depending on the
                        /// number of Products, this operation could take hours to complete. Before the operation
                        /// completes, some Products may still be returned by ProductService.GetProduct or
                        /// ProductService.ListProducts. Depending on the number of Products, this operation could take
                        /// hours to complete. To get a sample of Products that would be deleted, set
                        /// PurgeProductsRequest.force to false.
                        /// </summary>
                        public class PurgeRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Purge request.</summary>
                            public PurgeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPurgeProductsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the branch under which the products are created. The
                            /// format is
                            /// `projects/${projectId}/locations/global/catalogs/${catalogId}/branches/${branchId}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPurgeProductsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "purge";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+parent}/products:purge";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Incrementally removes place IDs from a Product.fulfillment_info.place_ids. This process is
                        /// asynchronous and does not require the Product to exist before updating fulfillment
                        /// information. If the request is valid, the update will be enqueued and processed downstream.
                        /// As a consequence, when a response is returned, the removed place IDs are not immediately
                        /// manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. The returned Operations will be obsolete after 1 day, and
                        /// GetOperation API will return NOT_FOUND afterwards. If conflicting updates are issued, the
                        /// Operations associated with the stale updates will not be marked as done until being
                        /// obsolete. This feature is only available for users who have Retail Search enabled. Enable
                        /// Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="product">
                        /// Required. Full resource name of Product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                        /// If the caller does not have permission to access the Product, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned.
                        /// </param>
                        public virtual RemoveFulfillmentPlacesRequest RemoveFulfillmentPlaces(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveFulfillmentPlacesRequest body, string product)
                        {
                            return new RemoveFulfillmentPlacesRequest(service, body, product);
                        }

                        /// <summary>
                        /// Incrementally removes place IDs from a Product.fulfillment_info.place_ids. This process is
                        /// asynchronous and does not require the Product to exist before updating fulfillment
                        /// information. If the request is valid, the update will be enqueued and processed downstream.
                        /// As a consequence, when a response is returned, the removed place IDs are not immediately
                        /// manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. The returned Operations will be obsolete after 1 day, and
                        /// GetOperation API will return NOT_FOUND afterwards. If conflicting updates are issued, the
                        /// Operations associated with the stale updates will not be marked as done until being
                        /// obsolete. This feature is only available for users who have Retail Search enabled. Enable
                        /// Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        public class RemoveFulfillmentPlacesRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new RemoveFulfillmentPlaces request.</summary>
                            public RemoveFulfillmentPlacesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveFulfillmentPlacesRequest body, string product) : base(service)
                            {
                                Product = product;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                            /// If the caller does not have permission to access the Product, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Product { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveFulfillmentPlacesRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "removeFulfillmentPlaces";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+product}:removeFulfillmentPlaces";

                            /// <summary>Initializes RemoveFulfillmentPlaces parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "product",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/products/.*$",
                                });
                            }
                        }

                        /// <summary>
                        /// Remove local inventory information for a Product at a list of places at a removal timestamp.
                        /// This process is asynchronous. If the request is valid, the removal will be enqueued and
                        /// processed downstream. As a consequence, when a response is returned, removals are not
                        /// immediately manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. Local inventory information can only be removed using this
                        /// method. ProductService.CreateProduct and ProductService.UpdateProduct has no effect on local
                        /// inventories. The returned Operations will be obsolete after 1 day, and GetOperation API will
                        /// return NOT_FOUND afterwards. If conflicting updates are issued, the Operations associated
                        /// with the stale updates will not be marked as done until being obsolete. This feature is only
                        /// available for users who have Retail Search enabled. Enable Retail Search on Cloud Console
                        /// before using this feature.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="product">
                        /// Required. Full resource name of Product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                        /// If the caller does not have permission to access the Product, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned.
                        /// </param>
                        public virtual RemoveLocalInventoriesRequest RemoveLocalInventories(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveLocalInventoriesRequest body, string product)
                        {
                            return new RemoveLocalInventoriesRequest(service, body, product);
                        }

                        /// <summary>
                        /// Remove local inventory information for a Product at a list of places at a removal timestamp.
                        /// This process is asynchronous. If the request is valid, the removal will be enqueued and
                        /// processed downstream. As a consequence, when a response is returned, removals are not
                        /// immediately manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. Local inventory information can only be removed using this
                        /// method. ProductService.CreateProduct and ProductService.UpdateProduct has no effect on local
                        /// inventories. The returned Operations will be obsolete after 1 day, and GetOperation API will
                        /// return NOT_FOUND afterwards. If conflicting updates are issued, the Operations associated
                        /// with the stale updates will not be marked as done until being obsolete. This feature is only
                        /// available for users who have Retail Search enabled. Enable Retail Search on Cloud Console
                        /// before using this feature.
                        /// </summary>
                        public class RemoveLocalInventoriesRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new RemoveLocalInventories request.</summary>
                            public RemoveLocalInventoriesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveLocalInventoriesRequest body, string product) : base(service)
                            {
                                Product = product;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
                            /// If the caller does not have permission to access the Product, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Product { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveLocalInventoriesRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "removeLocalInventories";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+product}:removeLocalInventories";

                            /// <summary>Initializes RemoveLocalInventories parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "product",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/branches/[^/]+/products/.*$",
                                });
                            }
                        }

                        /// <summary>
                        /// Updates inventory information for a Product while respecting the last update timestamps of
                        /// each inventory field. This process is asynchronous and does not require the Product to exist
                        /// before updating fulfillment information. If the request is valid, the update is enqueued and
                        /// processed downstream. As a consequence, when a response is returned, updates are not
                        /// immediately manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. When inventory is updated with ProductService.CreateProduct and
                        /// ProductService.UpdateProduct, the specified inventory field value(s) overwrite any existing
                        /// value(s) while ignoring the last update time for this field. Furthermore, the last update
                        /// times for the specified inventory fields are overwritten by the times of the
                        /// ProductService.CreateProduct or ProductService.UpdateProduct request. If no inventory fields
                        /// are set in CreateProductRequest.product, then any pre-existing inventory information for
                        /// this product is used. If no inventory fields are set in SetInventoryRequest.set_mask, then
                        /// any existing inventory information is preserved. Pre-existing inventory information can only
                        /// be updated with ProductService.SetInventory, ProductService.AddFulfillmentPlaces, and
                        /// ProductService.RemoveFulfillmentPlaces. The returned Operations is obsolete after one day,
                        /// and the GetOperation API returns `NOT_FOUND` afterwards. If conflicting updates are issued,
                        /// the Operations associated with the stale updates are not marked as done until they are
                        /// obsolete. This feature is only available for users who have Retail Search enabled. Enable
                        /// Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Immutable. Full resource name of the product, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`.
                        /// </param>
                        public virtual SetInventoryRequest SetInventory(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSetInventoryRequest body, string name)
                        {
                            return new SetInventoryRequest(service, body, name);
                        }

                        /// <summary>
                        /// Updates inventory information for a Product while respecting the last update timestamps of
                        /// each inventory field. This process is asynchronous and does not require the Product to exist
                        /// before updating fulfillment information. If the request is valid, the update is enqueued and
                        /// processed downstream. As a consequence, when a response is returned, updates are not
                        /// immediately manifested in the Product queried by ProductService.GetProduct or
                        /// ProductService.ListProducts. When inventory is updated with ProductService.CreateProduct and
                        /// ProductService.UpdateProduct, the specified inventory field value(s) overwrite any existing
                        /// value(s) while ignoring the last update time for this field. Furthermore, the last update
                        /// times for the specified inventory fields are overwritten by the times of the
                        /// ProductService.CreateProduct or ProductService.UpdateProduct request. If no inventory fields
                        /// are set in CreateProductRequest.product, then any pre-existing inventory information for
                        /// this product is used. If no inventory fields are set in SetInventoryRequest.set_mask, then
                        /// any existing inventory information is preserved. Pre-existing inventory information can only
                        /// be updated with ProductService.SetInventory, ProductService.AddFulfillmentPlaces, and
                        /// ProductService.RemoveFulfillmentPlaces. The returned Operations is obsolete after one day,
                        /// and the GetOperation API returns `NOT_FOUND` afterwards. If conflicting updates are issued,
                        /// the Operations associated with the stale updates are not marked as done until they are
                        /// obsolete. This feature is only available for users who have Retail Search enabled. Enable
                        /// Retail Search on Cloud Console before using this feature.
                        /// </summary>
                        public class SetInventoryRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new SetInventory request.</summary>
                            public SetInventoryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSetInventoryRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Immutable. Full resource name of the product, such as
                            /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSetInventoryRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "setInventory";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2alpha/{+name}:setInventory";

                            /// <summary>Initializes SetInventory parameter list.</summary>
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
                    }
                }

                /// <summary>Gets the CompletionData resource.</summary>
                public virtual CompletionDataResource CompletionData { get; }

                /// <summary>The "completionData" collection of methods.</summary>
                public class CompletionDataResource
                {
                    private const string Resource = "completionData";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CompletionDataResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Bulk import of processed completion dataset. Request processing is asynchronous. Partial
                    /// updating is not supported. The operation is successfully finished only after the imported
                    /// suggestions are indexed successfully and ready for serving. The process takes hours. This
                    /// feature is only available for users who have Retail Search enabled. Enable Retail Search on
                    /// Cloud Console before using this feature.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The catalog which the suggestions dataset belongs to. Format:
                    /// `projects/1234/locations/global/catalogs/default_catalog`.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportCompletionDataRequest body, string parent)
                    {
                        return new ImportRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Bulk import of processed completion dataset. Request processing is asynchronous. Partial
                    /// updating is not supported. The operation is successfully finished only after the imported
                    /// suggestions are indexed successfully and ready for serving. The process takes hours. This
                    /// feature is only available for users who have Retail Search enabled. Enable Retail Search on
                    /// Cloud Console before using this feature.
                    /// </summary>
                    public class ImportRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportCompletionDataRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The catalog which the suggestions dataset belongs to. Format:
                        /// `projects/1234/locations/global/catalogs/default_catalog`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportCompletionDataRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/completionData:import";

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
                }

                /// <summary>Gets the Controls resource.</summary>
                public virtual ControlsResource Controls { get; }

                /// <summary>The "controls" collection of methods.</summary>
                public class ControlsResource
                {
                    private const string Resource = "controls";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ControlsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a Control. If the Control to create already exists, an ALREADY_EXISTS error is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Full resource name of parent catalog. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a Control. If the Control to create already exists, an ALREADY_EXISTS error is returned.
                    /// </summary>
                    public class CreateRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of parent catalog. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the Control, which will become the final component of the
                        /// Control's resource name. This value should be 4-63 characters, and valid characters are
                        /// /a-z-_/.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("controlId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ControlId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/controls";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                            RequestParameters.Add("controlId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "controlId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a Control. If the Control to delete does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the Control to delete. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/controls/{control_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a Control. If the Control to delete does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    public class DeleteRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Control to delete. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/controls/{control_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/controls/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a Control.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the Control to get. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/controls/{control_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a Control.</summary>
                    public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Control to get. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/controls/{control_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/controls/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all Controls by their parent Catalog.</summary>
                    /// <param name="parent">
                    /// Required. The catalog resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all Controls by their parent Catalog.</summary>
                    public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaListControlsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The catalog resource name. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. A filter to apply on the list results. Supported features: * List all the products
                        /// under the parent branch if filter is unset. * List controls that are used in a single
                        /// ServingConfig: 'serving_config = "boosted_home_page_cvr"'
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of results to return. If unspecified, defaults to 50. Max allowed
                        /// value is 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListControls` call. Provide this to
                        /// retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/controls";

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

                    /// <summary>
                    /// Updates a Control. Control cannot be set to a different oneof field, if so an INVALID_ARGUMENT
                    /// is returned. If the Control to update does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Fully qualified name `projects/*/locations/global/catalogs/*/controls/*`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a Control. Control cannot be set to a different oneof field, if so an INVALID_ARGUMENT
                    /// is returned. If the Control to update does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    public class PatchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Fully qualified name `projects/*/locations/global/catalogs/*/controls/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Indicates which fields in the provided Control to update. The following are NOT supported: *
                        /// Control.name If not set or empty, all supported fields are updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaControl Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/controls/[^/]+$",
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

                /// <summary>Gets the Models resource.</summary>
                public virtual ModelsResource Models { get; }

                /// <summary>The "models" collection of methods.</summary>
                public class ModelsResource
                {
                    private const string Resource = "models";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ModelsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new model.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource under which to create the model. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new model.</summary>
                    public class CreateRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource under which to create the model. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Whether to run a dry run to validate the request (without actually creating the
                        /// model).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dryRun", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> DryRun { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/models";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                            RequestParameters.Add("dryRun", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dryRun",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes an existing model.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the Model to delete. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an existing model.</summary>
                    public class DeleteRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Model to delete. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/models/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all the models linked to this event store.</summary>
                    /// <param name="parent">
                    /// Required. The parent for which to list models. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all the models linked to this event store.</summary>
                    public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaListModelsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent for which to list models. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of results to return. If unspecified, defaults to 50. Max allowed
                        /// value is 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListModels` call. Provide this to retrieve
                        /// the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/models";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
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

                    /// <summary>
                    /// Update of model metadata. Only fields that currently can be updated are: `filtering_option` and
                    /// `periodic_tuning_state`. If other values are provided, this API method ignores them.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The fully qualified resource name of the model. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                    /// catalog_id has char limit of 50. recommendation_model_id has char limit of 40.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Update of model metadata. Only fields that currently can be updated are: `filtering_option` and
                    /// `periodic_tuning_state`. If other values are provided, this API method ignores them.
                    /// </summary>
                    public class PatchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The fully qualified resource name of the model. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                        /// catalog_id has char limit of 50. recommendation_model_id has char limit of 40.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Indicates which fields in the provided 'model' to update. If not set, by default
                        /// updates all fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/models/[^/]+$",
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

                    /// <summary>Pauses the training of an existing model.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the model to pause. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                    /// </param>
                    public virtual PauseRequest Pause(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPauseModelRequest body, string name)
                    {
                        return new PauseRequest(service, body, name);
                    }

                    /// <summary>Pauses the training of an existing model.</summary>
                    public class PauseRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel>
                    {
                        /// <summary>Constructs a new Pause request.</summary>
                        public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPauseModelRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the model to pause. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPauseModelRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "pause";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}:pause";

                        /// <summary>Initializes Pause parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/models/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Resumes the training of an existing model.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the model to resume. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                    /// </param>
                    public virtual ResumeRequest Resume(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaResumeModelRequest body, string name)
                    {
                        return new ResumeRequest(service, body, name);
                    }

                    /// <summary>Resumes the training of an existing model.</summary>
                    public class ResumeRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaModel>
                    {
                        /// <summary>Constructs a new Resume request.</summary>
                        public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaResumeModelRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the model to resume. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaResumeModelRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "resume";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}:resume";

                        /// <summary>Initializes Resume parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/models/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Tunes an existing model.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the model to tune. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                    /// </param>
                    public virtual TuneRequest Tune(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaTuneModelRequest body, string name)
                    {
                        return new TuneRequest(service, body, name);
                    }

                    /// <summary>Tunes an existing model.</summary>
                    public class TuneRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Tune request.</summary>
                        public TuneRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaTuneModelRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the model to tune. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaTuneModelRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "tune";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}:tune";

                        /// <summary>Initializes Tune parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/models/[^/]+$",
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
                    public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
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
                        public override string RestPath => "v2alpha/{+name}";

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
                    public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v2alpha/{+name}/operations";

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
                    /// `{placement=projects/*/locations/global/catalogs/default_catalog/servingConfigs/*}` or
                    /// `{placement=projects/*/locations/global/catalogs/default_catalog/placements/*}`. We recommend
                    /// using the `servingConfigs` resource. `placements` is a legacy resource. The ID of the
                    /// Recommendations AI serving config or placement. Before you can request predictions from your
                    /// model, you must create at least one serving config or placement for it. For more information,
                    /// see [Managing serving configurations] (https://cloud.google.com/retail/docs/manage-configs). The
                    /// full list of available serving configs can be seen at
                    /// https://console.cloud.google.com/ai/retail/catalogs/default_catalog/configs
                    /// </param>
                    public virtual PredictRequest Predict(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictRequest body, string placement)
                    {
                        return new PredictRequest(service, body, placement);
                    }

                    /// <summary>Makes a recommendation prediction.</summary>
                    public class PredictRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictResponse>
                    {
                        /// <summary>Constructs a new Predict request.</summary>
                        public PredictRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictRequest body, string placement) : base(service)
                        {
                            Placement = placement;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of the format:
                        /// `{placement=projects/*/locations/global/catalogs/default_catalog/servingConfigs/*}` or
                        /// `{placement=projects/*/locations/global/catalogs/default_catalog/placements/*}`. We
                        /// recommend using the `servingConfigs` resource. `placements` is a legacy resource. The ID of
                        /// the Recommendations AI serving config or placement. Before you can request predictions from
                        /// your model, you must create at least one serving config or placement for it. For more
                        /// information, see [Managing serving configurations]
                        /// (https://cloud.google.com/retail/docs/manage-configs). The full list of available serving
                        /// configs can be seen at
                        /// https://console.cloud.google.com/ai/retail/catalogs/default_catalog/configs
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("placement", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Placement { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "predict";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+placement}:predict";

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

                    /// <summary>
                    /// Performs a search. This feature is only available for users who have Retail Search enabled.
                    /// Enable Retail Search on Cloud Console before using this feature.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="placement">
                    /// Required. The resource name of the Retail Search serving config, such as
                    /// `projects/*/locations/global/catalogs/default_catalog/servingConfigs/default_serving_config` or
                    /// the name of the legacy placement resource, such as
                    /// `projects/*/locations/global/catalogs/default_catalog/placements/default_search`. This field is
                    /// used to identify the serving configuration name and the set of models that will be used to make
                    /// the search.
                    /// </param>
                    public virtual SearchRequest Search(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchRequest body, string placement)
                    {
                        return new SearchRequest(service, body, placement);
                    }

                    /// <summary>
                    /// Performs a search. This feature is only available for users who have Retail Search enabled.
                    /// Enable Retail Search on Cloud Console before using this feature.
                    /// </summary>
                    public class SearchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchResponse>
                    {
                        /// <summary>Constructs a new Search request.</summary>
                        public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchRequest body, string placement) : base(service)
                        {
                            Placement = placement;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Retail Search serving config, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/servingConfigs/default_serving_config`
                        /// or the name of the legacy placement resource, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/placements/default_search`. This field
                        /// is used to identify the serving configuration name and the set of models that will be used
                        /// to make the search.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("placement", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Placement { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "search";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+placement}:search";

                        /// <summary>Initializes Search parameter list.</summary>
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

                /// <summary>Gets the ServingConfigs resource.</summary>
                public virtual ServingConfigsResource ServingConfigs { get; }

                /// <summary>The "servingConfigs" collection of methods.</summary>
                public class ServingConfigsResource
                {
                    private const string Resource = "servingConfigs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ServingConfigsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Enables a Control on the specified ServingConfig. The control is added in the last position of
                    /// the list of controls it belongs to (e.g. if it's a facet spec control it will be applied in the
                    /// last position of servingConfig.facetSpecIds) Returns a ALREADY_EXISTS error if the control has
                    /// already been applied. Returns a FAILED_PRECONDITION error if the addition could exceed maximum
                    /// number of control allowed for that type of control.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="servingConfig">
                    /// Required. The source ServingConfig resource name . Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                    /// </param>
                    public virtual AddControlRequest AddControl(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddControlRequest body, string servingConfig)
                    {
                        return new AddControlRequest(service, body, servingConfig);
                    }

                    /// <summary>
                    /// Enables a Control on the specified ServingConfig. The control is added in the last position of
                    /// the list of controls it belongs to (e.g. if it's a facet spec control it will be applied in the
                    /// last position of servingConfig.facetSpecIds) Returns a ALREADY_EXISTS error if the control has
                    /// already been applied. Returns a FAILED_PRECONDITION error if the addition could exceed maximum
                    /// number of control allowed for that type of control.
                    /// </summary>
                    public class AddControlRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig>
                    {
                        /// <summary>Constructs a new AddControl request.</summary>
                        public AddControlRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddControlRequest body, string servingConfig) : base(service)
                        {
                            ServingConfig = servingConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The source ServingConfig resource name . Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServingConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAddControlRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "addControl";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+servingConfig}:addControl";

                        /// <summary>Initializes AddControl parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servingConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/servingConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Creates a ServingConfig. A maximum of 100 ServingConfigs are allowed in a Catalog, otherwise a
                    /// FAILED_PRECONDITION error is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Full resource name of parent. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a ServingConfig. A maximum of 100 ServingConfigs are allowed in a Catalog, otherwise a
                    /// FAILED_PRECONDITION error is returned.
                    /// </summary>
                    public class CreateRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of parent. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the ServingConfig, which will become the final component of the
                        /// ServingConfig's resource name. This value should be 4-63 characters, and valid characters
                        /// are /a-z-_/.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("servingConfigId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ServingConfigId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/servingConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                            RequestParameters.Add("servingConfigId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servingConfigId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a ServingConfig. Returns a NotFound error if the ServingConfig does not exist.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the ServingConfig to delete. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a ServingConfig. Returns a NotFound error if the ServingConfig does not exist.
                    /// </summary>
                    public class DeleteRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the ServingConfig to delete. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/servingConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets a ServingConfig. Returns a NotFound error if the ServingConfig does not exist.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the ServingConfig to get. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets a ServingConfig. Returns a NotFound error if the ServingConfig does not exist.
                    /// </summary>
                    public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the ServingConfig to get. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/servingConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all ServingConfigs linked to this catalog.</summary>
                    /// <param name="parent">
                    /// Required. The catalog resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all ServingConfigs linked to this catalog.</summary>
                    public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaListServingConfigsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The catalog resource name. Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of results to return. If unspecified, defaults to 100. If a value
                        /// greater than 100 is provided, at most 100 results are returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListServingConfigs` call. Provide this to
                        /// retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/servingConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
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

                    /// <summary>Updates a ServingConfig.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Fully qualified name `projects/*/locations/global/catalogs/*/servingConfig/*`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates a ServingConfig.</summary>
                    public class PatchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Fully qualified name `projects/*/locations/global/catalogs/*/servingConfig/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Indicates which fields in the provided ServingConfig to update. The following are NOT
                        /// supported: * ServingConfig.name If not set, all supported fields are updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/servingConfigs/[^/]+$",
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

                    /// <summary>Makes a recommendation prediction.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="placement">
                    /// Required. Full resource name of the format:
                    /// `{placement=projects/*/locations/global/catalogs/default_catalog/servingConfigs/*}` or
                    /// `{placement=projects/*/locations/global/catalogs/default_catalog/placements/*}`. We recommend
                    /// using the `servingConfigs` resource. `placements` is a legacy resource. The ID of the
                    /// Recommendations AI serving config or placement. Before you can request predictions from your
                    /// model, you must create at least one serving config or placement for it. For more information,
                    /// see [Managing serving configurations] (https://cloud.google.com/retail/docs/manage-configs). The
                    /// full list of available serving configs can be seen at
                    /// https://console.cloud.google.com/ai/retail/catalogs/default_catalog/configs
                    /// </param>
                    public virtual PredictRequest Predict(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictRequest body, string placement)
                    {
                        return new PredictRequest(service, body, placement);
                    }

                    /// <summary>Makes a recommendation prediction.</summary>
                    public class PredictRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictResponse>
                    {
                        /// <summary>Constructs a new Predict request.</summary>
                        public PredictRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictRequest body, string placement) : base(service)
                        {
                            Placement = placement;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of the format:
                        /// `{placement=projects/*/locations/global/catalogs/default_catalog/servingConfigs/*}` or
                        /// `{placement=projects/*/locations/global/catalogs/default_catalog/placements/*}`. We
                        /// recommend using the `servingConfigs` resource. `placements` is a legacy resource. The ID of
                        /// the Recommendations AI serving config or placement. Before you can request predictions from
                        /// your model, you must create at least one serving config or placement for it. For more
                        /// information, see [Managing serving configurations]
                        /// (https://cloud.google.com/retail/docs/manage-configs). The full list of available serving
                        /// configs can be seen at
                        /// https://console.cloud.google.com/ai/retail/catalogs/default_catalog/configs
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("placement", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Placement { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPredictRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "predict";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+placement}:predict";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/servingConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Disables a Control on the specified ServingConfig. The control is removed from the
                    /// ServingConfig. Returns a NOT_FOUND error if the Control is not enabled for the ServingConfig.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="servingConfig">
                    /// Required. The source ServingConfig resource name . Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                    /// </param>
                    public virtual RemoveControlRequest RemoveControl(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveControlRequest body, string servingConfig)
                    {
                        return new RemoveControlRequest(service, body, servingConfig);
                    }

                    /// <summary>
                    /// Disables a Control on the specified ServingConfig. The control is removed from the
                    /// ServingConfig. Returns a NOT_FOUND error if the Control is not enabled for the ServingConfig.
                    /// </summary>
                    public class RemoveControlRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaServingConfig>
                    {
                        /// <summary>Constructs a new RemoveControl request.</summary>
                        public RemoveControlRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveControlRequest body, string servingConfig) : base(service)
                        {
                            ServingConfig = servingConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The source ServingConfig resource name . Format:
                        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServingConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRemoveControlRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "removeControl";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+servingConfig}:removeControl";

                        /// <summary>Initializes RemoveControl parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servingConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/servingConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Performs a search. This feature is only available for users who have Retail Search enabled.
                    /// Enable Retail Search on Cloud Console before using this feature.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="placement">
                    /// Required. The resource name of the Retail Search serving config, such as
                    /// `projects/*/locations/global/catalogs/default_catalog/servingConfigs/default_serving_config` or
                    /// the name of the legacy placement resource, such as
                    /// `projects/*/locations/global/catalogs/default_catalog/placements/default_search`. This field is
                    /// used to identify the serving configuration name and the set of models that will be used to make
                    /// the search.
                    /// </param>
                    public virtual SearchRequest Search(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchRequest body, string placement)
                    {
                        return new SearchRequest(service, body, placement);
                    }

                    /// <summary>
                    /// Performs a search. This feature is only available for users who have Retail Search enabled.
                    /// Enable Retail Search on Cloud Console before using this feature.
                    /// </summary>
                    public class SearchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchResponse>
                    {
                        /// <summary>Constructs a new Search request.</summary>
                        public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchRequest body, string placement) : base(service)
                        {
                            Placement = placement;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Retail Search serving config, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/servingConfigs/default_serving_config`
                        /// or the name of the legacy placement resource, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/placements/default_search`. This field
                        /// is used to identify the serving configuration name and the set of models that will be used
                        /// to make the search.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("placement", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Placement { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSearchRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "search";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+placement}:search";

                        /// <summary>Initializes Search parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("placement", new Google.Apis.Discovery.Parameter
                            {
                                Name = "placement",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/servingConfigs/[^/]+$",
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
                    public class CollectRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleApiHttpBody>
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
                        public override string RestPath => "v2alpha/{+parent}/userEvents:collect";

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
                    /// are skipped. Use this method for backfilling historical user events. `Operation.response` is of
                    /// type `ImportResponse`. Note that it is possible for a subset of the items to be successfully
                    /// inserted. `Operation.metadata` is of type `ImportMetadata`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. `projects/1234/locations/global/catalogs/default_catalog`</param>
                    public virtual ImportRequest Import(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportUserEventsRequest body, string parent)
                    {
                        return new ImportRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Bulk import of User events. Request processing might be synchronous. Events that already exist
                    /// are skipped. Use this method for backfilling historical user events. `Operation.response` is of
                    /// type `ImportResponse`. Note that it is possible for a subset of the items to be successfully
                    /// inserted. `Operation.metadata` is of type `ImportMetadata`.
                    /// </summary>
                    public class ImportRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportUserEventsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. `projects/1234/locations/global/catalogs/default_catalog`</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaImportUserEventsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/userEvents:import";

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
                    public virtual PurgeRequest Purge(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPurgeUserEventsRequest body, string parent)
                    {
                        return new PurgeRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Deletes permanently all user events specified by the filter provided. Depending on the number of
                    /// events specified by the filter, this operation could take hours or days to complete. To test a
                    /// filter, use the list command first.
                    /// </summary>
                    public class PurgeRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Purge request.</summary>
                        public PurgeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPurgeUserEventsRequest body, string parent) : base(service)
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
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaPurgeUserEventsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "purge";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/userEvents:purge";

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
                    /// Starts a user-event rejoin operation with latest product catalog. Events are not annotated with
                    /// detailed product information for products that are missing from the catalog when the user event
                    /// is ingested. These events are stored as unjoined events with limited usage on training and
                    /// serving. You can use this method to start a join operation on specified events with the latest
                    /// version of product catalog. You can also use this method to correct events joined with the wrong
                    /// product catalog. A rejoin operation can take hours or days to complete.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent catalog resource name, such as
                    /// `projects/1234/locations/global/catalogs/default_catalog`.
                    /// </param>
                    public virtual RejoinRequest Rejoin(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRejoinUserEventsRequest body, string parent)
                    {
                        return new RejoinRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Starts a user-event rejoin operation with latest product catalog. Events are not annotated with
                    /// detailed product information for products that are missing from the catalog when the user event
                    /// is ingested. These events are stored as unjoined events with limited usage on training and
                    /// serving. You can use this method to start a join operation on specified events with the latest
                    /// version of product catalog. You can also use this method to correct events joined with the wrong
                    /// product catalog. A rejoin operation can take hours or days to complete.
                    /// </summary>
                    public class RejoinRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Rejoin request.</summary>
                        public RejoinRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRejoinUserEventsRequest body, string parent) : base(service)
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
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaRejoinUserEventsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rejoin";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/userEvents:rejoin";

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
                    public virtual WriteRequest Write(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaUserEvent body, string parent)
                    {
                        return new WriteRequest(service, body, parent);
                    }

                    /// <summary>Writes a single user event.</summary>
                    public class WriteRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaUserEvent>
                    {
                        /// <summary>Constructs a new Write request.</summary>
                        public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaUserEvent body, string parent) : base(service)
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
                        Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaUserEvent Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "write";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/userEvents:write";

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

                /// <summary>
                /// Completes the specified prefix with keyword suggestions. This feature is only available for users
                /// who have Retail Search enabled. Enable Retail Search on Cloud Console before using this feature.
                /// </summary>
                /// <param name="catalog">
                /// Required. Catalog for which the completion is performed. Full resource name of catalog, such as
                /// `projects/*/locations/global/catalogs/default_catalog`.
                /// </param>
                public virtual CompleteQueryRequest CompleteQuery(string catalog)
                {
                    return new CompleteQueryRequest(service, catalog);
                }

                /// <summary>
                /// Completes the specified prefix with keyword suggestions. This feature is only available for users
                /// who have Retail Search enabled. Enable Retail Search on Cloud Console before using this feature.
                /// </summary>
                public class CompleteQueryRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCompleteQueryResponse>
                {
                    /// <summary>Constructs a new CompleteQuery request.</summary>
                    public CompleteQueryRequest(Google.Apis.Services.IClientService service, string catalog) : base(service)
                    {
                        Catalog = catalog;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Catalog for which the completion is performed. Full resource name of catalog, such as
                    /// `projects/*/locations/global/catalogs/default_catalog`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("catalog", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Catalog { get; private set; }

                    /// <summary>
                    /// Determines which dataset to use for fetching completion. "user-data" will use the imported
                    /// dataset through CompletionService.ImportCompletionData. "cloud-retail" will use the dataset
                    /// generated by cloud retail based on user events. If leave empty, it will use the "user-data".
                    /// Current supported values: * user-data * cloud-retail: This option requires enabling
                    /// auto-learning function first. See
                    /// [guidelines](https://cloud.google.com/retail/docs/completion-overview#generated-completion-dataset).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataset", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Dataset { get; set; }

                    /// <summary>
                    /// The device type context for completion suggestions. It is useful to apply different suggestions
                    /// on different device types, e.g. `DESKTOP`, `MOBILE`. If it is empty, the suggestions are across
                    /// all device types. Supported formats: * `UNKNOWN_DEVICE_TYPE` * `DESKTOP` * `MOBILE` * A
                    /// customized string starts with `OTHER_`, e.g. `OTHER_IPHONE`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("deviceType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DeviceType { get; set; }

                    /// <summary>
                    /// Note that this field applies for `user-data` dataset only. For requests with `cloud-retail`
                    /// dataset, setting this field has no effect. The language filters applied to the output
                    /// suggestions. If set, it should contain the language of the query. If not set, suggestions are
                    /// returned without considering language restrictions. This is the BCP-47 language code, such as
                    /// "en-US" or "sr-Latn". For more information, see [Tags for Identifying
                    /// Languages](https://tools.ietf.org/html/bcp47). The maximum number of language codes is 3.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("languageCodes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> LanguageCodes { get; set; }

                    /// <summary>
                    /// Completion max suggestions. If left unset or set to 0, then will fallback to the configured
                    /// value CompletionConfig.max_suggestions. The maximum allowed max suggestions is 20. If it is set
                    /// higher, it will be capped by 20.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("maxSuggestions", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> MaxSuggestions { get; set; }

                    /// <summary>
                    /// Required. The query used to generate suggestions. The maximum number of allowed characters is
                    /// 255.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Query { get; set; }

                    /// <summary>
                    /// Required field. A unique identifier for tracking visitors. For example, this could be
                    /// implemented with an HTTP cookie, which should be able to uniquely identify a visitor on a single
                    /// device. This unique identifier should not change if the visitor logs in or out of the website.
                    /// The field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an
                    /// INVALID_ARGUMENT error is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("visitorId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VisitorId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "completeQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+catalog}:completeQuery";

                    /// <summary>Initializes CompleteQuery parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("catalog", new Google.Apis.Discovery.Parameter
                        {
                            Name = "catalog",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                        });
                        RequestParameters.Add("dataset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataset",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("deviceType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "deviceType",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("languageCodes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "languageCodes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("maxSuggestions", new Google.Apis.Discovery.Parameter
                        {
                            Name = "maxSuggestions",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                        {
                            Name = "query",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("visitorId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "visitorId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets an AttributesConfig.</summary>
                /// <param name="name">
                /// Required. Full AttributesConfig resource name. Format:
                /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                /// </param>
                public virtual GetAttributesConfigRequest GetAttributesConfig(string name)
                {
                    return new GetAttributesConfigRequest(service, name);
                }

                /// <summary>Gets an AttributesConfig.</summary>
                public class GetAttributesConfigRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig>
                {
                    /// <summary>Constructs a new GetAttributesConfig request.</summary>
                    public GetAttributesConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Full AttributesConfig resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getAttributesConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

                    /// <summary>Initializes GetAttributesConfig parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/attributesConfig$",
                        });
                    }
                }

                /// <summary>Gets a CompletionConfig.</summary>
                /// <param name="name">
                /// Required. Full CompletionConfig resource name. Format:
                /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
                /// </param>
                public virtual GetCompletionConfigRequest GetCompletionConfig(string name)
                {
                    return new GetCompletionConfigRequest(service, name);
                }

                /// <summary>Gets a CompletionConfig.</summary>
                public class GetCompletionConfigRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCompletionConfig>
                {
                    /// <summary>Constructs a new GetCompletionConfig request.</summary>
                    public GetCompletionConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Full CompletionConfig resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getCompletionConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

                    /// <summary>Initializes GetCompletionConfig parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/completionConfig$",
                        });
                    }
                }

                /// <summary>
                /// Get which branch is currently default branch set by CatalogService.SetDefaultBranch method under a
                /// specified parent catalog.
                /// </summary>
                /// <param name="catalog">
                /// The parent catalog resource name, such as `projects/*/locations/global/catalogs/default_catalog`.
                /// </param>
                public virtual GetDefaultBranchRequest GetDefaultBranch(string catalog)
                {
                    return new GetDefaultBranchRequest(service, catalog);
                }

                /// <summary>
                /// Get which branch is currently default branch set by CatalogService.SetDefaultBranch method under a
                /// specified parent catalog.
                /// </summary>
                public class GetDefaultBranchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaGetDefaultBranchResponse>
                {
                    /// <summary>Constructs a new GetDefaultBranch request.</summary>
                    public GetDefaultBranchRequest(Google.Apis.Services.IClientService service, string catalog) : base(service)
                    {
                        Catalog = catalog;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent catalog resource name, such as
                    /// `projects/*/locations/global/catalogs/default_catalog`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("catalog", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Catalog { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getDefaultBranch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+catalog}:getDefaultBranch";

                    /// <summary>Initializes GetDefaultBranch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("catalog", new Google.Apis.Discovery.Parameter
                        {
                            Name = "catalog",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                        });
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
                public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaListCatalogsResponse>
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
                    public override string RestPath => "v2alpha/{+parent}/catalogs";

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
                public virtual PatchRequest Patch(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCatalog body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the Catalogs.</summary>
                public class PatchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCatalog>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCatalog body, string name) : base(service)
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
                    Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCatalog Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

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

                /// <summary>
                /// Set a specified branch id as default branch. API methods such as SearchService.Search,
                /// ProductService.GetProduct, ProductService.ListProducts will treat requests using "default_branch" to
                /// the actual branch id set as default. For example, if `projects/*/locations/*/catalogs/*/branches/1`
                /// is set as default, setting SearchRequest.branch to
                /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent to setting
                /// SearchRequest.branch to `projects/*/locations/*/catalogs/*/branches/1`. Using multiple branches can
                /// be useful when developers would like to have a staging branch to test and verify for future usage.
                /// When it becomes ready, developers switch on the staging branch using this API while keeping using
                /// `projects/*/locations/*/catalogs/*/branches/default_branch` as SearchRequest.branch to route the
                /// traffic to this staging branch. CAUTION: If you have live predict/search traffic, switching the
                /// default branch could potentially cause outages if the ID space of the new branch is very different
                /// from the old one. More specifically: * PredictionService will only return product IDs from branch
                /// {newBranch}. * SearchService will only return product IDs from branch {newBranch} (if branch is not
                /// explicitly set). * UserEventService will only join events with products from branch {newBranch}.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="catalog">
                /// Full resource name of the catalog, such as `projects/*/locations/global/catalogs/default_catalog`.
                /// </param>
                public virtual SetDefaultBranchRequest SetDefaultBranch(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSetDefaultBranchRequest body, string catalog)
                {
                    return new SetDefaultBranchRequest(service, body, catalog);
                }

                /// <summary>
                /// Set a specified branch id as default branch. API methods such as SearchService.Search,
                /// ProductService.GetProduct, ProductService.ListProducts will treat requests using "default_branch" to
                /// the actual branch id set as default. For example, if `projects/*/locations/*/catalogs/*/branches/1`
                /// is set as default, setting SearchRequest.branch to
                /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent to setting
                /// SearchRequest.branch to `projects/*/locations/*/catalogs/*/branches/1`. Using multiple branches can
                /// be useful when developers would like to have a staging branch to test and verify for future usage.
                /// When it becomes ready, developers switch on the staging branch using this API while keeping using
                /// `projects/*/locations/*/catalogs/*/branches/default_branch` as SearchRequest.branch to route the
                /// traffic to this staging branch. CAUTION: If you have live predict/search traffic, switching the
                /// default branch could potentially cause outages if the ID space of the new branch is very different
                /// from the old one. More specifically: * PredictionService will only return product IDs from branch
                /// {newBranch}. * SearchService will only return product IDs from branch {newBranch} (if branch is not
                /// explicitly set). * UserEventService will only join events with products from branch {newBranch}.
                /// </summary>
                public class SetDefaultBranchRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new SetDefaultBranch request.</summary>
                    public SetDefaultBranchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSetDefaultBranchRequest body, string catalog) : base(service)
                    {
                        Catalog = catalog;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Full resource name of the catalog, such as
                    /// `projects/*/locations/global/catalogs/default_catalog`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("catalog", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Catalog { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaSetDefaultBranchRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setDefaultBranch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+catalog}:setDefaultBranch";

                    /// <summary>Initializes SetDefaultBranch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("catalog", new Google.Apis.Discovery.Parameter
                        {
                            Name = "catalog",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates the AttributesConfig. The catalog attributes in the request will be updated in the catalog,
                /// or inserted if they do not exist. Existing catalog attributes not included in the request will
                /// remain unchanged. Attributes that are assigned to products, but do not exist at the catalog level,
                /// are always included in the response. The product attribute is assigned default values for missing
                /// catalog attribute fields, e.g., searchable and dynamic facetable options.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Immutable. The fully qualified resource name of the attribute config. Format:
                /// `projects/*/locations/*/catalogs/*/attributesConfig`
                /// </param>
                public virtual UpdateAttributesConfigRequest UpdateAttributesConfig(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig body, string name)
                {
                    return new UpdateAttributesConfigRequest(service, body, name);
                }

                /// <summary>
                /// Updates the AttributesConfig. The catalog attributes in the request will be updated in the catalog,
                /// or inserted if they do not exist. Existing catalog attributes not included in the request will
                /// remain unchanged. Attributes that are assigned to products, but do not exist at the catalog level,
                /// are always included in the response. The product attribute is assigned default values for missing
                /// catalog attribute fields, e.g., searchable and dynamic facetable options.
                /// </summary>
                public class UpdateAttributesConfigRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig>
                {
                    /// <summary>Constructs a new UpdateAttributesConfig request.</summary>
                    public UpdateAttributesConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Immutable. The fully qualified resource name of the attribute config. Format:
                    /// `projects/*/locations/*/catalogs/*/attributesConfig`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Indicates which fields in the provided AttributesConfig to update. The following is the only
                    /// supported field: * AttributesConfig.catalog_attributes If not set, all supported fields are
                    /// updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaAttributesConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateAttributesConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

                    /// <summary>Initializes UpdateAttributesConfig parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/attributesConfig$",
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

                /// <summary>Updates the CompletionConfigs.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Immutable. Fully qualified name `projects/*/locations/*/catalogs/*/completionConfig`
                /// </param>
                public virtual UpdateCompletionConfigRequest UpdateCompletionConfig(Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCompletionConfig body, string name)
                {
                    return new UpdateCompletionConfigRequest(service, body, name);
                }

                /// <summary>Updates the CompletionConfigs.</summary>
                public class UpdateCompletionConfigRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCompletionConfig>
                {
                    /// <summary>Constructs a new UpdateCompletionConfig request.</summary>
                    public UpdateCompletionConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCompletionConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Immutable. Fully qualified name `projects/*/locations/*/catalogs/*/completionConfig`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Indicates which fields in the provided CompletionConfig to update. The following are the only
                    /// supported fields: * CompletionConfig.matching_order * CompletionConfig.max_suggestions *
                    /// CompletionConfig.min_prefix_length * CompletionConfig.auto_learning If not set, all supported
                    /// fields are updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRetail.v2alpha.Data.GoogleCloudRetailV2alphaCompletionConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateCompletionConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

                    /// <summary>Initializes UpdateCompletionConfig parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/completionConfig$",
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
                public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
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
                    public override string RestPath => "v2alpha/{+name}";

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
                public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningListOperationsResponse>
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
                    public override string RestPath => "v2alpha/{+name}/operations";

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
            public class GetRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningOperation>
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
                public override string RestPath => "v2alpha/{+name}";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            public class ListRequest : CloudRetailBaseServiceRequest<Google.Apis.CloudRetail.v2alpha.Data.GoogleLongrunningListOperationsResponse>
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
                public override string RestPath => "v2alpha/{+name}/operations";

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
                        Pattern = @"^projects/[^/]+$",
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
namespace Google.Apis.CloudRetail.v2alpha.Data
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

    /// <summary>
    /// Metadata related to the progress of the AddFulfillmentPlaces operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.AddFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2AddFulfillmentPlacesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the AddFulfillmentPlacesRequest. Currently empty because there is no meaningful response populated
    /// from the ProductService.AddFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2AddFulfillmentPlacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the AddLocalInventories operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.AddLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2AddLocalInventoriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ProductService.AddLocalInventories API. Currently empty because there is no meaningful response
    /// populated from the ProductService.AddLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2AddLocalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportCompletionDataRequest. If the long running operation is done, this message is returned by
    /// the google.longrunning.Operations.response field if the operation is successful.
    /// </summary>
    public class GoogleCloudRetailV2ImportCompletionDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudRetailV2ImportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory.
        /// Import errors are written to sharded files in this directory, one per line, as a JSON-encoded
        /// `google.rpc.Status` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Import operation. This is returned by the
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

        /// <summary>
        /// Pub/Sub topic for receiving notification. If this field is set, when the import is finished, a notification
        /// is sent to specified Pub/Sub topic. The message data is JSON string of a Operation. Format of the Pub/Sub
        /// topic is `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPubsubTopic")]
        public virtual string NotificationPubsubTopic { get; set; }

        /// <summary>Deprecated. This field is never set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

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

    /// <summary>
    /// Metadata related to the progress of the Purge operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2PurgeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Metadata for `RejoinUserEvents` method.</summary>
    public class GoogleCloudRetailV2RejoinUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `RejoinUserEvents` method.</summary>
    public class GoogleCloudRetailV2RejoinUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest product catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the RemoveFulfillmentPlaces operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.RemoveFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2RemoveFulfillmentPlacesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the RemoveFulfillmentPlacesRequest. Currently empty because there is no meaningful response
    /// populated from the ProductService.RemoveFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2RemoveFulfillmentPlacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the RemoveLocalInventories operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.RemoveLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2RemoveLocalInventoriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ProductService.RemoveLocalInventories API. Currently empty because there is no meaningful
    /// response populated from the ProductService.RemoveLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2RemoveLocalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the SetInventory operation. Currently empty because there is no meaningful
    /// metadata populated from the ProductService.SetInventory method.
    /// </summary>
    public class GoogleCloudRetailV2SetInventoryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the SetInventoryRequest. Currently empty because there is no meaningful response populated from the
    /// ProductService.SetInventory method.
    /// </summary>
    public class GoogleCloudRetailV2SetInventoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Request for CatalogService.AddCatalogAttribute method.</summary>
    public class GoogleCloudRetailV2alphaAddCatalogAttributeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The CatalogAttribute to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogAttribute")]
        public virtual GoogleCloudRetailV2alphaCatalogAttribute CatalogAttribute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for AddControl method.</summary>
    public class GoogleCloudRetailV2alphaAddControlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The id of the control to apply. Assumed to be in the same catalog as the serving config - if id is
        /// not found a NOT_FOUND error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlId")]
        public virtual string ControlId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the AddFulfillmentPlaces operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.AddFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2alphaAddFulfillmentPlacesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ProductService.AddFulfillmentPlaces method.</summary>
    public class GoogleCloudRetailV2alphaAddFulfillmentPlacesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when the fulfillment updates are issued, used to prevent out-of-order updates on fulfillment
        /// information. If not provided, the internal system time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addTime")]
        public virtual object AddTime { get; set; }

        /// <summary>
        /// If set to true, and the Product is not found, the fulfillment information will still be processed and
        /// retained for at most 1 day and processed once the Product is created. If set to false, a NOT_FOUND error is
        /// returned if the Product is not found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Required. The IDs for this type, such as the store IDs for "pickup-in-store" or the region IDs for
        /// "same-day-delivery" to be added for this type. Duplicate IDs will be automatically ignored. At least 1 value
        /// is required, and a maximum of 2000 values are allowed. Each value must be a string with a length limit of 10
        /// characters, matching the pattern `[a-zA-Z0-9_-]+`, such as "store1" or "REGION-2". Otherwise, an
        /// INVALID_ARGUMENT error is returned. If the total number of place IDs exceeds 2000 for this type after
        /// adding, then the update will be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeIds")]
        public virtual System.Collections.Generic.IList<string> PlaceIds { get; set; }

        /// <summary>
        /// Required. The fulfillment type, including commonly used types (such as pickup in store and same day
        /// delivery), and custom types. Supported values: * "pickup-in-store" * "ship-to-store" * "same-day-delivery" *
        /// "next-day-delivery" * "custom-type-1" * "custom-type-2" * "custom-type-3" * "custom-type-4" *
        /// "custom-type-5" If this field is set to an invalid value other than these, an INVALID_ARGUMENT error is
        /// returned. This field directly corresponds to Product.fulfillment_info.type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the AddFulfillmentPlacesRequest. Currently empty because there is no meaningful response populated
    /// from the ProductService.AddFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2alphaAddFulfillmentPlacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the AddLocalInventories operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.AddLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2alphaAddLocalInventoriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ProductService.AddLocalInventories method.</summary>
    public class GoogleCloudRetailV2alphaAddLocalInventoriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates which inventory fields in the provided list of LocalInventory to update. The field is updated to
        /// the provided value. If a field is set while the place does not have a previous local inventory, the local
        /// inventory at that store is created. If a field is set while the value of that field is not provided, the
        /// original field value, if it exists, is deleted. If the mask is not set or set with empty paths, all
        /// inventory fields will be updated. If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned and the entire update will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addMask")]
        public virtual object AddMask { get; set; }

        /// <summary>
        /// The time when the inventory updates are issued. Used to prevent out-of-order updates on local inventory
        /// fields. If not provided, the internal system time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addTime")]
        public virtual object AddTime { get; set; }

        /// <summary>
        /// If set to true, and the Product is not found, the local inventory will still be processed and retained for
        /// at most 1 day and processed once the Product is created. If set to false, a NOT_FOUND error is returned if
        /// the Product is not found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Required. A list of inventory information at difference places. Each place is identified by its place ID. At
        /// most 3000 inventories are allowed per request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localInventories")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaLocalInventory> LocalInventories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ProductService.AddLocalInventories API. Currently empty because there is no meaningful response
    /// populated from the ProductService.AddLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2alphaAddLocalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Catalog level attribute config.</summary>
    public class GoogleCloudRetailV2alphaAttributesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The AttributeConfigLevel used for this catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeConfigLevel")]
        public virtual string AttributeConfigLevel { get; set; }

        /// <summary>
        /// Enable attribute(s) config at catalog level. For example, indexable, dynamic_facetable, or searchable for
        /// each attribute. The key is catalog attribute's name. For example: `color`, `brands`,
        /// `attributes.custom_attribute`, such as `attributes.xyz`. The maximum number of catalog attributes allowed in
        /// a request is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRetailV2alphaCatalogAttribute> CatalogAttributes { get; set; }

        /// <summary>
        /// Required. Immutable. The fully qualified resource name of the attribute config. Format:
        /// `projects/*/locations/*/catalogs/*/attributesConfig`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An intended audience of the Product for whom it's sold.</summary>
    public class GoogleCloudRetailV2alphaAudience : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The age groups of the audience. Strongly encouraged to use the standard values: "newborn" (up to 3 months
        /// old), "infant" (3–12 months old), "toddler" (1–5 years old), "kids" (5–13 years old), "adult" (typically
        /// teens or older). At most 5 values are allowed. Each value must be a UTF-8 encoded string with a length limit
        /// of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center property
        /// [age_group](https://support.google.com/merchants/answer/6324463). Schema.org property
        /// [Product.audience.suggestedMinAge](https://schema.org/suggestedMinAge) and
        /// [Product.audience.suggestedMaxAge](https://schema.org/suggestedMaxAge).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ageGroups")]
        public virtual System.Collections.Generic.IList<string> AgeGroups { get; set; }

        /// <summary>
        /// The genders of the audience. Strongly encouraged to use the standard values: "male", "female", "unisex". At
        /// most 5 values are allowed. Each value must be a UTF-8 encoded string with a length limit of 128 characters.
        /// Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center property
        /// [gender](https://support.google.com/merchants/answer/6324479). Schema.org property
        /// [Product.audience.suggestedGender](https://schema.org/suggestedGender).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genders")]
        public virtual System.Collections.Generic.IList<string> Genders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for CatalogService.BatchRemoveCatalogAttributes method.</summary>
    public class GoogleCloudRetailV2alphaBatchRemoveCatalogAttributesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The attribute name keys of the CatalogAttributes to delete. A maximum of 1000 catalog attributes
        /// can be deleted in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeKeys")]
        public virtual System.Collections.Generic.IList<string> AttributeKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the CatalogService.BatchRemoveCatalogAttributes.</summary>
    public class GoogleCloudRetailV2alphaBatchRemoveCatalogAttributesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Catalog attributes that were deleted. Only pre-loaded catalog attributes that are neither in use by products
        /// nor predefined can be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedCatalogAttributes")]
        public virtual System.Collections.Generic.IList<string> DeletedCatalogAttributes { get; set; }

        /// <summary>
        /// Catalog attributes that were reset. Catalog attributes that are either in use by products or are predefined
        /// attributes cannot be deleted; however, their configuration properties will reset to default values upon
        /// removal request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resetCatalogAttributes")]
        public virtual System.Collections.Generic.IList<string> ResetCatalogAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BigQuery output result.</summary>
    public class GoogleCloudRetailV2alphaBigQueryOutputResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of a BigQuery Dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>The ID of a BigQuery Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BigQuery source import data from.</summary>
    public class GoogleCloudRetailV2alphaBigQuerySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for product imports: * `product`
        /// (default): One JSON Product per line. Each product must have a valid Product.id. *
        /// `product_merchant_center`: See [Importing catalog data from Merchant
        /// Center](https://cloud.google.com/retail/recommendations-ai/docs/upload-catalog#mc). Supported values for
        /// user events imports: * `user_event` (default): One JSON UserEvent per line. * `user_event_ga360`: The schema
        /// is available here: https://support.google.com/analytics/answer/3437719. * `user_event_ga4`: The schema is
        /// available here: https://support.google.com/analytics/answer/7029846. Supported values for auto-completion
        /// imports: * `suggestions` (default): One JSON completion suggestion per line. * `denylist`: One JSON deny
        /// suggestion per line. * `allowlist`: One JSON allow suggestion per line.
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
        /// BigQuery time partitioned table's _PARTITIONDATE in YYYY-MM-DD format. Only supported in
        /// ImportProductsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionDate")]
        public virtual GoogleTypeDate PartitionDate { get; set; }

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
    public class GoogleCloudRetailV2alphaCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The catalog display name. This field must be a UTF-8 encoded string with a length limit
        /// of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The Merchant Center linking configuration. Once a link is added, the data stream from Merchant Center to
        /// Cloud Retail will be enabled automatically. The requester must have access to the merchant center account in
        /// order to make changes to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantCenterLinkingConfig")]
        public virtual GoogleCloudRetailV2alphaMerchantCenterLinkingConfig MerchantCenterLinkingConfig { get; set; }

        /// <summary>Required. Immutable. The fully qualified resource name of the catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The product level configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLevelConfig")]
        public virtual GoogleCloudRetailV2alphaProductLevelConfig ProductLevelConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Catalog level attribute config for an attribute. For example, if customers want to enable/disable facet for a
    /// specific attribute.
    /// </summary>
    public class GoogleCloudRetailV2alphaCatalogAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If DYNAMIC_FACETABLE_ENABLED, attribute values are available for dynamic facet. Could only be
        /// DYNAMIC_FACETABLE_DISABLED if CatalogAttribute.indexable_option is INDEXABLE_DISABLED. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicFacetableOption")]
        public virtual string DynamicFacetableOption { get; set; }

        /// <summary>
        /// If EXACT_SEARCHABLE_ENABLED, attribute values will be exact searchable. This property only applies to
        /// textual custom attributes and requires indexable set to enabled to enable exact-searchable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactSearchableOption")]
        public virtual string ExactSearchableOption { get; set; }

        /// <summary>
        /// Output only. Indicates whether this attribute has been used by any products. `True` if at least one Product
        /// is using this attribute in Product.attributes. Otherwise, this field is `False`. CatalogAttribute can be
        /// pre-loaded by using CatalogService.AddCatalogAttribute, CatalogService.ImportCatalogAttributes, or
        /// CatalogService.UpdateAttributesConfig APIs. This field is `False` for pre-loaded CatalogAttributes. Only
        /// pre-loaded catalog attributes that are neither in use by products nor predefined can be deleted. Catalog
        /// attributes that are either in use by products or are predefined attributes cannot be deleted; however, their
        /// configuration properties will reset to default values upon removal request. After catalog changes, it takes
        /// about 10 minutes for this field to update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inUse")]
        public virtual System.Nullable<bool> InUse { get; set; }

        /// <summary>
        /// When AttributesConfig.attribute_config_level is CATALOG_LEVEL_ATTRIBUTE_CONFIG, if INDEXABLE_ENABLED
        /// attribute values are indexed so that it can be filtered, faceted, or boosted in SearchService.Search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexableOption")]
        public virtual string IndexableOption { get; set; }

        /// <summary>
        /// Required. Attribute name. For example: `color`, `brands`, `attributes.custom_attribute`, such as
        /// `attributes.xyz`. To be indexable, the attribute name can contain only alpha-numeric characters and
        /// underscores. For example, an attribute named `attributes.abc_xyz` can be indexed, but an attribute named
        /// `attributes.abc-xyz` cannot be indexed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// When AttributesConfig.attribute_config_level is CATALOG_LEVEL_ATTRIBUTE_CONFIG, if
        /// RECOMMENDATIONS_FILTERING_ENABLED, attribute values are filterable for recommendations. This option works
        /// for categorical features only, does not work for numerical features, inventory filtering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendationsFilteringOption")]
        public virtual string RecommendationsFilteringOption { get; set; }

        /// <summary>
        /// When AttributesConfig.attribute_config_level is CATALOG_LEVEL_ATTRIBUTE_CONFIG, if SEARCHABLE_ENABLED,
        /// attribute values are searchable by text queries in SearchService.Search. If SEARCHABLE_ENABLED but attribute
        /// type is numerical, attribute values will not be searchable by text queries in SearchService.Search, as there
        /// are no text values associated to numerical attributes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchableOption")]
        public virtual string SearchableOption { get; set; }

        /// <summary>
        /// Output only. The type of this attribute. This is derived from the attribute in Product.attributes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The color information of a Product.</summary>
    public class GoogleCloudRetailV2alphaColorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The standard color families. Strongly recommended to use the following standard color groups: "Red", "Pink",
        /// "Orange", "Yellow", "Purple", "Green", "Cyan", "Blue", "Brown", "White", "Gray", "Black" and "Mixed".
        /// Normally it is expected to have only 1 color family. May consider using single "Mixed" instead of multiple
        /// values. A maximum of 5 values are allowed. Each value must be a UTF-8 encoded string with a length limit of
        /// 128 characters. Otherwise, an INVALID_ARGUMENT error is returned. Google Merchant Center property
        /// [color](https://support.google.com/merchants/answer/6324487). Schema.org property
        /// [Product.color](https://schema.org/color).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorFamilies")]
        public virtual System.Collections.Generic.IList<string> ColorFamilies { get; set; }

        /// <summary>
        /// The color display names, which may be different from standard color family names, such as the color aliases
        /// used in the website frontend. Normally it is expected to have only 1 color. May consider using single
        /// "Mixed" instead of multiple values. A maximum of 25 colors are allowed. Each value must be a UTF-8 encoded
        /// string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned. Google
        /// Merchant Center property [color](https://support.google.com/merchants/answer/6324487). Schema.org property
        /// [Product.color](https://schema.org/color).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual System.Collections.Generic.IList<string> Colors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the auto-complete query.</summary>
    public class GoogleCloudRetailV2alphaCompleteQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique complete token. This should be included in the UserEvent.completion_detail for search events
        /// resulting from this completion, which enables accurate attribution of complete model performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>
        /// Results of the matching suggestions. The result list is ordered and the first result is top suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaCompleteQueryResponseCompletionResult> CompletionResults { get; set; }

        /// <summary>
        /// Matched recent searches of this user. The maximum number of recent searches is 10. This field is a
        /// restricted feature. Contact Retail Search support team if you are interested in enabling it. This feature is
        /// only available when CompleteQueryRequest.visitor_id field is set and UserEvent is imported. The recent
        /// searches satisfy the follow rules: * They are ordered from latest to oldest. * They are matched with
        /// CompleteQueryRequest.query case insensitively. * They are transformed to lower case. * They are UTF-8 safe.
        /// Recent searches are deduplicated. More recent searches will be reserved when duplication happens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentSearchResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaCompleteQueryResponseRecentSearchResult> RecentSearchResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that represents completion results.</summary>
    public class GoogleCloudRetailV2alphaCompleteQueryResponseCompletionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Custom attributes for the suggestion term. * For "user-data", the attributes are additional custom
        /// attributes ingested through BigQuery. * For "cloud-retail", the attributes are product attributes generated
        /// by Cloud Retail. It requires UserEvent.product_details is imported properly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRetailV2alphaCustomAttribute> Attributes { get; set; }

        /// <summary>The suggestion for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestion")]
        public virtual string Suggestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Recent search of this user.</summary>
    public class GoogleCloudRetailV2alphaCompleteQueryResponseRecentSearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recent search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentSearch")]
        public virtual string RecentSearch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Catalog level autocomplete config for customers to customize autocomplete feature's settings.</summary>
    public class GoogleCloudRetailV2alphaCompletionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The source data for the latest import of the autocomplete allowlist phrases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowlistInputConfig")]
        public virtual GoogleCloudRetailV2alphaCompletionDataInputConfig AllowlistInputConfig { get; set; }

        /// <summary>
        /// If set to true, the auto learning function is enabled. Auto learning uses user data to generate suggestions
        /// using ML techniques. Default value is false. Only after enabling auto learning can users use `cloud-retail`
        /// data in CompleteQueryRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoLearning")]
        public virtual System.Nullable<bool> AutoLearning { get; set; }

        /// <summary>Output only. The source data for the latest import of the autocomplete denylist phrases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denylistInputConfig")]
        public virtual GoogleCloudRetailV2alphaCompletionDataInputConfig DenylistInputConfig { get; set; }

        /// <summary>
        /// Output only. Name of the LRO corresponding to the latest allowlist import. Can use GetOperation API to
        /// retrieve the latest state of the Long Running Operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAllowlistImportOperation")]
        public virtual string LastAllowlistImportOperation { get; set; }

        /// <summary>
        /// Output only. Name of the LRO corresponding to the latest denylist import. Can use GetOperation API to
        /// retrieve the latest state of the Long Running Operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDenylistImportOperation")]
        public virtual string LastDenylistImportOperation { get; set; }

        /// <summary>
        /// Output only. Name of the LRO corresponding to the latest suggestion terms list import. Can use GetOperation
        /// API to retrieve the latest state of the Long Running Operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSuggestionsImportOperation")]
        public virtual string LastSuggestionsImportOperation { get; set; }

        /// <summary>
        /// Specifies the matching order for autocomplete suggestions, e.g., a query consisting of 'sh' with
        /// 'out-of-order' specified would suggest "women's shoes", whereas a query of 'red s' with 'exact-prefix'
        /// specified would suggest "red shoes". Currently supported values: * 'out-of-order' * 'exact-prefix' Default
        /// value: 'exact-prefix'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingOrder")]
        public virtual string MatchingOrder { get; set; }

        /// <summary>
        /// The maximum number of autocomplete suggestions returned per term. Default value is 20. If left unset or set
        /// to 0, then will fallback to default value. Value range is 1 to 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSuggestions")]
        public virtual System.Nullable<int> MaxSuggestions { get; set; }

        /// <summary>
        /// The minimum number of characters needed to be typed in order to get suggestions. Default value is 2. If left
        /// unset or set to 0, then will fallback to default value. Value range is 1 to 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minPrefixLength")]
        public virtual System.Nullable<int> MinPrefixLength { get; set; }

        /// <summary>
        /// Required. Immutable. Fully qualified name `projects/*/locations/*/catalogs/*/completionConfig`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The source data for the latest import of the autocomplete suggestion phrases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestionsInputConfig")]
        public virtual GoogleCloudRetailV2alphaCompletionDataInputConfig SuggestionsInputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input config source for completion data.</summary>
    public class GoogleCloudRetailV2alphaCompletionDataInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. BigQuery input source. Add the IAM permission "BigQuery Data Viewer" for
        /// cloud-retail-customer-data-access@system.gserviceaccount.com before using this feature otherwise an error is
        /// thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQuerySource")]
        public virtual GoogleCloudRetailV2alphaBigQuerySource BigQuerySource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Detailed completion information including completion attribution token and clicked completion info.
    /// </summary>
    public class GoogleCloudRetailV2alphaCompletionDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Completion attribution token in CompleteQueryResponse.attribution_token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionAttributionToken")]
        public virtual string CompletionAttributionToken { get; set; }

        /// <summary>
        /// End user selected CompleteQueryResponse.CompletionResult.suggestion position, starting from 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedPosition")]
        public virtual System.Nullable<int> SelectedPosition { get; set; }

        /// <summary>End user selected CompleteQueryResponse.CompletionResult.suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedSuggestion")]
        public virtual string SelectedSuggestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata that is used to define a condition that triggers an action. A valid condition must specify at least one
    /// of 'query_terms' or 'products_filter'. If multiple fields are specified, the condition is met if all the fields
    /// are satisfied e.g. if a set of query terms and product_filter are set, then only items matching the
    /// product_filter for requests with a query matching the query terms wil get boosted.
    /// </summary>
    public class GoogleCloudRetailV2alphaCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Range of time(s) specifying when Condition is active. Condition true if any time range matches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeTimeRange")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaConditionTimeRange> ActiveTimeRange { get; set; }

        /// <summary>
        /// A list (up to 10 entries) of terms to match the query on. If not specified, match all queries. If many query
        /// terms are specified, the condition is matched if any of the terms is a match (i.e. using the OR operator).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryTerms")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaConditionQueryTerm> QueryTerms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Query terms that we want to match on.</summary>
    public class GoogleCloudRetailV2alphaConditionQueryTerm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this is supposed to be a full or partial match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullMatch")]
        public virtual System.Nullable<bool> FullMatch { get; set; }

        /// <summary>
        /// The value of the term to match on. Value cannot be empty. Value can have at most 3 terms if specified as a
        /// partial match. Each space separated string is considered as one term. For example, "a b c" is 3 terms and
        /// allowed, but " a b c d" is 4 terms and not allowed for a partial match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used for time-dependent conditions. Example: Want to have rule applied for week long sale.</summary>
    public class GoogleCloudRetailV2alphaConditionTimeRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of time range. Range is inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Start of time range. Range is inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures dynamic metadata that can be linked to a ServingConfig and affect search or recommendation results at
    /// serving time.
    /// </summary>
    public class GoogleCloudRetailV2alphaControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. List of serving configuration ids that are associated with this control in the same Catalog.
        /// Note the association is managed via the ServingConfig, this is an output only denormalized view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedServingConfigIds")]
        public virtual System.Collections.Generic.IList<string> AssociatedServingConfigIds { get; set; }

        /// <summary>
        /// Required. The human readable control display name. Used in Retail UI. This field must be a UTF-8 encoded
        /// string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// A facet specification to perform faceted search. Note that this field is deprecated and will throw
        /// NOT_IMPLEMENTED if used for creating a control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestFacetSpec FacetSpec { get; set; }

        /// <summary>Immutable. Fully qualified name `projects/*/locations/global/catalogs/*/controls/*`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A rule control - a condition-action pair. Enacts a set action when the condition is triggered. For example:
        /// Boost "gShoe" when query full matches "Running Shoes".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual GoogleCloudRetailV2alphaRule Rule { get; set; }

        /// <summary>
        /// Specifies the use case for the control. Affects what condition fields can be set. Only settable by search
        /// controls. Will default to SEARCH_SOLUTION_USE_CASE_SEARCH if not specified. Currently only allow one
        /// search_solution_use_case per control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchSolutionUseCase")]
        public virtual System.Collections.Generic.IList<string> SearchSolutionUseCase { get; set; }

        /// <summary>
        /// Required. Immutable. The solution types that the control is used for. Currently we support setting only one
        /// type of solution at creation time. Only `SOLUTION_TYPE_SEARCH` value is supported at the moment. If no
        /// solution type is provided at creation time, will default to SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solutionTypes")]
        public virtual System.Collections.Generic.IList<string> SolutionTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata associated with a create operation.</summary>
    public class GoogleCloudRetailV2alphaCreateModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the model that this create applies to. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom attribute that is not explicitly modeled in Product.</summary>
    public class GoogleCloudRetailV2alphaCustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field is normally ignored unless AttributesConfig.attribute_config_level of the Catalog is set to the
        /// deprecated 'PRODUCT_LEVEL_ATTRIBUTE_CONFIG' mode. For information about product-level attribute
        /// configuration, see [Configuration
        /// modes](https://cloud.google.com/retail/docs/attribute-config#config-modes). If true, custom attribute values
        /// are indexed, so that they can be filtered, faceted or boosted in SearchService.Search. This field is ignored
        /// in a UserEvent. See SearchRequest.filter, SearchRequest.facet_specs and SearchRequest.boost_spec for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexable")]
        public virtual System.Nullable<bool> Indexable { get; set; }

        /// <summary>
        /// The numerical values of this custom attribute. For example, `[2.3, 15.4]` when the key is "lengths_cm".
        /// Exactly one of text or numbers should be set. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numbers")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Numbers { get; set; }

        /// <summary>
        /// This field is normally ignored unless AttributesConfig.attribute_config_level of the Catalog is set to the
        /// deprecated 'PRODUCT_LEVEL_ATTRIBUTE_CONFIG' mode. For information about product-level attribute
        /// configuration, see [Configuration
        /// modes](https://cloud.google.com/retail/docs/attribute-config#config-modes). If true, custom attribute values
        /// are searchable by text queries in SearchService.Search. This field is ignored in a UserEvent. Only set if
        /// type text is set. Otherwise, a INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchable")]
        public virtual System.Nullable<bool> Searchable { get; set; }

        /// <summary>
        /// The textual values of this custom attribute. For example, `["yellow", "green"]` when the key is "color".
        /// Empty string is not allowed. Otherwise, an INVALID_ARGUMENT error is returned. Exactly one of text or
        /// numbers should be set. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual System.Collections.Generic.IList<string> Text { get; set; }

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
    /// Metadata related to the progress of the Export operation. This is returned by the
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

        /// <summary>This field is never set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Output result indicating where the data were exported to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputResult")]
        public virtual GoogleCloudRetailV2alphaOutputResult OutputResult { get; set; }

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

        /// <summary>This field is never set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Output result indicating where the data were exported to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputResult")]
        public virtual GoogleCloudRetailV2alphaOutputResult OutputResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fulfillment information, such as the store IDs for in-store pickup or region IDs for different shipping methods.
    /// </summary>
    public class GoogleCloudRetailV2alphaFulfillmentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The IDs for this type, such as the store IDs for FulfillmentInfo.type.pickup-in-store or the region IDs for
        /// FulfillmentInfo.type.same-day-delivery. A maximum of 3000 values are allowed. Each value must be a string
        /// with a length limit of 30 characters, matching the pattern `[a-zA-Z0-9_-]+`, such as "store1" or "REGION-2".
        /// Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeIds")]
        public virtual System.Collections.Generic.IList<string> PlaceIds { get; set; }

        /// <summary>
        /// The fulfillment type, including commonly used types (such as pickup in store and same day delivery), and
        /// custom types. Customers have to map custom types to their display names before rendering UI. Supported
        /// values: * "pickup-in-store" * "ship-to-store" * "same-day-delivery" * "next-day-delivery" * "custom-type-1"
        /// * "custom-type-2" * "custom-type-3" * "custom-type-4" * "custom-type-5" If this field is set to an invalid
        /// value other than these, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage location for input content.</summary>
    public class GoogleCloudRetailV2alphaGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for product imports: * `product`
        /// (default): One JSON Product per line. Each product must have a valid Product.id. *
        /// `product_merchant_center`: See [Importing catalog data from Merchant
        /// Center](https://cloud.google.com/retail/recommendations-ai/docs/upload-catalog#mc). Supported values for
        /// user events imports: * `user_event` (default): One JSON UserEvent per line. * `user_event_ga360`: Using
        /// https://support.google.com/analytics/answer/3437719. Supported values for control imports: * `control`
        /// (default): One JSON Control per line. Supported values for catalog attribute imports: * `catalog_attribute`
        /// (default): One CSV CatalogAttribute per line.
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

    /// <summary>Response message of CatalogService.GetDefaultBranch.</summary>
    public class GoogleCloudRetailV2alphaGetDefaultBranchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Full resource name of the branch id currently set as default branch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branch")]
        public virtual string Branch { get; set; }

        /// <summary>
        /// This corresponds to SetDefaultBranchRequest.note field, when this branch was set as default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>The time when this branch is set to default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setTime")]
        public virtual object SetTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Product image. Recommendations AI and Retail Search do not use product images to improve prediction and search
    /// results. However, product images can be returned in results, and are shown in prediction or search previews in
    /// the console.
    /// </summary>
    public class GoogleCloudRetailV2alphaImage : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for ImportCompletionData methods.</summary>
    public class GoogleCloudRetailV2alphaImportCompletionDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The desired input location of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudRetailV2alphaCompletionDataInputConfig InputConfig { get; set; }

        /// <summary>
        /// Pub/Sub topic for receiving notification. If this field is set, when the import is finished, a notification
        /// is sent to specified Pub/Sub topic. The message data is JSON string of a Operation. Format of the Pub/Sub
        /// topic is `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPubsubTopic")]
        public virtual string NotificationPubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportCompletionDataRequest. If the long running operation is done, this message is returned by
    /// the google.longrunning.Operations.response field if the operation is successful.
    /// </summary>
    public class GoogleCloudRetailV2alphaImportCompletionDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudRetailV2alphaImportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory.
        /// Import errors are written to sharded files in this directory, one per line, as a JSON-encoded
        /// `google.rpc.Status` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Import operation. This is returned by the
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

        /// <summary>
        /// Pub/Sub topic for receiving notification. If this field is set, when the import is finished, a notification
        /// is sent to specified Pub/Sub topic. The message data is JSON string of a Operation. Format of the Pub/Sub
        /// topic is `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPubsubTopic")]
        public virtual string NotificationPubsubTopic { get; set; }

        /// <summary>Deprecated. This field is never set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        /// <summary>Metadata related to transform user events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformedUserEventsMetadata")]
        public virtual GoogleCloudRetailV2alphaTransformedUserEventsMetadata TransformedUserEventsMetadata { get; set; }

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Import methods.</summary>
    public class GoogleCloudRetailV2alphaImportProductsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The desired location of errors incurred during the Import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Required. The desired input location of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudRetailV2alphaProductInputConfig InputConfig { get; set; }

        /// <summary>
        /// Full Pub/Sub topic name for receiving notification. If this field is set, when the import is finished, a
        /// notification is sent to specified Pub/Sub topic. The message data is JSON string of a Operation. Format of
        /// the Pub/Sub topic is `projects/{project}/topics/{topic}`. It has to be within the same project as
        /// ImportProductsRequest.parent. Make sure that `service-@gcp-sa-retail.iam.gserviceaccount.com` has the
        /// `pubsub.topics.publish` IAM permission on the topic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPubsubTopic")]
        public virtual string NotificationPubsubTopic { get; set; }

        /// <summary>
        /// The mode of reconciliation between existing products and the products to be imported. Defaults to
        /// ReconciliationMode.INCREMENTAL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciliationMode")]
        public virtual string ReconciliationMode { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// If true, this performs the FULL import even if it would delete a large proportion of the products in the
        /// default branch, which could potentially cause outages if you have live predict/search traffic. Only
        /// supported when ImportProductsRequest.reconciliation_mode is set to `FULL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipDefaultBranchProtection")]
        public virtual System.Nullable<bool> SkipDefaultBranchProtection { get; set; }

        /// <summary>
        /// Indicates which fields in the provided imported `products` to update. If not set, all fields are updated.
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

    /// <summary>Request message for the ImportUserEvents request.</summary>
    public class GoogleCloudRetailV2alphaImportUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The desired location of errors incurred during the Import. Cannot be set for inline user event imports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2alphaImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Required. The desired input location of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudRetailV2alphaUserEventInputConfig InputConfig { get; set; }

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

    /// <summary>A floating point interval.</summary>
    public class GoogleCloudRetailV2alphaInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Exclusive upper bound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusiveMaximum")]
        public virtual System.Nullable<double> ExclusiveMaximum { get; set; }

        /// <summary>Exclusive lower bound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusiveMinimum")]
        public virtual System.Nullable<double> ExclusiveMinimum { get; set; }

        /// <summary>Inclusive upper bound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual System.Nullable<double> Maximum { get; set; }

        /// <summary>Inclusive lower bound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual System.Nullable<double> Minimum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for CatalogService.ListCatalogs method.</summary>
    public class GoogleCloudRetailV2alphaListCatalogsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All the customer's Catalogs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaCatalog> Catalogs { get; set; }

        /// <summary>
        /// A token that can be sent as ListCatalogsRequest.page_token to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListControls method.</summary>
    public class GoogleCloudRetailV2alphaListControlsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All the Controls for a given catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controls")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaControl> Controls { get; set; }

        /// <summary>Pagination token, if not returned indicates the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a ListModelRequest.</summary>
    public class GoogleCloudRetailV2alphaListModelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaModel> Models { get; set; }

        /// <summary>Pagination token, if not returned indicates the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ProductService.ListProducts method.</summary>
    public class GoogleCloudRetailV2alphaListProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as ListProductsRequest.page_token to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaProduct> Products { get; set; }

        /// <summary>
        /// The total count of matched Products irrespective of pagination. The total number of Products returned by
        /// pagination may be less than the total_size that matches. This field is ignored if
        /// ListProductsRequest.require_total_size is not set or ListProductsRequest.page_token is not empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListServingConfigs method.</summary>
    public class GoogleCloudRetailV2alphaListServingConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination token, if not returned indicates the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>All the ServingConfigs for a given catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaServingConfig> ServingConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inventory information at a place (e.g. a store) identified by a place ID.</summary>
    public class GoogleCloudRetailV2alphaLocalInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional local inventory attributes, for example, store name, promotion tags, etc. This field needs to
        /// pass all below criteria, otherwise an INVALID_ARGUMENT error is returned: * At most 30 attributes are
        /// allowed. * The key must be a UTF-8 encoded string with a length limit of 32 characters. * The key must match
        /// the pattern: `a-zA-Z0-9*`. For example, key0LikeThis or KEY_1_LIKE_THIS. * The attribute values must be of
        /// the same type (text or number). * Only 1 value is allowed for each attribute. * For text values, the length
        /// limit is 256 UTF-8 characters. * The attribute does not support search. The `searchable` field should be
        /// unset or set to false. * The max summed total bytes of custom attribute keys and values per product is 5MiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRetailV2alphaCustomAttribute> Attributes { get; set; }

        /// <summary>
        /// Input only. Supported fulfillment types. Valid fulfillment type values include commonly used types (such as
        /// pickup in store and same day delivery), and custom types. Customers have to map custom types to their
        /// display names before rendering UI. Supported values: * "pickup-in-store" * "ship-to-store" *
        /// "same-day-delivery" * "next-day-delivery" * "custom-type-1" * "custom-type-2" * "custom-type-3" *
        /// "custom-type-4" * "custom-type-5" If this field is set to an invalid value other than these, an
        /// INVALID_ARGUMENT error is returned. All the elements must be distinct. Otherwise, an INVALID_ARGUMENT error
        /// is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentTypes")]
        public virtual System.Collections.Generic.IList<string> FulfillmentTypes { get; set; }

        /// <summary>The place ID for the current set of inventory information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>
        /// Product price and cost information. Google Merchant Center property
        /// [price](https://support.google.com/merchants/answer/6324371).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceInfo")]
        public virtual GoogleCloudRetailV2alphaPriceInfo PriceInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a link between a Merchant Center account and a branch. Once a link is established, products from the
    /// linked merchant center account will be streamed to the linked branch.
    /// </summary>
    public class GoogleCloudRetailV2alphaMerchantCenterLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The branch id (e.g. 0/1/2) within this catalog that products from merchant_center_account_id are streamed
        /// to. When updating this field, an empty value will use the currently configured default branch. However,
        /// changing the default branch later on won't change the linked branch here. A single branch id can only have
        /// one linked merchant center account id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branchId")]
        public virtual string BranchId { get; set; }

        /// <summary>
        /// String representing the destination to import for, all if left empty. List of possible values is given in
        /// [Included destination](https://support.google.com/merchants/answer/7501026). List of allowed string values:
        /// "Shopping_ads", "Buy_on_google_listings", "Display_ads", "Local_inventory _ads", "Free_listings",
        /// "Free_local_listings" NOTE: The string values are case sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<string> Destinations { get; set; }

        /// <summary>
        /// Language of the title/description and other string attributes. Use language tags defined by [BCP
        /// 47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt). ISO 639-1. This specifies the language of offers in
        /// Merchant Center that will be accepted. If empty no language filtering will be performed. Example value:
        /// `en`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Required. The linked [Merchant center account
        /// id](https://developers.google.com/shopping-content/guides/accountstatuses). The account must be a standalone
        /// account or a sub-account of a MCA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantCenterAccountId")]
        public virtual System.Nullable<long> MerchantCenterAccountId { get; set; }

        /// <summary>
        /// Region code of offers to accept. 2-letter Uppercase ISO 3166-1 alpha-2 code. List of values can be found
        /// [here](https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry) under the
        /// `region` tag. If left blank no region filtering will be performed. Example value: `US`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures Merchant Center linking. Links contained in the config will be used to sync data from a Merchant
    /// Center account to a Cloud Retail branch.
    /// </summary>
    public class GoogleCloudRetailV2alphaMerchantCenterLinkingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Links between Merchant Center accounts and branches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaMerchantCenterLink> Links { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata that describes the training and serving parameters of a Model. A Model can be associated with a
    /// ServingConfig and then queried through the Predict API.
    /// </summary>
    public class GoogleCloudRetailV2alphaModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp the Recommendation Model was created at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The state of data requirements for this model: `DATA_OK` and `DATA_ERROR`. Recommendation model
        /// cannot be trained if the data is in `DATA_ERROR` state. Recommendation model can have `DATA_ERROR` state
        /// even if serving state is `ACTIVE`: models were trained successfully before, but cannot be refreshed because
        /// model no longer has sufficient data for training.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataState")]
        public virtual string DataState { get; set; }

        /// <summary>
        /// Required. The display name of the model. Should be human readable, used to display Recommendation Models in
        /// the Retail Cloud Console Dashboard. UTF-8 encoded string with limit of 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. If `RECOMMENDATIONS_FILTERING_ENABLED`, recommendation filtering by attributes is enabled for the
        /// model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteringOption")]
        public virtual string FilteringOption { get; set; }

        /// <summary>Output only. The timestamp when the latest successful tune finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTuneTime")]
        public virtual object LastTuneTime { get; set; }

        /// <summary>
        /// Required. The fully qualified resource name of the model. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}` catalog_id has
        /// char limit of 50. recommendation_model_id has char limit of 40.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The optimization objective e.g. `cvr`. Currently supported values: `ctr`, `cvr`,
        /// `revenue-per-order`. If not specified, we choose default based on model type. Default depends on type of
        /// recommendation: `recommended-for-you` =&amp;gt; `ctr` `others-you-may-like` =&amp;gt; `ctr`
        /// `frequently-bought-together` =&amp;gt; `revenue_per_order` This field together with optimization_objective
        /// describe model metadata to use to control model training and serving. See
        /// https://cloud.google.com/retail/docs/models for more details on what the model metadata control and which
        /// combination of parameters are valid. For invalid combinations of parameters (e.g. type =
        /// `frequently-bought-together` and optimization_objective = `ctr`), you receive an error 400 if you try to
        /// create/update a recommendation with this set of knobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizationObjective")]
        public virtual string OptimizationObjective { get; set; }

        /// <summary>Optional. The page optimization config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageOptimizationConfig")]
        public virtual GoogleCloudRetailV2alphaModelPageOptimizationConfig PageOptimizationConfig { get; set; }

        /// <summary>
        /// Optional. The state of periodic tuning. The period we use is 3 months - to do a one-off tune earlier use the
        /// `TuneModel` method. Default value is `PERIODIC_TUNING_ENABLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodicTuningState")]
        public virtual string PeriodicTuningState { get; set; }

        /// <summary>
        /// Output only. The list of valid serving configs associated with the PageOptimizationConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingConfigLists")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaModelServingConfigList> ServingConfigLists { get; set; }

        /// <summary>Output only. The serving state of the model: `ACTIVE`, `NOT_ACTIVE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingState")]
        public virtual string ServingState { get; set; }

        /// <summary>
        /// Optional. The training state that the model is in (e.g. `TRAINING` or `PAUSED`). Since part of the cost of
        /// running the service is frequency of training - this can be used to determine when to train model in order to
        /// control cost. If not specified: the default value for `CreateModel` method is `TRAINING`. The default value
        /// for `UpdateModel` method is to keep the state the same as before.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingState")]
        public virtual string TrainingState { get; set; }

        /// <summary>
        /// Output only. The tune operation associated with the model. Can be used to determine if there is an ongoing
        /// tune for this recommendation. Empty field implies no tune is goig on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tuningOperation")]
        public virtual string TuningOperation { get; set; }

        /// <summary>
        /// Required. The type of model e.g. `home-page`. Currently supported values: `recommended-for-you`,
        /// `others-you-may-like`, `frequently-bought-together`, `page-optimization`, `similar-items`, `buy-it-again`,
        /// and `recently-viewed`(readonly value). This field together with optimization_objective describe model
        /// metadata to use to control model training and serving. See https://cloud.google.com/retail/docs/models for
        /// more details on what the model metadata control and which combination of parameters are valid. For invalid
        /// combinations of parameters (e.g. type = `frequently-bought-together` and optimization_objective = `ctr`),
        /// you receive an error 400 if you try to create/update a recommendation with this set of knobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Output only. Timestamp the Recommendation Model was last updated. E.g. if a Recommendation Model was paused
        /// - this would be the time the pause was initiated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The PageOptimizationConfig for model training. This determines how many panels to optimize for, and which
    /// serving configurations to consider for each panel. The purpose of this model is to optimize which ServingConfig
    /// to show on which panels in way that optimizes the visitors shopping journey.
    /// </summary>
    public class GoogleCloudRetailV2alphaModelPageOptimizationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The type of UserEvent this page optimization is shown for. Each page has an associated event type
        /// - this will be the corresponding event type for the page that the page optimization model is used on.
        /// Supported types: * `add-to-cart`: Products being added to cart. * `detail-page-view`: Products detail page
        /// viewed. * `home-page-view`: Homepage viewed * `category-page-view`: Homepage viewed *
        /// `shopping-cart-page-view`: User viewing a shopping cart. `home-page-view` only allows models with type
        /// `recommended-for-you`. All other page_optimization_event_type allow all Model.types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageOptimizationEventType")]
        public virtual string PageOptimizationEventType { get; set; }

        /// <summary>Required. A list of panel configurations. Limit = 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panels")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaModelPageOptimizationConfigPanel> Panels { get; set; }

        /// <summary>
        /// Optional. How to restrict results across panels e.g. can the same ServingConfig be shown on multiple panels
        /// at once. If unspecified, default to `UNIQUE_MODEL_RESTRICTION`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restriction")]
        public virtual string Restriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A candidate to consider for a given panel. Currently only ServingConfig are valid candidates.</summary>
    public class GoogleCloudRetailV2alphaModelPageOptimizationConfigCandidate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This has to be a valid ServingConfig identifier. For example, for a ServingConfig with full name:
        /// `projects/*/locations/global/catalogs/default_catalog/servingConfigs/my_candidate_config`, this would be
        /// `my_candidate_config`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingConfigId")]
        public virtual string ServingConfigId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual panel with a list of ServingConfigs to consider for it.</summary>
    public class GoogleCloudRetailV2alphaModelPageOptimizationConfigPanel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The candidates to consider on the panel. Limit = 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candidates")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaModelPageOptimizationConfigCandidate> Candidates { get; set; }

        /// <summary>
        /// Required. The default candidate. If the model fails at serving time, we fall back to the default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultCandidate")]
        public virtual GoogleCloudRetailV2alphaModelPageOptimizationConfigCandidate DefaultCandidate { get; set; }

        /// <summary>Optional. The name to display for the panel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an ordered combination of valid serving configs, which can be used for `PAGE_OPTIMIZATION`
    /// recommendations.
    /// </summary>
    public class GoogleCloudRetailV2alphaModelServingConfigList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A set of valid serving configs that may be used for `PAGE_OPTIMIZATION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingConfigIds")]
        public virtual System.Collections.Generic.IList<string> ServingConfigIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output result.</summary>
    public class GoogleCloudRetailV2alphaOutputResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Export result in BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryResult")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaBigQueryOutputResult> BigqueryResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for pausing training of a model.</summary>
    public class GoogleCloudRetailV2alphaPauseModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Predict method.</summary>
    public class GoogleCloudRetailV2alphaPredictRequest : Google.Apis.Requests.IDirectResponseSchema
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
        /// results, the API will return generic (unfiltered) popular products. If you only want results strictly
        /// matching the filters, set `strictFiltering` to True in `PredictRequest.params` to receive empty results
        /// instead. Note that the API will never return items with storageStatus of "EXPIRED" or "DELETED" regardless
        /// of filter choices. If `filterSyntaxV2` is set to true under the `params` field, then attribute-based
        /// expressions are expected instead of the above described tag-based syntax. Examples: * (colors: ANY("Red",
        /// "Blue")) AND NOT (categories: ANY("Phones")) * (availability: ANY("IN_STOCK")) AND (colors: ANY("Red") OR
        /// categories: ANY("Phones"))
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The labels applied to a resource must meet the following requirements: * Each resource can have multiple
        /// labels, up to a maximum of 64. * Each label must be a key-value pair. * Keys have a minimum length of 1
        /// character and a maximum length of 63 characters and cannot be empty. Values can be empty and have a maximum
        /// length of 63 characters. * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. All characters must use UTF-8 encoding, and international characters are allowed. *
        /// The key portion of a label must be unique. However, you can use the same key with multiple resources. * Keys
        /// must start with a lowercase letter or international character. See [Google Cloud
        /// Document](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements) for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Maximum number of results to return. Set this property to the number of prediction results needed. If zero,
        /// the service will choose a reasonable default. The maximum allowed value is 100. Values above 100 will be
        /// coerced to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>This field is not used; leave it unset.</summary>
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
        /// on product category. * `filterSyntaxV2`: Boolean. False by default. If set to true, the `filter` field is
        /// interpreteted according to the new, attribute-based syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>
        /// Required. Context about the user, what they are looking at and what action they took to trigger the predict
        /// request. Note that this user event detail won't be ingested to userEvent logs. Thus, a separate userEvent
        /// write request is required for event logging. Don't set UserEvent.visitor_id or UserInfo.user_id to the same
        /// fixed ID for different users. If you are trying to receive non-personalized recommendations (not
        /// recommended; this can negatively impact model performance), instead set UserEvent.visitor_id to a random
        /// unique ID and leave UserInfo.user_id unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvent")]
        public virtual GoogleCloudRetailV2alphaUserEvent UserEvent { get; set; }

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
    public class GoogleCloudRetailV2alphaPredictResponse : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaPredictResponsePredictionResult> Results { get; set; }

        /// <summary>True if the validateOnly property was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PredictionResult represents the recommendation prediction results.</summary>
    public class GoogleCloudRetailV2alphaPredictResponsePredictionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the recommended product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Additional product metadata / annotations. Possible values: * `product`: JSON representation of the product.
        /// Is set if `returnProduct` is set to true in `PredictRequest.params`. * `score`: Prediction score in double
        /// value. Is set if `returnScore` is set to true in `PredictRequest.params`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price information of a Product.</summary>
    public class GoogleCloudRetailV2alphaPriceInfo : Google.Apis.Requests.IDirectResponseSchema
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
        /// field is an unrecognizable currency code, an INVALID_ARGUMENT error is returned. The Product.Type.VARIANT
        /// Products with the same Product.primary_product_id must share the same currency_code. Otherwise, a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Price of the product without any discount. If zero, by default set to be the price. If set, original_price
        /// should be greater than or equal to price, otherwise an INVALID_ARGUMENT error is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPrice")]
        public virtual System.Nullable<float> OriginalPrice { get; set; }

        /// <summary>
        /// Price of the product. Google Merchant Center property
        /// [price](https://support.google.com/merchants/answer/6324371). Schema.org property
        /// [Offer.price](https://schema.org/price).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual System.Nullable<float> Price { get; set; }

        /// <summary>
        /// The timestamp when the price starts to be effective. This can be set as a future timestamp, and the price is
        /// only used for search after price_effective_time. If so, the original_price must be set and original_price is
        /// used before price_effective_time. Do not set if price is always effective because it will cause additional
        /// latency during search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceEffectiveTime")]
        public virtual object PriceEffectiveTime { get; set; }

        /// <summary>
        /// The timestamp when the price stops to be effective. The price is used for search before price_expire_time.
        /// If this field is set, the original_price must be set and original_price is used after price_expire_time. Do
        /// not set if price is always effective because it will cause additional latency during search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceExpireTime")]
        public virtual object PriceExpireTime { get; set; }

        /// <summary>
        /// Output only. The price range of all the child Product.Type.VARIANT Products grouped together on the
        /// Product.Type.PRIMARY Product. Only populated for Product.Type.PRIMARY Products. Note: This field is
        /// OUTPUT_ONLY for ProductService.GetProduct. Do not set this field in API requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceRange")]
        public virtual GoogleCloudRetailV2alphaPriceInfoPriceRange PriceRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price range of all variant Product having the same Product.primary_product_id.</summary>
    public class GoogleCloudRetailV2alphaPriceInfoPriceRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The inclusive Product.pricing_info.original_price internal of all variant Product having the same
        /// Product.primary_product_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPrice")]
        public virtual GoogleCloudRetailV2alphaInterval OriginalPrice { get; set; }

        /// <summary>
        /// The inclusive Product.pricing_info.price interval of all variant Product having the same
        /// Product.primary_product_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual GoogleCloudRetailV2alphaInterval Price { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product captures all metadata information of items to be recommended or searched.</summary>
    public class GoogleCloudRetailV2alphaProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Highly encouraged. Extra product attributes to be included. For example, for products, this could include
        /// the store name, vendor, style, color, etc. These are very strong signals for recommendation model, thus we
        /// highly recommend providing the attributes here. Features that can take on one of a limited number of
        /// possible values. Two types of features can be set are: Textual features. some examples would be the
        /// brand/maker of a product, or country of a customer. Numerical features. Some examples would be the
        /// height/weight of a product, or age of a customer. For example: `{ "vendor": {"text": ["vendor123",
        /// "vendor456"]}, "lengths_cm": {"numbers":[2.3, 15.4]}, "heights_cm": {"numbers":[8.1, 6.4]} }`. This field
        /// needs to pass all below criteria, otherwise an INVALID_ARGUMENT error is returned: * Max entries count: 200.
        /// * The key must be a UTF-8 encoded string with a length limit of 128 characters. * For indexable attribute,
        /// the key must match the pattern: `a-zA-Z0-9*`. For example, `key0LikeThis` or `KEY_1_LIKE_THIS`. * For text
        /// attributes, at most 400 values are allowed. Empty values are not allowed. Each value must be a non-empty
        /// UTF-8 encoded string with a length limit of 256 characters. * For number attributes, at most 400 values are
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRetailV2alphaCustomAttribute> Attributes { get; set; }

        /// <summary>
        /// The target group associated with a given audience (e.g. male, veterans, car owners, musicians, etc.) of the
        /// product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual GoogleCloudRetailV2alphaAudience Audience { get; set; }

        /// <summary>
        /// The online availability of the Product. Default to Availability.IN_STOCK. Corresponding properties: Google
        /// Merchant Center property [availability](https://support.google.com/merchants/answer/6324448). Schema.org
        /// property [Offer.availability](https://schema.org/availability).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>The available quantity of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableQuantity")]
        public virtual System.Nullable<int> AvailableQuantity { get; set; }

        /// <summary>
        /// The timestamp when this Product becomes available for SearchService.Search. Note that this is only
        /// applicable to Type.PRIMARY and Type.COLLECTION, and ignored for Type.VARIANT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableTime")]
        public virtual object AvailableTime { get; set; }

        /// <summary>
        /// The brands of the product. A maximum of 30 brands are allowed. Each brand must be a UTF-8 encoded string
        /// with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error is returned. Corresponding
        /// properties: Google Merchant Center property [brand](https://support.google.com/merchants/answer/6324351).
        /// Schema.org property [Product.brand](https://schema.org/brand).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brands")]
        public virtual System.Collections.Generic.IList<string> Brands { get; set; }

        /// <summary>
        /// Product categories. This field is repeated for supporting one product belonging to several parallel
        /// categories. Strongly recommended using the full path for better search / recommendation quality. To
        /// represent full path of category, use '&amp;gt;' sign to separate different hierarchies. If '&amp;gt;' is
        /// part of the category name, replace it with other character(s). For example, if a shoes product belongs to
        /// both ["Shoes &amp;amp; Accessories" -&amp;gt; "Shoes"] and ["Sports &amp;amp; Fitness" -&amp;gt; "Athletic
        /// Clothing" -&amp;gt; "Shoes"], it could be represented as: "categories": [ "Shoes &amp;amp; Accessories
        /// &amp;gt; Shoes", "Sports &amp;amp; Fitness &amp;gt; Athletic Clothing &amp;gt; Shoes" ] Must be set for
        /// Type.PRIMARY Product otherwise an INVALID_ARGUMENT error is returned. At most 250 values are allowed per
        /// Product. Empty values are not allowed. Each value must be a UTF-8 encoded string with a length limit of
        /// 5,000 characters. Otherwise, an INVALID_ARGUMENT error is returned. Corresponding properties: Google
        /// Merchant Center property google_product_category. Schema.org property [Product.category]
        /// (https://schema.org/category). [mc_google_product_category]:
        /// https://support.google.com/merchants/answer/6324436
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// The id of the collection members when type is Type.COLLECTION. Non-existent product ids are allowed. The
        /// type of the members must be either Type.PRIMARY or Type.VARIANT otherwise an INVALID_ARGUMENT error is
        /// thrown. Should not set it for other types. A maximum of 1000 values are allowed. Otherwise, an
        /// INVALID_ARGUMENT error is return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionMemberIds")]
        public virtual System.Collections.Generic.IList<string> CollectionMemberIds { get; set; }

        /// <summary>
        /// The color of the product. Corresponding properties: Google Merchant Center property
        /// [color](https://support.google.com/merchants/answer/6324487). Schema.org property
        /// [Product.color](https://schema.org/color).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorInfo")]
        public virtual GoogleCloudRetailV2alphaColorInfo ColorInfo { get; set; }

        /// <summary>
        /// The condition of the product. Strongly encouraged to use the standard values: "new", "refurbished", "used".
        /// A maximum of 1 value is allowed per Product. Each value must be a UTF-8 encoded string with a length limit
        /// of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned. Corresponding properties: Google
        /// Merchant Center property [condition](https://support.google.com/merchants/answer/6324469). Schema.org
        /// property [Offer.itemCondition](https://schema.org/itemCondition).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<string> Conditions { get; set; }

        /// <summary>
        /// Product description. This field must be a UTF-8 encoded string with a length limit of 5,000 characters.
        /// Otherwise, an INVALID_ARGUMENT error is returned. Corresponding properties: Google Merchant Center property
        /// [description](https://support.google.com/merchants/answer/6324468). Schema.org property
        /// [Product.description](https://schema.org/description).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The timestamp when this product becomes unavailable for SearchService.Search. Note that this is only
        /// applicable to Type.PRIMARY and Type.COLLECTION, and ignored for Type.VARIANT. In general, we suggest the
        /// users to delete the stale products explicitly, instead of using this field to determine staleness. If it is
        /// set, the Product is not available for SearchService.Search after expire_time. However, the product can still
        /// be retrieved by ProductService.GetProduct and ProductService.ListProducts. expire_time must be later than
        /// available_time and publish_time, otherwise an INVALID_ARGUMENT error is thrown. Corresponding properties:
        /// Google Merchant Center property [expiration_date](https://support.google.com/merchants/answer/6324499).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Fulfillment information, such as the store IDs for in-store pickup or region IDs for different shipping
        /// methods. All the elements must have distinct FulfillmentInfo.type. Otherwise, an INVALID_ARGUMENT error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentInfo")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaFulfillmentInfo> FulfillmentInfo { get; set; }

        /// <summary>
        /// The Global Trade Item Number (GTIN) of the product. This field must be a UTF-8 encoded string with a length
        /// limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned. This field must be a Unigram.
        /// Otherwise, an INVALID_ARGUMENT error is returned. Corresponding properties: Google Merchant Center property
        /// [gtin](https://support.google.com/merchants/answer/6324461). Schema.org property
        /// [Product.isbn](https://schema.org/isbn), [Product.gtin8](https://schema.org/gtin8),
        /// [Product.gtin12](https://schema.org/gtin12), [Product.gtin13](https://schema.org/gtin13), or
        /// [Product.gtin14](https://schema.org/gtin14). If the value is not a valid GTIN, an INVALID_ARGUMENT error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; }

        /// <summary>
        /// Immutable. Product identifier, which is the final component of name. For example, this field is "id_1", if
        /// name is `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/id_1`. This
        /// field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT
        /// error is returned. Corresponding properties: Google Merchant Center property
        /// [id](https://support.google.com/merchants/answer/6324405). Schema.org property
        /// [Product.sku](https://schema.org/sku).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Product images for the product. We highly recommend putting the main image first. A maximum of 300 images
        /// are allowed. Corresponding properties: Google Merchant Center property
        /// [image_link](https://support.google.com/merchants/answer/6324350). Schema.org property
        /// [Product.image](https://schema.org/image).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaImage> Images { get; set; }

        /// <summary>
        /// Language of the title/description and other string attributes. Use language tags defined by [BCP
        /// 47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt). For product prediction, this field is ignored and the
        /// model automatically detects the text language. The Product can include text in different languages, but
        /// duplicating Products to provide text in multiple languages can result in degraded model performance. For
        /// product search this field is in use. It defaults to "en-US" if unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Output only. A list of local inventories specific to different places. This is only available for users who
        /// have Retail Search enabled, and it can be managed by ProductService.AddLocalInventories and
        /// ProductService.RemoveLocalInventories APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localInventories")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaLocalInventory> LocalInventories { get; set; }

        /// <summary>
        /// The material of the product. For example, "leather", "wooden". A maximum of 20 values are allowed. Each
        /// value must be a UTF-8 encoded string with a length limit of 200 characters. Otherwise, an INVALID_ARGUMENT
        /// error is returned. Corresponding properties: Google Merchant Center property
        /// [material](https://support.google.com/merchants/answer/6324410). Schema.org property
        /// [Product.material](https://schema.org/material).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<string> Materials { get; set; }

        /// <summary>
        /// Immutable. Full resource name of the product, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/product_id`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The pattern or graphic print of the product. For example, "striped", "polka dot", "paisley". A maximum of 20
        /// values are allowed per Product. Each value must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned. Corresponding properties: Google Merchant
        /// Center property [pattern](https://support.google.com/merchants/answer/6324483). Schema.org property
        /// [Product.pattern](https://schema.org/pattern).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patterns")]
        public virtual System.Collections.Generic.IList<string> Patterns { get; set; }

        /// <summary>
        /// Product price and cost information. Corresponding properties: Google Merchant Center property
        /// [price](https://support.google.com/merchants/answer/6324371).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceInfo")]
        public virtual GoogleCloudRetailV2alphaPriceInfo PriceInfo { get; set; }

        /// <summary>
        /// Variant group identifier. Must be an id, with the same parent branch with this product. Otherwise, an error
        /// is thrown. For Type.PRIMARY Products, this field can only be empty or set to the same value as id. For
        /// VARIANT Products, this field cannot be empty. A maximum of 2,000 products are allowed to share the same
        /// Type.PRIMARY Product. Otherwise, an INVALID_ARGUMENT error is returned. Corresponding properties: Google
        /// Merchant Center property [item_group_id](https://support.google.com/merchants/answer/6324507). Schema.org
        /// property [Product.inProductGroupWithID](https://schema.org/inProductGroupWithID).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryProductId")]
        public virtual string PrimaryProductId { get; set; }

        /// <summary>
        /// The promotions applied to the product. A maximum of 10 values are allowed per Product. Only
        /// Promotion.promotion_id will be used, other fields will be ignored if set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaPromotion> Promotions { get; set; }

        /// <summary>
        /// The timestamp when the product is published by the retailer for the first time, which indicates the
        /// freshness of the products. Note that this field is different from available_time, given it purely describes
        /// product freshness regardless of when it is available on search and recommendation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; }

        /// <summary>The rating of this product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rating")]
        public virtual GoogleCloudRetailV2alphaRating Rating { get; set; }

        /// <summary>
        /// Indicates which fields in the Products are returned in SearchResponse. Supported fields for all types: *
        /// audience * availability * brands * color_info * conditions * gtin * materials * name * patterns * price_info
        /// * rating * sizes * title * uri Supported fields only for Type.PRIMARY and Type.COLLECTION: * categories *
        /// description * images Supported fields only for Type.VARIANT: * Only the first image in images To mark
        /// attributes as retrievable, include paths of the form "attributes.key" where "key" is the key of a custom
        /// attribute, as specified in attributes. For Type.PRIMARY and Type.COLLECTION, the following fields are always
        /// returned in SearchResponse by default: * name For Type.VARIANT, the following fields are always returned in
        /// by default: * name * color_info The maximum number of paths is 30. Otherwise, an INVALID_ARGUMENT error is
        /// returned. Note: Returning more fields in SearchResponse can increase response payload size and serving
        /// latency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievableFields")]
        public virtual object RetrievableFields { get; set; }

        /// <summary>
        /// The size of the product. To represent different size systems or size types, consider using this format:
        /// [[[size_system:]size_type:]size_value]. For example, in "US:MENS:M", "US" represents size system; "MENS"
        /// represents size type; "M" represents size value. In "GIRLS:27", size system is empty; "GIRLS" represents
        /// size type; "27" represents size value. In "32 inches", both size system and size type are empty, while size
        /// value is "32 inches". A maximum of 20 values are allowed per Product. Each value must be a UTF-8 encoded
        /// string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// Corresponding properties: Google Merchant Center property
        /// [size](https://support.google.com/merchants/answer/6324492),
        /// [size_type](https://support.google.com/merchants/answer/6324497), and
        /// [size_system](https://support.google.com/merchants/answer/6324502). Schema.org property
        /// [Product.size](https://schema.org/size).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizes")]
        public virtual System.Collections.Generic.IList<string> Sizes { get; set; }

        /// <summary>
        /// Custom tags associated with the product. At most 250 values are allowed per Product. This value must be a
        /// UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error is
        /// returned. This tag can be used for filtering recommendation results by passing the tag as part of the
        /// PredictRequest.filter. Corresponding properties: Google Merchant Center property
        /// [custom_label_0–4](https://support.google.com/merchants/answer/6324473).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Required. Product title. This field must be a UTF-8 encoded string with a length limit of 1,000 characters.
        /// Otherwise, an INVALID_ARGUMENT error is returned. Corresponding properties: Google Merchant Center property
        /// [title](https://support.google.com/merchants/answer/6324415). Schema.org property
        /// [Product.name](https://schema.org/name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Input only. The TTL (time to live) of the product. Note that this is only applicable to Type.PRIMARY and
        /// Type.COLLECTION, and ignored for Type.VARIANT. In general, we suggest the users to delete the stale products
        /// explicitly, instead of using this field to determine staleness. If it is set, it must be a non-negative
        /// value, and expire_time is set as current timestamp plus ttl. The derived expire_time is returned in the
        /// output and ttl is left blank when retrieving the Product. If it is set, the product is not available for
        /// SearchService.Search after current timestamp plus ttl. However, the product can still be retrieved by
        /// ProductService.GetProduct and ProductService.ListProducts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>
        /// Immutable. The type of the product. Default to Catalog.product_level_config.ingestion_product_type if unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Canonical URL directly linking to the product detail page. It is strongly recommended to provide a valid uri
        /// for the product, otherwise the service performance could be significantly degraded. This field must be a
        /// UTF-8 encoded string with a length limit of 5,000 characters. Otherwise, an INVALID_ARGUMENT error is
        /// returned. Corresponding properties: Google Merchant Center property
        /// [link](https://support.google.com/merchants/answer/6324416). Schema.org property
        /// [Offer.url](https://schema.org/url).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// Output only. Product variants grouped together on primary product which share similar product attributes.
        /// It's automatically grouped by primary_product_id for all the product variants. Only populated for
        /// Type.PRIMARY Products. Note: This field is OUTPUT_ONLY for ProductService.GetProduct. Do not set this field
        /// in API requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaProduct> Variants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed product information associated with a user event.</summary>
    public class GoogleCloudRetailV2alphaProductDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Product information. Required field(s): * Product.id Optional override field(s): *
        /// Product.price_info If any supported optional fields are provided, we will treat them as a full override when
        /// looking up product information from the catalog. Thus, it is important to ensure that the overriding fields
        /// are accurate and complete. All other product fields are ignored and instead populated via catalog lookup
        /// after event ingestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudRetailV2alphaProduct Product { get; set; }

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
    public class GoogleCloudRetailV2alphaProductInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of products to update/create. Each product must have a valid Product.id. Recommended max of
        /// 100 items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaProduct> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input config source for products.</summary>
    public class GoogleCloudRetailV2alphaProductInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQuerySource")]
        public virtual GoogleCloudRetailV2alphaBigQuerySource BigQuerySource { get; set; }

        /// <summary>Google Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudRetailV2alphaGcsSource GcsSource { get; set; }

        /// <summary>The Inline source for the input content for products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productInlineSource")]
        public virtual GoogleCloudRetailV2alphaProductInlineSource ProductInlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures what level the product should be uploaded with regards to how users will be send events and how
    /// predictions will be made.
    /// </summary>
    public class GoogleCloudRetailV2alphaProductLevelConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of Products allowed to be ingested into the catalog. Acceptable values are: * `primary` (default):
        /// You can ingest Products of all types. When ingesting a Product, its type will default to
        /// Product.Type.PRIMARY if unset. * `variant` (incompatible with Retail Search): You can only ingest
        /// Product.Type.VARIANT Products. This means Product.primary_product_id cannot be empty. If this field is set
        /// to an invalid value other than these, an INVALID_ARGUMENT error is returned. If this field is `variant` and
        /// merchant_center_product_id_field is `itemGroupId`, an INVALID_ARGUMENT error is returned. See [Product
        /// levels](https://cloud.google.com/retail/docs/catalog#product-levels) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestionProductType")]
        public virtual string IngestionProductType { get; set; }

        /// <summary>
        /// Which field of [Merchant Center Product](/bigquery-transfer/docs/merchant-center-products-schema) should be
        /// imported as Product.id. Acceptable values are: * `offerId` (default): Import `offerId` as the product ID. *
        /// `itemGroupId`: Import `itemGroupId` as the product ID. Notice that Retail API will choose one item from the
        /// ones with the same `itemGroupId`, and use it to represent the item group. If this field is set to an invalid
        /// value other than these, an INVALID_ARGUMENT error is returned. If this field is `itemGroupId` and
        /// ingestion_product_type is `variant`, an INVALID_ARGUMENT error is returned. See [Product
        /// levels](https://cloud.google.com/retail/docs/catalog#product-levels) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantCenterProductIdField")]
        public virtual string MerchantCenterProductIdField { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Promotion specification.</summary>
    public class GoogleCloudRetailV2alphaPromotion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Promotion identifier, which is the final component of name. For example, this field is "free_gift", if name
        /// is `projects/*/locations/global/catalogs/default_catalog/promotions/free_gift`. The value must be a UTF-8
        /// encoded string with a length limit of 128 characters, and match the pattern: `a-zA-Z*`. For example,
        /// id0LikeThis or ID_1_LIKE_THIS. Otherwise, an INVALID_ARGUMENT error is returned. Corresponds to Google
        /// Merchant Center property [promotion_id](https://support.google.com/merchants/answer/7050148).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionId")]
        public virtual string PromotionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transaction represents the entire purchase transaction.</summary>
    public class GoogleCloudRetailV2alphaPurchaseTransaction : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudRetailV2alphaPurgeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the PurgeProducts operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRetailV2alphaPurgeProductsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were deleted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PurgeProducts method.</summary>
    public class GoogleCloudRetailV2alphaPurgeProductsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The filter string to specify the products to be deleted with a length limit of 5,000 characters.
        /// Empty string filter is not allowed. "*" implies delete all items in a branch. The eligible fields for
        /// filtering are: * `availability`: Double quoted Product.availability string. * `create_time` : in ISO 8601
        /// "zulu" format. Supported syntax: * Comparators ("&amp;gt;", "&amp;lt;", "&amp;gt;=", "&amp;lt;=", "=").
        /// Examples: * create_time &amp;lt;= "2015-02-13T17:05:46Z" * availability = "IN_STOCK" * Conjunctions ("AND")
        /// Examples: * create_time &amp;lt;= "2015-02-13T17:05:46Z" AND availability = "PREORDER" * Disjunctions ("OR")
        /// Examples: * create_time &amp;lt;= "2015-02-13T17:05:46Z" OR availability = "IN_STOCK" * Can support nested
        /// queries. Examples: * (create_time &amp;lt;= "2015-02-13T17:05:46Z" AND availability = "PREORDER") OR
        /// (create_time &amp;gt;= "2015-02-14T13:03:32Z" AND availability = "IN_STOCK") * Filter Limits: * Filter
        /// should not contain more than 6 conditions. * Max nesting depth should not exceed 2 levels. Examples queries:
        /// * Delete back order products created before a timestamp. create_time &amp;lt;= "2015-02-13T17:05:46Z" OR
        /// availability = "BACKORDER"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Actually perform the purge. If `force` is set to false, the method will return the expected purge count
        /// without deleting any products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the PurgeProductsRequest. If the long running operation is successfully done, then this message is
    /// returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudRetailV2alphaPurgeProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of products purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeCount")]
        public virtual System.Nullable<long> PurgeCount { get; set; }

        /// <summary>
        /// A sample of the product names that will be deleted. Only populated if `force` is set to false. A max of 100
        /// names will be returned and the names are chosen at random.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeSample")]
        public virtual System.Collections.Generic.IList<string> PurgeSample { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PurgeUserEvents method.</summary>
    public class GoogleCloudRetailV2alphaPurgeUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudRetailV2alphaPurgeUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of events purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgedEventsCount")]
        public virtual System.Nullable<long> PurgedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The rating of a Product.</summary>
    public class GoogleCloudRetailV2alphaRating : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The average rating of the Product. The rating is scaled at 1-5. Otherwise, an INVALID_ARGUMENT error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageRating")]
        public virtual System.Nullable<float> AverageRating { get; set; }

        /// <summary>
        /// The total number of ratings. This value is independent of the value of rating_histogram. This value must be
        /// nonnegative. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratingCount")]
        public virtual System.Nullable<int> RatingCount { get; set; }

        /// <summary>
        /// List of rating counts per rating value (index = rating - 1). The list is empty if there is no rating. If the
        /// list is non-empty, its size is always 5. Otherwise, an INVALID_ARGUMENT error is returned. For example, [41,
        /// 14, 13, 47, 303]. It means that the Product got 41 ratings with 1 star, 14 ratings with 2 star, and so on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratingHistogram")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RatingHistogram { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `RejoinUserEvents` method.</summary>
    public class GoogleCloudRetailV2alphaRejoinUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RejoinUserEvents method.</summary>
    public class GoogleCloudRetailV2alphaRejoinUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of the user event rejoin to define the scope and range of the user events to be rejoined with the
        /// latest product catalog. Defaults to `USER_EVENT_REJOIN_SCOPE_UNSPECIFIED` if this field is not set, or set
        /// to an invalid integer value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEventRejoinScope")]
        public virtual string UserEventRejoinScope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `RejoinUserEvents` method.</summary>
    public class GoogleCloudRetailV2alphaRejoinUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest product catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for CatalogService.RemoveCatalogAttribute method.</summary>
    public class GoogleCloudRetailV2alphaRemoveCatalogAttributeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attribute name key of the CatalogAttribute to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for RemoveControl method.</summary>
    public class GoogleCloudRetailV2alphaRemoveControlRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The id of the control to apply. Assumed to be in the same catalog as the serving config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlId")]
        public virtual string ControlId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the RemoveFulfillmentPlaces operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.RemoveFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2alphaRemoveFulfillmentPlacesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ProductService.RemoveFulfillmentPlaces method.</summary>
    public class GoogleCloudRetailV2alphaRemoveFulfillmentPlacesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, and the Product is not found, the fulfillment information will still be processed and
        /// retained for at most 1 day and processed once the Product is created. If set to false, a NOT_FOUND error is
        /// returned if the Product is not found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Required. The IDs for this type, such as the store IDs for "pickup-in-store" or the region IDs for
        /// "same-day-delivery", to be removed for this type. At least 1 value is required, and a maximum of 2000 values
        /// are allowed. Each value must be a string with a length limit of 10 characters, matching the pattern
        /// `[a-zA-Z0-9_-]+`, such as "store1" or "REGION-2". Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeIds")]
        public virtual System.Collections.Generic.IList<string> PlaceIds { get; set; }

        /// <summary>
        /// The time when the fulfillment updates are issued, used to prevent out-of-order updates on fulfillment
        /// information. If not provided, the internal system time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeTime")]
        public virtual object RemoveTime { get; set; }

        /// <summary>
        /// Required. The fulfillment type, including commonly used types (such as pickup in store and same day
        /// delivery), and custom types. Supported values: * "pickup-in-store" * "ship-to-store" * "same-day-delivery" *
        /// "next-day-delivery" * "custom-type-1" * "custom-type-2" * "custom-type-3" * "custom-type-4" *
        /// "custom-type-5" If this field is set to an invalid value other than these, an INVALID_ARGUMENT error is
        /// returned. This field directly corresponds to Product.fulfillment_info.type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the RemoveFulfillmentPlacesRequest. Currently empty because there is no meaningful response
    /// populated from the ProductService.RemoveFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2alphaRemoveFulfillmentPlacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the RemoveLocalInventories operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.RemoveLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2alphaRemoveLocalInventoriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ProductService.RemoveLocalInventories method.</summary>
    public class GoogleCloudRetailV2alphaRemoveLocalInventoriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, and the Product is not found, the local inventory removal request will still be processed
        /// and retained for at most 1 day and processed once the Product is created. If set to false, a NOT_FOUND error
        /// is returned if the Product is not found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Required. A list of place IDs to have their inventory deleted. At most 3000 place IDs are allowed per
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeIds")]
        public virtual System.Collections.Generic.IList<string> PlaceIds { get; set; }

        /// <summary>
        /// The time when the inventory deletions are issued. Used to prevent out-of-order updates and deletions on
        /// local inventory fields. If not provided, the internal system time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeTime")]
        public virtual object RemoveTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ProductService.RemoveLocalInventories API. Currently empty because there is no meaningful
    /// response populated from the ProductService.RemoveLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2alphaRemoveLocalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for CatalogService.ReplaceCatalogAttribute method.</summary>
    public class GoogleCloudRetailV2alphaReplaceCatalogAttributeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The updated CatalogAttribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogAttribute")]
        public virtual GoogleCloudRetailV2alphaCatalogAttribute CatalogAttribute { get; set; }

        /// <summary>
        /// Indicates which fields in the provided CatalogAttribute to update. The following are NOT supported: *
        /// CatalogAttribute.key If not set, all supported fields are updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for resuming training of a model.</summary>
    public class GoogleCloudRetailV2alphaResumeModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rule is a condition-action pair * A condition defines when a rule is to be triggered. * An action specifies
    /// what occurs on that trigger. Currently rules only work for controls with SOLUTION_TYPE_SEARCH.
    /// </summary>
    public class GoogleCloudRetailV2alphaRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boost action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostAction")]
        public virtual GoogleCloudRetailV2alphaRuleBoostAction BoostAction { get; set; }

        /// <summary>
        /// Required. The condition that triggers the rule. If the condition is empty, the rule will always apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleCloudRetailV2alphaCondition Condition { get; set; }

        /// <summary>Prevents term from being associated with other terms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doNotAssociateAction")]
        public virtual GoogleCloudRetailV2alphaRuleDoNotAssociateAction DoNotAssociateAction { get; set; }

        /// <summary>Filters results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterAction")]
        public virtual GoogleCloudRetailV2alphaRuleFilterAction FilterAction { get; set; }

        /// <summary>Ignores specific terms from query during search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreAction")]
        public virtual GoogleCloudRetailV2alphaRuleIgnoreAction IgnoreAction { get; set; }

        /// <summary>
        /// Treats specific term as a synonym with a group of terms. Group of terms will not be treated as synonyms with
        /// the specific term.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onewaySynonymsAction")]
        public virtual GoogleCloudRetailV2alphaRuleOnewaySynonymsAction OnewaySynonymsAction { get; set; }

        /// <summary>Redirects a shopper to a specific page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectAction")]
        public virtual GoogleCloudRetailV2alphaRuleRedirectAction RedirectAction { get; set; }

        /// <summary>Replaces specific terms in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacementAction")]
        public virtual GoogleCloudRetailV2alphaRuleReplacementAction ReplacementAction { get; set; }

        /// <summary>Treats a set of terms as synonyms of one another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twowaySynonymsAction")]
        public virtual GoogleCloudRetailV2alphaRuleTwowaySynonymsAction TwowaySynonymsAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A boost action to apply to results matching condition specified above.</summary>
    public class GoogleCloudRetailV2alphaRuleBoostAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Strength of the condition boost, which must be in [-1, 1]. Negative boost means demotion. Default is 0.0.
        /// Setting to 1.0 gives the item a big promotion. However, it does not necessarily mean that the boosted item
        /// will be the top result at all times, nor that other items will be excluded. Results could still be shown
        /// even when none of them matches the condition. And results that are significantly more relevant to the search
        /// query can still trump your heavily favored but irrelevant items. Setting to -1.0 gives the item a big
        /// demotion. However, results that are deeply relevant might still be shown. The item will have an upstream
        /// battle to get a fairly high ranking, but it is not blocked out completely. Setting to 0.0 means no boost
        /// applied. The boosting condition is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boost")]
        public virtual System.Nullable<float> Boost { get; set; }

        /// <summary>
        /// The filter can have a max size of 5000 characters. An expression which specifies which products to apply an
        /// action to. The syntax and supported fields are the same as a filter expression. See SearchRequest.filter for
        /// detail syntax and limitations. Examples: * To boost products with product ID "product_1" or "product_2", and
        /// color "Red" or "Blue": *(id: ANY("product_1", "product_2")) * *AND * *(colorFamilies: ANY("Red", "Blue")) *
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productsFilter")]
        public virtual string ProductsFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Prevents `query_term` from being associated with specified terms during search. Example: Don't associate "gShoe"
    /// and "cheap".
    /// </summary>
    public class GoogleCloudRetailV2alphaRuleDoNotAssociateAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cannot contain duplicates or the query term. Can specify up to 100 terms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doNotAssociateTerms")]
        public virtual System.Collections.Generic.IList<string> DoNotAssociateTerms { get; set; }

        /// <summary>
        /// Terms from the search query. Will not consider do_not_associate_terms for search if in search query. Can
        /// specify up to 100 terms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryTerms")]
        public virtual System.Collections.Generic.IList<string> QueryTerms { get; set; }

        /// <summary>Will be [deprecated = true] post migration;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terms")]
        public virtual System.Collections.Generic.IList<string> Terms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// * Rule Condition: - No Condition.query_terms provided is a global match. - 1 or more Condition.query_terms
    /// provided are combined with OR operator. * Action Input: The request query and filter that are applied to the
    /// retrieved products, in addition to any filters already provided with the SearchRequest. The AND operator is used
    /// to combine the query's existing filters with the filter rule(s). NOTE: May result in 0 results when filters
    /// conflict. * Action Result: Filters the returned objects to be ONLY those that passed the filter.
    /// </summary>
    public class GoogleCloudRetailV2alphaRuleFilterAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A filter to apply on the matching condition results. Supported features: * filter must be set. * Filter
        /// syntax is identical to SearchRequest.filter. See more details at the Retail Search [user
        /// guide](/retail/search/docs/filter-and-order#filter). * To filter products with product ID "product_1" or
        /// "product_2", and color "Red" or "Blue": *(id: ANY("product_1", "product_2")) * *AND * *(colorFamilies:
        /// ANY("Red", "Blue")) *
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Prevents a term in the query from being used in search. Example: Don't search for "shoddy".</summary>
    public class GoogleCloudRetailV2alphaRuleIgnoreAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Terms to ignore in the search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreTerms")]
        public virtual System.Collections.Generic.IList<string> IgnoreTerms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maps a set of terms to a set of synonyms. Set of synonyms will be treated as synonyms of each query term only.
    /// `query_terms` will not be treated as synonyms of each other. Example: "sneakers" will use a synonym of "shoes".
    /// "shoes" will not use a synonym of "sneakers".
    /// </summary>
    public class GoogleCloudRetailV2alphaRuleOnewaySynonymsAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Will be [deprecated = true] post migration;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onewayTerms")]
        public virtual System.Collections.Generic.IList<string> OnewayTerms { get; set; }

        /// <summary>
        /// Terms from the search query. Will treat synonyms as their synonyms. Not themselves synonyms of the synonyms.
        /// Can specify up to 100 terms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryTerms")]
        public virtual System.Collections.Generic.IList<string> QueryTerms { get; set; }

        /// <summary>Defines a set of synonyms. Cannot contain duplicates. Can specify up to 100 synonyms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<string> Synonyms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Redirects a shopper to a specific page. * Rule Condition: - Must specify Condition.query_terms. * Action Input:
    /// Request Query * Action Result: Redirects shopper to provided uri.
    /// </summary>
    public class GoogleCloudRetailV2alphaRuleRedirectAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL must have length equal or less than 2000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replaces a term in the query. Multiple replacement candidates can be specified. All `query_terms` will be
    /// replaced with the replacement term. Example: Replace "gShoe" with "google shoe".
    /// </summary>
    public class GoogleCloudRetailV2alphaRuleReplacementAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Terms from the search query. Will be replaced by replacement term. Can specify up to 100 terms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryTerms")]
        public virtual System.Collections.Generic.IList<string> QueryTerms { get; set; }

        /// <summary>Term that will be used for replacement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacementTerm")]
        public virtual string ReplacementTerm { get; set; }

        /// <summary>Will be [deprecated = true] post migration;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("term")]
        public virtual string Term { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates a set of terms that will be treated as synonyms of each other. Example: synonyms of "sneakers" and
    /// "shoes". * "sneakers" will use a synonym of "shoes". * "shoes" will use a synonym of "sneakers".
    /// </summary>
    public class GoogleCloudRetailV2alphaRuleTwowaySynonymsAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defines a set of synonyms. Can specify up to 100 synonyms. Must specify at least 2 synonyms.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<string> Synonyms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchService.Search method.</summary>
    public class GoogleCloudRetailV2alphaSearchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Boost specification to boost certain products. See more details at this [user
        /// guide](https://cloud.google.com/retail/docs/boosting). Notice that if both ServingConfig.boost_control_ids
        /// and SearchRequest.boost_spec are set, the boost conditions from both places are evaluated. If a search
        /// request matches multiple boost conditions, the final boost score is equal to the sum of the boost scores
        /// from all matched boost conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestBoostSpec BoostSpec { get; set; }

        /// <summary>
        /// The branch resource name, such as `projects/*/locations/global/catalogs/default_catalog/branches/0`. Use
        /// "default_branch" as the branch ID or leave this field empty, to search products under the default branch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branch")]
        public virtual string Branch { get; set; }

        /// <summary>
        /// The default filter that is applied when a user performs a search without checking any filters on the search
        /// page. The filter applied to every search request when quality improvement such as query expansion is needed.
        /// For example, if a query does not have enough results, an expanded query with SearchRequest.canonical_filter
        /// will be returned as a supplement of the original query. This field is strongly recommended to achieve high
        /// search quality. See SearchRequest.filter for more details about filter syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalFilter")]
        public virtual string CanonicalFilter { get; set; }

        /// <summary>
        /// Deprecated. Refer to https://cloud.google.com/retail/docs/configs#dynamic to enable dynamic facets. Do not
        /// set this field. The specification for dynamically generated facets. Notice that only textual facets can be
        /// dynamically generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicFacetSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestDynamicFacetSpec DynamicFacetSpec { get; set; }

        /// <summary>
        /// Facet specifications for faceted search. If empty, no facets are returned. A maximum of 100 values are
        /// allowed. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaSearchRequestFacetSpec> FacetSpecs { get; set; }

        /// <summary>
        /// The filter syntax consists of an expression language for constructing a predicate from one or more fields of
        /// the products being filtered. Filter expression is case-sensitive. See more details at this [user
        /// guide](https://cloud.google.com/retail/docs/filter-and-order#filter). If this field is unrecognizable, an
        /// INVALID_ARGUMENT is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The labels applied to a resource must meet the following requirements: * Each resource can have multiple
        /// labels, up to a maximum of 64. * Each label must be a key-value pair. * Keys have a minimum length of 1
        /// character and a maximum length of 63 characters and cannot be empty. Values can be empty and have a maximum
        /// length of 63 characters. * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. All characters must use UTF-8 encoding, and international characters are allowed. *
        /// The key portion of a label must be unique. However, you can use the same key with multiple resources. * Keys
        /// must start with a lowercase letter or international character. See [Google Cloud
        /// Document](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements) for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// A 0-indexed integer that specifies the current offset (that is, starting result location, amongst the
        /// Products deemed by the API as relevant) in search results. This field is only considered if page_token is
        /// unset. If this field is negative, an INVALID_ARGUMENT is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The order in which products are returned. Products can be ordered by a field in an Product object. Leave it
        /// unset if ordered by relevance. OrderBy expression is case-sensitive. See more details at this [user
        /// guide](https://cloud.google.com/retail/docs/filter-and-order#order). If this field is unrecognizable, an
        /// INVALID_ARGUMENT is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// The categories associated with a category page. Required for category navigation queries to achieve good
        /// search quality. The format should be the same as UserEvent.page_categories; To represent full path of
        /// category, use '&amp;gt;' sign to separate different hierarchies. If '&amp;gt;' is part of the category name,
        /// replace it with other character(s). Category pages include special pages such as sales or promotions. For
        /// instance, a special sale page may have the category hierarchy: "pageCategories" : ["Sales &amp;gt; 2017
        /// Black Friday Deals"].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageCategories")]
        public virtual System.Collections.Generic.IList<string> PageCategories { get; set; }

        /// <summary>
        /// Maximum number of Products to return. If unspecified, defaults to a reasonable value. The maximum allowed
        /// value is 120. Values above 120 will be coerced to 120. If this field is negative, an INVALID_ARGUMENT is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token SearchResponse.next_page_token, received from a previous SearchService.Search call. Provide
        /// this to retrieve the subsequent page. When paginating, all other parameters provided to SearchService.Search
        /// must match the call that provided the page token. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// The specification for personalization. Notice that if both ServingConfig.personalization_spec and
        /// SearchRequest.personalization_spec are set. SearchRequest.personalization_spec will override
        /// ServingConfig.personalization_spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalizationSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestPersonalizationSpec PersonalizationSpec { get; set; }

        /// <summary>
        /// Raw search query. If this field is empty, the request is considered a category browsing request and returned
        /// results are based on filter and page_categories.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The query expansion specification that specifies the conditions under which query expansion will occur. See
        /// more details at this [user guide](https://cloud.google.com/retail/docs/result-size#query_expansion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryExpansionSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestQueryExpansionSpec QueryExpansionSpec { get; set; }

        /// <summary>
        /// The relevance threshold of the search results. Defaults to RelevanceThreshold.HIGH, which means only the
        /// most relevant results are shown, and the least number of results are returned. See more details at this
        /// [user guide](https://cloud.google.com/retail/docs/result-size#relevance_thresholding).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevanceThreshold")]
        public virtual string RelevanceThreshold { get; set; }

        /// <summary>
        /// The search mode of the search request. If not specified, a single search request triggers both product
        /// search and faceted search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchMode")]
        public virtual string SearchMode { get; set; }

        /// <summary>
        /// The spell correction specification that specifies the mode under which spell correction will take effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spellCorrectionSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestSpellCorrectionSpec SpellCorrectionSpec { get; set; }

        /// <summary>User information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudRetailV2alphaUserInfo UserInfo { get; set; }

        /// <summary>
        /// The keys to fetch and rollup the matching variant Products attributes, FulfillmentInfo or LocalInventorys
        /// attributes. The attributes from all the matching variant Products or LocalInventorys are merged and
        /// de-duplicated. Notice that rollup attributes will lead to extra query latency. Maximum number of keys is 30.
        /// For FulfillmentInfo, a fulfillment type and a fulfillment ID must be provided in the format of
        /// "fulfillmentType.fulfillmentId". E.g., in "pickupInStore.store123", "pickupInStore" is fulfillment type and
        /// "store123" is the store ID. Supported keys are: * colorFamilies * price * originalPrice * discount *
        /// variantId * inventory(place_id,price) * inventory(place_id,original_price) *
        /// inventory(place_id,attributes.key), where key is any key in the Product.local_inventories.attributes map. *
        /// attributes.key, where key is any key in the Product.attributes map. * pickupInStore.id, where id is any
        /// FulfillmentInfo.place_ids for FulfillmentInfo.type "pickup-in-store". * shipToStore.id, where id is any
        /// FulfillmentInfo.place_ids for FulfillmentInfo.type "ship-to-store". * sameDayDelivery.id, where id is any
        /// FulfillmentInfo.place_ids for FulfillmentInfo.type "same-day-delivery". * nextDayDelivery.id, where id is
        /// any FulfillmentInfo.place_ids for FulfillmentInfo.type "next-day-delivery". * customFulfillment1.id, where
        /// id is any FulfillmentInfo.place_ids for FulfillmentInfo.type "custom-type-1". * customFulfillment2.id, where
        /// id is any FulfillmentInfo.place_ids for FulfillmentInfo.type "custom-type-2". * customFulfillment3.id, where
        /// id is any FulfillmentInfo.place_ids for FulfillmentInfo.type "custom-type-3". * customFulfillment4.id, where
        /// id is any FulfillmentInfo.place_ids for FulfillmentInfo.type "custom-type-4". * customFulfillment5.id, where
        /// id is any FulfillmentInfo.place_ids for FulfillmentInfo.type "custom-type-5". If this field is set to an
        /// invalid value other than these, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantRollupKeys")]
        public virtual System.Collections.Generic.IList<string> VariantRollupKeys { get; set; }

        /// <summary>
        /// Required. A unique identifier for tracking visitors. For example, this could be implemented with an HTTP
        /// cookie, which should be able to uniquely identify a visitor on a single device. This unique identifier
        /// should not change if the visitor logs in or out of the website. This should be the same identifier as
        /// UserEvent.visitor_id. The field must be a UTF-8 encoded string with a length limit of 128 characters.
        /// Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Boost specification to boost certain items.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestBoostSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Condition boost specifications. If a product matches multiple conditions in the specifictions, boost scores
        /// from these specifications are all applied and combined in a non-linear way. Maximum number of specifications
        /// is 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionBoostSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaSearchRequestBoostSpecConditionBoostSpec> ConditionBoostSpecs { get; set; }

        /// <summary>
        /// Whether to skip boostspec validation. If this field is set to true, invalid BoostSpec.condition_boost_specs
        /// will be ignored and valid BoostSpec.condition_boost_specs will still be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipBoostSpecValidation")]
        public virtual System.Nullable<bool> SkipBoostSpecValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Boost applies to products which match a condition.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestBoostSpecConditionBoostSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Strength of the condition boost, which should be in [-1, 1]. Negative boost means demotion. Default is 0.0.
        /// Setting to 1.0 gives the item a big promotion. However, it does not necessarily mean that the boosted item
        /// will be the top result at all times, nor that other items will be excluded. Results could still be shown
        /// even when none of them matches the condition. And results that are significantly more relevant to the search
        /// query can still trump your heavily favored but irrelevant items. Setting to -1.0 gives the item a big
        /// demotion. However, results that are deeply relevant might still be shown. The item will have an upstream
        /// battle to get a fairly high ranking, but it is not blocked out completely. Setting to 0.0 means no boost
        /// applied. The boosting condition is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boost")]
        public virtual System.Nullable<float> Boost { get; set; }

        /// <summary>
        /// An expression which specifies a boost condition. The syntax and supported fields are the same as a filter
        /// expression. See SearchRequest.filter for detail syntax and limitations. Examples: * To boost products with
        /// product ID "product_1" or "product_2", and color "Red" or "Blue": * (id: ANY("product_1", "product_2")) AND
        /// (colorFamilies: ANY("Red","Blue"))
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications of dynamically generated facets.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestDynamicFacetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mode of the DynamicFacet feature. Defaults to Mode.DISABLED if it's unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A facet specification to perform faceted search.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestFacetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enables dynamic position for this facet. If set to true, the position of this facet among all facets in the
        /// response is determined by Google Retail Search. It will be ordered together with dynamic facets if dynamic
        /// facets is enabled. If set to false, the position of this facet in the response will be the same as in the
        /// request, and it will be ranked before the facets with dynamic position enable and all dynamic facets. For
        /// example, you may always want to have rating facet returned in the response, but it's not necessarily to
        /// always display the rating facet at the top. In that case, you can set enable_dynamic_position to true so
        /// that the position of rating facet in response will be determined by Google Retail Search. Another example,
        /// assuming you have the following facets in the request: * "rating", enable_dynamic_position = true * "price",
        /// enable_dynamic_position = false * "brands", enable_dynamic_position = false And also you have a dynamic
        /// facets enable, which will generate a facet 'gender'. Then the final order of the facets in the response can
        /// be ("price", "brands", "rating", "gender") or ("price", "brands", "gender", "rating") depends on how Google
        /// Retail Search orders "gender" and "rating" facets. However, notice that "price" and "brands" will always be
        /// ranked at 1st and 2nd position since their enable_dynamic_position are false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDynamicPosition")]
        public virtual System.Nullable<bool> EnableDynamicPosition { get; set; }

        /// <summary>
        /// List of keys to exclude when faceting. By default, FacetKey.key is not excluded from the filter unless it is
        /// listed in this field. Listing a facet key in this field allows its values to appear as facet results, even
        /// when they are filtered out of search results. Using this field does not affect what search results are
        /// returned. For example, suppose there are 100 products with the color facet "Red" and 200 products with the
        /// color facet "Blue". A query containing the filter "colorFamilies:ANY("Red")" and having "colorFamilies" as
        /// FacetKey.key would by default return only "Red" products in the search results, and also return "Red" with
        /// count 100 as the only color facet. Although there are also blue products available, "Blue" would not be
        /// shown as an available facet value. If "colorFamilies" is listed in "excludedFilterKeys", then the query
        /// returns the facet values "Red" with count 100 and "Blue" with count 200, because the "colorFamilies" key is
        /// now excluded from the filter. Because this field doesn't affect search results, the search results are still
        /// correctly filtered to return only "Red" products. A maximum of 100 values are allowed. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedFilterKeys")]
        public virtual System.Collections.Generic.IList<string> ExcludedFilterKeys { get; set; }

        /// <summary>Required. The facet key specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetKey")]
        public virtual GoogleCloudRetailV2alphaSearchRequestFacetSpecFacetKey FacetKey { get; set; }

        /// <summary>
        /// Maximum of facet values that should be returned for this facet. If unspecified, defaults to 20. The maximum
        /// allowed value is 300. Values above 300 will be coerced to 300. If this field is negative, an
        /// INVALID_ARGUMENT is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<int> Limit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how a facet is computed.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestFacetSpecFacetKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True to make facet keys case insensitive when getting faceting values with prefixes or contains; false
        /// otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseInsensitive")]
        public virtual System.Nullable<bool> CaseInsensitive { get; set; }

        /// <summary>
        /// Only get facet values that contains the given strings. For example, suppose "categories" has three values
        /// "Women &amp;gt; Shoe", "Women &amp;gt; Dress" and "Men &amp;gt; Shoe". If set "contains" to "Shoe", the
        /// "categories" facet will give only "Women &amp;gt; Shoe" and "Men &amp;gt; Shoe". Only supported on textual
        /// fields. Maximum is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contains")]
        public virtual System.Collections.Generic.IList<string> Contains { get; set; }

        /// <summary>
        /// Set only if values should be bucketized into intervals. Must be set for facets with numerical values. Must
        /// not be set for facet with text values. Maximum number of intervals is 30.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervals")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaInterval> Intervals { get; set; }

        /// <summary>
        /// Required. Supported textual and numerical facet keys in Product object, over which the facet values are
        /// computed. Facet key is case-sensitive. Allowed facet keys when FacetKey.query is not specified: *
        /// textual_field = * "brands" * "categories" * "genders" * "ageGroups" * "availability" * "colorFamilies" *
        /// "colors" * "sizes" * "materials" * "patterns" * "conditions" * "attributes.key" * "pickupInStore" *
        /// "shipToStore" * "sameDayDelivery" * "nextDayDelivery" * "customFulfillment1" * "customFulfillment2" *
        /// "customFulfillment3" * "customFulfillment4" * "customFulfillment5" * "inventory(place_id,attributes.key)" *
        /// numerical_field = * "price" * "discount" * "rating" * "ratingCount" * "attributes.key" *
        /// "inventory(place_id,price)" * "inventory(place_id,original_price)" * "inventory(place_id,attributes.key)"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The order in which SearchResponse.Facet.values are returned. Allowed values are: * "count desc", which means
        /// order by SearchResponse.Facet.values.count descending. * "value desc", which means order by
        /// SearchResponse.Facet.values.value descending. Only applies to textual facets. If not set, textual values are
        /// sorted in [natural order](https://en.wikipedia.org/wiki/Natural_sort_order); numerical intervals are sorted
        /// in the order given by FacetSpec.FacetKey.intervals; FulfillmentInfo.place_ids are sorted in the order given
        /// by FacetSpec.FacetKey.restricted_values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Only get facet values that start with the given string prefix. For example, suppose "categories" has three
        /// values "Women &amp;gt; Shoe", "Women &amp;gt; Dress" and "Men &amp;gt; Shoe". If set "prefixes" to "Women",
        /// the "categories" facet will give only "Women &amp;gt; Shoe" and "Women &amp;gt; Dress". Only supported on
        /// textual fields. Maximum is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixes")]
        public virtual System.Collections.Generic.IList<string> Prefixes { get; set; }

        /// <summary>
        /// The query that is used to compute facet for the given facet key. When provided, it will override the default
        /// behavior of facet computation. The query syntax is the same as a filter expression. See SearchRequest.filter
        /// for detail syntax and limitations. Notice that there is no limitation on FacetKey.key when query is
        /// specified. In the response, SearchResponse.Facet.values.value will be always "1" and
        /// SearchResponse.Facet.values.count will be the number of results that match the query. For example, you can
        /// set a customized facet for "shipToStore", where FacetKey.key is "customizedShipToStore", and FacetKey.query
        /// is "availability: ANY(\"IN_STOCK\") AND shipToStore: ANY(\"123\")". Then the facet will count the products
        /// that are both in stock and ship to store "123".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// Only get facet for the given restricted values. For example, when using "pickupInStore" as key and set
        /// restricted values to ["store123", "store456"], only facets for "store123" and "store456" are returned. Only
        /// supported on predefined textual fields, custom textual attributes and fulfillments. Maximum is 20. Must be
        /// set for the fulfillment facet keys: * pickupInStore * shipToStore * sameDayDelivery * nextDayDelivery *
        /// customFulfillment1 * customFulfillment2 * customFulfillment3 * customFulfillment4 * customFulfillment5
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedValues")]
        public virtual System.Collections.Generic.IList<string> RestrictedValues { get; set; }

        /// <summary>
        /// Returns the min and max value for each numerical facet intervals. Ignored for textual facets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnMinMax")]
        public virtual System.Nullable<bool> ReturnMinMax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification for personalization.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestPersonalizationSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defaults to Mode.AUTO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification to determine under which conditions query expansion should occur.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestQueryExpansionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition under which query expansion should occur. Default to Condition.DISABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// Whether to pin unexpanded results. If this field is set to true, unexpanded products are always at the top
        /// of the search results, followed by the expanded results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pinUnexpandedResults")]
        public virtual System.Nullable<bool> PinUnexpandedResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification for query spell correction.</summary>
    public class GoogleCloudRetailV2alphaSearchRequestSpellCorrectionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The mode under which spell correction should take effect to replace the original search query. Default to
        /// Mode.AUTO.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchService.Search method.</summary>
    public class GoogleCloudRetailV2alphaSearchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fully qualified resource name of applied
        /// [controls](https://cloud.google.com/retail/docs/serving-control-rules).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedControls")]
        public virtual System.Collections.Generic.IList<string> AppliedControls { get; set; }

        /// <summary>
        /// A unique search token. This should be included in the UserEvent logs resulting from this search, which
        /// enables accurate attribution of search model performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>
        /// Contains the spell corrected query, if found. If the spell correction type is AUTOMATIC, then the search
        /// results are based on corrected_query. Otherwise the original query is used for search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedQuery")]
        public virtual string CorrectedQuery { get; set; }

        /// <summary>Results of facets requested by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facets")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaSearchResponseFacet> Facets { get; set; }

        /// <summary>
        /// The invalid SearchRequest.BoostSpec.condition_boost_specs that are not applied during serving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidConditionBoostSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaSearchRequestBoostSpecConditionBoostSpec> InvalidConditionBoostSpecs { get; set; }

        /// <summary>
        /// A token that can be sent as SearchRequest.page_token to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Query expansion information for the returned results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryExpansionInfo")]
        public virtual GoogleCloudRetailV2alphaSearchResponseQueryExpansionInfo QueryExpansionInfo { get; set; }

        /// <summary>
        /// The URI of a customer-defined redirect page. If redirect action is triggered, no search is performed, and
        /// only redirect_uri and attribution_token are set in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>A list of matched items. The order represents the ranking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaSearchResponseSearchResult> Results { get; set; }

        /// <summary>
        /// The estimated total count of matched items irrespective of pagination. The count of results returned by
        /// pagination may be less than the total_size that matches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A facet result.</summary>
    public class GoogleCloudRetailV2alphaSearchResponseFacet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the facet is dynamically generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicFacet")]
        public virtual System.Nullable<bool> DynamicFacet { get; set; }

        /// <summary>The key for this facet. E.g., "colorFamilies" or "price" or "attributes.attr1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The facet values for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaSearchResponseFacetFacetValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A facet value which contains value names and their count.</summary>
    public class GoogleCloudRetailV2alphaSearchResponseFacetFacetValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of items that have this facet value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Interval value for a facet, such as [10, 20) for facet "price".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual GoogleCloudRetailV2alphaInterval Interval { get; set; }

        /// <summary>
        /// The maximum value in the FacetValue.interval. Only supported on numerical facets and returned if
        /// SearchRequest.FacetSpec.FacetKey.return_min_max is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; }

        /// <summary>
        /// The minimum value in the FacetValue.interval. Only supported on numerical facets and returned if
        /// SearchRequest.FacetSpec.FacetKey.return_min_max is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; }

        /// <summary>Text value of a facet, such as "Black" for facet "colorFamilies".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information describing query expansion including whether expansion has occurred.</summary>
    public class GoogleCloudRetailV2alphaSearchResponseQueryExpansionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bool describing whether query expansion has occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedQuery")]
        public virtual System.Nullable<bool> ExpandedQuery { get; set; }

        /// <summary>
        /// Number of pinned results. This field will only be set when expansion happens and
        /// SearchRequest.QueryExpansionSpec.pin_unexpanded_results is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pinnedResultCount")]
        public virtual System.Nullable<long> PinnedResultCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the search results.</summary>
    public class GoogleCloudRetailV2alphaSearchResponseSearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Product.id of the searched Product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The count of matched variant Products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingVariantCount")]
        public virtual System.Nullable<int> MatchingVariantCount { get; set; }

        /// <summary>
        /// If a variant Product matches the search query, this map indicates which Product fields are matched. The key
        /// is the Product.name, the value is a field mask of the matched Product fields. If matched attributes cannot
        /// be determined, this map will be empty. For example, a key "sku1" with field mask "products.color_info"
        /// indicates there is a match between "sku1" ColorInfo and the query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingVariantFields")]
        public virtual System.Collections.Generic.IDictionary<string, object> MatchingVariantFields { get; set; }

        /// <summary>
        /// Specifies previous events related to this product for this user based on UserEvent with same
        /// SearchRequest.visitor_id or UserInfo.user_id. This is set only when SearchRequest.PersonalizationSpec.mode
        /// is SearchRequest.PersonalizationSpec.Mode.AUTO. Possible values: * `purchased`: Indicates that this product
        /// has been purchased before.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalLabels")]
        public virtual System.Collections.Generic.IList<string> PersonalLabels { get; set; }

        /// <summary>
        /// The product data snippet in the search response. Only Product.name is guaranteed to be populated.
        /// Product.variants contains the product variants that match the search query. If there are multiple product
        /// variants matching the query, top 5 most relevant product variants are returned and ordered by relevancy. If
        /// relevancy can be deternmined, use matching_variant_fields to look up matched product variants fields. If
        /// relevancy cannot be determined, e.g. when searching "shoe" all products in a shoe product can be a match, 5
        /// product variants are returned but order is meaningless.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual GoogleCloudRetailV2alphaProduct Product { get; set; }

        /// <summary>
        /// The rollup matching variant Product attributes. The key is one of the SearchRequest.variant_rollup_keys. The
        /// values are the merged and de-duplicated Product attributes. Notice that the rollup values are respect
        /// filter. For example, when filtering by "colorFamilies:ANY(\"red\")" and rollup "colorFamilies", only "red"
        /// is returned. For textual and numerical attributes, the rollup values is a list of string or double values
        /// with type google.protobuf.ListValue. For example, if there are two variants with colors "red" and "blue",
        /// the rollup values are { key: "colorFamilies" value { list_value { values { string_value: "red" } values {
        /// string_value: "blue" } } } } For FulfillmentInfo, the rollup values is a double value with type
        /// google.protobuf.Value. For example, `{key: "pickupInStore.store1" value { number_value: 10 }}` means a there
        /// are 10 variants in this product are available in the store "store1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantRollupValues")]
        public virtual System.Collections.Generic.IDictionary<string, object> VariantRollupValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures metadata that is used to generate serving time results (e.g. search results or recommendation
    /// predictions).
    /// </summary>
    public class GoogleCloudRetailV2alphaServingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Condition boost specifications. If a product matches multiple conditions in the specifications, boost scores
        /// from these specifications are all applied and combined in a non-linear way. Maximum number of specifications
        /// is 100. Notice that if both ServingConfig.boost_control_ids and SearchRequest.boost_spec are set, the boost
        /// conditions from both places are evaluated. If a search request matches multiple boost conditions, the final
        /// boost score is equal to the sum of the boost scores from all matched boost conditions. Can only be set if
        /// solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostControlIds")]
        public virtual System.Collections.Generic.IList<string> BoostControlIds { get; set; }

        /// <summary>
        /// Required. The human readable serving config display name. Used in Retail UI. This field must be a UTF-8
        /// encoded string with a length limit of 128 characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// How much diversity to use in recommendation model results e.g. `medium-diversity` or `high-diversity`.
        /// Currently supported values: * `no-diversity` * `low-diversity` * `medium-diversity` * `high-diversity` *
        /// `auto-diversity` If not specified, we choose default based on recommendation model type. Default value:
        /// `no-diversity`. Can only be set if solution_types is SOLUTION_TYPE_RECOMMENDATION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diversityLevel")]
        public virtual string DiversityLevel { get; set; }

        /// <summary>What kind of diversity to use - data driven or rule based.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diversityType")]
        public virtual string DiversityType { get; set; }

        /// <summary>
        /// Condition do not associate specifications. If multiple do not associate conditions match, all matching do
        /// not associate controls in the list will execute. - Order does not matter. - Maximum number of specifications
        /// is 100. Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doNotAssociateControlIds")]
        public virtual System.Collections.Generic.IList<string> DoNotAssociateControlIds { get; set; }

        /// <summary>
        /// The specification for dynamically generated facets. Notice that only textual facets can be dynamically
        /// generated. Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicFacetSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestDynamicFacetSpec DynamicFacetSpec { get; set; }

        /// <summary>
        /// Whether to add additional category filters on the `similar-items` model. If not specified, we enable it by
        /// default. Allowed values are: * `no-category-match`: No additional filtering of original results from the
        /// model and the customer's filters. * `relaxed-category-match`: Only keep results with categories that match
        /// at least one item categories in the PredictRequests's context item. * If customer also sends filters in the
        /// PredictRequest, then the results will satisfy both conditions (user given and category match). Can only be
        /// set if solution_types is SOLUTION_TYPE_RECOMMENDATION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableCategoryFilterLevel")]
        public virtual string EnableCategoryFilterLevel { get; set; }

        /// <summary>
        /// Facet specifications for faceted search. If empty, no facets are returned. The ids refer to the ids of
        /// Control resources with only the Facet control set. These controls are assumed to be in the same Catalog as
        /// the ServingConfig. A maximum of 100 values are allowed. Otherwise, an INVALID_ARGUMENT error is returned.
        /// Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetControlIds")]
        public virtual System.Collections.Generic.IList<string> FacetControlIds { get; set; }

        /// <summary>
        /// Condition filter specifications. If a product matches multiple conditions in the specifications, filters
        /// from these specifications are all applied and combined via the AND operator. Maximum number of
        /// specifications is 100. Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterControlIds")]
        public virtual System.Collections.Generic.IList<string> FilterControlIds { get; set; }

        /// <summary>
        /// Condition ignore specifications. If multiple ignore conditions match, all matching ignore controls in the
        /// list will execute. - Order does not matter. - Maximum number of specifications is 100. Can only be set if
        /// solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreControlIds")]
        public virtual System.Collections.Generic.IList<string> IgnoreControlIds { get; set; }

        /// <summary>
        /// The id of the model in the same Catalog to use at serving time. Currently only RecommendationModels are
        /// supported: https://cloud.google.com/retail/recommendations-ai/docs/create-models Can be changed but only to
        /// a compatible model (e.g. others-you-may-like CTR to others-you-may-like CVR). Required when solution_types
        /// is SOLUTION_TYPE_RECOMMENDATION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelId")]
        public virtual string ModelId { get; set; }

        /// <summary>Immutable. Fully qualified name `projects/*/locations/global/catalogs/*/servingConfig/*`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Condition oneway synonyms specifications. If multiple oneway synonyms conditions match, all matching oneway
        /// synonyms controls in the list will execute. Order of controls in the list will not matter. Maximum number of
        /// specifications is 100. Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onewaySynonymsControlIds")]
        public virtual System.Collections.Generic.IList<string> OnewaySynonymsControlIds { get; set; }

        /// <summary>
        /// The specification for personalization spec. Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// Notice that if both ServingConfig.personalization_spec and SearchRequest.personalization_spec are set.
        /// SearchRequest.personalization_spec will override ServingConfig.personalization_spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalizationSpec")]
        public virtual GoogleCloudRetailV2alphaSearchRequestPersonalizationSpec PersonalizationSpec { get; set; }

        /// <summary>
        /// How much price ranking we want in serving results. Price reranking causes product items with a similar
        /// recommendation probability to be ordered by price, with the highest-priced items first. This setting could
        /// result in a decrease in click-through and conversion rates. Allowed values are: * `no-price-reranking` *
        /// `low-price-raranking` * `medium-price-reranking` * `high-price-reranking` If not specified, we choose
        /// default based on model type. Default value: `no-price-reranking`. Can only be set if solution_types is
        /// SOLUTION_TYPE_RECOMMENDATION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceRerankingLevel")]
        public virtual string PriceRerankingLevel { get; set; }

        /// <summary>
        /// Condition redirect specifications. Only the first triggered redirect action is applied, even if multiple
        /// apply. Maximum number of specifications is 1000. Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectControlIds")]
        public virtual System.Collections.Generic.IList<string> RedirectControlIds { get; set; }

        /// <summary>
        /// Condition replacement specifications. - Applied according to the order in the list. - A previously replaced
        /// term can not be re-replaced. - Maximum number of specifications is 100. Can only be set if solution_types is
        /// SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacementControlIds")]
        public virtual System.Collections.Generic.IList<string> ReplacementControlIds { get; set; }

        /// <summary>
        /// Required. Immutable. Specifies the solution types that a serving config can be associated with. Currently we
        /// support setting only one type of solution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("solutionTypes")]
        public virtual System.Collections.Generic.IList<string> SolutionTypes { get; set; }

        /// <summary>
        /// Condition synonyms specifications. If multiple syonyms conditions match, all matching synonyms control in
        /// the list will execute. Order of controls in the list will not matter. Maximum number of specifications is
        /// 100. Can only be set if solution_types is SOLUTION_TYPE_SEARCH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("twowaySynonymsControlIds")]
        public virtual System.Collections.Generic.IList<string> TwowaySynonymsControlIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to set a specified branch as new default_branch.</summary>
    public class GoogleCloudRetailV2alphaSetDefaultBranchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The final component of the resource name of a branch. This field must be one of "0", "1" or "2". Otherwise,
        /// an INVALID_ARGUMENT error is returned. If there are no sufficient active products in the targeted branch and
        /// force is not set, a FAILED_PRECONDITION error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branchId")]
        public virtual string BranchId { get; set; }

        /// <summary>
        /// If set to true, it permits switching to a branch with branch_id even if it has no sufficient active
        /// products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>
        /// Some note on this request, this can be retrieved by CatalogService.GetDefaultBranch before next valid
        /// default branch set occurs. This field must be a UTF-8 encoded string with a length limit of 1,000
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the SetInventory operation. Currently empty because there is no meaningful
    /// metadata populated from the ProductService.SetInventory method.
    /// </summary>
    public class GoogleCloudRetailV2alphaSetInventoryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ProductService.SetInventory method.</summary>
    public class GoogleCloudRetailV2alphaSetInventoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, and the Product with name Product.name is not found, the inventory update will still be
        /// processed and retained for at most 1 day until the Product is created. If set to false, a NOT_FOUND error is
        /// returned if the Product is not found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Required. The inventory information to update. The allowable fields to update are: * Product.price_info *
        /// Product.availability * Product.available_quantity * Product.fulfillment_info The updated inventory fields
        /// must be specified in SetInventoryRequest.set_mask. If SetInventoryRequest.inventory.name is empty or
        /// invalid, an INVALID_ARGUMENT error is returned. If the caller does not have permission to update the Product
        /// named in Product.name, regardless of whether or not it exists, a PERMISSION_DENIED error is returned. If the
        /// Product to update does not have existing inventory information, the provided inventory information will be
        /// inserted. If the Product to update has existing inventory information, the provided inventory information
        /// will be merged while respecting the last update time for each inventory field, using the provided or default
        /// value for SetInventoryRequest.set_time. The caller can replace place IDs for a subset of fulfillment types
        /// in the following ways: * Adds "fulfillment_info" in SetInventoryRequest.set_mask * Specifies only the
        /// desired fulfillment types and corresponding place IDs to update in
        /// SetInventoryRequest.inventory.fulfillment_info The caller can clear all place IDs from a subset of
        /// fulfillment types in the following ways: * Adds "fulfillment_info" in SetInventoryRequest.set_mask *
        /// Specifies only the desired fulfillment types to clear in SetInventoryRequest.inventory.fulfillment_info *
        /// Checks that only the desired fulfillment info types have empty
        /// SetInventoryRequest.inventory.fulfillment_info.place_ids The last update time is recorded for the following
        /// inventory fields: * Product.price_info * Product.availability * Product.available_quantity *
        /// Product.fulfillment_info If a full overwrite of inventory information while ignoring timestamps is needed,
        /// ProductService.UpdateProduct should be invoked instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventory")]
        public virtual GoogleCloudRetailV2alphaProduct Inventory { get; set; }

        /// <summary>
        /// Indicates which inventory fields in the provided Product to update. At least one field must be provided. If
        /// an unsupported or unknown field is provided, an INVALID_ARGUMENT error is returned and the entire update
        /// will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setMask")]
        public virtual object SetMask { get; set; }

        /// <summary>
        /// The time when the request is issued, used to prevent out-of-order updates on inventory fields with the last
        /// update time recorded. If not provided, the internal system time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setTime")]
        public virtual object SetTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the SetInventoryRequest. Currently empty because there is no meaningful response populated from the
    /// ProductService.SetInventory method.
    /// </summary>
    public class GoogleCloudRetailV2alphaSetInventoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to transform user events operation.</summary>
    public class GoogleCloudRetailV2alphaTransformedUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of entries in the source user events BigQuery table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceEventsCount")]
        public virtual System.Nullable<long> SourceEventsCount { get; set; }

        /// <summary>
        /// Count of entries in the transformed user events BigQuery table, which could be different from the actually
        /// imported number of user events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformedEventsCount")]
        public virtual System.Nullable<long> TransformedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata associated with a tune operation.</summary>
    public class GoogleCloudRetailV2alphaTuneModelMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the model that this tune applies to. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to manually start a tuning process now (instead of waiting for the periodically scheduled tuning to
    /// happen).
    /// </summary>
    public class GoogleCloudRetailV2alphaTuneModelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response associated with a tune operation.</summary>
    public class GoogleCloudRetailV2alphaTuneModelResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UserEvent captures all metadata information Retail API needs to know about how end users interact with
    /// customers' website.
    /// </summary>
    public class GoogleCloudRetailV2alphaUserEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Extra user event features to include in the recommendation model. If you provide custom attributes for
        /// ingested user events, also include them in the user events that you associate with prediction requests.
        /// Custom attribute formatting must be consistent between imported events and events provided with prediction
        /// requests. This lets the Retail API use those custom attributes when training models and serving predictions,
        /// which helps improve recommendation quality. This field needs to pass all below criteria, otherwise an
        /// INVALID_ARGUMENT error is returned: * The key must be a UTF-8 encoded string with a length limit of 5,000
        /// characters. * For text attributes, at most 400 values are allowed. Empty values are not allowed. Each value
        /// must be a UTF-8 encoded string with a length limit of 256 characters. * For number attributes, at most 400
        /// values are allowed. For product recommendations, an example of extra user information is traffic_channel,
        /// which is how a user arrives at the site. Users can arrive at the site by coming to the site directly, coming
        /// through Google search, or in other ways.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRetailV2alphaCustomAttribute> Attributes { get; set; }

        /// <summary>
        /// Highly recommended for user events that are the result of PredictionService.Predict. This field enables
        /// accurate attribution of recommendation model performance. The value must be a valid
        /// PredictResponse.attribution_token for user events that are the result of PredictionService.Predict. The
        /// value must be a valid SearchResponse.attribution_token for user events that are the result of
        /// SearchService.Search. This token enables us to accurately attribute page view or purchase back to the event
        /// and the particular predict response containing this clicked/purchased product. If user clicks on product K
        /// in the recommendation results, pass PredictResponse.attribution_token as a URL parameter to product K's
        /// page. When recording events on product K's page, log the PredictResponse.attribution_token to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>
        /// The ID or name of the associated shopping cart. This ID is used to associate multiple items added or present
        /// in the cart before purchase. This can only be set for `add-to-cart`, `purchase-complete`, or
        /// `shopping-cart-page-view` events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cartId")]
        public virtual string CartId { get; set; }

        /// <summary>
        /// The main auto-completion details related to the event. This field should be set for `search` event when
        /// autocomplete function is enabled and the user clicks a suggestion for search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionDetail")]
        public virtual GoogleCloudRetailV2alphaCompletionDetail CompletionDetail { get; set; }

        /// <summary>
        /// Only required for UserEventService.ImportUserEvents method. Timestamp of when the user event happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// Required. User event type. Allowed values are: * `add-to-cart`: Products being added to cart. *
        /// `category-page-view`: Special pages such as sale or promotion pages viewed. * `detail-page-view`: Products
        /// detail page viewed. * `home-page-view`: Homepage viewed. * `promotion-offered`: Promotion is offered to a
        /// user. * `promotion-not-offered`: Promotion is not offered to a user. * `purchase-complete`: User finishing a
        /// purchase. * `search`: Product search. * `shopping-cart-page-view`: User viewing a shopping cart.
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
        /// The filter syntax consists of an expression language for constructing a predicate from one or more fields of
        /// the products being filtered. See SearchRequest.filter for definition and syntax. The value must be a UTF-8
        /// encoded string with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// An integer that specifies the current offset for pagination (the 0-indexed starting location, amongst the
        /// products deemed by the API as relevant). See SearchRequest.offset for definition. If this field is negative,
        /// an INVALID_ARGUMENT is returned. This can only be set for `search` events. Other event types should not set
        /// this field. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The order in which products are returned. See SearchRequest.order_by for definition and syntax. The value
        /// must be a UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error
        /// is returned. This can only be set for `search` events. Other event types should not set this field.
        /// Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// The categories associated with a category page. To represent full path of category, use '&amp;gt;' sign to
        /// separate different hierarchies. If '&amp;gt;' is part of the category name, replace it with other
        /// character(s). Category pages include special pages such as sales or promotions. For instance, a special sale
        /// page may have the category hierarchy: "pageCategories" : ["Sales &amp;gt; 2017 Black Friday Deals"].
        /// Required for `category-page-view` events. At least one of search_query or page_categories is required for
        /// `search` events. Other event types should not set this field. Otherwise, an INVALID_ARGUMENT error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageCategories")]
        public virtual System.Collections.Generic.IList<string> PageCategories { get; set; }

        /// <summary>
        /// A unique ID of a web page view. This should be kept the same for all user events triggered from the same
        /// pageview. For example, an item detail page view could trigger multiple events as the user is browsing the
        /// page. The `pageViewId` property should be kept the same for all these events so that they can be grouped
        /// together properly. When using the client side event reporting with JavaScript pixel and Google Tag Manager,
        /// this value is filled in automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageViewId")]
        public virtual string PageViewId { get; set; }

        /// <summary>
        /// The main product details related to the event. This field is optional except for the following event types:
        /// * `add-to-cart` * `detail-page-view` * `purchase-complete` In a `search` event, this field represents the
        /// products returned to the end user on the current page (the end user may have not finished browsing the whole
        /// page yet). When a new page is returned to the end user, after pagination/filtering/ordering even for the
        /// same query, a new `search` event with different product_details is desired. The end user may have not
        /// finished browsing the whole page yet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaProductDetail> ProductDetails { get; set; }

        /// <summary>
        /// A transaction represents the entire purchase transaction. Required for `purchase-complete` events. Other
        /// event types should not set this field. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTransaction")]
        public virtual GoogleCloudRetailV2alphaPurchaseTransaction PurchaseTransaction { get; set; }

        /// <summary>
        /// The referrer URL of the current page. When using the client side event reporting with JavaScript pixel and
        /// Google Tag Manager, this value is filled in automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrerUri")]
        public virtual string ReferrerUri { get; set; }

        /// <summary>
        /// The user's search query. See SearchRequest.query for definition. The value must be a UTF-8 encoded string
        /// with a length limit of 5,000 characters. Otherwise, an INVALID_ARGUMENT error is returned. At least one of
        /// search_query or page_categories is required for `search` events. Other event types should not set this
        /// field. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchQuery")]
        public virtual string SearchQuery { get; set; }

        /// <summary>
        /// A unique identifier for tracking a visitor session with a length limit of 128 bytes. A session is an
        /// aggregation of an end user behavior in a time span. A general guideline to populate the sesion_id: 1. If
        /// user has no activity for 30 min, a new session_id should be assigned. 2. The session_id should be unique
        /// across users, suggest use uuid or add visitor_id as prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>
        /// Complete URL (window.location.href) of the user's current page. When using the client side event reporting
        /// with JavaScript pixel and Google Tag Manager, this value is filled in automatically. Maximum length 5,000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>User information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudRetailV2alphaUserInfo UserInfo { get; set; }

        /// <summary>
        /// Required. A unique identifier for tracking visitors. For example, this could be implemented with an HTTP
        /// cookie, which should be able to uniquely identify a visitor on a single device. This unique identifier
        /// should not change if the visitor log in/out of the website. Don't set the field to the same fixed ID for
        /// different users. This mixes the event history of those users together, which results in degraded model
        /// quality. The field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned. The field should not contain PII or user-data. We recommend to use
        /// Google Analytics [Client
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

    /// <summary>The inline source for the input config for ImportUserEvents method.</summary>
    public class GoogleCloudRetailV2alphaUserEventInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of user events to import. Recommended max of 10k items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2alphaUserEvent> UserEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input config source for user events.</summary>
    public class GoogleCloudRetailV2alphaUserEventInputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQuerySource")]
        public virtual GoogleCloudRetailV2alphaBigQuerySource BigQuerySource { get; set; }

        /// <summary>Required. Google Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudRetailV2alphaGcsSource GcsSource { get; set; }

        /// <summary>Required. The Inline source for the input content for UserEvents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEventInlineSource")]
        public virtual GoogleCloudRetailV2alphaUserEventInlineSource UserEventInlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information of an end user.</summary>
    public class GoogleCloudRetailV2alphaUserInfo : Google.Apis.Requests.IDirectResponseSchema
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
        /// The end user's IP address. This field is used to extract location information for personalization. This
        /// field must be either an IPv4 address (e.g. "104.133.9.80") or an IPv6 address (e.g.
        /// "2001:0db8:85a3:0000:0000:8a2e:0370:7334"). Otherwise, an INVALID_ARGUMENT error is returned. This should
        /// not be set when: * setting SearchRequest.user_info. * using the JavaScript tag in
        /// UserEventService.CollectUserEvent or if direct_user_request is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// User agent as included in the HTTP header. Required for getting SearchResponse.sponsored_results. The field
        /// must be a UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error
        /// is returned. This should not be set when using the client side event reporting with GTM or JavaScript tag in
        /// UserEventService.CollectUserEvent or if direct_user_request is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Highly recommended for logged-in users. Unique identifier for logged-in user, such as a user name. Don't set
        /// for anonymous users. Always use a hashed value for this ID. Don't set the field to the same fixed ID for
        /// different users. This mixes the event history of those users together, which results in degraded model
        /// quality. The field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the AddFulfillmentPlaces operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.AddFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2betaAddFulfillmentPlacesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the AddFulfillmentPlacesRequest. Currently empty because there is no meaningful response populated
    /// from the ProductService.AddFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2betaAddFulfillmentPlacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the AddLocalInventories operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.AddLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2betaAddLocalInventoriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ProductService.AddLocalInventories API. Currently empty because there is no meaningful response
    /// populated from the ProductService.AddLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2betaAddLocalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BigQuery output result.</summary>
    public class GoogleCloudRetailV2betaBigQueryOutputResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of a BigQuery Dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>The ID of a BigQuery Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

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
    /// Metadata related to the progress of the Export operation. This is returned by the
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

        /// <summary>This field is never set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2betaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Output result indicating where the data were exported to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputResult")]
        public virtual GoogleCloudRetailV2betaOutputResult OutputResult { get; set; }

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

        /// <summary>This field is never set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRetailV2betaExportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Output result indicating where the data were exported to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputResult")]
        public virtual GoogleCloudRetailV2betaOutputResult OutputResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportCompletionDataRequest. If the long running operation is done, this message is returned by
    /// the google.longrunning.Operations.response field if the operation is successful.
    /// </summary>
    public class GoogleCloudRetailV2betaImportCompletionDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudRetailV2betaImportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory.
        /// Import errors are written to sharded files in this directory, one per line, as a JSON-encoded
        /// `google.rpc.Status` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the Import operation. This is returned by the
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

        /// <summary>
        /// Pub/Sub topic for receiving notification. If this field is set, when the import is finished, a notification
        /// is sent to specified Pub/Sub topic. The message data is JSON string of a Operation. Format of the Pub/Sub
        /// topic is `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPubsubTopic")]
        public virtual string NotificationPubsubTopic { get; set; }

        /// <summary>Deprecated. This field is never set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

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

    /// <summary>Output result.</summary>
    public class GoogleCloudRetailV2betaOutputResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Export result in BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryResult")]
        public virtual System.Collections.Generic.IList<GoogleCloudRetailV2betaBigQueryOutputResult> BigqueryResult { get; set; }

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

    /// <summary>Metadata for `RejoinUserEvents` method.</summary>
    public class GoogleCloudRetailV2betaRejoinUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `RejoinUserEvents` method.</summary>
    public class GoogleCloudRetailV2betaRejoinUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest product catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the RemoveFulfillmentPlaces operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.RemoveFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2betaRemoveFulfillmentPlacesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the RemoveFulfillmentPlacesRequest. Currently empty because there is no meaningful response
    /// populated from the ProductService.RemoveFulfillmentPlaces method.
    /// </summary>
    public class GoogleCloudRetailV2betaRemoveFulfillmentPlacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the RemoveLocalInventories operation. Currently empty because there is no
    /// meaningful metadata populated from the ProductService.RemoveLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2betaRemoveLocalInventoriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ProductService.RemoveLocalInventories API. Currently empty because there is no meaningful
    /// response populated from the ProductService.RemoveLocalInventories method.
    /// </summary>
    public class GoogleCloudRetailV2betaRemoveLocalInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the SetInventory operation. Currently empty because there is no meaningful
    /// metadata populated from the ProductService.SetInventory method.
    /// </summary>
    public class GoogleCloudRetailV2betaSetInventoryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the SetInventoryRequest. Currently empty because there is no meaningful response populated from the
    /// ProductService.SetInventory method.
    /// </summary>
    public class GoogleCloudRetailV2betaSetInventoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
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

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
