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

namespace Google.Apis.Backupdr.v1
{
    /// <summary>The Backupdr Service.</summary>
    public class BackupdrService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BackupdrService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BackupdrService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://backupdr.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://backupdr.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "backupdr";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Backup and DR Service API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Backup and DR Service API.</summary>
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

    /// <summary>A base abstract class for Backupdr requests.</summary>
    public abstract class BackupdrBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BackupdrBaseServiceRequest instance.</summary>
        protected BackupdrBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Backupdr parameter list.</summary>
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
                BackupPlanAssociations = new BackupPlanAssociationsResource(service);
                BackupPlans = new BackupPlansResource(service);
                BackupVaults = new BackupVaultsResource(service);
                ManagementServers = new ManagementServersResource(service);
                Operations = new OperationsResource(service);
                ResourceBackupConfigs = new ResourceBackupConfigsResource(service);
                ServiceConfig = new ServiceConfigResource(service);
            }

            /// <summary>Gets the BackupPlanAssociations resource.</summary>
            public virtual BackupPlanAssociationsResource BackupPlanAssociations { get; }

            /// <summary>The "backupPlanAssociations" collection of methods.</summary>
            public class BackupPlanAssociationsResource
            {
                private const string Resource = "backupPlanAssociations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupPlanAssociationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a BackupPlanAssociation</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The backup plan association project and location in the format
                /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations map to GCP regions, for
                /// example **us-central1**.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Backupdr.v1.Data.BackupPlanAssociation body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a BackupPlanAssociation</summary>
                public class CreateRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.BackupPlanAssociation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backup plan association project and location in the format
                    /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations map to GCP regions,
                    /// for example **us-central1**.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The name of the backup plan association to create. The name must be unique for the
                    /// specified project and location.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupPlanAssociationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupPlanAssociationId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and t he request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.BackupPlanAssociation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupPlanAssociations";

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
                        RequestParameters.Add("backupPlanAssociationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "backupPlanAssociationId",
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

                /// <summary>Deletes a single BackupPlanAssociation.</summary>
                /// <param name="name">
                /// Required. Name of the backup plan association resource, in the format
                /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single BackupPlanAssociation.</summary>
                public class DeleteRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backup plan association resource, in the format
                    /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlanAssociations/[^/]+$",
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

                /// <summary>Gets details of a single BackupPlanAssociation.</summary>
                /// <param name="name">
                /// Required. Name of the backup plan association resource, in the format
                /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single BackupPlanAssociation.</summary>
                public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.BackupPlanAssociation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backup plan association resource, in the format
                    /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlanAssociations/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists BackupPlanAssociations in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve backup Plan Associations information, in
                /// the format `projects/{project_id}/locations/{location}`. In Cloud BackupDR, locations map to GCP
                /// regions, for example **us-central1**. To retrieve backup plan associations for all locations, use
                /// "-" for the `{location}` value.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists BackupPlanAssociations in a given project and location.</summary>
                public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListBackupPlanAssociationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve backup Plan Associations information,
                    /// in the format `projects/{project_id}/locations/{location}`. In Cloud BackupDR, locations map to
                    /// GCP regions, for example **us-central1**. To retrieve backup plan associations for all
                    /// locations, use "-" for the `{location}` value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupPlanAssociations";

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

                /// <summary>Triggers a new Backup.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the backup plan association resource, in the format
                /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
                /// </param>
                public virtual TriggerBackupRequest TriggerBackup(Google.Apis.Backupdr.v1.Data.TriggerBackupRequest body, string name)
                {
                    return new TriggerBackupRequest(this.service, body, name);
                }

                /// <summary>Triggers a new Backup.</summary>
                public class TriggerBackupRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new TriggerBackup request.</summary>
                    public TriggerBackupRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.TriggerBackupRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backup plan association resource, in the format
                    /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.TriggerBackupRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "triggerBackup";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:triggerBackup";

                    /// <summary>Initializes TriggerBackup parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlanAssociations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the BackupPlans resource.</summary>
            public virtual BackupPlansResource BackupPlans { get; }

            /// <summary>The "backupPlans" collection of methods.</summary>
            public class BackupPlansResource
            {
                private const string Resource = "backupPlans";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupPlansResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a BackupPlan</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The `BackupPlan` project and location in the format
                /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations map to GCP regions, for
                /// example **us-central1**.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Backupdr.v1.Data.BackupPlan body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a BackupPlan</summary>
                public class CreateRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.BackupPlan body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `BackupPlan` project and location in the format
                    /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations map to GCP regions, for
                    /// example **us-central1**.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The name of the `BackupPlan` to create. The name must be unique for the specified
                    /// project and location.The name must start with a lowercase letter followed by up to 62 lowercase
                    /// letters, numbers, or hyphens. Pattern, /a-z{,62}/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupPlanId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupPlanId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and t he request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.BackupPlan Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupPlans";

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
                        RequestParameters.Add("backupPlanId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "backupPlanId",
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

                /// <summary>Deletes a single BackupPlan.</summary>
                /// <param name="name">
                /// Required. The resource name of the `BackupPlan` to delete. Format:
                /// `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single BackupPlan.</summary>
                public class DeleteRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the `BackupPlan` to delete. Format:
                    /// `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
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

                /// <summary>Gets details of a single BackupPlan.</summary>
                /// <param name="name">
                /// Required. The resource name of the `BackupPlan` to retrieve. Format:
                /// `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single BackupPlan.</summary>
                public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.BackupPlan>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the `BackupPlan` to retrieve. Format:
                    /// `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPlans/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists BackupPlans in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve `BackupPlans` information. Format:
                /// `projects/{project}/locations/{location}`. In Cloud BackupDR, locations map to GCP regions, for e.g.
                /// **us-central1**. To retrieve backup plans for all locations, use "-" for the `{location}` value.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists BackupPlans in a given project and location.</summary>
                public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListBackupPlansResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve `BackupPlans` information. Format:
                    /// `projects/{project}/locations/{location}`. In Cloud BackupDR, locations map to GCP regions, for
                    /// e.g. **us-central1**. To retrieve backup plans for all locations, use "-" for the `{location}`
                    /// value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Field match expression used to filter the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Field by which to sort the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of `BackupPlans` to return in a single response. If not specified,
                    /// a default value will be chosen by the service. Note that the response may include a partial list
                    /// and a caller should only rely on the response's next_page_token to determine if there are more
                    /// instances left to be queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The value of next_page_token received from a previous `ListBackupPlans` call. Provide
                    /// this to retrieve the subsequent page in a multi-page list of results. When paginating, all other
                    /// parameters provided to `ListBackupPlans` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupPlans";

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
            }

            /// <summary>Gets the BackupVaults resource.</summary>
            public virtual BackupVaultsResource BackupVaults { get; }

            /// <summary>The "backupVaults" collection of methods.</summary>
            public class BackupVaultsResource
            {
                private const string Resource = "backupVaults";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupVaultsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    DataSources = new DataSourcesResource(service);
                }

                /// <summary>Gets the DataSources resource.</summary>
                public virtual DataSourcesResource DataSources { get; }

                /// <summary>The "dataSources" collection of methods.</summary>
                public class DataSourcesResource
                {
                    private const string Resource = "dataSources";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DataSourcesResource(Google.Apis.Services.IClientService service)
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

                        /// <summary>Deletes a Backup.</summary>
                        /// <param name="name">Required. Name of the resource.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>Deletes a Backup.</summary>
                        public class DeleteRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the resource.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. An optional request ID to identify requests. Specify a unique request ID so
                            /// that if you must retry your request, the server will know to ignore the request if it
                            /// has already been completed. The server will guarantee that for at least 60 minutes after
                            /// the first request. For example, consider a situation where you make an initial request
                            /// and the request times out. If you make the request again with the same request ID, the
                            /// server can check if original operation with the same request ID was received, and if so,
                            /// will ignore the second request. This prevents clients from accidentally creating
                            /// duplicate commitments. The request ID must be a valid UUID with the exception that zero
                            /// UUID is not supported (00000000-0000-0000-0000-000000000000).
                            /// </summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+/backups/[^/]+$",
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

                        /// <summary>Gets details of a Backup.</summary>
                        /// <param name="name">
                        /// Required. Name of the data source resource name, in the format
                        /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a Backup.</summary>
                        public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Backup>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the data source resource name, in the format
                            /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup
                            /// resource.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>
                            /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup
                            /// resource.
                            /// </summary>
                            public enum ViewEnum
                            {
                                /// <summary>If the value is not set, the default 'FULL' view is used.</summary>
                                [Google.Apis.Util.StringValueAttribute("BACKUP_VIEW_UNSPECIFIED")]
                                BACKUPVIEWUNSPECIFIED = 0,

                                /// <summary>Includes basic data about the Backup, but not the full contents.</summary>
                                [Google.Apis.Util.StringValueAttribute("BACKUP_VIEW_BASIC")]
                                BACKUPVIEWBASIC = 1,

                                /// <summary>
                                /// Includes all data about the Backup. This is the default value (for both ListBackups
                                /// and GetBackup).
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("BACKUP_VIEW_FULL")]
                                BACKUPVIEWFULL = 2,
                            }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+/backups/[^/]+$",
                                });
                                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "view",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Lists Backups in a given project and location.</summary>
                        /// <param name="parent">
                        /// Required. The project and location for which to retrieve backup information, in the format
                        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to
                        /// Google Cloud regions, for example **us-central1**. To retrieve data sources for all
                        /// locations, use "-" for the '{location}' value.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists Backups in a given project and location.</summary>
                        public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListBackupsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The project and location for which to retrieve backup information, in the
                            /// format 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations
                            /// map to Google Cloud regions, for example **us-central1**. To retrieve data sources for
                            /// all locations, use "-" for the '{location}' value.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. Filtering results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. Hint for how to order the results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. Requested page size. Server may return fewer items than requested. If
                            /// unspecified, server will pick an appropriate default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A token identifying a page of results the server should return.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup
                            /// resource.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>
                            /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup
                            /// resource.
                            /// </summary>
                            public enum ViewEnum
                            {
                                /// <summary>If the value is not set, the default 'FULL' view is used.</summary>
                                [Google.Apis.Util.StringValueAttribute("BACKUP_VIEW_UNSPECIFIED")]
                                BACKUPVIEWUNSPECIFIED = 0,

                                /// <summary>Includes basic data about the Backup, but not the full contents.</summary>
                                [Google.Apis.Util.StringValueAttribute("BACKUP_VIEW_BASIC")]
                                BACKUPVIEWBASIC = 1,

                                /// <summary>
                                /// Includes all data about the Backup. This is the default value (for both ListBackups
                                /// and GetBackup).
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("BACKUP_VIEW_FULL")]
                                BACKUPVIEWFULL = 2,
                            }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
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
                                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "view",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Updates the settings of a Backup.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Output only. Identifier. Name of the backup to create. It must have the
                        /// format`"projects//locations//backupVaults//dataSources/{datasource}/backups/{backup}"`.
                        /// `{backup}` cannot be changed after creation. It must be between 3-63 characters long and
                        /// must be unique within the datasource.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.Backupdr.v1.Data.Backup body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>Updates the settings of a Backup.</summary>
                        public class PatchRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.Backup body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Output only. Identifier. Name of the backup to create. It must have the
                            /// format`"projects//locations//backupVaults//dataSources/{datasource}/backups/{backup}"`.
                            /// `{backup}` cannot be changed after creation. It must be between 3-63 characters long and
                            /// must be unique within the datasource.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. An optional request ID to identify requests. Specify a unique request ID so
                            /// that if you must retry your request, the server will know to ignore the request if it
                            /// has already been completed. The server will guarantee that for at least 60 minutes since
                            /// the first request. For example, consider a situation where you make an initial request
                            /// and the request times out. If you make the request again with the same request ID, the
                            /// server can check if original operation with the same request ID was received, and if so,
                            /// will ignore the second request. This prevents clients from accidentally creating
                            /// duplicate commitments. The request ID must be a valid UUID with the exception that zero
                            /// UUID is not supported (00000000-0000-0000-0000-000000000000).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string RequestId { get; set; }

                            /// <summary>
                            /// Required. Field mask is used to specify the fields to be overwritten in the Backup
                            /// resource by the update. The fields specified in the update_mask are relative to the
                            /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                            /// user does not provide a mask then the request will fail.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Backupdr.v1.Data.Backup Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+/backups/[^/]+$",
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

                        /// <summary>Restore from a Backup</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the Backup instance, in the format
                        /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
                        /// </param>
                        public virtual RestoreRequest Restore(Google.Apis.Backupdr.v1.Data.RestoreBackupRequest body, string name)
                        {
                            return new RestoreRequest(this.service, body, name);
                        }

                        /// <summary>Restore from a Backup</summary>
                        public class RestoreRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Restore request.</summary>
                            public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.RestoreBackupRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Backup instance, in the format
                            /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Backupdr.v1.Data.RestoreBackupRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "restore";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:restore";

                            /// <summary>Initializes Restore parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+/backups/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Internal only. Abandons a backup.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="dataSource">
                    /// Required. The resource name of the instance, in the format
                    /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                    /// </param>
                    public virtual AbandonBackupRequest AbandonBackup(Google.Apis.Backupdr.v1.Data.AbandonBackupRequest body, string dataSource)
                    {
                        return new AbandonBackupRequest(this.service, body, dataSource);
                    }

                    /// <summary>Internal only. Abandons a backup.</summary>
                    public class AbandonBackupRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new AbandonBackup request.</summary>
                        public AbandonBackupRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.AbandonBackupRequest body, string dataSource) : base(service)
                        {
                            DataSource = dataSource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the instance, in the format
                        /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DataSource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Backupdr.v1.Data.AbandonBackupRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "abandonBackup";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+dataSource}:abandonBackup";

                        /// <summary>Initializes AbandonBackup parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataSource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataSource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Internal only. Fetch access token for a given data source.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name for the location for which static IPs should be returned. Must be in
                    /// the format 'projects/*/locations/*/backupVaults/*/dataSources'.
                    /// </param>
                    public virtual FetchAccessTokenRequest FetchAccessToken(Google.Apis.Backupdr.v1.Data.FetchAccessTokenRequest body, string name)
                    {
                        return new FetchAccessTokenRequest(this.service, body, name);
                    }

                    /// <summary>Internal only. Fetch access token for a given data source.</summary>
                    public class FetchAccessTokenRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.FetchAccessTokenResponse>
                    {
                        /// <summary>Constructs a new FetchAccessToken request.</summary>
                        public FetchAccessTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.FetchAccessTokenRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name for the location for which static IPs should be returned. Must
                        /// be in the format 'projects/*/locations/*/backupVaults/*/dataSources'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Backupdr.v1.Data.FetchAccessTokenRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchAccessToken";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:fetchAccessToken";

                        /// <summary>Initializes FetchAccessToken parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Internal only. Finalize a backup that was started by a call to InitiateBackup.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="dataSource">
                    /// Required. The resource name of the instance, in the format
                    /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                    /// </param>
                    public virtual FinalizeBackupRequest FinalizeBackup(Google.Apis.Backupdr.v1.Data.FinalizeBackupRequest body, string dataSource)
                    {
                        return new FinalizeBackupRequest(this.service, body, dataSource);
                    }

                    /// <summary>
                    /// Internal only. Finalize a backup that was started by a call to InitiateBackup.
                    /// </summary>
                    public class FinalizeBackupRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new FinalizeBackup request.</summary>
                        public FinalizeBackupRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.FinalizeBackupRequest body, string dataSource) : base(service)
                        {
                            DataSource = dataSource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the instance, in the format
                        /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DataSource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Backupdr.v1.Data.FinalizeBackupRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "finalizeBackup";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+dataSource}:finalizeBackup";

                        /// <summary>Initializes FinalizeBackup parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataSource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataSource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a DataSource.</summary>
                    /// <param name="name">
                    /// Required. Name of the data source resource name, in the format
                    /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a DataSource.</summary>
                    public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.DataSource>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the data source resource name, in the format
                        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Internal only. Initiates a backup.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="dataSource">
                    /// Required. The resource name of the instance, in the format
                    /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                    /// </param>
                    public virtual InitiateBackupRequest InitiateBackup(Google.Apis.Backupdr.v1.Data.InitiateBackupRequest body, string dataSource)
                    {
                        return new InitiateBackupRequest(this.service, body, dataSource);
                    }

                    /// <summary>Internal only. Initiates a backup.</summary>
                    public class InitiateBackupRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.InitiateBackupResponse>
                    {
                        /// <summary>Constructs a new InitiateBackup request.</summary>
                        public InitiateBackupRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.InitiateBackupRequest body, string dataSource) : base(service)
                        {
                            DataSource = dataSource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the instance, in the format
                        /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DataSource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Backupdr.v1.Data.InitiateBackupRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "initiateBackup";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+dataSource}:initiateBackup";

                        /// <summary>Initializes InitiateBackup parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataSource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataSource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists DataSources in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The project and location for which to retrieve data sources information, in the format
                    /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to Google
                    /// Cloud regions, for example **us-central1**. To retrieve data sources for all locations, use "-"
                    /// for the '{location}' value.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists DataSources in a given project and location.</summary>
                    public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListDataSourcesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The project and location for which to retrieve data sources information, in the
                        /// format 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map
                        /// to Google Cloud regions, for example **us-central1**. To retrieve data sources for all
                        /// locations, use "-" for the '{location}' value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dataSources";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
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

                    /// <summary>Updates the settings of a DataSource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Identifier. Name of the datasource to create. It must have the
                    /// format`"projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}"`.
                    /// `{datasource}` cannot be changed after creation. It must be between 3-63 characters long and
                    /// must be unique within the backup vault.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Backupdr.v1.Data.DataSource body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the settings of a DataSource.</summary>
                    public class PatchRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.DataSource body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Identifier. Name of the datasource to create. It must have the
                        /// format`"projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}"`.
                        /// `{datasource}` cannot be changed after creation. It must be between 3-63 characters long and
                        /// must be unique within the backup vault.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. Enable upsert.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes since the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the DataSource
                        /// resource by the update. The fields specified in the update_mask are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then the request will fail.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Backupdr.v1.Data.DataSource Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
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
                    /// Deletes a DataSource. This is a custom method instead of a standard delete method because
                    /// external clients will not delete DataSources except for BackupDR backup appliances.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the resource.</param>
                    public virtual RemoveRequest Remove(Google.Apis.Backupdr.v1.Data.RemoveDataSourceRequest body, string name)
                    {
                        return new RemoveRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Deletes a DataSource. This is a custom method instead of a standard delete method because
                    /// external clients will not delete DataSources except for BackupDR backup appliances.
                    /// </summary>
                    public class RemoveRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Remove request.</summary>
                        public RemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.RemoveDataSourceRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Backupdr.v1.Data.RemoveDataSourceRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "remove";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:remove";

                        /// <summary>Initializes Remove parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Sets the internal status of a DataSource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="dataSource">
                    /// Required. The resource name of the instance, in the format
                    /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                    /// </param>
                    public virtual SetInternalStatusRequest SetInternalStatus(Google.Apis.Backupdr.v1.Data.SetInternalStatusRequest body, string dataSource)
                    {
                        return new SetInternalStatusRequest(this.service, body, dataSource);
                    }

                    /// <summary>Sets the internal status of a DataSource.</summary>
                    public class SetInternalStatusRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new SetInternalStatus request.</summary>
                        public SetInternalStatusRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.SetInternalStatusRequest body, string dataSource) : base(service)
                        {
                            DataSource = dataSource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the instance, in the format
                        /// 'projects/*/locations/*/backupVaults/*/dataSources/'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dataSource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DataSource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Backupdr.v1.Data.SetInternalStatusRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setInternalStatus";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+dataSource}:setInternalStatus";

                        /// <summary>Initializes SetInternalStatus parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("dataSource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dataSource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/dataSources/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new BackupVault in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.Backupdr.v1.Data.BackupVault body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new BackupVault in a given project and location.</summary>
                public class CreateRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.BackupVault body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. ID of the requesting object If auto-generating ID server-side, remove this field and
                    /// backup_vault_id from the method_signature of Create RPC
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupVaultId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupVaultId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Only validate the request, but do not perform mutations. The default is 'false'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.BackupVault Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupVaults";

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
                        RequestParameters.Add("backupVaultId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "backupVaultId",
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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a BackupVault.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a BackupVault.</summary>
                public class DeleteRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If true and the BackupVault is not found, the request will succeed but no action will
                    /// be taken.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The current etag of the backup vault. If an etag is provided and does not match the current etag
                    /// of the connection, deletion will be blocked.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. If set to true, any data source from this backup vault will also be deleted.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. If set to true, backupvault deletion will proceed even if there are backup plans
                    /// referencing the backupvault. The default is 'false'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreBackupPlanReferences", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreBackupPlanReferences { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Only validate the request, but do not perform mutations. The default is 'false'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ignoreBackupPlanReferences", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreBackupPlanReferences",
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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// FetchUsableBackupVaults lists usable BackupVaults in a given project and location. Usable
                /// BackupVault are the ones that user has backupdr.backupVaults.get permission.
                /// </summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve backupvault stores information, in the
                /// format 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to Google
                /// Cloud regions, for example **us-central1**. To retrieve backupvault stores for all locations, use
                /// "-" for the '{location}' value.
                /// </param>
                public virtual FetchUsableRequest FetchUsable(string parent)
                {
                    return new FetchUsableRequest(this.service, parent);
                }

                /// <summary>
                /// FetchUsableBackupVaults lists usable BackupVaults in a given project and location. Usable
                /// BackupVault are the ones that user has backupdr.backupVaults.get permission.
                /// </summary>
                public class FetchUsableRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.FetchUsableBackupVaultsResponse>
                {
                    /// <summary>Constructs a new FetchUsable request.</summary>
                    public FetchUsableRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve backupvault stores information, in the
                    /// format 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to
                    /// Google Cloud regions, for example **us-central1**. To retrieve backupvault stores for all
                    /// locations, use "-" for the '{location}' value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchUsable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupVaults:fetchUsable";

                    /// <summary>Initializes FetchUsable parameter list.</summary>
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

                /// <summary>Gets details of a BackupVault.</summary>
                /// <param name="name">
                /// Required. Name of the backupvault store resource name, in the format
                /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a BackupVault.</summary>
                public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.BackupVault>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the backupvault store resource name, in the format
                    /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup Vault
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup Vault
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default 'FULL' view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("BACKUP_VAULT_VIEW_UNSPECIFIED")]
                        BACKUPVAULTVIEWUNSPECIFIED = 0,

                        /// <summary>Includes basic data about the Backup Vault, but not the full contents.</summary>
                        [Google.Apis.Util.StringValueAttribute("BACKUP_VAULT_VIEW_BASIC")]
                        BACKUPVAULTVIEWBASIC = 1,

                        /// <summary>
                        /// Includes all data about the Backup Vault. This is the default value (for both
                        /// ListBackupVaults and GetBackupVault).
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BACKUP_VAULT_VIEW_FULL")]
                        BACKUPVAULTVIEWFULL = 2,
                    }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
                        });
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists BackupVaults in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve backupvault stores information, in the
                /// format 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to Google
                /// Cloud regions, for example **us-central1**. To retrieve backupvault stores for all locations, use
                /// "-" for the '{location}' value.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists BackupVaults in a given project and location.</summary>
                public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListBackupVaultsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve backupvault stores information, in the
                    /// format 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to
                    /// Google Cloud regions, for example **us-central1**. To retrieve backupvault stores for all
                    /// locations, use "-" for the '{location}' value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup Vault.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Optional. Reserved for future use to provide a BASIC &amp;amp; FULL view of Backup Vault.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default 'FULL' view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("BACKUP_VAULT_VIEW_UNSPECIFIED")]
                        BACKUPVAULTVIEWUNSPECIFIED = 0,

                        /// <summary>Includes basic data about the Backup Vault, but not the full contents.</summary>
                        [Google.Apis.Util.StringValueAttribute("BACKUP_VAULT_VIEW_BASIC")]
                        BACKUPVAULTVIEWBASIC = 1,

                        /// <summary>
                        /// Includes all data about the Backup Vault. This is the default value (for both
                        /// ListBackupVaults and GetBackupVault).
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BACKUP_VAULT_VIEW_FULL")]
                        BACKUPVAULTVIEWFULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupVaults";

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
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates the settings of a BackupVault.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Identifier. Name of the backup vault to create. It must have the
                /// format`"projects/{project}/locations/{location}/backupVaults/{backupvault}"`. `{backupvault}` cannot
                /// be changed after creation. It must be between 3-63 characters long and must be unique within the
                /// project and location.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Backupdr.v1.Data.BackupVault body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the settings of a BackupVault.</summary>
                public class PatchRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.BackupVault body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Identifier. Name of the backup vault to create. It must have the
                    /// format`"projects/{project}/locations/{location}/backupVaults/{backupvault}"`. `{backupvault}`
                    /// cannot be changed after creation. It must be between 3-63 characters long and must be unique
                    /// within the project and location.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, will not check plan duration against backup vault enforcement
                    /// duration.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the BackupVault resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then the request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. Only validate the request, but do not perform mutations. The default is 'false'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.BackupVault Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
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
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Returns the caller's permissions on a BackupVault resource. A caller is not required to have Google
                /// IAM permission to make this request.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Backupdr.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns the caller's permissions on a BackupVault resource. A caller is not required to have Google
                /// IAM permission to make this request.
                /// </summary>
                public class TestIamPermissionsRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the ManagementServers resource.</summary>
            public virtual ManagementServersResource ManagementServers { get; }

            /// <summary>The "managementServers" collection of methods.</summary>
            public class ManagementServersResource
            {
                private const string Resource = "managementServers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ManagementServersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new ManagementServer in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The management server project and location in the format
                /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR locations map to Google Cloud
                /// regions, for example **us-central1**.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Backupdr.v1.Data.ManagementServer body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new ManagementServer in a given project and location.</summary>
                public class CreateRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.ManagementServer body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The management server project and location in the format
                    /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR locations map to Google
                    /// Cloud regions, for example **us-central1**.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The name of the management server to create. The name must be unique for the specified
                    /// project and location.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("managementServerId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ManagementServerId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.ManagementServer Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/managementServers";

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
                        RequestParameters.Add("managementServerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "managementServerId",
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

                /// <summary>Deletes a single ManagementServer.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single ManagementServer.</summary>
                public class DeleteRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/managementServers/[^/]+$",
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

                /// <summary>Gets details of a single ManagementServer.</summary>
                /// <param name="name">
                /// Required. Name of the management server resource name, in the format
                /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ManagementServer.</summary>
                public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ManagementServer>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the management server resource name, in the format
                    /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/managementServers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/managementServers/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists ManagementServers in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve management servers information, in the
                /// format 'projects/{project_id}/locations/{location}'. In Cloud BackupDR, locations map to Google
                /// Cloud regions, for example **us-central1**. To retrieve management servers for all locations, use
                /// "-" for the '{location}' value.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists ManagementServers in a given project and location.</summary>
                public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListManagementServersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve management servers information, in the
                    /// format 'projects/{project_id}/locations/{location}'. In Cloud BackupDR, locations map to Google
                    /// Cloud regions, for example **us-central1**. To retrieve management servers for all locations,
                    /// use "-" for the '{location}' value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/managementServers";

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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Backupdr.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/managementServers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Backupdr.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/managementServers/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.Backupdr.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Empty>
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
                public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
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
                public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the ResourceBackupConfigs resource.</summary>
            public virtual ResourceBackupConfigsResource ResourceBackupConfigs { get; }

            /// <summary>The "resourceBackupConfigs" collection of methods.</summary>
            public class ResourceBackupConfigsResource
            {
                private const string Resource = "resourceBackupConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ResourceBackupConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists ResourceBackupConfigs.</summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve resource backup configs. Format:
                /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to Google Cloud
                /// regions, for example **us-central1**.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists ResourceBackupConfigs.</summary>
                public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListResourceBackupConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve resource backup configs. Format:
                    /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR, locations map to Google
                    /// Cloud regions, for example **us-central1**.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/resourceBackupConfigs";

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
            }

            /// <summary>Gets the ServiceConfig resource.</summary>
            public virtual ServiceConfigResource ServiceConfig { get; }

            /// <summary>The "serviceConfig" collection of methods.</summary>
            public class ServiceConfigResource
            {
                private const string Resource = "serviceConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServiceConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Initializes the service related config for a project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the serviceConfig used to initialize the service. Format:
                /// `projects/{project_id}/locations/{location}/serviceConfig`.
                /// </param>
                public virtual InitializeRequest Initialize(Google.Apis.Backupdr.v1.Data.InitializeServiceRequest body, string name)
                {
                    return new InitializeRequest(this.service, body, name);
                }

                /// <summary>Initializes the service related config for a project.</summary>
                public class InitializeRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Initialize request.</summary>
                    public InitializeRequest(Google.Apis.Services.IClientService service, Google.Apis.Backupdr.v1.Data.InitializeServiceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the serviceConfig used to initialize the service. Format:
                    /// `projects/{project_id}/locations/{location}/serviceConfig`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Backupdr.v1.Data.InitializeServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "initialize";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:initialize";

                    /// <summary>Initializes Initialize parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceConfig$",
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
            public class GetRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.Location>
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
            public class ListRequest : BackupdrBaseServiceRequest<Google.Apis.Backupdr.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.Backupdr.v1.Data
{
    /// <summary>request message for AbandonBackup.</summary>
    public class AbandonBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes since the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of the type and number of accelerator cards attached to the instance.</summary>
    public class AcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of the guest accelerator cards exposed to this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorCount")]
        public virtual System.Nullable<int> AcceleratorCount { get; set; }

        /// <summary>
        /// Optional. Full or partial URL of the accelerator type resource to attach to this instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorType")]
        public virtual string AcceleratorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An access configuration attached to an instance's network interface. Only one access config per instance is
    /// supported.
    /// </summary>
    public class AccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The external IPv6 address of this access configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIpv6")]
        public virtual string ExternalIpv6 { get; set; }

        /// <summary>Optional. The prefix length of the external IPv6 range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIpv6PrefixLength")]
        public virtual System.Nullable<int> ExternalIpv6PrefixLength { get; set; }

        /// <summary>Optional. The name of this access configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The external IP address of this access configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("natIP")]
        public virtual string NatIP { get; set; }

        /// <summary>Optional. This signifies the networking tier used for configuring this access</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTier")]
        public virtual string NetworkTier { get; set; }

        /// <summary>Optional. The DNS domain name for the public PTR record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicPtrDomainName")]
        public virtual string PublicPtrDomainName { get; set; }

        /// <summary>
        /// Optional. Specifies whether a public DNS 'PTR' record should be created to map the external IP address of
        /// the instance to a DNS domain name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setPublicPtr")]
        public virtual System.Nullable<bool> SetPublicPtr { get; set; }

        /// <summary>
        /// Optional. In accessConfigs (IPv4), the default and only option is ONE_TO_ONE_NAT. In ipv6AccessConfigs, the
        /// default and only option is DIRECT_IPV6.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies options for controlling advanced machine features.</summary>
    public class AdvancedMachineFeatures : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether to enable nested virtualization or not (default is false).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNestedVirtualization")]
        public virtual System.Nullable<bool> EnableNestedVirtualization { get; set; }

        /// <summary>Optional. Whether to enable UEFI networking for instance creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableUefiNetworking")]
        public virtual System.Nullable<bool> EnableUefiNetworking { get; set; }

        /// <summary>
        /// Optional. The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to
        /// 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadsPerCore")]
        public virtual System.Nullable<int> ThreadsPerCore { get; set; }

        /// <summary>
        /// Optional. The number of physical cores to expose to an instance. Multiply by the number of threads per core
        /// to compute the total number of virtual CPUs to expose to the instance. If unset, the number of cores is
        /// inferred from the instance's nominal CPU count and the underlying platform's SMT width.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleCoreCount")]
        public virtual System.Nullable<int> VisibleCoreCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An alias IP range attached to an instance's network interface.</summary>
    public class AliasIpRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The IP alias ranges to allocate for this interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipCidrRange")]
        public virtual string IpCidrRange { get; set; }

        /// <summary>
        /// Optional. The name of a subnetwork secondary IP range from which to allocate an IP alias range. If not
        /// specified, the primary range of the subnetwork is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetworkRangeName")]
        public virtual string SubnetworkRangeName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the reservations that this instance can consume from.</summary>
    public class AllocationAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies the type of reservation from which this instance can consume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumeReservationType")]
        public virtual string ConsumeReservationType { get; set; }

        /// <summary>Optional. Corresponds to the label key of a reservation resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. Corresponds to the label values of a reservation resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instance-attached disk resource.</summary>
    public class AttachedDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies whether the disk will be auto-deleted when the instance is deleted (but not when the
        /// disk is detached from the instance).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoDelete")]
        public virtual System.Nullable<bool> AutoDelete { get; set; }

        /// <summary>
        /// Optional. Indicates that this is a boot disk. The virtual machine will use the first partition of the disk
        /// for its root filesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boot")]
        public virtual System.Nullable<bool> Boot { get; set; }

        /// <summary>
        /// Optional. This is used as an identifier for the disks. This is the unique name has to provided to modify
        /// disk parameters like disk_name and replica_zones (in case of RePDs)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>Optional. Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryptionKey")]
        public virtual CustomerEncryptionKey DiskEncryptionKey { get; set; }

        /// <summary>Optional. Specifies the disk interface to use for attaching this disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskInterface")]
        public virtual string DiskInterface { get; set; }

        /// <summary>Optional. The size of the disk in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Optional. Output only. The URI of the disk type resource. For example:
        /// projects/project/zones/zone/diskTypes/pd-standard or pd-ssd
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>Specifies the type of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskTypeDeprecated")]
        public virtual string DiskTypeDeprecated { get; set; }

        /// <summary>
        /// Optional. A list of features to enable on the guest operating system. Applicable only for bootable images.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestOsFeature")]
        public virtual System.Collections.Generic.IList<GuestOsFeature> GuestOsFeature { get; set; }

        /// <summary>Optional. A zero-based index to this disk, where 0 is reserved for the boot disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<long> Index { get; set; }

        /// <summary>Optional. Specifies the parameters to initialize this disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializeParams")]
        public virtual InitializeParams InitializeParams { get; set; }

        /// <summary>Optional. Type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional. Any valid publicly visible licenses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual System.Collections.Generic.IList<string> License { get; set; }

        /// <summary>Optional. The mode in which to attach this disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Optional. Output only. The state of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedState")]
        public virtual string SavedState { get; set; }

        /// <summary>Optional. Specifies a valid partial or full URL to an existing Persistent Disk resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Optional. Specifies the type of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

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
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Message describing a Backup object.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Backup Appliance specific backup properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceBackupProperties")]
        public virtual BackupApplianceBackupProperties BackupApplianceBackupProperties { get; set; }

        /// <summary>Optional. The list of BackupLocks taken by the accessor Backup Appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceLocks")]
        public virtual System.Collections.Generic.IList<BackupLock> BackupApplianceLocks { get; set; }

        /// <summary>Output only. Type of the backup, unspecified, scheduled or ondemand.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        /// <summary>Output only. Compute Engine specific backup properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeInstanceBackupProperties")]
        public virtual ComputeInstanceBackupProperties ComputeInstanceBackupProperties { get; set; }

        private string _consistencyTimeRaw;

        private object _consistencyTime;

        /// <summary>Output only. The point in time when this backup was captured from the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consistencyTime")]
        public virtual string ConsistencyTimeRaw
        {
            get => _consistencyTimeRaw;
            set
            {
                _consistencyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _consistencyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ConsistencyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ConsistencyTimeDateTimeOffset instead.")]
        public virtual object ConsistencyTime
        {
            get => _consistencyTime;
            set
            {
                _consistencyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _consistencyTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ConsistencyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ConsistencyTimeRaw);
            set => ConsistencyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the instance was created.</summary>
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

        /// <summary>Output only. The description of the Backup instance (2048 characters or less).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _enforcedRetentionEndTimeRaw;

        private object _enforcedRetentionEndTime;

        /// <summary>Optional. The backup can not be deleted before this time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforcedRetentionEndTime")]
        public virtual string EnforcedRetentionEndTimeRaw
        {
            get => _enforcedRetentionEndTimeRaw;
            set
            {
                _enforcedRetentionEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _enforcedRetentionEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EnforcedRetentionEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EnforcedRetentionEndTimeDateTimeOffset instead.")]
        public virtual object EnforcedRetentionEndTime
        {
            get => _enforcedRetentionEndTime;
            set
            {
                _enforcedRetentionEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _enforcedRetentionEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EnforcedRetentionEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EnforcedRetentionEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EnforcedRetentionEndTimeRaw);
            set => EnforcedRetentionEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Server specified ETag to prevent updates from overwriting each other.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Optional. When this backup is automatically expired.</summary>
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

        /// <summary>Output only. Configuration for a Google Cloud resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpBackupPlanInfo")]
        public virtual GCPBackupPlanInfo GcpBackupPlanInfo { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. No labels currently defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Identifier. Name of the backup to create. It must have the
        /// format`"projects//locations//backupVaults//dataSources/{datasource}/backups/{backup}"`. `{backup}` cannot be
        /// changed after creation. It must be between 3-63 characters long and must be unique within the datasource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. source resource size in bytes at the time of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSizeBytes")]
        public virtual System.Nullable<long> ResourceSizeBytes { get; set; }

        /// <summary>Optional. Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Optional. Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Output only. The list of BackupLocks taken by the service to prevent the deletion of the backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLocks")]
        public virtual System.Collections.Generic.IList<BackupLock> ServiceLocks { get; set; }

        /// <summary>Output only. The Backup resource instance state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the instance was updated.</summary>
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
    }

    /// <summary>
    /// BackupApplianceBackupConfig captures the backup configuration for applications that are protected by Backup
    /// Appliances.
    /// </summary>
    public class BackupApplianceBackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationName")]
        public virtual string ApplicationName { get; set; }

        /// <summary>The ID of the backup appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceId")]
        public virtual System.Nullable<long> BackupApplianceId { get; set; }

        /// <summary>The name of the backup appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceName")]
        public virtual string BackupApplianceName { get; set; }

        /// <summary>The name of the host where the application is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostName")]
        public virtual string HostName { get; set; }

        /// <summary>The ID of the SLA of this application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slaId")]
        public virtual System.Nullable<long> SlaId { get; set; }

        /// <summary>The name of the SLP associated with the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slpName")]
        public virtual string SlpName { get; set; }

        /// <summary>The name of the SLT associated with the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sltName")]
        public virtual string SltName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupApplianceBackupProperties represents BackupDR backup appliance's properties.</summary>
    public class BackupApplianceBackupProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finalizeTimeRaw;

        private object _finalizeTime;

        /// <summary>
        /// Output only. The time when this backup object was finalized (if none, backup is not finalized).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizeTime")]
        public virtual string FinalizeTimeRaw
        {
            get => _finalizeTimeRaw;
            set
            {
                _finalizeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finalizeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinalizeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinalizeTimeDateTimeOffset instead.")]
        public virtual object FinalizeTime
        {
            get => _finalizeTime;
            set
            {
                _finalizeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finalizeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinalizeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinalizeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinalizeTimeRaw);
            set => FinalizeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The numeric generation ID of the backup (monotonically increasing).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationId")]
        public virtual System.Nullable<int> GenerationId { get; set; }

        private string _recoveryRangeEndTimeRaw;

        private object _recoveryRangeEndTime;

        /// <summary>Optional. The latest timestamp of data available in this Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryRangeEndTime")]
        public virtual string RecoveryRangeEndTimeRaw
        {
            get => _recoveryRangeEndTimeRaw;
            set
            {
                _recoveryRangeEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _recoveryRangeEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RecoveryRangeEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RecoveryRangeEndTimeDateTimeOffset instead.")]
        public virtual object RecoveryRangeEndTime
        {
            get => _recoveryRangeEndTime;
            set
            {
                _recoveryRangeEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _recoveryRangeEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RecoveryRangeEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RecoveryRangeEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RecoveryRangeEndTimeRaw);
            set => RecoveryRangeEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _recoveryRangeStartTimeRaw;

        private object _recoveryRangeStartTime;

        /// <summary>Optional. The earliest timestamp of data available in this Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryRangeStartTime")]
        public virtual string RecoveryRangeStartTimeRaw
        {
            get => _recoveryRangeStartTimeRaw;
            set
            {
                _recoveryRangeStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _recoveryRangeStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RecoveryRangeStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RecoveryRangeStartTimeDateTimeOffset instead.")]
        public virtual object RecoveryRangeStartTime
        {
            get => _recoveryRangeStartTime;
            set
            {
                _recoveryRangeStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _recoveryRangeStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RecoveryRangeStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RecoveryRangeStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RecoveryRangeStartTimeRaw);
            set => RecoveryRangeStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupApplianceLockInfo contains metadata about the backupappliance that created the lock.</summary>
    public class BackupApplianceLockInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the backup/recovery appliance that created this lock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceId")]
        public virtual System.Nullable<long> BackupApplianceId { get; set; }

        /// <summary>Required. The name of the backup/recovery appliance that created this lock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceName")]
        public virtual string BackupApplianceName { get; set; }

        /// <summary>The image name that depends on this Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupImage")]
        public virtual string BackupImage { get; set; }

        /// <summary>The job name on the backup/recovery appliance that created this lock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobName")]
        public virtual string JobName { get; set; }

        /// <summary>
        /// Required. The reason for the lock: e.g. MOUNT/RESTORE/BACKUP/etc. The value of this string is only
        /// meaningful to the client and it is not interpreted by the BackupVault service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockReason")]
        public virtual string LockReason { get; set; }

        /// <summary>The SLA on the backup/recovery appliance that owns the lock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slaId")]
        public virtual System.Nullable<long> SlaId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BackupConfigDetails has information about how the resource is configured for backups and about the most recent
    /// backup taken for this configuration.
    /// </summary>
    public class BackupConfigDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-format) of
        /// the resource that is applicable for the backup configuration. Example:
        /// "//compute.googleapis.com/projects/{project}/zones/{zone}/instances/{instance}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicableResource")]
        public virtual string ApplicableResource { get; set; }

        /// <summary>
        /// Output only. The full resource name of the backup config source resource. For example,
        /// "//backupdr.googleapis.com/v1/projects/{project}/locations/{region}/backupPlans/{backupplanId}" or
        /// "//compute.googleapis.com/projects/{project}/locations/{region}/resourcePolicies/{resourcePolicyId}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfigSource")]
        public virtual string BackupConfigSource { get; set; }

        /// <summary>Output only. The display name of the backup config source resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfigSourceDisplayName")]
        public virtual string BackupConfigSourceDisplayName { get; set; }

        /// <summary>Backup and DR's Backup Plan specific data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDrPlanConfig")]
        public virtual BackupDrPlanConfig BackupDrPlanConfig { get; set; }

        /// <summary>Backup and DR's Template specific data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDrTemplateConfig")]
        public virtual BackupDrTemplateConfig BackupDrTemplateConfig { get; set; }

        /// <summary>The locations where the backups are to be stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupLocations")]
        public virtual System.Collections.Generic.IList<BackupLocation> BackupLocations { get; set; }

        /// <summary>
        /// Output only. The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-format) of
        /// the backup vault that will store the backups generated through this backup configuration. Example:
        /// "//backupdr.googleapis.com/v1/projects/{project}/locations/{region}/backupVaults/{backupvaultId}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVault")]
        public virtual string BackupVault { get; set; }

        private string _latestSuccessfulBackupTimeRaw;

        private object _latestSuccessfulBackupTime;

        /// <summary>
        /// Output only. Timestamp of the latest successful backup created via this backup configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestSuccessfulBackupTime")]
        public virtual string LatestSuccessfulBackupTimeRaw
        {
            get => _latestSuccessfulBackupTimeRaw;
            set
            {
                _latestSuccessfulBackupTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestSuccessfulBackupTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestSuccessfulBackupTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestSuccessfulBackupTimeDateTimeOffset instead.")]
        public virtual object LatestSuccessfulBackupTime
        {
            get => _latestSuccessfulBackupTime;
            set
            {
                _latestSuccessfulBackupTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestSuccessfulBackupTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestSuccessfulBackupTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestSuccessfulBackupTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestSuccessfulBackupTimeRaw);
            set => LatestSuccessfulBackupTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Point in time recovery settings of the backup configuration resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitrSettings")]
        public virtual PitrSettings PitrSettings { get; set; }

        /// <summary>Output only. The state of the backup config resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The type of the backup config resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BackupConfigInfo has information about how the resource is configured for Backup and about the most recent
    /// backup to this vault.
    /// </summary>
    public class BackupConfigInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for an application backed up by a Backup Appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceBackupConfig")]
        public virtual BackupApplianceBackupConfig BackupApplianceBackupConfig { get; set; }

        /// <summary>Configuration for a Google Cloud resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpBackupConfig")]
        public virtual GcpBackupConfig GcpBackupConfig { get; set; }

        /// <summary>Output only. If the last backup failed, this field has the error message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastBackupError")]
        public virtual Status LastBackupError { get; set; }

        /// <summary>Output only. The status of the last backup to this BackupVault</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastBackupState")]
        public virtual string LastBackupState { get; set; }

        private string _lastSuccessfulBackupConsistencyTimeRaw;

        private object _lastSuccessfulBackupConsistencyTime;

        /// <summary>Output only. If the last backup were successful, this field has the consistency date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSuccessfulBackupConsistencyTime")]
        public virtual string LastSuccessfulBackupConsistencyTimeRaw
        {
            get => _lastSuccessfulBackupConsistencyTimeRaw;
            set
            {
                _lastSuccessfulBackupConsistencyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSuccessfulBackupConsistencyTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="LastSuccessfulBackupConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSuccessfulBackupConsistencyTimeDateTimeOffset instead.")]
        public virtual object LastSuccessfulBackupConsistencyTime
        {
            get => _lastSuccessfulBackupConsistencyTime;
            set
            {
                _lastSuccessfulBackupConsistencyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSuccessfulBackupConsistencyTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of
        /// <see cref="LastSuccessfulBackupConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSuccessfulBackupConsistencyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSuccessfulBackupConsistencyTimeRaw);
            set => LastSuccessfulBackupConsistencyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _lastSuccessfulLogBackupConsistencyTimeRaw;

        private object _lastSuccessfulLogBackupConsistencyTime;

        /// <summary>Output only. If the last log backup were successful, this field has the consistency date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSuccessfulLogBackupConsistencyTime")]
        public virtual string LastSuccessfulLogBackupConsistencyTimeRaw
        {
            get => _lastSuccessfulLogBackupConsistencyTimeRaw;
            set
            {
                _lastSuccessfulLogBackupConsistencyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSuccessfulLogBackupConsistencyTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="LastSuccessfulLogBackupConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSuccessfulLogBackupConsistencyTimeDateTimeOffset instead.")]
        public virtual object LastSuccessfulLogBackupConsistencyTime
        {
            get => _lastSuccessfulLogBackupConsistencyTime;
            set
            {
                _lastSuccessfulLogBackupConsistencyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSuccessfulLogBackupConsistencyTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of
        /// <see cref="LastSuccessfulLogBackupConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSuccessfulLogBackupConsistencyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSuccessfulLogBackupConsistencyTimeRaw);
            set => LastSuccessfulLogBackupConsistencyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BackupDrPlanConfig has additional information about Backup and DR's Plan backup configuration.
    /// </summary>
    public class BackupDrPlanConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Backup rules of the backup plan resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDrPlanRules")]
        public virtual System.Collections.Generic.IList<BackupDrPlanRule> BackupDrPlanRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupDrPlanRule has rule specific information of the backup plan resource.</summary>
    public class BackupDrPlanRule : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastSuccessfulBackupTimeRaw;

        private object _lastSuccessfulBackupTime;

        /// <summary>Output only. Timestamp of the latest successful backup created via this backup rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSuccessfulBackupTime")]
        public virtual string LastSuccessfulBackupTimeRaw
        {
            get => _lastSuccessfulBackupTimeRaw;
            set
            {
                _lastSuccessfulBackupTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSuccessfulBackupTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastSuccessfulBackupTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSuccessfulBackupTimeDateTimeOffset instead.")]
        public virtual object LastSuccessfulBackupTime
        {
            get => _lastSuccessfulBackupTime;
            set
            {
                _lastSuccessfulBackupTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSuccessfulBackupTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastSuccessfulBackupTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSuccessfulBackupTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSuccessfulBackupTimeRaw);
            set => LastSuccessfulBackupTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Unique Id of the backup rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BackupDrTemplateConfig has additional information about Backup and DR's Template backup configuration.
    /// </summary>
    public class BackupDrTemplateConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The URI of the BackupDr template resource for the first party identity users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPartyManagementUri")]
        public virtual string FirstPartyManagementUri { get; set; }

        /// <summary>
        /// Output only. The URI of the BackupDr template resource for the third party identity users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyManagementUri")]
        public virtual string ThirdPartyManagementUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupLocation represents a cloud location where a backup can be stored.</summary>
    public class BackupLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The id of the cloud location. Example: "us-central1"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Output only. The type of the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BackupLock represents a single lock on a Backup resource. An unexpired lock on a Backup prevents the Backup from
    /// being deleted.
    /// </summary>
    public class BackupLock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the client is a backup and recovery appliance, this contains metadata about why the lock exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupApplianceLockInfo")]
        public virtual BackupApplianceLockInfo BackupApplianceLockInfo { get; set; }

        private string _lockUntilTimeRaw;

        private object _lockUntilTime;

        /// <summary>
        /// Required. The time after which this lock is not considered valid and will no longer protect the Backup from
        /// deletion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockUntilTime")]
        public virtual string LockUntilTimeRaw
        {
            get => _lockUntilTimeRaw;
            set
            {
                _lockUntilTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lockUntilTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LockUntilTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LockUntilTimeDateTimeOffset instead.")]
        public virtual object LockUntilTime
        {
            get => _lockUntilTime;
            set
            {
                _lockUntilTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lockUntilTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LockUntilTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LockUntilTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LockUntilTimeRaw);
            set => LockUntilTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Contains metadata about the lock exist for Google Cloud native backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLockInfo")]
        public virtual ServiceLockInfo ServiceLockInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `BackupPlan` specifies some common fields, such as `description` as well as one or more `BackupRule` messages.
    /// Each `BackupRule` has a retention policy and defines a schedule by which the system is to perform backup
    /// workloads.
    /// </summary>
    public class BackupPlan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The backup rules for this `BackupPlan`. There must be at least one `BackupRule` message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRules")]
        public virtual System.Collections.Generic.IList<BackupRule> BackupRules { get; set; }

        /// <summary>
        /// Required. Resource name of backup vault which will be used as storage location for backups. Format:
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVault")]
        public virtual string BackupVault { get; set; }

        /// <summary>
        /// Output only. The Google Cloud Platform Service Account to be used by the BackupVault for taking backups.
        /// Specify the email address of the Backup Vault Service Account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVaultServiceAccount")]
        public virtual string BackupVaultServiceAccount { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the `BackupPlan` was created.</summary>
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
        /// Optional. The description of the `BackupPlan` resource. The description allows for additional details about
        /// `BackupPlan` and its use cases to be provided. An example description is the following: "This is a backup
        /// plan that performs a daily backup at 6pm and retains data for 3 months". The description must be at most
        /// 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. `etag` is returned from the service in the response. As a user of the service, you may provide an
        /// etag value in this field to prevent stale resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. This collection of key/value pairs allows for custom labels to be supplied by the user. Example,
        /// {"tag": "Weekly"}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of the `BackupPlan`. Format:
        /// `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Output only. The `State` for the `BackupPlan`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the `BackupPlan` was last updated.</summary>
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
    }

    /// <summary>
    /// A BackupPlanAssociation represents a single BackupPlanAssociation which contains details like workload, backup
    /// plan etc
    /// </summary>
    public class BackupPlanAssociation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Resource name of backup plan which needs to be applied on workload. Format:
        /// projects/{project}/locations/{location}/backupPlans/{backupPlanId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlan")]
        public virtual string BackupPlan { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the instance was created.</summary>
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
        /// Output only. Resource name of data source which will be used as storage location for backups taken. Format :
        /// projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name of BackupPlanAssociation in below format Format :
        /// projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Immutable. Resource name of workload on which backupplan is applied</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Required. Immutable. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Output only. The config info related to backup rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesConfigInfo")]
        public virtual System.Collections.Generic.IList<RuleConfigInfo> RulesConfigInfo { get; set; }

        /// <summary>Output only. The BackupPlanAssociation resource state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the instance was updated.</summary>
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

    /// <summary>`BackupRule` binds the backup schedule to a retention policy.</summary>
    public class BackupRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Configures the duration for which backup data will be kept. It is defined in “days”. The value
        /// should be greater than or equal to minimum enforced retention of the backup vault. Minimum value is 1 and
        /// maximum value is 90 for hourly backups. Minimum value is 1 and maximum value is 90 for daily backups.
        /// Minimum value is 7 and maximum value is 186 for weekly backups. Minimum value is 30 and maximum value is 732
        /// for monthly backups. Minimum value is 365 and maximum value is 36159 for yearly backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionDays")]
        public virtual System.Nullable<int> BackupRetentionDays { get; set; }

        /// <summary>
        /// Required. Immutable. The unique id of this `BackupRule`. The `rule_id` is unique per `BackupPlan`.The
        /// `rule_id` must start with a lowercase letter followed by up to 62 lowercase letters, numbers, or hyphens.
        /// Pattern, /a-z{,62}/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>Required. Defines a schedule that runs within the confines of a defined window of time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardSchedule")]
        public virtual StandardSchedule StandardSchedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing a BackupVault object.</summary>
    public class BackupVault : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Note: This field is added for future use case and will not be supported in the current release.
        /// Access restriction for the backup vault. Default value is WITHIN_ORGANIZATION if not provided during
        /// creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessRestriction")]
        public virtual string AccessRestriction { get; set; }

        /// <summary>
        /// Optional. User annotations. See https://google.aip.dev/128#annotations Stores small amounts of arbitrary
        /// data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. The number of backups in this backup vault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupCount")]
        public virtual System.Nullable<long> BackupCount { get; set; }

        /// <summary>
        /// Required. The default and minimum enforced retention for each backup within the backup vault. The enforced
        /// retention for each backup can be extended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupMinimumEnforcedRetentionDuration")]
        public virtual object BackupMinimumEnforcedRetentionDuration { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the instance was created.</summary>
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

        /// <summary>Output only. Set to true when there are no backups nested under this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletable")]
        public virtual System.Nullable<bool> Deletable { get; set; }

        /// <summary>Optional. The description of the BackupVault instance (2048 characters or less).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _effectiveTimeRaw;

        private object _effectiveTime;

        /// <summary>Optional. Time after which the BackupVault resource is locked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
        public virtual string EffectiveTimeRaw
        {
            get => _effectiveTimeRaw;
            set
            {
                _effectiveTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _effectiveTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EffectiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EffectiveTimeDateTimeOffset instead.")]
        public virtual object EffectiveTime
        {
            get => _effectiveTime;
            set
            {
                _effectiveTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _effectiveTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EffectiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EffectiveTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EffectiveTimeRaw);
            set => EffectiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Server specified ETag for the backup vault resource to prevent simultaneous updates from
        /// overwiting each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. No labels currently defined:
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Identifier. Name of the backup vault to create. It must have the
        /// format`"projects/{project}/locations/{location}/backupVaults/{backupvault}"`. `{backupvault}` cannot be
        /// changed after creation. It must be between 3-63 characters long and must be unique within the project and
        /// location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Service account used by the BackupVault Service for this BackupVault. The user should grant
        /// this account permissions in their workload project to enable the service to run backups and restores there.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. The BackupVault resource instance state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Total size of the storage used by all backup resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalStoredBytes")]
        public virtual System.Nullable<long> TotalStoredBytes { get; set; }

        /// <summary>Output only. Immutable after resource creation until resource deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the instance was updated.</summary>
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
    }

    /// <summary>`BackupWindow` defines a window of the day during which backup jobs will run.</summary>
    public class BackupWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The hour of day (1-24) when the window end for e.g. if value of end hour of day is 10 that mean
        /// backup window end time is 10:00. End hour of day should be greater than start hour of day. 0 &amp;lt;=
        /// start_hour_of_day &amp;lt; end_hour_of_day &amp;lt;= 24 End hour of day is not include in backup window that
        /// mean if end_hour_of_day= 10 jobs should start before 10:00.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endHourOfDay")]
        public virtual System.Nullable<int> EndHourOfDay { get; set; }

        /// <summary>
        /// Required. The hour of day (0-23) when the window starts for e.g. if value of start hour of day is 6 that
        /// mean backup window start at 6:00.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startHourOfDay")]
        public virtual System.Nullable<int> StartHourOfDay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ComputeInstanceBackupProperties represents Compute Engine instance backup properties.</summary>
    public class ComputeInstanceBackupProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enables instances created based on these properties to send packets with source IP addresses other than
        /// their own and receive packets with destination IP addresses other than their own. If these instances will be
        /// used as an IP gateway or it will be set as the next-hop in a Route resource, specify `true`. If unsure,
        /// leave this set to `false`. See the https://cloud.google.com/vpc/docs/using-routes#canipforward documentation
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canIpForward")]
        public virtual System.Nullable<bool> CanIpForward { get; set; }

        /// <summary>An optional text description for the instances that are created from these properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// An array of disks that are associated with the instances that are created from these properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual System.Collections.Generic.IList<AttachedDisk> Disk { get; set; }

        /// <summary>
        /// A list of guest accelerator cards' type and count to use for instances created from these properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestAccelerator")]
        public virtual System.Collections.Generic.IList<AcceleratorConfig> GuestAccelerator { get; set; }

        /// <summary>
        /// KeyRevocationActionType of the instance. Supported options are "STOP" and "NONE". The default value is
        /// "NONE" if it is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyRevocationActionType")]
        public virtual string KeyRevocationActionType { get; set; }

        /// <summary>Labels to apply to instances that are created from these properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The machine type to use for instances that are created from these properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// The metadata key/value pairs to assign to instances that are created from these properties. These pairs can
        /// consist of custom metadata or predefined keys. See https://cloud.google.com/compute/docs/metadata/overview
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual Metadata Metadata { get; set; }

        /// <summary>
        /// Minimum cpu/platform to be used by instances. The instance may be scheduled on the specified or newer
        /// cpu/platform. Applicable values are the friendly names of CPU platforms, such as `minCpuPlatform: Intel
        /// Haswell` or `minCpuPlatform: Intel Sandy Bridge`. For more information, read
        /// https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>An array of network access configurations for this interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterface")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterface { get; set; }

        /// <summary>
        /// Specifies the scheduling options for the instances that are created from these properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduling")]
        public virtual Scheduling Scheduling { get; set; }

        /// <summary>
        /// A list of service accounts with specified scopes. Access tokens for these service accounts are available to
        /// the instances that are created from these properties. Use metadata queries to obtain the access tokens for
        /// these instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual System.Collections.Generic.IList<ServiceAccount> ServiceAccount { get; set; }

        /// <summary>
        /// The source instance used to create this backup. This can be a partial or full URL to the resource. For
        /// example, the following are valid values:
        /// -https://www.googleapis.com/compute/v1/projects/project/zones/zone/instances/instance
        /// -projects/project/zones/zone/instances/instance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceInstance")]
        public virtual string SourceInstance { get; set; }

        /// <summary>
        /// A list of tags to apply to the instances that are created from these properties. The tags identify valid
        /// sources or targets for network firewalls. The setTags method can modify this list of tags. Each tag within
        /// the list must comply with RFC1035 (https://www.ietf.org/rfc/rfc1035.txt).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual Tags Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ComputeInstanceDataSourceProperties represents the properties of a ComputeEngine resource that are stored in the
    /// DataSource.
    /// </summary>
    public class ComputeInstanceDataSourceProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The machine type of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Name of the compute instance backed up by the datasource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The total number of disks attached to the Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDiskCount")]
        public virtual System.Nullable<long> TotalDiskCount { get; set; }

        /// <summary>The sum of all the disk sizes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDiskSizeGb")]
        public virtual System.Nullable<long> TotalDiskSizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ComputeInstanceRestoreProperties represents Compute Engine instance properties to be overridden during restore.
    /// </summary>
    public class ComputeInstanceRestoreProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Controls for advanced machine-related behavior features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedMachineFeatures")]
        public virtual AdvancedMachineFeatures AdvancedMachineFeatures { get; set; }

        /// <summary>
        /// Optional. Allows this instance to send and receive packets with non-matching destination or source IPs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canIpForward")]
        public virtual System.Nullable<bool> CanIpForward { get; set; }

        /// <summary>Optional. Controls Confidential compute options on the instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialInstanceConfig")]
        public virtual ConfidentialInstanceConfig ConfidentialInstanceConfig { get; set; }

        /// <summary>Optional. Whether the resource should be protected against deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtection")]
        public virtual System.Nullable<bool> DeletionProtection { get; set; }

        /// <summary>
        /// Optional. An optional description of this resource. Provide this property when you create the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Array of disks associated with this instance. Persistent disks must be created before you can
        /// assign them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<AttachedDisk> Disks { get; set; }

        /// <summary>Optional. Enables display device for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayDevice")]
        public virtual DisplayDevice DisplayDevice { get; set; }

        /// <summary>Optional. A list of the type and count of accelerator cards attached to the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestAccelerators")]
        public virtual System.Collections.Generic.IList<AcceleratorConfig> GuestAccelerators { get; set; }

        /// <summary>
        /// Optional. Specifies the hostname of the instance. The specified hostname must be RFC1035 compliant. If
        /// hostname is not specified, the default hostname is [INSTANCE_NAME].c.[PROJECT_ID].internal when using the
        /// global DNS, and [INSTANCE_NAME].[ZONE].c.[PROJECT_ID].internal when using zonal DNS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Optional. Encrypts suspended data for an instance with a customer-managed encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceEncryptionKey")]
        public virtual CustomerEncryptionKey InstanceEncryptionKey { get; set; }

        /// <summary>Optional. KeyRevocationActionType of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyRevocationActionType")]
        public virtual string KeyRevocationActionType { get; set; }

        /// <summary>Optional. Labels to apply to this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Full or partial URL of the machine type resource to use for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Optional. This includes custom metadata and predefined keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual Metadata Metadata { get; set; }

        /// <summary>Optional. Minimum CPU platform to use for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>Required. Name of the compute instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. An array of network configurations for this instance. These specify how interfaces are configured
        /// to interact with other network services, such as connecting to the internet. Multiple interfaces are
        /// supported per instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>Optional. Configure network performance such as egress bandwidth tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkPerformanceConfig")]
        public virtual NetworkPerformanceConfig NetworkPerformanceConfig { get; set; }

        /// <summary>
        /// Input only. Additional params passed with the request, but not persisted as part of resource payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual InstanceParams Params__ { get; set; }

        /// <summary>
        /// Optional. The private IPv6 google access type for the VM. If not specified, use INHERIT_FROM_SUBNETWORK as
        /// default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIpv6GoogleAccess")]
        public virtual string PrivateIpv6GoogleAccess { get; set; }

        /// <summary>Optional. Specifies the reservations that this instance can consume from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationAffinity")]
        public virtual AllocationAffinity ReservationAffinity { get; set; }

        /// <summary>Optional. Resource policies applied to this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePolicies")]
        public virtual System.Collections.Generic.IList<string> ResourcePolicies { get; set; }

        /// <summary>Optional. Sets the scheduling options for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduling")]
        public virtual Scheduling Scheduling { get; set; }

        /// <summary>
        /// Optional. A list of service accounts, with their specified scopes, authorized for this instance. Only one
        /// service account per VM instance is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccounts")]
        public virtual System.Collections.Generic.IList<ServiceAccount> ServiceAccounts { get; set; }

        /// <summary>
        /// Optional. Tags to apply to this instance. Tags are used to identify valid sources or targets for network
        /// firewalls and are specified by the client during instance creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual Tags Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ComputeInstanceTargetEnvironment represents Compute Engine target environment to be used during restore.
    /// </summary>
    public class ComputeInstanceTargetEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Target project for the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>Required. The zone of the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of Confidential Instance options.</summary>
    public class ConfidentialInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Defines whether the instance should have confidential compute enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableConfidentialCompute")]
        public virtual System.Nullable<bool> EnableConfidentialCompute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A customer-supplied encryption key.</summary>
    public class CustomerEncryptionKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the encryption key that is stored in Google Cloud KMS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Optional. The service account being used for the encryption request for the given KMS key. If absent, the
        /// Compute Engine default service account is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyServiceAccount")]
        public virtual string KmsKeyServiceAccount { get; set; }

        /// <summary>Optional. Specifies a 256-bit customer-supplied encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawKey")]
        public virtual string RawKey { get; set; }

        /// <summary>
        /// Optional. RSA-wrapped 2048-bit customer-supplied encryption key to either encrypt or decrypt this resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rsaEncryptedKey")]
        public virtual string RsaEncryptedKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message describing a DataSource object. Datasource object used to represent Datasource details for both admin
    /// and basic view.
    /// </summary>
    public class DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Details of how the resource is configured for backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfigInfo")]
        public virtual BackupConfigInfo BackupConfigInfo { get; set; }

        /// <summary>Number of backups in the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupCount")]
        public virtual System.Nullable<long> BackupCount { get; set; }

        /// <summary>Output only. The backup configuration state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configState")]
        public virtual string ConfigState { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the instance was created.</summary>
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

        /// <summary>The backed up resource is a backup appliance application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceBackupApplianceApplication")]
        public virtual DataSourceBackupApplianceApplication DataSourceBackupApplianceApplication { get; set; }

        /// <summary>
        /// The backed up resource is a Google Cloud resource. The word 'DataSource' was included in the names to
        /// indicate that this is the representation of the Google Cloud resource used within the DataSource object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceGcpResource")]
        public virtual DataSourceGcpResource DataSourceGcpResource { get; set; }

        /// <summary>
        /// Server specified ETag for the ManagementServer resource to prevent simultaneous updates from overwiting each
        /// other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. No labels currently defined:
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Identifier. Name of the datasource to create. It must have the
        /// format`"projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}"`.
        /// `{datasource}` cannot be changed after creation. It must be between 3-63 characters long and must be unique
        /// within the backup vault.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The DataSource resource instance state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The number of bytes (metadata and data) stored in this datasource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalStoredBytes")]
        public virtual System.Nullable<long> TotalStoredBytes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the instance was updated.</summary>
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
    }

    /// <summary>
    /// BackupApplianceApplication describes a Source Resource when it is an application backed up by a BackupAppliance.
    /// </summary>
    public class DataSourceBackupApplianceApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Appliance Id of the Backup Appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applianceId")]
        public virtual System.Nullable<long> ApplianceId { get; set; }

        /// <summary>The appid field of the application within the Backup Appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
        public virtual System.Nullable<long> ApplicationId { get; set; }

        /// <summary>The name of the Application as known to the Backup Appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationName")]
        public virtual string ApplicationName { get; set; }

        /// <summary>Appliance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupAppliance")]
        public virtual string BackupAppliance { get; set; }

        /// <summary>Hostid of the application host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostId")]
        public virtual System.Nullable<long> HostId { get; set; }

        /// <summary>Hostname of the host where the application is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>The type of the application. e.g. VMBackup</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DataSourceGcpResource is used for protected resources that are Google Cloud Resources. This name is easeier to
    /// understand than GcpResourceDataSource or GcpDataSourceResource
    /// </summary>
    public class DataSourceGcpResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ComputeInstanceDataSourceProperties has a subset of Compute Instance properties that are useful at the
        /// Datasource level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeInstanceDatasourceProperties")]
        public virtual ComputeInstanceDataSourceProperties ComputeInstanceDatasourceProperties { get; set; }

        /// <summary>Output only. Full resource pathname URL of the source Google Cloud resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpResourcename")]
        public virtual string GcpResourcename { get; set; }

        /// <summary>Location of the resource: //"global"/"unspecified".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The type of the Google Cloud resource. Use the Unified Resource Type, eg. compute.googleapis.com/Instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of Display Device options</summary>
    public class DisplayDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Enables display for the Compute Engine VM</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDisplay")]
        public virtual System.Nullable<bool> EnableDisplay { get; set; }

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

    /// <summary>A key/value pair to be used for storing metadata.</summary>
    public class Entry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Key for the metadata entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Optional. Value for the metadata entry. These are free-form strings, and only have meaning as interpreted by
        /// the image running in the instance. The only restriction placed on values is that their size must be less
        /// than or equal to 262144 bytes (256 KiB).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for FetchAccessToken.</summary>
    public class FetchAccessTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The generation of the backup to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationId")]
        public virtual System.Nullable<int> GenerationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for FetchAccessToken.</summary>
    public class FetchAccessTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>The token is valid until this time.</summary>
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

        /// <summary>The location in bucket that can be used for reading.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readLocation")]
        public virtual string ReadLocation { get; set; }

        /// <summary>The downscoped token that was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The location in bucket that can be used for writing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeLocation")]
        public virtual string WriteLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for fetching usable BackupVaults.</summary>
    public class FetchUsableBackupVaultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of BackupVault instances in the project for the specified location. If the '{location}' value in
        /// the request is "-", the response contains a list of instances from all locations. In case any location is
        /// unreachable, the response will only return backup vaults in reachable locations and the 'unreachable' field
        /// will be populated with a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVaults")]
        public virtual System.Collections.Generic.IList<BackupVault> BackupVaults { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for finalizing a Backup.</summary>
    public class FinalizeBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Resource ID of the Backup resource to be finalized. This must be the same backup_id that was used
        /// in the InitiateBackupRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual string BackupId { get; set; }

        private string _consistencyTimeRaw;

        private object _consistencyTime;

        /// <summary>
        /// The point in time when this backup was captured from the source. This will be assigned to the
        /// consistency_time field of the newly created Backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consistencyTime")]
        public virtual string ConsistencyTimeRaw
        {
            get => _consistencyTimeRaw;
            set
            {
                _consistencyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _consistencyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ConsistencyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ConsistencyTimeDateTimeOffset instead.")]
        public virtual object ConsistencyTime
        {
            get => _consistencyTime;
            set
            {
                _consistencyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _consistencyTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ConsistencyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ConsistencyTimeRaw);
            set => ConsistencyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>This will be assigned to the description field of the newly created Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _recoveryRangeEndTimeRaw;

        private object _recoveryRangeEndTime;

        /// <summary>
        /// The latest timestamp of data available in this Backup. This will be set on the newly created Backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryRangeEndTime")]
        public virtual string RecoveryRangeEndTimeRaw
        {
            get => _recoveryRangeEndTimeRaw;
            set
            {
                _recoveryRangeEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _recoveryRangeEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RecoveryRangeEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RecoveryRangeEndTimeDateTimeOffset instead.")]
        public virtual object RecoveryRangeEndTime
        {
            get => _recoveryRangeEndTime;
            set
            {
                _recoveryRangeEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _recoveryRangeEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RecoveryRangeEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RecoveryRangeEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RecoveryRangeEndTimeRaw);
            set => RecoveryRangeEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _recoveryRangeStartTimeRaw;

        private object _recoveryRangeStartTime;

        /// <summary>
        /// The earliest timestamp of data available in this Backup. This will set on the newly created Backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryRangeStartTime")]
        public virtual string RecoveryRangeStartTimeRaw
        {
            get => _recoveryRangeStartTimeRaw;
            set
            {
                _recoveryRangeStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _recoveryRangeStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RecoveryRangeStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RecoveryRangeStartTimeDateTimeOffset instead.")]
        public virtual object RecoveryRangeStartTime
        {
            get => _recoveryRangeStartTime;
            set
            {
                _recoveryRangeStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _recoveryRangeStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RecoveryRangeStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RecoveryRangeStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RecoveryRangeStartTimeRaw);
            set => RecoveryRangeStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// The ExpireTime on the backup will be set to FinalizeTime plus this duration. If the resulting ExpireTime is
        /// less than EnforcedRetentionEndTime, then ExpireTime is set to EnforcedRetentionEndTime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionDuration")]
        public virtual object RetentionDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GCPBackupPlanInfo captures the plan configuration details of Google Cloud resources at the time of backup.
    /// </summary>
    public class GCPBackupPlanInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of backup plan by which workload is protected at the time of the backup. Format:
        /// projects/{project}/locations/{location}/backupPlans/{backupPlanId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlan")]
        public virtual string BackupPlan { get; set; }

        /// <summary>
        /// The rule id of the backup plan which triggered this backup in case of scheduled backup or used for
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlanRuleId")]
        public virtual string BackupPlanRuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GcpBackupConfig captures the Backup configuration details for Google Cloud resources. All Google Cloud resources
    /// regardless of type are protected with backup plan associations.
    /// </summary>
    public class GcpBackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the backup plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlan")]
        public virtual string BackupPlan { get; set; }

        /// <summary>The name of the backup plan association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlanAssociation")]
        public virtual string BackupPlanAssociation { get; set; }

        /// <summary>The description of the backup plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlanDescription")]
        public virtual string BackupPlanDescription { get; set; }

        /// <summary>The names of the backup plan rules which point to this backupvault</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlanRules")]
        public virtual System.Collections.Generic.IList<string> BackupPlanRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Minimum details to identify a Google Cloud resource</summary>
    public class GcpResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the Google Cloud resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpResourcename")]
        public virtual string GcpResourcename { get; set; }

        /// <summary>Location of the resource: //"global"/"unspecified".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Type of the resource. Use the Unified Resource Type, eg. compute.googleapis.com/Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Feature type of the Guest OS.</summary>
    public class GuestOsFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of a supported feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the parameters to initialize this disk.</summary>
    public class InitializeParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies the disk name. If not specified, the default is to use the name of the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskName")]
        public virtual string DiskName { get; set; }

        /// <summary>
        /// Optional. URL of the zone where the disk should be created. Required for each regional disk associated with
        /// the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaZones")]
        public virtual System.Collections.Generic.IList<string> ReplicaZones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for initializing the service.</summary>
    public class InitializeServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes since the first request. For example, consider a situation where you
        /// make an initial request and t he request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Required. The resource type to which the default service config will be applied. Examples include,
        /// "compute.googleapis.com/Instance" and "storage.googleapis.com/Bucket".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>request message for InitiateBackup.</summary>
    public class InitiateBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Resource ID of the Backup resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual string BackupId { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes since the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for InitiateBackup.</summary>
    public class InitiateBackupResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the backup that was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>The generation id of the base backup. It is needed for the incremental backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseBackupGenerationId")]
        public virtual System.Nullable<int> BaseBackupGenerationId { get; set; }

        /// <summary>The generation id of the new backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newBackupGenerationId")]
        public virtual System.Nullable<int> NewBackupGenerationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional instance params.</summary>
    public class InstanceParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Resource manager tags to be bound to the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceManagerTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceManagerTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for List BackupPlanAssociation</summary>
    public class ListBackupPlanAssociationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of Backup Plan Associations in the project for the specified location. If the `{location}` value in
        /// the request is "-", the response contains a list of instances from all locations. In case any location is
        /// unreachable, the response will only return backup plan associations in reachable locations and the
        /// 'unreachable' field will be populated with a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlanAssociations")]
        public virtual System.Collections.Generic.IList<BackupPlanAssociation> BackupPlanAssociations { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for getting a list of `BackupPlan`.</summary>
    public class ListBackupPlansResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of `BackupPlans` in the project for the specified location. If the `{location}` value in the
        /// request is "-", the response contains a list of resources from all locations. In case any location is
        /// unreachable, the response will only return backup plans in reachable locations and the 'unreachable' field
        /// will be populated with a list of unreachable locations. BackupPlan
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPlans")]
        public virtual System.Collections.Generic.IList<BackupPlan> BackupPlans { get; set; }

        /// <summary>
        /// A token which may be sent as page_token in a subsequent `ListBackupPlans` call to retrieve the next page of
        /// results. If this field is omitted or empty, then there are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing BackupVaults.</summary>
    public class ListBackupVaultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of BackupVault instances in the project for the specified location. If the '{location}' value in
        /// the request is "-", the response contains a list of instances from all locations. In case any location is
        /// unreachable, the response will only return backup vaults in reachable locations and the 'unreachable' field
        /// will be populated with a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVaults")]
        public virtual System.Collections.Generic.IList<BackupVault> BackupVaults { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing Backups.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of Backup instances in the project for the specified location. If the '{location}' value in the
        /// request is "-", the response contains a list of instances from all locations. In case any location is
        /// unreachable, the response will only return data sources in reachable locations and the 'unreachable' field
        /// will be populated with a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing DataSources.</summary>
    public class ListDataSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of DataSource instances in the project for the specified location. If the '{location}' value in the
        /// request is "-", the response contains a list of instances from all locations. In case any location is
        /// unreachable, the response will only return data sources in reachable locations and the 'unreachable' field
        /// will be populated with a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSources")]
        public virtual System.Collections.Generic.IList<DataSource> DataSources { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
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

    /// <summary>Response message for listing management servers.</summary>
    public class ListManagementServersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of ManagementServer instances in the project for the specified location. If the '{location}' value
        /// in the request is "-", the response contains a list of instances from all locations. In case any location is
        /// unreachable, the response will only return management servers in reachable locations and the 'unreachable'
        /// field will be populated with a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementServers")]
        public virtual System.Collections.Generic.IList<ManagementServer> ManagementServers { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Response for ListResourceBackupConfigs.</summary>
    public class ListResourceBackupConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of ResourceBackupConfigs for the specified scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceBackupConfigs")]
        public virtual System.Collections.Generic.IList<ResourceBackupConfig> ResourceBackupConfigs { get; set; }

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

    /// <summary>ManagementServer describes a single BackupDR ManagementServer instance.</summary>
    public class ManagementServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The hostname or ip address of the exposed AGM endpoints, used by BAs to connect to BA proxy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baProxyUri")]
        public virtual System.Collections.Generic.IList<string> BaProxyUri { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the instance was created.</summary>
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

        /// <summary>Optional. The description of the ManagementServer instance (2048 characters or less).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Server specified ETag for the ManagementServer resource to prevent simultaneous updates from
        /// overwiting each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. Labels currently defined: 1. migrate_from_go=
        /// If set to true, the MS is created in migration ready mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The hostname or ip address of the exposed AGM endpoints, used by clients to connect to AGM/RD
        /// graphical user interface and APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementUri")]
        public virtual ManagementURI ManagementUri { get; set; }

        /// <summary>Output only. Identifier. The resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. VPC networks to which the ManagementServer instance is connected. For this version, only a single
        /// network is supported. This field is optional if MS is created without PSA
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<NetworkConfig> Networks { get; set; }

        /// <summary>
        /// Output only. The OAuth 2.0 client id is required to make API calls to the BackupDR instance API of this
        /// ManagementServer. This is the value that should be provided in the 'aud' field of the OIDC ID Token (see
        /// openid specification https://openid.net/specs/openid-connect-core-1_0.html#IDToken).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientId")]
        public virtual string Oauth2ClientId { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The ManagementServer state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. The type of the ManagementServer resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the instance was updated.</summary>
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
        /// Output only. The hostnames of the exposed AGM endpoints for both types of user i.e. 1p and 3p, used to
        /// connect AGM/RM UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforceIdentityBasedManagementUri")]
        public virtual WorkforceIdentityBasedManagementURI WorkforceIdentityBasedManagementUri { get; set; }

        /// <summary>Output only. The OAuth client IDs for both types of user i.e. 1p and 3p.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforceIdentityBasedOauth2ClientId")]
        public virtual WorkforceIdentityBasedOAuth2ClientID WorkforceIdentityBasedOauth2ClientId { get; set; }
    }

    /// <summary>ManagementURI for the Management Server resource.</summary>
    public class ManagementURI : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ManagementServer AGM/RD API URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("api")]
        public virtual string Api { get; set; }

        /// <summary>Output only. The ManagementServer AGM/RD WebUI URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webUi")]
        public virtual string WebUi { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A metadata key/value entry.</summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Array of key/value pairs. The total size of all keys and values must be less than 512 KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Entry> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network configuration for ManagementServer instance.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource name of the Google Compute Engine VPC network to which the ManagementServer instance
        /// is connected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The network connect mode of the ManagementServer instance. For this version, only
        /// PRIVATE_SERVICE_ACCESS is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringMode")]
        public virtual string PeeringMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A network interface resource attached to an instance. s</summary>
    public class NetworkInterface : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of configurations for this interface. Currently, only one access config,ONE_TO_ONE_NAT is
        /// supported. If there are no accessConfigs specified, then this instance will have no external internet
        /// access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessConfigs")]
        public virtual System.Collections.Generic.IList<AccessConfig> AccessConfigs { get; set; }

        /// <summary>
        /// Optional. An array of alias IP ranges for this network interface. You can only specify this field for
        /// network interfaces in VPC networks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasIpRanges")]
        public virtual System.Collections.Generic.IList<AliasIpRange> AliasIpRanges { get; set; }

        /// <summary>Optional. The prefix length of the primary internal IPv6 range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIpv6PrefixLength")]
        public virtual System.Nullable<int> InternalIpv6PrefixLength { get; set; }

        /// <summary>
        /// Optional. An array of IPv6 access configurations for this interface. Currently, only one IPv6 access config,
        /// DIRECT_IPV6, is supported. If there is no ipv6AccessConfig specified, then this instance will have no
        /// external IPv6 Internet access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6AccessConfigs")]
        public virtual System.Collections.Generic.IList<AccessConfig> Ipv6AccessConfigs { get; set; }

        /// <summary>
        /// Optional. [Output Only] One of EXTERNAL, INTERNAL to indicate whether the IP can be accessed from the
        /// Internet. This field is always inherited from its subnetwork.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6AccessType")]
        public virtual string Ipv6AccessType { get; set; }

        /// <summary>
        /// Optional. An IPv6 internal network address for this network interface. To use a static internal IP address,
        /// it must be unused and in the same region as the instance's zone. If not specified, Google Cloud will
        /// automatically assign an internal IPv6 address from the instance's subnetwork.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6Address")]
        public virtual string Ipv6Address { get; set; }

        /// <summary>
        /// Output only. [Output Only] The name of the network interface, which is generated by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. URL of the VPC network resource for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The URL of the network attachment that this interface should connect to in the following format:
        /// projects/{project_number}/regions/{region_name}/networkAttachments/{network_attachment_name}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkAttachment")]
        public virtual string NetworkAttachment { get; set; }

        /// <summary>
        /// Optional. An IPv4 internal IP address to assign to the instance for this network interface. If not specified
        /// by the user, an unused internal IP is assigned by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkIP")]
        public virtual string NetworkIP { get; set; }

        /// <summary>Optional. The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nicType")]
        public virtual string NicType { get; set; }

        /// <summary>
        /// Optional. The networking queue count that's specified by users for the network interface. Both Rx and Tx
        /// queues will be set to this number. It'll be empty if not specified by the users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queueCount")]
        public virtual System.Nullable<int> QueueCount { get; set; }

        /// <summary>The stack type for this network interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackType")]
        public virtual string StackType { get; set; }

        /// <summary>Optional. The URL of the Subnetwork resource for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network performance configuration.</summary>
    public class NetworkPerformanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The tier of the total egress bandwidth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalEgressBandwidthTier")]
        public virtual string TotalEgressBandwidthTier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Node Affinity: the configuration of desired nodes onto which this Instance could be scheduled.
    /// </summary>
    public class NodeAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Corresponds to the label key of Node resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. Defines the operation of node selection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>Optional. Corresponds to the label values of Node resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. AdditionalInfo contains additional Info related to backup plan association resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalInfo")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalInfo { get; set; }

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
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to 'Code.CANCELLED'.
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

    /// <summary>Point in time recovery settings of the backup configuration resource.</summary>
    public class PitrSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of days to retain the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionDays")]
        public virtual System.Nullable<int> RetentionDays { get; set; }

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
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

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

    /// <summary>Message for deleting a DataSource.</summary>
    public class RemoveDataSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceBackupConfig represents a resource along with its backup configurations.</summary>
    public class ResourceBackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Backup configurations applying to the target resource, including those targeting its related/child
        /// resources. For example, backup configuration applicable to Compute Engine disks will be populated in this
        /// field for a Compute Engine VM which has the disk associated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfigsDetails")]
        public virtual System.Collections.Generic.IList<BackupConfigDetails> BackupConfigsDetails { get; set; }

        /// <summary>
        /// Output only. Whether the target resource is configured for backup. This is true if the
        /// backup_configs_details is not empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfigured")]
        public virtual System.Nullable<bool> BackupConfigured { get; set; }

        /// <summary>
        /// Identifier. The resource name of the ResourceBackupConfig. Format:
        /// projects/{project}/locations/{location}/resourceBackupConfigs/{uid}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-format) of
        /// the cloud resource that this configuration applies to. Supported resource types are
        /// ResourceBackupConfig.ResourceType.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        /// <summary>Output only. The human friendly name of the target resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResourceDisplayName")]
        public virtual string TargetResourceDisplayName { get; set; }

        /// <summary>Labels associated with the target resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResourceLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> TargetResourceLabels { get; set; }

        /// <summary>Output only. The type of the target resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResourceType")]
        public virtual string TargetResourceType { get; set; }

        /// <summary>Output only. The unique identifier of the resource backup config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        /// Output only. Whether the target resource is protected by a backup vault. This is true if the
        /// backup_configs_details is not empty and any of the ResourceBackupConfig.backup_configs_details has a backup
        /// configuration with BackupConfigDetails.backup_vault set. set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vaulted")]
        public virtual System.Nullable<bool> Vaulted { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for restoring from a Backup.</summary>
    public class RestoreBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compute Engine instance properties to be overridden during restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeInstanceRestoreProperties")]
        public virtual ComputeInstanceRestoreProperties ComputeInstanceRestoreProperties { get; set; }

        /// <summary>Compute Engine target environment to be used during restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeInstanceTargetEnvironment")]
        public virtual ComputeInstanceTargetEnvironment ComputeInstanceTargetEnvironment { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for restoring from a Backup.</summary>
    public class RestoreBackupResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details of the target resource created/modified as part of restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual TargetResource TargetResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for rules config info.</summary>
    public class RuleConfigInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. google.rpc.Status object to store the last backup error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastBackupError")]
        public virtual Status LastBackupError { get; set; }

        /// <summary>Output only. The last backup state for rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastBackupState")]
        public virtual string LastBackupState { get; set; }

        private string _lastSuccessfulBackupConsistencyTimeRaw;

        private object _lastSuccessfulBackupConsistencyTime;

        /// <summary>
        /// Output only. The point in time when the last successful backup was captured from the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSuccessfulBackupConsistencyTime")]
        public virtual string LastSuccessfulBackupConsistencyTimeRaw
        {
            get => _lastSuccessfulBackupConsistencyTimeRaw;
            set
            {
                _lastSuccessfulBackupConsistencyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSuccessfulBackupConsistencyTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="LastSuccessfulBackupConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSuccessfulBackupConsistencyTimeDateTimeOffset instead.")]
        public virtual object LastSuccessfulBackupConsistencyTime
        {
            get => _lastSuccessfulBackupConsistencyTime;
            set
            {
                _lastSuccessfulBackupConsistencyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSuccessfulBackupConsistencyTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of
        /// <see cref="LastSuccessfulBackupConsistencyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSuccessfulBackupConsistencyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSuccessfulBackupConsistencyTimeRaw);
            set => LastSuccessfulBackupConsistencyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Backup Rule id fetched from backup plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sets the scheduling options for an Instance.</summary>
    public class Scheduling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies whether the instance should be automatically restarted if it is terminated by Compute
        /// Engine (not terminated by a user).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automaticRestart")]
        public virtual System.Nullable<bool> AutomaticRestart { get; set; }

        /// <summary>Optional. Specifies the termination action for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceTerminationAction")]
        public virtual string InstanceTerminationAction { get; set; }

        /// <summary>
        /// Optional. Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd
        /// state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default
        /// value being 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localSsdRecoveryTimeout")]
        public virtual SchedulingDuration LocalSsdRecoveryTimeout { get; set; }

        /// <summary>
        /// Optional. The minimum number of virtual CPUs this instance will consume when running on a sole-tenant node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodeCpus")]
        public virtual System.Nullable<int> MinNodeCpus { get; set; }

        /// <summary>
        /// Optional. A set of node affinity and anti-affinity configurations. Overrides reservationAffinity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeAffinities")]
        public virtual System.Collections.Generic.IList<NodeAffinity> NodeAffinities { get; set; }

        /// <summary>Optional. Defines the maintenance behavior for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onHostMaintenance")]
        public virtual string OnHostMaintenance { get; set; }

        /// <summary>Optional. Defines whether the instance is preemptible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preemptible")]
        public virtual System.Nullable<bool> Preemptible { get; set; }

        /// <summary>Optional. Specifies the provisioning model of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningModel")]
        public virtual string ProvisioningModel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A SchedulingDuration represents a fixed-length span of time represented as a count of seconds and fractions of
    /// seconds at nanosecond resolution. It is independent of any calendar and concepts like "day" or "month". Range is
    /// approximately 10,000 years.
    /// </summary>
    public class SchedulingDuration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Span of time that's a fraction of a second at nanosecond resolution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>Optional. Span of time at a resolution of a second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<long> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A service account.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Email address of the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Optional. The list of scopes to be made available for this service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ServiceLockInfo represents the details of a lock taken by the service on a Backup resource.</summary>
    public class ServiceLockInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The name of the operation that created this lock. The lock will automatically be released when
        /// the operation completes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SetStatusInternal method.</summary>
    public class SetInternalStatusRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Output only. The new BackupConfigState to set for the DataSource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfigState")]
        public virtual string BackupConfigState { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. The request ID must be a valid UUID with the
        /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Required. The value required for this method to work. This field must be the 32-byte SHA256 hash of the
        /// DataSourceID. The DataSourceID used here is only the final piece of the fully qualified resource path for
        /// this DataSource (i.e. the part after '.../dataSources/'). This field exists to make this method difficult to
        /// call since it is intended for use only by Backup Appliances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message from SetStatusInternal method.</summary>
    public class SetInternalStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `StandardSchedule` defines a schedule that run within the confines of a defined window of days. We can define
    /// recurrence type for schedule as HOURLY, DAILY, WEEKLY, MONTHLY or YEARLY.
    /// </summary>
    public class StandardSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A BackupWindow defines the window of day during which backup jobs will run. Jobs are queued at the
        /// beginning of the window and will be marked as `NOT_RUN` if they do not start by the end of the window. Note:
        /// running jobs will not be cancelled at the end of the window.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupWindow")]
        public virtual BackupWindow BackupWindow { get; set; }

        /// <summary>
        /// Optional. Specifies days of months like 1, 5, or 14 on which jobs will run. Values for `days_of_month` are
        /// only applicable for `recurrence_type`, `MONTHLY` and `YEARLY`. A validation error will occur if other values
        /// are supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfMonth")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DaysOfMonth { get; set; }

        /// <summary>
        /// Optional. Specifies days of week like, MONDAY or TUESDAY, on which jobs will run. This is required for
        /// `recurrence_type`, `WEEKLY` and is not applicable otherwise. A validation error will occur if a value is
        /// supplied and `recurrence_type` is not `WEEKLY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfWeek")]
        public virtual System.Collections.Generic.IList<string> DaysOfWeek { get; set; }

        /// <summary>
        /// Optional. Specifies frequency for hourly backups. A hourly frequency of 2 means jobs will run every 2 hours
        /// from start time till end time defined. This is required for `recurrence_type`, `HOURLY` and is not
        /// applicable otherwise. A validation error will occur if a value is supplied and `recurrence_type` is not
        /// `HOURLY`. Value of hourly frequency should be between 4 and 23. Reason for limit : We found that there is
        /// bandwidth limitation of 3GB/S for GMI while taking a backup and 5GB/S while doing a restore. Given the
        /// amount of parallel backups and restore we are targeting, this will potentially take the backup time to mins
        /// and hours (in worst case scenario).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourlyFrequency")]
        public virtual System.Nullable<int> HourlyFrequency { get; set; }

        /// <summary>
        /// Optional. Specifies the months of year, like `FEBRUARY` and/or `MAY`, on which jobs will run. This field is
        /// only applicable when `recurrence_type` is `YEARLY`. A validation error will occur if other values are
        /// supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("months")]
        public virtual System.Collections.Generic.IList<string> Months { get; set; }

        /// <summary>Required. Specifies the `RecurrenceType` for the schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrenceType")]
        public virtual string RecurrenceType { get; set; }

        /// <summary>
        /// Required. The time zone to be used when interpreting the schedule. The value of this field must be a time
        /// zone name from the IANA tz database. See https://en.wikipedia.org/wiki/List_of_tz_database_time_zones for
        /// the list of valid timezone names. For e.g., Europe/Paris.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// Optional. Specifies a week day of the month like, FIRST SUNDAY or LAST MONDAY, on which jobs will run. This
        /// will be specified by two fields in `WeekDayOfMonth`, one for the day, e.g. `MONDAY`, and one for the week,
        /// e.g. `LAST`. This field is only applicable for `recurrence_type`, `MONTHLY` and `YEARLY`. A validation error
        /// will occur if other values are supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekDayOfMonth")]
        public virtual WeekDayOfMonth WeekDayOfMonth { get; set; }

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

    /// <summary>A set of instance tags.</summary>
    public class Tags : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of tags. Each tag must be 1-63 characters long, and comply with RFC1035.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<string> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the target resource created/modified as part of restore.</summary>
    public class TargetResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details of the native Google Cloud resource created as part of restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpResource")]
        public virtual GcpResource GcpResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for triggering a backup.</summary>
    public class TriggerBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes after the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>Required. backup rule_id for which a backup needs to be triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `WeekDayOfMonth` defines the week day of the month on which the backups will run. The message combines a
    /// `WeekOfMonth` and `DayOfWeek` to produce values like `FIRST`/`MONDAY` or `LAST`/`FRIDAY`.
    /// </summary>
    public class WeekDayOfMonth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>Required. Specifies the week of the month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekOfMonth")]
        public virtual string WeekOfMonth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ManagementURI depending on the Workforce Identity i.e. either 1p or 3p.</summary>
    public class WorkforceIdentityBasedManagementURI : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. First party Management URI for Google Identities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPartyManagementUri")]
        public virtual string FirstPartyManagementUri { get; set; }

        /// <summary>Output only. Third party Management URI for External Identity Providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyManagementUri")]
        public virtual string ThirdPartyManagementUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OAuth Client ID depending on the Workforce Identity i.e. either 1p or 3p,</summary>
    public class WorkforceIdentityBasedOAuth2ClientID : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. First party OAuth Client ID for Google Identities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPartyOauth2ClientId")]
        public virtual string FirstPartyOauth2ClientId { get; set; }

        /// <summary>Output only. Third party OAuth Client ID for External Identity Providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyOauth2ClientId")]
        public virtual string ThirdPartyOauth2ClientId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
