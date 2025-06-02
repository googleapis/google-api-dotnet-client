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

namespace Google.Apis.VMMigrationService.v1
{
    /// <summary>The VMMigrationService Service.</summary>
    public class VMMigrationServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public VMMigrationServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public VMMigrationServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://vmmigration.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://vmmigration.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "vmmigration";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the VM Migration API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the VM Migration API.</summary>
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

    /// <summary>A base abstract class for VMMigrationService requests.</summary>
    public abstract class VMMigrationServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new VMMigrationServiceBaseServiceRequest instance.</summary>
        protected VMMigrationServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes VMMigrationService parameter list.</summary>
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
                Groups = new GroupsResource(service);
                ImageImports = new ImageImportsResource(service);
                Operations = new OperationsResource(service);
                Sources = new SourcesResource(service);
                TargetProjects = new TargetProjectsResource(service);
            }

            /// <summary>Gets the Groups resource.</summary>
            public virtual GroupsResource Groups { get; }

            /// <summary>The "groups" collection of methods.</summary>
            public class GroupsResource
            {
                private const string Resource = "groups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GroupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Adds a MigratingVm to a Group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="group">Required. The full path name of the Group to add to.</param>
                public virtual AddGroupMigrationRequest AddGroupMigration(Google.Apis.VMMigrationService.v1.Data.AddGroupMigrationRequest body, string group)
                {
                    return new AddGroupMigrationRequest(this.service, body, group);
                }

                /// <summary>Adds a MigratingVm to a Group.</summary>
                public class AddGroupMigrationRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new AddGroupMigration request.</summary>
                    public AddGroupMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.AddGroupMigrationRequest body, string group) : base(service)
                    {
                        Group = group;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The full path name of the Group to add to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("group", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Group { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.AddGroupMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "addGroupMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+group}:addGroupMigration";

                    /// <summary>Initializes AddGroupMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("group", new Google.Apis.Discovery.Parameter
                        {
                            Name = "group",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a new Group in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The Group's parent.</param>
                public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.Group body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Group in a given project and location.</summary>
                public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.Group body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The Group's parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The group identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GroupId { get; set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.Group Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/groups";

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
                        RequestParameters.Add("groupId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupId",
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

                /// <summary>Deletes a single Group.</summary>
                /// <param name="name">Required. The Group name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Group.</summary>
                public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The Group name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
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

                /// <summary>Gets details of a single Group.</summary>
                /// <param name="name">Required. The group name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Group.</summary>
                public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Group>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The group name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Groups in a given project and location.</summary>
                /// <param name="parent">Required. The parent, which owns this collection of groups.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Groups in a given project and location.</summary>
                public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListGroupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent, which owns this collection of groups.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. the order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of groups to return. The service may return fewer than this value.
                    /// If unspecified, at most 500 groups will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Required. A page token, received from a previous `ListGroups` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListGroups` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/groups";

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

                /// <summary>Updates the parameters of a single Group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The Group name.</param>
                public virtual PatchRequest Patch(Google.Apis.VMMigrationService.v1.Data.Group body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Group.</summary>
                public class PatchRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.Group body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The Group name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the Group resource by the update.
                    /// The fields specified in the update_mask are relative to the resource, not the full request. A
                    /// field will be overwritten if it is in the mask. If the user does not provide a mask then all
                    /// fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.Group Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
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

                /// <summary>Removes a MigratingVm from a Group.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="group">Required. The name of the Group.</param>
                public virtual RemoveGroupMigrationRequest RemoveGroupMigration(Google.Apis.VMMigrationService.v1.Data.RemoveGroupMigrationRequest body, string group)
                {
                    return new RemoveGroupMigrationRequest(this.service, body, group);
                }

                /// <summary>Removes a MigratingVm from a Group.</summary>
                public class RemoveGroupMigrationRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new RemoveGroupMigration request.</summary>
                    public RemoveGroupMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.RemoveGroupMigrationRequest body, string group) : base(service)
                    {
                        Group = group;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the Group.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("group", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Group { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.RemoveGroupMigrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeGroupMigration";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+group}:removeGroupMigration";

                    /// <summary>Initializes RemoveGroupMigration parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("group", new Google.Apis.Discovery.Parameter
                        {
                            Name = "group",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/groups/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the ImageImports resource.</summary>
            public virtual ImageImportsResource ImageImports { get; }

            /// <summary>The "imageImports" collection of methods.</summary>
            public class ImageImportsResource
            {
                private const string Resource = "imageImports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImageImportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ImageImportJobs = new ImageImportJobsResource(service);
                }

                /// <summary>Gets the ImageImportJobs resource.</summary>
                public virtual ImageImportJobsResource ImageImportJobs { get; }

                /// <summary>The "imageImportJobs" collection of methods.</summary>
                public class ImageImportJobsResource
                {
                    private const string Resource = "imageImportJobs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ImageImportJobsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Initiates the cancellation of a running clone job.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The image import job id.</param>
                    public virtual CancelRequest Cancel(Google.Apis.VMMigrationService.v1.Data.CancelImageImportJobRequest body, string name)
                    {
                        return new CancelRequest(this.service, body, name);
                    }

                    /// <summary>Initiates the cancellation of a running clone job.</summary>
                    public class CancelRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.CancelImageImportJobRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The image import job id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.CancelImageImportJobRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/imageImports/[^/]+/imageImportJobs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single ImageImportJob.</summary>
                    /// <param name="name">Required. The ImageImportJob name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single ImageImportJob.</summary>
                    public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ImageImportJob>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The ImageImportJob name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/imageImports/[^/]+/imageImportJobs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists ImageImportJobs in a given project.</summary>
                    /// <param name="parent">Required. The parent, which owns this collection of targets.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists ImageImportJobs in a given project.</summary>
                    public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListImageImportJobsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent, which owns this collection of targets.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter request (according to AIP-160).</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The order by fields for the result (according to AIP-132). Currently ordering is
                        /// only possible by "name" field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of targets to return. The service may return fewer than this
                        /// value. If unspecified, at most 500 targets will be returned. The maximum value is 1000;
                        /// values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListImageImportJobs` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListImageImportJobs` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/imageImportJobs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/imageImports/[^/]+$",
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

                /// <summary>Creates a new ImageImport in a given project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The ImageImport's parent.</param>
                public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.ImageImport body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new ImageImport in a given project.</summary>
                public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.ImageImport body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The ImageImport's parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The image import identifier. This value maximum length is 63 characters, and valid
                    /// characters are /a-z-/. It must start with an english letter and must not end with a hyphen.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("imageImportId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ImageImportId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.ImageImport Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/imageImports";

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
                        RequestParameters.Add("imageImportId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "imageImportId",
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

                /// <summary>Deletes a single ImageImport.</summary>
                /// <param name="name">Required. The ImageImport name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single ImageImport.</summary>
                public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The ImageImport name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and t he request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/imageImports/[^/]+$",
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

                /// <summary>Gets details of a single ImageImport.</summary>
                /// <param name="name">Required. The ImageImport name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ImageImport.</summary>
                public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ImageImport>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The ImageImport name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/imageImports/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists ImageImports in a given project.</summary>
                /// <param name="parent">Required. The parent, which owns this collection of targets.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists ImageImports in a given project.</summary>
                public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListImageImportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent, which owns this collection of targets.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter request (according to AIP-160).</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The order by fields for the result (according to AIP-132). Currently ordering is only
                    /// possible by "name" field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of targets to return. The service may return fewer than this value.
                    /// If unspecified, at most 500 targets will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListImageImports` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListImageImports` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/imageImports";

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
                public virtual CancelRequest Cancel(Google.Apis.VMMigrationService.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Empty>
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
                public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
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
                public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the Sources resource.</summary>
            public virtual SourcesResource Sources { get; }

            /// <summary>The "sources" collection of methods.</summary>
            public class SourcesResource
            {
                private const string Resource = "sources";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SourcesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    DatacenterConnectors = new DatacenterConnectorsResource(service);
                    MigratingVms = new MigratingVmsResource(service);
                    UtilizationReports = new UtilizationReportsResource(service);
                }

                /// <summary>Gets the DatacenterConnectors resource.</summary>
                public virtual DatacenterConnectorsResource DatacenterConnectors { get; }

                /// <summary>The "datacenterConnectors" collection of methods.</summary>
                public class DatacenterConnectorsResource
                {
                    private const string Resource = "datacenterConnectors";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DatacenterConnectorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new DatacenterConnector in a given Source.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The DatacenterConnector's parent. Required. The Source in where the new
                    /// DatacenterConnector will be created. For example:
                    /// `projects/my-project/locations/us-central1/sources/my-source`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.DatacenterConnector body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new DatacenterConnector in a given Source.</summary>
                    public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.DatacenterConnector body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The DatacenterConnector's parent. Required. The Source in where the new
                        /// DatacenterConnector will be created. For example:
                        /// `projects/my-project/locations/us-central1/sources/my-source`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The datacenterConnector identifier.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("datacenterConnectorId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DatacenterConnectorId { get; set; }

                        /// <summary>
                        /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.DatacenterConnector Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/datacenterConnectors";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
                            });
                            RequestParameters.Add("datacenterConnectorId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "datacenterConnectorId",
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

                    /// <summary>Deletes a single DatacenterConnector.</summary>
                    /// <param name="name">Required. The DatacenterConnector name.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single DatacenterConnector.</summary>
                    public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The DatacenterConnector name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes after the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/datacenterConnectors/[^/]+$",
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

                    /// <summary>Gets details of a single DatacenterConnector.</summary>
                    /// <param name="name">Required. The name of the DatacenterConnector.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single DatacenterConnector.</summary>
                    public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.DatacenterConnector>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the DatacenterConnector.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/datacenterConnectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists DatacenterConnectors in a given Source.</summary>
                    /// <param name="parent">Required. The parent, which owns this collection of connectors.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists DatacenterConnectors in a given Source.</summary>
                    public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListDatacenterConnectorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent, which owns this collection of connectors.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. the order by fields for the result.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of connectors to return. The service may return fewer than this
                        /// value. If unspecified, at most 500 sources will be returned. The maximum value is 1000;
                        /// values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Required. A page token, received from a previous `ListDatacenterConnectors` call. Provide
                        /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListDatacenterConnectors` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/datacenterConnectors";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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
                    /// Upgrades the appliance relate to this DatacenterConnector to the in-place updateable version.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="datacenterConnector">Required. The DatacenterConnector name.</param>
                    public virtual UpgradeApplianceRequest UpgradeAppliance(Google.Apis.VMMigrationService.v1.Data.UpgradeApplianceRequest body, string datacenterConnector)
                    {
                        return new UpgradeApplianceRequest(this.service, body, datacenterConnector);
                    }

                    /// <summary>
                    /// Upgrades the appliance relate to this DatacenterConnector to the in-place updateable version.
                    /// </summary>
                    public class UpgradeApplianceRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new UpgradeAppliance request.</summary>
                        public UpgradeApplianceRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.UpgradeApplianceRequest body, string datacenterConnector) : base(service)
                        {
                            DatacenterConnector = datacenterConnector;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The DatacenterConnector name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("datacenterConnector", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DatacenterConnector { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.UpgradeApplianceRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upgradeAppliance";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+datacenterConnector}:upgradeAppliance";

                        /// <summary>Initializes UpgradeAppliance parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("datacenterConnector", new Google.Apis.Discovery.Parameter
                            {
                                Name = "datacenterConnector",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/datacenterConnectors/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the MigratingVms resource.</summary>
                public virtual MigratingVmsResource MigratingVms { get; }

                /// <summary>The "migratingVms" collection of methods.</summary>
                public class MigratingVmsResource
                {
                    private const string Resource = "migratingVms";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MigratingVmsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        CloneJobs = new CloneJobsResource(service);
                        CutoverJobs = new CutoverJobsResource(service);
                        ReplicationCycles = new ReplicationCyclesResource(service);
                    }

                    /// <summary>Gets the CloneJobs resource.</summary>
                    public virtual CloneJobsResource CloneJobs { get; }

                    /// <summary>The "cloneJobs" collection of methods.</summary>
                    public class CloneJobsResource
                    {
                        private const string Resource = "cloneJobs";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public CloneJobsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Initiates the cancellation of a running clone job.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The clone job id</param>
                        public virtual CancelRequest Cancel(Google.Apis.VMMigrationService.v1.Data.CancelCloneJobRequest body, string name)
                        {
                            return new CancelRequest(this.service, body, name);
                        }

                        /// <summary>Initiates the cancellation of a running clone job.</summary>
                        public class CancelRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Cancel request.</summary>
                            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.CancelCloneJobRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The clone job id</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.VMMigrationService.v1.Data.CancelCloneJobRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+/cloneJobs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Initiates a Clone of a specific migrating VM.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The Clone's parent.</param>
                        public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.CloneJob body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>Initiates a Clone of a specific migrating VM.</summary>
                        public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.CloneJob body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The Clone's parent.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Required. The clone job identifier.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("cloneJobId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string CloneJobId { get; set; }

                            /// <summary>
                            /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                            /// your request, the server will know to ignore the request if it has already been
                            /// completed. The server will guarantee that for at least 60 minutes since the first
                            /// request. For example, consider a situation where you make an initial request and the
                            /// request times out. If you make the request again with the same request ID, the server
                            /// can check if original operation with the same request ID was received, and if so, will
                            /// ignore the second request. This prevents clients from accidentally creating duplicate
                            /// commitments. The request ID must be a valid UUID with the exception that zero UUID is
                            /// not supported (00000000-0000-0000-0000-000000000000).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string RequestId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.VMMigrationService.v1.Data.CloneJob Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/cloneJobs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                                });
                                RequestParameters.Add("cloneJobId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "cloneJobId",
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

                        /// <summary>Gets details of a single CloneJob.</summary>
                        /// <param name="name">Required. The name of the CloneJob.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single CloneJob.</summary>
                        public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.CloneJob>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the CloneJob.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+/cloneJobs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists the CloneJobs of a migrating VM. Only 25 most recent CloneJobs are listed.
                        /// </summary>
                        /// <param name="parent">Required. The parent, which owns this collection of source VMs.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists the CloneJobs of a migrating VM. Only 25 most recent CloneJobs are listed.
                        /// </summary>
                        public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListCloneJobsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. The parent, which owns this collection of source VMs.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. The filter request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. the order by fields for the result.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of clone jobs to return. The service may return fewer than
                            /// this value. If unspecified, at most 500 clone jobs will be returned. The maximum value
                            /// is 1000; values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Required. A page token, received from a previous `ListCloneJobs` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListCloneJobs` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/cloneJobs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
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

                    /// <summary>Gets the CutoverJobs resource.</summary>
                    public virtual CutoverJobsResource CutoverJobs { get; }

                    /// <summary>The "cutoverJobs" collection of methods.</summary>
                    public class CutoverJobsResource
                    {
                        private const string Resource = "cutoverJobs";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public CutoverJobsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Initiates the cancellation of a running cutover job.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The cutover job id</param>
                        public virtual CancelRequest Cancel(Google.Apis.VMMigrationService.v1.Data.CancelCutoverJobRequest body, string name)
                        {
                            return new CancelRequest(this.service, body, name);
                        }

                        /// <summary>Initiates the cancellation of a running cutover job.</summary>
                        public class CancelRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Cancel request.</summary>
                            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.CancelCutoverJobRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The cutover job id</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.VMMigrationService.v1.Data.CancelCutoverJobRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+/cutoverJobs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Initiates a Cutover of a specific migrating VM. The returned LRO is completed when the
                        /// cutover job resource is created and the job is initiated.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The Cutover's parent.</param>
                        public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.CutoverJob body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Initiates a Cutover of a specific migrating VM. The returned LRO is completed when the
                        /// cutover job resource is created and the job is initiated.
                        /// </summary>
                        public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.CutoverJob body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The Cutover's parent.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Required. The cutover job identifier.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("cutoverJobId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string CutoverJobId { get; set; }

                            /// <summary>
                            /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                            /// your request, the server will know to ignore the request if it has already been
                            /// completed. The server will guarantee that for at least 60 minutes since the first
                            /// request. For example, consider a situation where you make an initial request and the
                            /// request times out. If you make the request again with the same request ID, the server
                            /// can check if original operation with the same request ID was received, and if so, will
                            /// ignore the second request. This prevents clients from accidentally creating duplicate
                            /// commitments. The request ID must be a valid UUID with the exception that zero UUID is
                            /// not supported (00000000-0000-0000-0000-000000000000).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string RequestId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.VMMigrationService.v1.Data.CutoverJob Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/cutoverJobs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                                });
                                RequestParameters.Add("cutoverJobId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "cutoverJobId",
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

                        /// <summary>Gets details of a single CutoverJob.</summary>
                        /// <param name="name">Required. The name of the CutoverJob.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single CutoverJob.</summary>
                        public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.CutoverJob>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the CutoverJob.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+/cutoverJobs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists the CutoverJobs of a migrating VM. Only 25 most recent CutoverJobs are listed.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of migrating VMs.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists the CutoverJobs of a migrating VM. Only 25 most recent CutoverJobs are listed.
                        /// </summary>
                        public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListCutoverJobsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. The parent, which owns this collection of migrating VMs.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. The filter request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. the order by fields for the result.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of cutover jobs to return. The service may return fewer
                            /// than this value. If unspecified, at most 500 cutover jobs will be returned. The maximum
                            /// value is 1000; values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Required. A page token, received from a previous `ListCutoverJobs` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListCutoverJobs` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/cutoverJobs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
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

                    /// <summary>Gets the ReplicationCycles resource.</summary>
                    public virtual ReplicationCyclesResource ReplicationCycles { get; }

                    /// <summary>The "replicationCycles" collection of methods.</summary>
                    public class ReplicationCyclesResource
                    {
                        private const string Resource = "replicationCycles";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ReplicationCyclesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Gets details of a single ReplicationCycle.</summary>
                        /// <param name="name">Required. The name of the ReplicationCycle.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single ReplicationCycle.</summary>
                        public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ReplicationCycle>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the ReplicationCycle.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+/replicationCycles/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists ReplicationCycles in a given MigratingVM.</summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of ReplicationCycles.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists ReplicationCycles in a given MigratingVM.</summary>
                        public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListReplicationCyclesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of ReplicationCycles.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. The filter request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. the order by fields for the result.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of replication cycles to return. The service may return
                            /// fewer than this value. If unspecified, at most 100 migrating VMs will be returned. The
                            /// maximum value is 100; values above 100 will be coerced to 100.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Required. A page token, received from a previous `ListReplicationCycles` call. Provide
                            /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListReplicationCycles` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/replicationCycles";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
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

                    /// <summary>Creates a new MigratingVm in a given Source.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The MigratingVm's parent.</param>
                    public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.MigratingVm body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new MigratingVm in a given Source.</summary>
                    public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.MigratingVm body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The MigratingVm's parent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The migratingVm identifier.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("migratingVmId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string MigratingVmId { get; set; }

                        /// <summary>
                        /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.MigratingVm Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/migratingVms";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
                            });
                            RequestParameters.Add("migratingVmId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "migratingVmId",
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

                    /// <summary>Deletes a single MigratingVm.</summary>
                    /// <param name="name">Required. The name of the MigratingVm.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single MigratingVm.</summary>
                    public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the MigratingVm.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Extend the migrating VM time to live.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="migratingVm">Required. The name of the MigratingVm.</param>
                    public virtual ExtendMigrationRequest ExtendMigration(Google.Apis.VMMigrationService.v1.Data.ExtendMigrationRequest body, string migratingVm)
                    {
                        return new ExtendMigrationRequest(this.service, body, migratingVm);
                    }

                    /// <summary>Extend the migrating VM time to live.</summary>
                    public class ExtendMigrationRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new ExtendMigration request.</summary>
                        public ExtendMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.ExtendMigrationRequest body, string migratingVm) : base(service)
                        {
                            MigratingVm = migratingVm;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the MigratingVm.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("migratingVm", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string MigratingVm { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.ExtendMigrationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "extendMigration";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+migratingVm}:extendMigration";

                        /// <summary>Initializes ExtendMigration parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("migratingVm", new Google.Apis.Discovery.Parameter
                            {
                                Name = "migratingVm",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks a migration as completed, deleting migration resources that are no longer being used. Only
                    /// applicable after cutover is done.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="migratingVm">Required. The name of the MigratingVm.</param>
                    public virtual FinalizeMigrationRequest FinalizeMigration(Google.Apis.VMMigrationService.v1.Data.FinalizeMigrationRequest body, string migratingVm)
                    {
                        return new FinalizeMigrationRequest(this.service, body, migratingVm);
                    }

                    /// <summary>
                    /// Marks a migration as completed, deleting migration resources that are no longer being used. Only
                    /// applicable after cutover is done.
                    /// </summary>
                    public class FinalizeMigrationRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new FinalizeMigration request.</summary>
                        public FinalizeMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.FinalizeMigrationRequest body, string migratingVm) : base(service)
                        {
                            MigratingVm = migratingVm;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the MigratingVm.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("migratingVm", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string MigratingVm { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.FinalizeMigrationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "finalizeMigration";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+migratingVm}:finalizeMigration";

                        /// <summary>Initializes FinalizeMigration parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("migratingVm", new Google.Apis.Discovery.Parameter
                            {
                                Name = "migratingVm",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single MigratingVm.</summary>
                    /// <param name="name">Required. The name of the MigratingVm.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single MigratingVm.</summary>
                    public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.MigratingVm>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the MigratingVm.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. The level of details of the migrating VM.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Optional. The level of details of the migrating VM.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>View is unspecified. The API will fallback to the default value.</summary>
                            [Google.Apis.Util.StringValueAttribute("MIGRATING_VM_VIEW_UNSPECIFIED")]
                            MIGRATINGVMVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Get the migrating VM basic details. The basic details do not include the recent clone
                            /// jobs and recent cutover jobs lists.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("MIGRATING_VM_VIEW_BASIC")]
                            MIGRATINGVMVIEWBASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("MIGRATING_VM_VIEW_FULL")]
                            MIGRATINGVMVIEWFULL = 2,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
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

                    /// <summary>Lists MigratingVms in a given Source.</summary>
                    /// <param name="parent">Required. The parent, which owns this collection of MigratingVms.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists MigratingVms in a given Source.</summary>
                    public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListMigratingVmsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent, which owns this collection of MigratingVms.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. the order by fields for the result.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of migrating VMs to return. The service may return fewer than
                        /// this value. If unspecified, at most 500 migrating VMs will be returned. The maximum value is
                        /// 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Required. A page token, received from a previous `ListMigratingVms` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListMigratingVms` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Optional. The level of details of each migrating VM.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Optional. The level of details of each migrating VM.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>View is unspecified. The API will fallback to the default value.</summary>
                            [Google.Apis.Util.StringValueAttribute("MIGRATING_VM_VIEW_UNSPECIFIED")]
                            MIGRATINGVMVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Get the migrating VM basic details. The basic details do not include the recent clone
                            /// jobs and recent cutover jobs lists.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("MIGRATING_VM_VIEW_BASIC")]
                            MIGRATINGVMVIEWBASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("MIGRATING_VM_VIEW_FULL")]
                            MIGRATINGVMVIEWFULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/migratingVms";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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

                    /// <summary>Updates the parameters of a single MigratingVm.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Output only. The identifier of the MigratingVm.</param>
                    public virtual PatchRequest Patch(Google.Apis.VMMigrationService.v1.Data.MigratingVm body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a single MigratingVm.</summary>
                    public class PatchRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.MigratingVm body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Output only. The identifier of the MigratingVm.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Field mask is used to specify the fields to be overwritten in the MigratingVm resource by
                        /// the update. The fields specified in the update_mask are relative to the resource, not the
                        /// full request. A field will be overwritten if it is in the mask. If the user does not provide
                        /// a mask then all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.MigratingVm Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
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
                    /// Pauses a migration for a VM. If cycle tasks are running they will be cancelled, preserving
                    /// source task data. Further replication cycles will not be triggered while the VM is paused.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="migratingVm">Required. The name of the MigratingVm.</param>
                    public virtual PauseMigrationRequest PauseMigration(Google.Apis.VMMigrationService.v1.Data.PauseMigrationRequest body, string migratingVm)
                    {
                        return new PauseMigrationRequest(this.service, body, migratingVm);
                    }

                    /// <summary>
                    /// Pauses a migration for a VM. If cycle tasks are running they will be cancelled, preserving
                    /// source task data. Further replication cycles will not be triggered while the VM is paused.
                    /// </summary>
                    public class PauseMigrationRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new PauseMigration request.</summary>
                        public PauseMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.PauseMigrationRequest body, string migratingVm) : base(service)
                        {
                            MigratingVm = migratingVm;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the MigratingVm.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("migratingVm", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string MigratingVm { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.PauseMigrationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "pauseMigration";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+migratingVm}:pauseMigration";

                        /// <summary>Initializes PauseMigration parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("migratingVm", new Google.Apis.Discovery.Parameter
                            {
                                Name = "migratingVm",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Resumes a migration for a VM. When called on a paused migration, will start the process of
                    /// uploading data and creating snapshots; when called on a completed cut-over migration, will
                    /// update the migration to active state and start the process of uploading data and creating
                    /// snapshots.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="migratingVm">Required. The name of the MigratingVm.</param>
                    public virtual ResumeMigrationRequest ResumeMigration(Google.Apis.VMMigrationService.v1.Data.ResumeMigrationRequest body, string migratingVm)
                    {
                        return new ResumeMigrationRequest(this.service, body, migratingVm);
                    }

                    /// <summary>
                    /// Resumes a migration for a VM. When called on a paused migration, will start the process of
                    /// uploading data and creating snapshots; when called on a completed cut-over migration, will
                    /// update the migration to active state and start the process of uploading data and creating
                    /// snapshots.
                    /// </summary>
                    public class ResumeMigrationRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new ResumeMigration request.</summary>
                        public ResumeMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.ResumeMigrationRequest body, string migratingVm) : base(service)
                        {
                            MigratingVm = migratingVm;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the MigratingVm.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("migratingVm", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string MigratingVm { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.ResumeMigrationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "resumeMigration";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+migratingVm}:resumeMigration";

                        /// <summary>Initializes ResumeMigration parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("migratingVm", new Google.Apis.Discovery.Parameter
                            {
                                Name = "migratingVm",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Starts migration for a VM. Starts the process of uploading data and creating snapshots, in
                    /// replication cycles scheduled by the policy.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="migratingVm">Required. The name of the MigratingVm.</param>
                    public virtual StartMigrationRequest StartMigration(Google.Apis.VMMigrationService.v1.Data.StartMigrationRequest body, string migratingVm)
                    {
                        return new StartMigrationRequest(this.service, body, migratingVm);
                    }

                    /// <summary>
                    /// Starts migration for a VM. Starts the process of uploading data and creating snapshots, in
                    /// replication cycles scheduled by the policy.
                    /// </summary>
                    public class StartMigrationRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new StartMigration request.</summary>
                        public StartMigrationRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.StartMigrationRequest body, string migratingVm) : base(service)
                        {
                            MigratingVm = migratingVm;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the MigratingVm.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("migratingVm", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string MigratingVm { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.StartMigrationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "startMigration";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+migratingVm}:startMigration";

                        /// <summary>Initializes StartMigration parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("migratingVm", new Google.Apis.Discovery.Parameter
                            {
                                Name = "migratingVm",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/migratingVms/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the UtilizationReports resource.</summary>
                public virtual UtilizationReportsResource UtilizationReports { get; }

                /// <summary>The "utilizationReports" collection of methods.</summary>
                public class UtilizationReportsResource
                {
                    private const string Resource = "utilizationReports";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UtilizationReportsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new UtilizationReport.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The Utilization Report's parent.</param>
                    public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.UtilizationReport body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new UtilizationReport.</summary>
                    public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.UtilizationReport body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The Utilization Report's parent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A request ID to identify requests. Specify a unique request ID so that if you must retry
                        /// your request, the server will know to ignore the request if it has already been completed.
                        /// The server will guarantee that for at least 60 minutes since the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. The ID to use for the report, which will become the final component of the
                        /// reports's resource name. This value maximum length is 63 characters, and valid characters
                        /// are /a-z-/. It must start with an english letter and must not end with a hyphen.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("utilizationReportId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UtilizationReportId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.VMMigrationService.v1.Data.UtilizationReport Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/utilizationReports";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("utilizationReportId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "utilizationReportId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single Utilization Report.</summary>
                    /// <param name="name">Required. The Utilization Report name.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single Utilization Report.</summary>
                    public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The Utilization Report name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server will know to ignore the request if it has already been
                        /// completed. The server will guarantee that for at least 60 minutes after the first request.
                        /// For example, consider a situation where you make an initial request and the request times
                        /// out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/utilizationReports/[^/]+$",
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

                    /// <summary>Gets a single Utilization Report.</summary>
                    /// <param name="name">Required. The Utilization Report name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a single Utilization Report.</summary>
                    public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.UtilizationReport>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The Utilization Report name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. The level of details of the report. Defaults to FULL</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Optional. The level of details of the report. Defaults to FULL</summary>
                        public enum ViewEnum
                        {
                            /// <summary>
                            /// The default / unset value. The API will default to FULL on single report request and
                            /// BASIC for multiple reports request.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("UTILIZATION_REPORT_VIEW_UNSPECIFIED")]
                            UTILIZATIONREPORTVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Get the report metadata, without the list of VMs and their utilization info.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+/utilizationReports/[^/]+$",
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

                    /// <summary>Lists Utilization Reports of the given Source.</summary>
                    /// <param name="parent">Required. The Utilization Reports parent.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Utilization Reports of the given Source.</summary>
                    public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListUtilizationReportsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The Utilization Reports parent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. the order by fields for the result.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of reports to return. The service may return fewer than this
                        /// value. If unspecified, at most 500 reports will be returned. The maximum value is 1000;
                        /// values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Required. A page token, received from a previous `ListUtilizationReports` call. Provide this
                        /// to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListUtilizationReports` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Optional. The level of details of each report. Defaults to BASIC.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Optional. The level of details of each report. Defaults to BASIC.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>
                            /// The default / unset value. The API will default to FULL on single report request and
                            /// BASIC for multiple reports request.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("UTILIZATION_REPORT_VIEW_UNSPECIFIED")]
                            UTILIZATIONREPORTVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Get the report metadata, without the list of VMs and their utilization info.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/utilizationReports";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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
                }

                /// <summary>Creates a new Source in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The Source's parent.</param>
                public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.Source body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Source in a given project and location.</summary>
                public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.Source body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The Source's parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The source identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("sourceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string SourceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.Source Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/sources";

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
                        RequestParameters.Add("sourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sourceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Source.</summary>
                /// <param name="name">Required. The Source name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Source.</summary>
                public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The Source name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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

                /// <summary>
                /// List remote source's inventory of VMs. The remote source is the onprem vCenter (remote in the sense
                /// it's not in Compute Engine). The inventory describes the list of existing VMs in that source. Note
                /// that this operation lists the VMs on the remote source, as opposed to listing the MigratingVms
                /// resources in the vmmigration service.
                /// </summary>
                /// <param name="source">Required. The name of the Source.</param>
                public virtual FetchInventoryRequest FetchInventory(string source)
                {
                    return new FetchInventoryRequest(this.service, source);
                }

                /// <summary>
                /// List remote source's inventory of VMs. The remote source is the onprem vCenter (remote in the sense
                /// it's not in Compute Engine). The inventory describes the list of existing VMs in that source. Note
                /// that this operation lists the VMs on the remote source, as opposed to listing the MigratingVms
                /// resources in the vmmigration service.
                /// </summary>
                public class FetchInventoryRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.FetchInventoryResponse>
                {
                    /// <summary>Constructs a new FetchInventory request.</summary>
                    public FetchInventoryRequest(Google.Apis.Services.IClientService service, string source) : base(service)
                    {
                        Source = source;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the Source.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Source { get; private set; }

                    /// <summary>
                    /// If this flag is set to true, the source will be queried instead of using cached results. Using
                    /// this flag will make the call slower.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("forceRefresh", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ForceRefresh { get; set; }

                    /// <summary>
                    /// The maximum number of VMs to return. The service may return fewer than this value. For AWS
                    /// source: If unspecified, at most 500 VMs will be returned. The maximum value is 1000; values
                    /// above 1000 will be coerced to 1000. For VMWare source: If unspecified, all VMs will be returned.
                    /// There is no limit for maximum value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `FetchInventory` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `FetchInventory` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchInventory";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+source}:fetchInventory";

                    /// <summary>Initializes FetchInventory parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                        {
                            Name = "source",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("forceRefresh", new Google.Apis.Discovery.Parameter
                        {
                            Name = "forceRefresh",
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

                /// <summary>Gets details of a single Source.</summary>
                /// <param name="name">Required. The Source name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Source.</summary>
                public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Source>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The Source name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Sources in a given project and location.</summary>
                /// <param name="parent">Required. The parent, which owns this collection of sources.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Sources in a given project and location.</summary>
                public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListSourcesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent, which owns this collection of sources.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. the order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of sources to return. The service may return fewer than this value.
                    /// If unspecified, at most 500 sources will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Required. A page token, received from a previous `ListSources` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListSources` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/sources";

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

                /// <summary>Updates the parameters of a single Source.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The Source name.</param>
                public virtual PatchRequest Patch(Google.Apis.VMMigrationService.v1.Data.Source body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Source.</summary>
                public class PatchRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.Source body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The Source name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the Source resource by the update.
                    /// The fields specified in the update_mask are relative to the resource, not the full request. A
                    /// field will be overwritten if it is in the mask. If the user does not provide a mask then all
                    /// fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.Source Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sources/[^/]+$",
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
            }

            /// <summary>Gets the TargetProjects resource.</summary>
            public virtual TargetProjectsResource TargetProjects { get; }

            /// <summary>The "targetProjects" collection of methods.</summary>
            public class TargetProjectsResource
            {
                private const string Resource = "targetProjects";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TargetProjectsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new TargetProject in a given project. NOTE: TargetProject is a global resource; hence the
                /// only supported value for location is `global`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The TargetProject's parent.</param>
                public virtual CreateRequest Create(Google.Apis.VMMigrationService.v1.Data.TargetProject body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new TargetProject in a given project. NOTE: TargetProject is a global resource; hence the
                /// only supported value for location is `global`.
                /// </summary>
                public class CreateRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.TargetProject body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The TargetProject's parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The target_project identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetProjectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TargetProjectId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.TargetProject Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/targetProjects";

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
                        RequestParameters.Add("targetProjectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetProjectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a single TargetProject. NOTE: TargetProject is a global resource; hence the only supported
                /// value for location is `global`.
                /// </summary>
                /// <param name="name">Required. The TargetProject name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a single TargetProject. NOTE: TargetProject is a global resource; hence the only supported
                /// value for location is `global`.
                /// </summary>
                public class DeleteRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The TargetProject name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targetProjects/[^/]+$",
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

                /// <summary>
                /// Gets details of a single TargetProject. NOTE: TargetProject is a global resource; hence the only
                /// supported value for location is `global`.
                /// </summary>
                /// <param name="name">Required. The TargetProject name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets details of a single TargetProject. NOTE: TargetProject is a global resource; hence the only
                /// supported value for location is `global`.
                /// </summary>
                public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.TargetProject>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The TargetProject name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targetProjects/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists TargetProjects in a given project. NOTE: TargetProject is a global resource; hence the only
                /// supported value for location is `global`.
                /// </summary>
                /// <param name="parent">Required. The parent, which owns this collection of targets.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists TargetProjects in a given project. NOTE: TargetProject is a global resource; hence the only
                /// supported value for location is `global`.
                /// </summary>
                public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListTargetProjectsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent, which owns this collection of targets.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. the order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of targets to return. The service may return fewer than this value.
                    /// If unspecified, at most 500 targets will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Required. A page token, received from a previous `ListTargets` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListTargets` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/targetProjects";

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
                /// Updates the parameters of a single TargetProject. NOTE: TargetProject is a global resource; hence
                /// the only supported value for location is `global`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The name of the target project.</param>
                public virtual PatchRequest Patch(Google.Apis.VMMigrationService.v1.Data.TargetProject body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates the parameters of a single TargetProject. NOTE: TargetProject is a global resource; hence
                /// the only supported value for location is `global`.
                /// </summary>
                public class PatchRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.VMMigrationService.v1.Data.TargetProject body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The name of the target project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the TargetProject resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.VMMigrationService.v1.Data.TargetProject Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targetProjects/[^/]+$",
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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.Location>
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
            public class ListRequest : VMMigrationServiceBaseServiceRequest<Google.Apis.VMMigrationService.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.VMMigrationService.v1.Data
{
    /// <summary>Message describing AWS Credentials using access key id and secret.</summary>
    public class AccessKeyCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AWS access key ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessKeyId")]
        public virtual string AccessKeyId { get; set; }

        /// <summary>Input only. AWS secret access key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretAccessKey")]
        public virtual string SecretAccessKey { get; set; }

        /// <summary>
        /// Input only. AWS session token. Used only when AWS security token service (STS) is responsible for creating
        /// the temporary credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionToken")]
        public virtual string SessionToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AdaptingOSStep contains specific step details.</summary>
    public class AdaptingOSStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'AddGroupMigration' request.</summary>
    public class AddGroupMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full path name of the MigratingVm to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migratingVm")]
        public virtual string MigratingVm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an appliance version.</summary>
    public class ApplianceVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determine whether it's critical to upgrade the appliance to this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("critical")]
        public virtual System.Nullable<bool> Critical { get; set; }

        /// <summary>Link to a page that contains the version release notes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotesUri")]
        public virtual string ReleaseNotesUri { get; set; }

        /// <summary>A link for downloading the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The appliance version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AppliedLicense holds the license data returned by adaptation module report.</summary>
    public class AppliedLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OS license returned from the adaptation module's report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osLicense")]
        public virtual string OsLicense { get; set; }

        /// <summary>The license type that was used in OS adaptation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds information about the available versions for upgrade.</summary>
    public class AvailableUpdates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The latest version for in place update. The current appliance can be updated to this version using the API
        /// or m4c CLI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inPlaceUpdate")]
        public virtual ApplianceVersion InPlaceUpdate { get; set; }

        /// <summary>
        /// The newest deployable version of the appliance. The current appliance can't be updated into this version,
        /// and the owner must manually deploy this OVA to a new appliance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newDeployableAppliance")]
        public virtual ApplianceVersion NewDeployableAppliance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of an AWS instance disk.</summary>
    public class AwsDiskDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ordinal number of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskNumber")]
        public virtual System.Nullable<int> DiskNumber { get; set; }

        /// <summary>Output only. Size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<long> SizeGb { get; set; }

        /// <summary>Output only. AWS volume ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AwsSecurityGroup describes a security group of an AWS VM.</summary>
    public class AwsSecurityGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AWS security group id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The AWS security group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AwsSourceDetails message describes a specific source details for the AWS source type.</summary>
    public class AwsSourceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AWS Credentials using access key id and secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessKeyCreds")]
        public virtual AccessKeyCredentials AccessKeyCreds { get; set; }

        /// <summary>Immutable. The AWS region that the source VMs will be migrated from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsRegion")]
        public virtual string AwsRegion { get; set; }

        /// <summary>Output only. Provides details on the state of the Source in case of an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>AWS security group names to limit the scope of the source inventory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventorySecurityGroupNames")]
        public virtual System.Collections.Generic.IList<string> InventorySecurityGroupNames { get; set; }

        /// <summary>AWS resource tags to limit the scope of the source inventory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryTagList")]
        public virtual System.Collections.Generic.IList<Tag> InventoryTagList { get; set; }

        /// <summary>
        /// User specified tags to add to every M2VM generated resource in AWS. These tags will be set in addition to
        /// the default tags that are set as part of the migration process. The tags must not begin with the reserved
        /// prefix `m2vm`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationResourcesUserTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> MigrationResourcesUserTags { get; set; }

        /// <summary>
        /// Output only. The source's public IP. All communication initiated by this source will originate from this IP.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicIp")]
        public virtual string PublicIp { get; set; }

        /// <summary>Output only. State of the source as determined by the health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the source AWS VM details.</summary>
    public class AwsSourceVmDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The VM architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. The total size of the disks being migrated in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("committedStorageBytes")]
        public virtual System.Nullable<long> CommittedStorageBytes { get; set; }

        /// <summary>Output only. The disks attached to the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<AwsDiskDetails> Disks { get; set; }

        /// <summary>Output only. The firmware type of the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firmware")]
        public virtual string Firmware { get; set; }

        /// <summary>Output only. Information about VM capabilities needed for some Compute Engine features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmCapabilitiesInfo")]
        public virtual VmCapabilities VmCapabilitiesInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AwsVmDetails describes a VM in AWS.</summary>
    public class AwsVmDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CPU architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The VM Boot Option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootOption")]
        public virtual string BootOption { get; set; }

        /// <summary>The total size of the storage allocated to the VM in MB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("committedStorageMb")]
        public virtual System.Nullable<long> CommittedStorageMb { get; set; }

        /// <summary>The number of cpus the VM has.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCount")]
        public virtual System.Nullable<int> CpuCount { get; set; }

        /// <summary>The number of disks the VM has.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskCount")]
        public virtual System.Nullable<int> DiskCount { get; set; }

        /// <summary>The display name of the VM. Note that this value is not necessarily unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The instance type of the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>The memory size of the VM in MB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMb")]
        public virtual System.Nullable<int> MemoryMb { get; set; }

        /// <summary>The VM's OS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osDescription")]
        public virtual string OsDescription { get; set; }

        /// <summary>Output only. The power state of the VM at the moment list was taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("powerState")]
        public virtual string PowerState { get; set; }

        /// <summary>The security groups the VM belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityGroups")]
        public virtual System.Collections.Generic.IList<AwsSecurityGroup> SecurityGroups { get; set; }

        /// <summary>The descriptive name of the AWS's source this VM is connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDescription")]
        public virtual string SourceDescription { get; set; }

        /// <summary>The id of the AWS's source this VM is connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceId")]
        public virtual string SourceId { get; set; }

        /// <summary>The tags of the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The virtualization type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualizationType")]
        public virtual string VirtualizationType { get; set; }

        /// <summary>The VM ID in AWS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The VPC ID the VM belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcId")]
        public virtual string VpcId { get; set; }

        /// <summary>The AWS zone of the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AWSVmsDetails describes VMs in AWS.</summary>
    public class AwsVmsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of the AWS VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<AwsVmDetails> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of an Azure VM disk.</summary>
    public class AzureDiskDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Azure disk ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskId")]
        public virtual string DiskId { get; set; }

        /// <summary>Output only. The ordinal number of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskNumber")]
        public virtual System.Nullable<int> DiskNumber { get; set; }

        /// <summary>Output only. Size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<long> SizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AzureSourceDetails message describes a specific source details for the Azure source type.</summary>
    public class AzureSourceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The Azure location (region) that the source VMs will be migrated from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureLocation")]
        public virtual string AzureLocation { get; set; }

        /// <summary>Azure Credentials using tenant ID, client ID and secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecretCreds")]
        public virtual ClientSecretCredentials ClientSecretCreds { get; set; }

        /// <summary>Output only. Provides details on the state of the Source in case of an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// User specified tags to add to every M2VM generated resource in Azure. These tags will be set in addition to
        /// the default tags that are set as part of the migration process. The tags must not begin with the reserved
        /// prefix `m4ce` or `m2vm`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationResourcesUserTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> MigrationResourcesUserTags { get; set; }

        /// <summary>
        /// Output only. The ID of the Azure resource group that contains all resources related to the migration process
        /// of this source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupId")]
        public virtual string ResourceGroupId { get; set; }

        /// <summary>Output only. State of the source as determined by the health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Immutable. Azure subscription ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionId")]
        public virtual string SubscriptionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the source Azure VM details.</summary>
    public class AzureSourceVmDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The VM architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. The total size of the disks being migrated in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("committedStorageBytes")]
        public virtual System.Nullable<long> CommittedStorageBytes { get; set; }

        /// <summary>Output only. The disks attached to the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<AzureDiskDetails> Disks { get; set; }

        /// <summary>Output only. The firmware type of the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firmware")]
        public virtual string Firmware { get; set; }

        /// <summary>Output only. Information about VM capabilities needed for some Compute Engine features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmCapabilitiesInfo")]
        public virtual VmCapabilities VmCapabilitiesInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AzureVmDetails describes a VM in Azure.</summary>
    public class AzureVmDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CPU architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The VM Boot Option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootOption")]
        public virtual string BootOption { get; set; }

        /// <summary>The total size of the storage allocated to the VM in MB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("committedStorageMb")]
        public virtual System.Nullable<long> CommittedStorageMb { get; set; }

        /// <summary>The VM's ComputerName.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computerName")]
        public virtual string ComputerName { get; set; }

        /// <summary>The number of cpus the VM has.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCount")]
        public virtual System.Nullable<int> CpuCount { get; set; }

        /// <summary>The number of disks the VM has, including OS disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskCount")]
        public virtual System.Nullable<int> DiskCount { get; set; }

        /// <summary>Description of the data disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<Disk> Disks { get; set; }

        /// <summary>The memory size of the VM in MB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMb")]
        public virtual System.Nullable<int> MemoryMb { get; set; }

        /// <summary>Description of the OS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osDescription")]
        public virtual OSDescription OsDescription { get; set; }

        /// <summary>Description of the OS disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osDisk")]
        public virtual OSDisk OsDisk { get; set; }

        /// <summary>The power state of the VM at the moment list was taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("powerState")]
        public virtual string PowerState { get; set; }

        /// <summary>The tags of the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The VM full path in Azure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>VM size as configured in Azure. Determines the VM's hardware spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmSize")]
        public virtual string VmSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AzureVmsDetails describes VMs in Azure.</summary>
    public class AzureVmsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of the Azure VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<AzureVmDetails> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BootDiskDefaults hold information about the boot disk of a VM.</summary>
    public class BootDiskDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies a unique device name of your choice that is reflected into the /dev/disk/by-id/google-*
        /// tree of a Linux operating system running within the instance. If not specified, the server chooses a default
        /// device name to apply to this disk, in the form persistent-disk-x, where x is a number assigned by Google
        /// Compute Engine. This field is only applicable for persistent disks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>Optional. The name of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskName")]
        public virtual string DiskName { get; set; }

        /// <summary>Optional. The type of disk provisioning to use for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>Optional. The encryption to apply to the boot disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>The image to use when creating the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual DiskImageDefaults Image { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'CancelCloneJob' request.</summary>
    public class CancelCloneJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'CancelCutoverJob' request.</summary>
    public class CancelCutoverJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'CancelImageImportJob' request.</summary>
    public class CancelImageImportJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing Azure Credentials using tenant ID, client ID and secret.</summary>
    public class ClientSecretCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Azure client ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Input only. Azure client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>Azure tenant ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantId")]
        public virtual string TenantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CloneJob describes the process of creating a clone of a MigratingVM to the requested target based on the latest
    /// successful uploaded snapshots. While the migration cycles of a MigratingVm take place, it is possible to verify
    /// the uploaded VM can be started in the cloud, by creating a clone. The clone can be created without any downtime,
    /// and it is created using the latest snapshots which are already in the cloud. The cloneJob is only responsible
    /// for its work, not its products, which means once it is finished, it will never touch the instance it created. It
    /// will only delete it in case of the CloneJob being cancelled or upon failure to clone.
    /// </summary>
    public class CloneJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Details of the target Persistent Disks in Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineDisksTargetDetails")]
        public virtual ComputeEngineDisksTargetDetails ComputeEngineDisksTargetDetails { get; set; }

        /// <summary>Output only. Details of the target VM in Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineTargetDetails")]
        public virtual ComputeEngineTargetDetails ComputeEngineTargetDetails { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time the clone job was created (as an API call, not when it was actually created in the
        /// target).
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the clone job was ended.</summary>
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

        /// <summary>Output only. Provides details for the errors that led to the Clone Job's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Output only. The name of the clone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the clone job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _stateTimeRaw;

        private object _stateTime;

        /// <summary>Output only. The time the state was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTime")]
        public virtual string StateTimeRaw
        {
            get => _stateTimeRaw;
            set
            {
                _stateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _stateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StateTimeDateTimeOffset instead.")]
        public virtual object StateTime
        {
            get => _stateTime;
            set
            {
                _stateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _stateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StateTimeRaw);
            set => StateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The clone steps list representing its progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<CloneStep> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CloneStep holds information about the clone step progress.</summary>
    public class CloneStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adapting OS step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptingOs")]
        public virtual AdaptingOSStep AdaptingOs { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the step has ended.</summary>
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

        /// <summary>Instantiating migrated VM step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instantiatingMigratedVm")]
        public virtual InstantiatingMigratedVMStep InstantiatingMigratedVm { get; set; }

        /// <summary>Preparing VM disks step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preparingVmDisks")]
        public virtual PreparingVMDisksStep PreparingVmDisks { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the step has started.</summary>
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
    /// ComputeEngineDisksTargetDefaults is a collection of details for creating Persistent Disks in a target Compute
    /// Engine project.
    /// </summary>
    public class ComputeEngineDisksTargetDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of each Persistent Disk to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<PersistentDiskDefaults> Disks { get; set; }

        /// <summary>Details of the disk only migration target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disksTargetDefaults")]
        public virtual DisksMigrationDisksTargetDefaults DisksTargetDefaults { get; set; }

        /// <summary>
        /// The full path of the resource of type TargetProject which represents the Compute Engine project in which to
        /// create the Persistent Disks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProject")]
        public virtual string TargetProject { get; set; }

        /// <summary>Details of the VM migration target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmTargetDefaults")]
        public virtual DisksMigrationVmTargetDefaults VmTargetDefaults { get; set; }

        /// <summary>The zone in which to create the Persistent Disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ComputeEngineDisksTargetDetails is a collection of created Persistent Disks details.</summary>
    public class ComputeEngineDisksTargetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of each created Persistent Disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<PersistentDisk> Disks { get; set; }

        /// <summary>Details of the disks-only migration target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disksTargetDetails")]
        public virtual DisksMigrationDisksTargetDetails DisksTargetDetails { get; set; }

        /// <summary>Details for the VM the migrated data disks are attached to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmTargetDetails")]
        public virtual DisksMigrationVmTargetDetails VmTargetDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ComputeEngineTargetDefaults is a collection of details for creating a VM in a target Compute Engine project.
    /// </summary>
    public class ComputeEngineTargetDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional licenses to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLicenses")]
        public virtual System.Collections.Generic.IList<string> AdditionalLicenses { get; set; }

        /// <summary>Output only. The OS license returned from the adaptation module report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedLicense")]
        public virtual AppliedLicense AppliedLicense { get; set; }

        /// <summary>
        /// Optional. By default the virtual machine will keep its existing boot option. Setting this property will
        /// trigger an internal process which will convert the virtual machine from using the existing boot option to
        /// another.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootConversion")]
        public virtual string BootConversion { get; set; }

        /// <summary>Output only. The VM Boot Option, as set in the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootOption")]
        public virtual string BootOption { get; set; }

        /// <summary>Compute instance scheduling information (if empty default is used).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeScheduling")]
        public virtual ComputeScheduling ComputeScheduling { get; set; }

        /// <summary>The disk type to use in the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Optional. Defines whether the instance has integrity monitoring enabled. This can be set to true only if the
        /// VM boot option is EFI, and vTPM is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>
        /// Optional. Defines whether the instance has vTPM enabled. This can be set to true only if the VM boot option
        /// is EFI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>Optional. Immutable. The encryption to apply to the VM disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>The hostname to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>A map of labels to associate with the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The license type to use in OS adaptation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>The machine type to create the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The machine type series to create the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineTypeSeries")]
        public virtual string MachineTypeSeries { get; set; }

        /// <summary>The metadata key/value pairs to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>List of NICs connected to this VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>A list of network tags to associate with the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>
        /// Defines whether the instance has Secure Boot enabled. This can be set to true only if the VM boot option is
        /// EFI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secureBoot")]
        public virtual System.Nullable<bool> SecureBoot { get; set; }

        /// <summary>The service account to associate the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The full path of the resource of type TargetProject which represents the Compute Engine project in which to
        /// create this VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProject")]
        public virtual string TargetProject { get; set; }

        /// <summary>The name of the VM to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmName")]
        public virtual string VmName { get; set; }

        /// <summary>The zone in which to create the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ComputeEngineTargetDetails is a collection of details for creating a VM in a target Compute Engine project.
    /// </summary>
    public class ComputeEngineTargetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional licenses to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLicenses")]
        public virtual System.Collections.Generic.IList<string> AdditionalLicenses { get; set; }

        /// <summary>The OS license returned from the adaptation module report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedLicense")]
        public virtual AppliedLicense AppliedLicense { get; set; }

        /// <summary>
        /// Optional. By default the virtual machine will keep its existing boot option. Setting this property will
        /// trigger an internal process which will convert the virtual machine from using the existing boot option to
        /// another.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootConversion")]
        public virtual string BootConversion { get; set; }

        /// <summary>The VM Boot Option, as set in the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootOption")]
        public virtual string BootOption { get; set; }

        /// <summary>Compute instance scheduling information (if empty default is used).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeScheduling")]
        public virtual ComputeScheduling ComputeScheduling { get; set; }

        /// <summary>The disk type to use in the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>Optional. Defines whether the instance has integrity monitoring enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>Optional. Defines whether the instance has vTPM enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>Optional. The encryption to apply to the VM disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>The hostname to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>A map of labels to associate with the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The license type to use in OS adaptation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>The machine type to create the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The machine type series to create the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineTypeSeries")]
        public virtual string MachineTypeSeries { get; set; }

        /// <summary>The metadata key/value pairs to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>List of NICs connected to this VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>A list of network tags to associate with the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>The Google Cloud target project ID or project name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>
        /// Defines whether the instance has Secure Boot enabled. This can be set to true only if the VM boot option is
        /// EFI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secureBoot")]
        public virtual System.Nullable<bool> SecureBoot { get; set; }

        /// <summary>The service account to associate the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The name of the VM to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmName")]
        public virtual string VmName { get; set; }

        /// <summary>The zone in which to create the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Scheduling information for VM on maintenance/restart behaviour and node allocation in sole tenant nodes. Options
    /// for instance behavior when the host machine undergoes maintenance that may temporarily impact instance
    /// performance.
    /// </summary>
    public class ComputeScheduling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum number of virtual CPUs this instance will consume when running on a sole-tenant node. Ignored if
        /// no node_affinites are configured.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodeCpus")]
        public virtual System.Nullable<int> MinNodeCpus { get; set; }

        /// <summary>A set of node affinity and anti-affinity configurations for sole tenant nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeAffinities")]
        public virtual System.Collections.Generic.IList<SchedulingNodeAffinity> NodeAffinities { get; set; }

        /// <summary>
        /// How the instance should behave when the host machine undergoes maintenance that may temporarily impact
        /// instance performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onHostMaintenance")]
        public virtual string OnHostMaintenance { get; set; }

        /// <summary>
        /// Whether the Instance should be automatically restarted whenever it is terminated by Compute Engine (not
        /// terminated by user). This configuration is identical to `automaticRestart` field in Compute Engine create
        /// instance under scheduling. It was changed to an enum (instead of a boolean) to match the default value in
        /// Compute Engine which is automatic restart.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restartType")]
        public virtual string RestartType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CreatingImageStep contains specific step details.</summary>
    public class CreatingImageStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CutoverForecast holds information about future CutoverJobs of a MigratingVm.</summary>
    public class CutoverForecast : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Estimation of the CutoverJob duration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedCutoverJobDuration")]
        public virtual object EstimatedCutoverJobDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CutoverJob message describes a cutover of a migrating VM. The CutoverJob is the operation of shutting down the
    /// VM, creating a snapshot and cloning the VM using the replicated snapshot.
    /// </summary>
    public class CutoverJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Details of the target Persistent Disks in Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineDisksTargetDetails")]
        public virtual ComputeEngineDisksTargetDetails ComputeEngineDisksTargetDetails { get; set; }

        /// <summary>Output only. Details of the target VM in Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineTargetDetails")]
        public virtual ComputeEngineTargetDetails ComputeEngineTargetDetails { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time the cutover job was created (as an API call, not when it was actually created in the
        /// target).
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the cutover job had finished.</summary>
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

        /// <summary>Output only. Provides details for the errors that led to the Cutover Job's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Output only. The name of the cutover job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current progress in percentage of the cutover job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Output only. State of the cutover job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. A message providing possible extra details about the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _stateTimeRaw;

        private object _stateTime;

        /// <summary>Output only. The time the state was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTime")]
        public virtual string StateTimeRaw
        {
            get => _stateTimeRaw;
            set
            {
                _stateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _stateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StateTimeDateTimeOffset instead.")]
        public virtual object StateTime
        {
            get => _stateTime;
            set
            {
                _stateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _stateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StateTimeRaw);
            set => StateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The cutover steps list representing its progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<CutoverStep> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CutoverStep holds information about the cutover step progress.</summary>
    public class CutoverStep : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the step has ended.</summary>
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

        /// <summary>Final sync step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalSync")]
        public virtual ReplicationCycle FinalSync { get; set; }

        /// <summary>Instantiating migrated VM step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instantiatingMigratedVm")]
        public virtual InstantiatingMigratedVMStep InstantiatingMigratedVm { get; set; }

        /// <summary>Preparing VM disks step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preparingVmDisks")]
        public virtual PreparingVMDisksStep PreparingVmDisks { get; set; }

        /// <summary>A replication cycle prior cutover step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousReplicationCycle")]
        public virtual ReplicationCycle PreviousReplicationCycle { get; set; }

        /// <summary>Shutting down VM step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuttingDownSourceVm")]
        public virtual ShuttingDownSourceVMStep ShuttingDownSourceVm { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the step has started.</summary>
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

    /// <summary>CycleStep holds information about a step progress.</summary>
    public class CycleStep : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the cycle step has ended.</summary>
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

        /// <summary>Initializing replication step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializingReplication")]
        public virtual InitializingReplicationStep InitializingReplication { get; set; }

        /// <summary>Post processing step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postProcessing")]
        public virtual PostProcessingStep PostProcessing { get; set; }

        /// <summary>Replicating step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicating")]
        public virtual ReplicatingStep Replicating { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the cycle step has started.</summary>
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

    /// <summary>Mentions that the image import is not using OS adaptation process.</summary>
    public class DataDiskImageImport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DatacenterConnector message describes a connector between the Source and Google Cloud, which is installed on a
    /// vmware datacenter (an OVA vm installed by the user) to connect the Datacenter to Google Cloud and support vm
    /// migration data transfer.
    /// </summary>
    public class DatacenterConnector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Appliance OVA version. This is the OVA which is manually installed by the user and contains the
        /// infrastructure for the automatically updatable components on the appliance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applianceInfrastructureVersion")]
        public virtual string ApplianceInfrastructureVersion { get; set; }

        /// <summary>
        /// Output only. Appliance last installed update bundle version. This is the version of the automatically
        /// updatable components on the appliance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applianceSoftwareVersion")]
        public virtual string ApplianceSoftwareVersion { get; set; }

        /// <summary>Output only. The available versions for updating this appliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableVersions")]
        public virtual AvailableUpdates AvailableVersions { get; set; }

        /// <summary>Output only. The communication channel between the datacenter connector and Google Cloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time the connector was created (as an API call, not when it was actually installed).
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
        /// Output only. Provides details on the state of the Datacenter Connector in case of an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Output only. The connector's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. A unique key for this connector. This key is internal to the OVA connector and is supplied with
        /// its creation during the registration process and can not be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registrationId")]
        public virtual string RegistrationId { get; set; }

        /// <summary>The service account to use in the connector when communicating with the cloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. State of the DatacenterConnector, as determined by the health checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _stateTimeRaw;

        private object _stateTime;

        /// <summary>Output only. The time the state was last set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTime")]
        public virtual string StateTimeRaw
        {
            get => _stateTimeRaw;
            set
            {
                _stateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _stateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StateTimeDateTimeOffset instead.")]
        public virtual object StateTime
        {
            get => _stateTime;
            set
            {
                _stateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _stateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StateTimeRaw);
            set => StateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time the connector was updated with an API call.</summary>
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

        /// <summary>Output only. The status of the current / last upgradeAppliance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeStatus")]
        public virtual UpgradeStatus UpgradeStatus { get; set; }

        /// <summary>
        /// The version running in the DatacenterConnector. This is supplied by the OVA connector during the
        /// registration process and can not be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message describing a data disk.</summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The disk's Logical Unit Number (LUN).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lun")]
        public virtual System.Nullable<int> Lun { get; set; }

        /// <summary>The disk name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The disk size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains details about the image source used to create the disk.</summary>
    public class DiskImageDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Image resource used when creating the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImage")]
        public virtual string SourceImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The target details of the image resource that will be created by the import job.</summary>
    public class DiskImageTargetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional licenses to assign to the image. Format:
        /// https://www.googleapis.com/compute/v1/projects/PROJECT_ID/global/licenses/LICENSE_NAME Or
        /// https://www.googleapis.com/compute/beta/projects/PROJECT_ID/global/licenses/LICENSE_NAME
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLicenses")]
        public virtual System.Collections.Generic.IList<string> AdditionalLicenses { get; set; }

        /// <summary>Optional. Use to skip OS adaptation process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskImageImport")]
        public virtual DataDiskImageImport DataDiskImageImport { get; set; }

        /// <summary>Optional. An optional description of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Immutable. The encryption to apply to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>Optional. The name of the image family to which the new image belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>Required. The name of the image to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageName")]
        public virtual string ImageName { get; set; }

        /// <summary>Optional. A map of labels to associate with the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Use to set the parameters relevant for the OS adaptation process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osAdaptationParameters")]
        public virtual ImageImportOsAdaptationParameters OsAdaptationParameters { get; set; }

        /// <summary>
        /// Optional. Set to true to set the image storageLocations to the single region of the import job. When false,
        /// the closest multi-region is selected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleRegionStorage")]
        public virtual System.Nullable<bool> SingleRegionStorage { get; set; }

        /// <summary>
        /// Required. Reference to the TargetProject resource that represents the target project in which the imported
        /// image will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProject")]
        public virtual string TargetProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for a disk only migration.</summary>
    public class DisksMigrationDisksTargetDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for a disks-only migration.</summary>
    public class DisksMigrationDisksTargetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for creation of a VM that migrated data disks will be attached to.</summary>
    public class DisksMigrationVmTargetDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Additional licenses to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLicenses")]
        public virtual System.Collections.Generic.IList<string> AdditionalLicenses { get; set; }

        /// <summary>Optional. Details of the boot disk of the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskDefaults")]
        public virtual BootDiskDefaults BootDiskDefaults { get; set; }

        /// <summary>Optional. Compute instance scheduling information (if empty default is used).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeScheduling")]
        public virtual ComputeScheduling ComputeScheduling { get; set; }

        /// <summary>Optional. Defines whether the instance has integrity monitoring enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>Optional. Defines whether the instance has vTPM enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>Optional. The encryption to apply to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>Optional. The hostname to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Optional. A map of labels to associate with the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Required. The machine type to create the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Optional. The machine type series to create the VM with. For presentation only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineTypeSeries")]
        public virtual string MachineTypeSeries { get; set; }

        /// <summary>Optional. The metadata key/value pairs to assign to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>Optional. NICs to attach to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>Optional. A list of network tags to associate with the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>
        /// Optional. Defines whether the instance has Secure Boot enabled. This can be set to true only if the VM boot
        /// option is EFI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secureBoot")]
        public virtual System.Nullable<bool> SecureBoot { get; set; }

        /// <summary>Optional. The service account to associate the VM with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Required. The name of the VM to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmName")]
        public virtual string VmName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for the VM created VM as part of disks migration.</summary>
    public class DisksMigrationVmTargetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The URI of the Compute Engine VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmUri")]
        public virtual string VmUri { get; set; }

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

    /// <summary>Encryption message describes the details of the applied encryption.</summary>
    public class Encryption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the encryption key that is stored in Google Cloud KMS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Expiration holds information about the expiration of a MigratingVm.</summary>
    public class Expiration : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. Timestamp of when this resource is considered expired.</summary>
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

        /// <summary>Output only. Describes whether the expiration can be extended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendable")]
        public virtual System.Nullable<bool> Extendable { get; set; }

        /// <summary>Output only. The number of times expiration was extended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensionCount")]
        public virtual System.Nullable<int> ExtensionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'ExtendMigrationRequest' request.</summary>
    public class ExtendMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for fetchInventory.</summary>
    public class FetchInventoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the VMs in a Source of type AWS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsVms")]
        public virtual AwsVmsDetails AwsVms { get; set; }

        /// <summary>The description of the VMs in a Source of type Azure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureVms")]
        public virtual AzureVmsDetails AzureVms { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the source was last queried (if the result is from the cache).
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

        /// <summary>The description of the VMs in a Source of type Vmware.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareVms")]
        public virtual VmwareVmsDetails VmwareVms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'FinalizeMigration' request.</summary>
    public class FinalizeMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes message for 'Group' resource. The Group is a collections of several MigratingVms.</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The create time timestamp.</summary>
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

        /// <summary>User-provided description of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name is a user defined name for this group which can be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Immutable. The target type of this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationTargetType")]
        public virtual string MigrationTargetType { get; set; }

        /// <summary>Output only. The Group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The update time timestamp.</summary>
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

    /// <summary>ImageImport describes the configuration of the image import to run.</summary>
    public class ImageImport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The path to the Cloud Storage file from which the image should be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageUri")]
        public virtual string CloudStorageUri { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the image import was created.</summary>
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

        /// <summary>Immutable. Target details for importing a disk image, will be used by ImageImportJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskImageTargetDefaults")]
        public virtual DiskImageTargetDetails DiskImageTargetDefaults { get; set; }

        /// <summary>
        /// Immutable. The encryption details used by the image import process during the image adaptation for Compute
        /// Engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>Immutable. Target details for importing a machine image, will be used by ImageImportJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineImageTargetDefaults")]
        public virtual MachineImageTargetDetails MachineImageTargetDefaults { get; set; }

        /// <summary>Output only. The resource path of the ImageImport.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The result of the most recent runs for this ImageImport. All jobs for this ImageImport can be
        /// listed via ListImageImportJobs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentImageImportJobs")]
        public virtual System.Collections.Generic.IList<ImageImportJob> RecentImageImportJobs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ImageImportJob describes the progress and result of an image import.</summary>
    public class ImageImportJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The path to the Cloud Storage file from which the image should be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageUri")]
        public virtual string CloudStorageUri { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time the image import was created (as an API call, not when it was actually created in the
        /// target).
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

        /// <summary>Output only. The resource paths of the resources created by the image import job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdResources")]
        public virtual System.Collections.Generic.IList<string> CreatedResources { get; set; }

        /// <summary>Output only. Target details used to import a disk image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskImageTargetDetails")]
        public virtual DiskImageTargetDetails DiskImageTargetDetails { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the image import was ended.</summary>
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
        /// Output only. Provides details on the error that led to the image import state in case of an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Status> Errors { get; set; }

        /// <summary>Output only. Target details used to import a machine image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineImageTargetDetails")]
        public virtual MachineImageTargetDetails MachineImageTargetDetails { get; set; }

        /// <summary>Output only. The resource path of the ImageImportJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the image import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The image import steps list representing its progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<ImageImportStep> Steps { get; set; }

        /// <summary>Output only. Warnings that occurred during the image import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<MigrationWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters affecting the OS adaptation process.</summary>
    public class ImageImportOsAdaptationParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. By default the image will keep its existing boot option. Setting this property will trigger an
        /// internal process which will convert the image from using the existing boot option to another. The size of
        /// the boot disk might be increased to allow the conversion
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootConversion")]
        public virtual string BootConversion { get; set; }

        /// <summary>
        /// Optional. Set to true in order to generalize the imported image. The generalization process enables
        /// co-existence of multiple VMs created from the same image. For Windows, generalizing the image removes
        /// computer-specific information such as installed drivers and the computer security identifier (SID).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generalize")]
        public virtual System.Nullable<bool> Generalize { get; set; }

        /// <summary>Optional. Choose which type of license to apply to the imported image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ImageImportStep holds information about the image import step progress.</summary>
    public class ImageImportStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adapting OS step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptingOs")]
        public virtual AdaptingOSStep AdaptingOs { get; set; }

        /// <summary>Creating image step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatingImage")]
        public virtual CreatingImageStep CreatingImage { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the step has ended.</summary>
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

        /// <summary>Initializing step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializing")]
        public virtual InitializingImageImportStep Initializing { get; set; }

        /// <summary>Loading source files step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadingSourceFiles")]
        public virtual LoadingImageSourceFilesStep LoadingSourceFiles { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The time the step has started.</summary>
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

    /// <summary>InitializingImageImportStep contains specific step details.</summary>
    public class InitializingImageImportStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>InitializingReplicationStep contains specific step details.</summary>
    public class InitializingReplicationStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>InstantiatingMigratedVMStep contains specific step details.</summary>
    public class InstantiatingMigratedVMStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a URL link.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes what the link offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The URL of the link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListCloneJobs' request.</summary>
    public class ListCloneJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of clone jobs response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloneJobs")]
        public virtual System.Collections.Generic.IList<CloneJob> CloneJobs { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListCutoverJobs' request.</summary>
    public class ListCutoverJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of cutover jobs response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cutoverJobs")]
        public virtual System.Collections.Generic.IList<CutoverJob> CutoverJobs { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListDatacenterConnectors' request.</summary>
    public class ListDatacenterConnectorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of sources response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datacenterConnectors")]
        public virtual System.Collections.Generic.IList<DatacenterConnector> DatacenterConnectors { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListGroups' request.</summary>
    public class ListGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of groups response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListImageImportJobs' call.</summary>
    public class ListImageImportJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of target response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageImportJobs")]
        public virtual System.Collections.Generic.IList<ImageImportJob> ImageImportJobs { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListImageImports' call.</summary>
    public class ListImageImportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of target response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageImports")]
        public virtual System.Collections.Generic.IList<ImageImport> ImageImports { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
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

    /// <summary>Response message for 'ListMigratingVms' request.</summary>
    public class ListMigratingVmsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of Migrating VMs response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migratingVms")]
        public virtual System.Collections.Generic.IList<MigratingVm> MigratingVms { get; set; }

        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
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

    /// <summary>Response message for 'ListReplicationCycles' request.</summary>
    public class ListReplicationCyclesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The list of replication cycles response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationCycles")]
        public virtual System.Collections.Generic.IList<ReplicationCycle> ReplicationCycles { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListSources' request.</summary>
    public class ListSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The list of sources response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<Source> Sources { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListTargetProjects' call.</summary>
    public class ListTargetProjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The list of target response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProjects")]
        public virtual System.Collections.Generic.IList<TargetProject> TargetProjects { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListUtilizationReports' request.</summary>
    public class ListUtilizationReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>Output only. The list of reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utilizationReports")]
        public virtual System.Collections.Generic.IList<UtilizationReport> UtilizationReports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LoadingImageSourceFilesStep contains specific step details.</summary>
    public class LoadingImageSourceFilesStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides a localized error message that is safe to return to the user which can be attached to an RPC error.
    /// </summary>
    public class LocalizedMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The locale used following the specification defined at https://www.rfc-editor.org/rfc/bcp/bcp47.txt.
        /// Examples are: "en-US", "fr-CH", "es-MX"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>The localized error message in the above locale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

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

    /// <summary>Parameters overriding decisions based on the source machine image configurations.</summary>
    public class MachineImageParametersOverrides : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The machine type to create the MachineImage with. If empty, the service will choose a relevant
        /// machine type based on the information from the source image. For more information about machine types,
        /// please refer to https://cloud.google.com/compute/docs/machine-resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The target details of the machine image resource that will be created by the image import job.
    /// </summary>
    public class MachineImageTargetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional licenses to assign to the instance created by the machine image. Format:
        /// https://www.googleapis.com/compute/v1/projects/PROJECT_ID/global/licenses/LICENSE_NAME Or
        /// https://www.googleapis.com/compute/beta/projects/PROJECT_ID/global/licenses/LICENSE_NAME
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLicenses")]
        public virtual System.Collections.Generic.IList<string> AdditionalLicenses { get; set; }

        /// <summary>Optional. An optional description of the machine image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Immutable. The encryption to apply to the machine image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>Optional. The labels to apply to the instance created by the machine image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Required. The name of the machine image to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineImageName")]
        public virtual string MachineImageName { get; set; }

        /// <summary>
        /// Optional. Parameters overriding decisions based on the source machine image configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineImageParametersOverrides")]
        public virtual MachineImageParametersOverrides MachineImageParametersOverrides { get; set; }

        /// <summary>
        /// Optional. The network interfaces to create with the instance created by the machine image. Internal and
        /// external IP addresses are ignored for machine image import.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>Optional. Use to set the parameters relevant for the OS adaptation process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osAdaptationParameters")]
        public virtual ImageImportOsAdaptationParameters OsAdaptationParameters { get; set; }

        /// <summary>Optional. The service account to assign to the instance created by the machine image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; }

        /// <summary>Optional. Shielded instance configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual ShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>
        /// Optional. Set to true to set the machine image storageLocations to the single region of the import job. When
        /// false, the closest multi-region is selected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleRegionStorage")]
        public virtual System.Nullable<bool> SingleRegionStorage { get; set; }

        /// <summary>Optional. Use to skip OS adaptation process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipOsAdaptation")]
        public virtual SkipOsAdaptation SkipOsAdaptation { get; set; }

        /// <summary>Optional. The tags to apply to the instance created by the machine image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Required. Reference to the TargetProject resource that represents the target project in which the imported
        /// machine image will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProject")]
        public virtual string TargetProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MigratingVm describes the VM that will be migrated from a Source environment and its replication state.
    /// </summary>
    public class MigratingVm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Details of the VM from an AWS source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsSourceVmDetails")]
        public virtual AwsSourceVmDetails AwsSourceVmDetails { get; set; }

        /// <summary>Output only. Details of the VM from an Azure source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureSourceVmDetails")]
        public virtual AzureSourceVmDetails AzureSourceVmDetails { get; set; }

        /// <summary>Details of the target Persistent Disks in Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineDisksTargetDefaults")]
        public virtual ComputeEngineDisksTargetDefaults ComputeEngineDisksTargetDefaults { get; set; }

        /// <summary>Details of the target VM in Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngineTargetDefaults")]
        public virtual ComputeEngineTargetDefaults ComputeEngineTargetDefaults { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time the migrating VM was created (this refers to this resource and not to the time it was
        /// installed in the source).
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

        /// <summary>Output only. Details of the current running replication cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSyncInfo")]
        public virtual ReplicationCycle CurrentSyncInfo { get; set; }

        /// <summary>
        /// Output only. Provides details of future CutoverJobs of a MigratingVm. Set to empty when cutover forecast is
        /// unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cutoverForecast")]
        public virtual CutoverForecast CutoverForecast { get; set; }

        /// <summary>The description attached to the migrating VM by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The display name attached to the MigratingVm by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Provides details on the state of the Migrating VM in case of an error in replication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Output only. Provides details about the expiration state of the migrating VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual Expiration Expiration { get; set; }

        /// <summary>
        /// Output only. The group this migrating vm is included in, if any. The group is represented by the full path
        /// of the appropriate Group resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The labels of the migrating VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Details of the last replication cycle. This will be updated whenever a replication cycle is
        /// finished and is not to be confused with last_sync which is only updated on successful replication cycles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastReplicationCycle")]
        public virtual ReplicationCycle LastReplicationCycle { get; set; }

        /// <summary>
        /// Output only. The most updated snapshot created time in the source that finished replication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSync")]
        public virtual ReplicationSync LastSync { get; set; }

        /// <summary>Output only. The identifier of the MigratingVm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The replication schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual SchedulePolicy Policy { get; set; }

        /// <summary>
        /// Output only. The recent clone jobs performed on the migrating VM. This field holds the vm's last completed
        /// clone job and the vm's running clone job, if one exists. Note: To have this field populated you need to
        /// explicitly request it via the "view" parameter of the Get/List request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentCloneJobs")]
        public virtual System.Collections.Generic.IList<CloneJob> RecentCloneJobs { get; set; }

        /// <summary>
        /// Output only. The recent cutover jobs performed on the migrating VM. This field holds the vm's last completed
        /// cutover job and the vm's running cutover job, if one exists. Note: To have this field populated you need to
        /// explicitly request it via the "view" parameter of the Get/List request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentCutoverJobs")]
        public virtual System.Collections.Generic.IList<CutoverJob> RecentCutoverJobs { get; set; }

        /// <summary>
        /// The unique ID of the VM in the source. The VM's name in vSphere can be changed, so this is not the VM's name
        /// but rather its moRef id. This id is of the form vm-.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceVmId")]
        public virtual string SourceVmId { get; set; }

        /// <summary>Output only. State of the MigratingVm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _stateTimeRaw;

        private object _stateTime;

        /// <summary>Output only. The last time the migrating VM state was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTime")]
        public virtual string StateTimeRaw
        {
            get => _stateTimeRaw;
            set
            {
                _stateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _stateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StateTimeDateTimeOffset instead.")]
        public virtual object StateTime
        {
            get => _stateTime;
            set
            {
                _stateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _stateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StateTimeRaw);
            set => StateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time the migrating VM resource was updated.</summary>
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

        /// <summary>Output only. Details of the VM from a Vmware source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareSourceVmDetails")]
        public virtual VmwareSourceVmDetails VmwareSourceVmDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents migration resource error information that can be used with google.rpc.Status message. MigrationError
    /// is used to present the user with error information in migration operations.
    /// </summary>
    public class MigrationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Suggested action for solving the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionItem")]
        public virtual LocalizedMessage ActionItem { get; set; }

        /// <summary>Output only. The error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Output only. The localized error message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual LocalizedMessage ErrorMessage { get; set; }

        private string _errorTimeRaw;

        private object _errorTime;

        /// <summary>Output only. The time the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorTime")]
        public virtual string ErrorTimeRaw
        {
            get => _errorTimeRaw;
            set
            {
                _errorTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _errorTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ErrorTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ErrorTimeDateTimeOffset instead.")]
        public virtual object ErrorTime
        {
            get => _errorTime;
            set
            {
                _errorTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _errorTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ErrorTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ErrorTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ErrorTimeRaw);
            set => ErrorTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. URL(s) pointing to additional information on handling the current error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpLinks")]
        public virtual System.Collections.Generic.IList<Link> HelpLinks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents migration resource warning information that can be used with google.rpc.Status message.
    /// MigrationWarning is used to present the user with warning information in migration operations.
    /// </summary>
    public class MigrationWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Suggested action for solving the warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionItem")]
        public virtual LocalizedMessage ActionItem { get; set; }

        /// <summary>The warning code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Output only. URL(s) pointing to additional information on handling the current warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpLinks")]
        public virtual System.Collections.Generic.IList<Link> HelpLinks { get; set; }

        /// <summary>Output only. The localized warning message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningMessage")]
        public virtual LocalizedMessage WarningMessage { get; set; }

        private string _warningTimeRaw;

        private object _warningTime;

        /// <summary>The time the warning occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningTime")]
        public virtual string WarningTimeRaw
        {
            get => _warningTimeRaw;
            set
            {
                _warningTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _warningTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="WarningTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use WarningTimeDateTimeOffset instead.")]
        public virtual object WarningTime
        {
            get => _warningTime;
            set
            {
                _warningTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _warningTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="WarningTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? WarningTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(WarningTimeRaw);
            set => WarningTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NetworkInterface represents a NIC of a VM.</summary>
    public class NetworkInterface : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The external IP to define in the NIC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>
        /// Optional. The internal IP to define in the NIC. The formats accepted are: `ephemeral` \ ipv4 address \ a
        /// named address resource full path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>The network to connect the NIC to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The networking tier used for optimizing connectivity between instances and systems on the
        /// internet. Applies only for external ephemeral IP addresses. If left empty, will default to PREMIUM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTier")]
        public virtual string NetworkTier { get; set; }

        /// <summary>Optional. The subnetwork to connect the NIC to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message describing the VM's OS. Including OS, Publisher, Offer and Plan if applicable.</summary>
    public class OSDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OS offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offer")]
        public virtual string Offer { get; set; }

        /// <summary>OS plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual string Plan { get; set; }

        /// <summary>OS publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual string Publisher { get; set; }

        /// <summary>OS type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message describing the OS disk.</summary>
    public class OSDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The disk's full name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The disk's size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>The disk's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>Request message for 'PauseMigration' request.</summary>
    public class PauseMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a created Persistent Disk.</summary>
    public class PersistentDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the Persistent Disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskUri")]
        public virtual string DiskUri { get; set; }

        /// <summary>The ordinal number of the source VM disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDiskNumber")]
        public virtual System.Nullable<int> SourceDiskNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for creation of a Persistent Disk.</summary>
    public class PersistentDiskDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A map of labels to associate with the Persistent Disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalLabels { get; set; }

        /// <summary>Optional. The name of the Persistent Disk to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskName")]
        public virtual string DiskName { get; set; }

        /// <summary>The disk type to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>Optional. The encryption to apply to the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>Required. The ordinal number of the source VM disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDiskNumber")]
        public virtual System.Nullable<int> SourceDiskNumber { get; set; }

        /// <summary>
        /// Optional. Details for attachment of the disk to a VM. Used when the disk is set to be attached to a target
        /// VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmAttachmentDetails")]
        public virtual VmAttachmentDetails VmAttachmentDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PostProcessingStep contains specific step details.</summary>
    public class PostProcessingStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PreparingVMDisksStep contains specific step details.</summary>
    public class PreparingVMDisksStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'RemoveMigration' request.</summary>
    public class RemoveGroupMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The MigratingVm to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migratingVm")]
        public virtual string MigratingVm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ReplicatingStep contains specific step details.</summary>
    public class ReplicatingStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source disks replication rate for the last 30 minutes in bytes per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastThirtyMinutesAverageBytesPerSecond")]
        public virtual System.Nullable<long> LastThirtyMinutesAverageBytesPerSecond { get; set; }

        /// <summary>The source disks replication rate for the last 2 minutes in bytes per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTwoMinutesAverageBytesPerSecond")]
        public virtual System.Nullable<long> LastTwoMinutesAverageBytesPerSecond { get; set; }

        /// <summary>Replicated bytes in the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicatedBytes")]
        public virtual System.Nullable<long> ReplicatedBytes { get; set; }

        /// <summary>Total bytes to be handled in the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytes")]
        public virtual System.Nullable<long> TotalBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ReplicationCycle contains information about the current replication cycle status.</summary>
    public class ReplicationCycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cycle's ordinal number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycleNumber")]
        public virtual System.Nullable<int> CycleNumber { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the replication cycle has ended.</summary>
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

        /// <summary>Output only. Provides details on the state of the cycle in case of an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The identifier of the ReplicationCycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The current progress in percentage of this cycle. Was replaced by 'steps' field, which breaks down the cycle
        /// progression more accurately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the replication cycle has started.</summary>
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

        /// <summary>State of the ReplicationCycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The cycle's steps list representing its progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<CycleStep> Steps { get; set; }

        /// <summary>The accumulated duration the replication cycle was paused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPauseDuration")]
        public virtual object TotalPauseDuration { get; set; }

        /// <summary>Output only. Warnings that occurred during the cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<MigrationWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ReplicationSync contain information about the last replica sync to the cloud.</summary>
    public class ReplicationSync : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastSyncTimeRaw;

        private object _lastSyncTime;

        /// <summary>The most updated snapshot created time in the source that finished replication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual string LastSyncTimeRaw
        {
            get => _lastSyncTimeRaw;
            set
            {
                _lastSyncTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSyncTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastSyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSyncTimeDateTimeOffset instead.")]
        public virtual object LastSyncTime
        {
            get => _lastSyncTime;
            set
            {
                _lastSyncTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSyncTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastSyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSyncTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSyncTimeRaw);
            set => LastSyncTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'ResumeMigration' request.</summary>
    public class ResumeMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A policy for scheduling replications.</summary>
    public class SchedulePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The idle duration between replication stages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleDuration")]
        public virtual object IdleDuration { get; set; }

        /// <summary>
        /// A flag to indicate whether to skip OS adaptation during the replication sync. OS adaptation is a process
        /// where the VM's operating system undergoes changes and adaptations to fully function on Compute Engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipOsAdaptation")]
        public virtual System.Nullable<bool> SkipOsAdaptation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Node Affinity: the configuration of desired nodes onto which this Instance could be scheduled. Based on
    /// https://cloud.google.com/compute/docs/reference/rest/v1/instances/setScheduling
    /// </summary>
    public class SchedulingNodeAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label key of Node resource to reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The operator to use for the node resources specified in the `values` parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>Corresponds to the label values of Node resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Service account to assign to the instance created by the machine image.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The email address of the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Optional. The list of scopes to be made available for this service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Shielded instance configuration.</summary>
    public class ShieldedInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Defines whether the instance created by the machine image has integrity monitoring enabled. This
        /// can be set to true only if the image boot option is EFI, and vTPM is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>
        /// Optional. Defines whether the instance created by the machine image has vTPM enabled. This can be set to
        /// true only if the image boot option is EFI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>
        /// Optional. Defines whether the instance created by the machine image has Secure Boot enabled. This can be set
        /// to true only if the image boot option is EFI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secureBoot")]
        public virtual string SecureBoot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ShuttingDownSourceVMStep contains specific step details.</summary>
    public class ShuttingDownSourceVMStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mentions that the machine image import is not using OS adaptation process.</summary>
    public class SkipOsAdaptation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Source message describes a specific vm migration Source resource. It contains the source environment
    /// information.
    /// </summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AWS type source details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aws")]
        public virtual AwsSourceDetails Aws { get; set; }

        /// <summary>Azure type source details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azure")]
        public virtual AzureSourceDetails Azure { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The create time timestamp.</summary>
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

        /// <summary>User-provided description of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Immutable. The encryption details of the source data stored by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual Encryption Encryption { get; set; }

        /// <summary>The labels of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The Source name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The update time timestamp.</summary>
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

        /// <summary>Vmware type source details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmware")]
        public virtual VmwareSourceDetails Vmware { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'StartMigrationRequest' request.</summary>
    public class StartMigrationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Tag is an AWS tag representation.</summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Key of tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Required. Value of tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TargetProject message represents a target Compute Engine project for a migration or a clone.</summary>
    public class TargetProject : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time this target project resource was created (not related to when the Compute Engine
        /// project it points to was created).
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

        /// <summary>The target project's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The name of the target project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The target project ID (number) or project name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time the target project resource was updated.</summary>
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

    /// <summary>Request message for 'UpgradeAppliance' request.</summary>
    public class UpgradeApplianceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A request ID to identify requests. Specify a unique request ID so that if you must retry your request, the
        /// server will know to ignore the request if it has already been completed. The server will guarantee that for
        /// at least 60 minutes after the first request. For example, consider a situation where you make an initial
        /// request and the request times out. If you make the request again with the same request ID, the server can
        /// check if original operation with the same request ID was received, and if so, will ignore the second
        /// request. This prevents clients from accidentally creating duplicate commitments. The request ID must be a
        /// valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UpgradeStatus contains information about upgradeAppliance operation.</summary>
    public class UpgradeStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Provides details on the state of the upgrade operation in case of an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The version from which we upgraded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousVersion")]
        public virtual string PreviousVersion { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the operation was started.</summary>
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

        /// <summary>The state of the upgradeAppliance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The version to upgrade to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Utilization report details the utilization (CPU, memory, etc.) of selected source VMs.</summary>
    public class UtilizationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time the report was created (this refers to the time of the request, not the time the
        /// report creation completed).
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

        /// <summary>The report display name, as assigned by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Provides details on the state of the report in case of an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        private string _frameEndTimeRaw;

        private object _frameEndTime;

        /// <summary>
        /// Output only. The point in time when the time frame ends. Notice that the time frame is counted backwards.
        /// For instance if the "frame_end_time" value is 2021/01/20 and the time frame is WEEK then the report covers
        /// the week between 2021/01/20 and 2021/01/14.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameEndTime")]
        public virtual string FrameEndTimeRaw
        {
            get => _frameEndTimeRaw;
            set
            {
                _frameEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _frameEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FrameEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FrameEndTimeDateTimeOffset instead.")]
        public virtual object FrameEndTime
        {
            get => _frameEndTime;
            set
            {
                _frameEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _frameEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FrameEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FrameEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FrameEndTimeRaw);
            set => FrameEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The report unique name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Current state of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _stateTimeRaw;

        private object _stateTime;

        /// <summary>Output only. The time the state was last set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTime")]
        public virtual string StateTimeRaw
        {
            get => _stateTimeRaw;
            set
            {
                _stateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _stateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StateTimeDateTimeOffset instead.")]
        public virtual object StateTime
        {
            get => _stateTime;
            set
            {
                _stateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _stateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StateTimeRaw);
            set => StateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Time frame of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeFrame")]
        public virtual string TimeFrame { get; set; }

        /// <summary>Output only. Total number of VMs included in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmCount")]
        public virtual System.Nullable<int> VmCount { get; set; }

        /// <summary>
        /// List of utilization information per VM. When sent as part of the request, the "vm_id" field is used in order
        /// to specify which VMs to include in the report. In that case all other fields are ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vms")]
        public virtual System.Collections.Generic.IList<VmUtilizationInfo> Vms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for attachment of the disk to a VM.</summary>
    public class VmAttachmentDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies a unique device name of your choice that is reflected into the /dev/disk/by-id/google-*
        /// tree of a Linux operating system running within the instance. If not specified, the server chooses a default
        /// device name to apply to this disk, in the form persistent-disk-x, where x is a number assigned by Google
        /// Compute Engine. This field is only applicable for persistent disks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Migrating VM source information about the VM capabilities needed for some Compute Engine features.
    /// </summary>
    public class VmCapabilities : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastOsCapabilitiesUpdateTimeRaw;

        private object _lastOsCapabilitiesUpdateTime;

        /// <summary>Output only. The last time OS capabilities list was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastOsCapabilitiesUpdateTime")]
        public virtual string LastOsCapabilitiesUpdateTimeRaw
        {
            get => _lastOsCapabilitiesUpdateTimeRaw;
            set
            {
                _lastOsCapabilitiesUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastOsCapabilitiesUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastOsCapabilitiesUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastOsCapabilitiesUpdateTimeDateTimeOffset instead.")]
        public virtual object LastOsCapabilitiesUpdateTime
        {
            get => _lastOsCapabilitiesUpdateTime;
            set
            {
                _lastOsCapabilitiesUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastOsCapabilitiesUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastOsCapabilitiesUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastOsCapabilitiesUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastOsCapabilitiesUpdateTimeRaw);
            set => LastOsCapabilitiesUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Unordered list. List of certain VM OS capabilities needed for some Compute Engine features.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osCapabilities")]
        public virtual System.Collections.Generic.IList<string> OsCapabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Utilization information of a single VM.</summary>
    public class VmUtilizationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Utilization metrics for this VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utilization")]
        public virtual VmUtilizationMetrics Utilization { get; set; }

        /// <summary>The VM's ID in the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The description of the VM in a Source of type Vmware.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareVmDetails")]
        public virtual VmwareVmDetails VmwareVmDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Utilization metrics values for a single VM.</summary>
    public class VmUtilizationMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average CPU usage, percent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuAveragePercent")]
        public virtual System.Nullable<int> CpuAveragePercent { get; set; }

        /// <summary>Max CPU usage, percent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuMaxPercent")]
        public virtual System.Nullable<int> CpuMaxPercent { get; set; }

        /// <summary>Average disk IO rate, in kilobytes per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskIoRateAverageKbps")]
        public virtual System.Nullable<long> DiskIoRateAverageKbps { get; set; }

        /// <summary>Max disk IO rate, in kilobytes per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskIoRateMaxKbps")]
        public virtual System.Nullable<long> DiskIoRateMaxKbps { get; set; }

        /// <summary>Average memory usage, percent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryAveragePercent")]
        public virtual System.Nullable<int> MemoryAveragePercent { get; set; }

        /// <summary>Max memory usage, percent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMaxPercent")]
        public virtual System.Nullable<int> MemoryMaxPercent { get; set; }

        /// <summary>
        /// Average network throughput (combined transmit-rates and receive-rates), in kilobytes per second.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkThroughputAverageKbps")]
        public virtual System.Nullable<long> NetworkThroughputAverageKbps { get; set; }

        /// <summary>
        /// Max network throughput (combined transmit-rates and receive-rates), in kilobytes per second.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkThroughputMaxKbps")]
        public virtual System.Nullable<long> NetworkThroughputMaxKbps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a Vmware VM disk.</summary>
    public class VmwareDiskDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ordinal number of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskNumber")]
        public virtual System.Nullable<int> DiskNumber { get; set; }

        /// <summary>Output only. The disk label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. Size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<long> SizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareSourceDetails message describes a specific source details for the vmware source type.</summary>
    public class VmwareSourceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. The credentials password. This is write only and can not be read in a GET operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The hostname of the vcenter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedVcenterHost")]
        public virtual string ResolvedVcenterHost { get; set; }

        /// <summary>The thumbprint representing the certificate for the vcenter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbprint")]
        public virtual string Thumbprint { get; set; }

        /// <summary>The credentials username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ip address of the vcenter this Source represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenterIp")]
        public virtual string VcenterIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the source Vmware VM details.</summary>
    public class VmwareSourceVmDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The VM architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. The total size of the disks being migrated in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("committedStorageBytes")]
        public virtual System.Nullable<long> CommittedStorageBytes { get; set; }

        /// <summary>Output only. The disks attached to the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<VmwareDiskDetails> Disks { get; set; }

        /// <summary>Output only. The firmware type of the source VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firmware")]
        public virtual string Firmware { get; set; }

        /// <summary>Output only. Information about VM capabilities needed for some Compute Engine features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmCapabilitiesInfo")]
        public virtual VmCapabilities VmCapabilitiesInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareVmDetails describes a VM in vCenter.</summary>
    public class VmwareVmDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The CPU architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. The VM Boot Option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootOption")]
        public virtual string BootOption { get; set; }

        /// <summary>The total size of the storage allocated to the VM in MB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("committedStorageMb")]
        public virtual System.Nullable<long> CommittedStorageMb { get; set; }

        /// <summary>The number of cpus in the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCount")]
        public virtual System.Nullable<int> CpuCount { get; set; }

        /// <summary>The descriptive name of the vCenter's datacenter this VM is contained in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datacenterDescription")]
        public virtual string DatacenterDescription { get; set; }

        /// <summary>The id of the vCenter's datacenter this VM is contained in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datacenterId")]
        public virtual string DatacenterId { get; set; }

        /// <summary>The number of disks the VM has.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskCount")]
        public virtual System.Nullable<int> DiskCount { get; set; }

        /// <summary>The display name of the VM. Note that this is not necessarily unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The VM's OS. See for example
        /// https://vdc-repo.vmware.com/vmwb-repository/dcr-public/da47f910-60ac-438b-8b9b-6122f4d14524/16b7274a-bf8b-4b4c-a05e-746f2aa93c8c/doc/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html
        /// for types of strings this might hold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestDescription")]
        public virtual string GuestDescription { get; set; }

        /// <summary>The size of the memory of the VM in MB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMb")]
        public virtual System.Nullable<int> MemoryMb { get; set; }

        /// <summary>The power state of the VM at the moment list was taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("powerState")]
        public virtual string PowerState { get; set; }

        /// <summary>The unique identifier of the VM in vCenter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uuid")]
        public virtual string Uuid { get; set; }

        /// <summary>
        /// The VM's id in the source (note that this is not the MigratingVm's id). This is the moref id of the VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareVmsDetails describes VMs in vCenter.</summary>
    public class VmwareVmsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of the vmware VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<VmwareVmDetails> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
