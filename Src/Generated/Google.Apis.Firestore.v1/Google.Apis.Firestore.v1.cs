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

namespace Google.Apis.Firestore.v1
{
    /// <summary>The Firestore Service.</summary>
    public class FirestoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firestore";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://firestore.googleapis.com/";
        #else
            "https://firestore.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://firestore.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Firestore API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Cloud Datastore data</summary>
            public static string Datastore = "https://www.googleapis.com/auth/datastore";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Firestore API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
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
            Locations = new LocationsResource(service);
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
                CollectionGroups = new CollectionGroupsResource(service);
                Documents = new DocumentsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the CollectionGroups resource.</summary>
            public virtual CollectionGroupsResource CollectionGroups { get; }

            /// <summary>The "collectionGroups" collection of methods.</summary>
            public class CollectionGroupsResource
            {
                private const string Resource = "collectionGroups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CollectionGroupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Fields = new FieldsResource(service);
                    Indexes = new IndexesResource(service);
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
                    }

                    /// <summary>Gets the metadata and configuration for a Field.</summary>
                    /// <param name="name">
                    /// Required. A name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the metadata and configuration for a Field.</summary>
                    public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Field>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
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
                                Pattern = @"^projects/[^/]+/databases/[^/]+/collectionGroups/[^/]+/fields/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists the field configuration and metadata for this database. Currently,
                    /// FirestoreAdmin.ListFields only supports listing fields that have been explicitly overridden. To
                    /// issue this query, call FirestoreAdmin.ListFields with the filter set to
                    /// `indexConfig.usesAncestorConfig:false` .
                    /// </summary>
                    /// <param name="parent">
                    /// Required. A parent name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists the field configuration and metadata for this database. Currently,
                    /// FirestoreAdmin.ListFields only supports listing fields that have been explicitly overridden. To
                    /// issue this query, call FirestoreAdmin.ListFields with the filter set to
                    /// `indexConfig.usesAncestorConfig:false` .
                    /// </summary>
                    public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ListFieldsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A parent name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The filter to apply to list results. Currently, FirestoreAdmin.ListFields only supports
                        /// listing fields that have been explicitly overridden. To issue this query, call
                        /// FirestoreAdmin.ListFields with a filter that includes `indexConfig.usesAncestorConfig:false`
                        /// .
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The number of results to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, returned from a previous call to FirestoreAdmin.ListFields, that may be used
                        /// to get the next page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/fields";

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
                                Pattern = @"^projects/[^/]+/databases/[^/]+/collectionGroups/[^/]+$",
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
                    /// Updates a field configuration. Currently, field updates apply only to single field index
                    /// configuration. However, calls to FirestoreAdmin.UpdateField should provide a field mask to avoid
                    /// changing any configuration that the caller isn't aware of. The field mask should be specified
                    /// as: `{ paths: "index_config" }`. This call returns a google.longrunning.Operation which may be
                    /// used to track the status of the field update. The metadata for the operation will be the type
                    /// FieldOperationMetadata. To configure the default field settings for the database, use the
                    /// special `Field` with resource name:
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. A field name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}`
                    /// A field path may be a simple field name, e.g. `address` or a path to fields within map_value ,
                    /// e.g. `address.city`, or a special field path. The only valid special field is `*`, which
                    /// represents any field. Field paths may be quoted using ` (backtick). The only character that
                    /// needs to be escaped within a quoted field path is the backtick character itself, escaped using a
                    /// backslash. Special characters in field paths that must be quoted include: `*`, `.`, ```
                    /// (backtick), `[`, `]`, as well as any ascii symbolic characters. Examples: (Note: Comments here
                    /// are written in markdown syntax, so there is an additional layer of backticks to represent a code
                    /// block) `\`address.city\`` represents a field named `address.city`, not the map key `city` in the
                    /// field `address`. `\`*\`` represents a field named `*`, not any field. A special `Field` contains
                    /// the default indexing settings for all fields. This field's resource name is:
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*` Indexes
                    /// defined on this `Field` will be applied to all fields which do not have their own `Field` index
                    /// configuration.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Field body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates a field configuration. Currently, field updates apply only to single field index
                    /// configuration. However, calls to FirestoreAdmin.UpdateField should provide a field mask to avoid
                    /// changing any configuration that the caller isn't aware of. The field mask should be specified
                    /// as: `{ paths: "index_config" }`. This call returns a google.longrunning.Operation which may be
                    /// used to track the status of the field update. The metadata for the operation will be the type
                    /// FieldOperationMetadata. To configure the default field settings for the database, use the
                    /// special `Field` with resource name:
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
                    /// </summary>
                    public class PatchRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Field body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A field name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}`
                        /// A field path may be a simple field name, e.g. `address` or a path to fields within map_value
                        /// , e.g. `address.city`, or a special field path. The only valid special field is `*`, which
                        /// represents any field. Field paths may be quoted using ` (backtick). The only character that
                        /// needs to be escaped within a quoted field path is the backtick character itself, escaped
                        /// using a backslash. Special characters in field paths that must be quoted include: `*`, `.`,
                        /// ``` (backtick), `[`, `]`, as well as any ascii symbolic characters. Examples: (Note:
                        /// Comments here are written in markdown syntax, so there is an additional layer of backticks
                        /// to represent a code block) `\`address.city\`` represents a field named `address.city`, not
                        /// the map key `city` in the field `address`. `\`*\`` represents a field named `*`, not any
                        /// field. A special `Field` contains the default indexing settings for all fields. This field's
                        /// resource name is:
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`
                        /// Indexes defined on this `Field` will be applied to all fields which do not have their own
                        /// `Field` index configuration.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A mask, relative to the field. If specified, only configuration specified by this field_mask
                        /// will be updated in the field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Field Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/databases/[^/]+/collectionGroups/[^/]+/fields/[^/]+$",
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
                    /// Creates a composite index. This returns a google.longrunning.Operation which may be used to
                    /// track the status of the creation. The metadata for the operation will be the type
                    /// IndexOperationMetadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. A parent name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Index body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a composite index. This returns a google.longrunning.Operation which may be used to
                    /// track the status of the creation. The metadata for the operation will be the type
                    /// IndexOperationMetadata.
                    /// </summary>
                    public class CreateRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Index body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A parent name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Index Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/indexes";

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
                                Pattern = @"^projects/[^/]+/databases/[^/]+/collectionGroups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a composite index.</summary>
                    /// <param name="name">
                    /// Required. A name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a composite index.</summary>
                    public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
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
                                Pattern = @"^projects/[^/]+/databases/[^/]+/collectionGroups/[^/]+/indexes/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a composite index.</summary>
                    /// <param name="name">
                    /// Required. A name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a composite index.</summary>
                    public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Index>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
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
                                Pattern = @"^projects/[^/]+/databases/[^/]+/collectionGroups/[^/]+/indexes/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists composite indexes.</summary>
                    /// <param name="parent">
                    /// Required. A parent name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists composite indexes.</summary>
                    public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ListIndexesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A parent name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The number of results to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, returned from a previous call to FirestoreAdmin.ListIndexes, that may be used
                        /// to get the next page of results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/indexes";

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
                                Pattern = @"^projects/[^/]+/databases/[^/]+/collectionGroups/[^/]+$",
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
                public virtual BatchGetRequest BatchGet(Google.Apis.Firestore.v1.Data.BatchGetDocumentsRequest body, string database)
                {
                    return new BatchGetRequest(service, body, database);
                }

                /// <summary>
                /// Gets multiple documents. Documents returned by this method are not guaranteed to be returned in the
                /// same order that they were requested.
                /// </summary>
                public class BatchGetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.BatchGetDocumentsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.BatchGetDocumentsRequest body, string database) : base(service)
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
                    Google.Apis.Firestore.v1.Data.BatchGetDocumentsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/documents:batchGet";

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
                public virtual BatchWriteRequest BatchWrite(Google.Apis.Firestore.v1.Data.BatchWriteRequest body, string database)
                {
                    return new BatchWriteRequest(service, body, database);
                }

                /// <summary>
                /// Applies a batch of write operations. The BatchWrite method does not apply the write operations
                /// atomically and can apply them out of order. Method does not allow more than one write per document.
                /// Each write succeeds or fails independently. See the BatchWriteResponse for the success status of
                /// each write. If you require an atomically applied set of writes, use Commit instead.
                /// </summary>
                public class BatchWriteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.BatchWriteResponse>
                {
                    /// <summary>Constructs a new BatchWrite request.</summary>
                    public BatchWriteRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.BatchWriteRequest body, string database) : base(service)
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
                    Google.Apis.Firestore.v1.Data.BatchWriteRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchWrite";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/documents:batchWrite";

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
                public virtual BeginTransactionRequest BeginTransaction(Google.Apis.Firestore.v1.Data.BeginTransactionRequest body, string database)
                {
                    return new BeginTransactionRequest(service, body, database);
                }

                /// <summary>Starts a new transaction.</summary>
                public class BeginTransactionRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.BeginTransactionResponse>
                {
                    /// <summary>Constructs a new BeginTransaction request.</summary>
                    public BeginTransactionRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.BeginTransactionRequest body, string database) : base(service)
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
                    Google.Apis.Firestore.v1.Data.BeginTransactionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "beginTransaction";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/documents:beginTransaction";

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
                public virtual CommitRequest Commit(Google.Apis.Firestore.v1.Data.CommitRequest body, string database)
                {
                    return new CommitRequest(service, body, database);
                }

                /// <summary>Commits a transaction, while optionally updating documents.</summary>
                public class CommitRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.CommitResponse>
                {
                    /// <summary>Constructs a new Commit request.</summary>
                    public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.CommitRequest body, string database) : base(service)
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
                    Google.Apis.Firestore.v1.Data.CommitRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "commit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/documents:commit";

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
                public virtual CreateDocumentRequest CreateDocument(Google.Apis.Firestore.v1.Data.Document body, string parent, string collectionId)
                {
                    return new CreateDocumentRequest(service, body, parent, collectionId);
                }

                /// <summary>Creates a new document.</summary>
                public class CreateDocumentRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Document>
                {
                    /// <summary>Constructs a new CreateDocument request.</summary>
                    public CreateDocumentRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.Document body, string parent, string collectionId) : base(service)
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
                    Google.Apis.Firestore.v1.Data.Document Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createDocument";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/{collectionId}";

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
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a document.</summary>
                public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Empty>
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

                    /// <summary>
                    /// When set, the target document must exist and have been last updated at that time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currentDocument.updateTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CurrentDocumentUpdateTime { get; set; }

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
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a single document.</summary>
                public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Document>
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

                    /// <summary>
                    /// Reads the version of the document at the given time. This may not be older than 270 seconds.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>Reads the document in a transaction.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("transaction", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Transaction { get; set; }

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
                /// Required. The collection ID, relative to `parent`, to list. For example: `chatrooms` or `messages`.
                /// </param>
                public virtual ListRequest List(string parent, string collectionId)
                {
                    return new ListRequest(service, parent, collectionId);
                }

                /// <summary>Lists documents.</summary>
                public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.ListDocumentsResponse>
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
                    /// Required. The collection ID, relative to `parent`, to list. For example: `chatrooms` or
                    /// `messages`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("collectionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CollectionId { get; private set; }

                    /// <summary>
                    /// The list of field paths in the mask. See Document.fields for a field path syntax reference.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("mask.fieldPaths", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> MaskFieldPaths { get; set; }

                    /// <summary>The order to sort results by. For example: `priority desc, name`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of documents to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The `next_page_token` value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Reads documents as they were at the given time. This may not be older than 270 seconds.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>
                    /// If the list should show missing documents. A missing document is a document that does not exist
                    /// but has sub-documents. These documents will be returned with a key but will not have fields,
                    /// Document.create_time, or Document.update_time set. Requests with `show_missing` may not specify
                    /// `where` or `order_by`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("showMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowMissing { get; set; }

                    /// <summary>Reads documents in a transaction.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("transaction", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Transaction { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/{collectionId}";

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
                public virtual ListCollectionIdsRequest ListCollectionIds(Google.Apis.Firestore.v1.Data.ListCollectionIdsRequest body, string parent)
                {
                    return new ListCollectionIdsRequest(service, body, parent);
                }

                /// <summary>Lists all the collection IDs underneath a document.</summary>
                public class ListCollectionIdsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.ListCollectionIdsResponse>
                {
                    /// <summary>Constructs a new ListCollectionIds request.</summary>
                    public ListCollectionIdsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.ListCollectionIdsRequest body, string parent) : base(service)
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
                    Google.Apis.Firestore.v1.Data.ListCollectionIdsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listCollectionIds";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:listCollectionIds";

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

                /// <summary>Listens to changes.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`.
                /// </param>
                public virtual ListenRequest Listen(Google.Apis.Firestore.v1.Data.ListenRequest body, string database)
                {
                    return new ListenRequest(service, body, database);
                }

                /// <summary>Listens to changes.</summary>
                public class ListenRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.ListenResponse>
                {
                    /// <summary>Constructs a new Listen request.</summary>
                    public ListenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.ListenRequest body, string database) : base(service)
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
                    Google.Apis.Firestore.v1.Data.ListenRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listen";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/documents:listen";

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
                public virtual PartitionQueryRequest PartitionQuery(Google.Apis.Firestore.v1.Data.PartitionQueryRequest body, string parent)
                {
                    return new PartitionQueryRequest(service, body, parent);
                }

                /// <summary>
                /// Partitions a query by returning partition cursors that can be used to run the query in parallel. The
                /// returned partition cursors are split points that can be used by RunQuery as starting/end points for
                /// the query results.
                /// </summary>
                public class PartitionQueryRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.PartitionQueryResponse>
                {
                    /// <summary>Constructs a new PartitionQuery request.</summary>
                    public PartitionQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.PartitionQueryRequest body, string parent) : base(service)
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
                    Google.Apis.Firestore.v1.Data.PartitionQueryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "partitionQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:partitionQuery";

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
                public virtual PatchRequest Patch(Google.Apis.Firestore.v1.Data.Document body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates or inserts a document.</summary>
                public class PatchRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Document>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.Document body, string name) : base(service)
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

                    /// <summary>
                    /// When set, the target document must exist and have been last updated at that time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("currentDocument.updateTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CurrentDocumentUpdateTime { get; set; }

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
                    Google.Apis.Firestore.v1.Data.Document Body { get; set; }

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
                public virtual RollbackRequest Rollback(Google.Apis.Firestore.v1.Data.RollbackRequest body, string database)
                {
                    return new RollbackRequest(service, body, database);
                }

                /// <summary>Rolls back a transaction.</summary>
                public class RollbackRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Rollback request.</summary>
                    public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.RollbackRequest body, string database) : base(service)
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
                    Google.Apis.Firestore.v1.Data.RollbackRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rollback";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/documents:rollback";

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

                /// <summary>Runs a query.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name. In the format:
                /// `projects/{project_id}/databases/{database_id}/documents` or
                /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`. For example:
                /// `projects/my-project/databases/my-database/documents` or
                /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
                /// </param>
                public virtual RunQueryRequest RunQuery(Google.Apis.Firestore.v1.Data.RunQueryRequest body, string parent)
                {
                    return new RunQueryRequest(service, body, parent);
                }

                /// <summary>Runs a query.</summary>
                public class RunQueryRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.RunQueryResponse>
                {
                    /// <summary>Constructs a new RunQuery request.</summary>
                    public RunQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.RunQueryRequest body, string parent) : base(service)
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
                    Google.Apis.Firestore.v1.Data.RunQueryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "runQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:runQuery";

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

                /// <summary>Streams batches of document updates and deletes, in order.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`. This is
                /// only required in the first message.
                /// </param>
                public virtual WriteRequest Write(Google.Apis.Firestore.v1.Data.WriteRequest body, string database)
                {
                    return new WriteRequest(service, body, database);
                }

                /// <summary>Streams batches of document updates and deletes, in order.</summary>
                public class WriteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.WriteResponse>
                {
                    /// <summary>Constructs a new Write request.</summary>
                    public WriteRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.WriteRequest body, string database) : base(service)
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
                    Google.Apis.Firestore.v1.Data.WriteRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "write";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+database}/documents:write";

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
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Firestore.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be deleted.</summary>
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/operations/[^/]+$",
                        });
                    }
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
                public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/operations/[^/]+$",
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
                public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningListOperationsResponse>
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
                    public override string RestPath => "v1/{+name}/operations";

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
            /// operation is cancelled before completion it may leave partial data behind in Google Cloud Storage. For
            /// more details on export behavior and output format, refer to:
            /// https://cloud.google.com/firestore/docs/manage-data/export-import
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Database to export. Should be of the form: `projects/{project_id}/databases/{database_id}`.
            /// </param>
            public virtual ExportDocumentsRequest ExportDocuments(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ExportDocumentsRequest body, string name)
            {
                return new ExportDocumentsRequest(service, body, name);
            }

            /// <summary>
            /// Exports a copy of all or a subset of documents from Google Cloud Firestore to another storage system,
            /// such as Google Cloud Storage. Recent updates to documents may not be reflected in the export. The export
            /// occurs in the background and its progress can be monitored and managed via the Operation resource that
            /// is created. The output of an export may only be used once the associated operation is done. If an export
            /// operation is cancelled before completion it may leave partial data behind in Google Cloud Storage. For
            /// more details on export behavior and output format, refer to:
            /// https://cloud.google.com/firestore/docs/manage-data/export-import
            /// </summary>
            public class ExportDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ExportDocuments request.</summary>
                public ExportDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ExportDocumentsRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Database to export. Should be of the form:
                /// `projects/{project_id}/databases/{database_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ExportDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportDocuments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:exportDocuments";

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
            /// Required. Database to import into. Should be of the form:
            /// `projects/{project_id}/databases/{database_id}`.
            /// </param>
            public virtual ImportDocumentsRequest ImportDocuments(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ImportDocumentsRequest body, string name)
            {
                return new ImportDocumentsRequest(service, body, name);
            }

            /// <summary>
            /// Imports documents into Google Cloud Firestore. Existing documents with the same name are overwritten.
            /// The import occurs in the background and its progress can be monitored and managed via the Operation
            /// resource that is created. If an ImportDocuments operation is cancelled, it is possible that a subset of
            /// the data has already been imported to Cloud Firestore.
            /// </summary>
            public class ImportDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ImportDocuments request.</summary>
                public ImportDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ImportDocumentsRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Database to import into. Should be of the form:
                /// `projects/{project_id}/databases/{database_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ImportDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "importDocuments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:importDocuments";

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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/locations";

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
namespace Google.Apis.Firestore.v1.Data
{
    /// <summary>An array value.</summary>
    public class ArrayValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Values in the array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Value> Values { get; set; }

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

