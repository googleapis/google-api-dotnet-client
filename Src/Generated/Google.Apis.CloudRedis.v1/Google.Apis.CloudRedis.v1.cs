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

namespace Google.Apis.CloudRedis.v1
{
    /// <summary>The CloudRedis Service.</summary>
    public class CloudRedisService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRedisService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRedisService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://redis.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://redis.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "redis";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Memorystore for Redis API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Google Cloud Memorystore for Redis API.
        /// </summary>
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

    /// <summary>A base abstract class for CloudRedis requests.</summary>
    public abstract class CloudRedisBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRedisBaseServiceRequest instance.</summary>
        protected CloudRedisBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudRedis parameter list.</summary>
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
                BackupCollections = new BackupCollectionsResource(service);
                Clusters = new ClustersResource(service);
                Instances = new InstancesResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the BackupCollections resource.</summary>
            public virtual BackupCollectionsResource BackupCollections { get; }

            /// <summary>The "backupCollections" collection of methods.</summary>
            public class BackupCollectionsResource
            {
                private const string Resource = "backupCollections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupCollectionsResource(Google.Apis.Services.IClientService service)
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

                    /// <summary>Deletes a specific backup.</summary>
                    /// <param name="name">
                    /// Required. Redis backup resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a specific backup.</summary>
                    public class DeleteRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Redis backup resource name using the form:
                        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. Idempotent request UUID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupCollections/[^/]+/backups/[^/]+$",
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

                    /// <summary>Exports a specific backup to a customer target Cloud Storage URI.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Redis backup resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
                    /// </param>
                    public virtual ExportRequest Export(Google.Apis.CloudRedis.v1.Data.ExportBackupRequest body, string name)
                    {
                        return new ExportRequest(this.service, body, name);
                    }

                    /// <summary>Exports a specific backup to a customer target Cloud Storage URI.</summary>
                    public class ExportRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Export request.</summary>
                        public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.ExportBackupRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Redis backup resource name using the form:
                        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRedis.v1.Data.ExportBackupRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "export";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:export";

                        /// <summary>Initializes Export parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupCollections/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the details of a specific backup.</summary>
                    /// <param name="name">
                    /// Required. Redis backup resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the details of a specific backup.</summary>
                    public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Backup>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Redis backup resource name using the form:
                        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupCollections/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all backups owned by a backup collection.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the backupCollection using the form:
                    /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all backups owned by a backup collection.</summary>
                    public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListBackupsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the backupCollection using the form:
                        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If not specified, a default value of 1000
                        /// will be used by the service. Regardless of the page_size value, the response may include a
                        /// partial list and a caller should only rely on response's `next_page_token` to determine if
                        /// there are more clusters left to be queried.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The `next_page_token` value returned from a previous [ListBackupCollections]
                        /// request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupCollections/[^/]+$",
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

                /// <summary>Get a backup collection.</summary>
                /// <param name="name">
                /// Required. Redis backupCollection resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}` where
                /// `location_id` refers to a Google Cloud region.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get a backup collection.</summary>
                public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.BackupCollection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis backupCollection resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}` where
                    /// `location_id` refers to a Google Cloud region.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupCollections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all backup collections owned by a consumer project in either the specified location (region)
                /// or all locations. If `location_id` is specified as `-` (wildcard), then all regions available to the
                /// project are queried, and the results are aggregated.
                /// </summary>
                /// <param name="parent">
                /// Required. The resource name of the backupCollection location using the form:
                /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a Google Cloud region.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all backup collections owned by a consumer project in either the specified location (region)
                /// or all locations. If `location_id` is specified as `-` (wildcard), then all regions available to the
                /// project are queried, and the results are aggregated.
                /// </summary>
                public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListBackupCollectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the backupCollection location using the form:
                    /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a Google Cloud
                    /// region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If not specified, a default value of 1000 will
                    /// be used by the service. Regardless of the page_size value, the response may include a partial
                    /// list and a caller should only rely on response's `next_page_token` to determine if there are
                    /// more clusters left to be queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The `next_page_token` value returned from a previous [ListBackupCollections] request,
                    /// if any.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupCollections";

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
            }

            /// <summary>Gets the Clusters resource.</summary>
            public virtual ClustersResource Clusters { get; }

            /// <summary>The "clusters" collection of methods.</summary>
            public class ClustersResource
            {
                private const string Resource = "clusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Backup Redis Cluster. If this is the first time a backup is being created, a backup collection will
                /// be created at the backend, and this backup belongs to this collection. Both collection and backup
                /// will have a resource name. Backup will be executed for each shard. A replica (primary if nonHA) will
                /// be selected to perform the execution. Backup call will be rejected if there is an ongoing backup or
                /// update operation. Be aware that during preview, if the cluster's internal software version is too
                /// old, critical update will be performed before actual backup. Once the internal software version is
                /// updated to the minimum version required by the backup feature, subsequent backups will not require
                /// critical update. After preview, there will be no critical update needed for backup.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Redis cluster resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers to
                /// a Google Cloud region.
                /// </param>
                public virtual BackupRequest Backup(Google.Apis.CloudRedis.v1.Data.BackupClusterRequest body, string name)
                {
                    return new BackupRequest(this.service, body, name);
                }

                /// <summary>
                /// Backup Redis Cluster. If this is the first time a backup is being created, a backup collection will
                /// be created at the backend, and this backup belongs to this collection. Both collection and backup
                /// will have a resource name. Backup will be executed for each shard. A replica (primary if nonHA) will
                /// be selected to perform the execution. Backup call will be rejected if there is an ongoing backup or
                /// update operation. Be aware that during preview, if the cluster's internal software version is too
                /// old, critical update will be performed before actual backup. Once the internal software version is
                /// updated to the minimum version required by the backup feature, subsequent backups will not require
                /// critical update. After preview, there will be no critical update needed for backup.
                /// </summary>
                public class BackupRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Backup request.</summary>
                    public BackupRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.BackupClusterRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis cluster resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers
                    /// to a Google Cloud region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.BackupClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "backup";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:backup";

                    /// <summary>Initializes Backup parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a Redis cluster based on the specified properties. The creation is executed asynchronously
                /// and callers may check the returned operation to track its progress. Once the operation is completed
                /// the Redis cluster will be fully functional. The completed longrunning.Operation will contain the new
                /// cluster object in the response field. The returned operation is automatically deleted after a few
                /// hours, so there is no need to call DeleteOperation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the cluster location using the form:
                /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a Google Cloud region.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRedis.v1.Data.Cluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a Redis cluster based on the specified properties. The creation is executed asynchronously
                /// and callers may check the returned operation to track its progress. Once the operation is completed
                /// the Redis cluster will be fully functional. The completed longrunning.Operation will contain the new
                /// cluster object in the response field. The returned operation is automatically deleted after a few
                /// hours, so there is no need to call DeleteOperation.
                /// </summary>
                public class CreateRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.Cluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the cluster location using the form:
                    /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a Google Cloud
                    /// region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The logical name of the Redis cluster in the customer project with the following
                    /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a
                    /// letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be
                    /// unique within the customer project / location
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

                    /// <summary>Optional. Idempotent request UUID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/clusters";

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
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
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

                /// <summary>Deletes a specific Redis cluster. Cluster stops serving and data is deleted.</summary>
                /// <param name="name">
                /// Required. Redis cluster resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers to
                /// a Google Cloud region.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a specific Redis cluster. Cluster stops serving and data is deleted.</summary>
                public class DeleteRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis cluster resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers
                    /// to a Google Cloud region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Idempotent request UUID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                /// <summary>Gets the details of a specific Redis cluster.</summary>
                /// <param name="name">
                /// Required. Redis cluster resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers to
                /// a Google Cloud region.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a specific Redis cluster.</summary>
                public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis cluster resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers
                    /// to a Google Cloud region.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of certificate authority information for Redis cluster.</summary>
                /// <param name="name">
                /// Required. Redis cluster certificate authority resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority` where
                /// `location_id` refers to a Google Cloud region.
                /// </param>
                public virtual GetCertificateAuthorityRequest GetCertificateAuthority(string name)
                {
                    return new GetCertificateAuthorityRequest(this.service, name);
                }

                /// <summary>Gets the details of certificate authority information for Redis cluster.</summary>
                public class GetCertificateAuthorityRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.CertificateAuthority>
                {
                    /// <summary>Constructs a new GetCertificateAuthority request.</summary>
                    public GetCertificateAuthorityRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis cluster certificate authority resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority` where
                    /// `location_id` refers to a Google Cloud region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getCertificateAuthority";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes GetCertificateAuthority parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/certificateAuthority$",
                        });
                    }
                }

                /// <summary>
                /// Lists all Redis clusters owned by a project in either the specified location (region) or all
                /// locations. The location should have the following format: *
                /// `projects/{project_id}/locations/{location_id}` If `location_id` is specified as `-` (wildcard),
                /// then all regions available to the project are queried, and the results are aggregated.
                /// </summary>
                /// <param name="parent">
                /// Required. The resource name of the cluster location using the form:
                /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a Google Cloud region.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all Redis clusters owned by a project in either the specified location (region) or all
                /// locations. The location should have the following format: *
                /// `projects/{project_id}/locations/{location_id}` If `location_id` is specified as `-` (wildcard),
                /// then all regions available to the project are queried, and the results are aggregated.
                /// </summary>
                public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the cluster location using the form:
                    /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a Google Cloud
                    /// region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of items to return. If not specified, a default value of 1000 will be used by
                    /// the service. Regardless of the page_size value, the response may include a partial list and a
                    /// caller should only rely on response's `next_page_token` to determine if there are more clusters
                    /// left to be queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The `next_page_token` value returned from a previous ListClusters request, if any.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/clusters";

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
                /// Updates the metadata and configuration of a specific Redis cluster. Completed longrunning.Operation
                /// will contain the new cluster object in the response field. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Identifier. Unique name of the resource in this scope including project and location using
                /// the form: `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudRedis.v1.Data.Cluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates the metadata and configuration of a specific Redis cluster. Completed longrunning.Operation
                /// will contain the new cluster object in the response field. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                public class PatchRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.Cluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Identifier. Unique name of the resource in this scope including project and location
                    /// using the form: `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Idempotent request UUID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field. The
                    /// elements of the repeated paths field may only include these fields from Cluster: * `size_gb` *
                    /// `replica_count` * `cluster_endpoints`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.Cluster Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                /// <summary>Reschedules upcoming maintenance event.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Redis Cluster instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers to
                /// a Google Cloud region.
                /// </param>
                public virtual RescheduleClusterMaintenanceRequest RescheduleClusterMaintenance(Google.Apis.CloudRedis.v1.Data.RescheduleClusterMaintenanceRequest body, string name)
                {
                    return new RescheduleClusterMaintenanceRequest(this.service, body, name);
                }

