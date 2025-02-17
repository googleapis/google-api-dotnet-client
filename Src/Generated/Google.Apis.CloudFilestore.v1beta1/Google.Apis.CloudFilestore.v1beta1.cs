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

namespace Google.Apis.CloudFilestore.v1beta1
{
    /// <summary>The CloudFilestore Service.</summary>
    public class CloudFilestoreService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudFilestoreService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudFilestoreService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://file.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://file.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "file";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Filestore API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Filestore API.</summary>
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

    /// <summary>A base abstract class for CloudFilestore requests.</summary>
    public abstract class CloudFilestoreBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudFilestoreBaseServiceRequest instance.</summary>
        protected CloudFilestoreBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudFilestore parameter list.</summary>
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
                Backups = new BackupsResource(service);
                Instances = new InstancesResource(service);
                Operations = new OperationsResource(service);
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

                /// <summary>Creates a backup.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The backup's project and location, in the format
                /// `projects/{project_id}/locations/{location}`. In Filestore, backup locations map to Google Cloud
                /// regions, for example **us-west1**.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudFilestore.v1beta1.Data.Backup body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a backup.</summary>
                public class CreateRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Backup body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backup's project and location, in the format
                    /// `projects/{project_id}/locations/{location}`. In Filestore, backup locations map to Google Cloud
                    /// regions, for example **us-west1**.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the backup. The ID must be unique within the specified project and
                    /// location. This value must start with a lowercase letter followed by up to 62 lowercase letters,
                    /// numbers, or hyphens, and cannot end with a hyphen.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.Backup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/backups";

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
                        RequestParameters.Add("backupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "backupId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a backup.</summary>
                /// <param name="name">
                /// Required. The backup resource name, in the format
                /// `projects/{project_id}/locations/{location}/backups/{backup_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a backup.</summary>
                public class DeleteRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backup resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backups/{backup_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a specific backup.</summary>
                /// <param name="name">
                /// Required. The backup resource name, in the format
                /// `projects/{project_id}/locations/{location}/backups/{backup_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a specific backup.</summary>
                public class GetRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Backup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backup resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backups/{backup_id}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backups/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all backups in a project for either a specified location or for all locations.
                /// </summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve backup information, in the format
                /// `projects/{project_id}/locations/{location}`. In Filestore, backup locations map to Google Cloud
                /// regions, for example **us-west1**. To retrieve backup information for all locations, use "-" for the
                /// `{location}` value.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all backups in a project for either a specified location or for all locations.
                /// </summary>
                public class ListRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.ListBackupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve backup information, in the format
                    /// `projects/{project_id}/locations/{location}`. In Filestore, backup locations map to Google Cloud
                    /// regions, for example **us-west1**. To retrieve backup information for all locations, use "-" for
                    /// the `{location}` value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Sort results. Supported values are "name", "name desc" or "" (unsorted).</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The next_page_token value to use if there are additional results to retrieve for this list
                    /// request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/backups";

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

                /// <summary>Updates the settings of a specific backup.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the backup, in the format
                /// `projects/{project_id}/locations/{location_id}/backups/{backup_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudFilestore.v1beta1.Data.Backup body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the settings of a specific backup.</summary>
                public class PatchRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Backup body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the backup, in the format
                    /// `projects/{project_id}/locations/{location_id}/backups/{backup_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.Backup Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backups/[^/]+$",
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
                    Shares = new SharesResource(service);
                    Snapshots = new SnapshotsResource(service);
                }

                /// <summary>Gets the Shares resource.</summary>
                public virtual SharesResource Shares { get; }

                /// <summary>The "shares" collection of methods.</summary>
                public class SharesResource
                {
                    private const string Resource = "shares";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SharesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a share.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The Filestore Instance to create the share for, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudFilestore.v1beta1.Data.Share body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a share.</summary>
                    public class CreateRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Share body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Filestore Instance to create the share for, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the share. The ID must be unique within the specified instance.
                        /// This value must start with a lowercase letter followed by up to 62 lowercase letters,
                        /// numbers, or hyphens, and cannot end with a hyphen.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("shareId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ShareId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudFilestore.v1beta1.Data.Share Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/shares";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                            });
                            RequestParameters.Add("shareId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "shareId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a share.</summary>
                    /// <param name="name">
                    /// Required. The share resource name, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}/share/{share_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a share.</summary>
                    public class DeleteRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The share resource name, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/share/{share_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/shares/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the details of a specific share.</summary>
                    /// <param name="name">
                    /// Required. The share resource name, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}/shares/{share_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the details of a specific share.</summary>
                    public class GetRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Share>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The share resource name, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/shares/{share_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/shares/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all shares for a specified instance.</summary>
                    /// <param name="parent">
                    /// Required. The instance for which to retrieve share information, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all shares for a specified instance.</summary>
                    public class ListRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.ListSharesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The instance for which to retrieve share information, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>List filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Sort results. Supported values are "name", "name desc" or "" (unsorted).</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>The maximum number of items to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The next_page_token value to use if there are additional results to retrieve for this list
                        /// request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/shares";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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

                    /// <summary>Updates the settings of a specific share.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of the share, in the format
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}/shares/{share_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudFilestore.v1beta1.Data.Share body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the settings of a specific share.</summary>
                    public class PatchRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Share body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of the share, in the format
                        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}/shares/{share_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field. The
                        /// elements of the repeated paths field may only include these fields: * "description" *
                        /// "capacity_gb" * "labels" * "nfs_export_options"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudFilestore.v1beta1.Data.Share Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/shares/[^/]+$",
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

                /// <summary>Gets the Snapshots resource.</summary>
                public virtual SnapshotsResource Snapshots { get; }

                /// <summary>The "snapshots" collection of methods.</summary>
                public class SnapshotsResource
                {
                    private const string Resource = "snapshots";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SnapshotsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a snapshot.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The Filestore Instance to create the snapshots of, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudFilestore.v1beta1.Data.Snapshot body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a snapshot.</summary>
                    public class CreateRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Snapshot body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Filestore Instance to create the snapshots of, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the snapshot. The ID must be unique within the specified
                        /// instance. This value must start with a lowercase letter followed by up to 62 lowercase
                        /// letters, numbers, or hyphens, and cannot end with a hyphen.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("snapshotId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string SnapshotId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudFilestore.v1beta1.Data.Snapshot Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                            });
                            RequestParameters.Add("snapshotId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "snapshotId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a snapshot.</summary>
                    /// <param name="name">
                    /// Required. The snapshot resource name, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a snapshot.</summary>
                    public class DeleteRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The snapshot resource name, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the details of a specific snapshot.</summary>
                    /// <param name="name">
                    /// Required. The snapshot resource name, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the details of a specific snapshot.</summary>
                    public class GetRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Snapshot>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The snapshot resource name, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all snapshots in a project for either a specified location or for all locations.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The instance for which to retrieve snapshot information, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists all snapshots in a project for either a specified location or for all locations.
                    /// </summary>
                    public class ListRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.ListSnapshotsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The instance for which to retrieve snapshot information, in the format
                        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>List filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Sort results. Supported values are "name", "name desc" or "" (unsorted).</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>The maximum number of items to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The next_page_token value to use if there are additional results to retrieve for this list
                        /// request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                            RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                            {
                                Name = "returnPartialSuccess",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Updates the settings of a specific snapshot.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name of the snapshot, in the format
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}/snapshots/{snapshot_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudFilestore.v1beta1.Data.Snapshot body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the settings of a specific snapshot.</summary>
                    public class PatchRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Snapshot body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name of the snapshot, in the format
                        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}/snapshots/{snapshot_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudFilestore.v1beta1.Data.Snapshot Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/snapshots/[^/]+$",
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

                /// <summary>
                /// Creates an instance. When creating from a backup, the capacity of the new instance needs to be equal
                /// to or larger than the capacity of the backup (and also equal to or larger than the minimum capacity
                /// of the tier).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The instance's project and location, in the format
                /// `projects/{project_id}/locations/{location}`. In Filestore, locations map to Google Cloud zones, for
                /// example **us-west1-b**.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudFilestore.v1beta1.Data.Instance body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates an instance. When creating from a backup, the capacity of the new instance needs to be equal
                /// to or larger than the capacity of the backup (and also equal to or larger than the minimum capacity
                /// of the tier).
                /// </summary>
                public class CreateRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Instance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance's project and location, in the format
                    /// `projects/{project_id}/locations/{location}`. In Filestore, locations map to Google Cloud zones,
                    /// for example **us-west1-b**.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the instance to create. The ID must be unique within the specified project
                    /// and location. This value must start with a lowercase letter followed by up to 62 lowercase
                    /// letters, numbers, or hyphens, and cannot end with a hyphen.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.Instance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/instances";

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

                /// <summary>Deletes an instance.</summary>
                /// <param name="name">
                /// Required. The instance resource name, in the format
                /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an instance.</summary>
                public class DeleteRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance resource name, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, any snapshots of the instance will also be deleted. (Otherwise, the request will
                    /// only work if the instance has no snapshots.)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the details of a specific instance.</summary>
                /// <param name="name">
                /// Required. The instance resource name, in the format
                /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a specific instance.</summary>
                public class GetRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The instance resource name, in the format
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all instances in a project for either a specified location or for all locations.
                /// </summary>
                /// <param name="parent">
                /// Required. The project and location for which to retrieve instance information, in the format
                /// `projects/{project_id}/locations/{location}`. In Cloud Filestore, locations map to Google Cloud
                /// zones, for example **us-west1-b**. To retrieve instance information for all locations, use "-" for
                /// the `{location}` value.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all instances in a project for either a specified location or for all locations.
                /// </summary>
                public class ListRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.ListInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location for which to retrieve instance information, in the format
                    /// `projects/{project_id}/locations/{location}`. In Cloud Filestore, locations map to Google Cloud
                    /// zones, for example **us-west1-b**. To retrieve instance information for all locations, use "-"
                    /// for the `{location}` value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Sort results. Supported values are "name", "name desc" or "" (unsorted).</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The next_page_token value to use if there are additional results to retrieve for this list
                    /// request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/instances";

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

                /// <summary>Updates the settings of a specific instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the instance, in the format
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudFilestore.v1beta1.Data.Instance body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the settings of a specific instance.</summary>
                public class PatchRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.Instance body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the instance, in the format
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field. The
                    /// elements of the repeated paths field may only include these fields: * "description" *
                    /// "directory_services" * "file_shares" * "labels" * "performance_config" *
                    /// "deletion_protection_enabled" * "deletion_protection_reason"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.Instance Body { get; set; }

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

                /// <summary>Promote the standby instance (replica).</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the instance, in the format
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                /// </param>
                public virtual PromoteReplicaRequest PromoteReplica(Google.Apis.CloudFilestore.v1beta1.Data.PromoteReplicaRequest body, string name)
                {
                    return new PromoteReplicaRequest(this.service, body, name);
                }

                /// <summary>Promote the standby instance (replica).</summary>
                public class PromoteReplicaRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new PromoteReplica request.</summary>
                    public PromoteReplicaRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.PromoteReplicaRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the instance, in the format
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.PromoteReplicaRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "promoteReplica";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:promoteReplica";

                    /// <summary>Initializes PromoteReplica parameter list.</summary>
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
                /// Restores an existing instance's file share from a backup. The capacity of the instance needs to be
                /// equal to or larger than the capacity of the backup (and also equal to or larger than the minimum
                /// capacity of the tier).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the instance, in the format
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.CloudFilestore.v1beta1.Data.RestoreInstanceRequest body, string name)
                {
                    return new RestoreRequest(this.service, body, name);
                }

                /// <summary>
                /// Restores an existing instance's file share from a backup. The capacity of the instance needs to be
                /// equal to or larger than the capacity of the backup (and also equal to or larger than the minimum
                /// capacity of the tier).
                /// </summary>
                public class RestoreRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.RestoreInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the instance, in the format
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.RestoreInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:restore";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Revert an existing instance's file system to a specified snapshot.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the instance, in the format
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                /// </param>
                public virtual RevertRequest Revert(Google.Apis.CloudFilestore.v1beta1.Data.RevertInstanceRequest body, string name)
                {
                    return new RevertRequest(this.service, body, name);
                }

                /// <summary>Revert an existing instance's file system to a specified snapshot.</summary>
                public class RevertRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Revert request.</summary>
                    public RevertRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.RevertInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the instance, in the format
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.RevertInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "revert";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:revert";

                    /// <summary>Initializes Revert parameter list.</summary>
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
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.CloudFilestore.v1beta1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudFilestore.v1beta1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudFilestore.v1beta1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:cancel";

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
                public class DeleteRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Empty>
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
                public class GetRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Operation>
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
                public class ListRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1beta1/{+name}/operations";

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
            public class GetRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.Location>
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
            public class ListRequest : CloudFilestoreBaseServiceRequest<Google.Apis.CloudFilestore.v1beta1.Data.ListLocationsResponse>
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

                /// <summary>If true, the returned list will include locations which are not yet revealed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUnrevealedLocations", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUnrevealedLocations { get; set; }

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
                public override string RestPath => "v1beta1/{+name}/locations";

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
                    RequestParameters.Add("includeUnrevealedLocations", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUnrevealedLocations",
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
namespace Google.Apis.CloudFilestore.v1beta1.Data
{
    /// <summary>A Filestore backup.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Capacity of the source file share when the backup was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGb")]
        public virtual System.Nullable<long> CapacityGb { get; set; }

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

        /// <summary>
        /// A description of the backup with 2048 characters or less. Requests with longer descriptions will be
        /// rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Amount of bytes that will be downloaded if the backup is restored</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadBytes")]
        public virtual System.Nullable<long> DownloadBytes { get; set; }

        /// <summary>
        /// Output only. The file system protocol of the source Filestore instance that this backup is created from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSystemProtocol")]
        public virtual string FileSystemProtocol { get; set; }

        /// <summary>Immutable. KMS key name used for data encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The resource name of the backup, in the format
        /// `projects/{project_id}/locations/{location_id}/backups/{backup_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Name of the file share in the source Filestore instance that the backup is created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFileShare")]
        public virtual string SourceFileShare { get; set; }

        /// <summary>
        /// The resource name of the source Filestore instance, in the format
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`, used to create this backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceInstance")]
        public virtual string SourceInstance { get; set; }

        /// <summary>
        /// Output only. The service tier of the source Filestore instance that this backup is created from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceInstanceTier")]
        public virtual string SourceInstanceTier { get; set; }

        /// <summary>Output only. The backup state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The size of the storage used by the backup. As backups share storage, this number is expected
        /// to change with backup creation/deletion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBytes")]
        public virtual System.Nullable<long> StorageBytes { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag key-value pairs bound to this resource. Each key must be a namespaced
        /// name and each value a short name. Example: "123456789012/environment" : "production",
        /// "123456789013/costCenter" : "marketing" See the documentation for more information: - Namespaced name:
        /// https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing#retrieving_tag_key - Short
        /// name: https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing#retrieving_tag_value
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for daily operations.</summary>
    public class DailyCycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Duration of the time window, set by service producer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Time within the day to start the operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

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
    public class Date : Google.Apis.Requests.IDirectResponseSchema
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
    /// DenyMaintenancePeriod definition. Maintenance is forbidden within the deny period. The start_date must be less
    /// than the end_date.
    /// </summary>
    public class DenyMaintenancePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deny period end date. This can be: * A full date, with non-zero year, month and day values. * A month and
        /// day value, with a zero year. Allows recurring deny periods each year. Date matching this period will have to
        /// be before the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// Deny period start date. This can be: * A full date, with non-zero year, month and day values. * A month and
        /// day value, with a zero year. Allows recurring deny periods each year. Date matching this period will have to
        /// be the same or after the start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>
        /// Time in UTC when the Blackout period starts on start_date and ends on end_date. This can be: * Full time. *
        /// All zeros for 00:00:00 UTC
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual TimeOfDay Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Directory Services configuration for Kerberos-based authentication.</summary>
    public class DirectoryServicesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for Managed Service for Microsoft Active Directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedActiveDirectory")]
        public virtual ManagedActiveDirectoryConfig ManagedActiveDirectory { get; set; }

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

    /// <summary>File share configuration for the instance.</summary>
    public class FileShareConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>File share capacity in gigabytes (GB). Filestore defines 1 GB as 1024^3 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGb")]
        public virtual System.Nullable<long> CapacityGb { get; set; }

        /// <summary>
        /// Required. The name of the file share. Must use 1-16 characters for the basic service tier and 1-63
        /// characters for all other service tiers. Must use lowercase letters, numbers, or underscores `[a-z0-9_]`.
        /// Must start with a letter. Immutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nfs Export Options. There is a limit of 10 export options per file share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsExportOptions")]
        public virtual System.Collections.Generic.IList<NfsExportOptions> NfsExportOptions { get; set; }

        /// <summary>
        /// The resource name of the backup, in the format
        /// `projects/{project_id}/locations/{location_id}/backups/{backup_id}`, that this file share has been restored
        /// from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fixed IOPS (input/output operations per second) parameters.</summary>
    public class FixedIOPS : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Maximum IOPS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIops")]
        public virtual System.Nullable<long> MaxIops { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Instance represents the interface for SLM services to actuate the state of control plane resources. Example
    /// Instance in JSON, where consumer-project-number=123456, producer-project-id=cloud-sql:
    /// ```
    /// json Instance: {
    /// "name": "projects/123456/locations/us-east1/instances/prod-instance", "create_time": { "seconds": 1526406431, },
    /// "labels": { "env": "prod", "foo": "bar" }, "state": READY, "software_versions": { "software_update":
    /// "cloud-sql-09-28-2018", }, "maintenance_policy_names": { "UpdatePolicy":
    /// "projects/123456/locations/us-east1/maintenancePolicies/prod-update-policy", } "tenant_project_id":
    /// "cloud-sql-test-tenant", "producer_metadata": { "cloud-sql-tier": "basic", "cloud-sql-instance-size": "1G", },
    /// "provisioned_resources": [ { "resource-type": "compute-instance", "resource-url":
    /// "https://www.googleapis.com/compute/v1/projects/cloud-sql/zones/us-east1-b/instances/vm-1", } ],
    /// "maintenance_schedules": { "csa_rollout": { "start_time": { "seconds": 1526406431, }, "end_time": { "seconds":
    /// 1535406431, }, }, "ncsa_rollout": { "start_time": { "seconds": 1526406431, }, "end_time": { "seconds":
    /// 1535406431, }, } }, "consumer_defined_name": "my-sql-instance1", }
    /// ```
    /// LINT.IfChange
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// consumer_defined_name is the name of the instance set by the service consumers. Generally this is different
        /// from the `name` field which reperesents the system-assigned id of the instance which the service consumers
        /// do not recognize. This is a required field for tenants onboarding to Maintenance Window notifications
        /// (go/slm-rollout-maintenance-policies#prerequisites).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerDefinedName")]
        public virtual string ConsumerDefinedName { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the resource was created.</summary>
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
        /// Optional. The instance_type of this instance of format:
        /// projects/{project_number}/locations/{location_id}/instanceTypes/{instance_type_id}. Instance Type represents
        /// a high-level tier or SKU of the service that this instance belong to. When enabled(eg: Maintenance Rollout),
        /// Rollout uses 'instance_type' along with 'software_versions' to determine whether instance needs an update or
        /// not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. Each label is a key-value pair, where both
        /// the key and the value are arbitrary strings provided by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The MaintenancePolicies that have been attached to the instance. The key must be of the type name
        /// of the oneof policy name defined in MaintenancePolicy, and the referenced policy must define the same policy
        /// type. For details, please refer to go/mr-user-guide. Should not be set if
        /// maintenance_settings.maintenance_policies is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicyNames")]
        public virtual System.Collections.Generic.IDictionary<string, string> MaintenancePolicyNames { get; set; }

        /// <summary>
        /// The MaintenanceSchedule contains the scheduling information of published maintenance schedule with same key
        /// as software_versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSchedules")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSchedule> MaintenanceSchedules { get; set; }

        /// <summary>Optional. The MaintenanceSettings associated with instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSettings")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSettings MaintenanceSettings { get; set; }

        /// <summary>
        /// Unique name of the resource. It uses the form:
        /// `projects/{project_number}/locations/{location_id}/instances/{instance_id}` Note: This name is passed,
        /// stored and logged across the rollout system. So use of consumer project_id or any other consumer PII in the
        /// name is strongly discouraged for wipeout (go/wipeout) compliance. See
        /// go/elysium/project_ids#storage-guidance for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. notification_parameter are information that service producers may like to include that is not
        /// relevant to Rollout. This parameter will only be passed to Gamma and Cloud Logging for notification/logging
        /// purpose.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationParameters")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSaasacceleratorManagementProvidersV1NotificationParameter> NotificationParameters { get; set; }

        /// <summary>
        /// Output only. Custom string attributes used primarily to expose producer-specific information in monitoring
        /// dashboards. See go/get-instance-metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> ProducerMetadata { get; set; }

        /// <summary>
        /// Output only. The list of data plane resources provisioned for this instance, e.g. compute VMs. See
        /// go/get-instance-metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1ProvisionedResource> ProvisionedResources { get; set; }

        /// <summary>
        /// Link to the SLM instance template. Only populated when updating SLM instances via SSA's Actuation service
        /// adaptor. Service producers with custom control plane (e.g. Cloud SQL) doesn't need to populate this field.
        /// Instead they should use software_versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slmInstanceTemplate")]
        public virtual string SlmInstanceTemplate { get; set; }

        /// <summary>
        /// Output only. SLO metadata for instance classification in the Standardized dataplane SLO platform. See
        /// go/cloud-ssa-standard-slo for feature description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sloMetadata")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1SloMetadata SloMetadata { get; set; }

        /// <summary>
        /// Software versions that are used to deploy this instance. This can be mutated by rollout services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareVersions")]
        public virtual System.Collections.Generic.IDictionary<string, string> SoftwareVersions { get; set; }

        /// <summary>
        /// Output only. Current lifecycle state of the resource (e.g. if it's being created or ready to use).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ID of the associated GCP tenant project. See go/get-instance-metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectId")]
        public virtual string TenantProjectId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the resource was last modified.</summary>
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
    /// Maintenance schedule which is exposed to customer and potentially end user, indicating published upcoming future
    /// maintenance schedule
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field is deprecated, and will be always set to true since reschedule can happen multiple times now.
        /// This field should not be removed until all service producers remove this for their customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReschedule")]
        public virtual System.Nullable<bool> CanReschedule { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The scheduled end time for the maintenance.</summary>
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
        /// The rollout management policy this maintenance schedule is associated with. When doing reschedule update
        /// request, the reschedule should be against this given policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutManagementPolicy")]
        public virtual string RolloutManagementPolicy { get; set; }

        private string _scheduleDeadlineTimeRaw;

        private object _scheduleDeadlineTime;

        /// <summary>
        /// schedule_deadline_time is the time deadline any schedule start time cannot go beyond, including reschedule.
        /// It's normally the initial schedule start time plus maintenance window length (1 day or 1 week). Maintenance
        /// cannot be scheduled to start beyond this deadline.
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

        /// <summary>The scheduled start time for the maintenance.</summary>
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
    /// Maintenance settings associated with instance. Allows service producers and end users to assign settings that
    /// controls maintenance on this instance.
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Exclude instance from maintenance. When true, rollout service will not attempt maintenance on the
        /// instance. Rollout service will include the instance in reported rollout progress as not attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclude")]
        public virtual System.Nullable<bool> Exclude { get; set; }

        /// <summary>Optional. If the update call is triggered from rollback, set the value as true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRollback")]
        public virtual System.Nullable<bool> IsRollback { get; set; }

        /// <summary>
        /// Optional. The MaintenancePolicies that have been attached to the instance. The key must be of the type name
        /// of the oneof policy name defined in MaintenancePolicy, and the embedded policy must define the same policy
        /// type. For details, please refer to go/mr-user-guide. Should not be set if maintenance_policy_names is set.
        /// If only the name is needed, then only populate MaintenancePolicy.name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicies")]
        public virtual System.Collections.Generic.IDictionary<string, MaintenancePolicy> MaintenancePolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Node information for custom per-node SLO implementations. SSA does not support per-node SLO, but producers can
    /// populate per-node information in SloMetadata for custom precomputations. SSA Eligibility Exporter will emit
    /// per-node metric based on this information.
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1NodeSloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The location of the node, if different from instance location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The id of the node. This should be equal to SaasInstanceNode.node_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeId")]
        public virtual string NodeId { get; set; }

        /// <summary>
        /// If present, this will override eligibility for the node coming from instance or exclusions for specified
        /// SLIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSliEligibility")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1PerSliSloEligibility PerSliEligibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains notification related data.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1NotificationParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Array of string values. e.g. instance's replica information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PerSliSloEligibility is a mapping from an SLI name to eligibility.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1PerSliSloEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An entry in the eligibilities map specifies an eligibility for a particular SLI for the given instance. The
        /// SLI key in the name must be a valid SLI name specified in the Eligibility Exporter binary flags otherwise an
        /// error will be emitted by Eligibility Exporter and the oncaller will be alerted. If an SLI has been defined
        /// in the binary flags but the eligibilities map does not contain it, the corresponding SLI time series will
        /// not be emitted by the Eligibility Exporter. This ensures a smooth rollout and compatibility between the data
        /// produced by different versions of the Eligibility Exporters. If eligibilities map contains a key for an SLI
        /// which has not been declared in the binary flags, there will be an error message emitted in the Eligibility
        /// Exporter log and the metric for the SLI in question will not be emitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibilities")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSaasacceleratorManagementProvidersV1SloEligibility> Eligibilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes provisioned dataplane resources.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1ProvisionedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type of the resource. This can be either a GCP resource or a custom one (e.g. another cloud provider's VM).
        /// For GCP compute resources use singular form of the names listed in GCP compute API documentation
        /// (https://cloud.google.com/compute/docs/reference/rest/v1/), prefixed with 'compute-', for example:
        /// 'compute-instance', 'compute-disk', 'compute-autoscaler'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>URL identifying the resource, e.g. "https://www.googleapis.com/compute/v1/projects/...)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SloEligibility is a tuple containing eligibility value: true if an instance is eligible for SLO calculation or
    /// false if it should be excluded from all SLO-related calculations along with a user-defined reason.
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether an instance is eligible or ineligible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligible")]
        public virtual System.Nullable<bool> Eligible { get; set; }

        /// <summary>
        /// User-defined reason for the current value of instance eligibility. Usually, this can be directly mapped to
        /// the internal state. An empty reason is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SloMetadata contains resources required for proper SLO classification of the instance.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of nodes. Some producers need to use per-node metadata to calculate SLO. This field allows
        /// such producers to publish per-node SLO meta data, which will be consumed by SSA Eligibility Exporter and
        /// published in the form of per node metric to Monarch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1NodeSloMetadata> Nodes { get; set; }

        /// <summary>Optional. Multiple per-instance SLI eligibilities which apply for individual SLIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSliEligibility")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1PerSliSloEligibility PerSliEligibility { get; set; }

        /// <summary>
        /// Name of the SLO tier the Instance belongs to. This name will be expected to match the tiers specified in the
        /// service SLO configuration. Field is mandatory and must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IOPS per TB. Filestore defines TB as 1024^4 bytes (TiB).</summary>
    public class IOPSPerTB : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Maximum IOPS per TiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIopsPerTb")]
        public virtual System.Nullable<long> MaxIopsPerTb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Filestore instance.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The storage capacity of the instance in gigabytes (GB = 1024^3 bytes). This capacity can be increased up to
        /// `max_capacity_gb` GB in multipliers of `capacity_step_size_gb` GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGb")]
        public virtual System.Nullable<long> CapacityGb { get; set; }

        /// <summary>Output only. The increase/decrease capacity step size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityStepSizeGb")]
        public virtual System.Nullable<long> CapacityStepSizeGb { get; set; }

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
        /// Output only. Indicates whether this instance supports configuring its performance. If true, the user can
        /// configure the instance's performance by using the 'performance_config' field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPerformanceSupported")]
        public virtual System.Nullable<bool> CustomPerformanceSupported { get; set; }

        /// <summary>Optional. Indicates whether the instance is protected against deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtectionEnabled")]
        public virtual System.Nullable<bool> DeletionProtectionEnabled { get; set; }

        /// <summary>Optional. The reason for enabling deletion protection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtectionReason")]
        public virtual string DeletionProtectionReason { get; set; }

        /// <summary>The description of the instance (2048 characters or less).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Directory Services configuration for Kerberos-based authentication. Should only be set if protocol
        /// is "NFS_V4_1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directoryServices")]
        public virtual DirectoryServicesConfig DirectoryServices { get; set; }

        /// <summary>
        /// Server-specified ETag for the instance resource to prevent simultaneous updates from overwriting each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// File system shares on the instance. For this version, only a single file share is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileShares")]
        public virtual System.Collections.Generic.IList<FileShareConfig> FileShares { get; set; }

        /// <summary>KMS key name used for data encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The max capacity of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCapacityGb")]
        public virtual System.Nullable<long> MaxCapacityGb { get; set; }

        /// <summary>The max number of shares allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxShareCount")]
        public virtual System.Nullable<long> MaxShareCount { get; set; }

        /// <summary>
        /// Indicates whether this instance uses a multi-share configuration with which it can have more than one
        /// file-share or none at all. File-shares are added, updated and removed through the separate file-share APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiShareEnabled")]
        public virtual System.Nullable<bool> MultiShareEnabled { get; set; }

        /// <summary>
        /// Output only. The resource name of the instance, in the format
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// VPC networks to which the instance is connected. For this version, only a single network is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<NetworkConfig> Networks { get; set; }

        /// <summary>Optional. Used to configure performance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceConfig")]
        public virtual PerformanceConfig PerformanceConfig { get; set; }

        /// <summary>Output only. Used for getting performance limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceLimits")]
        public virtual PerformanceLimits PerformanceLimits { get; set; }

        /// <summary>
        /// Immutable. The protocol indicates the access protocol for all shares in the instance. This field is
        /// immutable and it cannot be changed after the instance has been created. Default value: `NFS_V3`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Optional. Replication configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replication")]
        public virtual Replication Replication { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The instance state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional information about the instance state, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Field indicates all the reasons the instance is in "SUSPENDED" state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReasons")]
        public virtual System.Collections.Generic.IList<string> SuspensionReasons { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag key-value pairs bound to this resource. Each key must be a namespaced
        /// name and each value a short name. Example: "123456789012/environment" : "production",
        /// "123456789013/costCenter" : "marketing" See the documentation for more information: - Namespaced name:
        /// https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing#retrieving_tag_key - Short
        /// name: https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing#retrieving_tag_value
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The service tier of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }
    }

    /// <summary>ListBackupsResponse is the result of ListBackupsRequest.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of backups in the project for the specified location. If the `{location}` value in the request is
        /// "-", the response contains a list of backups from all locations. If any location is unreachable, the
        /// response will only return backups in reachable locations and the "unreachable" field will be populated with
        /// a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// The token you can use to retrieve the next page of results. Not returned if there are no more results in the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListInstancesResponse is the result of ListInstancesRequest.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of instances in the project for the specified location. If the `{location}` value in the request is
        /// "-", the response contains a list of instances from all locations. If any location is unreachable, the
        /// response will only return instances in reachable locations and the "unreachable" field will be populated
        /// with a list of unreachable locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>
        /// The token you can use to retrieve the next page of results. Not returned if there are no more results in the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
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

    /// <summary>ListSharesResponse is the result of ListSharesRequest.</summary>
    public class ListSharesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token you can use to retrieve the next page of results. Not returned if there are no more results in the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of shares in the project for the specified instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shares")]
        public virtual System.Collections.Generic.IList<Share> Shares { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListSnapshotsResponse is the result of ListSnapshotsRequest.</summary>
    public class ListSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token you can use to retrieve the next page of results. Not returned if there are no more results in the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of snapshots in the project for the specified instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshots")]
        public virtual System.Collections.Generic.IList<Snapshot> Snapshots { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Defines policies to service maintenance events.</summary>
    public class MaintenancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the resource was created.</summary>
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

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. Each label is a key-value pair, where both
        /// the key and the value are arbitrary strings provided by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. MaintenancePolicy name using the form:
        /// `projects/{project_id}/locations/{location_id}/maintenancePolicies/{maintenance_policy_id}` where
        /// {project_id} refers to a GCP consumer project ID, {location_id} refers to a GCP region/zone,
        /// {maintenance_policy_id} must be 1-63 characters long and match the regular expression
        /// `[a-z0-9]([-a-z0-9]*[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The state of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Maintenance policy applicable to instance update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePolicy")]
        public virtual UpdatePolicy UpdatePolicy { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the resource was updated.</summary>
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

    /// <summary>MaintenanceWindow definition.</summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daily cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyCycle")]
        public virtual DailyCycle DailyCycle { get; set; }

        /// <summary>Weekly cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyCycle")]
        public virtual WeeklyCycle WeeklyCycle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ManagedActiveDirectoryConfig contains all the parameters for connecting to Managed Service for Microsoft Active
    /// Directory (Managed Microsoft AD).
    /// </summary>
    public class ManagedActiveDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The computer name is used as a prefix in the command to mount the remote target. For example: if
        /// the computer is `my-computer`, the mount command will look like: `$mount -o vers=4.1,sec=krb5
        /// my-computer.filestore.: `.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computer")]
        public virtual string Computer { get; set; }

        /// <summary>
        /// Required. The domain resource name, in the format `projects/{project_id}/locations/global/domains/{domain}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network configuration for the instance.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The network connect mode of the Filestore instance. If not provided, the connect mode defaults to
        /// DIRECT_PEERING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectMode")]
        public virtual string ConnectMode { get; set; }

        /// <summary>
        /// Output only. IPv4 addresses in the format `{octet1}.{octet2}.{octet3}.{octet4}` or IPv6 addresses in the
        /// format `{block1}:{block2}:{block3}:{block4}:{block5}:{block6}:{block7}:{block8}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>
        /// Internet protocol versions for which the instance has IP addresses assigned. For this version, only
        /// MODE_IPV4 is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modes")]
        public virtual System.Collections.Generic.IList<string> Modes { get; set; }

        /// <summary>
        /// The name of the Google Compute Engine [VPC network](https://cloud.google.com/vpc/docs/vpc) to which the
        /// instance is connected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional, reserved_ip_range can have one of the following two types of values. * CIDR range value when using
        /// DIRECT_PEERING connect mode. * [Allocated IP address
        /// range](https://cloud.google.com/compute/docs/ip-addresses/reserve-static-internal-ip-address) when using
        /// PRIVATE_SERVICE_ACCESS connect mode. When the name of an allocated IP address range is specified, it must be
        /// one of the ranges associated with the private service access connection. When specified as a direct CIDR
        /// value, it must be a /29 CIDR block for Basic tier, a /24 CIDR block for High Scale tier, or a /26 CIDR block
        /// for Enterprise tier in one of the [internal IP address
        /// ranges](https://www.arin.net/reference/research/statistics/address_filters/) that identifies the range of IP
        /// addresses reserved for this instance. For example, 10.0.0.0/29, 192.168.0.0/24, or 192.168.0.0/26,
        /// respectively. The range you specify can't overlap with either existing subnets or assigned IP address ranges
        /// for other Filestore instances in the selected VPC network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedIpRange")]
        public virtual string ReservedIpRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NFS export options specifications.</summary>
    public class NfsExportOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Either READ_ONLY, for allowing only read requests on the exported directory, or READ_WRITE, for allowing
        /// both read and write requests. The default is READ_WRITE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessMode")]
        public virtual string AccessMode { get; set; }

        /// <summary>
        /// An integer representing the anonymous group id with a default value of 65534. Anon_gid may only be set with
        /// squash_mode of ROOT_SQUASH. An error will be returned if this field is specified for other squash_mode
        /// settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anonGid")]
        public virtual System.Nullable<long> AnonGid { get; set; }

        /// <summary>
        /// An integer representing the anonymous user id with a default value of 65534. Anon_uid may only be set with
        /// squash_mode of ROOT_SQUASH. An error will be returned if this field is specified for other squash_mode
        /// settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anonUid")]
        public virtual System.Nullable<long> AnonUid { get; set; }

        /// <summary>
        /// List of either an IPv4 addresses in the format `{octet1}.{octet2}.{octet3}.{octet4}` or CIDR ranges in the
        /// format `{octet1}.{octet2}.{octet3}.{octet4}/{mask size}` which may mount the file share. Overlapping IP
        /// ranges are not allowed, both within and across NfsExportOptions. An error will be returned. The limit is 64
        /// IP ranges/addresses for each FileShareConfig among all NfsExportOptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipRanges")]
        public virtual System.Collections.Generic.IList<string> IpRanges { get; set; }

        /// <summary>The security flavors allowed for mount operations. The default is AUTH_SYS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityFlavors")]
        public virtual System.Collections.Generic.IList<string> SecurityFlavors { get; set; }

        /// <summary>
        /// Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH, for not allowing
        /// root access. The default is NO_ROOT_SQUASH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("squashMode")]
        public virtual string SquashMode { get; set; }

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

    /// <summary>
    /// Used for setting the performance configuration. If the user doesn't specify PerformanceConfig, automatically
    /// provision the default performance settings as described in https://cloud.google.com/filestore/docs/performance.
    /// Larger instances will be linearly set to more IOPS. If the instance's capacity is increased or decreased, its
    /// performance will be automatically adjusted upwards or downwards accordingly (respectively).
    /// </summary>
    public class PerformanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Choose a fixed provisioned IOPS value for the instance, which will remain constant regardless of instance
        /// capacity. Value must be a multiple of 1000. If the chosen value is outside the supported range for the
        /// instance's capacity during instance creation, instance creation will fail with an `InvalidArgument` error.
        /// Similarly, if an instance capacity update would result in a value outside the supported range, the update
        /// will fail with an `InvalidArgument` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedIops")]
        public virtual FixedIOPS FixedIops { get; set; }

        /// <summary>
        /// Provision IOPS dynamically based on the capacity of the instance. Provisioned IOPS will be calculated by
        /// multiplying the capacity of the instance in TiB by the `iops_per_tb` value. For example, for a 2 TiB
        /// instance with an `iops_per_tb` value of 17000 the provisioned IOPS will be 34000. If the calculated value is
        /// outside the supported range for the instance's capacity during instance creation, instance creation will
        /// fail with an `InvalidArgument` error. Similarly, if an instance capacity update would result in a value
        /// outside the supported range, the update will fail with an `InvalidArgument` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iopsPerTb")]
        public virtual IOPSPerTB IopsPerTb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The enforced performance limits, calculated from the instance's performance configuration.</summary>
    public class PerformanceLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The max IOPS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIops")]
        public virtual System.Nullable<long> MaxIops { get; set; }

        /// <summary>Output only. The max read IOPS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReadIops")]
        public virtual System.Nullable<long> MaxReadIops { get; set; }

        /// <summary>Output only. The max read throughput in bytes per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReadThroughputBps")]
        public virtual System.Nullable<long> MaxReadThroughputBps { get; set; }

        /// <summary>Output only. The max write IOPS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWriteIops")]
        public virtual System.Nullable<long> MaxWriteIops { get; set; }

        /// <summary>Output only. The max write throughput in bytes per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWriteThroughputBps")]
        public virtual System.Nullable<long> MaxWriteThroughputBps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PromoteReplicaRequest promotes a Filestore standby instance (replica).</summary>
    public class PromoteReplicaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource name of the peer instance to promote, in the format
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`. The peer instance is required if
        /// the operation is called on an active instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerInstance")]
        public virtual string PeerInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Replica configuration for the instance.</summary>
    public class ReplicaConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastActiveSyncTimeRaw;

        private object _lastActiveSyncTime;

        /// <summary>
        /// Output only. The timestamp of the latest replication snapshot taken on the active instance and is already
        /// replicated safely.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastActiveSyncTime")]
        public virtual string LastActiveSyncTimeRaw
        {
            get => _lastActiveSyncTimeRaw;
            set
            {
                _lastActiveSyncTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastActiveSyncTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastActiveSyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastActiveSyncTimeDateTimeOffset instead.")]
        public virtual object LastActiveSyncTime
        {
            get => _lastActiveSyncTime;
            set
            {
                _lastActiveSyncTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastActiveSyncTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastActiveSyncTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastActiveSyncTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastActiveSyncTimeRaw);
            set => LastActiveSyncTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The peer instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerInstance")]
        public virtual string PeerInstance { get; set; }

        /// <summary>Output only. The replica state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional information about the replication state, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateReasons")]
        public virtual System.Collections.Generic.IList<string> StateReasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Replication specifications.</summary>
    public class Replication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Replication configuration for the replica instance associated with this instance. Only a single replica is
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Collections.Generic.IList<ReplicaConfig> Replicas { get; set; }

        /// <summary>Output only. The replication role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RestoreInstanceRequest restores an existing instance's file share from a backup.</summary>
    public class RestoreInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the file share in the Filestore instance that the backup is being restored to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileShare")]
        public virtual string FileShare { get; set; }

        /// <summary>
        /// The resource name of the backup, in the format
        /// `projects/{project_id}/locations/{location_id}/backups/{backup_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>
        /// The resource name of the snapshot, in the format
        /// `projects/{project_id}/locations/{location_id}/snapshots/{snapshot_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSnapshot")]
        public virtual string SourceSnapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RevertInstanceRequest reverts the given instance's file share to the specified snapshot.</summary>
    public class RevertInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The snapshot resource ID, in the format 'my-snapshot', where the specified ID is the {snapshot_id}
        /// of the fully qualified name like
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSnapshotId")]
        public virtual string TargetSnapshotId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configure the schedule.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allows to define schedule that runs specified day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Output only. Duration of the time window, set by service producer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Time within the window to start the operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Filestore share.</summary>
    public class Share : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Full name of the Cloud Filestore Backup resource that this Share is restored from, in the format
        /// of projects/{project_id}/locations/{location_id}/backups/{backup_id}. Empty, if the Share is created from
        /// scratch and not restored from a backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// File share capacity in gigabytes (GB). Filestore defines 1 GB as 1024^3 bytes. Must be greater than 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGb")]
        public virtual System.Nullable<long> CapacityGb { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the share was created.</summary>
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
        /// A description of the share with 2048 characters or less. Requests with longer descriptions will be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The mount name of the share. Must be 63 characters or less and consist of uppercase or lowercase letters,
        /// numbers, and underscores.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountName")]
        public virtual string MountName { get; set; }

        /// <summary>
        /// Output only. The resource name of the share, in the format
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}/shares/{share_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nfs Export Options. There is a limit of 10 export options per file share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsExportOptions")]
        public virtual System.Collections.Generic.IList<NfsExportOptions> NfsExportOptions { get; set; }

        /// <summary>Output only. The share state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Filestore snapshot.</summary>
    public class Snapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the snapshot was created.</summary>
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
        /// A description of the snapshot with 2048 characters or less. Requests with longer descriptions will be
        /// rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The amount of bytes needed to allocate a full copy of the snapshot content</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesystemUsedBytes")]
        public virtual System.Nullable<long> FilesystemUsedBytes { get; set; }

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The resource name of the snapshot, in the format
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}/snapshots/{snapshot_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The snapshot state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag key-value pairs bound to this resource. Each key must be a namespaced
        /// name and each value a short name. Example: "123456789012/environment" : "production",
        /// "123456789013/costCenter" : "marketing" See the documentation for more information: - Namespaced name:
        /// https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing#retrieving_tag_key - Short
        /// name: https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing#retrieving_tag_value
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

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

    /// <summary>Maintenance policy applicable to instance updates.</summary>
    public class UpdatePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Relative scheduling channel applied to resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// Deny Maintenance Period that is applied to resource to indicate when maintenance is forbidden. The protocol
        /// supports zero-to-many such periods, but the current SLM Rollout implementation only supports zero-to-one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyMaintenancePeriods")]
        public virtual System.Collections.Generic.IList<DenyMaintenancePeriod> DenyMaintenancePeriods { get; set; }

        /// <summary>Optional. Maintenance window that is applied to resources covered by this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("window")]
        public virtual MaintenanceWindow Window { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for weekly operations.</summary>
    public class WeeklyCycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User can specify multiple windows in a week. Minimum of 1 window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual System.Collections.Generic.IList<Schedule> Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