        /// <summary>Reads documents as they were at the given time. This may not be older than 270 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

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

        /// <summary>
        /// The time at which the document was read. This may be monotically increasing, in this case the previous
        /// documents in the result stream are guaranteed not to have changed between their read_time and this one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

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
        /// <summary>
        /// The time at which the commit occurred. Any read with an equal or greater `read_time` is guaranteed to see
        /// the effects of the commit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTime")]
        public virtual object CommitTime { get; set; }

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
        /// <summary>The list of filters to combine. Must contain at least one filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<Filter> Filters { get; set; }

        /// <summary>The operator for combining multiple filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; }

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
        /// <summary>
        /// Output only. The time at which the document was created. This value increases monotonically when a document
        /// is deleted then recreated. It can also be compared to values from other documents and the `read_time` of a
        /// query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The document's fields. The map keys represent field names. A simple field name contains only characters `a`
        /// to `z`, `A` to `Z`, `0` to `9`, or `_`, and must not start with `0` to `9`. For example, `foo_bar_17`. Field
        /// names matching the regular expression `__.*__` are reserved. Reserved field names are forbidden except in
        /// certain documented contexts. The map keys, represented as UTF-8, must not exceed 1,500 bytes and cannot be
        /// empty. Field paths may be used in other contexts to refer to structured fields defined here. For
        /// `map_value`, the field path is represented by the simple or quoted field names of the containing fields,
        /// delimited by `.`. For example, the structured field `"foo" : { map_value: { "x&amp;amp;y" : { string_value:
        /// "hello" }}}` would be represented by the field path `foo.x&amp;amp;y`. Within a field path, a quoted field
        /// name starts and ends with `` ` `` and may contain any character. Some characters, including `` ` ``, must be
        /// escaped using a `\`. For example, `` `x&amp;amp;y` `` represents `x&amp;amp;y` and `` `bak\`tik` ``
        /// represents `` bak`tik ``.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, Value> Fields { get; set; }

