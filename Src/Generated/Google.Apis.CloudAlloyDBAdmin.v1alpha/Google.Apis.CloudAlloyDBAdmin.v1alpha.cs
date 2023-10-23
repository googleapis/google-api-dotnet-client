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

namespace Google.Apis.CloudAlloyDBAdmin.v1alpha
{
    /// <summary>The CloudAlloyDBAdmin Service.</summary>
    public class CloudAlloyDBAdminService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudAlloyDBAdminService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudAlloyDBAdminService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "alloydb";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://alloydb.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://alloydb.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the AlloyDB API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the AlloyDB API.</summary>
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

    /// <summary>A base abstract class for CloudAlloyDBAdmin requests.</summary>
    public abstract class CloudAlloyDBAdminBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudAlloyDBAdminBaseServiceRequest instance.</summary>
        protected CloudAlloyDBAdminBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudAlloyDBAdmin parameter list.</summary>
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
                Clusters = new ClustersResource(service);
                Operations = new OperationsResource(service);
                SupportedDatabaseFlags = new SupportedDatabaseFlagsResource(service);
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

                /// <summary>Creates a new Backup in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Backup body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Backup in a given project and location.</summary>
                public class CreateRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Backup body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the requesting object.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupId { get; set; }

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
                    /// Optional. If set, the backend validates the request, but doesn't actually execute it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Backup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/backups";

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

                /// <summary>Deletes a single Backup.</summary>
                /// <param name="name">
                /// Required. Name of the resource. For the required format, see the comment on the Backup.name field.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Backup.</summary>
                public class DeleteRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource. For the required format, see the comment on the Backup.name
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The current etag of the Backup. If an etag is provided and does not match the current
                    /// etag of the Backup, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                    /// Optional. If set, the backend validates the request, but doesn't actually execute it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Gets details of a single Backup.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single Backup.</summary>
                public class GetRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Backup>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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

                /// <summary>Lists Backups in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListBackupsRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Backups in a given project and location.</summary>
                public class ListRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.ListBackupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListBackupsRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/backups";

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

                /// <summary>Updates the parameters of a single Backup.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The name of the backup resource with the format: *
                /// projects/{project}/locations/{region}/backups/{backup_id} where the cluster and backup ID segments
                /// should satisfy the regex expression `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`, e.g. 1-63 characters of
                /// lowercase letters, numbers, and dashes, starting with a letter, and ending with a letter or number.
                /// For more details see https://google.aip.dev/122. The prefix of the backup resource name is the name
                /// of the parent resource: * projects/{project}/locations/{region}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Backup body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single Backup.</summary>
                public class PatchRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Backup body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The name of the backup resource with the format: *
                    /// projects/{project}/locations/{region}/backups/{backup_id} where the cluster and backup ID
                    /// segments should satisfy the regex expression `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`, e.g. 1-63
                    /// characters of lowercase letters, numbers, and dashes, starting with a letter, and ending with a
                    /// letter or number. For more details see https://google.aip.dev/122. The prefix of the backup
                    /// resource name is the name of the parent resource: * projects/{project}/locations/{region}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, update succeeds even if instance is not found. In that case, a new
                    /// backup is created and `update_mask` is ignored.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

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
                    /// Optional. Field mask is used to specify the fields to be overwritten in the Backup resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If set, the backend validates the request, but doesn't actually execute it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Backup Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                    Instances = new InstancesResource(service);
                    Users = new UsersResource(service);
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

