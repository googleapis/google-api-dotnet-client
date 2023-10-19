// Copyright 2023 Google LLC
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

namespace Google.Apis.DiscoveryEngine.v1beta
{
    /// <summary>The DiscoveryEngine Service.</summary>
    public class DiscoveryEngineService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DiscoveryEngineService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DiscoveryEngineService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "discoveryengine";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://discoveryengine.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://discoveryengine.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Discovery Engine API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Discovery Engine API.</summary>
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

    /// <summary>A base abstract class for DiscoveryEngine requests.</summary>
    public abstract class DiscoveryEngineBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DiscoveryEngineBaseServiceRequest instance.</summary>
        protected DiscoveryEngineBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DiscoveryEngine parameter list.</summary>
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
                Collections = new CollectionsResource(service);
                DataStores = new DataStoresResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Collections resource.</summary>
            public virtual CollectionsResource Collections { get; }

            /// <summary>The "collections" collection of methods.</summary>
            public class CollectionsResource
            {
                private const string Resource = "collections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CollectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    DataStores = new DataStoresResource(service);
                    Engines = new EnginesResource(service);
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the DataStores resource.</summary>
                public virtual DataStoresResource DataStores { get; }

                /// <summary>The "dataStores" collection of methods.</summary>
                public class DataStoresResource
                {
                    private const string Resource = "dataStores";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DataStoresResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Branches = new BranchesResource(service);
                        Conversations = new ConversationsResource(service);
                        Models = new ModelsResource(service);
                        Operations = new OperationsResource(service);
                        Schemas = new SchemasResource(service);
                        ServingConfigs = new ServingConfigsResource(service);
                        SiteSearchEngine = new SiteSearchEngineResource(service);
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
                            Documents = new DocumentsResource(service);
                            Operations = new OperationsResource(service);
                        }

                        /// <summary>Gets the Documents resource.</summary>
                        public virtual DocumentsResource Documents { get; }

                        /// <summary>The "documents" collection of methods.</summary>
                        public class DocumentsResource
                        {
                            private const string Resource = "documents";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public DocumentsResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                            }

                            /// <summary>Creates a Document.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="parent">
                            /// Required. The parent resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// </param>
                            public virtual CreateRequest Create(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string parent)
                            {
                                return new CreateRequest(service, body, parent);
                            }

                            /// <summary>Creates a Document.</summary>
                            public class CreateRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument>
                            {
                                /// <summary>Constructs a new Create request.</summary>
                                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string parent) : base(service)
                                {
                                    Parent = parent;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The parent resource name, such as
                                /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// Required. The ID to use for the Document, which will become the final component of
                                /// the Document.name. If the caller does not have permission to create the Document,
                                /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is returned.
                                /// This field must be unique among all Documents with the same parent. Otherwise, an
                                /// `ALREADY_EXISTS` error is returned. This field must conform to
                                /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length limit of 63
                                /// characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("documentId", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string DocumentId { get; set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "create";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1beta/{+parent}/documents";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+$",
                                    });
                                    RequestParameters.Add("documentId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "documentId",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                }
                            }

                            /// <summary>Deletes a Document.</summary>
                            /// <param name="name">
                            /// Required. Full resource name of Document, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                            /// If the caller does not have permission to delete the Document, regardless of whether or
                            /// not it exists, a `PERMISSION_DENIED` error is returned. If the Document to delete does
                            /// not exist, a `NOT_FOUND` error is returned.
                            /// </param>
                            public virtual DeleteRequest Delete(string name)
                            {
                                return new DeleteRequest(service, name);
                            }

                            /// <summary>Deletes a Document.</summary>
                            public class DeleteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleProtobufEmpty>
                            {
                                /// <summary>Constructs a new Delete request.</summary>
                                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. Full resource name of Document, such as
                                /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                                /// If the caller does not have permission to delete the Document, regardless of whether
                                /// or not it exists, a `PERMISSION_DENIED` error is returned. If the Document to delete
                                /// does not exist, a `NOT_FOUND` error is returned.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "delete";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "DELETE";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1beta/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+/documents/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>Gets a Document.</summary>
                            /// <param name="name">
                            /// Required. Full resource name of Document, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                            /// If the caller does not have permission to access the Document, regardless of whether or
                            /// not it exists, a `PERMISSION_DENIED` error is returned. If the requested Document does
                            /// not exist, a `NOT_FOUND` error is returned.
                            /// </param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(service, name);
                            }