        /// <summary>
        /// The resource name of the document, for example
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The time at which the document was last changed. This value is initially set to the
        /// `create_time` then increases monotonically with each change to the document. It can also be compared to
        /// values from other documents and the `read_time` of a query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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

        /// <summary>
        /// The read timestamp at which the delete was observed. Greater or equal to the `commit_time` of the delete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

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

        /// <summary>
        /// The read timestamp at which the remove was observed. Greater or equal to the `commit_time` of the
        /// change/delete/remove.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A digest of all the documents that match a given target.</summary>
    public class ExistenceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The total count of documents that match target_id. If different from the count of documents in the client
        /// that match, the client must manually determine which documents no longer match the target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>The target ID to which this filter applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual System.Nullable<int> TargetId { get; set; }

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

    /// <summary>A reference to a field, such as `max(messages.time) as max_time`.</summary>
    public class FieldReference : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.ExportDocuments.</summary>
    public class GoogleFirestoreAdminV1ExportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids are being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>The time this operation completed. Will be unset if operation still in progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The state of the export operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>Where the entities are being exported to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1Progress ProgressDocuments { get; set; }

        /// <summary>The time this operation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirestoreAdmin.ExportDocuments.</summary>
    public class GoogleFirestoreAdminV1ExportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleFirestoreAdminV1ExportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Represents a single field in the database. Fields are grouped by their "Collection Group", which represent all
    /// collections in the database with the same id.
    /// </summary>
    public class GoogleFirestoreAdminV1Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The index configuration for this field. If unset, field indexing will revert to the configuration defined by
        /// the `ancestor_field`. To explicitly remove all indexes for this field, specify an index config with an empty
        /// list of indexes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexConfig")]
        public virtual GoogleFirestoreAdminV1IndexConfig IndexConfig { get; set; }

