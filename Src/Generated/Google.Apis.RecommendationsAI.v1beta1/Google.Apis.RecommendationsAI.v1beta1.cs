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

namespace Google.Apis.RecommendationsAI.v1beta1
{
    /// <summary>The RecommendationsAI Service.</summary>
    public class RecommendationsAIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public RecommendationsAIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public RecommendationsAIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "recommendationengine";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://recommendationengine.googleapis.com/";
        #else
            "https://recommendationengine.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://recommendationengine.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Recommendations AI (Beta).</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Recommendations AI (Beta).</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for RecommendationsAI requests.</summary>
    public abstract class RecommendationsAIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new RecommendationsAIBaseServiceRequest instance.</summary>
        protected RecommendationsAIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes RecommendationsAI parameter list.</summary>
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
                    CatalogItems = new CatalogItemsResource(service);
                    EventStores = new EventStoresResource(service);
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the CatalogItems resource.</summary>
                public virtual CatalogItemsResource CatalogItems { get; }

                /// <summary>The "catalogItems" collection of methods.</summary>
                public class CatalogItemsResource
                {
                    private const string Resource = "catalogItems";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CatalogItemsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a catalog item.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent catalog resource name, such as
                    /// `projects/*/locations/global/catalogs/default_catalog`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a catalog item.</summary>
                    public class CreateRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent catalog resource name, such as
                        /// `projects/*/locations/global/catalogs/default_catalog`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/catalogItems";

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
                        }
                    }

                    /// <summary>Deletes a catalog item.</summary>
                    /// <param name="name">
                    /// Required. Full resource name of catalog item, such as
                    /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a catalog item.</summary>
                    public class DeleteRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of catalog item, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/catalogItems/.*$",
                            });
                        }
                    }

                    /// <summary>Gets a specific catalog item.</summary>
                    /// <param name="name">
                    /// Required. Full resource name of catalog item, such as
                    /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a specific catalog item.</summary>
                    public class GetRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of catalog item, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/catalogItems/.*$",
                            });
                        }
                    }

                    /// <summary>
                    /// Bulk import of multiple catalog items. Request processing may be synchronous. No partial
                    /// updating supported. Non-existing items will be created. Operation.response is of type
                    /// ImportResponse. Note that it is possible for a subset of the items to be successfully updated.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. `projects/1234/locations/global/catalogs/default_catalog` If no updateMask is
                    /// specified, requires catalogItems.create permission. If updateMask is specified, requires
                    /// catalogItems.update permission.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ImportCatalogItemsRequest body, string parent)
                    {
                        return new ImportRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Bulk import of multiple catalog items. Request processing may be synchronous. No partial
                    /// updating supported. Non-existing items will be created. Operation.response is of type
                    /// ImportResponse. Note that it is possible for a subset of the items to be successfully updated.
                    /// </summary>
                    public class ImportRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ImportCatalogItemsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. `projects/1234/locations/global/catalogs/default_catalog` If no updateMask is
                        /// specified, requires catalogItems.create permission. If updateMask is specified, requires
                        /// catalogItems.update permission.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ImportCatalogItemsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/catalogItems:import";

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

                    /// <summary>Gets a list of catalog items.</summary>
                    /// <param name="parent">
                    /// Required. The parent catalog resource name, such as
                    /// `projects/*/locations/global/catalogs/default_catalog`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Gets a list of catalog items.</summary>
                    public class ListRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ListCatalogItemsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent catalog resource name, such as
                        /// `projects/*/locations/global/catalogs/default_catalog`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. A filter to apply on the list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of results to return per page. If zero, the service will choose a
                        /// reasonable default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. The previous ListCatalogItemsResponse.next_page_token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/catalogItems";

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
                    /// Updates a catalog item. Partial updating is supported. Non-existing items will be created.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Full resource name of catalog item, such as
                    /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a catalog item. Partial updating is supported. Non-existing items will be created.
                    /// </summary>
                    public class PatchRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of catalog item, such as
                        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Indicates which fields in the provided 'item' to update. If not set, will by
                        /// default update all fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CatalogItem Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/catalogItems/.*$",
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

                /// <summary>Gets the EventStores resource.</summary>
                public virtual EventStoresResource EventStores { get; }

                /// <summary>The "eventStores" collection of methods.</summary>
                public class EventStoresResource
                {
                    private const string Resource = "eventStores";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EventStoresResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Operations = new OperationsResource(service);
                        Placements = new PlacementsResource(service);
                        PredictionApiKeyRegistrations = new PredictionApiKeyRegistrationsResource(service);
                        UserEvents = new UserEventsResource(service);
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
                        public class GetRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningOperation>
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
                            public override string RestPath => "v1beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API
                        /// services to override the binding to use different resource name schemes, such as
                        /// `users/*/operations`. To override the binding, API services can add a binding such as
                        /// `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
                        /// compatibility, the default name includes the operations collection id, however overriding
                        /// users must ensure the name binding is the parent resource, without the operations collection
                        /// id.
                        /// </summary>
                        /// <param name="name">The name of the operation's parent resource.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API
                        /// services to override the binding to use different resource name schemes, such as
                        /// `users/*/operations`. To override the binding, API services can add a binding such as
                        /// `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
                        /// compatibility, the default name includes the operations collection id, however overriding
                        /// users must ensure the name binding is the parent resource, without the operations collection
                        /// id.
                        /// </summary>
                        public class ListRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningListOperationsResponse>
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
                            public override string RestPath => "v1beta1/{+name}/operations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
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

                        /// <summary>
                        /// Makes a recommendation prediction. If using API Key based authentication, the API Key must
                        /// be registered using the PredictionApiKeyRegistry service. [Learn
                        /// more](https://cloud.google.com/recommendations-ai/docs/setting-up#register-key).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. Full resource name of the format:
                        /// `{name=projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/*}`
                        /// The id of the recommendation engine placement. This id is used to identify the set of models
                        /// that will be used to make the prediction. We currently support three placements with the
                        /// following IDs by default: * `shopping_cart`: Predicts items frequently bought together with
                        /// one or more catalog items in the same shopping session. Commonly displayed after
                        /// `add-to-cart` events, on product detail pages, or on the shopping cart page. * `home_page`:
                        /// Predicts the next product that a user will most likely engage with or purchase based on the
                        /// shopping or viewing history of the specified `userId` or `visitorId`. For example -
                        /// Recommendations for you. * `product_detail`: Predicts the next product that a user will most
                        /// likely engage with or purchase. The prediction is based on the shopping or viewing history
                        /// of the specified `userId` or `visitorId` and its relevance to a specified `CatalogItem`.
                        /// Typically used on product detail pages. For example - More items like this. *
                        /// `recently_viewed_default`: Returns up to 75 items recently viewed by the specified `userId`
                        /// or `visitorId`, most recent ones first. Returns nothing if neither of them has viewed any
                        /// items yet. For example - Recently viewed. The full list of available placements can be seen
                        /// at https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
                        /// </param>
                        public virtual PredictRequest Predict(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PredictRequest body, string name)
                        {
                            return new PredictRequest(service, body, name);
                        }

                        /// <summary>
                        /// Makes a recommendation prediction. If using API Key based authentication, the API Key must
                        /// be registered using the PredictionApiKeyRegistry service. [Learn
                        /// more](https://cloud.google.com/recommendations-ai/docs/setting-up#register-key).
                        /// </summary>
                        public class PredictRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PredictResponse>
                        {
                            /// <summary>Constructs a new Predict request.</summary>
                            public PredictRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PredictRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of the format:
                            /// `{name=projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/*}`
                            /// The id of the recommendation engine placement. This id is used to identify the set of
                            /// models that will be used to make the prediction. We currently support three placements
                            /// with the following IDs by default: * `shopping_cart`: Predicts items frequently bought
                            /// together with one or more catalog items in the same shopping session. Commonly displayed
                            /// after `add-to-cart` events, on product detail pages, or on the shopping cart page. *
                            /// `home_page`: Predicts the next product that a user will most likely engage with or
                            /// purchase based on the shopping or viewing history of the specified `userId` or
                            /// `visitorId`. For example - Recommendations for you. * `product_detail`: Predicts the
                            /// next product that a user will most likely engage with or purchase. The prediction is
                            /// based on the shopping or viewing history of the specified `userId` or `visitorId` and
                            /// its relevance to a specified `CatalogItem`. Typically used on product detail pages. For
                            /// example - More items like this. * `recently_viewed_default`: Returns up to 75 items
                            /// recently viewed by the specified `userId` or `visitorId`, most recent ones first.
                            /// Returns nothing if neither of them has viewed any items yet. For example - Recently
                            /// viewed. The full list of available placements can be seen at
                            /// https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PredictRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "predict";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+name}:predict";

                            /// <summary>Initializes Predict parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+/placements/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Gets the PredictionApiKeyRegistrations resource.</summary>
                    public virtual PredictionApiKeyRegistrationsResource PredictionApiKeyRegistrations { get; }

                    /// <summary>The "predictionApiKeyRegistrations" collection of methods.</summary>
                    public class PredictionApiKeyRegistrationsResource
                    {
                        private const string Resource = "predictionApiKeyRegistrations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public PredictionApiKeyRegistrationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Register an API key for use with predict method.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource path.
                        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CreatePredictionApiKeyRegistrationRequest body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Register an API key for use with predict method.</summary>
                        public class CreateRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PredictionApiKeyRegistration>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CreatePredictionApiKeyRegistrationRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource path.
                            /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1CreatePredictionApiKeyRegistrationRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/predictionApiKeyRegistrations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Unregister an apiKey from using for predict method.</summary>
                        /// <param name="name">
                        /// Required. The API key to unregister including full resource path.
                        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Unregister an apiKey from using for predict method.</summary>
                        public class DeleteRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The API key to unregister including full resource path.
                            /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+/predictionApiKeyRegistrations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>List the registered apiKeys for use with predict method.</summary>
                        /// <param name="parent">
                        /// Required. The parent placement resource name such as
                        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>List the registered apiKeys for use with predict method.</summary>
                        public class ListRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ListPredictionApiKeyRegistrationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent placement resource name such as
                            /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Maximum number of results to return per page. If unset, the service will
                            /// choose a reasonable default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. The previous `ListPredictionApiKeyRegistration.nextPageToken`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/predictionApiKeyRegistrations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
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
                        /// restriction of POST-ing to a 3rd party domain. This method is used only by the
                        /// Recommendations AI JavaScript pixel. Users should not call this method directly.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent eventStore name, such as
                        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
                        /// </param>
                        public virtual CollectRequest Collect(string parent)
                        {
                            return new CollectRequest(service, parent);
                        }

                        /// <summary>
                        /// Writes a single user event from the browser. This uses a GET request to due to browser
                        /// restriction of POST-ing to a 3rd party domain. This method is used only by the
                        /// Recommendations AI JavaScript pixel. Users should not call this method directly.
                        /// </summary>
                        public class CollectRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleApiHttpBody>
                        {
                            /// <summary>Constructs a new Collect request.</summary>
                            public CollectRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent eventStore name, such as
                            /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. The event timestamp in milliseconds. This prevents browser caching of
                            /// otherwise identical get requests. The name is abbreviated to reduce the payload bytes.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("ets", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<long> Ets { get; set; }

                            /// <summary>
                            /// Optional. The url including cgi-parameters but excluding the hash fragment. The URL must
                            /// be truncated to 1.5K bytes to conservatively be under the 2K bytes. This is often more
                            /// useful than the referer url, because many browsers only send the domain for 3rd party
                            /// requests.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("uri", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Uri { get; set; }

                            /// <summary>Required. URL encoded UserEvent proto.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("userEvent", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string UserEvent { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "collect";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/userEvents:collect";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
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
                        /// Bulk import of User events. Request processing might be synchronous. Events that already
                        /// exist are skipped. Use this method for backfilling historical user events.
                        /// Operation.response is of type ImportResponse. Note that it is possible for a subset of the
                        /// items to be successfully inserted. Operation.metadata is of type ImportMetadata.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required.
                        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
                        /// </param>
                        public virtual ImportRequest Import(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ImportUserEventsRequest body, string parent)
                        {
                            return new ImportRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Bulk import of User events. Request processing might be synchronous. Events that already
                        /// exist are skipped. Use this method for backfilling historical user events.
                        /// Operation.response is of type ImportResponse. Note that it is possible for a subset of the
                        /// items to be successfully inserted. Operation.metadata is of type ImportMetadata.
                        /// </summary>
                        public class ImportRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Import request.</summary>
                            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ImportUserEventsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required.
                            /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ImportUserEventsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "import";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/userEvents:import";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets a list of user events within a time range, with potential filtering. The method does
                        /// not list unjoined user events. Unjoined user event definition: when a user event is ingested
                        /// from Recommendations AI User Event APIs, the catalog item included in the user event is
                        /// connected with the current catalog. If a catalog item of the ingested event is not in the
                        /// current catalog, it could lead to degraded model quality. This is called an unjoined event.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent eventStore resource name, such as
                        /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>
                        /// Gets a list of user events within a time range, with potential filtering. The method does
                        /// not list unjoined user events. Unjoined user event definition: when a user event is ingested
                        /// from Recommendations AI User Event APIs, the catalog item included in the user event is
                        /// connected with the current catalog. If a catalog item of the ingested event is not in the
                        /// current catalog, it could lead to degraded model quality. This is called an unjoined event.
                        /// </summary>
                        public class ListRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ListUserEventsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent eventStore resource name, such as
                            /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Filtering expression to specify restrictions over returned events. This is a
                            /// sequence of terms, where each term applies some kind of a restriction to the returned
                            /// user events. Use this expression to restrict results to a specific time range, or filter
                            /// events by eventType. eg: eventTime &amp;gt; "2012-04-23T18:25:43.511Z"
                            /// eventsMissingCatalogItems eventTime&amp;lt;"2012-04-23T18:25:43.511Z" eventType=search
                            /// We expect only 3 types of fields: * eventTime: this can be specified a maximum of 2
                            /// times, once with a less than operator and once with a greater than operator. The
                            /// eventTime restrict should result in one contiguous valid eventTime range. * eventType:
                            /// only 1 eventType restriction can be specified. * eventsMissingCatalogItems: specififying
                            /// this will restrict results to events for which catalog items were not found in the
                            /// catalog. The default behavior is to return only those events for which catalog items
                            /// were found. Some examples of valid filters expressions: * Example 1: eventTime &amp;gt;
                            /// "2012-04-23T18:25:43.511Z" eventTime &amp;lt; "2012-04-23T18:30:43.511Z" * Example 2:
                            /// eventTime &amp;gt; "2012-04-23T18:25:43.511Z" eventType = detail-page-view * Example 3:
                            /// eventsMissingCatalogItems eventType = search eventTime &amp;lt;
                            /// "2018-04-23T18:30:43.511Z" * Example 4: eventTime &amp;gt; "2012-04-23T18:25:43.511Z" *
                            /// Example 5: eventType = search * Example 6: eventsMissingCatalogItems
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Maximum number of results to return per page. If zero, the service will choose
                            /// a reasonable default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>Optional. The previous ListUserEventsResponse.next_page_token.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/userEvents";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
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
                        /// Deletes permanently all user events specified by the filter provided. Depending on the
                        /// number of events specified by the filter, this operation could take hours or days to
                        /// complete. To test a filter, use the list command first.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The resource name of the event_store under which the events are created. The
                        /// format is
                        /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
                        /// </param>
                        public virtual PurgeRequest Purge(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PurgeUserEventsRequest body, string parent)
                        {
                            return new PurgeRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Deletes permanently all user events specified by the filter provided. Depending on the
                        /// number of events specified by the filter, this operation could take hours or days to
                        /// complete. To test a filter, use the list command first.
                        /// </summary>
                        public class PurgeRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Purge request.</summary>
                            public PurgeRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PurgeUserEventsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the event_store under which the events are created. The
                            /// format is
                            /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1PurgeUserEventsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "purge";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/userEvents:purge";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Triggers a user event rejoin operation with latest catalog data. Events will not be
                        /// annotated with detailed catalog information if catalog item is missing at the time the user
                        /// event is ingested, and these events are stored as unjoined events with a limited usage on
                        /// training and serving. This API can be used to trigger a 'join' operation on specified events
                        /// with latest version of catalog items. It can also be used to correct events joined with
                        /// wrong catalog items.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. Full resource name of user event, such as
                        /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
                        /// </param>
                        public virtual RejoinRequest Rejoin(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1RejoinUserEventsRequest body, string parent)
                        {
                            return new RejoinRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Triggers a user event rejoin operation with latest catalog data. Events will not be
                        /// annotated with detailed catalog information if catalog item is missing at the time the user
                        /// event is ingested, and these events are stored as unjoined events with a limited usage on
                        /// training and serving. This API can be used to trigger a 'join' operation on specified events
                        /// with latest version of catalog items. It can also be used to correct events joined with
                        /// wrong catalog items.
                        /// </summary>
                        public class RejoinRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Rejoin request.</summary>
                            public RejoinRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1RejoinUserEventsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of user event, such as
                            /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1RejoinUserEventsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "rejoin";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/userEvents:rejoin";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Writes a single user event.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent eventStore resource name, such as
                        /// "projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store".
                        /// </param>
                        public virtual WriteRequest Write(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1UserEvent body, string parent)
                        {
                            return new WriteRequest(service, body, parent);
                        }

                        /// <summary>Writes a single user event.</summary>
                        public class WriteRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1UserEvent>
                        {
                            /// <summary>Constructs a new Write request.</summary>
                            public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1UserEvent body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent eventStore resource name, such as
                            /// "projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store".
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1UserEvent Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "write";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/userEvents:write";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/eventStores/[^/]+$",
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
                    public class GetRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningOperation>
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
                        public override string RestPath => "v1beta1/{+name}";

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
                    public class ListRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v1beta1/{+name}/operations";

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

                /// <summary>Lists all the catalog configurations associated with the project.</summary>
                /// <param name="parent">Required. The account resource name with an associated location.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all the catalog configurations associated with the project.</summary>
                public class ListRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1ListCatalogsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The account resource name with an associated location.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Maximum number of results to return. If unspecified, defaults to 50. Max allowed value
                    /// is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListCatalogs` call. Provide this to retrieve
                    /// the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/catalogs";

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

                /// <summary>Updates the catalog configuration.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The fully qualified resource name of the catalog.</param>
                public virtual PatchRequest Patch(Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1Catalog body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the catalog configuration.</summary>
                public class PatchRequest : RecommendationsAIBaseServiceRequest<Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1Catalog>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1Catalog body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The fully qualified resource name of the catalog.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Indicates which fields in the provided 'catalog' to update. If not set, will only
                    /// update the catalog_item_level_config field. Currently only fields that can be updated are
                    /// catalog_item_level_config.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.RecommendationsAI.v1beta1.Data.GoogleCloudRecommendationengineV1beta1Catalog Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
        }
    }
}
namespace Google.Apis.RecommendationsAI.v1beta1.Data
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

    /// <summary>Metadata for TriggerCatalogRejoin method.</summary>
    public class GoogleCloudRecommendationengineV1alphaRejoinCatalogMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TriggerCatalogRejoin method.</summary>
    public class GoogleCloudRecommendationengineV1alphaRejoinCatalogResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest catalog items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata associated with a tune operation.</summary>
    public class GoogleCloudRecommendationengineV1alphaTuningMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the recommendation model that this tune applies to. Format:
        /// projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/eventStores/{event_store_id}/recommendationModels/{recommendation_model_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendationModel")]
        public virtual string RecommendationModel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response associated with a tune operation.</summary>
    public class GoogleCloudRecommendationengineV1alphaTuningResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BigQuery source import data from.</summary>
    public class GoogleCloudRecommendationengineV1beta1BigQuerySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The schema to use when parsing the data from the source. Supported values for catalog imports: 1:
        /// "catalog_recommendations_ai" using https://cloud.google.com/recommendations-ai/docs/upload-catalog#json
        /// (Default for catalogItems.import) 2: "catalog_merchant_center" using
        /// https://cloud.google.com/recommendations-ai/docs/upload-catalog#mc Supported values for user event imports:
        /// 1: "user_events_recommendations_ai" using
        /// https://cloud.google.com/recommendations-ai/docs/manage-user-events#import (Default for userEvents.import)
        /// 2. "user_events_ga360" using https://support.google.com/analytics/answer/3437719?hl=en
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSchema")]
        public virtual string DataSchema { get; set; }

        /// <summary>Required. The BigQuery data set to copy the data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>
        /// Optional. Intermediate Cloud Storage directory used for the import. Can be specified if one wants to have
        /// the BigQuery export to a specific Cloud Storage directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsStagingDir")]
        public virtual string GcsStagingDir { get; set; }

        /// <summary>
        /// Optional. The project id (can be project # or id) that the BigQuery source is in. If not specified, inherits
        /// the project id from the parent request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. The BigQuery table to copy the data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The catalog configuration. Next ID: 5.</summary>
    public class GoogleCloudRecommendationengineV1beta1Catalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The catalog item level configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogItemLevelConfig")]
        public virtual GoogleCloudRecommendationengineV1beta1CatalogItemLevelConfig CatalogItemLevelConfig { get; set; }

        /// <summary>Required. The ID of the default event store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultEventStoreId")]
        public virtual string DefaultEventStoreId { get; set; }

        /// <summary>Required. The catalog display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The fully qualified resource name of the catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inline source for the input config for ImportCatalogItems method.</summary>
    public class GoogleCloudRecommendationengineV1beta1CatalogInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of catalog items to update/create. Recommended max of 10k items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogItems")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1CatalogItem> CatalogItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CatalogItem captures all metadata information of items to be recommended.</summary>
    public class GoogleCloudRecommendationengineV1beta1CatalogItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Catalog item categories. This field is repeated for supporting one catalog item belonging to
        /// several parallel category hierarchies. For example, if a shoes product belongs to both ["Shoes &amp;amp;
        /// Accessories" -&amp;gt; "Shoes"] and ["Sports &amp;amp; Fitness" -&amp;gt; "Athletic Clothing" -&amp;gt;
        /// "Shoes"], it could be represented as: "categoryHierarchies": [ { "categories": ["Shoes &amp;amp;
        /// Accessories", "Shoes"]}, { "categories": ["Sports &amp;amp; Fitness", "Athletic Clothing", "Shoes"] } ]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryHierarchies")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1CatalogItemCategoryHierarchy> CategoryHierarchies { get; set; }

        /// <summary>Optional. Catalog item description. UTF-8 encoded string with a length limit of 5 KiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Catalog item identifier. UTF-8 encoded string with a length limit of 128 bytes. This id must be
        /// unique among all catalog items within the same catalog. It should also be used when logging user events in
        /// order for the user events to be joined with the Catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Highly encouraged. Extra catalog item attributes to be included in the recommendation model. For
        /// example, for retail products, this could include the store name, vendor, style, color, etc. These are very
        /// strong signals for recommendation model, thus we highly recommend providing the item attributes here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemAttributes")]
        public virtual GoogleCloudRecommendationengineV1beta1FeatureMap ItemAttributes { get; set; }

        /// <summary>
        /// Optional. Variant group identifier for prediction results. UTF-8 encoded string with a length limit of 128
        /// bytes. This field must be enabled before it can be used. [Learn
        /// more](/recommendations-ai/docs/catalog#item-group-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupId")]
        public virtual string ItemGroupId { get; set; }

        /// <summary>
        /// Optional. Deprecated. The model automatically detects the text language. Your catalog can include text in
        /// different languages, but duplicating catalog items to provide text in multiple languages can result in
        /// degraded model performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Optional. Metadata specific to retail products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productMetadata")]
        public virtual GoogleCloudRecommendationengineV1beta1ProductCatalogItem ProductMetadata { get; set; }

        /// <summary>
        /// Optional. Filtering tags associated with the catalog item. Each tag should be a UTF-8 encoded string with a
        /// length limit of 1 KiB. This tag can be used for filtering recommendation results by passing the tag as part
        /// of the predict request filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>Required. Catalog item title. UTF-8 encoded string with a length limit of 1 KiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Category represents catalog item category hierarchy.</summary>
    public class GoogleCloudRecommendationengineV1beta1CatalogItemCategoryHierarchy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Catalog item categories. Each category should be a UTF-8 encoded string with a length limit of 2
        /// KiB. Note that the order in the list denotes the specificity (from least to most specific).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures the catalog level that users send events to, and the level at which predictions are made.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1CatalogItemLevelConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Level of the catalog at which events are uploaded. See
        /// https://cloud.google.com/recommendations-ai/docs/catalog#catalog-levels for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventItemLevel")]
        public virtual string EventItemLevel { get; set; }

        /// <summary>
        /// Optional. Level of the catalog at which predictions are made. See
        /// https://cloud.google.com/recommendations-ai/docs/catalog#catalog-levels for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictItemLevel")]
        public virtual string PredictItemLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the `CreatePredictionApiKeyRegistration` method.</summary>
    public class GoogleCloudRecommendationengineV1beta1CreatePredictionApiKeyRegistrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The prediction API key registration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictionApiKeyRegistration")]
        public virtual GoogleCloudRecommendationengineV1beta1PredictionApiKeyRegistration PredictionApiKeyRegistration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User event details shared by all recommendation types.</summary>
    public class GoogleCloudRecommendationengineV1beta1EventDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Extra user event features to include in the recommendation model. For product recommendation, an
        /// example of extra user information is traffic_channel, i.e. how user arrives at the site. Users can arrive at
        /// the site by coming to the site directly, or coming through Google search, and etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventAttributes")]
        public virtual GoogleCloudRecommendationengineV1beta1FeatureMap EventAttributes { get; set; }

        /// <summary>
        /// Optional. A list of identifiers for the independent experiment groups this user event belongs to. This is
        /// used to distinguish between user events associated with different experiment setups (e.g. using
        /// Recommendation Engine system, using different recommendation models).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experimentIds")]
        public virtual System.Collections.Generic.IList<string> ExperimentIds { get; set; }

        /// <summary>
        /// Optional. A unique id of a web page view. This should be kept the same for all user events triggered from
        /// the same pageview. For example, an item detail page view could trigger multiple events as the user is
        /// browsing the page. The `pageViewId` property should be kept the same for all these events so that they can
        /// be grouped together properly. This `pageViewId` will be automatically generated if using the JavaScript
        /// pixel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageViewId")]
        public virtual string PageViewId { get; set; }

        /// <summary>
        /// Optional. Recommendation token included in the recommendation prediction response. This field enables
        /// accurate attribution of recommendation model performance. This token enables us to accurately attribute page
        /// view or purchase back to the event and the particular predict response containing this clicked/purchased
        /// item. If user clicks on product K in the recommendation results, pass the
        /// `PredictResponse.recommendationToken` property as a url parameter to product K's page. When recording events
        /// on product K's page, log the PredictResponse.recommendation_token to this field. Optional, but highly
        /// encouraged for user events that are the result of a recommendation prediction query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendationToken")]
        public virtual string RecommendationToken { get; set; }

        /// <summary>
        /// Optional. The referrer url of the current page. When using the JavaScript pixel, this value is filled in
        /// automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrerUri")]
        public virtual string ReferrerUri { get; set; }

        /// <summary>
        /// Optional. Complete url (window.location.href) of the user's current page. When using the JavaScript pixel,
        /// this value is filled in automatically. Maximum length 5KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// FeatureMap represents extra features that customers want to include in the recommendation model for
    /// catalogs/user events as categorical/numerical features.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1FeatureMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Categorical features that can take on one of a limited number of possible values. Some examples would be the
        /// brand/maker of a product, or country of a customer. Feature names and values must be UTF-8 encoded strings.
        /// For example: `{ "colors": {"value": ["yellow", "green"]}, "sizes": {"value":["S", "M"]}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoricalFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRecommendationengineV1beta1FeatureMapStringList> CategoricalFeatures { get; set; }

        /// <summary>
        /// Numerical features. Some examples would be the height/weight of a product, or age of a customer. Feature
        /// names must be UTF-8 encoded strings. For example: `{ "lengths_cm": {"value":[2.3, 15.4]}, "heights_cm":
        /// {"value":[8.1, 6.4]} }`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericalFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRecommendationengineV1beta1FeatureMapFloatList> NumericalFeatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of float features.</summary>
    public class GoogleCloudRecommendationengineV1beta1FeatureMapFloatList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Float feature value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of string features.</summary>
    public class GoogleCloudRecommendationengineV1beta1FeatureMapStringList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String feature value with a length limit of 128 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage location for input content. format.</summary>
    public class GoogleCloudRecommendationengineV1beta1GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Google Cloud Storage URIs to input files. URI can be up to 2000 characters long. URIs can match
        /// the full object path (for example, `gs://bucket/directory/object.json`) or a pattern matching one or more
        /// files, such as `gs://bucket/directory/*.json`. A request can contain at most 100 files, and each file can be
        /// up to 2 GB. See [Importing catalog information](/recommendations-ai/docs/upload-catalog) for the expected
        /// file format and setup instructions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUris")]
        public virtual System.Collections.Generic.IList<string> InputUris { get; set; }

        /// <summary>
        /// Optional. The schema to use when parsing the data from the source. Supported values for catalog imports: 1:
        /// "catalog_recommendations_ai" using https://cloud.google.com/recommendations-ai/docs/upload-catalog#json
        /// (Default for catalogItems.import) 2: "catalog_merchant_center" using
        /// https://cloud.google.com/recommendations-ai/docs/upload-catalog#mc Supported values for user events imports:
        /// 1: "user_events_recommendations_ai" using
        /// https://cloud.google.com/recommendations-ai/docs/manage-user-events#import (Default for userEvents.import)
        /// 2. "user_events_ga360" using https://support.google.com/analytics/answer/3437719?hl=en
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual string JsonSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Catalog item thumbnail/detail image.</summary>
    public class GoogleCloudRecommendationengineV1beta1Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Height of the image in number of pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Required. URL of the image with a length limit of 5 KiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>Optional. Width of the image in number of pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Import methods.</summary>
    public class GoogleCloudRecommendationengineV1beta1ImportCatalogItemsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The desired location of errors incurred during the Import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRecommendationengineV1beta1ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Required. The desired input location of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudRecommendationengineV1beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// Optional. Unique identifier provided by client, within the ancestor dataset scope. Ensures idempotency and
        /// used for request deduplication. Server-generated if unspecified. Up to 128 characters long. This is returned
        /// as google.longrunning.Operation.name in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Optional. Indicates which fields in the provided imported 'items' to update. If not set, will by default
        /// update all fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportCatalogItemsRequest. If the long running operation is done, then this message is returned
    /// by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1ImportCatalogItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRecommendationengineV1beta1ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudRecommendationengineV1beta1ImportErrorsConfig : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudRecommendationengineV1beta1ImportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Name of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationName")]
        public virtual string OperationName { get; set; }

        /// <summary>
        /// Id of the request / operation. This is parroting back the requestId that was passed in the request.
        /// </summary>
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

    /// <summary>Request message for the ImportUserEvents request.</summary>
    public class GoogleCloudRecommendationengineV1beta1ImportUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The desired location of errors incurred during the Import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRecommendationengineV1beta1ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Required. The desired input location of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual GoogleCloudRecommendationengineV1beta1InputConfig InputConfig { get; set; }

        /// <summary>
        /// Optional. Unique identifier provided by client, within the ancestor dataset scope. Ensures idempotency for
        /// expensive long running operations. Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response. Note that this field must not be set if the
        /// desired input config is catalog_inline_source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1ImportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorsConfig")]
        public virtual GoogleCloudRecommendationengineV1beta1ImportErrorsConfig ErrorsConfig { get; set; }

        /// <summary>Aggregated statistics of user event import status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importSummary")]
        public virtual GoogleCloudRecommendationengineV1beta1UserEventImportSummary ImportSummary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input config source.</summary>
    public class GoogleCloudRecommendationengineV1beta1InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQuerySource")]
        public virtual GoogleCloudRecommendationengineV1beta1BigQuerySource BigQuerySource { get; set; }

        /// <summary>The Inline source for the input content for Catalog items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogInlineSource")]
        public virtual GoogleCloudRecommendationengineV1beta1CatalogInlineSource CatalogInlineSource { get; set; }

        /// <summary>Google Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudRecommendationengineV1beta1GcsSource GcsSource { get; set; }

        /// <summary>The Inline source for the input content for UserEvents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEventInlineSource")]
        public virtual GoogleCloudRecommendationengineV1beta1UserEventInlineSource UserEventInlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListCatalogItems method.</summary>
    public class GoogleCloudRecommendationengineV1beta1ListCatalogItemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The catalog items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogItems")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1CatalogItem> CatalogItems { get; set; }

        /// <summary>
        /// If empty, the list is complete. If nonempty, the token to pass to the next request's
        /// ListCatalogItemRequest.page_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListCatalogs method.</summary>
    public class GoogleCloudRecommendationengineV1beta1ListCatalogsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. All the customer's catalogs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1Catalog> Catalogs { get; set; }

        /// <summary>Pagination token, if not returned indicates the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ListPredictionApiKeyRegistrations`.</summary>
    public class GoogleCloudRecommendationengineV1beta1ListPredictionApiKeyRegistrationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If empty, the list is complete. If nonempty, pass the token to the next request's
        /// `ListPredictionApiKeysRegistrationsRequest.pageToken`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of registered API keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictionApiKeyRegistrations")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1PredictionApiKeyRegistration> PredictionApiKeyRegistrations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListUserEvents method.</summary>
    public class GoogleCloudRecommendationengineV1beta1ListUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If empty, the list is complete. If nonempty, the token to pass to the next request's
        /// ListUserEvents.page_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The user events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1UserEvent> UserEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Predict method.</summary>
    public class GoogleCloudRecommendationengineV1beta1PredictRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Use dryRun mode for this prediction query. If set to true, a dummy model will be used that returns
        /// arbitrary catalog items. Note that the dryRun mode should only be used for testing the API, or if the model
        /// is not ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>
        /// Optional. Filter for restricting prediction results. Accepts values for tags and the `filterOutOfStockItems`
        /// flag. * Tag expressions. Restricts predictions to items that match all of the specified tags. Boolean
        /// operators `OR` and `NOT` are supported if the expression is enclosed in parentheses, and must be separated
        /// from the tag values by a space. `-"tagA"` is also supported and is equivalent to `NOT "tagA"`. Tag values
        /// must be double quoted UTF-8 encoded strings with a size limit of 1 KiB. * filterOutOfStockItems. Restricts
        /// predictions to items that do not have a stockState value of OUT_OF_STOCK. Examples: * tag=("Red" OR "Blue")
        /// tag="New-Arrival" tag=(NOT "promotional") * filterOutOfStockItems tag=(-"promotional") *
        /// filterOutOfStockItems If your filter blocks all prediction results, nothing will be returned. If you want
        /// generic (unfiltered) popular items to be returned instead, set `strictFiltering` to false in
        /// `PredictRequest.params`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. The labels for the predict request. * Label keys can contain lowercase letters, digits and
        /// hyphens, must start with a letter, and must end with a letter or digit. * Non-zero label values can contain
        /// lowercase letters, digits and hyphens, must start with a letter, and must end with a letter or digit. * No
        /// more than 64 labels can be associated with a given request. See https://goo.gl/xmQnxf for more information
        /// on and examples of labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Maximum number of results to return per page. Set this property to the number of prediction
        /// results required. If zero, the service will choose a reasonable default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>Optional. The previous PredictResponse.next_page_token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Optional. Additional domain specific parameters for the predictions. Allowed values: * `returnCatalogItem`:
        /// Boolean. If set to true, the associated catalogItem object will be returned in the
        /// `PredictResponse.PredictionResult.itemMetadata` object in the method response. * `returnItemScore`: Boolean.
        /// If set to true, the prediction 'score' corresponding to each returned item will be set in the `metadata`
        /// field in the prediction response. The given 'score' indicates the probability of an item being
        /// clicked/purchased given the user's context and history. * `strictFiltering`: Boolean. True by default. If
        /// set to false, the service will return generic (unfiltered) popular items instead of empty if your filter
        /// blocks all prediction results. * `priceRerankLevel`: String. Default empty. If set to be non-empty, then it
        /// needs to be one of {'no-price-reranking', 'low-price-reranking', 'medium-price-reranking',
        /// 'high-price-reranking'}. This gives request level control and adjust prediction results based on product
        /// price. * `diversityLevel`: String. Default empty. If set to be non-empty, then it needs to be one of
        /// {'no-diversity', 'low-diversity', 'medium-diversity', 'high-diversity', 'auto-diversity'}. This gives
        /// request level control and adjust prediction results based on product category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>
        /// Required. Context about the user, what they are looking at and what action they took to trigger the predict
        /// request. Note that this user event detail won't be ingested to userEvent logs. Thus, a separate userEvent
        /// write request is required for event logging.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvent")]
        public virtual GoogleCloudRecommendationengineV1beta1UserEvent UserEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for predict method.</summary>
    public class GoogleCloudRecommendationengineV1beta1PredictResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the dryRun property was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>IDs of items in the request that were missing from the catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsMissingInCatalog")]
        public virtual System.Collections.Generic.IList<string> ItemsMissingInCatalog { get; set; }

        /// <summary>Additional domain specific prediction response metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// If empty, the list is complete. If nonempty, the token to pass to the next request's
        /// PredictRequest.page_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A unique recommendation token. This should be included in the user event logs resulting from this
        /// recommendation, which enables accurate attribution of recommendation model performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendationToken")]
        public virtual string RecommendationToken { get; set; }

        /// <summary>
        /// A list of recommended items. The order represents the ranking (from the most relevant item to the least).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1PredictResponsePredictionResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PredictionResult represents the recommendation prediction results.</summary>
    public class GoogleCloudRecommendationengineV1beta1PredictResponsePredictionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the recommended catalog item</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Additional item metadata / annotations. Possible values: * `catalogItem`: JSON representation of the
        /// catalogItem. Will be set if `returnCatalogItem` is set to true in `PredictRequest.params`. * `score`:
        /// Prediction score in double value. Will be set if `returnItemScore` is set to true in
        /// `PredictRequest.params`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> ItemMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Registered Api Key.</summary>
    public class GoogleCloudRecommendationengineV1beta1PredictionApiKeyRegistration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKey")]
        public virtual string ApiKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ProductCatalogItem captures item metadata specific to retail products.</summary>
    public class GoogleCloudRecommendationengineV1beta1ProductCatalogItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The available quantity of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableQuantity")]
        public virtual System.Nullable<long> AvailableQuantity { get; set; }

        /// <summary>
        /// Optional. Canonical URL directly linking to the item detail page with a length limit of 5 KiB..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalProductUri")]
        public virtual string CanonicalProductUri { get; set; }

        /// <summary>
        /// Optional. A map to pass the costs associated with the product. For example: {"manufacturing": 45.5} The
        /// profit of selling this item is computed like so: * If 'exactPrice' is provided, profit = displayPrice -
        /// sum(costs) * If 'priceRange' is provided, profit = minPrice - sum(costs)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costs")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<float>> Costs { get; set; }

        /// <summary>
        /// Optional. Only required if the price is set. Currency code for price/costs. Use three-character ISO-4217
        /// code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Optional. The exact product price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactPrice")]
        public virtual GoogleCloudRecommendationengineV1beta1ProductCatalogItemExactPrice ExactPrice { get; set; }

        /// <summary>Optional. Product images for the catalog item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1Image> Images { get; set; }

        /// <summary>Optional. The product price range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceRange")]
        public virtual GoogleCloudRecommendationengineV1beta1ProductCatalogItemPriceRange PriceRange { get; set; }

        /// <summary>Optional. Online stock state of the catalog item. Default is `IN_STOCK`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stockState")]
        public virtual string StockState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Exact product price.</summary>
    public class GoogleCloudRecommendationengineV1beta1ProductCatalogItemExactPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Display price of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayPrice")]
        public virtual System.Nullable<float> DisplayPrice { get; set; }

        /// <summary>
        /// Optional. Price of the product without any discount. If zero, by default set to be the 'displayPrice'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPrice")]
        public virtual System.Nullable<float> OriginalPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Product price range when there are a range of prices for different variations of the same product.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1ProductCatalogItemPriceRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The maximum product price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<float> Max { get; set; }

        /// <summary>Required. The minimum product price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<float> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed product information associated with a user event.</summary>
    public class GoogleCloudRecommendationengineV1beta1ProductDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Quantity of the products in stock when a user event happens. Optional. If provided, this overrides
        /// the available quantity in Catalog for this event. and can only be set if `stock_status` is set to
        /// `IN_STOCK`. Note that if an item is out of stock, you must set the `stock_state` field to be `OUT_OF_STOCK`.
        /// Leaving this field unspecified / as zero is not sufficient to mark the item out of stock.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableQuantity")]
        public virtual System.Nullable<int> AvailableQuantity { get; set; }

        /// <summary>
        /// Optional. Currency code for price/costs. Use three-character ISO-4217 code. Required only if originalPrice
        /// or displayPrice is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Optional. Display price of the product (e.g. discounted price). If provided, this will override the display
        /// price in Catalog for this product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayPrice")]
        public virtual System.Nullable<float> DisplayPrice { get; set; }

        /// <summary>Required. Catalog item ID. UTF-8 encoded string with a length limit of 128 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Extra features associated with a product in the user event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemAttributes")]
        public virtual GoogleCloudRecommendationengineV1beta1FeatureMap ItemAttributes { get; set; }

        /// <summary>
        /// Optional. Original price of the product. If provided, this will override the original price in Catalog for
        /// this product.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPrice")]
        public virtual System.Nullable<float> OriginalPrice { get; set; }

        /// <summary>
        /// Optional. Quantity of the product associated with the user event. For example, this field will be 2 if two
        /// products are added to the shopping cart for `add-to-cart` event. Required for `add-to-cart`, `add-to-list`,
        /// `remove-from-cart`, `checkout-start`, `purchase-complete`, `refund` event types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>
        /// Optional. Item stock state. If provided, this overrides the stock state in Catalog for items in this event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stockState")]
        public virtual string StockState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ProductEventDetail captures user event information specific to retail products.</summary>
    public class GoogleCloudRecommendationengineV1beta1ProductEventDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The id or name of the associated shopping cart. This id is used to associate multiple items added
        /// or present in the cart before purchase. This can only be set for `add-to-cart`, `remove-from-cart`,
        /// `checkout-start`, `purchase-complete`, or `shopping-cart-page-view` events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cartId")]
        public virtual string CartId { get; set; }

        /// <summary>
        /// Required for `add-to-list` and `remove-from-list` events. The id or name of the list that the item is being
        /// added to or removed from. Other event types should not set this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listId")]
        public virtual string ListId { get; set; }

        /// <summary>
        /// Required for `category-page-view` events. At least one of search_query or page_categories is required for
        /// `search` events. Other event types should not set this field. The categories associated with a category
        /// page. Category pages include special pages such as sales or promotions. For instance, a special sale page
        /// may have the category hierarchy: categories : ["Sales", "2017 Black Friday Deals"].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageCategories")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1CatalogItemCategoryHierarchy> PageCategories { get; set; }

        /// <summary>
        /// The main product details related to the event. This field is required for the following event types: *
        /// `add-to-cart` * `add-to-list` * `checkout-start` * `detail-page-view` * `purchase-complete` * `refund` *
        /// `remove-from-cart` * `remove-from-list` This field is optional for the following event types: * `page-visit`
        /// * `shopping-cart-page-view` - note that 'product_details' should be set for this unless the shopping cart is
        /// empty. * `search` (highly encouraged) In a `search` event, this field represents the products returned to
        /// the end user on the current page (the end user may have not finished broswing the whole page yet). When a
        /// new page is returned to the end user, after pagination/filtering/ordering even for the same query, a new
        /// SEARCH event with different product_details is desired. The end user may have not finished broswing the
        /// whole page yet. This field is not allowed for the following event types: * `category-page-view` *
        /// `home-page-view`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1ProductDetail> ProductDetails { get; set; }

        /// <summary>
        /// Optional. A transaction represents the entire purchase transaction. Required for `purchase-complete` events.
        /// Optional for `checkout-start` events. Other event types should not set this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTransaction")]
        public virtual GoogleCloudRecommendationengineV1beta1PurchaseTransaction PurchaseTransaction { get; set; }

        /// <summary>
        /// At least one of search_query or page_categories is required for `search` events. Other event types should
        /// not set this field. The user's search query as UTF-8 encoded text with a length limit of 5 KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchQuery")]
        public virtual string SearchQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transaction represents the entire purchase transaction.</summary>
    public class GoogleCloudRecommendationengineV1beta1PurchaseTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. All the costs associated with the product. These can be manufacturing costs, shipping expenses not
        /// borne by the end user, or any other costs. Total product cost such that profit = revenue - (sum(taxes) +
        /// sum(costs)) If product_cost is not set, then profit = revenue - tax - shipping - sum(CatalogItem.costs). If
        /// CatalogItem.cost is not specified for one of the items, CatalogItem.cost based profit *cannot* be calculated
        /// for this Transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costs")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<float>> Costs { get; set; }

        /// <summary>
        /// Required. Currency code. Use three-character ISO-4217 code. This field is not required if the event type is
        /// `refund`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Optional. The transaction ID with a length limit of 128 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. Total revenue or grand total associated with the transaction. This value include shipping, tax, or
        /// other adjustments to total revenue that you want to include as part of your revenue calculations. This field
        /// is not required if the event type is `refund`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revenue")]
        public virtual System.Nullable<float> Revenue { get; set; }

        /// <summary>Optional. All the taxes associated with the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxes")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<float>> Taxes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the PurgeUserEvents operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1PurgeUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation create time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The ID of the request / operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationName")]
        public virtual string OperationName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PurgeUserEvents method.</summary>
    public class GoogleCloudRecommendationengineV1beta1PurgeUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The filter string to specify the events to be deleted. Empty string filter is not allowed. The
        /// eligible fields for filtering are: * `eventType`: UserEvent.eventType field of type string. * `eventTime`:
        /// in ISO 8601 "zulu" format. * `visitorId`: field of type string. Specifying this will delete all events
        /// associated with a visitor. * `userId`: field of type string. Specifying this will delete all events
        /// associated with a user. Examples: * Deleting all events in a time range: `eventTime &amp;gt;
        /// "2012-04-23T18:25:43.511Z" eventTime &amp;lt; "2012-04-23T18:30:43.511Z"` * Deleting specific eventType in
        /// time range: `eventTime &amp;gt; "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"` * Deleting all
        /// events for a specific visitor: `visitorId = "visitor1024"` The filtering fields are assumed to have an
        /// implicit AND.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. The default value is false. Override this flag to true to actually perform the purge. If the field
        /// is not set to true, a sampling of events to be deleted will be returned.
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
    public class GoogleCloudRecommendationengineV1beta1PurgeUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of events purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgedEventsCount")]
        public virtual System.Nullable<long> PurgedEventsCount { get; set; }

        /// <summary>
        /// A sampling of events deleted (or will be deleted) depending on the `force` property in the request. Max of
        /// 500 items will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEventsSample")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1UserEvent> UserEventsSample { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for RejoinUserEvents method.</summary>
    public class GoogleCloudRecommendationengineV1beta1RejoinUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CatalogRejoin method.</summary>
    public class GoogleCloudRecommendationengineV1beta1RejoinUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The type of the catalog rejoin to define the scope and range of the user events to be rejoined
        /// with catalog items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEventRejoinScope")]
        public virtual string UserEventRejoinScope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RejoinUserEvents method.</summary>
    public class GoogleCloudRecommendationengineV1beta1RejoinUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of user events that were joined with latest catalog items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejoinedUserEventsCount")]
        public virtual System.Nullable<long> RejoinedUserEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UserEvent captures all metadata information recommendation engine needs to know about how end users interact
    /// with customers' website.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1UserEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. User event detailed information common across different recommendation types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDetail")]
        public virtual GoogleCloudRecommendationengineV1beta1EventDetail EventDetail { get; set; }

        /// <summary>
        /// Optional. This field should *not* be set when using JavaScript pixel or the Recommendations AI Tag. Defaults
        /// to `EVENT_SOURCE_UNSPECIFIED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventSource")]
        public virtual string EventSource { get; set; }

        /// <summary>Optional. Only required for ImportUserEvents method. Timestamp of user event created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// Required. User event type. Allowed values are: * `add-to-cart` Products being added to cart. * `add-to-list`
        /// Items being added to a list (shopping list, favorites etc). * `category-page-view` Special pages such as
        /// sale or promotion pages viewed. * `checkout-start` User starting a checkout process. * `detail-page-view`
        /// Products detail page viewed. * `home-page-view` Homepage viewed. * `page-visit` Generic page visits not
        /// included in the event types above. * `purchase-complete` User finishing a purchase. * `refund` Purchased
        /// items being refunded or returned. * `remove-from-cart` Products being removed from cart. *
        /// `remove-from-list` Items being removed from a list. * `search` Product search. * `shopping-cart-page-view`
        /// User viewing a shopping cart. * `impression` List of items displayed. Used by Google Tag Manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// Optional. Retail product specific user event metadata. This field is required for the following event types:
        /// * `add-to-cart` * `add-to-list` * `category-page-view` * `checkout-start` * `detail-page-view` *
        /// `purchase-complete` * `refund` * `remove-from-cart` * `remove-from-list` * `search` This field is optional
        /// for the following event types: * `page-visit` * `shopping-cart-page-view` - note that 'product_event_detail'
        /// should be set for this unless the shopping cart is empty. This field is not allowed for the following event
        /// types: * `home-page-view`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productEventDetail")]
        public virtual GoogleCloudRecommendationengineV1beta1ProductEventDetail ProductEventDetail { get; set; }

        /// <summary>Required. User information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudRecommendationengineV1beta1UserInfo UserInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A summary of import result. The UserEventImportSummary summarizes the import status for user events.
    /// </summary>
    public class GoogleCloudRecommendationengineV1beta1UserEventImportSummary : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudRecommendationengineV1beta1UserEventInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of user events to import. Recommended max of 10k items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommendationengineV1beta1UserEvent> UserEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information of end users.</summary>
    public class GoogleCloudRecommendationengineV1beta1UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Indicates if the request is made directly from the end user in which case the user_agent and
        /// ip_address fields can be populated from the HTTP request. This should *not* be set when using the javascript
        /// pixel. This flag should be set only if the API request is made directly from the end user such as a mobile
        /// app (and not if a gateway or a server is processing and pushing the user events).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directUserRequest")]
        public virtual System.Nullable<bool> DirectUserRequest { get; set; }

        /// <summary>
        /// Optional. IP address of the user. This could be either IPv4 (e.g. 104.133.9.80) or IPv6 (e.g.
        /// 2001:0db8:85a3:0000:0000:8a2e:0370:7334). This should *not* be set when using the javascript pixel or if
        /// `direct_user_request` is set. Used to extract location information for personalization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// Optional. User agent as included in the HTTP header. UTF-8 encoded string with a length limit of 1 KiB. This
        /// should *not* be set when using the JavaScript pixel or if `directUserRequest` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Optional. Unique identifier for logged-in user with a length limit of 128 bytes. Required only for logged-in
        /// users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>
        /// Required. A unique identifier for tracking visitors with a length limit of 128 bytes. For example, this
        /// could be implemented with an HTTP cookie, which should be able to uniquely identify a visitor on a single
        /// device. This unique identifier should not change if the visitor logs in or out of the website. Maximum
        /// length 128 bytes. Cannot be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitorId")]
        public virtual string VisitorId { get; set; }

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
