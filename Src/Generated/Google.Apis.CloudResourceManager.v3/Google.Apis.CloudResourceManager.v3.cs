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

namespace Google.Apis.CloudResourceManager.v3
{
    /// <summary>The CloudResourceManager Service.</summary>
    public class CloudResourceManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudResourceManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudResourceManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Liens = new LiensResource(this);
            Operations = new OperationsResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            TagBindings = new TagBindingsResource(this);
            TagKeys = new TagKeysResource(this);
            TagValues = new TagValuesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudresourcemanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudresourcemanager.googleapis.com/";
        #else
            "https://cloudresourcemanager.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudresourcemanager.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Resource Manager API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Resource Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Liens resource.</summary>
        public virtual LiensResource Liens { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the TagBindings resource.</summary>
        public virtual TagBindingsResource TagBindings { get; }

        /// <summary>Gets the TagKeys resource.</summary>
        public virtual TagKeysResource TagKeys { get; }

        /// <summary>Gets the TagValues resource.</summary>
        public virtual TagValuesResource TagValues { get; }
    }

    /// <summary>A base abstract class for CloudResourceManager requests.</summary>
    public abstract class CloudResourceManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudResourceManagerBaseServiceRequest instance.</summary>
        protected CloudResourceManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudResourceManager parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a folder in the resource hierarchy. Returns an `Operation` which can be used to track the progress
        /// of the folder creation workflow. Upon success, the `Operation.response` field will be populated with the
        /// created Folder. In order to succeed, the addition of this new folder must not violate the folder naming,
        /// height, or fanout constraints. + The folder's `display_name` must be distinct from all other folders that
        /// share its parent. + The addition of the folder must not cause the active folder hierarchy to exceed a height
        /// of 10. Note, the full active + deleted folder hierarchy is allowed to reach a height of 20; this provides
        /// additional headroom when moving folders that contain deleted folders. + The addition of the folder must not
        /// cause the total number of folders under its parent to exceed 300. If the operation fails due to a folder
        /// constraint violation, some errors may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint violations will be communicated in
        /// the `Operation`, with the specific `PreconditionFailure` returned in the details list in the
        /// `Operation.error` field. The caller must have `resourcemanager.folders.create` permission on the identified
        /// parent.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v3.Data.Folder body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a folder in the resource hierarchy. Returns an `Operation` which can be used to track the progress
        /// of the folder creation workflow. Upon success, the `Operation.response` field will be populated with the
        /// created Folder. In order to succeed, the addition of this new folder must not violate the folder naming,
        /// height, or fanout constraints. + The folder's `display_name` must be distinct from all other folders that
        /// share its parent. + The addition of the folder must not cause the active folder hierarchy to exceed a height
        /// of 10. Note, the full active + deleted folder hierarchy is allowed to reach a height of 20; this provides
        /// additional headroom when moving folders that contain deleted folders. + The addition of the folder must not
        /// cause the total number of folders under its parent to exceed 300. If the operation fails due to a folder
        /// constraint violation, some errors may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint violations will be communicated in
        /// the `Operation`, with the specific `PreconditionFailure` returned in the details list in the
        /// `Operation.error` field. The caller must have `resourcemanager.folders.create` permission on the identified
        /// parent.
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.Folder body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.Folder Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/folders";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the DELETE_REQUESTED state immediately, and is
        /// deleted approximately 30 days later. This method may only be called on an empty folder, where a folder is
        /// empty if it doesn't contain any folders or projects in the ACTIVE state. If called on a folder in
        /// DELETE_REQUESTED state the operation will result in a no-op success. The caller must have
        /// `resourcemanager.folders.delete` permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to be deleted. Must be of the form `folders/{folder_id}`.
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the DELETE_REQUESTED state immediately, and is
        /// deleted approximately 30 days later. This method may only be called on an empty folder, where a folder is
        /// empty if it doesn't contain any folders or projects in the ACTIVE state. If called on a folder in
        /// DELETE_REQUESTED state the operation will result in a no-op success. The caller must have
        /// `resourcemanager.folders.delete` permission on the identified folder.
        /// </summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the folder to be deleted. Must be of the form `folders/{folder_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name. Valid folder resource names have the format
        /// `folders/{folder_id}` (for example, `folders/1234`). The caller must have `resourcemanager.folders.get`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to retrieve. Must be of the form `folders/{folder_id}`.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name. Valid folder resource names have the format
        /// `folders/{folder_id}` (for example, `folders/1234`). The caller must have `resourcemanager.folders.get`
        /// permission on the identified folder.
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Folder>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the folder to retrieve. Must be of the form `folders/{folder_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be empty if no such policy or resource
        /// exists. The `resource` field should be the folder's resource name, for example: "folders/1234". The caller
        /// must have `resourcemanager.folders.getIamPolicy` permission on the identified folder.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be empty if no such policy or resource
        /// exists. The `resource` field should be the folder's resource name, for example: "folders/1234". The caller
        /// must have `resourcemanager.folders.getIamPolicy` permission on the identified folder.
        /// </summary>
        public class GetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:getIamPolicy";

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
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource. `list()` provides a strongly
        /// consistent view of the folders underneath the specified parent resource. `list()` returns folders sorted
        /// based upon the (ascending) lexical ordering of their display_name. The caller must have
        /// `resourcemanager.folders.list` permission on the identified parent.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource. `list()` provides a strongly
        /// consistent view of the folders underneath the specified parent resource. `list()` returns folders sorted
        /// based upon the (ascending) lexical ordering of their display_name. The caller must have
        /// `resourcemanager.folders.list` permission on the identified parent.
        /// </summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.ListFoldersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of folders to return in the response. If unspecified, server picks an
            /// appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to `ListFolders` that indicates where this
            /// listing should continue from.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The resource name of the organization or folder whose folders are being listed. Must be of the
            /// form `folders/{folder_id}` or `organizations/{org_id}`. Access to this method is controlled by checking
            /// the `resourcemanager.folders.list` permission on the `parent`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>
            /// Optional. Controls whether folders in the DELETE_REQUESTED state should be returned. Defaults to false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/folders";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>
        /// Moves a folder under a new resource parent. Returns an `Operation` which can be used to track the progress
        /// of the folder move workflow. Upon success, the `Operation.response` field will be populated with the moved
        /// folder. Upon failure, a `FolderOperationError` categorizing the failure cause will be returned - if the
        /// failure occurs synchronously then the `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned in the `Operation.error` field. In
        /// addition, the `Operation.metadata` field will be populated with a `FolderOperation` message as an aid to
        /// stateless clients. Folder moves will be rejected if they violate either the naming, height, or fanout
        /// constraints described in the CreateFolder documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of the Folder to move. Must be of the form folders/{folder_id}
        /// </param>
        public virtual MoveRequest Move(Google.Apis.CloudResourceManager.v3.Data.MoveFolderRequest body, string name)
        {
            return new MoveRequest(service, body, name);
        }