                            /// <summary>Gets a Document.</summary>
                            public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument>
                            {
                                /// <summary>Constructs a new Get request.</summary>
                                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. Full resource name of Document, such as
                                /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                                /// If the caller does not have permission to access the Document, regardless of whether
                                /// or not it exists, a `PERMISSION_DENIED` error is returned. If the requested Document
                                /// does not exist, a `NOT_FOUND` error is returned.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "get";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1beta/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+/documents/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Bulk import of multiple Documents. Request processing may be synchronous. Non-existing
                            /// items will be created. Note: It is possible for a subset of the Documents to be
                            /// successfully updated.
                            /// </summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="parent">
                            /// Required. The parent branch resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// Requires create/update permission.
                            /// </param>
                            public virtual ImportRequest Import(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportDocumentsRequest body, string parent)
                            {
                                return new ImportRequest(service, body, parent);
                            }

                            /// <summary>
                            /// Bulk import of multiple Documents. Request processing may be synchronous. Non-existing
                            /// items will be created. Note: It is possible for a subset of the Documents to be
                            /// successfully updated.
                            /// </summary>
                            public class ImportRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                            {
                                /// <summary>Constructs a new Import request.</summary>
                                public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportDocumentsRequest body, string parent) : base(service)
                                {
                                    Parent = parent;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The parent branch resource name, such as
                                /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                                /// Requires create/update permission.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportDocumentsRequest Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "import";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1beta/{+parent}/documents:import";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>Gets a list of Documents.</summary>
                            /// <param name="parent">
                            /// Required. The parent branch resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// Use `default_branch` as the branch ID, to list documents under the default branch. If
                            /// the caller does not have permission to list Documents under this branch, regardless of
                            /// whether or not this branch exists, a `PERMISSION_DENIED` error is returned.
                            /// </param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(service, parent);
                            }

                            /// <summary>Gets a list of Documents.</summary>
                            public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaListDocumentsResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The parent branch resource name, such as
                                /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                                /// Use `default_branch` as the branch ID, to list documents under the default branch.
                                /// If the caller does not have permission to list Documents under this branch,
                                /// regardless of whether or not this branch exists, a `PERMISSION_DENIED` error is
                                /// returned.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// Maximum number of Documents to return. If unspecified, defaults to 100. The maximum
                                /// allowed value is 1000. Values above 1000 will be coerced to 1000. If this field is
                                /// negative, an `INVALID_ARGUMENT` error is returned.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>
                                /// A page token ListDocumentsResponse.next_page_token, received from a previous
                                /// DocumentService.ListDocuments call. Provide this to retrieve the subsequent page.
                                /// When paginating, all other parameters provided to DocumentService.ListDocuments must
                                /// match the call that provided the page token. Otherwise, an `INVALID_ARGUMENT` error
                                /// is returned.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1beta/{+parent}/documents";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+$",
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

                            /// <summary>Updates a Document.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="name">
                            /// Immutable. The full resource name of the document. Format:
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
                            /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                            /// </param>
                            public virtual PatchRequest Patch(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string name)
                            {
                                return new PatchRequest(service, body, name);
                            }

                            /// <summary>Updates a Document.</summary>
                            public class PatchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument>
                            {
                                /// <summary>Constructs a new Patch request.</summary>
                                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string name) : base(service)
                                {
                                    Name = name;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Immutable. The full resource name of the document. Format:
                                /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
                                /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>
                                /// If set to true, and the Document is not found, a new Document will be created.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<bool> AllowMissing { get; set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "patch";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "PATCH";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1beta/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+/documents/[^/]+$",
                                    });
                                    RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "allowMissing",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                }
                            }

                            /// <summary>
                            /// Permanently deletes all selected Documents in a branch. This process is asynchronous.
                            /// Depending on the number of Documents to be deleted, this operation can take hours to
                            /// complete. Before the delete operation completes, some Documents might still be returned
                            /// by DocumentService.GetDocument or DocumentService.ListDocuments. To get a list of the
                            /// Documents to be deleted, set PurgeDocumentsRequest.force to false.
                            /// </summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="parent">
                            /// Required. The parent resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// </param>
                            public virtual PurgeRequest Purge(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaPurgeDocumentsRequest body, string parent)
                            {
                                return new PurgeRequest(service, body, parent);
                            }

                            /// <summary>
                            /// Permanently deletes all selected Documents in a branch. This process is asynchronous.
                            /// Depending on the number of Documents to be deleted, this operation can take hours to
                            /// complete. Before the delete operation completes, some Documents might still be returned
                            /// by DocumentService.GetDocument or DocumentService.ListDocuments. To get a list of the
                            /// Documents to be deleted, set PurgeDocumentsRequest.force to false.
                            /// </summary>
                            public class PurgeRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                            {
                                /// <summary>Constructs a new Purge request.</summary>
                                public PurgeRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaPurgeDocumentsRequest body, string parent) : base(service)
                                {
                                    Parent = parent;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The parent resource name, such as
                                /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaPurgeDocumentsRequest Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "purge";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1beta/{+parent}/documents:purge";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+$",
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
                            public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                                public override string RestPath => "v1beta/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+/operations/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            /// <param name="name">The name of the operation's parent resource.</param>
                            public virtual ListRequest List(string name)
                            {
                                return new ListRequest(service, name);
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                                public override string RestPath => "v1beta/{+name}/operations";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/branches/[^/]+$",
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

                    /// <summary>Gets the Conversations resource.</summary>
                    public virtual ConversationsResource Conversations { get; }

                    /// <summary>The "conversations" collection of methods.</summary>
                    public class ConversationsResource
                    {
                        private const string Resource = "conversations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ConversationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Converses a conversation.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the Conversation to get. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
                        /// Use
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
                        /// to activate auto session mode, which automatically creates a new conversation inside a
                        /// ConverseConversation session.
                        /// </param>
                        public virtual ConverseRequest Converse(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationRequest body, string name)
                        {
                            return new ConverseRequest(service, body, name);
                        }

                        /// <summary>Converses a conversation.</summary>
                        public class ConverseRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationResponse>
                        {
                            /// <summary>Constructs a new Converse request.</summary>
                            public ConverseRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Conversation to get. Format:
                            /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
                            /// Use
                            /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
                            /// to activate auto session mode, which automatically creates a new conversation inside a
                            /// ConverseConversation session.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "converse";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}:converse";

                            /// <summary>Initializes Converse parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Creates a Conversation. If the Conversation to create already exists, an ALREADY_EXISTS
                        /// error is returned.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. Full resource name of parent data store. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Creates a Conversation. If the Conversation to create already exists, an ALREADY_EXISTS
                        /// error is returned.
                        /// </summary>
                        public class CreateRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of parent data store. Format:
                            /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/conversations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes a Conversation. If the Conversation to delete does not exist, a NOT_FOUND error is
                        /// returned.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the Conversation to delete. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes a Conversation. If the Conversation to delete does not exist, a NOT_FOUND error is
                        /// returned.
                        /// </summary>
                        public class DeleteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Conversation to delete. Format:
                            /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets a Conversation.</summary>
                        /// <param name="name">
                        /// Required. The resource name of the Conversation to get. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets a Conversation.</summary>
                        public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Conversation to get. Format:
                            /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists all Conversations by their parent DataStore.</summary>
                        /// <param name="parent">
                        /// Required. The data store resource name. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists all Conversations by their parent DataStore.</summary>
                        public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaListConversationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The data store resource name. Format:
                            /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// A filter to apply on the list results. The supported features are: user_pseudo_id,
                            /// state. Example: "user_pseudo_id = some_id"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// A comma-separated list of fields to order by, sorted in ascending order. Use "desc"
                            /// after a field name for descending. Supported fields: * `update_time` * `create_time` *
                            /// `conversation_name` Example: "update_time desc" "create_time"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Maximum number of results to return. If unspecified, defaults to 50. Max allowed value
                            /// is 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListConversations` call. Provide this to
                            /// retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/conversations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "orderBy",
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
                        /// Updates a Conversation. Conversation action type cannot be changed. If the Conversation to
                        /// update does not exist, a NOT_FOUND error is returned.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Immutable. Fully qualified name
                        /// `project/*/locations/global/collections/{collection}/dataStore/*/conversations/*`
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>
                        /// Updates a Conversation. Conversation action type cannot be changed. If the Conversation to
                        /// update does not exist, a NOT_FOUND error is returned.
                        /// </summary>
                        public class PatchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Immutable. Fully qualified name
                            /// `project/*/locations/global/collections/{collection}/dataStore/*/conversations/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Indicates which fields in the provided Conversation to update. The following are NOT
                            /// supported: * conversation.name If not set or empty, all supported fields are updated.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
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
                            public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                                public override string RestPath => "v1beta/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/models/[^/]+/operations/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            /// <param name="name">The name of the operation's parent resource.</param>
                            public virtual ListRequest List(string name)
                            {
                                return new ListRequest(service, name);
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                                public override string RestPath => "v1beta/{+name}/operations";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/models/[^/]+$",
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
                        public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        /// <param name="name">The name of the operation's parent resource.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                            public override string RestPath => "v1beta/{+name}/operations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
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

                    /// <summary>Gets the Schemas resource.</summary>
                    public virtual SchemasResource Schemas { get; }

                    /// <summary>The "schemas" collection of methods.</summary>
                    public class SchemasResource
                    {
                        private const string Resource = "schemas";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SchemasResource(Google.Apis.Services.IClientService service)
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
                            public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                                public override string RestPath => "v1beta/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/schemas/[^/]+/operations/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            /// <param name="name">The name of the operation's parent resource.</param>
                            public virtual ListRequest List(string name)
                            {
                                return new ListRequest(service, name);
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                                public override string RestPath => "v1beta/{+name}/operations";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/schemas/[^/]+$",
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

                        /// <summary>Creates a Schema.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent data store resource name, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a Schema.</summary>
                        public class CreateRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent data store resource name, in the format of
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the Schema, which will become the final component of the
                            /// Schema.name. This field should conform to
                            /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length limit of 63
                            /// characters.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("schemaId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string SchemaId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/schemas";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
                                });
                                RequestParameters.Add("schemaId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "schemaId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Deletes a Schema.</summary>
                        /// <param name="name">
                        /// Required. The full resource name of the schema, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes a Schema.</summary>
                        public class DeleteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The full resource name of the schema, in the format of
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/schemas/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets a Schema.</summary>
                        /// <param name="name">
                        /// Required. The full resource name of the schema, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets a Schema.</summary>
                        public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The full resource name of the schema, in the format of
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/schemas/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets a list of Schemas.</summary>
                        /// <param name="parent">
                        /// Required. The parent data store resource name, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Gets a list of Schemas.</summary>
                        public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaListSchemasResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent data store resource name, in the format of
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of Schemas to return. The service may return fewer than this value.
                            /// If unspecified, at most 100 Schemas will be returned. The maximum value is 1000; values
                            /// above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous SchemaService.ListSchemas call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// SchemaService.ListSchemas must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/schemas";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
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

                        /// <summary>Updates a Schema.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Immutable. The full resource name of the schema, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                        /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates a Schema.</summary>
                        public class PatchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Immutable. The full resource name of the schema, in the format of
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                            /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// If set to true, and the Schema is not found, a new Schema will be created. In this
                            /// situation, `update_mask` is ignored.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> AllowMissing { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/schemas/[^/]+$",
                                });
                                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "allowMissing",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
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

                        /// <summary>Makes a recommendation, which requires a contextual user event.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="servingConfig">
                        /// Required. Full resource name of the format:
                        /// `projects/*/locations/global/collections/*/dataStores/*/servingConfigs/*` Before you can
                        /// request recommendations from your model, you must create at least one serving config for it.
                        /// </param>
                        public virtual RecommendRequest Recommend(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest body, string servingConfig)
                        {
                            return new RecommendRequest(service, body, servingConfig);
                        }

                        /// <summary>Makes a recommendation, which requires a contextual user event.</summary>
                        public class RecommendRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendResponse>
                        {
                            /// <summary>Constructs a new Recommend request.</summary>
                            public RecommendRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest body, string servingConfig) : base(service)
                            {
                                ServingConfig = servingConfig;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of the format:
                            /// `projects/*/locations/global/collections/*/dataStores/*/servingConfigs/*` Before you can
                            /// request recommendations from your model, you must create at least one serving config for
                            /// it.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ServingConfig { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "recommend";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+servingConfig}:recommend";

                            /// <summary>Initializes Recommend parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "servingConfig",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/servingConfigs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Performs a search.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="servingConfig">
                        /// Required. The resource name of the Search serving config, such as
                        /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store/servingConfigs/default_serving_config`.
                        /// This field is used to identify the serving configuration name, set of models used to make
                        /// the search.
                        /// </param>
                        public virtual SearchRequest Search(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest body, string servingConfig)
                        {
                            return new SearchRequest(service, body, servingConfig);
                        }

                        /// <summary>Performs a search.</summary>
                        public class SearchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchResponse>
                        {
                            /// <summary>Constructs a new Search request.</summary>
                            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest body, string servingConfig) : base(service)
                            {
                                ServingConfig = servingConfig;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Search serving config, such as
                            /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store/servingConfigs/default_serving_config`.
                            /// This field is used to identify the serving configuration name, set of models used to
                            /// make the search.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ServingConfig { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "search";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+servingConfig}:search";

                            /// <summary>Initializes Search parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "servingConfig",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/servingConfigs/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Gets the SiteSearchEngine resource.</summary>
                    public virtual SiteSearchEngineResource SiteSearchEngine { get; }

                    /// <summary>The "siteSearchEngine" collection of methods.</summary>
                    public class SiteSearchEngineResource
                    {
                        private const string Resource = "siteSearchEngine";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SiteSearchEngineResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Operations = new OperationsResource(service);
                            TargetSites = new TargetSitesResource(service);
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
                            public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                                public override string RestPath => "v1beta/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/siteSearchEngine/operations/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            /// <param name="name">The name of the operation's parent resource.</param>
                            public virtual ListRequest List(string name)
                            {
                                return new ListRequest(service, name);
                            }

                            /// <summary>
                            /// Lists operations that match the specified filter in the request. If the server doesn't
                            /// support this method, it returns `UNIMPLEMENTED`.
                            /// </summary>
                            public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                                public override string RestPath => "v1beta/{+name}/operations";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/siteSearchEngine$",
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

                        /// <summary>Gets the TargetSites resource.</summary>
                        public virtual TargetSitesResource TargetSites { get; }

                        /// <summary>The "targetSites" collection of methods.</summary>
                        public class TargetSitesResource
                        {
                            private const string Resource = "targetSites";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public TargetSitesResource(Google.Apis.Services.IClientService service)
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
                                /// Gets the latest state of a long-running operation. Clients can use this method to
                                /// poll the operation result at intervals as recommended by the API service.
                                /// </summary>
                                /// <param name="name">The name of the operation resource.</param>
                                public virtual GetRequest Get(string name)
                                {
                                    return new GetRequest(service, name);
                                }

                                /// <summary>
                                /// Gets the latest state of a long-running operation. Clients can use this method to
                                /// poll the operation result at intervals as recommended by the API service.
                                /// </summary>
                                public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                                    public override string RestPath => "v1beta/{+name}";

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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/siteSearchEngine/targetSites/operations/[^/]+$",
                                        });
                                    }
                                }

                                /// <summary>
                                /// Lists operations that match the specified filter in the request. If the server
                                /// doesn't support this method, it returns `UNIMPLEMENTED`.
                                /// </summary>
                                /// <param name="name">The name of the operation's parent resource.</param>
                                public virtual ListRequest List(string name)
                                {
                                    return new ListRequest(service, name);
                                }

                                /// <summary>
                                /// Lists operations that match the specified filter in the request. If the server
                                /// doesn't support this method, it returns `UNIMPLEMENTED`.
                                /// </summary>
                                public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                                    public override string RestPath => "v1beta/{+name}/operations";

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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+/siteSearchEngine/targetSites$",
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
                        /// restriction of POST-ing to a third-party domain. This method is used only by the Discovery
                        /// Engine API JavaScript pixel and Google Tag Manager. Users should not call this method
                        /// directly.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent DataStore resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                        /// </param>
                        public virtual CollectRequest Collect(string parent)
                        {
                            return new CollectRequest(service, parent);
                        }

                        /// <summary>
                        /// Writes a single user event from the browser. This uses a GET request to due to browser
                        /// restriction of POST-ing to a third-party domain. This method is used only by the Discovery
                        /// Engine API JavaScript pixel and Google Tag Manager. Users should not call this method
                        /// directly.
                        /// </summary>
                        public class CollectRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleApiHttpBody>
                        {
                            /// <summary>Constructs a new Collect request.</summary>
                            public CollectRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent DataStore resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The event timestamp in milliseconds. This prevents browser caching of otherwise
                            /// identical get requests. The name is abbreviated to reduce the payload bytes.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("ets", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<long> Ets { get; set; }

                            /// <summary>
                            /// The URL including cgi-parameters but excluding the hash fragment with a length limit of
                            /// 5,000 characters. This is often more useful than the referer URL, because many browsers
                            /// only send the domain for third-party requests.
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
                            public override string RestPath => "v1beta/{+parent}/userEvents:collect";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
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
                        /// Required. Parent DataStore resource name, of the form
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`
                        /// </param>
                        public virtual ImportRequest Import(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportUserEventsRequest body, string parent)
                        {
                            return new ImportRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Bulk import of User events. Request processing might be synchronous. Events that already
                        /// exist are skipped. Use this method for backfilling historical user events.
                        /// Operation.response is of type ImportResponse. Note that it is possible for a subset of the
                        /// items to be successfully inserted. Operation.metadata is of type ImportMetadata.
                        /// </summary>
                        public class ImportRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Import request.</summary>
                            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportUserEventsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Parent DataStore resource name, of the form
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportUserEventsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "import";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/userEvents:import";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Writes a single user event.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent DataStore resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                        /// </param>
                        public virtual WriteRequest Write(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent body, string parent)
                        {
                            return new WriteRequest(service, body, parent);
                        }

                        /// <summary>Writes a single user event.</summary>
                        public class WriteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent>
                        {
                            /// <summary>Constructs a new Write request.</summary>
                            public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent DataStore resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "write";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/userEvents:write";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Completes the specified user input with keyword suggestions.</summary>
                    /// <param name="dataStore">
                    /// Required. The parent data store resource name for which the completion is performed, such as
                    /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store`.
                    /// </param>
                    public virtual CompleteQueryRequest CompleteQuery(string dataStore)
                    {
                        return new CompleteQueryRequest(service, dataStore);
                    }

                    /// <summary>Completes the specified user input with keyword suggestions.</summary>
                    public class CompleteQueryRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaCompleteQueryResponse>
                    {
                        /// <summary>Constructs a new CompleteQuery request.</summary>
                        public CompleteQueryRequest(Google.Apis.Services.IClientService service, string dataStore) : base(service)
                        {
                            DataStore = dataStore;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent data store resource name for which the completion is performed, such as
                        /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataStore", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DataStore { get; private set; }

                        /// <summary>
                        /// Indicates if tail suggestions should be returned if there are no suggestions that match the
                        /// full query. Even if set to true, if there are suggestions that match the full query, those
                        /// are returned and no tail suggestions are returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("includeTailSuggestions", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IncludeTailSuggestions { get; set; }

                        /// <summary>
                        /// Required. The typeahead input used to fetch suggestions. Maximum length is 128 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Query { get; set; }

                        /// <summary>
                        /// Selects data model of query suggestions for serving. Currently supported values: *
                        /// `document` - Using suggestions generated from user-imported documents. * `search-history` -
                        /// Using suggestions generated from the past history of SearchService.Search API calls. Do not
                        /// use it when there is no traffic for Search API. * `user-event` - Using suggestions generated
                        /// from user-imported search events. * `document-completable` - Using suggestions taken
                        /// directly from user-imported document fields marked as completable. Default values: *
                        /// `document` is the default model for regular dataStores. * `search-history` is the default
                        /// model for site search dataStores.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("queryModel", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QueryModel { get; set; }

                        /// <summary>
                        /// A unique identifier for tracking visitors. For example, this could be implemented with an
                        /// HTTP cookie, which should be able to uniquely identify a visitor on a single device. This
                        /// unique identifier should not change if the visitor logs in or out of the website. This field
                        /// should NOT have a fixed value such as `unknown_visitor`. This should be the same identifier
                        /// as UserEvent.user_pseudo_id and SearchRequest.user_pseudo_id. The field must be a UTF-8
                        /// encoded string with a length limit of 128 characters. Otherwise, an `INVALID_ARGUMENT` error
                        /// is returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("userPseudoId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UserPseudoId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "completeQuery";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+dataStore}:completeQuery";

                        /// <summary>Initializes CompleteQuery parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataStore", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataStore",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/dataStores/[^/]+$",
                            });
                            RequestParameters.Add("includeTailSuggestions", new Google.Apis.Discovery.Parameter
                            {
                                Name = "includeTailSuggestions",
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
                            RequestParameters.Add("queryModel", new Google.Apis.Discovery.Parameter
                            {
                                Name = "queryModel",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("userPseudoId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userPseudoId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Engines resource.</summary>
                public virtual EnginesResource Engines { get; }

                /// <summary>The "engines" collection of methods.</summary>
                public class EnginesResource
                {
                    private const string Resource = "engines";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EnginesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Operations = new OperationsResource(service);
                        ServingConfigs = new ServingConfigsResource(service);
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
                        public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/engines/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        /// <param name="name">The name of the operation's parent resource.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                            public override string RestPath => "v1beta/{+name}/operations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/engines/[^/]+$",
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

                        /// <summary>Makes a recommendation, which requires a contextual user event.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="servingConfig">
                        /// Required. Full resource name of the format:
                        /// `projects/*/locations/global/collections/*/dataStores/*/servingConfigs/*` Before you can
                        /// request recommendations from your model, you must create at least one serving config for it.
                        /// </param>
                        public virtual RecommendRequest Recommend(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest body, string servingConfig)
                        {
                            return new RecommendRequest(service, body, servingConfig);
                        }

                        /// <summary>Makes a recommendation, which requires a contextual user event.</summary>
                        public class RecommendRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendResponse>
                        {
                            /// <summary>Constructs a new Recommend request.</summary>
                            public RecommendRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest body, string servingConfig) : base(service)
                            {
                                ServingConfig = servingConfig;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of the format:
                            /// `projects/*/locations/global/collections/*/dataStores/*/servingConfigs/*` Before you can
                            /// request recommendations from your model, you must create at least one serving config for
                            /// it.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ServingConfig { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "recommend";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+servingConfig}:recommend";

                            /// <summary>Initializes Recommend parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "servingConfig",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/engines/[^/]+/servingConfigs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Performs a search.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="servingConfig">
                        /// Required. The resource name of the Search serving config, such as
                        /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store/servingConfigs/default_serving_config`.
                        /// This field is used to identify the serving configuration name, set of models used to make
                        /// the search.
                        /// </param>
                        public virtual SearchRequest Search(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest body, string servingConfig)
                        {
                            return new SearchRequest(service, body, servingConfig);
                        }

                        /// <summary>Performs a search.</summary>
                        public class SearchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchResponse>
                        {
                            /// <summary>Constructs a new Search request.</summary>
                            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest body, string servingConfig) : base(service)
                            {
                                ServingConfig = servingConfig;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Search serving config, such as
                            /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store/servingConfigs/default_serving_config`.
                            /// This field is used to identify the serving configuration name, set of models used to
                            /// make the search.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ServingConfig { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "search";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+servingConfig}:search";

                            /// <summary>Initializes Search parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "servingConfig",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/engines/[^/]+/servingConfigs/[^/]+$",
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
                    public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v1beta/{+name}/operations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/collections/[^/]+$",
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

            /// <summary>Gets the DataStores resource.</summary>
            public virtual DataStoresResource DataStores { get; }

            /// <summary>The "dataStores" collection of methods.</summary>
            public class DataStoresResource
            {
                private const string Resource = "dataStores";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DataStoresResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Branches = new BranchesResource(service);
                    Conversations = new ConversationsResource(service);
                    Models = new ModelsResource(service);
                    Operations = new OperationsResource(service);
                    Schemas = new SchemasResource(service);
                    ServingConfigs = new ServingConfigsResource(service);
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
                        Documents = new DocumentsResource(service);
                        Operations = new OperationsResource(service);
                    }

                    /// <summary>Gets the Documents resource.</summary>
                    public virtual DocumentsResource Documents { get; }

                    /// <summary>The "documents" collection of methods.</summary>
                    public class DocumentsResource
                    {
                        private const string Resource = "documents";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public DocumentsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a Document.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a Document.</summary>
                        public class CreateRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the Document, which will become the final component of the
                            /// Document.name. If the caller does not have permission to create the Document, regardless
                            /// of whether or not it exists, a `PERMISSION_DENIED` error is returned. This field must be
                            /// unique among all Documents with the same parent. Otherwise, an `ALREADY_EXISTS` error is
                            /// returned. This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
                            /// standard with a length limit of 63 characters. Otherwise, an `INVALID_ARGUMENT` error is
                            /// returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("documentId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string DocumentId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/documents";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+$",
                                });
                                RequestParameters.Add("documentId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "documentId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Deletes a Document.</summary>
                        /// <param name="name">
                        /// Required. Full resource name of Document, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                        /// If the caller does not have permission to delete the Document, regardless of whether or not
                        /// it exists, a `PERMISSION_DENIED` error is returned. If the Document to delete does not
                        /// exist, a `NOT_FOUND` error is returned.
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes a Document.</summary>
                        public class DeleteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Document, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                            /// If the caller does not have permission to delete the Document, regardless of whether or
                            /// not it exists, a `PERMISSION_DENIED` error is returned. If the Document to delete does
                            /// not exist, a `NOT_FOUND` error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+/documents/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets a Document.</summary>
                        /// <param name="name">
                        /// Required. Full resource name of Document, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                        /// If the caller does not have permission to access the Document, regardless of whether or not
                        /// it exists, a `PERMISSION_DENIED` error is returned. If the requested Document does not
                        /// exist, a `NOT_FOUND` error is returned.
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets a Document.</summary>
                        public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Full resource name of Document, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                            /// If the caller does not have permission to access the Document, regardless of whether or
                            /// not it exists, a `PERMISSION_DENIED` error is returned. If the requested Document does
                            /// not exist, a `NOT_FOUND` error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+/documents/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Bulk import of multiple Documents. Request processing may be synchronous. Non-existing items
                        /// will be created. Note: It is possible for a subset of the Documents to be successfully
                        /// updated.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent branch resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                        /// Requires create/update permission.
                        /// </param>
                        public virtual ImportRequest Import(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportDocumentsRequest body, string parent)
                        {
                            return new ImportRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Bulk import of multiple Documents. Request processing may be synchronous. Non-existing items
                        /// will be created. Note: It is possible for a subset of the Documents to be successfully
                        /// updated.
                        /// </summary>
                        public class ImportRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Import request.</summary>
                            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportDocumentsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent branch resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// Requires create/update permission.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportDocumentsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "import";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/documents:import";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets a list of Documents.</summary>
                        /// <param name="parent">
                        /// Required. The parent branch resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                        /// Use `default_branch` as the branch ID, to list documents under the default branch. If the
                        /// caller does not have permission to list Documents under this branch, regardless of whether
                        /// or not this branch exists, a `PERMISSION_DENIED` error is returned.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Gets a list of Documents.</summary>
                        public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaListDocumentsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent branch resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// Use `default_branch` as the branch ID, to list documents under the default branch. If
                            /// the caller does not have permission to list Documents under this branch, regardless of
                            /// whether or not this branch exists, a `PERMISSION_DENIED` error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Maximum number of Documents to return. If unspecified, defaults to 100. The maximum
                            /// allowed value is 1000. Values above 1000 will be coerced to 1000. If this field is
                            /// negative, an `INVALID_ARGUMENT` error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token ListDocumentsResponse.next_page_token, received from a previous
                            /// DocumentService.ListDocuments call. Provide this to retrieve the subsequent page. When
                            /// paginating, all other parameters provided to DocumentService.ListDocuments must match
                            /// the call that provided the page token. Otherwise, an `INVALID_ARGUMENT` error is
                            /// returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/documents";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+$",
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

                        /// <summary>Updates a Document.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Immutable. The full resource name of the document. Format:
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
                        /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates a Document.</summary>
                        public class PatchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Immutable. The full resource name of the document. Format:
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
                            /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// If set to true, and the Document is not found, a new Document will be created.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> AllowMissing { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaDocument Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+/documents/[^/]+$",
                                });
                                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "allowMissing",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Permanently deletes all selected Documents in a branch. This process is asynchronous.
                        /// Depending on the number of Documents to be deleted, this operation can take hours to
                        /// complete. Before the delete operation completes, some Documents might still be returned by
                        /// DocumentService.GetDocument or DocumentService.ListDocuments. To get a list of the Documents
                        /// to be deleted, set PurgeDocumentsRequest.force to false.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                        /// </param>
                        public virtual PurgeRequest Purge(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaPurgeDocumentsRequest body, string parent)
                        {
                            return new PurgeRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Permanently deletes all selected Documents in a branch. This process is asynchronous.
                        /// Depending on the number of Documents to be deleted, this operation can take hours to
                        /// complete. Before the delete operation completes, some Documents might still be returned by
                        /// DocumentService.GetDocument or DocumentService.ListDocuments. To get a list of the Documents
                        /// to be deleted, set PurgeDocumentsRequest.force to false.
                        /// </summary>
                        public class PurgeRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Purge request.</summary>
                            public PurgeRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaPurgeDocumentsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource name, such as
                            /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaPurgeDocumentsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "purge";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/documents:purge";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+$",
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
                        public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        /// <param name="name">The name of the operation's parent resource.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                            public override string RestPath => "v1beta/{+name}/operations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/branches/[^/]+$",
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

                /// <summary>Gets the Conversations resource.</summary>
                public virtual ConversationsResource Conversations { get; }

                /// <summary>The "conversations" collection of methods.</summary>
                public class ConversationsResource
                {
                    private const string Resource = "conversations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConversationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Converses a conversation.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the Conversation to get. Format:
                    /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
                    /// Use
                    /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
                    /// to activate auto session mode, which automatically creates a new conversation inside a
                    /// ConverseConversation session.
                    /// </param>
                    public virtual ConverseRequest Converse(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationRequest body, string name)
                    {
                        return new ConverseRequest(service, body, name);
                    }

                    /// <summary>Converses a conversation.</summary>
                    public class ConverseRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationResponse>
                    {
                        /// <summary>Constructs a new Converse request.</summary>
                        public ConverseRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Conversation to get. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
                        /// Use
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
                        /// to activate auto session mode, which automatically creates a new conversation inside a
                        /// ConverseConversation session.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConverseConversationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "converse";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}:converse";

                        /// <summary>Initializes Converse parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Creates a Conversation. If the Conversation to create already exists, an ALREADY_EXISTS error is
                    /// returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Full resource name of parent data store. Format:
                    /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a Conversation. If the Conversation to create already exists, an ALREADY_EXISTS error is
                    /// returned.
                    /// </summary>
                    public class CreateRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of parent data store. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/conversations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a Conversation. If the Conversation to delete does not exist, a NOT_FOUND error is
                    /// returned.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the Conversation to delete. Format:
                    /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a Conversation. If the Conversation to delete does not exist, a NOT_FOUND error is
                    /// returned.
                    /// </summary>
                    public class DeleteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Conversation to delete. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a Conversation.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the Conversation to get. Format:
                    /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a Conversation.</summary>
                    public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Conversation to get. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all Conversations by their parent DataStore.</summary>
                    /// <param name="parent">
                    /// Required. The data store resource name. Format:
                    /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all Conversations by their parent DataStore.</summary>
                    public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaListConversationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The data store resource name. Format:
                        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter to apply on the list results. The supported features are: user_pseudo_id, state.
                        /// Example: "user_pseudo_id = some_id"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// A comma-separated list of fields to order by, sorted in ascending order. Use "desc" after a
                        /// field name for descending. Supported fields: * `update_time` * `create_time` *
                        /// `conversation_name` Example: "update_time desc" "create_time"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Maximum number of results to return. If unspecified, defaults to 50. Max allowed value is
                        /// 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListConversations` call. Provide this to retrieve
                        /// the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/conversations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                            {
                                Name = "orderBy",
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
                    /// Updates a Conversation. Conversation action type cannot be changed. If the Conversation to
                    /// update does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Fully qualified name
                    /// `project/*/locations/global/collections/{collection}/dataStore/*/conversations/*`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a Conversation. Conversation action type cannot be changed. If the Conversation to
                    /// update does not exist, a NOT_FOUND error is returned.
                    /// </summary>
                    public class PatchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Fully qualified name
                        /// `project/*/locations/global/collections/{collection}/dataStore/*/conversations/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Indicates which fields in the provided Conversation to update. The following are NOT
                        /// supported: * conversation.name If not set or empty, all supported fields are updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaConversation Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/conversations/[^/]+$",
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
                        public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/models/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        /// <param name="name">The name of the operation's parent resource.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                            public override string RestPath => "v1beta/{+name}/operations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/models/[^/]+$",
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
                    public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v1beta/{+name}/operations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
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

                /// <summary>Gets the Schemas resource.</summary>
                public virtual SchemasResource Schemas { get; }

                /// <summary>The "schemas" collection of methods.</summary>
                public class SchemasResource
                {
                    private const string Resource = "schemas";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SchemasResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a Schema.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent data store resource name, in the format of
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a Schema.</summary>
                    public class CreateRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent data store resource name, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the Schema, which will become the final component of the
                        /// Schema.name. This field should conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
                        /// standard with a length limit of 63 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("schemaId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string SchemaId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/schemas";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
                            });
                            RequestParameters.Add("schemaId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "schemaId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a Schema.</summary>
                    /// <param name="name">
                    /// Required. The full resource name of the schema, in the format of
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a Schema.</summary>
                    public class DeleteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the schema, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/schemas/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a Schema.</summary>
                    /// <param name="name">
                    /// Required. The full resource name of the schema, in the format of
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a Schema.</summary>
                    public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full resource name of the schema, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/schemas/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a list of Schemas.</summary>
                    /// <param name="parent">
                    /// Required. The parent data store resource name, in the format of
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Gets a list of Schemas.</summary>
                    public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaListSchemasResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent data store resource name, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of Schemas to return. The service may return fewer than this value. If
                        /// unspecified, at most 100 Schemas will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous SchemaService.ListSchemas call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// SchemaService.ListSchemas must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/schemas";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
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

                    /// <summary>Updates a Schema.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. The full resource name of the schema, in the format of
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                    /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates a Schema.</summary>
                    public class PatchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. The full resource name of the schema, in the format of
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
                        /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the Schema is not found, a new Schema will be created. In this
                        /// situation, `update_mask` is ignored.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSchema Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/schemas/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
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

                    /// <summary>Makes a recommendation, which requires a contextual user event.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="servingConfig">
                    /// Required. Full resource name of the format:
                    /// `projects/*/locations/global/collections/*/dataStores/*/servingConfigs/*` Before you can request
                    /// recommendations from your model, you must create at least one serving config for it.
                    /// </param>
                    public virtual RecommendRequest Recommend(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest body, string servingConfig)
                    {
                        return new RecommendRequest(service, body, servingConfig);
                    }

                    /// <summary>Makes a recommendation, which requires a contextual user event.</summary>
                    public class RecommendRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendResponse>
                    {
                        /// <summary>Constructs a new Recommend request.</summary>
                        public RecommendRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest body, string servingConfig) : base(service)
                        {
                            ServingConfig = servingConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Full resource name of the format:
                        /// `projects/*/locations/global/collections/*/dataStores/*/servingConfigs/*` Before you can
                        /// request recommendations from your model, you must create at least one serving config for it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServingConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaRecommendRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "recommend";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+servingConfig}:recommend";

                        /// <summary>Initializes Recommend parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servingConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/servingConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Performs a search.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="servingConfig">
                    /// Required. The resource name of the Search serving config, such as
                    /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store/servingConfigs/default_serving_config`.
                    /// This field is used to identify the serving configuration name, set of models used to make the
                    /// search.
                    /// </param>
                    public virtual SearchRequest Search(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest body, string servingConfig)
                    {
                        return new SearchRequest(service, body, servingConfig);
                    }

                    /// <summary>Performs a search.</summary>
                    public class SearchRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchResponse>
                    {
                        /// <summary>Constructs a new Search request.</summary>
                        public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest body, string servingConfig) : base(service)
                        {
                            ServingConfig = servingConfig;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Search serving config, such as
                        /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store/servingConfigs/default_serving_config`.
                        /// This field is used to identify the serving configuration name, set of models used to make
                        /// the search.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("servingConfig", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServingConfig { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaSearchRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "search";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+servingConfig}:search";

                        /// <summary>Initializes Search parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("servingConfig", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servingConfig",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+/servingConfigs/[^/]+$",
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
                    /// restriction of POST-ing to a third-party domain. This method is used only by the Discovery
                    /// Engine API JavaScript pixel and Google Tag Manager. Users should not call this method directly.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent DataStore resource name, such as
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                    /// </param>
                    public virtual CollectRequest Collect(string parent)
                    {
                        return new CollectRequest(service, parent);
                    }

                    /// <summary>
                    /// Writes a single user event from the browser. This uses a GET request to due to browser
                    /// restriction of POST-ing to a third-party domain. This method is used only by the Discovery
                    /// Engine API JavaScript pixel and Google Tag Manager. Users should not call this method directly.
                    /// </summary>
                    public class CollectRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleApiHttpBody>
                    {
                        /// <summary>Constructs a new Collect request.</summary>
                        public CollectRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent DataStore resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
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
                        /// send the domain for third-party requests.
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
                        public override string RestPath => "v1beta/{+parent}/userEvents:collect";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
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
                    /// <param name="parent">
                    /// Required. Parent DataStore resource name, of the form
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportUserEventsRequest body, string parent)
                    {
                        return new ImportRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Bulk import of User events. Request processing might be synchronous. Events that already exist
                    /// are skipped. Use this method for backfilling historical user events. Operation.response is of
                    /// type ImportResponse. Note that it is possible for a subset of the items to be successfully
                    /// inserted. Operation.metadata is of type ImportMetadata.
                    /// </summary>
                    public class ImportRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportUserEventsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent DataStore resource name, of the form
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaImportUserEventsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/userEvents:import";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Writes a single user event.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent DataStore resource name, such as
                    /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                    /// </param>
                    public virtual WriteRequest Write(Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent body, string parent)
                    {
                        return new WriteRequest(service, body, parent);
                    }

                    /// <summary>Writes a single user event.</summary>
                    public class WriteRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent>
                    {
                        /// <summary>Constructs a new Write request.</summary>
                        public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent DataStore resource name, such as
                        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaUserEvent Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "write";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/userEvents:write";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Completes the specified user input with keyword suggestions.</summary>
                /// <param name="dataStore">
                /// Required. The parent data store resource name for which the completion is performed, such as
                /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store`.
                /// </param>
                public virtual CompleteQueryRequest CompleteQuery(string dataStore)
                {
                    return new CompleteQueryRequest(service, dataStore);
                }

                /// <summary>Completes the specified user input with keyword suggestions.</summary>
                public class CompleteQueryRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleCloudDiscoveryengineV1betaCompleteQueryResponse>
                {
                    /// <summary>Constructs a new CompleteQuery request.</summary>
                    public CompleteQueryRequest(Google.Apis.Services.IClientService service, string dataStore) : base(service)
                    {
                        DataStore = dataStore;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent data store resource name for which the completion is performed, such as
                    /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataStore", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DataStore { get; private set; }

                    /// <summary>
                    /// Indicates if tail suggestions should be returned if there are no suggestions that match the full
                    /// query. Even if set to true, if there are suggestions that match the full query, those are
                    /// returned and no tail suggestions are returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeTailSuggestions", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeTailSuggestions { get; set; }

                    /// <summary>
                    /// Required. The typeahead input used to fetch suggestions. Maximum length is 128 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Query { get; set; }

                    /// <summary>
                    /// Selects data model of query suggestions for serving. Currently supported values: * `document` -
                    /// Using suggestions generated from user-imported documents. * `search-history` - Using suggestions
                    /// generated from the past history of SearchService.Search API calls. Do not use it when there is
                    /// no traffic for Search API. * `user-event` - Using suggestions generated from user-imported
                    /// search events. * `document-completable` - Using suggestions taken directly from user-imported
                    /// document fields marked as completable. Default values: * `document` is the default model for
                    /// regular dataStores. * `search-history` is the default model for site search dataStores.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("queryModel", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string QueryModel { get; set; }

                    /// <summary>
                    /// A unique identifier for tracking visitors. For example, this could be implemented with an HTTP
                    /// cookie, which should be able to uniquely identify a visitor on a single device. This unique
                    /// identifier should not change if the visitor logs in or out of the website. This field should NOT
                    /// have a fixed value such as `unknown_visitor`. This should be the same identifier as
                    /// UserEvent.user_pseudo_id and SearchRequest.user_pseudo_id. The field must be a UTF-8 encoded
                    /// string with a length limit of 128 characters. Otherwise, an `INVALID_ARGUMENT` error is
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userPseudoId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UserPseudoId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "completeQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+dataStore}:completeQuery";

                    /// <summary>Initializes CompleteQuery parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("dataStore", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataStore",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dataStores/[^/]+$",
                        });
                        RequestParameters.Add("includeTailSuggestions", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeTailSuggestions",
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
                        RequestParameters.Add("queryModel", new Google.Apis.Discovery.Parameter
                        {
                            Name = "queryModel",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("userPseudoId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userPseudoId",
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
                public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                    public override string RestPath => "v1beta/{+name}";

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
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                    public override string RestPath => "v1beta/{+name}/operations";

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
            public class GetRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningOperation>
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
                public override string RestPath => "v1beta/{+name}";

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
            /// method, it returns `UNIMPLEMENTED`.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`.
            /// </summary>
            public class ListRequest : DiscoveryEngineBaseServiceRequest<Google.Apis.DiscoveryEngine.v1beta.Data.GoogleLongrunningListOperationsResponse>
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
                public override string RestPath => "v1beta/{+name}/operations";

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
namespace Google.Apis.DiscoveryEngine.v1beta.Data
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
    public class GoogleCloudDiscoveryengineLoggingErrorContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP request which was processed when the error was triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual GoogleCloudDiscoveryengineLoggingHttpRequestContext HttpRequest { get; set; }

        /// <summary>
        /// The location in the source code where the decision was made to report the error, usually the place where it
        /// was logged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportLocation")]
        public virtual GoogleCloudDiscoveryengineLoggingSourceLocation ReportLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error log which is reported to the Error Reporting system.</summary>
    public class GoogleCloudDiscoveryengineLoggingErrorLog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A description of the context in which the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudDiscoveryengineLoggingErrorContext Context { get; set; }

        /// <summary>The error payload that is populated on LRO import APIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importPayload")]
        public virtual GoogleCloudDiscoveryengineLoggingImportErrorContext ImportPayload { get; set; }

        /// <summary>A message describing the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// The API request payload, represented as a protocol buffer. Most API request types are supported—for example:
        /// * `type.googleapis.com/google.cloud.discoveryengine.v1alpha.DocumentService.CreateDocumentRequest` *
        /// `type.googleapis.com/google.cloud.discoveryengine.v1alpha.UserEventService.WriteUserEventRequest`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> RequestPayload { get; set; }

        /// <summary>
        /// The API response payload, represented as a protocol buffer. This is used to log some "soft errors", where
        /// the response is valid but we consider there are some quality issues like unjoined events. The following API
        /// responses are supported, and no PII is included: *
        /// `google.cloud.discoveryengine.v1alpha.RecommendationService.Recommend` *
        /// `google.cloud.discoveryengine.v1alpha.UserEventService.WriteUserEvent` *
        /// `google.cloud.discoveryengine.v1alpha.UserEventService.CollectUserEvent`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responsePayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> ResponsePayload { get; set; }

        /// <summary>The service context in which this error has occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceContext")]
        public virtual GoogleCloudDiscoveryengineLoggingServiceContext ServiceContext { get; set; }

        /// <summary>The RPC status associated with the error log.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTP request data that is related to a reported error.</summary>
    public class GoogleCloudDiscoveryengineLoggingHttpRequestContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP response status code for the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseStatusCode")]
        public virtual System.Nullable<int> ResponseStatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The error payload that is populated on LRO import APIs, including the following: *
    /// `google.cloud.discoveryengine.v1alpha.DocumentService.ImportDocuments` *
    /// `google.cloud.discoveryengine.v1alpha.UserEventService.ImportUserEvents`
    /// </summary>
    public class GoogleCloudDiscoveryengineLoggingImportErrorContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed content which caused the error on importing a document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual string Document { get; set; }

        /// <summary>
        /// Google Cloud Storage file path of the import source. Can be set for batch operation error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPath")]
        public virtual string GcsPath { get; set; }

        /// <summary>
        /// Line number of the content in file. Should be empty for permission or batch operation error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual string LineNumber { get; set; }

        /// <summary>The operation resource name of the LRO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>The detailed content which caused the error on importing a user event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvent")]
        public virtual string UserEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a running service that sends errors.</summary>
    public class GoogleCloudDiscoveryengineLoggingServiceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An identifier of the service—for example, `discoveryengine.googleapis.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates a location in the source code of the service for which errors are reported.</summary>
    public class GoogleCloudDiscoveryengineLoggingSourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Human-readable name of a function or method—for example,
        /// `google.cloud.discoveryengine.v1alpha.RecommendationService.Recommend`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for Create Schema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1CreateSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for DeleteSchema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1DeleteSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the ImportDocuments operation. This is returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportDocumentsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1ImportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1ImportErrorConfig ErrorConfig { get; set; }

        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudDiscoveryengineV1ImportErrorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory. Import
        /// errors are written to sharded files in this directory, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
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
    public class GoogleCloudDiscoveryengineV1ImportUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1ImportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1ImportErrorConfig ErrorConfig { get; set; }

        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Count of user events imported with complete existing Documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinedEventsCount")]
        public virtual System.Nullable<long> JoinedEventsCount { get; set; }

        /// <summary>
        /// Count of user events imported, but with Document information not found in the existing Branch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unjoinedEventsCount")]
        public virtual System.Nullable<long> UnjoinedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the PurgeDocuments operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1PurgeDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were deleted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for DocumentService.PurgeDocuments method. If the long running operation is successfully done,
    /// then this message is returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1PurgeDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of documents purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeCount")]
        public virtual System.Nullable<long> PurgeCount { get; set; }

        /// <summary>
        /// A sample of document names that will be deleted. Only populated if `force` is set to false. A max of 100
        /// names will be returned and the names are chosen at random.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeSample")]
        public virtual System.Collections.Generic.IList<string> PurgeSample { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the structure and layout of a type of document data.</summary>
    public class GoogleCloudDiscoveryengineV1Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The JSON representation of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual string JsonSchema { get; set; }

        /// <summary>
        /// Immutable. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The structured representation of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structSchema")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for UpdateSchema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1UpdateSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for Create Schema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1alphaCreateSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for DeleteSchema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1alphaDeleteSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configurations for fields of a schema. For example, configuring a field is indexable, or searchable.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaFieldConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If completable_option is COMPLETABLE_ENABLED, field values are directly used and returned as suggestions for
        /// Autocomplete in CompletionService.CompleteQuery. If completable_option is unset, the server behavior
        /// defaults to COMPLETABLE_DISABLED for fields that support setting completable options, which are just
        /// `string` fields. For those fields that do not support setting completable options, the server will skip
        /// completable option setting, and setting completable_option for those fields will throw `INVALID_ARGUMENT`
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completableOption")]
        public virtual string CompletableOption { get; set; }

        /// <summary>
        /// If dynamic_facetable_option is DYNAMIC_FACETABLE_ENABLED, field values are available for dynamic facet.
        /// Could only be DYNAMIC_FACETABLE_DISABLED if FieldConfig.indexable_option is INDEXABLE_DISABLED. Otherwise,
        /// an `INVALID_ARGUMENT` error will be returned. If dynamic_facetable_option is unset, the server behavior
        /// defaults to DYNAMIC_FACETABLE_DISABLED for fields that support setting dynamic facetable options. For those
        /// fields that do not support setting dynamic facetable options, such as `object` and `boolean`, the server
        /// will skip dynamic facetable option setting, and setting dynamic_facetable_option for those fields will throw
        /// `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicFacetableOption")]
        public virtual string DynamicFacetableOption { get; set; }

        /// <summary>
        /// Required. Field path of the schema field. For example: `title`, `description`, `release_info.release_year`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>Output only. Raw type of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldType")]
        public virtual string FieldType { get; set; }

        /// <summary>
        /// If indexable_option is INDEXABLE_ENABLED, field values are indexed so that it can be filtered or faceted in
        /// SearchService.Search. If indexable_option is unset, the server behavior defaults to INDEXABLE_DISABLED for
        /// fields that support setting indexable options. For those fields that do not support setting indexable
        /// options, such as `object` and `boolean` and key properties, the server will skip indexable_option setting,
        /// and setting indexable_option for those fields will throw `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexableOption")]
        public virtual string IndexableOption { get; set; }

        /// <summary>
        /// Output only. Type of the key property that this field is mapped to. Empty string if this is not annotated as
        /// mapped to a key property. Example types are `title`, `description`. Full list is defined by
        /// `keyPropertyMapping` in the schema field annotation. If the schema field has a `KeyPropertyMapping`
        /// annotation, `indexable_option` and `searchable_option` of this field cannot be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyPropertyType")]
        public virtual string KeyPropertyType { get; set; }

        /// <summary>
        /// If recs_filterable_option is FILTERABLE_ENABLED, field values are filterable by filter expression in
        /// RecommendationService.Recommend. If FILTERABLE_ENABLED but the field type is numerical, field values are not
        /// filterable by text queries in RecommendationService.Recommend. Only textual fields are supported. If
        /// recs_filterable_option is unset, the default setting is FILTERABLE_DISABLED for fields that support setting
        /// filterable options. When a field set to [FILTERABLE_DISABLED] is filtered, a warning is generated and an
        /// empty result is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recsFilterableOption")]
        public virtual string RecsFilterableOption { get; set; }

        /// <summary>
        /// If retrievable_option is RETRIEVABLE_ENABLED, field values are included in the search results. If
        /// retrievable_option is unset, the server behavior defaults to RETRIEVABLE_DISABLED for fields that support
        /// setting retrievable options. For those fields that do not support setting retrievable options, such as
        /// `object` and `boolean`, the server will skip retrievable option setting, and setting retrievable_option for
        /// those fields will throw `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievableOption")]
        public virtual string RetrievableOption { get; set; }

        /// <summary>
        /// If searchable_option is SEARCHABLE_ENABLED, field values are searchable by text queries in
        /// SearchService.Search. If SEARCHABLE_ENABLED but field type is numerical, field values will not be searchable
        /// by text queries in SearchService.Search, as there are no text values associated to numerical fields. If
        /// searchable_option is unset, the server behavior defaults to SEARCHABLE_DISABLED for fields that support
        /// setting searchable options. Only `string` fields that have no key property mapping support setting
        /// searchable_option. For those fields that do not support setting searchable options, the server will skip
        /// searchable option setting, and setting searchable_option for those fields will throw `INVALID_ARGUMENT`
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchableOption")]
        public virtual string SearchableOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the ImportDocuments operation. This is returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportDocumentsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaImportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1alphaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudDiscoveryengineV1alphaImportErrorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory. Import
        /// errors are written to sharded files in this directory, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
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
    public class GoogleCloudDiscoveryengineV1alphaImportUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaImportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1alphaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Count of user events imported with complete existing Documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinedEventsCount")]
        public virtual System.Nullable<long> JoinedEventsCount { get; set; }

        /// <summary>
        /// Count of user events imported, but with Document information not found in the existing Branch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unjoinedEventsCount")]
        public virtual System.Nullable<long> UnjoinedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the PurgeDocuments operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaPurgeDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were deleted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for DocumentService.PurgeDocuments method. If the long running operation is successfully done,
    /// then this message is returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaPurgeDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of documents purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeCount")]
        public virtual System.Nullable<long> PurgeCount { get; set; }

        /// <summary>
        /// A sample of document names that will be deleted. Only populated if `force` is set to false. A max of 100
        /// names will be returned and the names are chosen at random.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeSample")]
        public virtual System.Collections.Generic.IList<string> PurgeSample { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the PurgeUserEvents operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaPurgeUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were deleted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the PurgeUserEventsRequest. If the long running operation is successfully done, then this message is
    /// returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaPurgeUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of events purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeCount")]
        public virtual System.Nullable<long> PurgeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the SiteSearchEngineService.RecrawlUris operation. This will be returned by
    /// the google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaRecrawlUrisMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Unique URIs in the request that don't match any TargetSite in the DataStore, only match TargetSites that
        /// haven't been fully indexed, or match a TargetSite with type EXCLUDE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidUris")]
        public virtual System.Collections.Generic.IList<string> InvalidUris { get; set; }

        /// <summary>Total number of URIs that have yet to be crawled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingCount")]
        public virtual System.Nullable<int> PendingCount { get; set; }

        /// <summary>Total number of URIs that were rejected due to insufficient indexing resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaExceededCount")]
        public virtual System.Nullable<int> QuotaExceededCount { get; set; }

        /// <summary>Total number of URIs that have been crawled so far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<int> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Total number of unique URIs in the request that are not in invalid_uris.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validUrisCount")]
        public virtual System.Nullable<int> ValidUrisCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SiteSearchEngineService.RecrawlUris method.</summary>
    public class GoogleCloudDiscoveryengineV1alphaRecrawlUrisResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URIs that were not crawled before the LRO terminated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedUris")]
        public virtual System.Collections.Generic.IList<string> FailedUris { get; set; }

        /// <summary>Details for a sample of up to 10 `failed_uris`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureSamples")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1alphaRecrawlUrisResponseFailureInfo> FailureSamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about why a particular URI failed to be crawled. Each FailureInfo contains one FailureReason per
    /// CorpusType.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaRecrawlUrisResponseFailureInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of failure reasons by corpus type (e.g. desktop, mobile).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReasons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1alphaRecrawlUrisResponseFailureInfoFailureReason> FailureReasons { get; set; }

        /// <summary>URI that failed to be crawled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about why crawling failed for a particular CorpusType, e.g. DESKTOP and MOBILE crawling may fail for
    /// different reasons.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaRecrawlUrisResponseFailureInfoFailureReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DESKTOP, MOBILE, or CORPUS_TYPE_UNSPECIFIED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corpusType")]
        public virtual string CorpusType { get; set; }

        /// <summary>Reason why the URI was not crawled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the structure and layout of a type of document data.</summary>
    public class GoogleCloudDiscoveryengineV1alphaSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Configurations for fields of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1alphaFieldConfig> FieldConfigs { get; set; }

        /// <summary>The JSON representation of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual string JsonSchema { get; set; }

        /// <summary>
        /// Immutable. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The structured representation of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structSchema")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Verification information for target sites in advanced site search.</summary>
    public class GoogleCloudDiscoveryengineV1alphaSiteVerificationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Site verification state indicating the ownership and validity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteVerificationState")]
        public virtual string SiteVerificationState { get; set; }

        private string _verifyTimeRaw;

        private object _verifyTime;

        /// <summary>Latest site verification time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyTime")]
        public virtual string VerifyTimeRaw
        {
            get => _verifyTimeRaw;
            set
            {
                _verifyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _verifyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="VerifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use VerifyTimeDateTimeOffset instead.")]
        public virtual object VerifyTime
        {
            get => _verifyTime;
            set
            {
                _verifyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _verifyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="VerifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? VerifyTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(VerifyTimeRaw);
            set => VerifyTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A target site for the SiteSearchEngine.</summary>
    public class GoogleCloudDiscoveryengineV1alphaTargetSite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. If set to false, a uri_pattern is generated to include all pages whose address contains the
        /// provided_uri_pattern. If set to true, an uri_pattern is generated to try to be an exact match of the
        /// provided_uri_pattern or just the specific page if the provided_uri_pattern is a specific one.
        /// provided_uri_pattern is always normalized to generate the URI pattern to be used by the search engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactMatch")]
        public virtual System.Nullable<bool> ExactMatch { get; set; }

        /// <summary>Output only. Failure reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual GoogleCloudDiscoveryengineV1alphaTargetSiteFailureReason FailureReason { get; set; }

        /// <summary>Output only. This is system-generated based on the provided_uri_pattern.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedUriPattern")]
        public virtual string GeneratedUriPattern { get; set; }

        /// <summary>Output only. Indexing status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexingStatus")]
        public virtual string IndexingStatus { get; set; }

        /// <summary>
        /// Output only. The fully qualified resource name of the target site.
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`
        /// The `target_site_id` is system-generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Input only. The user provided URI pattern from which the `generated_uri_pattern` is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providedUriPattern")]
        public virtual string ProvidedUriPattern { get; set; }

        /// <summary>Output only. Site ownership and validity verification status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteVerificationInfo")]
        public virtual GoogleCloudDiscoveryengineV1alphaSiteVerificationInfo SiteVerificationInfo { get; set; }

        /// <summary>The type of the target site, e.g. whether the site is to be included or excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The target site's last updated time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Site search indexing failure reasons.</summary>
    public class GoogleCloudDiscoveryengineV1alphaTargetSiteFailureReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Failed due to insufficient quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaFailure")]
        public virtual GoogleCloudDiscoveryengineV1alphaTargetSiteFailureReasonQuotaFailure QuotaFailure { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudDiscoveryengineV1alphaTargetSiteFailureReasonQuotaFailure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for UpdateSchema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1alphaUpdateSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BigQuery source import data from.</summary>
    public class GoogleCloudDiscoveryengineV1betaBigQuerySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for user event imports: *
        /// `user_event` (default): One UserEvent per row. Supported values for document imports: * `document`
        /// (default): One Document format per row. Each document must have a valid Document.id and one of
        /// Document.json_data or Document.struct_data. * `custom`: One custom data per row in arbitrary format that
        /// conforms to the defined Schema of the data store. This can only be used by Gen App Builder.
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

        /// <summary>BigQuery time partitioned table's _PARTITIONDATE in YYYY-MM-DD format.</summary>
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

    /// <summary>Response message for CompletionService.CompleteQuery method.</summary>
    public class GoogleCloudDiscoveryengineV1betaCompleteQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Results of the matched query suggestions. The result list is ordered and the first result is a top
        /// suggestion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("querySuggestions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaCompleteQueryResponseQuerySuggestion> QuerySuggestions { get; set; }

        /// <summary>
        /// True if the returned suggestions are all tail suggestions. For tail matching to be triggered,
        /// include_tail_suggestions in the request must be true and there must be no suggestions that match the full
        /// query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tailMatchTriggered")]
        public virtual System.Nullable<bool> TailMatchTriggered { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Suggestions as search queries.</summary>
    public class GoogleCloudDiscoveryengineV1betaCompleteQueryResponseQuerySuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique document field paths that serve as the source of this suggestion if it was generated from
        /// completable fields. This field is only populated for the document-completable model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completableFieldPaths")]
        public virtual System.Collections.Generic.IList<string> CompletableFieldPaths { get; set; }

        /// <summary>The suggestion for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestion")]
        public virtual string Suggestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Detailed completion information including completion attribution token and clicked completion info.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaCompletionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// End user selected CompleteQueryResponse.QuerySuggestion.suggestion position, starting from 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedPosition")]
        public virtual System.Nullable<int> SelectedPosition { get; set; }

        /// <summary>End user selected CompleteQueryResponse.QuerySuggestion.suggestion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedSuggestion")]
        public virtual string SelectedSuggestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>External conversation proto definition.</summary>
    public class GoogleCloudDiscoveryengineV1betaConversation : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the conversation finished.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Conversation messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaConversationMessage> Messages { get; set; }

        /// <summary>
        /// Immutable. Fully qualified name
        /// `project/*/locations/global/collections/{collection}/dataStore/*/conversations/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The time the conversation started.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The state of the Conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A unique identifier for tracking users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPseudoId")]
        public virtual string UserPseudoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines context of the conversation</summary>
    public class GoogleCloudDiscoveryengineV1betaConversationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current active document the user opened. It contains the document resource reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDocument")]
        public virtual string ActiveDocument { get; set; }

        /// <summary>
        /// The current list of documents the user is seeing. It contains the document resource references.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextDocuments")]
        public virtual System.Collections.Generic.IList<string> ContextDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a conversation message.</summary>
    public class GoogleCloudDiscoveryengineV1betaConversationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Message creation timestamp.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Search reply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reply")]
        public virtual GoogleCloudDiscoveryengineV1betaReply Reply { get; set; }

        /// <summary>User text input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInput")]
        public virtual GoogleCloudDiscoveryengineV1betaTextInput UserInput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ConversationalSearchService.ConverseConversation method.</summary>
    public class GoogleCloudDiscoveryengineV1betaConverseConversationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The conversation to be used by auto session only. The name field will be ignored as we automatically assign
        /// new name for the conversation in auto session.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversation")]
        public virtual GoogleCloudDiscoveryengineV1betaConversation Conversation { get; set; }

        /// <summary>Required. Current user input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual GoogleCloudDiscoveryengineV1betaTextInput Query { get; set; }

        /// <summary>Whether to turn on safe search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeSearch")]
        public virtual System.Nullable<bool> SafeSearch { get; set; }

        /// <summary>
        /// The resource name of the Serving Config to use. Format:
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/servingConfigs/{serving_config_id}`
        /// If this is not set, the default serving config will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingConfig")]
        public virtual string ServingConfig { get; set; }

        /// <summary>A specification for configuring the summary returned in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summarySpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpecSummarySpec SummarySpec { get; set; }

        /// <summary>
        /// The user labels applied to a resource must meet the following requirements: * Each resource can have
        /// multiple labels, up to a maximum of 64. * Each label must be a key-value pair. * Keys have a minimum length
        /// of 1 character and a maximum length of 63 characters and cannot be empty. Values can be empty and have a
        /// maximum length of 63 characters. * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. All characters must use UTF-8 encoding, and international characters are allowed. *
        /// The key portion of a label must be unique. However, you can use the same key with multiple resources. * Keys
        /// must start with a lowercase letter or international character. See [Google Cloud
        /// Document](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements) for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConversationalSearchService.ConverseConversation method.</summary>
    public class GoogleCloudDiscoveryengineV1betaConverseConversationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Updated conversation including the answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversation")]
        public virtual GoogleCloudDiscoveryengineV1betaConversation Conversation { get; set; }

        /// <summary>Suggested related questions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedQuestions")]
        public virtual System.Collections.Generic.IList<string> RelatedQuestions { get; set; }

        /// <summary>Answer to the current query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reply")]
        public virtual GoogleCloudDiscoveryengineV1betaReply Reply { get; set; }

        /// <summary>Search Results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchResponseSearchResult> SearchResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for Create Schema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1betaCreateSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom attribute that is not explicitly modeled in a resource, e.g. UserEvent.</summary>
    public class GoogleCloudDiscoveryengineV1betaCustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The numerical values of this custom attribute. For example, `[2.3, 15.4]` when the key is "lengths_cm".
        /// Exactly one of CustomAttribute.text or CustomAttribute.numbers should be set. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numbers")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Numbers { get; set; }

        /// <summary>
        /// The textual values of this custom attribute. For example, `["yellow", "green"]` when the key is "color".
        /// Empty string is not allowed. Otherwise, an `INVALID_ARGUMENT` error is returned. Exactly one of
        /// CustomAttribute.text or CustomAttribute.numbers should be set. Otherwise, an `INVALID_ARGUMENT` error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual System.Collections.Generic.IList<string> Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for DeleteSchema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1betaDeleteSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Document captures all raw metadata information of items to be recommended or searched.</summary>
    public class GoogleCloudDiscoveryengineV1betaDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unstructured data linked to this document. Content must be set if this document is under a
        /// `CONTENT_REQUIRED` data store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual GoogleCloudDiscoveryengineV1betaDocumentContent Content { get; set; }

        /// <summary>
        /// Output only. This field is OUTPUT_ONLY. It contains derived data that are not in the original input
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivedStructData")]
        public virtual System.Collections.Generic.IDictionary<string, object> DerivedStructData { get; set; }

        /// <summary>
        /// Immutable. The identifier of the document. Id should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length limit of 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The JSON string representation of the document. It should conform to the registered Schema or an
        /// `INVALID_ARGUMENT` error is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonData")]
        public virtual string JsonData { get; set; }

        /// <summary>
        /// Immutable. The full resource name of the document. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
        /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The identifier of the parent document. Currently supports at most two level document hierarchy. Id should
        /// conform to [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length limit of 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDocumentId")]
        public virtual string ParentDocumentId { get; set; }

        /// <summary>The identifier of the schema located in the same data store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaId")]
        public virtual string SchemaId { get; set; }

        /// <summary>
        /// The structured JSON data for the document. It should conform to the registered Schema or an
        /// `INVALID_ARGUMENT` error is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structData")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Unstructured data linked to this document.</summary>
    public class GoogleCloudDiscoveryengineV1betaDocumentContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The MIME type of the content. Supported types: * `application/pdf` (PDF, only native PDFs are supported for
        /// now) * `text/html` (HTML) * `application/vnd.openxmlformats-officedocument.wordprocessingml.document` (DOCX)
        /// * `application/vnd.openxmlformats-officedocument.presentationml.presentation` (PPTX) * `text/plain` (TXT)
        /// See https://www.iana.org/assignments/media-types/media-types.xhtml.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// The content represented as a stream of bytes. The maximum length is 1,000,000 bytes (1 MB / ~0.95 MiB).
        /// Note: As with all `bytes` fields, this field is represented as pure binary in Protocol Buffers and
        /// base64-encoded string in JSON. For example, `abc123!?$*&amp;amp;()'-=@~` should be represented as
        /// `YWJjMTIzIT8kKiYoKSctPUB+` in JSON. See https://developers.google.com/protocol-buffers/docs/proto3#json.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawBytes")]
        public virtual string RawBytes { get; set; }

        /// <summary>
        /// The URI of the content. Only Cloud Storage URIs (e.g. `gs://bucket-name/path/to/file`) are supported. The
        /// maximum file size is 100 MB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed document information associated with a user event.</summary>
    public class GoogleCloudDiscoveryengineV1betaDocumentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Document resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The Document resource full name, of the form:
        /// `projects/{project_id}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/branches/{branch_id}/documents/{document_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The promotion IDs associated with this Document. Currently, this field is restricted to at most one ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionIds")]
        public virtual System.Collections.Generic.IList<string> PromotionIds { get; set; }

        /// <summary>
        /// Quantity of the Document associated with the user event. Defaults to 1. For example, this field will be 2 if
        /// two quantities of the same Document are involved in a `add-to-cart` event. Required for events of the
        /// following event types: * `add-to-cart` * `purchase`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>The Document URI - only allowed for website data stores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Double list.</summary>
    public class GoogleCloudDiscoveryengineV1betaDoubleList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Storage location for input content.</summary>
    public class GoogleCloudDiscoveryengineV1betaGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for document imports: * `document`
        /// (default): One JSON Document per line. Each document must have a valid Document.id. * `content`:
        /// Unstructured data (e.g. PDF, HTML). Each file matched by `input_uris` becomes a document, with the ID set to
        /// the first 128 bits of SHA256(URI) encoded as a hex string. * `custom`: One custom data JSON per row in
        /// arbitrary format that conforms to the defined Schema of the data store. This can only be used by Gen App
        /// Builder. * `csv`: A CSV file with header conforming to the defined Schema of the data store. Each entry
        /// after the header is imported as a Document. This can only be used by Gen App Builder. Supported values for
        /// user even imports: * `user_event` (default): One JSON UserEvent per line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSchema")]
        public virtual string DataSchema { get; set; }

        /// <summary>
        /// Required. Cloud Storage URIs to input files. URI can be up to 2000 characters long. URIs can match the full
        /// object path (for example, `gs://bucket/directory/object.json`) or a pattern matching one or more files, such
        /// as `gs://bucket/directory/*.json`. A request can contain at most 100 files (or 100,000 files if
        /// `data_schema` is `content`). Each file can be up to 2 GB (or 100 MB if `data_schema` is `content`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUris")]
        public virtual System.Collections.Generic.IList<string> InputUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the ImportDocuments operation. This is returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Import methods.</summary>
    public class GoogleCloudDiscoveryengineV1betaImportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to automatically generate IDs for the documents if absent. If set to `true`, Document.ids are
        /// automatically generated based on the hash of the payload, where IDs may not be consistent during multiple
        /// imports. In which case ReconciliationMode.FULL is highly recommended to avoid duplicate contents. If unset
        /// or set to `false`, Document.ids have to be specified using id_field, otherwise, documents without IDs fail
        /// to be imported. Only set this field when using GcsSource or BigQuerySource, and when GcsSource.data_schema
        /// or BigQuerySource.data_schema is `custom` or `csv`. Otherwise, an INVALID_ARGUMENT error is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoGenerateIds")]
        public virtual System.Nullable<bool> AutoGenerateIds { get; set; }

        /// <summary>BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigquerySource")]
        public virtual GoogleCloudDiscoveryengineV1betaBigQuerySource BigquerySource { get; set; }

        /// <summary>The desired location of errors incurred during the Import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1betaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudDiscoveryengineV1betaGcsSource GcsSource { get; set; }

        /// <summary>
        /// The field in the Cloud Storage and BigQuery sources that indicates the unique IDs of the documents. For
        /// GcsSource it is the key of the JSON field. For instance, `my_id` for JSON `{"my_id": "some_uuid"}`. For
        /// BigQuerySource it is the column name of the BigQuery table where the unique ids are stored. The values of
        /// the JSON field or the BigQuery column are used as the Document.ids. The JSON field or the BigQuery column
        /// must be of string type, and the values must be set as valid strings conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) with 1-63 characters. Otherwise, documents without valid IDs
        /// fail to be imported. Only set this field when using GcsSource or BigQuerySource, and when
        /// GcsSource.data_schema or BigQuerySource.data_schema is `custom`. And only set this field when
        /// auto_generate_ids is unset or set as `false`. Otherwise, an INVALID_ARGUMENT error is thrown. If it is
        /// unset, a default value `_id` is used when importing from the allowed data sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idField")]
        public virtual string IdField { get; set; }

        /// <summary>The Inline source for the input content for documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineSource")]
        public virtual GoogleCloudDiscoveryengineV1betaImportDocumentsRequestInlineSource InlineSource { get; set; }

        /// <summary>
        /// The mode of reconciliation between existing documents and the documents to be imported. Defaults to
        /// ReconciliationMode.INCREMENTAL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciliationMode")]
        public virtual string ReconciliationMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inline source for the input config for ImportDocuments method.</summary>
    public class GoogleCloudDiscoveryengineV1betaImportDocumentsRequestInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of documents to update/create. Each document must have a valid Document.id. Recommended max
        /// of 100 items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaDocument> Documents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportDocumentsRequest. If the long running operation is done, then this message is returned by
    /// the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaImportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Echoes the destination for the complete errors in the request if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1betaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of destination for Import related errors.</summary>
    public class GoogleCloudDiscoveryengineV1betaImportErrorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory. Import
        /// errors are written to sharded files in this directory, one per line, as a JSON-encoded `google.rpc.Status`
        /// message.
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
    public class GoogleCloudDiscoveryengineV1betaImportUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were processed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ImportUserEvents request.</summary>
    public class GoogleCloudDiscoveryengineV1betaImportUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigquerySource")]
        public virtual GoogleCloudDiscoveryengineV1betaBigQuerySource BigquerySource { get; set; }

        /// <summary>
        /// The desired location of errors incurred during the Import. Cannot be set for inline user event imports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1betaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudDiscoveryengineV1betaGcsSource GcsSource { get; set; }

        /// <summary>The Inline source for the input content for UserEvents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineSource")]
        public virtual GoogleCloudDiscoveryengineV1betaImportUserEventsRequestInlineSource InlineSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inline source for the input config for ImportUserEvents method.</summary>
    public class GoogleCloudDiscoveryengineV1betaImportUserEventsRequestInlineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of user events to import. Recommended max of 10k items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaUserEvent> UserEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of the ImportUserEventsRequest. If the long running operation was successful, then this message is
    /// returned by the google.longrunning.Operations.response field if the operation was successful.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaImportUserEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Echoes the destination for the complete errors if this field was set in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1betaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>A sample of errors encountered while processing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorSamples")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> ErrorSamples { get; set; }

        /// <summary>Count of user events imported with complete existing Documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinedEventsCount")]
        public virtual System.Nullable<long> JoinedEventsCount { get; set; }

        /// <summary>
        /// Count of user events imported, but with Document information not found in the existing Branch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unjoinedEventsCount")]
        public virtual System.Nullable<long> UnjoinedEventsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A floating point interval.</summary>
    public class GoogleCloudDiscoveryengineV1betaInterval : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Response for ListConversations method.</summary>
    public class GoogleCloudDiscoveryengineV1betaListConversationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All the Conversations for a given data store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaConversation> Conversations { get; set; }

        /// <summary>Pagination token, if not returned indicates the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentService.ListDocuments method.</summary>
    public class GoogleCloudDiscoveryengineV1betaListDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaDocument> Documents { get; set; }

        /// <summary>
        /// A token that can be sent as ListDocumentsRequest.page_token to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SchemaService.ListSchemas method.</summary>
    public class GoogleCloudDiscoveryengineV1betaListSchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as ListSchemasRequest.page_token to retrieve the next page. If this field is
        /// omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSchema> Schemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Media-specific user event information.</summary>
    public class GoogleCloudDiscoveryengineV1betaMediaInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The media progress time in seconds, if applicable. For example, if the end user has finished 90 seconds of a
        /// playback video, then MediaInfo.media_progress_duration.seconds should be set to 90.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaProgressDuration")]
        public virtual object MediaProgressDuration { get; set; }

        /// <summary>
        /// Media progress should be computed using only the media_progress_duration relative to the media total length.
        /// This value must be between `[0, 1.0]` inclusive. If this is not a playback or the progress cannot be
        /// computed (e.g. ongoing livestream), this field should be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaProgressPercentage")]
        public virtual System.Nullable<float> MediaProgressPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed page information.</summary>
    public class GoogleCloudDiscoveryengineV1betaPageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The most specific category associated with a category page. To represent full path of category, use
        /// '&amp;gt;' sign to separate different hierarchies. If '&amp;gt;' is part of the category name, please
        /// replace it with other character(s). Category pages include special pages such as sales or promotions. For
        /// instance, a special sale page may have the category hierarchy: `"pageCategory" : "Sales &amp;gt; 2017 Black
        /// Friday Deals"`. Required for `view-category-page` events. Other event types should not set this field.
        /// Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageCategory")]
        public virtual string PageCategory { get; set; }

        /// <summary>
        /// A unique ID of a web page view. This should be kept the same for all user events triggered from the same
        /// pageview. For example, an item detail page view could trigger multiple events as the user is browsing the
        /// page. The `pageview_id` property should be kept the same for all these events so that they can be grouped
        /// together properly. When using the client side event reporting with JavaScript pixel and Google Tag Manager,
        /// this value is filled in automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageviewId")]
        public virtual string PageviewId { get; set; }

        /// <summary>
        /// The referrer URL of the current page. When using the client side event reporting with JavaScript pixel and
        /// Google Tag Manager, this value is filled in automatically. However, some browser privacy restrictions may
        /// cause this field to be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrerUri")]
        public virtual string ReferrerUri { get; set; }

        /// <summary>
        /// Complete URL (window.location.href) of the user's current page. When using the client side event reporting
        /// with JavaScript pixel and Google Tag Manager, this value is filled in automatically. Maximum length 5,000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed panel information associated with a user event.</summary>
    public class GoogleCloudDiscoveryengineV1betaPanelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the panel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The panel ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelId")]
        public virtual string PanelId { get; set; }

        /// <summary>
        /// The ordered position of the panel, if shown to the user with other panels. If set, then total_panels must
        /// also be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panelPosition")]
        public virtual System.Nullable<int> PanelPosition { get; set; }

        /// <summary>
        /// The total number of panels, including this one, shown to the user. Must be set if panel_position is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPanels")]
        public virtual System.Nullable<int> TotalPanels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the PurgeDocuments operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaPurgeDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Count of entries that encountered errors while processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<long> FailureCount { get; set; }

        /// <summary>Count of entries that were deleted successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<long> SuccessCount { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.PurgeDocuments method.</summary>
    public class GoogleCloudDiscoveryengineV1betaPurgeDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Filter matching documents to purge. Only currently supported value is `*` (all items).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Actually performs the purge. If `force` is set to false, return the expected purge count without deleting
        /// any documents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for DocumentService.PurgeDocuments method. If the long running operation is successfully done,
    /// then this message is returned by the google.longrunning.Operations.response field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaPurgeDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total count of documents purged as a result of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeCount")]
        public virtual System.Nullable<long> PurgeCount { get; set; }

        /// <summary>
        /// A sample of document names that will be deleted. Only populated if `force` is set to false. A max of 100
        /// names will be returned and the names are chosen at random.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeSample")]
        public virtual System.Collections.Generic.IList<string> PurgeSample { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Recommend method.</summary>
    public class GoogleCloudDiscoveryengineV1betaRecommendRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Filter for restricting recommendation results with a length limit of 5,000 characters. Currently, only
        /// filter expressions on the `filter_tags` attribute is supported. Examples: * `(filter_tags: ANY("Red",
        /// "Blue") OR filter_tags: ANY("Hot", "Cold"))` * `(filter_tags: ANY("Red", "Blue")) AND NOT (filter_tags:
        /// ANY("Green"))` If `attributeFilteringSyntax` is set to true under the `params` field, then attribute-based
        /// expressions are expected instead of the above described tag-based syntax. Examples: * (launguage: ANY("en",
        /// "es")) AND NOT (categories: ANY("Movie")) * (available: true) AND (launguage: ANY("en", "es")) OR
        /// (categories: ANY("Movie")) If your filter blocks all results, the API will return generic (unfiltered)
        /// popular Documents. If you only want results strictly matching the filters, set `strictFiltering` to True in
        /// RecommendRequest.params to receive empty results instead. Note that the API will never return Documents with
        /// `storageStatus` of `EXPIRED` or `DELETED` regardless of filter choices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Maximum number of results to return. Set this property to the number of recommendation results needed. If
        /// zero, the service will choose a reasonable default. The maximum allowed value is 100. Values above 100 will
        /// be coerced to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Additional domain specific parameters for the recommendations. Allowed values: * `returnDocument`: Boolean.
        /// If set to true, the associated Document object will be returned in
        /// RecommendResponse.RecommendationResult.document. * `returnScore`: Boolean. If set to true, the
        /// recommendation 'score' corresponding to each returned Document will be set in
        /// RecommendResponse.RecommendationResult.metadata. The given 'score' indicates the probability of a Document
        /// conversion given the user's context and history. * `strictFiltering`: Boolean. True by default. If set to
        /// false, the service will return generic (unfiltered) popular Documents instead of empty if your filter blocks
        /// all recommendation results. * `diversityLevel`: String. Default empty. If set to be non-empty, then it needs
        /// to be one of: * `no-diversity` * `low-diversity` * `medium-diversity` * `high-diversity` * `auto-diversity`
        /// This gives request-level control and adjusts recommendation results based on Document category. *
        /// `attributeFilteringSyntax`: Boolean. False by default. If set to true, the `filter` field is interpreted
        /// according to the new, attribute-based syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>
        /// Required. Context about the user, what they are looking at and what action they took to trigger the
        /// Recommend request. Note that this user event detail won't be ingested to userEvent logs. Thus, a separate
        /// userEvent write request is required for event logging. Don't set UserEvent.user_pseudo_id or
        /// UserEvent.user_info.user_id to the same fixed ID for different users. If you are trying to receive
        /// non-personalized recommendations (not recommended; this can negatively impact model performance), instead
        /// set UserEvent.user_pseudo_id to a random unique ID and leave UserEvent.user_info.user_id unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEvent")]
        public virtual GoogleCloudDiscoveryengineV1betaUserEvent UserEvent { get; set; }

        /// <summary>
        /// The user labels applied to a resource must meet the following requirements: * Each resource can have
        /// multiple labels, up to a maximum of 64. * Each label must be a key-value pair. * Keys have a minimum length
        /// of 1 character and a maximum length of 63 characters and cannot be empty. Values can be empty and have a
        /// maximum length of 63 characters. * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. All characters must use UTF-8 encoding, and international characters are allowed. *
        /// The key portion of a label must be unique. However, you can use the same key with multiple resources. * Keys
        /// must start with a lowercase letter or international character. See [Requirements for
        /// labels](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements) for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>
        /// Use validate only mode for this recommendation query. If set to true, a fake model will be used that returns
        /// arbitrary Document IDs. Note that the validate only mode should only be used for testing the API, or if the
        /// model is not ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Recommend method.</summary>
    public class GoogleCloudDiscoveryengineV1betaRecommendResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique attribution token. This should be included in the UserEvent logs resulting from this
        /// recommendation, which enables accurate attribution of recommendation model performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>
        /// IDs of documents in the request that were missing from the default Branch associated with the requested
        /// ServingConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingIds")]
        public virtual System.Collections.Generic.IList<string> MissingIds { get; set; }

        /// <summary>
        /// A list of recommended Documents. The order represents the ranking (from the most relevant Document to the
        /// least).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaRecommendResponseRecommendationResult> Results { get; set; }

        /// <summary>True if RecommendRequest.validate_only was set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RecommendationResult represents a generic recommendation result with associated metadata.</summary>
    public class GoogleCloudDiscoveryengineV1betaRecommendResponseRecommendationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set if `returnDocument` is set to true in RecommendRequest.params.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudDiscoveryengineV1betaDocument Document { get; set; }

        /// <summary>Resource ID of the recommended Document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Additional Document metadata / annotations. Possible values: * `score`: Recommendation score in double
        /// value. Is set if `returnScore` is set to true in RecommendRequest.params.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a reply message to user.</summary>
    public class GoogleCloudDiscoveryengineV1betaReply : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>References in the reply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaReplyReference> References { get; set; }

        /// <summary>DEPRECATED: use `summary` instead. Text reply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reply")]
        public virtual string Reply { get; set; }

        /// <summary>Summary based on search results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchResponseSummary Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines reference in reply.</summary>
    public class GoogleCloudDiscoveryengineV1betaReplyReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anchor text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anchorText")]
        public virtual string AnchorText { get; set; }

        /// <summary>Anchor text end index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<int> End { get; set; }

        /// <summary>Anchor text start index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<int> Start { get; set; }

        /// <summary>URI link reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the structure and layout of a type of document data.</summary>
    public class GoogleCloudDiscoveryengineV1betaSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The JSON representation of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual string JsonSchema { get; set; }

        /// <summary>
        /// Immutable. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// This field must be a UTF-8 encoded string with a length limit of 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The structured representation of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structSchema")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed search information.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An integer that specifies the current offset for pagination (the 0-indexed starting location, amongst the
        /// products deemed by the API as relevant). See SearchRequest.offset for definition. If this field is negative,
        /// an `INVALID_ARGUMENT` is returned. This can only be set for `search` events. Other event types should not
        /// set this field. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The order in which products are returned, if applicable. See SearchRequest.order_by for definition and
        /// syntax. The value must be a UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned. This can only be set for `search` events. Other event types should not
        /// set this field. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// The user's search query. See SearchRequest.query for definition. The value must be a UTF-8 encoded string
        /// with a length limit of 5,000 characters. Otherwise, an `INVALID_ARGUMENT` error is returned. At least one of
        /// search_query or PageInfo.page_category is required for `search` events. Other event types should not set
        /// this field. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchQuery")]
        public virtual string SearchQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SearchService.Search method.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Boost specification to boost certain documents. For more information on boosting, see
        /// [Boosting](https://cloud.google.com/retail/docs/boosting#boost)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostSpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestBoostSpec BoostSpec { get; set; }

        /// <summary>
        /// The branch resource name, such as
        /// `projects/*/locations/global/collections/default_collection/dataStores/default_data_store/branches/0`. Use
        /// `default_branch` as the branch ID or leave this field empty, to search documents under the default branch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branch")]
        public virtual string Branch { get; set; }

        /// <summary>A specification for configuring the behavior of content search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentSearchSpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpec ContentSearchSpec { get; set; }

        /// <summary>
        /// Uses the provided embedding to do additional semantic document retrieval. The retrieval is based on the dot
        /// product of SearchRequest.embedding_spec.embedding_vectors.vector and the document embedding that is provided
        /// in SearchRequest.embedding_spec.embedding_vectors.field_path. If
        /// SearchRequest.embedding_spec.embedding_vectors.field_path is not provided, it will use
        /// ServingConfig.embedding_config.field_paths.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddingSpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestEmbeddingSpec EmbeddingSpec { get; set; }

        /// <summary>
        /// Facet specifications for faceted search. If empty, no facets are returned. A maximum of 100 values are
        /// allowed. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchRequestFacetSpec> FacetSpecs { get; set; }

        /// <summary>
        /// The filter syntax consists of an expression language for constructing a predicate from one or more fields of
        /// the documents being filtered. Filter expression is case-sensitive. If this field is unrecognizable, an
        /// `INVALID_ARGUMENT` is returned. Filtering in Vertex AI Search is done by mapping the LHS filter key to a key
        /// property defined in the Vertex AI Search backend -- this mapping is defined by the customer in their schema.
        /// For example a media customer might have a field 'name' in their schema. In this case the filter would look
        /// like this: filter --&amp;gt; name:'ANY("king kong")' For more information about filtering including syntax
        /// and filter operators, see
        /// [Filter](https://cloud.google.com/generative-ai-app-builder/docs/filter-search-metadata)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Raw image query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageQuery")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestImageQuery ImageQuery { get; set; }

        /// <summary>
        /// A 0-indexed integer that specifies the current offset (that is, starting result location, amongst the
        /// Documents deemed by the API as relevant) in search results. This field is only considered if page_token is
        /// unset. If this field is negative, an `INVALID_ARGUMENT` is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The order in which documents are returned. Documents can be ordered by a field in an Document object. Leave
        /// it unset if ordered by relevance. `order_by` expression is case-sensitive. For more information on ordering,
        /// see [Ordering](https://cloud.google.com/retail/docs/filter-and-order#order) If this field is unrecognizable,
        /// an `INVALID_ARGUMENT` is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Maximum number of Documents to return. If unspecified, defaults to a reasonable value. The maximum allowed
        /// value is 100. Values above 100 are coerced to 100. If this field is negative, an `INVALID_ARGUMENT` is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token received from a previous SearchService.Search call. Provide this to retrieve the subsequent
        /// page. When paginating, all other parameters provided to SearchService.Search must match the call that
        /// provided the page token. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Additional search parameters. For public website search only, supported values are: * `user_country_code`:
        /// string. Default empty. If set to non-empty, results are restricted or boosted based on the location
        /// provided. * `search_type`: double. Default empty. Enables non-webpage searching depending on the value. The
        /// only valid non-default value is 1, which enables image searching.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>Raw search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The query expansion specification that specifies the conditions under which query expansion occurs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryExpansionSpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestQueryExpansionSpec QueryExpansionSpec { get; set; }

        /// <summary>
        /// The ranking expression controls the customized ranking on retrieval documents. This overrides
        /// ServingConfig.ranking_expression. The ranking expression is a single function or multiple functions that are
        /// joint by "+". * ranking_expression = function, { " + ", function }; Supported functions: * double *
        /// relevance_score * double * dotProduct(embedding_field_path) Function variables: `relevance_score`:
        /// pre-defined keywords, used for measure relevance between query and document. `embedding_field_path`: the
        /// document embedding field used with query embedding vector. `dotProduct`: embedding function between
        /// embedding_field_path and query embedding vector. Example ranking expression: If document has an embedding
        /// field doc_embedding, the ranking expression could be `0.5 * relevance_score + 0.3 *
        /// dotProduct(doc_embedding)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankingExpression")]
        public virtual string RankingExpression { get; set; }

        /// <summary>Whether to turn on safe search. This is only supported for website search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeSearch")]
        public virtual System.Nullable<bool> SafeSearch { get; set; }

        /// <summary>
        /// The spell correction specification that specifies the mode under which spell correction takes effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spellCorrectionSpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestSpellCorrectionSpec SpellCorrectionSpec { get; set; }

        /// <summary>
        /// Information about the end user. Highly recommended for analytics. UserInfo.user_agent is used to deduce
        /// `device_type` for analytics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaUserInfo UserInfo { get; set; }

        /// <summary>
        /// The user labels applied to a resource must meet the following requirements: * Each resource can have
        /// multiple labels, up to a maximum of 64. * Each label must be a key-value pair. * Keys have a minimum length
        /// of 1 character and a maximum length of 63 characters and cannot be empty. Values can be empty and have a
        /// maximum length of 63 characters. * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. All characters must use UTF-8 encoding, and international characters are allowed. *
        /// The key portion of a label must be unique. However, you can use the same key with multiple resources. * Keys
        /// must start with a lowercase letter or international character. See [Google Cloud
        /// Document](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements) for more
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>
        /// A unique identifier for tracking visitors. For example, this could be implemented with an HTTP cookie, which
        /// should be able to uniquely identify a visitor on a single device. This unique identifier should not change
        /// if the visitor logs in or out of the website. This field should NOT have a fixed value such as
        /// `unknown_visitor`. This should be the same identifier as UserEvent.user_pseudo_id and
        /// CompleteQueryRequest.user_pseudo_id The field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPseudoId")]
        public virtual string UserPseudoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Boost specification to boost certain documents.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestBoostSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Condition boost specifications. If a document matches multiple conditions in the specifictions, boost scores
        /// from these specifications are all applied and combined in a non-linear way. Maximum number of specifications
        /// is 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionBoostSpecs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchRequestBoostSpecConditionBoostSpec> ConditionBoostSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Boost applies to documents which match a condition.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestBoostSpecConditionBoostSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Strength of the condition boost, which should be in [-1, 1]. Negative boost means demotion. Default is 0.0.
        /// Setting to 1.0 gives the document a big promotion. However, it does not necessarily mean that the boosted
        /// document will be the top result at all times, nor that other documents will be excluded. Results could still
        /// be shown even when none of them matches the condition. And results that are significantly more relevant to
        /// the search query can still trump your heavily favored but irrelevant documents. Setting to -1.0 gives the
        /// document a big demotion. However, results that are deeply relevant might still be shown. The document will
        /// have an upstream battle to get a fairly high ranking, but it is not blocked out completely. Setting to 0.0
        /// means no boost applied. The boosting condition is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boost")]
        public virtual System.Nullable<float> Boost { get; set; }

        /// <summary>
        /// An expression which specifies a boost condition. The syntax and supported fields are the same as a filter
        /// expression. See SearchRequest.filter for detail syntax and limitations. Examples: * To boost documents with
        /// document ID "doc_1" or "doc_2", and color "Red" or "Blue": * (id: ANY("doc_1", "doc_2")) AND (color:
        /// ANY("Red","Blue"))
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification for configuring the behavior of content search.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there is no extractive_content_spec provided, there will be no extractive answer in the search response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractiveContentSpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpecExtractiveContentSpec ExtractiveContentSpec { get; set; }

        /// <summary>If `snippetSpec` is not specified, snippets are not included in the search response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippetSpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpecSnippetSpec SnippetSpec { get; set; }

        /// <summary>If `summarySpec` is not specified, summaries are not included in the search response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summarySpec")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpecSummarySpec SummarySpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification for configuring the extractive content in a search response.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpecExtractiveContentSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of extractive answers returned in each search result. An extractive answer is a verbatim
        /// answer extracted from the original document, which provides a precise and contextually relevant answer to
        /// the search query. If the number of matching answers is less than the `max_extractive_answer_count`, return
        /// all of the answers. Otherwise, return the `max_extractive_answer_count`. At most one answer is returned for
        /// each SearchResult.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxExtractiveAnswerCount")]
        public virtual System.Nullable<int> MaxExtractiveAnswerCount { get; set; }

        /// <summary>
        /// The max number of extractive segments returned in each search result. Only applied if the DataStore is set
        /// to DataStore.ContentConfig.CONTENT_REQUIRED or DataStore.solution_types is SOLUTION_TYPE_CHAT. An extractive
        /// segment is a text segment extracted from the original document that is relevant to the search query, and, in
        /// general, more verbose than an extractive answer. The segment could then be used as input for LLMs to
        /// generate summaries and answers. If the number of matching segments is less than
        /// `max_extractive_segment_count`, return all of the segments. Otherwise, return the
        /// `max_extractive_segment_count`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxExtractiveSegmentCount")]
        public virtual System.Nullable<int> MaxExtractiveSegmentCount { get; set; }

        /// <summary>Return at most `num_next_segments` segments after each selected segments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numNextSegments")]
        public virtual System.Nullable<int> NumNextSegments { get; set; }

        /// <summary>
        /// Specifies whether to also include the adjacent from each selected segments. Return at most
        /// `num_previous_segments` segments before each selected segments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numPreviousSegments")]
        public virtual System.Nullable<int> NumPreviousSegments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification for configuring snippets in a search response.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpecSnippetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [DEPRECATED] This field is deprecated. To control snippet return, use `return_snippet` field. For backwards
        /// compatibility, we will return snippet if max_snippet_count &amp;gt; 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSnippetCount")]
        public virtual System.Nullable<int> MaxSnippetCount { get; set; }

        /// <summary>[DEPRECATED] This field is deprecated and will have no affect on the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceOnly")]
        public virtual System.Nullable<bool> ReferenceOnly { get; set; }

        /// <summary>
        /// If `true`, then return snippet. If no snippet can be generated, we return "No snippet is available for this
        /// page." A `snippet_status` with `SUCCESS` or `NO_SNIPPET_AVAILABLE` will also be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnSnippet")]
        public virtual System.Nullable<bool> ReturnSnippet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification for configuring a summary returned in a search response.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestContentSearchSpecSummarySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies whether to filter out adversarial queries. The default value is `false`. Google employs
        /// search-query classification to detect adversarial queries. No summary is returned if the search query is
        /// classified as an adversarial query. For example, a user might ask a question regarding negative comments
        /// about the company or submit a query designed to generate unsafe, policy-violating output. If this field is
        /// set to `true`, we skip generating summaries for adversarial queries and return fallback messages instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreAdversarialQuery")]
        public virtual System.Nullable<bool> IgnoreAdversarialQuery { get; set; }

        /// <summary>
        /// Specifies whether to filter out queries that are not summary-seeking. The default value is `false`. Google
        /// employs search-query classification to detect summary-seeking queries. No summary is returned if the search
        /// query is classified as a non-summary seeking query. For example, `why is the sky blue` and `Who is the best
        /// soccer player in the world?` are summary-seeking queries, but `SFO airport` and `world cup 2026` are not.
        /// They are most likely navigational queries. If this field is set to `true`, we skip generating summaries for
        /// non-summary seeking queries and return fallback messages instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreNonSummarySeekingQuery")]
        public virtual System.Nullable<bool> IgnoreNonSummarySeekingQuery { get; set; }

        /// <summary>
        /// Specifies whether to include citations in the summary. The default value is `false`. When this field is set
        /// to `true`, summaries include in-line citation numbers. Example summary including citations: BigQuery is
        /// Google Cloud's fully managed and completely serverless enterprise data warehouse [1]. BigQuery supports all
        /// data types, works across clouds, and has built-in machine learning and business intelligence, all within a
        /// unified platform [2, 3]. The citation numbers refer to the returned search results and are 1-indexed. For
        /// example, [1] means that the sentence is attributed to the first search result. [2, 3] means that the
        /// sentence is attributed to both the second and third search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeCitations")]
        public virtual System.Nullable<bool> IncludeCitations { get; set; }

        /// <summary>
        /// Language code for Summary. Use language tags defined by
        /// [BCP47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt). Note: This is an experimental feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The number of top results to generate the summary from. If the number of results returned is less than
        /// `summaryResultCount`, the summary is generated from all of the results. At most five results can be used to
        /// generate a summary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryResultCount")]
        public virtual System.Nullable<int> SummaryResultCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification that uses customized query embedding vector to do semantic document retrieval.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestEmbeddingSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The embedding vector used for retrieval. Limit to 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("embeddingVectors")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchRequestEmbeddingSpecEmbeddingVector> EmbeddingVectors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Embedding vector.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestEmbeddingSpecEmbeddingVector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Embedding field path in schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>Query embedding vector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vector")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> Vector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A facet specification to perform faceted search.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestFacetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enables dynamic position for this facet. If set to true, the position of this facet among all facets in the
        /// response is determined automatically. If dynamic facets are enabled, it is ordered together. If set to
        /// false, the position of this facet in the response is the same as in the request, and it is ranked before the
        /// facets with dynamic position enable and all dynamic facets. For example, you may always want to have rating
        /// facet returned in the response, but it's not necessarily to always display the rating facet at the top. In
        /// that case, you can set enable_dynamic_position to true so that the position of rating facet in response is
        /// determined automatically. Another example, assuming you have the following facets in the request: *
        /// "rating", enable_dynamic_position = true * "price", enable_dynamic_position = false * "brands",
        /// enable_dynamic_position = false And also you have a dynamic facets enabled, which generates a facet
        /// `gender`. Then the final order of the facets in the response can be ("price", "brands", "rating", "gender")
        /// or ("price", "brands", "gender", "rating") depends on how API orders "gender" and "rating" facets. However,
        /// notice that "price" and "brands" are always ranked at first and second position because their
        /// enable_dynamic_position is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDynamicPosition")]
        public virtual System.Nullable<bool> EnableDynamicPosition { get; set; }

        /// <summary>
        /// List of keys to exclude when faceting. By default, FacetKey.key is not excluded from the filter unless it is
        /// listed in this field. Listing a facet key in this field allows its values to appear as facet results, even
        /// when they are filtered out of search results. Using this field does not affect what search results are
        /// returned. For example, suppose there are 100 documents with the color facet "Red" and 200 documents with the
        /// color facet "Blue". A query containing the filter "color:ANY("Red")" and having "color" as FacetKey.key
        /// would by default return only "Red" documents in the search results, and also return "Red" with count 100 as
        /// the only color facet. Although there are also blue documents available, "Blue" would not be shown as an
        /// available facet value. If "color" is listed in "excludedFilterKeys", then the query returns the facet values
        /// "Red" with count 100 and "Blue" with count 200, because the "color" key is now excluded from the filter.
        /// Because this field doesn't affect search results, the search results are still correctly filtered to return
        /// only "Red" documents. A maximum of 100 values are allowed. Otherwise, an `INVALID_ARGUMENT` error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedFilterKeys")]
        public virtual System.Collections.Generic.IList<string> ExcludedFilterKeys { get; set; }

        /// <summary>Required. The facet key specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetKey")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchRequestFacetSpecFacetKey FacetKey { get; set; }

        /// <summary>
        /// Maximum of facet values that should be returned for this facet. If unspecified, defaults to 20. The maximum
        /// allowed value is 300. Values above 300 are coerced to 300. If this field is negative, an `INVALID_ARGUMENT`
        /// is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<int> Limit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how a facet is computed.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestFacetSpecFacetKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True to make facet keys case insensitive when getting faceting values with prefixes or contains; false
        /// otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseInsensitive")]
        public virtual System.Nullable<bool> CaseInsensitive { get; set; }

        /// <summary>
        /// Only get facet values that contains the given strings. For example, suppose "category" has three values
        /// "Action &amp;gt; 2022", "Action &amp;gt; 2021" and "Sci-Fi &amp;gt; 2022". If set "contains" to "2022", the
        /// "category" facet only contains "Action &amp;gt; 2022" and "Sci-Fi &amp;gt; 2022". Only supported on textual
        /// fields. Maximum is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contains")]
        public virtual System.Collections.Generic.IList<string> Contains { get; set; }

        /// <summary>
        /// Set only if values should be bucketed into intervals. Must be set for facets with numerical values. Must not
        /// be set for facet with text values. Maximum number of intervals is 30.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervals")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaInterval> Intervals { get; set; }

        /// <summary>
        /// Required. Supported textual and numerical facet keys in Document object, over which the facet values are
        /// computed. Facet key is case-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The order in which documents are returned. Allowed values are: * "count desc", which means order by
        /// SearchResponse.Facet.values.count descending. * "value desc", which means order by
        /// SearchResponse.Facet.values.value descending. Only applies to textual facets. If not set, textual values are
        /// sorted in [natural order](https://en.wikipedia.org/wiki/Natural_sort_order); numerical intervals are sorted
        /// in the order given by FacetSpec.FacetKey.intervals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Only get facet values that start with the given string prefix. For example, suppose "category" has three
        /// values "Action &amp;gt; 2022", "Action &amp;gt; 2021" and "Sci-Fi &amp;gt; 2022". If set "prefixes" to
        /// "Action", the "category" facet only contains "Action &amp;gt; 2022" and "Action &amp;gt; 2021". Only
        /// supported on textual fields. Maximum is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixes")]
        public virtual System.Collections.Generic.IList<string> Prefixes { get; set; }

        /// <summary>
        /// Only get facet for the given restricted values. Only supported on textual fields. For example, suppose
        /// "category" has three values "Action &amp;gt; 2022", "Action &amp;gt; 2021" and "Sci-Fi &amp;gt; 2022". If
        /// set "restricted_values" to "Action &amp;gt; 2022", the "category" facet only contains "Action &amp;gt;
        /// 2022". Only supported on textual fields. Maximum is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedValues")]
        public virtual System.Collections.Generic.IList<string> RestrictedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the image query input.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestImageQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Base64 encoded image bytes. Supported image formats: JPEG, PNG, and BMP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageBytes")]
        public virtual string ImageBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification to determine under which conditions query expansion should occur.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchRequestQueryExpansionSpec : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudDiscoveryengineV1betaSearchRequestSpellCorrectionSpec : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudDiscoveryengineV1betaSearchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Controls applied as part of the Control service.</summary>
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
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchResponseFacet> Facets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("geoSearchDebugInfo")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchResponseGeoSearchDebugInfo> GeoSearchDebugInfo { get; set; }

        /// <summary>Guided search result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guidedSearchResult")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchResponseGuidedSearchResult GuidedSearchResult { get; set; }

        /// <summary>
        /// A token that can be sent as SearchRequest.page_token to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Query expansion information for the returned results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryExpansionInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchResponseQueryExpansionInfo QueryExpansionInfo { get; set; }

        /// <summary>
        /// The URI of a customer-defined redirect page. If redirect action is triggered, no search is performed, and
        /// only redirect_uri and attribution_token are set in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>A list of matched documents. The order represents the ranking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchResponseSearchResult> Results { get; set; }

        /// <summary>
        /// A summary as part of the search results. This field is only returned if
        /// SearchRequest.ContentSearchSpec.summary_spec is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchResponseSummary Summary { get; set; }

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
    public class GoogleCloudDiscoveryengineV1betaSearchResponseFacet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the facet is dynamically generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicFacet")]
        public virtual System.Nullable<bool> DynamicFacet { get; set; }

        /// <summary>
        /// The key for this facet. E.g., "colors" or "price". It matches SearchRequest.FacetSpec.FacetKey.key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The facet values for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchResponseFacetFacetValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A facet value which contains value names and their count.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchResponseFacetFacetValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of items that have this facet value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// Interval value for a facet, such as 10, 20) for facet "price". It matches
        /// [SearchRequest.FacetSpec.FacetKey.intervals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual GoogleCloudDiscoveryengineV1betaInterval Interval { get; set; }

        /// <summary>Text value of a facet, such as "Black" for facet "colors".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Debug information specifically related to forward geocoding issues arising from Geolocation Search.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaSearchResponseGeoSearchDebugInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error produced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The address from which forward geocoding ingestion produced issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalAddressQuery")]
        public virtual string OriginalAddressQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Guided search result. The guided search helps user to refine the search results and narrow down to the real
    /// needs from a broaded search results.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaSearchResponseGuidedSearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Suggested follow-up questions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followUpQuestions")]
        public virtual System.Collections.Generic.IList<string> FollowUpQuestions { get; set; }

        /// <summary>A list of ranked refinement attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refinementAttributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaSearchResponseGuidedSearchResultRefinementAttribute> RefinementAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Useful attribute for search result refinements.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchResponseGuidedSearchResultRefinementAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attribute key used to refine the results e.g. 'movie_type'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeKey")]
        public virtual string AttributeKey { get; set; }

        /// <summary>Attribute value used to refine the results e.g. 'drama'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeValue")]
        public virtual string AttributeValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information describing query expansion including whether expansion has occurred.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchResponseQueryExpansionInfo : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudDiscoveryengineV1betaSearchResponseSearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The document data snippet in the search response. Only fields that are marked as retrievable are populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudDiscoveryengineV1betaDocument Document { get; set; }

        /// <summary>Document.id of the searched Document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Google provided available scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelScores")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDiscoveryengineV1betaDoubleList> ModelScores { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary of the top N search result specified by the summary spec.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchResponseSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of Safety Attribute categories and their associated confidence scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyAttributes")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchResponseSummarySafetyAttributes SafetyAttributes { get; set; }

        /// <summary>
        /// Additional summary-skipped reasons. This provides the reason for ignored cases. If nothing is skipped, this
        /// field is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summarySkippedReasons")]
        public virtual System.Collections.Generic.IList<string> SummarySkippedReasons { get; set; }

        /// <summary>The summary content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summaryText")]
        public virtual string SummaryText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Safety Attribute categories and their associated confidence scores.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchResponseSummarySafetyAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The display names of Safety Attribute categories associated with the generated content. Order matches the
        /// Scores.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// The confidence scores of the each category, higher value means higher confidence. Order matches the
        /// Categories.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scores")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> Scores { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines text input.</summary>
    public class GoogleCloudDiscoveryengineV1betaTextInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Conversation context of the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudDiscoveryengineV1betaConversationContext Context { get; set; }

        /// <summary>Text input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual string Input { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transaction represents the entire purchase transaction.</summary>
    public class GoogleCloudDiscoveryengineV1betaTransactionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All the costs associated with the products. These can be manufacturing costs, shipping expenses not borne by
        /// the end user, or any other costs, such that: * Profit = value - tax - cost
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cost")]
        public virtual System.Nullable<float> Cost { get; set; }

        /// <summary>Required. Currency code. Use three-character ISO-4217 code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>
        /// The total discount(s) value applied to this transaction. This figure should be excluded from
        /// TransactionInfo.value For example, if a user paid TransactionInfo.value amount, then nominal (pre-discount)
        /// value of the transaction is the sum of TransactionInfo.value and TransactionInfo.discount_value This means
        /// that profit is calculated the same way, regardless of the discount value, and that
        /// TransactionInfo.discount_value can be larger than TransactionInfo.value: * Profit = value - tax - cost
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discountValue")]
        public virtual System.Nullable<float> DiscountValue { get; set; }

        /// <summary>All the taxes associated with the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tax")]
        public virtual System.Nullable<float> Tax { get; set; }

        /// <summary>The transaction ID with a length limit of 128 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>
        /// Required. Total non-zero value associated with the transaction. This value may include shipping, tax, or
        /// other adjustments to the total value that you want to include.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<float> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for UpdateSchema LRO.</summary>
    public class GoogleCloudDiscoveryengineV1betaUpdateSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Operation create time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Operation last update time. If the operation is done, this is also the finish time.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UserEvent captures all metadata information Discovery Engine API needs to know about how end users interact with
    /// customers' website.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaUserEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Extra user event features to include in the recommendation model. These attributes must NOT contain data
        /// that needs to be parsed or processed further, e.g. JSON or other encodings. If you provide custom attributes
        /// for ingested user events, also include them in the user events that you associate with prediction requests.
        /// Custom attribute formatting must be consistent between imported events and events provided with prediction
        /// requests. This lets the Discovery Engine API use those custom attributes when training models and serving
        /// predictions, which helps improve recommendation quality. This field needs to pass all below criteria,
        /// otherwise an `INVALID_ARGUMENT` error is returned: * The key must be a UTF-8 encoded string with a length
        /// limit of 5,000 characters. * For text attributes, at most 400 values are allowed. Empty values are not
        /// allowed. Each value must be a UTF-8 encoded string with a length limit of 256 characters. * For number
        /// attributes, at most 400 values are allowed. For product recommendations, an example of extra user
        /// information is `traffic_channel`, which is how a user arrives at the site. Users can arrive at the site by
        /// coming to the site directly, coming through Google search, or in other ways.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDiscoveryengineV1betaCustomAttribute> Attributes { get; set; }

        /// <summary>
        /// Token to attribute an API response to user action(s) to trigger the event. Highly recommended for user
        /// events that are the result of RecommendationService.Recommend. This field enables accurate attribution of
        /// recommendation model performance. The value must be one of: * RecommendResponse.attribution_token for events
        /// that are the result of RecommendationService.Recommend. * SearchResponse.attribution_token for events that
        /// are the result of SearchService.Search. This token enables us to accurately attribute page view or
        /// conversion completion back to the event and the particular predict response containing this
        /// clicked/purchased product. If user clicks on product K in the recommendation results, pass
        /// RecommendResponse.attribution_token as a URL parameter to product K's page. When recording events on product
        /// K's page, log the RecommendResponse.attribution_token to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>
        /// CompletionService.CompleteQuery details related to the event. This field should be set for `search` event
        /// when autocomplete function is enabled and the user clicks a suggestion for search.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaCompletionInfo CompletionInfo { get; set; }

        /// <summary>
        /// Should set to true if the request is made directly from the end user, in which case the
        /// UserEvent.user_info.user_agent can be populated from the HTTP request. This flag should be set only if the
        /// API request is made directly from the end user such as a mobile app (and not if a gateway or a server is
        /// processing and pushing the user events). This should not be set when using the JavaScript tag in
        /// UserEventService.CollectUserEvent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directUserRequest")]
        public virtual System.Nullable<bool> DirectUserRequest { get; set; }

        /// <summary>
        /// List of Documents associated with this user event. This field is optional except for the following event
        /// types: * `view-item` * `add-to-cart` * `purchase` * `media-play` * `media-complete` In a `search` event,
        /// this field represents the documents returned to the end user on the current page (the end user may have not
        /// finished browsing the whole page yet). When a new page is returned to the end user, after
        /// pagination/filtering/ordering even for the same query, a new `search` event with different
        /// UserEvent.documents is desired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDiscoveryengineV1betaDocumentInfo> Documents { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// Only required for UserEventService.ImportUserEvents method. Timestamp of when the user event happened.
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Required. User event type. Allowed values are: Generic values: * `search`: Search for Documents. *
        /// `view-item`: Detailed page view of a Document. * `view-item-list`: View of a panel or ordered list of
        /// Documents. * `view-home-page`: View of the home page. * `view-category-page`: View of a category page, e.g.
        /// Home &amp;gt; Men &amp;gt; Jeans Retail-related values: * `add-to-cart`: Add an item(s) to cart, e.g. in
        /// Retail online shopping * `purchase`: Purchase an item(s) Media-related values: * `media-play`: Start/resume
        /// watching a video, playing a song, etc. * `media-complete`: Finished or stopped midway through a video, song,
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// The filter syntax consists of an expression language for constructing a predicate from one or more fields of
        /// the documents being filtered. One example is for `search` events, the associated SearchRequest may contain a
        /// filter expression in SearchRequest.filter conforming to https://google.aip.dev/160#filtering. Similarly, for
        /// `view-item-list` events that are generated from a RecommendationService.RecommendRequest, this field may be
        /// populated directly from RecommendationService.RecommendRequest.filter conforming to
        /// https://google.aip.dev/160#filtering. The value must be a UTF-8 encoded string with a length limit of 1,000
        /// characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Media-specific info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaMediaInfo MediaInfo { get; set; }

        /// <summary>
        /// Page metadata such as categories and other critical information for certain event types such as
        /// `view-category-page`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaPageInfo PageInfo { get; set; }

        /// <summary>Panel metadata associated with this user event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("panel")]
        public virtual GoogleCloudDiscoveryengineV1betaPanelInfo Panel { get; set; }

        /// <summary>
        /// The promotion IDs if this is an event associated with promotions. Currently, this field is restricted to at
        /// most one ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionIds")]
        public virtual System.Collections.Generic.IList<string> PromotionIds { get; set; }

        /// <summary>
        /// SearchService.Search details related to the event. This field should be set for `search` event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchInfo SearchInfo { get; set; }

        /// <summary>
        /// A unique identifier for tracking a visitor session with a length limit of 128 bytes. A session is an
        /// aggregation of an end user behavior in a time span. A general guideline to populate the session_id: 1. If
        /// user has no activity for 30 min, a new session_id should be assigned. 2. The session_id should be unique
        /// across users, suggest use uuid or add UserEvent.user_pseudo_id as prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>
        /// A list of identifiers for the independent experiment groups this user event belongs to. This is used to
        /// distinguish between user events associated with different experiment setups on the customer end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagIds")]
        public virtual System.Collections.Generic.IList<string> TagIds { get; set; }

        /// <summary>The transaction metadata (if any) associated with this user event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaTransactionInfo TransactionInfo { get; set; }

        /// <summary>Information about the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaUserInfo UserInfo { get; set; }

        /// <summary>
        /// Required. A unique identifier for tracking visitors. For example, this could be implemented with an HTTP
        /// cookie, which should be able to uniquely identify a visitor on a single device. This unique identifier
        /// should not change if the visitor log in/out of the website. Do not set the field to the same fixed ID for
        /// different users. This mixes the event history of those users together, which results in degraded model
        /// quality. The field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned. The field should not contain PII or user-data. We recommend to use
        /// Google Analytics [Client
        /// ID](https://developers.google.com/analytics/devguides/collection/analyticsjs/field-reference#clientId) for
        /// this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPseudoId")]
        public virtual string UserPseudoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information of an end user.</summary>
    public class GoogleCloudDiscoveryengineV1betaUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User agent as included in the HTTP header. The field must be a UTF-8 encoded string with a length limit of
        /// 1,000 characters. Otherwise, an `INVALID_ARGUMENT` error is returned. This should not be set when using the
        /// client side event reporting with GTM or JavaScript tag in UserEventService.CollectUserEvent or if
        /// UserEvent.direct_user_request is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Highly recommended for logged-in users. Unique identifier for logged-in user, such as a user name. Don't set
        /// for anonymous users. Always use a hashed value for this ID. Don't set the field to the same fixed ID for
        /// different users. This mixes the event history of those users together, which results in degraded model
        /// quality. The field must be a UTF-8 encoded string with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

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
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
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
