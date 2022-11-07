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
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://discoveryengine.googleapis.com/";
        #else
            "https://discoveryengine.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://discoveryengine.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

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
                DataStores = new DataStoresResource(service);
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
                    Models = new ModelsResource(service);
                    Operations = new OperationsResource(service);
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}`.
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
                            /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the Document, which will become the final component of the
                            /// Document.name. If the caller does not have permission to create the Document, regardless
                            /// of whether or not it exists, a PERMISSION_DENIED error is returned. This field must be
                            /// unique among all Documents with the same parent. Otherwise, an ALREADY_EXISTS error is
                            /// returned. This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
                            /// standard with a length limit of 63 characters. Otherwise, an INVALID_ARGUMENT error is
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                        /// If the caller does not have permission to delete the Document, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned. If the Document to delete does not exist,
                        /// a NOT_FOUND error is returned.
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
                            /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                            /// If the caller does not have permission to delete the Document, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned. If the Document to delete does not
                            /// exist, a NOT_FOUND error is returned.
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                        /// If the caller does not have permission to access the Document, regardless of whether or not
                        /// it exists, a PERMISSION_DENIED error is returned. If the requested Document does not exist,
                        /// a NOT_FOUND error is returned.
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
                            /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
                            /// If the caller does not have permission to access the Document, regardless of whether or
                            /// not it exists, a PERMISSION_DENIED error is returned. If the requested Document does not
                            /// exist, a NOT_FOUND error is returned.
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}`.
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
                            /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}`.
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}`. Use
                        /// `default_branch` as the branch ID, to list documents under the default branch. If the caller
                        /// does not have permission to list Documentss under this branch, regardless of whether or not
                        /// this branch exists, a PERMISSION_DENIED error is returned.
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
                            /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}`. Use
                            /// `default_branch` as the branch ID, to list documents under the default branch. If the
                            /// caller does not have permission to list Documentss under this branch, regardless of
                            /// whether or not this branch exists, a PERMISSION_DENIED error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Maximum number of Documents to return. If unspecified, defaults to 100. The maximum
                            /// allowed value is 1000. Values above 1000 will be coerced to 1000. If this field is
                            /// negative, an INVALID_ARGUMENT error is returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token ListDocumentsResponse.next_page_token, received from a previous
                            /// DocumentService.ListDocuments call. Provide this to retrieve the subsequent page. When
                            /// paginating, all other parameters provided to DocumentService.ListDocuments must match
                            /// the call that provided the page token. Otherwise, an INVALID_ARGUMENT error is returned.
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
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
                            /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
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
                    /// projects/*/locations/global/dataStores/*/servingConfigs/* Before you can request recommendations
                    /// from your model, you must create at least one serving config for it.
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
                        /// projects/*/locations/global/dataStores/*/servingConfigs/* Before you can request
                        /// recommendations from your model, you must create at least one serving config for it.
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
                    /// restriction of POST-ing to a 3rd party domain. This method is used only by the Discovery Engine
                    /// API JavaScript pixel and Google Tag Manager. Users should not call this method directly.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent DataStore resource name, such as
                    /// `projects/{project}/locations/{location}/dataStores/{data_store}`.
                    /// </param>
                    public virtual CollectRequest Collect(string parent)
                    {
                        return new CollectRequest(service, parent);
                    }

                    /// <summary>
                    /// Writes a single user event from the browser. This uses a GET request to due to browser
                    /// restriction of POST-ing to a 3rd party domain. This method is used only by the Discovery Engine
                    /// API JavaScript pixel and Google Tag Manager. Users should not call this method directly.
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}`.
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
                    /// `projects/{project}/locations/{location}/dataStores/{data_store}`
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}`
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
                    /// `projects/{project}/locations/{location}/dataStores/{data_store}`.
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
                        /// `projects/{project}/locations/{location}/dataStores/{data_store}`.
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

    /// <summary>
    /// Metadata related to the progress of the ImportDocuments operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1alphaImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        /// Google Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory.
        /// Import errors will be written to sharded files in this directory, one per line, as a JSON-encoded
        /// `google.rpc.Status` message.
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
    public class GoogleCloudDiscoveryengineV1alphaImportUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>BigQuery source import data from.</summary>
    public class GoogleCloudDiscoveryengineV1betaBigQuerySource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for imports: * `user_event`
        /// (default): One JSON UserEvent per line. * `document` (default): One JSON Document per line. Each document
        /// must have a valid document.id.
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

    /// <summary>
    /// Detailed completion information including completion attribution token and clicked completion info.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaCompletionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>A custom attribute that is not explicitly modeled in a resource, e.g. UserEvent.</summary>
    public class GoogleCloudDiscoveryengineV1betaCustomAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The numerical values of this custom attribute. For example, `[2.3, 15.4]` when the key is "lengths_cm".
        /// Exactly one of text or numbers should be set. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numbers")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Numbers { get; set; }

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

    /// <summary>Document captures all raw metadata information of items to be recommended or searched.</summary>
    public class GoogleCloudDiscoveryengineV1betaDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. The identifier of the document. Id should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length limit of 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The JSON string representation of the document. It should conform to the registered schema or an
        /// INVALID_ARGUMENT error is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonData")]
        public virtual string JsonData { get; set; }

        /// <summary>
        /// Immutable. The full resource name of the document. Format:
        /// `projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document_id}`.
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

        /// <summary>Required. The identifier of the schema located in the same data store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaId")]
        public virtual string SchemaId { get; set; }

        /// <summary>
        /// The structured JSON data for the document. It should conform to the registered schema or an INVALID_ARGUMENT
        /// error is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structData")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed document information associated with a user event.</summary>
    public class GoogleCloudDiscoveryengineV1betaDocumentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Document resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The Document resource full name, of the form:
        /// projects//locations//dataStores//branches//documents/
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage location for input content. format.</summary>
    public class GoogleCloudDiscoveryengineV1betaGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The schema to use when parsing the data from the source. Supported values for imports: * `user_event`
        /// (default): One JSON UserEvent per line. * `document` (default): One JSON Document per line. Each document
        /// must have a valid Document.id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSchema")]
        public virtual string DataSchema { get; set; }

        /// <summary>
        /// Required. Google Cloud Storage URIs to input files. URI can be up to 2000 characters long. URIs can match
        /// the full object path (for example, `gs://bucket/directory/object.json`) or a pattern matching one or more
        /// files, such as `gs://bucket/directory/*.json`. A request can contain at most 100 files, and each file can be
        /// up to 2 GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUris")]
        public virtual System.Collections.Generic.IList<string> InputUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata related to the progress of the ImportDocuments operation. This will be returned by the
    /// google.longrunning.Operation.metadata field.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleCloudDiscoveryengineV1betaImportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigquerySource")]
        public virtual GoogleCloudDiscoveryengineV1betaBigQuerySource BigquerySource { get; set; }

        /// <summary>The desired location of errors incurred during the Import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1betaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>Google Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudDiscoveryengineV1betaGcsSource GcsSource { get; set; }

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
        /// Google Cloud Storage prefix for import errors. This must be an empty, existing Cloud Storage directory.
        /// Import errors will be written to sharded files in this directory, one per line, as a JSON-encoded
        /// `google.rpc.Status` message.
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
    public class GoogleCloudDiscoveryengineV1betaImportUserEventsMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for the ImportUserEvents request.</summary>
    public class GoogleCloudDiscoveryengineV1betaImportUserEventsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. BigQuery input source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigquerySource")]
        public virtual GoogleCloudDiscoveryengineV1betaBigQuerySource BigquerySource { get; set; }

        /// <summary>
        /// The desired location of errors incurred during the Import. Cannot be set for inline user event imports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorConfig")]
        public virtual GoogleCloudDiscoveryengineV1betaImportErrorConfig ErrorConfig { get; set; }

        /// <summary>Required. Google Cloud Storage location for the input content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudDiscoveryengineV1betaGcsSource GcsSource { get; set; }

        /// <summary>Required. The Inline source for the input content for UserEvents.</summary>
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
        /// This value must be between [0, 1.0] inclusive. If this is not a playback or the progress cannot be computed
        /// (e.g. ongoing livestream), this field should be unset.
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
        /// instance, a special sale page may have the category hierarchy: "pageCategory" : "Sales &amp;gt; 2017 Black
        /// Friday Deals". Required for `view-category-page` events. Other event types should not set this field.
        /// Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageCategory")]
        public virtual string PageCategory { get; set; }

        /// <summary>
        /// A unique ID of a web page view. This should be kept the same for all user events triggered from the same
        /// pageview. For example, an item detail page view could trigger multiple events as the user is browsing the
        /// page. The `pageViewId` property should be kept the same for all these events so that they can be grouped
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

    /// <summary>Request message for Recommend method.</summary>
    public class GoogleCloudDiscoveryengineV1betaRecommendRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Filter for restricting recommendation results with a length limit of 5,000 characters. Currently, only
        /// filter expressions on the `filter_tags` attribute is supported. Examples: * (filter_tags: ANY("Red", "Blue")
        /// OR filter_tags: ANY("Hot", "Cold")) * (filter_tags: ANY("Red", "Blue")) AND NOT (filter_tags: ANY("Green"))
        /// If your filter blocks all results, the API will return generic (unfiltered) popular Documents. If you only
        /// want results strictly matching the filters, set `strictFiltering` to True in RecommendRequest.params to
        /// receive empty results instead. Note that the API will never return Documents with storageStatus of "EXPIRED"
        /// or "DELETED" regardless of filter choices.
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
        /// If set to true, the associated Document object will be returned in RecommendResponse.results.document. *
        /// `returnScore`: Boolean. If set to true, the recommendation 'score' corresponding to each returned Document
        /// will be set in RecommendResponse.results.metadata. The given 'score' indicates the probability of a Document
        /// conversion given the user's context and history. * `strictFiltering`: Boolean. True by default. If set to
        /// false, the service will return generic (unfiltered) popular Documents instead of empty if your filter blocks
        /// all recommendation results. * `diversityLevel`: String. Default empty. If set to be non-empty, then it needs
        /// to be one of: * 'no-diversity' * 'low-diversity' * 'medium-diversity' * 'high-diversity' * 'auto-diversity'
        /// This gives request-level control and adjusts recommendation results based on Document category.
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
        /// must start with a lowercase letter or international character. See [Google Cloud
        /// Document](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements) for more
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

    /// <summary>Detailed search information.</summary>
    public class GoogleCloudDiscoveryengineV1betaSearchInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An integer that specifies the current offset for pagination (the 0-indexed starting location, amongst the
        /// products deemed by the API as relevant). See SearchRequest.offset for definition. If this field is negative,
        /// an INVALID_ARGUMENT is returned. This can only be set for `search` events. Other event types should not set
        /// this field. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The order in which products are returned, if applicable. See SearchRequest.order_by for definition and
        /// syntax. The value must be a UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned. This can only be set for `search` events. Other event types should not
        /// set this field. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// The user's search query. See SearchRequest.query for definition. The value must be a UTF-8 encoded string
        /// with a length limit of 5,000 characters. Otherwise, an INVALID_ARGUMENT error is returned. At least one of
        /// search_query or page_categories is required for `search` events. Other event types should not set this
        /// field. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchQuery")]
        public virtual string SearchQuery { get; set; }

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

    /// <summary>
    /// UserEvent captures all metadata information DiscoveryEngine API needs to know about how end users interact with
    /// customers' website.
    /// </summary>
    public class GoogleCloudDiscoveryengineV1betaUserEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Extra user event features to include in the recommendation model. These attributes must NOT contain data
        /// that needs to be parsed or processed further, e.g. JSON or other encodings. If you provide custom attributes
        /// for ingested user events, also include them in the user events that you associate with prediction requests.
        /// Custom attribute formatting must be consistent between imported events and events provided with prediction
        /// requests. This lets the DiscoveryEngine API use those custom attributes when training models and serving
        /// predictions, which helps improve recommendation quality. This field needs to pass all below criteria,
        /// otherwise an INVALID_ARGUMENT error is returned: * The key must be a UTF-8 encoded string with a length
        /// limit of 5,000 characters. * For text attributes, at most 400 values are allowed. Empty values are not
        /// allowed. Each value must be a UTF-8 encoded string with a length limit of 256 characters. * For number
        /// attributes, at most 400 values are allowed. For product recommendations, an example of extra user
        /// information is traffic_channel, which is how a user arrives at the site. Users can arrive at the site by
        /// coming to the site directly, coming through Google search, or in other ways.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudDiscoveryengineV1betaCustomAttribute> Attributes { get; set; }

        /// <summary>
        /// Token to attribute an API response to user action(s) to trigger the event. Highly recommended for user
        /// events that are the result of PredictionService.Predict. This field enables accurate attribution of
        /// recommendation model performance. The value must be one of: * PredictResponse.attribution_token for events
        /// that are the result of PredictionService.Predict. * SearchResponse.attribution_token for events that are the
        /// result of SearchService.Search. * CompleteQueryResponse.attribution_token for events that are the result of
        /// SearchService.CompleteQuery. This token enables us to accurately attribute page view or conversion
        /// completion back to the event and the particular predict response containing this clicked/purchased product.
        /// If user clicks on product K in the recommendation results, pass PredictResponse.attribution_token as a URL
        /// parameter to product K's page. When recording events on product K's page, log the
        /// PredictResponse.attribution_token to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributionToken")]
        public virtual string AttributionToken { get; set; }

        /// <summary>
        /// CompleteQuery API details related to the event. This field should be set for `search` event when
        /// autocomplete function is enabled and the user clicks a suggestion for search.
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

        /// <summary>
        /// Only required for UserEventService.ImportUserEvents method. Timestamp of when the user event happened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

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
        /// the documents being filtered. One example is for `search` events, the associated SearchService.SearchRequest
        /// may contain a filter expression in SearchService.SearchRequest.filter conforming to
        /// https://google.aip.dev/160#filtering. Similarly, for `view-item-list` events that are generated from a
        /// PredictionService.PredictRequest, this field may be populated directly from
        /// PredictionService.PredictRequest.filter conforming to https://google.aip.dev/160#filtering. The value must
        /// be a UTF-8 encoded string with a length limit of 1,000 characters. Otherwise, an INVALID_ARGUMENT error is
        /// returned.
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

        /// <summary>Search API details related to the event. This field should be set for `search` event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchInfo")]
        public virtual GoogleCloudDiscoveryengineV1betaSearchInfo SearchInfo { get; set; }

        /// <summary>
        /// A unique identifier for tracking a visitor session with a length limit of 128 bytes. A session is an
        /// aggregation of an end user behavior in a time span. A general guideline to populate the sesion_id: 1. If
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
        /// INVALID_ARGUMENT error is returned. The field should not contain PII or user-data. We recommend to use
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