        /// <summary>
        /// Moves a folder under a new resource parent. Returns an `Operation` which can be used to track the progress
        /// of the folder move workflow. Upon success, the `Operation.response` field will be populated with the moved
        /// folder. Upon failure, a `FolderOperationError` categorizing the failure cause will be returned - if the
        /// failure occurs synchronously then the `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned in the `Operation.error` field. In
        /// addition, the `Operation.metadata` field will be populated with a `FolderOperation` message as an aid to
        /// stateless clients. Folder moves will be rejected if they violate either the naming, height, or fanout
        /// constraints described in the CreateFolder documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        public class MoveRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Move request.</summary>
            public MoveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.MoveFolderRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the Folder to move. Must be of the form folders/{folder_id}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.MoveFolderRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "move";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}:move";

            /// <summary>Initializes Move parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates a folder, changing its `display_name`. Changes to the folder `display_name` will be rejected if they
        /// violate either the `display_name` formatting rules or the naming constraints described in the CreateFolder
        /// documentation. The folder's `display_name` must start and end with a letter or digit, may contain letters,
        /// digits, spaces, hyphens and underscores and can be between 3 and 30 characters. This is captured by the
        /// regular expression: `\p{L}\p{N}{1,28}[\p{L}\p{N}]`. The caller must have `resourcemanager.folders.update`
        /// permission on the identified folder. If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned in the Status.details field.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. The resource name of the folder. Its format is `folders/{folder_id}`, for example:
        /// "folders/1234".
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.CloudResourceManager.v3.Data.Folder body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>
        /// Updates a folder, changing its `display_name`. Changes to the folder `display_name` will be rejected if they
        /// violate either the `display_name` formatting rules or the naming constraints described in the CreateFolder
        /// documentation. The folder's `display_name` must start and end with a letter or digit, may contain letters,
        /// digits, spaces, hyphens and underscores and can be between 3 and 30 characters. This is captured by the
        /// regular expression: `\p{L}\p{N}{1,28}[\p{L}\p{N}]`. The caller must have `resourcemanager.folders.update`
        /// permission on the identified folder. If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned in the Status.details field.
        /// </summary>
        public class PatchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.Folder body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. The resource name of the folder. Its format is `folders/{folder_id}`, for example:
            /// "folders/1234".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. Fields to be updated. Only the `display_name` can be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.Folder Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^folders/[^/]+$",
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
        /// Search for folders that match specific filter criteria. `search()` provides an eventually consistent view of
        /// the folders a user has access to which meet the specified filter criteria. This will only return folders on
        /// which the caller has the permission `resourcemanager.folders.get`.
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// Search for folders that match specific filter criteria. `search()` provides an eventually consistent view of
        /// the folders a user has access to which meet the specified filter criteria. This will only return folders on
        /// which the caller has the permission `resourcemanager.folders.get`.
        /// </summary>
        public class SearchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.SearchFoldersResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of folders to return in the response. If unspecified, server picks an
            /// appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to `SearchFolders` that indicates from where
            /// search should continue.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. Search criteria used to select the folders to return. If no search criteria is specified then
            /// all accessible folders will be returned. Query expressions can be used to restrict results based upon
            /// displayName, state and parent, where the operators `=` (`:`) `NOT`, `AND` and `OR` can be used along
            /// with the suffix wildcard symbol `*`. The `displayName` field in a query expression should use escaped
            /// quotes for values that include whitespace to prevent unexpected behavior. | Field | Description |
            /// |-------------------------|----------------------------------------| | displayName | Filters by
            /// displayName. | | parent | Filters by parent (for example: folders/123). | | state, lifecycleState |
            /// Filters by state. | Some example queries are: * Query `displayName=Test*` returns Folder resources whose
            /// display name starts with "Test". * Query `state=ACTIVE` returns Folder resources with `state` set to
            /// `ACTIVE`. * Query `parent=folders/123` returns Folder resources that have `folders/123` as a parent
            /// resource. * Query `parent=folders/123 AND state=ACTIVE` returns active Folder resources that have
            /// `folders/123` as a parent resource. * Query `displayName=\\"Test String\\"` returns Folder resources
            /// with display names that include both "Test" and "String".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/folders:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy. The `resource` field should be
        /// the folder's resource name, for example: "folders/1234". The caller must have
        /// `resourcemanager.folders.setIamPolicy` permission on the identified folder.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy. The `resource` field should be
        /// the folder's resource name, for example: "folders/1234". The caller must have
        /// `resourcemanager.folders.setIamPolicy` permission on the identified folder.
        /// </summary>
        public class SetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:setIamPolicy";

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
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified folder. The `resource` field should be the folder's
        /// resource name, for example: "folders/1234". There are no permissions required for making this API call.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified folder. The `resource` field should be the folder's
        /// resource name, for example: "folders/1234". There are no permissions required for making this API call.
        /// </summary>
        public class TestIamPermissionsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:testIamPermissions";

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
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a folder in any state. If the folder
        /// is in the ACTIVE state the result will be a no-op success. In order to succeed, the folder's parent must be
        /// in the ACTIVE state. In addition, reintroducing the folder into the tree must not violate folder naming,
        /// height, and fanout constraints described in the CreateFolder documentation. The caller must have
        /// `resourcemanager.folders.undelete` permission on the identified folder.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of the folder to undelete. Must be of the form `folders/{folder_id}`.
        /// </param>
        public virtual UndeleteRequest Undelete(Google.Apis.CloudResourceManager.v3.Data.UndeleteFolderRequest body, string name)
        {
            return new UndeleteRequest(service, body, name);
        }

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a folder in any state. If the folder
        /// is in the ACTIVE state the result will be a no-op success. In order to succeed, the folder's parent must be
        /// in the ACTIVE state. In addition, reintroducing the folder into the tree must not violate folder naming,
        /// height, and fanout constraints described in the CreateFolder documentation. The caller must have
        /// `resourcemanager.folders.undelete` permission on the identified folder.
        /// </summary>
        public class UndeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.UndeleteFolderRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the folder to undelete. Must be of the form `folders/{folder_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.UndeleteFolderRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}:undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "liens" collection of methods.</summary>
    public class LiensResource
    {
        private const string Resource = "liens";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LiensResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Create a Lien which applies to the resource denoted by the `parent` field. Callers of this method will
        /// require permission on the `parent` resource. For example, applying to `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`. NOTE: Some resources may limit the number of Liens which may be
        /// applied.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v3.Data.Lien body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Create a Lien which applies to the resource denoted by the `parent` field. Callers of this method will
        /// require permission on the `parent` resource. For example, applying to `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`. NOTE: Some resources may limit the number of Liens which may be
        /// applied.
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Lien>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.Lien body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.Lien Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/liens";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Delete a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`.
        /// </summary>
        /// <param name="name">Required. The name/identifier of the Lien to delete.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Delete a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.updateLiens`.
        /// </summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name/identifier of the Lien to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^liens/.*$",
                });
            }
        }

        /// <summary>
        /// Retrieve a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission `resourcemanager.projects.get`
        /// </summary>
        /// <param name="name">Required. The name/identifier of the Lien.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Retrieve a Lien by `name`. Callers of this method will require permission on the `parent` resource. For
        /// example, a Lien with a `parent` of `projects/1234` requires permission `resourcemanager.projects.get`
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Lien>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name/identifier of the Lien.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^liens/.*$",
                });
            }
        }

        /// <summary>
        /// List all Liens applied to the `parent` resource. Callers of this method will require permission on the
        /// `parent` resource. For example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.get`.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// List all Liens applied to the `parent` resource. Callers of this method will require permission on the
        /// `parent` resource. For example, a Lien with a `parent` of `projects/1234` requires permission
        /// `resourcemanager.projects.get`.
        /// </summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.ListLiensResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of items to return. This is a suggestion for the server.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The `next_page_token` value returned from a previous List request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The name of the resource to list all attached Liens. For example, `projects/1234`.
            /// (google.api.field_policy).resource_type annotation is not set since the parent depends on the meta api
            /// implementation. This field could be a project or other sub project resources.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/liens";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
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

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
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
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^operations/.*$",
                });
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Fetches an organization resource identified by the specified resource name.</summary>
        /// <param name="name">
        /// Required. The resource name of the Organization to fetch. This is the organization's relative path in the
        /// API, formatted as "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Fetches an organization resource identified by the specified resource name.</summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Organization>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the Organization to fetch. This is the organization's relative path in
            /// the API, formatted as "organizations/[organizationId]". For example, "organizations/1234".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may be empty if no such policy or
        /// resource exists. The `resource` field should be the organization's resource name, for example:
        /// "organizations/123". Authorization requires the IAM permission `resourcemanager.organizations.getIamPolicy`
        /// on the specified organization.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may be empty if no such policy or
        /// resource exists. The `resource` field should be the organization's resource name, for example:
        /// "organizations/123". Authorization requires the IAM permission `resourcemanager.organizations.getIamPolicy`
        /// on the specified organization.
        /// </summary>
        public class GetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:getIamPolicy";

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
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy the specified filter. This method
        /// returns organizations in an unspecified order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear. Search will only return organizations on which the
        /// user has the permission `resourcemanager.organizations.get`
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy the specified filter. This method
        /// returns organizations in an unspecified order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear. Search will only return organizations on which the
        /// user has the permission `resourcemanager.organizations.get`
        /// </summary>
        public class SearchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.SearchOrganizationsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of organizations to return in the response. If unspecified, server picks an
            /// appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to `SearchOrganizations` that indicates from
            /// where listing should continue.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. An optional query string used to filter the Organizations to return in the response. Query
            /// rules are case-insensitive. | Field | Description |
            /// |------------------|--------------------------------------------| | directoryCustomerId,
            /// owner.directoryCustomerId | Filters by directory customer id. | | domain | Filters by domain. |
            /// Organizations may be queried by `directoryCustomerId` or by `domain`, where the domain is a G Suite
            /// domain, for example: * Query `directorycustomerid:123456789` returns Organization resources with
            /// `owner.directory_customer_id` equal to `123456789`. * Query `domain:google.com` returns Organization
            /// resources corresponding to the domain `google.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/organizations:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any existing policy. The `resource`
        /// field should be the organization's resource name, for example: "organizations/123". Authorization requires
        /// the IAM permission `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any existing policy. The `resource`
        /// field should be the organization's resource name, for example: "organizations/123". Authorization requires
        /// the IAM permission `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        public class SetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:setIamPolicy";

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
                    Pattern = @"^organizations/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization. The `resource` field should be the
        /// organization's resource name, for example: "organizations/123". There are no permissions required for making
        /// this API call.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization. The `resource` field should be the
        /// organization's resource name, for example: "organizations/123". There are no permissions required for making
        /// this API call.
        /// </summary>
        public class TestIamPermissionsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:testIamPermissions";

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
                    Pattern = @"^organizations/[^/]+$",
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
        }

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which can be used to track the creation
        /// process. This process usually takes a few seconds, but can sometimes take much longer. The tracking
        /// `Operation` is automatically deleted after a few hours, so there is no need to call `DeleteOperation`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v3.Data.Project body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which can be used to track the creation
        /// process. This process usually takes a few seconds, but can sometimes take much longer. The tracking
        /// `Operation` is automatically deleted after a few hours, so there is no need to call `DeleteOperation`.
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.Project body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.Project Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/projects";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Marks the project identified by the specified `name` (for example, `projects/415104041262`) for deletion.
        /// This method will only affect the project if it has a lifecycle state of ACTIVE. This method changes the
        /// Project's lifecycle state from ACTIVE to DELETE_REQUESTED. The deletion starts at an unspecified time, at
        /// which point the Project is no longer accessible. Until the deletion completes, you can check the lifecycle
        /// state checked by retrieving the project with GetProject, and the project remains visible to ListProjects.
        /// However, you cannot update the project. After the deletion completes, the project is not retrievable by the
        /// GetProject, ListProjects, and SearchProjects methods. This method behaves idempotently, such that deleting a
        /// `DELETE_REQUESTED` project will not cause an error, but also won't do anything. The caller must have
        /// `resourcemanager.projects.delete` permissions for this project.
        /// </summary>
        /// <param name="name">Required. The name of the Project (for example, `projects/415104041262`).</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Marks the project identified by the specified `name` (for example, `projects/415104041262`) for deletion.
        /// This method will only affect the project if it has a lifecycle state of ACTIVE. This method changes the
        /// Project's lifecycle state from ACTIVE to DELETE_REQUESTED. The deletion starts at an unspecified time, at
        /// which point the Project is no longer accessible. Until the deletion completes, you can check the lifecycle
        /// state checked by retrieving the project with GetProject, and the project remains visible to ListProjects.
        /// However, you cannot update the project. After the deletion completes, the project is not retrievable by the
        /// GetProject, ListProjects, and SearchProjects methods. This method behaves idempotently, such that deleting a
        /// `DELETE_REQUESTED` project will not cause an error, but also won't do anything. The caller must have
        /// `resourcemanager.projects.delete` permissions for this project.
        /// </summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the Project (for example, `projects/415104041262`).</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example, `projects/415104041262`). The caller
        /// must have `resourcemanager.projects.get` permission for this project.
        /// </summary>
        /// <param name="name">Required. The name of the project (for example, `projects/415104041262`).</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example, `projects/415104041262`). The caller
        /// must have `resourcemanager.projects.get` permission for this project.
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Project>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the project (for example, `projects/415104041262`).</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns the IAM access control policy for the specified project. Permission is denied if the policy or the
        /// resource do not exist.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Returns the IAM access control policy for the specified project. Permission is denied if the policy or the
        /// resource do not exist.
        /// </summary>
        public class GetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:getIamPolicy";

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
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists projects that are direct children of the specified folder or organization resource. `list()` provides
        /// a strongly consistent view of the projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their `display_name`. The caller must have
        /// `resourcemanager.projects.list` permission on the identified parent.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists projects that are direct children of the specified folder or organization resource. `list()` provides
        /// a strongly consistent view of the projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their `display_name`. The caller must have
        /// `resourcemanager.projects.list` permission on the identified parent.
        /// </summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.ListProjectsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of projects to return in the response. The server can return fewer projects
            /// than requested. If unspecified, server picks an appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to ListProjects that indicates from where
            /// listing should continue.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The name of the parent resource to list projects under. For example, setting this field to
            /// 'folders/1234' would list all projects directly under that folder.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>
            /// Optional. Indicate that projects in the `DELETE_REQUESTED` state should also be returned. Normally only
            /// `ACTIVE` projects are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/projects";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new resource parent. Returns an
        /// operation which can be used to track the process of the project move workflow. Upon success, the
        /// `Operation.response` field will be populated with the moved project. The caller must have
        /// `resourcemanager.projects.update` permission on the project and have `resourcemanager.projects.move`
        /// permission on the project's current and proposed new parent. If project has no current parent, or it
        /// currently does not have an associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The name of the project to move.</param>
        public virtual MoveRequest Move(Google.Apis.CloudResourceManager.v3.Data.MoveProjectRequest body, string name)
        {
            return new MoveRequest(service, body, name);
        }

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new resource parent. Returns an
        /// operation which can be used to track the process of the project move workflow. Upon success, the
        /// `Operation.response` field will be populated with the moved project. The caller must have
        /// `resourcemanager.projects.update` permission on the project and have `resourcemanager.projects.move`
        /// permission on the project's current and proposed new parent. If project has no current parent, or it
        /// currently does not have an associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        public class MoveRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Move request.</summary>
            public MoveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.MoveProjectRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the project to move.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.MoveProjectRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "move";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}:move";

            /// <summary>Initializes Move parameter list.</summary>
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
            }
        }

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the specified `name` (for example,
        /// `projects/415104041262`). Deleting all labels requires an update mask for labels field. The caller must have
        /// `resourcemanager.projects.update` permission for this project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. The unique resource name of the project. It is an int64 generated number prefixed by
        /// "projects/". Example: `projects/415104041262`
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.CloudResourceManager.v3.Data.Project body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the specified `name` (for example,
        /// `projects/415104041262`). Deleting all labels requires an update mask for labels field. The caller must have
        /// `resourcemanager.projects.update` permission for this project.
        /// </summary>
        public class PatchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.Project body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. The unique resource name of the project. It is an int64 generated number prefixed by
            /// "projects/". Example: `projects/415104041262`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. An update mask to selectively update fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.Project Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^projects/[^/]+$",
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
        /// Search for projects that the caller has both `resourcemanager.projects.get` permission on, and also satisfy
        /// the specified query. This method returns projects in an unspecified order. This method is eventually
        /// consistent with project mutations; this means that a newly created project may not appear in the results or
        /// recent updates to an existing project may not be reflected in the results. To retrieve the latest state of a
        /// project, use the GetProject method.
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// Search for projects that the caller has both `resourcemanager.projects.get` permission on, and also satisfy
        /// the specified query. This method returns projects in an unspecified order. This method is eventually
        /// consistent with project mutations; this means that a newly created project may not appear in the results or
        /// recent updates to an existing project may not be reflected in the results. To retrieve the latest state of a
        /// project, use the GetProject method.
        /// </summary>
        public class SearchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.SearchProjectsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of projects to return in the response. The server can return fewer projects
            /// than requested. If unspecified, server picks an appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to ListProjects that indicates from where
            /// listing should continue.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. A query string for searching for projects that the caller has `resourcemanager.projects.get`
            /// permission to. If multiple fields are included in the query, the it will return results that match any
            /// of the fields. Some eligible fields are: | Field | Description |
            /// |-------------------------|----------------------------------------------| | displayName, name | Filters
            /// by displayName. | | parent | Project's parent (for example: folders/123, organizations/*). Prefer parent
            /// field over parent.type and parent.id.| | parent.type | Parent's type: `folder` or `organization`. | |
            /// parent.id | Parent's id number (for example: 123) | | id, projectId | Filters by projectId. | | state,
            /// lifecycleState | Filters by state. | | labels | Filters by label name or value. | | labels.\ (where
            /// *key* is the name of a label) | Filters by label name.| Search expressions are case insensitive. Some
            /// examples queries: | Query | Description |
            /// |------------------|-----------------------------------------------------| | name:how* | The project's
            /// name starts with "how". | | name:Howl | The project's name is `Howl` or `howl`. | | name:HOWL |
            /// Equivalent to above. | | NAME:howl | Equivalent to above. | | labels.color:* | The project has the label
            /// `color`. | | labels.color:red | The project's label `color` has the value `red`. | | labels.color:red
            /// labels.size:big | The project's label `color` has the value `red` and its label `size` has the value
            /// `big`.| If no query is specified, the call will return projects for which the user has the
            /// `resourcemanager.projects.get` permission.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/projects:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Sets the IAM access control policy for the specified project. CAUTION: This method will replace the existing
        /// policy, and cannot be used to append additional IAM settings. Note: Removing service accounts from policies
        /// or changing their roles can render services completely inoperable. It is important to understand how the
        /// service account is being used before removing or updating its roles. The following constraints apply when
        /// using `setIamPolicy()`: + Project does not support `allUsers` and `allAuthenticatedUsers` as `members` in a
        /// `Binding` of a `Policy`. + The owner role can be granted to a `user`, `serviceAccount`, or a group that is
        /// part of an organization. For example, group@myownpersonaldomain.com could be added as an owner to a project
        /// in the myownpersonaldomain.com organization, but not the examplepetstore.com organization. + Service
        /// accounts can be made owners of a project directly without any restrictions. However, to be added as an
        /// owner, a user must be invited using the Cloud Platform console and must accept the invitation. + A user
        /// cannot be granted the owner role using `setIamPolicy()`. The user must be granted the owner role using the
        /// Cloud Platform Console and must explicitly accept the invitation. + Invitations to grant the owner role
        /// cannot be sent using `setIamPolicy()`; they must be sent only using the Cloud Platform Console. + Membership
        /// changes that leave the project without any owners that have accepted the Terms of Service (ToS) will be
        /// rejected. + If the project is not part of an organization, there must be at least one owner who has accepted
        /// the Terms of Service (ToS) agreement in the policy. Calling `setIamPolicy()` to remove the last ToS-accepted
        /// owner from the policy will fail. This restriction also applies to legacy projects that no longer have owners
        /// who have accepted the ToS. Edits to IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. + Calling this method requires enabling the App Engine Admin API.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the IAM access control policy for the specified project. CAUTION: This method will replace the existing
        /// policy, and cannot be used to append additional IAM settings. Note: Removing service accounts from policies
        /// or changing their roles can render services completely inoperable. It is important to understand how the
        /// service account is being used before removing or updating its roles. The following constraints apply when
        /// using `setIamPolicy()`: + Project does not support `allUsers` and `allAuthenticatedUsers` as `members` in a
        /// `Binding` of a `Policy`. + The owner role can be granted to a `user`, `serviceAccount`, or a group that is
        /// part of an organization. For example, group@myownpersonaldomain.com could be added as an owner to a project
        /// in the myownpersonaldomain.com organization, but not the examplepetstore.com organization. + Service
        /// accounts can be made owners of a project directly without any restrictions. However, to be added as an
        /// owner, a user must be invited using the Cloud Platform console and must accept the invitation. + A user
        /// cannot be granted the owner role using `setIamPolicy()`. The user must be granted the owner role using the
        /// Cloud Platform Console and must explicitly accept the invitation. + Invitations to grant the owner role
        /// cannot be sent using `setIamPolicy()`; they must be sent only using the Cloud Platform Console. + Membership
        /// changes that leave the project without any owners that have accepted the Terms of Service (ToS) will be
        /// rejected. + If the project is not part of an organization, there must be at least one owner who has accepted
        /// the Terms of Service (ToS) agreement in the policy. Calling `setIamPolicy()` to remove the last ToS-accepted
        /// owner from the policy will fail. This restriction also applies to legacy projects that no longer have owners
        /// who have accepted the ToS. Edits to IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. + Calling this method requires enabling the App Engine Admin API.
        /// </summary>
        public class SetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:setIamPolicy";

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
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>Returns permissions that a caller has on the specified project.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>Returns permissions that a caller has on the specified project.</summary>
        public class TestIamPermissionsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:testIamPermissions";

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
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Restores the project identified by the specified `name` (for example, `projects/415104041262`). You can only
        /// use this method for a project that has a lifecycle state of DELETE_REQUESTED. After deletion starts, the
        /// project cannot be restored. The caller must have `resourcemanager.projects.undelete` permission for this
        /// project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`). Required.
        /// </param>
        public virtual UndeleteRequest Undelete(Google.Apis.CloudResourceManager.v3.Data.UndeleteProjectRequest body, string name)
        {
            return new UndeleteRequest(service, body, name);
        }

        /// <summary>
        /// Restores the project identified by the specified `name` (for example, `projects/415104041262`). You can only
        /// use this method for a project that has a lifecycle state of DELETE_REQUESTED. After deletion starts, the
        /// project cannot be restored. The caller must have `resourcemanager.projects.undelete` permission for this
        /// project.
        /// </summary>
        public class UndeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.UndeleteProjectRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the project (for example, `projects/415104041262`). Required.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.UndeleteProjectRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}:undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
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
            }
        }
    }

    /// <summary>The "tagBindings" collection of methods.</summary>
    public class TagBindingsResource
    {
        private const string Resource = "tagBindings";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TagBindingsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a TagBinding between a TagValue and a cloud resource (currently project, folder, or organization).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v3.Data.TagBinding body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a TagBinding between a TagValue and a cloud resource (currently project, folder, or organization).
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TagBinding body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. Set to true to perform the validations necessary for creating the resource, but not actually
            /// perform the action.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TagBinding Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/tagBindings";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary>Deletes a TagBinding.</summary>
        /// <param name="name">
        /// Required. The name of the TagBinding. This is a String of the form: `tagBindings/{id}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes a TagBinding.</summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the TagBinding. This is a String of the form: `tagBindings/{id}` (e.g.
            /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^tagBindings/.*$",
                });
            }
        }

        /// <summary>
        /// Lists the TagBindings for the given cloud resource, as specified with `parent`. NOTE: The `parent` field is
        /// expected to be a full resource name: https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists the TagBindings for the given cloud resource, as specified with `parent`. NOTE: The `parent` field is
        /// expected to be a full resource name: https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.ListTagBindingsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of TagBindings to return in the response. The server allows a maximum of
            /// 300 TagBindings to return. If unspecified, the server will use 100 as the default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to `ListTagBindings` that indicates where
            /// this listing should continue from.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The full resource name of a resource for which you want to list existing TagBindings. E.g.
            /// "//cloudresourcemanager.googleapis.com/projects/123"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/tagBindings";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "tagKeys" collection of methods.</summary>
    public class TagKeysResource
    {
        private const string Resource = "tagKeys";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TagKeysResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is sent while the original request is in
        /// process, the second request will receive an error. A maximum of 300 TagKeys can exist under a parent at any
        /// given time.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v3.Data.TagKey body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is sent while the original request is in
        /// process, the second request will receive an error. A maximum of 300 TagKeys can exist under a parent at any
        /// given time.
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TagKey body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. Set to true to perform validations necessary for creating the resource, but not actually
            /// perform the action.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TagKey Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/tagKeys";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary>Deletes a TagKey. The TagKey cannot be deleted if it has any child TagValues.</summary>
        /// <param name="name">
        /// Required. The resource name of a TagKey to be deleted in the format `tagKeys/123`. The TagKey cannot be a
        /// parent of any existing TagValues or it will not be deleted successfully.
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes a TagKey. The TagKey cannot be deleted if it has any child TagValues.</summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of a TagKey to be deleted in the format `tagKeys/123`. The TagKey cannot be
            /// a parent of any existing TagValues or it will not be deleted successfully.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. The etag known to the client for the expected state of the TagKey. This is to be used for
            /// optimistic concurrency.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Etag { get; set; }

            /// <summary>
            /// Optional. Set as true to perform validations necessary for deletion, but not actually perform the
            /// action.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^tagKeys/[^/]+$",
                });
                RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                {
                    Name = "etag",
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
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the key does not exist or the user does
        /// not have permission to view it.
        /// </summary>
        /// <param name="name">Required. A resource name in the format `tagKeys/{id}`, such as `tagKeys/123`.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the key does not exist or the user does
        /// not have permission to view it.
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.TagKey>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. A resource name in the format `tagKeys/{id}`, such as `tagKeys/123`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^tagKeys/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be empty if no such policy or resource
        /// exists. The `resource` field should be the TagKey's resource name. For example, "tagKeys/1234". The caller
        /// must have `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on the specified TagKey.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be empty if no such policy or resource
        /// exists. The `resource` field should be the TagKey's resource name. For example, "tagKeys/1234". The caller
        /// must have `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on the specified TagKey.
        /// </summary>
        public class GetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:getIamPolicy";

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
                    Pattern = @"^tagKeys/[^/]+$",
                });
            }
        }

        /// <summary>Lists all TagKeys for a parent resource.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all TagKeys for a parent resource.</summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.ListTagKeysResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of TagKeys to return in the response. The server allows a maximum of 300
            /// TagKeys to return. If unspecified, the server will use 100 as the default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to `ListTagKey` that indicates where this
            /// listing should continue from.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. The resource name of the new TagKey's parent. Must be of the form `folders/{folder_id}` or
            /// `organizations/{org_id}`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/tagKeys";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the attributes of the TagKey resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Immutable. The resource name for a TagKey. Must be in the format `tagKeys/{tag_key_id}`, where `tag_key_id`
        /// is the generated numeric id for the TagKey.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.CloudResourceManager.v3.Data.TagKey body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates the attributes of the TagKey resource.</summary>
        public class PatchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TagKey body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Immutable. The resource name for a TagKey. Must be in the format `tagKeys/{tag_key_id}`, where
            /// `tag_key_id` is the generated numeric id for the TagKey.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Fields to be updated. The mask may only contain `description` or `etag`. If omitted entirely, both
            /// `description` and `etag` are assumed to be significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>
            /// Set as true to perform validations necessary for updating the resource, but not actually perform the
            /// action.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TagKey Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^tagKeys/[^/]+$",
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
        /// Sets the access control policy on a TagKey, replacing any existing policy. The `resource` field should be
        /// the TagKey's resource name. For example, "tagKeys/1234". The caller must have
        /// `resourcemanager.tagKeys.setIamPolicy` permission on the identified tagValue.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing policy. The `resource` field should be
        /// the TagKey's resource name. For example, "tagKeys/1234". The caller must have
        /// `resourcemanager.tagKeys.setIamPolicy` permission on the identified tagValue.
        /// </summary>
        public class SetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:setIamPolicy";

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
                    Pattern = @"^tagKeys/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey. The `resource` field should be the TagKey's
        /// resource name. For example, "tagKeys/1234". There are no permissions required for making this API call.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey. The `resource` field should be the TagKey's
        /// resource name. For example, "tagKeys/1234". There are no permissions required for making this API call.
        /// </summary>
        public class TestIamPermissionsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:testIamPermissions";

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
                    Pattern = @"^tagKeys/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "tagValues" collection of methods.</summary>
    public class TagValuesResource
    {
        private const string Resource = "tagValues";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TagValuesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another request with the same parameters is sent
        /// while the original request is in process the second request will receive an error. A maximum of 300
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudResourceManager.v3.Data.TagValue body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another request with the same parameters is sent
        /// while the original request is in process the second request will receive an error. A maximum of 300
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        public class CreateRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TagValue body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. Set as true to perform the validations necessary for creating the resource, but not actually
            /// perform the action.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TagValue Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/tagValues";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

        /// <summary>Deletes a TagValue. The TagValue cannot have any bindings when it is deleted.</summary>
        /// <param name="name">Required. Resource name for TagValue to be deleted in the format tagValues/456.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes a TagValue. The TagValue cannot have any bindings when it is deleted.</summary>
        public class DeleteRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Resource name for TagValue to be deleted in the format tagValues/456.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. The etag known to the client for the expected state of the TagValue. This is to be used for
            /// optimistic concurrency.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Etag { get; set; }

            /// <summary>
            /// Optional. Set as true to perform the validations necessary for deletion, but not actually perform the
            /// action.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^tagValues/[^/]+$",
                });
                RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                {
                    Name = "etag",
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
        /// Retrieves TagValue. If the TagValue or namespaced name does not exist, or if the user does not have
        /// permission to view it, this method will return `PERMISSION_DENIED`.
        /// </summary>
        /// <param name="name">Required. Resource name for TagValue to be fetched in the format `tagValues/456`.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Retrieves TagValue. If the TagValue or namespaced name does not exist, or if the user does not have
        /// permission to view it, this method will return `PERMISSION_DENIED`.
        /// </summary>
        public class GetRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.TagValue>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Resource name for TagValue to be fetched in the format `tagValues/456`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^tagValues/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for a TagValue. The returned policy may be empty if no such policy or
        /// resource exists. The `resource` field should be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on the
        /// identified TagValue to get the access control policy.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a TagValue. The returned policy may be empty if no such policy or
        /// resource exists. The `resource` field should be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on the
        /// identified TagValue to get the access control policy.
        /// </summary>
        public class GetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:getIamPolicy";

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
                    Pattern = @"^tagValues/[^/]+$",
                });
            }
        }

        /// <summary>Lists all TagValues for a specific TagKey.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all TagValues for a specific TagKey.</summary>
        public class ListRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.ListTagValuesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The maximum number of TagValues to return in the response. The server allows a maximum of 300
            /// TagValues to return. If unspecified, the server will use 100 as the default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A pagination token returned from a previous call to `ListTagValues` that indicates where this
            /// listing should continue from.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. Resource name for TagKey, parent of the TagValues to be listed, in the format `tagKeys/123`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/tagValues";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the attributes of the TagValue resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Immutable. Resource name for TagValue in the format `tagValues/456`.</param>
        public virtual PatchRequest Patch(Google.Apis.CloudResourceManager.v3.Data.TagValue body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates the attributes of the TagValue resource.</summary>
        public class PatchRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TagValue body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Immutable. Resource name for TagValue in the format `tagValues/456`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. Fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>
            /// Optional. True to perform validations necessary for updating the resource, but not actually perform the
            /// action.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ValidateOnly { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TagValue Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^tagValues/[^/]+$",
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
        /// Sets the access control policy on a TagValue, replacing any existing policy. The `resource` field should be
        /// the TagValue's resource name. For example: `tagValues/1234`. The caller must have
        /// `resourcemanager.tagValues.setIamPolicy` permission on the identified tagValue.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on a TagValue, replacing any existing policy. The `resource` field should be
        /// the TagValue's resource name. For example: `tagValues/1234`. The caller must have
        /// `resourcemanager.tagValues.setIamPolicy` permission on the identified tagValue.
        /// </summary>
        public class SetIamPolicyRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:setIamPolicy";

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
                    Pattern = @"^tagValues/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified TagValue. The `resource` field should be the
        /// TagValue's resource name. For example: `tagValues/1234`. There are no permissions required for making this
        /// API call.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified TagValue. The `resource` field should be the
        /// TagValue's resource name. For example: `tagValues/1234`. There are no permissions required for making this
        /// API call.
        /// </summary>
        public class TestIamPermissionsRequest : CloudResourceManagerBaseServiceRequest<Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudResourceManager.v3.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+resource}:testIamPermissions";

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
                    Pattern = @"^tagValues/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.CloudResourceManager.v3.Data
{
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
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
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

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing a long running folder operation</summary>
    public class CloudresourcemanagerGoogleCloudResourcemanagerV2alpha1FolderOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the folder or organization we are either creating the folder under or moving the folder
        /// to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The type of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// The resource name of the folder's parent. Only applicable when the operation_type is MOVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing a long running folder operation</summary>
    public class CloudresourcemanagerGoogleCloudResourcemanagerV2beta1FolderOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the folder or organization we are either creating the folder under or moving the folder
        /// to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The type of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// The resource name of the folder's parent. Only applicable when the operation_type is MOVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata pertaining to the Folder creation process.</summary>
    public class CreateFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the folder or organization we are creating the folder under.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by CreateProject. It provides
    /// insight for when significant phases of Project creation have completed.
    /// </summary>
    public class CreateProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time of the project creation workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// True if the project can be retrieved using `GetProject`. No other operations on the project are guaranteed
        /// to work until the project creation is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gettable")]
        public virtual System.Nullable<bool> Gettable { get; set; }

        /// <summary>True if the project creation process is complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ready")]
        public virtual System.Nullable<bool> Ready { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for creating a TagValue.</summary>
    public class CreateTagBindingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for creating a TagKey.</summary>
    public class CreateTagKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for creating a TagValue.</summary>
    public class CreateTagValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the `Operation` returned by `DeleteFolder`.
    /// </summary>
    public class DeleteFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the operation returned by DeleteOrganization.
    /// </summary>
    public class DeleteOrganizationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by `DeleteProject`.
    /// </summary>
    public class DeleteProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for deleting a TagBinding.</summary>
    public class DeleteTagBindingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for deleting a TagKey.</summary>
    public class DeleteTagKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for deleting a TagValue.</summary>
    public class DeleteTagValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>
    /// A folder in an organization's resource hierarchy, used to organize that organization's resources.
    /// </summary>
    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp when the folder was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Timestamp when the folder was requested to be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// The folder's display name. A folder's display name must be unique amongst its siblings. For example, no two
        /// folders with the same parent can share the same display name. The display name must start and end with a
        /// letter or digit, may contain letters, digits, spaces, hyphens and underscores and can be no longer than 30
        /// characters. This is captured by the regular expression: `[\p{L}\p{N}]([\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. A checksum computed by the server based on the current value of the folder resource. This may
        /// be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. The resource name of the folder. Its format is `folders/{folder_id}`, for example:
        /// "folders/1234".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The folder's parent's resource name. Updates to the folder's parent must be performed using
        /// MoveFolder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Output only. The lifecycle state of the folder. Updates to the state must be performed using DeleteFolder
        /// and UndeleteFolder.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Timestamp when the folder was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>Metadata describing a long running folder operation</summary>
    public class FolderOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the folder or organization we are either creating the folder under or moving the folder
        /// to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The type of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// The resource name of the folder's parent. Only applicable when the operation_type is MOVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A classification of the Folder Operation error.</summary>
    public class FolderOperationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of operation error experienced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessageId")]
        public virtual string ErrorMessageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Lien represents an encumbrance on the actions that can be performed on a resource.</summary>
    public class Lien : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time of this Lien.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A system-generated unique identifier for this Lien. Example: `liens/1234abcd`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A stable, user-visible/meaningful string identifying the origin of the Lien, intended to be inspected
        /// programmatically. Maximum length of 200 characters. Example: 'compute.googleapis.com'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>
        /// A reference to the resource this Lien is attached to. The server will validate the parent against those for
        /// which Liens are supported. Example: `projects/1234`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Concise user-visible strings indicating why an action cannot be performed on a resource. Maximum length of
        /// 200 characters. Example: 'Holds production API key'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// The types of operations which should be blocked as a result of this Lien. Each value should correspond to an
        /// IAM permission. The server will validate the permissions against those for which Liens are supported. An
        /// empty list is meaningless and will be rejected. Example: ['resourcemanager.projects.delete']
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual System.Collections.Generic.IList<string> Restrictions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListFolders response message.</summary>
    public class ListFoldersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A possibly paginated list of folders that are direct descendants of the specified parent resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>
        /// A pagination token returned from a previous call to `ListFolders` that indicates from where listing should
        /// continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Liens.ListLiens.</summary>
    public class ListLiensResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Liens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liens")]
        public virtual System.Collections.Generic.IList<Lien> Liens { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A page of the response received from the ListProjects method. A paginated response where more pages are
    /// available has `next_page_token` set. This token can be used in a subsequent request to retrieve the next request
    /// page. NOTE: A response may contain fewer elements than the request `page_size` and still have a
    /// `next_page_token`.
    /// </summary>
    public class ListProjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token. If the result set is too large to fit in a single response, this token is returned. It
        /// encodes the position of the current result cursor. Feeding this value into a new list request with the
        /// `page_token` parameter gives the next page of the results. When `next_page_token` is not filled in, there is
        /// no next page and the list returned is the last page in the result set. Pagination tokens have a limited
        /// lifetime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Projects under the parent. This list can be paginated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projects")]
        public virtual System.Collections.Generic.IList<Project> Projects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListTagBindings response.</summary>
    public class ListTagBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token. If the result set is too large to fit in a single response, this token is returned. It
        /// encodes the position of the current result cursor. Feeding this value into a new list request with the
        /// `page_token` parameter gives the next page of the results. When `next_page_token` is not filled in, there is
        /// no next page and the list returned is the last page in the result set. Pagination tokens have a limited
        /// lifetime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A possibly paginated list of TagBindings for the specified resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagBindings")]
        public virtual System.Collections.Generic.IList<TagBinding> TagBindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListTagKeys response message.</summary>
    public class ListTagKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token returned from a previous call to `ListTagKeys` that indicates from where listing should
        /// continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of TagKeys that live under the specified parent in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagKeys")]
        public virtual System.Collections.Generic.IList<TagKey> TagKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListTagValues response.</summary>
    public class ListTagValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token returned from a previous call to `ListTagValues` that indicates from where listing should
        /// continue. This is currently not used, but the server may at any point start supplying a valid token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A possibly paginated list of TagValues that are direct descendants of the specified parent TagKey.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValues")]
        public virtual System.Collections.Generic.IList<TagValue> TagValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata pertaining to the folder move process.</summary>
    public class MoveFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the folder or organization to move the folder to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The display name of the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the folder's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceParent")]
        public virtual string SourceParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The MoveFolder request message.</summary>
    public class MoveFolderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the folder or organization which should be the folder's new parent. Must be
        /// of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by MoveProject.
    /// </summary>
    public class MoveProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to MoveProject method.</summary>
    public class MoveProjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new parent to move the Project under.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationParent")]
        public virtual string DestinationParent { get; set; }

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
    /// The root node in the resource hierarchy to which a particular entity's (a company, for example) resources
    /// belong.
    /// </summary>
    public class Organization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp when the Organization was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Timestamp when the Organization was requested for deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>Immutable. The G Suite / Workspace customer id used in the Directory API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directoryCustomerId")]
        public virtual string DirectoryCustomerId { get; set; }

        /// <summary>
        /// Output only. A human-readable string that refers to the organization in the Google Cloud Console. This
        /// string is set by the server and cannot be changed. The string will be set to the primary domain (for
        /// example, "google.com") of the Google Workspace customer that owns the organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. A checksum computed by the server based on the current value of the Organization resource. This
        /// may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. The resource name of the organization. This is the organization's relative path in the API. Its
        /// format is "organizations/[organization_id]". For example, "organizations/1234".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The organization's current lifecycle state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Timestamp when the Organization was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
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

    /// <summary>
    /// A project is a high-level Google Cloud entity. It is a container for ACLs, APIs, App Engine Apps, VMs, and other
    /// Google Cloud Platform resources.
    /// </summary>
    public class Project : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time at which this resource was requested for deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// Optional. A user-assigned display name of the project. When present it must be between 4 to 30 characters.
        /// Allowed characters are: lowercase and uppercase letters, numbers, hyphen, single-quote, double-quote, space,
        /// and exclamation point. Example: `My Project`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. A checksum computed by the server based on the current value of the Project resource. This may
        /// be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The labels associated with this project. Label keys must be between 1 and 63 characters long and
        /// must conform to the following regular expression: \[a-z\](\[-a-z0-9\]*\[a-z0-9\])?. Label values must be
        /// between 0 and 63 characters long and must conform to the regular expression
        /// (\[a-z\](\[-a-z0-9\]*\[a-z0-9\])?)?. No more than 256 labels can be associated with a given resource.
        /// Clients should store labels in a representation such as JSON that does not depend on specific characters
        /// being disallowed. Example: `"myBusinessDimension" : "businessValue"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The unique resource name of the project. It is an int64 generated number prefixed by
        /// "projects/". Example: `projects/415104041262`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. A reference to a parent Resource. eg., `organizations/123` or `folders/876`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Immutable. The unique, user-assigned id of the project. It must be 6 to 30 lowercase ASCII letters, digits,
        /// or hyphens. It must start with a letter. Trailing hyphens are prohibited. Example: `tokyo-rain-123`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Output only. The project lifecycle state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The most recent time this resource was modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by CreateProject. It provides
    /// insight for when significant phases of Project creation have completed.
    /// </summary>
    public class ProjectCreationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time of the project creation workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// True if the project can be retrieved using GetProject. No other operations on the project are guaranteed to
        /// work until the project creation is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gettable")]
        public virtual System.Nullable<bool> Gettable { get; set; }

        /// <summary>True if the project creation process is complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ready")]
        public virtual System.Nullable<bool> Ready { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for searching folders.</summary>
    public class SearchFoldersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A possibly paginated folder search results. the specified parent resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>
        /// A pagination token returned from a previous call to `SearchFolders` that indicates from where searching
        /// should continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response returned from the `SearchOrganizations` method.</summary>
    public class SearchOrganizationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token to be used to retrieve the next page of results. If the result is too large to fit within
        /// the page size specified in the request, this field will be set with a token that can be used to fetch the
        /// next page of results. If this field is empty, it indicates that this response contains the last page of
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Organizations that matched the search query, possibly paginated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<Organization> Organizations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A page of the response received from the SearchProjects method. A paginated response where more pages are
    /// available has `next_page_token` set. This token can be used in a subsequent request to retrieve the next request
    /// page.
    /// </summary>
    public class SearchProjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pagination token. If the result set is too large to fit in a single response, this token is returned. It
        /// encodes the position of the current result cursor. Feeding this value into a new list request with the
        /// `page_token` parameter gives the next page of the results. When `next_page_token` is not filled in, there is
        /// no next page and the list returned is the last page in the result set. Pagination tokens have a limited
        /// lifetime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Projects that matched the list filter query. This list can be paginated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projects")]
        public virtual System.Collections.Generic.IList<Project> Projects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
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
    /// A TagBinding represents a connection between a TagValue and a cloud resource (currently project, folder, or
    /// organization). Once a TagBinding is created, the TagValue is applied to all the descendants of the cloud
    /// resource.
    /// </summary>
    public class TagBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The name of the TagBinding. This is a String of the form:
        /// `tagBindings/{full-resource-name}/{tag-value-name}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The full resource name of the resource the TagValue is bound to. E.g.
        /// `//cloudresourcemanager.googleapis.com/projects/123`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The TagValue of the TagBinding. Must be of the form `tagValues/456`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValue")]
        public virtual string TagValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A TagKey, used to group a set of TagValues.</summary>
    public class TagKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. User-assigned description of the TagKey. Must not exceed 256 characters. Read-write.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Entity tag which users can pass to prevent race conditions. This field is always set in server
        /// responses. See UpdateTagKeyRequest for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Immutable. The resource name for a TagKey. Must be in the format `tagKeys/{tag_key_id}`, where `tag_key_id`
        /// is the generated numeric id for the TagKey.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Immutable. Namespaced name of the TagKey.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedName")]
        public virtual string NamespacedName { get; set; }

        /// <summary>
        /// Immutable. The resource name of the new TagKey's parent. Must be of the form `organizations/{org_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Required. Immutable. The user friendly name for a TagKey. The short name should be unique for TagKeys within
        /// the same tag namespace. The short name must be 1-63 characters, beginning and ending with an alphanumeric
        /// character ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and alphanumerics between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>Output only. Update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>
    /// A TagValue is a child of a particular TagKey. This is used to group cloud resources for the purpose of
    /// controlling them using policies.
    /// </summary>
    public class TagValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. User-assigned description of the TagValue. Must not exceed 256 characters. Read-write.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Entity tag which users can pass to prevent race conditions. This field is always set in server
        /// responses. See UpdateTagValueRequest for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Immutable. Resource name for TagValue in the format `tagValues/456`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Namespaced name of the TagValue. Must be in the format
        /// `{organization_id}/{tag_key_short_name}/{short_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespacedName")]
        public virtual string NamespacedName { get; set; }

        /// <summary>
        /// Immutable. The resource name of the new TagValue's parent TagKey. Must be of the form
        /// `tagKeys/{tag_key_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Required. Immutable. User-assigned short name for TagValue. The short name should be unique for TagValues
        /// within the same parent TagKey. The short name must be 63 characters or less, beginning and ending with an
        /// alphanumeric character ([a-z0-9A-Z]) with dashes (-), underscores (_), dots (.), and alphanumerics between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>Output only. Update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
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

    /// <summary>
    /// A status object which is used as the `metadata` field for the `Operation` returned by `UndeleteFolder`.
    /// </summary>
    public class UndeleteFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The UndeleteFolder request message.</summary>
    public class UndeleteFolderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by UndeleteOrganization.
    /// </summary>
    public class UndeleteOrganizationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by `UndeleteProject`.
    /// </summary>
    public class UndeleteProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to the UndeleteProject method.</summary>
    public class UndeleteProjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by UpdateFolder.
    /// </summary>
    public class UpdateFolderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status object which is used as the `metadata` field for the Operation returned by UpdateProject.
    /// </summary>
    public class UpdateProjectMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for updating a TagKey.</summary>
    public class UpdateTagKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime operation information for updating a TagValue.</summary>
    public class UpdateTagValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
