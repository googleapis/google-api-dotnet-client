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

namespace Google.Apis.SQLAdmin.v1
{
    /// <summary>The SQLAdmin Service.</summary>
    public class SQLAdminService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SQLAdminService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SQLAdminService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Instances = new InstancesResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "sqladmin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://sqladmin.googleapis.com/";
        #else
            "https://sqladmin.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://sqladmin.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud SQL Admin API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google SQL Service instances</summary>
            public static string SqlserviceAdmin = "https://www.googleapis.com/auth/sqlservice.admin";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud SQL Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google SQL Service instances</summary>
            public const string SqlserviceAdmin = "https://www.googleapis.com/auth/sqlservice.admin";
        }

        /// <summary>Gets the Instances resource.</summary>
        public virtual InstancesResource Instances { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for SQLAdmin requests.</summary>
    public abstract class SQLAdminBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SQLAdminBaseServiceRequest instance.</summary>
        protected SQLAdminBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SQLAdmin parameter list.</summary>
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

        /// <summary>Lists instances under a given project.</summary>
        /// <param name="project">Project ID of the project for which to list Cloud SQL instances.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(service, project);
        }

        /// <summary>Lists instances under a given project.</summary>
        public class ListRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1.Data.InstancesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>Project ID of the project for which to list Cloud SQL instances.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// A filter expression that filters resources listed in the response. The expression is in the form of
            /// field:value. For example, 'instanceType:CLOUD_SQL_INSTANCE'. Fields can be nested as needed as per their
            /// JSON representation, such as 'settings.userLabels.auto_start:true'. Multiple filter queries are
            /// space-separated. For example. 'state:RUNNABLE instanceType:CLOUD_SQL_INSTANCE'. By default, each
            /// expression is an AND expression. However, you can include AND and OR expressions explicitly.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results to return per response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{project}/instances";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
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
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
                CreateEphemeral = new CreateEphemeralResource(service);
            }

            /// <summary>Gets the CreateEphemeral resource.</summary>
            public virtual CreateEphemeralResource CreateEphemeral { get; }

            /// <summary>The "createEphemeral" collection of methods.</summary>
            public class CreateEphemeralResource
            {
                private const string Resource = "createEphemeral";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CreateEphemeralResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Generates a short-lived X509 certificate containing the provided public key and signed by a private
                /// key specific to the target instance. Users may use the certificate to authenticate as themselves
                /// when connecting to the database.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="project">Project ID of the Cloud SQL project.</param>
                /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
                public virtual CreateRequest Create(Google.Apis.SQLAdmin.v1.Data.SslCertsCreateEphemeralRequest body, string project, string instance)
                {
                    return new CreateRequest(service, body, project, instance);
                }

                /// <summary>
                /// Generates a short-lived X509 certificate containing the provided public key and signed by a private
                /// key specific to the target instance. Users may use the certificate to authenticate as themselves
                /// when connecting to the database.
                /// </summary>
                public class CreateRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1.Data.SslCert>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1.Data.SslCertsCreateEphemeralRequest body, string project, string instance) : base(service)
                    {
                        Project = project;
                        Instance = instance;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Project ID of the Cloud SQL project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Project { get; private set; }

                    /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Instance { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SQLAdmin.v1.Data.SslCertsCreateEphemeralRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{project}/instances/{instance}/createEphemeral";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Generates a short-lived X509 certificate containing the provided public key and signed by a private key
            /// specific to the target instance. Users may use the certificate to authenticate as themselves when
            /// connecting to the database.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">Project ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual GenerateEphemeralCertRequest GenerateEphemeralCert(Google.Apis.SQLAdmin.v1.Data.GenerateEphemeralCertRequest body, string project, string instance)
            {
                return new GenerateEphemeralCertRequest(service, body, project, instance);
            }

            /// <summary>
            /// Generates a short-lived X509 certificate containing the provided public key and signed by a private key
            /// specific to the target instance. Users may use the certificate to authenticate as themselves when
            /// connecting to the database.
            /// </summary>
            public class GenerateEphemeralCertRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1.Data.GenerateEphemeralCertResponse>
            {
                /// <summary>Constructs a new GenerateEphemeralCert request.</summary>
                public GenerateEphemeralCertRequest(Google.Apis.Services.IClientService service, Google.Apis.SQLAdmin.v1.Data.GenerateEphemeralCertRequest body, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Project ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SQLAdmin.v1.Data.GenerateEphemeralCertRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generateEphemeralCert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{project}/instances/{instance}:generateEphemeralCert";

                /// <summary>Initializes GenerateEphemeralCert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a resource containing information about a Cloud SQL instance.</summary>
            /// <param name="project">Project ID of the project that contains the instance.</param>
            /// <param name="instance">Database instance ID. This does not include the project ID.</param>
            public virtual GetRequest Get(string project, string instance)
            {
                return new GetRequest(service, project, instance);
            }

            /// <summary>Retrieves a resource containing information about a Cloud SQL instance.</summary>
            public class GetRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1.Data.DatabaseInstance>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    InitParameters();
                }

                /// <summary>Project ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Database instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{project}/instances/{instance}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves connect settings about a Cloud SQL instance.</summary>
            /// <param name="project">Project ID of the project that contains the instance.</param>
            /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
            public virtual GetConnectSettingsRequest GetConnectSettings(string project, string instance)
            {
                return new GetConnectSettingsRequest(service, project, instance);
            }

            /// <summary>Retrieves connect settings about a Cloud SQL instance.</summary>
            public class GetConnectSettingsRequest : SQLAdminBaseServiceRequest<Google.Apis.SQLAdmin.v1.Data.ConnectSettings>
            {
                /// <summary>Constructs a new GetConnectSettings request.</summary>
                public GetConnectSettingsRequest(Google.Apis.Services.IClientService service, string project, string instance) : base(service)
                {
                    Project = project;
                    Instance = instance;
                    InitParameters();
                }

                /// <summary>Project ID of the project that contains the instance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Cloud SQL instance ID. This does not include the project ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Instance { get; private set; }

                /// <summary>Optional. Optional snapshot read timestamp to trade freshness for performance.</summary>
                [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getConnectSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{project}/instances/{instance}/connectSettings";

                /// <summary>Initializes GetConnectSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "instance",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTime",
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
namespace Google.Apis.SQLAdmin.v1.Data
{
    /// <summary>An entry for an Access Control list.</summary>
    public class AclEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when this access control entry expires in [RFC 3339](https://tools.ietf.org/html/rfc3339) format,
        /// for example **2012-11-15T16:19:00.094Z**.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual object ExpirationTime { get; set; }

        /// <summary>This is always **sql#aclEntry**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Optional. A label to identify this entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The allowlisted value for the access control list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Admin API warning message.</summary>
    public class ApiWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Code to uniquely identify the warning type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The warning message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The region name for REGION_UNREACHABLE warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance backup configuration.</summary>
    public class BackupConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Backup retention settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionSettings")]
        public virtual BackupRetentionSettings BackupRetentionSettings { get; set; }

        /// <summary>
        /// (MySQL only) Whether binary log is enabled. If backup configuration is disabled, binarylog must be disabled
        /// as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryLogEnabled")]
        public virtual System.Nullable<bool> BinaryLogEnabled { get; set; }

        /// <summary>Whether this configuration is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>This is always **sql#backupConfiguration**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Location of the backup</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>(Postgres only) Whether point in time recovery is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointInTimeRecoveryEnabled")]
        public virtual System.Nullable<bool> PointInTimeRecoveryEnabled { get; set; }

        /// <summary>Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationLogArchivingEnabled")]
        public virtual System.Nullable<bool> ReplicationLogArchivingEnabled { get; set; }

        /// <summary>
        /// Start time for the daily backup configuration in UTC timezone in the 24 hour format - **HH:MM**.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>The number of days of transaction logs we retain for point in time restore, from 1-7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionLogRetentionDays")]
        public virtual System.Nullable<int> TransactionLogRetentionDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// We currently only support backup retention by specifying the number of backups we will retain.
    /// </summary>
    public class BackupRetentionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Depending on the value of retention_unit, this is used to determine if a backup needs to be deleted. If
        /// retention_unit is 'COUNT', we will retain this many backups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainedBackups")]
        public virtual System.Nullable<int> RetainedBackups { get; set; }

        /// <summary>The unit that 'retained_backups' represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionUnit")]
        public virtual string RetentionUnit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Connect settings retrieval response.</summary>
    public class ConnectSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// **SECOND_GEN**: Cloud SQL database instance. **EXTERNAL**: A database server that is not managed by Google.
        /// This property is read-only; use the **tier** property in the **settings** object to determine the database
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendType")]
        public virtual string BackendType { get; set; }

        /// <summary>
        /// The database engine type and version. The **databaseVersion** field cannot be changed after instance
        /// creation. MySQL instances: **MYSQL_8_0**, **MYSQL_5_7** (default), or **MYSQL_5_6**. PostgreSQL instances:
        /// **POSTGRES_9_6**, **POSTGRES_10**, **POSTGRES_11** or **POSTGRES_12** (default). SQL Server instances:
        /// **SQLSERVER_2017_STANDARD** (default), **SQLSERVER_2017_ENTERPRISE**, **SQLSERVER_2017_EXPRESS**, or
        /// **SQLSERVER_2017_WEB**.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>The assigned IP addresses for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<IpMapping> IpAddresses { get; set; }

        /// <summary>This is always `sql#connectSettings`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>SSL configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaCert")]
        public virtual SslCert ServerCaCert { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database flags for Cloud SQL instances.</summary>
    public class DatabaseFlags : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the flag. These flags are passed at instance startup, so include both server options and system
        /// variables for MySQL. Flags are specified with underscores, not hyphens. For more information, see
        /// [Configuring Database Flags](/sql/docs/mysql/flags) in the Cloud SQL documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The value of the flag. Booleans are set to **on** for true and **off** for false. This field must be omitted
        /// if the flag doesn't take a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Cloud SQL instance resource.</summary>
    public class DatabaseInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        ///  *SECOND_GEN*: Cloud SQL database instance. *EXTERNAL*: A database server that is not managed by Google.
        /// This property is read-only; use the *tier* property in the *settings* object to determine the database type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendType")]
        public virtual string BackendType { get; set; }

        /// <summary>Connection name of the Cloud SQL instance used in connection strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionName")]
        public virtual string ConnectionName { get; set; }

        /// <summary>
        /// The current disk usage of the instance in bytes. This property has been deprecated. Use the
        /// "cloudsql.googleapis.com/database/disk/bytes_used" metric in Cloud Monitoring API instead. Please see this
        /// announcement for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentDiskSize")]
        public virtual System.Nullable<long> CurrentDiskSize { get; set; }

        /// <summary>
        /// The database engine type and version. The *databaseVersion* field cannot be changed after instance creation.
        /// MySQL instances: *MYSQL_8_0*, *MYSQL_5_7* (default), or *MYSQL_5_6*. PostgreSQL instances: *POSTGRES_9_6*,
        /// *POSTGRES_10*, *POSTGRES_11*, *POSTGRES_12*, or *POSTGRES_13* (default). SQL Server instances:
        /// *SQLSERVER_2017_STANDARD* (default), *SQLSERVER_2017_ENTERPRISE*, *SQLSERVER_2017_EXPRESS*, or
        /// *SQLSERVER_2017_WEB*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>
        /// Disk encryption configuration specific to an instance. Applies only to Second Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryptionConfiguration")]
        public virtual DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }

        /// <summary>
        /// Disk encryption status specific to an instance. Applies only to Second Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryptionStatus")]
        public virtual DiskEncryptionStatus DiskEncryptionStatus { get; set; }

        /// <summary>For internal usage only. The encrypted password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedRootPassword")]
        public virtual string EncryptedRootPassword { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed from a future version of the API. Use the
        /// *settings.settingsVersion* field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The name and status of the failover replica. This property is applicable only to Second Generation
        /// instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverReplica")]
        public virtual FailoverReplicaData FailoverReplica { get; set; }

        /// <summary>
        /// The Compute Engine zone that the instance is currently serving from. This value could be different from the
        /// zone that was specified when the instance was created if the instance has failed over to its secondary zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceZone")]
        public virtual string GceZone { get; set; }

        /// <summary>
        /// installed_version stores the current fully resolved database version including minor version such as
        /// MySQL_5.6.50
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedVersion")]
        public virtual string InstalledVersion { get; set; }

        /// <summary>
        /// The instance type. This can be one of the following. *CLOUD_SQL_INSTANCE*: A Cloud SQL instance that is not
        /// replicating from a primary instance. *ON_PREMISES_INSTANCE*: An instance running on the customer's premises.
        /// *READ_REPLICA_INSTANCE*: A Cloud SQL instance configured as a read-replica.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>Uid of the Cloud SQL instance. Used by Pantheon to check instance is created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceUid")]
        public virtual string InstanceUid { get; set; }

        /// <summary>The assigned IP addresses for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<IpMapping> IpAddresses { get; set; }

        /// <summary>
        /// The IPv6 address assigned to the instance. (Deprecated) This property was applicable only to First
        /// Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6Address")]
        public virtual string Ipv6Address { get; set; }

        /// <summary>This is always *sql#instance*.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The reference to the instance which will act as primary in the replication setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterInstance")]
        public virtual InstanceReference MasterInstance { get; set; }

        /// <summary>The name of the instance which will act as primary in the replication setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterInstanceName")]
        public virtual string MasterInstanceName { get; set; }

        /// <summary>The maximum disk size of the instance in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDiskSize")]
        public virtual System.Nullable<long> MaxDiskSize { get; set; }

        /// <summary>Name of the Cloud SQL instance. This does not include the project ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Configuration specific to on-premises instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onPremisesConfiguration")]
        public virtual OnPremisesConfiguration OnPremisesConfiguration { get; set; }

        /// <summary>
        /// This field represents the report generated by the proactive database wellness job for OutOfDisk issues.
        /// Writers: -- the proactive database wellness job for OOD. Readers: -- the Pantheon frontend -- the proactive
        /// database wellness job
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfDiskReport")]
        public virtual SqlOutOfDiskReport OutOfDiskReport { get; set; }

        /// <summary>
        /// The project ID of the project containing the Cloud SQL instance. The Google apps domain is prefixed if
        /// applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>
        /// The geographical region. Can be *us-central* (*FIRST_GEN* instances only) *us-central1* (*SECOND_GEN*
        /// instances only) *asia-east1* or *europe-west1*. Defaults to *us-central* or *us-central1* depending on the
        /// instance type. The region cannot be changed after instance creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Configuration specific to failover replicas and read replicas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaConfiguration")]
        public virtual ReplicaConfiguration ReplicaConfiguration { get; set; }

        /// <summary>The replicas of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaInstances")]
        public virtual System.Collections.Generic.IList<InstanceReference> ReplicaInstances { get; set; }

        /// <summary>The replicas of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaNames")]
        public virtual System.Collections.Generic.IList<string> ReplicaNames { get; set; }

        /// <summary>Initial root password. Use only on creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPassword")]
        public virtual string RootPassword { get; set; }

        /// <summary>The status indicating if instance satisfiesPzs. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>The start time of any upcoming scheduled maintenance for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledMaintenance")]
        public virtual SqlScheduledMaintenance ScheduledMaintenance { get; set; }

        /// <summary>
        /// The Compute Engine zone that the failover instance is currently serving from for a regional instance. This
        /// value could be different from the zone that was specified when the instance was created if the instance has
        /// failed over to its secondary/failover zone. Reserved for future use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryGceZone")]
        public virtual string SecondaryGceZone { get; set; }

        /// <summary>The URI of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>SSL configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCaCert")]
        public virtual SslCert ServerCaCert { get; set; }

        /// <summary>The service account email address assigned to the instance. This property is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmailAddress")]
        public virtual string ServiceAccountEmailAddress { get; set; }

        /// <summary>The user settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual Settings Settings { get; set; }

        /// <summary>
        /// The current serving state of the Cloud SQL instance. This can be one of the following.
        /// *SQL_INSTANCE_STATE_UNSPECIFIED*: The state of the instance is unknown. *RUNNABLE*: The instance is running,
        /// or has been stopped by owner. *SUSPENDED*: The instance is not available, for example due to problems with
        /// billing. *PENDING_DELETE*: The instance is being deleted. *PENDING_CREATE*: The instance is being created.
        /// *MAINTENANCE*: The instance is down for maintenance. *FAILED*: The instance creation failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>If the instance state is SUSPENDED, the reason for the suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReason")]
        public virtual System.Collections.Generic.IList<string> SuspensionReason { get; set; }

        /// <summary>
        /// The name and status of the failover replica. This property is applicable only to Second Generation
        /// instances.
        /// </summary>
        public class FailoverReplicaData
        {
            /// <summary>
            /// The availability status of the failover replica. A false status indicates that the failover replica is
            /// out of sync. The primary instance can only failover to the failover replica when the status is true.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("available")]
            public virtual System.Nullable<bool> Available { get; set; }

            /// <summary>
            /// A reference to the failover replica. If specified at instance creation, a failover replica is created
            /// for the instance. Currently, the failover replica can only be created in the same region as the primary
            /// instance.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("failoverInstance")]
            public virtual InstanceReference FailoverInstance { get; set; }

            /// <summary>
            /// The name of the failover replica. If specified at instance creation, a failover replica is created for
            /// the instance. The name doesn't include the project ID. This property is applicable only to Second
            /// Generation instances.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }
        }
    }

    /// <summary>
    /// Deny maintenance Periods. This specifies a date range during when all CSA rollout will be denied.
    /// </summary>
    public class DenyMaintenancePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// "deny maintenance period" end date. If the year of the end date is empty, the year of the start date also
        /// must be empty. In this case, it means the no maintenance interval recurs every year. The date is in format
        /// yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// "deny maintenance period" start date. If the year of the start date is empty, the year of the end date also
        /// must be empty. In this case, it means the no maintenance interval recurs every year. The date is in format
        /// yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>
        /// Time in UTC when the "deny maintenance period" starts on start_date and ends on end_date. The time is in
        /// format: HH:mm:SS, i.e., 00:00:00
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual string Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk encryption configuration for an instance.</summary>
    public class DiskEncryptionConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always **sql#diskEncryptionConfiguration**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Resource name of KMS key for disk encryption</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk encryption status for an instance.</summary>
    public class DiskEncryptionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always **sql#diskEncryptionStatus**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>KMS key version used to encrypt the Cloud SQL instance resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersionName")]
        public virtual string KmsKeyVersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ephemeral certificate creation request.</summary>
    public class GenerateEphemeralCertRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Access token to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
        public virtual string AccessToken { get; set; }

        /// <summary>PEM encoded public key to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("public_key")]
        public virtual string PublicKey { get; set; }

        /// <summary>Optional. Optional snapshot read timestamp to trade freshness for performance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ephemeral certificate creation request.</summary>
    public class GenerateEphemeralCertResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Generated cert</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralCert")]
        public virtual SslCert EphemeralCert { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Insights configuration. This specifies when Cloud SQL Insights feature is enabled and optional configuration.
    /// </summary>
    public class InsightsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Query Insights feature is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInsightsEnabled")]
        public virtual System.Nullable<bool> QueryInsightsEnabled { get; set; }

        /// <summary>
        /// Number of query plans generated by Insights per minute. Default is 5. Changing this will restart the
        /// database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryPlansPerMinute")]
        public virtual System.Nullable<int> QueryPlansPerMinute { get; set; }

        /// <summary>
        /// Maximum query length stored in bytes. Default value: 1024 bytes. Range: 256-4500 bytes. Query length more
        /// than this field value will be truncated to this value. When unset, query length will be the default value.
        /// Changing query length will restart the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryStringLength")]
        public virtual System.Nullable<int> QueryStringLength { get; set; }

        /// <summary>Whether Query Insights will record application tags from query when enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordApplicationTags")]
        public virtual System.Nullable<bool> RecordApplicationTags { get; set; }

        /// <summary>Whether Query Insights will record client address when enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordClientAddress")]
        public virtual System.Nullable<bool> RecordClientAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reference to another Cloud SQL instance.</summary>
    public class InstanceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Cloud SQL instance being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The region of the Cloud SQL instance being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instances list response.</summary>
    public class InstancesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of database instance resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<DatabaseInstance> Items { get; set; }

        /// <summary>This is always *sql#instancesList*.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of warnings that occurred while handling the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<ApiWarning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IP Management configuration.</summary>
    public class IpConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of external networks that are allowed to connect to the instance using the IP. In 'CIDR' notation,
        /// also known as 'slash' notation (for example: **192.168.100.0/24**).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedNetworks")]
        public virtual System.Collections.Generic.IList<AclEntry> AuthorizedNetworks { get; set; }

        /// <summary>Whether the instance is assigned a public IP address or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv4Enabled")]
        public virtual System.Nullable<bool> Ipv4Enabled { get; set; }

        /// <summary>
        /// The resource link for the VPC network from which the Cloud SQL instance is accessible for private IP. For
        /// example, **/projects/myProject/global/networks/default**. This setting can be updated, but it cannot be
        /// removed after it is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateNetwork")]
        public virtual string PrivateNetwork { get; set; }

        /// <summary>Whether SSL connections over IP are enforced or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireSsl")]
        public virtual System.Nullable<bool> RequireSsl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance IP Mapping.</summary>
    public class IpMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IP address assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// The due time for this IP to be retired in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for
        /// example **2012-11-15T16:19:00.094Z**. This field is only available when the IP is scheduled to be retired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeToRetire")]
        public virtual object TimeToRetire { get; set; }

        /// <summary>
        /// The type of this IP address. A **PRIMARY** address is a public address that can accept incoming connections.
        /// A **PRIVATE** address is a private address that can accept incoming connections. An **OUTGOING** address is
        /// the source address of connections originating from the instance, if supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Preferred location. This specifies where a Cloud SQL instance is located. Note that if the preferred location is
    /// not available, the instance will be located as close as possible within the region. Only one location may be
    /// specified.
    /// </summary>
    public class LocationPreference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is always **sql#locationPreference**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The preferred Compute Engine zone for the secondary/failover (for example: us-central1-a, us-central1-b,
        /// etc.). Reserved for future use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryZone")]
        public virtual string SecondaryZone { get; set; }

        /// <summary>The preferred Compute Engine zone (for example: us-central1-a, us-central1-b, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance window. This specifies when a Cloud SQL instance is restarted for system maintenance purposes.
    /// </summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>day of week (1-7), starting on Monday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>hour of day - 0 to 23.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>This is always **sql#maintenanceWindow**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Maintenance timing setting: **canary** (Earlier) or **stable** (Later). [Learn more]
        /// (https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/instance-settings#maintenance-timing-2ndgen).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTrack")]
        public virtual string UpdateTrack { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-replica configuration specific to MySQL databases.</summary>
    public class MySqlReplicaConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificate")]
        public virtual string CaCertificate { get; set; }

        /// <summary>PEM representation of the replica's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>
        /// PEM representation of the replica's private key. The corresponsing public key is encoded in the client's
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>Seconds to wait between connect retries. MySQL's default is 60 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectRetryInterval")]
        public virtual System.Nullable<int> ConnectRetryInterval { get; set; }

        /// <summary>
        /// Path to a SQL dump file in Google Cloud Storage from which the replica instance is to be created. The URI is
        /// in the form gs://bucketName/fileName. Compressed gzip files (.gz) are also supported. Dumps have the binlog
        /// co-ordinates from which replication begins. This can be accomplished by setting --master-data to 1 when
        /// using mysqldump.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpFilePath")]
        public virtual string DumpFilePath { get; set; }

        /// <summary>This is always **sql#mysqlReplicaConfiguration**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Interval in milliseconds between replication heartbeats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterHeartbeatPeriod")]
        public virtual System.Nullable<long> MasterHeartbeatPeriod { get; set; }

        /// <summary>The password for the replication connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>A list of permissible ciphers to use for SSL encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCipher")]
        public virtual string SslCipher { get; set; }

        /// <summary>The username for the replication connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>
        /// Whether or not to check the primary instance's Common Name value in the certificate that it sends during the
        /// SSL handshake.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyServerCertificate")]
        public virtual System.Nullable<bool> VerifyServerCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>On-premises instance configuration.</summary>
    public class OnPremisesConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificate")]
        public virtual string CaCertificate { get; set; }

        /// <summary>PEM representation of the replica's x509 certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>
        /// PEM representation of the replica's private key. The corresponsing public key is encoded in the client's
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>The dump file to create the Cloud SQL replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpFilePath")]
        public virtual string DumpFilePath { get; set; }

        /// <summary>The host and port of the on-premises instance in host:port format</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostPort")]
        public virtual string HostPort { get; set; }

        /// <summary>This is always *sql#onPremisesConfiguration*.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The password for connecting to on-premises instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The username for connecting to on-premises instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Read-replica configuration for connecting to the primary instance.</summary>
    public class ReplicaConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies if the replica is the failover target. If the field is set to *true* the replica will be
        /// designated as a failover replica. In case the primary instance fails, the replica instance will be promoted
        /// as the new primary instance. Only one replica can be specified as failover target, and the replica has to be
        /// in different zone with the primary instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverTarget")]
        public virtual System.Nullable<bool> FailoverTarget { get; set; }

        /// <summary>This is always *sql#replicaConfiguration*.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// MySQL specific configuration when replicating from a MySQL on-premises primary instance. Replication
        /// configuration information such as the username, password, certificates, and keys are not stored in the
        /// instance metadata.The configuration information is used only to set up the replication connection and is
        /// stored by MySQL in a file named *master.info* in the data directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlReplicaConfiguration")]
        public virtual MySqlReplicaConfiguration MysqlReplicaConfiguration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database instance settings.</summary>
    public class Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The activation policy specifies when the instance is activated; it is applicable only when the instance
        /// state is RUNNABLE. Valid values: **ALWAYS**: The instance is on, and remains so even in the absence of
        /// connection requests. **NEVER**: The instance is off; it is not activated, even if a connection request
        /// arrives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationPolicy")]
        public virtual string ActivationPolicy { get; set; }

        /// <summary>Active Directory configuration, relevant only for Cloud SQL for SQL Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDirectoryConfig")]
        public virtual SqlActiveDirectoryConfig ActiveDirectoryConfig { get; set; }

        /// <summary>
        /// Availability type. Potential values: **ZONAL**: The instance serves data from only one zone. Outages in that
        /// zone affect data accessibility. **REGIONAL**: The instance can serve data from more than one zone in a
        /// region (it is highly available). For more information, see [Overview of the High Availability
        /// Configuration](/sql/docs/postgres/high-availability).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityType")]
        public virtual string AvailabilityType { get; set; }

        /// <summary>The daily backup configuration for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupConfiguration")]
        public virtual BackupConfiguration BackupConfiguration { get; set; }

        /// <summary>The name of server Instance collation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>
        /// Configuration specific to read replica instances. Indicates whether database flags for crash-safe
        /// replication are enabled. This property was only applicable to First Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashSafeReplicationEnabled")]
        public virtual System.Nullable<bool> CrashSafeReplicationEnabled { get; set; }

        /// <summary>The size of data disk, in GB. The data disk size minimum is 10GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskSizeGb")]
        public virtual System.Nullable<long> DataDiskSizeGb { get; set; }

        /// <summary>The type of data disk: **PD_SSD** (default) or **PD_HDD**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskType")]
        public virtual string DataDiskType { get; set; }

        /// <summary>The database flags passed to the instance at startup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseFlags")]
        public virtual System.Collections.Generic.IList<DatabaseFlags> DatabaseFlags { get; set; }

        /// <summary>
        /// Configuration specific to read replica instances. Indicates whether replication is enabled or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseReplicationEnabled")]
        public virtual System.Nullable<bool> DatabaseReplicationEnabled { get; set; }

        /// <summary>Deny maintenance periods</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyMaintenancePeriods")]
        public virtual System.Collections.Generic.IList<DenyMaintenancePeriod> DenyMaintenancePeriods { get; set; }

        /// <summary>Insights configuration, for now relevant only for Postgres.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insightsConfig")]
        public virtual InsightsConfig InsightsConfig { get; set; }

        /// <summary>
        /// The settings for IP Management. This allows to enable or disable the instance IP and manage which external
        /// networks can connect to the instance. The IPv4 address cannot be disabled for Second Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipConfiguration")]
        public virtual IpConfiguration IpConfiguration { get; set; }

        /// <summary>This is always **sql#settings**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The location preference settings. This allows the instance to be located as near as possible to Compute
        /// Engine zone for better performance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationPreference")]
        public virtual LocationPreference LocationPreference { get; set; }

        /// <summary>
        /// The maintenance window for this instance. This specifies when the instance can be restarted for maintenance
        /// purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// The pricing plan for this instance. This can be either **PER_USE** or **PACKAGE**. Only **PER_USE** is
        /// supported for Second Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pricingPlan")]
        public virtual string PricingPlan { get; set; }

        /// <summary>
        /// The type of replication this instance uses. This can be either **ASYNCHRONOUS** or **SYNCHRONOUS**.
        /// (Deprecated) This property was only applicable to First Generation instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationType")]
        public virtual string ReplicationType { get; set; }

        /// <summary>
        /// The version of instance settings. This is a required field for update method to make sure concurrent updates
        /// are handled properly. During update, use the most recent settingsVersion value for this instance and do not
        /// try to update this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settingsVersion")]
        public virtual System.Nullable<long> SettingsVersion { get; set; }

        /// <summary>Configuration to increase storage size automatically. The default value is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageAutoResize")]
        public virtual System.Nullable<bool> StorageAutoResize { get; set; }

        /// <summary>
        /// The maximum size to which storage capacity can be automatically increased. The default value is 0, which
        /// specifies that there is no limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageAutoResizeLimit")]
        public virtual System.Nullable<long> StorageAutoResizeLimit { get; set; }

        /// <summary>The tier (or machine type) for this instance, for example **db-custom-1-3840**.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>
        /// User-provided labels, represented as a dictionary where each label is a single key value pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Active Directory configuration, relevant only for Cloud SQL for SQL Server.</summary>
    public class SqlActiveDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the domain (e.g., mydomain.com).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>This is always sql#activeDirectoryConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message wraps up the information written by out-of-disk detection job.</summary>
    public class SqlOutOfDiskReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum recommended increase size in GigaBytes This field is consumed by the frontend Writers: -- the
        /// proactive database wellness job for OOD. Readers: -- the Pantheon frontend
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlMinRecommendedIncreaseSizeGb")]
        public virtual System.Nullable<int> SqlMinRecommendedIncreaseSizeGb { get; set; }

        /// <summary>
        /// This field represents the state generated by the proactive database wellness job for OutOfDisk issues.
        /// Writers: -- the proactive database wellness job for OOD. Readers: -- the Pantheon frontend -- the proactive
        /// database wellness job
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlOutOfDiskState")]
        public virtual string SqlOutOfDiskState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Any scheduled maintenancce for this instance.</summary>
    public class SqlScheduledMaintenance : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("canDefer")]
        public virtual System.Nullable<bool> CanDefer { get; set; }

        /// <summary>If the scheduled maintenance can be rescheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReschedule")]
        public virtual System.Nullable<bool> CanReschedule { get; set; }

        /// <summary>Maintenance cannot be rescheduled to start beyond this deadline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleDeadlineTime")]
        public virtual object ScheduleDeadlineTime { get; set; }

        /// <summary>The start time of any upcoming scheduled maintenance for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCerts Resource</summary>
    public class SslCert : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cert")]
        public virtual string Cert { get; set; }

        /// <summary>Serial number, as extracted from the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certSerialNumber")]
        public virtual string CertSerialNumber { get; set; }

        /// <summary>User supplied name. Constrained to [a-zA-Z.-_ ]+.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonName")]
        public virtual string CommonName { get; set; }

        /// <summary>
        /// The time when the certificate was created in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for
        /// example **2012-11-15T16:19:00.094Z**
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The time when the certificate expires in [RFC 3339](https://tools.ietf.org/html/rfc3339) format, for example
        /// **2012-11-15T16:19:00.094Z**.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual object ExpirationTime { get; set; }

        /// <summary>Name of the database instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>This is always sql#sslCert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Sha1 Fingerprint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Fingerprint")]
        public virtual string Sha1Fingerprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SslCerts create ephemeral certificate request.</summary>
    public class SslCertsCreateEphemeralRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access token to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
        public virtual string AccessToken { get; set; }

        /// <summary>PEM encoded public key to include in the signed certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("public_key")]
        public virtual string PublicKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
