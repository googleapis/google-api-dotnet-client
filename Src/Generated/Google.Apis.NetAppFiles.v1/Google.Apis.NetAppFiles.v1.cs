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

namespace Google.Apis.NetAppFiles.v1
{
    /// <summary>The NetAppFiles Service.</summary>
    public class NetAppFilesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public NetAppFilesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public NetAppFilesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://netapp.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://netapp.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "netapp";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the NetApp API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the NetApp API.</summary>
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

    /// <summary>A base abstract class for NetAppFiles requests.</summary>
    public abstract class NetAppFilesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new NetAppFilesBaseServiceRequest instance.</summary>
        protected NetAppFilesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes NetAppFiles parameter list.</summary>
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
                ActiveDirectories = new ActiveDirectoriesResource(service);
                BackupPolicies = new BackupPoliciesResource(service);
                BackupVaults = new BackupVaultsResource(service);
                KmsConfigs = new KmsConfigsResource(service);
                Operations = new OperationsResource(service);
                StoragePools = new StoragePoolsResource(service);
                Volumes = new VolumesResource(service);
            }

            /// <summary>Gets the ActiveDirectories resource.</summary>
            public virtual ActiveDirectoriesResource ActiveDirectories { get; }

            /// <summary>The "activeDirectories" collection of methods.</summary>
            public class ActiveDirectoriesResource
            {
                private const string Resource = "activeDirectories";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ActiveDirectoriesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>CreateActiveDirectory Creates the active directory specified in the request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.ActiveDirectory body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>CreateActiveDirectory Creates the active directory specified in the request.</summary>
                public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.ActiveDirectory body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. ID of the active directory to create. Must be unique within the parent resource. Must
                    /// contain only letters, numbers and hyphen, with the first character a letter , the last a letter
                    /// or a number, and a 63 character maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("activeDirectoryId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ActiveDirectoryId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.ActiveDirectory Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/activeDirectories";

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
                        RequestParameters.Add("activeDirectoryId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "activeDirectoryId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete the active directory specified in the request.</summary>
                /// <param name="name">Required. Name of the active directory.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete the active directory specified in the request.</summary>
                public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the active directory.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/activeDirectories/[^/]+$",
                        });
                    }
                }

                /// <summary>Describes a specified active directory.</summary>
                /// <param name="name">Required. Name of the active directory.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Describes a specified active directory.</summary>
                public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ActiveDirectory>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the active directory.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/activeDirectories/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists active directories.</summary>
                /// <param name="parent">Required. Parent value for ListActiveDirectoriesRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists active directories.</summary>
                public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListActiveDirectoriesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListActiveDirectoriesRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, the server
                    /// will pick an appropriate default.
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
                    public override string RestPath => "v1/{+parent}/activeDirectories";

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

                /// <summary>Update the parameters of an active directories.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the active directory. Format:
                /// `projects/{project_number}/locations/{location_id}/activeDirectories/{active_directory_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.ActiveDirectory body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update the parameters of an active directories.</summary>
                public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.ActiveDirectory body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the active directory. Format:
                    /// `projects/{project_number}/locations/{location_id}/activeDirectories/{active_directory_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the Active Directory
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.ActiveDirectory Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/activeDirectories/[^/]+$",
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

            /// <summary>Gets the BackupPolicies resource.</summary>
            public virtual BackupPoliciesResource BackupPolicies { get; }

            /// <summary>The "backupPolicies" collection of methods.</summary>
            public class BackupPoliciesResource
            {
                private const string Resource = "backupPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BackupPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates new backup policy</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location to create the backup policies of, in the format
                /// `projects/{project_id}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.BackupPolicy body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates new backup policy</summary>
                public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.BackupPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location to create the backup policies of, in the format
                    /// `projects/{project_id}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the backup policy. The ID must be unique within the specified
                    /// location. Must contain only letters, numbers and hyphen, with the first character a letter, the
                    /// last a letter or a number, and a 63 character maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupPolicyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupPolicyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.BackupPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/backupPolicies";

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
                        RequestParameters.Add("backupPolicyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "backupPolicyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Warning! This operation will permanently delete the backup policy.</summary>
                /// <param name="name">
                /// Required. The backup policy resource name, in the format
                /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Warning! This operation will permanently delete the backup policy.</summary>
                public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backup policy resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the description of the specified backup policy by backup_policy_id.</summary>
                /// <param name="name">
                /// Required. The backupPolicy resource name, in the format
                /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the description of the specified backup policy by backup_policy_id.</summary>
                public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.BackupPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backupPolicy resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns list of all available backup policies.</summary>
                /// <param name="parent">Required. Parent value for ListBackupPoliciesRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Returns list of all available backup policies.</summary>
                public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListBackupPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListBackupPoliciesRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, the server
                    /// will pick an appropriate default.
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
                    public override string RestPath => "v1/{+parent}/backupPolicies";

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

                /// <summary>Updates settings of a specific backup policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the backup policy. Format:
                /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.BackupPolicy body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates settings of a specific backup policy.</summary>
                public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.BackupPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the backup policy. Format:
                    /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the Backup Policy
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.BackupPolicy Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupPolicies/[^/]+$",
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

                    /// <summary>
                    /// Creates a backup from the volume specified in the request The backup can be created from the
                    /// given snapshot if specified in the request. If no snapshot specified, there'll be a new snapshot
                    /// taken to initiate the backup creation.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The NetApp backupVault to create the backups of, in the format
                    /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.Backup body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a backup from the volume specified in the request The backup can be created from the
                    /// given snapshot if specified in the request. If no snapshot specified, there'll be a new snapshot
                    /// taken to initiate the backup creation.
                    /// </summary>
                    public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Backup body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The NetApp backupVault to create the backups of, in the format
                        /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the backup. The ID must be unique within the specified
                        /// backupVault. Must contain only letters, numbers and hyphen, with the first character a
                        /// letter, the last a letter or a number, and a 63 character maximum.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string BackupId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.Backup Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
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

                    /// <summary>Warning! This operation will permanently delete the backup.</summary>
                    /// <param name="name">
                    /// Required. The backup resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Warning! This operation will permanently delete the backup.</summary>
                    public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The backup resource name, in the format
                        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the description of the specified backup</summary>
                    /// <param name="name">
                    /// Required. The backup resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the description of the specified backup</summary>
                    public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Backup>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The backup resource name, in the format
                        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns descriptions of all backups for a backupVault.</summary>
                    /// <param name="parent">
                    /// Required. The backupVault for which to retrieve backup information, in the format
                    /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`. To retrieve backup
                    /// information for all locations, use "-" for the `{location}` value. To retrieve backup
                    /// information for all backupVaults, use "-" for the `{backup_vault_id}` value. To retrieve backup
                    /// information for a volume, use "-" for the `{backup_vault_id}` value and specify volume full name
                    /// with the filter.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Returns descriptions of all backups for a backupVault.</summary>
                    public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListBackupsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The backupVault for which to retrieve backup information, in the format
                        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`. To retrieve
                        /// backup information for all locations, use "-" for the `{location}` value. To retrieve backup
                        /// information for all backupVaults, use "-" for the `{backup_vault_id}` value. To retrieve
                        /// backup information for a volume, use "-" for the `{backup_vault_id}` value and specify
                        /// volume full name with the filter.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The standard list filter. If specified, backups will be returned based on the attribute name
                        /// that matches the filter expression. If empty, then no backups are filtered out. See
                        /// https://google.aip.dev/160
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Sort results. Supported values are "name", "name desc" or "" (unsorted).</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of items to return. The service may return fewer than this value. The
                        /// maximum value is 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
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

                    /// <summary>Update backup with full spec.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the backup. Format:
                    /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.Backup body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Update backup with full spec.</summary>
                    public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Backup body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the backup. Format:
                        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the Backup resource
                        /// to be updated. The fields specified in the update_mask are relative to the resource, not the
                        /// full request. A field will be overwritten if it is in the mask. If the user does not provide
                        /// a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.Backup Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+/backups/[^/]+$",
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

                /// <summary>Creates new backup vault</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location to create the backup vaults, in the format
                /// `projects/{project_id}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.BackupVault body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates new backup vault</summary>
                public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.BackupVault body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location to create the backup vaults, in the format
                    /// `projects/{project_id}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the backupVault. The ID must be unique within the specified
                    /// location. Must contain only letters, numbers and hyphen, with the first character a letter, the
                    /// last a letter or a number, and a 63 character maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("backupVaultId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BackupVaultId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.BackupVault Body { get; set; }

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
                    }
                }

                /// <summary>Warning! This operation will permanently delete the backup vault.</summary>
                /// <param name="name">
                /// Required. The backupVault resource name, in the format
                /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Warning! This operation will permanently delete the backup vault.</summary>
                public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backupVault resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the description of the specified backup vault</summary>
                /// <param name="name">
                /// Required. The backupVault resource name, in the format
                /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the description of the specified backup vault</summary>
                public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.BackupVault>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The backupVault resource name, in the format
                    /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/backupVaults/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns list of all available backup vaults.</summary>
                /// <param name="parent">
                /// Required. The location for which to retrieve backupVault information, in the format
                /// `projects/{project_id}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Returns list of all available backup vaults.</summary>
                public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListBackupVaultsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location for which to retrieve backupVault information, in the format
                    /// `projects/{project_id}/locations/{location}`.
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
                    }
                }

                /// <summary>Updates the settings of a specific backup vault.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the backup vault. Format:
                /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.BackupVault body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the settings of a specific backup vault.</summary>
                public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.BackupVault body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the backup vault. Format:
                    /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the Backup resource to
                    /// be updated. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.BackupVault Body { get; set; }

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

            /// <summary>Gets the KmsConfigs resource.</summary>
            public virtual KmsConfigsResource KmsConfigs { get; }

            /// <summary>The "kmsConfigs" collection of methods.</summary>
            public class KmsConfigsResource
            {
                private const string Resource = "kmsConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public KmsConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new KMS config.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.KmsConfig body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new KMS config.</summary>
                public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.KmsConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Id of the requesting KmsConfig. Must be unique within the parent resource. Must
                    /// contain only letters, numbers and hyphen, with the first character a letter, the last a letter
                    /// or a number, and a 63 character maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("kmsConfigId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string KmsConfigId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.KmsConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/kmsConfigs";

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
                        RequestParameters.Add("kmsConfigId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "kmsConfigId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Warning! This operation will permanently delete the Kms config.</summary>
                /// <param name="name">Required. Name of the KmsConfig.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Warning! This operation will permanently delete the Kms config.</summary>
                public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the KmsConfig.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/kmsConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Encrypt the existing volumes without CMEK encryption with the desired the KMS config for the whole
                /// region.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the KmsConfig.</param>
                public virtual EncryptRequest Encrypt(Google.Apis.NetAppFiles.v1.Data.EncryptVolumesRequest body, string name)
                {
                    return new EncryptRequest(this.service, body, name);
                }

                /// <summary>
                /// Encrypt the existing volumes without CMEK encryption with the desired the KMS config for the whole
                /// region.
                /// </summary>
                public class EncryptRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Encrypt request.</summary>
                    public EncryptRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.EncryptVolumesRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the KmsConfig.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.EncryptVolumesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "encrypt";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:encrypt";

                    /// <summary>Initializes Encrypt parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/kmsConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the description of the specified KMS config by kms_config_id.</summary>
                /// <param name="name">Required. Name of the KmsConfig</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the description of the specified KMS config by kms_config_id.</summary>
                public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.KmsConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the KmsConfig</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/kmsConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns descriptions of all KMS configs owned by the caller.</summary>
                /// <param name="parent">Required. Parent value</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Returns descriptions of all KMS configs owned by the caller.</summary>
                public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListKmsConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value</summary>
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
                    public override string RestPath => "v1/{+parent}/kmsConfigs";

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

                /// <summary>Updates the Kms config properties with the full spec</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Identifier. Name of the KmsConfig.</param>
                public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.KmsConfig body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the Kms config properties with the full spec</summary>
                public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.KmsConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifier. Name of the KmsConfig.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the KmsConfig resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.KmsConfig Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/kmsConfigs/[^/]+$",
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

                /// <summary>Verifies KMS config reachability.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the KMS Config to be verified.</param>
                public virtual VerifyRequest Verify(Google.Apis.NetAppFiles.v1.Data.VerifyKmsConfigRequest body, string name)
                {
                    return new VerifyRequest(this.service, body, name);
                }

                /// <summary>Verifies KMS config reachability.</summary>
                public class VerifyRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.VerifyKmsConfigResponse>
                {
                    /// <summary>Constructs a new Verify request.</summary>
                    public VerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.VerifyKmsConfigRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the KMS Config to be verified.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.VerifyKmsConfigRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "verify";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:verify";

                    /// <summary>Initializes Verify parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/kmsConfigs/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.NetAppFiles.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.GoogleProtobufEmpty>
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
                public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
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
                public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the StoragePools resource.</summary>
            public virtual StoragePoolsResource StoragePools { get; }

            /// <summary>The "storagePools" collection of methods.</summary>
            public class StoragePoolsResource
            {
                private const string Resource = "storagePools";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StoragePoolsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new storage pool.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.StoragePool body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new storage pool.</summary>
                public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.StoragePool body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Id of the requesting storage pool. Must be unique within the parent resource. Must
                    /// contain only letters, numbers and hyphen, with the first character a letter, the last a letter
                    /// or a number, and a 63 character maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("storagePoolId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string StoragePoolId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.StoragePool Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/storagePools";

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
                        RequestParameters.Add("storagePoolId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "storagePoolId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Warning! This operation will permanently delete the storage pool.</summary>
                /// <param name="name">Required. Name of the storage pool</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Warning! This operation will permanently delete the storage pool.</summary>
                public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the storage pool</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storagePools/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the description of the specified storage pool by poolId.</summary>
                /// <param name="name">Required. Name of the storage pool</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the description of the specified storage pool by poolId.</summary>
                public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.StoragePool>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the storage pool</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storagePools/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns descriptions of all storage pools owned by the caller.</summary>
                /// <param name="parent">Required. Parent value</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Returns descriptions of all storage pools owned by the caller.</summary>
                public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListStoragePoolsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Sort results. Supported values are "name", "name desc" or "" (unsorted).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Optional. The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The next_page_token value to use if there are additional results to retrieve for this
                    /// list request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/storagePools";

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

                /// <summary>Updates the storage pool properties with the full spec</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Identifier. Name of the storage pool</param>
                public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.StoragePool body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the storage pool properties with the full spec</summary>
                public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.StoragePool body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifier. Name of the storage pool</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the StoragePool resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.StoragePool Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storagePools/[^/]+$",
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

                /// <summary>This operation will switch the active/replica zone for a regional storagePool.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the storage pool</param>
                public virtual NetAppFilesSwitchRequest NetAppFilesSwitch(Google.Apis.NetAppFiles.v1.Data.SwitchActiveReplicaZoneRequest body, string name)
                {
                    return new NetAppFilesSwitchRequest(this.service, body, name);
                }

                /// <summary>This operation will switch the active/replica zone for a regional storagePool.</summary>
                public class NetAppFilesSwitchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new NetAppFilesSwitch request.</summary>
                    public NetAppFilesSwitchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.SwitchActiveReplicaZoneRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the storage pool</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.SwitchActiveReplicaZoneRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "switch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:switch";

                    /// <summary>Initializes NetAppFilesSwitch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storagePools/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// ValidateDirectoryService does a connectivity check for a directory service policy attached to the
                /// storage pool.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the storage pool</param>
                public virtual ValidateDirectoryServiceRequest ValidateDirectoryService(Google.Apis.NetAppFiles.v1.Data.ValidateDirectoryServiceRequest body, string name)
                {
                    return new ValidateDirectoryServiceRequest(this.service, body, name);
                }

                /// <summary>
                /// ValidateDirectoryService does a connectivity check for a directory service policy attached to the
                /// storage pool.
                /// </summary>
                public class ValidateDirectoryServiceRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ValidateDirectoryService request.</summary>
                    public ValidateDirectoryServiceRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.ValidateDirectoryServiceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the storage pool</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.ValidateDirectoryServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "validateDirectoryService";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:validateDirectoryService";

                    /// <summary>Initializes ValidateDirectoryService parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storagePools/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Volumes resource.</summary>
            public virtual VolumesResource Volumes { get; }

            /// <summary>The "volumes" collection of methods.</summary>
            public class VolumesResource
            {
                private const string Resource = "volumes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VolumesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    QuotaRules = new QuotaRulesResource(service);
                    Replications = new ReplicationsResource(service);
                    Snapshots = new SnapshotsResource(service);
                }

                /// <summary>Gets the QuotaRules resource.</summary>
                public virtual QuotaRulesResource QuotaRules { get; }

                /// <summary>The "quotaRules" collection of methods.</summary>
                public class QuotaRulesResource
                {
                    private const string Resource = "quotaRules";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public QuotaRulesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new quota rule.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. Parent value for CreateQuotaRuleRequest</param>
                    public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.QuotaRule body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new quota rule.</summary>
                    public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.QuotaRule body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for CreateQuotaRuleRequest</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. ID of the quota rule to create. Must be unique within the parent resource. Must
                        /// contain only letters, numbers, underscore and hyphen, with the first character a letter or
                        /// underscore, the last a letter or underscore or a number, and a 63 character maximum.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaRuleId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaRuleId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.QuotaRule Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/quotaRules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                            });
                            RequestParameters.Add("quotaRuleId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "quotaRuleId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a quota rule.</summary>
                    /// <param name="name">Required. Name of the quota rule.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a quota rule.</summary>
                    public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the quota rule.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/quotaRules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns details of the specified quota rule.</summary>
                    /// <param name="name">Required. Name of the quota rule</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns details of the specified quota rule.</summary>
                    public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.QuotaRule>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the quota rule</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/quotaRules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns list of all quota rules in a location.</summary>
                    /// <param name="parent">Required. Parent value for ListQuotaRulesRequest</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Returns list of all quota rules in a location.</summary>
                    public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListQuotaRulesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for ListQuotaRulesRequest</summary>
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
                        /// the server will pick an appropriate default.
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
                        public override string RestPath => "v1/{+parent}/quotaRules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                    /// <summary>Updates a quota rule.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the quota rule. Format:
                    /// `projects/{project_number}/locations/{location_id}/volumes/volumes/{volume_id}/quotaRules/{quota_rule_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.QuotaRule body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a quota rule.</summary>
                    public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.QuotaRule body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the quota rule. Format:
                        /// `projects/{project_number}/locations/{location_id}/volumes/volumes/{volume_id}/quotaRules/{quota_rule_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask is used to specify the fields to be overwritten in the Quota Rule
                        /// resource by the update. The fields specified in the update_mask are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.QuotaRule Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/quotaRules/[^/]+$",
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

                /// <summary>Gets the Replications resource.</summary>
                public virtual ReplicationsResource Replications { get; }

                /// <summary>The "replications" collection of methods.</summary>
                public class ReplicationsResource
                {
                    private const string Resource = "replications";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReplicationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create a new replication for a volume.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The NetApp volume to create the replications of, in the format
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.Replication body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create a new replication for a volume.</summary>
                    public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Replication body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The NetApp volume to create the replications of, in the format
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. ID of the replication to create. Must be unique within the parent resource. Must
                        /// contain only letters, numbers and hyphen, with the first character a letter, the last a
                        /// letter or a number, and a 63 character maximum.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("replicationId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ReplicationId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.Replication Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/replications";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                            });
                            RequestParameters.Add("replicationId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "replicationId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a replication.</summary>
                    /// <param name="name">
                    /// Required. The replication resource name, in the format
                    /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a replication.</summary>
                    public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The replication resource name, in the format
                        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Establish replication peering.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the replication, in the format of
                    /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                    /// </param>
                    public virtual EstablishPeeringRequest EstablishPeering(Google.Apis.NetAppFiles.v1.Data.EstablishPeeringRequest body, string name)
                    {
                        return new EstablishPeeringRequest(this.service, body, name);
                    }

                    /// <summary>Establish replication peering.</summary>
                    public class EstablishPeeringRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new EstablishPeering request.</summary>
                        public EstablishPeeringRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.EstablishPeeringRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the replication, in the format of
                        /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.EstablishPeeringRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "establishPeering";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:establishPeering";

                        /// <summary>Initializes EstablishPeering parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Describe a replication for a volume.</summary>
                    /// <param name="name">
                    /// Required. The replication resource name, in the format
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Describe a replication for a volume.</summary>
                    public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Replication>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The replication resource name, in the format
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns descriptions of all replications for a volume.</summary>
                    /// <param name="parent">
                    /// Required. The volume for which to retrieve replication information, in the format
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Returns descriptions of all replications for a volume.</summary>
                    public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListReplicationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The volume for which to retrieve replication information, in the format
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
                        public override string RestPath => "v1/{+parent}/replications";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                    /// <summary>Updates the settings of a specific replication.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the Replication. Format:
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.Replication body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the settings of a specific replication.</summary>
                    public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Replication body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the Replication. Format:
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.Replication Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
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

                    /// <summary>Resume Cross Region Replication.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the replication, in the format of
                    /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                    /// </param>
                    public virtual ResumeRequest Resume(Google.Apis.NetAppFiles.v1.Data.ResumeReplicationRequest body, string name)
                    {
                        return new ResumeRequest(this.service, body, name);
                    }

                    /// <summary>Resume Cross Region Replication.</summary>
                    public class ResumeRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Resume request.</summary>
                        public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.ResumeReplicationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the replication, in the format of
                        /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.ResumeReplicationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "resume";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:resume";

                        /// <summary>Initializes Resume parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Reverses direction of replication. Source becomes destination and destination becomes source.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the replication, in the format of
                    /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                    /// </param>
                    public virtual ReverseDirectionRequest ReverseDirection(Google.Apis.NetAppFiles.v1.Data.ReverseReplicationDirectionRequest body, string name)
                    {
                        return new ReverseDirectionRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Reverses direction of replication. Source becomes destination and destination becomes source.
                    /// </summary>
                    public class ReverseDirectionRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new ReverseDirection request.</summary>
                        public ReverseDirectionRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.ReverseReplicationDirectionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the replication, in the format of
                        /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.ReverseReplicationDirectionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "reverseDirection";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:reverseDirection";

                        /// <summary>Initializes ReverseDirection parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Stop Cross Region Replication.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the replication, in the format of
                    /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                    /// </param>
                    public virtual StopRequest Stop(Google.Apis.NetAppFiles.v1.Data.StopReplicationRequest body, string name)
                    {
                        return new StopRequest(this.service, body, name);
                    }

                    /// <summary>Stop Cross Region Replication.</summary>
                    public class StopRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Stop request.</summary>
                        public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.StopReplicationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the replication, in the format of
                        /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.StopReplicationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "stop";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:stop";

                        /// <summary>Initializes Stop parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Syncs the replication. This will invoke one time volume data transfer from source to
                    /// destination.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the replication, in the format of
                    /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                    /// </param>
                    public virtual SyncRequest Sync(Google.Apis.NetAppFiles.v1.Data.SyncReplicationRequest body, string name)
                    {
                        return new SyncRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Syncs the replication. This will invoke one time volume data transfer from source to
                    /// destination.
                    /// </summary>
                    public class SyncRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Sync request.</summary>
                        public SyncRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.SyncReplicationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the replication, in the format of
                        /// projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.SyncReplicationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "sync";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:sync";

                        /// <summary>Initializes Sync parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/replications/[^/]+$",
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

                    /// <summary>Create a new snapshot for a volume.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The NetApp volume to create the snapshots of, in the format
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.Snapshot body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create a new snapshot for a volume.</summary>
                    public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Snapshot body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The NetApp volume to create the snapshots of, in the format
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. ID of the snapshot to create. Must be unique within the parent resource. Must
                        /// contain only letters, numbers and hyphen, with the first character a letter, the last a
                        /// letter or a number, and a 63 character maximum.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("snapshotId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string SnapshotId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.Snapshot Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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
                    /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a snapshot.</summary>
                    public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The snapshot resource name, in the format
                        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Describe a snapshot for a volume.</summary>
                    /// <param name="name">
                    /// Required. The snapshot resource name, in the format
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Describe a snapshot for a volume.</summary>
                    public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Snapshot>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The snapshot resource name, in the format
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns descriptions of all snapshots for a volume.</summary>
                    /// <param name="parent">
                    /// Required. The volume for which to retrieve snapshot information, in the format
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Returns descriptions of all snapshots for a volume.</summary>
                    public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListSnapshotsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The volume for which to retrieve snapshot information, in the format
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
                        public override string RestPath => "v1/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                    /// <summary>Updates the settings of a specific snapshot.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the snapshot. Format:
                    /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.Snapshot body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the settings of a specific snapshot.</summary>
                    public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Snapshot body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the snapshot. Format:
                        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetAppFiles.v1.Data.Snapshot Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
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

                /// <summary>Creates a new Volume in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.NetAppFiles.v1.Data.Volume body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Volume in a given project and location.</summary>
                public class CreateRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Volume body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Id of the requesting volume. Must be unique within the parent resource. Must contain
                    /// only letters, numbers and hyphen, with the first character a letter, the last a letter or a
                    /// number, and a 63 character maximum.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("volumeId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VolumeId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.Volume Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/volumes";

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
                        RequestParameters.Add("volumeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "volumeId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Volume.</summary>
                /// <param name="name">Required. Name of the volume</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Volume.</summary>
                public class DeleteRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the volume</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If this field is set as true, CCFE will not block the volume resource deletion even if it has
                    /// any snapshots resource. (Otherwise, the request will only work if the volume has no snapshots.)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                /// <summary>Gets details of a single Volume.</summary>
                /// <param name="name">Required. Name of the volume</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Volume.</summary>
                public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Volume>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the volume</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Volumes in a given project.</summary>
                /// <param name="parent">Required. Parent value for ListVolumesRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Volumes in a given project.</summary>
                public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListVolumesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListVolumesRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, the server
                    /// will pick an appropriate default.
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
                    public override string RestPath => "v1/{+parent}/volumes";

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

                /// <summary>Updates the parameters of a single Volume.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Identifier. Name of the volume</param>
                public virtual PatchRequest Patch(Google.Apis.NetAppFiles.v1.Data.Volume body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Volume.</summary>
                public class PatchRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.Volume body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifier. Name of the volume</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the Volume resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.Volume Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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
                /// Revert an existing volume to a specified snapshot. Warning! This operation will permanently revert
                /// all changes made after the snapshot was created.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the volume, in the format of
                /// projects/{project_id}/locations/{location}/volumes/{volume_id}.
                /// </param>
                public virtual RevertRequest Revert(Google.Apis.NetAppFiles.v1.Data.RevertVolumeRequest body, string name)
                {
                    return new RevertRequest(this.service, body, name);
                }

                /// <summary>
                /// Revert an existing volume to a specified snapshot. Warning! This operation will permanently revert
                /// all changes made after the snapshot was created.
                /// </summary>
                public class RevertRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Revert request.</summary>
                    public RevertRequest(Google.Apis.Services.IClientService service, Google.Apis.NetAppFiles.v1.Data.RevertVolumeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the volume, in the format of
                    /// projects/{project_id}/locations/{location}/volumes/{volume_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetAppFiles.v1.Data.RevertVolumeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "revert";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:revert";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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
            public class GetRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.Location>
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
            public class ListRequest : NetAppFilesBaseServiceRequest<Google.Apis.NetAppFiles.v1.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
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
namespace Google.Apis.NetAppFiles.v1.Data
{
    /// <summary>ActiveDirectory is the public representation of the active directory config.</summary>
    public class ActiveDirectory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Users to be added to the Built-in Admininstrators group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrators")]
        public virtual System.Collections.Generic.IList<string> Administrators { get; set; }

        /// <summary>If enabled, AES encryption will be enabled for SMB communication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aesEncryption")]
        public virtual System.Nullable<bool> AesEncryption { get; set; }

        /// <summary>Optional. Users to be added to the Built-in Backup Operator active directory group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupOperators")]
        public virtual System.Collections.Generic.IList<string> BackupOperators { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time of the active directory.</summary>
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

        /// <summary>Description of the active directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Comma separated list of DNS server IP addresses for the Active Directory domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dns")]
        public virtual string Dns { get; set; }

        /// <summary>Required. Name of the Active Directory domain</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>If enabled, traffic between the SMB server to Domain Controller (DC) will be encrypted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptDcConnections")]
        public virtual System.Nullable<bool> EncryptDcConnections { get; set; }

        /// <summary>
        /// Name of the active directory machine. This optional parameter is used only while creating kerberos volume
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kdcHostname")]
        public virtual string KdcHostname { get; set; }

        /// <summary>KDC server IP address for the active directory machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kdcIp")]
        public virtual string KdcIp { get; set; }

        /// <summary>Labels for the active directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Specifies whether or not the LDAP traffic needs to be signed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ldapSigning")]
        public virtual System.Nullable<bool> LdapSigning { get; set; }

        /// <summary>
        /// Identifier. The resource name of the active directory. Format:
        /// `projects/{project_number}/locations/{location_id}/activeDirectories/{active_directory_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. NetBIOSPrefix is used as a prefix for SMB server name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("netBiosPrefix")]
        public virtual string NetBiosPrefix { get; set; }

        /// <summary>
        /// If enabled, will allow access to local users and LDAP users. If access is needed for only LDAP users, it has
        /// to be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsUsersWithLdap")]
        public virtual System.Nullable<bool> NfsUsersWithLdap { get; set; }

        /// <summary>The Organizational Unit (OU) within the Windows Active Directory the user belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationalUnit")]
        public virtual string OrganizationalUnit { get; set; }

        /// <summary>Required. Password of the Active Directory domain administrator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Optional. Domain users to be given the SeSecurityPrivilege.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityOperators")]
        public virtual System.Collections.Generic.IList<string> SecurityOperators { get; set; }

        /// <summary>The Active Directory site the service will limit Domain Controller discovery too.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual string Site { get; set; }

        /// <summary>Output only. The state of the AD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The state details of the Active Directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>Required. Username of the Active Directory domain administrator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A NetApp Backup.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Region in which backup is stored. Format: `projects/{project_id}/locations/{location}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRegion")]
        public virtual string BackupRegion { get; set; }

        /// <summary>Output only. Type of backup, manually created or created by a backup policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        /// <summary>
        /// Output only. Total size of all backups in a chain in bytes = baseline backup size + sum(incremental backup
        /// size)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chainStorageBytes")]
        public virtual System.Nullable<long> ChainStorageBytes { get; set; }

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

        private string _enforcedRetentionEndTimeRaw;

        private object _enforcedRetentionEndTime;

        /// <summary>Output only. The time until which the backup is not deletable.</summary>
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

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the backup. Format:
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// If specified, backup will be created from the given snapshot. If not specified, there will be a new snapshot
        /// taken to initiate the backup creation. Format:
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSnapshot")]
        public virtual string SourceSnapshot { get; set; }

        /// <summary>
        /// Volume full name of this backup belongs to. Format:
        /// `projects/{projects_id}/locations/{location}/volumes/{volume_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceVolume")]
        public virtual string SourceVolume { get; set; }

        /// <summary>Output only. The backup state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Region of the volume from which the backup was created. Format:
        /// `projects/{project_id}/locations/{location}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeRegion")]
        public virtual string VolumeRegion { get; set; }

        /// <summary>
        /// Output only. Size of the file system when the backup was created. When creating a new volume from the
        /// backup, the volume capacity will have to be at least as big.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeUsageBytes")]
        public virtual System.Nullable<long> VolumeUsageBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupConfig contains backup related config on a volume.</summary>
    public class BackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Total size of all backups in a chain in bytes = baseline backup size + sum(incremental backup
        /// size).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupChainBytes")]
        public virtual System.Nullable<long> BackupChainBytes { get; set; }

        /// <summary>
        /// Optional. When specified, schedule backups will be created based on the policy configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPolicies")]
        public virtual System.Collections.Generic.IList<string> BackupPolicies { get; set; }

        /// <summary>
        /// Optional. Name of backup vault. Format:
        /// projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVault")]
        public virtual string BackupVault { get; set; }

        /// <summary>
        /// Optional. When set to true, scheduled backup is enabled on the volume. This field should be nil when there's
        /// no backup policy attached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledBackupEnabled")]
        public virtual System.Nullable<bool> ScheduledBackupEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup Policy.</summary>
    public class BackupPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The total number of volumes assigned by this backup policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedVolumeCount")]
        public virtual System.Nullable<int> AssignedVolumeCount { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the backup policy was created.</summary>
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

        /// <summary>Number of daily backups to keep. Note that the minimum daily backup limit is 2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyBackupLimit")]
        public virtual System.Nullable<int> DailyBackupLimit { get; set; }

        /// <summary>Description of the backup policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// If enabled, make backups automatically according to the schedules. This will be applied to all volumes that
        /// have this policy attached and enforced on volume level. If not specified, default is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Number of monthly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater
        /// than 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyBackupLimit")]
        public virtual System.Nullable<int> MonthlyBackupLimit { get; set; }

        /// <summary>
        /// Identifier. The resource name of the backup policy. Format:
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The backup policy state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Number of weekly backups to keep. Note that the sum of daily, weekly and monthly backups should be greater
        /// than 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyBackupLimit")]
        public virtual System.Nullable<int> WeeklyBackupLimit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Retention policy for backups in the backup vault</summary>
    public class BackupRetentionPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Minimum retention duration in days for backups in the backup vault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupMinimumEnforcedRetentionDays")]
        public virtual System.Nullable<int> BackupMinimumEnforcedRetentionDays { get; set; }

        /// <summary>
        /// Optional. Indicates if the daily backups are immutable. At least one of daily_backup_immutable,
        /// weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyBackupImmutable")]
        public virtual System.Nullable<bool> DailyBackupImmutable { get; set; }

        /// <summary>
        /// Optional. Indicates if the manual backups are immutable. At least one of daily_backup_immutable,
        /// weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualBackupImmutable")]
        public virtual System.Nullable<bool> ManualBackupImmutable { get; set; }

        /// <summary>
        /// Optional. Indicates if the monthly backups are immutable. At least one of daily_backup_immutable,
        /// weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyBackupImmutable")]
        public virtual System.Nullable<bool> MonthlyBackupImmutable { get; set; }

        /// <summary>
        /// Optional. Indicates if the weekly backups are immutable. At least one of daily_backup_immutable,
        /// weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyBackupImmutable")]
        public virtual System.Nullable<bool> WeeklyBackupImmutable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A NetApp BackupVault.</summary>
    public class BackupVault : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Region where the backups are stored. Format: `projects/{project_id}/locations/{location}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRegion")]
        public virtual string BackupRegion { get; set; }

        /// <summary>Optional. Backup retention policy defining the retenton of backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionPolicy")]
        public virtual BackupRetentionPolicy BackupRetentionPolicy { get; set; }

        /// <summary>Optional. Type of backup vault to be created. Default is IN_REGION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVaultType")]
        public virtual string BackupVaultType { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time of the backup vault.</summary>
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

        /// <summary>Description of the backup vault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Name of the Backup vault created in backup region. Format:
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationBackupVault")]
        public virtual string DestinationBackupVault { get; set; }

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the backup vault. Format:
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Name of the Backup vault created in source region. Format:
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackupVault")]
        public virtual string SourceBackupVault { get; set; }

        /// <summary>
        /// Output only. Region in which the backup vault is created. Format:
        /// `projects/{project_id}/locations/{location}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRegion")]
        public virtual string SourceRegion { get; set; }

        /// <summary>Output only. The backup vault state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Make a snapshot every day e.g. at 04:00, 05:20, 23:50</summary>
    public class DailySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set the hour to start the snapshot (0-23), defaults to midnight (0).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<double> Hour { get; set; }

        /// <summary>
        /// Set the minute of the hour to start the snapshot (0-59), defaults to the top of the hour (0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<double> Minute { get; set; }

        /// <summary>The maximum number of Snapshots to keep for the hourly schedule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotsToKeep")]
        public virtual System.Nullable<double> SnapshotsToKeep { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DestinationVolumeParameters specify input parameters used for creating destination volume.</summary>
    public class DestinationVolumeParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description for the destination volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Destination volume's share name. If not specified, source volume's share name will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareName")]
        public virtual string ShareName { get; set; }

        /// <summary>Required. Existing destination StoragePool name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePool")]
        public virtual string StoragePool { get; set; }

        /// <summary>Optional. Tiering policy for the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tieringPolicy")]
        public virtual TieringPolicy TieringPolicy { get; set; }

        /// <summary>
        /// Desired destination volume resource id. If not specified, source volume's resource id will be used. This
        /// value must start with a lowercase letter followed by up to 62 lowercase letters, numbers, or hyphens, and
        /// cannot end with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EncryptVolumesRequest specifies the KMS config to encrypt existing volumes.</summary>
    public class EncryptVolumesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EstablishPeeringRequest establishes cluster and svm peerings between the source and the destination
    /// replications.
    /// </summary>
    public class EstablishPeeringRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the user's local source cluster to be peered with the destination cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerClusterName")]
        public virtual string PeerClusterName { get; set; }

        /// <summary>Optional. List of IPv4 ip addresses to be used for peering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerIpAddresses")]
        public virtual System.Collections.Generic.IList<string> PeerIpAddresses { get; set; }

        /// <summary>
        /// Required. Name of the user's local source vserver svm to be peered with the destination vserver svm.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerSvmName")]
        public virtual string PeerSvmName { get; set; }

        /// <summary>
        /// Required. Name of the user's local source volume to be peered with the destination volume.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerVolumeName")]
        public virtual string PeerVolumeName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the export policy for the volume.</summary>
    public class ExportPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of export policy rules</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<SimpleExportPolicyRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Make a snapshot every hour e.g. at 04:00, 05:00, 06:00.</summary>
    public class HourlySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set the minute of the hour to start the snapshot (0-59), defaults to the top of the hour (0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<double> Minute { get; set; }

        /// <summary>The maximum number of Snapshots to keep for the hourly schedule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotsToKeep")]
        public virtual System.Nullable<double> SnapshotsToKeep { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HybridPeeringDetails contains details about the hybrid peering.</summary>
    public class HybridPeeringDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Copy-paste-able commands to be used on user's ONTAP to accept peering requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        private string _commandExpiryTimeRaw;

        private object _commandExpiryTime;

        /// <summary>Output only. Expiration time for the peering command to be executed on user's ONTAP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandExpiryTime")]
        public virtual string CommandExpiryTimeRaw
        {
            get => _commandExpiryTimeRaw;
            set
            {
                _commandExpiryTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _commandExpiryTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CommandExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CommandExpiryTimeDateTimeOffset instead.")]
        public virtual object CommandExpiryTime
        {
            get => _commandExpiryTime;
            set
            {
                _commandExpiryTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _commandExpiryTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CommandExpiryTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CommandExpiryTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CommandExpiryTimeRaw);
            set => CommandExpiryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Temporary passphrase generated to accept cluster peering command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passphrase")]
        public virtual string Passphrase { get; set; }

        /// <summary>
        /// Output only. Name of the user's local source cluster to be peered with the destination cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerClusterName")]
        public virtual string PeerClusterName { get; set; }

        /// <summary>
        /// Output only. Name of the user's local source vserver svm to be peered with the destination vserver svm.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerSvmName")]
        public virtual string PeerSvmName { get; set; }

        /// <summary>
        /// Output only. Name of the user's local source volume to be peered with the destination volume.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerVolumeName")]
        public virtual string PeerVolumeName { get; set; }

        /// <summary>Output only. IP address of the subnet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetIp")]
        public virtual string SubnetIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Hybrid Replication parameters for the volume.</summary>
    public class HybridReplicationParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Name of source cluster location associated with the Hybrid replication. This is a free-form field
        /// for the display purpose only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterLocation")]
        public virtual string ClusterLocation { get; set; }

        /// <summary>Optional. Description of the replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Type of the hybrid replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridReplicationType")]
        public virtual string HybridReplicationType { get; set; }

        /// <summary>Optional. Labels to be added to the replication as the key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Constituent volume count for large volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeVolumeConstituentCount")]
        public virtual System.Nullable<int> LargeVolumeConstituentCount { get; set; }

        /// <summary>
        /// Required. Name of the user's local source cluster to be peered with the destination cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerClusterName")]
        public virtual string PeerClusterName { get; set; }

        /// <summary>Required. List of node ip addresses to be peered with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerIpAddresses")]
        public virtual System.Collections.Generic.IList<string> PeerIpAddresses { get; set; }

        /// <summary>
        /// Required. Name of the user's local source vserver svm to be peered with the destination vserver svm.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerSvmName")]
        public virtual string PeerSvmName { get; set; }

        /// <summary>
        /// Required. Name of the user's local source volume to be peered with the destination volume.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerVolumeName")]
        public virtual string PeerVolumeName { get; set; }

        /// <summary>Required. Desired name for the replication of this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replication")]
        public virtual string Replication { get; set; }

        /// <summary>Optional. Replication Schedule for the replication created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationSchedule")]
        public virtual string ReplicationSchedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>KmsConfig is the customer managed encryption key(CMEK) configuration.</summary>
    public class KmsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time of the KmsConfig.</summary>
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
        /// Required. Customer managed crypto key resource full name. Format:
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{key}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyName")]
        public virtual string CryptoKeyName { get; set; }

        /// <summary>Description of the KmsConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Instructions to provide the access to the customer provided encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual string Instructions { get; set; }

        /// <summary>Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Identifier. Name of the KmsConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The Service account which will have access to the customer provided encryption key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. State of the KmsConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. State details of the KmsConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListActiveDirectoriesResponse contains all the active directories requested.</summary>
    public class ListActiveDirectoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of active directories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDirectories")]
        public virtual System.Collections.Generic.IList<ActiveDirectory> ActiveDirectories { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListBackupPoliciesResponse contains all the backup policies requested.</summary>
    public class ListBackupPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of backup policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupPolicies")]
        public virtual System.Collections.Generic.IList<BackupPolicy> BackupPolicies { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListBackupVaultsResponse is the result of ListBackupVaultsRequest.</summary>
    public class ListBackupVaultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of backupVaults in the project for the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupVaults")]
        public virtual System.Collections.Generic.IList<BackupVault> BackupVaults { get; set; }

        /// <summary>
        /// The token you can use to retrieve the next page of results. Not returned if there are no more results in the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListBackupsResponse is the result of ListBackupsRequest.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of backups in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// The token you can use to retrieve the next page of results. Not returned if there are no more results in the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListKmsConfigsResponse is the response to a ListKmsConfigsRequest.</summary>
    public class ListKmsConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of KmsConfigs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsConfigs")]
        public virtual System.Collections.Generic.IList<KmsConfig> KmsConfigs { get; set; }

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

    /// <summary>ListQuotaRulesResponse is the response to a ListQuotaRulesRequest.</summary>
    public class ListQuotaRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of quota rules</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaRules")]
        public virtual System.Collections.Generic.IList<QuotaRule> QuotaRules { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListReplicationsResponse is the result of ListReplicationsRequest.</summary>
    public class ListReplicationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token you can use to retrieve the next page of results. Not returned if there are no more results in the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of replications in the project for the specified volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replications")]
        public virtual System.Collections.Generic.IList<Replication> Replications { get; set; }

        /// <summary>Locations that could not be reached.</summary>
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

        /// <summary>A list of snapshots in the project for the specified volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshots")]
        public virtual System.Collections.Generic.IList<Snapshot> Snapshots { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListStoragePoolsResponse is the response to a ListStoragePoolsRequest.</summary>
    public class ListStoragePoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of StoragePools</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePools")]
        public virtual System.Collections.Generic.IList<StoragePool> StoragePools { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing Volumes</summary>
    public class ListVolumesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The list of Volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

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

    /// <summary>Metadata for a given google.cloud.location.Location.</summary>
    public class LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates if the location has VCP support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasVcp")]
        public virtual System.Nullable<bool> HasVcp { get; set; }

        /// <summary>Output only. Supported flex performance in a location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedFlexPerformance")]
        public virtual System.Collections.Generic.IList<string> SupportedFlexPerformance { get; set; }

        /// <summary>Output only. Supported service levels in a location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedServiceLevels")]
        public virtual System.Collections.Generic.IList<string> SupportedServiceLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Make a snapshot once a month e.g. at 2nd 04:00, 7th 05:20, 24th 23:50</summary>
    public class MonthlySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set the day or days of the month to make a snapshot (1-31). Accepts a comma separated number of days.
        /// Defaults to '1'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfMonth")]
        public virtual string DaysOfMonth { get; set; }

        /// <summary>Set the hour to start the snapshot (0-23), defaults to midnight (0).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<double> Hour { get; set; }

        /// <summary>
        /// Set the minute of the hour to start the snapshot (0-59), defaults to the top of the hour (0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<double> Minute { get; set; }

        /// <summary>The maximum number of Snapshots to keep for the hourly schedule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotsToKeep")]
        public virtual System.Nullable<double> SnapshotsToKeep { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>View only mount options for a volume.</summary>
    public class MountOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Export string</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("export")]
        public virtual string Export { get; set; }

        /// <summary>Full export string</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFull")]
        public virtual string ExportFull { get; set; }

        /// <summary>Instructions for mounting</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual string Instructions { get; set; }

        /// <summary>Output only. IP Address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>Protocol to mount with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

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
        /// been canceled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
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
    /// QuotaRule specifies the maximum disk space a user or group can use within a volume. They can be used for
    /// creating default and individual quota rules.
    /// </summary>
    public class QuotaRule : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time of the quota rule</summary>
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

        /// <summary>Optional. Description of the quota rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The maximum allowed disk space in MiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskLimitMib")]
        public virtual System.Nullable<int> DiskLimitMib { get; set; }

        /// <summary>Optional. Labels of the quota rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the quota rule. Format:
        /// `projects/{project_number}/locations/{location_id}/volumes/volumes/{volume_id}/quotaRules/{quota_rule_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the quota rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. State details of the quota rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>
        /// Optional. The quota rule applies to the specified user or group, identified by a Unix UID/GID, Windows SID,
        /// or null for default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Required. The type of quota rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replication is a nested resource under Volume, that describes a cross-region replication relationship between 2
    /// volumes in different regions.
    /// </summary>
    public class Replication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Location of the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterLocation")]
        public virtual string ClusterLocation { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Replication create time.</summary>
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

        /// <summary>A description about this replication relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Full name of destination volume resource. Example :
        /// "projects/{project}/locations/{location}/volumes/{volume_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationVolume")]
        public virtual string DestinationVolume { get; set; }

        /// <summary>Required. Input only. Destination volume parameters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationVolumeParameters")]
        public virtual DestinationVolumeParameters DestinationVolumeParameters { get; set; }

        /// <summary>
        /// Output only. Condition of the relationship. Can be one of the following: - true: The replication
        /// relationship is healthy. It has not missed the most recent scheduled transfer. - false: The replication
        /// relationship is not healthy. It has missed the most recent scheduled transfer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthy")]
        public virtual System.Nullable<bool> Healthy { get; set; }

        /// <summary>Output only. Hybrid peering details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridPeeringDetails")]
        public virtual HybridPeeringDetails HybridPeeringDetails { get; set; }

        /// <summary>Output only. Type of the hybrid replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridReplicationType")]
        public virtual string HybridReplicationType { get; set; }

        /// <summary>
        /// Output only. Copy pastable snapmirror commands to be executed on onprem cluster by the customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridReplicationUserCommands")]
        public virtual UserCommands HybridReplicationUserCommands { get; set; }

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Indicates the state of mirroring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mirrorState")]
        public virtual string MirrorState { get; set; }

        /// <summary>
        /// Identifier. The resource name of the Replication. Format:
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Indicates the schedule for replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationSchedule")]
        public virtual string ReplicationSchedule { get; set; }

        /// <summary>Output only. Indicates whether this points to source or destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>
        /// Output only. Full name of source volume resource. Example :
        /// "projects/{project}/locations/{location}/volumes/{volume_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceVolume")]
        public virtual string SourceVolume { get; set; }

        /// <summary>Output only. State of the replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. State details of the replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>Output only. Replication transfer statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferStats")]
        public virtual TransferStats TransferStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The RestoreParameters if volume is created from a snapshot or backup.</summary>
    public class RestoreParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full name of the backup resource. Format:
        /// projects/{project}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>
        /// Full name of the snapshot resource. Format:
        /// projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSnapshot")]
        public virtual string SourceSnapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResumeReplicationRequest resumes a stopped replication.</summary>
    public class ResumeReplicationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ReverseReplicationDirectionRequest reverses direction of replication. Source becomes destination and destination
    /// becomes source.
    /// </summary>
    public class ReverseReplicationDirectionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RevertVolumeRequest reverts the given volume to the specified snapshot.</summary>
    public class RevertVolumeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The snapshot resource ID, in the format 'my-snapshot', where the specified ID is the {snapshot_id}
        /// of the fully qualified name like
        /// projects/{project_id}/locations/{location_id}/volumes/{volume_id}/snapshots/{snapshot_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotId")]
        public virtual string SnapshotId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An export policy rule describing various export options.</summary>
    public class SimpleExportPolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access type (ReadWrite, ReadOnly, None)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessType")]
        public virtual string AccessType { get; set; }

        /// <summary>Comma separated list of allowed clients IP addresses</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedClients")]
        public virtual string AllowedClients { get; set; }

        /// <summary>Whether Unix root access will be granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasRootAccess")]
        public virtual string HasRootAccess { get; set; }

        /// <summary>
        /// If enabled (true) the rule defines a read only access for clients matching the 'allowedClients'
        /// specification. It enables nfs clients to mount using 'authentication' kerberos security mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberos5ReadOnly")]
        public virtual System.Nullable<bool> Kerberos5ReadOnly { get; set; }

        /// <summary>
        /// If enabled (true) the rule defines read and write access for clients matching the 'allowedClients'
        /// specification. It enables nfs clients to mount using 'authentication' kerberos security mode. The
        /// 'kerberos5ReadOnly' value be ignored if this is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberos5ReadWrite")]
        public virtual System.Nullable<bool> Kerberos5ReadWrite { get; set; }

        /// <summary>
        /// If enabled (true) the rule defines a read only access for clients matching the 'allowedClients'
        /// specification. It enables nfs clients to mount using 'integrity' kerberos security mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberos5iReadOnly")]
        public virtual System.Nullable<bool> Kerberos5iReadOnly { get; set; }

        /// <summary>
        /// If enabled (true) the rule defines read and write access for clients matching the 'allowedClients'
        /// specification. It enables nfs clients to mount using 'integrity' kerberos security mode. The
        /// 'kerberos5iReadOnly' value be ignored if this is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberos5iReadWrite")]
        public virtual System.Nullable<bool> Kerberos5iReadWrite { get; set; }

        /// <summary>
        /// If enabled (true) the rule defines a read only access for clients matching the 'allowedClients'
        /// specification. It enables nfs clients to mount using 'privacy' kerberos security mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberos5pReadOnly")]
        public virtual System.Nullable<bool> Kerberos5pReadOnly { get; set; }

        /// <summary>
        /// If enabled (true) the rule defines read and write access for clients matching the 'allowedClients'
        /// specification. It enables nfs clients to mount using 'privacy' kerberos security mode. The
        /// 'kerberos5pReadOnly' value be ignored if this is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberos5pReadWrite")]
        public virtual System.Nullable<bool> Kerberos5pReadWrite { get; set; }

        /// <summary>NFS V3 protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsv3")]
        public virtual System.Nullable<bool> Nfsv3 { get; set; }

        /// <summary>NFS V4 protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsv4")]
        public virtual System.Nullable<bool> Nfsv4 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Snapshot is a point-in-time version of a Volume's content.</summary>
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

        /// <summary>Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the snapshot. Format:
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The snapshot state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. State details of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>Output only. Current storage usage for the snapshot in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedBytes")]
        public virtual System.Nullable<double> UsedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Snapshot Policy for a volume.</summary>
    public class SnapshotPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daily schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailySchedule")]
        public virtual DailySchedule DailySchedule { get; set; }

        /// <summary>If enabled, make snapshots automatically according to the schedules. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Hourly schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourlySchedule")]
        public virtual HourlySchedule HourlySchedule { get; set; }

        /// <summary>Monthly schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlySchedule")]
        public virtual MonthlySchedule MonthlySchedule { get; set; }

        /// <summary>Weekly schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklySchedule")]
        public virtual WeeklySchedule WeeklySchedule { get; set; }

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

    /// <summary>StopReplicationRequest stops a replication until resumed.</summary>
    public class StopReplicationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether to stop replication forcefully while data transfer is in progress. Warning! if force is
        /// true, this will abort any current transfers and can lead to data loss due to partial transfer. If force is
        /// false, stop replication will fail while data transfer is in progress and you will need to retry later.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// StoragePool is a container for volumes with a service level and capacity. Volumes can be created in a pool of
    /// sufficient available capacity. StoragePool capacity is what you are billed for.
    /// </summary>
    public class StoragePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies the Active Directory to be used for creating a SMB volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDirectory")]
        public virtual string ActiveDirectory { get; set; }

        /// <summary>
        /// Optional. True if the storage pool supports Auto Tiering enabled volumes. Default is false. Auto-tiering can
        /// be enabled after storage pool creation but it can't be disabled once enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAutoTiering")]
        public virtual System.Nullable<bool> AllowAutoTiering { get; set; }

        /// <summary>Output only. Available throughput of the storage pool (in MiB/s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableThroughputMibps")]
        public virtual System.Nullable<double> AvailableThroughputMibps { get; set; }

        /// <summary>Required. Capacity in GIB of the pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGib")]
        public virtual System.Nullable<long> CapacityGib { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time of the storage pool</summary>
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
        /// Optional. True if using Independent Scaling of capacity and performance (Hyperdisk) By default set to false
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPerformanceEnabled")]
        public virtual System.Nullable<bool> CustomPerformanceEnabled { get; set; }

        /// <summary>Optional. Description of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Flag indicating that the hot-tier threshold will be auto-increased by 10% of the hot-tier when it
        /// hits 100%. Default is true. The increment will kick in only if the new size after increment is still less
        /// than or equal to storage pool size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHotTierAutoResize")]
        public virtual System.Nullable<bool> EnableHotTierAutoResize { get; set; }

        /// <summary>Output only. Specifies the current pool encryption key source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>Deprecated. Used to allow SO pool to access AD or DNS server from other regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalAccessAllowed")]
        public virtual System.Nullable<bool> GlobalAccessAllowed { get; set; }

        /// <summary>
        /// Optional. Total hot tier capacity for the Storage Pool. It is applicable only to Flex service level. It
        /// should be less than the minimum storage pool size and cannot be more than the current storage pool size. It
        /// cannot be decreased once set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotTierSizeGib")]
        public virtual System.Nullable<long> HotTierSizeGib { get; set; }

        /// <summary>Optional. Specifies the KMS config to be used for volume encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsConfig")]
        public virtual string KmsConfig { get; set; }

        /// <summary>Optional. Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Flag indicating if the pool is NFS LDAP enabled or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ldapEnabled")]
        public virtual System.Nullable<bool> LdapEnabled { get; set; }

        /// <summary>Identifier. Name of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. VPC Network name. Format: projects/{project}/global/networks/{network}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Optional. This field is not implemented. The values provided in this field are ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("psaRange")]
        public virtual string PsaRange { get; set; }

        /// <summary>Optional. QoS (Quality of Service) Type of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qosType")]
        public virtual string QosType { get; set; }

        /// <summary>Optional. Specifies the replica zone for regional storagePool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaZone")]
        public virtual string ReplicaZone { get; set; }

        /// <summary>Output only. Reserved for future use</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Required. Service level of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLevel")]
        public virtual string ServiceLevel { get; set; }

        /// <summary>Output only. State of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. State details of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>
        /// Optional. Custom Performance Total IOPS of the pool if not provided, it will be calculated based on the
        /// total_throughput_mibps
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalIops")]
        public virtual System.Nullable<long> TotalIops { get; set; }

        /// <summary>Optional. Custom Performance Total Throughput of the pool (in MiBps)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalThroughputMibps")]
        public virtual System.Nullable<long> TotalThroughputMibps { get; set; }

        /// <summary>Output only. Allocated size of all volumes in GIB in the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeCapacityGib")]
        public virtual System.Nullable<long> VolumeCapacityGib { get; set; }

        /// <summary>Output only. Volume count of the storage pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeCount")]
        public virtual System.Nullable<int> VolumeCount { get; set; }

        /// <summary>Optional. Specifies the active zone for regional storagePool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SwitchActiveReplicaZoneRequest switch the active/replica zone for a regional storagePool.</summary>
    public class SwitchActiveReplicaZoneRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SyncReplicationRequest syncs the replication from source to destination.</summary>
    public class SyncReplicationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines tiering policy for the volume.</summary>
    public class TieringPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Time in days to mark the volume's data block as cold and make it eligible for tiering, can be
        /// range from 2-183. Default is 31.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coolingThresholdDays")]
        public virtual System.Nullable<int> CoolingThresholdDays { get; set; }

        /// <summary>
        /// Optional. Flag indicating that the hot tier bypass mode is enabled. Default is false. This is only
        /// applicable to Flex service level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotTierBypassModeEnabled")]
        public virtual System.Nullable<bool> HotTierBypassModeEnabled { get; set; }

        /// <summary>
        /// Optional. Flag indicating if the volume has tiering policy enable/pause. Default is PAUSED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tierAction")]
        public virtual string TierAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TransferStats reports all statistics related to replication transfer.</summary>
    public class TransferStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Lag duration indicates the duration by which Destination region volume content lags behind the primary
        /// region volume content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lagDuration")]
        public virtual object LagDuration { get; set; }

        /// <summary>Last transfer size in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransferBytes")]
        public virtual System.Nullable<long> LastTransferBytes { get; set; }

        /// <summary>Time taken during last transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransferDuration")]
        public virtual object LastTransferDuration { get; set; }

        private string _lastTransferEndTimeRaw;

        private object _lastTransferEndTime;

        /// <summary>Time when last transfer completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransferEndTime")]
        public virtual string LastTransferEndTimeRaw
        {
            get => _lastTransferEndTimeRaw;
            set
            {
                _lastTransferEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastTransferEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastTransferEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastTransferEndTimeDateTimeOffset instead.")]
        public virtual object LastTransferEndTime
        {
            get => _lastTransferEndTime;
            set
            {
                _lastTransferEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastTransferEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastTransferEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastTransferEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastTransferEndTimeRaw);
            set => LastTransferEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A message describing the cause of the last transfer failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransferError")]
        public virtual string LastTransferError { get; set; }

        /// <summary>Cumulative time taken across all transfers for the replication relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalTransferDuration")]
        public virtual object TotalTransferDuration { get; set; }

        /// <summary>Cumulative bytes transferred so far for the replication relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferBytes")]
        public virtual System.Nullable<long> TransferBytes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Time when progress was updated last.</summary>
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

    /// <summary>UserCommands contains the commands to be executed by the customer.</summary>
    public class UserCommands : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of commands to be executed by the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<string> Commands { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ValidateDirectoryServiceRequest validates the directory service policy attached to the storage pool.
    /// </summary>
    public class ValidateDirectoryServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of directory service policy attached to the storage pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directoryServiceType")]
        public virtual string DirectoryServiceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VerifyKmsConfigRequest specifies the KMS config to be validated.</summary>
    public class VerifyKmsConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VerifyKmsConfigResponse contains the information if the config is correctly and error message.
    /// </summary>
    public class VerifyKmsConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Error message if config is not healthy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthError")]
        public virtual string HealthError { get; set; }

        /// <summary>Output only. If the customer key configured correctly to the encrypt volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthy")]
        public virtual System.Nullable<bool> Healthy { get; set; }

        /// <summary>Output only. Instructions for the customers to provide the access to the encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual string Instructions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Volume provides a filesystem that you can mount.</summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Specifies the ActiveDirectory name of a SMB volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDirectory")]
        public virtual string ActiveDirectory { get; set; }

        /// <summary>BackupConfig of the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfig")]
        public virtual BackupConfig BackupConfig { get; set; }

        /// <summary>Required. Capacity in GIB of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGib")]
        public virtual System.Nullable<long> CapacityGib { get; set; }

        /// <summary>Output only. Size of the volume cold tier data rounded down to the nearest GiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coldTierSizeGib")]
        public virtual System.Nullable<long> ColdTierSizeGib { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time of the volume</summary>
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

        /// <summary>Optional. Description of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Specified the current volume encryption key source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>Optional. Export policy of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportPolicy")]
        public virtual ExportPolicy ExportPolicy { get; set; }

        /// <summary>Output only. Indicates whether the volume is part of a replication relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasReplication")]
        public virtual System.Nullable<bool> HasReplication { get; set; }

        /// <summary>Optional. The Hybrid Replication parameters for the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridReplicationParameters")]
        public virtual HybridReplicationParameters HybridReplicationParameters { get; set; }

        /// <summary>
        /// Optional. Flag indicating if the volume is a kerberos volume or not, export policy rules control kerberos
        /// security modes (krb5, krb5i, krb5p).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kerberosEnabled")]
        public virtual System.Nullable<bool> KerberosEnabled { get; set; }

        /// <summary>Output only. Specifies the KMS config to be used for volume encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsConfig")]
        public virtual string KmsConfig { get; set; }

        /// <summary>Optional. Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Flag indicating if the volume will be a large capacity volume or a regular volume.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeCapacity")]
        public virtual System.Nullable<bool> LargeCapacity { get; set; }

        /// <summary>Output only. Flag indicating if the volume is NFS LDAP enabled or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ldapEnabled")]
        public virtual System.Nullable<bool> LdapEnabled { get; set; }

        /// <summary>Output only. Mount options of this volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountOptions")]
        public virtual System.Collections.Generic.IList<MountOption> MountOptions { get; set; }

        /// <summary>
        /// Optional. Flag indicating if the volume will have an IP address per node for volumes supporting multiple IP
        /// endpoints. Only the volume with large_capacity will be allowed to have multiple endpoints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleEndpoints")]
        public virtual System.Nullable<bool> MultipleEndpoints { get; set; }

        /// <summary>Identifier. Name of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. VPC Network name. Format: projects/{project}/global/networks/{network}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Required. Protocols required for the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocols")]
        public virtual System.Collections.Generic.IList<string> Protocols { get; set; }

        /// <summary>
        /// Output only. This field is not implemented. The values provided in this field are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("psaRange")]
        public virtual string PsaRange { get; set; }

        /// <summary>Output only. Specifies the replica zone for regional volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaZone")]
        public virtual string ReplicaZone { get; set; }

        /// <summary>Optional. Specifies the source of the volume to be created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreParameters")]
        public virtual RestoreParameters RestoreParameters { get; set; }

        /// <summary>Optional. List of actions that are restricted on this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedActions")]
        public virtual System.Collections.Generic.IList<string> RestrictedActions { get; set; }

        /// <summary>Optional. Security Style of the Volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityStyle")]
        public virtual string SecurityStyle { get; set; }

        /// <summary>Output only. Service level of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLevel")]
        public virtual string ServiceLevel { get; set; }

        /// <summary>Required. Share name of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareName")]
        public virtual string ShareName { get; set; }

        /// <summary>Optional. SMB share settings for the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smbSettings")]
        public virtual System.Collections.Generic.IList<string> SmbSettings { get; set; }

        /// <summary>
        /// Optional. Snap_reserve specifies percentage of volume storage reserved for snapshot storage. Default is 0
        /// percent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapReserve")]
        public virtual System.Nullable<double> SnapReserve { get; set; }

        /// <summary>
        /// Optional. Snapshot_directory if enabled (true) the volume will contain a read-only .snapshot directory which
        /// provides access to each of the volume's snapshots.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotDirectory")]
        public virtual System.Nullable<bool> SnapshotDirectory { get; set; }

        /// <summary>Optional. SnapshotPolicy for a volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotPolicy")]
        public virtual SnapshotPolicy SnapshotPolicy { get; set; }

        /// <summary>Output only. State of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. State details of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDetails")]
        public virtual string StateDetails { get; set; }

        /// <summary>Required. StoragePool name of the volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePool")]
        public virtual string StoragePool { get; set; }

        /// <summary>Optional. Throughput of the volume (in MiB/s)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("throughputMibps")]
        public virtual System.Nullable<double> ThroughputMibps { get; set; }

        /// <summary>Tiering policy for the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tieringPolicy")]
        public virtual TieringPolicy TieringPolicy { get; set; }

        /// <summary>
        /// Optional. Default unix style permission (e.g. 777) the mount point will be created with. Applicable for NFS
        /// protocol types only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unixPermissions")]
        public virtual string UnixPermissions { get; set; }

        /// <summary>
        /// Output only. Used capacity in GIB of the volume. This is computed periodically and it does not represent the
        /// realtime usage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedGib")]
        public virtual System.Nullable<long> UsedGib { get; set; }

        /// <summary>Output only. Specifies the active zone for regional volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Make a snapshot every week e.g. at Monday 04:00, Wednesday 05:20, Sunday 23:50</summary>
    public class WeeklySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set the day or days of the week to make a snapshot. Accepts a comma separated days of the week. Defaults to
        /// 'Sunday'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Set the hour to start the snapshot (0-23), defaults to midnight (0).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<double> Hour { get; set; }

        /// <summary>
        /// Set the minute of the hour to start the snapshot (0-59), defaults to the top of the hour (0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minute")]
        public virtual System.Nullable<double> Minute { get; set; }

        /// <summary>The maximum number of Snapshots to keep for the hourly schedule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotsToKeep")]
        public virtual System.Nullable<double> SnapshotsToKeep { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