                /// <summary>Reschedules upcoming maintenance event.</summary>
                public class RescheduleClusterMaintenanceRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new RescheduleClusterMaintenance request.</summary>
                    public RescheduleClusterMaintenanceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.RescheduleClusterMaintenanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis Cluster instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}` where `location_id` refers
                    /// to a Google Cloud region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.RescheduleClusterMaintenanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rescheduleClusterMaintenance";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:rescheduleClusterMaintenance";

                    /// <summary>Initializes RescheduleClusterMaintenance parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }
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

                /// <summary>
                /// Creates a Redis instance based on the specified tier and memory size. By default, the instance is
                /// accessible from the project's [default network](https://cloud.google.com/vpc/docs/vpc). The creation
                /// is executed asynchronously and callers may check the returned operation to track its progress. Once
                /// the operation is completed the Redis instance will be fully functional. Completed
                /// longrunning.Operation will contain the new instance object in the response field. The returned
                /// operation is automatically deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the instance location using the form:
                /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP region.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRedis.v1.Data.Instance body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a Redis instance based on the specified tier and memory size. By default, the instance is
                /// accessible from the project's [default network](https://cloud.google.com/vpc/docs/vpc). The creation
                /// is executed asynchronously and callers may check the returned operation to track its progress. Once
                /// the operation is completed the Redis instance will be fully functional. Completed
                /// longrunning.Operation will contain the new instance object in the response field. The returned
                /// operation is automatically deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                public class CreateRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.Instance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the instance location using the form:
                    /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The logical name of the Redis instance in the customer project with the following
                    /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a
                    /// letter. * Must be between 1-40 characters. * Must end with a number or a letter. * Must be
                    /// unique within the customer project / location
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.Instance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instances";

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
                        RequestParameters.Add("instanceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instanceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a specific Redis instance. Instance stops serving and data is deleted.</summary>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a specific Redis instance. Instance stops serving and data is deleted.</summary>
                public class DeleteRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Export Redis instance data into a Redis RDB format file in Cloud Storage. Redis will continue
                /// serving during this operation. The returned operation is automatically deleted after a few hours, so
                /// there is no need to call DeleteOperation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual ExportRequest Export(Google.Apis.CloudRedis.v1.Data.ExportInstanceRequest body, string name)
                {
                    return new ExportRequest(this.service, body, name);
                }

                /// <summary>
                /// Export Redis instance data into a Redis RDB format file in Cloud Storage. Redis will continue
                /// serving during this operation. The returned operation is automatically deleted after a few hours, so
                /// there is no need to call DeleteOperation.
                /// </summary>
                public class ExportRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.ExportInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.ExportInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:export";

                    /// <summary>Initializes Export parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Initiates a failover of the primary node to current replica node for a specific STANDARD tier Cloud
                /// Memorystore for Redis instance.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual FailoverRequest Failover(Google.Apis.CloudRedis.v1.Data.FailoverInstanceRequest body, string name)
                {
                    return new FailoverRequest(this.service, body, name);
                }

                /// <summary>
                /// Initiates a failover of the primary node to current replica node for a specific STANDARD tier Cloud
                /// Memorystore for Redis instance.
                /// </summary>
                public class FailoverRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Failover request.</summary>
                    public FailoverRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.FailoverInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.FailoverInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "failover";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:failover";

                    /// <summary>Initializes Failover parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a specific Redis instance.</summary>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a specific Redis instance.</summary>
                public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the instance the response will
                /// be empty. This information is not included in the details returned to GetInstance.
                /// </summary>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual GetAuthStringRequest GetAuthString(string name)
                {
                    return new GetAuthStringRequest(this.service, name);
                }

                /// <summary>
                /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the instance the response will
                /// be empty. This information is not included in the details returned to GetInstance.
                /// </summary>
                public class GetAuthStringRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.InstanceAuthString>
                {
                    /// <summary>Constructs a new GetAuthString request.</summary>
                    public GetAuthStringRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getAuthString";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}/authString";

                    /// <summary>Initializes GetAuthString parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance. Redis may stop serving
                /// during this operation. Instance state will be IMPORTING for entire operation. When complete, the
                /// instance will contain only data from the imported file. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual ImportRequest Import(Google.Apis.CloudRedis.v1.Data.ImportInstanceRequest body, string name)
                {
                    return new ImportRequest(this.service, body, name);
                }

                /// <summary>
                /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance. Redis may stop serving
                /// during this operation. Instance state will be IMPORTING for entire operation. When complete, the
                /// instance will contain only data from the imported file. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                public class ImportRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Import request.</summary>
                    public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.ImportInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.ImportInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "import";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:import";

                    /// <summary>Initializes Import parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all Redis instances owned by a project in either the specified location (region) or all
                /// locations. The location should have the following format: *
                /// `projects/{project_id}/locations/{location_id}` If `location_id` is specified as `-` (wildcard),
                /// then all regions available to the project are queried, and the results are aggregated.
                /// </summary>
                /// <param name="parent">
                /// Required. The resource name of the instance location using the form:
                /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP region.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all Redis instances owned by a project in either the specified location (region) or all
                /// locations. The location should have the following format: *
                /// `projects/{project_id}/locations/{location_id}` If `location_id` is specified as `-` (wildcard),
                /// then all regions available to the project are queried, and the results are aggregated.
                /// </summary>
                public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the instance location using the form:
                    /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of items to return. If not specified, a default value of 1000 will be used by
                    /// the service. Regardless of the page_size value, the response may include a partial list and a
                    /// caller should only rely on response's `next_page_token` to determine if there are more instances
                    /// left to be queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The `next_page_token` value returned from a previous ListInstances request, if any.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instances";

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
                /// Updates the metadata and configuration of a specific Redis instance. Completed longrunning.Operation
                /// will contain the new instance object in the response field. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Unique name of the resource in this scope including project and location using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note: Redis instances are
                /// managed and addressed at regional level so location_id here refers to a GCP region; however, users
                /// may choose which specific zone (or collection of zones for cross-zone instances) an instance should
                /// be provisioned in. Refer to location_id and alternative_location_id fields for more details.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudRedis.v1.Data.Instance body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates the metadata and configuration of a specific Redis instance. Completed longrunning.Operation
                /// will contain the new instance object in the response field. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.
                /// </summary>
                public class PatchRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.Instance body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Unique name of the resource in this scope including project and location using the
                    /// form: `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note: Redis
                    /// instances are managed and addressed at regional level so location_id here refers to a GCP
                    /// region; however, users may choose which specific zone (or collection of zones for cross-zone
                    /// instances) an instance should be provisioned in. Refer to location_id and
                    /// alternative_location_id fields for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field. The
                    /// elements of the repeated paths field may only include these fields from Instance: *
                    /// `displayName` * `labels` * `memorySizeGb` * `redisConfig` * `replica_count`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.Instance Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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

                /// <summary>Reschedule maintenance for a given instance in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual RescheduleMaintenanceRequest RescheduleMaintenance(Google.Apis.CloudRedis.v1.Data.RescheduleMaintenanceRequest body, string name)
                {
                    return new RescheduleMaintenanceRequest(this.service, body, name);
                }

                /// <summary>Reschedule maintenance for a given instance in a given project and location.</summary>
                public class RescheduleMaintenanceRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new RescheduleMaintenance request.</summary>
                    public RescheduleMaintenanceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.RescheduleMaintenanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.RescheduleMaintenanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rescheduleMaintenance";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:rescheduleMaintenance";

                    /// <summary>Initializes RescheduleMaintenance parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Upgrades Redis instance to the newer Redis version specified in the request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers
                /// to a GCP region.
                /// </param>
                public virtual UpgradeRequest Upgrade(Google.Apis.CloudRedis.v1.Data.UpgradeInstanceRequest body, string name)
                {
                    return new UpgradeRequest(this.service, body, name);
                }

                /// <summary>Upgrades Redis instance to the newer Redis version specified in the request.</summary>
                public class UpgradeRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Upgrade request.</summary>
                    public UpgradeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.UpgradeInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.UpgradeInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "upgrade";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:upgrade";

