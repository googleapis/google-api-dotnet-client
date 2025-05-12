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

namespace Google.Apis.SQLAdmin.v1beta4
{
    /// <summary>The SQLAdmin Service.</summary>
    public class SQLAdminService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta4";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SQLAdminService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SQLAdminService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BackupRuns = new BackupRunsResource(this);
            Backups = new BackupsResource(this);
            Connect = new ConnectResource(this);
            Databases = new DatabasesResource(this);
            Flags = new FlagsResource(this);
            Instances = new InstancesResource(this);
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
            SslCerts = new SslCertsResource(this);
            Tiers = new TiersResource(this);
            Users = new UsersResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://sqladmin.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://sqladmin.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "sqladmin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud SQL Admin API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google SQL Service instances</summary>
            public static string SqlserviceAdmin = "https://www.googleapis.com/auth/sqlservice.admin";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud SQL Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google SQL Service instances</summary>
            public const string SqlserviceAdmin = "https://www.googleapis.com/auth/sqlservice.admin";
        }

        /// <summary>Gets the BackupRuns resource.</summary>
        public virtual BackupRunsResource BackupRuns { get; }

        /// <summary>Gets the Backups resource.</summary>
        public virtual BackupsResource Backups { get; }

        /// <summary>Gets the Connect resource.</summary>
        public virtual ConnectResource Connect { get; }

        /// <summary>Gets the Databases resource.</summary>
        public virtual DatabasesResource Databases { get; }

        /// <summary>Gets the Flags resource.</summary>
        public virtual FlagsResource Flags { get; }

        /// <summary>Gets the Instances resource.</summary>
        public virtual InstancesResource Instances { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the SslCerts resource.</summary>
        public virtual SslCertsResource SslCerts { get; }

        /// <summary>Gets the Tiers resource.</summary>
        public virtual TiersResource Tiers { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for SQLAdmin requests.</summary>
    public abstract class SQLAdminBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SQLAdminBaseServiceRequest instance.</summary>
        protected SQLAdminBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SQLAdmin parameter list.</summary>
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

    /// <summary>The "backupRuns" collection of methods.</summary>
    public class BackupRunsResource
    {
        private const string Resource = "backupRuns";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BackupRunsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes the backup taken by a backup run.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="id">
        /// The ID of the backup run to delete. To find a backup run ID, use the
        /// [list](https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1beta4/backupRuns/list) method.
        /// </param>
        public virtual DeleteRequest Delete(string project, string instance, long id)
        {
            return new DeleteRequest(this.service, project, instance, id);
        }

        /// <summary>Deletes the backup taken by a backup run.</summary>
        public class DeleteRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string instance, long id) : base(service)
            {
                Project = project;
                Instance = instance;
                Id = id;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>
            /// The ID of the backup run to delete. To find a backup run ID, use the
            /// [list](https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1beta4/backupRuns/list) method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/backupRuns/{id}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a resource containing information about a backup run.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="id">The ID of this backup run.</param>
        public virtual GetRequest Get(string project, string instance, long id)
        {
            return new GetRequest(this.service, project, instance, id);
        }

        /// <summary>Retrieves a resource containing information about a backup run.</summary>
        public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.BackupRun>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string instance, long id) : base(service)
            {
                Project = project;
                Instance = instance;
                Id = id;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>The ID of this backup run.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/backupRuns/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new backup run on demand.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual InsertRequest Insert(Google.Apis.SQLAdmin.v1beta4.Data.BackupRun body, string project, string instance)
        {
            return new InsertRequest(this.service, body, project, instance);
        }

        /// <summary>Creates a new backup run on demand.</summary>
        public class InsertRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.BackupRun body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.BackupRun Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/backupRuns";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all backup runs associated with the project or a given instance and configuration in the reverse
        /// chronological order of the backup initiation time.
        /// </summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">
        /// Cloud SQL instance ID, or "-" for all instances. This does not include the project ID.
        /// </param>
        public virtual ListRequest List(string project, string instance)
        {
            return new ListRequest(this.service, project, instance);
        }

        /// <summary>
        /// Lists all backup runs associated with the project or a given instance and configuration in the reverse
        /// chronological order of the backup initiation time.
        /// </summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.BackupRunsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Cloud SQL instance ID, or "-" for all instances. This does not include the project ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Maximum number of backup runs per response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/backupRuns";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to create on-demand backups.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The parent resource where this backup is created. Format: projects/{project}
        /// </param>
        public virtual CreateBackupRequest CreateBackup(Google.Apis.SQLAdmin.v1beta4.Data.Backup body, string parent)
        {
            return new CreateBackupRequest(this.service, body, parent);
        }

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to create on-demand backups.
        /// </summary>
        public class CreateBackupRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new CreateBackup request.</summary>
            public CreateBackupRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.Backup body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent resource where this backup is created. Format: projects/{project}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.Backup Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createBackup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/{+parent}/backups";

            /// <summary>Initializes CreateBackup parameter list.</summary>
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

        /// <summary>Deletes the backup.</summary>
        /// <param name="name">
        /// Required. The name of the backup to delete. Format: projects/{project}/backups/{backup}
        /// </param>
        public virtual DeleteBackupRequest DeleteBackup(string name)
        {
            return new DeleteBackupRequest(this.service, name);
        }

        /// <summary>Deletes the backup.</summary>
        public class DeleteBackupRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new DeleteBackup request.</summary>
            public DeleteBackupRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the backup to delete. Format: projects/{project}/backups/{backup}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteBackup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/{+name}";

            /// <summary>Initializes DeleteBackup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/backups/[^/]+$",
                });
            }
        }

        /// <summary>Retrieves a resource containing information about a backup.</summary>
        /// <param name="name">
        /// Required. The name of the backup to retrieve. Format: projects/{project}/backups/{backup}
        /// </param>
        public virtual GetBackupRequest GetBackup(string name)
        {
            return new GetBackupRequest(this.service, name);
        }

        /// <summary>Retrieves a resource containing information about a backup.</summary>
        public class GetBackupRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Backup>
        {
            /// <summary>Constructs a new GetBackup request.</summary>
            public GetBackupRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the backup to retrieve. Format: projects/{project}/backups/{backup}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getBackup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/{+name}";

            /// <summary>Initializes GetBackup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/backups/[^/]+$",
                });
            }
        }

        /// <summary>Lists all backups associated with the project.</summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of backups. Format: projects/{project}
        /// </param>
        public virtual ListBackupsRequest ListBackups(string parent)
        {
            return new ListBackupsRequest(this.service, parent);
        }

        /// <summary>Lists all backups associated with the project.</summary>
        public class ListBackupsRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.ListBackupsResponse>
        {
            /// <summary>Constructs a new ListBackups request.</summary>
            public ListBackupsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>Required. The parent that owns this collection of backups. Format: projects/{project}</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Multiple filter queries are separated by spaces. For example, 'instance:abc AND type:FINAL,
            /// 'location:us', 'backupInterval.startTime&amp;gt;=1950-01-01T01:01:25.771Z'. You can filter by type,
            /// instance, backupInterval.startTime (creation time), or location.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of backups to return per response. The service might return fewer backups than this
            /// value. If a value for this parameter isn't specified, then, at most, 500 backups are returned. The
            /// maximum value is 2,000. Any values that you set, which are greater than 2,000, are changed to 2,000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListBackups` call. Provide this to retrieve the subsequent page.
            /// When paginating, all other parameters provided to `ListBackups` must match the call that provided the
            /// page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listBackups";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/{+parent}/backups";

            /// <summary>Initializes ListBackups parameter list.</summary>
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
        /// Updates the retention period and the description of the backup. You can use this API to update final backups
        /// only.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. The resource name of the backup. Format: projects/{project}/backups/{backup}.
        /// </param>
        public virtual UpdateBackupRequest UpdateBackup(Google.Apis.SQLAdmin.v1beta4.Data.Backup body, string name)
        {
            return new UpdateBackupRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use this API to update final backups
        /// only.
        /// </summary>
        public class UpdateBackupRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new UpdateBackup request.</summary>
            public UpdateBackupRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.Backup body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. The resource name of the backup. Format: projects/{project}/backups/{backup}.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The list of fields that you can update. You can update only the description and retention period of the
            /// final backup.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.Backup Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateBackup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/{+name}";

            /// <summary>Initializes UpdateBackup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/backups/[^/]+$",
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

    /// <summary>The "connect" collection of methods.</summary>
    public class ConnectResource
    {
        private const string Resource = "connect";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ConnectResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key and signed by a private key
        /// specific to the target instance. Users may use the certificate to authenticate as themselves when connecting
        /// to the database.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual GenerateEphemeralCertRequest GenerateEphemeralCert(Google.Apis.SQLAdmin.v1beta4.Data.GenerateEphemeralCertRequest body, string project, string instance)
        {
            return new GenerateEphemeralCertRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key and signed by a private key
        /// specific to the target instance. Users may use the certificate to authenticate as themselves when connecting
        /// to the database.
        /// </summary>
        public class GenerateEphemeralCertRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.GenerateEphemeralCertResponse>
        {
            /// <summary>Constructs a new GenerateEphemeralCert request.</summary>
            public GenerateEphemeralCertRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.GenerateEphemeralCertRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.GenerateEphemeralCertRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateEphemeralCert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}:generateEphemeralCert";

            /// <summary>Initializes GenerateEphemeralCert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves connect settings about a Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual GetRequest Get(string project, string instance)
        {
            return new GetRequest(this.service, project, instance);
        }

        /// <summary>Retrieves connect settings about a Cloud SQL instance.</summary>
        public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.ConnectSettings>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            private object _readTime;

            /// <summary>
            /// String representation of <see cref="ReadTimeDateTimeOffset"/>, formatted for inclusion in the HTTP
            /// request.
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

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/connectSettings";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
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
            }
        }
    }

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
        }

        /// <summary>Deletes a database from a Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="database">Name of the database to be deleted in the instance.</param>
        public virtual DeleteRequest Delete(string project, string instance, string database)
        {
            return new DeleteRequest(this.service, project, instance, database);
        }

        /// <summary>Deletes a database from a Cloud SQL instance.</summary>
        public class DeleteRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string instance, string database) : base(service)
            {
                Project = project;
                Instance = instance;
                Database = database;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Name of the database to be deleted in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Database { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/databases/{database}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                {
                    Name = "database",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a resource containing information about a database inside a Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="database">Name of the database in the instance.</param>
        public virtual GetRequest Get(string project, string instance, string database)
        {
            return new GetRequest(this.service, project, instance, database);
        }

        /// <summary>Retrieves a resource containing information about a database inside a Cloud SQL instance.</summary>
        public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Database>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string instance, string database) : base(service)
            {
                Project = project;
                Instance = instance;
                Database = database;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Name of the database in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Database { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/databases/{database}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                {
                    Name = "database",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Inserts a resource containing information about a database inside a Cloud SQL instance. **Note:** You can't
        /// modify the default character set and collation.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        public virtual InsertRequest Insert(Google.Apis.SQLAdmin.v1beta4.Data.Database body, string project, string instance)
        {
            return new InsertRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Inserts a resource containing information about a database inside a Cloud SQL instance. **Note:** You can't
        /// modify the default character set and collation.
        /// </summary>
        public class InsertRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.Database body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.Database Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/databases";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists databases in the specified Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual ListRequest List(string project, string instance)
        {
            return new ListRequest(this.service, project, instance);
        }

        /// <summary>Lists databases in the specified Cloud SQL instance.</summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.DatabasesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/databases";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Partially updates a resource containing information about a database inside a Cloud SQL instance. This
        /// method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="database">Name of the database to be updated in the instance.</param>
        public virtual PatchRequest Patch(Google.Apis.SQLAdmin.v1beta4.Data.Database body, string project, string instance, string database)
        {
            return new PatchRequest(this.service, body, project, instance, database);
        }

        /// <summary>
        /// Partially updates a resource containing information about a database inside a Cloud SQL instance. This
        /// method supports patch semantics.
        /// </summary>
        public class PatchRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.Database body, string project, string instance, string database) : base(service)
            {
                Project = project;
                Instance = instance;
                Database = database;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Name of the database to be updated in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Database { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.Database Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/databases/{database}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                {
                    Name = "database",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a resource containing information about a database inside a Cloud SQL instance.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="database">Name of the database to be updated in the instance.</param>
        public virtual UpdateRequest Update(Google.Apis.SQLAdmin.v1beta4.Data.Database body, string project, string instance, string database)
        {
            return new UpdateRequest(this.service, body, project, instance, database);
        }

        /// <summary>Updates a resource containing information about a database inside a Cloud SQL instance.</summary>
        public class UpdateRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.Database body, string project, string instance, string database) : base(service)
            {
                Project = project;
                Instance = instance;
                Database = database;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Name of the database to be updated in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("database", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Database { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.Database Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/databases/{database}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("database", new Google.Apis.Discovery.Parameter
                {
                    Name = "database",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "flags" collection of methods.</summary>
    public class FlagsResource
    {
        private const string Resource = "flags";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FlagsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists all available database flags for Cloud SQL instances.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists all available database flags for Cloud SQL instances.</summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.FlagsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Database type and version you want to retrieve flags for. By default, this method returns flags for all
            /// database types and versions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("databaseVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DatabaseVersion { get; set; }

            /// <summary>
            /// Optional. Specify the scope of flags to be returned by SqlFlagsListService. Return list of database
            /// flags if unspecified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("flagScope", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<FlagScopeEnum> FlagScope { get; set; }

            /// <summary>
            /// Optional. Specify the scope of flags to be returned by SqlFlagsListService. Return list of database
            /// flags if unspecified.
            /// </summary>
            public enum FlagScopeEnum
            {
                /// <summary>Assume database flags if unspecified</summary>
                [Google.Apis.Util.StringValueAttribute("SQL_FLAG_SCOPE_UNSPECIFIED")]
                SQLFLAGSCOPEUNSPECIFIED = 0,

                /// <summary>database flags</summary>
                [Google.Apis.Util.StringValueAttribute("SQL_FLAG_SCOPE_DATABASE")]
                SQLFLAGSCOPEDATABASE = 1,

                /// <summary>connection pool configuration flags</summary>
                [Google.Apis.Util.StringValueAttribute("SQL_FLAG_SCOPE_CONNECTION_POOL")]
                SQLFLAGSCOPECONNECTIONPOOL = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/flags";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("databaseVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "databaseVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("flagScope", new Google.Apis.Discovery.Parameter
                {
                    Name = "flagScope",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "instances" collection of methods.</summary>
    public class InstancesResource
    {
        private const string Resource = "instances";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InstancesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Lists all versions of server certificates and certificate authorities (CAs) for the specified instance.
        /// There can be up to three sets of certs listed: the certificate that is currently in use, a future that has
        /// been added but not yet used to sign a certificate, and a certificate that has been rotated out. For
        /// instances not using Certificate Authority Service (CAS) server CA, use ListServerCas instead.
        /// </summary>
        /// <param name="project">Required. Project ID of the project that contains the instance.</param>
        /// <param name="instance">Required. Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual ListServerCertificatesRequest ListServerCertificates(string project, string instance)
        {
            return new ListServerCertificatesRequest(this.service, project, instance);
        }

        /// <summary>
        /// Lists all versions of server certificates and certificate authorities (CAs) for the specified instance.
        /// There can be up to three sets of certs listed: the certificate that is currently in use, a future that has
        /// been added but not yet used to sign a certificate, and a certificate that has been rotated out. For
        /// instances not using Certificate Authority Service (CAS) server CA, use ListServerCas instead.
        /// </summary>
        public class ListServerCertificatesRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.InstancesListServerCertificatesResponse>
        {
            /// <summary>Constructs a new ListServerCertificates request.</summary>
            public ListServerCertificatesRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Required. Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Required. Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "ListServerCertificates";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/listServerCertificates";

            /// <summary>Initializes ListServerCertificates parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Rotates the server certificate version to one previously added with the addServerCertificate method. For
        /// instances not using Certificate Authority Service (CAS) server CA, use RotateServerCa instead.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Required. Project ID of the project that contains the instance.</param>
        /// <param name="instance">Required. Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual RotateServerCertificateRequest RotateServerCertificate(Google.Apis.SQLAdmin.v1beta4.Data.InstancesRotateServerCertificateRequest body, string project, string instance)
        {
            return new RotateServerCertificateRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Rotates the server certificate version to one previously added with the addServerCertificate method. For
        /// instances not using Certificate Authority Service (CAS) server CA, use RotateServerCa instead.
        /// </summary>
        public class RotateServerCertificateRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new RotateServerCertificate request.</summary>
            public RotateServerCertificateRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesRotateServerCertificateRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Required. Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesRotateServerCertificateRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "RotateServerCertificate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/rotateServerCertificate";

            /// <summary>Initializes RotateServerCertificate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Acquire a lease for the setup of SQL Server Reporting Services (SSRS).</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Required. ID of the project that contains the instance (Example: project-id).</param>
        /// <param name="instance">
        /// Required. Cloud SQL instance ID. This doesn't include the project ID. It's composed of lowercase letters,
        /// numbers, and hyphens, and it must start with a letter. The total length must be 98 characters or less
        /// (Example: instance-id).
        /// </param>
        public virtual AcquireSsrsLeaseRequest AcquireSsrsLease(Google.Apis.SQLAdmin.v1beta4.Data.InstancesAcquireSsrsLeaseRequest body, string project, string instance)
        {
            return new AcquireSsrsLeaseRequest(this.service, body, project, instance);
        }

        /// <summary>Acquire a lease for the setup of SQL Server Reporting Services (SSRS).</summary>
        public class AcquireSsrsLeaseRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesAcquireSsrsLeaseResponse>
        {
            /// <summary>Constructs a new AcquireSsrsLease request.</summary>
            public AcquireSsrsLeaseRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesAcquireSsrsLeaseRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. ID of the project that contains the instance (Example: project-id).</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Required. Cloud SQL instance ID. This doesn't include the project ID. It's composed of lowercase
            /// letters, numbers, and hyphens, and it must start with a letter. The total length must be 98 characters
            /// or less (Example: instance-id).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesAcquireSsrsLeaseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "acquireSsrsLease";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/acquireSsrsLease";

            /// <summary>Initializes AcquireSsrsLease parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Add a new trusted Certificate Authority (CA) version for the specified instance. Required to prepare for a
        /// certificate rotation. If a CA version was previously added but never used in a certificate rotation, this
        /// operation replaces that version. There cannot be more than one CA version waiting to be rotated in. For
        /// instances that have enabled Certificate Authority Service (CAS) based server CA, use AddServerCertificate to
        /// add a new server certificate.
        /// </summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual AddServerCaRequest AddServerCa(string project, string instance)
        {
            return new AddServerCaRequest(this.service, project, instance);
        }

        /// <summary>
        /// Add a new trusted Certificate Authority (CA) version for the specified instance. Required to prepare for a
        /// certificate rotation. If a CA version was previously added but never used in a certificate rotation, this
        /// operation replaces that version. There cannot be more than one CA version waiting to be rotated in. For
        /// instances that have enabled Certificate Authority Service (CAS) based server CA, use AddServerCertificate to
        /// add a new server certificate.
        /// </summary>
        public class AddServerCaRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new AddServerCa request.</summary>
            public AddServerCaRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addServerCa";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/addServerCa";

            /// <summary>Initializes AddServerCa parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Add a new trusted server certificate version for the specified instance using Certificate Authority Service
        /// (CAS) server CA. Required to prepare for a certificate rotation. If a server certificate version was
        /// previously added but never used in a certificate rotation, this operation replaces that version. There
        /// cannot be more than one certificate version waiting to be rotated in. For instances not using CAS server CA,
        /// use AddServerCa instead.
        /// </summary>
        /// <param name="project">Required. Project ID of the project that contains the instance.</param>
        /// <param name="instance">Required. Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual AddServerCertificateRequest AddServerCertificate(string project, string instance)
        {
            return new AddServerCertificateRequest(this.service, project, instance);
        }

        /// <summary>
        /// Add a new trusted server certificate version for the specified instance using Certificate Authority Service
        /// (CAS) server CA. Required to prepare for a certificate rotation. If a server certificate version was
        /// previously added but never used in a certificate rotation, this operation replaces that version. There
        /// cannot be more than one certificate version waiting to be rotated in. For instances not using CAS server CA,
        /// use AddServerCa instead.
        /// </summary>
        public class AddServerCertificateRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new AddServerCertificate request.</summary>
            public AddServerCertificateRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Required. Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Required. Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addServerCertificate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/addServerCertificate";

            /// <summary>Initializes AddServerCertificate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. Using this operation might cause your
        /// instance to restart.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the source as well as the clone Cloud SQL instance.</param>
        /// <param name="instance">
        /// The ID of the Cloud SQL instance to be cloned (source). This does not include the project ID.
        /// </param>
        public virtual CloneRequest Clone(Google.Apis.SQLAdmin.v1beta4.Data.InstancesCloneRequest body, string project, string instance)
        {
            return new CloneRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. Using this operation might cause your
        /// instance to restart.
        /// </summary>
        public class CloneRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Clone request.</summary>
            public CloneRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesCloneRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the source as well as the clone Cloud SQL instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// The ID of the Cloud SQL instance to be cloned (source). This does not include the project ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesCloneRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "clone";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/clone";

            /// <summary>Initializes Clone parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance to be deleted.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual DeleteRequest Delete(string project, string instance)
        {
            return new DeleteRequest(this.service, project, instance);
        }

        /// <summary>Deletes a Cloud SQL instance.</summary>
        public class DeleteRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Flag to opt-in for final backup. By default, it is turned off.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enableFinalBackup", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnableFinalBackup { get; set; }

            /// <summary>Optional. The description of the final backup.</summary>
            [Google.Apis.Util.RequestParameterAttribute("finalBackupDescription", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string FinalBackupDescription { get; set; }

            private object _finalBackupExpiryTime;

            /// <summary>
            /// String representation of <see cref="FinalBackupExpiryTimeDateTimeOffset"/>, formatted for inclusion in
            /// the HTTP request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("finalBackupExpiryTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string FinalBackupExpiryTimeRaw { get; private set; }

            /// <summary><seealso cref="object"/> representation of <see cref="FinalBackupExpiryTimeRaw"/>.</summary>
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinalBackupExpiryTimeDateTimeOffset instead.")]
            public virtual object FinalBackupExpiryTime
            {
                get => _finalBackupExpiryTime;
                set
                {
                    FinalBackupExpiryTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                    _finalBackupExpiryTime = value;
                }
            }

            public virtual System.DateTimeOffset? FinalBackupExpiryTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinalBackupExpiryTimeRaw);
                set
                {
                    FinalBackupExpiryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                    _finalBackupExpiryTime = value;
                }
            }

            /// <summary>Optional. Retention period of the final backup.</summary>
            [Google.Apis.Util.RequestParameterAttribute("finalBackupTtlDays", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> FinalBackupTtlDays { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enableFinalBackup", new Google.Apis.Discovery.Parameter
                {
                    Name = "enableFinalBackup",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("finalBackupDescription", new Google.Apis.Discovery.Parameter
                {
                    Name = "finalBackupDescription",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("finalBackupExpiryTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "finalBackupExpiryTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("finalBackupTtlDays", new Google.Apis.Discovery.Parameter
                {
                    Name = "finalBackupTtlDays",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Demotes an existing standalone instance to be a Cloud SQL read replica for an external database server.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Required. The project ID of the project that contains the instance.</param>
        /// <param name="instance">Required. The name of the Cloud SQL instance.</param>
        public virtual DemoteRequest Demote(Google.Apis.SQLAdmin.v1beta4.Data.InstancesDemoteRequest body, string project, string instance)
        {
            return new DemoteRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Demotes an existing standalone instance to be a Cloud SQL read replica for an external database server.
        /// </summary>
        public class DemoteRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Demote request.</summary>
            public DemoteRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesDemoteRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Required. The name of the Cloud SQL instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesDemoteRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "demote";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/demote";

            /// <summary>Initializes Demote parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Demotes the stand-alone instance to be a Cloud SQL read replica for an external database server.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance name.</param>
        public virtual DemoteMasterRequest DemoteMaster(Google.Apis.SQLAdmin.v1beta4.Data.InstancesDemoteMasterRequest body, string project, string instance)
        {
            return new DemoteMasterRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Demotes the stand-alone instance to be a Cloud SQL read replica for an external database server.
        /// </summary>
        public class DemoteMasterRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new DemoteMaster request.</summary>
            public DemoteMasterRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesDemoteMasterRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesDemoteMasterRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "demoteMaster";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/demoteMaster";

            /// <summary>Initializes DemoteMaster parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Cloud Storage bucket as a SQL dump or CSV file.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance to be exported.</param>
        /// <param name="instance">The Cloud SQL instance ID. This doesn't include the project ID.</param>
        public virtual ExportRequest Export(Google.Apis.SQLAdmin.v1beta4.Data.InstancesExportRequest body, string project, string instance)
        {
            return new ExportRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Cloud Storage bucket as a SQL dump or CSV file.
        /// </summary>
        public class ExportRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Export request.</summary>
            public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesExportRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance to be exported.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The Cloud SQL instance ID. This doesn't include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesExportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "export";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/export";

            /// <summary>Initializes Export parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Initiates a manual failover of a high availability (HA) primary instance to a standby instance, which
        /// becomes the primary instance. Users are then rerouted to the new primary. For more information, see the
        /// [Overview of high availability](https://cloud.google.com/sql/docs/mysql/high-availability) page in the Cloud
        /// SQL documentation. If using Legacy HA (MySQL only), this causes the instance to failover to its failover
        /// replica instance.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual FailoverRequest Failover(Google.Apis.SQLAdmin.v1beta4.Data.InstancesFailoverRequest body, string project, string instance)
        {
            return new FailoverRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Initiates a manual failover of a high availability (HA) primary instance to a standby instance, which
        /// becomes the primary instance. Users are then rerouted to the new primary. For more information, see the
        /// [Overview of high availability](https://cloud.google.com/sql/docs/mysql/high-availability) page in the Cloud
        /// SQL documentation. If using Legacy HA (MySQL only), this causes the instance to failover to its failover
        /// replica instance.
        /// </summary>
        public class FailoverRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Failover request.</summary>
            public FailoverRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesFailoverRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>ID of the project that contains the read replica.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesFailoverRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "failover";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/failover";

            /// <summary>Initializes Failover parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a resource containing information about a Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        public virtual GetRequest Get(string project, string instance)
        {
            return new GetRequest(this.service, project, instance);
        }

        /// <summary>Retrieves a resource containing information about a Cloud SQL instance.</summary>
        public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Imports data into a Cloud SQL instance from a SQL dump or CSV file in Cloud Storage.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual ImportRequest Import(Google.Apis.SQLAdmin.v1beta4.Data.InstancesImportRequest body, string project, string instance)
        {
            return new ImportRequest(this.service, body, project, instance);
        }

        /// <summary>Imports data into a Cloud SQL instance from a SQL dump or CSV file in Cloud Storage.</summary>
        public class ImportRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Import request.</summary>
            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesImportRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesImportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "import";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/import";

            /// <summary>Initializes Import parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new Cloud SQL instance.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">
        /// Project ID of the project to which the newly created Cloud SQL instances should belong.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance body, string project)
        {
            return new InsertRequest(this.service, body, project);
        }

        /// <summary>Creates a new Cloud SQL instance.</summary>
        public class InsertRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Project ID of the project to which the newly created Cloud SQL instances should belong.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists instances under a given project.</summary>
        /// <param name="project">Project ID of the project for which to list Cloud SQL instances.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
        }

        /// <summary>Lists instances under a given project.</summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.InstancesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Project ID of the project for which to list Cloud SQL instances.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// A filter expression that filters resources listed in the response. The expression is in the form of
            /// field:value. For example, 'instanceType:CLOUD_SQL_INSTANCE'. Fields can be nested as needed as per their
            /// JSON representation, such as 'settings.userLabels.auto_start:true'. Multiple filter queries are
            /// space-separated. For example. 'state:RUNNABLE instanceType:CLOUD_SQL_INSTANCE'. By default, each
            /// expression is an AND expression. However, you can include AND and OR expressions explicitly.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of instances to return. The service may return fewer than this value. If unspecified,
            /// at most 500 instances are returned. The maximum value is 1000; values above 1000 are coerced to 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
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
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
        /// Lists all of the trusted Certificate Authorities (CAs) for the specified instance. There can be up to three
        /// CAs listed: the CA that was used to sign the certificate that is currently in use, a CA that has been added
        /// but not yet used to sign a certificate, and a CA used to sign a certificate that has previously rotated out.
        /// </summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual ListServerCasRequest ListServerCas(string project, string instance)
        {
            return new ListServerCasRequest(this.service, project, instance);
        }

        /// <summary>
        /// Lists all of the trusted Certificate Authorities (CAs) for the specified instance. There can be up to three
        /// CAs listed: the CA that was used to sign the certificate that is currently in use, a CA that has been added
        /// but not yet used to sign a certificate, and a CA used to sign a certificate that has previously rotated out.
        /// </summary>
        public class ListServerCasRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.InstancesListServerCasResponse>
        {
            /// <summary>Constructs a new ListServerCas request.</summary>
            public ListServerCasRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listServerCas";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/listServerCas";

            /// <summary>Initializes ListServerCas parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Partially updates settings of a Cloud SQL instance by merging the request with the current configuration.
        /// This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual PatchRequest Patch(Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance body, string project, string instance)
        {
            return new PatchRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Partially updates settings of a Cloud SQL instance by merging the request with the current configuration.
        /// This method supports patch semantics.
        /// </summary>
        public class PatchRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Point in time restore for an instance managed by Google Cloud Backup and Disaster Recovery.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The parent resource where you created this instance. Format: projects/{project}
        /// </param>
        public virtual PointInTimeRestoreRequest PointInTimeRestore(Google.Apis.SQLAdmin.v1beta4.Data.PointInTimeRestoreContext body, string parent)
        {
            return new PointInTimeRestoreRequest(this.service, body, parent);
        }

        /// <summary>
        /// Point in time restore for an instance managed by Google Cloud Backup and Disaster Recovery.
        /// </summary>
        public class PointInTimeRestoreRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new PointInTimeRestore request.</summary>
            public PointInTimeRestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.PointInTimeRestoreContext body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent resource where you created this instance. Format: projects/{project}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.PointInTimeRestoreContext Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "pointInTimeRestore";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/{+parent}:pointInTimeRestore";

            /// <summary>Initializes PointInTimeRestore parameter list.</summary>
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

        /// <summary>
        /// Promotes the read replica instance to be an independent Cloud SQL primary instance. Using this operation
        /// might cause your instance to restart.
        /// </summary>
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL read replica instance name.</param>
        public virtual PromoteReplicaRequest PromoteReplica(string project, string instance)
        {
            return new PromoteReplicaRequest(this.service, project, instance);
        }

        /// <summary>
        /// Promotes the read replica instance to be an independent Cloud SQL primary instance. Using this operation
        /// might cause your instance to restart.
        /// </summary>
        public class PromoteReplicaRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new PromoteReplica request.</summary>
            public PromoteReplicaRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>ID of the project that contains the read replica.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL read replica instance name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>
            /// Set to true to invoke a replica failover to the DR replica. As part of replica failover, the promote
            /// operation attempts to add the original primary instance as a replica of the promoted DR replica when the
            /// original primary instance comes back online. If set to false or not specified, then the original primary
            /// instance becomes an independent Cloud SQL primary instance.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("failover", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Failover { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "promoteReplica";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/promoteReplica";

            /// <summary>Initializes PromoteReplica parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("failover", new Google.Apis.Discovery.Parameter
                {
                    Name = "failover",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Reencrypt CMEK instance with latest key version.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual ReencryptRequest Reencrypt(Google.Apis.SQLAdmin.v1beta4.Data.InstancesReencryptRequest body, string project, string instance)
        {
            return new ReencryptRequest(this.service, body, project, instance);
        }

        /// <summary>Reencrypt CMEK instance with latest key version.</summary>
        public class ReencryptRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Reencrypt request.</summary>
            public ReencryptRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesReencryptRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesReencryptRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reencrypt";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/reencrypt";

            /// <summary>Initializes Reencrypt parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Release a lease for the setup of SQL Server Reporting Services (SSRS).</summary>
        /// <param name="project">
        /// Required. The ID of the project that contains the instance (Example: project-id).
        /// </param>
        /// <param name="instance">
        /// Required. The Cloud SQL instance ID. This doesn't include the project ID. It's composed of lowercase
        /// letters, numbers, and hyphens, and it must start with a letter. The total length must be 98 characters or
        /// less (Example: instance-id).
        /// </param>
        public virtual ReleaseSsrsLeaseRequest ReleaseSsrsLease(string project, string instance)
        {
            return new ReleaseSsrsLeaseRequest(this.service, project, instance);
        }

        /// <summary>Release a lease for the setup of SQL Server Reporting Services (SSRS).</summary>
        public class ReleaseSsrsLeaseRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesReleaseSsrsLeaseResponse>
        {
            /// <summary>Constructs a new ReleaseSsrsLease request.</summary>
            public ReleaseSsrsLeaseRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Required. The ID of the project that contains the instance (Example: project-id).</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Required. The Cloud SQL instance ID. This doesn't include the project ID. It's composed of lowercase
            /// letters, numbers, and hyphens, and it must start with a letter. The total length must be 98 characters
            /// or less (Example: instance-id).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "releaseSsrsLease";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/releaseSsrsLease";

            /// <summary>Initializes ReleaseSsrsLease parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate for the instance.
        /// </summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual ResetSslConfigRequest ResetSslConfig(string project, string instance)
        {
            return new ResetSslConfigRequest(this.service, project, instance);
        }

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate for the instance.
        /// </summary>
        public class ResetSslConfigRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new ResetSslConfig request.</summary>
            public ResetSslConfigRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resetSslConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/resetSslConfig";

            /// <summary>Initializes ResetSslConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Restarts a Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance to be restarted.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual RestartRequest Restart(string project, string instance)
        {
            return new RestartRequest(this.service, project, instance);
        }

        /// <summary>Restarts a Cloud SQL instance.</summary>
        public class RestartRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Restart request.</summary>
            public RestartRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance to be restarted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "restart";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/restart";

            /// <summary>Initializes Restart parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. Using this operation might cause your instance to restart.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual RestoreBackupRequest RestoreBackup(Google.Apis.SQLAdmin.v1beta4.Data.InstancesRestoreBackupRequest body, string project, string instance)
        {
            return new RestoreBackupRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. Using this operation might cause your instance to restart.
        /// </summary>
        public class RestoreBackupRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new RestoreBackup request.</summary>
            public RestoreBackupRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesRestoreBackupRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesRestoreBackupRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "restoreBackup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/restoreBackup";

            /// <summary>Initializes RestoreBackup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Rotates the server certificate to one signed by the Certificate Authority (CA) version previously added with
        /// the addServerCA method. For instances that have enabled Certificate Authority Service (CAS) based server CA,
        /// use RotateServerCertificate to rotate the server certificate.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual RotateServerCaRequest RotateServerCa(Google.Apis.SQLAdmin.v1beta4.Data.InstancesRotateServerCaRequest body, string project, string instance)
        {
            return new RotateServerCaRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Rotates the server certificate to one signed by the Certificate Authority (CA) version previously added with
        /// the addServerCA method. For instances that have enabled Certificate Authority Service (CAS) based server CA,
        /// use RotateServerCertificate to rotate the server certificate.
        /// </summary>
        public class RotateServerCaRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new RotateServerCa request.</summary>
            public RotateServerCaRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesRotateServerCaRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesRotateServerCaRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "rotateServerCa";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/rotateServerCa";

            /// <summary>Initializes RotateServerCa parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Starts the replication in the read replica instance.</summary>
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL read replica instance name.</param>
        public virtual StartReplicaRequest StartReplica(string project, string instance)
        {
            return new StartReplicaRequest(this.service, project, instance);
        }

        /// <summary>Starts the replication in the read replica instance.</summary>
        public class StartReplicaRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new StartReplica request.</summary>
            public StartReplicaRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>ID of the project that contains the read replica.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL read replica instance name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "startReplica";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/startReplica";

            /// <summary>Initializes StartReplica parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Stops the replication in the read replica instance.</summary>
        /// <param name="project">ID of the project that contains the read replica.</param>
        /// <param name="instance">Cloud SQL read replica instance name.</param>
        public virtual StopReplicaRequest StopReplica(string project, string instance)
        {
            return new StopReplicaRequest(this.service, project, instance);
        }

        /// <summary>Stops the replication in the read replica instance.</summary>
        public class StopReplicaRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new StopReplica request.</summary>
            public StopReplicaRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>ID of the project that contains the read replica.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL read replica instance name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stopReplica";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/stopReplica";

            /// <summary>Initializes StopReplica parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Switches over from the primary instance to the DR replica instance.</summary>
        /// <param name="project">ID of the project that contains the replica.</param>
        /// <param name="instance">Cloud SQL read replica instance name.</param>
        public virtual SwitchoverRequest Switchover(string project, string instance)
        {
            return new SwitchoverRequest(this.service, project, instance);
        }

        /// <summary>Switches over from the primary instance to the DR replica instance.</summary>
        public class SwitchoverRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Switchover request.</summary>
            public SwitchoverRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>ID of the project that contains the replica.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL read replica instance name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>
            /// Optional. (MySQL and PostgreSQL only) Cloud SQL instance operations timeout, which is a sum of all
            /// database operations. Default value is 10 minutes and can be modified to a maximum value of 24 hours.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dbTimeout", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object DbTimeout { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "switchover";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/switchover";

            /// <summary>Initializes Switchover parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dbTimeout", new Google.Apis.Discovery.Parameter
                {
                    Name = "dbTimeout",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Truncate MySQL general and slow query log tables MySQL only.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the Cloud SQL project.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual TruncateLogRequest TruncateLog(Google.Apis.SQLAdmin.v1beta4.Data.InstancesTruncateLogRequest body, string project, string instance)
        {
            return new TruncateLogRequest(this.service, body, project, instance);
        }

        /// <summary>Truncate MySQL general and slow query log tables MySQL only.</summary>
        public class TruncateLogRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new TruncateLog request.</summary>
            public TruncateLogRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.InstancesTruncateLogRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the Cloud SQL project.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.InstancesTruncateLogRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "truncateLog";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/truncateLog";

            /// <summary>Initializes TruncateLog parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Using this operation might cause your instance to restart.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual UpdateRequest Update(Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance body, string project, string instance)
        {
            return new UpdateRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Using this operation might cause your instance to restart.
        /// </summary>
        public class UpdateRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.DatabaseInstance Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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

        /// <summary>Cancels an instance operation that has been performed on an instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="operation">Instance operation ID.</param>
        public virtual CancelRequest Cancel(string project, string operation)
        {
            return new CancelRequest(this.service, project, operation);
        }

        /// <summary>Cancels an instance operation that has been performed on an instance.</summary>
        public class CancelRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, string project, string operation) : base(service)
            {
                Project = project;
                Operation = operation;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Instance operation ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operation", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Operation { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/operations/{operation}/cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("operation", new Google.Apis.Discovery.Parameter
                {
                    Name = "operation",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves an instance operation that has been performed on an instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="operation">Instance operation ID.</param>
        public virtual GetRequest Get(string project, string operation)
        {
            return new GetRequest(this.service, project, operation);
        }

        /// <summary>Retrieves an instance operation that has been performed on an instance.</summary>
        public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string operation) : base(service)
            {
                Project = project;
                Operation = operation;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Instance operation ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operation", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Operation { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/operations/{operation}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("operation", new Google.Apis.Discovery.Parameter
                {
                    Name = "operation",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all instance operations that have been performed on the given Cloud SQL instance in the reverse
        /// chronological order of the start time.
        /// </summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
        }

        /// <summary>
        /// Lists all instance operations that have been performed on the given Cloud SQL instance in the reverse
        /// chronological order of the start time.
        /// </summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.OperationsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Instance { get; set; }

            /// <summary>Maximum number of operations per response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/operations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
            Instances = new InstancesResource(service);
        }

        /// <summary>Gets the Instances resource.</summary>
        public virtual InstancesResource Instances { get; }

        /// <summary>The "instances" collection of methods.</summary>
        public class InstancesResource
        {
            private const string Resource = "instances";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InstancesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get Disk Shrink Config for a given instance.</summary>
            /// <param name="project">Project ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual GetDiskShrinkConfigRequest GetDiskShrinkConfig(string project, string instance)
            {
                return new GetDiskShrinkConfigRequest(this.service, project, instance);
            }

            /// <summary>Get Disk Shrink Config for a given instance.</summary>
            public class GetDiskShrinkConfigRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesGetDiskShrinkConfigResponse>
            {
                /// <summary>Constructs a new GetDiskShrinkConfig request.</summary>
                public GetDiskShrinkConfigRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    InitParameters();
                }

                /// <summary>Project ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getDiskShrinkConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/getDiskShrinkConfig";

                /// <summary>Initializes GetDiskShrinkConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get Latest Recovery Time for a given instance.</summary>
            /// <param name="project">Project ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual GetLatestRecoveryTimeRequest GetLatestRecoveryTime(string project, string instance)
            {
                return new GetLatestRecoveryTimeRequest(this.service, project, instance);
            }

            /// <summary>Get Latest Recovery Time for a given instance.</summary>
            public class GetLatestRecoveryTimeRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesGetLatestRecoveryTimeResponse>
            {
                /// <summary>Constructs a new GetLatestRecoveryTime request.</summary>
                public GetLatestRecoveryTimeRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    InitParameters();
                }

                /// <summary>Project ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getLatestRecoveryTime";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/getLatestRecoveryTime";

                /// <summary>Initializes GetLatestRecoveryTime parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Perform Disk Shrink on primary instance.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">Project ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual PerformDiskShrinkRequest PerformDiskShrink(Google.Apis.SQLAdmin.v1beta4.Data.PerformDiskShrinkContext body, string project, string instance)
            {
                return new PerformDiskShrinkRequest(this.service, body, project, instance);
            }

            /// <summary>Perform Disk Shrink on primary instance.</summary>
            public class PerformDiskShrinkRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
            {
                /// <summary>Constructs a new PerformDiskShrink request.</summary>
                public PerformDiskShrinkRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.PerformDiskShrinkContext body, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Project ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SQLAdmin.v1beta4.Data.PerformDiskShrinkContext Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "performDiskShrink";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/performDiskShrink";

                /// <summary>Initializes PerformDiskShrink parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Reschedules the maintenance on the given instance.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual RescheduleMaintenanceRequest RescheduleMaintenance(Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesRescheduleMaintenanceRequestBody body, string project, string instance)
            {
                return new RescheduleMaintenanceRequest(this.service, body, project, instance);
            }

            /// <summary>Reschedules the maintenance on the given instance.</summary>
            public class RescheduleMaintenanceRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
            {
                /// <summary>Constructs a new RescheduleMaintenance request.</summary>
                public RescheduleMaintenanceRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesRescheduleMaintenanceRequestBody body, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    Body = body;
                    InitParameters();
                }

                /// <summary>ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesRescheduleMaintenanceRequestBody Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "rescheduleMaintenance";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/rescheduleMaintenance";

                /// <summary>Initializes RescheduleMaintenance parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Reset Replica Size to primary instance disk size.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">ID of the project that contains the read replica.</param>
            /// <param name="instance">Cloud SQL read replica instance name.</param>
            public virtual ResetReplicaSizeRequest ResetReplicaSize(Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesResetReplicaSizeRequest body, string project, string instance)
            {
                return new ResetReplicaSizeRequest(this.service, body, project, instance);
            }

            /// <summary>Reset Replica Size to primary instance disk size.</summary>
            public class ResetReplicaSizeRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
            {
                /// <summary>Constructs a new ResetReplicaSize request.</summary>
                public ResetReplicaSizeRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesResetReplicaSizeRequest body, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    Body = body;
                    InitParameters();
                }

                /// <summary>ID of the project that contains the read replica.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL read replica instance name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesResetReplicaSizeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "resetReplicaSize";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/resetReplicaSize";

                /// <summary>Initializes ResetReplicaSize parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Start External primary instance migration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual StartExternalSyncRequest StartExternalSync(Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesStartExternalSyncRequest body, string project, string instance)
            {
                return new StartExternalSyncRequest(this.service, body, project, instance);
            }

            /// <summary>Start External primary instance migration.</summary>
            public class StartExternalSyncRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
            {
                /// <summary>Constructs a new StartExternalSync request.</summary>
                public StartExternalSyncRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesStartExternalSyncRequest body, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    Body = body;
                    InitParameters();
                }

                /// <summary>ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesStartExternalSyncRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "startExternalSync";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/startExternalSync";

                /// <summary>Initializes StartExternalSync parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Verify External primary instance external sync settings.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">Project ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual VerifyExternalSyncSettingsRequest VerifyExternalSyncSettings(Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesVerifyExternalSyncSettingsRequest body, string project, string instance)
            {
                return new VerifyExternalSyncSettingsRequest(this.service, body, project, instance);
            }

            /// <summary>Verify External primary instance external sync settings.</summary>
            public class VerifyExternalSyncSettingsRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesVerifyExternalSyncSettingsResponse>
            {
                /// <summary>Constructs a new VerifyExternalSyncSettings request.</summary>
                public VerifyExternalSyncSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesVerifyExternalSyncSettingsRequest body, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Project ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SQLAdmin.v1beta4.Data.SqlInstancesVerifyExternalSyncSettingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "verifyExternalSyncSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/verifyExternalSyncSettings";

                /// <summary>Initializes VerifyExternalSyncSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "sslCerts" collection of methods.</summary>
    public class SslCertsResource
    {
        private const string Resource = "sslCerts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SslCertsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key and signed by a private key
        /// specific to the target instance. Users may use the certificate to authenticate as themselves when connecting
        /// to the database.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the Cloud SQL project.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual CreateEphemeralRequest CreateEphemeral(Google.Apis.SQLAdmin.v1beta4.Data.SslCertsCreateEphemeralRequest body, string project, string instance)
        {
            return new CreateEphemeralRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key and signed by a private key
        /// specific to the target instance. Users may use the certificate to authenticate as themselves when connecting
        /// to the database.
        /// </summary>
        public class CreateEphemeralRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SslCert>
        {
            /// <summary>Constructs a new CreateEphemeral request.</summary>
            public CreateEphemeralRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.SslCertsCreateEphemeralRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the Cloud SQL project.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.SslCertsCreateEphemeralRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createEphemeral";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/createEphemeral";

            /// <summary>Initializes CreateEphemeral parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes the SSL certificate. For First Generation instances, the certificate remains valid until the
        /// instance is restarted.
        /// </summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="sha1Fingerprint">Sha1 FingerPrint.</param>
        public virtual DeleteRequest Delete(string project, string instance, string sha1Fingerprint)
        {
            return new DeleteRequest(this.service, project, instance, sha1Fingerprint);
        }

        /// <summary>
        /// Deletes the SSL certificate. For First Generation instances, the certificate remains valid until the
        /// instance is restarted.
        /// </summary>
        public class DeleteRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string instance, string sha1Fingerprint) : base(service)
            {
                Project = project;
                Instance = instance;
                Sha1Fingerprint = sha1Fingerprint;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Sha1 FingerPrint.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sha1Fingerprint", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sha1Fingerprint { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/sslCerts/{sha1Fingerprint}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sha1Fingerprint", new Google.Apis.Discovery.Parameter
                {
                    Name = "sha1Fingerprint",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves a particular SSL certificate. Does not include the private key (required for usage). The private
        /// key must be saved from the response to initial creation.
        /// </summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="sha1Fingerprint">Sha1 FingerPrint.</param>
        public virtual GetRequest Get(string project, string instance, string sha1Fingerprint)
        {
            return new GetRequest(this.service, project, instance, sha1Fingerprint);
        }

        /// <summary>
        /// Retrieves a particular SSL certificate. Does not include the private key (required for usage). The private
        /// key must be saved from the response to initial creation.
        /// </summary>
        public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SslCert>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string instance, string sha1Fingerprint) : base(service)
            {
                Project = project;
                Instance = instance;
                Sha1Fingerprint = sha1Fingerprint;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Sha1 FingerPrint.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sha1Fingerprint", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sha1Fingerprint { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/sslCerts/{sha1Fingerprint}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sha1Fingerprint", new Google.Apis.Discovery.Parameter
                {
                    Name = "sha1Fingerprint",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and server certificate authority. The
        /// new certificate will not be usable until the instance is restarted.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual InsertRequest Insert(Google.Apis.SQLAdmin.v1beta4.Data.SslCertsInsertRequest body, string project, string instance)
        {
            return new InsertRequest(this.service, body, project, instance);
        }

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and server certificate authority. The
        /// new certificate will not be usable until the instance is restarted.
        /// </summary>
        public class InsertRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SslCertsInsertResponse>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.SslCertsInsertRequest body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.SslCertsInsertRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/sslCerts";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all of the current SSL certificates for the instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        public virtual ListRequest List(string project, string instance)
        {
            return new ListRequest(this.service, project, instance);
        }

        /// <summary>Lists all of the current SSL certificates for the instance.</summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.SslCertsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/sslCerts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "tiers" collection of methods.</summary>
    public class TiersResource
    {
        private const string Resource = "tiers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TiersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Lists all available machine types (tiers) for Cloud SQL, for example, `db-custom-1-3840`. For related
        /// information, see [Pricing](/sql/pricing).
        /// </summary>
        /// <param name="project">Project ID of the project for which to list tiers.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
        }

        /// <summary>
        /// Lists all available machine types (tiers) for Cloud SQL, for example, `db-custom-1-3840`. For related
        /// information, see [Pricing](/sql/pricing).
        /// </summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.TiersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Project ID of the project for which to list tiers.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/tiers";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a user from a Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        public virtual DeleteRequest Delete(string project, string instance)
        {
            return new DeleteRequest(this.service, project, instance);
        }

        /// <summary>Deletes a user from a Cloud SQL instance.</summary>
        public class DeleteRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Host of the user in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("host", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Host { get; set; }

            /// <summary>Name of the user in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/users";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("host", new Google.Apis.Discovery.Parameter
                {
                    Name = "host",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a resource containing information about a user.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        /// <param name="name">User of the instance.</param>
        public virtual GetRequest Get(string project, string instance, string name)
        {
            return new GetRequest(this.service, project, instance, name);
        }

        /// <summary>Retrieves a resource containing information about a user.</summary>
        public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.User>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string instance, string name) : base(service)
            {
                Project = project;
                Instance = instance;
                Name = name;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>User of the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Host of a user of the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("host", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Host { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/users/{name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("host", new Google.Apis.Discovery.Parameter
                {
                    Name = "host",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new user in a Cloud SQL instance.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        public virtual InsertRequest Insert(Google.Apis.SQLAdmin.v1beta4.Data.User body, string project, string instance)
        {
            return new InsertRequest(this.service, body, project, instance);
        }

        /// <summary>Creates a new user in a Cloud SQL instance.</summary>
        public class InsertRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.User body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/users";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists users in the specified Cloud SQL instance.</summary>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        public virtual ListRequest List(string project, string instance)
        {
            return new ListRequest(this.service, project, instance);
        }

        /// <summary>Lists users in the specified Cloud SQL instance.</summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.UsersListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/users";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an existing user in a Cloud SQL instance.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Database instance ID. This does not include the project ID.</param>
        public virtual UpdateRequest Update(Google.Apis.SQLAdmin.v1beta4.Data.User body, string project, string instance)
        {
            return new UpdateRequest(this.service, body, project, instance);
        }

        /// <summary>Updates an existing user in a Cloud SQL instance.</summary>
        public class UpdateRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1beta4.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1beta4.Data.User body, string project, string instance) : base(service)
            {
                Project = project;
                Instance = instance;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID of the project that contains the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Database instance ID. This does not include the project ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Instance { get; private set; }

            /// <summary>Optional. Host of the user in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("host", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Host { get; set; }

            /// <summary>Name of the user in the instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SQLAdmin.v1beta4.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "sql/v1beta4/projects/{project}/instances/{instance}/users";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                {
                    Name = "instance",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("host", new Google.Apis.Discovery.Parameter
                {
                    Name = "host",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.SQLAdmin.v1beta4.Data
{
    /// <summary>An entry for an Access Control list.</summary>
    public class AclEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// The time when this access control entry expires in [RFC 3339](https://tools.ietf.org/html/rfc3339) format,
        /// for example `2012-11-15T16:19:00.094Z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>This is always `sql#aclEntry`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional. A label to identify this entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The allowlisted value for the access control list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Acquire SSRS lease context.</summary>
    public class AcquireSsrsLeaseContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Lease duration needed for the SSRS setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The report database to be used for the SSRS setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDatabase")]
        public virtual string ReportDatabase { get; set; }

        /// <summary>
        /// The username to be used as the service login to connect to the report database for SSRS setup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLogin")]
        public virtual string ServiceLogin { get; set; }

        /// <summary>
        /// The username to be used as the setup login to connect to the database server for SSRS setup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setupLogin")]
        public virtual string SetupLogin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies options for controlling advanced machine features.</summary>
    public class AdvancedMachineFeatures : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of threads per physical core.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadsPerCore")]
        public virtual System.Nullable<int> ThreadsPerCore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Admin API warning message.</summary>
    public class ApiWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Code to uniquely identify the warning type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The warning message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The region name for REGION_UNREACHABLE warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An available database version. It can be a major or a minor version.</summary>
    public class AvailableDatabaseVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The database version's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The version's major version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("majorVersion")]
        public virtual string MajorVersion { get; set; }

        /// <summary>
        /// The database version name. For MySQL 8.0, this string provides the database major and minor version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A backup resource. Next ID: 30</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This output contains the following values: start_time: All database writes up to this time are
        /// available. end_time: Any database writes after this time aren't available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupInterval")]
        public virtual Interval BackupInterval { get; set; }

        /// <summary>Output only. Specifies the kind of backup, PHYSICAL or DEFAULT_SNAPSHOT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupKind")]
        public virtual string BackupKind { get; set; }

        /// <summary>Output only. The mapping to backup run resource used for IAM validations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRun")]
        public virtual string BackupRun { get; set; }

        /// <summary>Output only. The database version of the instance of at the time this backup was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>The description of this backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Information about why the backup operation fails (for example, when the backup state fails).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual OperationError Error { get; set; }

        private string _expiryTimeRaw;

        private object _expiryTime;

        /// <summary>Backup expiration time. A UTC timestamp of when this resource expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTime")]
        public virtual string ExpiryTimeRaw
        {
            get => _expiryTimeRaw;
            set
            {
                _expiryTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expiryTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpiryTimeDateTimeOffset instead.")]
        public virtual object ExpiryTime
        {
            get => _expiryTime;
            set
            {
                _expiryTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expiryTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpiryTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpiryTimeRaw);
            set => ExpiryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The name of the database instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        private string _instanceDeletionTimeRaw;

        private object _instanceDeletionTime;

        /// <summary>
        /// Optional. Output only. Timestamp in UTC of when the instance associated with this backup is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceDeletionTime")]
        public virtual string InstanceDeletionTimeRaw
        {
            get => _instanceDeletionTimeRaw;
            set
            {
                _instanceDeletionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _instanceDeletionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InstanceDeletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InstanceDeletionTimeDateTimeOffset instead.")]
        public virtual object InstanceDeletionTime
        {
            get => _instanceDeletionTime;
            set
            {
                _instanceDeletionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _instanceDeletionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="InstanceDeletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InstanceDeletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InstanceDeletionTimeRaw);
            set => InstanceDeletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Output only. Instance setting of the source instance that's associated with this backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSettings")]
        public virtual DatabaseInstance InstanceSettings { get; set; }

        /// <summary>Output only. This is always `sql#backup`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. This output contains the encryption configuration for a backup and the resource name of the KMS
        /// key for disk encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>
        /// Output only. This output contains the encryption status for a backup and the version of the KMS key that's
        /// used to encrypt the Cloud SQL instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersion")]
        public virtual string KmsKeyVersion { get; set; }

        /// <summary>The storage location of the backups. The location can be multi-regional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Output only. The maximum chargeable bytes for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChargeableBytes")]
        public virtual System.Nullable<long> MaxChargeableBytes { get; set; }

        /// <summary>
        /// Output only. The resource name of the backup. Format: projects/{project}/backups/{backup}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. This status indicates whether the backup satisfies PZI. The status is reserved for future use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>
        /// Output only. This status indicates whether the backup satisfies PZS. The status is reserved for future use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The URI of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Output only. The state of this backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. This output contains a backup time zone. If a Cloud SQL for SQL Server instance has a different
        /// time zone from the backup's time zone, then the restore to the instance doesn't happen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// Input only. The time-to-live (TTL) interval for this resource (in days). For example: ttlDays:7, means 7
        /// days from the current time. The expiration time can't exceed 365 days from the time that the backup is
        /// created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttlDays")]
        public virtual System.Nullable<long> TtlDays { get; set; }

        /// <summary>
        /// Output only. The type of this backup. The type can be "AUTOMATED", "ON_DEMAND", or “FINAL”.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance backup configuration.</summary>
    public class BackupConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Backup retention settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionSettings")]
        public virtual BackupRetentionSettings BackupRetentionSettings { get; set; }

        /// <summary>Output only. Backup tier that manages the backups for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupTier")]
        public virtual string BackupTier { get; set; }

        /// <summary>
        /// (MySQL only) Whether binary log is enabled. If backup configuration is disabled, binarylog must be disabled
        /// as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryLogEnabled")]
        public virtual System.Nullable<bool> BinaryLogEnabled { get; set; }

        /// <summary>Whether this configuration is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>This is always `sql#backupConfiguration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Location of the backup</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Whether point in time recovery is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointInTimeRecoveryEnabled")]
        public virtual System.Nullable<bool> PointInTimeRecoveryEnabled { get; set; }

        /// <summary>Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationLogArchivingEnabled")]
        public virtual System.Nullable<bool> ReplicationLogArchivingEnabled { get; set; }

        /// <summary>
        /// Start time for the daily backup configuration in UTC timezone in the 24 hour format - `HH:MM`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>The number of days of transaction logs we retain for point in time restore, from 1-7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionLogRetentionDays")]
        public virtual System.Nullable<int> TransactionLogRetentionDays { get; set; }

        /// <summary>
        /// Output only. This value contains the storage location of transactional logs for the database for
        /// point-in-time recovery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionalLogStorageState")]
        public virtual string TransactionalLogStorageState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup context.</summary>
    public class BackupContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual System.Nullable<long> BackupId { get; set; }

        /// <summary>This is always `sql#backupContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the backup. Format: projects/{project}/backups/{backup}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup Reencryption Config</summary>
    public class BackupReencryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Backup re-encryption limit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupLimit")]
        public virtual System.Nullable<int> BackupLimit { get; set; }

        /// <summary>Type of backups users want to re-encrypt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// We currently only support backup retention by specifying the number of backups we will retain.
    /// </summary>
    public class BackupRetentionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Depending on the value of retention_unit, this is used to determine if a backup needs to be deleted. If
        /// retention_unit is 'COUNT', we will retain this many backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainedBackups")]
        public virtual System.Nullable<int> RetainedBackups { get; set; }

        /// <summary>The unit that 'retained_backups' represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionUnit")]
        public virtual string RetentionUnit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A BackupRun resource.</summary>
    public class BackupRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the kind of backup, PHYSICAL or DEFAULT_SNAPSHOT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupKind")]
        public virtual string BackupKind { get; set; }

        /// <summary>Output only. The instance database version at the time this backup was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>The description of this run, only applicable to on-demand backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Encryption configuration specific to a backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryptionConfiguration")]
        public virtual DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }

        /// <summary>Encryption status specific to a backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryptionStatus")]
        public virtual DiskEncryptionStatus DiskEncryptionStatus { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// The time the backup operation completed in UTC timezone in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// format, for example `2012-11-15T16:19:00.094Z`.
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

        private string _enqueuedTimeRaw;

        private object _enqueuedTime;

        /// <summary>
        /// The time the run was enqueued in UTC timezone in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enqueuedTime")]
        public virtual string EnqueuedTimeRaw
        {
            get => _enqueuedTimeRaw;
            set
            {
                _enqueuedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _enqueuedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EnqueuedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EnqueuedTimeDateTimeOffset instead.")]
        public virtual object EnqueuedTime
        {
            get => _enqueuedTime;
            set
            {
                _enqueuedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _enqueuedTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EnqueuedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EnqueuedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EnqueuedTimeRaw);
            set => EnqueuedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Information about why the backup operation failed. This is only present if the run has the FAILED status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual OperationError Error { get; set; }

        /// <summary>The identifier for this backup run. Unique only for a specific Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Name of the database instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>This is always `sql#backupRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Location of the backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Output only. The maximum chargeable bytes for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxChargeableBytes")]
        public virtual System.Nullable<long> MaxChargeableBytes { get; set; }

        /// <summary>The URI of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// The time the backup operation actually started in UTC timezone in [RFC
        /// 3339](https://tools.ietf.org/html/rfc3339) format, for example `2012-11-15T16:19:00.094Z`.
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

        /// <summary>The status of this run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Backup time zone to prevent restores to an instance with a different time zone. Now relevant only for SQL
        /// Server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// The type of this run; can be either "AUTOMATED" or "ON_DEMAND" or "FINAL". This field defaults to
        /// "ON_DEMAND" and is ignored, when specified for insert requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _windowStartTimeRaw;

        private object _windowStartTime;

        /// <summary>
        /// The start time of the backup window during which this the backup was attempted in [RFC
        /// 3339](https://tools.ietf.org/html/rfc3339) format, for example `2012-11-15T16:19:00.094Z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowStartTime")]
        public virtual string WindowStartTimeRaw
        {
            get => _windowStartTimeRaw;
            set
            {
                _windowStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _windowStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="WindowStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use WindowStartTimeDateTimeOffset instead.")]
        public virtual object WindowStartTime
        {
            get => _windowStartTime;
            set
            {
                _windowStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _windowStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="WindowStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? WindowStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(WindowStartTimeRaw);
            set => WindowStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup run list results.</summary>
    public class BackupRunsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of backup runs in reverse chronological order of the enqueued time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<BackupRun> Items { get; set; }

        /// <summary>This is always `sql#backupRunsList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Binary log coordinates.</summary>
    public class BinLogCoordinates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the binary log file for a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binLogFileName")]
        public virtual string BinLogFileName { get; set; }

        /// <summary>Position (offset) within the binary log file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binLogPosition")]
        public virtual System.Nullable<long> BinLogPosition { get; set; }

        /// <summary>This is always `sql#binLogCoordinates`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance clone context.</summary>
    public class CloneContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the allocated ip range for the private ip Cloud SQL instance. For example:
        /// "google-managed-services-default". If set, the cloned instance ip will be created in the allocated range.
        /// The range name must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035). Specifically, the name must
        /// be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?. Reserved for future
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedIpRange")]
        public virtual string AllocatedIpRange { get; set; }

        /// <summary>
        /// Binary log coordinates, if specified, identify the position up to which the source instance is cloned. If
        /// not specified, the source instance is cloned up to the most recent binary log coordinates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binLogCoordinates")]
        public virtual BinLogCoordinates BinLogCoordinates { get; set; }

        /// <summary>
        /// (SQL Server only) Clone only the specified databases from the source instance. Clone all databases if empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseNames")]
        public virtual System.Collections.Generic.IList<string> DatabaseNames { get; set; }

        /// <summary>Name of the Cloud SQL instance to be created as a clone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationInstanceName")]
        public virtual string DestinationInstanceName { get; set; }

        /// <summary>This is always `sql#cloneContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitrTimestampMs")]
        public virtual System.Nullable<long> PitrTimestampMs { get; set; }

        private string _pointInTimeRaw;

        private object _pointInTime;

        /// <summary>Timestamp, if specified, identifies the time to which the source instance is cloned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointInTime")]
        public virtual string PointInTimeRaw
        {
            get => _pointInTimeRaw;
            set
            {
                _pointInTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _pointInTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PointInTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PointInTimeDateTimeOffset instead.")]
        public virtual object PointInTime
        {
            get => _pointInTime;
            set
            {
                _pointInTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _pointInTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PointInTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PointInTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PointInTimeRaw);
            set => PointInTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Copy clone and point-in-time recovery clone of a regional instance in the specified zones. If not
        /// specified, clone to the same secondary zone as the source instance. This value cannot be the same as the
        /// preferred_zone field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredSecondaryZone")]
        public virtual string PreferredSecondaryZone { get; set; }

        /// <summary>
        /// Optional. Copy clone and point-in-time recovery clone of an instance to the specified zone. If no zone is
        /// specified, clone to the same primary zone as the source instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredZone")]
        public virtual string PreferredZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a single read pool node of a read pool.</summary>
    public class ConnectPoolNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The DNS name of the read pool node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsName")]
        public virtual string DnsName { get; set; }

        /// <summary>Output only. The list of DNS names used by this read pool node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsNames")]
        public virtual System.Collections.Generic.IList<DnsNameMapping> DnsNames { get; set; }

        /// <summary>
        /// Output only. Mappings containing IP addresses that can be used to connect to the read pool node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<IpMapping> IpAddresses { get; set; }

        /// <summary>Output only. The name of the read pool node. Doesn't include the project ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Connect settings retrieval response.</summary>
    public class ConnectSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `SECOND_GEN`: Cloud SQL database instance. `EXTERNAL`: A database server that is not managed by Google. This
        /// property is read-only; use the `tier` property in the `settings` object to determine the database type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendType")]
        public virtual string BackendType { get; set; }

        /// <summary>Custom subject alternative names for the server certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSubjectAlternativeNames")]
        public virtual System.Collections.Generic.IList<string> CustomSubjectAlternativeNames { get; set; }

        /// <summary>
        /// The database engine type and version. The `databaseVersion` field cannot be changed after instance creation.
        /// MySQL instances: `MYSQL_8_0`, `MYSQL_5_7` (default), or `MYSQL_5_6`. PostgreSQL instances: `POSTGRES_9_6`,
        /// `POSTGRES_10`, `POSTGRES_11` or `POSTGRES_12` (default), `POSTGRES_13`, or `POSTGRES_14`. SQL Server
        /// instances: `SQLSERVER_2017_STANDARD` (default), `SQLSERVER_2017_ENTERPRISE`, `SQLSERVER_2017_EXPRESS`,
        /// `SQLSERVER_2017_WEB`, `SQLSERVER_2019_STANDARD`, `SQLSERVER_2019_ENTERPRISE`, `SQLSERVER_2019_EXPRESS`, or
        /// `SQLSERVER_2019_WEB`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>The dns name of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsName")]
        public virtual string DnsName { get; set; }

        /// <summary>Output only. The list of DNS names used by this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsNames")]
        public virtual System.Collections.Generic.IList<DnsNameMapping> DnsNames { get; set; }

        /// <summary>The assigned IP addresses for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<IpMapping> IpAddresses { get; set; }

        /// <summary>This is always `sql#connectSettings`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The number of read pool nodes in a read pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>Output only. Entries containing information about each read pool node of the read pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<ConnectPoolNodeConfig> Nodes { get; set; }

        /// <summary>Whether PSC connectivity is enabled for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscEnabled")]
        public virtual System.Nullable<bool> PscEnabled { get; set; }

        /// <summary>
        /// The cloud region for the instance. e.g. `us-central1`, `europe-west1`. The region cannot be changed after
        /// instance creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>SSL configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaCert")]
        public virtual SslCert ServerCaCert { get; set; }

        /// <summary>Specify what type of CA is used for the server certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaMode")]
        public virtual string ServerCaMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The managed connection pooling configuration.</summary>
    public class ConnectionPoolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether managed connection pooling is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionPoolingEnabled")]
        public virtual System.Nullable<bool> ConnectionPoolingEnabled { get; set; }

        /// <summary>Optional. List of connection pool configuration flags</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flags")]
        public virtual System.Collections.Generic.IList<ConnectionPoolFlags> Flags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Connection pool flags for Cloud SQL instances managed connection pool configuration.</summary>
    public class ConnectionPoolFlags : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The value of the flag. Boolean flags are set to `on` for true and `off` for false. This field must
        /// be omitted if the flag doesn't take a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data cache configurations.</summary>
    public class DataCacheConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether data cache is enabled for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCacheEnabled")]
        public virtual System.Nullable<bool> DataCacheEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a SQL database on the Cloud SQL instance.</summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud SQL charset value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("charset")]
        public virtual string Charset { get; set; }

        /// <summary>The Cloud SQL collation value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>This field is deprecated and will be removed from a future version of the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The name of the Cloud SQL instance. This does not include the project ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>This is always `sql#database`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name of the database in the Cloud SQL instance. This does not include the project ID or instance name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The project ID of the project containing the Cloud SQL database. The Google apps domain is prefixed if
        /// applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The URI of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sqlserverDatabaseDetails")]
        public virtual SqlServerDatabaseDetails SqlserverDatabaseDetails { get; set; }
    }

    /// <summary>Database flags for Cloud SQL instances.</summary>
    public class DatabaseFlags : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the flag. These flags are passed at instance startup, so include both server options and system
        /// variables. Flags are specified with underscores, not hyphens. For more information, see [Configuring
        /// Database Flags](https://cloud.google.com/sql/docs/mysql/flags) in the Cloud SQL documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The value of the flag. Boolean flags are set to `on` for true and `off` for false. This field must be
        /// omitted if the flag doesn't take a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud SQL instance resource.</summary>
    public class DatabaseInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List all maintenance versions applicable on the instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableMaintenanceVersions")]
        public virtual System.Collections.Generic.IList<string> AvailableMaintenanceVersions { get; set; }

        /// <summary>
        /// The backend type. `SECOND_GEN`: Cloud SQL database instance. `EXTERNAL`: A database server that is not
        /// managed by Google. This property is read-only; use the `tier` property in the `settings` object to determine
        /// the database type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendType")]
        public virtual string BackendType { get; set; }

        /// <summary>Connection name of the Cloud SQL instance used in connection strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionName")]
        public virtual string ConnectionName { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time when the instance was created in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// format, for example `2012-11-15T16:19:00.094Z`.
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
        /// The current disk usage of the instance in bytes. This property has been deprecated. Use the
        /// "cloudsql.googleapis.com/database/disk/bytes_used" metric in Cloud Monitoring API instead. Please see [this
        /// announcement](https://groups.google.com/d/msg/google-cloud-sql-announce/I_7-F9EBhT0/BtvFtdFeAgAJ) for
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentDiskSize")]
        public virtual System.Nullable<long> CurrentDiskSize { get; set; }

        /// <summary>
        /// Output only. Stores the current database version running on the instance including minor version such as
        /// `MYSQL_8_0_18`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseInstalledVersion")]
        public virtual string DatabaseInstalledVersion { get; set; }

        /// <summary>
        /// The database engine type and version. The `databaseVersion` field cannot be changed after instance creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>Disk encryption configuration specific to an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryptionConfiguration")]
        public virtual DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }

        /// <summary>Disk encryption status specific to an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryptionStatus")]
        public virtual DiskEncryptionStatus DiskEncryptionStatus { get; set; }

        /// <summary>Output only. The dns name of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsName")]
        public virtual string DnsName { get; set; }

        /// <summary>Output only. The list of DNS names used by this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsNames")]
        public virtual System.Collections.Generic.IList<DnsNameMapping> DnsNames { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed from a future version of the API. Use the
        /// `settings.settingsVersion` field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The name and status of the failover replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverReplica")]
        public virtual FailoverReplicaData FailoverReplica { get; set; }

        /// <summary>
        /// The Compute Engine zone that the instance is currently serving from. This value could be different from the
        /// zone that was specified when the instance was created if the instance has failed over to its secondary zone.
        /// WARNING: Changing this might restart the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceZone")]
        public virtual string GceZone { get; set; }

        /// <summary>Gemini instance configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geminiConfig")]
        public virtual GeminiInstanceConfig GeminiConfig { get; set; }

        /// <summary>
        /// Input only. Determines whether an in-place major version upgrade of replicas happens when an in-place major
        /// version upgrade of a primary instance is initiated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeReplicasForMajorVersionUpgrade")]
        public virtual System.Nullable<bool> IncludeReplicasForMajorVersionUpgrade { get; set; }

        /// <summary>The instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>The assigned IP addresses for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<IpMapping> IpAddresses { get; set; }

        /// <summary>
        /// The IPv6 address assigned to the instance. (Deprecated) This property was applicable only to First
        /// Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6Address")]
        public virtual string Ipv6Address { get; set; }

        /// <summary>This is always `sql#instance`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The current software version on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceVersion")]
        public virtual string MaintenanceVersion { get; set; }

        /// <summary>The name of the instance which will act as primary in the replication setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterInstanceName")]
        public virtual string MasterInstanceName { get; set; }

        /// <summary>The maximum disk size of the instance in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDiskSize")]
        public virtual System.Nullable<long> MaxDiskSize { get; set; }

        /// <summary>Name of the Cloud SQL instance. This does not include the project ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The number of read pool nodes in a read pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>Output only. Entries containing information about each read pool node of the read pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<PoolNodeConfig> Nodes { get; set; }

        /// <summary>Configuration specific to on-premises instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onPremisesConfiguration")]
        public virtual OnPremisesConfiguration OnPremisesConfiguration { get; set; }

        /// <summary>
        /// This field represents the report generated by the proactive database wellness job for OutOfDisk issues. *
        /// Writers: * the proactive database wellness job for OOD. * Readers: * the proactive database wellness job
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfDiskReport")]
        public virtual SqlOutOfDiskReport OutOfDiskReport { get; set; }

        /// <summary>Output only. DEPRECATED: please use write_endpoint instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryDnsName")]
        public virtual string PrimaryDnsName { get; set; }

        /// <summary>
        /// The project ID of the project containing the Cloud SQL instance. The Google apps domain is prefixed if
        /// applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>Output only. The link to service attachment of PSC instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscServiceAttachmentLink")]
        public virtual string PscServiceAttachmentLink { get; set; }

        /// <summary>
        /// The geographical region of the Cloud SQL instance. It can be one of the
        /// [regions](https://cloud.google.com/sql/docs/mysql/locations#location-r) where Cloud SQL operates: For
        /// example, `asia-east1`, `europe-west1`, and `us-central1`. The default value is `us-central1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Configuration specific to failover replicas and read replicas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaConfiguration")]
        public virtual ReplicaConfiguration ReplicaConfiguration { get; set; }

        /// <summary>The replicas of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaNames")]
        public virtual System.Collections.Generic.IList<string> ReplicaNames { get; set; }

        /// <summary>
        /// A primary instance and disaster recovery (DR) replica pair. A DR replica is a cross-region replica that you
        /// designate for failover in the event that the primary instance experiences regional failure. Applicable to
        /// MySQL and PostgreSQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationCluster")]
        public virtual ReplicationCluster ReplicationCluster { get; set; }

        /// <summary>
        /// Initial root password. Use only on creation. You must set root passwords before you can connect to
        /// PostgreSQL instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPassword")]
        public virtual string RootPassword { get; set; }

        /// <summary>
        /// Output only. This status indicates whether the instance satisfies PZI. The status is reserved for future
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>
        /// This status indicates whether the instance satisfies PZS. The status is reserved for future use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>The start time of any upcoming scheduled maintenance for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledMaintenance")]
        public virtual SqlScheduledMaintenance ScheduledMaintenance { get; set; }

        /// <summary>
        /// The Compute Engine zone that the failover instance is currently serving from for a regional instance. This
        /// value could be different from the zone that was specified when the instance was created if the instance has
        /// failed over to its secondary/failover zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryGceZone")]
        public virtual string SecondaryGceZone { get; set; }

        /// <summary>The URI of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>SSL configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaCert")]
        public virtual SslCert ServerCaCert { get; set; }

        /// <summary>The service account email address assigned to the instance. \This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmailAddress")]
        public virtual string ServiceAccountEmailAddress { get; set; }

        /// <summary>The user settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual Settings Settings { get; set; }

        /// <summary>The SQL network architecture for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlNetworkArchitecture")]
        public virtual string SqlNetworkArchitecture { get; set; }

        /// <summary>The current serving state of the Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>If the instance state is SUSPENDED, the reason for the suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReason")]
        public virtual System.Collections.Generic.IList<string> SuspensionReason { get; set; }

        /// <summary>
        /// Input only. Whether Cloud SQL is enabled to switch storing point-in-time recovery log files from a data disk
        /// to Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("switchTransactionLogsToCloudStorageEnabled")]
        public virtual System.Nullable<bool> SwitchTransactionLogsToCloudStorageEnabled { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag keys and tag values that are bound to this instance. You must represent
        /// each item in the map as: `"" : ""`. For example, a single resource can have the following tags:
        /// ```
        /// "123/environment": "production", "123/costCenter": "marketing",
        /// ```
        /// For more information on tag creation and
        /// management, see https://cloud.google.com/resource-manager/docs/tags/tags-overview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>Output only. All database versions that are available for upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradableDatabaseVersions")]
        public virtual System.Collections.Generic.IList<AvailableDatabaseVersion> UpgradableDatabaseVersions { get; set; }

        /// <summary>Output only. The dns name of the primary instance in a replication group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeEndpoint")]
        public virtual string WriteEndpoint { get; set; }

        /// <summary>The name and status of the failover replica.</summary>
        public class FailoverReplicaData
        {
            /// <summary>
            /// The availability status of the failover replica. A false status indicates that the failover replica is
            /// out of sync. The primary instance can only failover to the failover replica when the status is true.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("available")]
            public virtual System.Nullable<bool> Available { get; set; }

            /// <summary>
            /// The name of the failover replica. If specified at instance creation, a failover replica is created for
            /// the instance. The name doesn't include the project ID.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }
        }
    }

    /// <summary>Database list response.</summary>
    public class DatabasesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of database resources in the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Database> Items { get; set; }

        /// <summary>This is always `sql#databasesList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This context is used to demote an existing standalone instance to be a Cloud SQL read replica for an external
    /// database server.
    /// </summary>
    public class DemoteContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#demoteContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Required. The name of the instance which acts as an on-premises primary instance in the replication setup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRepresentativeInstanceName")]
        public virtual string SourceRepresentativeInstanceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-replica configuration for connecting to the on-premises primary instance.</summary>
    public class DemoteMasterConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#demoteMasterConfiguration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// MySQL specific configuration when replicating from a MySQL on-premises primary instance. Replication
        /// configuration information such as the username, password, certificates, and keys are not stored in the
        /// instance metadata. The configuration information is used only to set up the replication connection and is
        /// stored by MySQL in a file named `master.info` in the data directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlReplicaConfiguration")]
        public virtual DemoteMasterMySqlReplicaConfiguration MysqlReplicaConfiguration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance demote primary instance context.</summary>
    public class DemoteMasterContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#demoteMasterContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name of the instance which will act as on-premises primary instance in the replication setup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterInstanceName")]
        public virtual string MasterInstanceName { get; set; }

        /// <summary>
        /// Configuration specific to read-replicas replicating from the on-premises primary instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaConfiguration")]
        public virtual DemoteMasterConfiguration ReplicaConfiguration { get; set; }

        /// <summary>Flag to skip replication setup on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipReplicationSetup")]
        public virtual System.Nullable<bool> SkipReplicationSetup { get; set; }

        /// <summary>
        /// Verify the GTID consistency for demote operation. Default value: `True`. Setting this flag to `false`
        /// enables you to bypass the GTID consistency check between on-premises primary instance and Cloud SQL instance
        /// during the demotion operation but also exposes you to the risk of future replication failures. Change the
        /// value only if you know the reason for the GTID divergence and are confident that doing so will not cause any
        /// replication issues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyGtidConsistency")]
        public virtual System.Nullable<bool> VerifyGtidConsistency { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-replica configuration specific to MySQL databases.</summary>
    public class DemoteMasterMySqlReplicaConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificate")]
        public virtual string CaCertificate { get; set; }

        /// <summary>PEM representation of the replica's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>
        /// PEM representation of the replica's private key. The corresponding public key is encoded in the client's
        /// certificate. The format of the replica's private key can be either PKCS #1 or PKCS #8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>This is always `sql#demoteMasterMysqlReplicaConfiguration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The password for the replication connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The username for the replication connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deny Maintenance Periods. This specifies a date range during when all CSA rollout will be denied.
    /// </summary>
    public class DenyMaintenancePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// "deny maintenance period" end date. If the year of the end date is empty, the year of the start date also
        /// must be empty. In this case, it means the deny maintenance period recurs every year. The date is in format
        /// yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// "deny maintenance period" start date. If the year of the start date is empty, the year of the end date also
        /// must be empty. In this case, it means the deny maintenance period recurs every year. The date is in format
        /// yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>
        /// Time in UTC when the "deny maintenance period" starts on start_date and ends on end_date. The time is in
        /// format: HH:mm:SS, i.e., 00:00:00
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual string Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk encryption configuration for an instance.</summary>
    public class DiskEncryptionConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#diskEncryptionConfiguration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Resource name of KMS key for disk encryption</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk encryption status for an instance.</summary>
    public class DiskEncryptionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#diskEncryptionStatus`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>KMS key version used to encrypt the Cloud SQL instance resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersionName")]
        public virtual string KmsKeyVersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DNS metadata.</summary>
    public class DnsNameMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The connection type of the DNS name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>Output only. The scope that the DNS name applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsScope")]
        public virtual string DnsScope { get; set; }

        /// <summary>The DNS name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>Database instance export context.</summary>
    public class ExportContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options for exporting BAK files (SQL Server-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bakExportOptions")]
        public virtual BakExportOptionsData BakExportOptions { get; set; }

        /// <summary>Options for exporting data as CSV. `MySQL` and `PostgreSQL` instances only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvExportOptions")]
        public virtual CsvExportOptionsData CsvExportOptions { get; set; }

        /// <summary>
        /// Databases to be exported. `MySQL instances:` If `fileType` is `SQL` and no database is specified, all
        /// databases are exported, except for the `mysql` system database. If `fileType` is `CSV`, you can specify one
        /// database, either by using this property or by using the `csvExportOptions.selectQuery` property, which takes
        /// precedence over this property. `PostgreSQL instances:` If you don't specify a database by name, all user
        /// databases in the instance are exported. This excludes system databases and Cloud SQL databases used to
        /// manage internal operations. Exporting all user databases is only available for directory-formatted parallel
        /// export. If `fileType` is `CSV`, this database must match the one specified in the
        /// `csvExportOptions.selectQuery` property. `SQL Server instances:` You must specify one database to be
        /// exported, and the `fileType` must be `BAK`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databases")]
        public virtual System.Collections.Generic.IList<string> Databases { get; set; }

        /// <summary>The file type for the specified uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>This is always `sql#exportContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Whether to perform a serverless export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offload")]
        public virtual System.Nullable<bool> Offload { get; set; }

        /// <summary>Options for exporting data as SQL statements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlExportOptions")]
        public virtual SqlExportOptionsData SqlExportOptions { get; set; }

        /// <summary>Optional. Export parameters specific to SQL Server TDE certificates</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tdeExportOptions")]
        public virtual TdeExportOptionsData TdeExportOptions { get; set; }

        /// <summary>
        /// The path to the file in Google Cloud Storage where the export will be stored. The URI is in the form
        /// `gs://bucketName/fileName`. If the file already exists, the request succeeds, but the operation fails. If
        /// `fileType` is `SQL` and the filename ends with .gz, the contents are compressed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Options for exporting BAK files (SQL Server-only)</summary>
        public class BakExportOptionsData
        {
            /// <summary>Type of this bak file will be export, FULL or DIFF, SQL Server only</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("bakType")]
            public virtual string BakType { get; set; }

            /// <summary>Deprecated: copy_only is deprecated. Use differential_base instead</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("copyOnly")]
            public virtual System.Nullable<bool> CopyOnly { get; set; }

            /// <summary>
            /// Whether or not the backup can be used as a differential base copy_only backup can not be served as
            /// differential base
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("differentialBase")]
            public virtual System.Nullable<bool> DifferentialBase { get; set; }

            private string _exportLogEndTimeRaw;

            private object _exportLogEndTime;

            /// <summary>
            /// Optional. The end timestamp when transaction log will be included in the export operation. [RFC
            /// 3339](https://tools.ietf.org/html/rfc3339) format (for example, `2023-10-01T16:19:00.094`) in UTC. When
            /// omitted, all available logs until current time will be included. Only applied to Cloud SQL for SQL
            /// Server.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("exportLogEndTime")]
            public virtual string ExportLogEndTimeRaw
            {
                get => _exportLogEndTimeRaw;
                set
                {
                    _exportLogEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                    _exportLogEndTimeRaw = value;
                }
            }

            /// <summary><seealso cref="object"/> representation of <see cref="ExportLogEndTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExportLogEndTimeDateTimeOffset instead.")]
            public virtual object ExportLogEndTime
            {
                get => _exportLogEndTime;
                set
                {
                    _exportLogEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                    _exportLogEndTime = value;
                }
            }

            /// <summary>
            /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExportLogEndTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? ExportLogEndTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExportLogEndTimeRaw);
                set => ExportLogEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
            }

            private string _exportLogStartTimeRaw;

            private object _exportLogStartTime;

            /// <summary>
            /// Optional. The begin timestamp when transaction log will be included in the export operation. [RFC
            /// 3339](https://tools.ietf.org/html/rfc3339) format (for example, `2023-10-01T16:19:00.094`) in UTC. When
            /// omitted, all available logs from the beginning of retention period will be included. Only applied to
            /// Cloud SQL for SQL Server.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("exportLogStartTime")]
            public virtual string ExportLogStartTimeRaw
            {
                get => _exportLogStartTimeRaw;
                set
                {
                    _exportLogStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                    _exportLogStartTimeRaw = value;
                }
            }

            /// <summary><seealso cref="object"/> representation of <see cref="ExportLogStartTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExportLogStartTimeDateTimeOffset instead.")]
            public virtual object ExportLogStartTime
            {
                get => _exportLogStartTime;
                set
                {
                    _exportLogStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                    _exportLogStartTime = value;
                }
            }

            /// <summary>
            /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExportLogStartTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? ExportLogStartTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExportLogStartTimeRaw);
                set => ExportLogStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
            }

            /// <summary>
            /// Option for specifying how many stripes to use for the export. If blank, and the value of the striped
            /// field is true, the number of stripes is automatically chosen.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("stripeCount")]
            public virtual System.Nullable<int> StripeCount { get; set; }

            /// <summary>Whether or not the export should be striped.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("striped")]
            public virtual System.Nullable<bool> Striped { get; set; }
        }

        /// <summary>Options for exporting data as CSV. `MySQL` and `PostgreSQL` instances only.</summary>
        public class CsvExportOptionsData
        {
            /// <summary>
            /// Specifies the character that should appear before a data character that needs to be escaped.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("escapeCharacter")]
            public virtual string EscapeCharacter { get; set; }

            /// <summary>Specifies the character that separates columns within each row (line) of the file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldsTerminatedBy")]
            public virtual string FieldsTerminatedBy { get; set; }

            /// <summary>
            /// This is used to separate lines. If a line does not contain all fields, the rest of the columns are set
            /// to their default values.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("linesTerminatedBy")]
            public virtual string LinesTerminatedBy { get; set; }

            /// <summary>Specifies the quoting character to be used when a data value is quoted.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("quoteCharacter")]
            public virtual string QuoteCharacter { get; set; }

            /// <summary>The select query used to extract the data.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("selectQuery")]
            public virtual string SelectQuery { get; set; }
        }

        /// <summary>Options for exporting data as SQL statements.</summary>
        public class SqlExportOptionsData
        {
            /// <summary>Options for exporting from MySQL.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mysqlExportOptions")]
            public virtual MysqlExportOptionsData MysqlExportOptions { get; set; }

            /// <summary>Optional. Whether or not the export should be parallel.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("parallel")]
            public virtual System.Nullable<bool> Parallel { get; set; }

            /// <summary>Options for exporting from a Cloud SQL for PostgreSQL instance.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("postgresExportOptions")]
            public virtual PostgresExportOptionsData PostgresExportOptions { get; set; }

            /// <summary>Export only schemas.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("schemaOnly")]
            public virtual System.Nullable<bool> SchemaOnly { get; set; }

            /// <summary>
            /// Tables to export, or that were exported, from the specified database. If you specify tables, specify one
            /// and only one database. For PostgreSQL instances, you can specify only one table.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tables")]
            public virtual System.Collections.Generic.IList<string> Tables { get; set; }

            /// <summary>Optional. The number of threads to use for parallel export.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("threads")]
            public virtual System.Nullable<int> Threads { get; set; }

            /// <summary>Options for exporting from MySQL.</summary>
            public class MysqlExportOptionsData
            {
                /// <summary>
                /// Option to include SQL statement required to set up replication. If set to `1`, the dump file
                /// includes a CHANGE MASTER TO statement with the binary log coordinates, and --set-gtid-purged is set
                /// to ON. If set to `2`, the CHANGE MASTER TO statement is written as a SQL comment and has no effect.
                /// If set to any value other than `1`, --set-gtid-purged is set to OFF.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("masterData")]
                public virtual System.Nullable<int> MasterData { get; set; }
            }

            /// <summary>Options for exporting from a Cloud SQL for PostgreSQL instance.</summary>
            public class PostgresExportOptionsData
            {
                /// <summary>
                /// Optional. Use this option to include DROP &amp;lt;object&amp;gt; SQL statements. Use these
                /// statements to delete database objects before running the import operation.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("clean")]
                public virtual System.Nullable<bool> Clean { get; set; }

                /// <summary>
                /// Optional. Option to include an IF EXISTS SQL statement with each DROP statement produced by clean.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("ifExists")]
                public virtual System.Nullable<bool> IfExists { get; set; }
            }
        }

        /// <summary>Optional. Export parameters specific to SQL Server TDE certificates</summary>
        public class TdeExportOptionsData
        {
            /// <summary>
            /// Required. Path to the TDE certificate public key in the form gs://bucketName/fileName. The instance must
            /// have write access to the location. Applicable only for SQL Server instances.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("certificatePath")]
            public virtual string CertificatePath { get; set; }

            /// <summary>Required. Certificate name. Applicable only for SQL Server instances.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Required. Password that encrypts the private key.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPassword")]
            public virtual string PrivateKeyPassword { get; set; }

            /// <summary>
            /// Required. Path to the TDE certificate private key in the form gs://bucketName/fileName. The instance
            /// must have write access to the location. Applicable only for SQL Server instances.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPath")]
            public virtual string PrivateKeyPath { get; set; }
        }
    }

    /// <summary>The selected object that Cloud SQL migrates.</summary>
    public class ExternalSyncSelectedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the database that Cloud SQL migrates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance failover context.</summary>
    public class FailoverContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#failoverContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The current settings version of this instance. Request will be rejected if this version doesn't match the
        /// current settings version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settingsVersion")]
        public virtual System.Nullable<long> SettingsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A flag resource.</summary>
    public class Flag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Use this field if only certain integers are accepted. Can be combined with min_value and max_value to add
        /// additional values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedIntValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AllowedIntValues { get; set; }

        /// <summary>For `STRING` flags, a list of strings that the value can be set to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedStringValues")]
        public virtual System.Collections.Generic.IList<string> AllowedStringValues { get; set; }

        /// <summary>
        /// The database version this flag applies to. Can be MySQL instances: `MYSQL_8_0`, `MYSQL_8_0_18`,
        /// `MYSQL_8_0_26`, `MYSQL_5_7`, or `MYSQL_5_6`. PostgreSQL instances: `POSTGRES_9_6`, `POSTGRES_10`,
        /// `POSTGRES_11` or `POSTGRES_12`. SQL Server instances: `SQLSERVER_2017_STANDARD`,
        /// `SQLSERVER_2017_ENTERPRISE`, `SQLSERVER_2017_EXPRESS`, `SQLSERVER_2017_WEB`, `SQLSERVER_2019_STANDARD`,
        /// `SQLSERVER_2019_ENTERPRISE`, `SQLSERVER_2019_EXPRESS`, or `SQLSERVER_2019_WEB`. See [the complete
        /// list](/sql/docs/mysql/admin-api/rest/v1/SqlDatabaseVersion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliesTo")]
        public virtual System.Collections.Generic.IList<string> AppliesTo { get; set; }

        /// <summary>Scope of flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flagScope")]
        public virtual string FlagScope { get; set; }

        /// <summary>Whether or not the flag is considered in beta.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inBeta")]
        public virtual System.Nullable<bool> InBeta { get; set; }

        /// <summary>This is always `sql#flag`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>For `INTEGER` flags, the maximum allowed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<long> MaxValue { get; set; }

        /// <summary>For `INTEGER` flags, the minimum allowed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<long> MinValue { get; set; }

        /// <summary>
        /// This is the name of the flag. Flag names always use underscores, not hyphens, for example:
        /// `max_allowed_packet`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Recommended flag value in integer format for UI display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedIntValue")]
        public virtual System.Nullable<long> RecommendedIntValue { get; set; }

        /// <summary>Recommended flag value in string format for UI display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedStringValue")]
        public virtual string RecommendedStringValue { get; set; }

        /// <summary>
        /// Indicates whether changing this flag will trigger a database restart. Only applicable to Second Generation
        /// instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiresRestart")]
        public virtual System.Nullable<bool> RequiresRestart { get; set; }

        /// <summary>
        /// The type of the flag. Flags are typed to being `BOOLEAN`, `STRING`, `INTEGER` or `NONE`. `NONE` is used for
        /// flags which do not take a value, such as `skip_grant_tables`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Flags list response.</summary>
    public class FlagsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of flags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Flag> Items { get; set; }

        /// <summary>This is always `sql#flagsList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Gemini instance configuration.</summary>
    public class GeminiInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether the active query is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeQueryEnabled")]
        public virtual System.Nullable<bool> ActiveQueryEnabled { get; set; }

        /// <summary>Output only. Whether Gemini is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitled")]
        public virtual System.Nullable<bool> Entitled { get; set; }

        /// <summary>Output only. Whether the flag recommender is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flagRecommenderEnabled")]
        public virtual System.Nullable<bool> FlagRecommenderEnabled { get; set; }

        /// <summary>Output only. Whether the vacuum management is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleVacuumMgmtEnabled")]
        public virtual System.Nullable<bool> GoogleVacuumMgmtEnabled { get; set; }

        /// <summary>Output only. Whether the index advisor is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexAdvisorEnabled")]
        public virtual System.Nullable<bool> IndexAdvisorEnabled { get; set; }

        /// <summary>Output only. Whether canceling the out-of-memory (OOM) session is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oomSessionCancelEnabled")]
        public virtual System.Nullable<bool> OomSessionCancelEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ephemeral certificate creation request.</summary>
    public class GenerateEphemeralCertRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Access token to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
        public virtual string AccessToken { get; set; }

        /// <summary>PEM encoded public key to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("public_key")]
        public virtual string PublicKey { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>Optional. Optional snapshot read timestamp to trade freshness for performance.</summary>
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

        /// <summary>Optional. If set, it will contain the cert valid duration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validDuration")]
        public virtual object ValidDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ephemeral certificate creation request.</summary>
    public class GenerateEphemeralCertResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Generated cert</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralCert")]
        public virtual SslCert EphemeralCert { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance import context.</summary>
    public class ImportContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Import parameters specific to SQL Server .BAK files</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bakImportOptions")]
        public virtual BakImportOptionsData BakImportOptions { get; set; }

        /// <summary>Options for importing data as CSV.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csvImportOptions")]
        public virtual CsvImportOptionsData CsvImportOptions { get; set; }

        /// <summary>
        /// The target database for the import. If `fileType` is `SQL`, this field is required only if the import file
        /// does not specify a database, and is overridden by any database specification in the import file. For entire
        /// instance parallel import operations, the database is overridden by the database name stored in subdirectory
        /// name. If `fileType` is `CSV`, one database must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>
        /// The file type for the specified uri. * `SQL`: The file contains SQL statements. * `CSV`: The file contains
        /// CSV data. * `BAK`: The file contains backup data for a SQL Server instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>The PostgreSQL user for this import operation. PostgreSQL instances only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importUser")]
        public virtual string ImportUser { get; set; }

        /// <summary>This is always `sql#importContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional. Options for importing data from SQL statements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlImportOptions")]
        public virtual SqlImportOptionsData SqlImportOptions { get; set; }

        /// <summary>
        /// Optional. Import parameters specific to SQL Server .TDE files Import parameters specific to SQL Server TDE
        /// certificates
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tdeImportOptions")]
        public virtual TdeImportOptionsData TdeImportOptions { get; set; }

        /// <summary>
        /// Path to the import file in Cloud Storage, in the form `gs://bucketName/fileName`. Compressed gzip files
        /// (.gz) are supported when `fileType` is `SQL`. The instance must have write permissions to the bucket and
        /// read access to the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>Import parameters specific to SQL Server .BAK files</summary>
        public class BakImportOptionsData
        {
            /// <summary>Type of the bak content, FULL or DIFF.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("bakType")]
            public virtual string BakType { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("encryptionOptions")]
            public virtual EncryptionOptionsData EncryptionOptions { get; set; }

            /// <summary>
            /// Whether or not the backup importing will restore database with NORECOVERY option Applies only to Cloud
            /// SQL for SQL Server.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("noRecovery")]
            public virtual System.Nullable<bool> NoRecovery { get; set; }

            /// <summary>
            /// Whether or not the backup importing request will just bring database online without downloading Bak
            /// content only one of "no_recovery" and "recovery_only" can be true otherwise error will return. Applies
            /// only to Cloud SQL for SQL Server.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("recoveryOnly")]
            public virtual System.Nullable<bool> RecoveryOnly { get; set; }

            private string _stopAtRaw;

            private object _stopAt;

            /// <summary>
            /// Optional. The timestamp when the import should stop. This timestamp is in the [RFC
            /// 3339](https://tools.ietf.org/html/rfc3339) format (for example, `2023-10-01T16:19:00.094`). This field
            /// is equivalent to the STOPAT keyword and applies to Cloud SQL for SQL Server only.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("stopAt")]
            public virtual string StopAtRaw
            {
                get => _stopAtRaw;
                set
                {
                    _stopAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                    _stopAtRaw = value;
                }
            }

            /// <summary><seealso cref="object"/> representation of <see cref="StopAtRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StopAtDateTimeOffset instead.")]
            public virtual object StopAt
            {
                get => _stopAt;
                set
                {
                    _stopAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                    _stopAt = value;
                }
            }

            /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StopAtRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? StopAtDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StopAtRaw);
                set => StopAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
            }

            /// <summary>
            /// Optional. The marked transaction where the import should stop. This field is equivalent to the
            /// STOPATMARK keyword and applies to Cloud SQL for SQL Server only.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("stopAtMark")]
            public virtual string StopAtMark { get; set; }

            /// <summary>
            /// Whether or not the backup set being restored is striped. Applies only to Cloud SQL for SQL Server.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("striped")]
            public virtual System.Nullable<bool> Striped { get; set; }

            public class EncryptionOptionsData
            {
                /// <summary>
                /// Path to the Certificate (.cer) in Cloud Storage, in the form `gs://bucketName/fileName`. The
                /// instance must have write permissions to the bucket and read access to the file.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("certPath")]
                public virtual string CertPath { get; set; }

                /// <summary>Optional. Whether the imported file remains encrypted.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("keepEncrypted")]
                public virtual System.Nullable<bool> KeepEncrypted { get; set; }

                /// <summary>Password that encrypts the private key</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("pvkPassword")]
                public virtual string PvkPassword { get; set; }

                /// <summary>
                /// Path to the Certificate Private Key (.pvk) in Cloud Storage, in the form `gs://bucketName/fileName`.
                /// The instance must have write permissions to the bucket and read access to the file.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("pvkPath")]
                public virtual string PvkPath { get; set; }
            }
        }

        /// <summary>Options for importing data as CSV.</summary>
        public class CsvImportOptionsData
        {
            /// <summary>
            /// The columns to which CSV data is imported. If not specified, all columns of the database table are
            /// loaded with CSV data.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("columns")]
            public virtual System.Collections.Generic.IList<string> Columns { get; set; }

            /// <summary>
            /// Specifies the character that should appear before a data character that needs to be escaped.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("escapeCharacter")]
            public virtual string EscapeCharacter { get; set; }

            /// <summary>Specifies the character that separates columns within each row (line) of the file.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("fieldsTerminatedBy")]
            public virtual string FieldsTerminatedBy { get; set; }

            /// <summary>
            /// This is used to separate lines. If a line does not contain all fields, the rest of the columns are set
            /// to their default values.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("linesTerminatedBy")]
            public virtual string LinesTerminatedBy { get; set; }

            /// <summary>Specifies the quoting character to be used when a data value is quoted.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("quoteCharacter")]
            public virtual string QuoteCharacter { get; set; }

            /// <summary>The table to which CSV data is imported.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("table")]
            public virtual string Table { get; set; }
        }

        /// <summary>Optional. Options for importing data from SQL statements.</summary>
        public class SqlImportOptionsData
        {
            /// <summary>Optional. Whether or not the import should be parallel.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("parallel")]
            public virtual System.Nullable<bool> Parallel { get; set; }

            /// <summary>Optional. Options for importing from a Cloud SQL for PostgreSQL instance.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("postgresImportOptions")]
            public virtual PostgresImportOptionsData PostgresImportOptions { get; set; }

            /// <summary>Optional. The number of threads to use for parallel import.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("threads")]
            public virtual System.Nullable<int> Threads { get; set; }

            /// <summary>Optional. Options for importing from a Cloud SQL for PostgreSQL instance.</summary>
            public class PostgresImportOptionsData
            {
                /// <summary>
                /// Optional. The --clean flag for the pg_restore utility. This flag applies only if you enabled Cloud
                /// SQL to import files in parallel.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("clean")]
                public virtual System.Nullable<bool> Clean { get; set; }

                /// <summary>
                /// Optional. The --if-exists flag for the pg_restore utility. This flag applies only if you enabled
                /// Cloud SQL to import files in parallel.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("ifExists")]
                public virtual System.Nullable<bool> IfExists { get; set; }
            }
        }

        /// <summary>
        /// Optional. Import parameters specific to SQL Server .TDE files Import parameters specific to SQL Server TDE
        /// certificates
        /// </summary>
        public class TdeImportOptionsData
        {
            /// <summary>
            /// Required. Path to the TDE certificate public key in the form gs://bucketName/fileName. The instance must
            /// have read access to the file. Applicable only for SQL Server instances.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("certificatePath")]
            public virtual string CertificatePath { get; set; }

            /// <summary>Required. Certificate name. Applicable only for SQL Server instances.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Required. Password that encrypts the private key.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPassword")]
            public virtual string PrivateKeyPassword { get; set; }

            /// <summary>
            /// Required. Path to the TDE certificate private key in the form gs://bucketName/fileName. The instance
            /// must have read access to the file. Applicable only for SQL Server instances.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPath")]
            public virtual string PrivateKeyPath { get; set; }
        }
    }

    /// <summary>
    /// Insights configuration. This specifies when Cloud SQL Insights feature is enabled and optional configuration.
    /// </summary>
    public class InsightsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Query Insights feature is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInsightsEnabled")]
        public virtual System.Nullable<bool> QueryInsightsEnabled { get; set; }

        /// <summary>
        /// Number of query execution plans captured by Insights per minute for all queries combined. Default is 5.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryPlansPerMinute")]
        public virtual System.Nullable<int> QueryPlansPerMinute { get; set; }

        /// <summary>
        /// Maximum query length stored in bytes. Default value: 1024 bytes. Range: 256-4500 bytes. Query length more
        /// than this field value will be truncated to this value. When unset, query length will be the default value.
        /// Changing query length will restart the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryStringLength")]
        public virtual System.Nullable<int> QueryStringLength { get; set; }

        /// <summary>Whether Query Insights will record application tags from query when enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordApplicationTags")]
        public virtual System.Nullable<bool> RecordApplicationTags { get; set; }

        /// <summary>Whether Query Insights will record client address when enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordClientAddress")]
        public virtual System.Nullable<bool> RecordClientAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reference to another Cloud SQL instance.</summary>
    public class InstanceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the Cloud SQL instance being referenced. This does not include the project ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The project ID of the Cloud SQL instance being referenced. The default is the same project ID as the
        /// instance references it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The region of the Cloud SQL instance being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to acquire an SSRS lease for an instance.</summary>
    public class InstancesAcquireSsrsLeaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains details about the acquire SSRS lease operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acquireSsrsLeaseContext")]
        public virtual AcquireSsrsLeaseContext AcquireSsrsLeaseContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance clone request.</summary>
    public class InstancesCloneRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains details about the clone operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloneContext")]
        public virtual CloneContext CloneContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database demote primary instance request.</summary>
    public class InstancesDemoteMasterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains details about the demoteMaster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("demoteMasterContext")]
        public virtual DemoteMasterContext DemoteMasterContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This request is used to demote an existing standalone instance to be a Cloud SQL read replica for an external
    /// database server.
    /// </summary>
    public class InstancesDemoteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This context is used to demote an existing standalone instance to be a Cloud SQL read replica for
        /// an external database server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("demoteContext")]
        public virtual DemoteContext DemoteContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance export request.</summary>
    public class InstancesExportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains details about the export operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportContext")]
        public virtual ExportContext ExportContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance failover request.</summary>
    public class InstancesFailoverRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Failover Context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverContext")]
        public virtual FailoverContext FailoverContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance import request.</summary>
    public class InstancesImportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains details about the import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importContext")]
        public virtual ImportContext ImportContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instances list response.</summary>
    public class InstancesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of database instance resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<DatabaseInstance> Items { get; set; }

        /// <summary>This is always `sql#instancesList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of warnings that occurred while handling the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<ApiWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instances ListServerCas response.</summary>
    public class InstancesListServerCasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("activeVersion")]
        public virtual string ActiveVersion { get; set; }

        /// <summary>List of server CA certificates for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certs")]
        public virtual System.Collections.Generic.IList<SslCert> Certs { get; set; }

        /// <summary>This is always `sql#instancesListServerCas`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instances ListServerCertificatess response.</summary>
    public class InstancesListServerCertificatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `sha1_fingerprint` of the active certificate from `server_certs`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeVersion")]
        public virtual string ActiveVersion { get; set; }

        /// <summary>List of server CA certificates for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCerts")]
        public virtual System.Collections.Generic.IList<SslCert> CaCerts { get; set; }

        /// <summary>This is always `sql#instancesListServerCertificates`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// List of server certificates for the instance, signed by the corresponding CA from the `ca_certs` list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCerts")]
        public virtual System.Collections.Generic.IList<SslCert> ServerCerts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database Instance reencrypt request.</summary>
    public class InstancesReencryptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration specific to backup re-encryption</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupReencryptionConfig")]
        public virtual BackupReencryptionConfig BackupReencryptionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance restore backup request.</summary>
    public class InstancesRestoreBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the backup that's used to restore a Cloud SQL instance: Format:
        /// projects/{project-id}/backups/{backup-uid}. Only one of restore_backup_context, backup, backupdr_backup can
        /// be passed to the input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// The name of the backup that's used to restore a Cloud SQL instance: Format:
        /// "projects/{project-id}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}/backups/{backup-uid}".
        /// Only one of restore_backup_context, backup, backupdr_backup can be passed to the input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupdrBackup")]
        public virtual string BackupdrBackup { get; set; }

        /// <summary>Parameters required to perform the restore backup operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreBackupContext")]
        public virtual RestoreBackupContext RestoreBackupContext { get; set; }

        /// <summary>
        /// Optional. By using this parameter, Cloud SQL overrides any instance settings stored in the backup you are
        /// restoring from. You can't change the instance's major database version and you can only increase the disk
        /// size. You can use this field to restore new instances only. This field is not applicable for restore to
        /// existing instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreInstanceSettings")]
        public virtual DatabaseInstance RestoreInstanceSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rotate Server CA request.</summary>
    public class InstancesRotateServerCaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains details about the rotate server CA operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotateServerCaContext")]
        public virtual RotateServerCaContext RotateServerCaContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rotate Server Certificate request.</summary>
    public class InstancesRotateServerCertificateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Contains details about the rotate server CA operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotateServerCertificateContext")]
        public virtual RotateServerCertificateContext RotateServerCertificateContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance truncate log request.</summary>
    public class InstancesTruncateLogRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains details about the truncate log operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truncateLogContext")]
        public virtual TruncateLogContext TruncateLogContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class Interval : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>IP Management configuration.</summary>
    public class IpConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the allocated ip range for the private ip Cloud SQL instance. For example:
        /// "google-managed-services-default". If set, the instance ip will be created in the allocated range. The range
        /// name must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035). Specifically, the name must be 1-63
        /// characters long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?.`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedIpRange")]
        public virtual string AllocatedIpRange { get; set; }

        /// <summary>
        /// The list of external networks that are allowed to connect to the instance using the IP. In 'CIDR' notation,
        /// also known as 'slash' notation (for example: `157.197.200.0/24`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedNetworks")]
        public virtual System.Collections.Generic.IList<AclEntry> AuthorizedNetworks { get; set; }

        /// <summary>Optional. Custom Subject Alternative Name(SAN)s for a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSubjectAlternativeNames")]
        public virtual System.Collections.Generic.IList<string> CustomSubjectAlternativeNames { get; set; }

        /// <summary>Controls connectivity to private IP instances from Google services, such as BigQuery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivatePathForGoogleCloudServices")]
        public virtual System.Nullable<bool> EnablePrivatePathForGoogleCloudServices { get; set; }

        /// <summary>Whether the instance is assigned a public IP address or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv4Enabled")]
        public virtual System.Nullable<bool> Ipv4Enabled { get; set; }

        /// <summary>
        /// The resource link for the VPC network from which the Cloud SQL instance is accessible for private IP. For
        /// example, `/projects/myProject/global/networks/default`. This setting can be updated, but it cannot be
        /// removed after it is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateNetwork")]
        public virtual string PrivateNetwork { get; set; }

        /// <summary>PSC settings for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConfig")]
        public virtual PscConfig PscConfig { get; set; }

        /// <summary>
        /// Use `ssl_mode` instead. Whether SSL/TLS connections over IP are enforced. If set to false, then allow both
        /// non-SSL/non-TLS and SSL/TLS connections. For SSL/TLS connections, the client certificate won't be verified.
        /// If set to true, then only allow connections encrypted with SSL/TLS and with valid client certificates. If
        /// you want to enforce SSL/TLS without enforcing the requirement for valid client certificates, then use the
        /// `ssl_mode` flag instead of the legacy `require_ssl` flag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireSsl")]
        public virtual System.Nullable<bool> RequireSsl { get; set; }

        /// <summary>Specify what type of CA is used for the server certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaMode")]
        public virtual string ServerCaMode { get; set; }

        /// <summary>
        /// Optional. The resource name of the server CA pool for an instance with `CUSTOMER_MANAGED_CAS_CA` as the
        /// `server_ca_mode`. Format: projects/{PROJECT}/locations/{REGION}/caPools/{CA_POOL_ID}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaPool")]
        public virtual string ServerCaPool { get; set; }

        /// <summary>
        /// Specify how SSL/TLS is enforced in database connections. If you must use the `require_ssl` flag for backward
        /// compatibility, then only the following value pairs are valid: For PostgreSQL and MySQL: *
        /// `ssl_mode=ALLOW_UNENCRYPTED_AND_ENCRYPTED` and `require_ssl=false` * `ssl_mode=ENCRYPTED_ONLY` and
        /// `require_ssl=false` * `ssl_mode=TRUSTED_CLIENT_CERTIFICATE_REQUIRED` and `require_ssl=true` For SQL Server:
        /// * `ssl_mode=ALLOW_UNENCRYPTED_AND_ENCRYPTED` and `require_ssl=false` * `ssl_mode=ENCRYPTED_ONLY` and
        /// `require_ssl=true` The value of `ssl_mode` has priority over the value of `require_ssl`. For example, for
        /// the pair `ssl_mode=ENCRYPTED_ONLY` and `require_ssl=false`, `ssl_mode=ENCRYPTED_ONLY` means accept only SSL
        /// connections, while `require_ssl=false` means accept both non-SSL and SSL connections. In this case, MySQL
        /// and PostgreSQL databases respect `ssl_mode` and accepts only SSL connections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslMode")]
        public virtual string SslMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance IP mapping</summary>
    public class IpMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IP address assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        private string _timeToRetireRaw;

        private object _timeToRetire;

        /// <summary>
        /// The due time for this IP to be retired in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for
        /// example `2012-11-15T16:19:00.094Z`. This field is only available when the IP is scheduled to be retired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeToRetire")]
        public virtual string TimeToRetireRaw
        {
            get => _timeToRetireRaw;
            set
            {
                _timeToRetire = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timeToRetireRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimeToRetireRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeToRetireDateTimeOffset instead.")]
        public virtual object TimeToRetire
        {
            get => _timeToRetire;
            set
            {
                _timeToRetireRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timeToRetire = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeToRetireRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeToRetireDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimeToRetireRaw);
            set => TimeToRetireRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The type of this IP address. A `PRIMARY` address is a public address that can accept incoming connections. A
        /// `PRIVATE` address is a private address that can accept incoming connections. An `OUTGOING` address is the
        /// source address of connections originating from the instance, if supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response payload containing a list of the backups.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, then there
        /// aren't subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// If a region isn't unavailable or if an unknown error occurs, then a warning message is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<ApiWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Preferred location. This specifies where a Cloud SQL instance is located. Note that if the preferred location is
    /// not available, the instance will be located as close as possible within the region. Only one location may be
    /// specified.
    /// </summary>
    public class LocationPreference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The App Engine application to follow, it must be in the same region as the Cloud SQL instance. WARNING:
        /// Changing this might restart the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followGaeApplication")]
        public virtual string FollowGaeApplication { get; set; }

        /// <summary>This is always `sql#locationPreference`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The preferred Compute Engine zone for the secondary/failover (for example: us-central1-a, us-central1-b,
        /// etc.). To disable this field, set it to 'no_secondary_zone'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryZone")]
        public virtual string SecondaryZone { get; set; }

        /// <summary>
        /// The preferred Compute Engine zone (for example: us-central1-a, us-central1-b, etc.). WARNING: Changing this
        /// might restart the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance window. This specifies when a Cloud SQL instance is restarted for system maintenance purposes.
    /// </summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of week - `MONDAY`, `TUESDAY`, `WEDNESDAY`, `THURSDAY`, `FRIDAY`, `SATURDAY`, or `SUNDAY`. Specify in
        /// the UTC time zone. Returned in output as an integer, 1 to 7, where `1` equals Monday.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Hour of day - 0 to 23. Specify in the UTC time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>This is always `sql#maintenanceWindow`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Maintenance timing settings: `canary`, `stable`, or `week5`. For more information, see [About maintenance on
        /// Cloud SQL instances](https://cloud.google.com/sql/docs/mysql/maintenance).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTrack")]
        public virtual string UpdateTrack { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-replica configuration specific to MySQL databases.</summary>
    public class MySqlReplicaConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificate")]
        public virtual string CaCertificate { get; set; }

        /// <summary>PEM representation of the replica's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>
        /// PEM representation of the replica's private key. The corresponding public key is encoded in the client's
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>Seconds to wait between connect retries. MySQL's default is 60 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectRetryInterval")]
        public virtual System.Nullable<int> ConnectRetryInterval { get; set; }

        /// <summary>
        /// Path to a SQL dump file in Google Cloud Storage from which the replica instance is to be created. The URI is
        /// in the form gs://bucketName/fileName. Compressed gzip files (.gz) are also supported. Dumps have the binlog
        /// co-ordinates from which replication begins. This can be accomplished by setting --master-data to 1 when
        /// using mysqldump.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpFilePath")]
        public virtual string DumpFilePath { get; set; }

        /// <summary>This is always `sql#mysqlReplicaConfiguration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Interval in milliseconds between replication heartbeats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterHeartbeatPeriod")]
        public virtual System.Nullable<long> MasterHeartbeatPeriod { get; set; }

        /// <summary>The password for the replication connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>A list of permissible ciphers to use for SSL encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCipher")]
        public virtual string SslCipher { get; set; }

        /// <summary>The username for the replication connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>
        /// Whether or not to check the primary instance's Common Name value in the certificate that it sends during the
        /// SSL handshake.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyServerCertificate")]
        public virtual System.Nullable<bool> VerifyServerCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MySQL-specific external server sync settings.</summary>
    public class MySqlSyncConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Flags to use for the initial dump.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialSyncFlags")]
        public virtual System.Collections.Generic.IList<SyncFlags> InitialSyncFlags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>On-premises instance configuration.</summary>
    public class OnPremisesConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificate")]
        public virtual string CaCertificate { get; set; }

        /// <summary>PEM representation of the replica's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>
        /// PEM representation of the replica's private key. The corresponding public key is encoded in the client's
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>The dump file to create the Cloud SQL replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpFilePath")]
        public virtual string DumpFilePath { get; set; }

        /// <summary>The host and port of the on-premises instance in host:port format</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostPort")]
        public virtual string HostPort { get; set; }

        /// <summary>This is always `sql#onPremisesConfiguration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The password for connecting to on-premises instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. A list of objects that the user selects for replication from an external source instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedObjects")]
        public virtual System.Collections.Generic.IList<SelectedObjects> SelectedObjects { get; set; }

        /// <summary>The reference to Cloud SQL instance if the source is Cloud SQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceInstance")]
        public virtual InstanceReference SourceInstance { get; set; }

        /// <summary>Optional. SslOption for replica connection to the on-premises source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslOption")]
        public virtual string SslOption { get; set; }

        /// <summary>The username for connecting to on-premises instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Operation resource. For successful operations that return an Operation resource, only the fields relevant to
    /// the operation are populated in the resource.
    /// </summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The context for acquire SSRS lease operation, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acquireSsrsLeaseContext")]
        public virtual AcquireSsrsLeaseContext AcquireSsrsLeaseContext { get; set; }

        /// <summary>An Admin API warning message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiWarning")]
        public virtual ApiWarning ApiWarning { get; set; }

        /// <summary>The context for backup operation, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupContext")]
        public virtual BackupContext BackupContext { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// The time this operation finished in UTC timezone in [RFC 3339](https://tools.ietf.org/html/rfc3339) format,
        /// for example `2012-11-15T16:19:00.094Z`.
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

        /// <summary>If errors occurred during processing of this operation, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual OperationErrors Error { get; set; }

        /// <summary>The context for export operation, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportContext")]
        public virtual ExportContext ExportContext { get; set; }

        /// <summary>The context for import operation, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importContext")]
        public virtual ImportContext ImportContext { get; set; }

        private string _insertTimeRaw;

        private object _insertTime;

        /// <summary>
        /// The time this operation was enqueued in UTC timezone in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// format, for example `2012-11-15T16:19:00.094Z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTimeRaw
        {
            get => _insertTimeRaw;
            set
            {
                _insertTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _insertTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InsertTimeDateTimeOffset instead.")]
        public virtual object InsertTime
        {
            get => _insertTime;
            set
            {
                _insertTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _insertTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InsertTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InsertTimeRaw);
            set => InsertTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>This is always `sql#operation`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// An identifier that uniquely identifies the operation. You can use this identifier to retrieve the Operations
        /// resource that has information about the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The type of the operation. Valid values are: * `CREATE` * `DELETE` * `UPDATE` * `RESTART` * `IMPORT` *
        /// `EXPORT` * `BACKUP_VOLUME` * `RESTORE_VOLUME` * `CREATE_USER` * `DELETE_USER` * `CREATE_DATABASE` *
        /// `DELETE_DATABASE`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>The URI of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// The time this operation actually started in UTC timezone in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// format, for example `2012-11-15T16:19:00.094Z`.
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

        /// <summary>The status of an operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Optional. The sub operation based on the operation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subOperationType")]
        public virtual SqlSubOperationType SubOperationType { get; set; }

        /// <summary>Name of the resource on which this operation runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targetLink")]
        public virtual string TargetLink { get; set; }

        /// <summary>The project ID of the target instance related to this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProject")]
        public virtual string TargetProject { get; set; }

        /// <summary>The email address of the user who initiated this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance operation error.</summary>
    public class OperationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the specific error that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>This is always `sql#operationError`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Additional information about the error encountered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance operation errors list wrapper.</summary>
    public class OperationErrors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of errors encountered while processing this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<OperationError> Errors { get; set; }

        /// <summary>This is always `sql#operationErrors`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the operation finished running.</summary>
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

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operations list response.</summary>
    public class OperationsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of operation resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Operation> Items { get; set; }

        /// <summary>This is always `sql#operationsList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-only password status.</summary>
    public class PasswordStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, user does not have login privileges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        private string _passwordExpirationTimeRaw;

        private object _passwordExpirationTime;

        /// <summary>The expiration time of the current password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordExpirationTime")]
        public virtual string PasswordExpirationTimeRaw
        {
            get => _passwordExpirationTimeRaw;
            set
            {
                _passwordExpirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _passwordExpirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PasswordExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PasswordExpirationTimeDateTimeOffset instead.")]
        public virtual object PasswordExpirationTime
        {
            get => _passwordExpirationTime;
            set
            {
                _passwordExpirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _passwordExpirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="PasswordExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PasswordExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PasswordExpirationTimeRaw);
            set => PasswordExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance local user password validation policy</summary>
    public class PasswordValidationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The complexity of the password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complexity")]
        public virtual string Complexity { get; set; }

        /// <summary>This field is deprecated and will be removed in a future version of the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disallowCompromisedCredentials")]
        public virtual System.Nullable<bool> DisallowCompromisedCredentials { get; set; }

        /// <summary>Disallow username as a part of the password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disallowUsernameSubstring")]
        public virtual System.Nullable<bool> DisallowUsernameSubstring { get; set; }

        /// <summary>Whether the password policy is enabled or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePasswordPolicy")]
        public virtual System.Nullable<bool> EnablePasswordPolicy { get; set; }

        /// <summary>Minimum number of characters allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<int> MinLength { get; set; }

        /// <summary>
        /// Minimum interval after which the password can be changed. This flag is only supported for PostgreSQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordChangeInterval")]
        public virtual object PasswordChangeInterval { get; set; }

        /// <summary>Number of previous passwords that cannot be reused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reuseInterval")]
        public virtual System.Nullable<int> ReuseInterval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Perform disk shrink context.</summary>
    public class PerformDiskShrinkContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target disk shrink size in GigaBytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSizeGb")]
        public virtual System.Nullable<long> TargetSizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Context to perform a point-in-time restore of an instance managed by Google Cloud Backup and Disaster Recovery.
    /// </summary>
    public class PointInTimeRestoreContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the allocated IP range for the internal IP Cloud SQL instance. For example:
        /// "google-managed-services-default". If you set this, then Cloud SQL creates the IP address for the cloned
        /// instance in the allocated range. This range must comply with [RFC 1035](https://tools.ietf.org/html/rfc1035)
        /// standards. Specifically, the name must be 1-63 characters long and match the regular expression
        /// [a-z]([-a-z0-9]*[a-z0-9])?. Reserved for future use. http://go/speckle-subnet-picker-clone
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedIpRange")]
        public virtual string AllocatedIpRange { get; set; }

        /// <summary>
        /// The Google Cloud Backup and Disaster Recovery Datasource URI. Format:
        /// projects/{project}/locations/{region}/backupVaults/{backupvault}/dataSources/{datasource}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasource")]
        public virtual string Datasource { get; set; }

        private string _pointInTimeRaw;

        private object _pointInTime;

        /// <summary>Required. The date and time to which you want to restore the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointInTime")]
        public virtual string PointInTimeRaw
        {
            get => _pointInTimeRaw;
            set
            {
                _pointInTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _pointInTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PointInTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PointInTimeDateTimeOffset instead.")]
        public virtual object PointInTime
        {
            get => _pointInTime;
            set
            {
                _pointInTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _pointInTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PointInTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PointInTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PointInTimeRaw);
            set => PointInTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Point-in-time recovery of a regional instance in the specified zones. If not specified, clone to
        /// the same secondary zone as the source instance. This value cannot be the same as the preferred_zone field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredSecondaryZone")]
        public virtual string PreferredSecondaryZone { get; set; }

        /// <summary>
        /// Optional. Point-in-time recovery of an instance to the specified zone. If no zone is specified, then clone
        /// to the same primary zone as the source instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredZone")]
        public virtual string PreferredZone { get; set; }

        /// <summary>
        /// Optional. The resource link for the VPC network from which the Cloud SQL instance is accessible for private
        /// IP. For example, `/projects/myProject/global/networks/default`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateNetwork")]
        public virtual string PrivateNetwork { get; set; }

        /// <summary>Target instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetInstance")]
        public virtual string TargetInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a single read pool node of a read pool.</summary>
    public class PoolNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The DNS name of the read pool node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsName")]
        public virtual string DnsName { get; set; }

        /// <summary>Output only. The list of DNS names used by this read pool node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsNames")]
        public virtual System.Collections.Generic.IList<DnsNameMapping> DnsNames { get; set; }

        /// <summary>Output only. The zone of the read pool node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceZone")]
        public virtual string GceZone { get; set; }

        /// <summary>
        /// Output only. Mappings containing IP addresses that can be used to connect to the read pool node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<IpMapping> IpAddresses { get; set; }

        /// <summary>Output only. The name of the read pool node, to be used for retrieving metrics and logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the read pool node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings for an automatically-setup Private Service Connect consumer endpoint that is used to connect to a Cloud
    /// SQL instance.
    /// </summary>
    public class PscAutoConnectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The consumer network of this consumer endpoint. This must be a resource path that includes both the host
        /// project and the network name. For example, `projects/project1/global/networks/network1`. The consumer host
        /// project of this network might be different from the consumer service project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerNetwork")]
        public virtual string ConsumerNetwork { get; set; }

        /// <summary>The connection policy status of the consumer network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerNetworkStatus")]
        public virtual string ConsumerNetworkStatus { get; set; }

        /// <summary>
        /// This is the project ID of consumer service project of this consumer endpoint. Optional. This is only
        /// applicable if consumer_network is a shared vpc network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerProject")]
        public virtual string ConsumerProject { get; set; }

        /// <summary>The IP address of the consumer endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>The connection status of the consumer endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PSC settings for a Cloud SQL instance.</summary>
    public class PscConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of consumer projects that are allow-listed for PSC connections to this instance. This
        /// instance can be connected to with PSC from any network in these projects. Each consumer project in this list
        /// may be represented by a project number (numeric) or by a project id (alphanumeric).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedConsumerProjects")]
        public virtual System.Collections.Generic.IList<string> AllowedConsumerProjects { get; set; }

        /// <summary>
        /// Optional. The list of settings for requested Private Service Connect consumer endpoints that can be used to
        /// connect to this Cloud SQL instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscAutoConnections")]
        public virtual System.Collections.Generic.IList<PscAutoConnectionConfig> PscAutoConnections { get; set; }

        /// <summary>Whether PSC connectivity is enabled for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscEnabled")]
        public virtual System.Nullable<bool> PscEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-replica configuration for connecting to the primary instance.</summary>
    public class ReplicaConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies if a SQL Server replica is a cascadable replica. A cascadable replica is a SQL Server
        /// cross region replica that supports replica(s) under it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cascadableReplica")]
        public virtual System.Nullable<bool> CascadableReplica { get; set; }

        /// <summary>
        /// Specifies if the replica is the failover target. If the field is set to `true` the replica will be
        /// designated as a failover replica. In case the primary instance fails, the replica instance will be promoted
        /// as the new primary instance. Only one replica can be specified as failover target, and the replica has to be
        /// in different zone with the primary instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverTarget")]
        public virtual System.Nullable<bool> FailoverTarget { get; set; }

        /// <summary>This is always `sql#replicaConfiguration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// MySQL specific configuration when replicating from a MySQL on-premises primary instance. Replication
        /// configuration information such as the username, password, certificates, and keys are not stored in the
        /// instance metadata. The configuration information is used only to set up the replication connection and is
        /// stored by MySQL in a file named `master.info` in the data directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlReplicaConfiguration")]
        public virtual MySqlReplicaConfiguration MysqlReplicaConfiguration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A primary instance and disaster recovery (DR) replica pair. A DR replica is a cross-region replica that you
    /// designate for failover in the event that the primary instance has regional failure. Applicable to MySQL and
    /// PostgreSQL.
    /// </summary>
    public class ReplicationCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Read-only field that indicates whether the replica is a DR replica. This field is not set if
        /// the instance is a primary instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drReplica")]
        public virtual System.Nullable<bool> DrReplica { get; set; }

        /// <summary>
        /// Optional. If the instance is a primary instance, then this field identifies the disaster recovery (DR)
        /// replica. A DR replica is an optional configuration for Enterprise Plus edition instances. If the instance is
        /// a read replica, then the field is not set. Set this field to a replica name to designate a DR replica for a
        /// primary instance. Remove the replica name to remove the DR replica designation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverDrReplicaName")]
        public virtual string FailoverDrReplicaName { get; set; }

        /// <summary>
        /// Output only. If set, this field indicates this instance has a private service access (PSA) DNS endpoint that
        /// is pointing to the primary instance of the cluster. If this instance is the primary, then the DNS endpoint
        /// points to this instance. After a switchover or replica failover operation, this DNS endpoint points to the
        /// promoted instance. This is a read-only field, returned to the user as information. This field can exist even
        /// if a standalone instance doesn't have a DR replica yet or the DR replica is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("psaWriteEndpoint")]
        public virtual string PsaWriteEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Reschedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the reschedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rescheduleType")]
        public virtual string RescheduleType { get; set; }

        private string _scheduleTimeRaw;

        private object _scheduleTime;

        /// <summary>
        /// Optional. Timestamp when the maintenance shall be rescheduled to if reschedule_type=SPECIFIC_TIME, in [RFC
        /// 3339](https://tools.ietf.org/html/rfc3339) format, for example `2012-11-15T16:19:00.094Z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTime")]
        public virtual string ScheduleTimeRaw
        {
            get => _scheduleTimeRaw;
            set
            {
                _scheduleTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scheduleTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScheduleTimeDateTimeOffset instead.")]
        public virtual object ScheduleTime
        {
            get => _scheduleTime;
            set
            {
                _scheduleTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scheduleTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScheduleTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ScheduleTimeRaw);
            set => ScheduleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Database instance restore from backup context. Backup context contains source instance id and project id.
    /// </summary>
    public class RestoreBackupContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the backup run to restore from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRunId")]
        public virtual System.Nullable<long> BackupRunId { get; set; }

        /// <summary>The ID of the instance that the backup was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>This is always `sql#restoreBackupContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The full project ID of the source instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance rotate server CA context.</summary>
    public class RotateServerCaContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#rotateServerCaContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The fingerprint of the next version to be rotated to. If left unspecified, will be rotated to the most
        /// recently added server CA version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextVersion")]
        public virtual string NextVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance rotate server certificate context.</summary>
    public class RotateServerCertificateContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. This is always `sql#rotateServerCertificateContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Optional. The fingerprint of the next version to be rotated to. If left unspecified, will be rotated to the
        /// most recently added server certificate version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextVersion")]
        public virtual string NextVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of objects that the user selects for replication from an external source instance.</summary>
    public class SelectedObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the database to migrate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance settings.</summary>
    public class Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The activation policy specifies when the instance is activated; it is applicable only when the instance
        /// state is RUNNABLE. Valid values: * `ALWAYS`: The instance is on, and remains so even in the absence of
        /// connection requests. * `NEVER`: The instance is off; it is not activated, even if a connection request
        /// arrives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationPolicy")]
        public virtual string ActivationPolicy { get; set; }

        /// <summary>Active Directory configuration, relevant only for Cloud SQL for SQL Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDirectoryConfig")]
        public virtual SqlActiveDirectoryConfig ActiveDirectoryConfig { get; set; }

        /// <summary>Specifies advanced machine configuration for the instances relevant only for SQL Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedMachineFeatures")]
        public virtual AdvancedMachineFeatures AdvancedMachineFeatures { get; set; }

        /// <summary>
        /// The App Engine app IDs that can access this instance. (Deprecated) Applied to First Generation instances
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedGaeApplications")]
        public virtual System.Collections.Generic.IList<string> AuthorizedGaeApplications { get; set; }

        /// <summary>
        /// Availability type. Potential values: * `ZONAL`: The instance serves data from only one zone. Outages in that
        /// zone affect data accessibility. * `REGIONAL`: The instance can serve data from more than one zone in a
        /// region (it is highly available)./ For more information, see [Overview of the High Availability
        /// Configuration](https://cloud.google.com/sql/docs/mysql/high-availability).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityType")]
        public virtual string AvailabilityType { get; set; }

        /// <summary>The daily backup configuration for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfiguration")]
        public virtual BackupConfiguration BackupConfiguration { get; set; }

        /// <summary>The name of server Instance collation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>Optional. The managed connection pooling configuration for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionPoolConfig")]
        public virtual ConnectionPoolConfig ConnectionPoolConfig { get; set; }

        /// <summary>
        /// Specifies if connections must use Cloud SQL connectors. Option values include the following: `NOT_REQUIRED`
        /// (Cloud SQL instances can be connected without Cloud SQL Connectors) and `REQUIRED` (Only allow connections
        /// that use Cloud SQL Connectors) Note that using REQUIRED disables all existing authorized networks. If this
        /// field is not specified when creating a new instance, NOT_REQUIRED is used. If this field is not specified
        /// when patching or updating an existing instance, it is left unchanged in the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorEnforcement")]
        public virtual string ConnectorEnforcement { get; set; }

        /// <summary>
        /// Configuration specific to read replica instances. Indicates whether database flags for crash-safe
        /// replication are enabled. This property was only applicable to First Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashSafeReplicationEnabled")]
        public virtual System.Nullable<bool> CrashSafeReplicationEnabled { get; set; }

        /// <summary>Configuration for data cache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCacheConfig")]
        public virtual DataCacheConfig DataCacheConfig { get; set; }

        /// <summary>
        /// Optional. Provisioned number of I/O operations per second for the data disk. This field is only used for
        /// hyperdisk-balanced disk types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskProvisionedIops")]
        public virtual System.Nullable<long> DataDiskProvisionedIops { get; set; }

        /// <summary>
        /// Optional. Provisioned throughput measured in MiB per second for the data disk. This field is only used for
        /// hyperdisk-balanced disk types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskProvisionedThroughput")]
        public virtual System.Nullable<long> DataDiskProvisionedThroughput { get; set; }

        /// <summary>The size of data disk, in GB. The data disk size minimum is 10GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskSizeGb")]
        public virtual System.Nullable<long> DataDiskSizeGb { get; set; }

        /// <summary>
        /// The type of data disk: `PD_SSD` (default) or `PD_HDD`. Not used for First Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskType")]
        public virtual string DataDiskType { get; set; }

        /// <summary>The database flags passed to the instance at startup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseFlags")]
        public virtual System.Collections.Generic.IList<DatabaseFlags> DatabaseFlags { get; set; }

        /// <summary>
        /// Configuration specific to read replica instances. Indicates whether replication is enabled or not. WARNING:
        /// Changing this restarts the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseReplicationEnabled")]
        public virtual System.Nullable<bool> DatabaseReplicationEnabled { get; set; }

        /// <summary>Configuration to protect against accidental instance deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtectionEnabled")]
        public virtual System.Nullable<bool> DeletionProtectionEnabled { get; set; }

        /// <summary>Deny maintenance periods</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyMaintenancePeriods")]
        public virtual System.Collections.Generic.IList<DenyMaintenancePeriod> DenyMaintenancePeriods { get; set; }

        /// <summary>Optional. The edition of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>
        /// Optional. By default, Cloud SQL instances have schema extraction disabled for Dataplex. When this parameter
        /// is set to true, schema extraction for Dataplex on Cloud SQL instances is activated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDataplexIntegration")]
        public virtual System.Nullable<bool> EnableDataplexIntegration { get; set; }

        /// <summary>
        /// Optional. When this parameter is set to true, Cloud SQL instances can connect to Vertex AI to pass requests
        /// for real-time predictions and insights to the AI. The default value is false. This applies only to Cloud SQL
        /// for MySQL and Cloud SQL for PostgreSQL instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableGoogleMlIntegration")]
        public virtual System.Nullable<bool> EnableGoogleMlIntegration { get; set; }

        /// <summary>Insights configuration, for now relevant only for Postgres.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insightsConfig")]
        public virtual InsightsConfig InsightsConfig { get; set; }

        /// <summary>
        /// The settings for IP Management. This allows to enable or disable the instance IP and manage which external
        /// networks can connect to the instance. The IPv4 address cannot be disabled for Second Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipConfiguration")]
        public virtual IpConfiguration IpConfiguration { get; set; }

        /// <summary>This is always `sql#settings`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The location preference settings. This allows the instance to be located as near as possible to either an
        /// App Engine app or Compute Engine zone for better performance. App Engine co-location was only applicable to
        /// First Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationPreference")]
        public virtual LocationPreference LocationPreference { get; set; }

        /// <summary>
        /// The maintenance window for this instance. This specifies when the instance can be restarted for maintenance
        /// purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>The local user password validation policy of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordValidationPolicy")]
        public virtual PasswordValidationPolicy PasswordValidationPolicy { get; set; }

        /// <summary>
        /// The pricing plan for this instance. This can be either `PER_USE` or `PACKAGE`. Only `PER_USE` is supported
        /// for Second Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingPlan")]
        public virtual string PricingPlan { get; set; }

        /// <summary>Optional. Configuration value for recreation of replica after certain replication lag</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationLagMaxSeconds")]
        public virtual System.Nullable<int> ReplicationLagMaxSeconds { get; set; }

        /// <summary>
        /// The type of replication this instance uses. This can be either `ASYNCHRONOUS` or `SYNCHRONOUS`. (Deprecated)
        /// This property was only applicable to First Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationType")]
        public virtual string ReplicationType { get; set; }

        /// <summary>
        /// Optional. When this parameter is set to true, Cloud SQL retains backups of the instance even after the
        /// instance is deleted. The ON_DEMAND backup will be retained until customer deletes the backup or the project.
        /// The AUTOMATED backup will be retained based on the backups retention setting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainBackupsOnDelete")]
        public virtual System.Nullable<bool> RetainBackupsOnDelete { get; set; }

        /// <summary>
        /// The version of instance settings. This is a required field for update method to make sure concurrent updates
        /// are handled properly. During update, use the most recent settingsVersion value for this instance and do not
        /// try to update this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settingsVersion")]
        public virtual System.Nullable<long> SettingsVersion { get; set; }

        /// <summary>SQL Server specific audit configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlServerAuditConfig")]
        public virtual SqlServerAuditConfig SqlServerAuditConfig { get; set; }

        /// <summary>Configuration to increase storage size automatically. The default value is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageAutoResize")]
        public virtual System.Nullable<bool> StorageAutoResize { get; set; }

        /// <summary>
        /// The maximum size to which storage capacity can be automatically increased. The default value is 0, which
        /// specifies that there is no limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageAutoResizeLimit")]
        public virtual System.Nullable<long> StorageAutoResizeLimit { get; set; }

        /// <summary>
        /// The tier (or machine type) for this instance, for example `db-custom-1-3840`. WARNING: Changing this
        /// restarts the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>Server timezone, relevant only for Cloud SQL for SQL Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// User-provided labels, represented as a dictionary where each label is a single key value pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Active Directory configuration, relevant only for Cloud SQL for SQL Server.</summary>
    public class SqlActiveDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the domain (e.g., mydomain.com).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>This is always sql#activeDirectoryConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>External primary instance migration setting error/warning.</summary>
    public class SqlExternalSyncSettingError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the error encountered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>Can be `sql#externalSyncSettingError` or `sql#externalSyncSettingWarning`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Identifies the specific error that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Acquire SSRS lease response.</summary>
    public class SqlInstancesAcquireSsrsLeaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier for this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance get disk shrink config response.</summary>
    public class SqlInstancesGetDiskShrinkConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#getDiskShrinkConfig`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Additional message to customers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The minimum size to which a disk can be shrunk in GigaBytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimalTargetSizeGb")]
        public virtual System.Nullable<long> MinimalTargetSizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance get latest recovery time response.</summary>
    public class SqlInstancesGetLatestRecoveryTimeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#getLatestRecoveryTime`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        private string _latestRecoveryTimeRaw;

        private object _latestRecoveryTime;

        /// <summary>Timestamp, identifies the latest recovery time of the source instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRecoveryTime")]
        public virtual string LatestRecoveryTimeRaw
        {
            get => _latestRecoveryTimeRaw;
            set
            {
                _latestRecoveryTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestRecoveryTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestRecoveryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestRecoveryTimeDateTimeOffset instead.")]
        public virtual object LatestRecoveryTime
        {
            get => _latestRecoveryTime;
            set
            {
                _latestRecoveryTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestRecoveryTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestRecoveryTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestRecoveryTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestRecoveryTimeRaw);
            set => LatestRecoveryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for the release of the SSRS lease.</summary>
    public class SqlInstancesReleaseSsrsLeaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operation ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reschedule options for maintenance windows.</summary>
    public class SqlInstancesRescheduleMaintenanceRequestBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the reschedule the user wants.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reschedule")]
        public virtual Reschedule Reschedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance reset replica size request.</summary>
    public class SqlInstancesResetReplicaSizeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SqlInstancesStartExternalSyncRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. MigrationType configures the migration to use physical files or logical dump files. If not set,
        /// then the logical dump file configuration is used. Valid values are `LOGICAL` or `PHYSICAL`. Only applicable
        /// to MySQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationType")]
        public virtual string MigrationType { get; set; }

        /// <summary>MySQL-specific settings for start external sync.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlSyncConfig")]
        public virtual MySqlSyncConfig MysqlSyncConfig { get; set; }

        /// <summary>Whether to skip the verification step (VESS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipVerification")]
        public virtual System.Nullable<bool> SkipVerification { get; set; }

        /// <summary>External sync mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncMode")]
        public virtual string SyncMode { get; set; }

        /// <summary>Optional. Parallel level for initial data sync. Currently only applicable for MySQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncParallelLevel")]
        public virtual string SyncParallelLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SqlInstancesVerifyExternalSyncSettingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. MigrationType configures the migration to use physical files or logical dump files. If not set,
        /// then the logical dump file configuration is used. Valid values are `LOGICAL` or `PHYSICAL`. Only applicable
        /// to MySQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationType")]
        public virtual string MigrationType { get; set; }

        /// <summary>Optional. MySQL-specific settings for start external sync.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlSyncConfig")]
        public virtual MySqlSyncConfig MysqlSyncConfig { get; set; }

        /// <summary>
        /// Optional. Migrate only the specified objects from the source instance. If this field is empty, then migrate
        /// all objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedObjects")]
        public virtual System.Collections.Generic.IList<ExternalSyncSelectedObject> SelectedObjects { get; set; }

        /// <summary>External sync mode</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncMode")]
        public virtual string SyncMode { get; set; }

        /// <summary>Optional. Parallel level for initial data sync. Only applicable for PostgreSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncParallelLevel")]
        public virtual string SyncParallelLevel { get; set; }

        /// <summary>Flag to enable verifying connection only</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyConnectionOnly")]
        public virtual System.Nullable<bool> VerifyConnectionOnly { get; set; }

        /// <summary>Optional. Flag to verify settings required by replication setup only</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyReplicationOnly")]
        public virtual System.Nullable<bool> VerifyReplicationOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance verify external sync settings response.</summary>
    public class SqlInstancesVerifyExternalSyncSettingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of migration violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<SqlExternalSyncSettingError> Errors { get; set; }

        /// <summary>This is always `sql#migrationSettingErrorList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>List of migration warnings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<SqlExternalSyncSettingError> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message wraps up the information written by out-of-disk detection job.</summary>
    public class SqlOutOfDiskReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum recommended increase size in GigaBytes This field is consumed by the frontend * Writers: * the
        /// proactive database wellness job for OOD. * Readers:
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlMinRecommendedIncreaseSizeGb")]
        public virtual System.Nullable<int> SqlMinRecommendedIncreaseSizeGb { get; set; }

        /// <summary>
        /// This field represents the state generated by the proactive database wellness job for OutOfDisk issues. *
        /// Writers: * the proactive database wellness job for OOD. * Readers: * the proactive database wellness job
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlOutOfDiskState")]
        public virtual string SqlOutOfDiskState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Any scheduled maintenance for this instance.</summary>
    public class SqlScheduledMaintenance : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("canDefer")]
        public virtual System.Nullable<bool> CanDefer { get; set; }

        /// <summary>If the scheduled maintenance can be rescheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReschedule")]
        public virtual System.Nullable<bool> CanReschedule { get; set; }

        private string _scheduleDeadlineTimeRaw;

        private object _scheduleDeadlineTime;

        /// <summary>Maintenance cannot be rescheduled to start beyond this deadline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleDeadlineTime")]
        public virtual string ScheduleDeadlineTimeRaw
        {
            get => _scheduleDeadlineTimeRaw;
            set
            {
                _scheduleDeadlineTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scheduleDeadlineTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScheduleDeadlineTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScheduleDeadlineTimeDateTimeOffset instead.")]
        public virtual object ScheduleDeadlineTime
        {
            get => _scheduleDeadlineTime;
            set
            {
                _scheduleDeadlineTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scheduleDeadlineTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ScheduleDeadlineTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScheduleDeadlineTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ScheduleDeadlineTimeRaw);
            set => ScheduleDeadlineTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The start time of any upcoming scheduled maintenance for this instance.</summary>
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

    /// <summary>SQL Server specific audit configuration.</summary>
    public class SqlServerAuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the destination bucket (e.g., gs://mybucket).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>This is always sql#sqlServerAuditConfig</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>How long to keep generated audit files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionInterval")]
        public virtual object RetentionInterval { get; set; }

        /// <summary>How often to upload generated audit files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadInterval")]
        public virtual object UploadInterval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Sql Server database on the Cloud SQL instance.</summary>
    public class SqlServerDatabaseDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The version of SQL Server with which the database is to be made compatible</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compatibilityLevel")]
        public virtual System.Nullable<int> CompatibilityLevel { get; set; }

        /// <summary>The recovery model of a SQL Server database</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryModel")]
        public virtual string RecoveryModel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Sql Server user on the Cloud SQL instance.</summary>
    public class SqlServerUserDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the user has been disabled</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The server roles for this user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverRoles")]
        public virtual System.Collections.Generic.IList<string> ServerRoles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The sub operation type based on the operation type.</summary>
    public class SqlSubOperationType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of maintenance to be performed on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceType")]
        public virtual string MaintenanceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCerts Resource</summary>
    public class SslCert : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cert")]
        public virtual string Cert { get; set; }

        /// <summary>Serial number, as extracted from the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certSerialNumber")]
        public virtual string CertSerialNumber { get; set; }

        /// <summary>User supplied name. Constrained to [a-zA-Z.-_ ]+.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonName")]
        public virtual string CommonName { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// The time when the certificate was created in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for
        /// example `2012-11-15T16:19:00.094Z`.
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

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// The time when the certificate expires in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for example
        /// `2012-11-15T16:19:00.094Z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Name of the database instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>This is always `sql#sslCert`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The URI of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Sha1 Fingerprint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Fingerprint")]
        public virtual string Sha1Fingerprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCertDetail.</summary>
    public class SslCertDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The public information about the cert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certInfo")]
        public virtual SslCert CertInfo { get; set; }

        /// <summary>
        /// The private key for the client cert, in pem format. Keep private in order to protect your security.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certPrivateKey")]
        public virtual string CertPrivateKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCerts create ephemeral certificate request.</summary>
    public class SslCertsCreateEphemeralRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access token to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
        public virtual string AccessToken { get; set; }

        /// <summary>PEM encoded public key to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("public_key")]
        public virtual string PublicKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCerts insert request.</summary>
    public class SslCertsInsertRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User supplied name. Must be a distinct name from the other certificates for this instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonName")]
        public virtual string CommonName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCert insert response.</summary>
    public class SslCertsInsertResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new client certificate and private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCert")]
        public virtual SslCertDetail ClientCert { get; set; }

        /// <summary>This is always `sql#sslCertsInsert`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The operation to track the ssl certs insert request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>
        /// The server Certificate Authority's certificate. If this is missing you can force a new one to be generated
        /// by calling resetSslConfig method on instances resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaCert")]
        public virtual SslCert ServerCaCert { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCerts list response.</summary>
    public class SslCertsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of client certificates for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<SslCert> Items { get; set; }

        /// <summary>This is always `sql#sslCertsList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Initial sync flags for certain Cloud SQL APIs. Currently used for the MySQL external server initial dump.
    /// </summary>
    public class SyncFlags : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The value of the flag. This field must be omitted if the flag doesn't take a value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Google Cloud SQL service tier resource.</summary>
    public class Tier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum disk size of this tier in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("DiskQuota")]
        public virtual System.Nullable<long> DiskQuota { get; set; }

        /// <summary>The maximum RAM usage of this tier in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("RAM")]
        public virtual System.Nullable<long> RAM { get; set; }

        /// <summary>This is always `sql#tier`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The applicable regions for this tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual System.Collections.Generic.IList<string> Region { get; set; }

        /// <summary>
        /// An identifier for the machine type, for example, `db-custom-1-3840`. For related information, see
        /// [Pricing](/sql/pricing).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string TierValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tiers list response.</summary>
    public class TiersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of tiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Tier> Items { get; set; }

        /// <summary>This is always `sql#tiersList`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database Instance truncate log context.</summary>
    public class TruncateLogContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always `sql#truncateLogContext`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The type of log to truncate. Valid values are `MYSQL_GENERAL_TABLE` and `MYSQL_SLOW_TABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud SQL user resource.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dual password status for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dualPasswordType")]
        public virtual string DualPasswordType { get; set; }

        /// <summary>This field is deprecated and will be removed from a future version of the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The host from which the user can connect. For `insert` operations, host defaults to an empty
        /// string. For `update` operations, host is specified as part of the request URL. The host name cannot be
        /// updated after insertion. For a MySQL instance, it's required; for a PostgreSQL or SQL Server instance, it's
        /// optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// The name of the Cloud SQL instance. This does not include the project ID. Can be omitted for *update*
        /// because it is already specified on the URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>This is always `sql#user`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name of the user in the Cloud SQL instance. Can be omitted for `update` because it is already specified
        /// in the URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The password for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>User level password validation policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordPolicy")]
        public virtual UserPasswordValidationPolicy PasswordPolicy { get; set; }

        /// <summary>
        /// The project ID of the project containing the Cloud SQL database. The Google apps domain is prefixed if
        /// applicable. Can be omitted for *update* because it is already specified on the URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sqlserverUserDetails")]
        public virtual SqlServerUserDetails SqlserverUserDetails { get; set; }

        /// <summary>
        /// The user type. It determines the method to authenticate the user during login. The default is the database's
        /// built-in user type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }
    }

    /// <summary>User level password validation policy.</summary>
    public class UserPasswordValidationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of failed login attempts allowed before user get locked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedFailedAttempts")]
        public virtual System.Nullable<int> AllowedFailedAttempts { get; set; }

        /// <summary>If true, failed login attempts check will be enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFailedAttemptsCheck")]
        public virtual System.Nullable<bool> EnableFailedAttemptsCheck { get; set; }

        /// <summary>
        /// If true, the user must specify the current password before changing the password. This flag is supported
        /// only for MySQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePasswordVerification")]
        public virtual System.Nullable<bool> EnablePasswordVerification { get; set; }

        /// <summary>Expiration duration after password is updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordExpirationDuration")]
        public virtual object PasswordExpirationDuration { get; set; }

        /// <summary>Output only. Read-only password status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual PasswordStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User list response.</summary>
    public class UsersListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of user resources in the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<User> Items { get; set; }

        /// <summary>This is always *sql#usersList*.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