        /// <summary>
        /// Required. A field name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}` A field
        /// path may be a simple field name, e.g. `address` or a path to fields within map_value , e.g. `address.city`,
        /// or a special field path. The only valid special field is `*`, which represents any field. Field paths may be
        /// quoted using ` (backtick). The only character that needs to be escaped within a quoted field path is the
        /// backtick character itself, escaped using a backslash. Special characters in field paths that must be quoted
        /// include: `*`, `.`, ``` (backtick), `[`, `]`, as well as any ascii symbolic characters. Examples: (Note:
        /// Comments here are written in markdown syntax, so there is an additional layer of backticks to represent a
        /// code block) `\`address.city\`` represents a field named `address.city`, not the map key `city` in the field
        /// `address`. `\`*\`` represents a field named `*`, not any field. A special `Field` contains the default
        /// indexing settings for all fields. This field's resource name is:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*` Indexes defined on
        /// this `Field` will be applied to all fields which do not have their own `Field` index configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.UpdateField.</summary>
    public class GoogleFirestoreAdminV1FieldOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time this operation completed. Will be unset if operation still in progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The field resource that this operation is acting on. For example:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>A list of IndexConfigDelta, which describe the intent of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexConfigDeltas")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1IndexConfigDelta> IndexConfigDeltas { get; set; }

        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1Progress ProgressDocuments { get; set; }

