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

namespace Google.Apis.DataCatalog.v1
{
    /// <summary>The DataCatalog Service.</summary>
    public class DataCatalogService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataCatalogService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataCatalogService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Catalog = new CatalogResource(this);
            Entries = new EntriesResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datacatalog";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://datacatalog.googleapis.com/";
        #else
            "https://datacatalog.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://datacatalog.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Data Catalog API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Cloud Data Catalog API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Catalog resource.</summary>
        public virtual CatalogResource Catalog { get; }

        /// <summary>Gets the Entries resource.</summary>
        public virtual EntriesResource Entries { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for DataCatalog requests.</summary>
    public abstract class DataCatalogBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataCatalogBaseServiceRequest instance.</summary>
        protected DataCatalogBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DataCatalog parameter list.</summary>
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

    /// <summary>The "catalog" collection of methods.</summary>
    public class CatalogResource
    {
        private const string Resource = "catalog";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CatalogResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that match a query. This is a [Custom
        /// Method] (https://cloud.google.com/apis/design/custom_methods) that doesn't return all information on a
        /// resource, only its ID and high level fields. To get more information, you can subsequently call specific get
        /// methods. Note: Data Catalog search queries don't guarantee full recall. Results that match your query might
        /// not be returned, even in subsequent result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries. For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1SearchCatalogRequest body)
        {
            return new SearchRequest(service, body);
        }

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that match a query. This is a [Custom
        /// Method] (https://cloud.google.com/apis/design/custom_methods) that doesn't return all information on a
        /// resource, only its ID and high level fields. To get more information, you can subsequently call specific get
        /// methods. Note: Data Catalog search queries don't guarantee full recall. Results that match your query might
        /// not be returned, even in subsequent result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries. For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        public class SearchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1SearchCatalogResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1SearchCatalogRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1SearchCatalogRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/catalog:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "entries" collection of methods.</summary>
    public class EntriesResource
    {
        private const string Resource = "entries";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EntriesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets an entry by its target resource name. The resource name comes from the source Google Cloud Platform
        /// service.
        /// </summary>
        public virtual LookupRequest Lookup()
        {
            return new LookupRequest(service);
        }

        /// <summary>
        /// Gets an entry by its target resource name. The resource name comes from the source Google Cloud Platform
        /// service.
        /// </summary>
        public class LookupRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Fully qualified name (FQN) of the resource. FQNs take two forms: * For non-regionalized resources:
            /// `{SYSTEM}:{PROJECT}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}` * For regionalized resources:
            /// `{SYSTEM}:{PROJECT}.{LOCATION_ID}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}` Example for a DPMS table:
            /// `dataproc_metastore:{PROJECT_ID}.{LOCATION_ID}.{INSTANCE_ID}.{DATABASE_ID}.{TABLE_ID}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("fullyQualifiedName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string FullyQualifiedName { get; set; }

            /// <summary>
            /// The full name of the Google Cloud Platform resource the Data Catalog entry represents. For more
            /// information, see [Full Resource Name]
            /// (https://cloud.google.com/apis/design/resource_names#full_resource_name). Full names are case-sensitive.
            /// For example: * `//bigquery.googleapis.com/projects/{PROJECT_ID}/datasets/{DATASET_ID}/tables/{TABLE_ID}`
            /// * `//pubsub.googleapis.com/projects/{PROJECT_ID}/topics/{TOPIC_ID}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("linkedResource", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LinkedResource { get; set; }

            /// <summary>
            /// The SQL name of the entry. SQL names are case-sensitive. Examples: * `pubsub.{PROJECT_ID}.{TOPIC_ID}` *
            /// `pubsub.{PROJECT_ID}.{TOPIC.ID.SEPARATED.WITH.DOTS}` *
            /// `bigquery.table.{PROJECT_ID}.{DATASET_ID}.{TABLE_ID}` * `bigquery.dataset.{PROJECT_ID}.{DATASET_ID}` *
            /// `datacatalog.entry.{PROJECT_ID}.{LOCATION_ID}.{ENTRY_GROUP_ID}.{ENTRY_ID}` Identifiers (`*_ID`) should
            /// comply with the [Lexical structure in Standard SQL]
            /// (https://cloud.google.com/bigquery/docs/reference/standard-sql/lexical).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sqlResource", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SqlResource { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/entries:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("fullyQualifiedName", new Google.Apis.Discovery.Parameter
                {
                    Name = "fullyQualifiedName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("linkedResource", new Google.Apis.Discovery.Parameter
                {
                    Name = "linkedResource",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sqlResource", new Google.Apis.Discovery.Parameter
                {
                    Name = "sqlResource",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
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
                EntryGroups = new EntryGroupsResource(service);
                TagTemplates = new TagTemplatesResource(service);
                Taxonomies = new TaxonomiesResource(service);
            }

            /// <summary>Gets the EntryGroups resource.</summary>
            public virtual EntryGroupsResource EntryGroups { get; }

            /// <summary>The "entryGroups" collection of methods.</summary>
            public class EntryGroupsResource
            {
                private const string Resource = "entryGroups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EntryGroupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Entries = new EntriesResource(service);
                    Tags = new TagsResource(service);
                }

                /// <summary>Gets the Entries resource.</summary>
                public virtual EntriesResource Entries { get; }

                /// <summary>The "entries" collection of methods.</summary>
                public class EntriesResource
                {
                    private const string Resource = "entries";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EntriesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Tags = new TagsResource(service);
                    }

                    /// <summary>Gets the Tags resource.</summary>
                    public virtual TagsResource Tags { get; }

                    /// <summary>The "tags" collection of methods.</summary>
                    public class TagsResource
                    {
                        private const string Resource = "tags";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TagsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Creates a tag and assigns it to: * An Entry if the method name is
                        /// ``projects.locations.entryGroups.entries.tags.create``. * Or EntryGroupif the method name is
                        /// ``projects.locations.entryGroups.tags.create``. Note: The project identified by the `parent`
                        /// parameter for the [tag]
                        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                        /// and the [tag template]
                        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
                        /// used to create the tag must be in the same organization.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The name of the resource to attach this tag to. Tags can be attached to entries or
                        /// entry groups. An entry can have up to 1000 attached tags. Note: The tag and its child
                        /// resources might not be stored in the location specified in its name.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Creates a tag and assigns it to: * An Entry if the method name is
                        /// ``projects.locations.entryGroups.entries.tags.create``. * Or EntryGroupif the method name is
                        /// ``projects.locations.entryGroups.tags.create``. Note: The project identified by the `parent`
                        /// parameter for the [tag]
                        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                        /// and the [tag template]
                        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
                        /// used to create the tag must be in the same organization.
                        /// </summary>
                        public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the resource to attach this tag to. Tags can be attached to
                            /// entries or entry groups. An entry can have up to 1000 attached tags. Note: The tag and
                            /// its child resources might not be stored in the location specified in its name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tags";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Deletes a tag.</summary>
                        /// <param name="name">Required. The name of the tag to delete. </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes a tag.</summary>
                        public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the tag to delete. </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+/tags/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists tags assigned to an Entry.</summary>
                        /// <param name="parent">
                        /// Required. The name of the Data Catalog resource to list the tags of. The resource can be an
                        /// Entry or an EntryGroup (without `/entries/{entries}` at the end).
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists tags assigned to an Entry.</summary>
                        public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ListTagsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the Data Catalog resource to list the tags of. The resource can be
                            /// an Entry or an EntryGroup (without `/entries/{entries}` at the end).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of tags to return. Default is 10. Maximum limit is 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Pagination token that specifies the next page to return. If empty, the first page is
                            /// returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tags";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
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

                        /// <summary>Updates an existing tag.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// The resource name of the tag in URL format where tag ID is a system-generated identifier.
                        /// Note: The tag itself might not be stored in the location specified in its name.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates an existing tag.</summary>
                        public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// The resource name of the tag in URL format where tag ID is a system-generated
                            /// identifier. Note: The tag itself might not be stored in the location specified in its
                            /// name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Names of fields whose values to overwrite on a tag. Currently, a tag has the only
                            /// modifiable field with the name `fields`. In general, if this parameter is absent or
                            /// empty, all modifiable fields are overwritten. If such fields are non-required and
                            /// omitted in the request body, their values are emptied.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+/tags/[^/]+$",
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

                    /// <summary>
                    /// Creates an entry. You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM', or
                    /// custom types. Data Catalog automatically creates entries with other types during metadata
                    /// ingestion from integrated systems. You must enable the Data Catalog API in the project
                    /// identified by the `parent` parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project). An entry group
                    /// can have a maximum of 100,000 entries.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the entry group this entry belongs to. Note: The entry itself and its
                    /// child resources might not be stored in the location specified in its name.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates an entry. You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM', or
                    /// custom types. Data Catalog automatically creates entries with other types during metadata
                    /// ingestion from integrated systems. You must enable the Data Catalog API in the project
                    /// identified by the `parent` parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project). An entry group
                    /// can have a maximum of 100,000 entries.
                    /// </summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the entry group this entry belongs to. Note: The entry itself and its
                        /// child resources might not be stored in the location specified in its name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the entry to create. The ID must contain only letters (a-z, A-Z),
                        /// numbers (0-9), and underscores (_). The maximum size is 64 bytes when encoded in UTF-8.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("entryId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string EntryId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/entries";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
                            });
                            RequestParameters.Add("entryId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "entryId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes an existing entry. You can delete only the entries created by the CreateEntry method.
                    /// You must enable the Data Catalog API in the project identified by the `name` parameter. For more
                    /// information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    /// <param name="name">Required. The name of the entry to delete. </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes an existing entry. You can delete only the entries created by the CreateEntry method.
                    /// You must enable the Data Catalog API in the project identified by the `name` parameter. For more
                    /// information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the entry to delete. </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an entry.</summary>
                    /// <param name="name">Required. The name of the entry to get. </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets an entry.</summary>
                    public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the entry to get. </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                    /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource
                    /// exists but doesn't have a set policy. Supported resources are: - Tag templates - Entry groups
                    /// Note: This method doesn't get policies from Google Cloud Platform resources ingested into Data
                    /// Catalog. To call this method, you must have the following Google IAM permissions: -
                    /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                    /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                    /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource
                    /// exists but doesn't have a set policy. Supported resources are: - Tag templates - Entry groups
                    /// Note: This method doesn't get policies from Google Cloud Platform resources ingested into Data
                    /// Catalog. To call this method, you must have the following Google IAM permissions: -
                    /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                    /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                    /// </summary>
                    public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists entries.</summary>
                    /// <param name="parent">
                    /// Required. The name of the entry group that contains the entries to list. Can be provided in URL
                    /// format.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists entries.</summary>
                    public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ListEntriesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the entry group that contains the entries to list. Can be provided in
                        /// URL format.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of items to return. Default is 10. Maximum limit is 1000. Throws an
                        /// invalid argument if `page_size` is more than 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Pagination token that specifies the next page to return. If empty, the first page is
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// The fields to return for each entry. If empty or omitted, all fields are returned. For
                        /// example, to return a list of entries with only the `name` field, set `read_mask` to only one
                        /// path with the `name` value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/entries";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
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
                        }
                    }

                    /// <summary>
                    /// Updates an existing entry. You must enable the Data Catalog API in the project identified by the
                    /// `entry.name` parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of an entry in URL format. Note: The entry itself and its child
                    /// resources might not be stored in the location specified in its name.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates an existing entry. You must enable the Data Catalog API in the project identified by the
                    /// `entry.name` parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of an entry in URL format. Note: The entry itself and its
                        /// child resources might not be stored in the location specified in its name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Names of fields whose values to overwrite on an entry. If this parameter is absent or empty,
                        /// all modifiable fields are overwritten. If such fields are non-required and omitted in the
                        /// request body, their values are emptied. You can modify only the fields listed below. For
                        /// entries with type `DATA_STREAM`: * `schema` For entries with type `FILESET`: * `schema` *
                        /// `display_name` * `description` * `gcs_fileset_spec` * `gcs_fileset_spec.file_patterns` For
                        /// entries with `user_specified_type`: * `schema` * `display_name` * `description` *
                        /// `user_specified_type` * `user_specified_system` * `linked_resource` *
                        /// `source_system_timestamps`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Entry Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
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
                    /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                    /// exist. Supported resources are: - Tag templates - Entry groups Note: This method gets policies
                    /// only within Data Catalog and can't be used to get policies from BigQuery, Pub/Sub, Dataproc
                    /// Metastore, and any external Google Cloud Platform resources ingested into Data Catalog. No
                    /// Google IAM permissions are required to call this method.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                    /// exist. Supported resources are: - Tag templates - Entry groups Note: This method gets policies
                    /// only within Data Catalog and can't be used to get policies from BigQuery, Pub/Sub, Dataproc
                    /// Metastore, and any external Google Cloud Platform resources ingested into Data Catalog. No
                    /// Google IAM permissions are required to call this method.
                    /// </summary>
                    public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Tags resource.</summary>
                public virtual TagsResource Tags { get; }

                /// <summary>The "tags" collection of methods.</summary>
                public class TagsResource
                {
                    private const string Resource = "tags";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TagsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a tag and assigns it to: * An Entry if the method name is
                    /// ``projects.locations.entryGroups.entries.tags.create``. * Or EntryGroupif the method name is
                    /// ``projects.locations.entryGroups.tags.create``. Note: The project identified by the `parent`
                    /// parameter for the [tag]
                    /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                    /// and the [tag template]
                    /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
                    /// used to create the tag must be in the same organization.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the resource to attach this tag to. Tags can be attached to entries or
                    /// entry groups. An entry can have up to 1000 attached tags. Note: The tag and its child resources
                    /// might not be stored in the location specified in its name.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a tag and assigns it to: * An Entry if the method name is
                    /// ``projects.locations.entryGroups.entries.tags.create``. * Or EntryGroupif the method name is
                    /// ``projects.locations.entryGroups.tags.create``. Note: The project identified by the `parent`
                    /// parameter for the [tag]
                    /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                    /// and the [tag template]
                    /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
                    /// used to create the tag must be in the same organization.
                    /// </summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource to attach this tag to. Tags can be attached to entries or
                        /// entry groups. An entry can have up to 1000 attached tags. Note: The tag and its child
                        /// resources might not be stored in the location specified in its name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/tags";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a tag.</summary>
                    /// <param name="name">Required. The name of the tag to delete. </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a tag.</summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the tag to delete. </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/tags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists tags assigned to an Entry.</summary>
                    /// <param name="parent">
                    /// Required. The name of the Data Catalog resource to list the tags of. The resource can be an
                    /// Entry or an EntryGroup (without `/entries/{entries}` at the end).
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists tags assigned to an Entry.</summary>
                    public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ListTagsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Data Catalog resource to list the tags of. The resource can be an
                        /// Entry or an EntryGroup (without `/entries/{entries}` at the end).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of tags to return. Default is 10. Maximum limit is 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Pagination token that specifies the next page to return. If empty, the first page is
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/tags";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
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

                    /// <summary>Updates an existing tag.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The resource name of the tag in URL format where tag ID is a system-generated identifier. Note:
                    /// The tag itself might not be stored in the location specified in its name.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates an existing tag.</summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name of the tag in URL format where tag ID is a system-generated identifier.
                        /// Note: The tag itself might not be stored in the location specified in its name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Names of fields whose values to overwrite on a tag. Currently, a tag has the only modifiable
                        /// field with the name `fields`. In general, if this parameter is absent or empty, all
                        /// modifiable fields are overwritten. If such fields are non-required and omitted in the
                        /// request body, their values are emptied.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Tag Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/tags/[^/]+$",
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

                /// <summary>
                /// Creates an entry group. An entry group contains logically related entries together with [Cloud
                /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies. These policies specify
                /// users who can create, edit, and view entries within entry groups. Data Catalog automatically creates
                /// entry groups with names that start with the `@` symbol for the following resources: * BigQuery
                /// entries (`@bigquery`) * Pub/Sub topics (`@pubsub`) * Dataproc Metastore services
                /// (`@dataproc_metastore_{SERVICE_NAME_HASH}`) You can create your own entry groups for Cloud Storage
                /// fileset entries and custom entries together with the corresponding IAM policies. User-created entry
                /// groups can't contain the `@` symbol, it is reserved for automatically created groups. Entry groups,
                /// like entries, can be searched. A maximum of 10,000 entry groups may be created per organization
                /// across all locations. You must enable the Data Catalog API in the project identified by the `parent`
                /// parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The names of the project and location that the new entry group belongs to. Note: The entry
                /// group itself and its child resources might not be stored in the location specified in its name.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates an entry group. An entry group contains logically related entries together with [Cloud
                /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies. These policies specify
                /// users who can create, edit, and view entries within entry groups. Data Catalog automatically creates
                /// entry groups with names that start with the `@` symbol for the following resources: * BigQuery
                /// entries (`@bigquery`) * Pub/Sub topics (`@pubsub`) * Dataproc Metastore services
                /// (`@dataproc_metastore_{SERVICE_NAME_HASH}`) You can create your own entry groups for Cloud Storage
                /// fileset entries and custom entries together with the corresponding IAM policies. User-created entry
                /// groups can't contain the `@` symbol, it is reserved for automatically created groups. Entry groups,
                /// like entries, can be searched. A maximum of 10,000 entry groups may be created per organization
                /// across all locations. You must enable the Data Catalog API in the project identified by the `parent`
                /// parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The names of the project and location that the new entry group belongs to. Note: The
                    /// entry group itself and its child resources might not be stored in the location specified in its
                    /// name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the entry group to create. The ID must contain only letters (a-z, A-Z),
                    /// numbers (0-9), underscores (_), and must start with a letter or underscore. The maximum size is
                    /// 64 bytes when encoded in UTF-8.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("entryGroupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EntryGroupId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/entryGroups";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("entryGroupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "entryGroupId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes an entry group. You must enable the Data Catalog API in the project identified by the `name`
                /// parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                /// <param name="name">Required. The name of the entry group to delete. </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an entry group. You must enable the Data Catalog API in the project identified by the `name`
                /// parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the entry group to delete. </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. If true, deletes all entries in the entry group.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets an entry group.</summary>
                /// <param name="name">Required. The name of the entry group to get. </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets an entry group.</summary>
                public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the entry group to get. </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The fields to return. If empty or omitted, all fields are returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
                        });
                        RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource exists
                /// but doesn't have a set policy. Supported resources are: - Tag templates - Entry groups Note: This
                /// method doesn't get policies from Google Cloud Platform resources ingested into Data Catalog. To call
                /// this method, you must have the following Google IAM permissions: -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource exists
                /// but doesn't have a set policy. Supported resources are: - Tag templates - Entry groups Note: This
                /// method doesn't get policies from Google Cloud Platform resources ingested into Data Catalog. To call
                /// this method, you must have the following Google IAM permissions: -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists entry groups.</summary>
                /// <param name="parent">
                /// Required. The name of the location that contains the entry groups to list. Can be provided as a URL.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists entry groups.</summary>
                public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ListEntryGroupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the location that contains the entry groups to list. Can be provided as a
                    /// URL.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. Default is 10. Maximum limit is 1000. Throws an
                    /// invalid argument if `page_size` is greater than 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Pagination token that specifies the next page to return. If empty, returns the first
                    /// page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/entryGroups";

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

                /// <summary>
                /// Updates an entry group. You must enable the Data Catalog API in the project identified by the
                /// `entry_group.name` parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the entry group in URL format. Note: The entry group itself and its child
                /// resources might not be stored in the location specified in its name.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates an entry group. You must enable the Data Catalog API in the project identified by the
                /// `entry_group.name` parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the entry group in URL format. Note: The entry group itself and its child
                    /// resources might not be stored in the location specified in its name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Names of fields whose values to overwrite on an entry group. If this parameter is absent or
                    /// empty, all modifiable fields are overwritten. If such fields are non-required and omitted in the
                    /// request body, their values are emptied.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1EntryGroup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
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
                /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources are:
                /// - Tag templates - Entry groups Note: This method sets policies only within Data Catalog and can't be
                /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any external Google Cloud
                /// Platform resources synced with the Data Catalog. To call this method, you must have the following
                /// Google IAM permissions: - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag templates.
                /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources are:
                /// - Tag templates - Entry groups Note: This method sets policies only within Data Catalog and can't be
                /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any external Google Cloud
                /// Platform resources synced with the Data Catalog. To call this method, you must have the following
                /// Google IAM permissions: - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag templates.
                /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                /// exist. Supported resources are: - Tag templates - Entry groups Note: This method gets policies only
                /// within Data Catalog and can't be used to get policies from BigQuery, Pub/Sub, Dataproc Metastore,
                /// and any external Google Cloud Platform resources ingested into Data Catalog. No Google IAM
                /// permissions are required to call this method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                /// exist. Supported resources are: - Tag templates - Entry groups Note: This method gets policies only
                /// within Data Catalog and can't be used to get policies from BigQuery, Pub/Sub, Dataproc Metastore,
                /// and any external Google Cloud Platform resources ingested into Data Catalog. No Google IAM
                /// permissions are required to call this method.
                /// </summary>
                public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the TagTemplates resource.</summary>
            public virtual TagTemplatesResource TagTemplates { get; }

            /// <summary>The "tagTemplates" collection of methods.</summary>
            public class TagTemplatesResource
            {
                private const string Resource = "tagTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TagTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Fields = new FieldsResource(service);
                }

                /// <summary>Gets the Fields resource.</summary>
                public virtual FieldsResource Fields { get; }

                /// <summary>The "fields" collection of methods.</summary>
                public class FieldsResource
                {
                    private const string Resource = "fields";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FieldsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        EnumValues = new EnumValuesResource(service);
                    }

                    /// <summary>Gets the EnumValues resource.</summary>
                    public virtual EnumValuesResource EnumValues { get; }

                    /// <summary>The "enumValues" collection of methods.</summary>
                    public class EnumValuesResource
                    {
                        private const string Resource = "enumValues";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public EnumValuesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Renames an enum value in a tag template. Within a single enum field, enum values must be
                        /// unique.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The name of the enum field value. </param>
                        public virtual RenameRequest Rename(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1RenameTagTemplateFieldEnumValueRequest body, string name)
                        {
                            return new RenameRequest(service, body, name);
                        }

                        /// <summary>
                        /// Renames an enum value in a tag template. Within a single enum field, enum values must be
                        /// unique.
                        /// </summary>
                        public class RenameRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField>
                        {
                            /// <summary>Constructs a new Rename request.</summary>
                            public RenameRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1RenameTagTemplateFieldEnumValueRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the enum field value. </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1RenameTagTemplateFieldEnumValueRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "rename";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:rename";

                            /// <summary>Initializes Rename parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+/fields/[^/]+/enumValues/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Creates a field in a tag template. You must enable the Data Catalog API in the project
                    /// identified by the `parent` parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the project and the template location
                    /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a field in a tag template. You must enable the Data Catalog API in the project
                    /// identified by the `parent` parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the project and the template location
                        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the tag template field to create. Note: Adding a required field to an
                        /// existing template is *not* allowed. Field IDs can contain letters (both uppercase and
                        /// lowercase), numbers (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
                        /// character long and at most 128 characters long. Field IDs must also be unique within their
                        /// template.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("tagTemplateFieldId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string TagTemplateFieldId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/fields";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
                            });
                            RequestParameters.Add("tagTemplateFieldId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "tagTemplateFieldId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a field in a tag template and all uses of this field from the tags based on this
                    /// template. You must enable the Data Catalog API in the project identified by the `name`
                    /// parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    /// <param name="name">Required. The name of the tag template field to delete. </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a field in a tag template and all uses of this field from the tags based on this
                    /// template. You must enable the Data Catalog API in the project identified by the `name`
                    /// parameter. For more information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the tag template field to delete. </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. If true, deletes this field from any tags that use it. Currently, `true` is the
                        /// only supported value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+/fields/[^/]+$",
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Updates a field in a tag template. You can't update the field type with this method. You must
                    /// enable the Data Catalog API in the project identified by the `name` parameter. For more
                    /// information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The name of the tag template field. </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a field in a tag template. You can't update the field type with this method. You must
                    /// enable the Data Catalog API in the project identified by the `name` parameter. For more
                    /// information, see [Data Catalog resource
                    /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the tag template field. </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Names of fields whose values to overwrite on an individual field of a tag
                        /// template. The following fields are modifiable: * `display_name` * `type.enum_type` *
                        /// `is_required` If this parameter is absent or empty, all modifiable fields are overwritten.
                        /// If such fields are non-required and omitted in the request body, their values are emptied
                        /// with one exception: when updating an enum type, the provided values are merged with the
                        /// existing values. Therefore, enum values can only be added, existing enum values cannot be
                        /// deleted or renamed. Additionally, updating a template field from optional to required is
                        /// *not* allowed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+/fields/[^/]+$",
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
                    /// Renames a field in a tag template. You must enable the Data Catalog API in the project
                    /// identified by the `name` parameter. For more information, see [Data Catalog resource project]
                    /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The name of the tag template. </param>
                    public virtual RenameRequest Rename(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1RenameTagTemplateFieldRequest body, string name)
                    {
                        return new RenameRequest(service, body, name);
                    }

                    /// <summary>
                    /// Renames a field in a tag template. You must enable the Data Catalog API in the project
                    /// identified by the `name` parameter. For more information, see [Data Catalog resource project]
                    /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                    /// </summary>
                    public class RenameRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplateField>
                    {
                        /// <summary>Constructs a new Rename request.</summary>
                        public RenameRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1RenameTagTemplateFieldRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the tag template. </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1RenameTagTemplateFieldRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rename";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:rename";

                        /// <summary>Initializes Rename parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+/fields/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a tag template. You must enable the Data Catalog API in the project identified by the
                /// `parent` parameter. For more information, see [Data Catalog resource project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the project and the template location
                /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a tag template. You must enable the Data Catalog API in the project identified by the
                /// `parent` parameter. For more information, see [Data Catalog resource project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the project and the template location
                    /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the tag template to create. The ID must contain only lowercase letters
                    /// (a-z), numbers (0-9), or underscores (_), and must start with a letter or underscore. The
                    /// maximum size is 64 bytes when encoded in UTF-8.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("tagTemplateId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TagTemplateId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/tagTemplates";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("tagTemplateId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tagTemplateId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a tag template and all tags that use it. You must enable the Data Catalog API in the project
                /// identified by the `name` parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                /// <param name="name">Required. The name of the tag template to delete. </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a tag template and all tags that use it. You must enable the Data Catalog API in the project
                /// identified by the `name` parameter. For more information, see [Data Catalog resource
                /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the tag template to delete. </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. If true, deletes all tags that use this template. Currently, `true` is the only
                    /// supported value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a tag template.</summary>
                /// <param name="name">Required. The name of the tag template to get. </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a tag template.</summary>
                public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the tag template to get. </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource exists
                /// but doesn't have a set policy. Supported resources are: - Tag templates - Entry groups Note: This
                /// method doesn't get policies from Google Cloud Platform resources ingested into Data Catalog. To call
                /// this method, you must have the following Google IAM permissions: -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. May return: * A`NOT_FOUND` error if the resource
                /// doesn't exist or you don't have the permission to view it. * An empty policy if the resource exists
                /// but doesn't have a set policy. Supported resources are: - Tag templates - Entry groups Note: This
                /// method doesn't get policies from Google Cloud Platform resources ingested into Data Catalog. To call
                /// this method, you must have the following Google IAM permissions: -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates a tag template. You can't update template fields with this method. These fields are separate
                /// resources with their own create, update, and delete methods. You must enable the Data Catalog API in
                /// the project identified by the `tag_template.name` parameter. For more information, see [Data Catalog
                /// resource project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the tag template in URL format. Note: The tag template itself and its child
                /// resources might not be stored in the location specified in its name.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a tag template. You can't update template fields with this method. These fields are separate
                /// resources with their own create, update, and delete methods. You must enable the Data Catalog API in
                /// the project identified by the `tag_template.name` parameter. For more information, see [Data Catalog
                /// resource project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
                /// </summary>
                public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the tag template in URL format. Note: The tag template itself and its child
                    /// resources might not be stored in the location specified in its name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Names of fields whose values to overwrite on a tag template. Currently, only `display_name` can
                    /// be overwritten. If this parameter is absent or empty, all modifiable fields are overwritten. If
                    /// such fields are non-required and omitted in the request body, their values are emptied.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1TagTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
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
                /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources are:
                /// - Tag templates - Entry groups Note: This method sets policies only within Data Catalog and can't be
                /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any external Google Cloud
                /// Platform resources synced with the Data Catalog. To call this method, you must have the following
                /// Google IAM permissions: - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag templates.
                /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets an access control policy for a resource. Replaces any existing policy. Supported resources are:
                /// - Tag templates - Entry groups Note: This method sets policies only within Data Catalog and can't be
                /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any external Google Cloud
                /// Platform resources synced with the Data Catalog. To call this method, you must have the following
                /// Google IAM permissions: - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag templates.
                /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                /// exist. Supported resources are: - Tag templates - Entry groups Note: This method gets policies only
                /// within Data Catalog and can't be used to get policies from BigQuery, Pub/Sub, Dataproc Metastore,
                /// and any external Google Cloud Platform resources ingested into Data Catalog. No Google IAM
                /// permissions are required to call this method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Gets your permissions on a resource. Returns an empty set of permissions if the resource doesn't
                /// exist. Supported resources are: - Tag templates - Entry groups Note: This method gets policies only
                /// within Data Catalog and can't be used to get policies from BigQuery, Pub/Sub, Dataproc Metastore,
                /// and any external Google Cloud Platform resources ingested into Data Catalog. No Google IAM
                /// permissions are required to call this method.
                /// </summary>
                public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Taxonomies resource.</summary>
            public virtual TaxonomiesResource Taxonomies { get; }

            /// <summary>The "taxonomies" collection of methods.</summary>
            public class TaxonomiesResource
            {
                private const string Resource = "taxonomies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TaxonomiesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    PolicyTags = new PolicyTagsResource(service);
                }

                /// <summary>Gets the PolicyTags resource.</summary>
                public virtual PolicyTagsResource PolicyTags { get; }

                /// <summary>The "policyTags" collection of methods.</summary>
                public class PolicyTagsResource
                {
                    private const string Resource = "policyTags";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PolicyTagsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a policy tag in a taxonomy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Resource name of the taxonomy that the policy tag will belong to.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a policy tag in a taxonomy.</summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the taxonomy that the policy tag will belong to.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/policyTags";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a policy tag together with the following: * All of its descendant policy tags, if any *
                    /// Policies associated with the policy tag and its descendants * References from BigQuery table
                    /// schema of the policy tag and its descendants
                    /// </summary>
                    /// <param name="name">
                    /// Required. Resource name of the policy tag to delete. Note: All of its descendant policy tags are
                    /// also deleted.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a policy tag together with the following: * All of its descendant policy tags, if any *
                    /// Policies associated with the policy tag and its descendants * References from BigQuery table
                    /// schema of the policy tag and its descendants
                    /// </summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the policy tag to delete. Note: All of its descendant policy tags
                        /// are also deleted.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a policy tag.</summary>
                    /// <param name="name">Required. Resource name of the policy tag. </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a policy tag.</summary>
                    public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Resource name of the policy tag. </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the IAM policy for a policy tag or a taxonomy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>Gets the IAM policy for a policy tag or a taxonomy.</summary>
                    public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all policy tags in a taxonomy.</summary>
                    /// <param name="parent">
                    /// Required. Resource name of the taxonomy to list the policy tags of.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all policy tags in a taxonomy.</summary>
                    public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ListPolicyTagsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Resource name of the taxonomy to list the policy tags of. </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of items to return. Must be a value between 1 and 1000 inclusively. If
                        /// not set, defaults to 50.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The pagination token of the next results page. If not set, returns the first page. The token
                        /// is returned in the response to a previous list request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/policyTags";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
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
                    /// Updates a policy tag, including its display name, description, and parent policy tag.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Resource name of this policy tag in the URL format. The policy tag manager
                    /// generates unique taxonomy IDs and policy tag IDs.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a policy tag, including its display name, description, and parent policy tag.
                    /// </summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Resource name of this policy tag in the URL format. The policy tag manager
                        /// generates unique taxonomy IDs and policy tag IDs.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Specifies the fields to update. You can update only display name, description, and parent
                        /// policy tag. If not set, defaults to all updatable fields. For more information, see
                        /// [FieldMask]
                        /// (https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1PolicyTag Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
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

                    /// <summary>Sets the IAM policy for a policy tag or a taxonomy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>Sets the IAM policy for a policy tag or a taxonomy.</summary>
                    public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns your permissions on a specified policy tag or taxonomy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>Returns your permissions on a specified policy tag or taxonomy.</summary>
                    public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a taxonomy in a specified project. The taxonomy is initially empty, that is, it doesn't
                /// contain policy tags.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the project that the taxonomy will belong to.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a taxonomy in a specified project. The taxonomy is initially empty, that is, it doesn't
                /// contain policy tags.
                /// </summary>
                public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the project that the taxonomy will belong to. </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/taxonomies";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a taxonomy, including all policy tags in this taxonomy, their associated policies, and the
                /// policy tags references from BigQuery columns.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the taxonomy to delete. Note: All policy tags in this taxonomy are also
                /// deleted.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a taxonomy, including all policy tags in this taxonomy, their associated policies, and the
                /// policy tags references from BigQuery columns.
                /// </summary>
                public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the taxonomy to delete. Note: All policy tags in this taxonomy are
                    /// also deleted.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Exports taxonomies in the requested type and returns them, including their policy tags. The
                /// requested taxonomies must belong to the same project. This method generates `SerializedTaxonomy`
                /// protocol buffers with nested policy tags that can be used as input for `ImportTaxonomies` calls.
                /// </summary>
                /// <param name="parent">
                /// Required. Resource name of the project that the exported taxonomies belong to.
                /// </param>
                public virtual ExportRequest Export(string parent)
                {
                    return new ExportRequest(service, parent);
                }

                /// <summary>
                /// Exports taxonomies in the requested type and returns them, including their policy tags. The
                /// requested taxonomies must belong to the same project. This method generates `SerializedTaxonomy`
                /// protocol buffers with nested policy tags that can be used as input for `ImportTaxonomies` calls.
                /// </summary>
                public class ExportRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ExportTaxonomiesResponse>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project that the exported taxonomies belong to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Serialized export taxonomies that contain all the policy tags as nested protocol buffers.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serializedTaxonomies", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> SerializedTaxonomies { get; set; }

                    /// <summary>Required. Resource names of the taxonomies to export.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("taxonomies", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Taxonomies { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/taxonomies:export";

                    /// <summary>Initializes Export parameter list.</summary>
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
                        RequestParameters.Add("serializedTaxonomies", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serializedTaxonomies",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("taxonomies", new Google.Apis.Discovery.Parameter
                        {
                            Name = "taxonomies",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a taxonomy.</summary>
                /// <param name="name">Required. Resource name of the taxonomy to get. </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a taxonomy.</summary>
                public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the taxonomy to get. </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the IAM policy for a policy tag or a taxonomy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>Gets the IAM policy for a policy tag or a taxonomy.</summary>
                public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates new taxonomies (including their policy tags) in a given project by importing from inlined or
                /// cross-regional sources. For a cross-regional source, new taxonomies are created by copying from a
                /// source in another region. For an inlined source, taxonomies and policy tags are created in bulk
                /// using nested protocol buffer structures.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of project that the imported taxonomies will belong to.
                /// </param>
                public virtual ImportRequest Import(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ImportTaxonomiesRequest body, string parent)
                {
                    return new ImportRequest(service, body, parent);
                }

                /// <summary>
                /// Creates new taxonomies (including their policy tags) in a given project by importing from inlined or
                /// cross-regional sources. For a cross-regional source, new taxonomies are created by copying from a
                /// source in another region. For an inlined source, taxonomies and policy tags are created in bulk
                /// using nested protocol buffer structures.
                /// </summary>
                public class ImportRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ImportTaxonomiesResponse>
                {
                    /// <summary>Constructs a new Import request.</summary>
                    public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ImportTaxonomiesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of project that the imported taxonomies will belong to.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ImportTaxonomiesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "import";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/taxonomies:import";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all taxonomies in a project in a particular location that you have a permission to view.
                /// </summary>
                /// <param name="parent">Required. Resource name of the project to list the taxonomies of. </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists all taxonomies in a project in a particular location that you have a permission to view.
                /// </summary>
                public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ListTaxonomiesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the project to list the taxonomies of. </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of items to return. Must be a value between 1 and 1000 inclusively. If not
                    /// set, defaults to 50.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The pagination token of the next results page. If not set, the first page is returned. The token
                    /// is returned in the response to a previous list request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/taxonomies";

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

                /// <summary>
                /// Updates a taxonomy, including its display name, description, and activated policy types.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of this taxonomy in URL format. Note: Policy tag manager generates unique
                /// taxonomy IDs.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a taxonomy, including its display name, description, and activated policy types.
                /// </summary>
                public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of this taxonomy in URL format. Note: Policy tag manager generates
                    /// unique taxonomy IDs.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Specifies fields to update. If not set, defaults to all fields you can update. For more
                    /// information, see [FieldMask]
                    /// (https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
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
                /// Replaces (updates) a taxonomy and all its policy tags. The taxonomy and its entire hierarchy of
                /// policy tags must be represented literally by `SerializedTaxonomy` and the nested
                /// `SerializedPolicyTag` messages. This operation automatically does the following: - Deletes the
                /// existing policy tags that are missing from the `SerializedPolicyTag`. - Creates policy tags that
                /// don't have resource names. They are considered new. - Updates policy tags with valid resources names
                /// accordingly.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Resource name of the taxonomy to update.</param>
                public virtual ReplaceRequest Replace(Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ReplaceTaxonomyRequest body, string name)
                {
                    return new ReplaceRequest(service, body, name);
                }

                /// <summary>
                /// Replaces (updates) a taxonomy and all its policy tags. The taxonomy and its entire hierarchy of
                /// policy tags must be represented literally by `SerializedTaxonomy` and the nested
                /// `SerializedPolicyTag` messages. This operation automatically does the following: - Deletes the
                /// existing policy tags that are missing from the `SerializedPolicyTag`. - Creates policy tags that
                /// don't have resource names. They are considered new. - Updates policy tags with valid resources names
                /// accordingly.
                /// </summary>
                public class ReplaceRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1Taxonomy>
                {
                    /// <summary>Constructs a new Replace request.</summary>
                    public ReplaceRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ReplaceTaxonomyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the taxonomy to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.GoogleCloudDatacatalogV1ReplaceTaxonomyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "replace";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:replace";

                    /// <summary>Initializes Replace parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }

                /// <summary>Sets the IAM policy for a policy tag or a taxonomy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>Sets the IAM policy for a policy tag or a taxonomy.</summary>
                public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns your permissions on a specified policy tag or taxonomy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>Returns your permissions on a specified policy tag or taxonomy.</summary>
                public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.DataCatalog.v1.Data
{
    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification for the BigQuery connection.</summary>
    public class GoogleCloudDatacatalogV1BigQueryConnectionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specification for the BigQuery connection to a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSql")]
        public virtual GoogleCloudDatacatalogV1CloudSqlBigQueryConnectionSpec CloudSql { get; set; }

        /// <summary>The type of the BigQuery connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>True if there are credentials attached to the BigQuery connection; false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasCredential")]
        public virtual System.Nullable<bool> HasCredential { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification for a group of BigQuery tables with the `[prefix]YYYYMMDD` name pattern. For more information, see
    /// [Introduction to partitioned tables]
    /// (https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding).
    /// </summary>
    public class GoogleCloudDatacatalogV1BigQueryDateShardedSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Data Catalog resource name of the dataset entry the current table belongs to. For example:
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/entrygroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<long> ShardCount { get; set; }

        /// <summary>
        /// Output only. The table name prefix of the shards. The name of any given shard is `[table_prefix]YYYYMMDD`.
        /// For example, for the `MyTable20180101` shard, the `table_prefix` is `MyTable`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tablePrefix")]
        public virtual string TablePrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fields specific for BigQuery routines.</summary>
    public class GoogleCloudDatacatalogV1BigQueryRoutineSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Paths of the imported libraries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importedLibraries")]
        public virtual System.Collections.Generic.IList<string> ImportedLibraries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a BigQuery table.</summary>
    public class GoogleCloudDatacatalogV1BigQueryTableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The table source type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableSourceType")]
        public virtual string TableSourceType { get; set; }

        /// <summary>
        /// Specification of a BigQuery table. Populated only if the `table_source_type` is `BIGQUERY_TABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableSpec")]
        public virtual GoogleCloudDatacatalogV1TableSpec TableSpec { get; set; }

        /// <summary>Table view specification. Populated only if the `table_source_type` is `BIGQUERY_VIEW`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewSpec")]
        public virtual GoogleCloudDatacatalogV1ViewSpec ViewSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification for the BigQuery connection to a Cloud SQL instance.</summary>
    public class GoogleCloudDatacatalogV1CloudSqlBigQueryConnectionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Database name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Cloud SQL instance ID in the format of `project:location:instance`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>Type of the Cloud SQL database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A column within a schema. Columns can be nested inside other columns.</summary>
    public class GoogleCloudDatacatalogV1ColumnSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the column. Must be a UTF-8 string without dots (.). The maximum size is 64 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual string Column { get; set; }

        /// <summary>
        /// Optional. Description of the column. Default value is an empty string. The description must be a UTF-8
        /// string with the maximum size of 2000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A column's mode indicates whether values in this column are required, nullable, or repeated. Only
        /// `NULLABLE`, `REQUIRED`, and `REPEATED` values are supported. Default mode is `NULLABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Optional. Schema of sub-columns. A column can have zero or more sub-columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subcolumns")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1ColumnSchema> Subcolumns { get; set; }

        /// <summary>Required. Type of the column. Must be a UTF-8 string with the maximum size of 128 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cross-regional source used to import an existing taxonomy into a different region.</summary>
    public class GoogleCloudDatacatalogV1CrossRegionalSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource name of the source taxonomy to import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomy")]
        public virtual string Taxonomy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Physical location of an entry.</summary>
    public class GoogleCloudDatacatalogV1DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full name of a resource as defined by the service. For example:
        /// `//bigquery.googleapis.com/projects/{PROJECT_ID}/locations/{LOCATION}/datasets/{DATASET_ID}/tables/{TABLE_ID}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Service that physically stores the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification that applies to a data source connection. Valid only for entries with the `DATA_SOURCE_CONNECTION`
    /// type.
    /// </summary>
    public class GoogleCloudDatacatalogV1DataSourceConnectionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fields specific to BigQuery connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryConnectionSpec")]
        public virtual GoogleCloudDatacatalogV1BigQueryConnectionSpec BigqueryConnectionSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to a table resource. Valid only for entries with the `TABLE` type.</summary>
    public class GoogleCloudDatacatalogV1DatabaseTableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Entry metadata. A Data Catalog entry represents another resource in Google Cloud Platform (such as a BigQuery
    /// dataset or a Pub/Sub topic) or outside of it. You can use the `linked_resource` field in the entry resource to
    /// refer to the original resource ID of the source system. An entry resource contains resource details, for
    /// example, its schema. Additionally, you can attach flexible metadata to an entry in the form of a Tag.
    /// </summary>
    public class GoogleCloudDatacatalogV1Entry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specification for a group of BigQuery tables with the `[prefix]YYYYMMDD` name pattern. For more information,
        /// see [Introduction to partitioned tables]
        /// (https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDateShardedSpec")]
        public virtual GoogleCloudDatacatalogV1BigQueryDateShardedSpec BigqueryDateShardedSpec { get; set; }

        /// <summary>
        /// Specification that applies to a BigQuery table. Valid only for entries with the `TABLE` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryTableSpec")]
        public virtual GoogleCloudDatacatalogV1BigQueryTableSpec BigqueryTableSpec { get; set; }

        /// <summary>Output only. Physical location of the entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual GoogleCloudDatacatalogV1DataSource DataSource { get; set; }

        /// <summary>
        /// Specification that applies to a data source connection. Valid only for entries with the
        /// `DATA_SOURCE_CONNECTION` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceConnectionSpec")]
        public virtual GoogleCloudDatacatalogV1DataSourceConnectionSpec DataSourceConnectionSpec { get; set; }

        /// <summary>
        /// Specification that applies to a table resource. Valid only for entries with the `TABLE` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseTableSpec")]
        public virtual GoogleCloudDatacatalogV1DatabaseTableSpec DatabaseTableSpec { get; set; }

        /// <summary>
        /// Entry description that can consist of several sentences or paragraphs that describe entry contents. The
        /// description must not contain Unicode non-characters as well as C0 and C1 control codes except tabs (HT), new
        /// lines (LF), carriage returns (CR), and page breaks (FF). The maximum size is 2000 bytes when encoded in
        /// UTF-8. Default value is an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Display name of an entry. The name must contain only Unicode letters, numbers (0-9), underscores (_), dashes
        /// (-), spaces ( ), and can't start or end with spaces. The maximum size is 200 bytes when encoded in UTF-8.
        /// Default value is an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Fully qualified name (FQN) of the resource. Set automatically for entries representing resources from synced
        /// systems. Settable only during creation and read-only afterwards. Can be used for search and lookup of the
        /// entries. FQNs take two forms: * For non-regionalized resources:
        /// `{SYSTEM}:{PROJECT}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}` * For regionalized resources:
        /// `{SYSTEM}:{PROJECT}.{LOCATION_ID}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}` Example for a DPMS table:
        /// `dataproc_metastore:{PROJECT_ID}.{LOCATION_ID}.{INSTANCE_ID}.{DATABASE_ID}.{TABLE_ID}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyQualifiedName")]
        public virtual string FullyQualifiedName { get; set; }

        /// <summary>
        /// Specification that applies to a Cloud Storage fileset. Valid only for entries with the `FILESET` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFilesetSpec")]
        public virtual GoogleCloudDatacatalogV1GcsFilesetSpec GcsFilesetSpec { get; set; }

        /// <summary>
        /// Output only. Indicates the entry's source system that Data Catalog integrates with, such as BigQuery,
        /// Pub/Sub, or Dataproc Metastore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integratedSystem")]
        public virtual string IntegratedSystem { get; set; }

        /// <summary>
        /// Cloud labels attached to the entry. In Data Catalog, you can create and modify labels attached only to
        /// custom entries. Synced entries have unmodifiable labels that come from the source system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource this metadata entry refers to. For Google Cloud Platform resources, `linked_resource` is the
        /// [Full Resource Name] (https://cloud.google.com/apis/design/resource_names#full_resource_name). For example,
        /// the `linked_resource` for a table resource from BigQuery is:
        /// `//bigquery.googleapis.com/projects/{PROJECT_ID}/datasets/{DATASET_ID}/tables/{TABLE_ID}` Output only when
        /// the entry is one of the types in the `EntryType` enum. For entries with a `user_specified_type`, this field
        /// is optional and defaults to an empty string. The resource string must contain only letters (a-z, A-Z),
        /// numbers (0-9), underscores (_), periods (.), colons (:), slashes (/), dashes (-), and hashes (#). The
        /// maximum size is 200 bytes when encoded in UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedResource")]
        public virtual string LinkedResource { get; set; }

        /// <summary>
        /// Output only. The resource name of an entry in URL format. Note: The entry itself and its child resources
        /// might not be stored in the location specified in its name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Specification that applies to a user-defined function or procedure. Valid only for entries with the
        /// `ROUTINE` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineSpec")]
        public virtual GoogleCloudDatacatalogV1RoutineSpec RoutineSpec { get; set; }

        /// <summary>Schema of the entry. An entry might not have any schema attached to it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual GoogleCloudDatacatalogV1Schema Schema { get; set; }

        /// <summary>
        /// Timestamps from the underlying resource, not from the Data Catalog entry. Output only when the entry has a
        /// type listed in the `EntryType` enum. For entries with `user_specified_type`, this field is optional and
        /// defaults to an empty timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSystemTimestamps")]
        public virtual GoogleCloudDatacatalogV1SystemTimestamps SourceSystemTimestamps { get; set; }

        /// <summary>
        /// The type of the entry. Only used for entries with types listed in the `EntryType` enum. Currently, only
        /// `FILESET` enum value is allowed. All other entries created in Data Catalog must use the
        /// `user_specified_type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. Resource usage statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageSignal")]
        public virtual GoogleCloudDatacatalogV1UsageSignal UsageSignal { get; set; }

        /// <summary>
        /// Indicates the entry's source system that Data Catalog doesn't automatically integrate with. The
        /// `user_specified_system` string has the following limitations: * Is case insensitive. * Must begin with a
        /// letter or underscore. * Can only contain letters, numbers, and underscores. * Must be at least 1 character
        /// and at most 64 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSpecifiedSystem")]
        public virtual string UserSpecifiedSystem { get; set; }

        /// <summary>
        /// Custom entry type that doesn't match any of the values allowed for input and listed in the `EntryType` enum.
        /// When creating an entry, first check the type values in the enum. If there are no appropriate types for the
        /// new entry, provide a custom value, for example, `my_special_type`. The `user_specified_type` string has the
        /// following limitations: * Is case insensitive. * Must begin with a letter or underscore. * Can only contain
        /// letters, numbers, and underscores. * Must be at least 1 character and at most 64 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSpecifiedType")]
        public virtual string UserSpecifiedType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Entry group metadata. An `EntryGroup` resource represents a logical grouping of zero or more Data Catalog Entry
    /// resources.
    /// </summary>
    public class GoogleCloudDatacatalogV1EntryGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamps of the entry group. Default value is empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCatalogTimestamps")]
        public virtual GoogleCloudDatacatalogV1SystemTimestamps DataCatalogTimestamps { get; set; }

        /// <summary>
        /// Entry group description. Can consist of several sentences or paragraphs that describe the entry group
        /// contents. Default value is an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A short name to identify the entry group, for example, "analytics data - jan 2011". Default value is an
        /// empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the entry group in URL format. Note: The entry group itself and its child resources
        /// might not be stored in the location specified in its name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ExportTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1ExportTaxonomiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of taxonomies and policy tags as nested protocol buffers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1SerializedTaxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDatacatalogV1FieldType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An enum type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumType")]
        public virtual GoogleCloudDatacatalogV1FieldTypeEnumType EnumType { get; set; }

        /// <summary>Primitive types, such as string, boolean, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primitiveType")]
        public virtual string PrimitiveType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDatacatalogV1FieldTypeEnumType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of allowed values for this enum. This set must not be empty and can include up to 100 allowed
        /// values. The display names of the values in this set must not be empty and must be case-insensitively unique
        /// within this set. The order of items in this set is preserved. This field can be used to create, remove, and
        /// reorder enum values. To rename enum values, use the `RenameTagTemplateFieldEnumValue` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1FieldTypeEnumTypeEnumValue> AllowedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDatacatalogV1FieldTypeEnumTypeEnumValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The display name of the enum value. Must not be an empty string. The name must contain only
        /// Unicode letters, numbers (0-9), underscores (_), dashes (-), spaces ( ), and can't start or end with spaces.
        /// The maximum length is 200 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a single file in Cloud Storage.</summary>
    public class GoogleCloudDatacatalogV1GcsFileSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Full file path. Example: `gs://bucket_name/a/b.txt`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>Output only. Creation, modification, and expiration timestamps of a Cloud Storage file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsTimestamps")]
        public virtual GoogleCloudDatacatalogV1SystemTimestamps GcsTimestamps { get; set; }

        /// <summary>Output only. File size in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a Cloud Storage fileset entry.</summary>
    public class GoogleCloudDatacatalogV1GcsFilesetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Patterns to identify a set of files in Google Cloud Storage. For more information, see [Wildcard
        /// Names] (https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames). Note: Currently, bucket
        /// wildcards are not supported. Examples of valid `file_patterns`: * `gs://bucket_name/dir/*`: matches all
        /// files in `bucket_name/dir` directory * `gs://bucket_name/dir/**`: matches all files in `bucket_name/dir` and
        /// all subdirectories * `gs://bucket_name/file*`: matches files prefixed by `file` in `bucket_name` *
        /// `gs://bucket_name/??.txt`: matches files with two characters followed by `.txt` in `bucket_name` *
        /// `gs://bucket_name/[aeiou].txt`: matches files that contain a single vowel character followed by `.txt` in
        /// `bucket_name` * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ... or `m` followed by
        /// `.txt` in `bucket_name` * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that match the
        /// `a/*/b` pattern, such as `a/c/b`, `a/d/b` * `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt`
        /// You can combine wildcards to match complex sets of files, for example: `gs://bucket_name/[a-m]??.j*g`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePatterns")]
        public virtual System.Collections.Generic.IList<string> FilePatterns { get; set; }

        /// <summary>
        /// Output only. Sample files contained in this fileset, not all files contained in this fileset are represented
        /// here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleGcsFileSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1GcsFileSpec> SampleGcsFileSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ImportTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1ImportTaxonomiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cross-regional source taxonomy to import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossRegionalSource")]
        public virtual GoogleCloudDatacatalogV1CrossRegionalSource CrossRegionalSource { get; set; }

        /// <summary>Inline source taxonomy to import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineSource")]
        public virtual GoogleCloudDatacatalogV1InlineSource InlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ImportTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1ImportTaxonomiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Imported taxonomies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1Taxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inline source containing taxonomies to import.</summary>
    public class GoogleCloudDatacatalogV1InlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Taxonomies to import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1SerializedTaxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListEntries.</summary>
    public class GoogleCloudDatacatalogV1ListEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Entry details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1Entry> Entries { get; set; }

        /// <summary>Pagination token of the next results page. Empty if there are no more items in results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListEntryGroups.</summary>
    public class GoogleCloudDatacatalogV1ListEntryGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Entry group details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1EntryGroup> EntryGroups { get; set; }

        /// <summary>
        /// Pagination token to specify in the next call to retrieve the next page of results. Empty if there are no
        /// more items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPolicyTags.</summary>
    public class GoogleCloudDatacatalogV1ListPolicyTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token of the next results page. Empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The policy tags that belong to the taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1PolicyTag> PolicyTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListTags.</summary>
    public class GoogleCloudDatacatalogV1ListTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pagination token of the next results page. Empty if there are no more items in results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Tag details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1Tag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1ListTaxonomiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token of the next results page. Empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Taxonomies that the project contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1Taxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Denotes one policy tag in a taxonomy, for example, SSN. Policy tags can be defined in a hierarchy. For example:
    /// ``` + Geolocation + LatLong + City + ZipCode ``` Where the "Geolocation" policy tag contains three children.
    /// </summary>
    public class GoogleCloudDatacatalogV1PolicyTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Resource names of child policy tags of this policy tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childPolicyTags")]
        public virtual System.Collections.Generic.IList<string> ChildPolicyTags { get; set; }

        /// <summary>
        /// Description of this policy tag. If not set, defaults to empty. The description must contain only Unicode
        /// characters, tabs, newlines, carriage returns and page breaks, and be at most 2000 bytes long when encoded in
        /// UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. User-defined name of this policy tag. The name can't start or end with spaces and must be unique
        /// within the parent taxonomy, contain only Unicode letters, numbers, underscores, dashes and spaces, and be at
        /// most 200 bytes long when encoded in UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Resource name of this policy tag in the URL format. The policy tag manager generates unique
        /// taxonomy IDs and policy tag IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Resource name of this policy tag's parent policy tag. If empty, this is a top level tag. If not set,
        /// defaults to an empty string. For example, for the "LatLong" policy tag in the example above, this field
        /// contains the resource name of the "Geolocation" policy tag, and, for "Geolocation", this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentPolicyTag")]
        public virtual string ParentPolicyTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RenameTagTemplateFieldEnumValue.</summary>
    public class GoogleCloudDatacatalogV1RenameTagTemplateFieldEnumValueRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new display name of the enum value. For example, `my_new_enum_value`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newEnumValueDisplayName")]
        public virtual string NewEnumValueDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RenameTagTemplateField.</summary>
    public class GoogleCloudDatacatalogV1RenameTagTemplateFieldRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new ID of this tag template field. For example, `my_new_field`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTagTemplateFieldId")]
        public virtual string NewTagTemplateFieldId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ReplaceTaxonomy.</summary>
    public class GoogleCloudDatacatalogV1ReplaceTaxonomyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Taxonomy to update along with its child policy tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedTaxonomy")]
        public virtual GoogleCloudDatacatalogV1SerializedTaxonomy SerializedTaxonomy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to a routine. Valid only for entries with the `ROUTINE` type.</summary>
    public class GoogleCloudDatacatalogV1RoutineSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fields specific for BigQuery routines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryRoutineSpec")]
        public virtual GoogleCloudDatacatalogV1BigQueryRoutineSpec BigqueryRoutineSpec { get; set; }

        /// <summary>The body of the routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitionBody")]
        public virtual string DefinitionBody { get; set; }

        /// <summary>
        /// The language the routine is written in. The exact value depends on the source system. For BigQuery routines,
        /// possible values are: * `SQL` * `JAVASCRIPT`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>
        /// Return type of the argument. The exact value depends on the source system and the language.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnType")]
        public virtual string ReturnType { get; set; }

        /// <summary>Arguments of the routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineArguments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1RoutineSpecArgument> RoutineArguments { get; set; }

        /// <summary>The type of the routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineType")]
        public virtual string RoutineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input or output argument of a function or stored procedure.</summary>
    public class GoogleCloudDatacatalogV1RoutineSpecArgument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies whether the argument is input or output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The name of the argument. A return argument of a function might not have a name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Type of the argument. The exact value depends on the source system and the language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a schema, for example, a BigQuery, GoogleSQL, or Avro schema.</summary>
    public class GoogleCloudDatacatalogV1Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unified GoogleSQL-like schema of columns. The overall maximum number of columns and nested columns is
        /// 10,000. The maximum nested depth is 15 levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1ColumnSchema> Columns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchCatalog.</summary>
    public class GoogleCloudDatacatalogV1SearchCatalogRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the order of results. Currently supported case-sensitive values are: * `relevance` that can only
        /// be descending * `last_modified_timestamp [asc|desc]` with descending (`desc`) as default If this parameter
        /// is omitted, it defaults to the descending `relevance`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Number of results to return in a single search page. Can't be negative or 0, defaults to 10 in this case.
        /// The maximum number is 1000. If exceeded, throws an "invalid argument" exception.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. Pagination token that, if specified, returns the next page of search results. If empty, returns
        /// the first page. This token is returned in the SearchCatalogResponse.next_page_token field of the response to
        /// a previous SearchCatalogRequest call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Optional. The query string with a minimum of 3 characters and specific syntax. For more information, see
        /// [Data Catalog search syntax](/data-catalog/docs/how-to/search-reference). An empty query string returns all
        /// data assets (in the specified scope) that you have access to. A query string can be a simple `xyz` or
        /// qualified by predicates: * `name:x` * `column:y` * `description:z`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// Required. The scope of this search request. The `scope` is invalid if `include_org_ids`,
        /// `include_project_ids` are empty AND `include_gcp_public_datasets` is set to `false`. In this case, the
        /// request returns an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual GoogleCloudDatacatalogV1SearchCatalogRequestScope Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The criteria that select the subspace used for query matching.</summary>
    public class GoogleCloudDatacatalogV1SearchCatalogRequestScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `true`, include Google Cloud Platform (GCP) public datasets in search results. By default, they are
        /// excluded. See [Google Cloud Public Datasets](/public-datasets) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeGcpPublicDatasets")]
        public virtual System.Nullable<bool> IncludeGcpPublicDatasets { get; set; }

        /// <summary>
        /// The list of organization IDs to search within. To find your organization ID, follow the steps from [Creating
        /// and managing organizations] (/resource-manager/docs/creating-managing-organization).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeOrgIds")]
        public virtual System.Collections.Generic.IList<string> IncludeOrgIds { get; set; }

        /// <summary>
        /// The list of project IDs to search within. For more information on the distinction between project names,
        /// IDs, and numbers, see [Projects](/docs/overview/#projects).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeProjectIds")]
        public virtual System.Collections.Generic.IList<string> IncludeProjectIds { get; set; }

        /// <summary>
        /// Optional. If `true`, include public tag templates in the search results. By default, they are included only
        /// if you have explicit permissions on them to view them. For example, if you are the owner. Other scope
        /// fields, for example, ``include_org_ids``, still restrict the returned public tag templates and at least one
        /// of them is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includePublicTagTemplates")]
        public virtual System.Nullable<bool> IncludePublicTagTemplates { get; set; }

        /// <summary>
        /// Optional. The list of locations to search within. If empty, all locations are searched. Returns an error if
        /// any location in the list isn't one of the [Supported
        /// regions](https://cloud.google.com/data-catalog/docs/concepts/regions#supported_regions). If a location is
        /// unreachable, its name is returned in the `SearchCatalogResponse.unreachable` field. To get additional
        /// information on the error, repeat the search request and set the location name as the value of this
        /// parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedLocations")]
        public virtual System.Collections.Generic.IList<string> RestrictedLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchCatalog.</summary>
    public class GoogleCloudDatacatalogV1SearchCatalogResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token that can be used in subsequent calls to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Search results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1SearchCatalogResult> Results { get; set; }

        /// <summary>
        /// Unreachable locations. Search results don't include data from those locations. To get additional information
        /// on an error, repeat the search request and restrict it to specific locations by setting the
        /// `SearchCatalogRequest.scope.restricted_locations` parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Result in the response to a search request. Each result captures details of one entry that matches the search.
    /// </summary>
    public class GoogleCloudDatacatalogV1SearchCatalogResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Fully qualified name (FQN) of the resource. FQNs take two forms: * For non-regionalized resources:
        /// `{SYSTEM}:{PROJECT}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}` * For regionalized resources:
        /// `{SYSTEM}:{PROJECT}.{LOCATION_ID}.{PATH_TO_RESOURCE_SEPARATED_WITH_DOTS}` Example for a DPMS table:
        /// `dataproc_metastore:PROJECT_ID.LOCATION_ID.INSTANCE_ID.DATABASE_ID.TABLE_ID`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyQualifiedName")]
        public virtual string FullyQualifiedName { get; set; }

        /// <summary>
        /// Output only. The source system that Data Catalog automatically integrates with, such as BigQuery, Cloud
        /// Pub/Sub, or Dataproc Metastore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integratedSystem")]
        public virtual string IntegratedSystem { get; set; }

        /// <summary>
        /// The full name of the Google Cloud resource the entry belongs to. For more information, see [Full Resource
        /// Name] (/apis/design/resource_names#full_resource_name). Example:
        /// `//bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedResource")]
        public virtual string LinkedResource { get; set; }

        /// <summary>The last modification timestamp of the entry in the source system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifyTime")]
        public virtual object ModifyTime { get; set; }

        /// <summary>
        /// The relative name of the resource in URL format. Examples: *
        /// `projects/{PROJECT_ID}/locations/{LOCATION_ID}/entryGroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}` *
        /// `projects/{PROJECT_ID}/tagTemplates/{TAG_TEMPLATE_ID}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeResourceName")]
        public virtual string RelativeResourceName { get; set; }

        /// <summary>
        /// Sub-type of the search result. A dot-delimited full type of the resource. The same type you specify in the
        /// `type` search predicate. Examples: `entry.table`, `entry.dataStream`, `tagTemplate`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchResultSubtype")]
        public virtual string SearchResultSubtype { get; set; }

        /// <summary>
        /// Type of the search result. You can use this field to determine which get method to call to fetch the full
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchResultType")]
        public virtual string SearchResultType { get; set; }

        /// <summary>Custom source system that you can manually integrate Data Catalog with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSpecifiedSystem")]
        public virtual string UserSpecifiedSystem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A nested protocol buffer that represents a policy tag and all its descendants.</summary>
    public class GoogleCloudDatacatalogV1SerializedPolicyTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Children of the policy tag, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childPolicyTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1SerializedPolicyTag> ChildPolicyTags { get; set; }

        /// <summary>
        /// Description of the serialized policy tag. At most 2000 bytes when encoded in UTF-8. If not set, defaults to
        /// an empty description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the policy tag. At most 200 bytes when encoded in UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource name of the policy tag. This field is ignored when calling `ImportTaxonomies`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTag")]
        public virtual string PolicyTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A nested protocol buffer that represents a taxonomy and the hierarchy of its policy tags. Used for taxonomy
    /// replacement, import, and export.
    /// </summary>
    public class GoogleCloudDatacatalogV1SerializedTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of policy types that are activated per taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activatedPolicyTypes")]
        public virtual System.Collections.Generic.IList<string> ActivatedPolicyTypes { get; set; }

        /// <summary>
        /// Description of the serialized taxonomy. At most 2000 bytes when encoded in UTF-8. If not set, defaults to an
        /// empty description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the taxonomy. At most 200 bytes when encoded in UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Top level policy tags associated with the taxonomy, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1SerializedPolicyTag> PolicyTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Timestamps associated with this resource in a particular system.</summary>
    public class GoogleCloudDatacatalogV1SystemTimestamps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation timestamp of the resource within the given system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. Expiration timestamp of the resource within the given system. Currently only applicable to
        /// BigQuery resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Timestamp of the last modification of the resource or its metadata within a given system. Note: Depending on
        /// the source system, not every modification updates this timestamp. For example, BigQuery timestamps every
        /// metadata modification but not data or permission changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Normal BigQuery table specification.</summary>
    public class GoogleCloudDatacatalogV1TableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If the table is date-sharded, that is, it matches the `[prefix]YYYYMMDD` name pattern, this
        /// field is the Data Catalog resource name of the date-sharded grouped entry. For example:
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/entrygroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}`. Otherwise,
        /// `grouped_entry` is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupedEntry")]
        public virtual string GroupedEntry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tags contain custom metadata and are attached to Data Catalog resources. Tags conform with the specification of
    /// their tag template. See [Data Catalog IAM](https://cloud.google.com/data-catalog/docs/concepts/iam) for
    /// information on the permissions needed to create or view tags.
    /// </summary>
    public class GoogleCloudDatacatalogV1Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resources like entry can have schemas associated with them. This scope allows you to attach tags to an
        /// individual column based on that schema. To attach a tag to a nested column, separate column names with a dot
        /// (`.`). Example: `column.nested_column`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual string Column { get; set; }

        /// <summary>
        /// Required. Maps the ID of a tag field to its value and additional information about that field. Tag template
        /// defines valid field IDs. A tag must have at least 1 field and at most 500 fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1TagField> Fields { get; set; }

        /// <summary>
        /// The resource name of the tag in URL format where tag ID is a system-generated identifier. Note: The tag
        /// itself might not be stored in the location specified in its name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The resource name of the tag template this tag uses. Example:
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/tagTemplates/{TAG_TEMPLATE_ID}` This field cannot be modified
        /// after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual string Template { get; set; }

        /// <summary>Output only. The display name of the tag template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateDisplayName")]
        public virtual string TemplateDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the value and additional information on a field within a Tag.</summary>
    public class GoogleCloudDatacatalogV1TagField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of a tag field with a boolean type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Output only. The display name of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The value of a tag field with a double type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>
        /// The value of a tag field with an enum type. This value must be one of the allowed values listed in this
        /// enum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValue")]
        public virtual GoogleCloudDatacatalogV1TagFieldEnumValue EnumValue { get; set; }

        /// <summary>
        /// Output only. The order of this field with respect to other fields in this tag. Can be set by Tag. For
        /// example, a higher value can indicate a more important field. The value can be negative. Multiple fields can
        /// have the same order, and field orders within a tag don't have to be sequential.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual System.Nullable<int> Order { get; set; }

        /// <summary>
        /// The value of a tag field with a rich text type. The maximum length is 10 MiB as this value holds HTML
        /// descriptions including encoded images. The maximum length of the text without images is 100 KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richtextValue")]
        public virtual string RichtextValue { get; set; }

        /// <summary>The value of a tag field with a string type. The maximum length is 2000 UTF-8 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The value of a tag field with a timestamp type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual object TimestampValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An enum value.</summary>
    public class GoogleCloudDatacatalogV1TagFieldEnumValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the enum value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A tag template defines a tag that can have one or more typed fields. The template is used to create tags that
    /// are attached to GCP resources. [Tag template roles]
    /// (https://cloud.google.com/iam/docs/understanding-roles#data-catalog-roles) provide permissions to create, edit,
    /// and use the template. For example, see the [TagTemplate User]
    /// (https://cloud.google.com/data-catalog/docs/how-to/template-user) role that includes a permission to use the tag
    /// template to tag resources.
    /// </summary>
    public class GoogleCloudDatacatalogV1TagTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Display name for this template. Defaults to an empty string. The name must contain only Unicode letters,
        /// numbers (0-9), underscores (_), dashes (-), spaces ( ), and can't start or end with spaces. The maximum
        /// length is 200 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. Map of tag template field IDs to the settings for the field. This map is an exhaustive list of the
        /// allowed fields. The map must contain at least one field and at most 500 fields. The keys to this map are tag
        /// template field IDs. The IDs have the following limitations: * Can contain uppercase and lowercase letters,
        /// numbers (0-9) and underscores (_). * Must be at least 1 character and at most 64 characters long. * Must
        /// start with a letter or underscore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1TagTemplateField> Fields { get; set; }

        /// <summary>
        /// Indicates whether this is a public tag template. Every user has view access to a *public* tag template by
        /// default. This means that: * Every user can use this tag template to tag an entry. * If an entry is tagged
        /// using the tag template, the tag is always shown in the response to ``ListTags`` called on the entry. * To
        /// get the template using the GetTagTemplate method, you need view access either on the project or the
        /// organization the tag template resides in but no other permission is needed. * Operations on the tag template
        /// other than viewing (for example, editing IAM policies) follow standard IAM structures. Tags created with a
        /// public tag template are referred to as public tags. You can search for a public tag by value with a simple
        /// search query instead of using a ``tag:`` predicate. Public tag templates may not appear in search results
        /// depending on scope, see: include_public_tag_templates
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPubliclyReadable")]
        public virtual System.Nullable<bool> IsPubliclyReadable { get; set; }

        /// <summary>
        /// The resource name of the tag template in URL format. Note: The tag template itself and its child resources
        /// might not be stored in the location specified in its name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The template for an individual field within a tag template.</summary>
    public class GoogleCloudDatacatalogV1TagTemplateField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description for this field. Defaults to an empty string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The display name for this field. Defaults to an empty string. The name must contain only Unicode letters,
        /// numbers (0-9), underscores (_), dashes (-), spaces ( ), and can't start or end with spaces. The maximum
        /// length is 200 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>If true, this field is required. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRequired")]
        public virtual System.Nullable<bool> IsRequired { get; set; }

        /// <summary>
        /// Output only. The resource name of the tag template field in URL format. Example:
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/tagTemplates/{TAG_TEMPLATE}/fields/{FIELD}` Note: The tag
        /// template field itself might not be stored in the location specified in its name. The name must contain only
        /// letters (a-z, A-Z), numbers (0-9), or underscores (_), and must start with a letter or underscore. The
        /// maximum length is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The order of this field with respect to other fields in this tag template. For example, a higher value can
        /// indicate a more important field. The value can be negative. Multiple fields can have the same order and
        /// field orders within a tag don't have to be sequential.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual System.Nullable<int> Order { get; set; }

        /// <summary>Required. The type of value this tag field can contain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual GoogleCloudDatacatalogV1FieldType Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A taxonomy is a collection of hierarchical policy tags that classify data along a common axis. For example, a
    /// "data sensitivity" taxonomy might contain the following policy tags: ``` + PII + Account number + Age + SSN +
    /// Zipcode + Financials + Revenue ``` A "data origin" taxonomy might contain the following policy tags: ``` + User
    /// data + Employee data + Partner data + Public data ```
    /// </summary>
    public class GoogleCloudDatacatalogV1Taxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of policy types that are activated for this taxonomy. If not set, defaults to an empty
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activatedPolicyTypes")]
        public virtual System.Collections.Generic.IList<string> ActivatedPolicyTypes { get; set; }

        /// <summary>
        /// Optional. Description of this taxonomy. If not set, defaults to empty. The description must contain only
        /// Unicode characters, tabs, newlines, carriage returns, and page breaks, and be at most 2000 bytes long when
        /// encoded in UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. User-defined name of this taxonomy. The name can't start or end with spaces, must contain only
        /// Unicode letters, numbers, underscores, dashes, and spaces, and be at most 200 bytes long when encoded in
        /// UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Resource name of this taxonomy in URL format. Note: Policy tag manager generates unique
        /// taxonomy IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Number of policy tags in this taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTagCount")]
        public virtual System.Nullable<int> PolicyTagCount { get; set; }

        /// <summary>Output only. Creation and modification timestamps of this taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomyTimestamps")]
        public virtual GoogleCloudDatacatalogV1SystemTimestamps TaxonomyTimestamps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The set of all usage signals that Data Catalog stores. Note: Usually, these signals are updated daily. In rare
    /// cases, an update may fail but will be performed again on the next day.
    /// </summary>
    public class GoogleCloudDatacatalogV1UsageSignal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end timestamp of the duration of usage statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Usage statistics over each of the predefined time ranges. Supported time ranges are `{"24H", "7D", "30D"}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageWithinTimeRange")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1UsageStats> UsageWithinTimeRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Detailed statistics on the entry's usage. Usage statistics have the following limitations: - Only BigQuery
    /// tables have them. - They only include BigQuery query jobs. - They might be underestimated because wildcard table
    /// references are not yet counted. For more information, see [Querying multiple tables using a wildcard table]
    /// (https://cloud.google.com/bigquery/docs/querying-wildcard-tables)
    /// </summary>
    public class GoogleCloudDatacatalogV1UsageStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of cancelled attempts to use the underlying entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCancellations")]
        public virtual System.Nullable<float> TotalCancellations { get; set; }

        /// <summary>The number of successful uses of the underlying entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCompletions")]
        public virtual System.Nullable<float> TotalCompletions { get; set; }

        /// <summary>Total time spent only on successful uses, in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalExecutionTimeForCompletionsMillis")]
        public virtual System.Nullable<float> TotalExecutionTimeForCompletionsMillis { get; set; }

        /// <summary>The number of failed attempts to use the underlying entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalFailures")]
        public virtual System.Nullable<float> TotalFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Table view specification.</summary>
    public class GoogleCloudDatacatalogV1ViewSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The query that defines the table view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewQuery")]
        public virtual string ViewQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
