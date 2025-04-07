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

namespace Google.Apis.FirebaseManagement.v1beta1
{
    /// <summary>The FirebaseManagement Service.</summary>
    public class FirebaseManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AvailableProjects = new AvailableProjectsResource(this);
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firebase.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firebase.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebase";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Management API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public static string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Management API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";

            /// <summary>View all your Firebase data and settings</summary>
            public const string FirebaseReadonly = "https://www.googleapis.com/auth/firebase.readonly";
        }

        /// <summary>Gets the AvailableProjects resource.</summary>
        public virtual AvailableProjectsResource AvailableProjects { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseManagement requests.</summary>
    public abstract class FirebaseManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseManagementBaseServiceRequest instance.</summary>
        protected FirebaseManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseManagement parameter list.</summary>
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

    /// <summary>The "availableProjects" collection of methods.</summary>
    public class AvailableProjectsResource
    {
        private const string Resource = "availableProjects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AvailableProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Lists each [Google Cloud `Project`](https://cloud.google.com/resource-manager/reference/rest/v1/projects)
        /// that can have Firebase resources added and Firebase services enabled. A Project will only be listed if: -
        /// The caller has sufficient [Google IAM](https://cloud.google.com/iam) permissions to call AddFirebase. - The
        /// Project is not already a FirebaseProject. - The Project is not in an Organization which has policies that
        /// prevent Firebase resources from being added.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists each [Google Cloud `Project`](https://cloud.google.com/resource-manager/reference/rest/v1/projects)
        /// that can have Firebase resources added and Firebase services enabled. A Project will only be listed if: -
        /// The caller has sufficient [Google IAM](https://cloud.google.com/iam) permissions to call AddFirebase. - The
        /// Project is not already a FirebaseProject. - The Project is not in an Organization which has policies that
        /// prevent Firebase resources from being added.
        /// </summary>
        public class ListRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ListAvailableProjectsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of Projects to return in the response. The server may return fewer than this value at
            /// its discretion. If no value is specified (or too large a value is specified), the server will impose its
            /// own limit. This value cannot be negative.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Token returned from a previous call to `ListAvailableProjects` indicating where in the set of Projects
            /// to resume listing.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/availableProjects";

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
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
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
            AndroidApps = new AndroidAppsResource(service);
            AvailableLocations = new AvailableLocationsResource(service);
            DefaultLocation = new DefaultLocationResource(service);
            IosApps = new IosAppsResource(service);
            WebApps = new WebAppsResource(service);
        }

        /// <summary>Gets the AndroidApps resource.</summary>
        public virtual AndroidAppsResource AndroidApps { get; }

        /// <summary>The "androidApps" collection of methods.</summary>
        public class AndroidAppsResource
        {
            private const string Resource = "androidApps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AndroidAppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Sha = new ShaResource(service);
            }

            /// <summary>Gets the Sha resource.</summary>
            public virtual ShaResource Sha { get; }

            /// <summary>The "sha" collection of methods.</summary>
            public class ShaResource
            {
                private const string Resource = "sha";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ShaResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Adds a ShaCertificate to the specified AndroidApp.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The resource name of the parent AndroidApp to which to add a ShaCertificate, in the format:
                /// projects/PROJECT_IDENTIFIER/androidApps/ APP_ID Since an APP_ID is a unique identifier, the Unique
                /// Resource from Sub-Collection access pattern may be used here, in the format:
                /// projects/-/androidApps/APP_ID Refer to the `AndroidApp`
                /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.FirebaseManagement.v1beta1.Data.ShaCertificate body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Adds a ShaCertificate to the specified AndroidApp.</summary>
                public class CreateRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ShaCertificate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.ShaCertificate body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the parent AndroidApp to which to add a ShaCertificate, in the format:
                    /// projects/PROJECT_IDENTIFIER/androidApps/ APP_ID Since an APP_ID is a unique identifier, the
                    /// Unique Resource from Sub-Collection access pattern may be used here, in the format:
                    /// projects/-/androidApps/APP_ID Refer to the `AndroidApp`
                    /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about
                    /// PROJECT_IDENTIFIER and APP_ID values.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseManagement.v1beta1.Data.ShaCertificate Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/sha";

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
                            Pattern = @"^projects/[^/]+/androidApps/[^/]+$",
                        });
                    }
                }

                /// <summary>Removes a ShaCertificate from the specified AndroidApp.</summary>
                /// <param name="name">
                /// The resource name of the ShaCertificate to remove from the parent AndroidApp, in the format:
                /// projects/PROJECT_IDENTIFIER/androidApps/APP_ID /sha/SHA_HASH Refer to the `ShaCertificate`
                /// [`name`](../projects.androidApps.sha#ShaCertificate.FIELDS.name) field for details about
                /// PROJECT_IDENTIFIER, APP_ID, and SHA_HASH values. You can obtain the full resource name of the
                /// `ShaCertificate` from the response of [`ListShaCertificates`](../projects.androidApps.sha/list) or
                /// the original [`CreateShaCertificate`](../projects.androidApps.sha/create).
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Removes a ShaCertificate from the specified AndroidApp.</summary>
                public class DeleteRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the ShaCertificate to remove from the parent AndroidApp, in the format:
                    /// projects/PROJECT_IDENTIFIER/androidApps/APP_ID /sha/SHA_HASH Refer to the `ShaCertificate`
                    /// [`name`](../projects.androidApps.sha#ShaCertificate.FIELDS.name) field for details about
                    /// PROJECT_IDENTIFIER, APP_ID, and SHA_HASH values. You can obtain the full resource name of the
                    /// `ShaCertificate` from the response of [`ListShaCertificates`](../projects.androidApps.sha/list)
                    /// or the original [`CreateShaCertificate`](../projects.androidApps.sha/create).
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
                            Pattern = @"^projects/[^/]+/androidApps/[^/]+/sha/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the SHA-1 and SHA-256 certificates for the specified AndroidApp.</summary>
                /// <param name="parent">
                /// The resource name of the parent AndroidApp for which to list each associated ShaCertificate, in the
                /// format: projects/PROJECT_IDENTIFIER /androidApps/APP_ID Since an APP_ID is a unique identifier, the
                /// Unique Resource from Sub-Collection access pattern may be used here, in the format:
                /// projects/-/androidApps/APP_ID Refer to the `AndroidApp`
                /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the SHA-1 and SHA-256 certificates for the specified AndroidApp.</summary>
                public class ListRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ListShaCertificatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the parent AndroidApp for which to list each associated ShaCertificate, in
                    /// the format: projects/PROJECT_IDENTIFIER /androidApps/APP_ID Since an APP_ID is a unique
                    /// identifier, the Unique Resource from Sub-Collection access pattern may be used here, in the
                    /// format: projects/-/androidApps/APP_ID Refer to the `AndroidApp`
                    /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about
                    /// PROJECT_IDENTIFIER and APP_ID values.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/sha";

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
                            Pattern = @"^projects/[^/]+/androidApps/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Requests the creation of a new AndroidApp in the specified FirebaseProject. The result of this call is
            /// an `Operation` which can be used to track the provisioning process. The `Operation` is automatically
            /// deleted after completion, so there is no need to call `DeleteOperation`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The resource name of the parent FirebaseProject in which to create an AndroidApp, in the format:
            /// projects/PROJECT_IDENTIFIER/androidApps Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Requests the creation of a new AndroidApp in the specified FirebaseProject. The result of this call is
            /// an `Operation` which can be used to track the provisioning process. The `Operation` is automatically
            /// deleted after completion, so there is no need to call `DeleteOperation`.
            /// </summary>
            public class CreateRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the parent FirebaseProject in which to create an AndroidApp, in the format:
                /// projects/PROJECT_IDENTIFIER/androidApps Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/androidApps";

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

            /// <summary>Gets the specified AndroidApp.</summary>
            /// <param name="name">
            /// The resource name of the AndroidApp, in the format: projects/ PROJECT_IDENTIFIER/androidApps/APP_ID
            /// Since an APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be
            /// used here, in the format: projects/-/androidApps/APP_ID Refer to the `AndroidApp`
            /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and
            /// APP_ID values.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the specified AndroidApp.</summary>
            public class GetRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the AndroidApp, in the format: projects/ PROJECT_IDENTIFIER/androidApps/APP_ID
                /// Since an APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may
                /// be used here, in the format: projects/-/androidApps/APP_ID Refer to the `AndroidApp`
                /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
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
                        Pattern = @"^projects/[^/]+/androidApps/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the configuration artifact associated with the specified AndroidApp.</summary>
            /// <param name="name">
            /// The resource name of the AndroidApp configuration to download, in the format:
            /// projects/PROJECT_IDENTIFIER/androidApps/APP_ID/config Since an APP_ID is a unique identifier, the Unique
            /// Resource from Sub-Collection access pattern may be used here, in the format:
            /// projects/-/androidApps/APP_ID Refer to the `AndroidApp`
            /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and
            /// APP_ID values.
            /// </param>
            public virtual GetConfigRequest GetConfig(string name)
            {
                return new GetConfigRequest(this.service, name);
            }

            /// <summary>Gets the configuration artifact associated with the specified AndroidApp.</summary>
            public class GetConfigRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.AndroidAppConfig>
            {
                /// <summary>Constructs a new GetConfig request.</summary>
                public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the AndroidApp configuration to download, in the format:
                /// projects/PROJECT_IDENTIFIER/androidApps/APP_ID/config Since an APP_ID is a unique identifier, the
                /// Unique Resource from Sub-Collection access pattern may be used here, in the format:
                /// projects/-/androidApps/APP_ID Refer to the `AndroidApp`
                /// [`name`](../projects.androidApps#AndroidApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes GetConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/androidApps/[^/]+/config$",
                    });
                }
            }

            /// <summary>
            /// Lists each AndroidApp associated with the specified FirebaseProject. The elements are returned in no
            /// particular order, but will be a consistent view of the Apps when additional requests are made with a
            /// `pageToken`.
            /// </summary>
            /// <param name="parent">
            /// The resource name of the parent FirebaseProject for which to list each associated AndroidApp, in the
            /// format: projects/PROJECT_IDENTIFIER /androidApps Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists each AndroidApp associated with the specified FirebaseProject. The elements are returned in no
            /// particular order, but will be a consistent view of the Apps when additional requests are made with a
            /// `pageToken`.
            /// </summary>
            public class ListRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ListAndroidAppsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the parent FirebaseProject for which to list each associated AndroidApp, in the
                /// format: projects/PROJECT_IDENTIFIER /androidApps Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of Apps to return in the response. The server may return fewer than this at its
                /// discretion. If no value is specified (or too large a value is specified), then the server will
                /// impose its own limit.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Token returned from a previous call to `ListAndroidApps` indicating where in the set of Apps to
                /// resume listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Controls whether Apps in the DELETED state should be returned in the response. If not specified,
                /// only `ACTIVE` Apps will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/androidApps";

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

            /// <summary>Updates the attributes of the specified AndroidApp.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the AndroidApp, in the format: projects/ PROJECT_IDENTIFIER/androidApps/APP_ID *
            /// PROJECT_IDENTIFIER: the parent Project's
            /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
            /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers
            /// in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for
            /// PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique,
            /// Firebase-assigned identifier for the App (see
            /// [`appId`](../projects.androidApps#AndroidApp.FIELDS.app_id)).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates the attributes of the specified AndroidApp.</summary>
            public class PatchRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the AndroidApp, in the format: projects/ PROJECT_IDENTIFIER/androidApps/APP_ID
                /// * PROJECT_IDENTIFIER: the parent Project's
                /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
                /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project
                /// identifiers in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value
                /// for PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique,
                /// Firebase-assigned identifier for the App (see
                /// [`appId`](../projects.androidApps#AndroidApp.FIELDS.app_id)).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Specifies which fields of the AndroidApp to update. Note that the following fields are immutable:
                /// `name`, `app_id`, `project_id`, and `package_name`. To update `state`, use any of the following
                /// endpoints: RemoveAndroidApp or UndeleteAndroidApp.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.AndroidApp Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/androidApps/[^/]+$",
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

            /// <summary>Removes the specified AndroidApp from the FirebaseProject.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the AndroidApp, in the format: projects/
            /// PROJECT_IDENTIFIER/androidApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource from
            /// Sub-Collection access pattern may be used here, in the format: projects/-/androidApps/APP_ID Refer to
            /// the AndroidApp [name](../projects.androidApps#AndroidApp.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER and APP_ID values.
            /// </param>
            public virtual RemoveRequest Remove(Google.Apis.FirebaseManagement.v1beta1.Data.RemoveAndroidAppRequest body, string name)
            {
                return new RemoveRequest(this.service, body, name);
            }

            /// <summary>Removes the specified AndroidApp from the FirebaseProject.</summary>
            public class RemoveRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Remove request.</summary>
                public RemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.RemoveAndroidAppRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the AndroidApp, in the format: projects/
                /// PROJECT_IDENTIFIER/androidApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource
                /// from Sub-Collection access pattern may be used here, in the format: projects/-/androidApps/APP_ID
                /// Refer to the AndroidApp [name](../projects.androidApps#AndroidApp.FIELDS.name) field for details
                /// about PROJECT_IDENTIFIER and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.RemoveAndroidAppRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "remove";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:remove";

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
                        Pattern = @"^projects/[^/]+/androidApps/[^/]+$",
                    });
                }
            }

            /// <summary>Restores the specified AndroidApp to the FirebaseProject.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the AndroidApp, in the format: projects/
            /// PROJECT_IDENTIFIER/androidApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource from
            /// Sub-Collection access pattern may be used here, in the format: projects/-/androidApps/APP_ID Refer to
            /// the AndroidApp [name](../projects.androidApps#AndroidApp.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER and APP_ID values.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteAndroidAppRequest body, string name)
            {
                return new UndeleteRequest(this.service, body, name);
            }

            /// <summary>Restores the specified AndroidApp to the FirebaseProject.</summary>
            public class UndeleteRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteAndroidAppRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the AndroidApp, in the format: projects/
                /// PROJECT_IDENTIFIER/androidApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource
                /// from Sub-Collection access pattern may be used here, in the format: projects/-/androidApps/APP_ID
                /// Refer to the AndroidApp [name](../projects.androidApps#AndroidApp.FIELDS.name) field for details
                /// about PROJECT_IDENTIFIER and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteAndroidAppRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:undelete";

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
                        Pattern = @"^projects/[^/]+/androidApps/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the AvailableLocations resource.</summary>
        public virtual AvailableLocationsResource AvailableLocations { get; }

        /// <summary>The "availableLocations" collection of methods.</summary>
        public class AvailableLocationsResource
        {
            private const string Resource = "availableLocations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AvailableLocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// **DECOMMISSIONED.** **If called, this endpoint will return a 404 error.** _Instead, use the applicable
            /// resource-specific REST API (or associated documentation, as needed) to determine valid locations for
            /// each resource used in your Project._ Lists the valid ["locations for default Google Cloud
            /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location) for the
            /// specified Project (including a FirebaseProject). One of these locations can be selected as the Project's
            /// location for default Google Cloud resources, which is the geographical location where the Project's
            /// resources associated with Google App Engine (such as the default Cloud Firestore instance) will be
            /// provisioned by default. However, if the location for default Google Cloud resources has already been set
            /// for the Project, then this setting cannot be changed. This call checks for any possible [location
            /// restrictions](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations) for
            /// the specified Project and, thus, might return a subset of all possible locations. To list all locations
            /// (regardless of any restrictions), call the endpoint without specifying a unique project identifier (that
            /// is, `/v1beta1/{parent=projects/-}/listAvailableLocations`). To call `ListAvailableLocations` with a
            /// specified project, a member must be at minimum a Viewer of the Project. Calls without a specified
            /// project do not require any specific project permissions.
            /// </summary>
            /// <param name="parent">
            /// The FirebaseProject for which to list [locations for default Google Cloud
            /// resources](https://firebase.google.com/docs/projects/locations#default-cloud-location), in the format:
            /// projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values. If
            /// no unique project identifier is specified (that is, `projects/-`), the returned list does not take into
            /// account org-specific or project-specific location restrictions.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// **DECOMMISSIONED.** **If called, this endpoint will return a 404 error.** _Instead, use the applicable
            /// resource-specific REST API (or associated documentation, as needed) to determine valid locations for
            /// each resource used in your Project._ Lists the valid ["locations for default Google Cloud
            /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location) for the
            /// specified Project (including a FirebaseProject). One of these locations can be selected as the Project's
            /// location for default Google Cloud resources, which is the geographical location where the Project's
            /// resources associated with Google App Engine (such as the default Cloud Firestore instance) will be
            /// provisioned by default. However, if the location for default Google Cloud resources has already been set
            /// for the Project, then this setting cannot be changed. This call checks for any possible [location
            /// restrictions](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations) for
            /// the specified Project and, thus, might return a subset of all possible locations. To list all locations
            /// (regardless of any restrictions), call the endpoint without specifying a unique project identifier (that
            /// is, `/v1beta1/{parent=projects/-}/listAvailableLocations`). To call `ListAvailableLocations` with a
            /// specified project, a member must be at minimum a Viewer of the Project. Calls without a specified
            /// project do not require any specific project permissions.
            /// </summary>
            public class ListRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ListAvailableLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The FirebaseProject for which to list [locations for default Google Cloud
                /// resources](https://firebase.google.com/docs/projects/locations#default-cloud-location), in the
                /// format: projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// If no unique project identifier is specified (that is, `projects/-`), the returned list does not
                /// take into account org-specific or project-specific location restrictions.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of locations to return in the response. The server may return fewer than this
                /// value at its discretion. If no value is specified (or too large a value is specified), then the
                /// server will impose its own limit. This value cannot be negative.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Token returned from a previous call to `ListAvailableLocations` indicating where in the list of
                /// locations to resume listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/availableLocations";

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

        /// <summary>Gets the DefaultLocation resource.</summary>
        public virtual DefaultLocationResource DefaultLocation { get; }

        /// <summary>The "defaultLocation" collection of methods.</summary>
        public class DefaultLocationResource
        {
            private const string Resource = "defaultLocation";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DefaultLocationResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// **DECOMMISSIONED.** **If called, this endpoint will return a 404 error.** _Instead, use the applicable
            /// resource-specific REST API to set the location for each resource used in your Project._ Sets the
            /// ["location for default Google Cloud
            /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location) for the
            /// specified FirebaseProject. This method creates a Google App Engine application with a [default Cloud
            /// Storage
            /// bucket](https://cloud.google.com/appengine/docs/standard/python/googlecloudstorageclient/setting-up-cloud-storage#activating_a_cloud_storage_bucket),
            /// located in the specified [`locationId`](#body.request_body.FIELDS.location_id). This location must be
            /// one of the available [App Engine locations](https://cloud.google.com/about/locations#region). After the
            /// location for default Google Cloud resources is finalized, or if it was already set, it cannot be
            /// changed. The location for default Google Cloud resources for the specified `FirebaseProject` might
            /// already be set because either the underlying Google Cloud `Project` already has an App Engine
            /// application or `FinalizeDefaultLocation` was previously called with a specified `locationId`. The result
            /// of this call is an [`Operation`](../../v1beta1/operations), which can be used to track the provisioning
            /// process. The [`response`](../../v1beta1/operations#Operation.FIELDS.response) type of the `Operation` is
            /// google.protobuf.Empty. The `Operation` can be polled by its `name` using GetOperation until `done` is
            /// true. When `done` is true, the `Operation` has either succeeded or failed. If the `Operation` has
            /// succeeded, its [`response`](../../v1beta1/operations#Operation.FIELDS.response) will be set to a
            /// google.protobuf.Empty; if the `Operation` has failed, its `error` will be set to a google.rpc.Status.
            /// The `Operation` is automatically deleted after completion, so there is no need to call DeleteOperation.
            /// All fields listed in the [request body](#request-body) are required. To call `FinalizeDefaultLocation`,
            /// a member must be an Owner of the Project.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The resource name of the FirebaseProject for which the ["location for default Google Cloud
            /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location) will be set, in
            /// the format: projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual FinalizeRequest Finalize(Google.Apis.FirebaseManagement.v1beta1.Data.FinalizeDefaultLocationRequest body, string parent)
            {
                return new FinalizeRequest(this.service, body, parent);
            }

            /// <summary>
            /// **DECOMMISSIONED.** **If called, this endpoint will return a 404 error.** _Instead, use the applicable
            /// resource-specific REST API to set the location for each resource used in your Project._ Sets the
            /// ["location for default Google Cloud
            /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location) for the
            /// specified FirebaseProject. This method creates a Google App Engine application with a [default Cloud
            /// Storage
            /// bucket](https://cloud.google.com/appengine/docs/standard/python/googlecloudstorageclient/setting-up-cloud-storage#activating_a_cloud_storage_bucket),
            /// located in the specified [`locationId`](#body.request_body.FIELDS.location_id). This location must be
            /// one of the available [App Engine locations](https://cloud.google.com/about/locations#region). After the
            /// location for default Google Cloud resources is finalized, or if it was already set, it cannot be
            /// changed. The location for default Google Cloud resources for the specified `FirebaseProject` might
            /// already be set because either the underlying Google Cloud `Project` already has an App Engine
            /// application or `FinalizeDefaultLocation` was previously called with a specified `locationId`. The result
            /// of this call is an [`Operation`](../../v1beta1/operations), which can be used to track the provisioning
            /// process. The [`response`](../../v1beta1/operations#Operation.FIELDS.response) type of the `Operation` is
            /// google.protobuf.Empty. The `Operation` can be polled by its `name` using GetOperation until `done` is
            /// true. When `done` is true, the `Operation` has either succeeded or failed. If the `Operation` has
            /// succeeded, its [`response`](../../v1beta1/operations#Operation.FIELDS.response) will be set to a
            /// google.protobuf.Empty; if the `Operation` has failed, its `error` will be set to a google.rpc.Status.
            /// The `Operation` is automatically deleted after completion, so there is no need to call DeleteOperation.
            /// All fields listed in the [request body](#request-body) are required. To call `FinalizeDefaultLocation`,
            /// a member must be an Owner of the Project.
            /// </summary>
            public class FinalizeRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Finalize request.</summary>
                public FinalizeRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.FinalizeDefaultLocationRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the FirebaseProject for which the ["location for default Google Cloud
                /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location) will be set,
                /// in the format: projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.FinalizeDefaultLocationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "finalize";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/defaultLocation:finalize";

                /// <summary>Initializes Finalize parameter list.</summary>
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
        }

        /// <summary>Gets the IosApps resource.</summary>
        public virtual IosAppsResource IosApps { get; }

        /// <summary>The "iosApps" collection of methods.</summary>
        public class IosAppsResource
        {
            private const string Resource = "iosApps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public IosAppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Requests the creation of a new IosApp in the specified FirebaseProject. The result of this call is an
            /// `Operation` which can be used to track the provisioning process. The `Operation` is automatically
            /// deleted after completion, so there is no need to call `DeleteOperation`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The resource name of the parent FirebaseProject in which to create an IosApp, in the format:
            /// projects/PROJECT_IDENTIFIER/iosApps Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseManagement.v1beta1.Data.IosApp body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Requests the creation of a new IosApp in the specified FirebaseProject. The result of this call is an
            /// `Operation` which can be used to track the provisioning process. The `Operation` is automatically
            /// deleted after completion, so there is no need to call `DeleteOperation`.
            /// </summary>
            public class CreateRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.IosApp body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the parent FirebaseProject in which to create an IosApp, in the format:
                /// projects/PROJECT_IDENTIFIER/iosApps Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.IosApp Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/iosApps";

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

            /// <summary>Gets the specified IosApp.</summary>
            /// <param name="name">
            /// The resource name of the IosApp, in the format: projects/PROJECT_IDENTIFIER /iosApps/APP_ID Since an
            /// APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be used here,
            /// in the format: projects/-/iosApps/APP_ID Refer to the `IosApp`
            /// [`name`](../projects.iosApps#IosApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and APP_ID
            /// values.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the specified IosApp.</summary>
            public class GetRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.IosApp>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the IosApp, in the format: projects/PROJECT_IDENTIFIER /iosApps/APP_ID Since an
                /// APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be used
                /// here, in the format: projects/-/iosApps/APP_ID Refer to the `IosApp`
                /// [`name`](../projects.iosApps#IosApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and
                /// APP_ID values.
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
                        Pattern = @"^projects/[^/]+/iosApps/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the configuration artifact associated with the specified IosApp.</summary>
            /// <param name="name">
            /// The resource name of the App configuration to download, in the format:
            /// projects/PROJECT_IDENTIFIER/iosApps/APP_ID/config Since an APP_ID is a unique identifier, the Unique
            /// Resource from Sub-Collection access pattern may be used here, in the format: projects/-/iosApps/APP_ID
            /// Refer to the `IosApp` [`name`](../projects.iosApps#IosApp.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER and APP_ID values.
            /// </param>
            public virtual GetConfigRequest GetConfig(string name)
            {
                return new GetConfigRequest(this.service, name);
            }

            /// <summary>Gets the configuration artifact associated with the specified IosApp.</summary>
            public class GetConfigRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.IosAppConfig>
            {
                /// <summary>Constructs a new GetConfig request.</summary>
                public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the App configuration to download, in the format:
                /// projects/PROJECT_IDENTIFIER/iosApps/APP_ID/config Since an APP_ID is a unique identifier, the Unique
                /// Resource from Sub-Collection access pattern may be used here, in the format:
                /// projects/-/iosApps/APP_ID Refer to the `IosApp` [`name`](../projects.iosApps#IosApp.FIELDS.name)
                /// field for details about PROJECT_IDENTIFIER and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes GetConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/iosApps/[^/]+/config$",
                    });
                }
            }

            /// <summary>
            /// Lists each IosApp associated with the specified FirebaseProject. The elements are returned in no
            /// particular order, but will be a consistent view of the Apps when additional requests are made with a
            /// `pageToken`.
            /// </summary>
            /// <param name="parent">
            /// The resource name of the parent FirebaseProject for which to list each associated IosApp, in the format:
            /// projects/PROJECT_IDENTIFIER/iosApps Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists each IosApp associated with the specified FirebaseProject. The elements are returned in no
            /// particular order, but will be a consistent view of the Apps when additional requests are made with a
            /// `pageToken`.
            /// </summary>
            public class ListRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ListIosAppsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the parent FirebaseProject for which to list each associated IosApp, in the
                /// format: projects/PROJECT_IDENTIFIER/iosApps Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of Apps to return in the response. The server may return fewer than this at its
                /// discretion. If no value is specified (or too large a value is specified), the server will impose its
                /// own limit.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Token returned from a previous call to `ListIosApps` indicating where in the set of Apps to resume
                /// listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Controls whether Apps in the DELETED state should be returned in the response. If not specified,
                /// only `ACTIVE` Apps will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/iosApps";

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

            /// <summary>Updates the attributes of the specified IosApp.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the IosApp, in the format: projects/PROJECT_IDENTIFIER /iosApps/APP_ID *
            /// PROJECT_IDENTIFIER: the parent Project's
            /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
            /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers
            /// in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for
            /// PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique,
            /// Firebase-assigned identifier for the App (see [`appId`](../projects.iosApps#IosApp.FIELDS.app_id)).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseManagement.v1beta1.Data.IosApp body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates the attributes of the specified IosApp.</summary>
            public class PatchRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.IosApp>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.IosApp body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the IosApp, in the format: projects/PROJECT_IDENTIFIER /iosApps/APP_ID *
                /// PROJECT_IDENTIFIER: the parent Project's
                /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
                /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project
                /// identifiers in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value
                /// for PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique,
                /// Firebase-assigned identifier for the App (see [`appId`](../projects.iosApps#IosApp.FIELDS.app_id)).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Specifies which fields of the IosApp to update. Note that the following fields are immutable:
                /// `name`, `app_id`, `project_id`, and `bundle_id`. To update `state`, use any of the following
                /// endpoints: RemoveIosApp or UndeleteIosApp.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.IosApp Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/iosApps/[^/]+$",
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

            /// <summary>Removes the specified IosApp from the FirebaseProject.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the IosApp, in the format: projects/ PROJECT_IDENTIFIER/iosApps/APP_ID
            /// Since an APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be
            /// used here, in the format: projects/-/iosApps/APP_ID Refer to the IosApp
            /// [name](../projects.iosApps#IosApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and APP_ID
            /// values.
            /// </param>
            public virtual RemoveRequest Remove(Google.Apis.FirebaseManagement.v1beta1.Data.RemoveIosAppRequest body, string name)
            {
                return new RemoveRequest(this.service, body, name);
            }

            /// <summary>Removes the specified IosApp from the FirebaseProject.</summary>
            public class RemoveRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Remove request.</summary>
                public RemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.RemoveIosAppRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the IosApp, in the format: projects/
                /// PROJECT_IDENTIFIER/iosApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource from
                /// Sub-Collection access pattern may be used here, in the format: projects/-/iosApps/APP_ID Refer to
                /// the IosApp [name](../projects.iosApps#IosApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.RemoveIosAppRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "remove";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:remove";

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
                        Pattern = @"^projects/[^/]+/iosApps/[^/]+$",
                    });
                }
            }

            /// <summary>Restores the specified IosApp to the FirebaseProject.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the IosApp, in the format: projects/ PROJECT_IDENTIFIER/iosApps/APP_ID
            /// Since an APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be
            /// used here, in the format: projects/-/iosApps/APP_ID Refer to the IosApp
            /// [name](../projects.iosApps#IosApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and APP_ID
            /// values.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteIosAppRequest body, string name)
            {
                return new UndeleteRequest(this.service, body, name);
            }

            /// <summary>Restores the specified IosApp to the FirebaseProject.</summary>
            public class UndeleteRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteIosAppRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the IosApp, in the format: projects/
                /// PROJECT_IDENTIFIER/iosApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource from
                /// Sub-Collection access pattern may be used here, in the format: projects/-/iosApps/APP_ID Refer to
                /// the IosApp [name](../projects.iosApps#IosApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteIosAppRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:undelete";

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
                        Pattern = @"^projects/[^/]+/iosApps/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the WebApps resource.</summary>
        public virtual WebAppsResource WebApps { get; }

        /// <summary>The "webApps" collection of methods.</summary>
        public class WebAppsResource
        {
            private const string Resource = "webApps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebAppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Requests the creation of a new WebApp in the specified FirebaseProject. The result of this call is an
            /// `Operation` which can be used to track the provisioning process. The `Operation` is automatically
            /// deleted after completion, so there is no need to call `DeleteOperation`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The resource name of the parent FirebaseProject in which to create a WebApp, in the format:
            /// projects/PROJECT_IDENTIFIER/webApps Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.FirebaseManagement.v1beta1.Data.WebApp body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Requests the creation of a new WebApp in the specified FirebaseProject. The result of this call is an
            /// `Operation` which can be used to track the provisioning process. The `Operation` is automatically
            /// deleted after completion, so there is no need to call `DeleteOperation`.
            /// </summary>
            public class CreateRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.WebApp body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the parent FirebaseProject in which to create a WebApp, in the format:
                /// projects/PROJECT_IDENTIFIER/webApps Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.WebApp Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/webApps";

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

            /// <summary>Gets the specified WebApp.</summary>
            /// <param name="name">
            /// The resource name of the WebApp, in the format: projects/PROJECT_IDENTIFIER /webApps/APP_ID Since an
            /// APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be used here,
            /// in the format: projects/-/webApps/APP_ID Refer to the `WebApp`
            /// [`name`](../projects.webApps#WebApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and APP_ID
            /// values.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the specified WebApp.</summary>
            public class GetRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.WebApp>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the WebApp, in the format: projects/PROJECT_IDENTIFIER /webApps/APP_ID Since an
                /// APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be used
                /// here, in the format: projects/-/webApps/APP_ID Refer to the `WebApp`
                /// [`name`](../projects.webApps#WebApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and
                /// APP_ID values.
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
                        Pattern = @"^projects/[^/]+/webApps/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the configuration artifact associated with the specified WebApp.</summary>
            /// <param name="name">
            /// The resource name of the WebApp configuration to download, in the format:
            /// projects/PROJECT_IDENTIFIER/webApps/APP_ID/config Since an APP_ID is a unique identifier, the Unique
            /// Resource from Sub-Collection access pattern may be used here, in the format: projects/-/webApps/APP_ID
            /// Refer to the `WebApp` [`name`](../projects.webApps#WebApp.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER and APP_ID values.
            /// </param>
            public virtual GetConfigRequest GetConfig(string name)
            {
                return new GetConfigRequest(this.service, name);
            }

            /// <summary>Gets the configuration artifact associated with the specified WebApp.</summary>
            public class GetConfigRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.WebAppConfig>
            {
                /// <summary>Constructs a new GetConfig request.</summary>
                public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the WebApp configuration to download, in the format:
                /// projects/PROJECT_IDENTIFIER/webApps/APP_ID/config Since an APP_ID is a unique identifier, the Unique
                /// Resource from Sub-Collection access pattern may be used here, in the format:
                /// projects/-/webApps/APP_ID Refer to the `WebApp` [`name`](../projects.webApps#WebApp.FIELDS.name)
                /// field for details about PROJECT_IDENTIFIER and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

                /// <summary>Initializes GetConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/webApps/[^/]+/config$",
                    });
                }
            }

            /// <summary>
            /// Lists each WebApp associated with the specified FirebaseProject. The elements are returned in no
            /// particular order, but will be a consistent view of the Apps when additional requests are made with a
            /// `pageToken`.
            /// </summary>
            /// <param name="parent">
            /// The resource name of the parent FirebaseProject for which to list each associated WebApp, in the format:
            /// projects/PROJECT_IDENTIFIER/webApps Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists each WebApp associated with the specified FirebaseProject. The elements are returned in no
            /// particular order, but will be a consistent view of the Apps when additional requests are made with a
            /// `pageToken`.
            /// </summary>
            public class ListRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ListWebAppsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the parent FirebaseProject for which to list each associated WebApp, in the
                /// format: projects/PROJECT_IDENTIFIER/webApps Refer to the `FirebaseProject`
                /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of Apps to return in the response. The server may return fewer than this value at
                /// its discretion. If no value is specified (or too large a value is specified), then the server will
                /// impose its own limit.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Token returned from a previous call to `ListWebApps` indicating where in the set of Apps to resume
                /// listing.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Controls whether Apps in the DELETED state should be returned in the response. If not specified,
                /// only `ACTIVE` Apps will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/webApps";

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

            /// <summary>Updates the attributes of the specified WebApp.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the WebApp, in the format: projects/PROJECT_IDENTIFIER /webApps/APP_ID *
            /// PROJECT_IDENTIFIER: the parent Project's
            /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
            /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers
            /// in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for
            /// PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique,
            /// Firebase-assigned identifier for the App (see [`appId`](../projects.webApps#WebApp.FIELDS.app_id)).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.FirebaseManagement.v1beta1.Data.WebApp body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates the attributes of the specified WebApp.</summary>
            public class PatchRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.WebApp>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.WebApp body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the WebApp, in the format: projects/PROJECT_IDENTIFIER /webApps/APP_ID *
                /// PROJECT_IDENTIFIER: the parent Project's
                /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
                /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project
                /// identifiers in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value
                /// for PROJECT_IDENTIFIER in any response body will be the `ProjectId`. * APP_ID: the globally unique,
                /// Firebase-assigned identifier for the App (see [`appId`](../projects.webApps#WebApp.FIELDS.app_id)).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Specifies which fields of the WebApp to update. Note that the following fields are immutable:
                /// `name`, `app_id`, and `project_id`. To update `state`, use any of the following endpoints:
                /// RemoveWebApp or UndeleteWebApp.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.WebApp Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/webApps/[^/]+$",
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

            /// <summary>Removes the specified WebApp from the FirebaseProject.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the WebApp, in the format: projects/ PROJECT_IDENTIFIER/webApps/APP_ID
            /// Since an APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be
            /// used here, in the format: projects/-/webApps/APP_ID Refer to the WebApp
            /// [name](../projects.webApps#WebApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and APP_ID
            /// values.
            /// </param>
            public virtual RemoveRequest Remove(Google.Apis.FirebaseManagement.v1beta1.Data.RemoveWebAppRequest body, string name)
            {
                return new RemoveRequest(this.service, body, name);
            }

            /// <summary>Removes the specified WebApp from the FirebaseProject.</summary>
            public class RemoveRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Remove request.</summary>
                public RemoveRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.RemoveWebAppRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the WebApp, in the format: projects/
                /// PROJECT_IDENTIFIER/webApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource from
                /// Sub-Collection access pattern may be used here, in the format: projects/-/webApps/APP_ID Refer to
                /// the WebApp [name](../projects.webApps#WebApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.RemoveWebAppRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "remove";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:remove";

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
                        Pattern = @"^projects/[^/]+/webApps/[^/]+$",
                    });
                }
            }

            /// <summary>Restores the specified WebApp to the FirebaseProject.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the WebApp, in the format: projects/ PROJECT_IDENTIFIER/webApps/APP_ID
            /// Since an APP_ID is a unique identifier, the Unique Resource from Sub-Collection access pattern may be
            /// used here, in the format: projects/-/webApps/APP_ID Refer to the WebApp
            /// [name](../projects.webApps#WebApp.FIELDS.name) field for details about PROJECT_IDENTIFIER and APP_ID
            /// values.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteWebAppRequest body, string name)
            {
                return new UndeleteRequest(this.service, body, name);
            }

            /// <summary>Restores the specified WebApp to the FirebaseProject.</summary>
            public class UndeleteRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteWebAppRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the WebApp, in the format: projects/
                /// PROJECT_IDENTIFIER/webApps/APP_ID Since an APP_ID is a unique identifier, the Unique Resource from
                /// Sub-Collection access pattern may be used here, in the format: projects/-/webApps/APP_ID Refer to
                /// the WebApp [name](../projects.webApps#WebApp.FIELDS.name) field for details about PROJECT_IDENTIFIER
                /// and APP_ID values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.FirebaseManagement.v1beta1.Data.UndeleteWebAppRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:undelete";

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
                        Pattern = @"^projects/[^/]+/webApps/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Adds Firebase resources and enables Firebase services in the specified existing [Google Cloud
        /// `Project`](https://cloud.google.com/resource-manager/reference/rest/v1/projects). Since a FirebaseProject is
        /// actually also a Google Cloud `Project`, a `FirebaseProject` has the same underlying Google Cloud identifiers
        /// (`projectNumber` and `projectId`). This allows for easy interop with Google APIs. The result of this call is
        /// an [`Operation`](../../v1beta1/operations). Poll the `Operation` to track the provisioning process by
        /// calling GetOperation until [`done`](../../v1beta1/operations#Operation.FIELDS.done) is `true`. When `done`
        /// is `true`, the `Operation` has either succeeded or failed. If the `Operation` succeeded, its
        /// [`response`](../../v1beta1/operations#Operation.FIELDS.response) is set to a FirebaseProject; if the
        /// `Operation` failed, its [`error`](../../v1beta1/operations#Operation.FIELDS.error) is set to a
        /// google.rpc.Status. The `Operation` is automatically deleted after completion, so there is no need to call
        /// DeleteOperation. This method does not modify any billing account information on the underlying Google Cloud
        /// `Project`. To call `AddFirebase`, a project member or service account must have the following permissions
        /// (the IAM roles of Editor and Owner contain these permissions): `firebase.projects.update`,
        /// `resourcemanager.projects.get`, `serviceusage.services.enable`, and `serviceusage.services.get`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">
        /// The resource name of the Google Cloud `Project` in which Firebase resources will be added and Firebase
        /// services enabled, in the format: projects/ PROJECT_IDENTIFIER Refer to the `FirebaseProject`
        /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values. After
        /// calling `AddFirebase`, the unique Project identifiers (
        /// [`projectNumber`](https://cloud.google.com/resource-manager/reference/rest/v1/projects#Project.FIELDS.project_number)
        /// and
        /// [`projectId`](https://cloud.google.com/resource-manager/reference/rest/v1/projects#Project.FIELDS.project_id))
        /// of the underlying Google Cloud `Project` are also the identifiers of the FirebaseProject.
        /// </param>
        public virtual AddFirebaseRequest AddFirebase(Google.Apis.FirebaseManagement.v1beta1.Data.AddFirebaseRequest body, string project)
        {
            return new AddFirebaseRequest(this.service, body, project);
        }

        /// <summary>
        /// Adds Firebase resources and enables Firebase services in the specified existing [Google Cloud
        /// `Project`](https://cloud.google.com/resource-manager/reference/rest/v1/projects). Since a FirebaseProject is
        /// actually also a Google Cloud `Project`, a `FirebaseProject` has the same underlying Google Cloud identifiers
        /// (`projectNumber` and `projectId`). This allows for easy interop with Google APIs. The result of this call is
        /// an [`Operation`](../../v1beta1/operations). Poll the `Operation` to track the provisioning process by
        /// calling GetOperation until [`done`](../../v1beta1/operations#Operation.FIELDS.done) is `true`. When `done`
        /// is `true`, the `Operation` has either succeeded or failed. If the `Operation` succeeded, its
        /// [`response`](../../v1beta1/operations#Operation.FIELDS.response) is set to a FirebaseProject; if the
        /// `Operation` failed, its [`error`](../../v1beta1/operations#Operation.FIELDS.error) is set to a
        /// google.rpc.Status. The `Operation` is automatically deleted after completion, so there is no need to call
        /// DeleteOperation. This method does not modify any billing account information on the underlying Google Cloud
        /// `Project`. To call `AddFirebase`, a project member or service account must have the following permissions
        /// (the IAM roles of Editor and Owner contain these permissions): `firebase.projects.update`,
        /// `resourcemanager.projects.get`, `serviceusage.services.enable`, and `serviceusage.services.get`.
        /// </summary>
        public class AddFirebaseRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new AddFirebase request.</summary>
            public AddFirebaseRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.AddFirebaseRequest body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the Google Cloud `Project` in which Firebase resources will be added and Firebase
            /// services enabled, in the format: projects/ PROJECT_IDENTIFIER Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// After calling `AddFirebase`, the unique Project identifiers (
            /// [`projectNumber`](https://cloud.google.com/resource-manager/reference/rest/v1/projects#Project.FIELDS.project_number)
            /// and
            /// [`projectId`](https://cloud.google.com/resource-manager/reference/rest/v1/projects#Project.FIELDS.project_id))
            /// of the underlying Google Cloud `Project` are also the identifiers of the FirebaseProject.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseManagement.v1beta1.Data.AddFirebaseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addFirebase";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+project}:addFirebase";

            /// <summary>Initializes AddFirebase parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Links the specified FirebaseProject with an existing [Google Analytics
        /// account](http://www.google.com/analytics/). Using this call, you can either: - Specify an
        /// `analyticsAccountId` to provision a new Google Analytics property within the specified account and associate
        /// the new property with the `FirebaseProject`. - Specify an existing `analyticsPropertyId` to associate the
        /// property with the `FirebaseProject`. Note that when you call `AddGoogleAnalytics`: 1. The first check
        /// determines if any existing data streams in the Google Analytics property correspond to any existing Firebase
        /// Apps in the `FirebaseProject` (based on the `packageName` or `bundleId` associated with the data stream).
        /// Then, as applicable, the data streams and apps are linked. Note that this auto-linking only applies to
        /// `AndroidApps` and `IosApps`. 2. If no corresponding data streams are found for the Firebase Apps, new data
        /// streams are provisioned in the Google Analytics property for each of the Firebase Apps. Note that a new data
        /// stream is always provisioned for a Web App even if it was previously associated with a data stream in the
        /// Analytics property. Learn more about the hierarchy and structure of Google Analytics accounts in the
        /// [Analytics documentation](https://support.google.com/analytics/answer/9303323). The result of this call is
        /// an [`Operation`](../../v1beta1/operations). Poll the `Operation` to track the provisioning process by
        /// calling GetOperation until [`done`](../../v1beta1/operations#Operation.FIELDS.done) is `true`. When `done`
        /// is `true`, the `Operation` has either succeeded or failed. If the `Operation` succeeded, its
        /// [`response`](../../v1beta1/operations#Operation.FIELDS.response) is set to an AnalyticsDetails; if the
        /// `Operation` failed, its [`error`](../../v1beta1/operations#Operation.FIELDS.error) is set to a
        /// google.rpc.Status. To call `AddGoogleAnalytics`, a project member must be an Owner for the existing
        /// `FirebaseProject` and have the [`Edit` permission](https://support.google.com/analytics/answer/2884495) for
        /// the Google Analytics account. If the `FirebaseProject` already has Google Analytics enabled, and you call
        /// `AddGoogleAnalytics` using an `analyticsPropertyId` that's different from the currently associated property,
        /// then the call will fail. Analytics may have already been enabled in the Firebase console or by specifying
        /// `timeZone` and `regionCode` in the call to [`AddFirebase`](../../v1beta1/projects/addFirebase).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// The resource name of the FirebaseProject to link to an existing Google Analytics account, in the format:
        /// projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name)
        /// field for details about PROJECT_IDENTIFIER values.
        /// </param>
        public virtual AddGoogleAnalyticsRequest AddGoogleAnalytics(Google.Apis.FirebaseManagement.v1beta1.Data.AddGoogleAnalyticsRequest body, string parent)
        {
            return new AddGoogleAnalyticsRequest(this.service, body, parent);
        }

        /// <summary>
        /// Links the specified FirebaseProject with an existing [Google Analytics
        /// account](http://www.google.com/analytics/). Using this call, you can either: - Specify an
        /// `analyticsAccountId` to provision a new Google Analytics property within the specified account and associate
        /// the new property with the `FirebaseProject`. - Specify an existing `analyticsPropertyId` to associate the
        /// property with the `FirebaseProject`. Note that when you call `AddGoogleAnalytics`: 1. The first check
        /// determines if any existing data streams in the Google Analytics property correspond to any existing Firebase
        /// Apps in the `FirebaseProject` (based on the `packageName` or `bundleId` associated with the data stream).
        /// Then, as applicable, the data streams and apps are linked. Note that this auto-linking only applies to
        /// `AndroidApps` and `IosApps`. 2. If no corresponding data streams are found for the Firebase Apps, new data
        /// streams are provisioned in the Google Analytics property for each of the Firebase Apps. Note that a new data
        /// stream is always provisioned for a Web App even if it was previously associated with a data stream in the
        /// Analytics property. Learn more about the hierarchy and structure of Google Analytics accounts in the
        /// [Analytics documentation](https://support.google.com/analytics/answer/9303323). The result of this call is
        /// an [`Operation`](../../v1beta1/operations). Poll the `Operation` to track the provisioning process by
        /// calling GetOperation until [`done`](../../v1beta1/operations#Operation.FIELDS.done) is `true`. When `done`
        /// is `true`, the `Operation` has either succeeded or failed. If the `Operation` succeeded, its
        /// [`response`](../../v1beta1/operations#Operation.FIELDS.response) is set to an AnalyticsDetails; if the
        /// `Operation` failed, its [`error`](../../v1beta1/operations#Operation.FIELDS.error) is set to a
        /// google.rpc.Status. To call `AddGoogleAnalytics`, a project member must be an Owner for the existing
        /// `FirebaseProject` and have the [`Edit` permission](https://support.google.com/analytics/answer/2884495) for
        /// the Google Analytics account. If the `FirebaseProject` already has Google Analytics enabled, and you call
        /// `AddGoogleAnalytics` using an `analyticsPropertyId` that's different from the currently associated property,
        /// then the call will fail. Analytics may have already been enabled in the Firebase console or by specifying
        /// `timeZone` and `regionCode` in the call to [`AddFirebase`](../../v1beta1/projects/addFirebase).
        /// </summary>
        public class AddGoogleAnalyticsRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Operation>
        {
            /// <summary>Constructs a new AddGoogleAnalytics request.</summary>
            public AddGoogleAnalyticsRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.AddGoogleAnalyticsRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the FirebaseProject to link to an existing Google Analytics account, in the format:
            /// projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseManagement.v1beta1.Data.AddGoogleAnalyticsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addGoogleAnalytics";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+parent}:addGoogleAnalytics";

            /// <summary>Initializes AddGoogleAnalytics parameter list.</summary>
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

        /// <summary>Gets the specified FirebaseProject.</summary>
        /// <param name="name">
        /// The resource name of the FirebaseProject, in the format: projects/ PROJECT_IDENTIFIER Refer to the
        /// `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
        /// PROJECT_IDENTIFIER values.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets the specified FirebaseProject.</summary>
        public class GetRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.FirebaseProject>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the FirebaseProject, in the format: projects/ PROJECT_IDENTIFIER Refer to the
            /// `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER values.
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
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets the configuration artifact associated with the specified FirebaseProject, which can be used by servers
        /// to simplify initialization. Typically, this configuration is used with the Firebase Admin SDK
        /// [initializeApp](https://firebase.google.com/docs/admin/setup#initialize_the_sdk) command.
        /// </summary>
        /// <param name="name">
        /// The resource name of the FirebaseProject, in the format: projects/ PROJECT_IDENTIFIER/adminSdkConfig Refer
        /// to the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
        /// PROJECT_IDENTIFIER values.
        /// </param>
        public virtual GetAdminSdkConfigRequest GetAdminSdkConfig(string name)
        {
            return new GetAdminSdkConfigRequest(this.service, name);
        }

        /// <summary>
        /// Gets the configuration artifact associated with the specified FirebaseProject, which can be used by servers
        /// to simplify initialization. Typically, this configuration is used with the Firebase Admin SDK
        /// [initializeApp](https://firebase.google.com/docs/admin/setup#initialize_the_sdk) command.
        /// </summary>
        public class GetAdminSdkConfigRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.AdminSdkConfig>
        {
            /// <summary>Constructs a new GetAdminSdkConfig request.</summary>
            public GetAdminSdkConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the FirebaseProject, in the format: projects/ PROJECT_IDENTIFIER/adminSdkConfig
            /// Refer to the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER values.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAdminSdkConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

            /// <summary>Initializes GetAdminSdkConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/adminSdkConfig$",
                });
            }
        }

        /// <summary>
        /// Gets the Google Analytics details currently associated with the specified FirebaseProject. If the
        /// `FirebaseProject` is not yet linked to Google Analytics, then the response to `GetAnalyticsDetails` is
        /// `NOT_FOUND`.
        /// </summary>
        /// <param name="name">
        /// The resource name of the FirebaseProject, in the format: projects/ PROJECT_IDENTIFIER/analyticsDetails Refer
        /// to the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
        /// PROJECT_IDENTIFIER values.
        /// </param>
        public virtual GetAnalyticsDetailsRequest GetAnalyticsDetails(string name)
        {
            return new GetAnalyticsDetailsRequest(this.service, name);
        }

        /// <summary>
        /// Gets the Google Analytics details currently associated with the specified FirebaseProject. If the
        /// `FirebaseProject` is not yet linked to Google Analytics, then the response to `GetAnalyticsDetails` is
        /// `NOT_FOUND`.
        /// </summary>
        public class GetAnalyticsDetailsRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.AnalyticsDetails>
        {
            /// <summary>Constructs a new GetAnalyticsDetails request.</summary>
            public GetAnalyticsDetailsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the FirebaseProject, in the format: projects/ PROJECT_IDENTIFIER/analyticsDetails
            /// Refer to the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER values.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAnalyticsDetails";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

            /// <summary>Initializes GetAnalyticsDetails parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/analyticsDetails$",
                });
            }
        }

        /// <summary>
        /// Lists each FirebaseProject accessible to the caller. The elements are returned in no particular order, but
        /// they will be a consistent view of the Projects when additional requests are made with a `pageToken`. This
        /// method is eventually consistent with Project mutations, which means newly provisioned Projects and recent
        /// modifications to existing Projects might not be reflected in the set of Projects. The list will include only
        /// ACTIVE Projects. Use GetFirebaseProject for consistent reads as well as for additional Project details.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists each FirebaseProject accessible to the caller. The elements are returned in no particular order, but
        /// they will be a consistent view of the Projects when additional requests are made with a `pageToken`. This
        /// method is eventually consistent with Project mutations, which means newly provisioned Projects and recent
        /// modifications to existing Projects might not be reflected in the set of Projects. The list will include only
        /// ACTIVE Projects. Use GetFirebaseProject for consistent reads as well as for additional Project details.
        /// </summary>
        public class ListRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.ListFirebaseProjectsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of Projects to return in the response. The server may return fewer than this at its
            /// discretion. If no value is specified (or too large a value is specified), the server will impose its own
            /// limit. This value cannot be negative.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Token returned from a previous call to `ListFirebaseProjects` indicating where in the set of Projects to
            /// resume listing.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. Controls whether Projects in the DELETED state should be returned in the response. If not
            /// specified, only `ACTIVE` Projects will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/projects";

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
        /// Updates the attributes of the specified FirebaseProject. All [query parameters](#query-parameters) are
        /// required.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the Project, in the format: projects/PROJECT_IDENTIFIER PROJECT_IDENTIFIER: the
        /// Project's [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
        /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in
        /// Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER
        /// in any response body will be the `ProjectId`.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.FirebaseManagement.v1beta1.Data.FirebaseProject body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates the attributes of the specified FirebaseProject. All [query parameters](#query-parameters) are
        /// required.
        /// </summary>
        public class PatchRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.FirebaseProject>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.FirebaseProject body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the Project, in the format: projects/PROJECT_IDENTIFIER PROJECT_IDENTIFIER: the
            /// Project's [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or
            /// its [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project
            /// identifiers in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for
            /// PROJECT_IDENTIFIER in any response body will be the `ProjectId`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Specifies which fields of the FirebaseProject to update. Note that the following fields are immutable:
            /// `name`, `project_id`, and `project_number`. To update `state`, use any of the following Google Cloud
            /// endpoints:
            /// [`projects.delete`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/delete) or
            /// [`projects.undelete`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/undelete)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseManagement.v1beta1.Data.FirebaseProject Body { get; set; }

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
        /// Unlinks the specified FirebaseProject from its Google Analytics account. This call removes the association
        /// of the specified `FirebaseProject` with its current Google Analytics property. However, this call does not
        /// delete the Google Analytics resources, such as the Google Analytics property or any data streams. These
        /// resources may be re-associated later to the `FirebaseProject` by calling
        /// [`AddGoogleAnalytics`](../../v1beta1/projects/addGoogleAnalytics) and specifying the same
        /// `analyticsPropertyId`. For Android Apps and iOS Apps, this call re-links data streams with their
        /// corresponding apps. However, for Web Apps, this call provisions a *new* data stream for each Web App. To
        /// call `RemoveAnalytics`, a project member must be an Owner for the `FirebaseProject`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// The resource name of the FirebaseProject to unlink from its Google Analytics account, in the format:
        /// projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name)
        /// field for details about PROJECT_IDENTIFIER values.
        /// </param>
        public virtual RemoveAnalyticsRequest RemoveAnalytics(Google.Apis.FirebaseManagement.v1beta1.Data.RemoveAnalyticsRequest body, string parent)
        {
            return new RemoveAnalyticsRequest(this.service, body, parent);
        }

        /// <summary>
        /// Unlinks the specified FirebaseProject from its Google Analytics account. This call removes the association
        /// of the specified `FirebaseProject` with its current Google Analytics property. However, this call does not
        /// delete the Google Analytics resources, such as the Google Analytics property or any data streams. These
        /// resources may be re-associated later to the `FirebaseProject` by calling
        /// [`AddGoogleAnalytics`](../../v1beta1/projects/addGoogleAnalytics) and specifying the same
        /// `analyticsPropertyId`. For Android Apps and iOS Apps, this call re-links data streams with their
        /// corresponding apps. However, for Web Apps, this call provisions a *new* data stream for each Web App. To
        /// call `RemoveAnalytics`, a project member must be an Owner for the `FirebaseProject`.
        /// </summary>
        public class RemoveAnalyticsRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.Empty>
        {
            /// <summary>Constructs a new RemoveAnalytics request.</summary>
            public RemoveAnalyticsRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseManagement.v1beta1.Data.RemoveAnalyticsRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the FirebaseProject to unlink from its Google Analytics account, in the format:
            /// projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject`
            /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseManagement.v1beta1.Data.RemoveAnalyticsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "removeAnalytics";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+parent}:removeAnalytics";

            /// <summary>Initializes RemoveAnalytics parameter list.</summary>
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

        /// <summary>
        /// Lists all available Apps for the specified FirebaseProject. This is a convenience method. Typically,
        /// interaction with an App should be done using the platform-specific service, but some tool use-cases require
        /// a summary of all known Apps (such as for App selector interfaces).
        /// </summary>
        /// <param name="parent">
        /// The parent FirebaseProject for which to list Apps, in the format: projects/ PROJECT_IDENTIFIER Refer to the
        /// `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
        /// PROJECT_IDENTIFIER values.
        /// </param>
        public virtual SearchAppsRequest SearchApps(string parent)
        {
            return new SearchAppsRequest(this.service, parent);
        }

        /// <summary>
        /// Lists all available Apps for the specified FirebaseProject. This is a convenience method. Typically,
        /// interaction with an App should be done using the platform-specific service, but some tool use-cases require
        /// a summary of all known Apps (such as for App selector interfaces).
        /// </summary>
        public class SearchAppsRequest : FirebaseManagementBaseServiceRequest<Google.Apis.FirebaseManagement.v1beta1.Data.SearchFirebaseAppsResponse>
        {
            /// <summary>Constructs a new SearchApps request.</summary>
            public SearchAppsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// The parent FirebaseProject for which to list Apps, in the format: projects/ PROJECT_IDENTIFIER Refer to
            /// the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name) field for details about
            /// PROJECT_IDENTIFIER values.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// A query string compatible with Google's [AIP-160 standard](https://google.aip.dev/160). Use any of the
            /// following fields in a query: * [`app_id`](../projects/searchApps#FirebaseAppInfo.FIELDS.app_id) *
            /// [`namespace`](../projects/searchApps#FirebaseAppInfo.FIELDS.namespace) *
            /// [`platform`](../projects/searchApps#FirebaseAppInfo.FIELDS.platform) This query also supports the
            /// following "virtual" fields. These are fields which are not actually part of the returned resource
            /// object, but they can be queried as if they are pre-populated with specific values. * `sha1_hash` or
            /// `sha1_hashes`: This field is considered to be a _repeated_ `string` field, populated with the list of
            /// all SHA-1 certificate fingerprints registered with the AndroidApp. This list is empty if the App is not
            /// an `AndroidApp`. * `sha256_hash` or `sha256_hashes`: This field is considered to be a _repeated_
            /// `string` field, populated with the list of all SHA-256 certificate fingerprints registered with the
            /// AndroidApp. This list is empty if the App is not an `AndroidApp`. * `app_store_id`: This field is
            /// considered to be a _singular_ `string` field, populated with the Apple App Store ID registered with the
            /// IosApp. This field is empty if the App is not an `IosApp`. * `team_id`: This field is considered to be a
            /// _singular_ `string` field, populated with the Apple team ID registered with the IosApp. This field is
            /// empty if the App is not an `IosApp`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of Apps to return in the response. The server may return fewer than this value at its
            /// discretion. If no value is specified (or too large a value is specified), then the server will impose
            /// its own limit. This value cannot be negative.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Token returned from a previous call to `SearchFirebaseApps` indicating where in the set of Apps to
            /// resume listing.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Controls whether Apps in the DELETED state should be returned. If not specified, only `ACTIVE` Apps will
            /// be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "searchApps";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+parent}:searchApps";

            /// <summary>Initializes SearchApps parameter list.</summary>
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
    }
}
namespace Google.Apis.FirebaseManagement.v1beta1.Data
{
    /// <summary>All fields are required.</summary>
    public class AddFirebaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **DEPRECATED.** _Instead, use product-specific REST APIs to work with the location of each resource in a
        /// Project. This field may be ignored, especially for newly provisioned projects after October 30, 2024._ The
        /// ID of the Project's ["location for default Google Cloud
        /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location), which are resources
        /// associated with Google App Engine. The location must be one of the available [Google App Engine
        /// locations](https://cloud.google.com/about/locations#region).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AddGoogleAnalyticsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID for the existing [Google Analytics account](http://www.google.com/analytics/) that you want to link
        /// with the `FirebaseProject`. Specifying this field will provision a new Google Analytics property in your
        /// Google Analytics account and associate the new property with the `FirebaseProject`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsAccountId")]
        public virtual string AnalyticsAccountId { get; set; }

        /// <summary>
        /// The ID for the existing Google Analytics property that you want to associate with the `FirebaseProject`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsPropertyId")]
        public virtual string AnalyticsPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdminSdkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **DEPRECATED.** _Instead, find the URL of the default Realtime Database instance using the [list
        /// endpoint](https://firebase.google.com/docs/reference/rest/database/database-management/rest/v1beta/projects.locations.instances/list)
        /// within the Firebase Realtime Database REST API. If the default instance for the Project has not yet been
        /// provisioned, the return might not contain a default instance. Note that the config that's generated for the
        /// Firebase console or the Firebase CLI uses the Realtime Database endpoint to populate this value for that
        /// config._ The URL of the default Firebase Realtime Database instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseURL")]
        public virtual string DatabaseURL { get; set; }

        /// <summary>
        /// **DEPRECATED.** _Instead, use product-specific REST APIs to find the location of each resource in a Project.
        /// This field may not be populated, especially for newly provisioned projects after October 30, 2024._ The ID
        /// of the Project's ["location for default Google Cloud
        /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location), which are resources
        /// associated with Google App Engine. The location is one of the available [App Engine
        /// locations](https://cloud.google.com/about/locations#region). This field is omitted if the location for
        /// default Google Cloud resources has not been set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Immutable. A user-assigned unique identifier for the `FirebaseProject`. This identifier may appear in URLs
        /// or names for some Firebase resources associated with the Project, but it should generally be treated as a
        /// convenience alias to reference the Project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// **DEPRECATED.** _Instead, find the name of the default Cloud Storage for Firebase bucket using the [list
        /// endpoint](https://firebase.google.com/docs/reference/rest/storage/rest/v1beta/projects.buckets/list) within
        /// the Cloud Storage for Firebase REST API. If the default bucket for the Project has not yet been provisioned,
        /// the return might not contain a default bucket. Note that the config that's generated for the Firebase
        /// console or the Firebase CLI uses the Cloud Storage for Firebase endpoint to populate this value for that
        /// config._ The name of the default Cloud Storage for Firebase bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBucket")]
        public virtual string StorageBucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AnalyticsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Analytics Property object associated with the specified `FirebaseProject`. This object contains the
        /// details of the Google Analytics property associated with the Project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsProperty")]
        public virtual AnalyticsProperty AnalyticsProperty { get; set; }

        /// <summary>
        ///  - For `AndroidApps` and `IosApps`: a map of `app` to `streamId` for each Firebase App in the specified
        /// `FirebaseProject`. Each `app` and `streamId` appears only once. - For `WebApps`: a map of `app` to
        /// `streamId` and `measurementId` for each `WebApp` in the specified `FirebaseProject`. Each `app`, `streamId`,
        /// and `measurementId` appears only once.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamMappings")]
        public virtual System.Collections.Generic.IList<StreamMapping> StreamMappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a Google Analytics property</summary>
    public class AnalyticsProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The ID of the [Google Analytics account](https://www.google.com/analytics/) for the Google
        /// Analytics property associated with the specified FirebaseProject.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsAccountId")]
        public virtual string AnalyticsAccountId { get; set; }

        /// <summary>
        /// The display name of the Google Analytics property associated with the specified `FirebaseProject`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The globally unique, Google-assigned identifier of the Google Analytics property associated with the
        /// specified `FirebaseProject`. If you called [`AddGoogleAnalytics`](../../v1beta1/projects/addGoogleAnalytics)
        /// to link the `FirebaseProject` with a Google Analytics account, the value in this `id` field is the same as
        /// the ID of the property either specified or provisioned with that call to `AddGoogleAnalytics`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a Firebase App for Android.</summary>
    public class AndroidApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The globally unique, Google-assigned identifier (UID) for the Firebase API key associated with the
        /// `AndroidApp`. Be aware that this value is the UID of the API key, _not_ the
        /// [`keyString`](https://cloud.google.com/api-keys/docs/reference/rest/v2/projects.locations.keys#Key.FIELDS.key_string)
        /// of the API key. The `keyString` is the value that can be found in the App's [configuration
        /// artifact](../../rest/v1beta1/projects.androidApps/getConfig). If `api_key_id` is not set in requests to
        /// [`androidApps.Create`](../../rest/v1beta1/projects.androidApps/create), then Firebase automatically
        /// associates an `api_key_id` with the `AndroidApp`. This auto-associated key may be an existing valid key or,
        /// if no valid key exists, a new one will be provisioned. In patch requests, `api_key_id` cannot be set to an
        /// empty value, and the new UID must have no restrictions or only have restrictions that are valid for the
        /// associated `AndroidApp`. We recommend using the [Google Cloud
        /// Console](https://console.cloud.google.com/apis/credentials) to manage API keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyId")]
        public virtual string ApiKeyId { get; set; }

        /// <summary>
        /// Output only. Immutable. The globally unique, Firebase-assigned identifier for the `AndroidApp`. This
        /// identifier should be treated as an opaque token, as the data format is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>The user-assigned display name for the `AndroidApp`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and it may be sent with update
        /// requests to ensure the client has an up-to-date value before proceeding. Learn more about `etag` in Google's
        /// [AIP-154 standard](https://google.aip.dev/154#declarative-friendly-resources). This etag is strongly
        /// validated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. If the App has been removed from the Project, this is the timestamp of when the App is
        /// considered expired and will be permanently deleted. After this time, the App cannot be undeleted (that is,
        /// restored to the Project). This value is only provided if the App is in the `DELETED` state.
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
        /// The resource name of the AndroidApp, in the format: projects/ PROJECT_IDENTIFIER/androidApps/APP_ID *
        /// PROJECT_IDENTIFIER: the parent Project's
        /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
        /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in
        /// Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER
        /// in any response body will be the `ProjectId`. * APP_ID: the globally unique, Firebase-assigned identifier
        /// for the App (see [`appId`](../projects.androidApps#AndroidApp.FIELDS.app_id)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The canonical package name of the Android app as would appear in the Google Play Developer
        /// Console.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Output only. Immutable. A user-assigned unique identifier of the parent FirebaseProject for the
        /// `AndroidApp`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The SHA1 certificate hashes for the AndroidApp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hashes")]
        public virtual System.Collections.Generic.IList<string> Sha1Hashes { get; set; }

        /// <summary>The SHA256 certificate hashes for the AndroidApp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hashes")]
        public virtual System.Collections.Generic.IList<string> Sha256Hashes { get; set; }

        /// <summary>Output only. The lifecycle state of the App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }
    }

    /// <summary>Configuration metadata of a single Firebase App for Android.</summary>
    public class AndroidAppConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the JSON configuration file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configFileContents")]
        public virtual string ConfigFileContents { get; set; }

        /// <summary>
        /// The filename that the configuration artifact for the `AndroidApp` is typically saved as. For example:
        /// `google-services.json`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configFilename")]
        public virtual string ConfigFilename { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **DEPRECATED.** _Auto-provisioning of these resources is changing, so this object no longer reliably provides
    /// information about the resources within the Project. Instead, retrieve information about each resource directly
    /// from its resource-specific API._ The default auto-provisioned resources associated with the Project.
    /// </summary>
    public class DefaultResources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. **DEPRECATED.** _Instead, find the name of the default Firebase Hosting site using
        /// [ListSites](https://firebase.google.com/docs/reference/hosting/rest/v1beta1/projects.sites/list) within the
        /// Firebase Hosting REST API. If the default Hosting site for the Project has not yet been provisioned, the
        /// return might not contain a default site._ The name of the default Firebase Hosting site, in the format:
        /// PROJECT_ID Though rare, your `projectId` might already be used as the name for an existing Hosting site in
        /// another project (learn more about creating non-default, [additional
        /// sites](https://firebase.google.com/docs/hosting/multisites)). In these cases, your `projectId` is appended
        /// with a hyphen then five alphanumeric characters to create your default Hosting site name. For example, if
        /// your `projectId` is `myproject123`, your default Hosting site name might be: `myproject123-a5c16`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostingSite")]
        public virtual string HostingSite { get; set; }

        /// <summary>
        /// Output only. **DEPRECATED.** _Instead, use product-specific REST APIs to find the location of each resource
        /// in a Project. This field may not be populated, especially for newly provisioned projects after October 30,
        /// 2024._ The ID of the Project's ["location for default Google Cloud
        /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location), which are resources
        /// associated with Google App Engine. The location is one of the available [Google App Engine
        /// locations](https://cloud.google.com/about/locations#region). This field is omitted if the location for
        /// default Google Cloud resources has not been set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Output only. **DEPRECATED.** _Instead, find the name of the default Realtime Database instance using the
        /// [list
        /// endpoint](https://firebase.google.com/docs/reference/rest/database/database-management/rest/v1beta/projects.locations.instances/list)
        /// within the Firebase Realtime Database REST API. If the default Realtime Database instance for a Project has
        /// not yet been provisioned, the return might not contain a default instance._ The default Firebase Realtime
        /// Database instance name, in the format: PROJECT_ID Though rare, your `projectId` might already be used as the
        /// name for an existing Realtime Database instance in another project (learn more about [database
        /// sharding](https://firebase.google.com/docs/database/usage/sharding)). In these cases, your `projectId` is
        /// appended with a hyphen then five alphanumeric characters to create your default Realtime Database instance
        /// name. For example, if your `projectId` is `myproject123`, your default database instance name might be:
        /// `myproject123-a5c16`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realtimeDatabaseInstance")]
        public virtual string RealtimeDatabaseInstance { get; set; }

        /// <summary>
        /// Output only. **DEPRECATED.** _Instead, find the name of the default Cloud Storage for Firebase bucket using
        /// the [list
        /// endpoint](https://firebase.google.com/docs/reference/rest/storage/rest/v1beta/projects.buckets/list) within
        /// the Cloud Storage for Firebase REST API. If the default bucket for the Project has not yet been provisioned,
        /// the return might not contain a default bucket._ The name of the default Cloud Storage for Firebase bucket,
        /// in one of the following formats: * If provisioned _before_ October 30, 2024: PROJECT_ID.firebasestorage.app
        /// * If provisioned _on or after_ October 30, 2024: PROJECT_ID.firebasestorage.app
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBucket")]
        public virtual string StorageBucket { get; set; }

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

    public class FinalizeDefaultLocationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **DEPRECATED** The ID of the Project's ["location for default Google Cloud
        /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location), which are resources
        /// associated with Google App Engine. The location must be one of the available [Google App Engine
        /// locations](https://cloud.google.com/about/locations#region).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A high-level summary of an App.</summary>
    public class FirebaseAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The globally unique, Google-assigned identifier (UID) for the Firebase API key associated with the App. Be
        /// aware that this value is the UID of the API key, _not_ the
        /// [`keyString`](https://cloud.google.com/api-keys/docs/reference/rest/v2/projects.locations.keys#Key.FIELDS.key_string)
        /// of the API key. The `keyString` is the value that can be found in the App's configuration artifact
        /// ([`AndroidApp`](../../rest/v1beta1/projects.androidApps/getConfig) |
        /// [`IosApp`](../../rest/v1beta1/projects.iosApps/getConfig) |
        /// [`WebApp`](../../rest/v1beta1/projects.webApps/getConfig)). If `api_key_id` is not set in requests to create
        /// the App ([`AndroidApp`](../../rest/v1beta1/projects.androidApps/create) |
        /// [`IosApp`](../../rest/v1beta1/projects.iosApps/create) |
        /// [`WebApp`](../../rest/v1beta1/projects.webApps/create)), then Firebase automatically associates an
        /// `api_key_id` with the App. This auto-associated key may be an existing valid key or, if no valid key exists,
        /// a new one will be provisioned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyId")]
        public virtual string ApiKeyId { get; set; }

        /// <summary>
        /// Output only. Immutable. The globally unique, Firebase-assigned identifier for the `WebApp`. This identifier
        /// should be treated as an opaque token, as the data format is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>The user-assigned display name of the Firebase App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. If the App has been removed from the Project, this is the timestamp of when the App is
        /// considered expired and will be permanently deleted. After this time, the App cannot be undeleted (that is,
        /// restored to the Project). This value is only provided if the App is in the `DELETED` state.
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
        /// The resource name of the Firebase App, in the format: projects/PROJECT_ID /iosApps/APP_ID or
        /// projects/PROJECT_ID/androidApps/APP_ID or projects/ PROJECT_ID/webApps/APP_ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Immutable. The platform-specific identifier of the App. *Note:* For most use cases, use
        /// `appId`, which is the canonical, globally unique identifier for referencing an App. This string is derived
        /// from a native identifier for each platform: `packageName` for an `AndroidApp`, `bundleId` for an `IosApp`,
        /// and `webId` for a `WebApp`. Its contents should be treated as opaque, as the native identifier format may
        /// change as platforms evolve. This string is only unique within a `FirebaseProject` and its associated Apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>The platform of the Firebase App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>Output only. The lifecycle state of the App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `FirebaseProject` is the top-level Firebase entity. It is the container for Firebase Apps, Firebase Hosting
    /// sites, storage systems (Firebase Realtime Database, Cloud Firestore, Cloud Storage buckets), and other Firebase
    /// and Google Cloud resources. You create a `FirebaseProject` by calling AddFirebase and specifying an *existing*
    /// [Google Cloud `Project`](https://cloud.google.com/resource-manager/reference/rest/v1/projects). This adds
    /// Firebase resources to the existing Google Cloud `Project`. Since a FirebaseProject is actually also a Google
    /// Cloud `Project`, a `FirebaseProject` has the same underlying Google Cloud identifiers (`projectNumber` and
    /// `projectId`). This allows for easy interop with Google APIs.
    /// </summary>
    public class FirebaseProject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A set of user-defined annotations for the FirebaseProject. Learn more about annotations in Google's [AIP-128
        /// standard](https://google.aip.dev/128#annotations). These annotations are intended solely for developers and
        /// client-side tools. Firebase services will not mutate this annotations set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>The user-assigned display name of the Project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and it may be sent with update
        /// requests to ensure the client has an up-to-date value before proceeding. Learn more about `etag` in Google's
        /// [AIP-154 standard](https://google.aip.dev/154#declarative-friendly-resources). This etag is strongly
        /// validated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The resource name of the Project, in the format: projects/PROJECT_IDENTIFIER PROJECT_IDENTIFIER: the
        /// Project's [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
        /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in
        /// Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER
        /// in any response body will be the `ProjectId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Immutable. A user-assigned unique identifier for the Project. This identifier may appear in
        /// URLs or names for some Firebase resources associated with the Project, but it should generally be treated as
        /// a convenience alias to reference the Project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Output only. Immutable. The globally unique, Google-assigned canonical identifier for the Project. Use this
        /// identifier when configuring integrations and/or making API calls to Firebase or third-party services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual System.Nullable<long> ProjectNumber { get; set; }

        /// <summary>
        /// Output only. **DEPRECATED.** _Auto-provisioning of these resources is changing, so this object no longer
        /// reliably provides information about the Project. Instead, retrieve information about each resource directly
        /// from its resource-specific API._ The default Firebase resources associated with the Project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual DefaultResources Resources { get; set; }

        /// <summary>Output only. The lifecycle state of the Project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }
    }

    /// <summary>Details of a Firebase App for iOS.</summary>
    public class IosApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The globally unique, Google-assigned identifier (UID) for the Firebase API key associated with the `IosApp`.
        /// Be aware that this value is the UID of the API key, _not_ the
        /// [`keyString`](https://cloud.google.com/api-keys/docs/reference/rest/v2/projects.locations.keys#Key.FIELDS.key_string)
        /// of the API key. The `keyString` is the value that can be found in the App's [configuration
        /// artifact](../../rest/v1beta1/projects.iosApps/getConfig). If `api_key_id` is not set in requests to
        /// [`iosApps.Create`](../../rest/v1beta1/projects.iosApps/create), then Firebase automatically associates an
        /// `api_key_id` with the `IosApp`. This auto-associated key may be an existing valid key or, if no valid key
        /// exists, a new one will be provisioned. In patch requests, `api_key_id` cannot be set to an empty value, and
        /// the new UID must have no restrictions or only have restrictions that are valid for the associated `IosApp`.
        /// We recommend using the [Google Cloud Console](https://console.cloud.google.com/apis/credentials) to manage
        /// API keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyId")]
        public virtual string ApiKeyId { get; set; }

        /// <summary>
        /// Output only. Immutable. The globally unique, Firebase-assigned identifier for the `IosApp`. This identifier
        /// should be treated as an opaque token, as the data format is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// The automatically generated Apple ID assigned to the iOS app by Apple in the iOS App Store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStoreId")]
        public virtual string AppStoreId { get; set; }

        /// <summary>Immutable. The canonical bundle ID of the iOS app as it would appear in the iOS AppStore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>The user-assigned display name for the `IosApp`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and it may be sent with update
        /// requests to ensure the client has an up-to-date value before proceeding. Learn more about `etag` in Google's
        /// [AIP-154 standard](https://google.aip.dev/154#declarative-friendly-resources). This etag is strongly
        /// validated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. If the App has been removed from the Project, this is the timestamp of when the App is
        /// considered expired and will be permanently deleted. After this time, the App cannot be undeleted (that is,
        /// restored to the Project). This value is only provided if the App is in the `DELETED` state.
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
        /// The resource name of the IosApp, in the format: projects/PROJECT_IDENTIFIER /iosApps/APP_ID *
        /// PROJECT_IDENTIFIER: the parent Project's
        /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
        /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in
        /// Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER
        /// in any response body will be the `ProjectId`. * APP_ID: the globally unique, Firebase-assigned identifier
        /// for the App (see [`appId`](../projects.iosApps#IosApp.FIELDS.app_id)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Immutable. A user-assigned unique identifier of the parent FirebaseProject for the `IosApp`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Output only. The lifecycle state of the App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The Apple Developer Team ID associated with the App in the App Store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamId")]
        public virtual string TeamId { get; set; }
    }

    /// <summary>Configuration metadata of a single Firebase App for iOS.</summary>
    public class IosAppConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content of the XML configuration file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configFileContents")]
        public virtual string ConfigFileContents { get; set; }

        /// <summary>
        /// The filename that the configuration artifact for the `IosApp` is typically saved as. For example:
        /// `GoogleService-Info.plist`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configFilename")]
        public virtual string ConfigFilename { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListAndroidAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of each `AndroidApp` associated with the specified `FirebaseProject`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<AndroidApp> Apps { get; set; }

        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty, then this response is the last page of results. This token can be used in a subsequent call to
        /// `ListAndroidApps` to find the next group of Apps. Page tokens are short-lived and should not be persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListAvailableLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One page of results from a call to `ListAvailableLocations`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty, then this response is the last page of results and all available locations have been listed. This
        /// token can be used in a subsequent call to `ListAvailableLocations` to find more locations. Page tokens are
        /// short-lived and should not be persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListAvailableProjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty, then this response is the last page of results. This token can be used in a subsequent calls to
        /// `ListAvailableProjects` to find the next group of Projects. Page tokens are short-lived and should not be
        /// persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Google Cloud `Projects` which can have Firebase resources added to them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectInfo")]
        public virtual System.Collections.Generic.IList<ProjectInfo> ProjectInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListFirebaseProjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty, then this response is the last page of results. This token can be used in a subsequent calls to
        /// `ListFirebaseProjects` to find the next group of Projects. Page tokens are short-lived and should not be
        /// persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>One page of the list of Projects that are accessible to the caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<FirebaseProject> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListIosAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of each `IosApp` associated with the specified `FirebaseProject`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<IosApp> Apps { get; set; }

        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty, then this response is the last page of results. This token can be used in a subsequent call to
        /// `ListIosApps` to find the next group of Apps. Page tokens are short-lived and should not be persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListShaCertificatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of each `ShaCertificate` associated with the `AndroidApp`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<ShaCertificate> Certificates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListWebAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of each `WebApp` associated with the specified `FirebaseProject`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<WebApp> Apps { get; set; }

        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty, then this response is the last page of results. This token can be used in a subsequent call to
        /// `ListWebApps` to find the next group of Apps. Page tokens are short-lived and should not be persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **DEPRECATED.** _This Location is no longer used to determine Firebase resource locations. Instead, consult
    /// product documentation to determine valid locations for each resource used in your Project._ A ["location for
    /// default Google Cloud resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location)
    /// that can be selected for a FirebaseProject. These are resources associated with Google App Engine.
    /// </summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Products and services that are available in the location for default Google Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<string> Features { get; set; }

        /// <summary>
        /// The ID of the Project's location for default Google Cloud resources. It will be one of the available [Google
        /// App Engine locations](https://cloud.google.com/about/locations#region).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Indicates whether the location for default Google Cloud resources is a [regional or multi-regional
        /// location](https://firebase.google.com/docs/projects/locations#types) for data replication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is proto2's version of MessageSet. DEPRECATED: DO NOT USE FOR NEW FIELDS. If you are using editions or
    /// proto2, please make your own extendable messages for your use case. If you are using proto3, please use `Any`
    /// instead. MessageSet was the implementation of extensions for proto1. When proto2 was introduced, extensions were
    /// implemented as a first-class feature. This schema for MessageSet was meant to be a "bridge" solution to migrate
    /// MessageSet-bearing messages from proto1 to proto2. This schema has been open-sourced only to facilitate the
    /// migration of Google products with MessageSet-bearing messages to open-source environments.
    /// </summary>
    public class MessageSet : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Describes the progress of an LRO. It is included in the `metadata` field of the `Operation`.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a long-running Product operation.</summary>
    public class ProductMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of warnings related to the associated operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningMessages")]
        public virtual System.Collections.Generic.IList<string> WarningMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a Google Cloud `Project`.</summary>
    public class ProjectInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user-assigned display name of the Google Cloud `Project`, for example: `My App`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// **DEPRECATED** _Instead, use product-specific REST APIs to work with the location of each resource in a
        /// Project. This field may not be populated, especially for newly provisioned projects after October 30, 2024._
        /// The ID of the Project's ["location for default Google Cloud
        /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location). The location is one
        /// of the available [Google App Engine locations](https://cloud.google.com/about/locations#region). Not all
        /// Projects will have this field populated. If it is not populated, it means that the Project does not yet have
        /// a location for default Google Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// The resource name of the Google Cloud `Project` to which Firebase resources can be added, in the format:
        /// projects/PROJECT_IDENTIFIER Refer to the `FirebaseProject` [`name`](../projects#FirebaseProject.FIELDS.name)
        /// field for details about PROJECT_IDENTIFIER values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAnalyticsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The ID of the Google Analytics property associated with the specified `FirebaseProject`. - If not
        /// set, then the Google Analytics property that is currently associated with the specified `FirebaseProject` is
        /// removed. - If set, and the specified `FirebaseProject` is currently associated with a *different* Google
        /// Analytics property, then the response is a `412 Precondition Failed` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsPropertyId")]
        public virtual string AnalyticsPropertyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RemoveAndroidAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, and the App is not found, the request will succeed but no action will be taken on the
        /// server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Checksum provided in the AndroidApp resource. If provided, this checksum ensures that the client has an
        /// up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Determines whether to _immediately_ delete the AndroidApp. If set to true, the App is immediately deleted
        /// from the Project and cannot be undeleted (that is, restored to the Project). If not set, defaults to false,
        /// which means the App will be set to expire in 30 days. Within the 30 days, the App may be restored to the
        /// Project using UndeleteAndroidApp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("immediate")]
        public virtual System.Nullable<bool> Immediate { get; set; }

        /// <summary>If set to true, the request is only validated. The App will _not_ be removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    public class RemoveIosAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, and the App is not found, the request will succeed but no action will be taken on the
        /// server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Checksum provided in the IosApp resource. If provided, this checksum ensures that the client has an
        /// up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Determines whether to _immediately_ delete the IosApp. If set to true, the App is immediately deleted from
        /// the Project and cannot be undeleted (that is, restored to the Project). If not set, defaults to false, which
        /// means the App will be set to expire in 30 days. Within the 30 days, the App may be restored to the Project
        /// using UndeleteIosApp
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("immediate")]
        public virtual System.Nullable<bool> Immediate { get; set; }

        /// <summary>If set to true, the request is only validated. The App will _not_ be removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    public class RemoveWebAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, and the App is not found, the request will succeed but no action will be taken on the
        /// server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Checksum provided in the WebApp resource. If provided, this checksum ensures that the client has an
        /// up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Determines whether to _immediately_ delete the WebApp. If set to true, the App is immediately deleted from
        /// the Project and cannot be undeleted (that is, restored to the Project). If not set, defaults to false, which
        /// means the App will be set to expire in 30 days. Within the 30 days, the App may be restored to the Project
        /// using UndeleteWebApp
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("immediate")]
        public virtual System.Nullable<bool> Immediate { get; set; }

        /// <summary>If set to true, the request is only validated. The App will _not_ be removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    public class SearchFirebaseAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One page of results from a call to `SearchFirebaseApps`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<FirebaseAppInfo> Apps { get; set; }

        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. This token can be
        /// used in a subsequent calls to `SearchFirebaseApps` to find the next group of Apps. Page tokens are
        /// short-lived and should not be persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SHA-1 or SHA-256 certificate associated with the AndroidApp.</summary>
    public class ShaCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of SHA certificate encoded in the hash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certType")]
        public virtual string CertType { get; set; }

        /// <summary>
        /// The resource name of the ShaCertificate for the AndroidApp, in the format:
        /// projects/PROJECT_IDENTIFIER/androidApps/APP_ID/sha/SHA_HASH * PROJECT_IDENTIFIER: the parent Project's
        /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
        /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in
        /// Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER
        /// in any response body will be the `ProjectId`. * APP_ID: the globally unique, Firebase-assigned identifier
        /// for the App (see [`appId`](../projects.androidApps#AndroidApp.FIELDS.app_id)). * SHA_HASH: the certificate
        /// hash for the App (see [`shaHash`](../projects.androidApps.sha#ShaCertificate.FIELDS.sha_hash)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The certificate hash for the `AndroidApp`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shaHash")]
        public virtual string ShaHash { get; set; }

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

    /// <summary>Wire-format for a Status object</summary>
    public class StatusProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional int32 canonical_code = 6;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalCode")]
        public virtual System.Nullable<int> CanonicalCode { get; set; }

        /// <summary>
        /// Numeric code drawn from the space specified below. Often, this is the canonical error space, and code is
        /// drawn from google3/util/task/codes.proto copybara:strip_begin(b/383363683) copybara:strip_end_and_replace
        /// optional int32 code = 1;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// Detail message copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional string message = 3;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// message_set associates an arbitrary proto message with the status. copybara:strip_begin(b/383363683)
        /// copybara:strip_end_and_replace optional proto2.bridge.MessageSet message_set = 5;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageSet")]
        public virtual MessageSet MessageSet { get; set; }

        /// <summary>
        /// copybara:strip_begin(b/383363683) Space to which this status belongs copybara:strip_end_and_replace optional
        /// string space = 2; // Space to which this status belongs
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual string Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A mapping of a Firebase App to a Google Analytics data stream</summary>
    public class StreamMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the Firebase App associated with the Google Analytics data stream, in the format:
        /// projects/PROJECT_IDENTIFIER/androidApps/APP_ID or projects/PROJECT_IDENTIFIER/iosApps/APP_ID or
        /// projects/PROJECT_IDENTIFIER /webApps/APP_ID Refer to the `FirebaseProject`
        /// [`name`](../projects#FirebaseProject.FIELDS.name) field for details about PROJECT_IDENTIFIER values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("app")]
        public virtual string App { get; set; }

        /// <summary>
        /// Applicable for Firebase Web Apps only. The unique Google-assigned identifier of the Google Analytics web
        /// stream associated with the Firebase Web App. Firebase SDKs use this ID to interact with Google Analytics
        /// APIs. Learn more about this ID and Google Analytics web streams in the [Analytics
        /// documentation](https://support.google.com/analytics/answer/9304153).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementId")]
        public virtual string MeasurementId { get; set; }

        /// <summary>
        /// The unique Google-assigned identifier of the Google Analytics data stream associated with the Firebase App.
        /// Learn more about Google Analytics data streams in the [Analytics
        /// documentation](https://support.google.com/analytics/answer/9303323).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamId")]
        public virtual System.Nullable<long> StreamId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UndeleteAndroidAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Checksum provided in the AndroidApp resource. If provided, this checksum ensures that the client has an
        /// up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>If set to true, the request is only validated. The App will _not_ be undeleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    public class UndeleteIosAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Checksum provided in the IosApp resource. If provided, this checksum ensures that the client has an
        /// up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>If set to true, the request is only validated. The App will _not_ be undeleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    public class UndeleteWebAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Checksum provided in the WebApp resource. If provided, this checksum ensures that the client has an
        /// up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>If set to true, the request is only validated. The App will _not_ be undeleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    /// <summary>Details of a Firebase App for the web.</summary>
    public class WebApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The globally unique, Google-assigned identifier (UID) for the Firebase API key associated with the `WebApp`.
        /// Be aware that this value is the UID of the API key, _not_ the
        /// [`keyString`](https://cloud.google.com/api-keys/docs/reference/rest/v2/projects.locations.keys#Key.FIELDS.key_string)
        /// of the API key. The `keyString` is the value that can be found in the App's [configuration
        /// artifact](../../rest/v1beta1/projects.webApps/getConfig). If `api_key_id` is not set in requests to
        /// [`webApps.Create`](../../rest/v1beta1/projects.webApps/create), then Firebase automatically associates an
        /// `api_key_id` with the `WebApp`. This auto-associated key may be an existing valid key or, if no valid key
        /// exists, a new one will be provisioned. In patch requests, `api_key_id` cannot be set to an empty value, and
        /// the new UID must have no restrictions or only have restrictions that are valid for the associated `WebApp`.
        /// We recommend using the [Google Cloud Console](https://console.cloud.google.com/apis/credentials) to manage
        /// API keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyId")]
        public virtual string ApiKeyId { get; set; }

        /// <summary>
        /// Output only. Immutable. The globally unique, Firebase-assigned identifier for the `WebApp`. This identifier
        /// should be treated as an opaque token, as the data format is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>The URLs where the `WebApp` is hosted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appUrls")]
        public virtual System.Collections.Generic.IList<string> AppUrls { get; set; }

        /// <summary>The user-assigned display name for the `WebApp`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and it may be sent with update
        /// requests to ensure the client has an up-to-date value before proceeding. Learn more about `etag` in Google's
        /// [AIP-154 standard](https://google.aip.dev/154#declarative-friendly-resources). This etag is strongly
        /// validated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. If the App has been removed from the Project, this is the timestamp of when the App is
        /// considered expired and will be permanently deleted. After this time, the App cannot be undeleted (that is,
        /// restored to the Project). This value is only provided if the App is in the `DELETED` state.
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
        /// The resource name of the WebApp, in the format: projects/PROJECT_IDENTIFIER /webApps/APP_ID *
        /// PROJECT_IDENTIFIER: the parent Project's
        /// [`ProjectNumber`](../projects#FirebaseProject.FIELDS.project_number) ***(recommended)*** or its
        /// [`ProjectId`](../projects#FirebaseProject.FIELDS.project_id). Learn more about using project identifiers in
        /// Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). Note that the value for PROJECT_IDENTIFIER
        /// in any response body will be the `ProjectId`. * APP_ID: the globally unique, Firebase-assigned identifier
        /// for the App (see [`appId`](../projects.webApps#WebApp.FIELDS.app_id)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Immutable. A user-assigned unique identifier of the parent FirebaseProject for the `WebApp`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Output only. The lifecycle state of the App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Immutable. A unique, Firebase-assigned identifier for the `WebApp`. This identifier is only
        /// used to populate the `namespace` value for the `WebApp`. For most use cases, use `appId` to identify or
        /// reference the App. The `webId` value is only unique within a `FirebaseProject` and its associated Apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webId")]
        public virtual string WebId { get; set; }
    }

    /// <summary>Configuration metadata of a single Firebase App for the web.</summary>
    public class WebAppConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The
        /// [`keyString`](https://cloud.google.com/api-keys/docs/reference/rest/v2/projects.locations.keys#Key.FIELDS.key_string)
        /// of the API key associated with the `WebApp`. Note that this value is _not_ the
        /// [`apiKeyId`](../projects.webApps#WebApp.FIELDS.api_key_id) (the UID) of the API key associated with the
        /// `WebApp`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKey")]
        public virtual string ApiKey { get; set; }

        /// <summary>Immutable. The globally unique, Firebase-assigned identifier for the `WebApp`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// The domain Firebase Auth configures for OAuth redirects, in the format: PROJECT_ID.firebaseapp.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authDomain")]
        public virtual string AuthDomain { get; set; }

        /// <summary>
        /// **DEPRECATED.** _Instead, find the URL of the default Realtime Database instance using the [list
        /// endpoint](https://firebase.google.com/docs/reference/rest/database/database-management/rest/v1beta/projects.locations.instances/list)
        /// within the Firebase Realtime Database REST API. If the default instance for the Project has not yet been
        /// provisioned, the return might not contain a default instance. Note that the config that's generated for the
        /// Firebase console or the Firebase CLI uses the Realtime Database endpoint to populate this value for that
        /// config._ The URL of the default Firebase Realtime Database instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseURL")]
        public virtual string DatabaseURL { get; set; }

        /// <summary>
        /// **DEPRECATED.** _Instead, use product-specific REST APIs to find the location of each resource in a Project.
        /// This field may not be populated, especially for newly provisioned projects after October 30, 2024._ The ID
        /// of the Project's ["location for default Google Cloud
        /// resources"](https://firebase.google.com/docs/projects/locations#default-cloud-location), which are resources
        /// associated with Google App Engine. The location is one of the available [App Engine
        /// locations](https://cloud.google.com/about/locations#region). This field is omitted if the location for
        /// default Google Cloud resources has not been set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// The unique Google-assigned identifier of the Google Analytics web stream associated with the `WebApp`.
        /// Firebase SDKs use this ID to interact with Google Analytics APIs. This field is only present if the `WebApp`
        /// is linked to a web stream in a Google Analytics App + Web property. Learn more about this ID and Google
        /// Analytics web streams in the [Analytics documentation](https://support.google.com/analytics/answer/9304153).
        /// To generate a `measurementId` and link the `WebApp` with a Google Analytics web stream, call
        /// [`AddGoogleAnalytics`](../../v1beta1/projects/addGoogleAnalytics). For apps using the Firebase JavaScript
        /// SDK v7.20.0 and later, Firebase dynamically fetches the `measurementId` when your app initializes Analytics.
        /// Having this ID in your config object is optional, but it does serve as a fallback in the rare case that the
        /// dynamic fetch fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementId")]
        public virtual string MeasurementId { get; set; }

        /// <summary>The sender ID for use with Firebase Cloud Messaging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messagingSenderId")]
        public virtual string MessagingSenderId { get; set; }

        /// <summary>Immutable. A user-assigned unique identifier for the `FirebaseProject`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Output only. Immutable. The globally unique, Google-assigned canonical identifier for the Project. Use this
        /// identifier when configuring integrations and/or making API calls to Google Cloud or third-party services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual string ProjectNumber { get; set; }

        /// <summary>
        /// Optional. Duplicate field for the URL of the default Realtime Database instances (if the default instance
        /// has been provisioned). If the request asks for the V2 config format, this field will be populated instead of
        /// `realtime_database_instance_uri`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realtimeDatabaseUrl")]
        public virtual string RealtimeDatabaseUrl { get; set; }

        /// <summary>
        /// **DEPRECATED.** _Instead, find the name of the default Cloud Storage for Firebase bucket using the [list
        /// endpoint](https://firebase.google.com/docs/reference/rest/storage/rest/v1beta/projects.buckets/list) within
        /// the Cloud Storage for Firebase REST API. If the default bucket for the Project has not yet been provisioned,
        /// the return might not contain a default bucket. Note that the config that's generated for the Firebase
        /// console or the Firebase CLI uses the Cloud Storage for Firebase endpoint to populate this value for that
        /// config._ The name of the default Cloud Storage for Firebase bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBucket")]
        public virtual string StorageBucket { get; set; }

        /// <summary>Version of the config specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