        /// <summary>The time this operation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.ImportDocuments.</summary>
    public class GoogleFirestoreAdminV1ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids are being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>The time this operation completed. Will be unset if operation still in progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The location of the documents being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUriPrefix")]
        public virtual string InputUriPrefix { get; set; }

        /// <summary>The state of the import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1Progress ProgressDocuments { get; set; }

        /// <summary>The time this operation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirestoreAdmin.ImportDocuments.</summary>
    public class GoogleFirestoreAdminV1ImportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids to import. Unspecified means all collections included in the import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// Location of the exported files. This must match the output_uri_prefix of an ExportDocumentsResponse from an
        /// export that has completed successfully. See:
        /// google.firestore.admin.v1.ExportDocumentsResponse.output_uri_prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUriPrefix")]
        public virtual string InputUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Firestore indexes enable simple and complex queries against documents in a database.</summary>
    public class GoogleFirestoreAdminV1Index : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields supported by this index. For composite indexes, this is always 2 or more fields. The last field
        /// entry is always for the field path `__name__`. If, on creation, `__name__` was not specified as the last
        /// field, it will be added automatically with the same direction as that of the last field defined. If the
        /// final field in a composite index is not directional, the `__name__` will be ordered ASCENDING (unless
        /// explicitly specified). For single field indexes, this will always be exactly one entry with a field path
        /// equal to the field path of the associated field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1IndexField> Fields { get; set; }

