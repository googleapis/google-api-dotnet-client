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

namespace Google.Apis.DataCatalog.v1beta1
{
    /// <summary>The DataCatalog Service.</summary>
    public class DataCatalogService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://datacatalog.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://datacatalog.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datacatalog";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Data Catalog API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Cloud Data Catalog API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
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
        /// Searches Data Catalog for multiple resources like entries, tags that match a query. This is a custom method
        /// (https://cloud.google.com/apis/design/custom_methods) and does not return the complete resource, only the
        /// resource identifier and high level fields. Clients can subsequently call `Get` methods. Note that Data
        /// Catalog search queries do not guarantee full recall. Query results that match your query may not be
        /// returned, even in subsequent result pages. Also note that results returned (and not returned) can vary
        /// across repeated search queries. See [Data Catalog Search
        /// Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference) for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SearchRequest Search(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1SearchCatalogRequest body)
        {
            return new SearchRequest(this.service, body);
        }

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries, tags that match a query. This is a custom method
        /// (https://cloud.google.com/apis/design/custom_methods) and does not return the complete resource, only the
        /// resource identifier and high level fields. Clients can subsequently call `Get` methods. Note that Data
        /// Catalog search queries do not guarantee full recall. Query results that match your query may not be
        /// returned, even in subsequent result pages. Also note that results returned (and not returned) can vary
        /// across repeated search queries. See [Data Catalog Search
        /// Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference) for more information.
        /// </summary>
        public class SearchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1SearchCatalogResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1SearchCatalogRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1SearchCatalogRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/catalog:search";

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
        /// Get an entry by target resource name. This method allows clients to use the resource name from the source
        /// Google Cloud Platform service to get the Data Catalog Entry.
        /// </summary>
        public virtual LookupRequest Lookup()
        {
            return new LookupRequest(this.service);
        }

