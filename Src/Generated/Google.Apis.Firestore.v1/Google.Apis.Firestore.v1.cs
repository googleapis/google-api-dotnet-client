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
                BackupSchedules = new BackupSchedulesResource(service);
                CollectionGroups = new CollectionGroupsResource(service);
                Documents = new DocumentsResource(service);
                Operations = new OperationsResource(service);
                UserCreds = new UserCredsResource(service);
            }

            /// <summary>Gets the BackupSchedules resource.</summary>
            public virtual BackupSchedulesResource BackupSchedules { get; }

            /// <summary>The "backupSchedules" collection of methods.</summary>
            public class BackupSchedulesResource
            {
                private const string Resource = "backupSchedules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupSchedulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a backup schedule on a database. At most two backup schedules can be configured on a
                /// database, one daily backup schedule and one weekly backup schedule.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent database. Format `projects/{project}/databases/{database}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a backup schedule on a database. At most two backup schedules can be configured on a
                /// database, one daily backup schedule and one weekly backup schedule.
                /// </summary>
                public class CreateRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent database. Format `projects/{project}/databases/{database}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupSchedules";

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

                /// <summary>Deletes a backup schedule.</summary>
                /// <param name="name">
                /// Required. The name of the backup schedule. Format
                /// `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a backup schedule.</summary>
                public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the backup schedule. Format
                    /// `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets information about a backup schedule.</summary>
                /// <param name="name">
                /// Required. The name of the backup schedule. Format
                /// `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a backup schedule.</summary>
                public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the backup schedule. Format
                    /// `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
                        });
                    }
                }

                /// <summary>List backup schedules.</summary>
                /// <param name="parent">
                /// Required. The parent database. Format is `projects/{project}/databases/{database}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List backup schedules.</summary>
                public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ListBackupSchedulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent database. Format is `projects/{project}/databases/{database}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupSchedules";

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
                    }
                }

                /// <summary>Updates a backup schedule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The unique backup schedule identifier across all locations and databases for the given
                /// project. This will be auto-assigned. Format is
                /// `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a backup schedule.</summary>
                public class PatchRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The unique backup schedule identifier across all locations and databases for the
                    /// given project. This will be auto-assigned. Format is
                    /// `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BackupSchedule Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/backupSchedules/[^/]+$",
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
                        return new GetRequest(this.service, name);
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
                    /// `indexConfig.usesAncestorConfig:false` or `ttlConfig:*`.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. A parent name of the form
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists the field configuration and metadata for this database. Currently,
                    /// FirestoreAdmin.ListFields only supports listing fields that have been explicitly overridden. To
                    /// issue this query, call FirestoreAdmin.ListFields with the filter set to
                    /// `indexConfig.usesAncestorConfig:false` or `ttlConfig:*`.
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
                        /// or `ttlConfig:*`.
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
                    /// Required. A field name of the form:
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}`
                    /// A field path can be a simple field name, e.g. `address` or a path to fields within `map_value` ,
                    /// e.g. `address.city`, or a special field path. The only valid special field is `*`, which
                    /// represents any field. Field paths can be quoted using `` ` `` (backtick). The only character
                    /// that must be escaped within a quoted field path is the backtick character itself, escaped using
                    /// a backslash. Special characters in field paths that must be quoted include: `*`, `.`, `` ` ``
                    /// (backtick), `[`, `]`, as well as any ascii symbolic characters. Examples: `` `address.city` ``
                    /// represents a field named `address.city`, not the map key `city` in the field `address`. `` `*`
                    /// `` represents a field named `*`, not any field. A special `Field` contains the default indexing
                    /// settings for all fields. This field's resource name is:
                    /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*` Indexes
                    /// defined on this `Field` will be applied to all fields which do not have their own `Field` index
                    /// configuration.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Field body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
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
                        /// Required. A field name of the form:
                        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}`
                        /// A field path can be a simple field name, e.g. `address` or a path to fields within
                        /// `map_value` , e.g. `address.city`, or a special field path. The only valid special field is
                        /// `*`, which represents any field. Field paths can be quoted using `` ` `` (backtick). The
                        /// only character that must be escaped within a quoted field path is the backtick character
                        /// itself, escaped using a backslash. Special characters in field paths that must be quoted
                        /// include: `*`, `.`, `` ` `` (backtick), `[`, `]`, as well as any ascii symbolic characters.
                        /// Examples: `` `address.city` `` represents a field named `address.city`, not the map key
                        /// `city` in the field `address`. `` `*` `` represents a field named `*`, not any field. A
                        /// special `Field` contains the default indexing settings for all fields. This field's resource
                        /// name is:
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
                        return new CreateRequest(this.service, body, parent);
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
                        return new DeleteRequest(this.service, name);
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
                        return new GetRequest(this.service, name);
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
                        return new ListRequest(this.service, parent);
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
                    return new BatchGetRequest(this.service, body, database);
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
                    return new BatchWriteRequest(this.service, body, database);
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
                    return new BeginTransactionRequest(this.service, body, database);
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
                    return new CommitRequest(this.service, body, database);
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
                    return new CreateDocumentRequest(this.service, body, parent, collectionId);
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
                    return new DeleteRequest(this.service, name);
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
                    return new GetRequest(this.service, name);
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
                /// Optional. The collection ID, relative to `parent`, to list. For example: `chatrooms` or `messages`.
                /// This is optional, and when not provided, Firestore will list documents from all collections under
                /// the provided `parent`.
                /// </param>
                public virtual ListRequest List(string parent, string collectionId)
                {
                    return new ListRequest(this.service, parent, collectionId);
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
                    return new ListCollectionIdsRequest(this.service, body, parent);
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
                public class ListDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.ListDocumentsResponse>
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
                    public override string RestPath => "v1/{+parent}/{collectionId}";

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
                public virtual ListenRequest Listen(Google.Apis.Firestore.v1.Data.ListenRequest body, string database)
                {
                    return new ListenRequest(this.service, body, database);
                }

                /// <summary>
                /// Listens to changes. This method is only available via gRPC or WebChannel (not REST).
                /// </summary>
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
                    return new PartitionQueryRequest(this.service, body, parent);
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
                    return new PatchRequest(this.service, body, name);
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
                    return new RollbackRequest(this.service, body, database);
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
                public virtual RunAggregationQueryRequest RunAggregationQuery(Google.Apis.Firestore.v1.Data.RunAggregationQueryRequest body, string parent)
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
                public class RunAggregationQueryRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.RunAggregationQueryResponse>
                {
                    /// <summary>Constructs a new RunAggregationQuery request.</summary>
                    public RunAggregationQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.RunAggregationQueryRequest body, string parent) : base(service)
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
                    Google.Apis.Firestore.v1.Data.RunAggregationQueryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "runAggregationQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:runAggregationQuery";

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
                public virtual RunQueryRequest RunQuery(Google.Apis.Firestore.v1.Data.RunQueryRequest body, string parent)
                {
                    return new RunQueryRequest(this.service, body, parent);
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

                /// <summary>
                /// Streams batches of document updates and deletes, in order. This method is only available via gRPC or
                /// WebChannel (not REST).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="database">
                /// Required. The database name. In the format: `projects/{project_id}/databases/{database_id}`. This is
                /// only required in the first message.
                /// </param>
                public virtual WriteRequest Write(Google.Apis.Firestore.v1.Data.WriteRequest body, string database)
                {
                    return new WriteRequest(this.service, body, database);
                }

                /// <summary>
                /// Streams batches of document updates and deletes, in order. This method is only available via gRPC or
                /// WebChannel (not REST).
                /// </summary>
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
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Firestore.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
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
                    return new DeleteRequest(this.service, name);
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
                    return new GetRequest(this.service, name);
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
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
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

            /// <summary>Gets the UserCreds resource.</summary>
            public virtual UserCredsResource UserCreds { get; }

            /// <summary>The "userCreds" collection of methods.</summary>
            public class UserCredsResource
            {
                private const string Resource = "userCreds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UserCredsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a user creds.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. A parent name of the form `projects/{project_id}/databases/{database_id}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a user creds.</summary>
                public class CreateRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A parent name of the form `projects/{project_id}/databases/{database_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the user creds, which will become the final component of the user
                    /// creds's resource name. This value should be 4-63 characters. Valid characters are /a-z-/ with
                    /// first character a letter and the last a letter or a number. Must not be UUID-like
                    /// /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userCredsId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UserCredsId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userCreds";

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
                        RequestParameters.Add("userCredsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userCredsId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a user creds.</summary>
                /// <param name="name">
                /// Required. A name of the form
                /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a user creds.</summary>
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
                    /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/userCreds/[^/]+$",
                        });
                    }
                }

                /// <summary>Disables a user creds. No-op if the user creds are already disabled.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. A name of the form
                /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                /// </param>
                public virtual DisableRequest Disable(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1DisableUserCredsRequest body, string name)
                {
                    return new DisableRequest(this.service, body, name);
                }

                /// <summary>Disables a user creds. No-op if the user creds are already disabled.</summary>
                public class DisableRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds>
                {
                    /// <summary>Constructs a new Disable request.</summary>
                    public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1DisableUserCredsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the form
                    /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1DisableUserCredsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "disable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:disable";

                    /// <summary>Initializes Disable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/userCreds/[^/]+$",
                        });
                    }
                }

                /// <summary>Enables a user creds. No-op if the user creds are already enabled.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. A name of the form
                /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                /// </param>
                public virtual EnableRequest Enable(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1EnableUserCredsRequest body, string name)
                {
                    return new EnableRequest(this.service, body, name);
                }

                /// <summary>Enables a user creds. No-op if the user creds are already enabled.</summary>
                public class EnableRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds>
                {
                    /// <summary>Constructs a new Enable request.</summary>
                    public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1EnableUserCredsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the form
                    /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1EnableUserCredsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:enable";

                    /// <summary>Initializes Enable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/userCreds/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a user creds resource. Note that the returned resource does not contain the secret value
                /// itself.
                /// </summary>
                /// <param name="name">
                /// Required. A name of the form
                /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets a user creds resource. Note that the returned resource does not contain the secret value
                /// itself.
                /// </summary>
                public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the form
                    /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
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
                            Pattern = @"^projects/[^/]+/databases/[^/]+/userCreds/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// List all user creds in the database. Note that the returned resource does not contain the secret
                /// value itself.
                /// </summary>
                /// <param name="parent">
                /// Required. A parent database name of the form `projects/{project_id}/databases/{database_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// List all user creds in the database. Note that the returned resource does not contain the secret
                /// value itself.
                /// </summary>
                public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ListUserCredsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A parent database name of the form `projects/{project_id}/databases/{database_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/userCreds";

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
                    }
                }

                /// <summary>Resets the password of a user creds.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. A name of the form
                /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                /// </param>
                public virtual ResetPasswordRequest ResetPassword(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ResetUserPasswordRequest body, string name)
                {
                    return new ResetPasswordRequest(this.service, body, name);
                }

                /// <summary>Resets the password of a user creds.</summary>
                public class ResetPasswordRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1UserCreds>
                {
                    /// <summary>Constructs a new ResetPassword request.</summary>
                    public ResetPasswordRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ResetUserPasswordRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the form
                    /// `projects/{project_id}/databases/{database_id}/userCreds/{user_creds_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ResetUserPasswordRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resetPassword";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:resetPassword";

                    /// <summary>Initializes ResetPassword parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/databases/[^/]+/userCreds/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Bulk deletes a subset of documents from Google Cloud Firestore. Documents created or updated after the
            /// underlying system starts to process the request will not be deleted. The bulk delete occurs in the
            /// background and its progress can be monitored and managed via the Operation resource that is created. For
            /// more details on bulk delete behavior, refer to:
            /// https://cloud.google.com/firestore/docs/manage-data/bulk-delete
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Database to operate. Should be of the form: `projects/{project_id}/databases/{database_id}`.
            /// </param>
            public virtual BulkDeleteDocumentsRequest BulkDeleteDocuments(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BulkDeleteDocumentsRequest body, string name)
            {
                return new BulkDeleteDocumentsRequest(this.service, body, name);
            }

            /// <summary>
            /// Bulk deletes a subset of documents from Google Cloud Firestore. Documents created or updated after the
            /// underlying system starts to process the request will not be deleted. The bulk delete occurs in the
            /// background and its progress can be monitored and managed via the Operation resource that is created. For
            /// more details on bulk delete behavior, refer to:
            /// https://cloud.google.com/firestore/docs/manage-data/bulk-delete
            /// </summary>
            public class BulkDeleteDocumentsRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new BulkDeleteDocuments request.</summary>
                public BulkDeleteDocumentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BulkDeleteDocumentsRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Database to operate. Should be of the form:
                /// `projects/{project_id}/databases/{database_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1BulkDeleteDocumentsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "bulkDeleteDocuments";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:bulkDeleteDocuments";

                /// <summary>Initializes BulkDeleteDocuments parameter list.</summary>
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
            /// Creates a new database by cloning an existing one. The new database must be in the same cloud region or
            /// multi-region location as the existing database. This behaves similar to FirestoreAdmin.CreateDatabase
            /// except instead of creating a new empty database, a new database is created with the database type, index
            /// configuration, and documents from an existing database. The long-running operation can be used to track
            /// the progress of the clone, with the Operation's metadata field type being the CloneDatabaseMetadata. The
            /// response type is the Database if the clone was successful. The new database is not readable or writeable
            /// until the LRO has completed.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The project to clone the database in. Format is `projects/{project_id}`.
            /// </param>
            public virtual CloneRequest Clone(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1CloneDatabaseRequest body, string parent)
            {
                return new CloneRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a new database by cloning an existing one. The new database must be in the same cloud region or
            /// multi-region location as the existing database. This behaves similar to FirestoreAdmin.CreateDatabase
            /// except instead of creating a new empty database, a new database is created with the database type, index
            /// configuration, and documents from an existing database. The long-running operation can be used to track
            /// the progress of the clone, with the Operation's metadata field type being the CloneDatabaseMetadata. The
            /// response type is the Database if the clone was successful. The new database is not readable or writeable
            /// until the LRO has completed.
            /// </summary>
            public class CloneRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Clone request.</summary>
                public CloneRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1CloneDatabaseRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project to clone the database in. Format is `projects/{project_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1CloneDatabaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "clone";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/databases:clone";

                /// <summary>Initializes Clone parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Create a database.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. A parent name of the form `projects/{project_id}`</param>
            public virtual CreateRequest Create(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Database body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Create a database.</summary>
            public class CreateRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Database body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. A parent name of the form `projects/{project_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The ID to use for the database, which will become the final component of the database's
                /// resource name. This value should be 4-63 characters. Valid characters are /a-z-/ with first
                /// character a letter and the last a letter or a number. Must not be UUID-like
                /// /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/. "(default)" database ID is also valid.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("databaseId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DatabaseId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Database Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/databases";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("databaseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "databaseId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a database.</summary>
            /// <param name="name">Required. A name of the form `projects/{project_id}/databases/{database_id}`</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a database.</summary>
            public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. A name of the form `projects/{project_id}/databases/{database_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The current etag of the Database. If an etag is provided and does not match the current etag of the
                /// database, deletion will be blocked and a FAILED_PRECONDITION error will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Etag { get; set; }

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
                        Pattern = @"^projects/[^/]+/databases/[^/]+$",
                    });
                    RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                    {
                        Name = "etag",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
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
                return new ExportDocumentsRequest(this.service, body, name);
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

            /// <summary>Gets information about a database.</summary>
            /// <param name="name">Required. A name of the form `projects/{project_id}/databases/{database_id}`</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a database.</summary>
            public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Database>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. A name of the form `projects/{project_id}/databases/{database_id}`</summary>
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
                return new ImportDocumentsRequest(this.service, body, name);
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

            /// <summary>List all the databases in the project.</summary>
            /// <param name="parent">Required. A parent name of the form `projects/{project_id}`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List all the databases in the project.</summary>
            public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ListDatabasesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. A parent name of the form `projects/{project_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>If true, also returns deleted resources.</summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/databases";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showDeleted",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a database.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the Database. Format: `projects/{project}/databases/{database}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Database body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a database.</summary>
            public class PatchRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Database body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the Database. Format: `projects/{project}/databases/{database}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Database Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/databases/[^/]+$",
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
            /// Creates a new database by restoring from an existing backup. The new database must be in the same cloud
            /// region or multi-region location as the existing backup. This behaves similar to
            /// FirestoreAdmin.CreateDatabase except instead of creating a new empty database, a new database is created
            /// with the database type, index configuration, and documents from an existing backup. The long-running
            /// operation can be used to track the progress of the restore, with the Operation's metadata field type
            /// being the RestoreDatabaseMetadata. The response type is the Database if the restore was successful. The
            /// new database is not readable or writeable until the LRO has completed.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The project to restore the database in. Format is `projects/{project_id}`.
            /// </param>
            public virtual RestoreRequest Restore(Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1RestoreDatabaseRequest body, string parent)
            {
                return new RestoreRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a new database by restoring from an existing backup. The new database must be in the same cloud
            /// region or multi-region location as the existing backup. This behaves similar to
            /// FirestoreAdmin.CreateDatabase except instead of creating a new empty database, a new database is created
            /// with the database type, index configuration, and documents from an existing backup. The long-running
            /// operation can be used to track the progress of the restore, with the Operation's metadata field type
            /// being the RestoreDatabaseMetadata. The response type is the Database if the restore was successful. The
            /// new database is not readable or writeable until the LRO has completed.
            /// </summary>
            public class RestoreRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Restore request.</summary>
                public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1RestoreDatabaseRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project to restore the database in. Format is `projects/{project_id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1RestoreDatabaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "restore";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/databases:restore";

                /// <summary>Initializes Restore parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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
                Backups = new BackupsResource(service);
            }

            /// <summary>Gets the Backups resource.</summary>
            public virtual BackupsResource Backups { get; }

            /// <summary>The "backups" collection of methods.</summary>
            public class BackupsResource
            {
                private const string Resource = "backups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Deletes a backup.</summary>
                /// <param name="name">
                /// Required. Name of the backup to delete. format is
                /// `projects/{project}/locations/{location}/backups/{backup}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a backup.</summary>
                public class DeleteRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backup to delete. format is
                    /// `projects/{project}/locations/{location}/backups/{backup}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets information about a backup.</summary>
                /// <param name="name">
                /// Required. Name of the backup to fetch. Format is
                /// `projects/{project}/locations/{location}/backups/{backup}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a backup.</summary>
                public class GetRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1Backup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backup to fetch. Format is
                    /// `projects/{project}/locations/{location}/backups/{backup}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the backups.</summary>
                /// <param name="parent">
                /// Required. The location to list backups from. Format is `projects/{project}/locations/{location}`.
                /// Use `{location} = '-'` to list backups from all locations for the given project. This allows listing
                /// backups from a single location or from all locations.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the backups.</summary>
                public class ListRequest : FirestoreBaseServiceRequest<Google.Apis.Firestore.v1.Data.GoogleFirestoreAdminV1ListBackupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location to list backups from. Format is
                    /// `projects/{project}/locations/{location}`. Use `{location} = '-'` to list backups from all
                    /// locations for the given project. This allows listing backups from a single location or from all
                    /// locations.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression that filters the list of returned backups. A filter expression consists of a field
                    /// name, a comparison operator, and a value for filtering. The value must be a string, a number, or
                    /// a boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`, `&amp;lt;=`,
                    /// `&amp;gt;=`, `!=`, `=`, or `:`. Colon `:` is the contains operator. Filter rules are not case
                    /// sensitive. The following fields in the Backup are eligible for filtering: * `database_uid`
                    /// (supports `=` only)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backups";

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
                    }
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
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
                return new ListRequest(this.service, name);
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
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// `"displayName=tokyo"`, and is documented in more detail in [AIP-160](https://google.aip.dev/160).
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
                    RequestParameters.Add("extraLocationTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "extraLocationTypes",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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

    /// <summary>
    /// A Backup of a Cloud Firestore Database. The backup contains all documents and index configurations for the given
    /// database at a specific point in time.
    /// </summary>
    public class GoogleFirestoreAdminV1Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the Firestore database that the backup is from. Format is
        /// `projects/{project}/databases/{database}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>
        /// Output only. The system-generated UUID4 for the Firestore database that the backup is from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseUid")]
        public virtual string DatabaseUid { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. The timestamp at which this backup expires.</summary>
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

        /// <summary>
        /// Output only. The unique resource name of the Backup. Format is
        /// `projects/{project}/locations/{location}/backups/{backup}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

        /// <summary>
        /// Output only. The backup contains an externally consistent copy of the database at this time.
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

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Statistics about the backup. This data only becomes available after the backup is fully
        /// materialized to secondary storage. This field will be empty till then.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual GoogleFirestoreAdminV1Stats Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A backup schedule for a Cloud Firestore Database. This resource is owned by the database it is backing up, and
    /// is deleted along with the database. The actual backups are not though.
    /// </summary>
    public class GoogleFirestoreAdminV1BackupSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The timestamp at which this backup schedule was created and effective since. No backups will be
        /// created for this schedule before this time.
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

        /// <summary>For a schedule that runs daily.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyRecurrence")]
        public virtual GoogleFirestoreAdminV1DailyRecurrence DailyRecurrence { get; set; }

        /// <summary>
        /// Output only. The unique backup schedule identifier across all locations and databases for the given project.
        /// This will be auto-assigned. Format is
        /// `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep
        /// backups for 7 days. The maximum supported retention period is 14 weeks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retention")]
        public virtual object Retention { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp at which this backup schedule was most recently updated. When a backup schedule
        /// is first created, this is the same as create_time.
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

        /// <summary>For a schedule that runs weekly on a specific day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyRecurrence")]
        public virtual GoogleFirestoreAdminV1WeeklyRecurrence WeeklyRecurrence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a backup that was used to restore a database.</summary>
    public class GoogleFirestoreAdminV1BackupSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the backup that was used to restore this database. Format:
        /// `projects/{project}/locations/{location}/backups/{backup}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

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

    /// <summary>
    /// The request for FirestoreAdmin.BulkDeleteDocuments. When both collection_ids and namespace_ids are set, only
    /// documents satisfying both conditions will be deleted. Requests with namespace_ids and collection_ids both empty
    /// will be rejected. Please use FirestoreAdmin.DeleteDatabase instead.
    /// </summary>
    public class GoogleFirestoreAdminV1BulkDeleteDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. IDs of the collection groups to delete. Unspecified means all collection groups. Each collection
        /// group in this list must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// Optional. Namespaces to delete. An empty list means all namespaces. This is the recommended usage for
        /// databases that don't use namespaces. An empty string element represents the default namespace. This should
        /// be used if the database has data in non-default namespaces, but doesn't want to delete from them. Each
        /// namespace in this list must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the long-running operation from the CloneDatabase request.</summary>
    public class GoogleFirestoreAdminV1CloneDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the database being cloned to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the clone finished, unset for ongoing clones.</summary>
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

        /// <summary>The operation state of the clone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>The snapshot from which this database was cloned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitrSnapshot")]
        public virtual GoogleFirestoreAdminV1PitrSnapshot PitrSnapshot { get; set; }

        /// <summary>How far along the clone is as an estimated percentage of remaining time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercentage")]
        public virtual GoogleFirestoreAdminV1Progress ProgressPercentage { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the clone was started.</summary>
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

    /// <summary>The request message for FirestoreAdmin.CloneDatabase.</summary>
    public class GoogleFirestoreAdminV1CloneDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The ID to use for the database, which will become the final component of the database's resource
        /// name. This database ID must not be associated with an existing database. This value should be 4-63
        /// characters. Valid characters are /a-z-/ with first character a letter and the last a letter or a number.
        /// Must not be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/. "(default)" database ID is also valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>
        /// Optional. Encryption configuration for the cloned database. If this field is not specified, the cloned
        /// database will use the same encryption configuration as the source database, namely use_source_encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual GoogleFirestoreAdminV1EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Required. Specification of the PITR data to clone from. The source database must exist. The cloned database
        /// will be created in the same location as the source database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitrSnapshot")]
        public virtual GoogleFirestoreAdminV1PitrSnapshot PitrSnapshot { get; set; }

        /// <summary>
        /// Optional. Immutable. Tags to be bound to the cloned database. The tags should be provided in the format of
        /// `tagKeys/{tag_key_id} -&amp;gt; tagValues/{tag_value_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The CMEK (Customer Managed Encryption Key) configuration for a Firestore database. If not present, the database
    /// is secured by the default Google encryption key.
    /// </summary>
    public class GoogleFirestoreAdminV1CmekConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Currently in-use [KMS key
        /// versions](https://cloud.google.com/kms/docs/resource-hierarchy#key_versions). During [key
        /// rotation](https://cloud.google.com/kms/docs/key-rotation), there can be multiple in-use key versions. The
        /// expected format is
        /// `projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{key_version}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeKeyVersion")]
        public virtual System.Collections.Generic.IList<string> ActiveKeyVersion { get; set; }

        /// <summary>
        /// Required. Only keys in the same location as this database are allowed to be used for encryption. For
        /// Firestore's nam5 multi-region, this corresponds to Cloud KMS multi-region us. For Firestore's eur3
        /// multi-region, this corresponds to Cloud KMS multi-region europe. See
        /// https://cloud.google.com/kms/docs/locations. The expected format is
        /// `projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to the create database operation.</summary>
    public class GoogleFirestoreAdminV1CreateDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration options for using CMEK (Customer Managed Encryption Key) encryption.</summary>
    public class GoogleFirestoreAdminV1CustomerManagedEncryptionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Only keys in the same location as the database are allowed to be used for encryption. For
        /// Firestore's nam5 multi-region, this corresponds to Cloud KMS multi-region us. For Firestore's eur3
        /// multi-region, this corresponds to Cloud KMS multi-region europe. See
        /// https://cloud.google.com/kms/docs/locations. The expected format is
        /// `projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a recurring schedule that runs every day. The time zone is UTC.</summary>
    public class GoogleFirestoreAdminV1DailyRecurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Firestore Database.</summary>
    public class GoogleFirestoreAdminV1Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The App Engine integration mode to use for this database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineIntegrationMode")]
        public virtual string AppEngineIntegrationMode { get; set; }

        /// <summary>Optional. Presence indicates CMEK is enabled for this database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekConfig")]
        public virtual GoogleFirestoreAdminV1CmekConfig CmekConfig { get; set; }

        /// <summary>The concurrency control mode to use for this database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrencyMode")]
        public virtual string ConcurrencyMode { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The timestamp at which this database was created. Databases created before 2016 do not populate
        /// create_time.
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

        /// <summary>Immutable. The edition of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseEdition")]
        public virtual string DatabaseEdition { get; set; }

        /// <summary>State of delete protection for the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteProtectionState")]
        public virtual string DeleteProtectionState { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. The timestamp at which this database was deleted. Only set if the database has been deleted.
        /// </summary>
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

        private string _earliestVersionTimeRaw;

        private object _earliestVersionTime;

        /// <summary>
        /// Output only. The earliest timestamp at which older versions of the data can be read from the database. See
        /// [version_retention_period] above; this field is populated with `now - version_retention_period`. This value
        /// is continuously updated, and becomes stale the moment it is queried. If you are using this value to recover
        /// data, make sure to account for the time from the moment when the value is queried to the moment when you
        /// initiate the recovery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestVersionTime")]
        public virtual string EarliestVersionTimeRaw
        {
            get => _earliestVersionTimeRaw;
            set
            {
                _earliestVersionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _earliestVersionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EarliestVersionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EarliestVersionTimeDateTimeOffset instead.")]
        public virtual object EarliestVersionTime
        {
            get => _earliestVersionTime;
            set
            {
                _earliestVersionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _earliestVersionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EarliestVersionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EarliestVersionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EarliestVersionTimeRaw);
            set => EarliestVersionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Background: Free tier is the ability of a Firestore database to use a small amount of resources
        /// every day without being charged. Once usage exceeds the free tier limit further usage is charged. Whether
        /// this database can make use of the free tier. Only one database per project can be eligible for the free
        /// tier. The first (or next) database that is created in a project without a free tier database will be marked
        /// as eligible for the free tier. Databases that are created while there is a free tier database will not be
        /// eligible for the free tier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTier")]
        public virtual System.Nullable<bool> FreeTier { get; set; }

        /// <summary>
        /// Output only. The key_prefix for this database. This key_prefix is used, in combination with the project ID
        /// ("~") to construct the application ID that is returned from the Cloud Datastore APIs in Google App Engine
        /// first generation runtimes. This value may be empty in which case the appid to use for URL-encoded keys is
        /// the project_id (eg: foo instead of v~foo).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyPrefix")]
        public virtual string KeyPrefix { get; set; }

        /// <summary>
        /// The location of the database. Available locations are listed at
        /// https://cloud.google.com/firestore/docs/locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>The resource name of the Database. Format: `projects/{project}/databases/{database}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether to enable the PITR feature on this database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointInTimeRecoveryEnablement")]
        public virtual string PointInTimeRecoveryEnablement { get; set; }

        /// <summary>
        /// Output only. The database resource's prior database ID. This field is only populated for deleted databases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousId")]
        public virtual string PreviousId { get; set; }

        /// <summary>Output only. Information about the provenance of this database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceInfo")]
        public virtual GoogleFirestoreAdminV1SourceInfo SourceInfo { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag keys/values directly bound to this resource. For example:
        /// "123/environment": "production", "123/costCenter": "marketing"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The type of the database. See https://cloud.google.com/datastore/docs/firestore-or-datastore for information
        /// about how to choose.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. The system-generated UUID4 for this Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp at which this database was most recently updated. Note this only includes updates
        /// to the database resource and not data contained by the database.
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

        /// <summary>
        /// Output only. The period during which past versions of data are retained in the database. Any read or query
        /// can specify a `read_time` within this window, and will read the state of the database at that time. If the
        /// PITR feature is enabled, the retention period is 7 days. Otherwise, the retention period is 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionRetentionPeriod")]
        public virtual object VersionRetentionPeriod { get; set; }
    }

    /// <summary>Metadata related to the delete database operation.</summary>
    public class GoogleFirestoreAdminV1DeleteDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirestoreAdmin.DisableUserCreds.</summary>
    public class GoogleFirestoreAdminV1DisableUserCredsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for FirestoreAdmin.EnableUserCreds.</summary>
    public class GoogleFirestoreAdminV1EnableUserCredsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encryption configuration for a new database being created from another source. The source could be a Backup .
    /// </summary>
    public class GoogleFirestoreAdminV1EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use Customer Managed Encryption Keys (CMEK) for encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerManagedEncryption")]
        public virtual GoogleFirestoreAdminV1CustomerManagedEncryptionOptions CustomerManagedEncryption { get; set; }

        /// <summary>Use Google default encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleDefaultEncryption")]
        public virtual GoogleFirestoreAdminV1GoogleDefaultEncryptionOptions GoogleDefaultEncryption { get; set; }

        /// <summary>The database will use the same encryption configuration as the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSourceEncryption")]
        public virtual GoogleFirestoreAdminV1SourceEncryptionOptions UseSourceEncryption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.ExportDocuments.</summary>
    public class GoogleFirestoreAdminV1ExportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection IDs are being exported.</summary>
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

        /// <summary>Which namespace IDs are being exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The state of the export operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>Where the documents are being exported to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1Progress ProgressDocuments { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

        /// <summary>
        /// The timestamp that corresponds to the version of the database that is being exported. If unspecified, there
        /// are no guarantees about the consistency of the documents being exported.
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

    /// <summary>The request for FirestoreAdmin.ExportDocuments.</summary>
    public class GoogleFirestoreAdminV1ExportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Which collection IDs to export. Unspecified means all collections. Each collection ID in this list must be
        /// unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// An empty list represents all namespaces. This is the preferred usage for databases that don't use
        /// namespaces. An empty string element represents the default namespace. This should be used if the database
        /// has data in non-default namespaces, but doesn't want to include them. Each namespace in this list must be
        /// unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>
        /// The output URI. Currently only supports Google Cloud Storage URIs of the form:
        /// `gs://BUCKET_NAME[/NAMESPACE_PATH]`, where `BUCKET_NAME` is the name of the Google Cloud Storage bucket and
        /// `NAMESPACE_PATH` is an optional Google Cloud Storage namespace path. When choosing a name, be sure to
        /// consider Google Cloud Storage naming guidelines: https://cloud.google.com/storage/docs/naming. If the URI is
        /// a bucket (without a namespace path), a prefix will be generated based on the start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUriPrefix")]
        public virtual string OutputUriPrefix { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

        /// <summary>
        /// The timestamp that corresponds to the version of the database to be exported. The timestamp must be in the
        /// past, rounded to the minute and not older than earliestVersionTime. If specified, then the exported
        /// documents will represent a consistent view of the database at the provided time. Otherwise, there are no
        /// guarantees about the consistency of the exported documents.
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
    /// collections in the database with the same ID.
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
        /// Required. A field name of the form:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_path}` A field
        /// path can be a simple field name, e.g. `address` or a path to fields within `map_value` , e.g.
        /// `address.city`, or a special field path. The only valid special field is `*`, which represents any field.
        /// Field paths can be quoted using `` ` `` (backtick). The only character that must be escaped within a quoted
        /// field path is the backtick character itself, escaped using a backslash. Special characters in field paths
        /// that must be quoted include: `*`, `.`, `` ` `` (backtick), `[`, `]`, as well as any ascii symbolic
        /// characters. Examples: `` `address.city` `` represents a field named `address.city`, not the map key `city`
        /// in the field `address`. `` `*` `` represents a field named `*`, not any field. A special `Field` contains
        /// the default indexing settings for all fields. This field's resource name is:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*` Indexes defined on
        /// this `Field` will be applied to all fields which do not have their own `Field` index configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The TTL configuration for this `Field`. Setting or unsetting this will enable or disable the TTL for
        /// documents that have this `Field`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttlConfig")]
        public virtual GoogleFirestoreAdminV1TtlConfig TtlConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.UpdateField.</summary>
    public class GoogleFirestoreAdminV1FieldOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Describes the deltas of TTL configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttlConfigDelta")]
        public virtual GoogleFirestoreAdminV1TtlConfigDelta TtlConfigDelta { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An index that stores vectors in a flat data structure, and supports exhaustive search.</summary>
    public class GoogleFirestoreAdminV1FlatIndex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration options for using Google default encryption.</summary>
    public class GoogleFirestoreAdminV1GoogleDefaultEncryptionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.ImportDocuments.</summary>
    public class GoogleFirestoreAdminV1ImportDocumentsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which collection IDs are being imported.</summary>
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

        /// <summary>The location of the documents being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUriPrefix")]
        public virtual string InputUriPrefix { get; set; }

        /// <summary>Which namespace IDs are being imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The state of the import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>The progress, in bytes, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressBytes")]
        public virtual GoogleFirestoreAdminV1Progress ProgressBytes { get; set; }

        /// <summary>The progress, in documents, of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressDocuments")]
        public virtual GoogleFirestoreAdminV1Progress ProgressDocuments { get; set; }

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

    /// <summary>The request for FirestoreAdmin.ImportDocuments.</summary>
    public class GoogleFirestoreAdminV1ImportDocumentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Which collection IDs to import. Unspecified means all collections included in the import. Each collection ID
        /// in this list must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionIds")]
        public virtual System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// Location of the exported files. This must match the output_uri_prefix of an ExportDocumentsResponse from an
        /// export that has completed successfully. See:
        /// google.firestore.admin.v1.ExportDocumentsResponse.output_uri_prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUriPrefix")]
        public virtual string InputUriPrefix { get; set; }

        /// <summary>
        /// An empty list represents all namespaces. This is the preferred usage for databases that don't use
        /// namespaces. An empty string element represents the default namespace. This should be used if the database
        /// has data in non-default namespaces, but doesn't want to include them. Each namespace in this list must be
        /// unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceIds")]
        public virtual System.Collections.Generic.IList<string> NamespaceIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Firestore indexes enable simple and complex queries against documents in a database.</summary>
    public class GoogleFirestoreAdminV1Index : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API scope supported by this index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiScope")]
        public virtual string ApiScope { get; set; }

        /// <summary>Immutable. The density configuration of the index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("density")]
        public virtual string Density { get; set; }

        /// <summary>
        /// The fields supported by this index. For composite indexes, this requires a minimum of 2 and a maximum of 100
        /// fields. The last field entry is always for the field path `__name__`. If, on creation, `__name__` was not
        /// specified as the last field, it will be added automatically with the same direction as that of the last
        /// field defined. If the final field in a composite index is not directional, the `__name__` will be ordered
        /// ASCENDING (unless explicitly specified). For single field indexes, this will always be exactly one entry
        /// with a field path equal to the field path of the associated field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1IndexField> Fields { get; set; }

        /// <summary>
        /// Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes,
        /// none of the paths in the index definition reach or traverse an array, except via an explicit array index.
        /// For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except
        /// via an explicit array index. Violations will result in errors. Note this field only applies to index with
        /// MONGODB_COMPATIBLE_API ApiScope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multikey")]
        public virtual System.Nullable<bool> Multikey { get; set; }

        /// <summary>
        /// Output only. A server defined name for this index. The form of this name for composite indexes will be:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{composite_index_id}`
        /// For single field indexes, this field will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Indexes with a collection query scope specified allow queries against a collection that is the child of a
        /// specific document, specified at query time, and that has the same collection ID. Indexes with a collection
        /// group query scope specified allow queries against all collections descended from a specific document,
        /// specified at query time, and that have the same collection ID as this index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryScope")]
        public virtual string QueryScope { get; set; }

        /// <summary>Optional. The number of shards for the index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<int> ShardCount { get; set; }

        /// <summary>Output only. The serving state of the index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique
        /// across documents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unique")]
        public virtual System.Nullable<bool> Unique { get; set; }

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

        /// <summary>Indicates that this field supports nearest neighbor and distance operations on vector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vectorConfig")]
        public virtual GoogleFirestoreAdminV1VectorConfig VectorConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for google.longrunning.Operation results from FirestoreAdmin.CreateIndex.</summary>
    public class GoogleFirestoreAdminV1IndexOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirestoreAdmin.ListBackupSchedules.</summary>
    public class GoogleFirestoreAdminV1ListBackupSchedulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all backup schedules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSchedules")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1BackupSchedule> BackupSchedules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for FirestoreAdmin.ListBackups.</summary>
    public class GoogleFirestoreAdminV1ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all backups for the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1Backup> Backups { get; set; }

        /// <summary>
        /// List of locations that existing backups were not able to be fetched from. Instead of failing the entire
        /// requests when a single location is unreachable, this response returns a partial result set and list of
        /// locations unable to be reached here. The request can be retried against a single location to get a concrete
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The list of databases for a project.</summary>
    public class GoogleFirestoreAdminV1ListDatabasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The databases in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databases")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1Database> Databases { get; set; }

        /// <summary>
        /// In the event that data about individual databases cannot be listed they will be recorded here. An example
        /// entry might be: projects/some_project/locations/some_location This can happen if the Cloud Region that the
        /// Database resides in is currently unavailable. In this case we can't fetch all the details about the
        /// database. You may be able to get a more detailed error message (or possibly fetch the resource) by sending a
        /// 'Get' request for the resource or a 'List' request for the specific location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>The response for FirestoreAdmin.ListUserCreds.</summary>
    public class GoogleFirestoreAdminV1ListUserCredsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user creds for the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCreds")]
        public virtual System.Collections.Generic.IList<GoogleFirestoreAdminV1UserCreds> UserCreds { get; set; }

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
    /// A consistent snapshot of a database at a specific point in time. A PITR (Point-in-time recovery) snapshot with
    /// previous versions of a database's data is available for every minute up to the associated database's data
    /// retention period. If the PITR feature is enabled, the retention period is 7 days; otherwise, it is one hour.
    /// </summary>
    public class GoogleFirestoreAdminV1PitrSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the database that this was a snapshot of. Format:
        /// `projects/{project}/databases/{database}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Output only. Public UUID of the database the snapshot was associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseUid")]
        public virtual string DatabaseUid { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

        /// <summary>Required. Snapshot time of the database.</summary>
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

    /// <summary>The request for FirestoreAdmin.ResetUserPassword.</summary>
    public class GoogleFirestoreAdminV1ResetUserPasswordRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a Resource Identity principal.</summary>
    public class GoogleFirestoreAdminV1ResourceIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Principal identifier string. See: https://cloud.google.com/iam/docs/principal-identifiers
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

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

    /// <summary>The request message for FirestoreAdmin.RestoreDatabase.</summary>
    public class GoogleFirestoreAdminV1RestoreDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Backup to restore from. Must be from the same project as the parent. The restored database will be
        /// created in the same location as the source backup. Format is:
        /// `projects/{project_id}/locations/{location}/backups/{backup}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// Required. The ID to use for the database, which will become the final component of the database's resource
        /// name. This database ID must not be associated with an existing database. This value should be 4-63
        /// characters. Valid characters are /a-z-/ with first character a letter and the last a letter or a number.
        /// Must not be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/. "(default)" database ID is also valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>
        /// Optional. Encryption configuration for the restored database. If this field is not specified, the restored
        /// database will use the same encryption configuration as the backup, namely use_source_encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual GoogleFirestoreAdminV1EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Optional. Immutable. Tags to be bound to the restored database. The tags should be provided in the format of
        /// `tagKeys/{tag_key_id} -&amp;gt; tagValues/{tag_value_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration options for using the same encryption method as the source.</summary>
    public class GoogleFirestoreAdminV1SourceEncryptionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the provenance of this database.</summary>
    public class GoogleFirestoreAdminV1SourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, this database was restored from the specified backup (or a snapshot thereof).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual GoogleFirestoreAdminV1BackupSource Backup { get; set; }

        /// <summary>
        /// The associated long-running operation. This field may not be set after the operation has completed. Format:
        /// `projects/{project}/databases/{database}/operations/{operation}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup specific statistics.</summary>
    public class GoogleFirestoreAdminV1Stats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The total number of documents contained in the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentCount")]
        public virtual System.Nullable<long> DocumentCount { get; set; }

        /// <summary>Output only. The total number of index entries contained in the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexCount")]
        public virtual System.Nullable<long> IndexCount { get; set; }

        /// <summary>
        /// Output only. Summation of the size of all documents and index entries in the backup, measured in bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The TTL (time-to-live) configuration for documents that have this `Field` set. Storing a timestamp value into a
    /// TTL-enabled field will be treated as the document's absolute expiration time. Timestamp values in the past
    /// indicate that the document is eligible for immediate expiration. Using any other data type or leaving the field
    /// absent will disable expiration for the individual document.
    /// </summary>
    public class GoogleFirestoreAdminV1TtlConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The state of the TTL configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a TTL configuration change.</summary>
    public class GoogleFirestoreAdminV1TtlConfigDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies how the TTL configuration is changing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeType")]
        public virtual string ChangeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to the update database operation.</summary>
    public class GoogleFirestoreAdminV1UpdateDatabaseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud Firestore User Creds.</summary>
    public class GoogleFirestoreAdminV1UserCreds : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the user creds were created.</summary>
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
        /// Identifier. The resource name of the UserCreds. Format:
        /// `projects/{project}/databases/{database}/userCreds/{user_creds}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Resource Identity descriptor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceIdentity")]
        public virtual GoogleFirestoreAdminV1ResourceIdentity ResourceIdentity { get; set; }

        /// <summary>
        /// Output only. The plaintext server-generated password for the user creds. Only populated in responses for
        /// CreateUserCreds and ResetUserPassword.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securePassword")]
        public virtual string SecurePassword { get; set; }

        /// <summary>
        /// Output only. Whether the user creds are enabled or disabled. Defaults to ENABLED on creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the user creds were last updated.</summary>
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

    /// <summary>The index configuration to support vector search operations</summary>
    public class GoogleFirestoreAdminV1VectorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The vector dimension this configuration applies to. The resulting index will only include vectors
        /// of this dimension, and can be used for vector search with the same dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual System.Nullable<int> Dimension { get; set; }

        /// <summary>Indicates the vector index is a flat index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flat")]
        public virtual GoogleFirestoreAdminV1FlatIndex Flat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a recurring schedule that runs on a specified day of the week. The time zone is UTC.
    /// </summary>
    public class GoogleFirestoreAdminV1WeeklyRecurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The day of week to run. DAY_OF_WEEK_UNSPECIFIED is not allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

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

    /// <summary>A resource that represents a Google Cloud location.</summary>
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