        /// <summary>
        /// Output only. A server defined name for this index. The form of this name for composite indexes will be:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{composite_index_id}`
        /// For single field indexes, this field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Indexes with a collection query scope specified allow queries against a collection that is the child of a
        /// specific document, specified at query time, and that has the same collection id. Indexes with a collection
        /// group query scope specified allow queries against all collections descended from a specific document,
        /// specified at query time, and that have the same collection id as this index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryScope")]
        public virtual string QueryScope { get; set; }

        /// <summary>Output only. The serving state of the index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The index configuration for this field.</summary>
    public class GoogleFirestoreAdminV1IndexConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Specifies the resource name of the `Field` from which this field's index configuration is set
        /// (when `uses_ancestor_config` is true), or from which it *would* be set if this field had no index
        /// configuration (when `uses_ancestor_config` is false).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestorField")]
        public virtual string AncestorField { get; set; }

        /// <summary>The indexes supported for this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1Index> Indexes { get; set; }

        /// <summary>
        /// Output only When true, the `Field`'s index configuration is in the process of being reverted. Once complete,
        /// the index config will transition to the same state as the field specified by `ancestor_field`, at which
        /// point `uses_ancestor_config` will be `true` and `reverting` will be `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reverting")]
        public virtual System.Nullable<bool> Reverting { get; set; }