                    /// <summary>Initializes Upgrade parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(this.service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class DeleteRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Empty>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
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
                public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Location>
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
            public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.CloudRedis.v1.Data
{
    /// <summary>Configuration of the AOF based persistence.</summary>
    public class AOFConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. fsync configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendFsync")]
        public virtual string AppendFsync { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The automated backup config for a cluster.</summary>
    public class AutomatedBackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The automated backup mode. If the mode is disabled, the other fields will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedBackupMode")]
        public virtual string AutomatedBackupMode { get; set; }

        /// <summary>Optional. Trigger automated backups at a fixed frequency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedFrequencySchedule")]
        public virtual FixedFrequencySchedule FixedFrequencySchedule { get; set; }

        /// <summary>
        /// Optional. How long to keep automated backups before the backups are deleted. The value should be between 1
        /// day and 365 days. If not specified, the default value is 35 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retention")]
        public virtual object Retention { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for availability of database instance</summary>
    public class AvailabilityConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Checks for existence of (multi-cluster) routing configuration that allows automatic failover to a different
        /// zone/region in case of an outage. Applicable to Bigtable resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automaticFailoverRoutingConfigured")]
        public virtual System.Nullable<bool> AutomaticFailoverRoutingConfigured { get; set; }

        /// <summary>
        /// Availability type. Potential values: * `ZONAL`: The instance serves data from only one zone. Outages in that
        /// zone affect data accessibility. * `REGIONAL`: The instance can serve data from more than one zone in a
        /// region (it is highly available).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityType")]
        public virtual string AvailabilityType { get; set; }

        /// <summary>
        /// Checks for resources that are configured to have redundancy, and ongoing replication across regions
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossRegionReplicaConfigured")]
        public virtual System.Nullable<bool> CrossRegionReplicaConfigured { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalReplicaConfigured")]
        public virtual System.Nullable<bool> ExternalReplicaConfigured { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("promotableReplicaConfigured")]
        public virtual System.Nullable<bool> PromotableReplicaConfigured { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup of a cluster.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of backup files of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupFiles")]
        public virtual System.Collections.Generic.IList<BackupFile> BackupFiles { get; set; }

        /// <summary>Output only. Type of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        /// <summary>Output only. Cluster resource path of this backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Output only. Cluster uid of this backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUid")]
        public virtual string ClusterUid { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the backup was created.</summary>
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

        /// <summary>Output only. Encryption information of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>Output only. redis-7.2, valkey-7.5</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineVersion")]
        public virtual string EngineVersion { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. The time when the backup will expire.</summary>
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
        /// Identifier. Full resource path of the backup. the last part of the name is the backup id with the following
        /// format: [YYYYMMDDHHMMSS]_[Shorted Cluster UID] OR customer specified while backup cluster. Example:
        /// 20240515123000_1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Node type of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeType")]
        public virtual string NodeType { get; set; }

        /// <summary>Output only. Number of replicas for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<int> ReplicaCount { get; set; }

        /// <summary>Output only. Number of shards for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<int> ShardCount { get; set; }

        /// <summary>Output only. State of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Total size of the backup in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSizeBytes")]
        public virtual System.Nullable<long> TotalSizeBytes { get; set; }

        /// <summary>Output only. System assigned unique identifier of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for [BackupCluster].</summary>
    public class BackupClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The id of the backup to be created. If not specified, the default value
        /// ([YYYYMMDDHHMMSS]_[Shortened Cluster UID] is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual string BackupId { get; set; }

        /// <summary>
        /// Optional. TTL for the backup to expire. Value range is 1 day to 100 years. If not specified, the default
        /// value is 100 years.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupCollection of a cluster.</summary>
    public class BackupCollection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The full resource path of the cluster the backup collection belongs to. Example:
        /// projects/{project}/locations/{location}/clusters/{cluster}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Output only. The cluster uid of the backup collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUid")]
        public virtual string ClusterUid { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the backup collection was created.</summary>
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

        /// <summary>Output only. The KMS key used to encrypt the backups under this backup collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>Identifier. Full resource path of the backup collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. System assigned unique identifier of the backup collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for automatic backups</summary>
    public class BackupConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether customer visible automated backups are enabled on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedBackupEnabled")]
        public virtual System.Nullable<bool> AutomatedBackupEnabled { get; set; }

        /// <summary>Backup retention settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionSettings")]
        public virtual RetentionSettings BackupRetentionSettings { get; set; }

        /// <summary>
        /// Whether point-in-time recovery is enabled. This is optional field, if the database service does not have
        /// this feature or metadata is not available in control plane, this can be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointInTimeRecoveryEnabled")]
        public virtual System.Nullable<bool> PointInTimeRecoveryEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BackupDRConfiguration to capture the backup and disaster recovery details of database resource.
    /// </summary>
    public class BackupDRConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if the resource is managed by BackupDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupdrManaged")]
        public virtual System.Nullable<bool> BackupdrManaged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup is consisted of multiple backup files.</summary>
    public class BackupFile : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the backup file was created.</summary>
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

        /// <summary>Output only. e.g: .rdb</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>Output only. Size of the backup file in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A backup run.</summary>
    public class BackupRun : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the backup operation completed. REQUIRED</summary>
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
        /// Information about why the backup operation failed. This is only present if the run has the FAILED status.
        /// OPTIONAL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual OperationError Error { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the backup operation started. REQUIRED</summary>
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

        /// <summary>The status of this run. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CertChain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The certificates that form the CA chain, from leaf to root order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<string> Certificates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Redis cluster certificate authority</summary>
    public class CertificateAuthority : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("managedServerCa")]
        public virtual ManagedCertificateAuthority ManagedServerCa { get; set; }

        /// <summary>
        /// Identifier. Unique name of the resource in this scope including project, location and cluster using the
        /// form: `projects/{project}/locations/{location}/clusters/{cluster}/certificateAuthority`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A cluster instance.</summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. Allows customers to specify if they are okay with deploying a multi-zone cluster in
        /// less than 3 zones. Once set, if there is a zonal outage during the cluster creation, the cluster will only
        /// be deployed in 2 zones, and stay within the 2 zones for its lifecycle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowFewerZonesDeployment")]
        public virtual System.Nullable<bool> AllowFewerZonesDeployment { get; set; }

        /// <summary>
        /// Optional. If true, cluster endpoints that are created and registered by customers can be deleted
        /// asynchronously. That is, such a cluster endpoint can be de-registered before the forwarding rules in the
        /// cluster endpoint are deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asyncClusterEndpointsDeletionEnabled")]
        public virtual System.Nullable<bool> AsyncClusterEndpointsDeletionEnabled { get; set; }

        /// <summary>
        /// Optional. The authorization mode of the Redis cluster. If not provided, auth feature is disabled for the
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationMode")]
        public virtual string AuthorizationMode { get; set; }

        /// <summary>Optional. The automated backup config for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedBackupConfig")]
        public virtual AutomatedBackupConfig AutomatedBackupConfig { get; set; }

        /// <summary>
        /// Optional. Output only. The backup collection full resource name. Example:
        /// projects/{project}/locations/{location}/backupCollections/{collection}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupCollection")]
        public virtual string BackupCollection { get; set; }

        /// <summary>Optional. A list of cluster endpoints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterEndpoints")]
        public virtual System.Collections.Generic.IList<ClusterEndpoint> ClusterEndpoints { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp associated with the cluster creation request.</summary>
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

        /// <summary>Optional. Cross cluster replication config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossClusterReplicationConfig")]
        public virtual CrossClusterReplicationConfig CrossClusterReplicationConfig { get; set; }

        /// <summary>Optional. The delete operation will fail when the value is set to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtectionEnabled")]
        public virtual System.Nullable<bool> DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Output only. Endpoints created on each given network, for Redis clients to connect to the cluster. Currently
        /// only one discovery endpoint is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryEndpoints")]
        public virtual System.Collections.Generic.IList<DiscoveryEndpoint> DiscoveryEndpoints { get; set; }

        /// <summary>Output only. Encryption information of the data at rest of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Optional. Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as
        /// the clusters. Read permission is required to import from the provided Cloud Storage objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsBackupSource GcsSource { get; set; }

        /// <summary>Optional. The KMS key used to encrypt the at-rest data of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>Optional. ClusterMaintenancePolicy determines when to allow or deny updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicy")]
        public virtual ClusterMaintenancePolicy MaintenancePolicy { get; set; }

        /// <summary>Output only. ClusterMaintenanceSchedule Output only Published maintenance schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSchedule")]
        public virtual ClusterMaintenanceSchedule MaintenanceSchedule { get; set; }

        /// <summary>Optional. Backups generated and managed by memorystore service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedBackupSource")]
        public virtual ManagedBackupSource ManagedBackupSource { get; set; }

        /// <summary>
        /// Required. Identifier. Unique name of the resource in this scope including project and location using the
        /// form: `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The type of a redis node in the cluster. NodeType determines the underlying machine-type of a
        /// redis node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeType")]
        public virtual string NodeType { get; set; }

        /// <summary>
        /// Optional. Input only. Ondemand maintenance for the cluster. This field can be used to trigger ondemand
        /// critical update on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ondemandMaintenance")]
        public virtual System.Nullable<bool> OndemandMaintenance { get; set; }

        /// <summary>Optional. Persistence config (RDB, AOF) for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistenceConfig")]
        public virtual ClusterPersistenceConfig PersistenceConfig { get; set; }

        /// <summary>Output only. Precise value of redis memory size in GB for the entire cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preciseSizeGb")]
        public virtual System.Nullable<double> PreciseSizeGb { get; set; }

        /// <summary>
        /// Optional. Each PscConfig configures the consumer network where IPs will be designated to the cluster for
        /// client access through Private Service Connect Automation. Currently, only one PscConfig is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConfigs")]
        public virtual System.Collections.Generic.IList<PscConfig> PscConfigs { get; set; }

        /// <summary>
        /// Output only. The list of PSC connections that are auto-created through service connectivity automation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConnections")]
        public virtual System.Collections.Generic.IList<PscConnection> PscConnections { get; set; }

        /// <summary>Output only. Service attachment details to configure Psc connections</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscServiceAttachments")]
        public virtual System.Collections.Generic.IList<PscServiceAttachment> PscServiceAttachments { get; set; }

        /// <summary>Optional. Key/Value pairs of customer overrides for mutable Redis Configs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, string> RedisConfigs { get; set; }

        /// <summary>Optional. The number of replica nodes per shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<int> ReplicaCount { get; set; }

        /// <summary>Optional. Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Optional. Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Optional. Number of shards for the Redis cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<int> ShardCount { get; set; }

        /// <summary>Optional. Input only. Simulate a maintenance event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simulateMaintenanceEvent")]
        public virtual System.Nullable<bool> SimulateMaintenanceEvent { get; set; }

        /// <summary>
        /// Output only. Redis memory size in GB for the entire cluster rounded up to the next integer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>
        /// Output only. The current state of this cluster. Can be CREATING, READY, UPDATING, DELETING and SUSPENDED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional information about the current state of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateInfo")]
        public virtual StateInfo StateInfo { get; set; }

        /// <summary>
        /// Optional. The in-transit encryption for the Redis cluster. If not provided, encryption is disabled for the
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitEncryptionMode")]
        public virtual string TransitEncryptionMode { get; set; }

        /// <summary>Output only. System assigned, unique identifier for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        /// Optional. This config will be used to determine how the customer wants us to distribute cluster resources
        /// within the region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoneDistributionConfig")]
        public virtual ZoneDistributionConfig ZoneDistributionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ClusterEndpoint consists of PSC connections that are created as a group in each VPC network for accessing the
    /// cluster. In each group, there shall be one connection for each service attachment in the cluster.
    /// </summary>
    public class ClusterEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A group of PSC connections. They are created in the same VPC network, one for each service
        /// attachment in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<ConnectionDetail> Connections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maintenance policy per cluster.</summary>
    public class ClusterMaintenancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time when the policy was created i.e. Maintenance Window or Deny Period was assigned.
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The time when the policy was updated i.e. Maintenance Window or Deny Period was updated.
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
        /// Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current
        /// version, the maximum number of weekly_maintenance_window is expected to be one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyMaintenanceWindow")]
        public virtual System.Collections.Generic.IList<ClusterWeeklyMaintenanceWindow> WeeklyMaintenanceWindow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Upcoming maintenance schedule.</summary>
    public class ClusterMaintenanceSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The end time of any upcoming scheduled maintenance for this instance.</summary>
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

        /// <summary>Output only. The start time of any upcoming scheduled maintenance for this instance.</summary>
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

    /// <summary>Configuration of the persistence functionality.</summary>
    public class ClusterPersistenceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. AOF configuration. This field will be ignored if mode is not AOF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aofConfig")]
        public virtual AOFConfig AofConfig { get; set; }

        /// <summary>Optional. The mode of persistence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Optional. RDB configuration. This field will be ignored if mode is not RDB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdbConfig")]
        public virtual RDBConfig RdbConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for weekly operations.</summary>
    public class ClusterWeeklyMaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Allows to define schedule that runs specified day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Optional. Start time of the window in UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains compliance information about a security standard indicating unmet recommendations.</summary>
    public class Compliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Industry-wide compliance standards or benchmarks, such as CIS, PCI, and OWASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>Version of the standard or benchmark, for example, 1.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Config based signal data. This is used to send signals to Condor which are based on the DB level configurations.
    /// These will be used to send signals for self managed databases.
    /// </summary>
    public class ConfigBasedSignalData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Full Resource name of the source resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        private string _lastRefreshTimeRaw;

        private object _lastRefreshTime;

        /// <summary>Required. Last time signal was refreshed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshTime")]
        public virtual string LastRefreshTimeRaw
        {
            get => _lastRefreshTimeRaw;
            set
            {
                _lastRefreshTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastRefreshTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastRefreshTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastRefreshTimeDateTimeOffset instead.")]
        public virtual object LastRefreshTime
        {
            get => _lastRefreshTime;
            set
            {
                _lastRefreshTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastRefreshTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastRefreshTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastRefreshTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastRefreshTimeRaw);
            set => LastRefreshTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Database resource id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual DatabaseResourceId ResourceId { get; set; }

        /// <summary>Signal data for boolean signals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalBoolValue")]
        public virtual System.Nullable<bool> SignalBoolValue { get; set; }

        /// <summary>Required. Signal type of the signal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed information of each PSC connection.</summary>
    public class ConnectionDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Detailed information of a PSC connection that is created through service connectivity automation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscAutoConnection")]
        public virtual PscAutoConnection PscAutoConnection { get; set; }

        /// <summary>
        /// Detailed information of a PSC connection that is created by the customer who owns the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConnection")]
        public virtual PscConnection PscConnection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cross cluster replication config.</summary>
    public class CrossClusterReplicationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The role of the cluster in cross cluster replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterRole")]
        public virtual string ClusterRole { get; set; }

        /// <summary>
        /// Output only. An output only view of all the member clusters participating in the cross cluster replication.
        /// This view will be provided by every member cluster irrespective of its cluster role(primary or secondary). A
        /// primary cluster can provide information about all the secondary clusters replicating from it. However, a
        /// secondary cluster only knows about the primary cluster from which it is replicating. However, for scenarios,
        /// where the primary cluster is unavailable(e.g. regional outage), a GetCluster request can be sent to any
        /// other member cluster and this field will list all the member clusters participating in cross cluster
        /// replication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual Membership Membership { get; set; }

        /// <summary>
        /// Details of the primary cluster that is used as the replication source for this secondary cluster. This field
        /// is only set for a secondary cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryCluster")]
        public virtual RemoteCluster PrimaryCluster { get; set; }

        /// <summary>
        /// List of secondary clusters that are replicating from this primary cluster. This field is only set for a
        /// primary cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryClusters")]
        public virtual System.Collections.Generic.IList<RemoteCluster> SecondaryClusters { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time cross cluster replication config was updated.</summary>
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
    /// Any custom metadata associated with the resource. e.g. A spanner instance can have multiple databases with its
    /// own unique metadata. Information for these individual databases can be captured in custom metadata data
    /// </summary>
    public class CustomMetadataData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metadata for individual internal resources in an instance. e.g. spanner instance can have multiple databases
        /// with unique configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalResourceMetadata")]
        public virtual System.Collections.Generic.IList<InternalResourceMetadata> InternalResourceMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DatabaseResourceFeed is the top level proto to be used to ingest different database resource level events into
    /// Condor platform. Next ID: 9
    /// </summary>
    public class DatabaseResourceFeed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Config based signal data is used to ingest signals that are generated based on the configuration of the
        /// database resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configBasedSignalData")]
        public virtual ConfigBasedSignalData ConfigBasedSignalData { get; set; }

        private string _feedTimestampRaw;

        private object _feedTimestamp;

        /// <summary>Required. Timestamp when feed is generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedTimestamp")]
        public virtual string FeedTimestampRaw
        {
            get => _feedTimestampRaw;
            set
            {
                _feedTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _feedTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FeedTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FeedTimestampDateTimeOffset instead.")]
        public virtual object FeedTimestamp
        {
            get => _feedTimestamp;
            set
            {
                _feedTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _feedTimestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FeedTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FeedTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FeedTimestampRaw);
            set => FeedTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Type feed to be ingested into condor</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedType")]
        public virtual string FeedType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("observabilityMetricData")]
        public virtual ObservabilityMetricData ObservabilityMetricData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recommendationSignalData")]
        public virtual DatabaseResourceRecommendationSignalData RecommendationSignalData { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceHealthSignalData")]
        public virtual DatabaseResourceHealthSignalData ResourceHealthSignalData { get; set; }

        /// <summary>
        /// Primary key associated with the Resource. resource_id is available in individual feed level as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual DatabaseResourceId ResourceId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceMetadata")]
        public virtual DatabaseResourceMetadata ResourceMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common model for database resource health signal data.</summary>
    public class DatabaseResourceHealthSignalData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any other additional metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> AdditionalMetadata { get; set; }

        /// <summary>
        /// Industry standards associated with this signal; if this signal is an issue, that could be a violation of the
        /// associated industry standard(s). For example, AUTO_BACKUP_DISABLED signal is associated with CIS GCP 1.1,
        /// CIS GCP 1.2, CIS GCP 1.3, NIST 800-53 and ISO-27001 compliance standards. If a database resource does not
        /// have automated backup enable, it will violate these following industry standards.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliance")]
        public virtual System.Collections.Generic.IList<Compliance> Compliance { get; set; }

        /// <summary>Description associated with signal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Required. The last time at which the event described by this signal took place</summary>
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
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The external-uri of the signal, using which more information about this signal can be obtained. In GCP, this
        /// will take user to SCC page to get more details about signals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>This is used to identify the location of the resource. Example: "us-central1"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Required. The name of the signal, ex: PUBLIC_SQL_INSTANCE, SQL_LOG_ERROR_VERBOSITY etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Cloud provider name. Ex: GCP/AWS/Azure/OnPrem/SelfManaged</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>
        /// Closest parent container of this resource. In GCP, 'container' refers to a Cloud Resource Manager project.
        /// It must be resource name of a Cloud Resource Manager project with the format of "provider//", such as
        /// "projects/123". For GCP provided resources, number should be project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        /// <summary>
        /// Required. Database resource name associated with the signal. Resource name to follow CAIS resource_name
        /// format as noted here go/condor-common-datamodel
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Required. The class of the signal, such as if it's a THREAT or VULNERABILITY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalClass")]
        public virtual string SignalClass { get; set; }

        /// <summary>
        /// Required. Unique identifier for the signal. This is an unique id which would be mainatined by partner to
        /// identify a signal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalId")]
        public virtual string SignalId { get; set; }

        /// <summary>The severity of the signal, such as if it's a HIGH or LOW severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalSeverity")]
        public virtual string SignalSeverity { get; set; }

        /// <summary>
        /// Required. Type of signal, for example, `AVAILABLE_IN_MULTIPLE_ZONES`, `LOGGING_MOST_ERRORS`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DatabaseResourceId will serve as primary key for any resource ingestion event.</summary>
    public class DatabaseResourceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Cloud provider name. Ex: GCP/AWS/Azure/OnPrem/SelfManaged</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Optional. Needs to be used only when the provider is PROVIDER_OTHER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerDescription")]
        public virtual string ProviderDescription { get; set; }

        /// <summary>
        /// Required. The type of resource this ID is identifying. Ex go/keep-sorted start
        /// alloydb.googleapis.com/Cluster, alloydb.googleapis.com/Instance, bigtableadmin.googleapis.com/Cluster,
        /// bigtableadmin.googleapis.com/Instance compute.googleapis.com/Instance firestore.googleapis.com/Database,
        /// redis.googleapis.com/Instance, redis.googleapis.com/Cluster,
        /// oracledatabase.googleapis.com/CloudExadataInfrastructure oracledatabase.googleapis.com/CloudVmCluster
        /// oracledatabase.googleapis.com/AutonomousDatabase spanner.googleapis.com/Instance,
        /// spanner.googleapis.com/Database, sqladmin.googleapis.com/Instance, go/keep-sorted end REQUIRED Please refer
        /// go/condor-common-datamodel
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>
        /// Required. A service-local token that distinguishes this resource from other resources within the same
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueId")]
        public virtual string UniqueId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common model for database resource instance metadata. Next ID: 26</summary>
    public class DatabaseResourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Availability configuration for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityConfiguration")]
        public virtual AvailabilityConfiguration AvailabilityConfiguration { get; set; }

        /// <summary>Backup configuration for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfiguration")]
        public virtual BackupConfiguration BackupConfiguration { get; set; }

        /// <summary>Latest backup run information for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRun")]
        public virtual BackupRun BackupRun { get; set; }

        /// <summary>Optional. BackupDR Configuration for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupdrConfiguration")]
        public virtual BackupDRConfiguration BackupdrConfiguration { get; set; }

        private string _creationTimeRaw;

        private object _creationTime;

        /// <summary>
        /// The creation time of the resource, i.e. the time when resource is created and recorded in partner service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw
        {
            get => _creationTimeRaw;
            set
            {
                _creationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimeDateTimeOffset instead.")]
        public virtual object CreationTime
        {
            get => _creationTime;
            set
            {
                _creationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Current state of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentState")]
        public virtual string CurrentState { get; set; }

        /// <summary>Any custom metadata associated with the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetadata")]
        public virtual CustomMetadataData CustomMetadata { get; set; }

        /// <summary>
        /// Optional. Edition represents whether the instance is ENTERPRISE or ENTERPRISE_PLUS. This information is core
        /// to Cloud SQL only and is used to identify the edition of the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>Entitlements associated with the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<Entitlement> Entitlements { get; set; }

        /// <summary>
        /// The state that the instance is expected to be in. For example, an instance state can transition to UNHEALTHY
        /// due to wrong patch update, while the expected state will remain at the HEALTHY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedState")]
        public virtual string ExpectedState { get; set; }

        /// <summary>GCBDR configuration for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcbdrConfiguration")]
        public virtual GCBDRConfiguration GcbdrConfiguration { get; set; }

        /// <summary>Required. Unique identifier for a Database resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual DatabaseResourceId Id { get; set; }

        /// <summary>The type of the instance. Specified at creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>The resource location. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Machine configuration for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineConfiguration")]
        public virtual MachineConfiguration MachineConfiguration { get; set; }

        /// <summary>
        /// Identifier for this resource's immediate parent/primary resource if the current resource is a replica or
        /// derived form of another Database resource. Else it would be NULL. REQUIRED if the immediate parent exists
        /// when first time resource is getting ingested, otherwise optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryResourceId")]
        public virtual DatabaseResourceId PrimaryResourceId { get; set; }

        /// <summary>
        /// Primary resource location. REQUIRED if the immediate parent exists when first time resource is getting
        /// ingested, otherwise optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryResourceLocation")]
        public virtual string PrimaryResourceLocation { get; set; }

        /// <summary>The product this resource represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        /// <summary>
        /// Closest parent Cloud Resource Manager container of this resource. It must be resource name of a Cloud
        /// Resource Manager project with the format of "/", such as "projects/123". For GCP provided resources, number
        /// should be project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        /// <summary>
        /// Required. Different from DatabaseResourceId.unique_id, a resource name can be reused over time. That is,
        /// after a resource named "ABC" is deleted, the name "ABC" can be used to to create a new resource within the
        /// same source. Resource name to follow CAIS resource_name format as noted here go/condor-common-datamodel
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Optional. Suspension reason for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReason")]
        public virtual string SuspensionReason { get; set; }

        /// <summary>Optional. Tags associated with this resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagsSet")]
        public virtual Tags TagsSet { get; set; }

        private string _updationTimeRaw;

        private object _updationTime;

        /// <summary>The time at which the resource was updated and recorded at partner service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updationTime")]
        public virtual string UpdationTimeRaw
        {
            get => _updationTimeRaw;
            set
            {
                _updationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdationTimeDateTimeOffset instead.")]
        public virtual object UpdationTime
        {
            get => _updationTime;
            set
            {
                _updationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updationTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdationTimeRaw);
            set => UpdationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>User-provided labels associated with the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabelSet")]
        public virtual UserLabels UserLabelSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common model for database resource recommendation signal data.</summary>
    public class DatabaseResourceRecommendationSignalData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Any other additional metadata specific to recommendation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> AdditionalMetadata { get; set; }

        private string _lastRefreshTimeRaw;

        private object _lastRefreshTime;

        /// <summary>Required. last time recommendationw as refreshed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshTime")]
        public virtual string LastRefreshTimeRaw
        {
            get => _lastRefreshTimeRaw;
            set
            {
                _lastRefreshTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastRefreshTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastRefreshTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastRefreshTimeDateTimeOffset instead.")]
        public virtual object LastRefreshTime
        {
            get => _lastRefreshTime;
            set
            {
                _lastRefreshTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastRefreshTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastRefreshTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastRefreshTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastRefreshTimeRaw);
            set => LastRefreshTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Recommendation state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendationState")]
        public virtual string RecommendationState { get; set; }

        /// <summary>
        /// Required. Name of recommendation. Examples:
        /// organizations/1234/locations/us-central1/recommenders/google.cloudsql.instance.PerformanceRecommender/recommendations/9876
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommender")]
        public virtual string Recommender { get; set; }

        /// <summary>Required. ID of recommender. Examples: "google.cloudsql.instance.PerformanceRecommender"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommenderId")]
        public virtual string RecommenderId { get; set; }

        /// <summary>
        /// Required. Contains an identifier for a subtype of recommendations produced for the same recommender. Subtype
        /// is a function of content and impact, meaning a new subtype might be added when significant changes to
        /// `content` or `primary_impact.category` are introduced. See the Recommenders section to see a list of
        /// subtypes for a given Recommender. Examples: For recommender =
        /// "google.cloudsql.instance.PerformanceRecommender", recommender_subtype can be
        /// "MYSQL_HIGH_NUMBER_OF_OPEN_TABLES_BEST_PRACTICE"/"POSTGRES_HIGH_TRANSACTION_ID_UTILIZATION_BEST_PRACTICE"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommenderSubtype")]
        public virtual string RecommenderSubtype { get; set; }

        /// <summary>
        /// Required. Database resource name associated with the signal. Resource name to follow CAIS resource_name
        /// format as noted here go/condor-common-datamodel
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Required. Type of signal, for example, `SIGNAL_TYPE_IDLE`, `SIGNAL_TYPE_HIGH_NUMBER_OF_TABLES`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Endpoints on each network, for Redis clients to connect to the cluster.</summary>
    public class DiscoveryEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Address of the exposed Redis endpoint used by clients to connect to the service. The address
        /// could be either IP or hostname.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Output only. The port number of the exposed Redis endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Output only. Customer configuration for where the endpoint is created and accessed from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConfig")]
        public virtual PscConfig PscConfig { get; set; }

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

    /// <summary>EncryptionInfo describes the encryption information of a cluster or a backup.</summary>
    public class EncryptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Type of encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>
        /// Output only. The state of the primary version of the KMS key perceived by the system. This field is not
        /// populated in backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyPrimaryState")]
        public virtual string KmsKeyPrimaryState { get; set; }

        /// <summary>Output only. KMS key versions that are being used to protect the data at-rest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersions")]
        public virtual System.Collections.Generic.IList<string> KmsKeyVersions { get; set; }

        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>Output only. The most recent time when the encryption info was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto representing the access that a user has to a specific feature/service. NextId: 3.</summary>
    public class Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current state of user's accessibility to a feature/benefit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementState")]
        public virtual string EntitlementState { get; set; }

        /// <summary>An enum that represents the type of this entitlement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for [ExportBackup].</summary>
    public class ExportBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage bucket, like "my-bucket".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBucket")]
        public virtual string GcsBucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for Export.</summary>
    public class ExportInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specify data to be exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual OutputConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for Failover.</summary>
    public class FailoverInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Available data protection modes that the user can choose. If it's unspecified, data protection
        /// mode will be LIMITED_DATA_LOSS by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProtectionMode")]
        public virtual string DataProtectionMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This schedule allows the backup to be triggered at a fixed frequency (currently only daily is supported).
    /// </summary>
    public class FixedFrequencySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The start time of every automated backup in UTC. It must be set to the start of an hour. This
        /// field is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GCBDR Configuration for the resource.</summary>
    public class GCBDRConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the resource is managed by GCBDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcbdrManaged")]
        public virtual System.Nullable<bool> GcbdrManaged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Backups stored in Cloud Storage buckets. The Cloud Storage buckets need to be the same region as the clusters.
    /// </summary>
    public class GcsBackupSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. URIs of the Cloud Storage objects to import. Example: gs://bucket1/object1,
        /// gs://bucket2/folder2/object2
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Cloud Storage location for the output content</summary>
    public class GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Data destination URI (e.g. 'gs://my_bucket/my_object'). Existing files will be overwritten.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Cloud Storage location for the input content</summary>
    public class GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Source data URI. (e.g. 'gs://my_bucket/my_object').</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This location metadata represents additional configuration options for a given location where a Redis instance
    /// may be created. All fields are output only. It is returned as content of the
    /// `google.cloud.location.Location.metadata` field.
    /// </summary>
    public class GoogleCloudRedisV1LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The set of available zones in the location. The map is keyed by the lowercase ID of each zone,
        /// as defined by GCE. These keys can be specified in `location_id` or `alternative_location_id` fields when
        /// creating a Redis instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableZones")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRedisV1ZoneMetadata> AvailableZones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the v1 metadata of the long-running operation.</summary>
    public class GoogleCloudRedisV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Specifies if cancellation was requested for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Creation timestamp.</summary>
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

        /// <summary>End timestamp.</summary>
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

        /// <summary>Operation status details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Operation target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Operation verb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines specific information for a particular zone. Currently empty and reserved for future use only.
    /// </summary>
    public class GoogleCloudRedisV1ZoneMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for Import.</summary>
    public class ImportInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specify data to be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual InputConfig InputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The input content</summary>
    public class InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage location where input content is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Memorystore for Redis instance.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If specified, at least one node will be provisioned in this zone in addition to the zone specified
        /// in location_id. Only applicable to standard tier. If provided, it must be a different zone from the one
        /// provided in [location_id]. Additional nodes beyond the first 2 will be placed in zones selected by the
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternativeLocationId")]
        public virtual string AlternativeLocationId { get; set; }

        /// <summary>
        /// Optional. Indicates whether OSS Redis AUTH is enabled for the instance. If set to "true" AUTH is enabled on
        /// the instance. Default value is "false" meaning AUTH is disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authEnabled")]
        public virtual System.Nullable<bool> AuthEnabled { get; set; }

        /// <summary>
        /// Optional. The full name of the Google Compute Engine [network](https://cloud.google.com/vpc/docs/vpc) to
        /// which the instance is connected. If left unspecified, the `default` network will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedNetwork")]
        public virtual string AuthorizedNetwork { get; set; }

        /// <summary>Optional. The available maintenance versions that an instance could update to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableMaintenanceVersions")]
        public virtual System.Collections.Generic.IList<string> AvailableMaintenanceVersions { get; set; }

        /// <summary>
        /// Optional. The network connect mode of the Redis instance. If not provided, the connect mode defaults to
        /// DIRECT_PEERING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectMode")]
        public virtual string ConnectMode { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the instance was created.</summary>
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
        /// Output only. The current zone where the Redis primary node is located. In basic tier, this will always be
        /// the same as [location_id]. In standard tier, this can be the zone of any node in the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentLocationId")]
        public virtual string CurrentLocationId { get; set; }

        /// <summary>
        /// Optional. The KMS key reference that the customer provides when trying to create the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerManagedKey")]
        public virtual string CustomerManagedKey { get; set; }

        /// <summary>An arbitrary and optional user-provided name for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Hostname or IP address of the exposed Redis endpoint used by clients to connect to the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Resource labels to represent user provided metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The zone where the instance will be provisioned. If not provided, the service will choose a zone
        /// from the specified region for the instance. For standard tier, additional nodes will be added across
        /// multiple zones for protection against zonal failures. If specified, at least one node will be provisioned in
        /// this zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Optional. The maintenance policy for the instance. If not provided, maintenance events can be performed at
        /// any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicy")]
        public virtual MaintenancePolicy MaintenancePolicy { get; set; }

        /// <summary>Output only. Date and time of upcoming maintenance events which have been scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSchedule")]
        public virtual MaintenanceSchedule MaintenanceSchedule { get; set; }

        /// <summary>
        /// Optional. The self service update maintenance version. The version is date based such as "20210712_00_00".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceVersion")]
        public virtual string MaintenanceVersion { get; set; }

        /// <summary>Required. Redis memory size in GiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; }

        /// <summary>
        /// Required. Unique name of the resource in this scope including project and location using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note: Redis instances are managed
        /// and addressed at regional level so location_id here refers to a GCP region; however, users may choose which
        /// specific zone (or collection of zones for cross-zone instances) an instance should be provisioned in. Refer
        /// to location_id and alternative_location_id fields for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Info per node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<NodeInfo> Nodes { get; set; }

        /// <summary>Optional. Persistence configuration parameters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistenceConfig")]
        public virtual PersistenceConfig PersistenceConfig { get; set; }

        /// <summary>
        /// Output only. Cloud IAM identity used by import / export operations to transfer data to/from Cloud Storage.
        /// Format is "serviceAccount:". The value may change over time for a given instance so should be checked before
        /// each import/export operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistenceIamIdentity")]
        public virtual string PersistenceIamIdentity { get; set; }

        /// <summary>Output only. The port number of the exposed Redis endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Output only. Hostname or IP address of the exposed readonly Redis endpoint. Standard tier only. Targets all
        /// healthy replica nodes in instance. Replication is asynchronous and replica nodes will exhibit some lag
        /// behind the primary. Write requests must target 'host'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readEndpoint")]
        public virtual string ReadEndpoint { get; set; }

        /// <summary>
        /// Output only. The port number of the exposed readonly redis endpoint. Standard tier only. Write requests
        /// should target 'port'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readEndpointPort")]
        public virtual System.Nullable<int> ReadEndpointPort { get; set; }

        /// <summary>Optional. Read replicas mode for the instance. Defaults to READ_REPLICAS_DISABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readReplicasMode")]
        public virtual string ReadReplicasMode { get; set; }

        /// <summary>
        /// Optional. Redis configuration parameters, according to http://redis.io/topics/config. Currently, the only
        /// supported parameters are: Redis version 3.2 and newer: * maxmemory-policy * notify-keyspace-events Redis
        /// version 4.0 and newer: * activedefrag * lfu-decay-time * lfu-log-factor * maxmemory-gb Redis version 5.0 and
        /// newer: * stream-node-max-bytes * stream-node-max-entries
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, string> RedisConfigs { get; set; }

        /// <summary>
        /// Optional. The version of Redis software. If not provided, the default version will be used. Currently, the
        /// supported values are: * `REDIS_3_2` for Redis 3.2 compatibility * `REDIS_4_0` for Redis 4.0 compatibility *
        /// `REDIS_5_0` for Redis 5.0 compatibility * `REDIS_6_X` for Redis 6.x compatibility * `REDIS_7_0` for Redis
        /// 7.0 compatibility (default) * `REDIS_7_2` for Redis 7.2 compatibility
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisVersion")]
        public virtual string RedisVersion { get; set; }

        /// <summary>
        /// Optional. The number of replica nodes. The valid range for the Standard Tier with read replicas enabled is
        /// [1-5] and defaults to 2. If read replicas are not enabled for a Standard Tier instance, the only valid value
        /// is 1 and the default is 1. The valid value for basic tier is 0 and the default is also 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<int> ReplicaCount { get; set; }

        /// <summary>
        /// Optional. For DIRECT_PEERING mode, the CIDR range of internal addresses that are reserved for this instance.
        /// Range must be unique and non-overlapping with existing subnets in an authorized network. For
        /// PRIVATE_SERVICE_ACCESS mode, the name of one allocated IP address ranges associated with this private
        /// service access connection. If not provided, the service will choose an unused /29 block, for example,
        /// 10.0.0.0/29 or 192.168.0.0/29. For READ_REPLICAS_ENABLED the default block size is /28.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedIpRange")]
        public virtual string ReservedIpRange { get; set; }

        /// <summary>Optional. Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Optional. Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Optional. Additional IP range for node placement. Required when enabling read replicas on an existing
        /// instance. For DIRECT_PEERING mode value must be a CIDR range of size /28, or "auto". For
        /// PRIVATE_SERVICE_ACCESS mode value must be the name of an allocated address range associated with the private
        /// service access connection, or "auto".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryIpRange")]
        public virtual string SecondaryIpRange { get; set; }

        /// <summary>Output only. List of server CA certificates for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaCerts")]
        public virtual System.Collections.Generic.IList<TlsCertificate> ServerCaCerts { get; set; }

        /// <summary>Output only. The current state of this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Additional information about the current status of this instance, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Optional. reasons that causes instance in "SUSPENDED" state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReasons")]
        public virtual System.Collections.Generic.IList<string> SuspensionReasons { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag keys/values directly bound to this resource. For example:
        /// "123/environment": "production", "123/costCenter": "marketing"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>Required. The service tier of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>
        /// Optional. The TLS mode of the Redis instance. If not provided, TLS is disabled for the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitEncryptionMode")]
        public virtual string TransitEncryptionMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance AUTH string details.</summary>
    public class InstanceAuthString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AUTH string set on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authString")]
        public virtual string AuthString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for individual internal resources in an instance. e.g. spanner instance can have multiple databases
    /// with unique configuration settings. Similarly bigtable can have multiple clusters within same bigtable instance.
    /// </summary>
    public class InternalResourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Backup configuration for this database</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfiguration")]
        public virtual BackupConfiguration BackupConfiguration { get; set; }

        /// <summary>Information about the last backup attempt for this database</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRun")]
        public virtual BackupRun BackupRun { get; set; }

        /// <summary>Whether deletion protection is enabled for this internal resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDeletionProtectionEnabled")]
        public virtual System.Nullable<bool> IsDeletionProtectionEnabled { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual DatabaseResourceId ResourceId { get; set; }

        /// <summary>
        /// Required. internal resource name for spanner this will be database name
        /// e.g."spanner.googleapis.com/projects/123/abc/instances/inst1/databases/db1"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for [ListBackupCollections].</summary>
    public class ListBackupCollectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of backupCollections in the project. If the `location_id` in the parent field of the request is "-",
        /// all regions available to the project are queried, and the results aggregated. If in such an aggregated query
        /// a location is unavailable, a placeholder backupCollection entry is included in the response with the `name`
        /// field set to a value of the form `projects/{project_id}/locations/{location_id}/backupCollections/`- and the
        /// `status` field set to ERROR and `status_message` field set to "location not available for
        /// ListBackupCollections".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupCollections")]
        public virtual System.Collections.Generic.IList<BackupCollection> BackupCollections { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for [ListBackups].</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of backups in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Backups that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListClusters.</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of Redis clusters in the project in the specified location, or across all locations. If the
        /// `location_id` in the parent field of the request is "-", all regions available to the project are queried,
        /// and the results aggregated. If in such an aggregated query a location is unavailable, a placeholder Redis
        /// entry is included in the response with the `name` field set to a value of the form
        /// `projects/{project_id}/locations/{location_id}/clusters/`- and the `status` field set to ERROR and
        /// `status_message` field set to "location not available for ListClusters".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListInstances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of Redis instances in the project in the specified location, or across all locations. If the
        /// `location_id` in the parent field of the request is "-", all regions available to the project are queried,
        /// and the results aggregated. If in such an aggregated query a location is unavailable, a placeholder Redis
        /// entry is included in the response with the `name` field set to a value of the form
        /// `projects/{project_id}/locations/{location_id}/instances/`- and the `status` field set to ERROR and
        /// `status_message` field set to "location not available for ListInstances".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

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

        /// <summary>Resource ID for the region. For example: "us-east1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Output only. The set of available zones in the location. The map is keyed by the lowercase ID of each zone,
        /// as defined by Compute Engine. These keys can be specified in `location_id` or `alternative_location_id`
        /// fields when creating a Redis instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Full resource name for the region. For example: "projects/example-project/locations/us-east1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MachineConfiguration describes the configuration of a machine specific to Database Resource.</summary>
    public class MachineConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of CPUs. Deprecated. Use vcpu_count instead. TODO(b/342344482) add proto validations again after
        /// bug fix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCount")]
        public virtual System.Nullable<int> CpuCount { get; set; }

        /// <summary>Memory size in bytes. TODO(b/342344482) add proto validations again after bug fix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeInBytes")]
        public virtual System.Nullable<long> MemorySizeInBytes { get; set; }

        /// <summary>Optional. Number of shards (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<int> ShardCount { get; set; }

        /// <summary>
        /// Optional. The number of vCPUs. TODO(b/342344482) add proto validations again after bug fix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcpuCount")]
        public virtual System.Nullable<double> VcpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maintenance policy for an instance.</summary>
    public class MaintenancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the policy was created.</summary>
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
        /// Optional. Description of what this policy is for. Create/Update methods return INVALID_ARGUMENT if the
        /// length is greater than 512.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the policy was last updated.</summary>
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
        /// Optional. Maintenance window that is applied to resources covered by this policy. Minimum 1. For the current
        /// version, the maximum number of weekly_window is expected to be one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyMaintenanceWindow")]
        public virtual System.Collections.Generic.IList<WeeklyMaintenanceWindow> WeeklyMaintenanceWindow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Upcoming maintenance schedule. If no maintenance is scheduled, fields are not populated.</summary>
    public class MaintenanceSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the scheduled maintenance can be rescheduled, default is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReschedule")]
        public virtual System.Nullable<bool> CanReschedule { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The end time of any upcoming scheduled maintenance for this instance.</summary>
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

        private string _scheduleDeadlineTimeRaw;

        private object _scheduleDeadlineTime;

        /// <summary>
        /// Output only. The deadline that the maintenance schedule start time can not go beyond, including reschedule.
        /// </summary>
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

        /// <summary>Output only. The start time of any upcoming scheduled maintenance for this instance.</summary>
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

    /// <summary>Backups that generated and managed by memorystore.</summary>
    public class ManagedBackupSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Example:
        /// //redis.googleapis.com/projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup}
        /// A shorter version (without the prefix) of the backup name is also supported, like
        /// projects/{project}/locations/{location}/backupCollections/{collection}/backups/{backup_id} In this case, it
        /// assumes the backup is under redis.googleapis.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ManagedCertificateAuthority : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The PEM encoded CA certificate chains for redis managed server authentication</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCerts")]
        public virtual System.Collections.Generic.IList<CertChain> CaCerts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An output only view of all the member clusters participating in the cross cluster replication.
    /// </summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The primary cluster that acts as the source of replication for the secondary clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryCluster")]
        public virtual RemoteCluster PrimaryCluster { get; set; }

        /// <summary>Output only. The list of secondary clusters replicating from the primary cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryClusters")]
        public virtual System.Collections.Generic.IList<RemoteCluster> SecondaryClusters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Node specific properties.</summary>
    public class NodeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Node identifying string. e.g. 'node-0', 'node-1'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Location of the node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ObservabilityMetricData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Type of aggregation performed on the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationType")]
        public virtual string AggregationType { get; set; }

        /// <summary>Required. Type of metric like CPU, Memory, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricType")]
        public virtual string MetricType { get; set; }

        private string _observationTimeRaw;

        private object _observationTime;

        /// <summary>Required. The time the metric value was observed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observationTime")]
        public virtual string ObservationTimeRaw
        {
            get => _observationTimeRaw;
            set
            {
                _observationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _observationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ObservationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ObservationTimeDateTimeOffset instead.")]
        public virtual object ObservationTime
        {
            get => _observationTime;
            set
            {
                _observationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _observationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ObservationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ObservationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ObservationTimeRaw);
            set => ObservationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. Database resource name associated with the signal. Resource name to follow CAIS resource_name
        /// format as noted here go/condor-common-datamodel
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Required. Value of the metric type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual TypedValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
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
        /// { `createTime`: The time the operation was created. `endTime`: The time the operation finished running.
        /// `target`: Server-defined resource path for the target of the operation. `verb`: Name of the verb executed by
        /// the operation. `statusDetail`: Human-readable status of the operation, if any. `cancelRequested`: Identifies
        /// whether the user has requested cancellation of the operation. Operations that have successfully been
        /// cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// `apiVersion`: API version used to start the operation. }
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

    /// <summary>An error that occurred during a backup creation operation.</summary>
    public class OperationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the specific error that occurred. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("errorType")]
        public virtual string ErrorType { get; set; }

        /// <summary>Additional information about the error encountered. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pre-defined metadata fields.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
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

    /// <summary>The output content</summary>
    public class OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage destination for output content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of the persistence functionality.</summary>
    public class PersistenceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Controls whether Persistence features are enabled. If not provided, the existing value will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistenceMode")]
        public virtual string PersistenceMode { get; set; }

        private string _rdbNextSnapshotTimeRaw;

        private object _rdbNextSnapshotTime;

        /// <summary>Output only. The next time that a snapshot attempt is scheduled to occur.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdbNextSnapshotTime")]
        public virtual string RdbNextSnapshotTimeRaw
        {
            get => _rdbNextSnapshotTimeRaw;
            set
            {
                _rdbNextSnapshotTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _rdbNextSnapshotTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RdbNextSnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RdbNextSnapshotTimeDateTimeOffset instead.")]
        public virtual object RdbNextSnapshotTime
        {
            get => _rdbNextSnapshotTime;
            set
            {
                _rdbNextSnapshotTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _rdbNextSnapshotTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RdbNextSnapshotTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RdbNextSnapshotTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RdbNextSnapshotTimeRaw);
            set => RdbNextSnapshotTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Period between RDB snapshots. Snapshots will be attempted every period starting from the provided
        /// snapshot start time. For example, a start time of 01/01/2033 06:45 and SIX_HOURS snapshot period will do
        /// nothing until 01/01/2033, and then trigger snapshots every day at 06:45, 12:45, 18:45, and 00:45 the next
        /// day, and so on. If not provided, TWENTY_FOUR_HOURS will be used as default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdbSnapshotPeriod")]
        public virtual string RdbSnapshotPeriod { get; set; }

        private string _rdbSnapshotStartTimeRaw;

        private object _rdbSnapshotStartTime;

        /// <summary>
        /// Optional. Date and time that the first snapshot was/will be attempted, and to which future snapshots will be
        /// aligned. If not provided, the current time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdbSnapshotStartTime")]
        public virtual string RdbSnapshotStartTimeRaw
        {
            get => _rdbSnapshotStartTimeRaw;
            set
            {
                _rdbSnapshotStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _rdbSnapshotStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RdbSnapshotStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RdbSnapshotStartTimeDateTimeOffset instead.")]
        public virtual object RdbSnapshotStartTime
        {
            get => _rdbSnapshotStartTime;
            set
            {
                _rdbSnapshotStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _rdbSnapshotStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RdbSnapshotStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RdbSnapshotStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RdbSnapshotStartTimeRaw);
            set => RdbSnapshotStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product specification for Condor resources.</summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specific engine that the underlying database is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>
        /// Minor version of the underlying database engine. Example values: For MySQL, it could be "8.0.32", "5.7.32"
        /// etc.. For Postgres, it could be "14.3", "15.3" etc..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minorVersion")]
        public virtual string MinorVersion { get; set; }

        /// <summary>Type of specific database product. It could be CloudSQL, AlloyDB etc..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Version of the underlying database engine. Example values: For MySQL, it could be "8.0", "5.7" etc.. For
        /// Postgres, it could be "14", "15" etc..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of consumer resources in a PSC connection that is created through Service Connectivity Automation.
    /// </summary>
    public class PscAutoConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The IP allocated on the consumer network for the PSC forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Output only. Type of the PSC connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>
        /// Output only. The URI of the consumer side forwarding rule. Example:
        /// projects/{projectNumOrId}/regions/us-east1/forwardingRules/{resourceId}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRule")]
        public virtual string ForwardingRule { get; set; }

        /// <summary>
        /// Required. The consumer network where the IP address resides, in the form of
        /// projects/{project_id}/global/networks/{network_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Required. The consumer project_id where the forwarding rule is created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Output only. The PSC connection id of the forwarding rule connected to the service attachment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConnectionId")]
        public virtual string PscConnectionId { get; set; }

        /// <summary>
        /// Output only. The status of the PSC connection. Please note that this value is updated periodically. Please
        /// use Private Service Connect APIs for the latest status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConnectionStatus")]
        public virtual string PscConnectionStatus { get; set; }

        /// <summary>
        /// Output only. The service attachment which is the target of the PSC connection, in the form of
        /// projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachment")]
        public virtual string ServiceAttachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PscConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The network where the IP address of the discovery endpoint will be reserved, in the form of
        /// projects/{network_project}/global/networks/{network_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of consumer resources in a PSC connection.</summary>
    public class PscConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The IP allocated on the consumer network for the PSC forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Output only. Type of the PSC connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>
        /// Required. The URI of the consumer side forwarding rule. Example:
        /// projects/{projectNumOrId}/regions/us-east1/forwardingRules/{resourceId}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRule")]
        public virtual string ForwardingRule { get; set; }

        /// <summary>
        /// Required. The consumer network where the IP address resides, in the form of
        /// projects/{project_id}/global/networks/{network_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Output only. port will only be set for Primary/Reader or Discovery endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Optional. Project ID of the consumer project where the forwarding rule is created in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Required. The PSC connection id of the forwarding rule connected to the service attachment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConnectionId")]
        public virtual string PscConnectionId { get; set; }

        /// <summary>
        /// Output only. The status of the PSC connection. Please note that this value is updated periodically. To get
        /// the latest status of a PSC connection, follow
        /// https://cloud.google.com/vpc/docs/configure-private-service-connect-services#endpoint-details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscConnectionStatus")]
        public virtual string PscConnectionStatus { get; set; }

        /// <summary>
        /// Required. The service attachment which is the target of the PSC connection, in the form of
        /// projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachment")]
        public virtual string ServiceAttachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of a service attachment of the cluster, for creating PSC connections.</summary>
    public class PscServiceAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Type of a PSC connection targeting this service attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>
        /// Output only. Service attachment URI which your self-created PscConnection should use as target
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachment")]
        public virtual string ServiceAttachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of the RDB based persistence.</summary>
    public class RDBConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Period between RDB snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdbSnapshotPeriod")]
        public virtual string RdbSnapshotPeriod { get; set; }

        private string _rdbSnapshotStartTimeRaw;

        private object _rdbSnapshotStartTime;

        /// <summary>
        /// Optional. The time that the first snapshot was/will be attempted, and to which future snapshots will be
        /// aligned. If not provided, the current time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rdbSnapshotStartTime")]
        public virtual string RdbSnapshotStartTimeRaw
        {
            get => _rdbSnapshotStartTimeRaw;
            set
            {
                _rdbSnapshotStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _rdbSnapshotStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RdbSnapshotStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RdbSnapshotStartTimeDateTimeOffset instead.")]
        public virtual object RdbSnapshotStartTime
        {
            get => _rdbSnapshotStartTime;
            set
            {
                _rdbSnapshotStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _rdbSnapshotStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RdbSnapshotStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RdbSnapshotStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RdbSnapshotStartTimeRaw);
            set => RdbSnapshotStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata returned by the CLH during resource state reconciliation.</summary>
    public class ReconciliationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DEPRECATED. Use exclusive_action instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteResource")]
        public virtual System.Nullable<bool> DeleteResource { get; set; }

        /// <summary>Excluisive action returned by the CLH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusiveAction")]
        public virtual string ExclusiveAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the remote cluster associated with this cluster in a cross cluster replication setup.
    /// </summary>
    public class RemoteCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The full resource path of the remote cluster in the format: projects//locations//clusters/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Output only. The unique identifier of the remote cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for rescheduling a cluster maintenance.</summary>
    public class RescheduleClusterMaintenanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rescheduleType")]
        public virtual string RescheduleType { get; set; }

        private string _scheduleTimeRaw;

        private object _scheduleTime;

        /// <summary>
        /// Optional. Timestamp when the maintenance shall be rescheduled to if reschedule_type=SPECIFIC_TIME, in RFC
        /// 3339 format, for example `2012-11-15T16:19:00.094Z`.
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

    /// <summary>Request for RescheduleMaintenance.</summary>
    public class RescheduleMaintenanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rescheduleType")]
        public virtual string RescheduleType { get; set; }

        private string _scheduleTimeRaw;

        private object _scheduleTime;

        /// <summary>
        /// Optional. Timestamp when the maintenance shall be rescheduled to if reschedule_type=SPECIFIC_TIME, in RFC
        /// 3339 format, for example `2012-11-15T16:19:00.094Z`.
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

    public class RetentionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Duration based retention period i.e. 172800 seconds (2 days)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationBasedRetention")]
        public virtual object DurationBasedRetention { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("quantityBasedRetention")]
        public virtual System.Nullable<int> QuantityBasedRetention { get; set; }

        /// <summary>The unit that 'retained_backups' represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionUnit")]
        public virtual string RetentionUnit { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timeBasedRetention")]
        public virtual object TimeBasedRetention { get; set; }

        private string _timestampBasedRetentionTimeRaw;

        private object _timestampBasedRetentionTime;

        /// <summary>Timestamp based retention period i.e. 2024-05-01T00:00:00Z</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampBasedRetentionTime")]
        public virtual string TimestampBasedRetentionTimeRaw
        {
            get => _timestampBasedRetentionTimeRaw;
            set
            {
                _timestampBasedRetentionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampBasedRetentionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampBasedRetentionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampBasedRetentionTimeDateTimeOffset instead.")]
        public virtual object TimestampBasedRetentionTime
        {
            get => _timestampBasedRetentionTime;
            set
            {
                _timestampBasedRetentionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestampBasedRetentionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampBasedRetentionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampBasedRetentionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampBasedRetentionTimeRaw);
            set => TimestampBasedRetentionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents additional information about the state of the cluster.</summary>
    public class StateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes ongoing update on the cluster when cluster state is UPDATING.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateInfo")]
        public virtual UpdateInfo UpdateInfo { get; set; }

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

    /// <summary>
    /// Message type for storing tags. Tags provide a way to create annotations for resources, and in some cases
    /// conditionally allow or deny policies based on whether a resource has a specific tag.
    /// </summary>
    public class Tags : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Tag key/value mappings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TlsCertificate Resource</summary>
    public class TlsCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cert")]
        public virtual string Cert { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time when the certificate was created in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// format, for example `2020-05-18T00:00:00.094Z`.
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

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The time when the certificate expires in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// format, for example `2020-05-18T00:00:00.094Z`.
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

        /// <summary>Serial number, as extracted from the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>Sha1 Fingerprint of the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Fingerprint")]
        public virtual string Sha1Fingerprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TypedValue represents the value of a metric type. It can either be a double, an int64, a string or a bool.
    /// </summary>
    public class TypedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For boolean value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>For double value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>For integer value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>For string value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents information about an updating cluster.</summary>
    public class UpdateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target node type for redis cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNodeType")]
        public virtual string TargetNodeType { get; set; }

        /// <summary>Target number of replica nodes per shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetReplicaCount")]
        public virtual System.Nullable<int> TargetReplicaCount { get; set; }

        /// <summary>Target number of shards for redis cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetShardCount")]
        public virtual System.Nullable<int> TargetShardCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for UpgradeInstance.</summary>
    public class UpgradeInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the target version of Redis software to upgrade to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisVersion")]
        public virtual string RedisVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message type for storing user labels. User labels are used to tag App Engine resources, allowing users to search
    /// for resources matching a set of labels and to aggregate usage data by labels.
    /// </summary>
    public class UserLabels : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Time window in which disruptive maintenance updates occur. Non-disruptive updates can occur inside or outside
    /// this window.
    /// </summary>
    public class WeeklyMaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The day of week that maintenance updates occur.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Output only. Duration of the maintenance window. The current window is fixed at 1 hour.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Required. Start time of the window in UTC time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Zone distribution config for allocation of cluster resources.</summary>
    public class ZoneDistributionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The mode of zone distribution. Defaults to MULTI_ZONE, when not specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// Optional. When SINGLE ZONE distribution is selected, zone field would be used to allocate all resources in
        /// that zone. This is not applicable to MULTI_ZONE, and would be ignored for MULTI_ZONE clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
