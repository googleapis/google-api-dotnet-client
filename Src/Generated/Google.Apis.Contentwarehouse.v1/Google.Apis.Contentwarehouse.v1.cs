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

namespace Google.Apis.Contentwarehouse.v1
{
    /// <summary>The Contentwarehouse Service.</summary>
    public class ContentwarehouseService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ContentwarehouseService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ContentwarehouseService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://contentwarehouse.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://contentwarehouse.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "contentwarehouse";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Document AI Warehouse API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Document AI Warehouse API.</summary>
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

    /// <summary>A base abstract class for Contentwarehouse requests.</summary>
    public abstract class ContentwarehouseBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ContentwarehouseBaseServiceRequest instance.</summary>
        protected ContentwarehouseBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Contentwarehouse parameter list.</summary>
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
                DocumentSchemas = new DocumentSchemasResource(service);
                Documents = new DocumentsResource(service);
                Operations = new OperationsResource(service);
                RuleSets = new RuleSetsResource(service);
                SynonymSets = new SynonymSetsResource(service);
            }

            /// <summary>Gets the DocumentSchemas resource.</summary>
            public virtual DocumentSchemasResource DocumentSchemas { get; }

            /// <summary>The "documentSchemas" collection of methods.</summary>
            public class DocumentSchemasResource
            {
                private const string Resource = "documentSchemas";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DocumentSchemasResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a document schema.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent name.</param>
                public virtual CreateRequest Create(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DocumentSchema body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a document schema.</summary>
                public class CreateRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DocumentSchema>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DocumentSchema body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DocumentSchema Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/documentSchemas";

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
                /// Deletes a document schema. Returns NOT_FOUND if the document schema does not exist. Returns
                /// BAD_REQUEST if the document schema has documents depending on it.
                /// </summary>
                /// <param name="name">Required. The name of the document schema to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a document schema. Returns NOT_FOUND if the document schema does not exist. Returns
                /// BAD_REQUEST if the document schema has documents depending on it.
                /// </summary>
                public class DeleteRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the document schema to delete.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documentSchemas/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a document schema. Returns NOT_FOUND if the document schema does not exist.</summary>
                /// <param name="name">Required. The name of the document schema to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a document schema. Returns NOT_FOUND if the document schema does not exist.</summary>
                public class GetRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DocumentSchema>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the document schema to retrieve.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documentSchemas/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists document schemas.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of document schemas. Format:
                /// projects/{project_number}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists document schemas.</summary>
                public class ListRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListDocumentSchemasResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of document schemas. Format:
                    /// projects/{project_number}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of document schemas to return. The service may return fewer than this value.
                    /// If unspecified, at most 50 document schemas will be returned. The maximum value is 1000; values
                    /// above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListDocumentSchemas` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListDocumentSchemas` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/documentSchemas";

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
                /// Updates a Document Schema. Returns INVALID_ARGUMENT if the name of the Document Schema is non-empty
                /// and does not equal the existing name. Supports only appending new properties, adding new ENUM
                /// possible values, and updating the EnumTypeOptions.validation_check_disabled flag for ENUM possible
                /// values. Updating existing properties will result into INVALID_ARGUMENT.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the document schema to update. Format:
                /// projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentSchemaRequest body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a Document Schema. Returns INVALID_ARGUMENT if the name of the Document Schema is non-empty
                /// and does not equal the existing name. Supports only appending new properties, adding new ENUM
                /// possible values, and updating the EnumTypeOptions.validation_check_disabled flag for ENUM possible
                /// values. Updating existing properties will result into INVALID_ARGUMENT.
                /// </summary>
                public class PatchRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DocumentSchema>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentSchemaRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the document schema to update. Format:
                    /// projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentSchemaRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documentSchemas/[^/]+$",
                        });
                    }
                }
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
                    DocumentLinks = new DocumentLinksResource(service);
                    ReferenceId = new ReferenceIdResource(service);
                }

                /// <summary>Gets the DocumentLinks resource.</summary>
                public virtual DocumentLinksResource DocumentLinks { get; }

                /// <summary>The "documentLinks" collection of methods.</summary>
                public class DocumentLinksResource
                {
                    private const string Resource = "documentLinks";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DocumentLinksResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create a link between a source document and a target document.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Parent of the document-link to be created. parent of document-link should be a
                    /// document. Format: projects/{project_number}/locations/{location}/documents/{source_document_id}.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1CreateDocumentLinkRequest body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create a link between a source document and a target document.</summary>
                    public class CreateRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DocumentLink>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1CreateDocumentLinkRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent of the document-link to be created. parent of document-link should be a
                        /// document. Format:
                        /// projects/{project_number}/locations/{location}/documents/{source_document_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1CreateDocumentLinkRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/documentLinks";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Remove the link between the source and target documents.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the document-link to be deleted. Format:
                    /// projects/{project_number}/locations/{location}/documents/{source_document_id}/documentLinks/{document_link_id}.
                    /// </param>
                    public virtual DeleteRequest Delete(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentLinkRequest body, string name)
                    {
                        return new DeleteRequest(this.service, body, name);
                    }

                    /// <summary>Remove the link between the source and target documents.</summary>
                    public class DeleteRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentLinkRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the document-link to be deleted. Format:
                        /// projects/{project_number}/locations/{location}/documents/{source_document_id}/documentLinks/{document_link_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentLinkRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:delete";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+/documentLinks/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the ReferenceId resource.</summary>
                public virtual ReferenceIdResource ReferenceId { get; }

                /// <summary>The "referenceId" collection of methods.</summary>
                public class ReferenceIdResource
                {
                    private const string Resource = "referenceId";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReferenceIdResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a document. Returns NOT_FOUND if the document does not exist.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the document to delete. Format:
                    /// projects/{project_number}/locations/{location}/documents/{document_id} or
                    /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                    /// </param>
                    public virtual DeleteRequest Delete(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentRequest body, string name)
                    {
                        return new DeleteRequest(this.service, body, name);
                    }

                    /// <summary>Deletes a document. Returns NOT_FOUND if the document does not exist.</summary>
                    public class DeleteRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the document to delete. Format:
                        /// projects/{project_number}/locations/{location}/documents/{document_id} or
                        /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:delete";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/documents/referenceId/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a document. Returns NOT_FOUND if the document does not exist.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the document to retrieve. Format:
                    /// projects/{project_number}/locations/{location}/documents/{document_id} or
                    /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                    /// </param>
                    public virtual GetRequest Get(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1GetDocumentRequest body, string name)
                    {
                        return new GetRequest(this.service, body, name);
                    }

                    /// <summary>Gets a document. Returns NOT_FOUND if the document does not exist.</summary>
                    public class GetRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1Document>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1GetDocumentRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the document to retrieve. Format:
                        /// projects/{project_number}/locations/{location}/documents/{document_id} or
                        /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1GetDocumentRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:get";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/documents/referenceId/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Updates a document. Returns INVALID_ARGUMENT if the name of the document is non-empty and does
                    /// not equal the existing name.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the document to update. Format:
                    /// projects/{project_number}/locations/{location}/documents/{document_id} or
                    /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentRequest body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates a document. Returns INVALID_ARGUMENT if the name of the document is non-empty and does
                    /// not equal the existing name.
                    /// </summary>
                    public class PatchRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentResponse>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the document to update. Format:
                        /// projects/{project_number}/locations/{location}/documents/{document_id} or
                        /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/documents/referenceId/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1CreateDocumentRequest body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a document.</summary>
                public class CreateRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1CreateDocumentResponse>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1CreateDocumentRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1CreateDocumentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/documents";

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

                /// <summary>Deletes a document. Returns NOT_FOUND if the document does not exist.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the document to delete. Format:
                /// projects/{project_number}/locations/{location}/documents/{document_id} or
                /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                /// </param>
                public virtual DeleteRequest Delete(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentRequest body, string name)
                {
                    return new DeleteRequest(this.service, body, name);
                }

                /// <summary>Deletes a document. Returns NOT_FOUND if the document does not exist.</summary>
                public class DeleteRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the document to delete. Format:
                    /// projects/{project_number}/locations/{location}/documents/{document_id} or
                    /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1DeleteDocumentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:delete";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns NOT_FOUND error if the resource does not
                /// exist. Returns an empty policy if the resource exists but does not have a policy set.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
                /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
                /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
                /// projects/{project_number}.
                /// </param>
                public virtual FetchAclRequest FetchAcl(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclRequest body, string resource)
                {
                    return new FetchAclRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns NOT_FOUND error if the resource does not
                /// exist. Returns an empty policy if the resource exists but does not have a policy set.
                /// </summary>
                public class FetchAclRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclResponse>
                {
                    /// <summary>Constructs a new FetchAcl request.</summary>
                    public FetchAclRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
                    /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
                    /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
                    /// projects/{project_number}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchAcl";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:fetchAcl";

                    /// <summary>Initializes FetchAcl parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a document. Returns NOT_FOUND if the document does not exist.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the document to retrieve. Format:
                /// projects/{project_number}/locations/{location}/documents/{document_id} or
                /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                /// </param>
                public virtual GetRequest Get(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1GetDocumentRequest body, string name)
                {
                    return new GetRequest(this.service, body, name);
                }

                /// <summary>Gets a document. Returns NOT_FOUND if the document does not exist.</summary>
                public class GetRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1Document>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1GetDocumentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the document to retrieve. Format:
                    /// projects/{project_number}/locations/{location}/documents/{document_id} or
                    /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1GetDocumentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:get";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                        });
                    }
                }

                /// <summary>Return all source document-links from the document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the document, for which all source links are returned. Format:
                /// projects/{project_number}/locations/{location}/documents/{source_document_id}.
                /// </param>
                public virtual LinkedSourcesRequest LinkedSources(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedSourcesRequest body, string parent)
                {
                    return new LinkedSourcesRequest(this.service, body, parent);
                }

                /// <summary>Return all source document-links from the document.</summary>
                public class LinkedSourcesRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedSourcesResponse>
                {
                    /// <summary>Constructs a new LinkedSources request.</summary>
                    public LinkedSourcesRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedSourcesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the document, for which all source links are returned. Format:
                    /// projects/{project_number}/locations/{location}/documents/{source_document_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedSourcesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "linkedSources";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/linkedSources";

                    /// <summary>Initializes LinkedSources parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                        });
                    }
                }

                /// <summary>Return all target document-links from the document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the document, for which all target links are returned. Format:
                /// projects/{project_number}/locations/{location}/documents/{target_document_id}.
                /// </param>
                public virtual LinkedTargetsRequest LinkedTargets(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedTargetsRequest body, string parent)
                {
                    return new LinkedTargetsRequest(this.service, body, parent);
                }

                /// <summary>Return all target document-links from the document.</summary>
                public class LinkedTargetsRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedTargetsResponse>
                {
                    /// <summary>Constructs a new LinkedTargets request.</summary>
                    public LinkedTargetsRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedTargetsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the document, for which all target links are returned. Format:
                    /// projects/{project_number}/locations/{location}/documents/{target_document_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListLinkedTargetsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "linkedTargets";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/linkedTargets";

                    /// <summary>Initializes LinkedTargets parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                        });
                    }
                }

                /// <summary>Lock the document so the document cannot be updated by other users.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the document to lock. Format:
                /// projects/{project_number}/locations/{location}/documents/{document}.
                /// </param>
                public virtual ContentwarehouseLockRequest ContentwarehouseLock(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1LockDocumentRequest body, string name)
                {
                    return new ContentwarehouseLockRequest(this.service, body, name);
                }

                /// <summary>Lock the document so the document cannot be updated by other users.</summary>
                public class ContentwarehouseLockRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1Document>
                {
                    /// <summary>Constructs a new ContentwarehouseLock request.</summary>
                    public ContentwarehouseLockRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1LockDocumentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the document to lock. Format:
                    /// projects/{project_number}/locations/{location}/documents/{document}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1LockDocumentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "lock";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:lock";

                    /// <summary>Initializes ContentwarehouseLock parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Updates a document. Returns INVALID_ARGUMENT if the name of the document is non-empty and does not
                /// equal the existing name.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the document to update. Format:
                /// projects/{project_number}/locations/{location}/documents/{document_id} or
                /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentRequest body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a document. Returns INVALID_ARGUMENT if the name of the document is non-empty and does not
                /// equal the existing name.
                /// </summary>
                public class PatchRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentResponse>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the document to update. Format:
                    /// projects/{project_number}/locations/{location}/documents/{document_id} or
                    /// projects/{project_number}/locations/{location}/documents/referenceId/{reference_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateDocumentRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Searches for documents using provided SearchDocumentsRequest. This call only returns documents that
                /// the caller has permission to search against.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of documents. Format:
                /// projects/{project_number}/locations/{location}.
                /// </param>
                public virtual SearchRequest Search(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SearchDocumentsRequest body, string parent)
                {
                    return new SearchRequest(this.service, body, parent);
                }

                /// <summary>
                /// Searches for documents using provided SearchDocumentsRequest. This call only returns documents that
                /// the caller has permission to search against.
                /// </summary>
                public class SearchRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SearchDocumentsResponse>
                {
                    /// <summary>Constructs a new Search request.</summary>
                    public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SearchDocumentsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of documents. Format:
                    /// projects/{project_number}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SearchDocumentsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "search";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/documents:search";

                    /// <summary>Initializes Search parameter list.</summary>
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

                /// <summary>Sets the access control policy for a resource. Replaces any existing policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
                /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
                /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
                /// projects/{project_number}.
                /// </param>
                public virtual SetAclRequest SetAcl(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclRequest body, string resource)
                {
                    return new SetAclRequest(this.service, body, resource);
                }

                /// <summary>Sets the access control policy for a resource. Replaces any existing policy.</summary>
                public class SetAclRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclResponse>
                {
                    /// <summary>Constructs a new SetAcl request.</summary>
                    public SetAclRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
                    /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
                    /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
                    /// projects/{project_number}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setAcl";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setAcl";

                    /// <summary>Initializes SetAcl parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/documents/[^/]+$",
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
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleLongrunningOperation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the RuleSets resource.</summary>
            public virtual RuleSetsResource RuleSets { get; }

            /// <summary>The "ruleSets" collection of methods.</summary>
            public class RuleSetsResource
            {
                private const string Resource = "ruleSets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RuleSetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a ruleset.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RuleSet body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a ruleset.</summary>
                public class CreateRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RuleSet>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RuleSet body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RuleSet Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/ruleSets";

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

                /// <summary>Deletes a ruleset. Returns NOT_FOUND if the document does not exist.</summary>
                /// <param name="name">
                /// Required. The name of the rule set to delete. Format:
                /// projects/{project_number}/locations/{location}/ruleSets/{rule_set_id}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a ruleset. Returns NOT_FOUND if the document does not exist.</summary>
                public class DeleteRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the rule set to delete. Format:
                    /// projects/{project_number}/locations/{location}/ruleSets/{rule_set_id}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ruleSets/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a ruleset. Returns NOT_FOUND if the ruleset does not exist.</summary>
                /// <param name="name">
                /// Required. The name of the rule set to retrieve. Format:
                /// projects/{project_number}/locations/{location}/ruleSets/{rule_set_id}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a ruleset. Returns NOT_FOUND if the ruleset does not exist.</summary>
                public class GetRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RuleSet>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the rule set to retrieve. Format:
                    /// projects/{project_number}/locations/{location}/ruleSets/{rule_set_id}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ruleSets/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists rulesets.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of document. Format:
                /// projects/{project_number}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists rulesets.</summary>
                public class ListRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListRuleSetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of document. Format:
                    /// projects/{project_number}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of rule sets to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 rule sets will be returned. The maximum value is 1000; values above 1000
                    /// will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListRuleSets` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListRuleSets` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/ruleSets";

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
                /// Updates a ruleset. Returns INVALID_ARGUMENT if the name of the ruleset is non-empty and does not
                /// equal the existing name.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the rule set to update. Format:
                /// projects/{project_number}/locations/{location}/ruleSets/{rule_set_id}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateRuleSetRequest body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a ruleset. Returns INVALID_ARGUMENT if the name of the ruleset is non-empty and does not
                /// equal the existing name.
                /// </summary>
                public class PatchRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RuleSet>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateRuleSetRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the rule set to update. Format:
                    /// projects/{project_number}/locations/{location}/ruleSets/{rule_set_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1UpdateRuleSetRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ruleSets/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the SynonymSets resource.</summary>
            public virtual SynonymSetsResource SynonymSets { get; }

            /// <summary>The "synonymSets" collection of methods.</summary>
            public class SynonymSetsResource
            {
                private const string Resource = "synonymSets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SynonymSetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a SynonymSet for a single context. Throws an ALREADY_EXISTS exception if a synonymset
                /// already exists for the context.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a SynonymSet for a single context. Throws an ALREADY_EXISTS exception if a synonymset
                /// already exists for the context.
                /// </summary>
                public class CreateRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/synonymSets";

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
                /// Deletes a SynonymSet for a given context. Throws a NOT_FOUND exception if the SynonymSet is not
                /// found.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the synonymSet to delete Format:
                /// projects/{project_number}/locations/{location}/synonymSets/{context}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a SynonymSet for a given context. Throws a NOT_FOUND exception if the SynonymSet is not
                /// found.
                /// </summary>
                public class DeleteRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the synonymSet to delete Format:
                    /// projects/{project_number}/locations/{location}/synonymSets/{context}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/synonymSets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a SynonymSet for a particular context. Throws a NOT_FOUND exception if the Synonymset does not
                /// exist
                /// </summary>
                /// <param name="name">
                /// Required. The name of the synonymSet to retrieve Format:
                /// projects/{project_number}/locations/{location}/synonymSets/{context}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets a SynonymSet for a particular context. Throws a NOT_FOUND exception if the Synonymset does not
                /// exist
                /// </summary>
                public class GetRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the synonymSet to retrieve Format:
                    /// projects/{project_number}/locations/{location}/synonymSets/{context}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/synonymSets/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns all SynonymSets (for all contexts) for the specified location.</summary>
                /// <param name="parent">
                /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Returns all SynonymSets (for all contexts) for the specified location.</summary>
                public class ListRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ListSynonymSetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent name. Format: projects/{project_number}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of synonymSets to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 rule sets will be returned. The maximum value is 1000; values above 1000
                    /// will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListSynonymSets` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListSynonymSets` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/synonymSets";

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
                /// Remove the existing SynonymSet for the context and replaces it with a new one. Throws a NOT_FOUND
                /// exception if the SynonymSet is not found.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the synonymSet to update Format:
                /// projects/{project_number}/locations/{location}/synonymSets/{context}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Remove the existing SynonymSet for the context and replaces it with a new one. Throws a NOT_FOUND
                /// exception if the SynonymSet is not found.
                /// </summary>
                public class PatchRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the synonymSet to update Format:
                    /// projects/{project_number}/locations/{location}/synonymSets/{context}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SynonymSet Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/synonymSets/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Get the project status.</summary>
            /// <param name="location">
            /// Required. The location to be queried Format: projects/{project_number}/locations/{location}.
            /// </param>
            public virtual GetStatusRequest GetStatus(string location)
            {
                return new GetStatusRequest(this.service, location);
            }

            /// <summary>Get the project status.</summary>
            public class GetStatusRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1ProjectStatus>
            {
                /// <summary>Constructs a new GetStatus request.</summary>
                public GetStatusRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                {
                    Location = location;
                    InitParameters();
                }

                /// <summary>
                /// Required. The location to be queried Format: projects/{project_number}/locations/{location}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getStatus";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}:getStatus";

                /// <summary>Initializes GetStatus parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Provisions resources for given tenant project. Returns a long running operation.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="location">
            /// Required. The location to be initialized Format: projects/{project_number}/locations/{location}.
            /// </param>
            public virtual InitializeRequest Initialize(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1InitializeProjectRequest body, string location)
            {
                return new InitializeRequest(this.service, body, location);
            }

            /// <summary>Provisions resources for given tenant project. Returns a long running operation.</summary>
            public class InitializeRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Initialize request.</summary>
                public InitializeRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1InitializeProjectRequest body, string location) : base(service)
                {
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The location to be initialized Format: projects/{project_number}/locations/{location}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1InitializeProjectRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "initialize";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}:initialize";

                /// <summary>Initializes Initialize parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Run a predefined pipeline.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name which owns the resources of the pipeline. Format:
            /// projects/{project_number}/locations/{location}.
            /// </param>
            public virtual RunPipelineRequest RunPipeline(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RunPipelineRequest body, string name)
            {
                return new RunPipelineRequest(this.service, body, name);
            }

            /// <summary>Run a predefined pipeline.</summary>
            public class RunPipelineRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new RunPipeline request.</summary>
                public RunPipelineRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RunPipelineRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name which owns the resources of the pipeline. Format:
                /// projects/{project_number}/locations/{location}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1RunPipelineRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "runPipeline";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:runPipeline";

                /// <summary>Initializes RunPipeline parameter list.</summary>
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
                }
            }
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns NOT_FOUND error if the resource does not exist.
        /// Returns an empty policy if the resource exists but does not have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
        /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
        /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
        /// projects/{project_number}.
        /// </param>
        public virtual FetchAclRequest FetchAcl(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclRequest body, string resource)
        {
            return new FetchAclRequest(this.service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns NOT_FOUND error if the resource does not exist.
        /// Returns an empty policy if the resource exists but does not have a policy set.
        /// </summary>
        public class FetchAclRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclResponse>
        {
            /// <summary>Constructs a new FetchAcl request.</summary>
            public FetchAclRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
            /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
            /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
            /// projects/{project_number}.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1FetchAclRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "fetchAcl";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:fetchAcl";

            /// <summary>Initializes FetchAcl parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>Sets the access control policy for a resource. Replaces any existing policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
        /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
        /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
        /// projects/{project_number}.
        /// </param>
        public virtual SetAclRequest SetAcl(Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclRequest body, string resource)
        {
            return new SetAclRequest(this.service, body, resource);
        }

        /// <summary>Sets the access control policy for a resource. Replaces any existing policy.</summary>
        public class SetAclRequest : ContentwarehouseBaseServiceRequest<Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclResponse>
        {
            /// <summary>Constructs a new SetAcl request.</summary>
            public SetAclRequest(Google.Apis.Services.IClientService service, Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. REQUIRED: The resource for which the policy is being requested. Format for document:
            /// projects/{project_number}/locations/{location}/documents/{document_id}. Format for collection:
            /// projects/{project_number}/locations/{location}/collections/{collection_id}. Format for project:
            /// projects/{project_number}.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Contentwarehouse.v1.Data.GoogleCloudContentwarehouseV1SetAclRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setAcl";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:setAcl";

            /// <summary>Initializes SetAcl parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.Contentwarehouse.v1.Data
{
    /// <summary>The identity to configure a CloudSQL instance provisioned via SLM Terraform.</summary>
    public class CloudAiPlatformTenantresourceCloudSqlInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The CloudSQL instance connection name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstanceConnectionName")]
        public virtual string CloudSqlInstanceConnectionName { get; set; }

        /// <summary>
        /// Input/Output [Optional]. The CloudSQL instance name within SLM instance. If not set, a random UUIC will be
        /// generated as instance name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstanceName")]
        public virtual string CloudSqlInstanceName { get; set; }

        /// <summary>
        /// Input [Optional]. The KMS key name or the KMS grant name used for CMEK encryption. Only set this field when
        /// provisioning new CloudSQL instances. For existing CloudSQL instances, this field will be ignored because
        /// CMEK re-encryption is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyReference")]
        public virtual string KmsKeyReference { get; set; }

        /// <summary>Input [Optional]. MDB roles for corp access to CloudSQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mdbRolesForCorpAccess")]
        public virtual System.Collections.Generic.IList<string> MdbRolesForCorpAccess { get; set; }

        /// <summary>Output only. The SLM instance's full resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slmInstanceName")]
        public virtual string SlmInstanceName { get; set; }

        /// <summary>Input [Required]. The SLM instance template to provision CloudSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slmInstanceTemplate")]
        public virtual string SlmInstanceTemplate { get; set; }

        /// <summary>Input [Required]. The SLM instance type to provision CloudSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slmInstanceType")]
        public virtual string SlmInstanceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The identity to configure a GCS bucket.</summary>
    public class CloudAiPlatformTenantresourceGcsBucketConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("admins")]
        public virtual System.Collections.Generic.IList<string> Admins { get; set; }

        /// <summary>
        /// Input/Output [Optional]. The name of a GCS bucket with max length of 63 chars. If not set, a random UUID
        /// will be generated as bucket name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>
        /// Input/Output [Optional]. Only needed for per-entity tenant GCP resources. During Deprovision API, the
        /// on-demand deletion will only cover the tenant GCP resources with the specified entity name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityName")]
        public virtual string EntityName { get; set; }

        /// <summary>
        /// Input/Output [Optional]. The KMS key name or the KMS grant name used for CMEK encryption. Only set this
        /// field when provisioning new GCS bucket. For existing GCS bucket, this field will be ignored because CMEK
        /// re-encryption is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyReference")]
        public virtual string KmsKeyReference { get; set; }

        /// <summary>
        /// Input/Output [Optional]. Only needed when the content in bucket need to be garbage collected within some
        /// amount of days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttlDays")]
        public virtual System.Nullable<int> TtlDays { get; set; }

        /// <summary>Input/Output [Required]. IAM roles (viewer/admin) put on the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewers")]
        public virtual System.Collections.Generic.IList<string> Viewers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The dynamic IAM bindings to be granted after tenant projects are created.</summary>
    public class CloudAiPlatformTenantresourceIamPolicyBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input/Output [Required]. The member service accounts with the roles above. Note: placeholders are same as
        /// the resource above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Input/Output [Required]. The resource name that will be accessed by members, which also depends on
        /// resource_type. Note: placeholders are supported in resource names. For example, ${tpn} will be used when the
        /// tenant project number is not ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Input/Output [Required]. Specifies the type of resource that will be accessed by members.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Input/Output [Required]. The role for members below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for a spanner database provisioning. Next ID: 8</summary>
    public class CloudAiPlatformTenantresourceInfraSpannerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input [Optional]. The options to create a spanner database. Note: give the right options to ensure the right
        /// KMS key access audit logging and AxT logging in expected logging category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDatabaseOptions")]
        public virtual CloudAiPlatformTenantresourceInfraSpannerConfigCreateDatabaseOptions CreateDatabaseOptions { get; set; }

        /// <summary>
        /// Input [Optional]. The KMS key name or the KMS grant name used for CMEK encryption. Only set this field when
        /// provisioning new Infra Spanner databases. For existing Infra Spanner databases, this field will be ignored
        /// because CMEK re-encryption is not supported. For example, projects//locations//keyRings//cryptoKeys/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyReference")]
        public virtual string KmsKeyReference { get; set; }

        /// <summary>Input [Required]. The file path to the spanner SDL bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdlBundlePath")]
        public virtual string SdlBundlePath { get; set; }

        /// <summary>
        /// Input [Optional]. The spanner borg service account for delegating the kms key to. For example,
        /// spanner-infra-cmek-nonprod@system.gserviceaccount.com, for the nonprod universe.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spannerBorgServiceAccount")]
        public virtual string SpannerBorgServiceAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("spannerLocalNamePrefix")]
        public virtual string SpannerLocalNamePrefix { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("spannerNamespace")]
        public virtual string SpannerNamespace { get; set; }

        /// <summary>
        /// Input [Required]. Every database in Spanner can be identified by the following path name: /span//:
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spannerUniverse")]
        public virtual string SpannerUniverse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The options to create a spanner database. KMS key access audit logging and AxT logging will be associated with
    /// the given resource name, resource type and service name. Please ensure to give right options to enable correct
    /// audit logging and AxT logging.
    /// </summary>
    public class CloudAiPlatformTenantresourceInfraSpannerConfigCreateDatabaseOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cloud resource name for the CMEK encryption. For example, projects//locations/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekCloudResourceName")]
        public virtual string CmekCloudResourceName { get; set; }

        /// <summary>
        /// The cloud resource type for the CMEK encryption. For example, contentwarehouse.googleapis.com/Location
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekCloudResourceType")]
        public virtual string CmekCloudResourceType { get; set; }

        /// <summary>The service name for the CMEK encryption. For example, contentwarehouse.googleapis.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekServiceName")]
        public virtual string CmekServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The identity to configure a service account.</summary>
    public class CloudAiPlatformTenantresourceServiceAccountIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The service account email that has been created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Input/Output [Optional]. The tag that configures the service account, as defined in
        /// google3/configs/production/cdpush/acl-zanzibar-cloud-prod/activation_grants/activation_grants.gcl. Note: The
        /// default P4 service account has the empty tag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The identity to configure a tenant project.</summary>
    public class CloudAiPlatformTenantresourceTenantProjectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input/Output [Required]. The billing account properties to create the tenant project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingConfig")]
        public virtual GoogleApiServiceconsumermanagementV1BillingConfig BillingConfig { get; set; }

        /// <summary>
        /// Input/Output [Required]. The folder that holds tenant projects and folder-level permissions will be
        /// automatically granted to all tenant projects under the folder. Note: the valid folder format is
        /// `folders/{folder_number}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual string Folder { get; set; }

        /// <summary>
        /// Input/Output [Required]. The policy bindings that are applied to the tenant project during creation. At
        /// least one binding must have the role `roles/owner` with either `user` or `group` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyBindings")]
        public virtual System.Collections.Generic.IList<GoogleApiServiceconsumermanagementV1PolicyBinding> PolicyBindings { get; set; }

        /// <summary>
        /// Input/Output [Required]. The API services that are enabled on the tenant project during creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<string> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The tenant project and tenant resources. Next ID: 10</summary>
    public class CloudAiPlatformTenantresourceTenantProjectResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CloudSQL instances that are provisioned under the tenant project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstances")]
        public virtual System.Collections.Generic.IList<CloudAiPlatformTenantresourceCloudSqlInstanceConfig> CloudSqlInstances { get; set; }

        /// <summary>The GCS buckets that are provisioned under the tenant project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBuckets")]
        public virtual System.Collections.Generic.IList<CloudAiPlatformTenantresourceGcsBucketConfig> GcsBuckets { get; set; }

        /// <summary>
        /// The dynamic IAM bindings that are granted under the tenant project. Note: this should only add new bindings
        /// to the project if they don't exist and the existing bindings won't be affected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicyBindings")]
        public virtual System.Collections.Generic.IList<CloudAiPlatformTenantresourceIamPolicyBinding> IamPolicyBindings { get; set; }

        /// <summary>
        /// The Infra Spanner databases that are provisioned under the tenant project. Note: this is an experimental
        /// feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infraSpannerConfigs")]
        public virtual System.Collections.Generic.IList<CloudAiPlatformTenantresourceInfraSpannerConfig> InfraSpannerConfigs { get; set; }

        /// <summary>
        /// Input/Output [Required]. The tag that uniquely identifies a tenant project within a tenancy unit. Note: for
        /// the same tenant project tag, all tenant manager operations should be idempotent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The configurations of a tenant project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectConfig")]
        public virtual CloudAiPlatformTenantresourceTenantProjectConfig TenantProjectConfig { get; set; }

        /// <summary>Output only. The tenant project ID that has been created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectId")]
        public virtual string TenantProjectId { get; set; }

        /// <summary>Output only. The tenant project number that has been created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectNumber")]
        public virtual System.Nullable<long> TenantProjectNumber { get; set; }

        /// <summary>
        /// The service account identities (or enabled API service's P4SA) that are expclicitly created under the tenant
        /// project (before JIT provisioning during enabled API services).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantServiceAccounts")]
        public virtual System.Collections.Generic.IList<CloudAiPlatformTenantresourceTenantServiceAccountIdentity> TenantServiceAccounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of tenant resources.</summary>
    public class CloudAiPlatformTenantresourceTenantResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of P4 service accounts (go/p4sa) to provision or deprovision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p4ServiceAccounts")]
        public virtual System.Collections.Generic.IList<CloudAiPlatformTenantresourceServiceAccountIdentity> P4ServiceAccounts { get; set; }

        /// <summary>A list of tenant projects and tenant resources to provision or deprovision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectResources")]
        public virtual System.Collections.Generic.IList<CloudAiPlatformTenantresourceTenantProjectResource> TenantProjectResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The identity of service accounts that have been explicitly created under tenant projects.</summary>
    public class CloudAiPlatformTenantresourceTenantServiceAccountIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The email address of the generated service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Input/Output [Required]. The service that the service account belongs to. (e.g. cloudbuild.googleapis.com
        /// for GCB service accounts)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the billing configuration for a new tenant project.</summary>
    public class GoogleApiServiceconsumermanagementV1BillingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the billing account. For example `billingAccounts/012345-567890-ABCDEF`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccount")]
        public virtual string BillingAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Translates to IAM Policy bindings (without auditing at this level)</summary>
    public class GoogleApiServiceconsumermanagementV1PolicyBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Uses the same format as in IAM policy. `member` must include both a prefix and ID. For example,
        /// `user:{emailId}`, `serviceAccount:{emailId}`, `group:{emailId}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role. (https://cloud.google.com/iam/docs/understanding-roles) For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action responsible for access control list management operations.</summary>
    public class GoogleCloudContentwarehouseV1AccessControlAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the type of operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// Represents the new policy from which bindings are added, removed or replaced based on the type of the
        /// operation. the policy is limited to a few 10s of KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action triggered by Rule Engine when the rule is true.</summary>
    public class GoogleCloudContentwarehouseV1Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action triggering access control operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControl")]
        public virtual GoogleCloudContentwarehouseV1AccessControlAction AccessControl { get; set; }

        /// <summary>ID of the action. Managed internally.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>Action triggering create document link operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addToFolder")]
        public virtual GoogleCloudContentwarehouseV1AddToFolderAction AddToFolder { get; set; }

        /// <summary>Action triggering data update operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataUpdate")]
        public virtual GoogleCloudContentwarehouseV1DataUpdateAction DataUpdate { get; set; }

        /// <summary>Action triggering data validation operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataValidation")]
        public virtual GoogleCloudContentwarehouseV1DataValidationAction DataValidation { get; set; }

        /// <summary>Action deleting the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDocumentAction")]
        public virtual GoogleCloudContentwarehouseV1DeleteDocumentAction DeleteDocumentAction { get; set; }

        /// <summary>Action publish to Pub/Sub operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishToPubSub")]
        public virtual GoogleCloudContentwarehouseV1PublishAction PublishToPubSub { get; set; }

        /// <summary>Action removing a document from a folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeFromFolderAction")]
        public virtual GoogleCloudContentwarehouseV1RemoveFromFolderAction RemoveFromFolderAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the output of the Action Executor.</summary>
    public class GoogleCloudContentwarehouseV1ActionExecutorOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of rule and corresponding actions result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleActionsPairs")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1RuleActionsPair> RuleActionsPairs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of executing an action.</summary>
    public class GoogleCloudContentwarehouseV1ActionOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>State of an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionState")]
        public virtual string ActionState { get; set; }

        /// <summary>Action execution output message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputMessage")]
        public virtual string OutputMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action responsible for adding document under a folder.</summary>
    public class GoogleCloudContentwarehouseV1AddToFolderAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Names of the folder under which new document is to be added. Format:
        /// projects/{project_number}/locations/{location}/documents/{document_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request Option for processing Cloud AI Document in CW Document.</summary>
    public class GoogleCloudContentwarehouseV1CloudAIDocumentOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, only selected entities will be converted to properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customizedEntitiesPropertiesConversions")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomizedEntitiesPropertiesConversions { get; set; }

        /// <summary>Whether to convert all the entities to properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableEntitiesConversions")]
        public virtual System.Nullable<bool> EnableEntitiesConversions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentLinkService.CreateDocumentLink.</summary>
    public class GoogleCloudContentwarehouseV1CreateDocumentLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Document links associated with the source documents (source_document_id).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLink")]
        public virtual GoogleCloudContentwarehouseV1DocumentLink DocumentLink { get; set; }

        /// <summary>
        /// The meta information collected about the document creator, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata object for CreateDocument request (currently empty).</summary>
    public class GoogleCloudContentwarehouseV1CreateDocumentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.CreateDocument.</summary>
    public class GoogleCloudContentwarehouseV1CreateDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Request Option for processing Cloud AI Document in Document Warehouse. This field offers limited support for
        /// mapping entities from Cloud AI Document to Warehouse Document. Please consult with product team before using
        /// this field and other available options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAiDocumentOption")]
        public virtual GoogleCloudContentwarehouseV1CloudAIDocumentOption CloudAiDocumentOption { get; set; }

        /// <summary>
        /// Field mask for creating Document fields. If mask path is empty, it means all fields are masked. For the
        /// `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createMask")]
        public virtual object CreateMask { get; set; }

        /// <summary>Required. The document to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudContentwarehouseV1Document Document { get; set; }

        /// <summary>
        /// Default document policy during creation. This refers to an Identity and Access (IAM) policy, which specifies
        /// access controls for the Document. Conditions defined in the policy will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// The meta information collected about the end user, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentService.CreateDocument.</summary>
    public class GoogleCloudContentwarehouseV1CreateDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document created after executing create request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudContentwarehouseV1Document Document { get; set; }

        /// <summary>post-processing LROs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longRunningOperations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> LongRunningOperations { get; set; }

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudContentwarehouseV1ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Output from Rule Engine recording the rule evaluator and action executor's output. Refer format in:
        /// google/cloud/contentwarehouse/v1/rule_engine.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleEngineOutput")]
        public virtual GoogleCloudContentwarehouseV1RuleEngineOutput RuleEngineOutput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>To support the custom weighting across document schemas.</summary>
    public class GoogleCloudContentwarehouseV1CustomWeightsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of schema and property name. Allows a maximum of 10 schemas to be specified for relevance boosting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightedSchemaProperties")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1WeightedSchemaProperty> WeightedSchemaProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action responsible for properties update operations.</summary>
    public class GoogleCloudContentwarehouseV1DataUpdateAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map of (K, V) -&amp;gt; (valid name of the field, new value of the field) E.g., ("age", "60") entry triggers
        /// update of field age with a value of 60. If the field is not present then new entry is added. During update
        /// action execution, value strings will be casted to appropriate types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IDictionary<string, string> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action responsible for data validation operations.</summary>
    public class GoogleCloudContentwarehouseV1DataValidationAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map of (K, V) -&amp;gt; (field, string condition to be evaluated on the field) E.g., ("age", "age &amp;gt;
        /// 18 &amp;amp;&amp;amp; age &amp;lt; 60") entry triggers validation of field age with the given condition. Map
        /// entries will be ANDed during validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Conditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DateTime values.</summary>
    public class GoogleCloudContentwarehouseV1DateTimeArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of datetime values. Both OffsetDateTime and ZonedDateTime are supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleTypeDateTime> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for a date time property.</summary>
    public class GoogleCloudContentwarehouseV1DateTimeTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action responsible for deleting the document.</summary>
    public class GoogleCloudContentwarehouseV1DeleteDocumentAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Boolean field to select between hard vs soft delete options. Set 'true' for 'hard delete' and 'false' for
        /// 'soft delete'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHardDelete")]
        public virtual System.Nullable<bool> EnableHardDelete { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentLinkService.DeleteDocumentLink.</summary>
    public class GoogleCloudContentwarehouseV1DeleteDocumentLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The meta information collected about the document creator, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.DeleteDocument.</summary>
    public class GoogleCloudContentwarehouseV1DeleteDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The meta information collected about the end user, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the structure for content warehouse document proto.</summary>
    public class GoogleCloudContentwarehouseV1Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document AI format to save the structured content, including OCR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAiDocument")]
        public virtual GoogleCloudDocumentaiV1Document CloudAiDocument { get; set; }

        /// <summary>Indicates the category (image, audio, video etc.) of the original content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentCategory")]
        public virtual string ContentCategory { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the document is created.</summary>
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

        /// <summary>The user who creates the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>
        /// Required. Display name of the document given by the user. This name will be displayed in the UI. Customer
        /// can populate this field with the name of the document. This differs from the 'title' field as 'title' is
        /// optional and stores the top heading in the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Uri to display the document, for example, in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayUri")]
        public virtual string DisplayUri { get; set; }

        private string _dispositionTimeRaw;

        private object _dispositionTime;

        /// <summary>
        /// Output only. If linked to a Collection with RetentionPolicy, the date when the document becomes mutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dispositionTime")]
        public virtual string DispositionTimeRaw
        {
            get => _dispositionTimeRaw;
            set
            {
                _dispositionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dispositionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DispositionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DispositionTimeDateTimeOffset instead.")]
        public virtual object DispositionTime
        {
            get => _dispositionTime;
            set
            {
                _dispositionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dispositionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DispositionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DispositionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DispositionTimeRaw);
            set => DispositionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The Document schema name. Format:
        /// projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchemaName")]
        public virtual string DocumentSchemaName { get; set; }

        /// <summary>Raw document content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineRawDocument")]
        public virtual string InlineRawDocument { get; set; }

        /// <summary>Output only. Indicates if the document has a legal hold on it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legalHold")]
        public virtual System.Nullable<bool> LegalHold { get; set; }

        /// <summary>
        /// The resource name of the document. Format:
        /// projects/{project_number}/locations/{location}/documents/{document_id}. The name is ignored when creating a
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Other document format, such as PPTX, XLXS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plainText")]
        public virtual string PlainText { get; set; }

        /// <summary>List of values that are user supplied metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1Property> Properties { get; set; }

        /// <summary>
        /// This is used when DocAI was not used to load the document and parsing/ extracting is needed for the
        /// inline_raw_document. For example, if inline_raw_document is the byte representation of a PDF file, then this
        /// should be set to: RAW_DOCUMENT_FILE_TYPE_PDF.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawDocumentFileType")]
        public virtual string RawDocumentFileType { get; set; }

        /// <summary>Raw document file in Cloud Storage path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawDocumentPath")]
        public virtual string RawDocumentPath { get; set; }

        /// <summary>The reference ID set by customers. Must be unique per project and location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceId")]
        public virtual string ReferenceId { get; set; }

        /// <summary>If true, text extraction will not be performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textExtractionDisabled")]
        public virtual System.Nullable<bool> TextExtractionDisabled { get; set; }

        /// <summary>If true, text extraction will be performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textExtractionEnabled")]
        public virtual System.Nullable<bool> TextExtractionEnabled { get; set; }

        /// <summary>
        /// Title that describes the document. This can be the top heading or text that describes the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the document is last updated.</summary>
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

        /// <summary>The user who lastly updates the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updater")]
        public virtual string Updater { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document-link between source and target document.</summary>
    public class GoogleCloudContentwarehouseV1DocumentLink : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the documentLink is created.</summary>
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

        /// <summary>Description of this document-link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Name of this document-link. It is required that the parent derived form the name to be consistent with the
        /// source document reference. Otherwise an exception will be thrown. Format:
        /// projects/{project_number}/locations/{location}/documents/{source_document_id}/documentLinks/{document_link_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Document references of the source document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDocumentReference")]
        public virtual GoogleCloudContentwarehouseV1DocumentReference SourceDocumentReference { get; set; }

        /// <summary>
        /// The state of the documentlink. If target node has been deleted, the link is marked as invalid. Removing a
        /// source node will result in removal of all associated links.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Document references of the target document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetDocumentReference")]
        public virtual GoogleCloudContentwarehouseV1DocumentReference TargetDocumentReference { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the documentLink is last updated.</summary>
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

    public class GoogleCloudContentwarehouseV1DocumentQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This filter specifies a structured syntax to match against the [PropertyDefinition].is_filterable marked as
        /// `true`. The syntax for this expression is a subset of SQL syntax. Supported operators are: `=`, `!=`,
        /// `&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, and `&amp;gt;=` where the left of the operator is a property name and
        /// the right of the operator is a number or a quoted string. You must escape backslash (\\) and quote (\")
        /// characters. Supported functions are `LOWER([property_name])` to perform a case insensitive match and
        /// `EMPTY([property_name])` to filter on the existence of a key. Boolean expressions (AND/OR/NOT) are supported
        /// up to 3 levels of nesting (for example, "((A AND B AND C) OR NOT D) AND E"), a maximum of 100 comparisons or
        /// functions are allowed in the expression. The expression must be &amp;lt; 6000 bytes in length. Sample Query:
        /// `(LOWER(driving_license)="class \"a\"" OR EMPTY(driving_license)) AND driving_years &amp;gt; 10`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPropertyFilter")]
        public virtual string CustomPropertyFilter { get; set; }

        /// <summary>
        /// To support the custom weighting across document schemas, customers need to provide the properties to be used
        /// to boost the ranking in the search request. For a search query with CustomWeightsMetadata specified, only
        /// the RetrievalImportance for the properties in the CustomWeightsMetadata will be honored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customWeightsMetadata")]
        public virtual GoogleCloudContentwarehouseV1CustomWeightsMetadata CustomWeightsMetadata { get; set; }

        /// <summary>
        /// The exact creator(s) of the documents to search against. If a value isn't specified, documents within the
        /// search results are associated with any creator. If multiple values are specified, documents within the
        /// search results may be associated with any of the specified creators.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentCreatorFilter")]
        public virtual System.Collections.Generic.IList<string> DocumentCreatorFilter { get; set; }

        /// <summary>
        /// Search the documents in the list. Format:
        /// projects/{project_number}/locations/{location}/documents/{document_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentNameFilter")]
        public virtual System.Collections.Generic.IList<string> DocumentNameFilter { get; set; }

        /// <summary>
        /// This filter specifies the exact document schema Document.document_schema_name of the documents to search
        /// against. If a value isn't specified, documents within the search results are associated with any schema. If
        /// multiple values are specified, documents within the search results may be associated with any of the
        /// specified schemas. At most 20 document schema names are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchemaNames")]
        public virtual System.Collections.Generic.IList<string> DocumentSchemaNames { get; set; }

        /// <summary>
        /// This filter specifies the types of files to return: ALL, FOLDER, or FILE. If FOLDER or FILE is specified,
        /// then only either folders or files will be returned, respectively. If ALL is specified, both folders and
        /// files will be returned. If no value is specified, ALL files will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileTypeFilter")]
        public virtual GoogleCloudContentwarehouseV1FileTypeFilter FileTypeFilter { get; set; }

        /// <summary>
        /// Search all the documents under this specified folder. Format:
        /// projects/{project_number}/locations/{location}/documents/{document_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderNameFilter")]
        public virtual string FolderNameFilter { get; set; }

        /// <summary>
        /// Experimental, do not use. If the query is a natural language question. False by default. If true, then the
        /// question-answering feature will be used instead of search, and `result_count` in SearchDocumentsRequest must
        /// be set. In addition, all other input fields related to search (pagination, histograms, etc.) will be
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isNlQuery")]
        public virtual System.Nullable<bool> IsNlQuery { get; set; }

        /// <summary>
        /// This filter specifies a structured syntax to match against the PropertyDefinition.is_filterable marked as
        /// `true`. The relationship between the PropertyFilters is OR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyFilter")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1PropertyFilter> PropertyFilter { get; set; }

        /// <summary>
        /// The query string that matches against the full text of the document and the searchable properties. The query
        /// partially supports [Google AIP style syntax](https://google.aip.dev/160). Specifically, the query supports
        /// literals, logical operators, negation operators, comparison operators, and functions. Literals: A bare
        /// literal value (examples: "42", "Hugo") is a value to be matched against. It searches over the full text of
        /// the document and the searchable properties. Logical operators: "AND", "and", "OR", and "or" are binary
        /// logical operators (example: "engineer OR developer"). Negation operators: "NOT" and "!" are negation
        /// operators (example: "NOT software"). Comparison operators: support the binary comparison operators =, !=,
        /// &amp;lt;, &amp;gt;, &amp;lt;= and &amp;gt;= for string, numeric, enum, boolean. Also support like operator
        /// `~~` for string. It provides semantic search functionality by parsing, stemming and doing synonyms expansion
        /// against the input query. To specify a property in the query, the left hand side expression in the comparison
        /// must be the property ID including the parent. The right hand side must be literals. For example:
        /// "\"projects/123/locations/us\".property_a &amp;lt; 1" matches results whose "property_a" is less than 1 in
        /// project 123 and us location. The literals and comparison expression can be connected in a single query
        /// (example: "software engineer \"projects/123/locations/us\".salary &amp;gt; 100"). Functions: supported
        /// functions are `LOWER([property_name])` to perform a case insensitive match and `EMPTY([property_name])` to
        /// filter on the existence of a key. Support nested expressions connected using parenthesis and logical
        /// operators. The default logical operators is `AND` if there is no operators between expressions. The query
        /// can be used with other filters e.g. `time_filters` and `folder_name_filter`. They are connected with `AND`
        /// operator under the hood. The maximum number of allowed characters is 255.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// For custom synonyms. Customers provide the synonyms based on context. One customer can provide multiple set
        /// of synonyms based on different context. The search query will be expanded based on the custom synonyms of
        /// the query context set. By default, no custom synonyms wll be applied if no query context is provided. It is
        /// not supported for CMEK compliant deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryContext")]
        public virtual System.Collections.Generic.IList<string> QueryContext { get; set; }

        /// <summary>Documents created/updated within a range specified by this filter are searched against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeFilters")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1TimeFilter> TimeFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>References to the documents.</summary>
    public class GoogleCloudContentwarehouseV1DocumentReference : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the document is created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The time when the document is deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// display_name of the referenced document; this name does not need to be consistent to the display_name in the
        /// Document proto, depending on the ACL constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The document type of the document being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentIsFolder")]
        public virtual System.Nullable<bool> DocumentIsFolder { get; set; }

        /// <summary>Document is a folder with legal hold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentIsLegalHoldFolder")]
        public virtual System.Nullable<bool> DocumentIsLegalHoldFolder { get; set; }

        /// <summary>Document is a folder with retention policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentIsRetentionFolder")]
        public virtual System.Nullable<bool> DocumentIsRetentionFolder { get; set; }

        /// <summary>Required. Name of the referenced document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentName")]
        public virtual string DocumentName { get; set; }

        /// <summary>
        /// Stores the subset of the referenced document's content. This is useful to allow user peek the information of
        /// the referenced document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the document is last updated.</summary>
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

    /// <summary>A document schema used to define document structure.</summary>
    public class GoogleCloudContentwarehouseV1DocumentSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the document schema is created.</summary>
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

        /// <summary>Schema description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Name of the schema given by the user. Must be unique per project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Document Type, true refers the document is a folder, otherwise it is a typical document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentIsFolder")]
        public virtual System.Nullable<bool> DocumentIsFolder { get; set; }

        /// <summary>
        /// The resource name of the document schema. Format:
        /// projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}. The name is ignored
        /// when creating a document schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Document details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyDefinitions")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1PropertyDefinition> PropertyDefinitions { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the document schema is last updated.</summary>
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

    /// <summary>Enum values.</summary>
    public class GoogleCloudContentwarehouseV1EnumArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of enum values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for an enum/categorical property.</summary>
    public class GoogleCloudContentwarehouseV1EnumTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of possible enum values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("possibleValues")]
        public virtual System.Collections.Generic.IList<string> PossibleValues { get; set; }

        /// <summary>
        /// Make sure the Enum property value provided in the document is in the possile value list during document
        /// creation. The validation check runs by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationCheckDisabled")]
        public virtual System.Nullable<bool> ValidationCheckDisabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the string value of the enum field.</summary>
    public class GoogleCloudContentwarehouseV1EnumValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// String value of the enum field. This must match defined set of enums in document schema using
        /// EnumTypeOptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of exporting documents from the Document Warehouse to CDW pipeline.</summary>
    public class GoogleCloudContentwarehouseV1ExportToCdwPipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The CDW dataset resource name. This field is optional. If not set, the documents will be exported
        /// to Cloud Storage only. Format: projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docAiDataset")]
        public virtual string DocAiDataset { get; set; }

        /// <summary>
        /// The list of all the resource names of the documents to be processed. Format:
        /// projects/{project_number}/locations/{location}/documents/{document_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>
        /// The Cloud Storage folder path used to store the exported documents before being sent to CDW. Format:
        /// `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFolderPath")]
        public virtual string ExportFolderPath { get; set; }

        /// <summary>
        /// Ratio of training dataset split. When importing into Document AI Workbench, documents will be automatically
        /// split into training and test split category with the specified ratio. This field is required if
        /// doc_ai_dataset is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingSplitRatio")]
        public virtual System.Nullable<float> TrainingSplitRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.FetchAcl</summary>
    public class GoogleCloudContentwarehouseV1FetchAclRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For Get Project ACL only. Authorization check for end user will be ignored when project_owner=true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectOwner")]
        public virtual System.Nullable<bool> ProjectOwner { get; set; }

        /// <summary>
        /// The meta information collected about the end user, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentService.FetchAcl.</summary>
    public class GoogleCloudContentwarehouseV1FetchAclResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudContentwarehouseV1ResponseMetadata Metadata { get; set; }

        /// <summary>The IAM policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter for the specific types of documents returned.</summary>
    public class GoogleCloudContentwarehouseV1FileTypeFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of files to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Float values.</summary>
    public class GoogleCloudContentwarehouseV1FloatArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of float values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for a float property.</summary>
    public class GoogleCloudContentwarehouseV1FloatTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of the Cloud Storage Ingestion pipeline.</summary>
    public class GoogleCloudContentwarehouseV1GcsIngestPipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The input Cloud Storage folder. All files under this folder will be imported to Document Warehouse. Format:
        /// `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputPath")]
        public virtual string InputPath { get; set; }

        /// <summary>
        /// Optional. The config for the Cloud Storage Ingestion pipeline. It provides additional customization options
        /// to run the pipeline and can be skipped if it is not applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineConfig")]
        public virtual GoogleCloudContentwarehouseV1IngestPipelineConfig PipelineConfig { get; set; }

        /// <summary>
        /// The Doc AI processor type name. Only used when the format of ingested files is Doc AI Document proto format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorType")]
        public virtual string ProcessorType { get; set; }

        /// <summary>
        /// The Document Warehouse schema resource name. All documents processed by this pipeline will use this schema.
        /// Format: projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaName")]
        public virtual string SchemaName { get; set; }

        /// <summary>
        /// The flag whether to skip ingested documents. If it is set to true, documents in Cloud Storage contains key
        /// "status" with value "status=ingested" in custom metadata will be skipped to ingest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipIngestedDocuments")]
        public virtual System.Nullable<bool> SkipIngestedDocuments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of the Cloud Storage Ingestion with DocAI Processors pipeline.</summary>
    public class GoogleCloudContentwarehouseV1GcsIngestWithDocAiProcessorsPipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The extract processors information. One matched extract processor will be used to process documents based on
        /// the classify processor result. If no classify processor is specified, the first extract processor will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractProcessorInfos")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1ProcessorInfo> ExtractProcessorInfos { get; set; }

        /// <summary>
        /// The input Cloud Storage folder. All files under this folder will be imported to Document Warehouse. Format:
        /// `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputPath")]
        public virtual string InputPath { get; set; }

        /// <summary>
        /// Optional. The config for the Cloud Storage Ingestion with DocAI Processors pipeline. It provides additional
        /// customization options to run the pipeline and can be skipped if it is not applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineConfig")]
        public virtual GoogleCloudContentwarehouseV1IngestPipelineConfig PipelineConfig { get; set; }

        /// <summary>
        /// The Cloud Storage folder path used to store the raw results from processors. Format: `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorResultsFolderPath")]
        public virtual string ProcessorResultsFolderPath { get; set; }

        /// <summary>
        /// The flag whether to skip ingested documents. If it is set to true, documents in Cloud Storage contains key
        /// "status" with value "status=ingested" in custom metadata will be skipped to ingest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipIngestedDocuments")]
        public virtual System.Nullable<bool> SkipIngestedDocuments { get; set; }

        /// <summary>
        /// The split and classify processor information. The split and classify result will be used to find a matched
        /// extract processor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitClassifyProcessorInfo")]
        public virtual GoogleCloudContentwarehouseV1ProcessorInfo SplitClassifyProcessorInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.GetDocument.</summary>
    public class GoogleCloudContentwarehouseV1GetDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The meta information collected about the end user, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The histogram request.</summary>
    public class GoogleCloudContentwarehouseV1HistogramQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Filter the result of histogram query by the property names. It only works with histogram query
        /// count('FilterableProperties'). It is an optional. It will perform histogram on all the property names for
        /// all the document schemas. Setting this field will have a better performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual GoogleCloudContentwarehouseV1HistogramQueryPropertyNameFilter Filters { get; set; }

        /// <summary>
        /// An expression specifies a histogram request against matching documents for searches. See
        /// SearchDocumentsRequest.histogram_queries for details about syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQuery")]
        public virtual string HistogramQuery { get; set; }

        /// <summary>
        /// Controls if the histogram query requires the return of a precise count. Enable this flag may adversely
        /// impact performance. Defaults to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePreciseResultSize")]
        public virtual System.Nullable<bool> RequirePreciseResultSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudContentwarehouseV1HistogramQueryPropertyNameFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This filter specifies the exact document schema(s) Document.document_schema_name to run histogram query
        /// against. It is optional. It will perform histogram for property names for all the document schemas if it is
        /// not set. At most 10 document schema names are allowed. Format:
        /// projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchemas")]
        public virtual System.Collections.Generic.IList<string> DocumentSchemas { get; set; }

        /// <summary>
        /// It is optional. It will perform histogram for all the property names if it is not set. The properties need
        /// to be defined with the is_filterable flag set to true and the name of the property should be in the format:
        /// "schemaId.propertyName". The property needs to be defined in the schema. Example: the schema id is abc. Then
        /// the name of property for property MORTGAGE_TYPE will be "abc.MORTGAGE_TYPE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyNames")]
        public virtual System.Collections.Generic.IList<string> PropertyNames { get; set; }

        /// <summary>By default, the y_axis is HISTOGRAM_YAXIS_DOCUMENT if this field is not set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yAxis")]
        public virtual string YAxis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Histogram result that matches HistogramQuery specified in searches.</summary>
    public class GoogleCloudContentwarehouseV1HistogramQueryResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map from the values of the facet associated with distinct values to the number of matching entries with
        /// corresponding value. The key format is: * (for string histogram) string values stored in the field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogram")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Histogram { get; set; }

        /// <summary>Requested histogram expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQuery")]
        public virtual string HistogramQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ingestion pipeline config.</summary>
    public class GoogleCloudContentwarehouseV1IngestPipelineConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud Function resource name. The Cloud Function needs to live inside consumer project and is accessible
        /// to Document AI Warehouse P4SA. Only Cloud Functions V2 is supported. Cloud function execution should
        /// complete within 5 minutes or this file ingestion may fail due to timeout. Format:
        /// `https://{region}-{project_id}.cloudfunctions.net/{cloud_function}` The following keys are available the
        /// request json payload. * display_name * properties * plain_text * reference_id * document_schema_name *
        /// raw_document_path * raw_document_file_type The following keys from the cloud function json response payload
        /// will be ingested to the Document AI Warehouse as part of Document proto content and/or related information.
        /// The original values will be overridden if any key is present in the response. * display_name * properties *
        /// plain_text * document_acl_policy * folder
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudFunction")]
        public virtual string CloudFunction { get; set; }

        /// <summary>
        /// The document level acl policy config. This refers to an Identity and Access (IAM) policy, which specifies
        /// access controls for all documents ingested by the pipeline. The role and members under the policy needs to
        /// be specified. The following roles are supported for document level acl control: *
        /// roles/contentwarehouse.documentAdmin * roles/contentwarehouse.documentEditor *
        /// roles/contentwarehouse.documentViewer The following members are supported for document level acl control: *
        /// user:user-email@example.com * group:group-email@example.com Note that for documents searched with LLM, only
        /// single level user or group acl check is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentAclPolicy")]
        public virtual GoogleIamV1Policy DocumentAclPolicy { get; set; }

        /// <summary>
        /// The document text extraction enabled flag. If the flag is set to true, DWH will perform text extraction on
        /// the raw document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDocumentTextExtraction")]
        public virtual System.Nullable<bool> EnableDocumentTextExtraction { get; set; }

        /// <summary>
        /// Optional. The name of the folder to which all ingested documents will be linked during ingestion process.
        /// Format is `projects/{project}/locations/{location}/documents/{folder_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual string Folder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for projectService.InitializeProject</summary>
    public class GoogleCloudContentwarehouseV1InitializeProjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The access control mode for accessing the customer data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControlMode")]
        public virtual string AccessControlMode { get; set; }

        /// <summary>Required. The type of database used to store customer data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

        /// <summary>Optional. The default role for the person who create a document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentCreatorDefaultRole")]
        public virtual string DocumentCreatorDefaultRole { get; set; }

        /// <summary>Optional. Whether to enable CAL user email logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableCalUserEmailLogging")]
        public virtual System.Nullable<bool> EnableCalUserEmailLogging { get; set; }

        /// <summary>
        /// Optional. The KMS key used for CMEK encryption. It is required that the kms key is in the same region as the
        /// endpoint. The same key will be used for all provisioned resources, if encryption is available. If the
        /// kms_key is left empty, no encryption will be enforced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for projectService.InitializeProject</summary>
    public class GoogleCloudContentwarehouseV1InitializeProjectResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message of the project initialization process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The state of the project initialization process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Integer values.</summary>
    public class GoogleCloudContentwarehouseV1IntegerArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of integer values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for an integer property.</summary>
    public class GoogleCloudContentwarehouseV1IntegerTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A triggered rule that failed the validation check(s) after parsing.</summary>
    public class GoogleCloudContentwarehouseV1InvalidRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Validation error on a parsed expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>Triggered rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual GoogleCloudContentwarehouseV1Rule Rule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentSchemaService.ListDocumentSchemas.</summary>
    public class GoogleCloudContentwarehouseV1ListDocumentSchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document schemas from the specified parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchemas")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1DocumentSchema> DocumentSchemas { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentLinkService.ListLinkedSources.</summary>
    public class GoogleCloudContentwarehouseV1ListLinkedSourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of document-links to return. The service may return fewer than this value. If
        /// unspecified, at most 50 document-links will be returned. The maximum value is 1000; values above 1000 will
        /// be coerced to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous `ListLinkedSources` call. Provide this to retrieve the subsequent
        /// page. When paginating, all other parameters provided to `ListLinkedSources` must match the call that
        /// provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// The meta information collected about the document creator, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentLinkService.ListLinkedSources.</summary>
    public class GoogleCloudContentwarehouseV1ListLinkedSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source document-links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLinks")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1DocumentLink> DocumentLinks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentLinkService.ListLinkedTargets.</summary>
    public class GoogleCloudContentwarehouseV1ListLinkedTargetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The meta information collected about the document creator, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentLinkService.ListLinkedTargets.</summary>
    public class GoogleCloudContentwarehouseV1ListLinkedTargetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target document-links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLinks")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1DocumentLink> DocumentLinks { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RuleSetService.ListRuleSets.</summary>
    public class GoogleCloudContentwarehouseV1ListRuleSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The rule sets from the specified parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleSets")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1RuleSet> RuleSets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SynonymSetService.ListSynonymSets.</summary>
    public class GoogleCloudContentwarehouseV1ListSynonymSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A page token, received from a previous `ListSynonymSets` call. Provide this to retrieve the subsequent page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The synonymSets from the specified parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonymSets")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1SynonymSet> SynonymSets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.LockDocument.</summary>
    public class GoogleCloudContentwarehouseV1LockDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection the document connects to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionId")]
        public virtual string CollectionId { get; set; }

        /// <summary>The user information who locks the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockingUser")]
        public virtual GoogleCloudContentwarehouseV1UserInfo LockingUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Map property value. Represents a structured entries of key value pairs, consisting of field names which map to
    /// dynamically typed values.
    /// </summary>
    public class GoogleCloudContentwarehouseV1MapProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unordered map of dynamically typed values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudContentwarehouseV1Value> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for a Map property.</summary>
    public class GoogleCloudContentwarehouseV1MapTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for merging updated fields.</summary>
    public class GoogleCloudContentwarehouseV1MergeFieldsOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When merging message fields, the default behavior is to merge the content of two message fields together. If
        /// you instead want to use the field from the source message to replace the corresponding field in the
        /// destination message, set this flag to true. When this flag is set, specified submessage fields that are
        /// missing in source will be cleared in destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceMessageFields")]
        public virtual System.Nullable<bool> ReplaceMessageFields { get; set; }

        /// <summary>
        /// When merging repeated fields, the default behavior is to append entries from the source repeated field to
        /// the destination repeated field. If you instead want to keep only the entries from the source repeated field,
        /// set this flag to true. If you want to replace a repeated field within a message field on the destination
        /// message, you must set both replace_repeated_fields and replace_message_fields to true, otherwise the
        /// repeated fields will be appended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceRepeatedFields")]
        public virtual System.Nullable<bool> ReplaceRepeatedFields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration of processing documents in Document Warehouse with DocAi processors pipeline.
    /// </summary>
    public class GoogleCloudContentwarehouseV1ProcessWithDocAiPipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of all the resource names of the documents to be processed. Format:
        /// projects/{project_number}/locations/{location}/documents/{document_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>
        /// The Cloud Storage folder path used to store the exported documents before being sent to CDW. Format:
        /// `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFolderPath")]
        public virtual string ExportFolderPath { get; set; }

        /// <summary>The CDW processor information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorInfo")]
        public virtual GoogleCloudContentwarehouseV1ProcessorInfo ProcessorInfo { get; set; }

        /// <summary>
        /// The Cloud Storage folder path used to store the raw results from processors. Format: `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorResultsFolderPath")]
        public virtual string ProcessorResultsFolderPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The DocAI processor information.</summary>
    public class GoogleCloudContentwarehouseV1ProcessorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The processor will process the documents with this document type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentType")]
        public virtual string DocumentType { get; set; }

        /// <summary>
        /// The processor resource name. Format is `projects/{project}/locations/{location}/processors/{processor}`, or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorName")]
        public virtual string ProcessorName { get; set; }

        /// <summary>
        /// The Document schema resource name. All documents processed by this processor will use this schema. Format:
        /// projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaName")]
        public virtual string SchemaName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of a project, including the project state, dbType, aclMode and etc.</summary>
    public class GoogleCloudContentwarehouseV1ProjectStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access control mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControlMode")]
        public virtual string AccessControlMode { get; set; }

        /// <summary>Database type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

        /// <summary>The default role for the person who create a document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentCreatorDefaultRole")]
        public virtual string DocumentCreatorDefaultRole { get; set; }

        /// <summary>The location of the queried project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>If the qa is enabled on this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qaEnabled")]
        public virtual System.Nullable<bool> QaEnabled { get; set; }

        /// <summary>State of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Property of a document.</summary>
    public class GoogleCloudContentwarehouseV1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date time property values. It is not supported by CMEK compliant deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimeValues")]
        public virtual GoogleCloudContentwarehouseV1DateTimeArray DateTimeValues { get; set; }

        /// <summary>Enum property values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValues")]
        public virtual GoogleCloudContentwarehouseV1EnumArray EnumValues { get; set; }

        /// <summary>Float property values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValues")]
        public virtual GoogleCloudContentwarehouseV1FloatArray FloatValues { get; set; }

        /// <summary>Integer property values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValues")]
        public virtual GoogleCloudContentwarehouseV1IntegerArray IntegerValues { get; set; }

        /// <summary>Map property values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapProperty")]
        public virtual GoogleCloudContentwarehouseV1MapProperty MapProperty { get; set; }

        /// <summary>Required. Must match the name of a PropertyDefinition in the DocumentSchema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nested structured data property values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyValues")]
        public virtual GoogleCloudContentwarehouseV1PropertyArray PropertyValues { get; set; }

        /// <summary>String/text property values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textValues")]
        public virtual GoogleCloudContentwarehouseV1TextArray TextValues { get; set; }

        /// <summary>Timestamp property values. It is not supported by CMEK compliant deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValues")]
        public virtual GoogleCloudContentwarehouseV1TimestampArray TimestampValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Property values.</summary>
    public class GoogleCloudContentwarehouseV1PropertyArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of property values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1Property> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the metadata for a schema property.</summary>
    public class GoogleCloudContentwarehouseV1PropertyDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date time property. It is not supported by CMEK compliant deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimeTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1DateTimeTypeOptions DateTimeTypeOptions { get; set; }

        /// <summary>The display-name for the property, used for front-end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Enum/categorical property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1EnumTypeOptions EnumTypeOptions { get; set; }

        /// <summary>Float property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1FloatTypeOptions FloatTypeOptions { get; set; }

        /// <summary>Integer property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1IntegerTypeOptions IntegerTypeOptions { get; set; }

        /// <summary>
        /// Whether the property can be filtered. If this is a sub-property, all the parent properties must be marked
        /// filterable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFilterable")]
        public virtual System.Nullable<bool> IsFilterable { get; set; }

        /// <summary>
        /// Whether the property is user supplied metadata. This out-of-the box placeholder setting can be used to tag
        /// derived properties. Its value and interpretation logic should be implemented by API user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMetadata")]
        public virtual System.Nullable<bool> IsMetadata { get; set; }

        /// <summary>Whether the property can have multiple values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRepeatable")]
        public virtual System.Nullable<bool> IsRepeatable { get; set; }

        /// <summary>
        /// Whether the property is mandatory. Default is 'false', i.e. populating property value can be skipped. If
        /// 'true' then user must populate the value for this property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRequired")]
        public virtual System.Nullable<bool> IsRequired { get; set; }

        /// <summary>Indicates that the property should be included in a global search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSearchable")]
        public virtual System.Nullable<bool> IsSearchable { get; set; }

        /// <summary>Map property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1MapTypeOptions MapTypeOptions { get; set; }

        /// <summary>
        /// Required. The name of the metadata property. Must be unique within a document schema and is case
        /// insensitive. Names must be non-blank, start with a letter, and can contain alphanumeric characters and: /,
        /// :, -, _, and .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nested structured data property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1PropertyTypeOptions PropertyTypeOptions { get; set; }

        /// <summary>The retrieval importance of the property during search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalImportance")]
        public virtual string RetrievalImportance { get; set; }

        /// <summary>The mapping information between this property to another schema source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaSources")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1PropertyDefinitionSchemaSource> SchemaSources { get; set; }

        /// <summary>Text/string property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1TextTypeOptions TextTypeOptions { get; set; }

        /// <summary>Timestamp property. It is not supported by CMEK compliant deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampTypeOptions")]
        public virtual GoogleCloudContentwarehouseV1TimestampTypeOptions TimestampTypeOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The schema source information.</summary>
    public class GoogleCloudContentwarehouseV1PropertyDefinitionSchemaSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The schema name in the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The Doc AI processor type name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorType")]
        public virtual string ProcessorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudContentwarehouseV1PropertyFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The filter condition. The syntax for this expression is a subset of SQL syntax. Supported operators are:
        /// `=`, `!=`, `&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`, and `~~` where the left of the operator is a
        /// property name and the right of the operator is a number or a quoted string. You must escape backslash (\\)
        /// and quote (\") characters. `~~` is the LIKE operator. The right of the operator must be a string. The only
        /// supported property data type for LIKE is text_values. It provides semantic search functionality by parsing,
        /// stemming and doing synonyms expansion against the input query. It matches if the property contains semantic
        /// similar content to the query. It is not regex matching or wildcard matching. For example, "property.company
        /// ~~ \"google\"" will match records whose property `property.compnay` have values like "Google Inc.", "Google
        /// LLC" or "Google Company". Supported functions are `LOWER([property_name])` to perform a case insensitive
        /// match and `EMPTY([property_name])` to filter on the existence of a key. Boolean expressions (AND/OR/NOT) are
        /// supported up to 3 levels of nesting (for example, "((A AND B AND C) OR NOT D) AND E"), a maximum of 100
        /// comparisons or functions are allowed in the expression. The expression must be &amp;lt; 6000 bytes in
        /// length. Only properties that are marked filterable are allowed (PropertyDefinition.is_filterable). Property
        /// names do not need to be prefixed by the document schema id (as is the case with histograms), however
        /// property names will need to be prefixed by its parent hierarchy, if any. For example:
        /// top_property_name.sub_property_name. Sample Query: `(LOWER(driving_license)="class \"a\"" OR
        /// EMPTY(driving_license)) AND driving_years &amp;gt; 10` CMEK compliant deployment only supports: * Operators:
        /// `=`, `&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, and `&amp;gt;=`. * Boolean expressions: AND and OR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// The Document schema name Document.document_schema_name. Format:
        /// projects/{project_number}/locations/{location}/documentSchemas/{document_schema_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchemaName")]
        public virtual string DocumentSchemaName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for a nested structured data property.</summary>
    public class GoogleCloudContentwarehouseV1PropertyTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of property definitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyDefinitions")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1PropertyDefinition> PropertyDefinitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action responsible for publishing messages to a Pub/Sub topic.</summary>
    public class GoogleCloudContentwarehouseV1PublishAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Messages to be published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<string> Messages { get; set; }

        /// <summary>The topic id in the Pub/Sub service for which messages will be published to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicId")]
        public virtual string TopicId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional result info for the question-answering feature.</summary>
    public class GoogleCloudContentwarehouseV1QAResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The calibrated confidence score for this document, in the range [0., 1.]. This represents the confidence
        /// level for whether the returned document and snippet answers the user's query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidenceScore")]
        public virtual System.Nullable<float> ConfidenceScore { get; set; }

        /// <summary>Highlighted sections in the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highlights")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1QAResultHighlight> Highlights { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text span in the search text snippet that represents a highlighted section (answer context, highly relevant
    /// sentence, etc.).
    /// </summary>
    public class GoogleCloudContentwarehouseV1QAResultHighlight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End index of the highlight, exclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>Start index of the highlight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the action responsible for remove a document from a specific folder.</summary>
    public class GoogleCloudContentwarehouseV1RemoveFromFolderAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Condition of the action to be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// Name of the folder under which new document is to be added. Format:
        /// projects/{project_number}/locations/{location}/documents/{document_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual string Folder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Meta information is used to improve the performance of the service.</summary>
    public class GoogleCloudContentwarehouseV1RequestMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Provides user unique identification and groups information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudContentwarehouseV1UserInfo UserInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information returned to client, such as debugging information.</summary>
    public class GoogleCloudContentwarehouseV1ResponseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique id associated with this call. This id is logged for tracking purpose.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the rule for a content warehouse trigger.</summary>
    public class GoogleCloudContentwarehouseV1Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of actions that are executed when the rule is satisfied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1Action> Actions { get; set; }

        /// <summary>
        /// Represents the conditional expression to be evaluated. Expression should evaluate to a boolean result. When
        /// the condition is true actions are executed. Example: user_role = "hsbc_role_1" AND doc.salary &amp;gt; 20000
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>Short description of the rule and its context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>ID of the rule. It has to be unique across all the examples. This is managed internally.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>Identifies the trigger type for running the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerType")]
        public virtual string TriggerType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a rule and outputs of associated actions.</summary>
    public class GoogleCloudContentwarehouseV1RuleActionsPair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Outputs of executing the actions associated with the above rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionOutputs")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1ActionOutput> ActionOutputs { get; set; }

        /// <summary>Represents the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual GoogleCloudContentwarehouseV1Rule Rule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Records the output of Rule Engine including rule evaluation and actions result.</summary>
    public class GoogleCloudContentwarehouseV1RuleEngineOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output from Action Executor containing rule and corresponding actions execution result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionExecutorOutput")]
        public virtual GoogleCloudContentwarehouseV1ActionExecutorOutput ActionExecutorOutput { get; set; }

        /// <summary>Name of the document against which the rules and actions were evaluated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentName")]
        public virtual string DocumentName { get; set; }

        /// <summary>Output from Rule Evaluator containing matched, unmatched and invalid rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleEvaluatorOutput")]
        public virtual GoogleCloudContentwarehouseV1RuleEvaluatorOutput RuleEvaluatorOutput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the output of the Rule Evaluator.</summary>
    public class GoogleCloudContentwarehouseV1RuleEvaluatorOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of triggered rules that failed the validation check(s) after parsing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1InvalidRule> InvalidRules { get; set; }

        /// <summary>A subset of triggered rules that are evaluated true for a given request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1Rule> MatchedRules { get; set; }

        /// <summary>List of rules fetched from database for the given request trigger type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggeredRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1Rule> TriggeredRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a set of rules from a single customer.</summary>
    public class GoogleCloudContentwarehouseV1RuleSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Short description of the rule-set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The resource name of the rule set. Managed internally. Format:
        /// projects/{project_number}/locations/{location}/ruleSet/{rule_set_id}. The name is ignored when creating a
        /// rule set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of rules given by the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1Rule> Rules { get; set; }

        /// <summary>Source of the rules i.e., customer name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata message of RunPipeline method.</summary>
    public class GoogleCloudContentwarehouseV1RunPipelineMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pipeline metadata for Export-to-CDW pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportToCdwPipelineMetadata")]
        public virtual GoogleCloudContentwarehouseV1RunPipelineMetadataExportToCdwPipelineMetadata ExportToCdwPipelineMetadata { get; set; }

        /// <summary>Number of files that have failed at some point in the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedFileCount")]
        public virtual System.Nullable<int> FailedFileCount { get; set; }

        /// <summary>The pipeline metadata for GcsIngest pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsIngestPipelineMetadata")]
        public virtual GoogleCloudContentwarehouseV1RunPipelineMetadataGcsIngestPipelineMetadata GcsIngestPipelineMetadata { get; set; }

        /// <summary>The list of response details of each document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualDocumentStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1RunPipelineMetadataIndividualDocumentStatus> IndividualDocumentStatuses { get; set; }

        /// <summary>The pipeline metadata for Process-with-DocAi pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processWithDocAiPipelineMetadata")]
        public virtual GoogleCloudContentwarehouseV1RunPipelineMetadataProcessWithDocAiPipelineMetadata ProcessWithDocAiPipelineMetadata { get; set; }

        /// <summary>Number of files that were processed by the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalFileCount")]
        public virtual System.Nullable<int> TotalFileCount { get; set; }

        /// <summary>User unique identification and groups information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudContentwarehouseV1UserInfo UserInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata message for Export-to-CDW pipeline.</summary>
    public class GoogleCloudContentwarehouseV1RunPipelineMetadataExportToCdwPipelineMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output CDW dataset resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docAiDataset")]
        public virtual string DocAiDataset { get; set; }

        /// <summary>The input list of all the resource names of the documents to be exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>The output Cloud Storage folder in this pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputPath")]
        public virtual string OutputPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata message for GcsIngest pipeline.</summary>
    public class GoogleCloudContentwarehouseV1RunPipelineMetadataGcsIngestPipelineMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The input Cloud Storage folder in this pipeline. Format: `gs:///`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputPath")]
        public virtual string InputPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of processing a document.</summary>
    public class GoogleCloudContentwarehouseV1RunPipelineMetadataIndividualDocumentStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document identifier of an existing document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>The status processing the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata message for Process-with-DocAi pipeline.</summary>
    public class GoogleCloudContentwarehouseV1RunPipelineMetadataProcessWithDocAiPipelineMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The input list of all the resource names of the documents to be processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>The DocAI processor to process the documents with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processorInfo")]
        public virtual GoogleCloudContentwarehouseV1ProcessorInfo ProcessorInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.RunPipeline.</summary>
    public class GoogleCloudContentwarehouseV1RunPipelineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Export docuemnts from Document Warehouse to CDW for training purpose.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportCdwPipeline")]
        public virtual GoogleCloudContentwarehouseV1ExportToCdwPipeline ExportCdwPipeline { get; set; }

        /// <summary>Cloud Storage ingestion pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsIngestPipeline")]
        public virtual GoogleCloudContentwarehouseV1GcsIngestPipeline GcsIngestPipeline { get; set; }

        /// <summary>
        /// Use DocAI processors to process documents in Cloud Storage and ingest them to Document Warehouse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsIngestWithDocAiProcessorsPipeline")]
        public virtual GoogleCloudContentwarehouseV1GcsIngestWithDocAiProcessorsPipeline GcsIngestWithDocAiProcessorsPipeline { get; set; }

        /// <summary>
        /// Use a DocAI processor to process documents in Document Warehouse, and re-ingest the updated results into
        /// Document Warehouse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processWithDocAiPipeline")]
        public virtual GoogleCloudContentwarehouseV1ProcessWithDocAiPipeline ProcessWithDocAiPipeline { get; set; }

        /// <summary>
        /// The meta information collected about the end user, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.SearchDocuments.</summary>
    public class GoogleCloudContentwarehouseV1SearchDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Query used to search against documents (keyword, filters, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentQuery")]
        public virtual GoogleCloudContentwarehouseV1DocumentQuery DocumentQuery { get; set; }

        /// <summary>
        /// An expression specifying a histogram request against matching documents. Expression syntax is an aggregation
        /// function call with histogram facets and other options. The following aggregation functions are supported: *
        /// `count(string_histogram_facet)`: Count the number of matching entities for each distinct attribute value.
        /// Data types: * Histogram facet (aka filterable properties): Facet names with format &amp;lt;schema
        /// id&amp;gt;.&amp;lt;facet&amp;gt;. Facets will have the format of: `a-zA-Z`. If the facet is a child facet,
        /// then the parent hierarchy needs to be specified separated by dots in the prefix after the schema id. Thus,
        /// the format for a multi- level facet is: &amp;lt;schema id&amp;gt;.&amp;lt;parent facet name&amp;gt;.
        /// &amp;lt;child facet name&amp;gt;. Example: schema123.root_parent_facet.middle_facet.child_facet *
        /// DocumentSchemaId: (with no schema id prefix) to get histograms for each document type (returns the schema id
        /// path, e.g. projects/12345/locations/us-west/documentSchemas/abc123). Example expression: * Document type
        /// counts: count('DocumentSchemaId') * For schema id, abc123, get the counts for MORTGAGE_TYPE:
        /// count('abc123.MORTGAGE_TYPE')
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQueries")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1HistogramQuery> HistogramQueries { get; set; }

        /// <summary>
        /// An integer that specifies the current offset (that is, starting result location, amongst the documents
        /// deemed by the API as relevant) in search results. This field is only considered if page_token is unset. The
        /// maximum allowed value is 5000. Otherwise an error is thrown. For example, 0 means to return results starting
        /// from the first matching document, and 10 means to return from the 11th document. This can be used for
        /// pagination, (for example, pageSize = 10 and offset = 10 means to return from the second page).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The criteria determining how search results are sorted. For non-empty query, default is `"relevance desc"`.
        /// For empty query, default is `"upload_date desc"`. Supported options are: * `"relevance desc"`: By relevance
        /// descending, as determined by the API algorithms. * `"upload_date desc"`: By upload date descending. *
        /// `"upload_date"`: By upload date ascending. * `"update_date desc"`: By last updated date descending. *
        /// `"update_date"`: By last updated date ascending. * `"retrieval_importance desc"`: By retrieval importance of
        /// properties descending. This feature is still under development, please do not use unless otherwise
        /// instructed to do so.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// A limit on the number of documents returned in the search results. Increasing this value above the default
        /// value of 10 can increase search response time. The value can be between 1 and 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The token specifying the current offset within search results. See SearchDocumentsResponse.next_page_token
        /// for an explanation of how to obtain the next set of query results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Experimental, do not use. The limit on the number of documents returned for the question-answering feature.
        /// To enable the question-answering feature, set [DocumentQuery].is_nl_query to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qaSizeLimit")]
        public virtual System.Nullable<int> QaSizeLimit { get; set; }

        /// <summary>
        /// The meta information collected about the end user, used to enforce access control and improve the search
        /// quality of the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>
        /// Controls if the search document request requires the return of a total size of matched documents. See
        /// SearchDocumentsResponse.total_size. Enabling this flag may adversely impact performance. Hint: If this is
        /// used with pagination, set this flag on the initial query but set this to false on subsequent page calls
        /// (keep the total count locally). Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireTotalSize")]
        public virtual System.Nullable<bool> RequireTotalSize { get; set; }

        /// <summary>
        /// Controls if the search document request requires the return of a total size of matched documents. See
        /// SearchDocumentsResponse.total_size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResultSize")]
        public virtual string TotalResultSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentService.SearchDocuments.</summary>
    public class GoogleCloudContentwarehouseV1SearchDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The histogram results that match with the specified SearchDocumentsRequest.histogram_queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramQueryResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1HistogramQueryResult> HistogramQueryResults { get; set; }

        /// <summary>The document entities that match the specified SearchDocumentsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingDocuments")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1SearchDocumentsResponseMatchingDocument> MatchingDocuments { get; set; }

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudContentwarehouseV1ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// The token that specifies the starting position of the next page of results. This field is empty if there are
        /// no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Experimental. Question answer from the query against the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionAnswer")]
        public virtual string QuestionAnswer { get; set; }

        /// <summary>
        /// The total number of matched documents which is available only if the client set
        /// SearchDocumentsRequest.require_total_size to `true` or set SearchDocumentsRequest.total_result_size to
        /// `ESTIMATED_SIZE` or `ACTUAL_SIZE`. Otherwise, the value will be `-1`. Typically a UI would handle this
        /// condition by displaying "of many", for example: "Displaying 10 of many".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Document entry with metadata inside SearchDocumentsResponse</summary>
    public class GoogleCloudContentwarehouseV1SearchDocumentsResponseMatchingDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Document that matches the specified SearchDocumentsRequest. This document only contains indexed metadata
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudContentwarehouseV1Document Document { get; set; }

        /// <summary>Return the 1-based page indices where those pages have one or more matched tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedTokenPageIndices")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MatchedTokenPageIndices { get; set; }

        /// <summary>Experimental. Additional result info if the question-answering feature is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qaResult")]
        public virtual GoogleCloudContentwarehouseV1QAResult QaResult { get; set; }

        /// <summary>
        /// Contains snippets of text from the document full raw text that most closely match a search query's keywords,
        /// if available. All HTML tags in the original fields are stripped when returned in this field, and matching
        /// query keywords are enclosed in HTML bold tags. If the question-answering feature is enabled, this field will
        /// instead contain a snippet that answers the user's natural-language query. No HTML bold tags will be present,
        /// and highlights in the answer snippet can be found in QAResult.highlights.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchTextSnippet")]
        public virtual string SearchTextSnippet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.SetAcl.</summary>
    public class GoogleCloudContentwarehouseV1SetAclRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited
        /// to a few 10s of KB. This refers to an Identity and Access (IAM) policy, which specifies access controls for
        /// the Document. You can set ACL with condition for projects only. Supported operators are: `=`, `!=`,
        /// `&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, and `&amp;gt;=` where the left of the operator is `DocumentSchemaId` or
        /// property name and the right of the operator is a number or a quoted string. You must escape backslash (\\)
        /// and quote (\") characters. Boolean expressions (AND/OR) are supported up to 3 levels of nesting (for
        /// example, "((A AND B AND C) OR D) AND E"), a maximum of 10 comparisons are allowed in the expression. The
        /// expression must be &amp;lt; 6000 bytes in length. Sample condition: `"DocumentSchemaId = \"some schema id\"
        /// OR SchemaId.floatPropertyName &amp;gt;= 10"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// For Set Project ACL only. Authorization check for end user will be ignored when project_owner=true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectOwner")]
        public virtual System.Nullable<bool> ProjectOwner { get; set; }

        /// <summary>
        /// The meta information collected about the end user, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentService.SetAcl.</summary>
    public class GoogleCloudContentwarehouseV1SetAclResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudContentwarehouseV1ResponseMetadata Metadata { get; set; }

        /// <summary>The policy will be attached to a resource (e.g. projecct, document).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a list of synonyms for a given context. For example a context "sales" could contain: Synonym 1: sale,
    /// invoice, bill, order Synonym 2: money, credit, finance, payment Synonym 3: shipping, freight, transport Each
    /// SynonymSets should be disjoint
    /// </summary>
    public class GoogleCloudContentwarehouseV1SynonymSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is a freeform field. Example contexts can be "sales," "engineering," "real estate," "accounting," etc.
        /// The context can be supplied during search requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual string Context { get; set; }

        /// <summary>
        /// The resource name of the SynonymSet This is mandatory for google.api.resource. Format:
        /// projects/{project_number}/locations/{location}/synonymSets/{context}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of Synonyms for the context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1SynonymSetSynonym> Synonyms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a list of words given by the customer All these words are synonyms of each other.</summary>
    public class GoogleCloudContentwarehouseV1SynonymSetSynonym : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For example: sale, invoice, bill, order</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>String/text values.</summary>
    public class GoogleCloudContentwarehouseV1TextArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of text values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for a text property.</summary>
    public class GoogleCloudContentwarehouseV1TextTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter on create timestamp or update timestamp of documents.</summary>
    public class GoogleCloudContentwarehouseV1TimeFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which time field to filter documents on. Defaults to TimeField.UPLOAD_TIME.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeField")]
        public virtual string TimeField { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timeRange")]
        public virtual GoogleTypeInterval TimeRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Timestamp values.</summary>
    public class GoogleCloudContentwarehouseV1TimestampArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of timestamp values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleCloudContentwarehouseV1TimestampValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for a timestamp property.</summary>
    public class GoogleCloudContentwarehouseV1TimestampTypeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Timestamp value type.</summary>
    public class GoogleCloudContentwarehouseV1TimestampValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The string must represent a valid instant in UTC and is parsed using
        /// java.time.format.DateTimeFormatter.ISO_INSTANT. e.g. "2013-09-29T18:46:19Z"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textValue")]
        public virtual string TextValue { get; set; }

        private string _timestampValueRaw;

        private object _timestampValue;

        /// <summary>Timestamp value</summary>
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

    /// <summary>Metadata object for UpdateDocument request (currently empty).</summary>
    public class GoogleCloudContentwarehouseV1UpdateDocumentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentService.UpdateDocument.</summary>
    public class GoogleCloudContentwarehouseV1UpdateDocumentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Request Option for processing Cloud AI Document in Document Warehouse. This field offers limited support for
        /// mapping entities from Cloud AI Document to Warehouse Document. Please consult with product team before using
        /// this field and other available options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAiDocumentOption")]
        public virtual GoogleCloudContentwarehouseV1CloudAIDocumentOption CloudAiDocumentOption { get; set; }

        /// <summary>Required. The document to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudContentwarehouseV1Document Document { get; set; }

        /// <summary>
        /// The meta information collected about the end user, used to enforce access control for the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual GoogleCloudContentwarehouseV1RequestMetadata RequestMetadata { get; set; }

        /// <summary>Options for the update operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateOptions")]
        public virtual GoogleCloudContentwarehouseV1UpdateOptions UpdateOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DocumentService.UpdateDocument.</summary>
    public class GoogleCloudContentwarehouseV1UpdateDocumentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Updated document after executing update request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual GoogleCloudContentwarehouseV1Document Document { get; set; }

        /// <summary>Additional information for the API invocation, such as the request tracking id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudContentwarehouseV1ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Output from Rule Engine recording the rule evaluator and action executor's output. Refer format in:
        /// google/cloud/contentwarehouse/v1/rule_engine.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleEngineOutput")]
        public virtual GoogleCloudContentwarehouseV1RuleEngineOutput RuleEngineOutput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DocumentSchemaService.UpdateDocumentSchema.</summary>
    public class GoogleCloudContentwarehouseV1UpdateDocumentSchemaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The document schema to update with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchema")]
        public virtual GoogleCloudContentwarehouseV1DocumentSchema DocumentSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for Update operations.</summary>
    public class GoogleCloudContentwarehouseV1UpdateOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options for merging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeFieldsOptions")]
        public virtual GoogleCloudContentwarehouseV1MergeFieldsOptions MergeFieldsOptions { get; set; }

        /// <summary>
        /// Field mask for merging Document fields. For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>Type for update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateType")]
        public virtual string UpdateType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RuleSetService.UpdateRuleSet.</summary>
    public class GoogleCloudContentwarehouseV1UpdateRuleSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The rule set to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleSet")]
        public virtual GoogleCloudContentwarehouseV1RuleSet RuleSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The user information.</summary>
    public class GoogleCloudContentwarehouseV1UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique group identifications which the user is belong to. The format is "group:yyyy@example.com";
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupIds")]
        public virtual System.Collections.Generic.IList<string> GroupIds { get; set; }

        /// <summary>
        /// A unique user identification string, as determined by the client. The maximum number of allowed characters
        /// is 255. Allowed characters include numbers 0 to 9, uppercase and lowercase letters, and restricted special
        /// symbols (:, @, +, -, _, ~) The format is "user:xxxx@example.com";
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Value` represents a dynamically typed value which can be either be a float, a integer, a string, or a datetime
    /// value. A producer of value is expected to set one of these variants. Absence of any variant indicates an error.
    /// </summary>
    public class GoogleCloudContentwarehouseV1Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>Represents a datetime value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeValue")]
        public virtual GoogleTypeDateTime DatetimeValue { get; set; }

        /// <summary>Represents an enum value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValue")]
        public virtual GoogleCloudContentwarehouseV1EnumValue EnumValue { get; set; }

        /// <summary>Represents a float value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>Represents a integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<int> IntValue { get; set; }

        /// <summary>Represents a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>Represents a timestamp value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual GoogleCloudContentwarehouseV1TimestampValue TimestampValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the schema property name.</summary>
    public class GoogleCloudContentwarehouseV1WeightedSchemaProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The document schema name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentSchemaName")]
        public virtual string DocumentSchemaName { get; set; }

        /// <summary>The property definition names in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyNames")]
        public virtual System.Collections.Generic.IList<string> PropertyNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata object for CreateDocument request (currently empty).</summary>
    public class GoogleCloudContentwarehouseV1beta1CreateDocumentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for projectService.InitializeProject</summary>
    public class GoogleCloudContentwarehouseV1beta1InitializeProjectResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message of the project initialization process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The state of the project initialization process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata object for UpdateDocument request (currently empty).</summary>
    public class GoogleCloudContentwarehouseV1beta1UpdateDocumentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encodes the detailed information of a barcode.</summary>
    public class GoogleCloudDocumentaiV1Barcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Format of a barcode. The supported formats are: - `CODE_128`: Code 128 type. - `CODE_39`: Code 39 type. -
        /// `CODE_93`: Code 93 type. - `CODABAR`: Codabar type. - `DATA_MATRIX`: 2D Data Matrix type. - `ITF`: ITF type.
        /// - `EAN_13`: EAN-13 type. - `EAN_8`: EAN-8 type. - `QR_CODE`: 2D QR code type. - `UPC_A`: UPC-A type. -
        /// `UPC_E`: UPC-E type. - `PDF417`: PDF417 type. - `AZTEC`: 2D Aztec code type. - `DATABAR`: GS1 DataBar code
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Raw value encoded in the barcode. For example: `'MEBKM:TITLE:Google;URL:https://www.google.com;;'`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawValue")]
        public virtual string RawValue { get; set; }

        /// <summary>
        /// Value format describes the format of the value that a barcode encodes. The supported formats are: -
        /// `CONTACT_INFO`: Contact information. - `EMAIL`: Email address. - `ISBN`: ISBN identifier. - `PHONE`: Phone
        /// number. - `PRODUCT`: Product. - `SMS`: SMS message. - `TEXT`: Text string. - `URL`: URL address. - `WIFI`:
        /// Wifi information. - `GEO`: Geo-localization. - `CALENDAR_EVENT`: Calendar event. - `DRIVER_LICENSE`:
        /// Driver's license.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFormat")]
        public virtual string ValueFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bounding polygon for the detected image annotation.</summary>
    public class GoogleCloudDocumentaiV1BoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon normalized vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedVertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1NormalizedVertex> NormalizedVertices { get; set; }

        /// <summary>The bounding polygon vertices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1Vertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Document represents the canonical document resource in Document AI. It is an interchange format that provides
    /// insights into documents and allows for collaboration between users and Document AI to iterate and optimize for
    /// quality.
    /// </summary>
    public class GoogleCloudDocumentaiV1Document : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Document chunked based on chunking config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkedDocument")]
        public virtual GoogleCloudDocumentaiV1DocumentChunkedDocument ChunkedDocument { get; set; }

        /// <summary>
        /// Optional. Inline document content, represented as a stream of bytes. Note: As with all `bytes` fields,
        /// protobuffers use a pure binary representation, whereas JSON representations use base64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Parsed layout of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLayout")]
        public virtual GoogleCloudDocumentaiV1DocumentDocumentLayout DocumentLayout { get; set; }

        /// <summary>
        /// A list of entities detected on Document.text. For document shards, entities in this list may cross shard
        /// boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentEntity> Entities { get; set; }

        /// <summary>Placeholder. Relationship among Document.entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityRelations")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentEntityRelation> EntityRelations { get; set; }

        /// <summary>Any error that occurred while processing this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>
        /// An IANA published [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Visual page layout for the Document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPage> Pages { get; set; }

        /// <summary>Placeholder. Revision history of this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentRevision> Revisions { get; set; }

        /// <summary>
        /// Information about the sharding if this document is sharded part of a larger document. If the document is not
        /// sharded, this message is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardInfo")]
        public virtual GoogleCloudDocumentaiV1DocumentShardInfo ShardInfo { get; set; }

        /// <summary>Optional. UTF-8 encoded text in reading order from the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Placeholder. A list of text corrections made to Document.text. This is usually used for annotating
        /// corrections to OCR mistakes. Text changes for a given revision may not overlap with each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textChanges")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentTextChange> TextChanges { get; set; }

        /// <summary>Styles for the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyles")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentStyle> TextStyles { get; set; }

        /// <summary>
        /// Optional. Currently supports Google Cloud Storage URI of the form `gs://bucket_name/object_name`. Object
        /// versioning is not supported. For more information, refer to [Google Cloud Storage Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the chunks that the document is divided into.</summary>
    public class GoogleCloudDocumentaiV1DocumentChunkedDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of chunks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentChunkedDocumentChunk> Chunks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a chunk.</summary>
    public class GoogleCloudDocumentaiV1DocumentChunkedDocumentChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkId")]
        public virtual string ChunkId { get; set; }

        /// <summary>Text content of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Page footers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFooters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageFooter> PageFooters { get; set; }

        /// <summary>Page headers associated with the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageHeaders")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageHeader> PageHeaders { get; set; }

        /// <summary>Page span of the chunk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBlockIds")]
        public virtual System.Collections.Generic.IList<string> SourceBlockIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page footer associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the footer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Footer in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the page header associated with the chunk.</summary>
    public class GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page span of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageSpan PageSpan { get; set; }

        /// <summary>Header in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the chunk starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1DocumentChunkedDocumentChunkChunkPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where chunk ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where chunk starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the parsed layout of a document as a collection of blocks that the document is divided into.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of blocks in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a block. A block could be one of the various types (text, table, list) supported.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockId")]
        public virtual string BlockId { get; set; }

        /// <summary>Block consisting of list content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listBlock")]
        public virtual GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock ListBlock { get; set; }

        /// <summary>Page span of the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSpan")]
        public virtual GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan PageSpan { get; set; }

        /// <summary>Block consisting of table content/structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableBlock")]
        public virtual GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock TableBlock { get; set; }

        /// <summary>Block consisting of text content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textBlock")]
        public virtual GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock TextBlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a list type block.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutListBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List entries that constitute a list block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listEntries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry> ListEntries { get; set; }

        /// <summary>Type of the list_entries (if exist). Available options are `ordered` and `unordered`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an entry in the list.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutListEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list entry is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents where the block starts and ends in the document.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutPageSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page where block ends in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageEnd")]
        public virtual System.Nullable<int> PageEnd { get; set; }

        /// <summary>Page where block starts in the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStart")]
        public virtual System.Nullable<int> PageStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a table type block.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Body rows containing main table content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> BodyRows { get; set; }

        /// <summary>Table caption/title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>Header rows at the top of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow> HeaderRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a cell in a table row.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A table cell is a list of blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a row in a table.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A table row is a list of table cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a text type block.</summary>
    public class GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlockLayoutTextBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A text block could further have child blocks. Repeated blocks support further hierarchies and nested blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentDocumentLayoutDocumentLayoutBlock> Blocks { get; set; }

        /// <summary>Text content stored in the block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// Type of the text in the block. Available options are: `paragraph`, `subtitle`, `heading-1`, `heading-2`,
        /// `heading-3`, `heading-4`, `heading-5`, `header`, `footer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An entity that could be a phrase in the text or a property that belongs to the document. It is a known entity
    /// type, such as a person, an organization, or location.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Confidence of detected Schema entity. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Canonical id. This will be a unique value in the entity list for this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Deprecated. Use `id` field instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionId")]
        public virtual string MentionId { get; set; }

        /// <summary>Optional. Text value of the entity e.g. `1600 Amphitheatre Pkwy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mentionText")]
        public virtual string MentionText { get; set; }

        /// <summary>
        /// Optional. Normalized entity value. Absent if the extracted value could not be converted or the type (e.g.
        /// address) is not supported for certain parsers. This field is also only populated for certain supported
        /// document types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedValue")]
        public virtual GoogleCloudDocumentaiV1DocumentEntityNormalizedValue NormalizedValue { get; set; }

        /// <summary>
        /// Optional. Represents the provenance of this entity wrt. the location on the page where it was found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageAnchor")]
        public virtual GoogleCloudDocumentaiV1DocumentPageAnchor PageAnchor { get; set; }

        /// <summary>
        /// Optional. Entities can be nested to form a hierarchical data structure representing the content in the
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentEntity> Properties { get; set; }

        /// <summary>Optional. The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>Optional. Whether the entity will be redacted for de-identification purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redacted")]
        public virtual System.Nullable<bool> Redacted { get; set; }

        /// <summary>Optional. Provenance of the entity. Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>Required. Entity type from a schema e.g. `Address`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parsed and normalized entity value.</summary>
    public class GoogleCloudDocumentaiV1DocumentEntityNormalizedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Postal address. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/postal_address.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressValue")]
        public virtual GoogleTypePostalAddress AddressValue { get; set; }

        /// <summary>Boolean value. Can be used for entities with binary values, or for checkboxes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>
        /// Date value. Includes year, month, day. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/date.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateValue")]
        public virtual GoogleTypeDate DateValue { get; set; }

        /// <summary>
        /// DateTime value. Includes date, time, and timezone. See also:
        /// https://github.com/googleapis/googleapis/blob/master/google/type/datetime.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeValue")]
        public virtual GoogleTypeDateTime DatetimeValue { get; set; }

        /// <summary>Float value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>Integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<int> IntegerValue { get; set; }

        /// <summary>
        /// Money value. See also: https://github.com/googleapis/googleapis/blob/master/google/type/money.proto
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moneyValue")]
        public virtual GoogleTypeMoney MoneyValue { get; set; }

        /// <summary>
        /// Optional. An optional field to store a normalized string. For some entity types, one of respective
        /// `structured_value` fields may also be populated. Also not all the types of `structured_value` will be
        /// normalized. For example, some processors may not generate `float` or `integer` normalized text by default.
        /// Below are sample formats mapped to structured values. - Money/Currency type (`money_value`) is in the ISO
        /// 4217 text format. - Date type (`date_value`) is in the ISO 8601 text format. - Datetime type
        /// (`datetime_value`) is in the ISO 8601 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Relationship between Entities.</summary>
    public class GoogleCloudDocumentaiV1DocumentEntityRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual string ObjectId { get; set; }

        /// <summary>Relationship description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual string Relation { get; set; }

        /// <summary>Subject entity id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectId")]
        public virtual string SubjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A page in a Document.</summary>
    public class GoogleCloudDocumentaiV1DocumentPage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of visually detected text blocks on the page. A block has a set of lines (collected into paragraphs)
        /// that have a common line-spacing and orientation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageBlock> Blocks { get; set; }

        /// <summary>A list of detected barcodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBarcodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedBarcode> DetectedBarcodes { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Physical dimension of the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual GoogleCloudDocumentaiV1DocumentPageDimension Dimension { get; set; }

        /// <summary>A list of visually detected form fields on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageFormField> FormFields { get; set; }

        /// <summary>
        /// Rendered image for this page. This image is preprocessed to remove any skew, rotation, and distortions such
        /// that the annotation bounding boxes can be upright and axis-aligned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDocumentaiV1DocumentPageImage Image { get; set; }

        /// <summary>Image quality scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageQualityScores")]
        public virtual GoogleCloudDocumentaiV1DocumentPageImageQualityScores ImageQualityScores { get; set; }

        /// <summary>Layout for the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>
        /// A list of visually detected text lines on the page. A collection of tokens that a human would perceive as a
        /// line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lines")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageLine> Lines { get; set; }

        /// <summary>
        /// 1-based index for current Page in a parent Document. Useful when a page is taken out of a Document for
        /// individual processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageNumber")]
        public virtual System.Nullable<int> PageNumber { get; set; }

        /// <summary>
        /// A list of visually detected text paragraphs on the page. A collection of lines that a human would perceive
        /// as a paragraph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraphs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageParagraph> Paragraphs { get; set; }

        /// <summary>The history of this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>A list of visually detected symbols on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbols")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageSymbol> Symbols { get; set; }

        /// <summary>A list of visually detected tables on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageTable> Tables { get; set; }

        /// <summary>A list of visually detected tokens on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokens")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageToken> Tokens { get; set; }

        /// <summary>
        /// Transformation matrices that were applied to the original document image to produce Page.image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transforms")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageMatrix> Transforms { get; set; }

        /// <summary>A list of detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visualElements")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageVisualElement> VisualElements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Referencing the visual context of the entity in the Document.pages. Page anchors can be cross-page, consist of
    /// multiple bounding polygons and optionally reference specific layout element types.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentPageAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One or more references to visual page elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageRefs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageAnchorPageRef> PageRefs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a weak reference to a page element within a document.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageAnchorPageRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Identifies the bounding polygon of a layout element on the page. If `layout_type` is set, the
        /// bounding polygon must be exactly the same to the layout element it's referring to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1BoundingPoly BoundingPoly { get; set; }

        /// <summary>Optional. Confidence of detected page element, if applicable. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Optional. Deprecated. Use PageRef.bounding_poly instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutId")]
        public virtual string LayoutId { get; set; }

        /// <summary>Optional. The type of the layout element that is being referenced if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layoutType")]
        public virtual string LayoutType { get; set; }

        /// <summary>
        /// Required. Index into the Document.pages element, for example using `Document.pages` to locate the related
        /// page element. This field is skipped when its value is the default `0`. See
        /// https://developers.google.com/protocol-buffers/docs/proto3#json.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("page")]
        public virtual System.Nullable<long> Page { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A block has a set of lines (collected into paragraphs) that have a common line-spacing and orientation.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentPageBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected barcode.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageDetectedBarcode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed barcode information of the DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barcode")]
        public virtual GoogleCloudDocumentaiV1Barcode Barcode { get; set; }

        /// <summary>Layout for DetectedBarcode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected language for a structural component.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageDetectedLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence of detected language. Range `[0, 1]`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The [BCP-47 language code](https://www.unicode.org/reports/tr35/#Unicode_locale_identifier), such as `en-US`
        /// or `sr-Latn`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension for the page.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<float> Height { get; set; }

        /// <summary>Dimension unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>Page width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<float> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A form field detected on the page.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageFormField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Created for Labeling UI to export key text. If corrections were made to the text identified by the
        /// `field_name.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedKeyText")]
        public virtual string CorrectedKeyText { get; set; }

        /// <summary>
        /// Created for Labeling UI to export value text. If corrections were made to the text identified by the
        /// `field_value.text_anchor`, this field will contain the correction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctedValueText")]
        public virtual string CorrectedValueText { get; set; }

        /// <summary>
        /// Layout for the FormField name. e.g. `Address`, `Email`, `Grand total`, `Phone number`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout FieldName { get; set; }

        /// <summary>Layout for the FormField value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldValue")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout FieldValue { get; set; }

        /// <summary>A list of detected languages for name together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> NameDetectedLanguages { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>A list of detected languages for value together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueDetectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> ValueDetectedLanguages { get; set; }

        /// <summary>
        /// If the value is non-textual, this field represents the type. Current valid values are: - blank (this
        /// indicates the `field_value` is normal text) - `unfilled_checkbox` - `filled_checkbox`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rendered image contents for this page.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Raw byte content of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Height of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>
        /// Encoding [media type (MIME type)](https://www.iana.org/assignments/media-types/media-types.xhtml) for the
        /// image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Width of the image in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image quality scores for the page image.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageImageQualityScores : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected defects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedDefects")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageImageQualityScoresDetectedDefect> DetectedDefects { get; set; }

        /// <summary>The overall quality score. Range `[0, 1]` where `1` is perfect quality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualityScore")]
        public virtual System.Nullable<float> QualityScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image Quality Defects</summary>
    public class GoogleCloudDocumentaiV1DocumentPageImageQualityScoresDetectedDefect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence of detected defect. Range `[0, 1]` where `1` indicates strong confidence that the defect exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Name of the defect type. Supported values are: - `quality/defect_blurry` - `quality/defect_noisy` -
        /// `quality/defect_dark` - `quality/defect_faint` - `quality/defect_text_too_small` -
        /// `quality/defect_document_cutoff` - `quality/defect_text_cutoff` - `quality/defect_glare`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Visual element describing a layout unit on a page.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bounding polygon for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingPoly")]
        public virtual GoogleCloudDocumentaiV1BoundingPoly BoundingPoly { get; set; }

        /// <summary>
        /// Confidence of the current Layout within context of the object this layout is for. e.g. confidence can be for
        /// a single token, a table, a visual element, etc. depending on context. Range `[0, 1]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Detected orientation for the Layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of tokens that a human would perceive as a line. Does not cross column boundaries, can be
    /// horizontal, vertical, etc.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentPageLine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation for transformation matrix, intended to be compatible and used with OpenCV format for image
    /// manipulation.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentPageMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of columns in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cols")]
        public virtual System.Nullable<int> Cols { get; set; }

        /// <summary>The matrix data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Number of rows in the matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Nullable<int> Rows { get; set; }

        /// <summary>
        /// This encodes information about what data type the matrix uses. For example, 0 (CV_8U) is an unsigned 8-bit
        /// image. For the full list of OpenCV primitive data types, please refer to
        /// https://docs.opencv.org/4.3.0/d1/d1b/group__core__hal__interface.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Nullable<int> Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of lines that a human would perceive as a paragraph.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Paragraph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected symbol.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageSymbol : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Symbol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A table representation similar to HTML table structure.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Body rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageTableTableRow> BodyRows { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Header rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerRows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageTableTableRow> HeaderRows { get; set; }

        /// <summary>Layout for Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A cell representation inside the table.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageTableTableCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many columns this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colSpan")]
        public virtual System.Nullable<int> ColSpan { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for TableCell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>How many rows this cell spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSpan")]
        public virtual System.Nullable<int> RowSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of table cells.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageTableTableRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cells that make up this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageTableTableCell> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detected token.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break at the end of a Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedBreak")]
        public virtual GoogleCloudDocumentaiV1DocumentPageTokenDetectedBreak DetectedBreak { get; set; }

        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for Token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual GoogleCloudDocumentaiV1DocumentProvenance Provenance { get; set; }

        /// <summary>Text style attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("styleInfo")]
        public virtual GoogleCloudDocumentaiV1DocumentPageTokenStyleInfo StyleInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected break at the end of a Token.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageTokenDetectedBreak : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected break type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font and other text style attributes.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageTokenStyleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Color of the background.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Whether the text is bold (equivalent to font_weight is at least `700`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bold")]
        public virtual System.Nullable<bool> Bold { get; set; }

        /// <summary>Font size in points (`1` point is `¹⁄₇₂` inches).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual System.Nullable<int> FontSize { get; set; }

        /// <summary>Name or style of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontType")]
        public virtual string FontType { get; set; }

        /// <summary>
        /// TrueType weight on a scale `100` (thin) to `1000` (ultra-heavy). Normal is `400`, bold is `700`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual System.Nullable<int> FontWeight { get; set; }

        /// <summary>Whether the text is handwritten.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handwritten")]
        public virtual System.Nullable<bool> Handwritten { get; set; }

        /// <summary>Whether the text is italic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italic")]
        public virtual System.Nullable<bool> Italic { get; set; }

        /// <summary>Letter spacing in points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("letterSpacing")]
        public virtual System.Nullable<double> LetterSpacing { get; set; }

        /// <summary>Font size in pixels, equal to _unrounded font_size_ * _resolution_ ÷ `72.0`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelFontSize")]
        public virtual System.Nullable<double> PixelFontSize { get; set; }

        /// <summary>Whether the text is in small caps. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smallcaps")]
        public virtual System.Nullable<bool> Smallcaps { get; set; }

        /// <summary>Whether the text is strikethrough. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strikeout")]
        public virtual System.Nullable<bool> Strikeout { get; set; }

        /// <summary>Whether the text is a subscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscript")]
        public virtual System.Nullable<bool> Subscript { get; set; }

        /// <summary>Whether the text is a superscript. This feature is not supported yet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superscript")]
        public virtual System.Nullable<bool> Superscript { get; set; }

        /// <summary>Color of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textColor")]
        public virtual GoogleTypeColor TextColor { get; set; }

        /// <summary>Whether the text is underlined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underlined")]
        public virtual System.Nullable<bool> Underlined { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected non-text visual elements e.g. checkbox, signature etc. on the page.</summary>
    public class GoogleCloudDocumentaiV1DocumentPageVisualElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of detected languages together with confidence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedLanguages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentPageDetectedLanguage> DetectedLanguages { get; set; }

        /// <summary>Layout for VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual GoogleCloudDocumentaiV1DocumentPageLayout Layout { get; set; }

        /// <summary>Type of the VisualElement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structure to identify provenance relationships between annotations in different revisions.</summary>
    public class GoogleCloudDocumentaiV1DocumentProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Id of this operation. Needs to be unique within the scope of the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>References to the original elements that are replaced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentProvenanceParent> Parents { get; set; }

        /// <summary>The index of the revision that produced this element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The type of provenance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The parent element the current element is based on. Used for referencing/aligning, removal and replacement
    /// operations.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentProvenanceParent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the parent provenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; }

        /// <summary>
        /// The index of the parent item in the corresponding item list (eg. list of entities, properties within
        /// entities, etc.) in the parent revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The index of the index into current revision's parent_ids list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains past or forward revisions of this document.</summary>
    public class GoogleCloudDocumentaiV1DocumentRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the change was made by a person specify the name or id of that person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// The time that the revision was created, internally generated by doc proto storage at the time of create.
        /// </summary>
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

        /// <summary>Human Review information of this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("humanReview")]
        public virtual GoogleCloudDocumentaiV1DocumentRevisionHumanReview HumanReview { get; set; }

        /// <summary>
        /// Id of the revision, internally generated by doc proto storage. Unique within the context of the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. This can include one or more parent (when documents are
        /// merged.) This field represents the index into the `revisions` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Parent { get; set; }

        /// <summary>
        /// The revisions that this revision is based on. Must include all the ids that have anything to do with this
        /// revision - eg. there are `provenance.parent.revision` fields that index into this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentIds")]
        public virtual System.Collections.Generic.IList<string> ParentIds { get; set; }

        /// <summary>If the annotation was made by processor identify the processor by its resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processor")]
        public virtual string Processor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Human Review information of the document.</summary>
    public class GoogleCloudDocumentaiV1DocumentRevisionHumanReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human review state. e.g. `requested`, `succeeded`, `rejected`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// A message providing more details about the current state of processing. For example, the rejection reason
        /// when the state is `rejected`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For a large document, sharding may be performed to produce several document shards. Each document shard contains
    /// this field to detail which shard it is.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentShardInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<long> ShardCount { get; set; }

        /// <summary>The 0-based index of this shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardIndex")]
        public virtual System.Nullable<long> ShardIndex { get; set; }

        /// <summary>The index of the first character in Document.text in the overall document global text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textOffset")]
        public virtual System.Nullable<long> TextOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotation for common text style attributes. This adheres to CSS conventions as much as possible.
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text background color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual GoogleTypeColor BackgroundColor { get; set; }

        /// <summary>Text color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual GoogleTypeColor Color { get; set; }

        /// <summary>
        /// Font family such as `Arial`, `Times New Roman`. https://www.w3schools.com/cssref/pr_font_font-family.asp
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>Font size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual GoogleCloudDocumentaiV1DocumentStyleFontSize FontSize { get; set; }

        /// <summary>
        /// [Font weight](https://www.w3schools.com/cssref/pr_font_weight.asp). Possible values are `normal`, `bold`,
        /// `bolder`, and `lighter`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontWeight")]
        public virtual string FontWeight { get; set; }

        /// <summary>Text anchor indexing into the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>
        /// [Text decoration](https://www.w3schools.com/cssref/pr_text_text-decoration.asp). Follows CSS standard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDecoration")]
        public virtual string TextDecoration { get; set; }

        /// <summary>
        /// [Text style](https://www.w3schools.com/cssref/pr_font_font-style.asp). Possible values are `normal`,
        /// `italic`, and `oblique`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textStyle")]
        public virtual string TextStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Font size with unit.</summary>
    public class GoogleCloudDocumentaiV1DocumentStyleFontSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Font size for the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<float> Size { get; set; }

        /// <summary>Unit for the font size. Follows CSS naming (such as `in`, `px`, and `pt`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Text reference indexing into the Document.text.</summary>
    public class GoogleCloudDocumentaiV1DocumentTextAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains the content of the text span so that users do not have to look it up in the text_segments. It is
        /// always populated for formFields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The text segments from the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textSegments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentTextAnchorTextSegment> TextSegments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text segment in the Document.text. The indices may be out of bounds which indicate that the text extends into
    /// another document shard for large sharded documents. See ShardInfo.text_offset
    /// </summary>
    public class GoogleCloudDocumentaiV1DocumentTextAnchorTextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>TextSegment half open end UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<long> EndIndex { get; set; }

        /// <summary>TextSegment start UTF-8 char index in the Document.text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<long> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message is used for text changes aka. OCR corrections.</summary>
    public class GoogleCloudDocumentaiV1DocumentTextChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that replaces the text identified in the `text_anchor`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changedText")]
        public virtual string ChangedText { get; set; }

        /// <summary>The history of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual System.Collections.Generic.IList<GoogleCloudDocumentaiV1DocumentProvenance> Provenance { get; set; }

        /// <summary>
        /// Provenance of the correction. Text anchor indexing into the Document.text. There can only be a single
        /// `TextAnchor.text_segments` element. If the start and end index of the text segment are the same, the text
        /// change is inserted before that index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnchor")]
        public virtual GoogleCloudDocumentaiV1DocumentTextAnchor TextAnchor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudDocumentaiV1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the vertex coordinates are in the same scale as the original
    /// image.
    /// </summary>
    public class GoogleCloudDocumentaiV1Vertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<int> X { get; set; }

        /// <summary>Y coordinate (starts from the top of the image).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<int> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class GoogleIamV1AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

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
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; }

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
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to and
    /// from color representations in various languages over compactness. For example, the fields of this representation
    /// can be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't have information about the
    /// absolute color space that should be used to interpret the RGB value—for example, sRGB, Adobe RGB, DCI-P3, and
    /// BT.2020. By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most `1e-5`. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class GoogleTypeColor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

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

    /// <summary>
    /// Represents civil time (or occasionally physical time). This type can represent a civil time in one of a few
    /// possible ways: * When utc_offset is set and time_zone is unset: a civil time on a calendar day with a particular
    /// offset from UTC. * When time_zone is set and utc_offset is unset: a civil time on a calendar day in a particular
    /// time zone. * When neither time_zone nor utc_offset is set: a civil time on a calendar day in local time. The
    /// date is relative to the Proleptic Gregorian Calendar. If year, month, or day are 0, the DateTime is considered
    /// not to have a specific year, month, or day respectively. This type may also be used to represent a physical time
    /// if all the date and time fields are set and either case of the `time_offset` oneof is set. Consider using
    /// `Timestamp` message for physical time instead. If your use case also would like to store the user's timezone,
    /// that can be done in another field. This type is more flexible than some applications may want. Make sure to
    /// document and validate your application's limitations.
    /// </summary>
    public class GoogleTypeDateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a datetime
        /// without a day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>
        /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An API may
        /// choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>
        /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API may allow the
        /// value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual GoogleTypeTimeZone TimeZone { get; set; }

        /// <summary>
        /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of -4:00 would
        /// be represented as { seconds: -14400 }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>
        /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

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
    public class GoogleTypeExpr : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class GoogleTypeInterval : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class GoogleTypeMoney : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a postal address. For example for postal delivery or payments addresses. Given a postal address, a
    /// postal service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical
    /// locations (roads, towns, mountains). In typical usage an address would be created by user input or from
    /// importing existing data, depending on the type of process. Advice on address input / editing: - Use an
    /// internationalization-ready address widget such as https://github.com/google/libaddressinput) - Users should not
    /// be presented with UI elements for input or editing of fields outside countries where that field is used. For
    /// more guidance on how to use this schema, see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class GoogleTypePostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (For example "Austin,
        /// TX"), it is important that the line order is clear. The order of address lines should be "envelope order"
        /// for the country/region of the address. In places where this can vary (For example Japan), address_language
        /// is used to make it explicit (For example "ja" for large-to-small ordering and "ja-Latn" or "en" for
        /// small-to-large). This way, the most specific line of an address can be selected based on the language. The
        /// minimum permitted structural representation of an address consists of a region_code with all remaining
        /// information placed in the address_lines. It would be possible to format such an address very approximately
        /// without geocoding, but no semantic reasoning could be made about any of the address components until it was
        /// at least partially resolved. Creating an address only containing a region_code and address_lines, and then
        /// geocoding is the recommended way to handle completely unstructured addresses (as opposed to guessing which
        /// parts of the address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (For example "Barcelona" and not "Catalonia"). Many countries
        /// don't use an administrative area in postal addresses. For example in Switzerland this should be left
        /// unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use address_lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (For example state/zip
        /// validation in the U.S.A.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See https://cldr.unicode.org/ and
        /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH"
        /// for Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (For example "CEDEX 7"), or just
        /// a number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (For example Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class GoogleTypeTimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