        /// <summary>
        /// Get an entry by target resource name. This method allows clients to use the resource name from the source
        /// Google Cloud Platform service to get the Data Catalog Entry.
        /// </summary>
        public class LookupRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The full name of the Google Cloud Platform resource the Data Catalog entry represents. See:
            /// https://cloud.google.com/apis/design/resource_names#full_resource_name. Full names are case-sensitive.
            /// Examples: * //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId *
            /// //pubsub.googleapis.com/projects/projectId/topics/topicId
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("linkedResource", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LinkedResource { get; set; }

            /// <summary>
            /// The SQL name of the entry. SQL names are case-sensitive. Examples: * `pubsub.project_id.topic_id` *
            /// ``pubsub.project_id.`topic.id.with.dots` `` * `bigquery.table.project_id.dataset_id.table_id` *
            /// `bigquery.dataset.project_id.dataset_id` *
            /// `datacatalog.entry.project_id.location_id.entry_group_id.entry_id` `*_id`s should satisfy the GoogleSQL
            /// rules for identifiers. https://cloud.google.com/bigquery/docs/reference/standard-sql/lexical.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sqlResource", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SqlResource { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/entries:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                        /// Creates a tag on an Entry. Note: The project identified by the `parent` parameter for the
                        /// [tag](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                        /// and the [tag
                        /// template](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.tagTemplates/create#path-parameters)
                        /// used to create the tag must be from the same organization.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The name of the resource to attach this tag to. Tags can be attached to Entries.
                        /// Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                        /// Note that this Tag and its child resources may not actually be stored in the location in
                        /// this name.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Creates a tag on an Entry. Note: The project identified by the `parent` parameter for the
                        /// [tag](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                        /// and the [tag
                        /// template](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.tagTemplates/create#path-parameters)
                        /// used to create the tag must be from the same organization.
                        /// </summary>
                        public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the resource to attach this tag to. Tags can be attached to
                            /// Entries. Example: *
                            /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                            /// Note that this Tag and its child resources may not actually be stored in the location in
                            /// this name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/tags";

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
                        /// <param name="name">
                        /// Required. The name of the tag to delete. Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>Deletes a tag.</summary>
                        public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the tag to delete. Example: *
                            /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+/tags/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists tags assigned to an Entry. The columns in the response are lowercased.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The name of the Data Catalog resource to list the tags of. The resource could be
                        /// an Entry or an EntryGroup. Examples: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists tags assigned to an Entry. The columns in the response are lowercased.
                        /// </summary>
                        public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ListTagsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the Data Catalog resource to list the tags of. The resource could
                            /// be an Entry or an EntryGroup. Examples: *
                            /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} *
                            /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of tags to return. Default is 10. Max limit is 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Token that specifies which page is requested. If empty, the first page is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/tags";

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
                        /// Identifier. The resource name of the tag in URL format. Example: *
                        /// projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
                        /// where `tag_id` is a system-generated identifier. Note that this Tag may not actually be
                        /// stored in the location in this name.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>Updates an existing tag.</summary>
                        public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Identifier. The resource name of the tag in URL format. Example: *
                            /// projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
                            /// where `tag_id` is a system-generated identifier. Note that this Tag may not actually be
                            /// stored in the location in this name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Note: Currently, this parameter can only take `"fields"` as value. Names of fields whose
                            /// values to overwrite on a tag. Currently, a tag has the only modifiable field with the
                            /// name `fields`. In general, if this parameter is absent or empty, all modifiable fields
                            /// are overwritten. If such fields are non-required and omitted in the request body, their
                            /// values are emptied.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag Body { get; set; }

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
                    /// Creates an entry. Only entries of 'FILESET' type or user-specified type can be created. Users
                    /// should enable the Data Catalog API in the project identified by the `parent` parameter (see
                    /// [Data Catalog Resource Project]
                    /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information). A
                    /// maximum of 100,000 entries may be created per entry group.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the entry group this entry is in. Example: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this Entry and
                    /// its child resources may not actually be stored in the location in this name.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates an entry. Only entries of 'FILESET' type or user-specified type can be created. Users
                    /// should enable the Data Catalog API in the project identified by the `parent` parameter (see
                    /// [Data Catalog Resource Project]
                    /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information). A
                    /// maximum of 100,000 entries may be created per entry group.
                    /// </summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the entry group this entry is in. Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this Entry
                        /// and its child resources may not actually be stored in the location in this name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The id of the entry to create.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("entryId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string EntryId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/entries";

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
                    /// Deletes an existing entry. Only entries created through CreateEntry method can be deleted. Users
                    /// should enable the Data Catalog API in the project identified by the `name` parameter (see [Data
                    /// Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project)
                    /// for more information).
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the entry. Example: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes an existing entry. Only entries created through CreateEntry method can be deleted. Users
                    /// should enable the Data Catalog API in the project identified by the `name` parameter (see [Data
                    /// Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project)
                    /// for more information).
                    /// </summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the entry. Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an entry.</summary>
                    /// <param name="name">
                    /// Required. The name of the entry. Example: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets an entry.</summary>
                    public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the entry. Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/entries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. A `NOT_FOUND` error is returned if the resource
                    /// does not exist. An empty policy is returned if the resource exists but does not have a policy
                    /// set on it. Supported resources are: - Tag templates. - Entries. - Entry groups. Note, this
                    /// method cannot be used to manage policies for BigQuery, Pub/Sub and any external Google Cloud
                    /// Platform resources synced to Data Catalog. Callers must have following Google IAM permission -
                    /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                    /// `datacatalog.entries.getIamPolicy` to get policies on entries. -
                    /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. A `NOT_FOUND` error is returned if the resource
                    /// does not exist. An empty policy is returned if the resource exists but does not have a policy
                    /// set on it. Supported resources are: - Tag templates. - Entries. - Entry groups. Note, this
                    /// method cannot be used to manage policies for BigQuery, Pub/Sub and any external Google Cloud
                    /// Platform resources synced to Data Catalog. Callers must have following Google IAM permission -
                    /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                    /// `datacatalog.entries.getIamPolicy` to get policies on entries. -
                    /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                    /// </summary>
                    public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                    /// Required. The name of the entry group that contains the entries, which can be provided in URL
                    /// format. Example: * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists entries.</summary>
                    public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ListEntriesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the entry group that contains the entries, which can be provided in
                        /// URL format. Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of items to return. Default is 10. Max limit is 1000. Throws an invalid
                        /// argument for `page_size &amp;gt; 1000`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Token that specifies which page is requested. If empty, the first page is returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// The fields to return for each Entry. If not set or empty, all fields are returned. For
                        /// example, setting read_mask to contain only one path "name" will cause ListEntries to return
                        /// a list of Entries with only "name" field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/entries";

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
                    /// Updates an existing entry. Users should enable the Data Catalog API in the project identified by
                    /// the `entry.name` parameter (see [Data Catalog Resource Project]
                    /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Identifier. The Data Catalog resource name of the entry in URL format. Example: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id} Note
                    /// that this Entry and its child resources may not actually be stored in the location in this name.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates an existing entry. Users should enable the Data Catalog API in the project identified by
                    /// the `entry.name` parameter (see [Data Catalog Resource Project]
                    /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                    /// </summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Identifier. The Data Catalog resource name of the entry in URL format. Example:
                        /// * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                        /// Note that this Entry and its child resources may not actually be stored in the location in
                        /// this name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Names of fields whose values to overwrite on an entry. If this parameter is absent or empty,
                        /// all modifiable fields are overwritten. If such fields are non-required and omitted in the
                        /// request body, their values are emptied. The following fields are modifiable: * For entries
                        /// with type `DATA_STREAM`: * `schema` * For entries with type `FILESET`: * `schema` *
                        /// `display_name` * `description` * `gcs_fileset_spec` * `gcs_fileset_spec.file_patterns` * For
                        /// entries with `user_specified_type`: * `schema` * `display_name` * `description` *
                        /// `user_specified_type` * `user_specified_system` * `linked_resource` *
                        /// `source_system_timestamps`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Entry Body { get; set; }

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
                    /// Returns the caller's permissions on a resource. If the resource does not exist, an empty set of
                    /// permissions is returned (We don't return a `NOT_FOUND` error). Supported resources are: - Tag
                    /// templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies for
                    /// BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog. A
                    /// caller is not required to have Google IAM permission to make this request.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns the caller's permissions on a resource. If the resource does not exist, an empty set of
                    /// permissions is returned (We don't return a `NOT_FOUND` error). Supported resources are: - Tag
                    /// templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies for
                    /// BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog. A
                    /// caller is not required to have Google IAM permission to make this request.
                    /// </summary>
                    public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                    /// Creates a tag on an Entry. Note: The project identified by the `parent` parameter for the
                    /// [tag](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                    /// and the [tag
                    /// template](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.tagTemplates/create#path-parameters)
                    /// used to create the tag must be from the same organization.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the resource to attach this tag to. Tags can be attached to Entries.
                    /// Example: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id} Note
                    /// that this Tag and its child resources may not actually be stored in the location in this name.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a tag on an Entry. Note: The project identified by the `parent` parameter for the
                    /// [tag](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.entryGroups.entries.tags/create#path-parameters)
                    /// and the [tag
                    /// template](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.tagTemplates/create#path-parameters)
                    /// used to create the tag must be from the same organization.
                    /// </summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource to attach this tag to. Tags can be attached to Entries.
                        /// Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                        /// Note that this Tag and its child resources may not actually be stored in the location in
                        /// this name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/tags";

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
                    /// <param name="name">
                    /// Required. The name of the tag to delete. Example: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a tag.</summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the tag to delete. Example: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/entryGroups/[^/]+/tags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists tags assigned to an Entry. The columns in the response are lowercased.</summary>
                    /// <param name="parent">
                    /// Required. The name of the Data Catalog resource to list the tags of. The resource could be an
                    /// Entry or an EntryGroup. Examples: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists tags assigned to an Entry. The columns in the response are lowercased.</summary>
                    public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ListTagsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Data Catalog resource to list the tags of. The resource could be
                        /// an Entry or an EntryGroup. Examples: *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} *
                        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of tags to return. Default is 10. Max limit is 1000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Token that specifies which page is requested. If empty, the first page is returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/tags";

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
                    /// Identifier. The resource name of the tag in URL format. Example: *
                    /// projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
                    /// where `tag_id` is a system-generated identifier. Note that this Tag may not actually be stored
                    /// in the location in this name.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing tag.</summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the tag in URL format. Example: *
                        /// projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
                        /// where `tag_id` is a system-generated identifier. Note that this Tag may not actually be
                        /// stored in the location in this name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Note: Currently, this parameter can only take `"fields"` as value. Names of fields whose
                        /// values to overwrite on a tag. Currently, a tag has the only modifiable field with the name
                        /// `fields`. In general, if this parameter is absent or empty, all modifiable fields are
                        /// overwritten. If such fields are non-required and omitted in the request body, their values
                        /// are emptied.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Tag Body { get; set; }

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
                /// A maximum of 10,000 entry groups may be created per organization across all locations. Users should
                /// enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog
                /// Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                /// information).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the project this entry group is in. Example: *
                /// projects/{project_id}/locations/{location} Note that this EntryGroup and its child resources may not
                /// actually be stored in the location in this name.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// A maximum of 10,000 entry groups may be created per organization across all locations. Users should
                /// enable the Data Catalog API in the project identified by the `parent` parameter (see [Data Catalog
                /// Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                /// information).
                /// </summary>
                public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the project this entry group is in. Example: *
                    /// projects/{project_id}/locations/{location} Note that this EntryGroup and its child resources may
                    /// not actually be stored in the location in this name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The id of the entry group to create. The id must begin with a letter or underscore,
                    /// contain only English letters, numbers and underscores, and be at most 64 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("entryGroupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EntryGroupId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/entryGroups";

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
                /// Deletes an EntryGroup. Only entry groups that do not contain entries can be deleted. Users should
                /// enable the Data Catalog API in the project identified by the `name` parameter (see [Data Catalog
                /// Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                /// information).
                /// </summary>
                /// <param name="name">
                /// Required. The name of the entry group. For example,
                /// `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes an EntryGroup. Only entry groups that do not contain entries can be deleted. Users should
                /// enable the Data Catalog API in the project identified by the `name` parameter (see [Data Catalog
                /// Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                /// information).
                /// </summary>
                public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the entry group. For example,
                    /// `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
                    /// </summary>
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

                /// <summary>Gets an EntryGroup.</summary>
                /// <param name="name">
                /// Required. The name of the entry group. For example,
                /// `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets an EntryGroup.</summary>
                public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the entry group. For example,
                    /// `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The fields to return. If not set or empty, all fields are returned.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

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
                /// Gets the access control policy for a resource. A `NOT_FOUND` error is returned if the resource does
                /// not exist. An empty policy is returned if the resource exists but does not have a policy set on it.
                /// Supported resources are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be
                /// used to manage policies for BigQuery, Pub/Sub and any external Google Cloud Platform resources
                /// synced to Data Catalog. Callers must have following Google IAM permission -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entries.getIamPolicy` to get policies on entries. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. A `NOT_FOUND` error is returned if the resource does
                /// not exist. An empty policy is returned if the resource exists but does not have a policy set on it.
                /// Supported resources are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be
                /// used to manage policies for BigQuery, Pub/Sub and any external Google Cloud Platform resources
                /// synced to Data Catalog. Callers must have following Google IAM permission -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entries.getIamPolicy` to get policies on entries. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                /// Required. The name of the location that contains the entry groups, which can be provided in URL
                /// format. Example: * projects/{project_id}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists entry groups.</summary>
                public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ListEntryGroupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the location that contains the entry groups, which can be provided in URL
                    /// format. Example: * projects/{project_id}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. Default is 10. Max limit is 1000. Throws an
                    /// invalid argument for `page_size &amp;gt; 1000`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Token that specifies which page is requested. If empty, the first page is returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/entryGroups";

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
                /// Updates an EntryGroup. The user should enable the Data Catalog API in the project identified by the
                /// `entry_group.name` parameter (see [Data Catalog Resource Project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the entry group in URL format. Example: *
                /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this EntryGroup
                /// and its child resources may not actually be stored in the location in this name.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates an EntryGroup. The user should enable the Data Catalog API in the project identified by the
                /// `entry_group.name` parameter (see [Data Catalog Resource Project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                /// </summary>
                public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the entry group in URL format. Example: *
                    /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this
                    /// EntryGroup and its child resources may not actually be stored in the location in this name.
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
                    Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1EntryGroup Body { get; set; }

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
                /// Sets the access control policy for a resource. Replaces any existing policy. Supported resources
                /// are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies
                /// for BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog.
                /// Callers must have following Google IAM permission - `datacatalog.tagTemplates.setIamPolicy` to set
                /// policies on tag templates. - `datacatalog.entries.setIamPolicy` to set policies on entries. -
                /// `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy for a resource. Replaces any existing policy. Supported resources
                /// are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies
                /// for BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog.
                /// Callers must have following Google IAM permission - `datacatalog.tagTemplates.setIamPolicy` to set
                /// policies on tag templates. - `datacatalog.entries.setIamPolicy` to set policies on entries. -
                /// `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                /// Returns the caller's permissions on a resource. If the resource does not exist, an empty set of
                /// permissions is returned (We don't return a `NOT_FOUND` error). Supported resources are: - Tag
                /// templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies for
                /// BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog. A caller
                /// is not required to have Google IAM permission to make this request.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns the caller's permissions on a resource. If the resource does not exist, an empty set of
                /// permissions is returned (We don't return a `NOT_FOUND` error). Supported resources are: - Tag
                /// templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies for
                /// BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog. A caller
                /// is not required to have Google IAM permission to make this request.
                /// </summary>
                public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                        /// Renames an enum value in a tag template. The enum values have to be unique within one enum
                        /// field. Thus, an enum value cannot be renamed with a name used in any other enum value within
                        /// the same enum field.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The name of the enum field value. Example: *
                        /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}
                        /// </param>
                        public virtual RenameRequest Rename(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldEnumValueRequest body, string name)
                        {
                            return new RenameRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Renames an enum value in a tag template. The enum values have to be unique within one enum
                        /// field. Thus, an enum value cannot be renamed with a name used in any other enum value within
                        /// the same enum field.
                        /// </summary>
                        public class RenameRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField>
                        {
                            /// <summary>Constructs a new Rename request.</summary>
                            public RenameRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldEnumValueRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the enum field value. Example: *
                            /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldEnumValueRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "rename";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+name}:rename";

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
                    /// Creates a field in a tag template. The user should enable the Data Catalog API in the project
                    /// identified by the `parent` parameter (see [Data Catalog Resource
                    /// Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                    /// information).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the project and the template location
                    /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions). Example: *
                    /// projects/{project_id}/locations/us-central1/tagTemplates/{tag_template_id}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a field in a tag template. The user should enable the Data Catalog API in the project
                    /// identified by the `parent` parameter (see [Data Catalog Resource
                    /// Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                    /// information).
                    /// </summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the project and the template location
                        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions). Example: *
                        /// projects/{project_id}/locations/us-central1/tagTemplates/{tag_template_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the tag template field to create. Field ids can contain letters (both
                        /// uppercase and lowercase), numbers (0-9), underscores (_) and dashes (-). Field IDs must be
                        /// at least 1 character long and at most 128 characters long. Field IDs must also be unique
                        /// within their template.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("tagTemplateFieldId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string TagTemplateFieldId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/fields";

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
                    /// Deletes a field in a tag template and all uses of that field. Users should enable the Data
                    /// Catalog API in the project identified by the `name` parameter (see [Data Catalog Resource
                    /// Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                    /// information).
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the tag template field to delete. Example: *
                    /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a field in a tag template and all uses of that field. Users should enable the Data
                    /// Catalog API in the project identified by the `name` parameter (see [Data Catalog Resource
                    /// Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                    /// information).
                    /// </summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the tag template field to delete. Example: *
                        /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Currently, this field must always be set to `true`. This confirms the deletion of
                        /// this field from any tags using this field. `force = false` will be supported in the future.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                    /// Updates a field in a tag template. This method cannot be used to update the field type. Users
                    /// should enable the Data Catalog API in the project identified by the `name` parameter (see [Data
                    /// Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project)
                    /// for more information).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the tag template field. Example: *
                    /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates a field in a tag template. This method cannot be used to update the field type. Users
                    /// should enable the Data Catalog API in the project identified by the `name` parameter (see [Data
                    /// Catalog Resource Project] (https://cloud.google.com/data-catalog/docs/concepts/resource-project)
                    /// for more information).
                    /// </summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the tag template field. Example: *
                        /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
                        /// </summary>
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
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField Body { get; set; }

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
                    /// Renames a field in a tag template. The user should enable the Data Catalog API in the project
                    /// identified by the `name` parameter (see [Data Catalog Resource
                    /// Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                    /// information).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the tag template. Example: *
                    /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
                    /// </param>
                    public virtual RenameRequest Rename(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldRequest body, string name)
                    {
                        return new RenameRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Renames a field in a tag template. The user should enable the Data Catalog API in the project
                    /// identified by the `name` parameter (see [Data Catalog Resource
                    /// Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                    /// information).
                    /// </summary>
                    public class RenameRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplateField>
                    {
                        /// <summary>Constructs a new Rename request.</summary>
                        public RenameRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the tag template. Example: *
                        /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rename";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:rename";

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
                /// Creates a tag template. The user should enable the Data Catalog API in the project identified by the
                /// `parent` parameter (see [Data Catalog Resource
                /// Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                /// information).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the project and the template location
                /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions. Example: *
                /// projects/{project_id}/locations/us-central1
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a tag template. The user should enable the Data Catalog API in the project identified by the
                /// `parent` parameter (see [Data Catalog Resource
                /// Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more
                /// information).
                /// </summary>
                public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the project and the template location
                    /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions. Example: *
                    /// projects/{project_id}/locations/us-central1
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The id of the tag template to create.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tagTemplateId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TagTemplateId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/tagTemplates";

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
                /// Deletes a tag template and all tags using the template. Users should enable the Data Catalog API in
                /// the project identified by the `name` parameter (see [Data Catalog Resource Project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                /// </summary>
                /// <param name="name">
                /// Required. The name of the tag template to delete. Example: *
                /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a tag template and all tags using the template. Users should enable the Data Catalog API in
                /// the project identified by the `name` parameter (see [Data Catalog Resource Project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                /// </summary>
                public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the tag template to delete. Example: *
                    /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Currently, this field must always be set to `true`. This confirms the deletion of any
                    /// possible tags using this template. `force = false` will be supported in the future.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                /// <param name="name">
                /// Required. The name of the tag template. Example: *
                /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a tag template.</summary>
                public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the tag template. Example: *
                    /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tagTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. A `NOT_FOUND` error is returned if the resource does
                /// not exist. An empty policy is returned if the resource exists but does not have a policy set on it.
                /// Supported resources are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be
                /// used to manage policies for BigQuery, Pub/Sub and any external Google Cloud Platform resources
                /// synced to Data Catalog. Callers must have following Google IAM permission -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entries.getIamPolicy` to get policies on entries. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. A `NOT_FOUND` error is returned if the resource does
                /// not exist. An empty policy is returned if the resource exists but does not have a policy set on it.
                /// Supported resources are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be
                /// used to manage policies for BigQuery, Pub/Sub and any external Google Cloud Platform resources
                /// synced to Data Catalog. Callers must have following Google IAM permission -
                /// `datacatalog.tagTemplates.getIamPolicy` to get policies on tag templates. -
                /// `datacatalog.entries.getIamPolicy` to get policies on entries. -
                /// `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
                /// </summary>
                public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                /// Updates a tag template. This method cannot be used to update the fields of a template. The tag
                /// template fields are represented as separate resources and should be updated using their own
                /// create/update/delete methods. Users should enable the Data Catalog API in the project identified by
                /// the `tag_template.name` parameter (see [Data Catalog Resource Project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the tag template in URL format. Example: *
                /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id} Note that this TagTemplate
                /// and its child resources may not actually be stored in the location in this name.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a tag template. This method cannot be used to update the fields of a template. The tag
                /// template fields are represented as separate resources and should be updated using their own
                /// create/update/delete methods. Users should enable the Data Catalog API in the project identified by
                /// the `tag_template.name` parameter (see [Data Catalog Resource Project]
                /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for more information).
                /// </summary>
                public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the tag template in URL format. Example: *
                    /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id} Note that this
                    /// TagTemplate and its child resources may not actually be stored in the location in this name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Names of fields whose values to overwrite on a tag template. Currently, only `display_name` can
                    /// be overwritten. In general, if this parameter is absent or empty, all modifiable fields are
                    /// overwritten. If such fields are non-required and omitted in the request body, their values are
                    /// emptied.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1TagTemplate Body { get; set; }

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
                /// Sets the access control policy for a resource. Replaces any existing policy. Supported resources
                /// are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies
                /// for BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog.
                /// Callers must have following Google IAM permission - `datacatalog.tagTemplates.setIamPolicy` to set
                /// policies on tag templates. - `datacatalog.entries.setIamPolicy` to set policies on entries. -
                /// `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy for a resource. Replaces any existing policy. Supported resources
                /// are: - Tag templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies
                /// for BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog.
                /// Callers must have following Google IAM permission - `datacatalog.tagTemplates.setIamPolicy` to set
                /// policies on tag templates. - `datacatalog.entries.setIamPolicy` to set policies on entries. -
                /// `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
                /// </summary>
                public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                /// Returns the caller's permissions on a resource. If the resource does not exist, an empty set of
                /// permissions is returned (We don't return a `NOT_FOUND` error). Supported resources are: - Tag
                /// templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies for
                /// BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog. A caller
                /// is not required to have Google IAM permission to make this request.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns the caller's permissions on a resource. If the resource does not exist, an empty set of
                /// permissions is returned (We don't return a `NOT_FOUND` error). Supported resources are: - Tag
                /// templates. - Entries. - Entry groups. Note, this method cannot be used to manage policies for
                /// BigQuery, Pub/Sub and any external Google Cloud Platform resources synced to Data Catalog. A caller
                /// is not required to have Google IAM permission to make this request.
                /// </summary>
                public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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

                    /// <summary>Creates a policy tag in the specified taxonomy.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Resource name of the taxonomy that the policy tag will belong to.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a policy tag in the specified taxonomy.</summary>
                    public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag body, string parent) : base(service)
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
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/policyTags";

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

                    /// <summary>Deletes a policy tag. Also deletes all of its descendant policy tags.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the policy tag to be deleted. All of its descendant policy tags will
                    /// also be deleted.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a policy tag. Also deletes all of its descendant policy tags.</summary>
                    public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the policy tag to be deleted. All of its descendant policy tags
                        /// will also be deleted.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a policy tag.</summary>
                    /// <param name="name">Required. Resource name of the requested policy tag.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a policy tag.</summary>
                    public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Resource name of the requested policy tag.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+/policyTags/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the IAM policy for a taxonomy or a policy tag.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>Gets the IAM policy for a taxonomy or a policy tag.</summary>
                    public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                    /// <param name="parent">Required. Resource name of the taxonomy to list the policy tags of.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all policy tags in a taxonomy.</summary>
                    public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ListPolicyTagsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Resource name of the taxonomy to list the policy tags of.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of items to return. Must be a value between 1 and 1000. If not set,
                        /// defaults to 50.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The next_page_token value returned from a previous List request, if any. If not set,
                        /// defaults to an empty string.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/policyTags";

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

                    /// <summary>Updates a policy tag.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. Resource name of this policy tag, whose format is:
                    /// "projects/{project_number}/locations/{location_id}/taxonomies/{taxonomy_id}/policyTags/{id}".
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a policy tag.</summary>
                    public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. Resource name of this policy tag, whose format is:
                        /// "projects/{project_number}/locations/{location_id}/taxonomies/{taxonomy_id}/policyTags/{id}".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The update mask applies to the resource. Only display_name, description and
                        /// parent_policy_tag can be updated and thus can be listed in the mask. If update_mask is not
                        /// provided, all allowed fields (i.e. display_name, description and parent) will be updated.
                        /// For more information including the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If
                        /// not set, defaults to all of the fields that are allowed to update.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1PolicyTag Body { get; set; }

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

                    /// <summary>Sets the IAM policy for a taxonomy or a policy tag.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>Sets the IAM policy for a taxonomy or a policy tag.</summary>
                    public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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

                    /// <summary>
                    /// Returns the permissions that a caller has on the specified taxonomy or policy tag.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns the permissions that a caller has on the specified taxonomy or policy tag.
                    /// </summary>
                    public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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

                /// <summary>Creates a taxonomy in the specified project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the project that the taxonomy will belong to.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a taxonomy in the specified project.</summary>
                public class CreateRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the project that the taxonomy will belong to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/taxonomies";

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
                /// Deletes a taxonomy. This operation will also delete all policy tags in this taxonomy along with
                /// their associated policies.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the taxonomy to be deleted. All policy tags in this taxonomy will also be
                /// deleted.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a taxonomy. This operation will also delete all policy tags in this taxonomy along with
                /// their associated policies.
                /// </summary>
                public class DeleteRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the taxonomy to be deleted. All policy tags in this taxonomy will
                    /// also be deleted.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Exports all taxonomies and their policy tags in a project. This method generates SerializedTaxonomy
                /// protos with nested policy tags that can be used as an input for future ImportTaxonomies calls.
                /// </summary>
                /// <param name="parent">
                /// Required. Resource name of the project that taxonomies to be exported will share.
                /// </param>
                public virtual ExportRequest Export(string parent)
                {
                    return new ExportRequest(this.service, parent);
                }

                /// <summary>
                /// Exports all taxonomies and their policy tags in a project. This method generates SerializedTaxonomy
                /// protos with nested policy tags that can be used as an input for future ImportTaxonomies calls.
                /// </summary>
                public class ExportRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ExportTaxonomiesResponse>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project that taxonomies to be exported will share.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Export taxonomies as serialized taxonomies.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("serializedTaxonomies", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> SerializedTaxonomies { get; set; }

                    /// <summary>Required. Resource names of the taxonomies to be exported.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("taxonomies", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Taxonomies { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/taxonomies:export";

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
                /// <param name="name">Required. Resource name of the requested taxonomy.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a taxonomy.</summary>
                public class GetRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the requested taxonomy.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/taxonomies/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the IAM policy for a taxonomy or a policy tag.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Gets the IAM policy for a taxonomy or a policy tag.</summary>
                public class GetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                /// Imports all taxonomies and their policy tags to a project as new taxonomies. This method provides a
                /// bulk taxonomy / policy tag creation using nested proto structure.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of project that the imported taxonomies will belong to.
                /// </param>
                public virtual ImportRequest Import(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ImportTaxonomiesRequest body, string parent)
                {
                    return new ImportRequest(this.service, body, parent);
                }

                /// <summary>
                /// Imports all taxonomies and their policy tags to a project as new taxonomies. This method provides a
                /// bulk taxonomy / policy tag creation using nested proto structure.
                /// </summary>
                public class ImportRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ImportTaxonomiesResponse>
                {
                    /// <summary>Constructs a new Import request.</summary>
                    public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ImportTaxonomiesRequest body, string parent) : base(service)
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
                    Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ImportTaxonomiesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "import";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/taxonomies:import";

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
                /// Lists all taxonomies in a project in a particular location that the caller has permission to view.
                /// </summary>
                /// <param name="parent">Required. Resource name of the project to list the taxonomies of.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all taxonomies in a project in a particular location that the caller has permission to view.
                /// </summary>
                public class ListRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1ListTaxonomiesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the project to list the taxonomies of.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Supported field for filter is 'service' and value is 'dataplex'. Eg: service=dataplex.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of items to return. Must be a value between 1 and 1000. If not set, defaults
                    /// to 50.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The next_page_token value returned from a previous list request, if any. If not set, defaults to
                    /// an empty string.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/taxonomies";

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

                /// <summary>Updates a taxonomy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Resource name of this taxonomy, whose format is:
                /// "projects/{project_number}/locations/{location_id}/taxonomies/{id}".
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a taxonomy.</summary>
                public class PatchRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Resource name of this taxonomy, whose format is:
                    /// "projects/{project_number}/locations/{location_id}/taxonomies/{id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The update mask applies to the resource. For the `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If not
                    /// set, defaults to all of the fields that are allowed to update.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.GoogleCloudDatacatalogV1beta1Taxonomy Body { get; set; }

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

                /// <summary>Sets the IAM policy for a taxonomy or a policy tag.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Sets the IAM policy for a taxonomy or a policy tag.</summary>
                public class SetIamPolicyRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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

                /// <summary>
                /// Returns the permissions that a caller has on the specified taxonomy or policy tag.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns the permissions that a caller has on the specified taxonomy or policy tag.
                /// </summary>
                public class TestIamPermissionsRequest : DataCatalogBaseServiceRequest<Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataCatalog.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
namespace Google.Apis.DataCatalog.v1beta1.Data
{
    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

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
        /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and 3.
        /// Requests specifying an invalid value will be rejected. Requests for policies with any conditional role
        /// bindings must specify version 3. Policies with no conditional role bindings may specify any valid value or
        /// leave the field unset. The policy in the response might use the policy version that you specified, or it
        /// might use a lower policy version. For example, if you specify version 3, but the policy has no conditional
        /// role bindings, the response uses version 1. To learn which resources support conditions in their IAM
        /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
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

        /// <summary>Output only. BigQuery resource name of the latest shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestShardResource")]
        public virtual string LatestShardResource { get; set; }

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

    /// <summary>Business Context of the entry.</summary>
    public class GoogleCloudDatacatalogV1BusinessContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contact people for the entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual GoogleCloudDatacatalogV1Contacts Contacts { get; set; }

        /// <summary>Entry overview fields for rich text descriptions of entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryOverview")]
        public virtual GoogleCloudDatacatalogV1EntryOverview EntryOverview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification that applies to Instance entries that are part of `CLOUD_BIGTABLE` system. (user_specified_type)
    /// </summary>
    public class GoogleCloudDatacatalogV1CloudBigtableInstanceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of clusters for the Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBigtableClusterSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1CloudBigtableInstanceSpecCloudBigtableClusterSpec> CloudBigtableClusterSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Spec that applies to clusters of an Instance of Cloud Bigtable.</summary>
    public class GoogleCloudDatacatalogV1CloudBigtableInstanceSpecCloudBigtableClusterSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>A link back to the parent resource, in this case Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedResource")]
        public virtual string LinkedResource { get; set; }

        /// <summary>Location of the cluster, typically a Cloud zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Type of the resource. For a cluster this would be "CLUSTER".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification that applies to all entries that are part of `CLOUD_BIGTABLE` system (user_specified_type)
    /// </summary>
    public class GoogleCloudDatacatalogV1CloudBigtableSystemSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Display name of the Instance. This is user specified and different from the resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceDisplayName")]
        public virtual string InstanceDisplayName { get; set; }

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

        /// <summary>Optional. Default value for the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; }

        /// <summary>
        /// Optional. Description of the column. Default value is an empty string. The description must be a UTF-8
        /// string with the maximum size of 2000 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Garbage collection policy for the column or column family. Applies to systems like Cloud Bigtable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcRule")]
        public virtual string GcRule { get; set; }

        /// <summary>Optional. Most important inclusion of this column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highestIndexingType")]
        public virtual string HighestIndexingType { get; set; }

        /// <summary>Looker specific column info of this column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lookerColumnSpec")]
        public virtual GoogleCloudDatacatalogV1ColumnSchemaLookerColumnSpec LookerColumnSpec { get; set; }

        /// <summary>
        /// Optional. A column's mode indicates whether values in this column are required, nullable, or repeated. Only
        /// `NULLABLE`, `REQUIRED`, and `REPEATED` values are supported. Default mode is `NULLABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Optional. Ordinal position</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ordinalPosition")]
        public virtual System.Nullable<int> OrdinalPosition { get; set; }

        /// <summary>
        /// Optional. The subtype of the RANGE, if the type of this field is RANGE. If the type is RANGE, this field is
        /// required. Possible values for the field element type of a RANGE include: * DATE * DATETIME * TIMESTAMP
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeElementType")]
        public virtual GoogleCloudDatacatalogV1ColumnSchemaFieldElementType RangeElementType { get; set; }

        /// <summary>Optional. Schema of sub-columns. A column can have zero or more sub-columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subcolumns")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1ColumnSchema> Subcolumns { get; set; }

        /// <summary>Required. Type of the column. Must be a UTF-8 string with the maximum size of 128 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the type of a field element.</summary>
    public class GoogleCloudDatacatalogV1ColumnSchemaFieldElementType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of a field element. See ColumnSchema.type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Column info specific to Looker System.</summary>
    public class GoogleCloudDatacatalogV1ColumnSchemaLookerColumnSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Looker specific column type of this column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common statistics on the entry's usage. They can be set on any system.</summary>
    public class GoogleCloudDatacatalogV1CommonUsageStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>View count in source system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewCount")]
        public virtual System.Nullable<long> ViewCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contact people for the entry.</summary>
    public class GoogleCloudDatacatalogV1Contacts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of contact people for the entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("people")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1ContactsPerson> People { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A contact person for the entry.</summary>
    public class GoogleCloudDatacatalogV1ContactsPerson : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Designation of the person, for example, Data Steward.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("designation")]
        public virtual string Designation { get; set; }

        /// <summary>Email of the person in the format of `john.doe@xyz`, ``, or `John Doe`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

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

        /// <summary>Output only. Data Catalog entry name, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceEntry")]
        public virtual string SourceEntry { get; set; }

        /// <summary>Detailed properties of the underlying storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageProperties")]
        public virtual GoogleCloudDatacatalogV1StorageProperties StorageProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification that applies to a data source connection. Valid only for entries with the `DATA_SOURCE_CONNECTION`
    /// type. Only one of internal specs can be set at the time, and cannot be changed later.
    /// </summary>
    public class GoogleCloudDatacatalogV1DataSourceConnectionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Fields specific to BigQuery connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryConnectionSpec")]
        public virtual GoogleCloudDatacatalogV1BigQueryConnectionSpec BigqueryConnectionSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to a table resource. Valid only for entries with the `TABLE` type.</summary>
    public class GoogleCloudDatacatalogV1DatabaseTableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Spec what applies to tables that are actually views. Not set for "real" tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseViewSpec")]
        public virtual GoogleCloudDatacatalogV1DatabaseTableSpecDatabaseViewSpec DatabaseViewSpec { get; set; }

        /// <summary>
        /// Output only. Fields specific to a Dataplex Universal Catalog table and present only in the Dataplex
        /// Universal Catalog table entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplexTable")]
        public virtual GoogleCloudDatacatalogV1DataplexTableSpec DataplexTable { get; set; }

        /// <summary>Type of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to database view.</summary>
    public class GoogleCloudDatacatalogV1DatabaseTableSpecDatabaseViewSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a singular table this view reflects one to one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTable")]
        public virtual string BaseTable { get; set; }

        /// <summary>SQL query used to generate this view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlQuery")]
        public virtual string SqlQuery { get; set; }

        /// <summary>Type of this view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewType")]
        public virtual string ViewType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// External table registered by Dataplex Universal Catalog. Dataplex Universal Catalog publishes data discovered
    /// from an asset into multiple other systems (BigQuery, DPMS) in form of tables. We call them "external tables".
    /// External tables are also synced into the Data Catalog. This message contains pointers to those external tables
    /// (fully qualified name, resource name et cetera) within the Data Catalog.
    /// </summary>
    public class GoogleCloudDatacatalogV1DataplexExternalTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the Data Catalog entry representing the external table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCatalogEntry")]
        public virtual string DataCatalogEntry { get; set; }

        /// <summary>Fully qualified name (FQN) of the external table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyQualifiedName")]
        public virtual string FullyQualifiedName { get; set; }

        /// <summary>Google Cloud resource name of the external table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudResource")]
        public virtual string GoogleCloudResource { get; set; }

        /// <summary>Service in which the external table is registered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("system")]
        public virtual string System { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entry specification for a Dataplex Universal Catalog fileset.</summary>
    public class GoogleCloudDatacatalogV1DataplexFilesetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common Dataplex Universal Catalog fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplexSpec")]
        public virtual GoogleCloudDatacatalogV1DataplexSpec DataplexSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common Dataplex Universal Catalog fields.</summary>
    public class GoogleCloudDatacatalogV1DataplexSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Fully qualified resource name of an asset in Dataplex Universal Catalog, to which the underlying data source
        /// (Cloud Storage bucket or BigQuery dataset) of the entity is attached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>Compression format of the data, e.g., zip, gzip etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compressionFormat")]
        public virtual string CompressionFormat { get; set; }

        /// <summary>Format of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFormat")]
        public virtual GoogleCloudDatacatalogV1PhysicalSchema DataFormat { get; set; }

        /// <summary>
        /// Project ID of the underlying Cloud Storage or BigQuery data. Note that this may not be the same project as
        /// the corresponding Dataplex Universal Catalog lake / zone / asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entry specification for a Dataplex Universal Catalog table.</summary>
    public class GoogleCloudDatacatalogV1DataplexTableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common Dataplex Universal Catalog fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplexSpec")]
        public virtual GoogleCloudDatacatalogV1DataplexSpec DataplexSpec { get; set; }

        /// <summary>
        /// List of external tables registered by Dataplex Universal Catalog in other systems based on the same
        /// underlying data. External tables allow to query this data in those systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalTables")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1DataplexExternalTable> ExternalTables { get; set; }

        /// <summary>Indicates if the table schema is managed by the user or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userManaged")]
        public virtual System.Nullable<bool> UserManaged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to a dataset. Valid only for entries with the `DATASET` type.</summary>
    public class GoogleCloudDatacatalogV1DatasetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Vertex AI Dataset specific fields</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexDatasetSpec")]
        public virtual GoogleCloudDatacatalogV1VertexDatasetSpec VertexDatasetSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for any item that can be contained in the dump.</summary>
    public class GoogleCloudDatacatalogV1DumpItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Entry and its tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taggedEntry")]
        public virtual GoogleCloudDatacatalogV1TaggedEntry TaggedEntry { get; set; }

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
        /// Output only. Specification for a group of BigQuery tables with the `[prefix]YYYYMMDD` name pattern. For more
        /// information, see [Introduction to partitioned tables]
        /// (https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDateShardedSpec")]
        public virtual GoogleCloudDatacatalogV1BigQueryDateShardedSpec BigqueryDateShardedSpec { get; set; }

        /// <summary>
        /// Output only. Specification that applies to a BigQuery table. Valid only for entries with the `TABLE` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryTableSpec")]
        public virtual GoogleCloudDatacatalogV1BigQueryTableSpec BigqueryTableSpec { get; set; }

        /// <summary>Business Context of the entry. Not supported for BigQuery datasets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessContext")]
        public virtual GoogleCloudDatacatalogV1BusinessContext BusinessContext { get; set; }

        /// <summary>
        /// Specification that applies to Cloud Bigtable system. Only settable when `integrated_system` is equal to
        /// `CLOUD_BIGTABLE`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBigtableSystemSpec")]
        public virtual GoogleCloudDatacatalogV1CloudBigtableSystemSpec CloudBigtableSystemSpec { get; set; }

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
        /// Specification that applies to a table resource. Valid only for entries with the `TABLE` or `EXPLORE` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseTableSpec")]
        public virtual GoogleCloudDatacatalogV1DatabaseTableSpec DatabaseTableSpec { get; set; }

        /// <summary>Specification that applies to a dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetSpec")]
        public virtual GoogleCloudDatacatalogV1DatasetSpec DatasetSpec { get; set; }

        /// <summary>
        /// Entry description that can consist of several sentences or paragraphs that describe entry contents. The
        /// description must not contain Unicode non-characters as well as C0 and C1 control codes except tabs (HT), new
        /// lines (LF), carriage returns (CR), and page breaks (FF). The maximum size is 2000 bytes when encoded in
        /// UTF-8. Default value is an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Display name of an entry. The maximum size is 500 bytes when encoded in UTF-8. Default value is an empty
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>FeatureonlineStore spec for Vertex AI Feature Store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureOnlineStoreSpec")]
        public virtual GoogleCloudDatacatalogV1FeatureOnlineStoreSpec FeatureOnlineStoreSpec { get; set; }

        /// <summary>
        /// Specification that applies to a fileset resource. Valid only for entries with the `FILESET` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesetSpec")]
        public virtual GoogleCloudDatacatalogV1FilesetSpec FilesetSpec { get; set; }

        /// <summary>
        /// [Fully Qualified Name (FQN)](https://cloud.google.com//data-catalog/docs/fully-qualified-names) of the
        /// resource. Set automatically for entries representing resources from synced systems. Settable only during
        /// creation, and read-only later. Can be used for search and lookup of the entries.
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
        /// Specification that applies to Looker sysstem. Only settable when `user_specified_system` is equal to
        /// `LOOKER`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lookerSystemSpec")]
        public virtual GoogleCloudDatacatalogV1LookerSystemSpec LookerSystemSpec { get; set; }

        /// <summary>Model specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelSpec")]
        public virtual GoogleCloudDatacatalogV1ModelSpec ModelSpec { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of an entry in URL format. Note: The entry itself and its child
        /// resources might not be stored in the location specified in its name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Additional information related to the entry. Private to the current user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalDetails")]
        public virtual GoogleCloudDatacatalogV1PersonalDetails PersonalDetails { get; set; }

        /// <summary>
        /// Specification that applies to a user-defined function or procedure. Valid only for entries with the
        /// `ROUTINE` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routineSpec")]
        public virtual GoogleCloudDatacatalogV1RoutineSpec RoutineSpec { get; set; }

        /// <summary>Schema of the entry. An entry might not have any schema attached to it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual GoogleCloudDatacatalogV1Schema Schema { get; set; }

        /// <summary>Specification that applies to a Service resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceSpec")]
        public virtual GoogleCloudDatacatalogV1ServiceSpec ServiceSpec { get; set; }

        /// <summary>
        /// Timestamps from the underlying resource, not from the Data Catalog entry. Output only when the entry has a
        /// system listed in the `IntegratedSystem` enum. For entries with `user_specified_system`, this field is
        /// optional and defaults to an empty timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSystemTimestamps")]
        public virtual GoogleCloudDatacatalogV1SystemTimestamps SourceSystemTimestamps { get; set; }

        /// <summary>
        /// Specification that applies to a relational database system. Only settable when `user_specified_system` is
        /// equal to `SQL_DATABASE`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlDatabaseSystemSpec")]
        public virtual GoogleCloudDatacatalogV1SqlDatabaseSystemSpec SqlDatabaseSystemSpec { get; set; }

        /// <summary>The type of the entry. For details, see [`EntryType`](#entrytype).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Resource usage statistics.</summary>
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

    /// <summary>Entry overview fields for rich text descriptions of entries.</summary>
    public class GoogleCloudDatacatalogV1EntryOverview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entry overview with support for rich text. The overview must only contain Unicode characters, and should be
        /// formatted using HTML. The maximum length is 10 MiB as this value holds HTML descriptions including encoded
        /// images. The maximum length of the text without images is 100 KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overview")]
        public virtual string Overview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detail description of the source information of a Vertex Feature Online Store.</summary>
    public class GoogleCloudDatacatalogV1FeatureOnlineStoreSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Type of underlying storage for the FeatureOnlineStore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageType")]
        public virtual string StorageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to a fileset. Valid only for entries with the 'FILESET' type.</summary>
    public class GoogleCloudDatacatalogV1FilesetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Fields specific to a Dataplex Universal Catalog fileset and present only in the Dataplex Universal Catalog
        /// fileset entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplexFileset")]
        public virtual GoogleCloudDatacatalogV1DataplexFilesetSpec DataplexFileset { get; set; }

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
        /// Names] (https://cloud.google.com/storage/docs/wildcards). Note: Currently, bucket wildcards are not
        /// supported. Examples of valid `file_patterns`: * `gs://bucket_name/dir/*`: matches all files in
        /// `bucket_name/dir` directory * `gs://bucket_name/dir/**`: matches all files in `bucket_name/dir` and all
        /// subdirectories * `gs://bucket_name/file*`: matches files prefixed by `file` in `bucket_name` *
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

    /// <summary>Metadata message for long-running operation returned by the ImportEntries.</summary>
    public class GoogleCloudDatacatalogV1ImportEntriesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Partial errors that are encountered during the ImportEntries operation. There is no guarantee that all the
        /// encountered errors are reported. However, if no errors are reported, it means that no errors were
        /// encountered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Status> Errors { get; set; }

        /// <summary>State of the import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for long-running operation returned by the ImportEntries.</summary>
    public class GoogleCloudDatacatalogV1ImportEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of entries deleted as a result of import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedEntriesCount")]
        public virtual System.Nullable<long> DeletedEntriesCount { get; set; }

        /// <summary>Cumulative number of entries created and entries updated as a result of import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upsertedEntriesCount")]
        public virtual System.Nullable<long> UpsertedEntriesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to entries that are part `LOOKER` system (user_specified_type)</summary>
    public class GoogleCloudDatacatalogV1LookerSystemSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the parent Looker Instance. Empty if it does not exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentInstanceDisplayName")]
        public virtual string ParentInstanceDisplayName { get; set; }

        /// <summary>
        /// ID of the parent Looker Instance. Empty if it does not exist. Example value: `someinstance.looker.com`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentInstanceId")]
        public virtual string ParentInstanceId { get; set; }

        /// <summary>Name of the parent Model. Empty if it does not exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentModelDisplayName")]
        public virtual string ParentModelDisplayName { get; set; }

        /// <summary>ID of the parent Model. Empty if it does not exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentModelId")]
        public virtual string ParentModelId { get; set; }

        /// <summary>Name of the parent View. Empty if it does not exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentViewDisplayName")]
        public virtual string ParentViewDisplayName { get; set; }

        /// <summary>ID of the parent View. Empty if it does not exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentViewId")]
        public virtual string ParentViewId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification that applies to a model. Valid only for entries with the `MODEL` type.</summary>
    public class GoogleCloudDatacatalogV1ModelSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specification for vertex model resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexModelSpec")]
        public virtual GoogleCloudDatacatalogV1VertexModelSpec VertexModelSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entry metadata relevant only to the user and private to them.</summary>
    public class GoogleCloudDatacatalogV1PersonalDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _starTimeRaw;

        private object _starTime;

        /// <summary>Set if the entry is starred; unset otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starTime")]
        public virtual string StarTimeRaw
        {
            get => _starTimeRaw;
            set
            {
                _starTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _starTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StarTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StarTimeDateTimeOffset instead.")]
        public virtual object StarTime
        {
            get => _starTime;
            set
            {
                _starTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _starTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StarTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StarTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StarTimeRaw);
            set => StarTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>True if the entry is starred by the user; false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starred")]
        public virtual System.Nullable<bool> Starred { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Native schema used by a resource represented as an entry. Used by query engines for deserializing and parsing
    /// source data.
    /// </summary>
    public class GoogleCloudDatacatalogV1PhysicalSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Schema in Avro JSON format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avro")]
        public virtual GoogleCloudDatacatalogV1PhysicalSchemaAvroSchema Avro { get; set; }

        /// <summary>Marks a CSV-encoded data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csv")]
        public virtual GoogleCloudDatacatalogV1PhysicalSchemaCsvSchema Csv { get; set; }

        /// <summary>Marks an ORC-encoded data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orc")]
        public virtual GoogleCloudDatacatalogV1PhysicalSchemaOrcSchema Orc { get; set; }

        /// <summary>Marks a Parquet-encoded data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parquet")]
        public virtual GoogleCloudDatacatalogV1PhysicalSchemaParquetSchema Parquet { get; set; }

        /// <summary>Schema in protocol buffer format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protobuf")]
        public virtual GoogleCloudDatacatalogV1PhysicalSchemaProtobufSchema Protobuf { get; set; }

        /// <summary>Schema in Thrift format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thrift")]
        public virtual GoogleCloudDatacatalogV1PhysicalSchemaThriftSchema Thrift { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schema in Avro JSON format.</summary>
    public class GoogleCloudDatacatalogV1PhysicalSchemaAvroSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>JSON source of the Avro schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Marks a CSV-encoded data source.</summary>
    public class GoogleCloudDatacatalogV1PhysicalSchemaCsvSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Marks an ORC-encoded data source.</summary>
    public class GoogleCloudDatacatalogV1PhysicalSchemaOrcSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Marks a Parquet-encoded data source.</summary>
    public class GoogleCloudDatacatalogV1PhysicalSchemaParquetSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schema in protocol buffer format.</summary>
    public class GoogleCloudDatacatalogV1PhysicalSchemaProtobufSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Protocol buffer source of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schema in Thrift format.</summary>
    public class GoogleCloudDatacatalogV1PhysicalSchemaThriftSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Thrift IDL source of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Long-running operation metadata message returned by the ReconcileTags.</summary>
    public class GoogleCloudDatacatalogV1ReconcileTagsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maps the name of each tagged column (or empty string for a sole entry) to tagging operation status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IDictionary<string, Status> Errors { get; set; }

        /// <summary>State of the reconciliation operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Long-running operation response message returned by ReconcileTags.</summary>
    public class GoogleCloudDatacatalogV1ReconcileTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of tags created in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdTagsCount")]
        public virtual System.Nullable<long> CreatedTagsCount { get; set; }

        /// <summary>Number of tags deleted in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedTagsCount")]
        public virtual System.Nullable<long> DeletedTagsCount { get; set; }

        /// <summary>Number of tags updated in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedTagsCount")]
        public virtual System.Nullable<long> UpdatedTagsCount { get; set; }

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

    /// <summary>
    /// Specification that applies to a Service resource. Valid only for entries with the `SERVICE` type.
    /// </summary>
    public class GoogleCloudDatacatalogV1ServiceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specification that applies to Instance entries of `CLOUD_BIGTABLE` system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBigtableInstanceSpec")]
        public virtual GoogleCloudDatacatalogV1CloudBigtableInstanceSpec CloudBigtableInstanceSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification that applies to entries that are part `SQL_DATABASE` system (user_specified_type)
    /// </summary>
    public class GoogleCloudDatacatalogV1SqlDatabaseSystemSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Version of the database engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>
        /// Host of the SQL database enum InstanceHost { UNDEFINED = 0; SELF_HOSTED = 1; CLOUD_SQL = 2; AMAZON_RDS = 3;
        /// AZURE_SQL = 4; } Host of the enclousing database instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceHost")]
        public virtual string InstanceHost { get; set; }

        /// <summary>
        /// SQL Database Engine. enum SqlEngine { UNDEFINED = 0; MY_SQL = 1; POSTGRE_SQL = 2; SQL_SERVER = 3; } Engine
        /// of the enclosing database instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlEngine")]
        public virtual string SqlEngine { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details the properties of the underlying storage.</summary>
    public class GoogleCloudDatacatalogV1StorageProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Patterns to identify a set of files for this fileset. Examples of a valid `file_pattern`: *
        /// `gs://bucket_name/dir/*`: matches all files in the `bucket_name/dir` directory * `gs://bucket_name/dir/**`:
        /// matches all files in the `bucket_name/dir` and all subdirectories recursively * `gs://bucket_name/file*`:
        /// matches files prefixed by `file` in `bucket_name` * `gs://bucket_name/??.txt`: matches files with two
        /// characters followed by `.txt` in `bucket_name` * `gs://bucket_name/[aeiou].txt`: matches files that contain
        /// a single vowel character followed by `.txt` in `bucket_name` * `gs://bucket_name/[a-m].txt`: matches files
        /// that contain `a`, `b`, ... or `m` followed by `.txt` in `bucket_name` * `gs://bucket_name/a/*/b`: matches
        /// all files in `bucket_name` that match the `a/*/b` pattern, such as `a/c/b`, `a/d/b` *
        /// `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePattern")]
        public virtual System.Collections.Generic.IList<string> FilePattern { get; set; }

        /// <summary>File type in MIME format, for example, `text/plain`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Timestamps associated with this resource in a particular system.</summary>
    public class GoogleCloudDatacatalogV1SystemTimestamps : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Creation timestamp of the resource within the given system.</summary>
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

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Expiration timestamp of the resource within the given system. Currently only applicable to
        /// BigQuery resources.
        /// </summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Timestamp of the last modification of the resource or its metadata within a given system. Note: Depending on
        /// the source system, not every modification updates this timestamp. For example, BigQuery timestamps every
        /// metadata modification but not data or permission changes.
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

        /// <summary>Output only. Denotes the transfer status of the Tag Template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplexTransferStatus")]
        public virtual string DataplexTransferStatus { get; set; }

        /// <summary>
        /// Required. Maps the ID of a tag field to its value and additional information about that field. Tag template
        /// defines valid field IDs. A tag must have at least 1 field and at most 500 fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1TagField> Fields { get; set; }

        /// <summary>
        /// Identifier. The resource name of the tag in URL format where tag ID is a system-generated identifier. Note:
        /// The tag itself might not be stored in the location specified in its name.
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

        private string _timestampValueRaw;

        private object _timestampValue;

        /// <summary>The value of a tag field with a timestamp type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual string TimestampValueRaw
        {
            get => _timestampValueRaw;
            set
            {
                _timestampValue = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampValueRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampValueRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampValueDateTimeOffset instead.")]
        public virtual object TimestampValue
        {
            get => _timestampValue;
            set
            {
                _timestampValueRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestampValue = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampValueRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampValueDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampValueRaw);
            set => TimestampValueRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
    /// Wrapper containing Entry and information about Tags that should and should not be attached to it.
    /// </summary>
    public class GoogleCloudDatacatalogV1TaggedEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Tags that should be deleted from the Data Catalog. Caller should populate template name and column
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absentTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1Tag> AbsentTags { get; set; }

        /// <summary>
        /// Optional. Tags that should be ingested into the Data Catalog. Caller should populate template name, column
        /// and fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1Tag> PresentTags { get; set; }

        /// <summary>Non-encrypted Data Catalog v1 Entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v1Entry")]
        public virtual GoogleCloudDatacatalogV1Entry V1Entry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The set of all usage signals that Data Catalog stores. Note: Usually, these signals are updated daily. In rare
    /// cases, an update may fail but will be performed again on the next day.
    /// </summary>
    public class GoogleCloudDatacatalogV1UsageSignal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Common usage statistics over each of the predefined time ranges. Supported time ranges are `{"24H", "7D",
        /// "30D", "Lifetime"}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonUsageWithinTimeRange")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1CommonUsageStats> CommonUsageWithinTimeRange { get; set; }

        /// <summary>Favorite count in the source system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("favoriteCount")]
        public virtual System.Nullable<long> FavoriteCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The end timestamp of the duration of usage statistics.</summary>
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
        /// Output only. BigQuery usage statistics over each of the predefined time ranges. Supported time ranges are
        /// `{"24H", "7D", "30D"}`.
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

    /// <summary>Specification for vertex dataset resources.</summary>
    public class GoogleCloudDatacatalogV1VertexDatasetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of DataItems in this Dataset. Only apply for non-structured Dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataItemCount")]
        public virtual System.Nullable<long> DataItemCount { get; set; }

        /// <summary>Type of the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detail description of the source information of a Vertex model.</summary>
    public class GoogleCloudDatacatalogV1VertexModelSourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If this Model is copy of another Model. If true then source_type pertains to the original.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copy")]
        public virtual System.Nullable<bool> Copy { get; set; }

        /// <summary>Type of the model source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification for vertex model resources.</summary>
    public class GoogleCloudDatacatalogV1VertexModelSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of the Docker image to be used as the custom container for serving predictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImageUri")]
        public virtual string ContainerImageUri { get; set; }

        /// <summary>User provided version aliases so that a model version can be referenced via alias</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionAliases")]
        public virtual System.Collections.Generic.IList<string> VersionAliases { get; set; }

        /// <summary>The description of this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionDescription")]
        public virtual string VersionDescription { get; set; }

        /// <summary>The version ID of the model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual string VersionId { get; set; }

        /// <summary>Source of a Vertex model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexModelSourceInfo")]
        public virtual GoogleCloudDatacatalogV1VertexModelSourceInfo VertexModelSourceInfo { get; set; }

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
    /// Spec for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`. Context:
    /// https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Data Catalog resource name of the dataset entry the current table belongs to, for example,
        /// `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Output only. Total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<long> ShardCount { get; set; }

        /// <summary>
        /// Output only. The table name prefix of the shards. The name of any given shard is `[table_prefix]YYYYMMDD`,
        /// for example, for shard `MyTable20180101`, the `table_prefix` is `MyTable`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tablePrefix")]
        public virtual string TablePrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a BigQuery table.</summary>
    public class GoogleCloudDatacatalogV1beta1BigQueryTableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The table source type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableSourceType")]
        public virtual string TableSourceType { get; set; }

        /// <summary>
        /// Spec of a BigQuery table. This field should only be populated if `table_source_type` is `BIGQUERY_TABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableSpec")]
        public virtual GoogleCloudDatacatalogV1beta1TableSpec TableSpec { get; set; }

        /// <summary>
        /// Table view specification. This field should only be populated if `table_source_type` is `BIGQUERY_VIEW`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewSpec")]
        public virtual GoogleCloudDatacatalogV1beta1ViewSpec ViewSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a column within a schema. Columns could be nested inside other columns.</summary>
    public class GoogleCloudDatacatalogV1beta1ColumnSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual string Column { get; set; }

        /// <summary>Optional. Description of the column. Default value is an empty string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A column's mode indicates whether the values in this column are required, nullable, etc. Only
        /// `NULLABLE`, `REQUIRED` and `REPEATED` are supported. Default mode is `NULLABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Optional. Schema of sub-columns. A column can have zero or more sub-columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subcolumns")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1ColumnSchema> Subcolumns { get; set; }

        /// <summary>Required. Type of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Entry Metadata. A Data Catalog Entry resource represents another resource in Google Cloud Platform (such as a
    /// BigQuery dataset or a Pub/Sub topic), or outside of Google Cloud Platform. Clients can use the `linked_resource`
    /// field in the Entry resource to refer to the original resource ID of the source system. An Entry resource
    /// contains resource details, such as its schema. An Entry can also be used to attach flexible metadata, such as a
    /// Tag.
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1Entry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specification for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`. Context:
        /// https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDateShardedSpec")]
        public virtual GoogleCloudDatacatalogV1beta1BigQueryDateShardedSpec BigqueryDateShardedSpec { get; set; }

        /// <summary>
        /// Specification that applies to a BigQuery table. This is only valid on entries of type `TABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryTableSpec")]
        public virtual GoogleCloudDatacatalogV1beta1BigQueryTableSpec BigqueryTableSpec { get; set; }

        /// <summary>
        /// Entry description, which can consist of several sentences or paragraphs that describe entry contents.
        /// Default value is an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Display information such as title and description. A short name to identify the entry, for example,
        /// "Analytics Data - Jan 2011". Default value is an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Specification that applies to a Cloud Storage fileset. This is only valid on entries of type FILESET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsFilesetSpec")]
        public virtual GoogleCloudDatacatalogV1beta1GcsFilesetSpec GcsFilesetSpec { get; set; }

        /// <summary>
        /// Output only. This field indicates the entry's source system that Data Catalog integrates with, such as
        /// BigQuery or Pub/Sub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integratedSystem")]
        public virtual string IntegratedSystem { get; set; }

        /// <summary>
        /// The resource this metadata entry refers to. For Google Cloud Platform resources, `linked_resource` is the
        /// [full name of the resource](https://cloud.google.com/apis/design/resource_names#full_resource_name). For
        /// example, the `linked_resource` for a table resource from BigQuery is: *
        /// //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId Output only when Entry is of
        /// type in the EntryType enum. For entries with user_specified_type, this field is optional and defaults to an
        /// empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedResource")]
        public virtual string LinkedResource { get; set; }

        /// <summary>
        /// Output only. Identifier. The Data Catalog resource name of the entry in URL format. Example: *
        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id} Note that this
        /// Entry and its child resources may not actually be stored in the location in this name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Schema of the entry. An entry might not have any schema attached to it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual GoogleCloudDatacatalogV1beta1Schema Schema { get; set; }

        /// <summary>
        /// Output only. Timestamps about the underlying resource, not about this Data Catalog entry. Output only when
        /// Entry is of type in the EntryType enum. For entries with user_specified_type, this field is optional and
        /// defaults to an empty timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSystemTimestamps")]
        public virtual GoogleCloudDatacatalogV1beta1SystemTimestamps SourceSystemTimestamps { get; set; }

        /// <summary>The type of the entry. Only used for Entries with types in the EntryType enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. Statistics on the usage level of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageSignal")]
        public virtual GoogleCloudDatacatalogV1beta1UsageSignal UsageSignal { get; set; }

        /// <summary>
        /// This field indicates the entry's source system that Data Catalog does not integrate with.
        /// `user_specified_system` strings must begin with a letter or underscore and can only contain letters,
        /// numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSpecifiedSystem")]
        public virtual string UserSpecifiedSystem { get; set; }

        /// <summary>
        /// Entry type if it does not fit any of the input-allowed values listed in `EntryType` enum above. When
        /// creating an entry, users should check the enum values first, if nothing matches the entry to be created,
        /// then provide a custom value, for example "my_special_type". `user_specified_type` strings must begin with a
        /// letter or underscore and can only contain letters, numbers, and underscores; are case insensitive; must be
        /// at least 1 character and at most 64 characters long. Currently, only FILESET enum value is allowed. All
        /// other entries created through Data Catalog must use `user_specified_type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSpecifiedType")]
        public virtual string UserSpecifiedType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EntryGroup Metadata. An EntryGroup resource represents a logical grouping of zero or more Data Catalog Entry
    /// resources.
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1EntryGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamps about this EntryGroup. Default value is empty timestamps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCatalogTimestamps")]
        public virtual GoogleCloudDatacatalogV1beta1SystemTimestamps DataCatalogTimestamps { get; set; }

        /// <summary>
        /// Entry group description, which can consist of several sentences or paragraphs that describe entry group
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
        /// Identifier. The resource name of the entry group in URL format. Example: *
        /// projects/{project_id}/locations/{location}/entryGroups/{entry_group_id} Note that this EntryGroup and its
        /// child resources may not actually be stored in the location in this name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ExportTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1beta1ExportTaxonomiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of taxonomies and policy tags in a tree structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1SerializedTaxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDatacatalogV1beta1FieldType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents an enum type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumType")]
        public virtual GoogleCloudDatacatalogV1beta1FieldTypeEnumType EnumType { get; set; }

        /// <summary>Represents primitive types - string, bool etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primitiveType")]
        public virtual string PrimitiveType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDatacatalogV1beta1FieldTypeEnumType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1FieldTypeEnumTypeEnumValue> AllowedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDatacatalogV1beta1FieldTypeEnumTypeEnumValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display name of the enum value. Must not be an empty string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifications of a single file in Cloud Storage.</summary>
    public class GoogleCloudDatacatalogV1beta1GcsFileSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The full file path. Example: `gs://bucket_name/a/b.txt`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>Output only. Timestamps about the Cloud Storage file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsTimestamps")]
        public virtual GoogleCloudDatacatalogV1beta1SystemTimestamps GcsTimestamps { get; set; }

        /// <summary>Output only. The size of the file, in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a Cloud Storage fileset entry.</summary>
    public class GoogleCloudDatacatalogV1beta1GcsFilesetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Patterns to identify a set of files in Google Cloud Storage. See [Cloud Storage
        /// documentation](https://cloud.google.com/storage/docs/wildcards) for more information. Note that bucket
        /// wildcards are currently not supported. Examples of valid file_patterns: * `gs://bucket_name/dir/*`: matches
        /// all files within `bucket_name/dir` directory. * `gs://bucket_name/dir/**`: matches all files in
        /// `bucket_name/dir` spanning all subdirectories. * `gs://bucket_name/file*`: matches files prefixed by `file`
        /// in `bucket_name` * `gs://bucket_name/??.txt`: matches files with two characters followed by `.txt` in
        /// `bucket_name` * `gs://bucket_name/[aeiou].txt`: matches files that contain a single vowel character followed
        /// by `.txt` in `bucket_name` * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ... or `m`
        /// followed by `.txt` in `bucket_name` * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that
        /// match `a/*/b` pattern, such as `a/c/b`, `a/d/b` * `gs://another_bucket/a.txt`: matches
        /// `gs://another_bucket/a.txt` You can combine wildcards to provide more powerful matches, for example: *
        /// `gs://bucket_name/[a-m]??.j*g`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePatterns")]
        public virtual System.Collections.Generic.IList<string> FilePatterns { get; set; }

        /// <summary>
        /// Output only. Sample files contained in this fileset, not all files contained in this fileset are represented
        /// here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleGcsFileSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1GcsFileSpec> SampleGcsFileSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ImportTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1beta1ImportTaxonomiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inline source used for taxonomies to be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineSource")]
        public virtual GoogleCloudDatacatalogV1beta1InlineSource InlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ImportTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1beta1ImportTaxonomiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Taxonomies that were imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1Taxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inline source used for taxonomies import.</summary>
    public class GoogleCloudDatacatalogV1beta1InlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Taxonomies to be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1SerializedTaxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListEntries.</summary>
    public class GoogleCloudDatacatalogV1beta1ListEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Entry details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1Entry> Entries { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. It is set to empty if no items remain in results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListEntryGroups.</summary>
    public class GoogleCloudDatacatalogV1beta1ListEntryGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>EntryGroup details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1EntryGroup> EntryGroups { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. It is set to empty if no items remain in results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPolicyTags.</summary>
    public class GoogleCloudDatacatalogV1beta1ListPolicyTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token used to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The policy tags that are in the requested taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1PolicyTag> PolicyTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListTags.</summary>
    public class GoogleCloudDatacatalogV1beta1ListTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results. It is set to empty if no items remain in results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Tag details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1Tag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListTaxonomies.</summary>
    public class GoogleCloudDatacatalogV1beta1ListTaxonomiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token used to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Taxonomies that the project contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomies")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1Taxonomy> Taxonomies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Denotes one policy tag in a taxonomy (e.g. ssn). Policy Tags can be defined in a hierarchy. For example,
    /// consider the following hierarchy: Geolocation -&amp;gt; (LatLong, City, ZipCode). PolicyTag "Geolocation"
    /// contains three child policy tags: "LatLong", "City", and "ZipCode".
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1PolicyTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Resource names of child policy tags of this policy tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childPolicyTags")]
        public virtual System.Collections.Generic.IList<string> ChildPolicyTags { get; set; }

        /// <summary>
        /// Description of this policy tag. It must: contain only unicode characters, tabs, newlines, carriage returns
        /// and page breaks; and be at most 2000 bytes long when encoded in UTF-8. If not set, defaults to an empty
        /// description. If not set, defaults to an empty description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. User defined name of this policy tag. It must: be unique within the parent taxonomy; contain only
        /// unicode letters, numbers, underscores, dashes and spaces; not start or end with spaces; and be at most 200
        /// bytes long when encoded in UTF-8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. Resource name of this policy tag, whose format is:
        /// "projects/{project_number}/locations/{location_id}/taxonomies/{taxonomy_id}/policyTags/{id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Resource name of this policy tag's parent policy tag (e.g. for the "LatLong" policy tag in the example
        /// above, this field contains the resource name of the "Geolocation" policy tag). If empty, it means this
        /// policy tag is a top level policy tag (e.g. this field is empty for the "Geolocation" policy tag in the
        /// example above). If not set, defaults to an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentPolicyTag")]
        public virtual string ParentPolicyTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RenameTagTemplateFieldEnumValue.</summary>
    public class GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldEnumValueRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new display name of the enum value. For example, `my_new_enum_value`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newEnumValueDisplayName")]
        public virtual string NewEnumValueDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RenameTagTemplateField.</summary>
    public class GoogleCloudDatacatalogV1beta1RenameTagTemplateFieldRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new ID of this tag template field. For example, `my_new_field`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTagTemplateFieldId")]
        public virtual string NewTagTemplateFieldId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a schema (e.g. BigQuery, GoogleSQL, Avro schema).</summary>
    public class GoogleCloudDatacatalogV1beta1Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Schema of columns. A maximum of 10,000 columns and sub-columns can be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1ColumnSchema> Columns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchCatalog.</summary>
    public class GoogleCloudDatacatalogV1beta1SearchCatalogRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the ordering of results, currently supported case-sensitive choices are: * `relevance`, only
        /// supports descending * `last_modified_timestamp [asc|desc]`, defaults to descending if not specified *
        /// `default` that can only be descending If not specified, defaults to `relevance` descending.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Number of results in the search page. If &amp;lt;=0 then defaults to 10. Max limit for page_size is 1000.
        /// Throws an invalid argument for page_size &amp;gt; 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. Pagination token returned in an earlier SearchCatalogResponse.next_page_token, which indicates
        /// that this is a continuation of a prior SearchCatalogRequest call, and that the system should return the next
        /// page of data. If empty, the first page is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Optional. The query string in search query syntax. An empty query string will result in all data assets (in
        /// the specified scope) that the user has access to. Query strings can be simple as "x" or more qualified as: *
        /// name:x * column:x * description:y Note: Query tokens need to have a minimum of 3 characters for substring
        /// matching to work correctly. See [Data Catalog Search
        /// Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// Required. The scope of this search request. A `scope` that has empty `include_org_ids`,
        /// `include_project_ids` AND false `include_gcp_public_datasets` is considered invalid. Data Catalog will
        /// return an error in such a case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual GoogleCloudDatacatalogV1beta1SearchCatalogRequestScope Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The criteria that select the subspace used for query matching.</summary>
    public class GoogleCloudDatacatalogV1beta1SearchCatalogRequestScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `true`, include Google Cloud public datasets in the search results. Info on Google Cloud public datasets
        /// is available at https://cloud.google.com/public-datasets/. By default, Google Cloud public datasets are
        /// excluded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeGcpPublicDatasets")]
        public virtual System.Nullable<bool> IncludeGcpPublicDatasets { get; set; }

        /// <summary>
        /// The list of organization IDs to search within. To find your organization ID, follow instructions in
        /// https://cloud.google.com/resource-manager/docs/creating-managing-organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeOrgIds")]
        public virtual System.Collections.Generic.IList<string> IncludeOrgIds { get; set; }

        /// <summary>
        /// The list of project IDs to search within. To learn more about the distinction between project
        /// names/IDs/numbers, go to https://cloud.google.com/docs/overview/#projects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeProjectIds")]
        public virtual System.Collections.Generic.IList<string> IncludeProjectIds { get; set; }

        /// <summary>
        /// Optional. The list of locations to search within. 1. If empty, search will be performed in all locations; 2.
        /// If any of the locations are NOT in the valid locations list, error will be returned; 3. Otherwise, search
        /// only the given locations for matching results. Typical usage is to leave this field empty. When a location
        /// is unreachable as returned in the `SearchCatalogResponse.unreachable` field, users can repeat the search
        /// request with this parameter set to get additional information on the error. Valid locations: * asia-east1 *
        /// asia-east2 * asia-northeast1 * asia-northeast2 * asia-northeast3 * asia-south1 * asia-southeast1 *
        /// australia-southeast1 * eu * europe-north1 * europe-west1 * europe-west2 * europe-west3 * europe-west4 *
        /// europe-west6 * global * northamerica-northeast1 * southamerica-east1 * us * us-central1 * us-east1 *
        /// us-east4 * us-west1 * us-west2
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedLocations")]
        public virtual System.Collections.Generic.IList<string> RestrictedLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchCatalog.</summary>
    public class GoogleCloudDatacatalogV1beta1SearchCatalogResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token that can be used to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Search results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1SearchCatalogResult> Results { get; set; }

        /// <summary>The approximate total number of entries matched by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>
        /// Unreachable locations. Search result does not include data from those locations. Users can get additional
        /// information on the error by repeating the search request with a more restrictive parameter -- setting the
        /// value for `SearchDataCatalogRequest.scope.restricted_locations`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A result that appears in the response of a search request. Each result captures details of one entry that
    /// matches the search.
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1SearchCatalogResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full name of the cloud resource the entry belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name. Example: *
        /// `//bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedResource")]
        public virtual string LinkedResource { get; set; }

        private string _modifyTimeRaw;

        private object _modifyTime;

        /// <summary>Last-modified timestamp of the entry from the managing system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifyTime")]
        public virtual string ModifyTimeRaw
        {
            get => _modifyTimeRaw;
            set
            {
                _modifyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _modifyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ModifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ModifyTimeDateTimeOffset instead.")]
        public virtual object ModifyTime
        {
            get => _modifyTime;
            set
            {
                _modifyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _modifyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ModifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ModifyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ModifyTimeRaw);
            set => ModifyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The relative resource name of the resource in URL format. Examples: *
        /// `projects/{project_id}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}` *
        /// `projects/{project_id}/tagTemplates/{tag_template_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeResourceName")]
        public virtual string RelativeResourceName { get; set; }

        /// <summary>
        /// Sub-type of the search result. This is a dot-delimited description of the resource's full type, and is the
        /// same as the value callers would provide in the "type" search facet. Examples: `entry.table`,
        /// `entry.dataStream`, `tagTemplate`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchResultSubtype")]
        public virtual string SearchResultSubtype { get; set; }

        /// <summary>
        /// Type of the search result. This field can be used to determine which Get method to call to fetch the full
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchResultType")]
        public virtual string SearchResultType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing one policy tag when exported as a nested proto.</summary>
    public class GoogleCloudDatacatalogV1beta1SerializedPolicyTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Children of the policy tag if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childPolicyTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1SerializedPolicyTag> ChildPolicyTags { get; set; }

        /// <summary>
        /// Description of the serialized policy tag. The length of the description is limited to 2000 bytes when
        /// encoded in UTF-8. If not set, defaults to an empty description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the policy tag. Max 200 bytes when encoded in UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name of the policy tag. This field will be ignored when calling ImportTaxonomies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTag")]
        public virtual string PolicyTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message capturing a taxonomy and its policy tag hierarchy as a nested proto. Used for taxonomy import/export and
    /// mutation.
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1SerializedTaxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of policy types that are activated for a taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activatedPolicyTypes")]
        public virtual System.Collections.Generic.IList<string> ActivatedPolicyTypes { get; set; }

        /// <summary>
        /// Description of the serialized taxonomy. The length of the description is limited to 2000 bytes when encoded
        /// in UTF-8. If not set, defaults to an empty description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the taxonomy. Max 200 bytes when encoded in UTF-8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Top level policy tags associated with the taxonomy if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTags")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatacatalogV1beta1SerializedPolicyTag> PolicyTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Timestamps about this resource according to a particular system.</summary>
    public class GoogleCloudDatacatalogV1beta1SystemTimestamps : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The creation time of the resource within the given system.</summary>
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

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The expiration time of the resource within the given system. Currently only apllicable to
        /// BigQuery resources.
        /// </summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The last-modified time of the resource within the given system.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Normal BigQuery table spec.</summary>
    public class GoogleCloudDatacatalogV1beta1TableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If the table is a dated shard, i.e., with name pattern `[prefix]YYYYMMDD`, `grouped_entry` is
        /// the Data Catalog resource name of the date sharded grouped entry, for example,
        /// `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`. Otherwise,
        /// `grouped_entry` is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupedEntry")]
        public virtual string GroupedEntry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tags are used to attach custom metadata to Data Catalog resources. Tags conform to the specifications within
    /// their tag template. See [Data Catalog IAM](https://cloud.google.com/data-catalog/docs/concepts/iam) for
    /// information on the permissions needed to create or view tags.
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
        /// individual column based on that schema. For attaching a tag to a nested column, use `.` to separate the
        /// column names. Example: * `outer_column.inner_column`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual string Column { get; set; }

        /// <summary>
        /// Required. This maps the ID of a tag field to the value of and additional information about that field. Valid
        /// field IDs are defined by the tag's template. A tag must have at least 1 field and at most 500 fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1beta1TagField> Fields { get; set; }

        /// <summary>
        /// Identifier. The resource name of the tag in URL format. Example: *
        /// projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
        /// where `tag_id` is a system-generated identifier. Note that this Tag may not actually be stored in the
        /// location in this name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The resource name of the tag template that this tag uses. Example: *
        /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id} This field cannot be modified
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

    /// <summary>Contains the value and supporting information for a field within a Tag.</summary>
    public class GoogleCloudDatacatalogV1beta1TagField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Holds the value for a tag field with boolean type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Output only. The display name of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Holds the value for a tag field with double type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>
        /// Holds the value for a tag field with enum type. This value must be one of the allowed values in the
        /// definition of this enum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValue")]
        public virtual GoogleCloudDatacatalogV1beta1TagFieldEnumValue EnumValue { get; set; }

        /// <summary>
        /// Output only. The order of this field with respect to other fields in this tag. It can be set in Tag. For
        /// example, a higher value can indicate a more important field. The value can be negative. Multiple fields can
        /// have the same order, and field orders within a tag do not have to be sequential.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual System.Nullable<int> Order { get; set; }

        /// <summary>Holds the value for a tag field with string type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        private string _timestampValueRaw;

        private object _timestampValue;

        /// <summary>Holds the value for a tag field with timestamp type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual string TimestampValueRaw
        {
            get => _timestampValueRaw;
            set
            {
                _timestampValue = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampValueRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampValueRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampValueDateTimeOffset instead.")]
        public virtual object TimestampValue
        {
            get => _timestampValue;
            set
            {
                _timestampValueRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestampValue = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampValueRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampValueDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampValueRaw);
            set => TimestampValueRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds an enum value.</summary>
    public class GoogleCloudDatacatalogV1beta1TagFieldEnumValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the enum value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A tag template defines a tag, which can have one or more typed fields. The template is used to create and attach
    /// the tag to Google Cloud resources. [Tag template
    /// roles](https://cloud.google.com/iam/docs/understanding-roles#data-catalog-roles) provide permissions to create,
    /// edit, and use the template. See, for example, the [TagTemplate
    /// User](https://cloud.google.com/data-catalog/docs/how-to/template-user) role, which includes permission to use
    /// the tag template to tag resources.
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1TagTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Transfer status of the TagTemplate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplexTransferStatus")]
        public virtual string DataplexTransferStatus { get; set; }

        /// <summary>The display name for this template. Defaults to an empty string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. Map of tag template field IDs to the settings for the field. This map is an exhaustive list of the
        /// allowed fields. This map must contain at least one field and at most 500 fields. The keys to this map are
        /// tag template field IDs. Field IDs can contain letters (both uppercase and lowercase), numbers (0-9) and
        /// underscores (_). Field IDs must be at least 1 character long and at most 64 characters long. Field IDs must
        /// start with a letter or underscore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1beta1TagTemplateField> Fields { get; set; }

        /// <summary>
        /// Identifier. The resource name of the tag template in URL format. Example: *
        /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id} Note that this TagTemplate and its
        /// child resources may not actually be stored in the location in this name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The template for an individual field within a tag template.</summary>
    public class GoogleCloudDatacatalogV1beta1TagTemplateField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description for this field. Defaults to an empty string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The display name for this field. Defaults to an empty string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Whether this is a required field. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRequired")]
        public virtual System.Nullable<bool> IsRequired { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of the tag template field in URL format. Example: *
        /// projects/{project_id}/locations/{location}/tagTemplates/{tag_template}/fields/{field} Note that this
        /// TagTemplateField may not actually be stored in the location in this name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The order of this field with respect to other fields in this tag template. A higher value indicates a more
        /// important field. The value can be negative. Multiple fields can have the same order, and field orders within
        /// a tag do not have to be sequential.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual System.Nullable<int> Order { get; set; }

        /// <summary>Required. The type of value this tag field can contain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual GoogleCloudDatacatalogV1beta1FieldType Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A taxonomy is a collection of policy tags that classify data along a common axis. For instance a data
    /// *sensitivity* taxonomy could contain policy tags denoting PII such as age, zipcode, and SSN. A data *origin*
    /// taxonomy could contain policy tags to distinguish user data, employee data, partner data, public data.
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1Taxonomy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of policy types that are activated for this taxonomy. If not set, defaults to an empty
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activatedPolicyTypes")]
        public virtual System.Collections.Generic.IList<string> ActivatedPolicyTypes { get; set; }

        /// <summary>
        /// Optional. Description of this taxonomy. It must: contain only unicode characters, tabs, newlines, carriage
        /// returns and page breaks; and be at most 2000 bytes long when encoded in UTF-8. If not set, defaults to an
        /// empty description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. User defined name of this taxonomy. It must: contain only unicode letters, numbers, underscores,
        /// dashes and spaces; not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8. The
        /// taxonomy display name must be unique within an organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. Resource name of this taxonomy, whose format is:
        /// "projects/{project_number}/locations/{location_id}/taxonomies/{id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Number of policy tags contained in this taxonomy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyTagCount")]
        public virtual System.Nullable<int> PolicyTagCount { get; set; }

        /// <summary>
        /// Output only. Identity of the service which owns the Taxonomy. This field is only populated when the taxonomy
        /// is created by a Google Cloud service. Currently only 'DATAPLEX' is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual GoogleCloudDatacatalogV1beta1TaxonomyService Service { get; set; }

        /// <summary>Output only. Timestamps about this taxonomy. Only create_time and update_time are used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxonomyTimestamps")]
        public virtual GoogleCloudDatacatalogV1beta1SystemTimestamps TaxonomyTimestamps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The source system of the Taxonomy.</summary>
    public class GoogleCloudDatacatalogV1beta1TaxonomyService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service agent for the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identity")]
        public virtual string Identity { get; set; }

        /// <summary>The Google Cloud service name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The set of all usage signals that we store in Data Catalog.</summary>
    public class GoogleCloudDatacatalogV1beta1UsageSignal : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The timestamp of the end of the usage statistics duration.</summary>
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
        /// Usage statistics over each of the pre-defined time ranges, supported strings for time ranges are {"24H",
        /// "7D", "30D"}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageWithinTimeRange")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDatacatalogV1beta1UsageStats> UsageWithinTimeRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Detailed counts on the entry's usage. Caveats: - Only BigQuery tables have usage stats - The usage stats only
    /// include BigQuery query jobs - The usage stats might be underestimated, e.g. wildcard table references are not
    /// yet counted in usage computation https://cloud.google.com/bigquery/docs/querying-wildcard-tables
    /// </summary>
    public class GoogleCloudDatacatalogV1beta1UsageStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of times that the underlying entry was attempted to be used but was cancelled by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCancellations")]
        public virtual System.Nullable<float> TotalCancellations { get; set; }

        /// <summary>The number of times that the underlying entry was successfully used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCompletions")]
        public virtual System.Nullable<float> TotalCompletions { get; set; }

        /// <summary>Total time spent (in milliseconds) during uses the resulted in completions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalExecutionTimeForCompletionsMillis")]
        public virtual System.Nullable<float> TotalExecutionTimeForCompletionsMillis { get; set; }

        /// <summary>The number of times that the underlying entry was attempted to be used but failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalFailures")]
        public virtual System.Nullable<float> TotalFailures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Table view specification.</summary>
    public class GoogleCloudDatacatalogV1beta1ViewSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The query that defines the table view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewQuery")]
        public virtual string ViewQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
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
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
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