                    /// <summary>Creates a new Instance in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the parent resource. For the required format, see the comment on the
                    /// Instance.name field.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new Instance in a given project and location.</summary>
                    public class CreateRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource. For the required format, see the comment on the
                        /// Instance.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. ID of the requesting object.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string InstanceId { get; set; }

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
                        /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                        /// validation), but do not actually execute the create request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/instances";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                            });
                            RequestParameters.Add("instanceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "instanceId",
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

                    /// <summary>Creates a new SECONDARY Instance in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the parent resource. For the required format, see the comment on the
                    /// Instance.name field.
                    /// </param>
                    public virtual CreatesecondaryRequest Createsecondary(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance body, string parent)
                    {
                        return new CreatesecondaryRequest(service, body, parent);
                    }

                    /// <summary>Creates a new SECONDARY Instance in a given project and location.</summary>
                    public class CreatesecondaryRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Createsecondary request.</summary>
                        public CreatesecondaryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource. For the required format, see the comment on the
                        /// Instance.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. ID of the requesting object.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string InstanceId { get; set; }

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
                        /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                        /// validation), but do not actually execute the create request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "createsecondary";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/instances:createsecondary";

                        /// <summary>Initializes Createsecondary parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                            });
                            RequestParameters.Add("instanceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "instanceId",
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

                    /// <summary>Deletes a single Instance.</summary>
                    /// <param name="name">
                    /// Required. The name of the resource. For the required format, see the comment on the
                    /// Instance.name field.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a single Instance.</summary>
                    public class DeleteRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource. For the required format, see the comment on the
                        /// Instance.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the Instance. If an etag is provided and does not match the
                        /// current etag of the Instance, deletion will be blocked and an ABORTED error will be
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
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
                        /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                        /// validation), but do not actually execute the delete.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/instances/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
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
                    /// Forces a Failover for a highly available instance. Failover promotes the HA standby instance as
                    /// the new primary. Imperative only.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the resource. For the required format, see the comment on the
                    /// Instance.name field.
                    /// </param>
                    public virtual FailoverRequest Failover(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.FailoverInstanceRequest body, string name)
                    {
                        return new FailoverRequest(service, body, name);
                    }

                    /// <summary>
                    /// Forces a Failover for a highly available instance. Failover promotes the HA standby instance as
                    /// the new primary. Imperative only.
                    /// </summary>
                    public class FailoverRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Failover request.</summary>
                        public FailoverRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.FailoverInstanceRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource. For the required format, see the comment on the
                        /// Instance.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.FailoverInstanceRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "failover";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:failover";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/instances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single Instance.</summary>
                    /// <param name="name">
                    /// Required. The name of the resource. For the required format, see the comment on the
                    /// Instance.name field.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets details of a single Instance.</summary>
                    public class GetRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource. For the required format, see the comment on the
                        /// Instance.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The view of the instance to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>The view of the instance to return.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>INSTANCE_VIEW_UNSPECIFIED Not specified, equivalent to BASIC.</summary>
                            [Google.Apis.Util.StringValueAttribute("INSTANCE_VIEW_UNSPECIFIED")]
                            INSTANCEVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// BASIC server responses for a primary or read instance include all the relevant instance
                            /// details, excluding the details of each node in the instance. The default value.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("INSTANCE_VIEW_BASIC")]
                            INSTANCEVIEWBASIC = 1,

                            /// <summary>
                            /// FULL response is equivalent to BASIC for primary instance (for now). For read pool
                            /// instance, this includes details of each node in the pool.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("INSTANCE_VIEW_FULL")]
                            INSTANCEVIEWFULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/instances/[^/]+$",
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

                    /// <summary>Get instance metadata used for a connection.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource. The required format is:
                    /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
                    /// </param>
                    public virtual GetConnectionInfoRequest GetConnectionInfo(string parent)
                    {
                        return new GetConnectionInfoRequest(service, parent);
                    }

                    /// <summary>Get instance metadata used for a connection.</summary>
                    public class GetConnectionInfoRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.ConnectionInfo>
                    {
                        /// <summary>Constructs a new GetConnectionInfo request.</summary>
                        public GetConnectionInfoRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource. The required format is:
                        /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getConnectionInfo";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/connectionInfo";

                        /// <summary>Initializes GetConnectionInfo parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/instances/[^/]+$",
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

                    /// <summary>Injects fault in an instance. Imperative only.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the resource. For the required format, see the comment on the
                    /// Instance.name field.
                    /// </param>
                    public virtual InjectFaultRequest InjectFault(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.InjectFaultRequest body, string name)
                    {
                        return new InjectFaultRequest(service, body, name);
                    }

                    /// <summary>Injects fault in an instance. Imperative only.</summary>
                    public class InjectFaultRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new InjectFault request.</summary>
                        public InjectFaultRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.InjectFaultRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource. For the required format, see the comment on the
                        /// Instance.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.InjectFaultRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "injectFault";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:injectFault";

                        /// <summary>Initializes InjectFault parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/instances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Instances in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource. For the required format, see the comment on the
                    /// Instance.name field. Additionally, you can perform an aggregated list operation by specifying a
                    /// value with one of the following formats: * projects/{project}/locations/-/clusters/- *
                    /// projects/{project}/locations/{region}/clusters/-
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists Instances in a given project and location.</summary>
                    public class ListRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.ListInstancesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource. For the required format, see the comment on the
                        /// Instance.name field. Additionally, you can perform an aggregated list operation by
                        /// specifying a value with one of the following formats: *
                        /// projects/{project}/locations/-/clusters/- * projects/{project}/locations/{region}/clusters/-
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/instances";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Updates the parameters of a single Instance.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The name of the instance resource with the format: *
                    /// projects/{project}/locations/{region}/clusters/{cluster_id}/instances/{instance_id} where the
                    /// cluster and instance ID segments should satisfy the regex expression
                    /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`, e.g. 1-63 characters of lowercase letters, numbers, and
                    /// dashes, starting with a letter, and ending with a letter or number. For more details see
                    /// https://google.aip.dev/122. The prefix of the instance resource name is the name of the parent
                    /// resource: * projects/{project}/locations/{region}/clusters/{cluster_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the parameters of a single Instance.</summary>
                    public class PatchRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The name of the instance resource with the format: *
                        /// projects/{project}/locations/{region}/clusters/{cluster_id}/instances/{instance_id} where
                        /// the cluster and instance ID segments should satisfy the regex expression
                        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`, e.g. 1-63 characters of lowercase letters, numbers, and
                        /// dashes, starting with a letter, and ending with a letter or number. For more details see
                        /// https://google.aip.dev/122. The prefix of the instance resource name is the name of the
                        /// parent resource: * projects/{project}/locations/{region}/clusters/{cluster_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set to true, update succeeds even if instance is not found. In that case, a new
                        /// instance is created and `update_mask` is ignored.
                        /// </summary>
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
                        /// Optional. Field mask is used to specify the fields to be overwritten in the Instance
                        /// resource by the update. The fields specified in the update_mask are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                        /// validation), but do not actually execute the update request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Instance Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/instances/[^/]+$",
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

                    /// <summary>Restart an Instance in a cluster. Imperative only.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the resource. For the required format, see the comment on the
                    /// Instance.name field.
                    /// </param>
                    public virtual RestartRequest Restart(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.RestartInstanceRequest body, string name)
                    {
                        return new RestartRequest(service, body, name);
                    }

                    /// <summary>Restart an Instance in a cluster. Imperative only.</summary>
                    public class RestartRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                    {
                        /// <summary>Constructs a new Restart request.</summary>
                        public RestartRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.RestartInstanceRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource. For the required format, see the comment on the
                        /// Instance.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.RestartInstanceRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "restart";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:restart";

                        /// <summary>Initializes Restart parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/instances/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Users resource.</summary>
                public virtual UsersResource Users { get; }

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

                    /// <summary>Creates a new User in a given project, location, and cluster.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. Value for parent.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new User in a given project, location, and cluster.</summary>
                    public class CreateRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Value for parent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

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

                        /// <summary>Required. ID of the requesting object.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UserId { get; set; }

                        /// <summary>
                        /// Optional. If set, the backend validates the request, but doesn't actually execute it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/users";

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
                            RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "userId",
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

                    /// <summary>Deletes a single User.</summary>
                    /// <param name="name">
                    /// Required. The name of the resource. For the required format, see the comment on the User.name
                    /// field.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a single User.</summary>
                    public class DeleteRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource. For the required format, see the comment on the
                        /// User.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
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
                        /// Optional. If set, the backend validates the request, but doesn't actually execute it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/users/[^/]+$",
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

                    /// <summary>Gets details of a single User.</summary>
                    /// <param name="name">
                    /// Required. The name of the resource. For the required format, see the comment on the User.name
                    /// field.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets details of a single User.</summary>
                    public class GetRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource. For the required format, see the comment on the
                        /// User.name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/users/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Users in a given project and location.</summary>
                    /// <param name="parent">Required. Parent value for ListUsersRequest</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists Users in a given project and location.</summary>
                    public class ListRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.ListUsersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for ListUsersRequest</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results</summary>
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
                        public override string RestPath => "v1alpha/{+parent}/users";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Updates the parameters of a single User.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Name of the resource in the form of
                    /// projects/{project}/locations/{location}/cluster/{cluster}/users/{user}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the parameters of a single User.</summary>
                    public class PatchRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Name of the resource in the form of
                        /// projects/{project}/locations/{location}/cluster/{cluster}/users/{user}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. Allow missing fields in the update mask.</summary>
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
                        /// Optional. Field mask is used to specify the fields to be overwritten in the User resource by
                        /// the update. The fields specified in the update_mask are relative to the resource, not the
                        /// full request. A field will be overwritten if it is in the mask. If the user does not provide
                        /// a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. If set, the backend validates the request, but doesn't actually execute it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.User Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/users/[^/]+$",
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
                }

                /// <summary>Creates a new Cluster in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location of the new cluster. For the required format, see the comment on the
                /// Cluster.name field.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Cluster in a given project and location.</summary>
                public class CreateRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location of the new cluster. For the required format, see the comment on the
                    /// Cluster.name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the requesting object.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

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
                    /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                    /// validation), but do not actually execute the create request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/clusters";

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
                /// Creates a cluster of type SECONDARY in the given location using the primary cluster as the source.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location of the new cluster. For the required format, see the comment on the
                /// Cluster.name field.
                /// </param>
                public virtual CreatesecondaryRequest Createsecondary(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster body, string parent)
                {
                    return new CreatesecondaryRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a cluster of type SECONDARY in the given location using the primary cluster as the source.
                /// </summary>
                public class CreatesecondaryRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Createsecondary request.</summary>
                    public CreatesecondaryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location of the new cluster. For the required format, see the comment on the
                    /// Cluster.name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the requesting object (the secondary cluster).</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

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
                    /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                    /// validation), but do not actually execute the create request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createsecondary";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/clusters:createsecondary";

                    /// <summary>Initializes Createsecondary parameter list.</summary>
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

                /// <summary>Deletes a single Cluster.</summary>
                /// <param name="name">
                /// Required. The name of the resource. For the required format, see the comment on the Cluster.name
                /// field.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Cluster.</summary>
                public class DeleteRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the resource. For the required format, see the comment on the Cluster.name
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The current etag of the Cluster. If an etag is provided and does not match the current
                    /// etag of the Cluster, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>Optional. Whether to cascade delete child instances for given cluster.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                    /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                    /// validation), but do not actually execute the delete.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                /// Generate a client certificate signed by a Cluster CA. The sole purpose of this endpoint is to
                /// support AlloyDB connectors and the Auth Proxy client. The endpoint's behavior is subject to change
                /// without notice, so do not rely on its behavior remaining constant. Future changes will not break
                /// AlloyDB connectors or the Auth Proxy client.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the parent resource. The required format is: *
                /// projects/{project}/locations/{location}/clusters/{cluster}
                /// </param>
                public virtual GenerateClientCertificateRequest GenerateClientCertificate(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.GenerateClientCertificateRequest body, string parent)
                {
                    return new GenerateClientCertificateRequest(service, body, parent);
                }

                /// <summary>
                /// Generate a client certificate signed by a Cluster CA. The sole purpose of this endpoint is to
                /// support AlloyDB connectors and the Auth Proxy client. The endpoint's behavior is subject to change
                /// without notice, so do not rely on its behavior remaining constant. Future changes will not break
                /// AlloyDB connectors or the Auth Proxy client.
                /// </summary>
                public class GenerateClientCertificateRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.GenerateClientCertificateResponse>
                {
                    /// <summary>Constructs a new GenerateClientCertificate request.</summary>
                    public GenerateClientCertificateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.GenerateClientCertificateRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent resource. The required format is: *
                    /// projects/{project}/locations/{location}/clusters/{cluster}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.GenerateClientCertificateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateClientCertificate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}:generateClientCertificate";

                    /// <summary>Initializes GenerateClientCertificate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Cluster.</summary>
                /// <param name="name">
                /// Required. The name of the resource. For the required format, see the comment on the Cluster.name
                /// field.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single Cluster.</summary>
                public class GetRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the resource. For the required format, see the comment on the Cluster.name
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The view of the cluster to return. Returns all default fields if not set.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Optional. The view of the cluster to return. Returns all default fields if not set.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>CLUSTER_VIEW_UNSPECIFIED Not specified, equivalent to BASIC.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// BASIC server responses include all the relevant cluster details, excluding
                        /// Cluster.ContinuousBackupInfo.EarliestRestorableTime and other view-specific fields. The
                        /// default value.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_BASIC")]
                        CLUSTERVIEWBASIC = 1,

                        /// <summary>
                        /// CONTINUOUS_BACKUP response returns all the fields from BASIC plus the earliest restorable
                        /// time if continuous backups are enabled. May increase latency.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_CONTINUOUS_BACKUP")]
                        CLUSTERVIEWCONTINUOUSBACKUP = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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

                /// <summary>Lists Clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The name of the parent resource. For the required format, see the comment on the
                /// Cluster.name field. Additionally, you can perform an aggregated list operation by specifying a value
                /// with the following format: * projects/{project}/locations/-
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Clusters in a given project and location.</summary>
                public class ListRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent resource. For the required format, see the comment on the
                    /// Cluster.name field. Additionally, you can perform an aggregated list operation by specifying a
                    /// value with the following format: * projects/{project}/locations/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/clusters";

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

                /// <summary>Updates the parameters of a single Cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The name of the cluster resource with the format: *
                /// projects/{project}/locations/{region}/clusters/{cluster_id} where the cluster ID segment should
                /// satisfy the regex expression `[a-z0-9-]+`. For more details see https://google.aip.dev/122. The
                /// prefix of the cluster resource name is the name of the parent resource: *
                /// projects/{project}/locations/{region}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the parameters of a single Cluster.</summary>
                public class PatchRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The name of the cluster resource with the format: *
                    /// projects/{project}/locations/{region}/clusters/{cluster_id} where the cluster ID segment should
                    /// satisfy the regex expression `[a-z0-9-]+`. For more details see https://google.aip.dev/122. The
                    /// prefix of the cluster resource name is the name of the parent resource: *
                    /// projects/{project}/locations/{region}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, update succeeds even if cluster is not found. In that case, a new
                    /// cluster is created and `update_mask` is ignored.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

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
                    /// Optional. Field mask is used to specify the fields to be overwritten in the Cluster resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If set, performs request validation (e.g. permission checks and any other type of
                    /// validation), but do not actually execute the update request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                /// Promotes a SECONDARY cluster. This turns down replication from the PRIMARY cluster and promotes a
                /// secondary cluster into its own standalone cluster. Imperative only.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the resource. For the required format, see the comment on the Cluster.name
                /// field
                /// </param>
                public virtual PromoteRequest Promote(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.PromoteClusterRequest body, string name)
                {
                    return new PromoteRequest(service, body, name);
                }

                /// <summary>
                /// Promotes a SECONDARY cluster. This turns down replication from the PRIMARY cluster and promotes a
                /// secondary cluster into its own standalone cluster. Imperative only.
                /// </summary>
                public class PromoteRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Promote request.</summary>
                    public PromoteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.PromoteClusterRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the resource. For the required format, see the comment on the Cluster.name
                    /// field
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.PromoteClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "promote";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:promote";

                    /// <summary>Initializes Promote parameter list.</summary>
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
                /// Creates a new Cluster in a given project and location, with a volume restored from the provided
                /// source, either a backup ID or a point-in-time and a source cluster.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the parent resource. For the required format, see the comment on the
                /// Cluster.name field.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.RestoreClusterRequest body, string parent)
                {
                    return new RestoreRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new Cluster in a given project and location, with a volume restored from the provided
                /// source, either a backup ID or a point-in-time and a source cluster.
                /// </summary>
                public class RestoreRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.RestoreClusterRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent resource. For the required format, see the comment on the
                    /// Cluster.name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.RestoreClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/clusters:restore";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:cancel";

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
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Empty>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.Operation>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1alpha/{+name}/operations";

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

            /// <summary>Gets the SupportedDatabaseFlags resource.</summary>
            public virtual SupportedDatabaseFlagsResource SupportedDatabaseFlags { get; }

            /// <summary>The "supportedDatabaseFlags" collection of methods.</summary>
            public class SupportedDatabaseFlagsResource
            {
                private const string Resource = "supportedDatabaseFlags";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SupportedDatabaseFlagsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists SupportedDatabaseFlags for a given project and location.</summary>
                /// <param name="parent">
                /// Required. The name of the parent resource. The required format is: *
                /// projects/{project}/locations/{location} Regardless of the parent specified here, as long it is
                /// contains a valid project and location, the service will return a static list of supported flags
                /// resources. Note that we do not yet support region-specific flags.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists SupportedDatabaseFlags for a given project and location.</summary>
                public class ListRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.ListSupportedDatabaseFlagsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent resource. The required format is: *
                    /// projects/{project}/locations/{location} Regardless of the parent specified here, as long it is
                    /// contains a valid project and location, the service will return a static list of supported flags
                    /// resources. Note that we do not yet support region-specific flags.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/supportedDatabaseFlags";

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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.GoogleCloudLocationLocation>
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
                public override string RestPath => "v1alpha/{+name}";

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
            public class ListRequest : CloudAlloyDBAdminBaseServiceRequest<Google.Apis.CloudAlloyDBAdmin.v1alpha.Data.GoogleCloudLocationListLocationsResponse>
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
                public override string RestPath => "v1alpha/{+name}/locations";

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
namespace Google.Apis.CloudAlloyDBAdmin.v1alpha.Data
{
    /// <summary>
    /// Message describing the user-specified automated backup policy. All fields in the automated backup policy are
    /// optional. Defaults for each field are provided if they are not set.
    /// </summary>
    public class AutomatedBackupPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The length of the time window during which a backup can be taken. If a backup does not succeed within this
        /// time window, it will be canceled and considered failed. The backup window must be at least 5 minutes long.
        /// There is no upper bound on the window. If not set, it defaults to 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupWindow")]
        public virtual object BackupWindow { get; set; }

        /// <summary>Whether automated automated backups are enabled. If not set, defaults to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. The encryption config can be specified to encrypt the backups with a customer-managed encryption
        /// key (CMEK). When this field is not specified, the backup will then use default encryption scheme to protect
        /// the user data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>Labels to apply to backups created using this configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The location where the backup will be stored. Currently, the only supported option is to store the backup in
        /// the same region as the cluster. If empty, defaults to the region of the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Quantity-based Backup retention policy to retain recent backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityBasedRetention")]
        public virtual QuantityBasedRetention QuantityBasedRetention { get; set; }

        /// <summary>Time-based Backup retention policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeBasedRetention")]
        public virtual TimeBasedRetention TimeBasedRetention { get; set; }

        /// <summary>Weekly schedule for the Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklySchedule")]
        public virtual WeeklySchedule WeeklySchedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing Backup object</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
        /// https://google.aip.dev/128
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Required. The full resource name of the backup source cluster (e.g.,
        /// projects/{project}/locations/{region}/clusters/{cluster_id}).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>
        /// Output only. The system-generated UID of the cluster which was used to create this resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUid")]
        public virtual string ClusterUid { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Output only. The database engine major version of the cluster this backup was created from. Any restored
        /// cluster created from this backup will have the same database version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Delete time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>User-provided description of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User-settable and human-readable display name for the Backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The encryption config can be specified to encrypt the backup with a customer-managed encryption
        /// key (CMEK). When this field is not specified, the backup will then use default encryption scheme to protect
        /// the user data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>Output only. The encryption information for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>For Resource freshness validation (https://google.aip.dev/154)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. The QuantityBasedExpiry of the backup, specified by the backup's retention policy. Once the
        /// expiry quantity is over retention, the backup is eligible to be garbage collected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryQuantity")]
        public virtual QuantityBasedExpiry ExpiryQuantity { get; set; }

        private string _expiryTimeRaw;

        private object _expiryTime;

        /// <summary>
        /// Output only. The time at which after the backup is eligible to be garbage collected. It is the duration
        /// specified by the backup's retention policy, added to the backup's create_time.
        /// </summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ExpiryTimeRaw);
            set => ExpiryTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The name of the backup resource with the format: *
        /// projects/{project}/locations/{region}/backups/{backup_id} where the cluster and backup ID segments should
        /// satisfy the regex expression `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`, e.g. 1-63 characters of lowercase letters,
        /// numbers, and dashes, starting with a letter, and ending with a letter or number. For more details see
        /// https://google.aip.dev/122. The prefix of the backup resource name is the name of the parent resource: *
        /// projects/{project}/locations/{region}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Reconciling (https://google.aip.dev/128#reconciliation), if true, indicates that the service is
        /// actively updating the resource. This can happen due to user-triggered updates or system actions like
        /// failover or maintenance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The size of the backup in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The backup type, which suggests the trigger for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Output only. The system-generated UID of the resource. The UID is assigned when the resource is created, and
        /// it is retained until it is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Update time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }
    }

    /// <summary>Message describing a BackupSource.</summary>
    public class BackupSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the backup resource with the format: *
        /// projects/{project}/locations/{region}/backups/{backup_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupName")]
        public virtual string BackupName { get; set; }

        /// <summary>
        /// Output only. The system-generated UID of the backup which was used to create this resource. The UID is
        /// generated when the backup is created, and it is retained until the backup is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupUid")]
        public virtual string BackupUid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Client connection configuration</summary>
    public class ClientConnectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configuration to enforce connectors only (ex: AuthProxy) connections to the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireConnectors")]
        public virtual System.Nullable<bool> RequireConnectors { get; set; }

        /// <summary>Optional. SSL config option for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslConfig")]
        public virtual SslConfig SslConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata returned by the CLH during resource state reconciliation.</summary>
    public class CloudControl2SharedOperationsReconciliationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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
    /// A cluster is a collection of regional AlloyDB resources. It can include a primary instance and one or more read
    /// pool instances. All cluster resources share a storage layer, which scales as needed.
    /// </summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
        /// https://google.aip.dev/128
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// The automated backup policy for this cluster. If no policy is provided then the default policy will be used.
        /// If backups are supported for the cluster, the default policy takes one backup a day, has a backup window of
        /// 1 hour, and retains backups for 14 days. For more information on the defaults, consult the documentation for
        /// the message type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedBackupPolicy")]
        public virtual AutomatedBackupPolicy AutomatedBackupPolicy { get; set; }

        /// <summary>Output only. Cluster created from backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSource")]
        public virtual BackupSource BackupSource { get; set; }

        /// <summary>
        /// Output only. The type of the cluster. This is an output-only field and it's populated at the Cluster
        /// creation time or the Cluster promotion time. The cluster type is determined by which RPC was used to create
        /// the cluster (i.e. `CreateCluster` vs. `CreateSecondaryCluster`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterType")]
        public virtual string ClusterType { get; set; }

        /// <summary>Optional. Continuous backup configuration for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousBackupConfig")]
        public virtual ContinuousBackupConfig ContinuousBackupConfig { get; set; }

        /// <summary>Output only. Continuous backup properties for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousBackupInfo")]
        public virtual ContinuousBackupInfo ContinuousBackupInfo { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Optional. The database engine major version. This is an optional field and it is populated at the Cluster
        /// creation time. If a database version is not supplied at cluster creation time, then a default database
        /// version will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Delete time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>User-settable and human-readable display name for the Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The encryption config can be specified to encrypt the data disks and other persistent data
        /// resources of a cluster with a customer-managed encryption key (CMEK). When this field is not specified, the
        /// cluster will then use default encryption scheme to protect the user data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>Output only. The encryption information for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>For Resource freshness validation (https://google.aip.dev/154)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Input only. Initial user to setup during cluster creation. Required. If used in `RestoreCluster` this is
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialUser")]
        public virtual UserPassword InitialUser { get; set; }

        /// <summary>Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Cluster created via DMS migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationSource")]
        public virtual MigrationSource MigrationSource { get; set; }

        /// <summary>
        /// Output only. The name of the cluster resource with the format: *
        /// projects/{project}/locations/{region}/clusters/{cluster_id} where the cluster ID segment should satisfy the
        /// regex expression `[a-z0-9-]+`. For more details see https://google.aip.dev/122. The prefix of the cluster
        /// resource name is the name of the parent resource: * projects/{project}/locations/{region}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The resource link for the VPC network in which cluster resources are created and from which they
        /// are accessible via Private IP. The network must belong to the same project as the cluster. It is specified
        /// in the form: "projects/{project}/global/networks/{network_id}". This is required to create a cluster.
        /// Deprecated, use network_config.network instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual NetworkConfig NetworkConfig { get; set; }

        /// <summary>Output only. Cross Region replication config specific to PRIMARY cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryConfig")]
        public virtual PrimaryConfig PrimaryConfig { get; set; }

        /// <summary>
        /// Output only. Reconciling (https://google.aip.dev/128#reconciliation). Set to true if the current state of
        /// Cluster does not match the user's intended state, and the service is actively updating the resource to
        /// reconcile them. This can happen due to user-triggered updates or system actions like failover or
        /// maintenance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Cross Region replication config specific to SECONDARY cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryConfig")]
        public virtual SecondaryConfig SecondaryConfig { get; set; }

        /// <summary>SSL configuration for this AlloyDB cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslConfig")]
        public virtual SslConfig SslConfig { get; set; }

        /// <summary>Output only. The current serving state of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The system-generated UID of the resource. The UID is assigned when the resource is created, and
        /// it is retained until it is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Update time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }
    }

    /// <summary>ConnectionInfo singleton resource. https://google.aip.dev/156</summary>
    public class ConnectionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceUid")]
        public virtual string InstanceUid { get; set; }

        /// <summary>
        /// Output only. The private network IP address for the Instance. This is the default IP for the instance and is
        /// always created (even if enable_public_ip is set). This is the connection endpoint for an end-user
        /// application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// The name of the ConnectionInfo singleton resource, e.g.:
        /// projects/{project}/locations/{location}/clusters/*/instances/*/connectionInfo This field currently has no
        /// semantic meaning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The pem-encoded chain that may be used to verify the X.509 certificate. Expected to be in
        /// issuer-to-root order according to RFC 5246.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificateChain")]
        public virtual System.Collections.Generic.IList<string> PemCertificateChain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ContinuousBackupConfig describes the continuous backups recovery configurations of a cluster.</summary>
    public class ContinuousBackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether ContinuousBackup is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// The encryption config can be specified to encrypt the backups with a customer-managed encryption key (CMEK).
        /// When this field is not specified, the backup will then use default encryption scheme to protect the user
        /// data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// The number of days that are eligible to restore from using PITR. To support the entire recovery window,
        /// backups and logs are retained for one day more than the recovery window. If not set, defaults to 14 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryWindowDays")]
        public virtual System.Nullable<int> RecoveryWindowDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ContinuousBackupInfo describes the continuous backup properties of a cluster.</summary>
    public class ContinuousBackupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _earliestRestorableTimeRaw;

        private object _earliestRestorableTime;

        /// <summary>Output only. The earliest restorable time that can be restored to. Output only field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestRestorableTime")]
        public virtual string EarliestRestorableTimeRaw
        {
            get => _earliestRestorableTimeRaw;
            set
            {
                _earliestRestorableTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _earliestRestorableTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EarliestRestorableTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EarliestRestorableTimeDateTimeOffset instead.")]
        public virtual object EarliestRestorableTime
        {
            get => _earliestRestorableTime;
            set
            {
                _earliestRestorableTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _earliestRestorableTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EarliestRestorableTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EarliestRestorableTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EarliestRestorableTimeRaw);
            set => EarliestRestorableTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _enabledTimeRaw;

        private object _enabledTime;

        /// <summary>
        /// Output only. When ContinuousBackup was most recently enabled. Set to null if ContinuousBackup is not
        /// enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledTime")]
        public virtual string EnabledTimeRaw
        {
            get => _enabledTimeRaw;
            set
            {
                _enabledTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _enabledTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EnabledTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EnabledTimeDateTimeOffset instead.")]
        public virtual object EnabledTime
        {
            get => _enabledTime;
            set
            {
                _enabledTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _enabledTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EnabledTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EnabledTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EnabledTimeRaw);
            set => EnabledTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Output only. The encryption information for the WALs and backups required for ContinuousBackup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Output only. Days of the week on which a continuous backup is taken. Output only field. Ignored if passed
        /// into the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual System.Collections.Generic.IList<string> Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing a ContinuousBackupSource.</summary>
    public class ContinuousBackupSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The source cluster from which to restore. This cluster must have continuous backup enabled for
        /// this operation to succeed. For the required format, see the comment on the Cluster.name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        private string _pointInTimeRaw;

        private object _pointInTime;

        /// <summary>Required. The point in time to restore to.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(PointInTimeRaw);
            set => PointInTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

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

    /// <summary>
    /// EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK
    /// (customer-managed encryption key).
    /// </summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following
        /// format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

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
        /// Output only. Cloud KMS key versions that are being used to protect the database or the backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersions")]
        public virtual System.Collections.Generic.IList<string> KmsKeyVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for triggering failover on an Instance</summary>
    public class FailoverInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>
        /// Optional. If set, performs request validation (e.g. permission checks and any other type of validation), but
        /// do not actually execute the failover.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for requests to generate a client certificate signed by the Cluster CA.</summary>
    public class GenerateClientCertificateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional hint to the endpoint to generate the client certificate with the requested duration.
        /// The duration can be from 1 hour to 24 hours. The endpoint may or may not honor the hint. If the hint is left
        /// unspecified or is not honored, then the endpoint will pick an appropriate default duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certDuration")]
        public virtual object CertDuration { get; set; }

        /// <summary>
        /// Optional. A pem-encoded X.509 certificate signing request (CSR). It is recommended to use public_key
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCsr")]
        public virtual string PemCsr { get; set; }

        /// <summary>Optional. The public key from the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

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
        /// Optional. An optional hint to the endpoint to generate a client ceritificate that can be used by AlloyDB
        /// connectors to exchange additional metadata with the server after TLS handshake.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useMetadataExchange")]
        public virtual System.Nullable<bool> UseMetadataExchange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message returned by a GenerateClientCertificate operation.</summary>
    public class GenerateClientCertificateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The pem-encoded cluster ca X.509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCert")]
        public virtual string CaCert { get; set; }

        /// <summary>Output only. The pem-encoded, signed X.509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificate")]
        public virtual string PemCertificate { get; set; }

        /// <summary>
        /// Output only. The pem-encoded chain that may be used to verify the X.509 certificate. Expected to be in
        /// issuer-to-root order according to RFC 5246.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificateChain")]
        public virtual System.Collections.Generic.IList<string> PemCertificateChain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class GoogleCloudLocationListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudLocationLocation> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a Google Cloud location.</summary>
    public class GoogleCloudLocationLocation : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class GoogleTypeTimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for triggering fault injection on an instance</summary>
    public class InjectFaultRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of fault to be injected in an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faultType")]
        public virtual string FaultType { get; set; }

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
        /// Optional. If set, performs request validation (e.g. permission checks and any other type of validation), but
        /// do not actually execute the fault injection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Instance is a computing unit that an end customer can connect to. It's the main unit of computing resources
    /// in AlloyDB.
    /// </summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
        /// https://google.aip.dev/128
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Availability type of an Instance. If empty, defaults to REGIONAL for primary instances. For read pools,
        /// availability_type is always UNSPECIFIED. Instances in the read pools are evenly distributed across available
        /// zones within the region (i.e. read pools with more than one node will have a node in at least two zones).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityType")]
        public virtual string AvailabilityType { get; set; }

        /// <summary>Optional. Client connection specific configurations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientConnectionConfig")]
        public virtual ClientConnectionConfig ClientConnectionConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Database flags. Set at instance level. * They are copied from primary instance on read instance creation. *
        /// Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling
        /// columnar cache on a read instance. Flags set on read instance may or may not be present on primary. This is
        /// a list of "key": "value" pairs. "key": The name of the flag. These flags are passed at instance setup time,
        /// so include both server options and system variables for Postgres. Flags are specified with underscores, not
        /// hyphens. "value": The value of the flag. Booleans are set to **on** for true and **off** for false. This
        /// field must be omitted if the flag doesn't take a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseFlags")]
        public virtual System.Collections.Generic.IDictionary<string, string> DatabaseFlags { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Delete time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>User-settable and human-readable display name for the Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>For Resource freshness validation (https://google.aip.dev/154)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The Compute Engine zone that the instance should serve from, per
        /// https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If
        /// present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance
        /// is created in a random zone with available capacity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceZone")]
        public virtual string GceZone { get; set; }

        /// <summary>Required. The type of the instance. Specified at creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>
        /// Output only. The IP address for the Instance. This is the connection endpoint for an end-user application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Configurations for the machines that host the underlying database engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineConfig")]
        public virtual MachineConfig MachineConfig { get; set; }

        /// <summary>
        /// Output only. The name of the instance resource with the format: *
        /// projects/{project}/locations/{region}/clusters/{cluster_id}/instances/{instance_id} where the cluster and
        /// instance ID segments should satisfy the regex expression `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`, e.g. 1-63
        /// characters of lowercase letters, numbers, and dashes, starting with a letter, and ending with a letter or
        /// number. For more details see https://google.aip.dev/122. The prefix of the instance resource name is the
        /// name of the parent resource: * projects/{project}/locations/{region}/clusters/{cluster_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. List of available read-only VMs in this instance, including the standby for a PRIMARY instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>Configuration for query insights.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInsightsConfig")]
        public virtual QueryInsightsInstanceConfig QueryInsightsConfig { get; set; }

        /// <summary>
        /// Read pool instance configuration. This is required if the value of instanceType is READ_POOL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readPoolConfig")]
        public virtual ReadPoolConfig ReadPoolConfig { get; set; }

        /// <summary>
        /// Output only. Reconciling (https://google.aip.dev/128#reconciliation). Set to true if the current state of
        /// Instance does not match the user's intended state, and the service is actively updating the resource to
        /// reconcile them. This can happen due to user-triggered updates or system actions like failover or
        /// maintenance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The current serving state of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The system-generated UID of the resource. The UID is assigned when the resource is created, and
        /// it is retained until it is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        /// Update policy that will be applied during instance update. This field is not persisted when you update the
        /// instance. To use a non-default update policy, you must specify explicitly specify the value in each update
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePolicy")]
        public virtual UpdatePolicy UpdatePolicy { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Update time stamp</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Output only. This is set for the read-write VM of the PRIMARY instance only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writableNode")]
        public virtual Node WritableNode { get; set; }
    }

    /// <summary>Restrictions on INTEGER type values.</summary>
    public class IntegerRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum value that can be specified, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<long> MaxValue { get; set; }

        /// <summary>The minimum value that can be specified, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<long> MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing Backups</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Backup</summary>
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

    /// <summary>Message for response to listing Clusters</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing Instances</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

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

    /// <summary>Message for response to listing SupportedDatabaseFlags.</summary>
    public class ListSupportedDatabaseFlagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of SupportedDatabaseFlags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedDatabaseFlags")]
        public virtual System.Collections.Generic.IList<SupportedDatabaseFlag> SupportedDatabaseFlags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing Users</summary>
    public class ListUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The list of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<User> Users { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MachineConfig describes the configuration of a machine.</summary>
    public class MachineConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of CPU's in the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCount")]
        public virtual System.Nullable<int> CpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Subset of the source instance configuration that is available when reading the cluster resource.
    /// </summary>
    public class MigrationSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The host and port of the on-premises instance in host:port format</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostPort")]
        public virtual string HostPort { get; set; }

        /// <summary>
        /// Output only. Place holder for the external source identifier(e.g DMS job name) that created the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceId")]
        public virtual string ReferenceId { get; set; }

        /// <summary>Output only. Type of migration source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to network configuration.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Name of the allocated IP range for the private IP AlloyDB cluster, for example:
        /// "google-managed-services-default". If set, the instance IPs for this cluster will be created in the
        /// allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters
        /// long and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?`. Field name is intended to be consistent
        /// with Cloud SQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedIpRange")]
        public virtual string AllocatedIpRange { get; set; }

        /// <summary>
        /// Required. The resource link for the VPC network in which cluster resources are created and from which they
        /// are accessible via Private IP. The network must belong to the same project as the cluster. It is specified
        /// in the form: "projects/{project_number}/global/networks/{network_id}". This is required to create a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of a single node in the instance. Nodes in an AlloyDB instance are ephemereal, they can change during
    /// update, failover, autohealing and resize operations.
    /// </summary>
    public class Node : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the VM e.g. "test-read-0601-407e52be-ms3l".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The private IP address of the VM e.g. "10.57.0.34".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>
        /// Determined by state of the compute VM and postgres-service health. Compute VM state can have values listed
        /// in https://cloud.google.com/compute/docs/instances/instance-life-cycle and postgres-service health can have
        /// values: HEALTHY and UNHEALTHY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The Compute Engine zone of the VM e.g. "us-central1-b".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoneId")]
        public virtual string ZoneId { get; set; }

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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
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

    /// <summary>
    /// Configuration for the primary cluster. It has the list of clusters that are replicating from this cluster. This
    /// should be set if and only if the cluster is of type PRIMARY.
    /// </summary>
    public class PrimaryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Names of the clusters that are replicating from this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryClusterNames")]
        public virtual System.Collections.Generic.IList<string> SecondaryClusterNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for promoting a Cluster</summary>
    public class PromoteClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The current etag of the Cluster. If an etag is provided and does not match the current etag of the
        /// Cluster, deletion will be blocked and an ABORTED error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

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
        /// Optional. If set, performs request validation (e.g. permission checks and any other type of validation), but
        /// do not actually execute the delete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    /// <summary>
    /// A backup's position in a quantity-based retention queue, of backups with the same source cluster and type, with
    /// length, retention, specified by the backup's retention policy. Once the position is greater than the retention,
    /// the backup is eligible to be garbage collected. Example: 5 backups from the same source cluster and type with a
    /// quantity-based retention of 3 and denoted by backup_id (position, retention). Safe: backup_5 (1, 3), backup_4,
    /// (2, 3), backup_3 (3, 3). Awaiting garbage collection: backup_2 (4, 3), backup_1 (5, 3)
    /// </summary>
    public class QuantityBasedExpiry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The backup's position among its backups with the same source cluster and type, by descending
        /// chronological order create time(i.e. newest first).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionCount")]
        public virtual System.Nullable<int> RetentionCount { get; set; }

        /// <summary>
        /// Output only. The length of the quantity-based queue, specified by the backup's retention policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRetentionCount")]
        public virtual System.Nullable<int> TotalRetentionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A quantity based policy specifies that a certain number of the most recent successful backups should be
    /// retained.
    /// </summary>
    public class QuantityBasedRetention : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of backups to retain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryInsights Instance specific configuration.</summary>
    public class QueryInsightsInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of query execution plans captured by Insights per minute for all queries combined. The default value
        /// is 5. Any integer between 0 and 20 is considered valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryPlansPerMinute")]
        public virtual System.Nullable<long> QueryPlansPerMinute { get; set; }

        /// <summary>
        /// Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryStringLength")]
        public virtual System.Nullable<long> QueryStringLength { get; set; }

        /// <summary>Record application tags for an instance. This flag is turned "on" by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordApplicationTags")]
        public virtual System.Nullable<bool> RecordApplicationTags { get; set; }

        /// <summary>
        /// Record client address for an instance. Client address is PII information. This flag is turned "on" by
        /// default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordClientAddress")]
        public virtual System.Nullable<bool> RecordClientAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a read pool instance.</summary>
    public class ReadPoolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Read capacity, i.e. number of nodes in a read pool instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RestartInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>
        /// Optional. If set, performs request validation (e.g. permission checks and any other type of validation), but
        /// do not actually execute the restart.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for restoring a Cluster from a backup or another cluster at a given point in time.</summary>
    public class RestoreClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Backup source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSource")]
        public virtual BackupSource BackupSource { get; set; }

        /// <summary>Required. The resource being created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual Cluster Cluster { get; set; }

        /// <summary>Required. ID of the requesting object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// ContinuousBackup source. Continuous backup needs to be enabled in the source cluster for this operation to
        /// succeed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousBackupSource")]
        public virtual ContinuousBackupSource ContinuousBackupSource { get; set; }

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

        /// <summary>
        /// Optional. If set, performs request validation (e.g. permission checks and any other type of validation), but
        /// do not actually execute the import request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration information for the secondary cluster. This should be set if and only if the cluster is of type
    /// SECONDARY.
    /// </summary>
    public class SecondaryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the primary cluster name with the format: *
        /// projects/{project}/locations/{region}/clusters/{cluster_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryClusterName")]
        public virtual string PrimaryClusterName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SSL configuration.</summary>
    public class SslConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Certificate Authority (CA) source. Only CA_SOURCE_MANAGED is supported currently, and is the
        /// default value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caSource")]
        public virtual string CaSource { get; set; }

        /// <summary>Optional. SSL mode. Specifies client-server SSL/TLS connection behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslMode")]
        public virtual string SslMode { get; set; }

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

    /// <summary>Configuration for availability of database instance</summary>
    public class StorageDatabasecenterPartnerapiV1mainAvailabilityConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Availability type. Potential values: * `ZONAL`: The instance serves data from only one zone. Outages in that
        /// zone affect data accessibility. * `REGIONAL`: The instance can serve data from more than one zone in a
        /// region (it is highly available).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityType")]
        public virtual string AvailabilityType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalReplicaConfigured")]
        public virtual System.Nullable<bool> ExternalReplicaConfigured { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("promotableReplicaConfigured")]
        public virtual System.Nullable<bool> PromotableReplicaConfigured { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for automatic backups</summary>
    public class StorageDatabasecenterPartnerapiV1mainBackupConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether customer visible automated backups are enabled on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedBackupEnabled")]
        public virtual System.Nullable<bool> AutomatedBackupEnabled { get; set; }

        /// <summary>Backup retention settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionSettings")]
        public virtual StorageDatabasecenterPartnerapiV1mainRetentionSettings BackupRetentionSettings { get; set; }

        /// <summary>
        /// Whether point-in-time recovery is enabled. This is optional field, if the database service does not have
        /// this feature or metadata is not available in control plane, this can be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointInTimeRecoveryEnabled")]
        public virtual System.Nullable<bool> PointInTimeRecoveryEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A backup run.</summary>
    public class StorageDatabasecenterPartnerapiV1mainBackupRun : Google.Apis.Requests.IDirectResponseSchema
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Information about why the backup operation failed. This is only present if the run has the FAILED status.
        /// OPTIONAL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual StorageDatabasecenterPartnerapiV1mainOperationError Error { get; set; }

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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The status of this run. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains compliance information about a security standard indicating unmet recommendations.</summary>
    public class StorageDatabasecenterPartnerapiV1mainCompliance : Google.Apis.Requests.IDirectResponseSchema
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
    /// DatabaseResourceFeed is the top level proto to be used to ingest different database resource level events into
    /// Condor platform.
    /// </summary>
    public class StorageDatabasecenterPartnerapiV1mainDatabaseResourceFeed : Google.Apis.Requests.IDirectResponseSchema
    {
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(FeedTimestampRaw);
            set => FeedTimestampRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Required. Type feed to be ingested into condor</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedType")]
        public virtual string FeedType { get; set; }

        /// <summary>More feed data would be added in subsequent CLs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceHealthSignalData")]
        public virtual StorageDatabasecenterPartnerapiV1mainDatabaseResourceHealthSignalData ResourceHealthSignalData { get; set; }

        /// <summary>
        /// Primary key associated with the Resource. resource_id is available in individual feed level as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual StorageDatabasecenterPartnerapiV1mainDatabaseResourceId ResourceId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceMetadata")]
        public virtual StorageDatabasecenterPartnerapiV1mainDatabaseResourceMetadata ResourceMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common model for database resource health signal data.</summary>
    public class StorageDatabasecenterPartnerapiV1mainDatabaseResourceHealthSignalData : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual System.Collections.Generic.IList<StorageDatabasecenterPartnerapiV1mainCompliance> Compliance { get; set; }

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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// The external-uri of the signal, using which more information about this signal can be obtained. In GCP, this
        /// will take user to SCC page to get more details about signals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>Required. The name of the signal, ex: PUBLIC_SQL_INSTANCE, SQL_LOG_ERROR_VERBOSITY etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Cloud provider name. Ex: GCP/AWS/Azure/OnPrem/SelfManaged</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>
        /// Closest parent container of this resource. In GCP, 'container' refers to a Cloud Resource Manager project.
        /// It must be resource name of a Cloud Resource Manager project with the format of "provider//", such as
        /// "gcp/projects/123". For GCP provided resources, number should be project number.
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
    public class StorageDatabasecenterPartnerapiV1mainDatabaseResourceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Cloud provider name. Ex: GCP/AWS/Azure/OnPrem/SelfManaged</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Optional. Needs to be used only when the provider is PROVIDER_OTHER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerDescription")]
        public virtual string ProviderDescription { get; set; }

        /// <summary>
        /// Required. The type of resource this ID is identifying. Ex alloydb.googleapis.com/Cluster,
        /// alloydb.googleapis.com/Instance, spanner.googleapis.com/Instance REQUIRED Please refer
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

    /// <summary>Common model for database resource instance metadata.</summary>
    public class StorageDatabasecenterPartnerapiV1mainDatabaseResourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Availability configuration for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityConfiguration")]
        public virtual StorageDatabasecenterPartnerapiV1mainAvailabilityConfiguration AvailabilityConfiguration { get; set; }

        /// <summary>Backup configuration for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfiguration")]
        public virtual StorageDatabasecenterPartnerapiV1mainBackupConfiguration BackupConfiguration { get; set; }

        /// <summary>Latest backup run information for this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRun")]
        public virtual StorageDatabasecenterPartnerapiV1mainBackupRun BackupRun { get; set; }

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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Current state of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentState")]
        public virtual string CurrentState { get; set; }

        /// <summary>Any custom metadata associated with the resource (a JSON field)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomMetadata { get; set; }

        /// <summary>
        /// The state that the instance is expected to be in. For example, an instance state can transition to UNHEALTHY
        /// due to wrong patch update, while the expected state will remain at the HEALTHY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedState")]
        public virtual string ExpectedState { get; set; }

        /// <summary>Required. Unique identifier for a Database resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual StorageDatabasecenterPartnerapiV1mainDatabaseResourceId Id { get; set; }

        /// <summary>The type of the instance. Specified at creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>The resource location. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Identifier for this resource's immediate parent/primary resource if the current resource is a replica or
        /// derived form of another Database resource. Else it would be NULL. REQUIRED if the immediate parent exists
        /// when first time resource is getting ingested
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryResourceId")]
        public virtual StorageDatabasecenterPartnerapiV1mainDatabaseResourceId PrimaryResourceId { get; set; }

        /// <summary>The product this resource represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual StorageDatabasecenterProtoCommonProduct Product { get; set; }

        /// <summary>
        /// Closest parent Cloud Resource Manager container of this resource. It must be resource name of a Cloud
        /// Resource Manager project with the format of "provider//", such as "gcp/projects/123". For GCP provided
        /// resources, number should be project number.
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdationTimeRaw);
            set => UpdationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// User-provided labels, represented as a dictionary where each label is a single key value pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error that occurred during a backup creation operation.</summary>
    public class StorageDatabasecenterPartnerapiV1mainOperationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the specific error that occurred. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Additional information about the error encountered. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class StorageDatabasecenterPartnerapiV1mainRetentionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("quantityBasedRetention")]
        public virtual System.Nullable<int> QuantityBasedRetention { get; set; }

        /// <summary>The unit that 'retained_backups' represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionUnit")]
        public virtual string RetentionUnit { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timeBasedRetention")]
        public virtual object TimeBasedRetention { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product specification for Condor resources.</summary>
    public class StorageDatabasecenterProtoCommonProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specific engine that the underlying database is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

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

    /// <summary>Restrictions on STRING type values</summary>
    public class StringRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of allowed values, if bounded. This field will be empty if there is a unbounded number of allowed
        /// values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SupportedDatabaseFlag gives general information about a database flag, like type and allowed values. This is a
    /// static value that is defined on the server side, and it cannot be modified by callers. To set the Database flags
    /// on a particular Instance, a caller should modify the Instance.database_flags field.
    /// </summary>
    public class SupportedDatabaseFlag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the database flag accepts multiple values. If true, a comma-separated list of stringified values may
        /// be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptsMultipleValues")]
        public virtual System.Nullable<bool> AcceptsMultipleValues { get; set; }

        /// <summary>
        /// The name of the database flag, e.g. "max_allowed_packets". The is a possibly key for the
        /// Instance.database_flags map field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flagName")]
        public virtual string FlagName { get; set; }

        /// <summary>Restriction on INTEGER type value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerRestrictions")]
        public virtual IntegerRestrictions IntegerRestrictions { get; set; }

        /// <summary>
        /// The name of the flag resource, following Google Cloud conventions, e.g.: *
        /// projects/{project}/locations/{location}/flags/{flag} This field currently has no semantic meaning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Whether setting or updating this flag on an Instance requires a database restart. If a flag that requires
        /// database restart is set, the backend will automatically restart the database (making sure to satisfy any
        /// availability SLO's).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiresDbRestart")]
        public virtual System.Nullable<bool> RequiresDbRestart { get; set; }

        /// <summary>Restriction on STRING type value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringRestrictions")]
        public virtual StringRestrictions StringRestrictions { get; set; }

        /// <summary>Major database engine versions for which this flag is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedDbVersions")]
        public virtual System.Collections.Generic.IList<string> SupportedDbVersions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A time based retention policy specifies that all backups within a certain time period should be retained.
    /// </summary>
    public class TimeBasedRetention : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The retention period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionPeriod")]
        public virtual object RetentionPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policy to be used while updating the instance.</summary>
    public class UpdatePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mode for updating the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing User object.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of database roles this user has. The database role strings are subject to the PostgreSQL
        /// naming conventions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseRoles")]
        public virtual System.Collections.Generic.IList<string> DatabaseRoles { get; set; }

        /// <summary>
        /// Output only. Name of the resource in the form of
        /// projects/{project}/locations/{location}/cluster/{cluster}/users/{user}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Input only. Password for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Optional. Type of this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userType")]
        public virtual string UserType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The username/password for a database user. Used for specifying initial users at cluster creation time.
    /// </summary>
    public class UserPassword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The initial password for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The database username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A weekly schedule starts a backup at prescribed start times within a day, for the specified days of the week.
    /// The weekly schedule message is flexible and can be used to create many types of schedules. For example, to have
    /// a daily backup that starts at 22:00, configure the `start_times` field to have one element "22:00" and the
    /// `days_of_week` field to have all seven days of the week.
    /// </summary>
    public class WeeklySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The days of the week to perform a backup. If this field is left empty, the default of every day of the week
        /// is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfWeek")]
        public virtual System.Collections.Generic.IList<string> DaysOfWeek { get; set; }

        /// <summary>
        /// The times during the day to start a backup. The start times are assumed to be in UTC and to be an exact hour
        /// (e.g., 04:00:00). If no start times are provided, a single fixed start time is chosen arbitrarily.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimes")]
        public virtual System.Collections.Generic.IList<GoogleTypeTimeOfDay> StartTimes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
