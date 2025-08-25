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

namespace Google.Apis.BigtableAdmin.v2
{
    /// <summary>The BigtableAdmin Service.</summary>
    public class BigtableAdminService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BigtableAdminService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BigtableAdminService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://bigtableadmin.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://bigtableadmin.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigtableadmin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Bigtable Admin API.</summary>
        public class Scope
        {
            /// <summary>Administer your Cloud Bigtable tables and clusters</summary>
            public static string BigtableAdmin = "https://www.googleapis.com/auth/bigtable.admin";

            /// <summary>Administer your Cloud Bigtable clusters</summary>
            public static string BigtableAdminCluster = "https://www.googleapis.com/auth/bigtable.admin.cluster";

            /// <summary>Administer your Cloud Bigtable clusters</summary>
            public static string BigtableAdminInstance = "https://www.googleapis.com/auth/bigtable.admin.instance";

            /// <summary>Administer your Cloud Bigtable tables</summary>
            public static string BigtableAdminTable = "https://www.googleapis.com/auth/bigtable.admin.table";

            /// <summary>Administer your Cloud Bigtable tables and clusters</summary>
            public static string CloudBigtableAdmin = "https://www.googleapis.com/auth/cloud-bigtable.admin";

            /// <summary>Administer your Cloud Bigtable clusters</summary>
            public static string CloudBigtableAdminCluster = "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster";

            /// <summary>Administer your Cloud Bigtable tables</summary>
            public static string CloudBigtableAdminTable = "https://www.googleapis.com/auth/cloud-bigtable.admin.table";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Bigtable Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Administer your Cloud Bigtable tables and clusters</summary>
            public const string BigtableAdmin = "https://www.googleapis.com/auth/bigtable.admin";

            /// <summary>Administer your Cloud Bigtable clusters</summary>
            public const string BigtableAdminCluster = "https://www.googleapis.com/auth/bigtable.admin.cluster";

            /// <summary>Administer your Cloud Bigtable clusters</summary>
            public const string BigtableAdminInstance = "https://www.googleapis.com/auth/bigtable.admin.instance";

            /// <summary>Administer your Cloud Bigtable tables</summary>
            public const string BigtableAdminTable = "https://www.googleapis.com/auth/bigtable.admin.table";

            /// <summary>Administer your Cloud Bigtable tables and clusters</summary>
            public const string CloudBigtableAdmin = "https://www.googleapis.com/auth/cloud-bigtable.admin";

            /// <summary>Administer your Cloud Bigtable clusters</summary>
            public const string CloudBigtableAdminCluster = "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster";

            /// <summary>Administer your Cloud Bigtable tables</summary>
            public const string CloudBigtableAdminTable = "https://www.googleapis.com/auth/cloud-bigtable.admin.table";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for BigtableAdmin requests.</summary>
    public abstract class BigtableAdminBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BigtableAdminBaseServiceRequest instance.</summary>
        protected BigtableAdminBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes BigtableAdmin parameter list.</summary>
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
            Projects = new ProjectsResource(service);
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

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
                Operations = new OperationsResource(service);
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
                public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListOperationsResponse>
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
                    public override string RestPath => "v2/{+name}/operations";

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
                            Pattern = @"^operations/projects/.*$",
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

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
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
            public override string RestPath => "v2/{+name}";

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
            Locations = new LocationsResource(service);
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
                AppProfiles = new AppProfilesResource(service);
                Clusters = new ClustersResource(service);
                LogicalViews = new LogicalViewsResource(service);
                MaterializedViews = new MaterializedViewsResource(service);
                Tables = new TablesResource(service);
            }

            /// <summary>Gets the AppProfiles resource.</summary>
            public virtual AppProfilesResource AppProfiles { get; }

            /// <summary>The "appProfiles" collection of methods.</summary>
            public class AppProfilesResource
            {
                private const string Resource = "appProfiles";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AppProfilesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates an app profile within an instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The unique name of the instance in which to create the new app profile. Values are of the
                /// form `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.AppProfile body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates an app profile within an instance.</summary>
                public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.AppProfile>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.AppProfile body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance in which to create the new app profile. Values are of
                    /// the form `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to be used when referring to the new app profile within its instance, e.g.,
                    /// just `myprofile` rather than `projects/myproject/instances/myinstance/appProfiles/myprofile`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appProfileId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AppProfileId { get; set; }