        /// <summary>
        /// Output only. When true, the `Field`'s index configuration is set from the configuration specified by the
        /// `ancestor_field`. When false, the `Field`'s index configuration is defined explicitly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usesAncestorConfig")]
        public virtual System.Nullable<bool> UsesAncestorConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an index configuration change.</summary>
    public class GoogleFirestoreAdminV1IndexConfigDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies how the index is changing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeType")]
        public virtual string ChangeType { get; set; }

        /// <summary>The index being changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual GoogleFirestoreAdminV1Index Index { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A field in an index. The field_path describes which field is indexed, the value_mode describes how the field
    /// value is indexed.
    /// </summary>
    public class GoogleFirestoreAdminV1IndexField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates that this field supports operations on `array_value`s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayConfig")]
        public virtual string ArrayConfig { get; set; }

        /// <summary>
        /// Can be __name__. For single field indexes, this must match the name of the field or may be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>
        /// Indicates that this field supports ordering by the specified order or comparing using =, !=, &amp;lt;,
        /// &amp;lt;=, &amp;gt;, &amp;gt;=.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.CreateIndex.</summary>
    public class GoogleFirestoreAdminV1IndexOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time this operation completed. Will be unset if operation still in progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The index resource that this operation is acting on. For example:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual string Index { get; set; }

        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1Progress ProgressDocuments { get; set; }

        /// <summary>The time this operation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirestoreAdmin.ListFields.</summary>
    public class GoogleFirestoreAdminV1ListFieldsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1Field> Fields { get; set; }

        /// <summary>
        /// A page token that may be used to request another page of results. If blank, this is the last page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirestoreAdmin.ListIndexes.</summary>
    public class GoogleFirestoreAdminV1ListIndexesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested indexes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1Index> Indexes { get; set; }

        /// <summary>
        /// A page token that may be used to request another page of results. If blank, this is the last page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata message for google.cloud.location.Location.metadata.</summary>
    public class GoogleFirestoreAdminV1LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>The next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
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

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
        /// too few results to be partitioned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<Cursor> Partitions { get; set; }

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

        /// <summary>When set, the target document must exist and have been last updated at that time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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
        /// <summary>Reads documents at the given time. This may not be older than 60 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for a transaction that can be used to read and write documents.</summary>
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

    /// <summary>The request for Firestore.RunQuery.</summary>
    public class RunQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Starts a new transaction and reads the documents. Defaults to a read-only transaction. The new transaction
        /// ID will be returned as the first response in the stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newTransaction")]
        public virtual TransactionOptions NewTransaction { get; set; }

        /// <summary>Reads documents as they were at the given time. This may not be older than 270 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>A structured query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredQuery")]
        public virtual StructuredQuery StructuredQuery { get; set; }

