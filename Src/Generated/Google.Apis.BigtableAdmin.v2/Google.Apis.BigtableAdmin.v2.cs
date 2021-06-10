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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigtableadmin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://bigtableadmin.googleapis.com/";
        #else
            "https://bigtableadmin.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://bigtableadmin.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

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

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
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

            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
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
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
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
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(string name)
        {
            return new CancelRequest(service, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        public class CancelRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
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
            public override string RestPath => "v2/{+name}:cancel";

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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        public class DeleteRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Empty>
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
                    Pattern = @"^operations/.*$",
                });
            }
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
                    return new CreateRequest(service, body, parent);
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
                    return new DeleteRequest(service, name);
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
                    return new GetRequest(service, name);
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
                    return new ListRequest(service, parent);
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
                /// The unique name of the app profile. Values are of the form
                /// `projects/{project}/instances/{instance}/appProfiles/_a-zA-Z0-9*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.BigtableAdmin.v2.Data.AppProfile body, string name)
                {
                    return new PatchRequest(service, body, name);
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
                    /// The unique name of the app profile. Values are of the form
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
                        return new CreateRequest(service, body, parent);
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
                        return new DeleteRequest(service, name);
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
                        return new GetRequest(service, name);
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
                    /// Gets the access control policy for a Table resource. Returns an empty policy if the resource
                    /// exists but does not have a policy set.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a Table resource. Returns an empty policy if the resource
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
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
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
                        return new ListRequest(service, parent);
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
                        return new PatchRequest(service, body, name);
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
                    /// Sets the access control policy on a Table resource. Replaces any existing policy.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on a Table resource. Replaces any existing policy.
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
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
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

                    /// <summary>Returns permissions that the caller has on the specified table resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>Returns permissions that the caller has on the specified table resource.</summary>
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
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
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

                /// <summary>Creates a cluster within an instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The unique name of the instance in which to create the new cluster. Values are of the form
                /// `projects/{project}/instances/{instance}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.Cluster body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a cluster within an instance.</summary>
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
                    return new DeleteRequest(service, name);
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
                    return new GetRequest(service, name);
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
                    return new ListRequest(service, parent);
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
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The unique name of the cluster. Values are of the form
                /// `projects/{project}/instances/{instance}/clusters/a-z*`.
                /// </param>
                public virtual PartialUpdateClusterRequest PartialUpdateCluster(Google.Apis.BigtableAdmin.v2.Data.Cluster body, string name)
                {
                    return new PartialUpdateClusterRequest(service, body, name);
                }

                /// <summary>
                /// Partially updates a cluster within a project. This method is the preferred way to update a Cluster.
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

                    /// <summary>
                    /// Required. The subset of Cluster fields which should be replaced. Must be explicitly set.
                    /// </summary>
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
                /// Updates a cluster within an instance. UpdateCluster is deprecated. Please use PartialUpdateCluster
                /// instead.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The unique name of the cluster. Values are of the form
                /// `projects/{project}/instances/{instance}/clusters/a-z*`.
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.BigtableAdmin.v2.Data.Cluster body, string name)
                {
                    return new UpdateRequest(service, body, name);
                }

                /// <summary>
                /// Updates a cluster within an instance. UpdateCluster is deprecated. Please use PartialUpdateCluster
                /// instead.
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
                    return new CheckConsistencyRequest(service, body, name);
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
                    return new CreateRequest(service, body, parent);
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
                    return new DeleteRequest(service, name);
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
                /// delete all rows in a table, or only those that match a particular prefix.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The unique name of the table on which to drop a range of rows. Values are of the form
                /// `projects/{project}/instances/{instance}/tables/{table}`.
                /// </param>
                public virtual DropRowRangeRequest DropRowRange(Google.Apis.BigtableAdmin.v2.Data.DropRowRangeRequest body, string name)
                {
                    return new DropRowRangeRequest(service, body, name);
                }

                /// <summary>
                /// Permanently drop/delete a row range from a specified table. The request can specify whether to
                /// delete all rows in a table, or only those that match a particular prefix.
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
                    return new GenerateConsistencyTokenRequest(service, body, name);
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
                    return new GetRequest(service, name);
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

                        /// <summary>Populates all fields.</summary>
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
                /// Gets the access control policy for a Table resource. Returns an empty policy if the resource exists
                /// but does not have a policy set.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a Table resource. Returns an empty policy if the resource exists
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
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
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
                    return new ListRequest(service, parent);
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
                    /// The view to be applied to the returned tables' fields. Only NAME_ONLY view (default) and
                    /// REPLICATION_VIEW are supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// The view to be applied to the returned tables' fields. Only NAME_ONLY view (default) and
                    /// REPLICATION_VIEW are supported.
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

                        /// <summary>Populates all fields.</summary>
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
                    return new ModifyColumnFamiliesRequest(service, body, name);
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

                /// <summary>
                /// Create a new table by restoring from a completed backup. The new table must be in the same project
                /// as the instance containing the backup. The returned table long-running operation can be used to
                /// track the progress of the operation, and to cancel it. The metadata field type is
                /// RestoreTableMetadata. The response type is Table, if successful.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the instance in which to create the restored table. This instance must be in
                /// the same project as the source backup. Values are of the form `projects//instances/`.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.BigtableAdmin.v2.Data.RestoreTableRequest body, string parent)
                {
                    return new RestoreRequest(service, body, parent);
                }

                /// <summary>
                /// Create a new table by restoring from a completed backup. The new table must be in the same project
                /// as the instance containing the backup. The returned table long-running operation can be used to
                /// track the progress of the operation, and to cancel it. The metadata field type is
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
                    /// Required. The name of the instance in which to create the restored table. This instance must be
                    /// in the same project as the source backup. Values are of the form `projects//instances/`.
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

                /// <summary>Sets the access control policy on a Table resource. Replaces any existing policy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>Sets the access control policy on a Table resource. Replaces any existing policy.</summary>
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
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
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

                /// <summary>Returns permissions that the caller has on the specified table resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>Returns permissions that the caller has on the specified table resource.</summary>
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
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
            }

            /// <summary>Create an instance within a project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The unique name of the project in which to create the new instance. Values are of the form
            /// `projects/{project}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.BigtableAdmin.v2.Data.CreateInstanceRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create an instance within a project.</summary>
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
                return new DeleteRequest(service, name);
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
                return new GetRequest(service, name);
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
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
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
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
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
                return new ListRequest(service, parent);
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
                return new PartialUpdateInstanceRequest(service, body, name);
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
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.BigtableAdmin.v2.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
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
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
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
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.BigtableAdmin.v2.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
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
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
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
                return new UpdateRequest(service, body, name);
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : BigtableAdminBaseServiceRequest<Google.Apis.BigtableAdmin.v2.Data.Location>
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in [AIP-160](https://google.aip.dev/160).
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
        /// The unique name of the app profile. Values are of the form
        /// `projects/{project}/instances/{instance}/appProfiles/_a-zA-Z0-9*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Use a single-cluster routing policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleClusterRouting")]
        public virtual SingleClusterRouting SingleClusterRouting { get; set; }
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

    /// <summary>A backup of a Cloud Bigtable table.</summary>
    public class Backup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The encryption information for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionInfo")]
        public virtual EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Output only. `end_time` is the time that the backup was finished. The row data in the backup will be no
        /// newer than this timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Required. The expiration time of the backup, with microseconds granularity that must be at least 6 hours and
        /// at most 30 days from the time the request is received. Once the `expire_time` has passed, Cloud Bigtable
        /// will delete the backup and free the resources used by the backup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

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
        /// Required. Immutable. Name of the table from which this backup was created. This needs to be in the same
        /// instance as the backup. Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{source_table}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual string SourceTable { get; set; }

        /// <summary>
        /// Output only. `start_time` is the time that the backup was started (i.e. approximately the time the
        /// CreateBackup request is received). The row data in this backup will be no older than this timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

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

        /// <summary>
        /// Output only. This time that the backup was finished. Row data in the backup will be no newer than this
        /// timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Output only. Name of the table the backup was created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual string SourceTable { get; set; }

        /// <summary>
        /// Output only. The time that the backup was started. Row data in the backup will be no older than this
        /// timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

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

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.CheckConsistency</summary>
    public class CheckConsistencyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The token created using GenerateConsistencyToken for the Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consistencyToken")]
        public virtual string ConsistencyToken { get; set; }

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

        /// <summary>
        /// Required. The number of nodes allocated to this cluster. More nodes enable higher throughput and more
        /// consistent performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serveNodes")]
        public virtual System.Nullable<int> ServeNodes { get; set; }

        /// <summary>Output only. The current state of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata type for the operation returned by CreateBackup.</summary>
    public class CreateBackupMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, the time at which this operation finished or was cancelled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The name of the backup being created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The name of the table the backup is created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual string SourceTable { get; set; }

        /// <summary>The time at which this operation started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by CreateCluster.</summary>
    public class CreateClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>The request that prompted the initiation of this CreateCluster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateClusterRequest OriginalRequest { get; set; }

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; }

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
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>The request that prompted the initiation of this CreateInstance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual CreateInstanceRequest OriginalRequest { get; set; }

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BigtableInstanceAdmin.CreateInstance.</summary>
    public class CreateInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The clusters to be created within the instance, mapped by desired cluster ID, e.g., just
        /// `mycluster` rather than `projects/myproject/instances/myinstance/clusters/mycluster`. Fields marked
        /// `OutputOnly` must be left blank. Currently, at most four clusters can be specified.
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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
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
        /// Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All
        /// clusters within an instance must use the same CMEK key. Values are of the form
        /// `projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}`
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

    /// <summary>Added to the error payload.</summary>
    public class FailureTrace : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<Frame> Frames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Frame : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("targetName")]
        public virtual string TargetName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("workflowGuid")]
        public virtual string WorkflowGuid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("zoneId")]
        public virtual string ZoneId { get; set; }

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

    /// <summary>
    /// A collection of Bigtable Tables and the resources that serve them. All tables in an instance are served from all
    /// Clusters in the instance.
    /// </summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The descriptive name for this instance as it appears in UIs. Can be changed at any time, but
        /// should be kept globally unique to avoid confusion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. Labels are a flexible and lightweight mechanism for organizing cloud resources into groups that
        /// reflect a customer's organizational needs and deployment strategies. They can be used to filter resources
        /// and aggregate metrics. * Label keys must be between 1 and 63 characters long and must conform to the regular
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

        /// <summary>Output only. The current state of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The type of the instance. Defaults to `PRODUCTION`.</summary>
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

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for google.bigtable.admin.v2.BigtableTableAdmin.ModifyColumnFamilies</summary>
    public class ModifyColumnFamiliesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Encapsulates progress related information for a Cloud Bigtable long running operation.</summary>
    public class OperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set, the time at which this operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Percent completion of the operation. Values are between 0 and 100 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Time the request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

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
        /// is OptimizeRestoreTableMetadata. The response type is Empty. This long-running operation may be
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
        /// Output only. Map from cluster ID to per-cluster table state. If it could not be determined whether or not
        /// the table has data in a particular cluster (for example, if its zone is unavailable), then there will be an
        /// entry for the cluster with UNKNOWN `replication_status`. Views: `REPLICATION_VIEW`, `ENCRYPTION_VIEW`,
        /// `FULL`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterStates")]
        public virtual System.Collections.Generic.IDictionary<string, ClusterState> ClusterStates { get; set; }

        /// <summary>
        /// The column families configured for this table, mapped by column family ID. Views: `SCHEMA_VIEW`, `FULL`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnFamilies")]
        public virtual System.Collections.Generic.IDictionary<string, ColumnFamily> ColumnFamilies { get; set; }

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
        /// `REPLICATION_VIEW`, `FULL`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. If this table was restored from another data source (e.g. a backup), this field will be
        /// populated with information about the restore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreInfo")]
        public virtual RestoreInfo RestoreInfo { get; set; }

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

    /// <summary>The metadata for the Operation returned by UpdateCluster.</summary>
    public class UpdateClusterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>The request that prompted the initiation of this UpdateCluster operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual Cluster OriginalRequest { get; set; }

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata for the Operation returned by UpdateInstance.</summary>
    public class UpdateInstanceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation failed or was completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>The request that prompted the initiation of this UpdateInstance operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequest")]
        public virtual PartialUpdateInstanceRequest OriginalRequest { get; set; }

        /// <summary>The time at which the original request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual object RequestTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