                    /// <summary>If true, ignore safety checks when creating the app profile.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreWarnings", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.AppProfile Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/appProfiles";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                        RequestParameters.Add("appProfileId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appProfileId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ignoreWarnings", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreWarnings",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes an app profile from an instance.</summary>
                /// <param name="name">
                /// Required. The unique name of the app profile to be deleted. Values are of the form
                /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes an app profile from an instance.</summary>
                public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the app profile to be deleted. Values are of the form
                    /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. If true, ignore safety checks when deleting the app profile.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreWarnings", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/appProfiles/[^/]+$",
                        });
                        RequestParameters.Add("ignoreWarnings", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreWarnings",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets information about an app profile.</summary>
                /// <param name="name">
                /// Required. The unique name of the requested app profile. Values are of the form
                /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about an app profile.</summary>
                public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.AppProfile>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the requested app profile. Values are of the form
                    /// `projects/{project}/instances/{instance}/appProfiles/{app_profile}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/appProfiles/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists information about app profiles in an instance.</summary>
                /// <param name="parent">
                /// Required. The unique name of the instance for which a list of app profiles is requested. Values are
                /// of the form `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list AppProfiles
                /// for all Instances in a project, e.g., `projects/myproject/instances/-`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists information about app profiles in an instance.</summary>
                public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListAppProfilesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance for which a list of app profiles is requested. Values
                    /// are of the form `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list
                    /// AppProfiles for all Instances in a project, e.g., `projects/myproject/instances/-`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Maximum number of results per page. A page_size of zero lets the server choose the number of
                    /// items to return. A page_size which is strictly positive will return at most that many items. A
                    /// negative page_size will cause an error. Following the first request, subsequent paginated calls
                    /// are not required to pass a page_size. If a page_size is set in subsequent calls, it must match
                    /// the page_size given in the first request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value of `next_page_token` returned by a previous call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/appProfiles";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

                /// <summary>Updates an app profile within an instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The unique name of the app profile, up to 50 characters long. Values are of the form
                /// `projects/{project}/instances/{instance}/appProfiles/_a-zA-Z0-9*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.AppProfile body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an app profile within an instance.</summary>
                public class PatchRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.AppProfile body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The unique name of the app profile, up to 50 characters long. Values are of the form
                    /// `projects/{project}/instances/{instance}/appProfiles/_a-zA-Z0-9*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>If true, ignore safety checks when updating the app profile.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreWarnings", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

                    /// <summary>
                    /// Required. The subset of app profile fields which should be replaced. If unset, all fields will
                    /// be replaced.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.AppProfile Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/appProfiles/[^/]+$",
                        });
                        RequestParameters.Add("ignoreWarnings", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreWarnings",
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
                    Backups = new BackupsResource(service);
                    HotTablets = new HotTabletsResource(service);
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
                    /// Copy a Cloud Bigtable backup to a new backup in the destination cluster located in the
                    /// destination instance and project.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the destination cluster that will contain the backup copy. The cluster
                    /// must already exist. Values are of the form:
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                    /// </param>
                    public virtual CopyRequest Copy(Google.Apis.BigtableAdmin.v2.Data.CopyBackupRequest body, string parent)
                    {
                        return new CopyRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Copy a Cloud Bigtable backup to a new backup in the destination cluster located in the
                    /// destination instance and project.
                    /// </summary>
                    public class CopyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Copy request.</summary>
                        public CopyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.CopyBackupRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the destination cluster that will contain the backup copy. The cluster
                        /// must already exist. Values are of the form:
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.CopyBackupRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "copy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/backups:copy";

                        /// <summary>Initializes Copy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Starts creating a new Cloud Bigtable Backup. The returned backup long-running operation can be
                    /// used to track creation of the backup. The metadata field type is CreateBackupMetadata. The
                    /// response field type is Backup, if successful. Cancelling the returned operation will stop the
                    /// creation and delete the backup.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. This must be one of the clusters in the instance in which this table is located. The
                    /// backup will be stored in this cluster. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.Backup body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Starts creating a new Cloud Bigtable Backup. The returned backup long-running operation can be
                    /// used to track creation of the backup. The metadata field type is CreateBackupMetadata. The
                    /// response field type is Backup, if successful. Cancelling the returned operation will stop the
                    /// creation and delete the backup.
                    /// </summary>
                    public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Backup body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. This must be one of the clusters in the instance in which this table is located.
                        /// The backup will be stored in this cluster. Values are of the form
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The id of the backup to be created. The `backup_id` along with the parent `parent`
                        /// are combined as {parent}/backups/{backup_id} to create the full backup name, of the form:
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`. This
                        /// string must be between 1 and 50 characters in length and match the regex _a-zA-Z0-9*.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("backupId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string BackupId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.Backup Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Deletes a pending or completed Cloud Bigtable backup.</summary>
                    /// <param name="name">
                    /// Required. Name of the backup to delete. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a pending or completed Cloud Bigtable backup.</summary>
                    public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the backup to delete. Values are of the form
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets metadata on a pending or completed Cloud Bigtable Backup.</summary>
                    /// <param name="name">
                    /// Required. Name of the backup. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets metadata on a pending or completed Cloud Bigtable Backup.</summary>
                    public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Backup>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the backup. Values are of the form
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                    /// exists but does not have a policy set.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                    /// exists but does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Cloud Bigtable backups. Returns both completed and pending backups.</summary>
                    /// <param name="parent">
                    /// Required. The cluster to list backups from. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}`. Use `{cluster} = '-'` to list
                    /// backups for all clusters in an instance, e.g.,
                    /// `projects/{project}/instances/{instance}/clusters/-`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Cloud Bigtable backups. Returns both completed and pending backups.</summary>
                    public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListBackupsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The cluster to list backups from. Values are of the form
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}`. Use `{cluster} = '-'` to list
                        /// backups for all clusters in an instance, e.g.,
                        /// `projects/{project}/instances/{instance}/clusters/-`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A filter expression that filters backups listed in the response. The expression must specify
                        /// the field name, a comparison operator, and the value that you want to use for filtering. The
                        /// value must be a string, a number, or a boolean. The comparison operator must be &amp;lt;,
                        /// &amp;gt;, &amp;lt;=, &amp;gt;=, !=, =, or :. Colon ':' represents a HAS operator which is
                        /// roughly synonymous with equality. Filter rules are case insensitive. The fields eligible for
                        /// filtering are: * `name` * `source_table` * `state` * `start_time` (and values are of the
                        /// format YYYY-MM-DDTHH:MM:SSZ) * `end_time` (and values are of the format
                        /// YYYY-MM-DDTHH:MM:SSZ) * `expire_time` (and values are of the format YYYY-MM-DDTHH:MM:SSZ) *
                        /// `size_bytes` To filter on multiple expressions, provide each separate expression within
                        /// parentheses. By default, each expression is an AND expression. However, you can include AND,
                        /// OR, and NOT expressions explicitly. Some examples of using filters are: * `name:"exact"`
                        /// --&amp;gt; The backup's name is the string "exact". * `name:howl` --&amp;gt; The backup's
                        /// name contains the string "howl". * `source_table:prod` --&amp;gt; The source_table's name
                        /// contains the string "prod". * `state:CREATING` --&amp;gt; The backup is pending creation. *
                        /// `state:READY` --&amp;gt; The backup is fully created and ready for use. * `(name:howl) AND
                        /// (start_time &amp;lt; \"2018-03-28T14:50:00Z\")` --&amp;gt; The backup name contains the
                        /// string "howl" and start_time of the backup is before 2018-03-28T14:50:00Z. * `size_bytes
                        /// &amp;gt; 10000000000` --&amp;gt; The backup's size is greater than 10GB
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// An expression for specifying the sort order of the results of the request. The string value
                        /// should specify one or more fields in Backup. The full syntax is described at
                        /// https://aip.dev/132#ordering. Fields supported are: * name * source_table * expire_time *
                        /// start_time * end_time * size_bytes * state For example, "start_time". The default sorting
                        /// order is ascending. To specify descending order for the field, a suffix " desc" should be
                        /// appended to the field name. For example, "start_time desc". Redundant space characters in
                        /// the syntax are insigificant. If order_by is empty, results will be sorted by `start_time` in
                        /// descending order starting from the most recently created backup.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Number of backups to be returned in the response. If 0 or less, defaults to the server's
                        /// maximum allowed page size.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// If non-empty, `page_token` should contain a next_page_token from a previous
                        /// ListBackupsResponse to the same `parent` and with the same `filter`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/backups";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
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

                    /// <summary>Updates a pending or completed Cloud Bigtable Backup.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// A globally unique identifier for the backup which cannot be changed. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}/ backups/_a-zA-Z0-9*` The final
                    /// segment of the name must be between 1 and 50 characters in length. The backup is stored in the
                    /// cluster identified by the prefix of the backup name of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.Backup body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a pending or completed Cloud Bigtable Backup.</summary>
                    public class PatchRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Backup>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Backup body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// A globally unique identifier for the backup which cannot be changed. Values are of the form
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}/ backups/_a-zA-Z0-9*` The final
                        /// segment of the name must be between 1 and 50 characters in length. The backup is stored in
                        /// the cluster identified by the prefix of the backup name of the form
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. A mask specifying which fields (e.g. `expire_time`) in the Backup resource should
                        /// be updated. This mask is relative to the Backup resource, not to the request message. The
                        /// field mask must always be specified; this prevents any future fields from being erased
                        /// accidentally by clients that do not know about them.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.Backup Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+/backups/[^/]+$",
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
                    /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                    /// </summary>
                    public class SetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+/backups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                    public class TestIamPermissionsRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+/backups/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the HotTablets resource.</summary>
                public virtual HotTabletsResource HotTablets { get; }

                /// <summary>The "hotTablets" collection of methods.</summary>
                public class HotTabletsResource
                {
                    private const string Resource = "hotTablets";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public HotTabletsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists hot tablets in a cluster, within the time range provided. Hot tablets are ordered based on
                    /// CPU usage.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The cluster name to list hot tablets. Value is in the following form:
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists hot tablets in a cluster, within the time range provided. Hot tablets are ordered based on
                    /// CPU usage.
                    /// </summary>
                    public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListHotTabletsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The cluster name to list hot tablets. Value is in the following form:
                        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        private object _endTime;

                        /// <summary>
                        /// String representation of <see cref="EndTimeDateTimeOffset"/>, formatted for inclusion in the
                        /// HTTP request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string EndTimeRaw { get; private set; }

                        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
                        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
                        public virtual object EndTime
                        {
                            get => _endTime;
                            set
                            {
                                EndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                                _endTime = value;
                            }
                        }

                        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
                        {
                            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
                            set
                            {
                                EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                                _endTime = value;
                            }
                        }

                        /// <summary>
                        /// Maximum number of results per page. A page_size that is empty or zero lets the server choose
                        /// the number of items to return. A page_size which is strictly positive will return at most
                        /// that many items. A negative page_size will cause an error. Following the first request,
                        /// subsequent paginated calls do not need a page_size field. If a page_size is set in
                        /// subsequent calls, it must match the page_size given in the first request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The value of `next_page_token` returned by a previous call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        private object _startTime;

                        /// <summary>
                        /// String representation of <see cref="StartTimeDateTimeOffset"/>, formatted for inclusion in
                        /// the HTTP request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string StartTimeRaw { get; private set; }

                        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
                        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
                        public virtual object StartTime
                        {
                            get => _startTime;
                            set
                            {
                                StartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                                _startTime = value;
                            }
                        }

                        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
                        {
                            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
                            set
                            {
                                StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                                _startTime = value;
                            }
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/hotTablets";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
                            });
                            RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "endTime",
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
                            RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "startTime",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a cluster within an instance. Note that exactly one of Cluster.serve_nodes and
                /// Cluster.cluster_config.cluster_autoscaling_config can be set. If serve_nodes is set to non-zero,
                /// then the cluster is manually scaled. If cluster_config.cluster_autoscaling_config is non-empty, then
                /// autoscaling is enabled.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The unique name of the instance in which to create the new cluster. Values are of the form
                /// `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.Cluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a cluster within an instance. Note that exactly one of Cluster.serve_nodes and
                /// Cluster.cluster_config.cluster_autoscaling_config can be set. If serve_nodes is set to non-zero,
                /// then the cluster is manually scaled. If cluster_config.cluster_autoscaling_config is non-empty, then
                /// autoscaling is enabled.
                /// </summary>
                public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Cluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance in which to create the new cluster. Values are of the
                    /// form `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to be used when referring to the new cluster within its instance, e.g., just
                    /// `mycluster` rather than `projects/myproject/instances/myinstance/clusters/mycluster`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/clusters";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a cluster from an instance.</summary>
                /// <param name="name">
                /// Required. The unique name of the cluster to be deleted. Values are of the form
                /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a cluster from an instance.</summary>
                public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the cluster to be deleted. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets information about a cluster.</summary>
                /// <param name="name">
                /// Required. The unique name of the requested cluster. Values are of the form
                /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a cluster.</summary>
                public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the requested cluster. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists information about clusters in an instance.</summary>
                /// <param name="parent">
                /// Required. The unique name of the instance for which a list of clusters is requested. Values are of
                /// the form `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list Clusters for all
                /// Instances in a project, e.g., `projects/myproject/instances/-`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists information about clusters in an instance.</summary>
                public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance for which a list of clusters is requested. Values are
                    /// of the form `projects/{project}/instances/{instance}`. Use `{instance} = '-'` to list Clusters
                    /// for all Instances in a project, e.g., `projects/myproject/instances/-`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>DEPRECATED: This field is unused and ignored.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/clusters";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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
                /// Partially updates a cluster within a project. This method is the preferred way to update a Cluster.
                /// To enable and update autoscaling, set cluster_config.cluster_autoscaling_config. When autoscaling is
                /// enabled, serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it are ignored.
                /// Note that an update cannot simultaneously set serve_nodes to non-zero and
                /// cluster_config.cluster_autoscaling_config to non-empty, and also specify both in the update_mask. To
                /// disable autoscaling, clear cluster_config.cluster_autoscaling_config, and explicitly set a
                /// serve_node count via the update_mask.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The unique name of the cluster. Values are of the form
                /// `projects/{project}/instances/{instance}/clusters/a-z*`.
                /// </param>
                public virtual PartialUpdateClusterRequest PartialUpdateCluster(Google.Apis.BigtableAdmin.v2.Data.Cluster body, string name)
                {
                    return new PartialUpdateClusterRequest(this.service, body, name);
                }

                /// <summary>
                /// Partially updates a cluster within a project. This method is the preferred way to update a Cluster.
                /// To enable and update autoscaling, set cluster_config.cluster_autoscaling_config. When autoscaling is
                /// enabled, serve_nodes is treated as an OUTPUT_ONLY field, meaning that updates to it are ignored.
                /// Note that an update cannot simultaneously set serve_nodes to non-zero and
                /// cluster_config.cluster_autoscaling_config to non-empty, and also specify both in the update_mask. To
                /// disable autoscaling, clear cluster_config.cluster_autoscaling_config, and explicitly set a
                /// serve_node count via the update_mask.
                /// </summary>
                public class PartialUpdateClusterRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new PartialUpdateCluster request.</summary>
                    public PartialUpdateClusterRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Cluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The unique name of the cluster. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/a-z*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The subset of Cluster fields which should be replaced.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "partialUpdateCluster";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes PartialUpdateCluster parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
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
                /// Updates a cluster within an instance. Note that UpdateCluster does not support updating
                /// cluster_config.cluster_autoscaling_config. In order to update it, you must use PartialUpdateCluster.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The unique name of the cluster. Values are of the form
                /// `projects/{project}/instances/{instance}/clusters/a-z*`.
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.BigtableAdmin.v2.Data.Cluster body, string name)
                {
                    return new UpdateRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a cluster within an instance. Note that UpdateCluster does not support updating
                /// cluster_config.cluster_autoscaling_config. In order to update it, you must use PartialUpdateCluster.
                /// </summary>
                public class UpdateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Cluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The unique name of the cluster. Values are of the form
                    /// `projects/{project}/instances/{instance}/clusters/a-z*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.Cluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/clusters/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the LogicalViews resource.</summary>
            public virtual LogicalViewsResource LogicalViews { get; }

            /// <summary>The "logicalViews" collection of methods.</summary>
            public class LogicalViewsResource
            {
                private const string Resource = "logicalViews";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LogicalViewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a logical view within an instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent instance where this logical view will be created. Format:
                /// `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.LogicalView body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a logical view within an instance.</summary>
                public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.LogicalView body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent instance where this logical view will be created. Format:
                    /// `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the logical view, which will become the final component of the
                    /// logical view's resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("logicalViewId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LogicalViewId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.LogicalView Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/logicalViews";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                        RequestParameters.Add("logicalViewId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "logicalViewId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a logical view from an instance.</summary>
                /// <param name="name">
                /// Required. The unique name of the logical view to be deleted. Format:
                /// `projects/{project}/instances/{instance}/logicalViews/{logical_view}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a logical view from an instance.</summary>
                public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the logical view to be deleted. Format:
                    /// `projects/{project}/instances/{instance}/logicalViews/{logical_view}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The current etag of the logical view. If an etag is provided and does not match the
                    /// current etag of the logical view, deletion will be blocked and an ABORTED error will be
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/logicalViews/[^/]+$",
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

                /// <summary>Gets information about a logical view.</summary>
                /// <param name="name">
                /// Required. The unique name of the requested logical view. Values are of the form
                /// `projects/{project}/instances/{instance}/logicalViews/{logical_view}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a logical view.</summary>
                public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.LogicalView>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the requested logical view. Values are of the form
                    /// `projects/{project}/instances/{instance}/logicalViews/{logical_view}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/logicalViews/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for an instance resource. Returns an empty policy if an instance
                /// exists but does not have a policy set.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for an instance resource. Returns an empty policy if an instance
                /// exists but does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/logicalViews/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists information about logical views in an instance.</summary>
                /// <param name="parent">
                /// Required. The unique name of the instance for which the list of logical views is requested. Values
                /// are of the form `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists information about logical views in an instance.</summary>
                public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListLogicalViewsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance for which the list of logical views is requested.
                    /// Values are of the form `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of logical views to return. The service may return fewer than this
                    /// value
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListLogicalViews` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListLogicalViews` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/logicalViews";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

                /// <summary>Updates a logical view within an instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The unique name of the logical view. Format:
                /// `projects/{project}/instances/{instance}/logicalViews/{logical_view}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.LogicalView body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a logical view within an instance.</summary>
                public class PatchRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.LogicalView body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The unique name of the logical view. Format:
                    /// `projects/{project}/instances/{instance}/logicalViews/{logical_view}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.LogicalView Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/logicalViews/[^/]+$",
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
                /// Sets the access control policy on an instance resource. Replaces any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on an instance resource. Replaces any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/logicalViews/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns permissions that the caller has on the specified instance resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>Returns permissions that the caller has on the specified instance resource.</summary>
                public class TestIamPermissionsRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/logicalViews/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the MaterializedViews resource.</summary>
            public virtual MaterializedViewsResource MaterializedViews { get; }

            /// <summary>The "materializedViews" collection of methods.</summary>
            public class MaterializedViewsResource
            {
                private const string Resource = "materializedViews";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MaterializedViewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a materialized view within an instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent instance where this materialized view will be created. Format:
                /// `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.MaterializedView body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a materialized view within an instance.</summary>
                public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.MaterializedView body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent instance where this materialized view will be created. Format:
                    /// `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the materialized view, which will become the final component of the
                    /// materialized view's resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("materializedViewId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string MaterializedViewId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.MaterializedView Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/materializedViews";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                        RequestParameters.Add("materializedViewId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "materializedViewId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a materialized view from an instance.</summary>
                /// <param name="name">
                /// Required. The unique name of the materialized view to be deleted. Format:
                /// `projects/{project}/instances/{instance}/materializedViews/{materialized_view}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a materialized view from an instance.</summary>
                public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the materialized view to be deleted. Format:
                    /// `projects/{project}/instances/{instance}/materializedViews/{materialized_view}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The current etag of the materialized view. If an etag is provided and does not match
                    /// the current etag of the materialized view, deletion will be blocked and an ABORTED error will be
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/materializedViews/[^/]+$",
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

                /// <summary>Gets information about a materialized view.</summary>
                /// <param name="name">
                /// Required. The unique name of the requested materialized view. Values are of the form
                /// `projects/{project}/instances/{instance}/materializedViews/{materialized_view}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a materialized view.</summary>
                public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.MaterializedView>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the requested materialized view. Values are of the form
                    /// `projects/{project}/instances/{instance}/materializedViews/{materialized_view}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/materializedViews/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for an instance resource. Returns an empty policy if an instance
                /// exists but does not have a policy set.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for an instance resource. Returns an empty policy if an instance
                /// exists but does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/materializedViews/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists information about materialized views in an instance.</summary>
                /// <param name="parent">
                /// Required. The unique name of the instance for which the list of materialized views is requested.
                /// Values are of the form `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists information about materialized views in an instance.</summary>
                public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListMaterializedViewsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance for which the list of materialized views is requested.
                    /// Values are of the form `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of materialized views to return. The service may return fewer than
                    /// this value
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListMaterializedViews` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListMaterializedViews` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/materializedViews";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

                /// <summary>Updates a materialized view within an instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The unique name of the materialized view. Format:
                /// `projects/{project}/instances/{instance}/materializedViews/{materialized_view}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.MaterializedView body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a materialized view within an instance.</summary>
                public class PatchRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.MaterializedView body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The unique name of the materialized view. Format:
                    /// `projects/{project}/instances/{instance}/materializedViews/{materialized_view}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.MaterializedView Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/materializedViews/[^/]+$",
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
                /// Sets the access control policy on an instance resource. Replaces any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on an instance resource. Replaces any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/materializedViews/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns permissions that the caller has on the specified instance resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>Returns permissions that the caller has on the specified instance resource.</summary>
                public class TestIamPermissionsRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/materializedViews/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Tables resource.</summary>
            public virtual TablesResource Tables { get; }

            /// <summary>The "tables" collection of methods.</summary>
            public class TablesResource
            {
                private const string Resource = "tables";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TablesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    AuthorizedViews = new AuthorizedViewsResource(service);
                    SchemaBundles = new SchemaBundlesResource(service);
                }

                /// <summary>Gets the AuthorizedViews resource.</summary>
                public virtual AuthorizedViewsResource AuthorizedViews { get; }

                /// <summary>The "authorizedViews" collection of methods.</summary>
                public class AuthorizedViewsResource
                {
                    private const string Resource = "authorizedViews";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AuthorizedViewsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new AuthorizedView in a table.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. This is the name of the table the AuthorizedView belongs to. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.AuthorizedView body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new AuthorizedView in a table.</summary>
                    public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.AuthorizedView body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. This is the name of the table the AuthorizedView belongs to. Values are of the
                        /// form `projects/{project}/instances/{instance}/tables/{table}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The id of the AuthorizedView to create. This AuthorizedView must not already
                        /// exist. The `authorized_view_id` appended to `parent` forms the full AuthorizedView name of
                        /// the form
                        /// `projects/{project}/instances/{instance}/tables/{table}/authorizedView/{authorized_view}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("authorizedViewId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string AuthorizedViewId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.AuthorizedView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/authorizedViews";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                            });
                            RequestParameters.Add("authorizedViewId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "authorizedViewId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Permanently deletes a specified AuthorizedView.</summary>
                    /// <param name="name">
                    /// Required. The unique name of the AuthorizedView to be deleted. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Permanently deletes a specified AuthorizedView.</summary>
                    public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The unique name of the AuthorizedView to be deleted. Values are of the form
                        /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the AuthorizedView. If an etag is provided and does not match
                        /// the current etag of the AuthorizedView, deletion will be blocked and an ABORTED error will
                        /// be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+$",
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

                    /// <summary>Gets information from a specified AuthorizedView.</summary>
                    /// <param name="name">
                    /// Required. The unique name of the requested AuthorizedView. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets information from a specified AuthorizedView.</summary>
                    public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.AuthorizedView>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The unique name of the requested AuthorizedView. Values are of the form
                        /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The resource_view to be applied to the returned AuthorizedView's fields. Default
                        /// to BASIC.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. The resource_view to be applied to the returned AuthorizedView's fields. Default
                        /// to BASIC.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>Uses the default view for each method as documented in the request.</summary>
                            [Google.Apis.Util.StringValueAttribute("RESPONSE_VIEW_UNSPECIFIED")]
                            RESPONSEVIEWUNSPECIFIED = 0,

                            /// <summary>Only populates `name`.</summary>
                            [Google.Apis.Util.StringValueAttribute("NAME_ONLY")]
                            NAMEONLY = 1,

                            /// <summary>
                            /// Only populates the AuthorizedView's basic metadata. This includes: name,
                            /// deletion_protection, etag.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 2,

                            /// <summary>Populates every fields.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 3,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+$",
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

                    /// <summary>
                    /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                    /// exists but does not have a policy set.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                    /// exists but does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all AuthorizedViews from a specific table.</summary>
                    /// <param name="parent">
                    /// Required. The unique name of the table for which AuthorizedViews should be listed. Values are of
                    /// the form `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all AuthorizedViews from a specific table.</summary>
                    public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListAuthorizedViewsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The unique name of the table for which AuthorizedViews should be listed. Values
                        /// are of the form `projects/{project}/instances/{instance}/tables/{table}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of results per page. A page_size of zero lets the server choose the
                        /// number of items to return. A page_size which is strictly positive will return at most that
                        /// many items. A negative page_size will cause an error. Following the first request,
                        /// subsequent paginated calls are not required to pass a page_size. If a page_size is set in
                        /// subsequent calls, it must match the page_size given in the first request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. The value of `next_page_token` returned by a previous call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. The resource_view to be applied to the returned AuthorizedViews' fields. Default
                        /// to NAME_ONLY.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. The resource_view to be applied to the returned AuthorizedViews' fields. Default
                        /// to NAME_ONLY.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>Uses the default view for each method as documented in the request.</summary>
                            [Google.Apis.Util.StringValueAttribute("RESPONSE_VIEW_UNSPECIFIED")]
                            RESPONSEVIEWUNSPECIFIED = 0,

                            /// <summary>Only populates `name`.</summary>
                            [Google.Apis.Util.StringValueAttribute("NAME_ONLY")]
                            NAMEONLY = 1,

                            /// <summary>
                            /// Only populates the AuthorizedView's basic metadata. This includes: name,
                            /// deletion_protection, etag.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 2,

                            /// <summary>Populates every fields.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 3,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/authorizedViews";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
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

                    /// <summary>Updates an AuthorizedView in a table.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The name of this AuthorizedView. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.AuthorizedView body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an AuthorizedView in a table.</summary>
                    public class PatchRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.AuthorizedView body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The name of this AuthorizedView. Values are of the form
                        /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If true, ignore the safety checks when updating the AuthorizedView.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("ignoreWarnings", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

                        /// <summary>
                        /// Optional. The list of fields to update. A mask specifying which fields in the AuthorizedView
                        /// resource should be updated. This mask is relative to the AuthorizedView resource, not to the
                        /// request message. A field will be overwritten if it is in the mask. If empty, all fields set
                        /// in the request will be overwritten. A special value `*` means to overwrite all fields
                        /// (including fields not set in the request).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.AuthorizedView Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+$",
                            });
                            RequestParameters.Add("ignoreWarnings", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ignoreWarnings",
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
                    /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                    /// </summary>
                    public class SetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                    public class TestIamPermissionsRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the SchemaBundles resource.</summary>
                public virtual SchemaBundlesResource SchemaBundles { get; }

                /// <summary>The "schemaBundles" collection of methods.</summary>
                public class SchemaBundlesResource
                {
                    private const string Resource = "schemaBundles";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SchemaBundlesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new schema bundle in the specified table.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource where this schema bundle will be created. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.SchemaBundle body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new schema bundle in the specified table.</summary>
                    public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SchemaBundle body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this schema bundle will be created. Values are of the
                        /// form `projects/{project}/instances/{instance}/tables/{table}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The unique ID to use for the schema bundle, which will become the final component
                        /// of the schema bundle's resource name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("schemaBundleId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string SchemaBundleId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.SchemaBundle Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/schemaBundles";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                            });
                            RequestParameters.Add("schemaBundleId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "schemaBundleId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a schema bundle in the specified table.</summary>
                    /// <param name="name">
                    /// Required. The unique name of the schema bundle to delete. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a schema bundle in the specified table.</summary>
                    public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The unique name of the schema bundle to delete. Values are of the form
                        /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The etag of the schema bundle. If this is provided, it must match the server's
                        /// etag. The server returns an ABORTED error on a mismatched etag.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/schemaBundles/[^/]+$",
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

                    /// <summary>Gets metadata information about the specified schema bundle.</summary>
                    /// <param name="name">
                    /// Required. The unique name of the schema bundle to retrieve. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets metadata information about the specified schema bundle.</summary>
                    public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.SchemaBundle>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The unique name of the schema bundle to retrieve. Values are of the form
                        /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/schemaBundles/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                    /// exists but does not have a policy set.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                    /// exists but does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/schemaBundles/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all schema bundles associated with the specified table.</summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of schema bundles. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all schema bundles associated with the specified table.</summary>
                    public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListSchemaBundlesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of schema bundles. Values are of the form
                        /// `projects/{project}/instances/{instance}/tables/{table}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of schema bundles to return. If the value is positive, the server may
                        /// return at most this value. If unspecified, the server will return the maximum allowed page
                        /// size.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListSchemaBundles` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListSchemaBundles`
                        /// must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. The resource_view to be applied to the returned SchemaBundles' fields. Defaults to
                        /// NAME_ONLY.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. The resource_view to be applied to the returned SchemaBundles' fields. Defaults to
                        /// NAME_ONLY.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>Uses the default view for each method as documented in the request.</summary>
                            [Google.Apis.Util.StringValueAttribute("SCHEMA_BUNDLE_VIEW_UNSPECIFIED")]
                            SCHEMABUNDLEVIEWUNSPECIFIED = 0,

                            /// <summary>Only populates `name`.</summary>
                            [Google.Apis.Util.StringValueAttribute("NAME_ONLY")]
                            NAMEONLY = 1,

                            /// <summary>
                            /// Only populates the SchemaBundle's basic metadata. This includes: name, etag,
                            /// create_time, update_time.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 2,

                            /// <summary>Populates every field.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 3,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/schemaBundles";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
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

                    /// <summary>Updates a schema bundle in the specified table.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The unique name identifying this schema bundle. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.SchemaBundle body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a schema bundle in the specified table.</summary>
                    public class PatchRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SchemaBundle body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The unique name identifying this schema bundle. Values are of the form
                        /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set, ignore the safety checks when updating the Schema Bundle. The safety
                        /// checks are: - The new Schema Bundle is backwards compatible with the existing Schema Bundle.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("ignoreWarnings", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

                        /// <summary>Optional. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.SchemaBundle Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/schemaBundles/[^/]+$",
                            });
                            RequestParameters.Add("ignoreWarnings", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ignoreWarnings",
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
                    /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                    /// </summary>
                    public class SetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/schemaBundles/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                    public class TestIamPermissionsRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+/schemaBundles/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Checks replication consistency based on a consistency token, that is, if replication has caught up
                /// based on the conditions specified in the token and the check request.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The unique name of the Table for which to check replication consistency. Values are of the
                /// form `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual CheckConsistencyRequest CheckConsistency(Google.Apis.BigtableAdmin.v2.Data.CheckConsistencyRequest body, string name)
                {
                    return new CheckConsistencyRequest(this.service, body, name);
                }

                /// <summary>
                /// Checks replication consistency based on a consistency token, that is, if replication has caught up
                /// based on the conditions specified in the token and the check request.
                /// </summary>
                public class CheckConsistencyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.CheckConsistencyResponse>
                {
                    /// <summary>Constructs a new CheckConsistency request.</summary>
                    public CheckConsistencyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.CheckConsistencyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the Table for which to check replication consistency. Values are of
                    /// the form `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.CheckConsistencyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "checkConsistency";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:checkConsistency";

                    /// <summary>Initializes CheckConsistency parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a new table in the specified instance. The table can be created with a full set of initial
                /// column families, specified in the request.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The unique name of the instance in which to create the table. Values are of the form
                /// `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.CreateTableRequest body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new table in the specified instance. The table can be created with a full set of initial
                /// column families, specified in the request.
                /// </summary>
                public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Table>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.CreateTableRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance in which to create the table. Values are of the form
                    /// `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.CreateTableRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/tables";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Permanently deletes a specified table and all of its data.</summary>
                /// <param name="name">
                /// Required. The unique name of the table to be deleted. Values are of the form
                /// `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Permanently deletes a specified table and all of its data.</summary>
                public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the table to be deleted. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Permanently drop/delete a row range from a specified table. The request can specify whether to
                /// delete all rows in a table, or only those that match a particular prefix. Note that row key prefixes
                /// used here are treated as service data. For more information about how service data is handled, see
                /// the [Google Cloud Privacy Notice](https://cloud.google.com/terms/cloud-privacy-notice).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The unique name of the table on which to drop a range of rows. Values are of the form
                /// `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual DropRowRangeRequest DropRowRange(Google.Apis.BigtableAdmin.v2.Data.DropRowRangeRequest body, string name)
                {
                    return new DropRowRangeRequest(this.service, body, name);
                }

                /// <summary>
                /// Permanently drop/delete a row range from a specified table. The request can specify whether to
                /// delete all rows in a table, or only those that match a particular prefix. Note that row key prefixes
                /// used here are treated as service data. For more information about how service data is handled, see
                /// the [Google Cloud Privacy Notice](https://cloud.google.com/terms/cloud-privacy-notice).
                /// </summary>
                public class DropRowRangeRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
                {
                    /// <summary>Constructs a new DropRowRange request.</summary>
                    public DropRowRangeRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.DropRowRangeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the table on which to drop a range of rows. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.DropRowRangeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "dropRowRange";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:dropRowRange";

                    /// <summary>Initializes DropRowRange parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Generates a consistency token for a Table, which can be used in CheckConsistency to check whether
                /// mutations to the table that finished before this call started have been replicated. The tokens will
                /// be available for 90 days.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The unique name of the Table for which to create a consistency token. Values are of the
                /// form `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual GenerateConsistencyTokenRequest GenerateConsistencyToken(Google.Apis.BigtableAdmin.v2.Data.GenerateConsistencyTokenRequest body, string name)
                {
                    return new GenerateConsistencyTokenRequest(this.service, body, name);
                }

                /// <summary>
                /// Generates a consistency token for a Table, which can be used in CheckConsistency to check whether
                /// mutations to the table that finished before this call started have been replicated. The tokens will
                /// be available for 90 days.
                /// </summary>
                public class GenerateConsistencyTokenRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.GenerateConsistencyTokenResponse>
                {
                    /// <summary>Constructs a new GenerateConsistencyToken request.</summary>
                    public GenerateConsistencyTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GenerateConsistencyTokenRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the Table for which to create a consistency token. Values are of
                    /// the form `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.GenerateConsistencyTokenRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateConsistencyToken";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:generateConsistencyToken";

                    /// <summary>Initializes GenerateConsistencyToken parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets metadata information about the specified table.</summary>
                /// <param name="name">
                /// Required. The unique name of the requested table. Values are of the form
                /// `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets metadata information about the specified table.</summary>
                public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Table>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the requested table. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The view to be applied to the returned table's fields. Defaults to `SCHEMA_VIEW` if unspecified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// The view to be applied to the returned table's fields. Defaults to `SCHEMA_VIEW` if unspecified.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>Uses the default view for each method as documented in its request.</summary>
                        [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                        VIEWUNSPECIFIED = 0,

                        /// <summary>Only populates `name`.</summary>
                        [Google.Apis.Util.StringValueAttribute("NAME_ONLY")]
                        NAMEONLY = 1,

                        /// <summary>Only populates `name` and fields related to the table's schema.</summary>
                        [Google.Apis.Util.StringValueAttribute("SCHEMA_VIEW")]
                        SCHEMAVIEW = 2,

                        /// <summary>
                        /// Only populates `name` and fields related to the table's replication state.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("REPLICATION_VIEW")]
                        REPLICATIONVIEW = 3,

                        /// <summary>Only populates `name` and fields related to the table's encryption state.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENCRYPTION_VIEW")]
                        ENCRYPTIONVIEW = 5,

                        /// <summary>
                        /// Only populates `name` and fields related to the table's stats (e.g. TableStats and
                        /// ColumnFamilyStats).
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("STATS_VIEW")]
                        STATSVIEW = 6,

                        /// <summary>Populates all fields except for stats. See STATS_VIEW to request stats.</summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 4,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
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

                /// <summary>
                /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                /// exists but does not have a policy set.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a Bigtable resource. Returns an empty policy if the resource
                /// exists but does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all tables served from a specified instance.</summary>
                /// <param name="parent">
                /// Required. The unique name of the instance for which tables should be listed. Values are of the form
                /// `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all tables served from a specified instance.</summary>
                public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListTablesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the instance for which tables should be listed. Values are of the
                    /// form `projects/{project}/instances/{instance}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Maximum number of results per page. A page_size of zero lets the server choose the number of
                    /// items to return. A page_size which is strictly positive will return at most that many items. A
                    /// negative page_size will cause an error. Following the first request, subsequent paginated calls
                    /// are not required to pass a page_size. If a page_size is set in subsequent calls, it must match
                    /// the page_size given in the first request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value of `next_page_token` returned by a previous call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// The view to be applied to the returned tables' fields. Only NAME_ONLY view (default),
                    /// REPLICATION_VIEW and ENCRYPTION_VIEW are supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// The view to be applied to the returned tables' fields. Only NAME_ONLY view (default),
                    /// REPLICATION_VIEW and ENCRYPTION_VIEW are supported.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>Uses the default view for each method as documented in its request.</summary>
                        [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                        VIEWUNSPECIFIED = 0,

                        /// <summary>Only populates `name`.</summary>
                        [Google.Apis.Util.StringValueAttribute("NAME_ONLY")]
                        NAMEONLY = 1,

                        /// <summary>Only populates `name` and fields related to the table's schema.</summary>
                        [Google.Apis.Util.StringValueAttribute("SCHEMA_VIEW")]
                        SCHEMAVIEW = 2,

                        /// <summary>
                        /// Only populates `name` and fields related to the table's replication state.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("REPLICATION_VIEW")]
                        REPLICATIONVIEW = 3,

                        /// <summary>Only populates `name` and fields related to the table's encryption state.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENCRYPTION_VIEW")]
                        ENCRYPTIONVIEW = 5,

                        /// <summary>
                        /// Only populates `name` and fields related to the table's stats (e.g. TableStats and
                        /// ColumnFamilyStats).
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("STATS_VIEW")]
                        STATSVIEW = 6,

                        /// <summary>Populates all fields except for stats. See STATS_VIEW to request stats.</summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 4,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/tables";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

                /// <summary>
                /// Performs a series of column family modifications on the specified table. Either all or none of the
                /// modifications will occur before this method returns, but data requests received prior to that point
                /// may see a table where only some modifications have taken effect.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The unique name of the table whose families should be modified. Values are of the form
                /// `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual ModifyColumnFamiliesRequest ModifyColumnFamilies(Google.Apis.BigtableAdmin.v2.Data.ModifyColumnFamiliesRequest body, string name)
                {
                    return new ModifyColumnFamiliesRequest(this.service, body, name);
                }

                /// <summary>
                /// Performs a series of column family modifications on the specified table. Either all or none of the
                /// modifications will occur before this method returns, but data requests received prior to that point
                /// may see a table where only some modifications have taken effect.
                /// </summary>
                public class ModifyColumnFamiliesRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Table>
                {
                    /// <summary>Constructs a new ModifyColumnFamilies request.</summary>
                    public ModifyColumnFamiliesRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.ModifyColumnFamiliesRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the table whose families should be modified. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.ModifyColumnFamiliesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "modifyColumnFamilies";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:modifyColumnFamilies";

                    /// <summary>Initializes ModifyColumnFamilies parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates a specified table.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The unique name of the table. Values are of the form
                /// `projects/{project}/instances/{instance}/tables/_a-zA-Z0-9*`. Views: `NAME_ONLY`, `SCHEMA_VIEW`,
                /// `REPLICATION_VIEW`, `STATS_VIEW`, `FULL`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.Table body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a specified table.</summary>
                public class PatchRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Table body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The unique name of the table. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/_a-zA-Z0-9*`. Views: `NAME_ONLY`, `SCHEMA_VIEW`,
                    /// `REPLICATION_VIEW`, `STATS_VIEW`, `FULL`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. If true, ignore safety checks when updating the table.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreWarnings", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

                    /// <summary>
                    /// Required. The list of fields to update. A mask specifying which fields (e.g.
                    /// `change_stream_config`) in the `table` field should be updated. This mask is relative to the
                    /// `table` field, not to the request message. The wildcard (*) path is currently not supported.
                    /// Currently UpdateTable is only supported for the following fields: * `change_stream_config` *
                    /// `change_stream_config.retention_period` * `deletion_protection` * `automated_backup_policy` *
                    /// `automated_backup_policy.retention_period` * `automated_backup_policy.frequency` *
                    /// `row_key_schema` If `column_families` is set in `update_mask`, it will return an UNIMPLEMENTED
                    /// error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.Table Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                        RequestParameters.Add("ignoreWarnings", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreWarnings",
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
                /// Create a new table by restoring from a completed backup. The returned table long-running operation
                /// can be used to track the progress of the operation, and to cancel it. The metadata field type is
                /// RestoreTableMetadata. The response type is Table, if successful.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the instance in which to create the restored table. Values are of the form
                /// `projects//instances/`.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.BigtableAdmin.v2.Data.RestoreTableRequest body, string parent)
                {
                    return new RestoreRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create a new table by restoring from a completed backup. The returned table long-running operation
                /// can be used to track the progress of the operation, and to cancel it. The metadata field type is
                /// RestoreTableMetadata. The response type is Table, if successful.
                /// </summary>
                public class RestoreRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.RestoreTableRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the instance in which to create the restored table. Values are of the form
                    /// `projects//instances/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.RestoreTableRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/tables:restore";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on a Bigtable resource. Replaces any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>Returns permissions that the caller has on the specified Bigtable resource.</summary>
                public class TestIamPermissionsRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }

                /// <summary>Restores a specified table which was accidentally deleted.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The unique name of the table to be restored. Values are of the form
                /// `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.BigtableAdmin.v2.Data.UndeleteTableRequest body, string name)
                {
                    return new UndeleteRequest(this.service, body, name);
                }

                /// <summary>Restores a specified table which was accidentally deleted.</summary>
                public class UndeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.UndeleteTableRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The unique name of the table to be restored. Values are of the form
                    /// `projects/{project}/instances/{instance}/tables/{table}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigtableAdmin.v2.Data.UndeleteTableRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:undelete";

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
                            Pattern = @"^projects/[^/]+/instances/[^/]+/tables/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Create an instance within a project. Note that exactly one of Cluster.serve_nodes and
            /// Cluster.cluster_config.cluster_autoscaling_config can be set. If serve_nodes is set to non-zero, then
            /// the cluster is manually scaled. If cluster_config.cluster_autoscaling_config is non-empty, then
            /// autoscaling is enabled.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The unique name of the project in which to create the new instance. Values are of the form
            /// `projects/{project}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.CreateInstanceRequest body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Create an instance within a project. Note that exactly one of Cluster.serve_nodes and
            /// Cluster.cluster_config.cluster_autoscaling_config can be set. If serve_nodes is set to non-zero, then
            /// the cluster is manually scaled. If cluster_config.cluster_autoscaling_config is non-empty, then
            /// autoscaling is enabled.
            /// </summary>
            public class CreateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.CreateInstanceRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The unique name of the project in which to create the new instance. Values are of the form
                /// `projects/{project}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigtableAdmin.v2.Data.CreateInstanceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/instances";

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
                }
            }

            /// <summary>Delete an instance from a project.</summary>
            /// <param name="name">
            /// Required. The unique name of the instance to be deleted. Values are of the form
            /// `projects/{project}/instances/{instance}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete an instance from a project.</summary>
            public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The unique name of the instance to be deleted. Values are of the form
                /// `projects/{project}/instances/{instance}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about an instance.</summary>
            /// <param name="name">
            /// Required. The unique name of the requested instance. Values are of the form
            /// `projects/{project}/instances/{instance}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about an instance.</summary>
            public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Instance>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The unique name of the requested instance. Values are of the form
                /// `projects/{project}/instances/{instance}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for an instance resource. Returns an empty policy if an instance exists
            /// but does not have a policy set.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Gets the access control policy for an instance resource. Returns an empty policy if an instance exists
            /// but does not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about instances in a project.</summary>
            /// <param name="parent">
            /// Required. The unique name of the project for which a list of instances is requested. Values are of the
            /// form `projects/{project}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists information about instances in a project.</summary>
            public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListInstancesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The unique name of the project for which a list of instances is requested. Values are of
                /// the form `projects/{project}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>DEPRECATED: This field is unused and ignored.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/instances";

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
            /// Partially updates an instance within a project. This method can modify all fields of an Instance and is
            /// the preferred way to update an Instance.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The unique name of the instance. Values are of the form `projects/{project}/instances/a-z+[a-z0-9]`.
            /// </param>
            public virtual PartialUpdateInstanceRequest PartialUpdateInstance(Google.Apis.BigtableAdmin.v2.Data.Instance body, string name)
            {
                return new PartialUpdateInstanceRequest(this.service, body, name);
            }

            /// <summary>
            /// Partially updates an instance within a project. This method can modify all fields of an Instance and is
            /// the preferred way to update an Instance.
            /// </summary>
            public class PartialUpdateInstanceRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Operation>
            {
                /// <summary>Constructs a new PartialUpdateInstance request.</summary>
                public PartialUpdateInstanceRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Instance body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique name of the instance. Values are of the form `projects/{project}/instances/a-z+[a-z0-9]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The subset of Instance fields which should be replaced. Must be explicitly set.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigtableAdmin.v2.Data.Instance Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "partialUpdateInstance";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes PartialUpdateInstance parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
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

            /// <summary>Sets the access control policy on an instance resource. Replaces any existing policy.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>Sets the access control policy on an instance resource. Replaces any existing policy.</summary>
            public class SetIamPolicyRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>Returns permissions that the caller has on the specified instance resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>Returns permissions that the caller has on the specified instance resource.</summary>
            public class TestIamPermissionsRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Updates an instance within a project. This method updates only the display name and type for an
            /// Instance. To update other Instance properties, such as labels, use PartialUpdateInstance.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The unique name of the instance. Values are of the form `projects/{project}/instances/a-z+[a-z0-9]`.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.BigtableAdmin.v2.Data.Instance body, string name)
            {
                return new UpdateRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an instance within a project. This method updates only the display name and type for an
            /// Instance. To update other Instance properties, such as labels, use PartialUpdateInstance.
            /// </summary>
            public class UpdateRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Instance>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigtableAdmin.v2.Data.Instance body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The unique name of the instance. Values are of the form `projects/{project}/instances/a-z+[a-z0-9]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.BigtableAdmin.v2.Data.Instance Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/instances/[^/]+$",
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
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.ListLocationsResponse>
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
                public override string RestPath => "v2/{+name}/locations";

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
namespace Google.Apis.BigtableAdmin.v2.Data
{
    /// <summary>
    /// A configuration object describing how Cloud Bigtable should treat traffic from a particular end user
    /// application.
    /// </summary>
    public class AppProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies that this app profile is intended for read-only usage via the Data Boost feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataBoostIsolationReadOnly")]
        public virtual DataBoostIsolationReadOnly DataBoostIsolationReadOnly { get; set; }

        /// <summary>Long form description of the use case for this AppProfile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Strongly validated etag for optimistic concurrency control. Preserve the value returned from `GetAppProfile`
        /// when calling `UpdateAppProfile` to fail the request if there has been a modification in the mean time. The
        /// `update_mask` of the request need not include `etag` for this protection to apply. See
        /// [Wikipedia](https://en.wikipedia.org/wiki/HTTP_ETag) and [RFC
        /// 7232](https://tools.ietf.org/html/rfc7232#section-2.3) for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Use a multi-cluster routing policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiClusterRoutingUseAny")]
        public virtual MultiClusterRoutingUseAny MultiClusterRoutingUseAny { get; set; }

        /// <summary>
        /// The unique name of the app profile, up to 50 characters long. Values are of the form
        /// `projects/{project}/instances/{instance}/appProfiles/_a-zA-Z0-9*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// This field has been deprecated in favor of `standard_isolation.priority`. If you set this field,
        /// `standard_isolation.priority` will be set instead. The priority of requests sent using this app profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>Use a single-cluster routing policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleClusterRouting")]
        public virtual SingleClusterRouting SingleClusterRouting { get; set; }

        /// <summary>The standard options used for isolating this app profile's traffic from other use cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardIsolation")]
        public virtual StandardIsolation StandardIsolation { get; set; }
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

    /// <summary>An Authorized View of a Cloud Bigtable Table.</summary>
    public class AuthorizedView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set to true to make the AuthorizedView protected against deletion. The parent Table and containing Instance
        /// cannot be deleted if an AuthorizedView has this bit set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtection")]
        public virtual System.Nullable<bool> DeletionProtection { get; set; }

        /// <summary>
        /// The etag for this AuthorizedView. If this is provided on update, it must match the server's etag. The server
        /// returns ABORTED error on a mismatched etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The name of this AuthorizedView. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An AuthorizedView permitting access to an explicit subset of a Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsetView")]
        public virtual GoogleBigtableAdminV2AuthorizedViewSubsetView SubsetView { get; set; }
    }

    /// <summary>Defines an automated backup policy for a table</summary>
    public class AutomatedBackupPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How frequently automated backups should occur. The only supported value at this time is 24 hours. An
        /// undefined frequency is treated as 24 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual object Frequency { get; set; }

        /// <summary>
        /// Required. How long the automated backups should be retained. Values must be at least 3 days and at most 90
        /// days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionPeriod")]
        public virtual object RetentionPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Limits for the number of nodes a Cluster can autoscale up/down to.</summary>
    public class AutoscalingLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Maximum number of nodes to scale up to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxServeNodes")]
        public virtual System.Nullable<int> MaxServeNodes { get; set; }

        /// <summary>Required. Minimum number of nodes to scale down to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minServeNodes")]
        public virtual System.Nullable<int> MinServeNodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Autoscaling targets for a Cluster. These determine the recommended nodes.</summary>
    public class AutoscalingTargets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cpu utilization that the Autoscaler should be trying to achieve. This number is on a scale from 0 (no
        /// utilization) to 100 (total utilization), and is limited between 10 and 80, otherwise it will return
        /// INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuUtilizationPercent")]
        public virtual System.Nullable<int> CpuUtilizationPercent { get; set; }

        /// <summary>
        /// The storage utilization that the Autoscaler should be trying to achieve. This number is limited between 2560
        /// (2.5TiB) and 5120 (5TiB) for a SSD cluster and between 8192 (8TiB) and 16384 (16TiB) for an HDD cluster,
        /// otherwise it will return INVALID_ARGUMENT error. If this value is set to 0, it will be treated as if it were
        /// set to the default value: 2560 for SSD, 8192 for HDD.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageUtilizationGibPerNode")]
        public virtual System.Nullable<int> StorageUtilizationGibPerNode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A backup of a Cloud Bigtable table.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the backup type of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        /// <summary>Output only. The encryption information for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Output only. `end_time` is the time that the backup was finished. The row data in the backup will be no
        /// newer than this timestamp.
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

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Required. The expiration time of the backup. When creating a backup or updating its `expire_time`, the value
        /// must be greater than the backup creation time by: - At least 6 hours - At most 90 days Once the
        /// `expire_time` has passed, Cloud Bigtable will delete the backup.
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

        private string _hotToStandardTimeRaw;

        private object _hotToStandardTime;

        /// <summary>
        /// The time at which the hot backup will be converted to a standard backup. Once the `hot_to_standard_time` has
        /// passed, Cloud Bigtable will convert the hot backup to a standard backup. This value must be greater than the
        /// backup creation time by: - At least 24 hours This field only applies for hot backups. When creating or
        /// updating a standard backup, attempting to set this field will fail the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotToStandardTime")]
        public virtual string HotToStandardTimeRaw
        {
            get => _hotToStandardTimeRaw;
            set
            {
                _hotToStandardTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _hotToStandardTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="HotToStandardTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use HotToStandardTimeDateTimeOffset instead.")]
        public virtual object HotToStandardTime
        {
            get => _hotToStandardTime;
            set
            {
                _hotToStandardTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _hotToStandardTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="HotToStandardTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? HotToStandardTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(HotToStandardTimeRaw);
            set => HotToStandardTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A globally unique identifier for the backup which cannot be changed. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/ backups/_a-zA-Z0-9*` The final segment of the
        /// name must be between 1 and 50 characters in length. The backup is stored in the cluster identified by the
        /// prefix of the backup name of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Size of the backup in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>
        /// Output only. Name of the backup from which this backup was copied. If a backup is not created by copying a
        /// backup, this field will be empty. Values are of the form: projects//instances//clusters//backups/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>
        /// Required. Immutable. Name of the table from which this backup was created. This needs to be in the same
        /// instance as the backup. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{source_table}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual string SourceTable { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Output only. `start_time` is the time that the backup was started (i.e. approximately the time the
        /// CreateBackup request is received). The row data in this backup will be no older than this timestamp.
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

        /// <summary>Output only. The current state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a backup.</summary>
    public class BackupInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Output only. This time that the backup was finished. Row data in the backup will be no newer than this
        /// timestamp.
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

        /// <summary>
        /// Output only. Name of the backup from which this backup was copied. If a backup is not created by copying a
        /// backup, this field will be empty. Values are of the form: projects//instances//clusters//backups/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>Output only. Name of the table the backup was created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual string SourceTable { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Output only. The time that the backup was started. Row data in the backup will be no older than this
        /// timestamp.
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

    /// <summary>Change stream configuration.</summary>
    public class ChangeStreamConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How long the change stream should be retained. Change stream data older than the retention period will not
        /// be returned when reading the change stream from the table. Values must be at least 1 day and at most 7 days,
        /// and will be truncated to microsecond granularity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionPeriod")]
        public virtual object RetentionPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.CheckConsistency</summary>
    public class CheckConsistencyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The token created using GenerateConsistencyToken for the Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consistencyToken")]
        public virtual string ConsistencyToken { get; set; }

        /// <summary>
        /// Checks that reads using an app profile with `DataBoostIsolationReadOnly` can see all writes committed before
        /// the token was created, but only if the read and write target the same cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataBoostReadLocalWrites")]
        public virtual DataBoostReadLocalWrites DataBoostReadLocalWrites { get; set; }

        /// <summary>
        /// Checks that reads using an app profile with `StandardIsolation` can see all writes committed before the
        /// token was created, even if the read and write target different clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardReadRemoteWrites")]
        public virtual StandardReadRemoteWrites StandardReadRemoteWrites { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for google.bigtable.admin.v2.BigtableTableAdmin.CheckConsistency</summary>
    public class CheckConsistencyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True only if the token is consistent. A token is consistent if replication has caught up with the
        /// restrictions specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consistent")]
        public virtual System.Nullable<bool> Consistent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resizable group of nodes in a particular cloud location, capable of serving all Tables in the parent Instance.
    /// </summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterConfig")]
        public virtual ClusterConfig ClusterConfig { get; set; }

        /// <summary>
        /// Immutable. The type of storage used by this cluster to serve its parent instance's tables, unless explicitly
        /// overridden.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultStorageType")]
        public virtual string DefaultStorageType { get; set; }

        /// <summary>Immutable. The encryption configuration for CMEK-protected clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Immutable. The location where this cluster's nodes and storage reside. For best performance, clients should
        /// be located as close as possible to this cluster. Currently only zones are supported, so values should be of
        /// the form `projects/{project}/locations/{zone}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The unique name of the cluster. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/a-z*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Immutable. The node scaling factor of this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeScalingFactor")]
        public virtual string NodeScalingFactor { get; set; }

        /// <summary>
        /// The number of nodes in the cluster. If no value is set, Cloud Bigtable automatically allocates nodes based
        /// on your data footprint and optimized for 50% storage utilization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serveNodes")]
        public virtual System.Nullable<int> ServeNodes { get; set; }

        /// <summary>Output only. The current state of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Autoscaling config for a cluster.</summary>
    public class ClusterAutoscalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Autoscaling limits for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingLimits")]
        public virtual AutoscalingLimits AutoscalingLimits { get; set; }

        /// <summary>Required. Autoscaling targets for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingTargets")]
        public virtual AutoscalingTargets AutoscalingTargets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a cluster.</summary>
    public class ClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Autoscaling configuration for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterAutoscalingConfig")]
        public virtual ClusterAutoscalingConfig ClusterAutoscalingConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The state of a table's data in a particular cluster.</summary>
    public class ClusterState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The encryption information for the table in this cluster. If the encryption key protecting this
        /// resource is customer managed, then its version can be rotated in Cloud Key Management Service (Cloud KMS).
        /// The primary version of the key and its status will be reflected here when changes propagate from Cloud KMS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual System.Collections.Generic.IList<EncryptionInfo> EncryptionInfo { get; set; }

        /// <summary>Output only. The state of replication for the table in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationState")]
        public virtual string ReplicationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of columns within a table which share a common configuration.</summary>
    public class ColumnFamily : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Garbage collection rule specified as a protobuf. Must serialize to at most 500 bytes. NOTE: Garbage
        /// collection executes opportunistically in the background, and so it's possible for reads to return a cell
        /// even if it matches the active GC expression for its family.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcRule")]
        public virtual GcRule GcRule { get; set; }

        /// <summary>
        /// Output only. Only available with STATS_VIEW, this includes summary statistics about column family contents.
        /// For statistics over an entire table, see TableStats above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual ColumnFamilyStats Stats { get; set; }

        /// <summary>
        /// The type of data stored in each of this family's cell values, including its full encoding. If omitted, the
        /// family only serves raw untyped bytes. For now, only the `Aggregate` type is supported. `Aggregate` can only
        /// be set at family creation and is immutable afterwards. If `value_type` is `Aggregate`, written data must be
        /// compatible with: * `value_type.input_type` for `AddInput` mutations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual Type ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Approximate statistics related to a single column family within a table. This information may change rapidly,
    /// interpreting these values at a point in time may already preset out-of-date information. Everything below is
    /// approximate, unless otherwise specified.
    /// </summary>
    public class ColumnFamilyStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How many cells are present per column qualifier in this column family, averaged over all rows containing any
        /// column in the column family. e.g. For column family "family" in a table with 3 rows: * A row with 3 cells in
        /// "family:col" and 1 cell in "other:col" (3 cells / 1 column in "family") * A row with 1 cell in "family:col",
        /// 7 cells in "family:other_col", and 7 cells in "other:data" (8 cells / 2 columns in "family") * A row with 3
        /// cells in "other:col" (0 columns in "family", "family" not present) would report (3 + 8 + 0)/(1 + 2 + 0) =
        /// 3.66 in this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageCellsPerColumn")]
        public virtual System.Nullable<double> AverageCellsPerColumn { get; set; }

        /// <summary>
        /// How many column qualifiers are present in this column family, averaged over all rows in the table. e.g. For
        /// column family "family" in a table with 3 rows: * A row with cells in "family:col" and "other:col" (1 column
        /// in "family") * A row with cells in "family:col", "family:other_col", and "other:data" (2 columns in
        /// "family") * A row with cells in "other:col" (0 columns in "family", "family" not present) would report (1 +
        /// 2 + 0)/3 = 1.5 in this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageColumnsPerRow")]
        public virtual System.Nullable<double> AverageColumnsPerRow { get; set; }

        /// <summary>
        /// How much space the data in the column family occupies. This is roughly how many bytes would be needed to
        /// read the contents of the entire column family (e.g. by streaming all contents out).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalDataBytes")]
        public virtual System.Nullable<long> LogicalDataBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the google.longrunning.Operation returned by CopyBackup.</summary>
    public class CopyBackupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the backup being created through the copy operation. Values are of the form
        /// `projects//instances//clusters//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The progress of the CopyBackup operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>Information about the source backup that is being copied from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackupInfo")]
        public virtual BackupInfo SourceBackupInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for CopyBackup.</summary>
    public class CopyBackupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The id of the new backup. The `backup_id` along with `parent` are combined as
        /// {parent}/backups/{backup_id} to create the full backup name, of the form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`. This string must be
        /// between 1 and 50 characters in length and match the regex _a-zA-Z0-9*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupId")]
        public virtual string BackupId { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Required. Required. The expiration time of the copied backup with microsecond granularity that must be at
        /// least 6 hours and at most 30 days from the time the request is received. Once the `expire_time` has passed,
        /// Cloud Bigtable will delete the backup and free the resources used by the backup.
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

        /// <summary>
        /// Required. The source backup to be copied from. The source backup needs to be in READY state for it to be
        /// copied. Copying a copied backup is not allowed. Once CopyBackup is in progress, the source backup cannot be
        /// deleted or cleaned up on expiration until CopyBackup is finished. Values are of the form:
        /// `projects//instances//clusters//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceBackup")]
        public virtual string SourceBackup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by CreateAuthorizedView.</summary>
    public class CreateAuthorizedViewMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The request that prompted the initiation of this CreateAuthorizedView operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateAuthorizedViewRequest OriginalRequest { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for CreateAuthorizedView</summary>
    public class CreateAuthorizedViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The AuthorizedView to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedView")]
        public virtual AuthorizedView AuthorizedView { get; set; }

        /// <summary>
        /// Required. The id of the AuthorizedView to create. This AuthorizedView must not already exist. The
        /// `authorized_view_id` appended to `parent` forms the full AuthorizedView name of the form
        /// `projects/{project}/instances/{instance}/tables/{table}/authorizedView/{authorized_view}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedViewId")]
        public virtual string AuthorizedViewId { get; set; }

        /// <summary>
        /// Required. This is the name of the table the AuthorizedView belongs to. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateBackup.</summary>
    public class CreateBackupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was cancelled.</summary>
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

        /// <summary>The name of the backup being created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The name of the table the backup is created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual string SourceTable { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation started.</summary>
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

    /// <summary>The metadata for the Operation returned by CreateCluster.</summary>
    public class CreateClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The request that prompted the initiation of this CreateCluster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateClusterRequest OriginalRequest { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Keys: the full `name` of each table that existed in the instance when CreateCluster was first called, i.e.
        /// `projects//instances//tables/`. Any table added to the instance by a later API call will be created in the
        /// new cluster by that API call, not this one. Values: information on how much of a table's data has been
        /// copied to the newly-created cluster so far.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IDictionary<string, TableProgress> Tables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BigtableInstanceAdmin.CreateCluster.</summary>
    public class CreateClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The cluster to be created. Fields marked `OutputOnly` must be left blank.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual Cluster Cluster { get; set; }

        /// <summary>
        /// Required. The ID to be used when referring to the new cluster within its instance, e.g., just `mycluster`
        /// rather than `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The unique name of the instance in which to create the new cluster. Values are of the form
        /// `projects/{project}/instances/{instance}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by CreateInstance.</summary>
    public class CreateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The request that prompted the initiation of this CreateInstance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateInstanceRequest OriginalRequest { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BigtableInstanceAdmin.CreateInstance.</summary>
    public class CreateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The clusters to be created within the instance, mapped by desired cluster ID, e.g., just
        /// `mycluster` rather than `projects/myproject/instances/myinstance/clusters/mycluster`. Fields marked
        /// `OutputOnly` must be left blank.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IDictionary<string, Cluster> Clusters { get; set; }

        /// <summary>Required. The instance to create. Fields marked `OutputOnly` must be left blank.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        /// <summary>
        /// Required. The ID to be used when referring to the new instance within its project, e.g., just `myinstance`
        /// rather than `projects/myproject/instances/myinstance`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>
        /// Required. The unique name of the project in which to create the new instance. Values are of the form
        /// `projects/{project}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by CreateLogicalView.</summary>
    public class CreateLogicalViewMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was canceled.</summary>
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

        /// <summary>The request that prompted the initiation of this CreateLogicalView operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateLogicalViewRequest OriginalRequest { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation started.</summary>
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

    /// <summary>Request message for BigtableInstanceAdmin.CreateLogicalView.</summary>
    public class CreateLogicalViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The logical view to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalView")]
        public virtual LogicalView LogicalView { get; set; }

        /// <summary>
        /// Required. The ID to use for the logical view, which will become the final component of the logical view's
        /// resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalViewId")]
        public virtual string LogicalViewId { get; set; }

        /// <summary>
        /// Required. The parent instance where this logical view will be created. Format:
        /// `projects/{project}/instances/{instance}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by CreateMaterializedView.</summary>
    public class CreateMaterializedViewMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was canceled.</summary>
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

        /// <summary>The request that prompted the initiation of this CreateMaterializedView operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateMaterializedViewRequest OriginalRequest { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation started.</summary>
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

    /// <summary>Request message for BigtableInstanceAdmin.CreateMaterializedView.</summary>
    public class CreateMaterializedViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The materialized view to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedView")]
        public virtual MaterializedView MaterializedView { get; set; }

        /// <summary>
        /// Required. The ID to use for the materialized view, which will become the final component of the materialized
        /// view's resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedViewId")]
        public virtual string MaterializedViewId { get; set; }

        /// <summary>
        /// Required. The parent instance where this materialized view will be created. Format:
        /// `projects/{project}/instances/{instance}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by CreateSchemaBundle.</summary>
    public class CreateSchemaBundleMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was canceled.</summary>
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
        /// The unique name identifying this schema bundle. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation started.</summary>
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

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.CreateTable</summary>
    public class CreateTableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The optional list of row keys that will be used to initially split the table into several tablets (tablets
        /// are similar to HBase regions). Given two split keys, `s1` and `s2`, three tablets will be created, spanning
        /// the key ranges: `[, s1), [s1, s2), [s2, )`. Example: * Row keys := `["a", "apple", "custom", "customer_1",
        /// "customer_2",` `"other", "zz"]` * initial_split_keys := `["apple", "customer_1", "customer_2", "other"]` *
        /// Key assignment: - Tablet 1 `[, apple) =&amp;gt; {"a"}.` - Tablet 2 `[apple, customer_1) =&amp;gt; {"apple",
        /// "custom"}.` - Tablet 3 `[customer_1, customer_2) =&amp;gt; {"customer_1"}.` - Tablet 4 `[customer_2, other)
        /// =&amp;gt; {"customer_2"}.` - Tablet 5 `[other, ) =&amp;gt; {"other", "zz"}.`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialSplits")]
        public virtual System.Collections.Generic.IList<Split> InitialSplits { get; set; }

        /// <summary>Required. The Table to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual Table Table { get; set; }

        /// <summary>
        /// Required. The name by which the new table should be referred to within the parent instance, e.g., `foobar`
        /// rather than `{parent}/tables/foobar`. Maximum 50 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data Boost is a serverless compute capability that lets you run high-throughput read jobs and queries on your
    /// Bigtable data, without impacting the performance of the clusters that handle your application traffic. Data
    /// Boost supports read-only use cases with single-cluster routing.
    /// </summary>
    public class DataBoostIsolationReadOnly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Compute Billing Owner for this Data Boost App Profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeBillingOwner")]
        public virtual string ComputeBillingOwner { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Checks that all writes before the consistency token was generated in the same cluster are readable by Databoost.
    /// </summary>
    public class DataBoostReadLocalWrites : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.DropRowRange</summary>
    public class DropRowRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Delete all rows in the table. Setting this to false is a no-op.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteAllDataFromTable")]
        public virtual System.Nullable<bool> DeleteAllDataFromTable { get; set; }

        /// <summary>Delete all rows that start with this row key prefix. Prefix cannot be zero length.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowKeyPrefix")]
        public virtual string RowKeyPrefix { get; set; }

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

    /// <summary>Cloud Key Management Service (Cloud KMS) settings for a CMEK-protected cluster.</summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The
        /// requirements for this key are: 1) The Cloud Bigtable service account associated with the project that
        /// contains this cluster must be granted the `cloudkms.cryptoKeyEncrypterDecrypter` role on the CMEK key. 2)
        /// Only regional keys can be used and the region of the CMEK key must match the region of the cluster. Values
        /// are of the form `projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encryption information for a given resource. If this resource is protected with customer managed encryption, the
    /// in-use Cloud Key Management Service (Cloud KMS) key version is specified along with its status.
    /// </summary>
    public class EncryptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The status of encrypt/decrypt calls on underlying data for this resource. Regardless of status,
        /// the existing data is always encrypted at rest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionStatus")]
        public virtual Status EncryptionStatus { get; set; }

        /// <summary>Output only. The type of encryption used to protect this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>
        /// Output only. The version of the Cloud KMS key specified in the parent cluster that is in use for the data
        /// underlying this table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersion")]
        public virtual string KmsKeyVersion { get; set; }

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

    /// <summary>Rule for determining which cells to delete during garbage collection.</summary>
    public class GcRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Delete cells that would be deleted by every nested rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intersection")]
        public virtual Intersection Intersection { get; set; }

        /// <summary>
        /// Delete cells in a column older than the given age. Values must be at least one millisecond, and will be
        /// truncated to microsecond granularity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAge")]
        public virtual object MaxAge { get; set; }

        /// <summary>Delete all cells in a column except the most recent N.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNumVersions")]
        public virtual System.Nullable<int> MaxNumVersions { get; set; }

        /// <summary>Delete cells that would be deleted by any nested rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("union")]
        public virtual Union Union { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.GenerateConsistencyToken</summary>
    public class GenerateConsistencyTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for google.bigtable.admin.v2.BigtableTableAdmin.GenerateConsistencyToken</summary>
    public class GenerateConsistencyTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The generated consistency token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consistencyToken")]
        public virtual string ConsistencyToken { get; set; }

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
        /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and 3.
        /// Requests specifying an invalid value will be rejected. Requests for policies with any conditional role
        /// bindings must specify version 3. Policies with no conditional role bindings may specify any valid value or
        /// leave the field unset. The policy in the response might use the policy version that you specified, or it
        /// might use a lower policy version. For example, if you specify version 3, but the policy has no conditional
        /// role bindings, the response uses version 1. To learn which resources support conditions in their IAM
        /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Subsets of a column family that are included in this AuthorizedView.</summary>
    public class GoogleBigtableAdminV2AuthorizedViewFamilySubsets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Prefixes for qualifiers to be included in the AuthorizedView. Every qualifier starting with one of these
        /// prefixes is included in the AuthorizedView. To provide access to all qualifiers, include the empty string as
        /// a prefix ("").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualifierPrefixes")]
        public virtual System.Collections.Generic.IList<string> QualifierPrefixes { get; set; }

        /// <summary>Individual exact column qualifiers to be included in the AuthorizedView.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qualifiers")]
        public virtual System.Collections.Generic.IList<string> Qualifiers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a simple AuthorizedView that is a subset of the underlying Table.</summary>
    public class GoogleBigtableAdminV2AuthorizedViewSubsetView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map from column family name to the columns in this family to be included in the AuthorizedView.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familySubsets")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleBigtableAdminV2AuthorizedViewFamilySubsets> FamilySubsets { get; set; }

        /// <summary>
        /// Row prefixes to be included in the AuthorizedView. To provide access to all rows, include the empty string
        /// as a prefix ("").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowPrefixes")]
        public virtual System.Collections.Generic.IList<string> RowPrefixes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A value that combines incremental updates into a summarized value. Data is never directly written or read using
    /// type `Aggregate`. Writes provide either the `input_type` or `state_type`, and reads always return the
    /// `state_type` .
    /// </summary>
    public class GoogleBigtableAdminV2TypeAggregate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>HyperLogLogPlusPlusUniqueCount aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hllppUniqueCount")]
        public virtual GoogleBigtableAdminV2TypeAggregateHyperLogLogPlusPlusUniqueCount HllppUniqueCount { get; set; }

        /// <summary>
        /// Type of the inputs that are accumulated by this `Aggregate`. Use `AddInput` mutations to accumulate new
        /// inputs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputType")]
        public virtual Type InputType { get; set; }

        /// <summary>Max aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual GoogleBigtableAdminV2TypeAggregateMax Max { get; set; }

        /// <summary>Min aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual GoogleBigtableAdminV2TypeAggregateMin Min { get; set; }

        /// <summary>
        /// Output only. Type that holds the internal accumulator state for the `Aggregate`. This is a function of the
        /// `input_type` and `aggregator` chosen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateType")]
        public virtual Type StateType { get; set; }

        /// <summary>Sum aggregator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sum")]
        public virtual GoogleBigtableAdminV2TypeAggregateSum Sum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Computes an approximate unique count over the input values. When using raw data as input, be careful to use a
    /// consistent encoding. Otherwise the same value encoded differently could count more than once, or two distinct
    /// values could count as identical. Input: Any, or omit for Raw State: TBD Special state conversions: `Int64` (the
    /// unique count estimate)
    /// </summary>
    public class GoogleBigtableAdminV2TypeAggregateHyperLogLogPlusPlusUniqueCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Computes the max of the input values. Allowed input: `Int64` State: same as input</summary>
    public class GoogleBigtableAdminV2TypeAggregateMax : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Computes the min of the input values. Allowed input: `Int64` State: same as input</summary>
    public class GoogleBigtableAdminV2TypeAggregateMin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Computes the sum of the input values. Allowed input: `Int64` State: same as input</summary>
    public class GoogleBigtableAdminV2TypeAggregateSum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ordered list of elements of a given type. Values of type `Array` are stored in `Value.array_value`.
    /// </summary>
    public class GoogleBigtableAdminV2TypeArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the elements in the array. This must not be `Array`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementType")]
        public virtual Type ElementType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>bool Values of type `Bool` are stored in `Value.bool_value`.</summary>
    public class GoogleBigtableAdminV2TypeBool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Bytes Values of type `Bytes` are stored in `Value.bytes_value`.</summary>
    public class GoogleBigtableAdminV2TypeBytes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoding to use when converting to or from lower level types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual GoogleBigtableAdminV2TypeBytesEncoding Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rules used to convert to or from lower level types.</summary>
    public class GoogleBigtableAdminV2TypeBytesEncoding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use `Raw` encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("raw")]
        public virtual GoogleBigtableAdminV2TypeBytesEncodingRaw Raw { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Leaves the value as-is. Sorted mode: all values are supported. Distinct mode: all values are supported.
    /// </summary>
    public class GoogleBigtableAdminV2TypeBytesEncodingRaw : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, allows NULL values to be encoded as the empty string "". The actual empty string, or any value which
        /// only contains the null byte 0x00, has one more null byte appended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("escapeNulls")]
        public virtual System.Nullable<bool> EscapeNulls { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Date Values of type `Date` are stored in `Value.date_value`.</summary>
    public class GoogleBigtableAdminV2TypeDate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protobuf enum type. Values of type `Enum` are stored in `Value.int_value`.</summary>
    public class GoogleBigtableAdminV2TypeEnum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fully qualified name of the protobuf enum message, including package. In the format of
        /// "foo.bar.EnumMessage".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumName")]
        public virtual string EnumName { get; set; }

        /// <summary>The ID of the schema bundle that this enum is defined in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaBundleId")]
        public virtual string SchemaBundleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Float32 Values of type `Float32` are stored in `Value.float_value`.</summary>
    public class GoogleBigtableAdminV2TypeFloat32 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Float64 Values of type `Float64` are stored in `Value.float_value`.</summary>
    public class GoogleBigtableAdminV2TypeFloat64 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Int64 Values of type `Int64` are stored in `Value.int_value`.</summary>
    public class GoogleBigtableAdminV2TypeInt64 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoding to use when converting to or from lower level types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual GoogleBigtableAdminV2TypeInt64Encoding Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rules used to convert to or from lower level types.</summary>
    public class GoogleBigtableAdminV2TypeInt64Encoding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use `BigEndianBytes` encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigEndianBytes")]
        public virtual GoogleBigtableAdminV2TypeInt64EncodingBigEndianBytes BigEndianBytes { get; set; }

        /// <summary>Use `OrderedCodeBytes` encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderedCodeBytes")]
        public virtual GoogleBigtableAdminV2TypeInt64EncodingOrderedCodeBytes OrderedCodeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encodes the value as an 8-byte big-endian two's complement value. Sorted mode: non-negative values are
    /// supported. Distinct mode: all values are supported. Compatible with: - BigQuery `BINARY` encoding - HBase
    /// `Bytes.toBytes` - Java `ByteBuffer.putLong()` with `ByteOrder.BIG_ENDIAN`
    /// </summary>
    public class GoogleBigtableAdminV2TypeInt64EncodingBigEndianBytes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated: ignored if set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesType")]
        public virtual GoogleBigtableAdminV2TypeBytes BytesType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encodes the value in a variable length binary format of up to 10 bytes. Values that are closer to zero use fewer
    /// bytes. Sorted mode: all values are supported. Distinct mode: all values are supported.
    /// </summary>
    public class GoogleBigtableAdminV2TypeInt64EncodingOrderedCodeBytes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mapping of keys to values of a given type. Values of type `Map` are stored in a `Value.array_value` where each
    /// entry is another `Value.array_value` with two elements (the key and the value, in that order). Normally encoded
    /// Map values won't have repeated keys, however, clients are expected to handle the case in which they do. If the
    /// same key appears multiple times, the _last_ value takes precedence.
    /// </summary>
    public class GoogleBigtableAdminV2TypeMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of a map key. Only `Bytes`, `String`, and `Int64` are allowed as key types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual Type KeyType { get; set; }

        /// <summary>The type of the values in a map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual Type ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protobuf message type. Values of type `Proto` are stored in `Value.bytes_value`.</summary>
    public class GoogleBigtableAdminV2TypeProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fully qualified name of the protobuf message, including package. In the format of "foo.bar.Message".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageName")]
        public virtual string MessageName { get; set; }

        /// <summary>The ID of the schema bundle that this proto is defined in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaBundleId")]
        public virtual string SchemaBundleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>String Values of type `String` are stored in `Value.string_value`.</summary>
    public class GoogleBigtableAdminV2TypeString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoding to use when converting to or from lower level types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual GoogleBigtableAdminV2TypeStringEncoding Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rules used to convert to or from lower level types.</summary>
    public class GoogleBigtableAdminV2TypeStringEncoding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use `Utf8Bytes` encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utf8Bytes")]
        public virtual GoogleBigtableAdminV2TypeStringEncodingUtf8Bytes Utf8Bytes { get; set; }

        /// <summary>Deprecated: if set, converts to an empty `utf8_bytes`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utf8Raw")]
        public virtual GoogleBigtableAdminV2TypeStringEncodingUtf8Raw Utf8Raw { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UTF-8 encoding. Sorted mode: - All values are supported. - Code point order is preserved. Distinct mode: all
    /// values are supported. Compatible with: - BigQuery `TEXT` encoding - HBase `Bytes.toBytes` - Java
    /// `String#getBytes(StandardCharsets.UTF_8)`
    /// </summary>
    public class GoogleBigtableAdminV2TypeStringEncodingUtf8Bytes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Single-character escape sequence used to support NULL values. If set, allows NULL values to be encoded as
        /// the empty string "". The actual empty string, or any value where every character equals `null_escape_char`,
        /// has one more `null_escape_char` appended. If `null_escape_char` is set and does not equal the ASCII null
        /// character 0x00, then the encoding will not support sorted mode. .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullEscapeChar")]
        public virtual string NullEscapeChar { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated: prefer the equivalent `Utf8Bytes`.</summary>
    public class GoogleBigtableAdminV2TypeStringEncodingUtf8Raw : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A structured data value, consisting of fields which map to dynamically typed values. Values of type `Struct` are
    /// stored in `Value.array_value` where entries are in the same order and number as `field_types`.
    /// </summary>
    public class GoogleBigtableAdminV2TypeStruct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoding to use when converting to or from lower level types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual GoogleBigtableAdminV2TypeStructEncoding Encoding { get; set; }

        /// <summary>The names and types of the fields in this struct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleBigtableAdminV2TypeStructField> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rules used to convert to or from lower level types.</summary>
    public class GoogleBigtableAdminV2TypeStructEncoding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use `DelimitedBytes` encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimitedBytes")]
        public virtual GoogleBigtableAdminV2TypeStructEncodingDelimitedBytes DelimitedBytes { get; set; }

        /// <summary>User `OrderedCodeBytes` encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderedCodeBytes")]
        public virtual GoogleBigtableAdminV2TypeStructEncodingOrderedCodeBytes OrderedCodeBytes { get; set; }

        /// <summary>Use `Singleton` encoding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleton")]
        public virtual GoogleBigtableAdminV2TypeStructEncodingSingleton Singleton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields are encoded independently and concatenated with a configurable `delimiter` in between. A struct with no
    /// fields defined is encoded as a single `delimiter`. Sorted mode: - Fields are encoded in sorted mode. - Encoded
    /// field values must not contain any bytes &amp;lt;= `delimiter[0]` - Element-wise order is preserved: `A &amp;lt;
    /// B` if `A[0] &amp;lt; B[0]`, or if `A[0] == B[0] &amp;amp;&amp;amp; A[1] &amp;lt; B[1]`, etc. Strict prefixes
    /// sort first. Distinct mode: - Fields are encoded in distinct mode. - Encoded field values must not contain
    /// `delimiter[0]`.
    /// </summary>
    public class GoogleBigtableAdminV2TypeStructEncodingDelimitedBytes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Byte sequence used to delimit concatenated fields. The delimiter must contain at least 1 character and at
        /// most 50 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields are encoded independently and concatenated with the fixed byte pair {0x00, 0x01} in between. Any null
    /// (0x00) byte in an encoded field is replaced by the fixed byte pair {0x00, 0xFF}. Fields that encode to the empty
    /// string "" have special handling: - If *every* field encodes to "", or if the STRUCT has no fields defined, then
    /// the STRUCT is encoded as the fixed byte pair {0x00, 0x00}. - Otherwise, the STRUCT only encodes until the last
    /// non-empty field, omitting any trailing empty fields. Any empty fields that aren't omitted are replaced with the
    /// fixed byte pair {0x00, 0x00}. Examples: - STRUCT() -&amp;gt; "\00\00" - STRUCT("") -&amp;gt; "\00\00" -
    /// STRUCT("", "") -&amp;gt; "\00\00" - STRUCT("", "B") -&amp;gt; "\00\00" + "\00\01" + "B" - STRUCT("A", "")
    /// -&amp;gt; "A" - STRUCT("", "B", "") -&amp;gt; "\00\00" + "\00\01" + "B" - STRUCT("A", "", "C") -&amp;gt; "A" +
    /// "\00\01" + "\00\00" + "\00\01" + "C" Since null bytes are always escaped, this encoding can cause size blowup
    /// for encodings like `Int64.BigEndianBytes` that are likely to produce many such bytes. Sorted mode: - Fields are
    /// encoded in sorted mode. - All values supported by the field encodings are allowed - Element-wise order is
    /// preserved: `A &amp;lt; B` if `A[0] &amp;lt; B[0]`, or if `A[0] == B[0] &amp;amp;&amp;amp; A[1] &amp;lt; B[1]`,
    /// etc. Strict prefixes sort first. Distinct mode: - Fields are encoded in distinct mode. - All values supported by
    /// the field encodings are allowed.
    /// </summary>
    public class GoogleBigtableAdminV2TypeStructEncodingOrderedCodeBytes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Uses the encoding of `fields[0].type` as-is. Only valid if `fields.size == 1`.</summary>
    public class GoogleBigtableAdminV2TypeStructEncodingSingleton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A struct field and its type.</summary>
    public class GoogleBigtableAdminV2TypeStructField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The field name (optional). Fields without a `field_name` are considered anonymous and cannot be referenced
        /// by name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>The type of values in this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual Type Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Timestamp Values of type `Timestamp` are stored in `Value.timestamp_value`.</summary>
    public class GoogleBigtableAdminV2TypeTimestamp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoding to use when converting to or from lower level types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual GoogleBigtableAdminV2TypeTimestampEncoding Encoding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rules used to convert to or from lower level types.</summary>
    public class GoogleBigtableAdminV2TypeTimestampEncoding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Encodes the number of microseconds since the Unix epoch using the given `Int64` encoding. Values must be
        /// microsecond-aligned. Compatible with: - Java `Instant.truncatedTo()` with `ChronoUnit.MICROS`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unixMicrosInt64")]
        public virtual GoogleBigtableAdminV2TypeInt64Encoding UnixMicrosInt64 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A tablet is a defined by a start and end key and is explained in
    /// https://cloud.google.com/bigtable/docs/overview#architecture and
    /// https://cloud.google.com/bigtable/docs/performance#optimization. A Hot tablet is a tablet that exhibits high
    /// average cpu usage during the time interval from start time to end time.
    /// </summary>
    public class HotTablet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tablet End Key (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endKey")]
        public virtual string EndKey { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The end time of the hot tablet.</summary>
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
        /// The unique name of the hot tablet. Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/hotTablets/[a-zA-Z0-9_-]*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The average CPU usage spent by a node on this tablet over the start_time to end_time time
        /// range. The percentage is the amount of CPU used by the node to serve the tablet, from 0% (tablet was not
        /// interacted with) to 100% (the node spent all cycles serving the hot tablet).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCpuUsagePercent")]
        public virtual System.Nullable<float> NodeCpuUsagePercent { get; set; }

        /// <summary>Tablet Start Key (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startKey")]
        public virtual string StartKey { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The start time of the hot tablet.</summary>
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

        /// <summary>
        /// Name of the table that contains the tablet. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/_a-zA-Z0-9*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableName")]
        public virtual string TableName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of Bigtable Tables and the resources that serve them. All tables in an instance are served from all
    /// Clusters in the instance.
    /// </summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. A commit timestamp representing when this Instance was created. For instances created before
        /// this field was added (August 2021), this value is `seconds: 0, nanos: 1`.
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
        /// Required. The descriptive name for this instance as it appears in UIs. Can be changed at any time, but
        /// should be kept globally unique to avoid confusion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that reflect a
        /// customer's organizational needs and deployment strategies. They can be used to filter resources and
        /// aggregate metrics. * Label keys must be between 1 and 63 characters long and must conform to the regular
        /// expression: `\p{Ll}\p{Lo}{0,62}`. * Label values must be between 0 and 63 characters long and must conform
        /// to the regular expression: `[\p{Ll}\p{Lo}\p{N}_-]{0,63}`. * No more than 64 labels can be associated with a
        /// given resource. * Keys and values must both be under 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The unique name of the instance. Values are of the form `projects/{project}/instances/a-z+[a-z0-9]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The current state of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag keys/values directly bound to this resource. For example: -
        /// "123/environment": "production", - "123/costCenter": "marketing" Tags and Labels (above) are both used to
        /// bind metadata to resources, with different use-cases. See
        /// https://cloud.google.com/resource-manager/docs/tags/tags-overview for an in-depth overview on the difference
        /// between tags and labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The type of the instance. Defaults to `PRODUCTION`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A GcRule which deletes cells matching all of the given rules.</summary>
    public class Intersection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Only delete cells which would be deleted by every element of `rules`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GcRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BigtableInstanceAdmin.ListAppProfiles.</summary>
    public class ListAppProfilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested app profiles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appProfiles")]
        public virtual System.Collections.Generic.IList<AppProfile> AppProfiles { get; set; }

        /// <summary>
        /// Locations from which AppProfile information could not be retrieved, due to an outage or some other transient
        /// condition. AppProfiles from these locations may be missing from `app_profiles`. Values are of the form
        /// `projects//locations/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedLocations")]
        public virtual System.Collections.Generic.IList<string> FailedLocations { get; set; }

        /// <summary>
        /// Set if not all app profiles could be returned in a single response. Pass this value to `page_token` in
        /// another request to get the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for google.bigtable.admin.v2.BigtableTableAdmin.ListAuthorizedViews</summary>
    public class ListAuthorizedViewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AuthorizedViews present in the requested table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedViews")]
        public virtual System.Collections.Generic.IList<AuthorizedView> AuthorizedViews { get; set; }

        /// <summary>
        /// Set if not all tables could be returned in a single response. Pass this value to `page_token` in another
        /// request to get the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for ListBackups.</summary>
    public class ListBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of matching backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual System.Collections.Generic.IList<Backup> Backups { get; set; }

        /// <summary>
        /// `next_page_token` can be sent in a subsequent ListBackups call to fetch more of the matching backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BigtableInstanceAdmin.ListClusters.</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>
        /// Locations from which Cluster information could not be retrieved, due to an outage or some other transient
        /// condition. Clusters from these locations may be missing from `clusters`, or may only have partial
        /// information returned. Values are of the form `projects//locations/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedLocations")]
        public virtual System.Collections.Generic.IList<string> FailedLocations { get; set; }

        /// <summary>DEPRECATED: This field is unused and ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BigtableInstanceAdmin.ListHotTablets.</summary>
    public class ListHotTabletsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of hot tablets in the tables of the requested cluster that fall within the requested time range. Hot
        /// tablets are ordered by node cpu usage percent. If there are multiple hot tablets that correspond to the same
        /// tablet within a 15-minute interval, only the hot tablet with the highest node cpu usage will be included in
        /// the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotTablets")]
        public virtual System.Collections.Generic.IList<HotTablet> HotTablets { get; set; }

        /// <summary>
        /// Set if not all hot tablets could be returned in a single response. Pass this value to `page_token` in
        /// another request to get the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BigtableInstanceAdmin.ListInstances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Locations from which Instance information could not be retrieved, due to an outage or some other transient
        /// condition. Instances whose Clusters are all in one of the failed locations may be missing from `instances`,
        /// and Instances with at least one Cluster in a failed location may only have partial information returned.
        /// Values are of the form `projects//locations/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedLocations")]
        public virtual System.Collections.Generic.IList<string> FailedLocations { get; set; }

        /// <summary>The list of requested instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>DEPRECATED: This field is unused and ignored.</summary>
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

    /// <summary>Response message for BigtableInstanceAdmin.ListLogicalViews.</summary>
    public class ListLogicalViewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested logical views.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalViews")]
        public virtual System.Collections.Generic.IList<LogicalView> LogicalViews { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BigtableInstanceAdmin.ListMaterializedViews.</summary>
    public class ListMaterializedViewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested materialized views.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedViews")]
        public virtual System.Collections.Generic.IList<MaterializedView> MaterializedViews { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
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

    /// <summary>The response for ListSchemaBundles.</summary>
    public class ListSchemaBundlesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The schema bundles from the specified table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaBundles")]
        public virtual System.Collections.Generic.IList<SchemaBundle> SchemaBundles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for google.bigtable.admin.v2.BigtableTableAdmin.ListTables</summary>
    public class ListTablesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set if not all tables could be returned in a single response. Pass this value to `page_token` in another
        /// request to get the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The tables present in the requested instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<Table> Tables { get; set; }

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

    /// <summary>A SQL logical view object that can be referenced in SQL queries.</summary>
    public class LogicalView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Set to true to make the LogicalView protected against deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtection")]
        public virtual System.Nullable<bool> DeletionProtection { get; set; }

        /// <summary>
        /// Optional. The etag for this logical view. This may be sent on update requests to ensure that the client has
        /// an up-to-date value before proceeding. The server returns an ABORTED error on a mismatched etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The unique name of the logical view. Format:
        /// `projects/{project}/instances/{instance}/logicalViews/{logical_view}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The logical view's select query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }
    }

    /// <summary>A materialized view object that can be referenced in SQL queries.</summary>
    public class MaterializedView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set to true to make the MaterializedView protected against deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtection")]
        public virtual System.Nullable<bool> DeletionProtection { get; set; }

        /// <summary>
        /// Optional. The etag for this materialized view. This may be sent on update requests to ensure that the client
        /// has an up-to-date value before proceeding. The server returns an ABORTED error on a mismatched etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The unique name of the materialized view. Format:
        /// `projects/{project}/instances/{instance}/materializedViews/{materialized_view}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Immutable. The materialized view's select query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }
    }

    /// <summary>A create, update, or delete of a particular column family.</summary>
    public class Modification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Create a new column family with the specified schema, or fail if one already exists with the given ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("create")]
        public virtual ColumnFamily Create { get; set; }

        /// <summary>Drop (delete) the column family with the given ID, or fail if no such family exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drop")]
        public virtual System.Nullable<bool> Drop { get; set; }

        /// <summary>The ID of the column family to be modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Update an existing column family to the specified schema, or fail if no column family exists with the given
        /// ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual ColumnFamily Update { get; set; }

        /// <summary>
        /// Optional. A mask specifying which fields (e.g. `gc_rule`) in the `update` mod should be updated, ignored for
        /// other modification types. If unset or empty, we treat it as updating `gc_rule` to be backward compatible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.ModifyColumnFamilies</summary>
    public class ModifyColumnFamiliesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true, ignore safety checks when modifying the column families.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreWarnings")]
        public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

        /// <summary>
        /// Required. Modifications to be atomically applied to the specified table's families. Entries are applied in
        /// order, meaning that earlier modifications can be masked by later ones (in the case of repeated updates to
        /// the same family, for example).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifications")]
        public virtual System.Collections.Generic.IList<Modification> Modifications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster
    /// that is available in the event of transient errors or delays. Clusters in a region are considered equidistant.
    /// Choosing this option sacrifices read-your-writes consistency to improve availability.
    /// </summary>
    public class MultiClusterRoutingUseAny : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of clusters to route to. The order is ignored; clusters will be tried in order of distance. If left
        /// empty, all clusters are eligible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterIds")]
        public virtual System.Collections.Generic.IList<string> ClusterIds { get; set; }

        /// <summary>
        /// Row affinity sticky routing based on the row key of the request. Requests that span multiple rows are routed
        /// non-deterministically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowAffinity")]
        public virtual RowAffinity RowAffinity { get; set; }

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

    /// <summary>Encapsulates progress related information for a Cloud Bigtable long running operation.</summary>
    public class OperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation failed or was completed successfully.</summary>
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

        /// <summary>Percent completion of the operation. Values are between 0 and 100 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time the request was received.</summary>
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
    /// Metadata type for the long-running operation used to track the progress of optimizations performed on a newly
    /// restored table. This long-running operation is automatically created by the system after the successful
    /// completion of a table restore, and cannot be cancelled.
    /// </summary>
    public class OptimizeRestoredTableMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the restored table being optimized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The progress of the post-restore optimizations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by PartialUpdateCluster.</summary>
    public class PartialUpdateClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The original request for PartialUpdateCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual PartialUpdateClusterRequest OriginalRequest { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BigtableInstanceAdmin.PartialUpdateCluster.</summary>
    public class PartialUpdateClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Cluster which contains the partial updates to be applied, subject to the update_mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual Cluster Cluster { get; set; }

        /// <summary>Required. The subset of Cluster fields which should be replaced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BigtableInstanceAdmin.PartialUpdateInstance.</summary>
    public class PartialUpdateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Instance which will (partially) replace the current value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual Instance Instance { get; set; }

        /// <summary>Required. The subset of Instance fields which should be replaced. Must be explicitly set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

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

    /// <summary>Represents a protobuf schema.</summary>
    public class ProtoSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Contains a protobuf-serialized
        /// [google.protobuf.FileDescriptorSet](https://github.com/protocolbuffers/protobuf/blob/main/src/google/protobuf/descriptor.proto),
        /// which could include multiple proto files. To generate it,
        /// [install](https://grpc.io/docs/protoc-installation/) and run `protoc` with `--include_imports` and
        /// `--descriptor_set_out`. For example, to generate for moon/shot/app.proto, run
        /// ```
        /// $protoc
        /// --proto_path=/app_path --proto_path=/lib_path \ --include_imports \ --descriptor_set_out=descriptors.pb \
        /// moon/shot/app.proto
        /// ```
        /// For more details, see protobuffer [self
        /// description](https://developers.google.com/protocol-buffers/docs/techniques#self-description).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDescriptors")]
        public virtual string ProtoDescriptors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a table restore.</summary>
    public class RestoreInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the backup used to restore the table. The backup may no longer exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupInfo")]
        public virtual BackupInfo BackupInfo { get; set; }

        /// <summary>The type of the restore source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the long-running operation returned by RestoreTable.</summary>
    public class RestoreTableMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("backupInfo")]
        public virtual BackupInfo BackupInfo { get; set; }

        /// <summary>Name of the table being created and restored to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If exists, the name of the long-running operation that will be used to track the post-restore optimization
        /// process to optimize the performance of the restored table. The metadata type of the long-running operation
        /// is OptimizeRestoredTableMetadata. The response type is Empty. This long-running operation may be
        /// automatically created by the system if applicable after the RestoreTable long-running operation completes
        /// successfully. This operation may not be created if the table is already optimized or the restore was not
        /// successful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optimizeTableOperationName")]
        public virtual string OptimizeTableOperationName { get; set; }

        /// <summary>The progress of the RestoreTable operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>The type of the restore source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for RestoreTable.</summary>
    public class RestoreTableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the backup from which to restore. Values are of the form `projects//instances//clusters//backups/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backup")]
        public virtual string Backup { get; set; }

        /// <summary>
        /// Required. The id of the table to create and restore to. This table must not already exist. The `table_id`
        /// appended to `parent` forms the full table name of the form `projects//instances//tables/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If enabled, Bigtable will route the request based on the row key of the request, rather than randomly. Instead,
    /// each row key will be assigned to a cluster, and will stick to that cluster. If clusters are added or removed,
    /// then this may affect which row keys stick to which clusters. To avoid this, users can use a cluster group to
    /// specify which clusters are to be used. In this case, new clusters that are not a part of the cluster group will
    /// not be routed to, and routing will be unaffected by the new cluster. Moreover, clusters specified in the cluster
    /// group cannot be deleted unless removed from the cluster group.
    /// </summary>
    public class RowAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A named collection of related schemas.</summary>
    public class SchemaBundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The etag for this schema bundle. This may be sent on update and delete requests to ensure the
        /// client has an up-to-date value before proceeding. The server returns an ABORTED error on a mismatched etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The unique name identifying this schema bundle. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Schema for Protobufs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoSchema")]
        public virtual ProtoSchema ProtoSchema { get; set; }
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

    /// <summary>
    /// Unconditionally routes all read/write requests to a specific cluster. This option preserves read-your-writes
    /// consistency but does not improve availability.
    /// </summary>
    public class SingleClusterRouting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether or not `CheckAndMutateRow` and `ReadModifyWriteRow` requests are allowed by this app profile. It is
        /// unsafe to send these requests to the same table/row/column in multiple clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowTransactionalWrites")]
        public virtual System.Nullable<bool> AllowTransactionalWrites { get; set; }

        /// <summary>The cluster to which read/write requests should be routed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An initial split point for a newly created table.</summary>
    public class Split : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Row key to use as an initial tablet boundary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Standard options for isolating this app profile's traffic from other use cases.</summary>
    public class StandardIsolation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The priority of requests sent using this app profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Checks that all writes before the consistency token was generated are replicated in every cluster and readable.
    /// </summary>
    public class StandardReadRemoteWrites : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// A collection of user data indexed by row, column, and timestamp. Each table is served using the resources of its
    /// parent cluster.
    /// </summary>
    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If specified, automated backups are enabled for this table. Otherwise, automated backups are disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedBackupPolicy")]
        public virtual AutomatedBackupPolicy AutomatedBackupPolicy { get; set; }

        /// <summary>
        /// If specified, enable the change stream on this table. Otherwise, the change stream is disabled and the
        /// change stream is not retained.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeStreamConfig")]
        public virtual ChangeStreamConfig ChangeStreamConfig { get; set; }

        /// <summary>
        /// Output only. Map from cluster ID to per-cluster table state. If it could not be determined whether or not
        /// the table has data in a particular cluster (for example, if its zone is unavailable), then there will be an
        /// entry for the cluster with UNKNOWN `replication_status`. Views: `REPLICATION_VIEW`, `ENCRYPTION_VIEW`,
        /// `FULL`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterStates")]
        public virtual System.Collections.Generic.IDictionary<string, ClusterState> ClusterStates { get; set; }

        /// <summary>
        /// The column families configured for this table, mapped by column family ID. Views: `SCHEMA_VIEW`,
        /// `STATS_VIEW`, `FULL`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnFamilies")]
        public virtual System.Collections.Generic.IDictionary<string, ColumnFamily> ColumnFamilies { get; set; }

        /// <summary>
        /// Set to true to make the table protected against data loss. i.e. deleting the following resources through
        /// Admin APIs are prohibited: * The table. * The column families in the table. * The instance containing the
        /// table. Note one can still delete the data stored in the table through Data APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtection")]
        public virtual System.Nullable<bool> DeletionProtection { get; set; }

        /// <summary>
        /// Immutable. The granularity (i.e. `MILLIS`) at which timestamps are stored in this table. Timestamps not
        /// matching the granularity will be rejected. If unspecified at creation time, the value will be set to
        /// `MILLIS`. Views: `SCHEMA_VIEW`, `FULL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("granularity")]
        public virtual string Granularity { get; set; }

        /// <summary>
        /// The unique name of the table. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/_a-zA-Z0-9*`. Views: `NAME_ONLY`, `SCHEMA_VIEW`,
        /// `REPLICATION_VIEW`, `STATS_VIEW`, `FULL`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. If this table was restored from another data source (e.g. a backup), this field will be
        /// populated with information about the restore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreInfo")]
        public virtual RestoreInfo RestoreInfo { get; set; }

        /// <summary>
        /// The row key schema for this table. The schema is used to decode the raw row key bytes into a structured
        /// format. The order of field declarations in this schema is important, as it reflects how the raw row key
        /// bytes are structured. Currently, this only affects how the key is read via a GoogleSQL query from the
        /// ExecuteQuery API. For a SQL query, the _key column is still read as raw bytes. But queries can reference the
        /// key fields by name, which will be decoded from _key using provided type and encoding. Queries that reference
        /// key fields will fail if they encounter an invalid row key. For example, if _key =
        /// "some_id#2024-04-30#\x00\x13\x00\xf3" with the following schema: { fields { field_name: "id" type { string {
        /// encoding: utf8_bytes {} } } } fields { field_name: "date" type { string { encoding: utf8_bytes {} } } }
        /// fields { field_name: "product_code" type { int64 { encoding: big_endian_bytes {} } } } encoding {
        /// delimited_bytes { delimiter: "#" } } } The decoded key parts would be: id = "some_id", date = "2024-04-30",
        /// product_code = 1245427 The query "SELECT _key, product_code FROM table" will return two columns:
        /// /------------------------------------------------------\ | _key | product_code | |
        /// --------------------------------------|--------------| | "some_id#2024-04-30#\x00\x13\x00\xf3" | 1245427 |
        /// \------------------------------------------------------/ The schema has the following invariants: (1) The
        /// decoded field values are order-preserved. For read, the field values will be decoded in sorted mode from the
        /// raw bytes. (2) Every field in the schema must specify a non-empty name. (3) Every field must specify a type
        /// with an associated encoding. The type is limited to scalar types only: Array, Map, Aggregate, and Struct are
        /// not allowed. (4) The field names must not collide with existing column family names and reserved keywords
        /// "_key" and "_timestamp". The following update operations are allowed for row_key_schema: - Update from an
        /// empty schema to a new schema. - Remove the existing schema. This operation requires setting the
        /// `ignore_warnings` flag to `true`, since it might be a backward incompatible change. Without the flag, the
        /// update request will fail with an INVALID_ARGUMENT error. Any other row key schema update operation (e.g.
        /// update existing schema columns names or types) is currently unsupported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowKeySchema")]
        public virtual GoogleBigtableAdminV2TypeStruct RowKeySchema { get; set; }

        /// <summary>
        /// Output only. Only available with STATS_VIEW, this includes summary statistics about the entire table
        /// contents. For statistics about a specific column family, see ColumnFamilyStats in the mapped ColumnFamily
        /// collection above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual TableStats Stats { get; set; }

        /// <summary>
        /// Rules to specify what data is stored in each storage tier. Different tiers store data differently, providing
        /// different trade-offs between cost and performance. Different parts of a table can be stored separately on
        /// different tiers. If a config is specified, tiered storage is enabled for this table. Otherwise, tiered
        /// storage is disabled. Only SSD instances can configure tiered storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tieredStorageConfig")]
        public virtual TieredStorageConfig TieredStorageConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Progress info for copying a table's data to the new cluster.</summary>
    public class TableProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Estimate of the number of bytes copied so far for this table. This will eventually reach
        /// 'estimated_size_bytes' unless the table copy is CANCELLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedCopiedBytes")]
        public virtual System.Nullable<long> EstimatedCopiedBytes { get; set; }

        /// <summary>Estimate of the size of the table to be copied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedSizeBytes")]
        public virtual System.Nullable<long> EstimatedSizeBytes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Approximate statistics related to a table. These statistics are calculated infrequently, while simultaneously,
    /// data in the table can change rapidly. Thus the values reported here (e.g. row count) are very likely out-of
    /// date, even the instant they are received in this API. Thus, only treat these values as approximate. IMPORTANT:
    /// Everything below is approximate, unless otherwise specified.
    /// </summary>
    public class TableStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How many cells are present per column (column family, column qualifier) combinations, averaged over all
        /// columns in all rows in the table. e.g. A table with 2 rows: * A row with 3 cells in "family:col" and 1 cell
        /// in "other:col" (4 cells / 2 columns) * A row with 1 cell in "family:col", 7 cells in "family:other_col", and
        /// 7 cells in "other:data" (15 cells / 3 columns) would report (4 + 15)/(2 + 3) = 3.8 in this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageCellsPerColumn")]
        public virtual System.Nullable<double> AverageCellsPerColumn { get; set; }

        /// <summary>
        /// How many (column family, column qualifier) combinations are present per row in the table, averaged over all
        /// rows in the table. e.g. A table with 2 rows: * A row with cells in "family:col" and "other:col" (2 distinct
        /// columns) * A row with cells in "family:col", "family:other_col", and "other:data" (3 distinct columns) would
        /// report (2 + 3)/2 = 2.5 in this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageColumnsPerRow")]
        public virtual System.Nullable<double> AverageColumnsPerRow { get; set; }

        /// <summary>
        /// This is roughly how many bytes would be needed to read the entire table (e.g. by streaming all contents
        /// out).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalDataBytes")]
        public virtual System.Nullable<long> LogicalDataBytes { get; set; }

        /// <summary>How many rows are in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<long> RowCount { get; set; }

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

    /// <summary>
    /// Config for tiered storage. A valid config must have a valid TieredStorageRule. Otherwise the whole
    /// TieredStorageConfig must be unset. By default all data is stored in the SSD tier (only SSD instances can
    /// configure tiered storage).
    /// </summary>
    public class TieredStorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Rule to specify what data is stored in the infrequent access(IA) tier. The IA tier allows storing more data
        /// per node with reduced performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infrequentAccess")]
        public virtual TieredStorageRule InfrequentAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rule to specify what data is stored in a storage tier.</summary>
    public class TieredStorageRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Include cells older than the given age. For the infrequent access tier, this value must be at least 30 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeIfOlderThan")]
        public virtual object IncludeIfOlderThan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Type` represents the type of data that is written to, read from, or stored in Bigtable. It is heavily based on
    /// the GoogleSQL standard to help maintain familiarity and consistency across products and features. For
    /// compatibility with Bigtable's existing untyped APIs, each `Type` includes an `Encoding` which describes how to
    /// convert to or from the underlying data. Each encoding can operate in one of two modes: - Sorted: In this mode,
    /// Bigtable guarantees that `Encode(X) &amp;lt;= Encode(Y)` if and only if `X &amp;lt;= Y`. This is useful anywhere
    /// sort order is important, for example when encoding keys. - Distinct: In this mode, Bigtable guarantees that if
    /// `X != Y` then `Encode(X) != Encode(Y)`. However, the converse is not guaranteed. For example, both "{'foo': '1',
    /// 'bar': '2'}" and "{'bar': '2', 'foo': '1'}" are valid encodings of the same JSON value. The API clearly
    /// documents which mode is used wherever an encoding can be configured. Each encoding also documents which values
    /// are supported in which modes. For example, when encoding INT64 as a numeric STRING, negative numbers cannot be
    /// encoded in sorted mode. This is because `INT64(1) &amp;gt; INT64(-1)`, but `STRING("-00001") &amp;gt;
    /// STRING("00001")`.
    /// </summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateType")]
        public virtual GoogleBigtableAdminV2TypeAggregate AggregateType { get; set; }

        /// <summary>Array</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayType")]
        public virtual GoogleBigtableAdminV2TypeArray ArrayType { get; set; }

        /// <summary>Bool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolType")]
        public virtual GoogleBigtableAdminV2TypeBool BoolType { get; set; }

        /// <summary>Bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesType")]
        public virtual GoogleBigtableAdminV2TypeBytes BytesType { get; set; }

        /// <summary>Date</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateType")]
        public virtual GoogleBigtableAdminV2TypeDate DateType { get; set; }

        /// <summary>Enum</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumType")]
        public virtual GoogleBigtableAdminV2TypeEnum EnumType { get; set; }

        /// <summary>Float32</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("float32Type")]
        public virtual GoogleBigtableAdminV2TypeFloat32 Float32Type { get; set; }

        /// <summary>Float64</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("float64Type")]
        public virtual GoogleBigtableAdminV2TypeFloat64 Float64Type { get; set; }

        /// <summary>Int64</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Type")]
        public virtual GoogleBigtableAdminV2TypeInt64 Int64Type { get; set; }

        /// <summary>Map</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapType")]
        public virtual GoogleBigtableAdminV2TypeMap MapType { get; set; }

        /// <summary>Proto</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoType")]
        public virtual GoogleBigtableAdminV2TypeProto ProtoType { get; set; }

        /// <summary>String</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringType")]
        public virtual GoogleBigtableAdminV2TypeString StringType { get; set; }

        /// <summary>Struct</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structType")]
        public virtual GoogleBigtableAdminV2TypeStruct StructType { get; set; }

        /// <summary>Timestamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampType")]
        public virtual GoogleBigtableAdminV2TypeTimestamp TimestampType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata type for the operation returned by google.bigtable.admin.v2.BigtableTableAdmin.UndeleteTable.
    /// </summary>
    public class UndeleteTableMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was cancelled.</summary>
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

        /// <summary>The name of the table being restored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation started.</summary>
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

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.UndeleteTable</summary>
    public class UndeleteTableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A GcRule which deletes cells matching any of the given rules.</summary>
    public class Union : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Delete cells which would be deleted by any element of `rules`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GcRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by UpdateAppProfile.</summary>
    public class UpdateAppProfileMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the google.longrunning.Operation returned by UpdateAuthorizedView.</summary>
    public class UpdateAuthorizedViewMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The request that prompted the initiation of this UpdateAuthorizedView operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual UpdateAuthorizedViewRequest OriginalRequest { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for UpdateAuthorizedView.</summary>
    public class UpdateAuthorizedViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The AuthorizedView to update. The `name` in `authorized_view` is used to identify the
        /// AuthorizedView. AuthorizedView name must in this format:
        /// `projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedView")]
        public virtual AuthorizedView AuthorizedView { get; set; }

        /// <summary>Optional. If true, ignore the safety checks when updating the AuthorizedView.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreWarnings")]
        public virtual System.Nullable<bool> IgnoreWarnings { get; set; }

        /// <summary>
        /// Optional. The list of fields to update. A mask specifying which fields in the AuthorizedView resource should
        /// be updated. This mask is relative to the AuthorizedView resource, not to the request message. A field will
        /// be overwritten if it is in the mask. If empty, all fields set in the request will be overwritten. A special
        /// value `*` means to overwrite all fields (including fields not set in the request).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by UpdateCluster.</summary>
    public class UpdateClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The request that prompted the initiation of this UpdateCluster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual Cluster OriginalRequest { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by UpdateInstance.</summary>
    public class UpdateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The request that prompted the initiation of this UpdateInstance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual PartialUpdateInstanceRequest OriginalRequest { get; set; }

        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by UpdateLogicalView.</summary>
    public class UpdateLogicalViewMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was canceled.</summary>
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

        /// <summary>The request that prompted the initiation of this UpdateLogicalView operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual UpdateLogicalViewRequest OriginalRequest { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation was started.</summary>
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

    /// <summary>Request message for BigtableInstanceAdmin.UpdateLogicalView.</summary>
    public class UpdateLogicalViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The logical view to update. The logical view's `name` field is used to identify the view to
        /// update. Format: `projects/{project}/instances/{instance}/logicalViews/{logical_view}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalView")]
        public virtual LogicalView LogicalView { get; set; }

        /// <summary>Optional. The list of fields to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by UpdateSchemaBundle.</summary>
    public class UpdateSchemaBundleMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was canceled.</summary>
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
        /// The unique name identifying this schema bundle. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}/schemaBundles/{schema_bundle}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation started.</summary>
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

    /// <summary>Metadata type for the operation returned by UpdateTable.</summary>
    public class UpdateTableMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>If set, the time at which this operation finished or was canceled.</summary>
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

        /// <summary>The name of the table being updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time at which this operation started.</summary>
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
}
