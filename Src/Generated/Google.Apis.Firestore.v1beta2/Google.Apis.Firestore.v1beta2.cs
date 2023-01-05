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

namespace Google.Apis.Firestore.v1beta2
{
    /// <summary>The Firestore Service.</summary>
    public class FirestoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta2";

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
        public override string BaseUri => BaseUriOverride ?? "https://firestore.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://firestore.googleapis.com/batch";

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
                CollectionGroups = new CollectionGroupsResource(service);
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
                    /// A name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the metadata and configuration for a Field.</summary>
                    public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Field>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// A name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta2/{+name}";

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
                    /// `indexConfig.usesAncestorConfig:false`.
                    /// </summary>
                    /// <param name="parent">
                    /// A parent name of the form
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
                    /// `indexConfig.usesAncestorConfig:false`.
                    /// </summary>
                    public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ListFieldsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// A parent name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The filter to apply to list results. Currently, FirestoreAdmin.ListFields only supports
                        /// listing fields that have been explicitly overridden. To issue this query, call
                        /// FirestoreAdmin.ListFields with the filter set to `indexConfig.usesAncestorConfig:false`.
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
                        public override string RestPath => "v1beta2/{+parent}/fields";

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
                    /// A field name of the form
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
                    public virtual PatchRequest Patch(Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Field body, string name)
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
                    public class PatchRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Field body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// A field name of the form
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
                        Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Field Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta2/{+name}";

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
                    /// A parent name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Index body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a composite index. This returns a google.longrunning.Operation which may be used to
                    /// track the status of the creation. The metadata for the operation will be the type
                    /// IndexOperationMetadata.
                    /// </summary>
                    public class CreateRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Index body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// A parent name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Index Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta2/{+parent}/indexes";

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
                    /// A name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a composite index.</summary>
                    public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// A name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta2/{+name}";

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
                    /// A name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a composite index.</summary>
                    public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2Index>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// A name of the form
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta2/{+name}";

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
                    /// A parent name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists composite indexes.</summary>
                    public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ListIndexesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// A parent name of the form
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
                        public override string RestPath => "v1beta2/{+parent}/indexes";

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
            public virtual ExportDocumentsRequest ExportDocuments(Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ExportDocumentsRequest body, string name)
            {
                return new ExportDocumentsRequest(service, body, name);
            }

            /// <summary>
            /// Exports a copy of all or a subset of documents from Google Cloud Firestore to another storage system,
            /// such as Google Cloud Storage. Recent updates to documents may not be reflected in the export. The export
            /// occurs in the background and its progress can be monitored and managed via the Operation resource that
            /// is created. The output of an export may only be used once the associated operation is done. If an export
            /// operation is cancelled before completion it may leave partial data behind in Google Cloud Storage.
            /// </summary>
            public class ExportDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ExportDocuments request.</summary>
                public ExportDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ExportDocumentsRequest body, string name) : base(service)
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
                Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ExportDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportDocuments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:exportDocuments";

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
            public virtual ImportDocumentsRequest ImportDocuments(Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ImportDocumentsRequest body, string name)
            {
                return new ImportDocumentsRequest(service, body, name);
            }

            /// <summary>
            /// Imports documents into Google Cloud Firestore. Existing documents with the same name are overwritten.
            /// The import occurs in the background and its progress can be monitored and managed via the Operation
            /// resource that is created. If an ImportDocuments operation is cancelled, it is possible that a subset of
            /// the data has already been imported to Cloud Firestore.
            /// </summary>
            public class ImportDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1beta2.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new ImportDocuments request.</summary>
                public ImportDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ImportDocumentsRequest body, string name) : base(service)
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
                Google.Apis.Firestore.v1beta2.Data.GoogleFirestoreAdminV1beta2ImportDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "importDocuments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:importDocuments";

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
namespace Google.Apis.Firestore.v1beta2.Data
{
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

    /// <summary>Metadata related to the update database operation.</summary>
    public class GoogleFirestoreAdminV1UpdateDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.ExportDocuments.</summary>
    public class GoogleFirestoreAdminV1beta2ExportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleFirestoreAdminV1beta2Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1beta2Progress ProgressDocuments { get; set; }

        /// <summary>The time this operation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirestoreAdmin.ExportDocuments.</summary>
    public class GoogleFirestoreAdminV1beta2ExportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleFirestoreAdminV1beta2ExportDocumentsResponse : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleFirestoreAdminV1beta2Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The index configuration for this field. If unset, field indexing will revert to the configuration defined by
        /// the `ancestor_field`. To explicitly remove all indexes for this field, specify an index config with an empty
        /// list of indexes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexConfig")]
        public virtual GoogleFirestoreAdminV1beta2IndexConfig IndexConfig { get; set; }

        /// <summary>
        /// A field name of the form
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
    public class GoogleFirestoreAdminV1beta2FieldOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesProgress")]
        public virtual GoogleFirestoreAdminV1beta2Progress BytesProgress { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentProgress")]
        public virtual GoogleFirestoreAdminV1beta2Progress DocumentProgress { get; set; }

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
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1beta2IndexConfigDelta> IndexConfigDeltas { get; set; }

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
    public class GoogleFirestoreAdminV1beta2ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleFirestoreAdminV1beta2Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1beta2Progress ProgressDocuments { get; set; }

        /// <summary>The time this operation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirestoreAdmin.ImportDocuments.</summary>
    public class GoogleFirestoreAdminV1beta2ImportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection ids to import. Unspecified means all collections included in the import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// Location of the exported files. This must match the output_uri_prefix of an ExportDocumentsResponse from an
        /// export that has completed successfully. See:
        /// google.firestore.admin.v1beta2.ExportDocumentsResponse.output_uri_prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUriPrefix")]
        public virtual string InputUriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Firestore indexes enable simple and complex queries against documents in a database.</summary>
    public class GoogleFirestoreAdminV1beta2Index : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1beta2IndexField> Fields { get; set; }

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
    public class GoogleFirestoreAdminV1beta2IndexConfig : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1beta2Index> Indexes { get; set; }

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
    public class GoogleFirestoreAdminV1beta2IndexConfigDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies how the index is changing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeType")]
        public virtual string ChangeType { get; set; }

        /// <summary>The index being changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual GoogleFirestoreAdminV1beta2Index Index { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A field in an index. The field_path describes which field is indexed, the value_mode describes how the field
    /// value is indexed.
    /// </summary>
    public class GoogleFirestoreAdminV1beta2IndexField : Google.Apis.Requests.IDirectResponseSchema
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
        /// Indicates that this field supports ordering by the specified order or comparing using =, &amp;lt;,
        /// &amp;lt;=, &amp;gt;, &amp;gt;=.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual string Order { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.CreateIndex.</summary>
    public class GoogleFirestoreAdminV1beta2IndexOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleFirestoreAdminV1beta2Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1beta2Progress ProgressDocuments { get; set; }

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
    public class GoogleFirestoreAdminV1beta2ListFieldsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1beta2Field> Fields { get; set; }

        /// <summary>
        /// A page token that may be used to request another page of results. If blank, this is the last page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirestoreAdmin.ListIndexes.</summary>
    public class GoogleFirestoreAdminV1beta2ListIndexesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested indexes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexes")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1beta2Index> Indexes { get; set; }

        /// <summary>
        /// A page token that may be used to request another page of results. If blank, this is the last page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the progress of the operation. Unit of work is generic and must be interpreted based on where Progress
    /// is used.
    /// </summary>
    public class GoogleFirestoreAdminV1beta2Progress : Google.Apis.Requests.IDirectResponseSchema
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
}
