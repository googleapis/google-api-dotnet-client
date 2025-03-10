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

namespace Google.Apis.DataprocMetastore.v2alpha
{
    /// <summary>The DataprocMetastore Service.</summary>
    public class DataprocMetastoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataprocMetastoreService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataprocMetastoreService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://metastore.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://metastore.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "metastore";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Dataproc Metastore API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Dataproc Metastore API.</summary>
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

    /// <summary>A base abstract class for DataprocMetastore requests.</summary>
    public abstract class DataprocMetastoreBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataprocMetastoreBaseServiceRequest instance.</summary>
        protected DataprocMetastoreBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DataprocMetastore parameter list.</summary>
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
                Services = new ServicesResource(service);
            }

            /// <summary>Gets the Services resource.</summary>
            public virtual ServicesResource Services { get; }

            /// <summary>The "services" collection of methods.</summary>
            public class ServicesResource
            {
                private const string Resource = "services";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServicesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Backups = new BackupsResource(service);
                    MigrationExecutions = new MigrationExecutionsResource(service);
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

                    /// <summary>Creates a new backup in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service in which to create a backup of the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaBackup body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new backup in a given project and location.</summary>
                    public class CreateRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaBackup body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service in which to create a backup of the
                        /// following form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the backup, which is used as the final component of the backup's
                        /// name.This value must be between 1 and 64 characters long, begin with a letter, end with a
                        /// letter or number, and consist of alpha-numeric ASCII characters or hyphens.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string BackupId { get; set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaBackup Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                            });
                            RequestParameters.Add("backupId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "backupId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single backup.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the backup to delete, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single backup.</summary>
                    public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the backup to delete, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/backups/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of a single backup.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the backup to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single backup.</summary>
                    public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaBackup>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the backup to retrieve, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists backups in a service.</summary>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service whose backups to list, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists backups in a service.</summary>
                    public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaListBackupsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service whose backups to list, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify the ordering of results as described in Sorting Order
                        /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                        /// results will be sorted in the default order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of backups to return. The response may contain less than the
                        /// maximum number. If unspecified, no more than 500 backups are returned. The maximum value is
                        /// 1000; values above 1000 are changed to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous DataprocMetastore.ListBackups call. Provide
                        /// this token to retrieve the subsequent page.To retrieve the first page, supply an empty page
                        /// token.When paginating, other parameters provided to DataprocMetastore.ListBackups must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                }

                /// <summary>Gets the MigrationExecutions resource.</summary>
                public virtual MigrationExecutionsResource MigrationExecutions { get; }

                /// <summary>The "migrationExecutions" collection of methods.</summary>
                public class MigrationExecutionsResource
                {
                    private const string Resource = "migrationExecutions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MigrationExecutionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a single migration execution.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the migrationExecution to delete, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single migration execution.</summary>
                    public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the migrationExecution to delete, in the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the
                        /// request if it has completed. The server will ignore subsequent requests that provide a
                        /// duplicate request ID for at least 60 minutes after the first request.For example, if an
                        /// initial request times out, followed by another request with the same request ID, the server
                        /// ignores the second request to prevent the creation of duplicate commitments.The request ID
                        /// must be a valid UUID (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A
                        /// zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/migrationExecutions/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of a single migration execution.</summary>
                    /// <param name="name">
                    /// Required. The relative resource name of the migration execution to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single migration execution.</summary>
                    public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaMigrationExecution>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the migration execution to retrieve, in the
                        /// following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/migrationExecutions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists migration executions on a service.</summary>
                    /// <param name="parent">
                    /// Required. The relative resource name of the service whose migration executions to list, in the
                    /// following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists migration executions on a service.</summary>
                    public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaListMigrationExecutionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The relative resource name of the service whose migration executions to list, in
                        /// the following
                        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify the ordering of results as described in Sorting Order
                        /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                        /// results will be sorted in the default order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of migration executions to return. The response may contain
                        /// less than the maximum number. If unspecified, no more than 500 migration executions are
                        /// returned. The maximum value is 1000; values above 1000 are changed to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous DataprocMetastore.ListMigrationExecutions
                        /// call. Provide this token to retrieve the subsequent page.To retrieve the first page, supply
                        /// an empty page token.When paginating, other parameters provided to
                        /// DataprocMetastore.ListMigrationExecutions must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2alpha/{+parent}/migrationExecutions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                }

                /// <summary>
                /// Alter metadata resource location. The metadata resource can be a database, table, or partition. This
                /// functionality only updates the parent directory for the respective metadata resource and does not
                /// transfer any existing data to the new location.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to mutate metadata, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual AlterLocationRequest AlterLocation(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaAlterMetadataResourceLocationRequest body, string service)
                {
                    return new AlterLocationRequest(this.service, body, service);
                }

                /// <summary>
                /// Alter metadata resource location. The metadata resource can be a database, table, or partition. This
                /// functionality only updates the parent directory for the respective metadata resource and does not
                /// transfer any existing data to the new location.
                /// </summary>
                public class AlterLocationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new AlterLocation request.</summary>
                    public AlterLocationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaAlterMetadataResourceLocationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to mutate metadata, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaAlterMetadataResourceLocationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "alterLocation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:alterLocation";

                    /// <summary>Initializes AlterLocation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Alter metadata table properties.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the Dataproc Metastore service that's being used to mutate
                /// metadata table properties, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual AlterTablePropertiesRequest AlterTableProperties(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaAlterTablePropertiesRequest body, string service)
                {
                    return new AlterTablePropertiesRequest(this.service, body, service);
                }

                /// <summary>Alter metadata table properties.</summary>
                public class AlterTablePropertiesRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new AlterTableProperties request.</summary>
                    public AlterTablePropertiesRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaAlterTablePropertiesRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the Dataproc Metastore service that's being used to
                    /// mutate metadata table properties, in the following
                    /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaAlterTablePropertiesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "alterTableProperties";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:alterTableProperties";

                    /// <summary>Initializes AlterTableProperties parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Cancels the ongoing Managed Migration process.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to cancel the ongoing migration to, in
                /// the following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual CancelMigrationRequest CancelMigration(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaCancelMigrationRequest body, string service)
                {
                    return new CancelMigrationRequest(this.service, body, service);
                }

                /// <summary>Cancels the ongoing Managed Migration process.</summary>
                public class CancelMigrationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new CancelMigration request.</summary>
                    public CancelMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaCancelMigrationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to cancel the ongoing migration
                    /// to, in the following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaCancelMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancelMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:cancelMigration";

                    /// <summary>Initializes CancelMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Completes the managed migration process. The Dataproc Metastore service will switch to using its own
                /// backend database after successful migration.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to complete the migration to, in the
                /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual CompleteMigrationRequest CompleteMigration(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaCompleteMigrationRequest body, string service)
                {
                    return new CompleteMigrationRequest(this.service, body, service);
                }

                /// <summary>
                /// Completes the managed migration process. The Dataproc Metastore service will switch to using its own
                /// backend database after successful migration.
                /// </summary>
                public class CompleteMigrationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new CompleteMigration request.</summary>
                    public CompleteMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaCompleteMigrationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to complete the migration to, in
                    /// the following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaCompleteMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "completeMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:completeMigration";

                    /// <summary>Initializes CompleteMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a metastore service in a project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The relative resource name of the location in which to create a metastore service, in the
                /// following form:projects/{project_number}/locations/{location_id}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaService body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a metastore service in a project and location.</summary>
                public class CreateRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaService body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the location in which to create a metastore service, in
                    /// the following form:projects/{project_number}/locations/{location_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. The ID of the metastore service, which is used as the final component of the metastore
                    /// service's name.This value must be between 2 and 63 characters long inclusive, begin with a
                    /// letter, end with a letter or number, and consist of alpha-numeric ASCII characters or hyphens.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaService Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+parent}/services";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("serviceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single service.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the metastore service to delete, in the following
                /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single service.</summary>
                public class DeleteRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to delete, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Exports metadata from a service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to run export, in the following
                /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual ExportMetadataRequest ExportMetadata(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaExportMetadataRequest body, string service)
                {
                    return new ExportMetadataRequest(this.service, body, service);
                }

                /// <summary>Exports metadata from a service.</summary>
                public class ExportMetadataRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new ExportMetadata request.</summary>
                    public ExportMetadataRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaExportMetadataRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to run export, in the following
                    /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaExportMetadataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exportMetadata";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:exportMetadata";

                    /// <summary>Initializes ExportMetadata parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a single service.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the metastore service to retrieve, in the following
                /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a single service.</summary>
                public class GetRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaService>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to retrieve, in the following
                    /// form:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Imports Metadata into a Dataproc Metastore service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The relative resource name of the metastore service to run import, in the following
                /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual ImportMetadataRequest ImportMetadata(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaImportMetadataRequest body, string name)
                {
                    return new ImportMetadataRequest(this.service, body, name);
                }

                /// <summary>Imports Metadata into a Dataproc Metastore service.</summary>
                public class ImportMetadataRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new ImportMetadata request.</summary>
                    public ImportMetadataRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaImportMetadataRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The relative resource name of the metastore service to run import, in the following
                    /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaImportMetadataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "importMetadata";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}:importMetadata";

                    /// <summary>Initializes ImportMetadata parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists services in a project and location.</summary>
                /// <param name="parent">
                /// Required. The relative resource name of the location of metastore services to list, in the following
                /// form:projects/{project_number}/locations/{location_id}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists services in a project and location.</summary>
                public class ListRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaListServicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the location of metastore services to list, in the
                    /// following form:projects/{project_number}/locations/{location_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter to apply to list results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specify the ordering of results as described in Sorting Order
                    /// (https://cloud.google.com/apis/design/design_patterns#sorting_order). If not specified, the
                    /// results will be sorted in the default order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of services to return. The response may contain less than the
                    /// maximum number. If unspecified, no more than 500 services are returned. The maximum value is
                    /// 1000; values above 1000 are changed to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous DataprocMetastore.ListServices call. Provide
                    /// this token to retrieve the subsequent page.To retrieve the first page, supply an empty page
                    /// token.When paginating, other parameters provided to DataprocMetastore.ListServices must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+parent}/services";

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

                /// <summary>Move a table to another database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to mutate metadata, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual MoveTableToDatabaseRequest MoveTableToDatabase(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaMoveTableToDatabaseRequest body, string service)
                {
                    return new MoveTableToDatabaseRequest(this.service, body, service);
                }

                /// <summary>Move a table to another database.</summary>
                public class MoveTableToDatabaseRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new MoveTableToDatabase request.</summary>
                    public MoveTableToDatabaseRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaMoveTableToDatabaseRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to mutate metadata, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaMoveTableToDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "moveTableToDatabase";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:moveTableToDatabase";

                    /// <summary>Initializes MoveTableToDatabase parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the parameters of a single service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The relative resource name of the metastore service, in the following
                /// format:projects/{project_number}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaService body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single service.</summary>
                public class PatchRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaService body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The relative resource name of the metastore service, in the following
                    /// format:projects/{project_number}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if
                    /// it has completed. The server will ignore subsequent requests that provide a duplicate request ID
                    /// for at least 60 minutes after the first request.For example, if an initial request times out,
                    /// followed by another request with the same request ID, the server ignores the second request to
                    /// prevent the creation of duplicate commitments.The request ID must be a valid UUID
                    /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
                    /// (00000000-0000-0000-0000-000000000000) is not supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. A field mask used to specify the fields to be overwritten in the metastore service
                    /// resource by the update. Fields specified in the update_mask are relative to the resource (not to
                    /// the full request). A field is overwritten if it is in the mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaService Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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

                /// <summary>Query Dataproc Metastore metadata.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to query metadata, in the following
                /// format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual QueryMetadataRequest QueryMetadata(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaQueryMetadataRequest body, string service)
                {
                    return new QueryMetadataRequest(this.service, body, service);
                }

                /// <summary>Query Dataproc Metastore metadata.</summary>
                public class QueryMetadataRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new QueryMetadata request.</summary>
                    public QueryMetadataRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaQueryMetadataRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to query metadata, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaQueryMetadataRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "queryMetadata";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:queryMetadata";

                    /// <summary>Initializes QueryMetadata parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Removes the attached IAM policies for a resource</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// Required. The relative resource name of the dataplane resource to remove IAM policy, in the
                /// following
                /// form:projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id} or
                /// projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id}/tables/{table_id}.
                /// </param>
                public virtual RemoveIamPolicyRequest RemoveIamPolicy(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaRemoveIamPolicyRequest body, string resource)
                {
                    return new RemoveIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Removes the attached IAM policies for a resource</summary>
                public class RemoveIamPolicyRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaRemoveIamPolicyResponse>
                {
                    /// <summary>Constructs a new RemoveIamPolicy request.</summary>
                    public RemoveIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaRemoveIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the dataplane resource to remove IAM policy, in the
                    /// following
                    /// form:projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id}
                    /// or
                    /// projects/{project_id}/locations/{location_id}/services/{service_id}/databases/{database_id}/tables/{table_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaRemoveIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+resource}:removeIamPolicy";

                    /// <summary>Initializes RemoveIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/.*$",
                        });
                    }
                }

                /// <summary>Restores a service from a backup.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to run restore, in the following
                /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaRestoreServiceRequest body, string service)
                {
                    return new RestoreRequest(this.service, body, service);
                }

                /// <summary>Restores a service from a backup.</summary>
                public class RestoreRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaRestoreServiceRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to run restore, in the following
                    /// form:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaRestoreServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:restore";

                    /// <summary>Initializes Restore parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts the Managed Migration process.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="service">
                /// Required. The relative resource name of the metastore service to start migrating to, in the
                /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                /// </param>
                public virtual StartMigrationRequest StartMigration(Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaStartMigrationRequest body, string service)
                {
                    return new StartMigrationRequest(this.service, body, service);
                }

                /// <summary>Starts the Managed Migration process.</summary>
                public class StartMigrationRequest : DataprocMetastoreBaseServiceRequest<Google.Apis.DataprocMetastore.v2alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new StartMigration request.</summary>
                    public StartMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaStartMigrationRequest body, string service_) : base(service)
                    {
                        Service_ = service_;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the metastore service to start migrating to, in the
                    /// following format:projects/{project_id}/locations/{location_id}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("service", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Service_ { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DataprocMetastore.v2alpha.Data.GoogleCloudMetastoreV2alphaStartMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "startMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2alpha/{+service}:startMigration";

                    /// <summary>Initializes StartMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("service", new Google.Apis.Discovery.Parameter
                        {
                            Name = "service",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.DataprocMetastore.v2alpha.Data
{
    /// <summary>Response message for DataprocMetastore.AlterMetadataResourceLocation.</summary>
    public class GoogleCloudMetastoreV1AlterMetadataResourceLocationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata about a custom region. This is only populated if the region is a custom region. For single/multi
    /// regions, it will be empty.
    /// </summary>
    public class GoogleCloudMetastoreV1CustomRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The read-only regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optionalReadOnlyRegions")]
        public virtual System.Collections.Generic.IList<string> OptionalReadOnlyRegions { get; set; }

        /// <summary>The read-write regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredReadWriteRegions")]
        public virtual System.Collections.Generic.IList<string> RequiredReadWriteRegions { get; set; }

        /// <summary>The Spanner witness region for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details in public error message for DataprocMetastore.QueryMetadata.</summary>
    public class GoogleCloudMetastoreV1ErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional structured details about this error.Keys define the failure items. Value describes the exception
        /// or details of the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, string> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of a supported version of the Hive Metastore software.</summary>
    public class GoogleCloudMetastoreV1HiveMetastoreVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether version will be chosen by the server if a metastore service is created with a HiveMetastoreConfig
        /// that omits the version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The semantic version of the Hive Metastore software.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the service in a location.</summary>
    public class GoogleCloudMetastoreV1LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Possible configurations supported if the current region is a custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRegionMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV1CustomRegionMetadata> CustomRegionMetadata { get; set; }

        /// <summary>The multi-region metadata if the current region is a multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionMetadata")]
        public virtual GoogleCloudMetastoreV1MultiRegionMetadata MultiRegionMetadata { get; set; }

        /// <summary>
        /// The versions of Hive Metastore that can be used when creating a new metastore service in this location. The
        /// server guarantees that exactly one HiveMetastoreVersion in the list will set is_default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedHiveMetastoreVersions")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV1HiveMetastoreVersion> SupportedHiveMetastoreVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.MoveTableToDatabase.</summary>
    public class GoogleCloudMetastoreV1MoveTableToDatabaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The metadata for the multi-region that includes the constituent regions. The metadata is only populated if the
    /// region is multi-region. For single region or custom dual region, it will be empty.
    /// </summary>
    public class GoogleCloudMetastoreV1MultiRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The regions constituting the multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constituentRegions")]
        public virtual System.Collections.Generic.IList<string> ConstituentRegions { get; set; }

        /// <summary>The continent for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continent")]
        public virtual string Continent { get; set; }

        /// <summary>The Spanner witness region for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of a long-running operation.</summary>
    public class GoogleCloudMetastoreV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

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

        /// <summary>
        /// Output only. Identifies whether the caller has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to Code.CANCELLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.QueryMetadata.</summary>
    public class GoogleCloudMetastoreV1QueryMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The manifest URI is link to a JSON instance in Cloud Storage. This instance manifests immediately along with
        /// QueryMetadataResponse. The content of the URI is not retriable until the long-running operation query
        /// against the metadata finishes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultManifestUri")]
        public virtual string ResultManifestUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.AlterMetadataResourceLocation.</summary>
    public class GoogleCloudMetastoreV1alphaAlterMetadataResourceLocationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.CancelMigration.</summary>
    public class GoogleCloudMetastoreV1alphaCancelMigrationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative resource name of the migration execution, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual string MigrationExecution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.CompleteMigration.</summary>
    public class GoogleCloudMetastoreV1alphaCompleteMigrationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative resource name of the migration execution, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual string MigrationExecution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata about a custom region. This is only populated if the region is a custom region. For single/multi
    /// regions, it will be empty.
    /// </summary>
    public class GoogleCloudMetastoreV1alphaCustomRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The read-only regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optionalReadOnlyRegions")]
        public virtual System.Collections.Generic.IList<string> OptionalReadOnlyRegions { get; set; }

        /// <summary>The read-write regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredReadWriteRegions")]
        public virtual System.Collections.Generic.IList<string> RequiredReadWriteRegions { get; set; }

        /// <summary>The Spanner witness region for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details in public error message for DataprocMetastore.QueryMetadata.</summary>
    public class GoogleCloudMetastoreV1alphaErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional structured details about this error.Keys define the failure items. Value describes the exception
        /// or details of the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, string> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of a supported version of the Hive Metastore software.</summary>
    public class GoogleCloudMetastoreV1alphaHiveMetastoreVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether version will be chosen by the server if a metastore service is created with a HiveMetastoreConfig
        /// that omits the version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The semantic version of the Hive Metastore software.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the service in a location.</summary>
    public class GoogleCloudMetastoreV1alphaLocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Possible configurations supported if the current region is a custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRegionMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV1alphaCustomRegionMetadata> CustomRegionMetadata { get; set; }

        /// <summary>The multi-region metadata if the current region is a multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionMetadata")]
        public virtual GoogleCloudMetastoreV1alphaMultiRegionMetadata MultiRegionMetadata { get; set; }

        /// <summary>
        /// The versions of Hive Metastore that can be used when creating a new metastore service in this location. The
        /// server guarantees that exactly one HiveMetastoreVersion in the list will set is_default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedHiveMetastoreVersions")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV1alphaHiveMetastoreVersion> SupportedHiveMetastoreVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.MoveTableToDatabase.</summary>
    public class GoogleCloudMetastoreV1alphaMoveTableToDatabaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The metadata for the multi-region that includes the constituent regions. The metadata is only populated if the
    /// region is multi-region. For single region or custom dual region, it will be empty.
    /// </summary>
    public class GoogleCloudMetastoreV1alphaMultiRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The regions constituting the multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constituentRegions")]
        public virtual System.Collections.Generic.IList<string> ConstituentRegions { get; set; }

        /// <summary>The continent for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continent")]
        public virtual string Continent { get; set; }

        /// <summary>The Spanner witness region for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of a long-running operation.</summary>
    public class GoogleCloudMetastoreV1alphaOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

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

        /// <summary>
        /// Output only. Identifies whether the caller has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to Code.CANCELLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.QueryMetadata.</summary>
    public class GoogleCloudMetastoreV1alphaQueryMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The manifest URI is link to a JSON instance in Cloud Storage. This instance manifests immediately along with
        /// QueryMetadataResponse. The content of the URI is not retriable until the long-running operation query
        /// against the metadata finishes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultManifestUri")]
        public virtual string ResultManifestUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.AlterMetadataResourceLocation.</summary>
    public class GoogleCloudMetastoreV1betaAlterMetadataResourceLocationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.CancelMigration.</summary>
    public class GoogleCloudMetastoreV1betaCancelMigrationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative resource name of the migration execution, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual string MigrationExecution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.CompleteMigration.</summary>
    public class GoogleCloudMetastoreV1betaCompleteMigrationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative resource name of the migration execution, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual string MigrationExecution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata about a custom region. This is only populated if the region is a custom region. For single/multi
    /// regions, it will be empty.
    /// </summary>
    public class GoogleCloudMetastoreV1betaCustomRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The read-only regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optionalReadOnlyRegions")]
        public virtual System.Collections.Generic.IList<string> OptionalReadOnlyRegions { get; set; }

        /// <summary>The read-write regions for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredReadWriteRegions")]
        public virtual System.Collections.Generic.IList<string> RequiredReadWriteRegions { get; set; }

        /// <summary>The Spanner witness region for this custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details in public error message for DataprocMetastore.QueryMetadata.</summary>
    public class GoogleCloudMetastoreV1betaErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional structured details about this error.Keys define the failure items. Value describes the exception
        /// or details of the item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, string> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of a supported version of the Hive Metastore software.</summary>
    public class GoogleCloudMetastoreV1betaHiveMetastoreVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether version will be chosen by the server if a metastore service is created with a HiveMetastoreConfig
        /// that omits the version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The semantic version of the Hive Metastore software.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the service in a location.</summary>
    public class GoogleCloudMetastoreV1betaLocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Possible configurations supported if the current region is a custom region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRegionMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV1betaCustomRegionMetadata> CustomRegionMetadata { get; set; }

        /// <summary>The multi-region metadata if the current region is a multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionMetadata")]
        public virtual GoogleCloudMetastoreV1betaMultiRegionMetadata MultiRegionMetadata { get; set; }

        /// <summary>
        /// The versions of Hive Metastore that can be used when creating a new metastore service in this location. The
        /// server guarantees that exactly one HiveMetastoreVersion in the list will set is_default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedHiveMetastoreVersions")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV1betaHiveMetastoreVersion> SupportedHiveMetastoreVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.MoveTableToDatabase.</summary>
    public class GoogleCloudMetastoreV1betaMoveTableToDatabaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The metadata for the multi-region that includes the constituent regions. The metadata is only populated if the
    /// region is multi-region. For single region or custom dual region, it will be empty.
    /// </summary>
    public class GoogleCloudMetastoreV1betaMultiRegionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The regions constituting the multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constituentRegions")]
        public virtual System.Collections.Generic.IList<string> ConstituentRegions { get; set; }

        /// <summary>The continent for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continent")]
        public virtual string Continent { get; set; }

        /// <summary>The Spanner witness region for this multi-region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessRegion")]
        public virtual string WitnessRegion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of a long-running operation.</summary>
    public class GoogleCloudMetastoreV1betaOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

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

        /// <summary>
        /// Output only. Identifies whether the caller has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to Code.CANCELLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.QueryMetadata.</summary>
    public class GoogleCloudMetastoreV1betaQueryMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The manifest URI is link to a JSON instance in Cloud Storage. This instance manifests immediately along with
        /// QueryMetadataResponse. The content of the URI is not retriable until the long-running operation query
        /// against the metadata finishes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultManifestUri")]
        public virtual string ResultManifestUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.AlterMetadataResourceLocation.</summary>
    public class GoogleCloudMetastoreV2alphaAlterMetadataResourceLocationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new location URI for the metadata resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationUri")]
        public virtual string LocationUri { get; set; }

        /// <summary>
        /// Required. The relative metadata resource name in the following format.databases/{database_id} or
        /// databases/{database_id}/tables/{table_id} or
        /// databases/{database_id}/tables/{table_id}/partitions/{partition_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.AlterTableProperties.</summary>
    public class GoogleCloudMetastoreV2alphaAlterTablePropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map that describes the desired values to mutate. If update_mask is empty, the properties will not update.
        /// Otherwise, the properties only alters the value whose associated paths exist in the update mask
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Required. The name of the table containing the properties you're altering in the following
        /// format.databases/{database_id}/tables/{table_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableName")]
        public virtual string TableName { get; set; }

        /// <summary>
        /// A field mask that specifies the metadata table properties that are overwritten by the update. Fields
        /// specified in the update_mask are relative to the resource (not to the full request). A field is overwritten
        /// if it is in the mask.For example, given the target properties: properties { a: 1 b: 2 } And an update
        /// properties: properties { a: 2 b: 3 c: 4 } then if the field mask is:paths: "properties.b",
        /// "properties.c"then the result will be: properties { a: 1 b: 3 c: 4 }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the autoscaling configuration of a metastore service.</summary>
    public class GoogleCloudMetastoreV2alphaAutoscalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether or not autoscaling is enabled for this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingEnabled")]
        public virtual System.Nullable<bool> AutoscalingEnabled { get; set; }

        /// <summary>Output only. The scaling factor of a service with autoscaling enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingFactor")]
        public virtual System.Nullable<int> AutoscalingFactor { get; set; }

        /// <summary>Optional. The LimitConfig of the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitConfig")]
        public virtual GoogleCloudMetastoreV2alphaLimitConfig LimitConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration information for the auxiliary service versions.</summary>
    public class GoogleCloudMetastoreV2alphaAuxiliaryVersionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mapping of Hive metastore configuration key-value pairs to apply to the auxiliary Hive metastore
        /// (configured in hive-site.xml) in addition to the primary version's overrides. If keys are present in both
        /// the auxiliary version's overrides and the primary version's overrides, the value from the auxiliary
        /// version's overrides takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configOverrides")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConfigOverrides { get; set; }

        /// <summary>
        /// Output only. The list of endpoints used to access the auxiliary metastore service, includes version and
        /// region data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV2alphaEndpoint> Endpoints { get; set; }

        /// <summary>
        /// The Hive metastore version of the auxiliary service. It must be less than the primary Hive metastore
        /// service's version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a backup resource.</summary>
    public class GoogleCloudMetastoreV2alphaBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the backup was started.</summary>
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

        /// <summary>The description of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time when the backup finished creating.</summary>
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
        /// Immutable. The relative resource name of the backup, in the following
        /// form:projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Services that are restoring from the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoringServices")]
        public virtual System.Collections.Generic.IList<string> RestoringServices { get; set; }

        /// <summary>Output only. The revision of the service at the time of backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceRevision")]
        public virtual GoogleCloudMetastoreV2alphaService ServiceRevision { get; set; }

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.CancelMigration.</summary>
    public class GoogleCloudMetastoreV2alphaCancelMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration information to start the Change Data Capture (CDC) streams from customer database to backend
    /// database of Dataproc Metastore.
    /// </summary>
    public class GoogleCloudMetastoreV2alphaCdcConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The bucket to write the intermediate stream event data in. The bucket name must be without any
        /// prefix like "gs://". See the bucket naming requirements
        /// (https://cloud.google.com/storage/docs/buckets#naming). This field is optional. If not set, the Artifacts
        /// Cloud Storage bucket will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Datastream service should use for the MySQL connection.
        /// This field is not returned on request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Required. The URL of the subnetwork resource to create the VM instance hosting the reverse proxy in. More
        /// context in https://cloud.google.com/datastream/docs/private-connectivity#reverse-csql-proxy The subnetwork
        /// should reside in the network provided in the request that Datastream will peer to and should be in the same
        /// region as Datastream, in the following format.
        /// projects/{project_id}/regions/{region_id}/subnetworks/{subnetwork_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reverseProxySubnet")]
        public virtual string ReverseProxySubnet { get; set; }

        /// <summary>
        /// Optional. The root path inside the Cloud Storage bucket. The stream event data will be written to this path.
        /// The default value is /migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPath")]
        public virtual string RootPath { get; set; }

        /// <summary>Required. A /29 CIDR IP range for peering with datastream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetIpRange")]
        public virtual string SubnetIpRange { get; set; }

        /// <summary>Required. The username that the Datastream service should use for the MySQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>
        /// Required. Fully qualified name of the Cloud SQL instance's VPC network or the shared VPC network that
        /// Datastream will peer to, in the following format:
        /// projects/{project_id}/locations/global/networks/{network_id}. More context in
        /// https://cloud.google.com/datastream/docs/network-connectivity-options#privateconnectivity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetwork")]
        public virtual string VpcNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration information to establish customer database connection before the cutover phase of migration
    /// </summary>
    public class GoogleCloudMetastoreV2alphaCloudSQLConnectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The hive database name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveDatabaseName")]
        public virtual string HiveDatabaseName { get; set; }

        /// <summary>Required. Cloud SQL database connection name (project_id:region:instance_name)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceConnectionName")]
        public virtual string InstanceConnectionName { get; set; }

        /// <summary>Required. The private IP address of the Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// Required. The relative resource name of the subnetwork to be used for Private Service Connect. Note that
        /// this cannot be a regular subnet and is used only for NAT.
        /// (https://cloud.google.com/vpc/docs/about-vpc-hosted-services#psc-subnets) This subnet is used to publish the
        /// SOCKS5 proxy service. The subnet size must be at least /29 and it should reside in a network through which
        /// the Cloud SQL instance is accessible. The resource name should be in the format,
        /// projects/{project_id}/regions/{region_id}/subnetworks/{subnetwork_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("natSubnet")]
        public virtual string NatSubnet { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Dataproc Metastore service will be using to connect to
        /// the database. This field is not returned on request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Required. The network port of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Required. The relative resource name of the subnetwork to deploy the SOCKS5 proxy service in. The subnetwork
        /// should reside in a network through which the Cloud SQL instance is accessible. The resource name should be
        /// in the format, projects/{project_id}/regions/{region_id}/subnetworks/{subnetwork_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxySubnet")]
        public virtual string ProxySubnet { get; set; }

        /// <summary>
        /// Required. The username that Dataproc Metastore service will use to connect to the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration information for migrating from self-managed hive metastore on Google Cloud using Cloud SQL as the
    /// backend database to Dataproc Metastore.
    /// </summary>
    public class GoogleCloudMetastoreV2alphaCloudSQLMigrationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Configuration information to start the Change Data Capture (CDC) streams from customer database to
        /// backend database of Dataproc Metastore. Dataproc Metastore switches to using its backend database after the
        /// cutover phase of migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cdcConfig")]
        public virtual GoogleCloudMetastoreV2alphaCdcConfig CdcConfig { get; set; }

        /// <summary>
        /// Required. Configuration information to establish customer database connection before the cutover phase of
        /// migration
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlConnectionConfig")]
        public virtual GoogleCloudMetastoreV2alphaCloudSQLConnectionConfig CloudSqlConnectionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.CompleteMigration.</summary>
    public class GoogleCloudMetastoreV2alphaCompleteMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how metastore metadata should be integrated with the Data Catalog service.</summary>
    public class GoogleCloudMetastoreV2alphaDataCatalogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Defines whether the metastore metadata should be synced to Data Catalog. The default value is to
        /// disable syncing metastore metadata to Data Catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A specification of the location and metadata type for a database dump from a relational database management
    /// system.
    /// </summary>
    public class GoogleCloudMetastoreV2alphaDatabaseDump : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A Cloud Storage object or folder URI that specifies the source from which to import metadata. It
        /// must begin with gs://.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>Optional. The type of the database dump. If unspecified, defaults to MYSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encryption settings for the service.</summary>
    public class GoogleCloudMetastoreV2alphaEncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An endpoint used to access the metastore service.</summary>
    public class GoogleCloudMetastoreV2alphaEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The URI of the endpoint used to access the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>Output only. The region where the endpoint is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.ExportMetadata.</summary>
    public class GoogleCloudMetastoreV2alphaExportMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of the database dump. If unspecified, defaults to MYSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDumpType")]
        public virtual string DatabaseDumpType { get; set; }

        /// <summary>
        /// A Cloud Storage URI of a folder, in the format gs:///. A sub-folder containing exported files will be
        /// created below it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationGcsFolder")]
        public virtual string DestinationGcsFolder { get; set; }

        /// <summary>
        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if it has
        /// completed. The server will ignore subsequent requests that provide a duplicate request ID for at least 60
        /// minutes after the first request.For example, if an initial request times out, followed by another request
        /// with the same request ID, the server ignores the second request to prevent the creation of duplicate
        /// commitments.The request ID must be a valid UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format). A zero UUID
        /// (00000000-0000-0000-0000-000000000000) is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies configuration information specific to running Hive metastore software as the metastore service.
    /// </summary>
    public class GoogleCloudMetastoreV2alphaHiveMetastoreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A mapping of Hive metastore version to the auxiliary version configuration. When specified, a
        /// secondary Hive metastore service is created along with the primary service. All auxiliary versions must be
        /// less than the service's primary version. The key is the auxiliary service name and it must match the regular
        /// expression a-z?. This means that the first character must be a lowercase letter, and all the following
        /// characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a
        /// hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auxiliaryVersions")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudMetastoreV2alphaAuxiliaryVersionConfig> AuxiliaryVersions { get; set; }

        /// <summary>
        /// Optional. A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore
        /// (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden). These
        /// overrides are also applied to auxiliary versions and can be further customized in the auxiliary version's
        /// AuxiliaryVersionConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configOverrides")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConfigOverrides { get; set; }

        /// <summary>
        /// Optional. The protocol to use for the metastore service endpoint. If unspecified, defaults to GRPC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointProtocol")]
        public virtual string EndpointProtocol { get; set; }

        /// <summary>Immutable. The Hive metastore schema version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.CreateMetadataImport.</summary>
    public class GoogleCloudMetastoreV2alphaImportMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. A database dump from a pre-existing metastore's database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseDump")]
        public virtual GoogleCloudMetastoreV2alphaDatabaseDump DatabaseDump { get; set; }

        /// <summary>Optional. The description of the metadata import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if it has
        /// completed. The server will ignore subsequent requests that provide a duplicate request ID for at least 60
        /// minutes after the first request.For example, if an initial request times out, followed by another request
        /// with the same request ID, the server ignores the second request to prevent the creation of duplicate
        /// commitments.The request ID must be a valid UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format). A zero UUID
        /// (00000000-0000-0000-0000-000000000000) is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of the latest scheduled backup.</summary>
    public class GoogleCloudMetastoreV2alphaLatestBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The ID of an in-progress scheduled backup. Empty if no backup is in progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual string BackupId { get; set; }

        /// <summary>Output only. The duration of the backup completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The time when the backup was started.</summary>
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

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the autoscaling limit configuration of a metastore service.</summary>
    public class GoogleCloudMetastoreV2alphaLimitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The highest scaling factor that the service should be autoscaled to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxScalingFactor")]
        public virtual System.Nullable<int> MaxScalingFactor { get; set; }

        /// <summary>Optional. The lowest scaling factor that the service should be autoscaled to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minScalingFactor")]
        public virtual System.Nullable<int> MinScalingFactor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.ListBackups.</summary>
    public class GoogleCloudMetastoreV2alphaListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The backups of the specified service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV2alphaBackup> Backups { get; set; }

        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.ListMigrationExecutions.</summary>
    public class GoogleCloudMetastoreV2alphaListMigrationExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The migration executions on the specified service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecutions")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV2alphaMigrationExecution> MigrationExecutions { get; set; }

        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.ListServices.</summary>
    public class GoogleCloudMetastoreV2alphaListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as page_token to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The services in the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV2alphaService> Services { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how metastore metadata should be integrated with external services.</summary>
    public class GoogleCloudMetastoreV2alphaMetadataIntegration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The integration config for the Data Catalog service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCatalogConfig")]
        public virtual GoogleCloudMetastoreV2alphaDataCatalogConfig DataCatalogConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a migration execution resource.</summary>
    public class GoogleCloudMetastoreV2alphaMigrationExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Configuration information specific to migrating from self-managed hive metastore on Google Cloud using Cloud
        /// SQL as the backend database to Dataproc Metastore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlMigrationConfig")]
        public virtual GoogleCloudMetastoreV2alphaCloudSQLMigrationConfig CloudSqlMigrationConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the migration execution was started.</summary>
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

        /// <summary>Output only. The time when the migration execution finished.</summary>
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
        /// Output only. The relative resource name of the migration execution, in the following form:
        /// projects/{project_number}/locations/{location_id}/services/{service_id}/migrationExecutions/{migration_execution_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current phase of the migration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>Output only. The current state of the migration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional information about the current state of the migration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.MoveTableToDatabase.</summary>
    public class GoogleCloudMetastoreV2alphaMoveTableToDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the database where the table resides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbName")]
        public virtual string DbName { get; set; }

        /// <summary>Required. The name of the database where the table should be moved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDbName")]
        public virtual string DestinationDbName { get; set; }

        /// <summary>Required. The name of the table to be moved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableName")]
        public virtual string TableName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.QueryMetadata.</summary>
    public class GoogleCloudMetastoreV2alphaQueryMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A read-only SQL query to execute against the metadata database. The query cannot change or mutate
        /// the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.RemoveIamPolicy.</summary>
    public class GoogleCloudMetastoreV2alphaRemoveIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Removes IAM policy attached to database or table asynchronously when it is set. The default is
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asynchronous")]
        public virtual System.Nullable<bool> Asynchronous { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DataprocMetastore.RemoveIamPolicy.</summary>
    public class GoogleCloudMetastoreV2alphaRemoveIamPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the policy is successfully removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("success")]
        public virtual System.Nullable<bool> Success { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.Restore.</summary>
    public class GoogleCloudMetastoreV2alphaRestoreServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The relative resource name of the metastore service backup to restore from, in the following
        /// form:projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}. Mutually
        /// exclusive with backup_location, and exactly one of the two must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// Optional. A Cloud Storage URI specifying the location of the backup artifacts, namely - backup avro files
        /// under "avro/", backup_metastore.json and service.json, in the following form:gs://. Mutually exclusive with
        /// backup, and exactly one of the two must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupLocation")]
        public virtual string BackupLocation { get; set; }

        /// <summary>
        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if it has
        /// completed. The server will ignore subsequent requests that provide a duplicate request ID for at least 60
        /// minutes after the first request.For example, if an initial request times out, followed by another request
        /// with the same request ID, the server ignores the second request to prevent the creation of duplicate
        /// commitments.The request ID must be a valid UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format). A zero UUID
        /// (00000000-0000-0000-0000-000000000000) is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>Optional. The type of restore. If unspecified, defaults to METADATA_ONLY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreType")]
        public virtual string RestoreType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the scaling configuration of a metastore service.</summary>
    public class GoogleCloudMetastoreV2alphaScalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The autoscaling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingConfig")]
        public virtual GoogleCloudMetastoreV2alphaAutoscalingConfig AutoscalingConfig { get; set; }

        /// <summary>Optional. Scaling factor from 1 to 5, increments of 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingFactor")]
        public virtual System.Nullable<int> ScalingFactor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This specifies the configuration of scheduled backup.</summary>
    public class GoogleCloudMetastoreV2alphaScheduledBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A Cloud Storage URI of a folder, in the format gs:///. A sub-folder containing backup files will
        /// be stored below it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupLocation")]
        public virtual string BackupLocation { get; set; }

        /// <summary>
        /// Optional. The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is
        /// empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSchedule")]
        public virtual string CronSchedule { get; set; }

        /// <summary>Optional. Defines whether the scheduled backup is enabled. The default value is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Output only. The details of the latest scheduled backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestBackup")]
        public virtual GoogleCloudMetastoreV2alphaLatestBackup LatestBackup { get; set; }

        private string _nextScheduledTimeRaw;

        private object _nextScheduledTime;

        /// <summary>Output only. The time when the next backups execution is scheduled to start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextScheduledTime")]
        public virtual string NextScheduledTimeRaw
        {
            get => _nextScheduledTimeRaw;
            set
            {
                _nextScheduledTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextScheduledTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextScheduledTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextScheduledTimeDateTimeOffset instead.")]
        public virtual object NextScheduledTime
        {
            get => _nextScheduledTime;
            set
            {
                _nextScheduledTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextScheduledTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextScheduledTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextScheduledTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextScheduledTimeRaw);
            set => NextScheduledTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Specifies the time zone to be used when interpreting cron_schedule. Must be a time zone name from
        /// the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g.
        /// America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A managed metastore service that serves metadata queries.</summary>
    public class GoogleCloudMetastoreV2alphaService : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the metastore service was created.</summary>
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
        /// Immutable. Information used to configure the Dataproc Metastore service to encrypt customer data at rest.
        /// Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual GoogleCloudMetastoreV2alphaEncryptionConfig EncryptionConfig { get; set; }

        /// <summary>Output only. The list of endpoints used to access the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<GoogleCloudMetastoreV2alphaEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Configuration information specific to running Hive metastore software as the metastore service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveMetastoreConfig")]
        public virtual GoogleCloudMetastoreV2alphaHiveMetastoreConfig HiveMetastoreConfig { get; set; }

        /// <summary>User-defined labels for the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The setting that defines how metastore metadata should be integrated with external services and
        /// systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataIntegration")]
        public virtual GoogleCloudMetastoreV2alphaMetadataIntegration MetadataIntegration { get; set; }

        /// <summary>
        /// Immutable. The relative resource name of the metastore service, in the following
        /// format:projects/{project_number}/locations/{location_id}/services/{service_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Scaling configuration of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingConfig")]
        public virtual GoogleCloudMetastoreV2alphaScalingConfig ScalingConfig { get; set; }

        /// <summary>Optional. The configuration of scheduled backup for the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledBackup")]
        public virtual GoogleCloudMetastoreV2alphaScheduledBackup ScheduledBackup { get; set; }

        /// <summary>Output only. The current state of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Additional information about the current state of the metastore service, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        /// <summary>Output only. The globally unique resource identifier of the metastore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the metastore service was last updated.</summary>
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
        /// Required. A Cloud Storage URI (starting with gs://) that specifies the default warehouse directory of the
        /// Hive Metastore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warehouseGcsUri")]
        public virtual string WarehouseGcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DataprocMetastore.StartMigration.</summary>
    public class GoogleCloudMetastoreV2alphaStartMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration details for the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationExecution")]
        public virtual GoogleCloudMetastoreV2alphaMigrationExecution MigrationExecution { get; set; }

        /// <summary>
        /// Optional. A request ID. Specify a unique request ID to allow the server to ignore the request if it has
        /// completed. The server will ignore subsequent requests that provide a duplicate request ID for at least 60
        /// minutes after the first request.For example, if an initial request times out, followed by another request
        /// with the same request ID, the server ignores the second request to prevent the creation of duplicate
        /// commitments.The request ID must be a valid UUID
        /// (https://en.wikipedia.org/wiki/Universally_unique_identifier#Format) A zero UUID
        /// (00000000-0000-0000-0000-000000000000) is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is false, it means the operation is still in progress. If true, the operation is completed, and
        /// either error or response is available.
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
        /// use the default HTTP mapping, the name should be a resource name ending with operations/{unique_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// Delete, the response is google.protobuf.Empty. If the original method is standard Get/Create/Update, the
        /// response should be the resource. For other methods, the response should have the type XxxResponse, where Xxx
        /// is the original method name. For example, if the original method name is TakeSnapshot(), the inferred
        /// response type is TakeSnapshotResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Status type defines a logical error model that is suitable for different programming environments, including
    /// REST APIs and RPC APIs. It is used by gRPC (https://github.com/grpc). Each Status message contains three pieces
    /// of data: error code, error message, and error details.You can find out more about this error model and how to
    /// work with it in the API Design Guide (https://cloud.google.com/apis/design/errors).
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
}