        /// <summary>Reads documents in a transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transaction")]
        public virtual string Transaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for Firestore.RunQuery.</summary>
    public class RunQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A query result. Not set when reporting partial progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual Document Document { get; set; }

        /// <summary>
        /// The time at which the document was read. This may be monotonically increasing; in this case, the previous
        /// documents in the result stream are guaranteed not to have changed between their `read_time` and this one. If
        /// the query returns no results, a response with `read_time` and no `document` will be sent, and this
        /// represents the time at which the query was run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

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

    /// <summary>A Firestore query.</summary>
    public class StructuredQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A end point for the query results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endAt")]
        public virtual Cursor EndAt { get; set; }

        /// <summary>The collections to query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("from")]
        public virtual System.Collections.Generic.IList<CollectionSelector> From { get; set; }

        /// <summary>
        /// The maximum number of results to return. Applies after all other constraints. Must be &amp;gt;= 0 if
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<int> Limit { get; set; }

        /// <summary>
        /// The number of results to skip. Applies before limit, but after all other constraints. Must be &amp;gt;= 0 if
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>
        /// The order to apply to the query results. Firestore guarantees a stable ordering through the following rules:
        /// * Any field required to appear in `order_by`, that is not already specified in `order_by`, is appended to
        /// the order in field name order by default. * If an order on `__name__` is not specified, it is appended by
        /// default. Fields are appended with the same sort direction as the last order specified, or 'ASCENDING' if no
        /// order was specified. For example: * `SELECT * FROM Foo ORDER BY A` becomes `SELECT * FROM Foo ORDER BY A,
        /// __name__` * `SELECT * FROM Foo ORDER BY A DESC` becomes `SELECT * FROM Foo ORDER BY A DESC, __name__ DESC` *
        /// `SELECT * FROM Foo WHERE A &amp;gt; 1` becomes `SELECT * FROM Foo WHERE A &amp;gt; 1 ORDER BY A, __name__`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual System.Collections.Generic.IList<Order> OrderBy { get; set; }

        /// <summary>The projection to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("select")]
        public virtual Projection Select { get; set; }

        /// <summary>A starting point for the query results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startAt")]
        public virtual Cursor StartAt { get; set; }

        /// <summary>The filter to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("where")]
        public virtual Filter Where { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of a set of documents to listen to.</summary>
    public class Target : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A target specified by a set of document names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documents")]
        public virtual DocumentsTarget Documents { get; set; }

        /// <summary>If the target should be removed once it is current and consistent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("once")]
        public virtual System.Nullable<bool> Once { get; set; }

        /// <summary>A target specified by a query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual QueryTarget Query { get; set; }

        /// <summary>
        /// Start listening after a specific `read_time`. The client must know the state of matching documents at this
        /// time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>
        /// A resume token from a prior TargetChange for an identical target. Using a resume token with a different
        /// target is unsupported and may fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resumeToken")]
        public virtual string ResumeToken { get; set; }

        /// <summary>
        /// The target ID that identifies the target on the stream. Must be a positive number and non-zero.
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

        /// <summary>
        /// The consistent `read_time` for the given `target_ids` (omitted when the target_ids are not at a consistent
        /// snapshot). The stream is guaranteed to send a `read_time` with `target_ids` empty whenever the entire stream
        /// reaches a new consistent snapshot. ADD, CURRENT, and RESET messages are guaranteed to (eventually) result in
        /// a new consistent snapshot (while NO_CHANGE and REMOVE messages are not). For a given stream, `read_time` is
        /// guaranteed to be monotonically increasing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

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
        /// An array value. Cannot directly contain another array value, though can contain an map which contains
        /// another array.
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

        /// <summary>
        /// A timestamp value. Precise only to microseconds. When stored, any additional precision is rounded down.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual object TimestampValue { get; set; }

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
        /// <summary>
        /// The time at which the commit occurred. Any read with an equal or greater `read_time` is guaranteed to see
        /// the effects of the write.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitTime")]
        public virtual object CommitTime { get; set; }

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

        /// <summary>
        /// The last update time of the document after applying the write. Not set after a `delete`. If the write did
        /// not actually change the document, this will be the previous update_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
