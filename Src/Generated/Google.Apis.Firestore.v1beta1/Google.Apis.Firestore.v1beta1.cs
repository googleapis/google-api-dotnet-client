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

namespace Google.Apis.Firestore.v1beta1
{
    /// <summary>The Firestore Service.</summary>
    public class FirestoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirestoreService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirestoreService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firestore.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firestore.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firestore";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Firestore API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Cloud Datastore data</summary>
            public static string Datastore = "https://www.googleapis.com/auth/datastore";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Firestore API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Cloud Datastore data</summary>
            public const string Datastore = "https://www.googleapis.com/auth/datastore";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Firestore requests.</summary>
    public abstract class FirestoreBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirestoreBaseServiceRequest instance.</summary>
        protected FirestoreBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Firestore parameter list.</summary>
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
            Databases = new DatabasesResource(service);
        }

        /// <summary>Gets the Databases resource.</summary>
        public virtual DatabasesResource Databases { get; }

        /// <summary>The "databases" collection of methods.</summary>
        public class DatabasesResource
        {
            private const string Resource = "databases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DatabasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Documents = new DocumentsResource(service);
                Indexes = new IndexesResource(service);
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

                /// <summary>
                /// Gets multiple documents. Documents returned by this method are not guaranteed to be returned in the
                /// same order that they were requested.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                /// </param>
                public virtual BatchGetRequest BatchGet(Google.Apis.Firestore.v1beta1.Data.BatchGetDocumentsRequest body, string database)
                {
                    return new BatchGetRequest(this.service, body, database);
                }

                /// <summary>
                /// Gets multiple documents. Documents returned by this method are not guaranteed to be returned in the
                /// same order that they were requested.
                /// </summary>
                public class BatchGetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.BatchGetDocumentsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.BatchGetDocumentsRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.BatchGetDocumentsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+database}/documents:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Applies a batch of write operations. The BatchWrite method does not apply the write operations
                /// atomically and can apply them out of order. Method does not allow more than one write per document.
                /// Each write succeeds or fails independently. See the BatchWriteResponse for the success status of
                /// each write. If you require an atomically applied set of writes, use Commit instead.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                /// </param>
                public virtual BatchWriteRequest BatchWrite(Google.Apis.Firestore.v1beta1.Data.BatchWriteRequest body, string database)
                {
                    return new BatchWriteRequest(this.service, body, database);
                }

                /// <summary>
                /// Applies a batch of write operations. The BatchWrite method does not apply the write operations
                /// atomically and can apply them out of order. Method does not allow more than one write per document.
                /// Each write succeeds or fails independently. See the BatchWriteResponse for the success status of
                /// each write. If you require an atomically applied set of writes, use Commit instead.
                /// </summary>
                public class BatchWriteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.BatchWriteResponse>
                {
                    /// <summary>Constructs a new BatchWrite request.</summary>
                    public BatchWriteRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.BatchWriteRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.BatchWriteRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchWrite";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+database}/documents:batchWrite";

                    /// <summary>Initializes BatchWrite parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts a new transaction.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                /// </param>
                public virtual BeginTransactionRequest BeginTransaction(Google.Apis.Firestore.v1beta1.Data.BeginTransactionRequest body, string database)
                {
                    return new BeginTransactionRequest(this.service, body, database);
                }

                /// <summary>Starts a new transaction.</summary>
                public class BeginTransactionRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.BeginTransactionResponse>
                {
                    /// <summary>Constructs a new BeginTransaction request.</summary>
                    public BeginTransactionRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.BeginTransactionRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.BeginTransactionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "beginTransaction";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+database}/documents:beginTransaction";

                    /// <summary>Initializes BeginTransaction parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>Commits a transaction, while optionally updating documents.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                /// </param>
                public virtual CommitRequest Commit(Google.Apis.Firestore.v1beta1.Data.CommitRequest body, string database)
                {
                    return new CommitRequest(this.service, body, database);
                }

                /// <summary>Commits a transaction, while optionally updating documents.</summary>
                public class CommitRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.CommitResponse>
                {
                    /// <summary>Constructs a new Commit request.</summary>
                    public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.CommitRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.CommitRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "commit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+database}/documents:commit";

                    /// <summary>Initializes Commit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a new document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource. For example:
                /// `projects/{project_id}/databases/{database_id}/documents` or
                /// `projects/{project_id}/databases/{database_id}/documents/chatrooms/{chatroom_id}`
                /// </param>
                /// <param name="collectionId">
                /// Required. The collection ID, relative to `parent`, to list. For example: `chatrooms`.
                /// </param>
                public virtual CreateDocumentRequest CreateDocument(Google.Apis.Firestore.v1beta1.Data.Document body, string parent, string collectionId)
                {
                    return new CreateDocumentRequest(this.service, body, parent, collectionId);
                }

                /// <summary>Creates a new document.</summary>
                public class CreateDocumentRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.Document>
                {
                    /// <summary>Constructs a new CreateDocument request.</summary>
                    public CreateDocumentRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.Document body, string parent, string collectionId) : base(service)
                    {
                        Parent = parent;
                        CollectionId = collectionId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource. For example:
                    /// `projects/{project_id}/databases/{database_id}/documents` or
                    /// `projects/{project_id}/databases/{database_id}/documents/chatrooms/{chatroom_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The collection ID, relative to `parent`, to list. For example: `chatrooms`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("collectionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CollectionId { get; private set; }

                    /// <summary>
                    /// The client-assigned document ID to use for this document. Optional. If not specified, an ID will
                    /// be assigned by the service.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("documentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DocumentId { get; set; }

                    /// <summary>
                    /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mask.fieldPaths", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> MaskFieldPaths { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.Document Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createDocument";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/{collectionId}";

                    /// <summary>Initializes CreateDocument parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/.*$",
                        });
                        RequestParameters.Add("collectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "collectionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("documentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "documentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("mask.fieldPaths", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mask.fieldPaths",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a document.</summary>
                /// <param name="name">
                /// Required. The resource name of the Document to delete. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a document.</summary>
                public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Document to delete. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// When set to `true`, the target document must exist. When set to `false`, the target document
                    /// must not exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currentDocument.exists", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> CurrentDocumentExists { get; set; }

                    private object _currentDocumentUpdateTime;

                    /// <summary>
                    /// String representation of <see cref="CurrentDocumentUpdateTimeDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currentDocument.updateTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CurrentDocumentUpdateTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="CurrentDocumentUpdateTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CurrentDocumentUpdateTimeDateTimeOffset instead.")]
                    public virtual object CurrentDocumentUpdateTime
                    {
                        get => _currentDocumentUpdateTime;
                        set
                        {
                            CurrentDocumentUpdateTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _currentDocumentUpdateTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? CurrentDocumentUpdateTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CurrentDocumentUpdateTimeRaw);
                        set
                        {
                            CurrentDocumentUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _currentDocumentUpdateTime = value;
                        }
                    }

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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                        RequestParameters.Add("currentDocument.exists", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currentDocument.exists",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("currentDocument.updateTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currentDocument.updateTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a single document.</summary>
                /// <param name="name">
                /// Required. The resource name of the Document to get. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a single document.</summary>
                public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.Document>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Document to get. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mask.fieldPaths", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> MaskFieldPaths { get; set; }

                    private object _readTime;

                    /// <summary>
                    /// String representation of <see cref="ReadTimeDateTimeOffset"/>, formatted for inclusion in the
                    /// HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReadTimeRaw { get; private set; }

                    /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
                    public virtual object ReadTime
                    {
                        get => _readTime;
                        set
                        {
                            ReadTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _readTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
                        set
                        {
                            ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _readTime = value;
                        }
                    }

                    /// <summary>Reads the document in a transaction.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("transaction", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Transaction { get; set; }

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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                        RequestParameters.Add("mask.fieldPaths", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mask.fieldPaths",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("transaction", new Google.Apis.Discovery.Parameter
                        {
                            Name = "transaction",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists documents.</summary>
                /// <param name="parent">
                /// Required. The parent resource name. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents` or
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                /// `projects/my-project/databases/my-database/documents` or
                /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                /// </param>
                /// <param name="collectionId">
                /// Optional. The collection ID, relative to `parent`, to list. For example: `chatrooms` or `messages`.
                /// This is optional, and when not provided, Firestore will list documents from all collections under
                /// the provided `parent`.
                /// </param>
                public virtual ListRequest List(string parent, string collectionId)
                {
                    return new ListRequest(this.service, parent, collectionId);
                }

                /// <summary>Lists documents.</summary>
                public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.ListDocumentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent, string collectionId) : base(service)
                    {
                        Parent = parent;
                        CollectionId = collectionId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents` or
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                    /// `projects/my-project/databases/my-database/documents` or
                    /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The collection ID, relative to `parent`, to list. For example: `chatrooms` or
                    /// `messages`. This is optional, and when not provided, Firestore will list documents from all
                    /// collections under the provided `parent`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("collectionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CollectionId { get; private set; }

                    /// <summary>
                    /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mask.fieldPaths", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> MaskFieldPaths { get; set; }

                    /// <summary>
                    /// Optional. The optional ordering of the documents to return. For example: `priority desc,
                    /// __name__ desc`. This mirrors the `ORDER BY` used in Firestore queries but in a string
                    /// representation. When absent, documents are ordered based on `__name__ ASC`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of documents to return in a single response. Firestore may return
                    /// fewer than this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListDocuments` response. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters (with the exception of
                    /// `page_size`) must match the values set in the request that generated the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    private object _readTime;

                    /// <summary>
                    /// String representation of <see cref="ReadTimeDateTimeOffset"/>, formatted for inclusion in the
                    /// HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReadTimeRaw { get; private set; }

                    /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
                    public virtual object ReadTime
                    {
                        get => _readTime;
                        set
                        {
                            ReadTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _readTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
                        set
                        {
                            ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _readTime = value;
                        }
                    }

                    /// <summary>
                    /// If the list should show missing documents. A document is missing if it does not exist, but there
                    /// are sub-documents nested underneath it. When true, such missing documents will be returned with
                    /// a key but will not have fields, `create_time`, or `update_time` set. Requests with
                    /// `show_missing` may not specify `where` or `order_by`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("showMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowMissing { get; set; }

                    /// <summary>Perform the read as part of an already active transaction.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("transaction", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Transaction { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/{collectionId}";

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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                        RequestParameters.Add("collectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "collectionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("mask.fieldPaths", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mask.fieldPaths",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("showMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "showMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("transaction", new Google.Apis.Discovery.Parameter
                        {
                            Name = "transaction",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all the collection IDs underneath a document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent document. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                /// </param>
                public virtual ListCollectionIdsRequest ListCollectionIds(Google.Apis.Firestore.v1beta1.Data.ListCollectionIdsRequest body, string parent)
                {
                    return new ListCollectionIdsRequest(this.service, body, parent);
                }

                /// <summary>Lists all the collection IDs underneath a document.</summary>
                public class ListCollectionIdsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.ListCollectionIdsResponse>
                {
                    /// <summary>Constructs a new ListCollectionIds request.</summary>
                    public ListCollectionIdsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.ListCollectionIdsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent document. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                    /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.ListCollectionIdsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listCollectionIds";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}:listCollectionIds";

                    /// <summary>Initializes ListCollectionIds parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                    }
                }

                /// <summary>Lists documents.</summary>
                /// <param name="parent">
                /// Required. The parent resource name. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents` or
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                /// `projects/my-project/databases/my-database/documents` or
                /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                /// </param>
                /// <param name="collectionId">
                /// Optional. The collection ID, relative to `parent`, to list. For example: `chatrooms` or `messages`.
                /// This is optional, and when not provided, Firestore will list documents from all collections under
                /// the provided `parent`.
                /// </param>
                public virtual ListDocumentsRequest ListDocuments(string parent, string collectionId)
                {
                    return new ListDocumentsRequest(this.service, parent, collectionId);
                }

                /// <summary>Lists documents.</summary>
                public class ListDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.ListDocumentsResponse>
                {
                    /// <summary>Constructs a new ListDocuments request.</summary>
                    public ListDocumentsRequest(Google.Apis.Services.IClientService service, string parent, string collectionId) : base(service)
                    {
                        Parent = parent;
                        CollectionId = collectionId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents` or
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                    /// `projects/my-project/databases/my-database/documents` or
                    /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The collection ID, relative to `parent`, to list. For example: `chatrooms` or
                    /// `messages`. This is optional, and when not provided, Firestore will list documents from all
                    /// collections under the provided `parent`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("collectionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CollectionId { get; private set; }

                    /// <summary>
                    /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mask.fieldPaths", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> MaskFieldPaths { get; set; }

                    /// <summary>
                    /// Optional. The optional ordering of the documents to return. For example: `priority desc,
                    /// __name__ desc`. This mirrors the `ORDER BY` used in Firestore queries but in a string
                    /// representation. When absent, documents are ordered based on `__name__ ASC`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of documents to return in a single response. Firestore may return
                    /// fewer than this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListDocuments` response. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters (with the exception of
                    /// `page_size`) must match the values set in the request that generated the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    private object _readTime;

                    /// <summary>
                    /// String representation of <see cref="ReadTimeDateTimeOffset"/>, formatted for inclusion in the
                    /// HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReadTimeRaw { get; private set; }

                    /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
                    public virtual object ReadTime
                    {
                        get => _readTime;
                        set
                        {
                            ReadTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _readTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
                        set
                        {
                            ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _readTime = value;
                        }
                    }

                    /// <summary>
                    /// If the list should show missing documents. A document is missing if it does not exist, but there
                    /// are sub-documents nested underneath it. When true, such missing documents will be returned with
                    /// a key but will not have fields, `create_time`, or `update_time` set. Requests with
                    /// `show_missing` may not specify `where` or `order_by`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("showMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowMissing { get; set; }

                    /// <summary>Perform the read as part of an already active transaction.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("transaction", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Transaction { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listDocuments";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/{collectionId}";

                    /// <summary>Initializes ListDocuments parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents$",
                        });
                        RequestParameters.Add("collectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "collectionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("mask.fieldPaths", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mask.fieldPaths",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("showMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "showMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("transaction", new Google.Apis.Discovery.Parameter
                        {
                            Name = "transaction",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Listens to changes. This method is only available via gRPC or WebChannel (not REST).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                /// </param>
                public virtual ListenRequest Listen(Google.Apis.Firestore.v1beta1.Data.ListenRequest body, string database)
                {
                    return new ListenRequest(this.service, body, database);
                }

                /// <summary>
                /// Listens to changes. This method is only available via gRPC or WebChannel (not REST).
                /// </summary>
                public class ListenRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.ListenResponse>
                {
                    /// <summary>Constructs a new Listen request.</summary>
                    public ListenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.ListenRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.ListenRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listen";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+database}/documents:listen";

                    /// <summary>Initializes Listen parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Partitions a query by returning partition cursors that can be used to run the query in parallel. The
                /// returned partition cursors are split points that can be used by RunQuery as starting/end points for
                /// the query results.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents`. Document resource names are not
                /// supported; only database resource names can be specified.
                /// </param>
                public virtual PartitionQueryRequest PartitionQuery(Google.Apis.Firestore.v1beta1.Data.PartitionQueryRequest body, string parent)
                {
                    return new PartitionQueryRequest(this.service, body, parent);
                }

                /// <summary>
                /// Partitions a query by returning partition cursors that can be used to run the query in parallel. The
                /// returned partition cursors are split points that can be used by RunQuery as starting/end points for
                /// the query results.
                /// </summary>
                public class PartitionQueryRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.PartitionQueryResponse>
                {
                    /// <summary>Constructs a new PartitionQuery request.</summary>
                    public PartitionQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.PartitionQueryRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents`. Document resource names are not
                    /// supported; only database resource names can be specified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.PartitionQueryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "partitionQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}:partitionQuery";

                    /// <summary>Initializes PartitionQuery parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                    }
                }

                /// <summary>Updates or inserts a document.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the document, for example
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firestore.v1beta1.Data.Document body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates or inserts a document.</summary>
                public class PatchRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.Document>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.Document body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the document, for example
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// When set to `true`, the target document must exist. When set to `false`, the target document
                    /// must not exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currentDocument.exists", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> CurrentDocumentExists { get; set; }

                    private object _currentDocumentUpdateTime;

                    /// <summary>
                    /// String representation of <see cref="CurrentDocumentUpdateTimeDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currentDocument.updateTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CurrentDocumentUpdateTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="CurrentDocumentUpdateTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CurrentDocumentUpdateTimeDateTimeOffset instead.")]
                    public virtual object CurrentDocumentUpdateTime
                    {
                        get => _currentDocumentUpdateTime;
                        set
                        {
                            CurrentDocumentUpdateTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _currentDocumentUpdateTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? CurrentDocumentUpdateTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CurrentDocumentUpdateTimeRaw);
                        set
                        {
                            CurrentDocumentUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _currentDocumentUpdateTime = value;
                        }
                    }

                    /// <summary>
                    /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mask.fieldPaths", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> MaskFieldPaths { get; set; }

                    /// <summary>
                    /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask.fieldPaths", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> UpdateMaskFieldPaths { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.Document Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                        RequestParameters.Add("currentDocument.exists", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currentDocument.exists",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("currentDocument.updateTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "currentDocument.updateTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("mask.fieldPaths", new Google.Apis.Discovery.Parameter
                        {
                            Name = "mask.fieldPaths",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("updateMask.fieldPaths", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask.fieldPaths",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Rolls back a transaction.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                /// </param>
                public virtual RollbackRequest Rollback(Google.Apis.Firestore.v1beta1.Data.RollbackRequest body, string database)
                {
                    return new RollbackRequest(this.service, body, database);
                }

                /// <summary>Rolls back a transaction.</summary>
                public class RollbackRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Rollback request.</summary>
                    public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.RollbackRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.RollbackRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rollback";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+database}/documents:rollback";

                    /// <summary>Initializes Rollback parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Runs an aggregation query. Rather than producing Document results like Firestore.RunQuery, this API
                /// allows running an aggregation to produce a series of AggregationResult server-side. High-Level
                /// Example:
                /// ```
                /// -- Return the number of documents in table given a filter. SELECT COUNT(*) FROM (
                /// SELECT * FROM k where a = true );
                /// ```
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents` or
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                /// `projects/my-project/databases/my-database/documents` or
                /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                /// </param>
                public virtual RunAggregationQueryRequest RunAggregationQuery(Google.Apis.Firestore.v1beta1.Data.RunAggregationQueryRequest body, string parent)
                {
                    return new RunAggregationQueryRequest(this.service, body, parent);
                }

                /// <summary>
                /// Runs an aggregation query. Rather than producing Document results like Firestore.RunQuery, this API
                /// allows running an aggregation to produce a series of AggregationResult server-side. High-Level
                /// Example:
                /// ```
                /// -- Return the number of documents in table given a filter. SELECT COUNT(*) FROM (
                /// SELECT * FROM k where a = true );
                /// ```
                /// </summary>
                public class RunAggregationQueryRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.RunAggregationQueryResponse>
                {
                    /// <summary>Constructs a new RunAggregationQuery request.</summary>
                    public RunAggregationQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.RunAggregationQueryRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents` or
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                    /// `projects/my-project/databases/my-database/documents` or
                    /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.RunAggregationQueryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "runAggregationQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}:runAggregationQuery";

                    /// <summary>Initializes RunAggregationQuery parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                    }
                }

                /// <summary>Runs a query.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents` or
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                /// `projects/my-project/databases/my-database/documents` or
                /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                /// </param>
                public virtual RunQueryRequest RunQuery(Google.Apis.Firestore.v1beta1.Data.RunQueryRequest body, string parent)
                {
                    return new RunQueryRequest(this.service, body, parent);
                }

                /// <summary>Runs a query.</summary>
                public class RunQueryRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.RunQueryResponse>
                {
                    /// <summary>Constructs a new RunQuery request.</summary>
                    public RunQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.RunQueryRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name. In the format:
                    /// `projects/{project_id}/databases/{database_id}/documents` or
                    /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                    /// `projects/my-project/databases/my-database/documents` or
                    /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.RunQueryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "runQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}:runQuery";

                    /// <summary>Initializes RunQuery parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/documents/[^/]+/.*$",
                        });
                    }
                }

                /// <summary>
                /// Streams batches of document updates and deletes, in order. This method is only available via gRPC or
                /// WebChannel (not REST).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`. This is
                /// only required in the first message.
                /// </param>
                public virtual WriteRequest Write(Google.Apis.Firestore.v1beta1.Data.WriteRequest body, string database)
                {
                    return new WriteRequest(this.service, body, database);
                }

                /// <summary>
                /// Streams batches of document updates and deletes, in order. This method is only available via gRPC or
                /// WebChannel (not REST).
                /// </summary>
                public class WriteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.WriteResponse>
                {
                    /// <summary>Constructs a new Write request.</summary>
                    public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.WriteRequest body, string database) : base(service)
                    {
                        Database = database;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                    /// This is only required in the first message.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Database { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.WriteRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "write";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+database}/documents:write";

                    /// <summary>Initializes Write parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                        {
                            Name = "database",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Indexes resource.</summary>
            public virtual IndexesResource Indexes { get; }

            /// <summary>The "indexes" collection of methods.</summary>
            public class IndexesResource
            {
                private const string Resource = "indexes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IndexesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates the specified index. A newly created index's initial state is `CREATING`. On completion of
                /// the returned google.longrunning.Operation, the state will be `READY`. If the index already exists,
                /// the call will return an `ALREADY_EXISTS` status. During creation, the process could result in an
                /// error, in which case the index will move to the `ERROR` state. The process can be recovered by
                /// fixing the data that caused the error, removing the index with delete, then re-creating the index
                /// with create. Indexes with a single field cannot be created.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The name of the database this index will apply to. For example:
                /// `projects/{project_id}/databases/{database_id}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1Index body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates the specified index. A newly created index's initial state is `CREATING`. On completion of
                /// the returned google.longrunning.Operation, the state will be `READY`. If the index already exists,
                /// the call will return an `ALREADY_EXISTS` status. During creation, the process could result in an
                /// error, in which case the index will move to the `ERROR` state. The process can be recovered by
                /// fixing the data that caused the error, removing the index with delete, then re-creating the index
                /// with create. Indexes with a single field cannot be created.
                /// </summary>
                public class CreateRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1Index body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the database this index will apply to. For example:
                    /// `projects/{project_id}/databases/{database_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1Index Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/indexes";

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
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes an index.</summary>
                /// <param name="name">
                /// The index name. For example: `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an index.</summary>
                public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The index name. For example: `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/indexes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets an index.</summary>
                /// <param name="name">
                /// The name of the index. For example:
                /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets an index.</summary>
                public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1Index>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the index. For example:
                    /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/indexes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the indexes that match the specified filters.</summary>
                /// <param name="parent">
                /// The database name. For example: `projects/{project_id}/databases/{database_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the indexes that match the specified filters.</summary>
                public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1ListIndexesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The database name. For example: `projects/{project_id}/databases/{database_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The standard List page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard List page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/indexes";

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
                            Pattern = @"^projects/[^/]+/databases/[^/]+$",
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

            /// <summary>
            /// Exports a copy of all or a subset of documents from Google Cloud Firestore to another storage system,
            /// such as Google Cloud Storage. Recent updates to documents may not be reflected in the export. The export
            /// occurs in the background and its progress can be monitored and managed via the Operation resource that
            /// is created. The output of an export may only be used once the associated operation is done. If an export
            /// operation is cancelled before completion it may leave partial data behind in Google Cloud Storage.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Database to export. Should be of the form: `projects/{project_id}/databases/{database_id}`.
            /// </param>
            public virtual ExportDocumentsRequest ExportDocuments(Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1ExportDocumentsRequest body, string name)
            {
                return new ExportDocumentsRequest(this.service, body, name);
            }

            /// <summary>
            /// Exports a copy of all or a subset of documents from Google Cloud Firestore to another storage system,
            /// such as Google Cloud Storage. Recent updates to documents may not be reflected in the export. The export
            /// occurs in the background and its progress can be monitored and managed via the Operation resource that
            /// is created. The output of an export may only be used once the associated operation is done. If an export
            /// operation is cancelled before completion it may leave partial data behind in Google Cloud Storage.
            /// </summary>
            public class ExportDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ExportDocuments request.</summary>
                public ExportDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1ExportDocumentsRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Database to export. Should be of the form: `projects/{project_id}/databases/{database_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1ExportDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportDocuments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:exportDocuments";

                /// <summary>Initializes ExportDocuments parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/databases/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Imports documents into Google Cloud Firestore. Existing documents with the same name are overwritten.
            /// The import occurs in the background and its progress can be monitored and managed via the Operation
            /// resource that is created. If an ImportDocuments operation is cancelled, it is possible that a subset of
            /// the data has already been imported to Cloud Firestore.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Database to import into. Should be of the form: `projects/{project_id}/databases/{database_id}`.
            /// </param>
            public virtual ImportDocumentsRequest ImportDocuments(Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1ImportDocumentsRequest body, string name)
            {
                return new ImportDocumentsRequest(this.service, body, name);
            }

            /// <summary>
            /// Imports documents into Google Cloud Firestore. Existing documents with the same name are overwritten.
            /// The import occurs in the background and its progress can be monitored and managed via the Operation
            /// resource that is created. If an ImportDocuments operation is cancelled, it is possible that a subset of
            /// the data has already been imported to Cloud Firestore.
            /// </summary>
            public class ImportDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ImportDocuments request.</summary>
                public ImportDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1ImportDocumentsRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Database to import into. Should be of the form: `projects/{project_id}/databases/{database_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1beta1.Data.GoogleFirestoreAdminV1beta1ImportDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "importDocuments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:importDocuments";

                /// <summary>Initializes ImportDocuments parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/databases/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Firestore.v1beta1.Data
{
    /// <summary>Defines an aggregation that produces a single result.</summary>
    public class Aggregation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional name of the field to store the result of the aggregation into. If not provided, Firestore
        /// will pick a default name following the format `field_`. For example:
        /// ```
        /// AGGREGATE COUNT_UP_TO(1) AS
        /// count_up_to_1, COUNT_UP_TO(2), COUNT_UP_TO(3) AS count_up_to_3, COUNT(*) OVER ( ... );
        /// ```
        /// becomes:
        /// ```
        /// AGGREGATE COUNT_UP_TO(1) AS count_up_to_1, COUNT_UP_TO(2) AS field_1, COUNT_UP_TO(3) AS count_up_to_3,
        /// COUNT(*) AS field_2 OVER ( ... );
        /// ```
        /// Requires: * Must be unique across all aggregation aliases. * Conform
        /// to document field name limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>Average aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avg")]
        public virtual Avg Avg { get; set; }

        /// <summary>Count aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual Count Count { get; set; }

        /// <summary>Sum aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sum")]
        public virtual Sum Sum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The result of a single bucket from a Firestore aggregation query. The keys of `aggregate_fields` are the same
    /// for all results in an aggregation query, unlike document queries which can have different fields present for
    /// each result.
    /// </summary>
    public class AggregationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The result of the aggregation functions, ex: `COUNT(*) AS total_docs`. The key is the alias assigned to the
        /// aggregation function on input and the size of this map equals the number of aggregation functions in the
        /// query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateFields")]
        public virtual System.Collections.Generic.IDictionary<string, Value> AggregateFields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An array value.</summary>
    public class ArrayValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Values in the array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Value> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Average of the values of the requested field. * Only numeric values will be aggregated. All non-numeric values
    /// including `NULL` are skipped. * If the aggregated values contain `NaN`, returns `NaN`. Infinity math follows
    /// IEEE-754 standards. * If the aggregated value set is empty, returns `NULL`. * Always returns the result as a
    /// double.
    /// </summary>
    public class Avg : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field to aggregate on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual FieldReference Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.BatchGetDocuments.</summary>
    public class BatchGetDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The names of the documents to retrieve. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. The request will fail if any of
        /// the document is not a child resource of the given `database`. Duplicate names will be elided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>
        /// The fields to return. If not set, returns all fields. If a document has a field that is not present in this
        /// mask, that field will not be returned in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mask")]
        public virtual DocumentMask Mask { get; set; }

        /// <summary>
        /// Starts a new transaction and reads the documents. Defaults to a read-only transaction. The new transaction
        /// ID will be returned as the first response in the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTransaction")]
        public virtual TransactionOptions NewTransaction { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Reads documents as they were at the given time. This must be a microsecond precision timestamp within the
        /// past one hour, or if Point-in-Time Recovery is enabled, can additionally be a whole minute timestamp within
        /// the past 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Reads documents in a transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The streamed response for Firestore.BatchGetDocuments.</summary>
    public class BatchGetDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A document that was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("found")]
        public virtual Document Found { get; set; }

        /// <summary>
        /// A document name that was requested but does not exist. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missing")]
        public virtual string Missing { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// The time at which the document was read. This may be monotically increasing, in this case the previous
        /// documents in the result stream are guaranteed not to have changed between their read_time and this one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The transaction that was started as part of this request. Will only be set in the first response, and only
        /// if BatchGetDocumentsRequest.new_transaction was set in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.BatchWrite.</summary>
    public class BatchWriteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Labels associated with this batch write.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The writes to apply. Method does not apply writes atomically and does not guarantee ordering. Each write
        /// succeeds or fails independently. You cannot write to the same document more than once per request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writes")]
        public virtual System.Collections.Generic.IList<Write> Writes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from Firestore.BatchWrite.</summary>
    public class BatchWriteResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The status of applying the writes. This i-th write status corresponds to the i-th write in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Collections.Generic.IList<Status> Status { get; set; }

        /// <summary>
        /// The result of applying the writes. This i-th write result corresponds to the i-th write in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeResults")]
        public virtual System.Collections.Generic.IList<WriteResult> WriteResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.BeginTransaction.</summary>
    public class BeginTransactionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The options for the transaction. Defaults to a read-write transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual TransactionOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.BeginTransaction.</summary>
    public class BeginTransactionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transaction that was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A sequence of bits, encoded in a byte array. Each byte in the `bitmap` byte array stores 8 bits of the sequence.
    /// The only exception is the last byte, which may store 8 _or fewer_ bits. The `padding` defines the number of bits
    /// of the last byte to be ignored as "padding". The values of these "padding" bits are unspecified and must be
    /// ignored. To retrieve the first bit, bit 0, calculate: `(bitmap[0] &amp;amp; 0x01) != 0`. To retrieve the second
    /// bit, bit 1, calculate: `(bitmap[0] &amp;amp; 0x02) != 0`. To retrieve the third bit, bit 2, calculate:
    /// `(bitmap[0] &amp;amp; 0x04) != 0`. To retrieve the fourth bit, bit 3, calculate: `(bitmap[0] &amp;amp; 0x08) !=
    /// 0`. To retrieve bit n, calculate: `(bitmap[n / 8] &amp;amp; (0x01 &amp;lt;&amp;lt; (n % 8))) != 0`. The "size"
    /// of a `BitSequence` (the number of bits it contains) is calculated by this formula: `(bitmap.length * 8) -
    /// padding`.
    /// </summary>
    public class BitSequence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bytes that encode the bit sequence. May have a length of zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitmap")]
        public virtual string Bitmap { get; set; }

        /// <summary>
        /// The number of bits of the last byte in `bitmap` to ignore as "padding". If the length of `bitmap` is zero,
        /// then this value must be `0`. Otherwise, this value must be between 0 and 7, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("padding")]
        public virtual System.Nullable<int> Padding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A bloom filter (https://en.wikipedia.org/wiki/Bloom_filter). The bloom filter hashes the entries with MD5 and
    /// treats the resulting 128-bit hash as 2 distinct 64-bit hash values, interpreted as unsigned integers using 2's
    /// complement encoding. These two hash values, named `h1` and `h2`, are then used to compute the `hash_count` hash
    /// values using the formula, starting at `i=0`: h(i) = h1 + (i * h2) These resulting values are then taken modulo
    /// the number of bits in the bloom filter to get the bits of the bloom filter to test for the given entry.
    /// </summary>
    public class BloomFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bloom filter data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bits")]
        public virtual BitSequence Bits { get; set; }

        /// <summary>The number of hashes used by the algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashCount")]
        public virtual System.Nullable<int> HashCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A selection of a collection, such as `messages as m1`.</summary>
    public class CollectionSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When false, selects only collections that are immediate children of the `parent` specified in the containing
        /// `RunQueryRequest`. When true, selects all descendant collections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allDescendants")]
        public virtual System.Nullable<bool> AllDescendants { get; set; }

        /// <summary>The collection ID. When set, selects only collections with this ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionId")]
        public virtual string CollectionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.Commit.</summary>
    public class CommitRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, applies all writes in this transaction, and commits it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The writes to apply. Always executed atomically and in order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writes")]
        public virtual System.Collections.Generic.IList<Write> Writes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.Commit.</summary>
    public class CommitResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _commitTimeRaw;

        private object _commitTime;

        /// <summary>
        /// The time at which the commit occurred. Any read with an equal or greater `read_time` is guaranteed to see
        /// the effects of the commit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTime")]
        public virtual string CommitTimeRaw
        {
            get => _commitTimeRaw;
            set
            {
                _commitTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _commitTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CommitTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CommitTimeDateTimeOffset instead.")]
        public virtual object CommitTime
        {
            get => _commitTime;
            set
            {
                _commitTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _commitTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CommitTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CommitTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CommitTimeRaw);
            set => CommitTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The result of applying the writes. This i-th write result corresponds to the i-th write in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeResults")]
        public virtual System.Collections.Generic.IList<WriteResult> WriteResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter that merges multiple other filters using the given operator.</summary>
    public class CompositeFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of filters to combine. Requires: * At least one filter is present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<Filter> Filters { get; set; }

        /// <summary>The operator for combining multiple filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Count of documents that match the query. The `COUNT(*)` aggregation function operates on the entire document so
    /// it does not require a field reference.
    /// </summary>
    public class Count : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional constraint on the maximum number of documents to count. This provides a way to set an
        /// upper bound on the number of documents to scan, limiting latency, and cost. Unspecified is interpreted as no
        /// bound. High-Level Example:
        /// ```
        /// AGGREGATE COUNT_UP_TO(1000) OVER ( SELECT * FROM k );
        /// ```
        /// Requires: * Must be
        /// greater than zero when present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upTo")]
        public virtual System.Nullable<long> UpTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A position in a query result set.</summary>
    public class Cursor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the position is just before or just after the given values, relative to the sort order defined by the
        /// query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("before")]
        public virtual System.Nullable<bool> Before { get; set; }

        /// <summary>
        /// The values that represent a position, in the order they appear in the order by clause of a query. Can
        /// contain fewer values than specified in the order by clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Value> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Firestore document. Must not exceed 1 MiB - 4 bytes.</summary>
    public class Document : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which the document was created. This value increases monotonically when a document
        /// is deleted then recreated. It can also be compared to values from other documents and the `read_time` of a
        /// query.
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

        /// <summary>
        /// The document's fields. The map keys represent field names. Field names matching the regular expression
        /// `__.*__` are reserved. Reserved field names are forbidden except in certain documented contexts. The field
        /// names, represented as UTF-8, must not exceed 1,500 bytes and cannot be empty. Field paths may be used in
        /// other contexts to refer to structured fields defined here. For `map_value`, the field path is represented by
        /// a dot-delimited (`.`) string of segments. Each segment is either a simple field name (defined below) or a
        /// quoted field name. For example, the structured field `"foo" : { map_value: { "x&amp;amp;y" : { string_value:
        /// "hello" }}}` would be represented by the field path `` foo.`x&amp;amp;y` ``. A simple field name contains
        /// only characters `a` to `z`, `A` to `Z`, `0` to `9`, or `_`, and must not start with `0` to `9`. For example,
        /// `foo_bar_17`. A quoted field name starts and ends with `` ` `` and may contain any character. Some
        /// characters, including `` ` ``, must be escaped using a `\`. For example, `` `x&amp;amp;y` `` represents
        /// `x&amp;amp;y` and `` `bak\`tik` `` represents `` bak`tik ``.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, Value> Fields { get; set; }

        /// <summary>
        /// The resource name of the document, for example
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The time at which the document was last changed. This value is initially set to the
        /// `create_time` then increases monotonically with each change to the document. It can also be compared to
        /// values from other documents and the `read_time` of a query.
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

    /// <summary>
    /// A Document has changed. May be the result of multiple writes, including deletes, that ultimately resulted in a
    /// new value for the Document. Multiple DocumentChange messages may be returned for the same logical change, if
    /// multiple targets are affected.
    /// </summary>
    public class DocumentChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new state of the Document. If `mask` is set, contains only fields that were updated or added.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>A set of target IDs for targets that no longer match this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedTargetIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RemovedTargetIds { get; set; }

        /// <summary>A set of target IDs of targets that match this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> TargetIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Document has been deleted. May be the result of multiple writes, including updates, the last of which deleted
    /// the Document. Multiple DocumentDelete messages may be returned for the same logical delete, if multiple targets
    /// are affected.
    /// </summary>
    public class DocumentDelete : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the Document that was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual string Document { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// The read timestamp at which the delete was observed. Greater or equal to the `commit_time` of the delete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A set of target IDs for targets that previously matched this entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedTargetIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RemovedTargetIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of field paths on a document. Used to restrict a get or update operation on a document to a subset of its
    /// fields. This is different from standard field masks, as this is always scoped to a Document, and takes in
    /// account the dynamic nature of Value.
    /// </summary>
    public class DocumentMask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPaths")]
        public virtual System.Collections.Generic.IList<string> FieldPaths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Document has been removed from the view of the targets. Sent if the document is no longer relevant to a target
    /// and is out of view. Can be sent instead of a DocumentDelete or a DocumentChange if the server can not send the
    /// new value of the document. Multiple DocumentRemove messages may be returned for the same logical write or
    /// delete, if multiple targets are affected.
    /// </summary>
    public class DocumentRemove : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the Document that has gone out of view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual string Document { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// The read timestamp at which the remove was observed. Greater or equal to the `commit_time` of the
        /// change/delete/remove.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A set of target IDs for targets that previously matched this document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedTargetIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RemovedTargetIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transformation of a document.</summary>
    public class DocumentTransform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the document to transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual string Document { get; set; }

        /// <summary>
        /// The list of transformations to apply to the fields of the document, in order. This must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldTransforms")]
        public virtual System.Collections.Generic.IList<FieldTransform> FieldTransforms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A target specified by a set of documents names.</summary>
    public class DocumentsTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The names of the documents to retrieve. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. The request will fail if any of
        /// the document is not a child resource of the given `database`. Duplicate names will be elided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<string> Documents { get; set; }

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

    /// <summary>Execution statistics for the query.</summary>
    public class ExecutionStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Debugging statistics from the execution of the query. Note that the debugging stats are subject to change as
        /// Firestore evolves. It could include: { "indexes_entries_scanned": "1000", "documents_scanned": "20",
        /// "billing_details" : { "documents_billable": "20", "index_entries_billable": "1000", "min_query_cost": "0" }
        /// }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugStats")]
        public virtual System.Collections.Generic.IDictionary<string, object> DebugStats { get; set; }

        /// <summary>Total time to execute the query in the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionDuration")]
        public virtual object ExecutionDuration { get; set; }

        /// <summary>Total billable read operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOperations")]
        public virtual System.Nullable<long> ReadOperations { get; set; }

        /// <summary>
        /// Total number of results returned, including documents, projections, aggregation results, keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsReturned")]
        public virtual System.Nullable<long> ResultsReturned { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A digest of all the documents that match a given target.</summary>
    public class ExistenceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of documents that match target_id. If different from the count of documents in the client
        /// that match, the client must manually determine which documents no longer match the target. The client can
        /// use the `unchanged_names` bloom filter to assist with this determination by testing ALL the document names
        /// against the filter; if the document name is NOT in the filter, it means the document no longer matches the
        /// target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>The target ID to which this filter applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual System.Nullable<int> TargetId { get; set; }

        /// <summary>
        /// A bloom filter that, despite its name, contains the UTF-8 byte encodings of the resource names of ALL the
        /// documents that match target_id, in the form
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. This bloom filter may be omitted
        /// at the server's discretion, such as if it is deemed that the client will not make use of it or if it is too
        /// computationally expensive to calculate or transmit. Clients must gracefully handle this field being absent
        /// by falling back to the logic used before this field existed; that is, re-add the target without a resume
        /// token to figure out which documents in the client's cache are out of sync.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unchangedNames")]
        public virtual BloomFilter UnchangedNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explain metrics for the query.</summary>
    public class ExplainMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Aggregated stats from the execution of the query. Only present when ExplainOptions.analyze is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStats")]
        public virtual ExecutionStats ExecutionStats { get; set; }

        /// <summary>Planning phase information for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("planSummary")]
        public virtual PlanSummary PlanSummary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explain options for the query.</summary>
    public class ExplainOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to execute this query. When false (the default), the query will be planned, returning only
        /// metrics from the planning stages. When true, the query will be planned and executed, returning the full
        /// query results along with both planning and execution stage metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyze")]
        public virtual System.Nullable<bool> Analyze { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter on a specific field.</summary>
    public class FieldFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field to filter by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual FieldReference Field { get; set; }

        /// <summary>The operator to filter by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; }

        /// <summary>The value to compare to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a field in a document, ex: `stats.operations`.</summary>
    public class FieldReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A reference to a field in a document. Requires: * MUST be a dot-delimited (`.`) string of segments, where
        /// each segment conforms to document field name limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transformation of a field of the document.</summary>
    public class FieldTransform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Append the given elements in order if they are not already present in the current field value. If the field
        /// is not an array, or if the field does not yet exist, it is first set to the empty array. Equivalent numbers
        /// of different types (e.g. 3L and 3.0) are considered equal when checking if a value is missing. NaN is equal
        /// to NaN, and Null is equal to Null. If the input contains multiple equivalent values, only the first will be
        /// considered. The corresponding transform_result will be the null value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendMissingElements")]
        public virtual ArrayValue AppendMissingElements { get; set; }

        /// <summary>The path of the field. See Document.fields for the field path syntax reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>
        /// Adds the given value to the field's current value. This must be an integer or a double value. If the field
        /// is not an integer or double, or if the field does not yet exist, the transformation will set the field to
        /// the given value. If either of the given value or the current field value are doubles, both values will be
        /// interpreted as doubles. Double arithmetic and representation of double values follow IEEE 754 semantics. If
        /// there is positive/negative integer overflow, the field is resolved to the largest magnitude
        /// positive/negative integer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("increment")]
        public virtual Value Increment { get; set; }

        /// <summary>
        /// Sets the field to the maximum of its current value and the given value. This must be an integer or a double
        /// value. If the field is not an integer or double, or if the field does not yet exist, the transformation will
        /// set the field to the given value. If a maximum operation is applied where the field and the input value are
        /// of mixed types (that is - one is an integer and one is a double) the field takes on the type of the larger
        /// operand. If the operands are equivalent (e.g. 3 and 3.0), the field does not change. 0, 0.0, and -0.0 are
        /// all zero. The maximum of a zero stored value and zero input value is always the stored value. The maximum of
        /// any numeric value x and NaN is NaN.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual Value Maximum { get; set; }

        /// <summary>
        /// Sets the field to the minimum of its current value and the given value. This must be an integer or a double
        /// value. If the field is not an integer or double, or if the field does not yet exist, the transformation will
        /// set the field to the input value. If a minimum operation is applied where the field and the input value are
        /// of mixed types (that is - one is an integer and one is a double) the field takes on the type of the smaller
        /// operand. If the operands are equivalent (e.g. 3 and 3.0), the field does not change. 0, 0.0, and -0.0 are
        /// all zero. The minimum of a zero stored value and zero input value is always the stored value. The minimum of
        /// any numeric value x and NaN is NaN.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual Value Minimum { get; set; }

        /// <summary>
        /// Remove all of the given elements from the array in the field. If the field is not an array, or if the field
        /// does not yet exist, it is set to the empty array. Equivalent numbers of the different types (e.g. 3L and
        /// 3.0) are considered equal when deciding whether an element should be removed. NaN is equal to NaN, and Null
        /// is equal to Null. This will remove all equivalent values if there are duplicates. The corresponding
        /// transform_result will be the null value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeAllFromArray")]
        public virtual ArrayValue RemoveAllFromArray { get; set; }

        /// <summary>Sets the field to the given server value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setToServerValue")]
        public virtual string SetToServerValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A composite filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeFilter")]
        public virtual CompositeFilter CompositeFilter { get; set; }

        /// <summary>A filter on a document field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldFilter")]
        public virtual FieldFilter FieldFilter { get; set; }

        /// <summary>A filter that takes exactly one argument.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unaryFilter")]
        public virtual UnaryFilter UnaryFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Nearest Neighbors search config. The ordering provided by FindNearest supersedes the order_by stage. If multiple
    /// documents have the same vector distance, the returned document order is not guaranteed to be stable between
    /// queries.
    /// </summary>
    public class FindNearest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The distance measure to use, required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceMeasure")]
        public virtual string DistanceMeasure { get; set; }

        /// <summary>
        /// Optional. Optional name of the field to output the result of the vector distance calculation. Must conform
        /// to document field name limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceResultField")]
        public virtual string DistanceResultField { get; set; }

        /// <summary>
        /// Optional. Option to specify a threshold for which no less similar documents will be returned. The behavior
        /// of the specified `distance_measure` will affect the meaning of the distance threshold. Since DOT_PRODUCT
        /// distances increase when the vectors are more similar, the comparison is inverted. * For EUCLIDEAN, COSINE:
        /// `WHERE distance &amp;lt;= distance_threshold` * For DOT_PRODUCT: `WHERE distance &amp;gt;=
        /// distance_threshold`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceThreshold")]
        public virtual System.Nullable<double> DistanceThreshold { get; set; }

        /// <summary>
        /// Required. The number of nearest neighbors to return. Must be a positive integer of no more than 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<int> Limit { get; set; }

        /// <summary>
        /// Required. The query vector that we are searching on. Must be a vector of no more than 2048 dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryVector")]
        public virtual Value QueryVector { get; set; }

        /// <summary>
        /// Required. An indexed vector field to search upon. Only documents which contain vectors whose dimensionality
        /// match the query_vector can be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vectorField")]
        public virtual FieldReference VectorField { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.BulkDeleteDocuments.</summary>
    public class GoogleFirestoreAdminV1BulkDeleteDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IDs of the collection groups that are being deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time this operation completed. Will be unset if operation still in progress.</summary>
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

        /// <summary>Which namespace IDs are being deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1Progress ProgressDocuments { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

        /// <summary>
        /// The timestamp that corresponds to the version of the database that is being read to get the list of
        /// documents to delete. This time can also be used as the timestamp of PITR in case of disaster recovery
        /// (subject to PITR window limit).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotTime")]
        public virtual string SnapshotTimeRaw
        {
            get => _snapshotTimeRaw;
            set
            {
                _snapshotTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _snapshotTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SnapshotTimeDateTimeOffset instead.")]
        public virtual object SnapshotTime
        {
            get => _snapshotTime;
            set
            {
                _snapshotTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _snapshotTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SnapshotTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SnapshotTimeRaw);
            set => SnapshotTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time this operation started.</summary>
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

    /// <summary>Metadata related to the create database operation.</summary>
    public class GoogleFirestoreAdminV1CreateDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to the delete database operation.</summary>
    public class GoogleFirestoreAdminV1DeleteDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the progress of the operation. Unit of work is generic and must be interpreted based on where Progress
    /// is used.
    /// </summary>
    public class GoogleFirestoreAdminV1Progress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount of work completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedWork")]
        public virtual System.Nullable<long> CompletedWork { get; set; }

        /// <summary>The amount of work estimated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedWork")]
        public virtual System.Nullable<long> EstimatedWork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the long-running operation from the RestoreDatabase request.</summary>
    public class GoogleFirestoreAdminV1RestoreDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the backup restoring from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>The name of the database being restored to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the restore finished, unset for ongoing restores.</summary>
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

        /// <summary>The operation state of the restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>How far along the restore is as an estimated percentage of remaining time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercentage")]
        public virtual GoogleFirestoreAdminV1Progress ProgressPercentage { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the restore was started.</summary>
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

    /// <summary>Metadata related to the update database operation.</summary>
    public class GoogleFirestoreAdminV1UpdateDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ExportDocuments operations.</summary>
    public class GoogleFirestoreAdminV1beta1ExportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids are being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// The time the operation ended, either successfully or otherwise. Unset if the operation is still active.
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

        /// <summary>The state of the export operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>Where the entities are being exported to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1beta1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of documents processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1beta1Progress ProgressDocuments { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time that work began on the operation.</summary>
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

    /// <summary>The request for FirestoreAdmin.ExportDocuments.</summary>
    public class GoogleFirestoreAdminV1beta1ExportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids to export. Unspecified means all collections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// The output URI. Currently only supports Google Cloud Storage URIs of the form:
        /// `gs://BUCKET_NAME[/NAMESPACE_PATH]`, where `BUCKET_NAME` is the name of the Google Cloud Storage bucket and
        /// `NAMESPACE_PATH` is an optional Google Cloud Storage namespace path. When choosing a name, be sure to
        /// consider Google Cloud Storage naming guidelines: https://cloud.google.com/storage/docs/naming. If the URI is
        /// a bucket (without a namespace path), a prefix will be generated based on the start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Returned in the google.longrunning.Operation response field.</summary>
    public class GoogleFirestoreAdminV1beta1ExportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location of the output files. This can be used to begin an import into Cloud Firestore (this project or
        /// another project) after the operation completes successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for ImportDocuments operations.</summary>
    public class GoogleFirestoreAdminV1beta1ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids are being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// The time the operation ended, either successfully or otherwise. Unset if the operation is still active.
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

        /// <summary>The location of the documents being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUriPrefix")]
        public virtual string InputUriPrefix { get; set; }

        /// <summary>The state of the import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>An estimate of the number of bytes processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1beta1Progress ProgressBytes { get; set; }

        /// <summary>An estimate of the number of documents processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1beta1Progress ProgressDocuments { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time that work began on the operation.</summary>
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

    /// <summary>The request for FirestoreAdmin.ImportDocuments.</summary>
    public class GoogleFirestoreAdminV1beta1ImportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids to import. Unspecified means all collections included in the import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// Location of the exported files. This must match the output_uri_prefix of an ExportDocumentsResponse from an
        /// export that has completed successfully. See:
        /// google.firestore.admin.v1beta1.ExportDocumentsResponse.output_uri_prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUriPrefix")]
        public virtual string InputUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An index definition.</summary>
    public class GoogleFirestoreAdminV1beta1Index : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection ID to which this index applies. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionId")]
        public virtual string CollectionId { get; set; }

        /// <summary>The fields to index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1beta1IndexField> Fields { get; set; }

        /// <summary>The resource name of the index. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The state of the index. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A field of an index.</summary>
    public class GoogleFirestoreAdminV1beta1IndexField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The path of the field. Must match the field path specification described by
        /// google.firestore.v1beta1.Document.fields. Special field path `__name__` may be used by itself or at the end
        /// of a path. `__type__` may be used only at the end of path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>The field's mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for index operations. This metadata populates the metadata field of google.longrunning.Operation.
    /// </summary>
    public class GoogleFirestoreAdminV1beta1IndexOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the [google.longrunning.Operation] was cancelled. If the cancellation is in progress, cancelled will
        /// be true but google.longrunning.Operation.done will be false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelled")]
        public virtual System.Nullable<bool> Cancelled { get; set; }

        /// <summary>Progress of the existing operation, measured in number of documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentProgress")]
        public virtual GoogleFirestoreAdminV1beta1Progress DocumentProgress { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// The time the operation ended, either successfully or otherwise. Unset if the operation is still active.
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

        /// <summary>
        /// The index resource that this operation is acting on. For example:
        /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual string Index { get; set; }

        /// <summary>The type of index operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time that work began on the operation.</summary>
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

    /// <summary>The response for FirestoreAdmin.ListIndexes.</summary>
    public class GoogleFirestoreAdminV1beta1ListIndexesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The indexes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1beta1Index> Indexes { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata message for google.cloud.location.Location.metadata.</summary>
    public class GoogleFirestoreAdminV1beta1LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Measures the progress of a particular metric.</summary>
    public class GoogleFirestoreAdminV1beta1Progress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An estimate of how much work has been completed. Note that this may be greater than `work_estimated`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workCompleted")]
        public virtual System.Nullable<long> WorkCompleted { get; set; }

        /// <summary>
        /// An estimate of how much work needs to be performed. Zero if the work estimate is unavailable. May change as
        /// work progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workEstimated")]
        public virtual System.Nullable<long> WorkEstimated { get; set; }

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
        public virtual Status Error { get; set; }

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
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.ListCollectionIds.</summary>
    public class ListCollectionIdsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum number of results to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>A page token. Must be a value from ListCollectionIdsResponse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Reads documents as they were at the given time. This must be a microsecond precision timestamp within the
        /// past one hour, or if Point-in-Time Recovery is enabled, can additionally be a whole minute timestamp within
        /// the past 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from Firestore.ListCollectionIds.</summary>
    public class ListCollectionIdsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection ids.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>A page token that may be used to continue the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.ListDocuments.</summary>
    public class ListDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Documents found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual System.Collections.Generic.IList<Document> Documents { get; set; }

        /// <summary>
        /// A token to retrieve the next page of documents. If this field is omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for Firestore.Listen</summary>
    public class ListenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A target to add to this stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addTarget")]
        public virtual Target AddTarget { get; set; }

        /// <summary>Labels associated with this target change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ID of a target to remove from this stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeTarget")]
        public virtual System.Nullable<int> RemoveTarget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.Listen.</summary>
    public class ListenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Document has changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentChange")]
        public virtual DocumentChange DocumentChange { get; set; }

        /// <summary>A Document has been deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentDelete")]
        public virtual DocumentDelete DocumentDelete { get; set; }

        /// <summary>
        /// A Document has been removed from a target (because it is no longer relevant to that target).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentRemove")]
        public virtual DocumentRemove DocumentRemove { get; set; }

        /// <summary>
        /// A filter to apply to the set of documents previously returned for the given target. Returned when documents
        /// may have been removed from the given target, but the exact documents are unknown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual ExistenceFilter Filter { get; set; }

        /// <summary>Targets have changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetChange")]
        public virtual TargetChange TargetChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A map value.</summary>
    public class MapValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The map's fields. The map keys represent field names. Field names matching the regular expression `__.*__`
        /// are reserved. Reserved field names are forbidden except in certain documented contexts. The map keys,
        /// represented as UTF-8, must not exceed 1,500 bytes and cannot be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, Value> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An order on a field.</summary>
    public class Order : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The direction to order by. Defaults to `ASCENDING`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>The field to order by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual FieldReference Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.PartitionQuery.</summary>
    public class PartitionQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of partitions to return in this call, subject to `partition_count`. For example, if
        /// `partition_count` = 10 and `page_size` = 8, the first call to PartitionQuery will return up to 8 partitions
        /// and a `next_page_token` if more results exist. A second call to PartitionQuery will return up to 2
        /// partitions, to complete the total of 10 specified in `partition_count`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The `next_page_token` value returned from a previous call to PartitionQuery that may be used to get an
        /// additional set of results. There are no ordering guarantees between sets of results. Thus, using multiple
        /// sets of results will require merging the different result sets. For example, two subsequent calls using a
        /// page_token may return: * cursor B, cursor M, cursor Q * cursor A, cursor U, cursor W To obtain a complete
        /// result set ordered with respect to the results of the query supplied to PartitionQuery, the results sets
        /// should be merged: cursor A, cursor B, cursor M, cursor Q, cursor U, cursor W
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// The desired maximum number of partition points. The partitions may be returned across multiple pages of
        /// results. The number must be positive. The actual number of partitions returned may be fewer. For example,
        /// this may be set to one fewer than the number of parallel queries to be run, or in running a data pipeline
        /// job, one fewer than the number of workers or compute instances available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionCount")]
        public virtual System.Nullable<long> PartitionCount { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Reads documents as they were at the given time. This must be a microsecond precision timestamp within the
        /// past one hour, or if Point-in-Time Recovery is enabled, can additionally be a whole minute timestamp within
        /// the past 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A structured query. Query must specify collection with all descendants and be ordered by name ascending.
        /// Other filters, order bys, limits, offsets, and start/end cursors are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredQuery")]
        public virtual StructuredQuery StructuredQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.PartitionQuery.</summary>
    public class PartitionQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A page token that may be used to request an additional set of results, up to the number specified by
        /// `partition_count` in the PartitionQuery request. If blank, there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Partition results. Each partition is a split point that can be used by RunQuery as a starting or end point
        /// for the query results. The RunQuery requests must be made with the same query supplied to this
        /// PartitionQuery request. The partition cursors will be ordered according to same ordering as the results of
        /// the query supplied to PartitionQuery. For example, if a PartitionQuery request returns partition cursors A
        /// and B, running the following three queries will return the entire result set of the original query: * query,
        /// end_at A * query, start_at A, end_at B * query, start_at B An empty result may indicate that the query has
        /// too few results to be partitioned, or that the query is not yet supported for partitioning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<Cursor> Partitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Planning phase information for the query.</summary>
    public class PlanSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The indexes selected for the query. For example: [ {"query_scope": "Collection", "properties": "(foo ASC,
        /// __name__ ASC)"}, {"query_scope": "Collection", "properties": "(bar ASC, __name__ ASC)"} ]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexesUsed")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> IndexesUsed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A precondition on a document, used for conditional operations.</summary>
    public class Precondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When set to `true`, the target document must exist. When set to `false`, the target document must not exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exists")]
        public virtual System.Nullable<bool> Exists { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// When set, the target document must exist and have been last updated at that time. Timestamp must be
        /// microsecond aligned.
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

    /// <summary>The projection of document's fields to return.</summary>
    public class Projection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields to return. If empty, all fields are returned. To only return the name of the document, use
        /// `['__name__']`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<FieldReference> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A target specified by a query.</summary>
    public class QueryTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The parent resource name. In the format: `projects/{project_id}/databases/{database_id}/documents` or
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
        /// `projects/my-project/databases/my-database/documents` or
        /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>A structured query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredQuery")]
        public virtual StructuredQuery StructuredQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a transaction that can only be used to read documents.</summary>
    public class ReadOnly : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Reads documents at the given time. This must be a microsecond precision timestamp within the past one hour,
        /// or if Point-in-Time Recovery is enabled, can additionally be a whole minute timestamp within the past 7
        /// days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options for a transaction that can be used to read and write documents. Firestore does not allow 3rd party auth
    /// requests to create read-write. transactions.
    /// </summary>
    public class ReadWrite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional transaction to retry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryTransaction")]
        public virtual string RetryTransaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.Rollback.</summary>
    public class RollbackRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The transaction to roll back.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.RunAggregationQuery.</summary>
    public class RunAggregationQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Explain options for the query. If set, additional query statistics will be returned. If not, only
        /// query results will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainOptions")]
        public virtual ExplainOptions ExplainOptions { get; set; }

        /// <summary>
        /// Starts a new transaction as part of the query, defaulting to read-only. The new transaction ID will be
        /// returned as the first response in the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTransaction")]
        public virtual TransactionOptions NewTransaction { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Executes the query at the given timestamp. This must be a microsecond precision timestamp within the past
        /// one hour, or if Point-in-Time Recovery is enabled, can additionally be a whole minute timestamp within the
        /// past 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>An aggregation query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredAggregationQuery")]
        public virtual StructuredAggregationQuery StructuredAggregationQuery { get; set; }

        /// <summary>
        /// Run the aggregation within an already active transaction. The value here is the opaque transaction ID to
        /// execute the query in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.RunAggregationQuery.</summary>
    public class RunAggregationQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Query explain metrics. This is only present when the RunAggregationQueryRequest.explain_options is provided,
        /// and it is sent only once with the last response in the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainMetrics")]
        public virtual ExplainMetrics ExplainMetrics { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// The time at which the aggregate result was computed. This is always monotonically increasing; in this case,
        /// the previous AggregationResult in the result stream are guaranteed not to have changed between their
        /// `read_time` and this one. If the query returns no results, a response with `read_time` and no `result` will
        /// be sent, and this represents the time at which the query was run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A single aggregation result. Not present when reporting partial progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual AggregationResult Result { get; set; }

        /// <summary>
        /// The transaction that was started as part of this request. Only present on the first response when the
        /// request requested to start a new transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for Firestore.RunQuery.</summary>
    public class RunQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Explain options for the query. If set, additional query statistics will be returned. If not, only
        /// query results will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainOptions")]
        public virtual ExplainOptions ExplainOptions { get; set; }

        /// <summary>
        /// Starts a new transaction and reads the documents. Defaults to a read-only transaction. The new transaction
        /// ID will be returned as the first response in the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTransaction")]
        public virtual TransactionOptions NewTransaction { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Reads documents as they were at the given time. This must be a microsecond precision timestamp within the
        /// past one hour, or if Point-in-Time Recovery is enabled, can additionally be a whole minute timestamp within
        /// the past 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A structured query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredQuery")]
        public virtual StructuredQuery StructuredQuery { get; set; }

        /// <summary>
        /// Run the query within an already active transaction. The value here is the opaque transaction ID to execute
        /// the query in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.RunQuery.</summary>
    public class RunQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A query result, not set when reporting partial progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>
        /// If present, Firestore has completely finished the request and no more documents will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>
        /// Query explain metrics. This is only present when the RunQueryRequest.explain_options is provided, and it is
        /// sent only once with the last response in the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explainMetrics")]
        public virtual ExplainMetrics ExplainMetrics { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// The time at which the document was read. This may be monotonically increasing; in this case, the previous
        /// documents in the result stream are guaranteed not to have changed between their `read_time` and this one. If
        /// the query returns no results, a response with `read_time` and no `document` will be sent, and this
        /// represents the time at which the query was run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The number of results that have been skipped due to an offset between the last response and the current
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippedResults")]
        public virtual System.Nullable<int> SkippedResults { get; set; }

        /// <summary>
        /// The transaction that was started as part of this request. Can only be set in the first response, and only if
        /// RunQueryRequest.new_transaction was set in the request. If set, no other fields will be set in this
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

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

    /// <summary>Firestore query for running an aggregation over a StructuredQuery.</summary>
    public class StructuredAggregationQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Series of aggregations to apply over the results of the `structured_query`. Requires: * A minimum
        /// of one and maximum of five aggregations per query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregations")]
        public virtual System.Collections.Generic.IList<Aggregation> Aggregations { get; set; }

        /// <summary>Nested structured query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredQuery")]
        public virtual StructuredQuery StructuredQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Firestore query. The query stages are executed in the following order: 1. from 2. where 3. select 4. order_by
    /// + start_at + end_at 5. offset 6. limit 7. find_nearest
    /// </summary>
    public class StructuredQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A potential prefix of a position in the result set to end the query at. This is similar to `START_AT` but
        /// with it controlling the end position rather than the start position. Requires: * The number of values cannot
        /// be greater than the number of fields specified in the `ORDER BY` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endAt")]
        public virtual Cursor EndAt { get; set; }

        /// <summary>
        /// Optional. A potential nearest neighbors search. Applies after all other filters and ordering. Finds the
        /// closest vector embeddings to the given query vector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findNearest")]
        public virtual FindNearest FindNearest { get; set; }

        /// <summary>The collections to query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("from")]
        public virtual System.Collections.Generic.IList<CollectionSelector> From { get; set; }

        /// <summary>
        /// The maximum number of results to return. Applies after all other constraints. Requires: * The value must be
        /// greater than or equal to zero if specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<int> Limit { get; set; }

        /// <summary>
        /// The number of documents to skip before returning the first result. This applies after the constraints
        /// specified by the `WHERE`, `START AT`, &amp;amp; `END AT` but before the `LIMIT` clause. Requires: * The
        /// value must be greater than or equal to zero if specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The order to apply to the query results. Firestore allows callers to provide a full ordering, a partial
        /// ordering, or no ordering at all. In all cases, Firestore guarantees a stable ordering through the following
        /// rules: * The `order_by` is required to reference all fields used with an inequality filter. * All fields
        /// that are required to be in the `order_by` but are not already present are appended in lexicographical
        /// ordering of the field name. * If an order on `__name__` is not specified, it is appended by default. Fields
        /// are appended with the same sort direction as the last order specified, or 'ASCENDING' if no order was
        /// specified. For example: * `ORDER BY a` becomes `ORDER BY a ASC, __name__ ASC` * `ORDER BY a DESC` becomes
        /// `ORDER BY a DESC, __name__ DESC` * `WHERE a &amp;gt; 1` becomes `WHERE a &amp;gt; 1 ORDER BY a ASC, __name__
        /// ASC` * `WHERE __name__ &amp;gt; ... AND a &amp;gt; 1` becomes `WHERE __name__ &amp;gt; ... AND a &amp;gt; 1
        /// ORDER BY a ASC, __name__ ASC`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual System.Collections.Generic.IList<Order> OrderBy { get; set; }

        /// <summary>
        /// Optional sub-set of the fields to return. This acts as a DocumentMask over the documents returned from a
        /// query. When not set, assumes that the caller wants all fields returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("select")]
        public virtual Projection Select { get; set; }

        /// <summary>
        /// A potential prefix of a position in the result set to start the query at. The ordering of the result set is
        /// based on the `ORDER BY` clause of the original query.
        /// ```
        /// SELECT * FROM k WHERE a = 1 AND b &amp;gt; 2 ORDER
        /// BY b ASC, __name__ ASC;
        /// ```
        /// This query's results are ordered by `(b ASC, __name__ ASC)`. Cursors can
        /// reference either the full ordering or a prefix of the location, though it cannot reference more fields than
        /// what are in the provided `ORDER BY`. Continuing off the example above, attaching the following start cursors
        /// will have varying impact: - `START BEFORE (2, /k/123)`: start the query right before `a = 1 AND b &amp;gt; 2
        /// AND __name__ &amp;gt; /k/123`. - `START AFTER (10)`: start the query right after `a = 1 AND b &amp;gt; 10`.
        /// Unlike `OFFSET` which requires scanning over the first N results to skip, a start cursor allows the query to
        /// begin at a logical position. This position is not required to match an actual result, it will scan forward
        /// from this position to find the next document. Requires: * The number of values cannot be greater than the
        /// number of fields specified in the `ORDER BY` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startAt")]
        public virtual Cursor StartAt { get; set; }

        /// <summary>The filter to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("where")]
        public virtual Filter Where { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sum of the values of the requested field. * Only numeric values will be aggregated. All non-numeric values
    /// including `NULL` are skipped. * If the aggregated values contain `NaN`, returns `NaN`. Infinity math follows
    /// IEEE-754 standards. * If the aggregated value set is empty, returns 0. * Returns a 64-bit integer if all
    /// aggregated numbers are integers and the sum result does not overflow. Otherwise, the result is returned as a
    /// double. Note that even if all the aggregated values are integers, the result is returned as a double if it
    /// cannot fit within a 64-bit signed integer. When this occurs, the returned value will lose precision. * When
    /// underflow occurs, floating-point aggregation is non-deterministic. This means that running the same query
    /// repeatedly without any changes to the underlying values could produce slightly different results each time. In
    /// those cases, values should be stored as integers over floating-point numbers.
    /// </summary>
    public class Sum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field to aggregate on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual FieldReference Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of a set of documents to listen to.</summary>
    public class Target : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A target specified by a set of document names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual DocumentsTarget Documents { get; set; }

        /// <summary>
        /// The number of documents that last matched the query at the resume token or read time. This value is only
        /// relevant when a `resume_type` is provided. This value being present and greater than zero signals that the
        /// client wants `ExistenceFilter.unchanged_names` to be included in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedCount")]
        public virtual System.Nullable<int> ExpectedCount { get; set; }

        /// <summary>If the target should be removed once it is current and consistent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("once")]
        public virtual System.Nullable<bool> Once { get; set; }

        /// <summary>A target specified by a query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual QueryTarget Query { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Start listening after a specific `read_time`. The client must know the state of matching documents at this
        /// time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A resume token from a prior TargetChange for an identical target. Using a resume token with a different
        /// target is unsupported and may fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resumeToken")]
        public virtual string ResumeToken { get; set; }

        /// <summary>
        /// The target ID that identifies the target on the stream. Must be a positive number and non-zero. If
        /// `target_id` is 0 (or unspecified), the server will assign an ID for this target and return that in a
        /// `TargetChange::ADD` event. Once a target with `target_id=0` is added, all subsequent targets must also have
        /// `target_id=0`. If an `AddTarget` request with `target_id != 0` is sent to the server after a target with
        /// `target_id=0` is added, the server will immediately send a response with a `TargetChange::Remove` event.
        /// Note that if the client sends multiple `AddTarget` requests without an ID, the order of IDs returned in
        /// `TargetChange.target_ids` are undefined. Therefore, clients should provide a target ID instead of relying on
        /// the server to assign one. If `target_id` is non-zero, there must not be an existing active target on this
        /// stream with the same ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual System.Nullable<int> TargetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targets being watched have changed.</summary>
    public class TargetChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error that resulted in this change, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual Status Cause { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// The consistent `read_time` for the given `target_ids` (omitted when the target_ids are not at a consistent
        /// snapshot). The stream is guaranteed to send a `read_time` with `target_ids` empty whenever the entire stream
        /// reaches a new consistent snapshot. ADD, CURRENT, and RESET messages are guaranteed to (eventually) result in
        /// a new consistent snapshot (while NO_CHANGE and REMOVE messages are not). For a given stream, `read_time` is
        /// guaranteed to be monotonically increasing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A token that can be used to resume the stream for the given `target_ids`, or all targets if `target_ids` is
        /// empty. Not set on every target change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resumeToken")]
        public virtual string ResumeToken { get; set; }

        /// <summary>The type of change that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetChangeType")]
        public virtual string TargetChangeType { get; set; }

        /// <summary>
        /// The target IDs of targets that have changed. If empty, the change applies to all targets. The order of the
        /// target IDs is not defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> TargetIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for creating a new transaction.</summary>
    public class TransactionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transaction can only be used for read operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual ReadOnly ReadOnly__ { get; set; }

        /// <summary>The transaction can be used for both read and write operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readWrite")]
        public virtual ReadWrite ReadWrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter with a single operand.</summary>
    public class UnaryFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field to which to apply the operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual FieldReference Field { get; set; }

        /// <summary>The unary operator to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message that can hold any of the supported value types.</summary>
    public class Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An array value. Cannot directly contain another array value, though can contain a map which contains another
        /// array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayValue")]
        public virtual ArrayValue ArrayValue { get; set; }

        /// <summary>A boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>
        /// A bytes value. Must not exceed 1 MiB - 89 bytes. Only the first 1,500 bytes are considered by queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesValue")]
        public virtual string BytesValue { get; set; }

        /// <summary>A double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>A geo point value representing a point on the surface of Earth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoPointValue")]
        public virtual LatLng GeoPointValue { get; set; }

        /// <summary>An integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<long> IntegerValue { get; set; }

        /// <summary>A map value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapValue")]
        public virtual MapValue MapValue { get; set; }

        /// <summary>A null value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullValue")]
        public virtual string NullValue { get; set; }

        /// <summary>
        /// A reference to a document. For example:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceValue")]
        public virtual string ReferenceValue { get; set; }

        /// <summary>
        /// A string value. The string, represented as UTF-8, must not exceed 1 MiB - 89 bytes. Only the first 1,500
        /// bytes of the UTF-8 representation are considered by queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        private string _timestampValueRaw;

        private object _timestampValue;

        /// <summary>
        /// A timestamp value. Precise only to microseconds. When stored, any additional precision is rounded down.
        /// </summary>
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

    /// <summary>A write on a document.</summary>
    public class Write : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An optional precondition on the document. The write will fail if this is set and not met by the target
        /// document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentDocument")]
        public virtual Precondition CurrentDocument { get; set; }

        /// <summary>
        /// A document name to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delete")]
        public virtual string Delete { get; set; }

        /// <summary>Applies a transformation to a document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transform")]
        public virtual DocumentTransform Transform { get; set; }

        /// <summary>A document to write.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual Document Update { get; set; }

        /// <summary>
        /// The fields to update in this write. This field can be set only when the operation is `update`. If the mask
        /// is not set for an `update` and the document exists, any existing data will be overwritten. If the mask is
        /// set and the document on the server has fields not covered by the mask, they are left unchanged. Fields
        /// referenced in the mask, but not present in the input document, are deleted from the document on the server.
        /// The field paths in this mask must not contain a reserved field name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual DocumentMask UpdateMask { get; set; }

        /// <summary>
        /// The transforms to perform after update. This field can be set only when the operation is `update`. If
        /// present, this write is equivalent to performing `update` and `transform` to the same document atomically and
        /// in order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTransforms")]
        public virtual System.Collections.Generic.IList<FieldTransform> UpdateTransforms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request for Firestore.Write. The first request creates a stream, or resumes an existing one from a token.
    /// When creating a new stream, the server replies with a response containing only an ID and a token, to use in the
    /// next request. When resuming a stream, the server first streams any responses later than the given token, then a
    /// response containing only an up-to-date token, to use in the next request.
    /// </summary>
    public class WriteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Labels associated with this write request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The ID of the write stream to resume. This may only be set in the first message. When left empty, a new
        /// write stream will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamId")]
        public virtual string StreamId { get; set; }

        /// <summary>
        /// A stream token that was previously sent by the server. The client should set this field to the token from
        /// the most recent WriteResponse it has received. This acknowledges that the client has received responses up
        /// to this token. After sending this token, earlier tokens may not be used anymore. The server may close the
        /// stream if there are too many unacknowledged responses. Leave this field unset when creating a new stream. To
        /// resume a stream at a specific point, set this field and the `stream_id` field. Leave this field unset when
        /// creating a new stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamToken")]
        public virtual string StreamToken { get; set; }

        /// <summary>
        /// The writes to apply. Always executed atomically and in order. This must be empty on the first request. This
        /// may be empty on the last request. This must not be empty on all other requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writes")]
        public virtual System.Collections.Generic.IList<Write> Writes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.Write.</summary>
    public class WriteResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _commitTimeRaw;

        private object _commitTime;

        /// <summary>
        /// The time at which the commit occurred. Any read with an equal or greater `read_time` is guaranteed to see
        /// the effects of the write.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTime")]
        public virtual string CommitTimeRaw
        {
            get => _commitTimeRaw;
            set
            {
                _commitTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _commitTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CommitTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CommitTimeDateTimeOffset instead.")]
        public virtual object CommitTime
        {
            get => _commitTime;
            set
            {
                _commitTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _commitTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CommitTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CommitTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CommitTimeRaw);
            set => CommitTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ID of the stream. Only set on the first message, when a new stream was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamId")]
        public virtual string StreamId { get; set; }

        /// <summary>
        /// A token that represents the position of this response in the stream. This can be used by a client to resume
        /// the stream at this point. This field is always set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamToken")]
        public virtual string StreamToken { get; set; }

        /// <summary>
        /// The result of applying the writes. This i-th write result corresponds to the i-th write in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeResults")]
        public virtual System.Collections.Generic.IList<WriteResult> WriteResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of applying a write.</summary>
    public class WriteResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The results of applying each DocumentTransform.FieldTransform, in the same order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformResults")]
        public virtual System.Collections.Generic.IList<Value> TransformResults { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// The last update time of the document after applying the write. Not set after a `delete`. If the write did
        /// not actually change the document, this will be the previous update_time.
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
}
