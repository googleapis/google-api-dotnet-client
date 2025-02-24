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

namespace Google.Apis.DatabaseMigrationService.v1
{
    /// <summary>The DatabaseMigrationService Service.</summary>
    public class DatabaseMigrationServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DatabaseMigrationServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DatabaseMigrationServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://datamigration.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://datamigration.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datamigration";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Database Migration API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Database Migration API.</summary>
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

    /// <summary>A base abstract class for DatabaseMigrationService requests.</summary>
    public abstract class DatabaseMigrationServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DatabaseMigrationServiceBaseServiceRequest instance.</summary>
        protected DatabaseMigrationServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DatabaseMigrationService parameter list.</summary>
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
                ConnectionProfiles = new ConnectionProfilesResource(service);
                ConversionWorkspaces = new ConversionWorkspacesResource(service);
                MigrationJobs = new MigrationJobsResource(service);
                Operations = new OperationsResource(service);
                PrivateConnections = new PrivateConnectionsResource(service);
            }

            /// <summary>Gets the ConnectionProfiles resource.</summary>
            public virtual ConnectionProfilesResource ConnectionProfiles { get; }

            /// <summary>The "connectionProfiles" collection of methods.</summary>
            public class ConnectionProfilesResource
            {
                private const string Resource = "connectionProfiles";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConnectionProfilesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new connection profile in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent which owns this collection of connection profiles.</param>
                public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new connection profile in a given project and location.</summary>
                public class CreateRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent which owns this collection of connection profiles.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The connection profile identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectionProfileId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectionProfileId { get; set; }

                    /// <summary>
                    /// Optional. A unique ID used to identify the request. If the server receives two requests with the
                    /// same ID, then the second request is ignored. It is recommended to always set this value to a
                    /// UUID. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens
                    /// (-). The maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Create the connection profile without validating it. The default is false. Only
                    /// supported for Oracle connection profiles.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("skipValidation", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> SkipValidation { get; set; }

                    /// <summary>
                    /// Optional. Only validate the connection profile, but don't create any resources. The default is
                    /// false. Only supported for Oracle connection profiles.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connectionProfiles";

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
                        RequestParameters.Add("connectionProfileId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectionProfileId",
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
                        RequestParameters.Add("skipValidation", new Google.Apis.Discovery.Parameter
                        {
                            Name = "skipValidation",
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
                /// Deletes a single Database Migration Service connection profile. A connection profile can only be
                /// deleted if it is not in use by any active migration jobs.
                /// </summary>
                /// <param name="name">Required. Name of the connection profile resource to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a single Database Migration Service connection profile. A connection profile can only be
                /// deleted if it is not in use by any active migration jobs.
                /// </summary>
                public class DeleteRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the connection profile resource to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// In case of force delete, the CloudSQL replica database is also deleted (only for CloudSQL
                    /// connection profile).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// A unique ID used to identify the request. If the server receives two requests with the same ID,
                    /// then the second request is ignored. It is recommended to always set this value to a UUID. The ID
                    /// must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The
                    /// maximum length is 40 characters.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
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
                    }
                }

                /// <summary>Gets details of a single connection profile.</summary>
                /// <param name="name">Required. Name of the connection profile resource to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single connection profile.</summary>
                public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the connection profile resource to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
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
                public class GetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
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

                /// <summary>Retrieves a list of all connection profiles in a given project and location.</summary>
                /// <param name="parent">Required. The parent which owns this collection of connection profiles.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieves a list of all connection profiles in a given project and location.</summary>
                public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListConnectionProfilesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent which owns this collection of connection profiles.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that filters connection profiles listed in the response. The expression must
                    /// specify the field name, a comparison operator, and the value that you want to use for filtering.
                    /// The value must be a string, a number, or a boolean. The comparison operator must be either =,
                    /// !=, &amp;gt;, or &amp;lt;. For example, list connection profiles created this year by specifying
                    /// **createTime %gt; 2020-01-01T00:00:00.000000000Z**. You can also filter nested fields. For
                    /// example, you could specify **mySql.username = %lt;my_username%gt;** to list all connection
                    /// profiles configured to connect with a specific username.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>A comma-separated list of fields to order results according to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of connection profiles to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 connection profiles will be returned. The maximum value is
                    /// 1000; values above 1000 are coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListConnectionProfiles` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListConnectionProfiles`
                    /// must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connectionProfiles";

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

                /// <summary>Update the configuration of a single connection profile.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of this connection profile resource in the form of
                /// projects/{project}/locations/{location}/connectionProfiles/{connectionProfile}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update the configuration of a single connection profile.</summary>
                public class PatchRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of this connection profile resource in the form of
                    /// projects/{project}/locations/{location}/connectionProfiles/{connectionProfile}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A unique ID used to identify the request. If the server receives two requests with the
                    /// same ID, then the second request is ignored. It is recommended to always set this value to a
                    /// UUID. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens
                    /// (-). The maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Update the connection profile without validating it. The default is false. Only
                    /// supported for Oracle connection profiles.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("skipValidation", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> SkipValidation { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                    /// conversion workspace resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. Only validate the connection profile, but don't update any resources. The default is
                    /// false. Only supported for Oracle connection profiles.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("skipValidation", new Google.Apis.Discovery.Parameter
                        {
                            Name = "skipValidation",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connectionProfiles/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the ConversionWorkspaces resource.</summary>
            public virtual ConversionWorkspacesResource ConversionWorkspaces { get; }

            /// <summary>The "conversionWorkspaces" collection of methods.</summary>
            public class ConversionWorkspacesResource
            {
                private const string Resource = "conversionWorkspaces";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConversionWorkspacesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    MappingRules = new MappingRulesResource(service);
                }

                /// <summary>Gets the MappingRules resource.</summary>
                public virtual MappingRulesResource MappingRules { get; }

                /// <summary>The "mappingRules" collection of methods.</summary>
                public class MappingRulesResource
                {
                    private const string Resource = "mappingRules";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MappingRulesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new mapping rule for a given conversion workspace.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The parent which owns this collection of mapping rules.</param>
                    public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.MappingRule body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new mapping rule for a given conversion workspace.</summary>
                    public class CreateRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.MappingRule>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.MappingRule body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent which owns this collection of mapping rules.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The ID of the rule to create.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("mappingRuleId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string MappingRuleId { get; set; }

                        /// <summary>
                        /// A unique ID used to identify the request. If the server receives two requests with the same
                        /// ID, then the second request is ignored. It is recommended to always set this value to a
                        /// UUID. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and
                        /// hyphens (-). The maximum length is 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DatabaseMigrationService.v1.Data.MappingRule Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/mappingRules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                            });
                            RequestParameters.Add("mappingRuleId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "mappingRuleId",
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

                    /// <summary>Deletes a single mapping rule.</summary>
                    /// <param name="name">Required. Name of the mapping rule resource to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single mapping rule.</summary>
                    public class DeleteRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the mapping rule resource to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A unique ID used to identify the request. If the server receives two requests with
                        /// the same ID, then the second request is ignored. It is recommended to always set this value
                        /// to a UUID. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and
                        /// hyphens (-). The maximum length is 40 characters.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+/mappingRules/[^/]+$",
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

                    /// <summary>Gets the details of a mapping rule.</summary>
                    /// <param name="name">
                    /// Required. Name of the mapping rule resource to get. Example:
                    /// conversionWorkspaces/123/mappingRules/rule123 In order to retrieve a previous revision of the
                    /// mapping rule, also provide the revision ID. Example:
                    /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the details of a mapping rule.</summary>
                    public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.MappingRule>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the mapping rule resource to get. Example:
                        /// conversionWorkspaces/123/mappingRules/rule123 In order to retrieve a previous revision of
                        /// the mapping rule, also provide the revision ID. Example:
                        /// conversionWorkspace/123/mappingRules/rule123@c7cfa2a8c7cfa2a8c7cfa2a8c7cfa2a8
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+/mappingRules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Imports the mapping rules for a given conversion workspace. Supports various formats of external
                    /// rules files.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Name of the conversion workspace resource to import the rules to in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.DatabaseMigrationService.v1.Data.ImportMappingRulesRequest body, string parent)
                    {
                        return new ImportRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Imports the mapping rules for a given conversion workspace. Supports various formats of external
                    /// rules files.
                    /// </summary>
                    public class ImportRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ImportMappingRulesRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the conversion workspace resource to import the rules to in the form of:
                        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DatabaseMigrationService.v1.Data.ImportMappingRulesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/mappingRules:import";

                        /// <summary>Initializes Import parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the mapping rules for a specific conversion workspace.</summary>
                    /// <param name="parent">
                    /// Required. Name of the conversion workspace resource whose mapping rules are listed in the form
                    /// of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the mapping rules for a specific conversion workspace.</summary>
                    public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListMappingRulesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the conversion workspace resource whose mapping rules are listed in the
                        /// form of:
                        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of rules to return. The service may return fewer than this value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The nextPageToken value received in the previous call to mappingRules.list, used in the
                        /// subsequent request to retrieve the next page of results. On first call this should be left
                        /// blank. When paginating, all other parameters provided to mappingRules.list must match the
                        /// call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/mappingRules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
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

                /// <summary>Applies draft tree onto a specific destination database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the conversion workspace resource for which to apply the draft tree. Must be
                /// in the form of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual ApplyRequest Apply(Google.Apis.DatabaseMigrationService.v1.Data.ApplyConversionWorkspaceRequest body, string name)
                {
                    return new ApplyRequest(this.service, body, name);
                }

                /// <summary>Applies draft tree onto a specific destination database.</summary>
                public class ApplyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Apply request.</summary>
                    public ApplyRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ApplyConversionWorkspaceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the conversion workspace resource for which to apply the draft tree. Must
                    /// be in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.ApplyConversionWorkspaceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "apply";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:apply";

                    /// <summary>Initializes Apply parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                    }
                }

                /// <summary>Marks all the data in the conversion workspace as committed.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the conversion workspace resource to commit.</param>
                public virtual CommitRequest Commit(Google.Apis.DatabaseMigrationService.v1.Data.CommitConversionWorkspaceRequest body, string name)
                {
                    return new CommitRequest(this.service, body, name);
                }

                /// <summary>Marks all the data in the conversion workspace as committed.</summary>
                public class CommitRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Commit request.</summary>
                    public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.CommitConversionWorkspaceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the conversion workspace resource to commit.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.CommitConversionWorkspaceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "commit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:commit";

                    /// <summary>Initializes Commit parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a draft tree schema for the destination database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Name of the conversion workspace resource to convert in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual ConvertRequest Convert(Google.Apis.DatabaseMigrationService.v1.Data.ConvertConversionWorkspaceRequest body, string name)
                {
                    return new ConvertRequest(this.service, body, name);
                }

                /// <summary>Creates a draft tree schema for the destination database.</summary>
                public class ConvertRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Convert request.</summary>
                    public ConvertRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ConvertConversionWorkspaceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the conversion workspace resource to convert in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.ConvertConversionWorkspaceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "convert";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:convert";

                    /// <summary>Initializes Convert parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a new conversion workspace in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent which owns this collection of conversion workspaces.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new conversion workspace in a given project and location.</summary>
                public class CreateRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent which owns this collection of conversion workspaces.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID of the conversion workspace to create.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspaceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConversionWorkspaceId { get; set; }

                    /// <summary>
                    /// A unique ID used to identify the request. If the server receives two requests with the same ID,
                    /// then the second request is ignored. It is recommended to always set this value to a UUID. The ID
                    /// must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The
                    /// maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/conversionWorkspaces";

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
                        RequestParameters.Add("conversionWorkspaceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "conversionWorkspaceId",
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

                /// <summary>Deletes a single conversion workspace.</summary>
                /// <param name="name">Required. Name of the conversion workspace resource to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single conversion workspace.</summary>
                public class DeleteRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the conversion workspace resource to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Force delete the conversion workspace, even if there's a running migration that is using the
                    /// workspace.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// A unique ID used to identify the request. If the server receives two requests with the same ID,
                    /// then the second request is ignored. It is recommended to always set this value to a UUID. The ID
                    /// must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The
                    /// maximum length is 40 characters.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
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
                    }
                }

                /// <summary>Retrieves a list of committed revisions of a specific conversion workspace.</summary>
                /// <param name="conversionWorkspace">
                /// Required. Name of the conversion workspace resource whose revisions are listed. Must be in the form
                /// of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual DescribeConversionWorkspaceRevisionsRequest DescribeConversionWorkspaceRevisions(string conversionWorkspace)
                {
                    return new DescribeConversionWorkspaceRevisionsRequest(this.service, conversionWorkspace);
                }

                /// <summary>Retrieves a list of committed revisions of a specific conversion workspace.</summary>
                public class DescribeConversionWorkspaceRevisionsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.DescribeConversionWorkspaceRevisionsResponse>
                {
                    /// <summary>Constructs a new DescribeConversionWorkspaceRevisions request.</summary>
                    public DescribeConversionWorkspaceRevisionsRequest(Google.Apis.Services.IClientService service, string conversionWorkspace) : base(service)
                    {
                        ConversionWorkspace = conversionWorkspace;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the conversion workspace resource whose revisions are listed. Must be in the
                    /// form of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspace", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ConversionWorkspace { get; private set; }

                    /// <summary>Optional. Optional filter to request a specific commit ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("commitId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CommitId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "describeConversionWorkspaceRevisions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+conversionWorkspace}:describeConversionWorkspaceRevisions";

                    /// <summary>Initializes DescribeConversionWorkspaceRevisions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("conversionWorkspace", new Google.Apis.Discovery.Parameter
                        {
                            Name = "conversionWorkspace",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                        RequestParameters.Add("commitId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "commitId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Describes the database entities tree for a specific conversion workspace and a specific tree type.
                /// Database entities are not resources like conversion workspaces or mapping rules, and they can't be
                /// created, updated or deleted. Instead, they are simple data objects describing the structure of the
                /// client database.
                /// </summary>
                /// <param name="conversionWorkspace">
                /// Required. Name of the conversion workspace resource whose database entities are described. Must be
                /// in the form of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual DescribeDatabaseEntitiesRequest DescribeDatabaseEntities(string conversionWorkspace)
                {
                    return new DescribeDatabaseEntitiesRequest(this.service, conversionWorkspace);
                }

                /// <summary>
                /// Describes the database entities tree for a specific conversion workspace and a specific tree type.
                /// Database entities are not resources like conversion workspaces or mapping rules, and they can't be
                /// created, updated or deleted. Instead, they are simple data objects describing the structure of the
                /// client database.
                /// </summary>
                public class DescribeDatabaseEntitiesRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.DescribeDatabaseEntitiesResponse>
                {
                    /// <summary>Constructs a new DescribeDatabaseEntities request.</summary>
                    public DescribeDatabaseEntitiesRequest(Google.Apis.Services.IClientService service, string conversionWorkspace) : base(service)
                    {
                        ConversionWorkspace = conversionWorkspace;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the conversion workspace resource whose database entities are described. Must
                    /// be in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspace", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ConversionWorkspace { get; private set; }

                    /// <summary>
                    /// Optional. Request a specific commit ID. If not specified, the entities from the latest commit
                    /// are returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("commitId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CommitId { get; set; }

                    /// <summary>Optional. Filter the returned entities based on AIP-160 standard.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of entities to return. The service may return fewer entities than
                    /// the value specifies.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The nextPageToken value received in the previous call to
                    /// conversionWorkspace.describeDatabaseEntities, used in the subsequent request to retrieve the
                    /// next page of results. On first call this should be left blank. When paginating, all other
                    /// parameters provided to conversionWorkspace.describeDatabaseEntities must match the call that
                    /// provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Required. The tree to fetch.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tree", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TreeEnum> Tree { get; set; }

                    /// <summary>Required. The tree to fetch.</summary>
                    public enum TreeEnum
                    {
                        /// <summary>Unspecified tree type.</summary>
                        [Google.Apis.Util.StringValueAttribute("DB_TREE_TYPE_UNSPECIFIED")]
                        DBTREETYPEUNSPECIFIED = 0,

                        /// <summary>The source database tree.</summary>
                        [Google.Apis.Util.StringValueAttribute("SOURCE_TREE")]
                        SOURCETREE = 1,

                        /// <summary>The draft database tree.</summary>
                        [Google.Apis.Util.StringValueAttribute("DRAFT_TREE")]
                        DRAFTTREE = 2,

                        /// <summary>The destination database tree.</summary>
                        [Google.Apis.Util.StringValueAttribute("DESTINATION_TREE")]
                        DESTINATIONTREE = 3,
                    }

                    /// <summary>
                    /// Optional. Whether to retrieve the latest committed version of the entities or the latest
                    /// version. This field is ignored if a specific commit_id is specified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("uncommitted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Uncommitted { get; set; }

                    /// <summary>Optional. Results view based on AIP-157</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>Optional. Results view based on AIP-157</summary>
                    public enum ViewEnum
                    {
                        /// <summary>Unspecified view. Defaults to basic view.</summary>
                        [Google.Apis.Util.StringValueAttribute("DATABASE_ENTITY_VIEW_UNSPECIFIED")]
                        DATABASEENTITYVIEWUNSPECIFIED = 0,

                        /// <summary>Default view. Does not return DDLs or Issues.</summary>
                        [Google.Apis.Util.StringValueAttribute("DATABASE_ENTITY_VIEW_BASIC")]
                        DATABASEENTITYVIEWBASIC = 1,

                        /// <summary>Return full entity details including mappings, ddl and issues.</summary>
                        [Google.Apis.Util.StringValueAttribute("DATABASE_ENTITY_VIEW_FULL")]
                        DATABASEENTITYVIEWFULL = 2,

                        /// <summary>
                        /// Top-most (Database, Schema) nodes which are returned contains summary details for their
                        /// descendants such as the number of entities per type and issues rollups. When this view is
                        /// used, only a single page of result is returned and the page_size property of the request is
                        /// ignored. The returned page will only include the top-most node types.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("DATABASE_ENTITY_VIEW_ROOT_SUMMARY")]
                        DATABASEENTITYVIEWROOTSUMMARY = 3,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "describeDatabaseEntities";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+conversionWorkspace}:describeDatabaseEntities";

                    /// <summary>Initializes DescribeDatabaseEntities parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("conversionWorkspace", new Google.Apis.Discovery.Parameter
                        {
                            Name = "conversionWorkspace",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                        RequestParameters.Add("commitId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "commitId",
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
                        RequestParameters.Add("tree", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tree",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("uncommitted", new Google.Apis.Discovery.Parameter
                        {
                            Name = "uncommitted",
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

                /// <summary>Gets details of a single conversion workspace.</summary>
                /// <param name="name">Required. Name of the conversion workspace resource to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single conversion workspace.</summary>
                public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the conversion workspace resource to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
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
                public class GetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
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

                /// <summary>Lists conversion workspaces in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent which owns this collection of conversion workspaces.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists conversion workspaces in a given project and location.</summary>
                public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListConversionWorkspacesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent which owns this collection of conversion workspaces.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that filters conversion workspaces listed in the response. The expression
                    /// must specify the field name, a comparison operator, and the value that you want to use for
                    /// filtering. The value must be a string, a number, or a boolean. The comparison operator must be
                    /// either =, !=, &amp;gt;, or &amp;lt;. For example, list conversion workspaces created this year
                    /// by specifying **createTime %gt; 2020-01-01T00:00:00.000000000Z.** You can also filter nested
                    /// fields. For example, you could specify **source.version = "12.c.1"** to select all conversion
                    /// workspaces with source database version equal to 12.c.1.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of conversion workspaces to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 sets are returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The nextPageToken value received in the previous call to conversionWorkspaces.list, used in the
                    /// subsequent request to retrieve the next page of results. On first call this should be left
                    /// blank. When paginating, all other parameters provided to conversionWorkspaces.list must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/conversionWorkspaces";

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

                /// <summary>Updates the parameters of a single conversion workspace.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Full name of the workspace resource, in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single conversion workspace.</summary>
                public class PatchRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Full name of the workspace resource, in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A unique ID used to identify the request. If the server receives two requests with the same ID,
                    /// then the second request is ignored. It is recommended to always set this value to a UUID. The ID
                    /// must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The
                    /// maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                    /// conversion workspace resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
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

                /// <summary>Rolls back a conversion workspace to the last committed snapshot.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the conversion workspace resource to roll back to.</param>
                public virtual RollbackRequest Rollback(Google.Apis.DatabaseMigrationService.v1.Data.RollbackConversionWorkspaceRequest body, string name)
                {
                    return new RollbackRequest(this.service, body, name);
                }

                /// <summary>Rolls back a conversion workspace to the last committed snapshot.</summary>
                public class RollbackRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Rollback request.</summary>
                    public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.RollbackConversionWorkspaceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the conversion workspace resource to roll back to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.RollbackConversionWorkspaceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rollback";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:rollback";

                    /// <summary>Initializes Rollback parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Searches/lists the background jobs for a specific conversion workspace. The background jobs are not
                /// resources like conversion workspaces or mapping rules, and they can't be created, updated or
                /// deleted. Instead, they are a way to expose the data plane jobs log.
                /// </summary>
                /// <param name="conversionWorkspace">
                /// Required. Name of the conversion workspace resource whose jobs are listed, in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual SearchBackgroundJobsRequest SearchBackgroundJobs(string conversionWorkspace)
                {
                    return new SearchBackgroundJobsRequest(this.service, conversionWorkspace);
                }

                /// <summary>
                /// Searches/lists the background jobs for a specific conversion workspace. The background jobs are not
                /// resources like conversion workspaces or mapping rules, and they can't be created, updated or
                /// deleted. Instead, they are a way to expose the data plane jobs log.
                /// </summary>
                public class SearchBackgroundJobsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.SearchBackgroundJobsResponse>
                {
                    /// <summary>Constructs a new SearchBackgroundJobs request.</summary>
                    public SearchBackgroundJobsRequest(Google.Apis.Services.IClientService service, string conversionWorkspace) : base(service)
                    {
                        ConversionWorkspace = conversionWorkspace;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the conversion workspace resource whose jobs are listed, in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspace", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ConversionWorkspace { get; private set; }

                    private object _completedUntilTime;

                    /// <summary>
                    /// String representation of <see cref="CompletedUntilTimeDateTimeOffset"/>, formatted for inclusion
                    /// in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("completedUntilTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CompletedUntilTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="CompletedUntilTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletedUntilTimeDateTimeOffset instead.")]
                    public virtual object CompletedUntilTime
                    {
                        get => _completedUntilTime;
                        set
                        {
                            CompletedUntilTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _completedUntilTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? CompletedUntilTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletedUntilTimeRaw);
                        set
                        {
                            CompletedUntilTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _completedUntilTime = value;
                        }
                    }

                    /// <summary>
                    /// Optional. The maximum number of jobs to return. The service may return fewer than this value. If
                    /// unspecified, at most 100 jobs are returned. The maximum value is 100; values above 100 are
                    /// coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("maxSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> MaxSize { get; set; }

                    /// <summary>Optional. Whether or not to return just the most recent job per job type,</summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnMostRecentPerJobType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnMostRecentPerJobType { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "searchBackgroundJobs";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+conversionWorkspace}:searchBackgroundJobs";

                    /// <summary>Initializes SearchBackgroundJobs parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("conversionWorkspace", new Google.Apis.Discovery.Parameter
                        {
                            Name = "conversionWorkspace",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                        RequestParameters.Add("completedUntilTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "completedUntilTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("maxSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "maxSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("returnMostRecentPerJobType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnMostRecentPerJobType",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Imports a snapshot of the source database into the conversion workspace.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Name of the conversion workspace resource to seed with new database structure, in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual SeedRequest Seed(Google.Apis.DatabaseMigrationService.v1.Data.SeedConversionWorkspaceRequest body, string name)
                {
                    return new SeedRequest(this.service, body, name);
                }

                /// <summary>Imports a snapshot of the source database into the conversion workspace.</summary>
                public class SeedRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Seed request.</summary>
                    public SeedRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.SeedConversionWorkspaceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the conversion workspace resource to seed with new database structure, in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.SeedConversionWorkspaceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "seed";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:seed";

                    /// <summary>Initializes Seed parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/conversionWorkspaces/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the MigrationJobs resource.</summary>
            public virtual MigrationJobsResource MigrationJobs { get; }

            /// <summary>The "migrationJobs" collection of methods.</summary>
            public class MigrationJobsResource
            {
                private const string Resource = "migrationJobs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MigrationJobsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Objects = new ObjectsResource(service);
                }

                /// <summary>Gets the Objects resource.</summary>
                public virtual ObjectsResource Objects { get; }

                /// <summary>The "objects" collection of methods.</summary>
                public class ObjectsResource
                {
                    private const string Resource = "objects";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ObjectsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Use this method to get details about a migration job object.</summary>
                    /// <param name="name">Required. The name of the migration job object resource to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Use this method to get details about a migration job object.</summary>
                    public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.MigrationJobObject>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the migration job object resource to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+/objects/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
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
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+/objects/[^/]+$",
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

                    /// <summary>Use this method to list the objects of a specific migration job.</summary>
                    /// <param name="parent">
                    /// Required. The parent migration job that owns the collection of objects.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Use this method to list the objects of a specific migration job.</summary>
                    public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListMigrationJobObjectsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent migration job that owns the collection of objects.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Maximum number of objects to return. Default is 50. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Page token received from a previous `ListMigrationJObObjectsRequest` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListMigrationJobObjectsRequest` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/objects";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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
                    /// Use this method to look up a migration job object by its source object identifier.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent migration job that owns the collection of objects.
                    /// </param>
                    public virtual LookupRequest Lookup(Google.Apis.DatabaseMigrationService.v1.Data.LookupMigrationJobObjectRequest body, string parent)
                    {
                        return new LookupRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Use this method to look up a migration job object by its source object identifier.
                    /// </summary>
                    public class LookupRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.MigrationJobObject>
                    {
                        /// <summary>Constructs a new Lookup request.</summary>
                        public LookupRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.LookupMigrationJobObjectRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent migration job that owns the collection of objects.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DatabaseMigrationService.v1.Data.LookupMigrationJobObjectRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "lookup";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/objects:lookup";

                        /// <summary>Initializes Lookup parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+/objects/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+/objects/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new migration job in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent which owns this collection of migration jobs.</param>
                public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new migration job in a given project and location.</summary>
                public class CreateRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent which owns this collection of migration jobs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID of the instance to create.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("migrationJobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string MigrationJobId { get; set; }

                    /// <summary>
                    /// Optional. A unique ID used to identify the request. If the server receives two requests with the
                    /// same ID, then the second request is ignored. It is recommended to always set this value to a
                    /// UUID. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens
                    /// (-). The maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/migrationJobs";

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
                        RequestParameters.Add("migrationJobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "migrationJobId",
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

                /// <summary>Deletes a single migration job.</summary>
                /// <param name="name">Required. Name of the migration job resource to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single migration job.</summary>
                public class DeleteRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the migration job resource to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The destination CloudSQL connection profile is always deleted with the migration job. In case of
                    /// force delete, the destination CloudSQL replica database is also deleted.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// A unique ID used to identify the request. If the server receives two requests with the same ID,
                    /// then the second request is ignored. It is recommended to always set this value to a UUID. The ID
                    /// must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The
                    /// maximum length is 40 characters.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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
                    }
                }

                /// <summary>
                /// Demotes the destination database to become a read replica of the source. This is applicable for the
                /// following migrations: 1. MySQL to Cloud SQL for MySQL 2. PostgreSQL to Cloud SQL for PostgreSQL 3.
                /// PostgreSQL to AlloyDB for PostgreSQL.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Name of the migration job resource to demote its destination.</param>
                public virtual DemoteDestinationRequest DemoteDestination(Google.Apis.DatabaseMigrationService.v1.Data.DemoteDestinationRequest body, string name)
                {
                    return new DemoteDestinationRequest(this.service, body, name);
                }

                /// <summary>
                /// Demotes the destination database to become a read replica of the source. This is applicable for the
                /// following migrations: 1. MySQL to Cloud SQL for MySQL 2. PostgreSQL to Cloud SQL for PostgreSQL 3.
                /// PostgreSQL to AlloyDB for PostgreSQL.
                /// </summary>
                public class DemoteDestinationRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new DemoteDestination request.</summary>
                    public DemoteDestinationRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.DemoteDestinationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to demote its destination.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.DemoteDestinationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "demoteDestination";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:demoteDestination";

                    /// <summary>Initializes DemoteDestination parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Retrieves objects from the source database that can be selected for data migration. This is
                /// applicable for the following migrations: 1. PostgreSQL to Cloud SQL for PostgreSQL 2. PostgreSQL to
                /// AlloyDB for PostgreSQL.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name for the migration job for which source objects should be returned.
                /// </param>
                public virtual FetchSourceObjectsRequest FetchSourceObjects(string name)
                {
                    return new FetchSourceObjectsRequest(this.service, name);
                }

                /// <summary>
                /// Retrieves objects from the source database that can be selected for data migration. This is
                /// applicable for the following migrations: 1. PostgreSQL to Cloud SQL for PostgreSQL 2. PostgreSQL to
                /// AlloyDB for PostgreSQL.
                /// </summary>
                public class FetchSourceObjectsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new FetchSourceObjects request.</summary>
                    public FetchSourceObjectsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for the migration job for which source objects should be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchSourceObjects";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:fetchSourceObjects";

                    /// <summary>Initializes FetchSourceObjects parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Generate a SSH configuration script to configure the reverse SSH connectivity.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="migrationJob">Name of the migration job resource to generate the SSH script.</param>
                public virtual GenerateSshScriptRequest GenerateSshScript(Google.Apis.DatabaseMigrationService.v1.Data.GenerateSshScriptRequest body, string migrationJob)
                {
                    return new GenerateSshScriptRequest(this.service, body, migrationJob);
                }

                /// <summary>Generate a SSH configuration script to configure the reverse SSH connectivity.</summary>
                public class GenerateSshScriptRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.SshScript>
                {
                    /// <summary>Constructs a new GenerateSshScript request.</summary>
                    public GenerateSshScriptRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.GenerateSshScriptRequest body, string migrationJob) : base(service)
                    {
                        MigrationJob = migrationJob;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to generate the SSH script.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("migrationJob", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MigrationJob { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.GenerateSshScriptRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateSshScript";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+migrationJob}:generateSshScript";

                    /// <summary>Initializes GenerateSshScript parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("migrationJob", new Google.Apis.Discovery.Parameter
                        {
                            Name = "migrationJob",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Generate a TCP Proxy configuration script to configure a cloud-hosted VM running a TCP Proxy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="migrationJob">
                /// Name of the migration job resource to generate the TCP Proxy script.
                /// </param>
                public virtual GenerateTcpProxyScriptRequest GenerateTcpProxyScript(Google.Apis.DatabaseMigrationService.v1.Data.GenerateTcpProxyScriptRequest body, string migrationJob)
                {
                    return new GenerateTcpProxyScriptRequest(this.service, body, migrationJob);
                }

                /// <summary>
                /// Generate a TCP Proxy configuration script to configure a cloud-hosted VM running a TCP Proxy.
                /// </summary>
                public class GenerateTcpProxyScriptRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.TcpProxyScript>
                {
                    /// <summary>Constructs a new GenerateTcpProxyScript request.</summary>
                    public GenerateTcpProxyScriptRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.GenerateTcpProxyScriptRequest body, string migrationJob) : base(service)
                    {
                        MigrationJob = migrationJob;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to generate the TCP Proxy script.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("migrationJob", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string MigrationJob { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.GenerateTcpProxyScriptRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateTcpProxyScript";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+migrationJob}:generateTcpProxyScript";

                    /// <summary>Initializes GenerateTcpProxyScript parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("migrationJob", new Google.Apis.Discovery.Parameter
                        {
                            Name = "migrationJob",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single migration job.</summary>
                /// <param name="name">Required. Name of the migration job resource to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single migration job.</summary>
                public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the migration job resource to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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
                public class GetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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

                /// <summary>Lists migration jobs in a given project and location.</summary>
                /// <param name="parent">Required. The parent which owns this collection of migrationJobs.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists migration jobs in a given project and location.</summary>
                public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListMigrationJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent which owns this collection of migrationJobs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that filters migration jobs listed in the response. The expression must
                    /// specify the field name, a comparison operator, and the value that you want to use for filtering.
                    /// The value must be a string, a number, or a boolean. The comparison operator must be either =,
                    /// !=, &amp;gt;, or &amp;lt;. For example, list migration jobs created this year by specifying
                    /// **createTime %gt; 2020-01-01T00:00:00.000000000Z.** You can also filter nested fields. For
                    /// example, you could specify **reverseSshConnectivity.vmIp = "1.2.3.4"** to select all migration
                    /// jobs connecting through the specific SSH tunnel bastion.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Sort the results based on the migration job name. Valid values are: "name", "name asc", and
                    /// "name desc".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of migration jobs to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 migration jobs will be returned. The maximum value is 1000; values above
                    /// 1000 are coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The nextPageToken value received in the previous call to migrationJobs.list, used in the
                    /// subsequent request to retrieve the next page of results. On first call this should be left
                    /// blank. When paginating, all other parameters provided to migrationJobs.list must match the call
                    /// that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/migrationJobs";

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

                /// <summary>Updates the parameters of a single migration job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (URI) of this migration job resource, in the form of:
                /// projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single migration job.</summary>
                public class PatchRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (URI) of this migration job resource, in the form of:
                    /// projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A unique ID used to identify the request. If the server receives two requests with the same ID,
                    /// then the second request is ignored. It is recommended to always set this value to a UUID. The ID
                    /// must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). The
                    /// maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                    /// conversion workspace resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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
                /// Promote a migration job, stopping replication to the destination and promoting the destination to be
                /// a standalone database.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Name of the migration job resource to promote.</param>
                public virtual PromoteRequest Promote(Google.Apis.DatabaseMigrationService.v1.Data.PromoteMigrationJobRequest body, string name)
                {
                    return new PromoteRequest(this.service, body, name);
                }

                /// <summary>
                /// Promote a migration job, stopping replication to the destination and promoting the destination to be
                /// a standalone database.
                /// </summary>
                public class PromoteRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Promote request.</summary>
                    public PromoteRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.PromoteMigrationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to promote.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.PromoteMigrationJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "promote";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:promote";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Restart a stopped or failed migration job, resetting the destination instance to its original state
                /// and starting the migration process from scratch.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Name of the migration job resource to restart.</param>
                public virtual RestartRequest Restart(Google.Apis.DatabaseMigrationService.v1.Data.RestartMigrationJobRequest body, string name)
                {
                    return new RestartRequest(this.service, body, name);
                }

                /// <summary>
                /// Restart a stopped or failed migration job, resetting the destination instance to its original state
                /// and starting the migration process from scratch.
                /// </summary>
                public class RestartRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Restart request.</summary>
                    public RestartRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.RestartMigrationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to restart.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.RestartMigrationJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restart";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:restart";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Resume a migration job that is currently stopped and is resumable (was stopped during CDC phase).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Name of the migration job resource to resume.</param>
                public virtual ResumeRequest Resume(Google.Apis.DatabaseMigrationService.v1.Data.ResumeMigrationJobRequest body, string name)
                {
                    return new ResumeRequest(this.service, body, name);
                }

                /// <summary>
                /// Resume a migration job that is currently stopped and is resumable (was stopped during CDC phase).
                /// </summary>
                public class ResumeRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Resume request.</summary>
                    public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.ResumeMigrationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to resume.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.ResumeMigrationJobRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Start an already created migration job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Name of the migration job resource to start.</param>
                public virtual StartRequest Start(Google.Apis.DatabaseMigrationService.v1.Data.StartMigrationJobRequest body, string name)
                {
                    return new StartRequest(this.service, body, name);
                }

                /// <summary>Start an already created migration job.</summary>
                public class StartRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.StartMigrationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to start.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.StartMigrationJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "start";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:start";

                    /// <summary>Initializes Start parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Stops a running migration job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Name of the migration job resource to stop.</param>
                public virtual StopRequest Stop(Google.Apis.DatabaseMigrationService.v1.Data.StopMigrationJobRequest body, string name)
                {
                    return new StopRequest(this.service, body, name);
                }

                /// <summary>Stops a running migration job.</summary>
                public class StopRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.StopMigrationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to stop.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.StopMigrationJobRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Verify a migration job, making sure the destination can reach the source and that all configuration
                /// and prerequisites are met.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Name of the migration job resource to verify.</param>
                public virtual VerifyRequest Verify(Google.Apis.DatabaseMigrationService.v1.Data.VerifyMigrationJobRequest body, string name)
                {
                    return new VerifyRequest(this.service, body, name);
                }

                /// <summary>
                /// Verify a migration job, making sure the destination can reach the source and that all configuration
                /// and prerequisites are met.
                /// </summary>
                public class VerifyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Verify request.</summary>
                    public VerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.VerifyMigrationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Name of the migration job resource to verify.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.VerifyMigrationJobRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/migrationJobs/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.DatabaseMigrationService.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Empty>
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
                public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
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
                public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the PrivateConnections resource.</summary>
            public virtual PrivateConnectionsResource PrivateConnections { get; }

            /// <summary>The "privateConnections" collection of methods.</summary>
            public class PrivateConnectionsResource
            {
                private const string Resource = "privateConnections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PrivateConnectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new private connection in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent that owns the collection of PrivateConnections.</param>
                public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.PrivateConnection body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new private connection in a given project and location.</summary>
                public class CreateRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.PrivateConnection body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent that owns the collection of PrivateConnections.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The private connection identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("privateConnectionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PrivateConnectionId { get; set; }

                    /// <summary>
                    /// Optional. A unique ID used to identify the request. If the server receives two requests with the
                    /// same ID, then the second request is ignored. It is recommended to always set this value to a
                    /// UUID. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens
                    /// (-). The maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Optional. If set to true, will skip validations.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("skipValidation", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> SkipValidation { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DatabaseMigrationService.v1.Data.PrivateConnection Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/privateConnections";

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
                        RequestParameters.Add("privateConnectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "privateConnectionId",
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
                        RequestParameters.Add("skipValidation", new Google.Apis.Discovery.Parameter
                        {
                            Name = "skipValidation",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Database Migration Service private connection.</summary>
                /// <param name="name">Required. The name of the private connection to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Database Migration Service private connection.</summary>
                public class DeleteRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the private connection to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A unique ID used to identify the request. If the server receives two requests with the
                    /// same ID, then the second request is ignored. It is recommended to always set this value to a
                    /// UUID. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens
                    /// (-). The maximum length is 40 characters.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
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

                /// <summary>Gets details of a single private connection.</summary>
                /// <param name="name">Required. The name of the private connection to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single private connection.</summary>
                public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.PrivateConnection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the private connection to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
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
                public class GetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
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

                /// <summary>Retrieves a list of private connections in a given project and location.</summary>
                /// <param name="parent">Required. The parent that owns the collection of private connections.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieves a list of private connections in a given project and location.</summary>
                public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListPrivateConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent that owns the collection of private connections.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that filters private connections listed in the response. The expression must
                    /// specify the field name, a comparison operator, and the value that you want to use for filtering.
                    /// The value must be a string, a number, or a boolean. The comparison operator must be either =,
                    /// !=, &amp;gt;, or &amp;lt;. For example, list private connections created this year by specifying
                    /// **createTime %gt; 2021-01-01T00:00:00.000000000Z**.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order by fields for the result.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Maximum number of private connections to return. If unspecified, at most 50 private connections
                    /// that are returned. The maximum value is 1000; values above 1000 are coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token received from a previous `ListPrivateConnections` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListPrivateConnections` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/privateConnections";

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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.DatabaseMigrationService.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/privateConnections/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Fetches a set of static IP addresses that need to be allowlisted by the customer when using the
            /// static-IP connectivity method.
            /// </summary>
            /// <param name="name">
            /// Required. The resource name for the location for which static IPs should be returned. Must be in the
            /// format `projects/*/locations/*`.
            /// </param>
            public virtual FetchStaticIpsRequest FetchStaticIps(string name)
            {
                return new FetchStaticIpsRequest(this.service, name);
            }

            /// <summary>
            /// Fetches a set of static IP addresses that need to be allowlisted by the customer when using the
            /// static-IP connectivity method.
            /// </summary>
            public class FetchStaticIpsRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.FetchStaticIpsResponse>
            {
                /// <summary>Constructs a new FetchStaticIps request.</summary>
                public FetchStaticIpsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name for the location for which static IPs should be returned. Must be in the
                /// format `projects/*/locations/*`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Maximum number of IPs to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A page token, received from a previous `FetchStaticIps` call.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "fetchStaticIps";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:fetchStaticIps";

                /// <summary>Initializes FetchStaticIps parameter list.</summary>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Location>
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
            public class ListRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.DatabaseMigrationService.v1.Data
{
    /// <summary>
    /// Specifies required connection parameters, and the parameters required to create an AlloyDB destination cluster.
    /// </summary>
    public class AlloyDbConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The AlloyDB cluster ID that this connection profile is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>Immutable. Metadata used to create the destination AlloyDB cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual AlloyDbSettings Settings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for creating an AlloyDB cluster.</summary>
    public class AlloyDbSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The database engine major version. This is an optional field. If a database version is not
        /// supplied at cluster creation time, then a default database version will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>
        /// Optional. The encryption config can be specified to encrypt the data disks and other persistent data
        /// resources of a cluster with a customer-managed encryption key (CMEK). When this field is not specified, the
        /// cluster will then use default encryption scheme to protect the user data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>Required. Input only. Initial user to setup during cluster creation. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialUser")]
        public virtual UserPassword InitialUser { get; set; }

        /// <summary>
        /// Labels for the AlloyDB cluster created by DMS. An object containing a list of 'key', 'value' pairs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryInstanceSettings")]
        public virtual PrimaryInstanceSettings PrimaryInstanceSettings { get; set; }

        /// <summary>
        /// Required. The resource link for the VPC network in which cluster resources are created and from which they
        /// are accessible via Private IP. The network must belong to the same project as the cluster. It is specified
        /// in the form: "projects/{project_number}/global/networks/{network_id}". This is required to create a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetwork")]
        public virtual string VpcNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'ApplyConversionWorkspace' request.</summary>
    public class ApplyConversionWorkspaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies whether the conversion workspace is to be committed automatically after the apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCommit")]
        public virtual System.Nullable<bool> AutoCommit { get; set; }

        /// <summary>Optional. Fully qualified (Uri) name of the destination connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfile")]
        public virtual string ConnectionProfile { get; set; }

        /// <summary>
        /// Optional. Only validates the apply process, but doesn't change the destination database. Only works for
        /// PostgreSQL destination connection profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>
        /// Filter which entities to apply. Leaving this field empty will apply all of the entities. Supports Google AIP
        /// 160 based filtering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Apply a hash function on the value.</summary>
    public class ApplyHash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Generate UUID from the data's byte array</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uuidFromBytes")]
        public virtual Empty UuidFromBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details regarding an Apply background job.</summary>
    public class ApplyJobDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The connection profile which was used for the apply job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfile")]
        public virtual string ConnectionProfile { get; set; }

        /// <summary>Output only. AIP-160 based filter used to specify the entities to apply</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set to a specific value (value is converted to fit the target data type)</summary>
    public class AssignSpecificValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specific value to be assigned</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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

    /// <summary>AuthorizedNetwork contains metadata for an authorized network.</summary>
    public class AuthorizedNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. CIDR range for one authorzied network of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidrRange")]
        public virtual string CidrRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Execution log of a background job.</summary>
    public class BackgroundJobLogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Apply job details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyJobDetails")]
        public virtual ApplyJobDetails ApplyJobDetails { get; set; }

        /// <summary>
        /// Output only. Job completion comment, such as how many entities were seeded, how many warnings were found
        /// during conversion, and similar information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionComment")]
        public virtual string CompletionComment { get; set; }

        /// <summary>Output only. Job completion state, i.e. the final state after the job completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionState")]
        public virtual string CompletionState { get; set; }

        /// <summary>Output only. Convert job details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertJobDetails")]
        public virtual ConvertJobDetails ConvertJobDetails { get; set; }

        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>The timestamp when the background job was finished.</summary>
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

        /// <summary>The background job log entry ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Import rules job details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importRulesJobDetails")]
        public virtual ImportRulesJobDetails ImportRulesJobDetails { get; set; }

        /// <summary>The type of job that was executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>
        /// Output only. Whether the client requested the conversion workspace to be committed after a successful
        /// completion of the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAutocommit")]
        public virtual System.Nullable<bool> RequestAutocommit { get; set; }

        /// <summary>Output only. Seed job details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seedJobDetails")]
        public virtual SeedJobDetails SeedJobDetails { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The timestamp when the background job was started.</summary>
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

    /// <summary>Configuration to use Binary Log Parser CDC technique.</summary>
    public class BinaryLogParser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use Oracle directories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logFileDirectories")]
        public virtual LogFileDirectories LogFileDirectories { get; set; }

        /// <summary>Use Oracle ASM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleAsmLogFileAccess")]
        public virtual OracleAsmLogFileAccess OracleAsmLogFileAccess { get; set; }

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

    /// <summary>
    /// Specifies required connection parameters, and, optionally, the parameters required to create a Cloud SQL
    /// destination database instance.
    /// </summary>
    public class CloudSqlConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Cloud SQL database instance's additional (outgoing) public IP. Used when the Cloud SQL
        /// database availability type is REGIONAL (i.e. multiple zones / highly available).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalPublicIp")]
        public virtual string AdditionalPublicIp { get; set; }

        /// <summary>Output only. The Cloud SQL instance ID that this connection profile is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlId")]
        public virtual string CloudSqlId { get; set; }

        /// <summary>Output only. The Cloud SQL database instance's private IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIp")]
        public virtual string PrivateIp { get; set; }

        /// <summary>Output only. The Cloud SQL database instance's public IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicIp")]
        public virtual string PublicIp { get; set; }

        /// <summary>Immutable. Metadata used to create the destination Cloud SQL database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual CloudSqlSettings Settings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for creating a Cloud SQL database instance.</summary>
    public class CloudSqlSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The activation policy specifies when the instance is activated; it is applicable only when the instance
        /// state is 'RUNNABLE'. Valid values: 'ALWAYS': The instance is on, and remains so even in the absence of
        /// connection requests. `NEVER`: The instance is off; it is not activated, even if a connection request
        /// arrives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationPolicy")]
        public virtual string ActivationPolicy { get; set; }

        /// <summary>
        /// [default: ON] If you enable this setting, Cloud SQL checks your available storage every 30 seconds. If the
        /// available storage falls below a threshold size, Cloud SQL automatically adds additional storage capacity. If
        /// the available storage repeatedly falls below the threshold size, Cloud SQL continues to add storage until it
        /// reaches the maximum of 30 TB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoStorageIncrease")]
        public virtual System.Nullable<bool> AutoStorageIncrease { get; set; }

        /// <summary>
        /// Optional. Availability type. Potential values: * `ZONAL`: The instance serves data from only one zone.
        /// Outages in that zone affect data availability. * `REGIONAL`: The instance can serve data from more than one
        /// zone in a region (it is highly available).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityType")]
        public virtual string AvailabilityType { get; set; }

        /// <summary>The KMS key name used for the csql instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekKeyName")]
        public virtual string CmekKeyName { get; set; }

        /// <summary>The Cloud SQL default instance level collation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>
        /// Optional. Data cache is an optional feature available for Cloud SQL for MySQL Enterprise Plus edition only.
        /// For more information on data cache, see [Data cache
        /// overview](https://cloud.google.com/sql/help/mysql-data-cache) in Cloud SQL documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCacheConfig")]
        public virtual DataCacheConfig DataCacheConfig { get; set; }

        /// <summary>
        /// The storage capacity available to the database, in GB. The minimum (and default) size is 10GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskSizeGb")]
        public virtual System.Nullable<long> DataDiskSizeGb { get; set; }

        /// <summary>The type of storage: `PD_SSD` (default) or `PD_HDD`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskType")]
        public virtual string DataDiskType { get; set; }

        /// <summary>
        /// The database flags passed to the Cloud SQL instance at startup. An object containing a list of "key": value
        /// pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseFlags")]
        public virtual System.Collections.Generic.IDictionary<string, string> DatabaseFlags { get; set; }

        /// <summary>The database engine type and version. Deprecated. Use database_version_name instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>Optional. The database engine type and version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersionName")]
        public virtual string DatabaseVersionName { get; set; }

        /// <summary>Optional. The edition of the given Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>
        /// The settings for IP Management. This allows to enable or disable the instance IP and manage which external
        /// networks can connect to the instance. The IPv4 address cannot be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipConfig")]
        public virtual SqlIpConfig IpConfig { get; set; }

        /// <summary>Input only. Initial root password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPassword")]
        public virtual string RootPassword { get; set; }

        /// <summary>Output only. Indicates If this connection profile root password is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPasswordSet")]
        public virtual System.Nullable<bool> RootPasswordSet { get; set; }

        /// <summary>
        /// Optional. The Google Cloud Platform zone where the failover Cloud SQL database instance is located. Used
        /// when the Cloud SQL database availability type is REGIONAL (i.e. multiple zones / highly available).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryZone")]
        public virtual string SecondaryZone { get; set; }

        /// <summary>
        /// The Database Migration Service source connection profile ID, in the format:
        /// `projects/my_project_name/locations/us-central1/connectionProfiles/connection_profile_ID`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceId")]
        public virtual string SourceId { get; set; }

        /// <summary>
        /// The maximum size to which storage capacity can be automatically increased. The default value is 0, which
        /// specifies that there is no limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageAutoResizeLimit")]
        public virtual System.Nullable<long> StorageAutoResizeLimit { get; set; }

        /// <summary>
        /// The tier (or machine type) for this instance, for example: `db-n1-standard-1` (MySQL instances) or
        /// `db-custom-1-3840` (PostgreSQL instances). For more information, see [Cloud SQL Instance
        /// Settings](https://cloud.google.com/sql/docs/mysql/instance-settings).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>
        /// The resource labels for a Cloud SQL instance to use to annotate any related underlying resources such as
        /// Compute Engine VMs. An object containing a list of "key": "value" pairs. Example: `{ "name": "wrench",
        /// "mass": "18kg", "count": "3" }`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The Google Cloud Platform zone where your Cloud SQL database instance is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Column is not used as an independent entity, it is retrieved as part of a Table entity.</summary>
    public class ColumnEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Is the column of array type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("array")]
        public virtual System.Nullable<bool> Array { get; set; }

        /// <summary>If the column is array, of which length.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayLength")]
        public virtual System.Nullable<int> ArrayLength { get; set; }

        /// <summary>Is the column auto-generated/identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoGenerated")]
        public virtual System.Nullable<bool> AutoGenerated { get; set; }

        /// <summary>Charset override - instead of table level charset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("charset")]
        public virtual string Charset { get; set; }

        /// <summary>Collation override - instead of table level collation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>Comment associated with the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Is the column a computed column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computed")]
        public virtual System.Nullable<bool> Computed { get; set; }

        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Column data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Default value of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; }

        /// <summary>Column fractional second precision - used for timestamp based datatypes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fractionalSecondsPrecision")]
        public virtual System.Nullable<int> FractionalSecondsPrecision { get; set; }

        /// <summary>Column length - e.g. varchar (50).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>Column name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Is the column nullable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>Column order in the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ordinalPosition")]
        public virtual System.Nullable<int> OrdinalPosition { get; set; }

        /// <summary>Column precision - when relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<int> Precision { get; set; }

        /// <summary>Column scale - when relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<int> Scale { get; set; }

        /// <summary>Specifies the list of values allowed in the column. Only used for set data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setValues")]
        public virtual System.Collections.Generic.IList<string> SetValues { get; set; }

        /// <summary>Is the column a UDT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("udt")]
        public virtual System.Nullable<bool> Udt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'CommitConversionWorkspace' request.</summary>
    public class CommitConversionWorkspaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Optional name of the commit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitName")]
        public virtual string CommitName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type ConditionalColumnSetValue. The rule is used to transform the data which is being
    /// replicated/migrated. The rule filter field can refer to one or more entities. The rule scope can be one of:
    /// Column.
    /// </summary>
    public class ConditionalColumnSetValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>
        /// Optional. Optional filter on source column precision and scale. Used for fixed point numbers such as
        /// NUMERIC/NUMBER data types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceNumericFilter")]
        public virtual SourceNumericFilter SourceNumericFilter { get; set; }

        /// <summary>
        /// Optional. Optional filter on source column length. Used for text based data types like varchar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTextFilter")]
        public virtual SourceTextFilter SourceTextFilter { get; set; }

        /// <summary>Required. Description of data transformation during migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueTransformation")]
        public virtual ValueTransformation ValueTransformation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A connection profile definition.</summary>
    public class ConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An AlloyDB cluster connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alloydb")]
        public virtual AlloyDbConnectionProfile Alloydb { get; set; }

        /// <summary>A CloudSQL database connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudsql")]
        public virtual CloudSqlConnectionProfile Cloudsql { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC "Zulu" format, accurate
        /// to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
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

        /// <summary>The connection profile display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The error details in case of state FAILED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// The resource labels for connection profile to use to annotate any related underlying resources such as
        /// Compute Engine VMs. An object containing a list of "key": "value" pairs. Example: `{ "name": "wrench",
        /// "mass": "1.3kg", "count": "3" }`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>A MySQL database connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysql")]
        public virtual MySqlConnectionProfile Mysql { get; set; }

        /// <summary>
        /// The name of this connection profile resource in the form of
        /// projects/{project}/locations/{location}/connectionProfiles/{connectionProfile}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An Oracle database connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracle")]
        public virtual OracleConnectionProfile Oracle { get; set; }

        /// <summary>A PostgreSQL database connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postgresql")]
        public virtual PostgreSqlConnectionProfile Postgresql { get; set; }

        /// <summary>The database provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Optional. The connection profile role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Output only. Zone Isolation compliance state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Zone Separation compliance state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Connection profile for a SQL Server data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlserver")]
        public virtual SqlServerConnectionProfile Sqlserver { get; set; }

        /// <summary>The current connection profile state (e.g. DRAFT, READY, or FAILED).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. A timestamp in RFC3339 UTC "Zulu" format,
        /// accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Constraint is not used as an independent entity, it is retrieved as part of another entity such as Table or
    /// View.
    /// </summary>
    public class ConstraintEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the table constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Reference columns which may be associated with the constraint. For example, if the constraint is a
        /// FOREIGN_KEY, this represents the list of full names of referenced columns by the foreign key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceColumns")]
        public virtual System.Collections.Generic.IList<string> ReferenceColumns { get; set; }

        /// <summary>
        /// Reference table which may be associated with the constraint. For example, if the constraint is a
        /// FOREIGN_KEY, this represents the list of full name of the referenced table by the foreign key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceTable")]
        public virtual string ReferenceTable { get; set; }

        /// <summary>
        /// Table columns used as part of the Constraint, for example primary key constraint should list the columns
        /// which constitutes the key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumns")]
        public virtual System.Collections.Generic.IList<string> TableColumns { get; set; }

        /// <summary>
        /// Table which is associated with the constraint. In case the constraint is defined on a table, this field is
        /// left empty as this information is stored in parent_name. However, if constraint is defined on a view, this
        /// field stores the table name on which the view is defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableName")]
        public virtual string TableName { get; set; }

        /// <summary>
        /// Type of constraint, for example unique, primary key, foreign key (currently only primary key is supported).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The main conversion workspace resource entity.</summary>
    public class ConversionWorkspace : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the workspace resource was created.</summary>
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

        /// <summary>Required. The destination engine details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual DatabaseEngineInfo Destination { get; set; }

        /// <summary>Optional. The display name for the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. A generic list of settings for the workspace. The settings are database pair dependant and can
        /// indicate default behavior for the mapping rules engine or turn on or off specific features. Such examples
        /// can be: convert_foreign_key_to_interleave=true, skip_triggers=false, ignore_non_table_synonyms=true
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalSettings")]
        public virtual System.Collections.Generic.IDictionary<string, string> GlobalSettings { get; set; }

        /// <summary>
        /// Output only. Whether the workspace has uncommitted changes (changes which were made after the workspace was
        /// committed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUncommittedChanges")]
        public virtual System.Nullable<bool> HasUncommittedChanges { get; set; }

        /// <summary>Output only. The latest commit ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCommitId")]
        public virtual string LatestCommitId { get; set; }

        private string _latestCommitTimeRaw;

        private object _latestCommitTime;

        /// <summary>Output only. The timestamp when the workspace was committed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCommitTime")]
        public virtual string LatestCommitTimeRaw
        {
            get => _latestCommitTimeRaw;
            set
            {
                _latestCommitTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestCommitTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestCommitTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestCommitTimeDateTimeOffset instead.")]
        public virtual object LatestCommitTime
        {
            get => _latestCommitTime;
            set
            {
                _latestCommitTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestCommitTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestCommitTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestCommitTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestCommitTimeRaw);
            set => LatestCommitTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Full name of the workspace resource, in the form of:
        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The source engine details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual DatabaseEngineInfo Source { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the workspace resource was last updated.</summary>
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

    /// <summary>A conversion workspace's version.</summary>
    public class ConversionWorkspaceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The commit ID of the conversion workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitId")]
        public virtual string CommitId { get; set; }

        /// <summary>The resource name (URI) of the conversion workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'ConvertConversionWorkspace' request.</summary>
    public class ConvertConversionWorkspaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies whether the conversion workspace is to be committed automatically after the conversion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCommit")]
        public virtual System.Nullable<bool> AutoCommit { get; set; }

        /// <summary>
        /// Optional. Automatically convert the full entity path for each entity specified by the filter. For example,
        /// if the filter specifies a table, that table schema (and database if there is one) will also be converted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertFullPath")]
        public virtual System.Nullable<bool> ConvertFullPath { get; set; }

        /// <summary>
        /// Optional. Filter the entities to convert. Leaving this field empty will convert all of the entities.
        /// Supports Google AIP-160 style filtering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details regarding a Convert background job.</summary>
    public class ConvertJobDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. AIP-160 based filter used to specify the entities to convert</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type ConvertROWIDToColumn. The rule is used to add column rowid to destination tables
    /// based on an Oracle rowid function/property. The rule filter field can refer to one or more entities. The rule
    /// scope can be one of: Table. This rule requires additional filter to be specified beyond the basic rule filter
    /// field, which is whether or not to work on tables which already have a primary key defined.
    /// </summary>
    public class ConvertRowIdToColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Only work on tables without primary key defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyIfNoPrimaryKey")]
        public virtual System.Nullable<bool> OnlyIfNoPrimaryKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data cache is an optional feature available for Cloud SQL for MySQL Enterprise Plus edition only. For more
    /// information on data cache, see [Data cache overview](https://cloud.google.com/sql/help/mysql-data-cache) in
    /// Cloud SQL documentation.
    /// </summary>
    public class DataCacheConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether data cache is enabled for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCacheEnabled")]
        public virtual System.Nullable<bool> DataCacheEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The type and version of a source or destination database.</summary>
    public class DatabaseEngineInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Engine type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>Required. Engine version, for example "12.c.1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The base entity type for all the database related entities. The message contains the entity name, the name of
    /// its parent, the entity type, and the specific details per entity type.
    /// </summary>
    public class DatabaseEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual DatabaseInstanceEntity Database { get; set; }

        /// <summary>Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseFunction")]
        public virtual FunctionEntity DatabaseFunction { get; set; }

        /// <summary>Package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databasePackage")]
        public virtual PackageEntity DatabasePackage { get; set; }

        /// <summary>
        /// Details about the entity DDL script. Multiple DDL scripts are provided for child entities such as a table
        /// entity will have one DDL for the table with additional DDLs for each index, constraint and such.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityDdl")]
        public virtual System.Collections.Generic.IList<EntityDdl> EntityDdl { get; set; }

        /// <summary>The type of the database entity (table, view, index, ...).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>Details about the various issues found for the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<EntityIssue> Issues { get; set; }

        /// <summary>
        /// Details about entity mappings. For source tree entities, this holds the draft entities which were generated
        /// by the mapping rules. For draft tree entities, this holds the source entities which were converted to form
        /// the draft entity. Destination entities will have no mapping details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappings")]
        public virtual System.Collections.Generic.IList<EntityMapping> Mappings { get; set; }

        /// <summary>Materialized view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materializedView")]
        public virtual MaterializedViewEntity MaterializedView { get; set; }

        /// <summary>The full name of the parent entity (e.g. schema name).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentEntity")]
        public virtual string ParentEntity { get; set; }

        /// <summary>Schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual SchemaEntity Schema { get; set; }

        /// <summary>Sequence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequence")]
        public virtual SequenceEntity Sequence { get; set; }

        /// <summary>The short name (e.g. table name) of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>Stored procedure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storedProcedure")]
        public virtual StoredProcedureEntity StoredProcedure { get; set; }

        /// <summary>Synonym.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonym")]
        public virtual SynonymEntity Synonym { get; set; }

        /// <summary>Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual TableEntity Table { get; set; }

        /// <summary>The type of tree the entity belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tree")]
        public virtual string Tree { get; set; }

        /// <summary>UDT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("udt")]
        public virtual UDTEntity Udt { get; set; }

        /// <summary>View.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual ViewEntity View { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DatabaseInstance acts as a parent entity to other database entities.</summary>
    public class DatabaseInstanceEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message defining the database engine and provider.</summary>
    public class DatabaseType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The database engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>The database provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'DemoteDestination' request.</summary>
    public class DemoteDestinationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'DescribeConversionWorkspaceRevisions' request.</summary>
    public class DescribeConversionWorkspaceRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of conversion workspace revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<ConversionWorkspace> Revisions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'DescribeDatabaseEntities' request.</summary>
    public class DescribeDatabaseEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of database entities for the conversion workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseEntities")]
        public virtual System.Collections.Generic.IList<DatabaseEntity> DatabaseEntities { get; set; }

        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Filter based on relation between source value and compare value of type double in ConditionalColumnSetValue
    /// </summary>
    public class DoubleComparisonFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Double compare value to be used</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>Required. Relation between source value and compare value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueComparison")]
        public virtual string ValueComparison { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dump flag definition.</summary>
    public class DumpFlag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the flag</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The value of the flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dump flags definition.</summary>
    public class DumpFlags : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The flags for the initial dump.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpFlags")]
        public virtual System.Collections.Generic.IList<DumpFlag> DumpFlagsValue { get; set; }

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
    /// EncryptionConfig describes the encryption config of a cluster that is encrypted with a CMEK (customer-managed
    /// encryption key).
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

    /// <summary>A single DDL statement for a specific entity</summary>
    public class EntityDdl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual ddl code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddl")]
        public virtual string Ddl { get; set; }

        /// <summary>The DDL Kind selected for apply, or SOURCE if getting the source tree.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlKind")]
        public virtual string DdlKind { get; set; }

        /// <summary>Type of DDL (Create, Alter).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddlType")]
        public virtual string DdlType { get; set; }

        /// <summary>
        /// If ddl_kind is USER_EDIT, this holds the DDL kind of the original content - DETERMINISTIC or AI. Otherwise,
        /// this is DDL_KIND_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editedDdlKind")]
        public virtual string EditedDdlKind { get; set; }

        /// <summary>The name of the database entity the ddl refers to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual string Entity { get; set; }

        /// <summary>The entity type (if the DDL is for a sub entity).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>EntityIssues found for this ddl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueId")]
        public virtual System.Collections.Generic.IList<string> IssueId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Issue related to the entity.</summary>
    public class EntityIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error/Warning code</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ddl which caused the issue, if relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ddl")]
        public virtual string Ddl { get; set; }

        /// <summary>The entity type (if the DDL is for a sub entity).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>Unique Issue ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Issue detailed message</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The position of the issue found, if relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Position Position { get; set; }

        /// <summary>Severity of the issue</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The type of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the mappings of a database entity.</summary>
    public class EntityMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Target entity full name. The draft entity can also include a column, index or constraint using the same
        /// naming notation schema.table.column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("draftEntity")]
        public virtual string DraftEntity { get; set; }

        /// <summary>Type of draft entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("draftType")]
        public virtual string DraftType { get; set; }

        /// <summary>
        /// Entity mapping log entries. Multiple rules can be effective and contribute changes to a converted entity,
        /// such as a rule can handle the entity name, another rule can handle an entity type. In addition, rules which
        /// did not change the entity are also logged along with the reason preventing them to do so.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappingLog")]
        public virtual System.Collections.Generic.IList<EntityMappingLogEntry> MappingLog { get; set; }

        /// <summary>
        /// Source entity full name. The source entity can also be a column, index or constraint using the same naming
        /// notation schema.table.column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceEntity")]
        public virtual string SourceEntity { get; set; }

        /// <summary>Type of source entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single record of a rule which was used for a mapping.</summary>
    public class EntityMappingLogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappingComment")]
        public virtual string MappingComment { get; set; }

        /// <summary>Which rule caused this log entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>Rule revision ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleRevisionId")]
        public virtual string RuleRevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type EntityMove. The rule is used to move an entity to a new schema. The rule filter
    /// field can refer to one or more entities. The rule scope can be one of: Table, Column, Constraint, Index, View,
    /// Function, Stored Procedure, Materialized View, Sequence, UDT
    /// </summary>
    public class EntityMove : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSchema")]
        public virtual string NewSchema { get; set; }

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

    /// <summary>Response message for a 'FetchStaticIps' request.</summary>
    public class FetchStaticIpsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of static IPs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIps")]
        public virtual System.Collections.Generic.IList<string> StaticIps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type FilterTableColumns. The rule is used to filter the list of columns to include or
    /// exclude from a table. The rule filter field can refer to one entity. The rule scope can be: Table Only one of
    /// the two lists can be specified for the rule.
    /// </summary>
    public class FilterTableColumns : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of columns to be excluded for a particular table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeColumns")]
        public virtual System.Collections.Generic.IList<string> ExcludeColumns { get; set; }

        /// <summary>Optional. List of columns to be included for a particular table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeColumns")]
        public virtual System.Collections.Generic.IList<string> IncludeColumns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Forward SSH Tunnel connectivity.</summary>
    public class ForwardSshTunnelConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Hostname for the SSH tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Input only. SSH password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Port for the SSH tunnel, default value is 22.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Input only. SSH private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKey")]
        public virtual string PrivateKey { get; set; }

        /// <summary>Required. Username for the SSH tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Function's parent is a schema.</summary>
    public class FunctionEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The SQL code which creates the function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'GenerateSshScript' request.</summary>
    public class GenerateSshScriptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Bastion VM Instance name to use or to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vm")]
        public virtual string Vm { get; set; }

        /// <summary>The VM creation configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmCreationConfig")]
        public virtual VmCreationConfig VmCreationConfig { get; set; }

        /// <summary>The port that will be open on the bastion host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmPort")]
        public virtual System.Nullable<int> VmPort { get; set; }

        /// <summary>The VM selection configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmSelectionConfig")]
        public virtual VmSelectionConfig VmSelectionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'GenerateTcpProxyScript' request.</summary>
    public class GenerateTcpProxyScriptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the Compute instance that will host the proxy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmMachineType")]
        public virtual string VmMachineType { get; set; }

        /// <summary>Required. The name of the Compute instance that will host the proxy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmName")]
        public virtual string VmName { get; set; }

        /// <summary>
        /// Required. The name of the subnet the Compute instance will use for private connectivity. Must be supplied in
        /// the form of projects/{project}/regions/{region}/subnetworks/{subnetwork}. Note: the region for the subnet
        /// must match the Compute instance region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmSubnet")]
        public virtual string VmSubnet { get; set; }

        /// <summary>
        /// Optional. The Google Cloud Platform zone to create the VM in. The fully qualified name of the zone must be
        /// specified, including the region name, for example "us-central1-b". If not specified, uses the "-b" zone of
        /// the destination Connection Profile's region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmZone")]
        public virtual string VmZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudClouddmsV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to `Code.CANCELLED`.
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

    /// <summary>Request message for 'ImportMappingRules' request.</summary>
    public class ImportMappingRulesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Should the conversion workspace be committed automatically after the import operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCommit")]
        public virtual System.Nullable<bool> AutoCommit { get; set; }

        /// <summary>Required. One or more rules files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesFiles")]
        public virtual System.Collections.Generic.IList<RulesFile> RulesFiles { get; set; }

        /// <summary>Required. The format of the rules content file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesFormat")]
        public virtual string RulesFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details regarding an Import Rules background job.</summary>
    public class ImportRulesJobDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The requested file format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileFormat")]
        public virtual string FileFormat { get; set; }

        /// <summary>Output only. File names used for the import rules job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<string> Files { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Index is not used as an independent entity, it is retrieved as part of a Table entity.</summary>
    public class IndexEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Table columns used as part of the Index, for example B-TREE index should list the columns which constitutes
        /// the index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumns")]
        public virtual System.Collections.Generic.IList<string> TableColumns { get; set; }

        /// <summary>
        /// For each table_column, mark whether it's sorting order is ascending (false) or descending (true). If no
        /// value is defined, assume all columns are sorted in ascending order. Otherwise, the number of items must
        /// match that of table_columns with each value specifying the direction of the matched column by its index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumnsDescending")]
        public virtual System.Collections.Generic.IList<System.Nullable<bool>> TableColumnsDescending { get; set; }

        /// <summary>Type of index, for example B-TREE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Boolean value indicating whether the index is unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unique")]
        public virtual System.Nullable<bool> Unique { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to instance level network configuration.</summary>
    public class InstanceNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of external network authorized to access this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedExternalNetworks")]
        public virtual System.Collections.Generic.IList<AuthorizedNetwork> AuthorizedExternalNetworks { get; set; }

        /// <summary>
        /// Optional. Enabling an outbound public IP address to support a database server sending requests out into the
        /// internet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableOutboundPublicIp")]
        public virtual System.Nullable<bool> EnableOutboundPublicIp { get; set; }

        /// <summary>Optional. Enabling public ip for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePublicIp")]
        public virtual System.Nullable<bool> EnablePublicIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Filter based on relation between source value and compare value of type integer in ConditionalColumnSetValue
    /// </summary>
    public class IntComparisonFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Integer compare value to be used</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>Required. Relation between source value and compare value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueComparison")]
        public virtual string ValueComparison { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListConnectionProfiles' request.</summary>
    public class ListConnectionProfilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The response list of connection profiles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfiles")]
        public virtual System.Collections.Generic.IList<ConnectionProfile> ConnectionProfiles { get; set; }

        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListConversionWorkspaces' request.</summary>
    public class ListConversionWorkspacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of conversion workspace objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionWorkspaces")]
        public virtual System.Collections.Generic.IList<ConversionWorkspace> ConversionWorkspaces { get; set; }

        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
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

    /// <summary>Response message for 'ListMappingRulesRequest' request.</summary>
    public class ListMappingRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of conversion workspace mapping rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappingRules")]
        public virtual System.Collections.Generic.IList<MappingRule> MappingRules { get; set; }

        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the objects for a migration job.</summary>
    public class ListMigrationJobObjectsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of migration job objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationJobObjects")]
        public virtual System.Collections.Generic.IList<MigrationJobObject> MigrationJobObjects { get; set; }

        /// <summary>A token, which can be sent as `page_token` to retrieve the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'ListMigrationJobs' request.</summary>
    public class ListMigrationJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of migration jobs objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationJobs")]
        public virtual System.Collections.Generic.IList<MigrationJob> MigrationJobs { get; set; }

        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
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

    /// <summary>Response message for 'ListPrivateConnections' request.</summary>
    public class ListPrivateConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of private connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnections")]
        public virtual System.Collections.Generic.IList<PrivateConnection> PrivateConnections { get; set; }

        /// <summary>Locations that could not be reached.</summary>
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

    /// <summary>Configuration to specify the Oracle directories to access the log files.</summary>
    public class LogFileDirectories : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Oracle directory for archived logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archivedLogDirectory")]
        public virtual string ArchivedLogDirectory { get; set; }

        /// <summary>Required. Oracle directory for online logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlineLogDirectory")]
        public virtual string OnlineLogDirectory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration to use LogMiner CDC method.</summary>
    public class LogMiner : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for looking up a specific migration job object by its source object identifier.</summary>
    public class LookupMigrationJobObjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The source object identifier which maps to the migration job object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceObjectIdentifier")]
        public virtual SourceObjectIdentifier SourceObjectIdentifier { get; set; }

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
    /// Definition of a transformation that is to be applied to a group of entities in the source schema. Several such
    /// transformations can be applied to an entity sequentially to define the corresponding entity in the target
    /// schema.
    /// </summary>
    public class MappingRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Rule to specify how the data contained in a column should be transformed (such as trimmed,
        /// rounded, etc) provided that the data meets certain criteria.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionalColumnSetValue")]
        public virtual ConditionalColumnSetValue ConditionalColumnSetValue { get; set; }

        /// <summary>
        /// Optional. Rule to specify how multiple tables should be converted with an additional rowid column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertRowidColumn")]
        public virtual ConvertRowIdToColumn ConvertRowidColumn { get; set; }

        /// <summary>Optional. A human readable name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Rule to specify how multiple entities should be relocated into a different schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityMove")]
        public virtual EntityMove EntityMove { get; set; }

        /// <summary>Required. The rule filter</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual MappingRuleFilter Filter { get; set; }

        /// <summary>Optional. Rule to specify the list of columns to include or exclude from a table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterTableColumns")]
        public virtual FilterTableColumns FilterTableColumns { get; set; }

        /// <summary>
        /// Optional. Rule to specify how multiple columns should be converted to a different data type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiColumnDataTypeChange")]
        public virtual MultiColumnDatatypeChange MultiColumnDataTypeChange { get; set; }

        /// <summary>Optional. Rule to specify how multiple entities should be renamed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiEntityRename")]
        public virtual MultiEntityRename MultiEntityRename { get; set; }

        /// <summary>
        /// Full name of the mapping rule resource, in the form of:
        /// projects/{project}/locations/{location}/conversionWorkspaces/{set}/mappingRule/{rule}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _revisionCreateTimeRaw;

        private object _revisionCreateTime;

        /// <summary>Output only. The timestamp that the revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual string RevisionCreateTimeRaw
        {
            get => _revisionCreateTimeRaw;
            set
            {
                _revisionCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _revisionCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RevisionCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RevisionCreateTimeDateTimeOffset instead.")]
        public virtual object RevisionCreateTime
        {
            get => _revisionCreateTime;
            set
            {
                _revisionCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _revisionCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RevisionCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RevisionCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RevisionCreateTimeRaw);
            set => RevisionCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The revision ID of the mapping rule. A new revision is committed whenever the mapping rule is
        /// changed in any way. The format is an 8-character hexadecimal string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>
        /// Required. The order in which the rule is applied. Lower order rules are applied before higher value rules so
        /// they may end up being overridden.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleOrder")]
        public virtual System.Nullable<long> RuleOrder { get; set; }

        /// <summary>Required. The rule scope</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleScope")]
        public virtual string RuleScope { get; set; }

        /// <summary>Optional. Rule to specify the primary key for a table</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setTablePrimaryKey")]
        public virtual SetTablePrimaryKey SetTablePrimaryKey { get; set; }

        /// <summary>Optional. Rule to specify how a single column is converted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleColumnChange")]
        public virtual SingleColumnChange SingleColumnChange { get; set; }

        /// <summary>Optional. Rule to specify how a single entity should be renamed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleEntityRename")]
        public virtual SingleEntityRename SingleEntityRename { get; set; }

        /// <summary>Optional. Rule to specify how a single package is converted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singlePackageChange")]
        public virtual SinglePackageChange SinglePackageChange { get; set; }

        /// <summary>Optional. Rule to change the sql code for an entity, for example, function, procedure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSqlChange")]
        public virtual SourceSqlChange SourceSqlChange { get; set; }

        /// <summary>Optional. The mapping rule state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter defining the entities that a mapping rule should be applied to. When more than one field is specified,
    /// the rule is applied only to entities which match all the fields.
    /// </summary>
    public class MappingRuleFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The rule should be applied to specific entities defined by their fully qualified names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<string> Entities { get; set; }

        /// <summary>
        /// Optional. The rule should be applied to entities whose non-qualified name contains the given string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityNameContains")]
        public virtual string EntityNameContains { get; set; }

        /// <summary>
        /// Optional. The rule should be applied to entities whose non-qualified name starts with the given prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityNamePrefix")]
        public virtual string EntityNamePrefix { get; set; }

        /// <summary>
        /// Optional. The rule should be applied to entities whose non-qualified name ends with the given suffix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityNameSuffix")]
        public virtual string EntityNameSuffix { get; set; }

        /// <summary>
        /// Optional. The rule should be applied to entities whose parent entity (fully qualified name) matches the
        /// given value. For example, if the rule applies to a table entity, the expected value should be a schema
        /// (schema). If the rule applies to a column or index entity, the expected value can be either a schema
        /// (schema) or a table (schema.table)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentEntity")]
        public virtual string ParentEntity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MaterializedView's parent is a schema.</summary>
    public class MaterializedViewEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>View indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indices")]
        public virtual System.Collections.Generic.IList<IndexEntity> Indices { get; set; }

        /// <summary>The SQL code which creates the view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Database Migration Service migration job object.</summary>
    public class MigrationJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The CMEK (customer-managed encryption key) fully qualified key name used for the migration job. This field
        /// supports all migration jobs types except for: * Mysql to Mysql (use the cmek field in the cloudsql
        /// connection profile instead). * PostrgeSQL to PostgreSQL (use the cmek field in the cloudsql connection
        /// profile instead). * PostgreSQL to AlloyDB (use the kms_key_name field in the alloydb connection profile
        /// instead). Each Cloud CMEK key has the following format:
        /// projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekKeyName")]
        public virtual string CmekKeyName { get; set; }

        /// <summary>The conversion workspace used by the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionWorkspace")]
        public virtual ConversionWorkspaceInfo ConversionWorkspace { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The timestamp when the migration job resource was created. A timestamp in RFC3339 UTC "Zulu"
        /// format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
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

        /// <summary>Required. The resource name (URI) of the destination connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>The database engine type and provider of the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDatabase")]
        public virtual DatabaseType DestinationDatabase { get; set; }

        /// <summary>The migration job display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The initial dump flags. This field and the "dump_path" field are mutually exclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpFlags")]
        public virtual DumpFlags DumpFlags { get; set; }

        /// <summary>
        /// The path to the dump file in Google Cloud Storage, in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]). This
        /// field and the "dump_flags" field are mutually exclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpPath")]
        public virtual string DumpPath { get; set; }

        /// <summary>
        /// Optional. The type of the data dump. Supported for MySQL to CloudSQL for MySQL migrations only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpType")]
        public virtual string DumpType { get; set; }

        /// <summary>
        /// Output only. The duration of the migration job (in seconds). A duration in seconds with up to nine
        /// fractional digits, terminated by 's'. Example: "3.5s".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. If the migration job is completed, the time when it was completed.</summary>
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

        /// <summary>Output only. The error details in case of state FAILED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// This field can be used to select the entities to migrate as part of the migration job. It uses AIP-160
        /// notation to select a subset of the entities configured on the associated conversion-workspace. This field
        /// should not be set on migration-jobs that are not associated with a conversion workspace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The resource labels for migration job to use to annotate any related underlying resources such as Compute
        /// Engine VMs. An object containing a list of "key": "value" pairs. Example: `{ "name": "wrench", "mass":
        /// "1.3kg", "count": "3" }`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The name (URI) of this migration job resource, in the form of:
        /// projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The objects that need to be migrated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsConfig")]
        public virtual MigrationJobObjectsConfig ObjectsConfig { get; set; }

        /// <summary>
        /// Configuration for heterogeneous **Oracle to Cloud SQL for PostgreSQL** and **Oracle to AlloyDB for
        /// PostgreSQL** migrations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleToPostgresConfig")]
        public virtual OracleToPostgresConfig OracleToPostgresConfig { get; set; }

        /// <summary>Optional. Data dump parallelism settings used by the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceConfig")]
        public virtual PerformanceConfig PerformanceConfig { get; set; }

        /// <summary>Output only. The current migration job phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>The details needed to communicate to the source over Reverse SSH tunnel connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reverseSshConnectivity")]
        public virtual ReverseSshConnectivity ReverseSshConnectivity { get; set; }

        /// <summary>Output only. Zone Isolation compliance state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Zone Separation compliance state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Required. The resource name (URI) of the source connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The database engine type and provider of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDatabase")]
        public virtual DatabaseType SourceDatabase { get; set; }

        /// <summary>Optional. Configuration for SQL Server homogeneous migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlserverHomogeneousMigrationJobConfig")]
        public virtual SqlServerHomogeneousMigrationJobConfig SqlserverHomogeneousMigrationJobConfig { get; set; }

        /// <summary>The current migration job state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>static ip connectivity data (default, no additional details needed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIpConnectivity")]
        public virtual StaticIpConnectivity StaticIpConnectivity { get; set; }

        /// <summary>Required. The migration job type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the migration job resource was last updated. A timestamp in RFC3339 UTC
        /// "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
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

        /// <summary>The details of the VPC network that the source database is located in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcPeeringConnectivity")]
        public virtual VpcPeeringConnectivity VpcPeeringConnectivity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific Migration Job Object (e.g. a specifc DB Table)</summary>
    public class MigrationJobObject : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time of the migration job object.</summary>
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

        /// <summary>Output only. The error details in case of failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The object's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The phase of the migration job object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>The object identifier in the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceObject")]
        public virtual SourceObjectIdentifier SourceObject { get; set; }

        /// <summary>The state of the migration job object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last update time of the migration job object.</summary>
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

    /// <summary>Configuration for the objects to be migrated.</summary>
    public class MigrationJobObjectsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of the migration job objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceObjectsConfig")]
        public virtual SourceObjectsConfig SourceObjectsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error message of a verification Migration job.</summary>
    public class MigrationJobVerificationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An instance of ErrorCode specifying the error that occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>Output only. A specific detailed error message, if supplied by the engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDetailMessage")]
        public virtual string ErrorDetailMessage { get; set; }

        /// <summary>Output only. A formatted message with further details about the error and a CTA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type MultiColumnDatatypeChange. The rule is used to change the data type and
    /// associated properties of multiple columns at once. The rule filter field can refer to one or more entities. The
    /// rule scope can be one of:Column. This rule requires additional filters to be specified beyond the basic rule
    /// filter field, which is the source data type, but the rule supports additional filtering capabilities such as the
    /// minimum and maximum field length. All additional filters which are specified are required to be met in order for
    /// the rule to be applied (logical AND between the fields).
    /// </summary>
    public class MultiColumnDatatypeChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Required. New data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newDataType")]
        public virtual string NewDataType { get; set; }

        /// <summary>
        /// Optional. Column fractional seconds precision - used only for timestamp based datatypes - if not specified
        /// and relevant uses the source column fractional seconds precision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideFractionalSecondsPrecision")]
        public virtual System.Nullable<int> OverrideFractionalSecondsPrecision { get; set; }

        /// <summary>
        /// Optional. Column length - e.g. varchar (50) - if not specified and relevant uses the source column length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideLength")]
        public virtual System.Nullable<long> OverrideLength { get; set; }

        /// <summary>
        /// Optional. Column precision - when relevant - if not specified and relevant uses the source column precision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overridePrecision")]
        public virtual System.Nullable<int> OverridePrecision { get; set; }

        /// <summary>
        /// Optional. Column scale - when relevant - if not specified and relevant uses the source column scale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideScale")]
        public virtual System.Nullable<int> OverrideScale { get; set; }

        /// <summary>Required. Filter on source data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDataTypeFilter")]
        public virtual string SourceDataTypeFilter { get; set; }

        /// <summary>Optional. Filter for fixed point number data types such as NUMERIC/NUMBER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceNumericFilter")]
        public virtual SourceNumericFilter SourceNumericFilter { get; set; }

        /// <summary>Optional. Filter for text-based data types like varchar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTextFilter")]
        public virtual SourceTextFilter SourceTextFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type MultiEntityRename. The rule is used to rename multiple entities. The rule filter
    /// field can refer to one or more entities. The rule scope can be one of: Database, Schema, Table, Column,
    /// Constraint, Index, View, Function, Stored Procedure, Materialized View, Sequence, UDT
    /// </summary>
    public class MultiEntityRename : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The pattern used to generate the new entity's name. This pattern must include the characters
        /// '{name}', which will be replaced with the name of the original entity. For example, the pattern 't_{name}'
        /// for an entity name jobs would be converted to 't_jobs'. If unspecified, the default value for this field is
        /// '{name}'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newNamePattern")]
        public virtual string NewNamePattern { get; set; }

        /// <summary>
        /// Optional. Additional transformation that can be done on the source entity name before it is being used by
        /// the new_name_pattern, for example lower case. If no transformation is desired, use NO_TRANSFORMATION
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceNameTransformation")]
        public virtual string SourceNameTransformation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies connection parameters required specifically for MySQL databases.</summary>
    public class MySqlConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlId")]
        public virtual string CloudSqlId { get; set; }

        /// <summary>Required. The IP or hostname of the source MySQL database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Database Migration Service will be using to connect to
        /// the database. This field is not returned on request, and the value is encrypted when stored in Database
        /// Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Output only. Indicates If this connection profile password is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSet")]
        public virtual System.Nullable<bool> PasswordSet { get; set; }

        /// <summary>Required. The network port of the source MySQL database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>SSL configuration for the destination to connect to the source database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssl")]
        public virtual SslConfig Ssl { get; set; }

        /// <summary>
        /// Required. The username that Database Migration Service will use to connect to the database. The value is
        /// encrypted when stored in Database Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

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

    /// <summary>Configuration for Oracle Automatic Storage Management (ASM) connection.</summary>
    public class OracleAsmConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ASM service name for the Oracle ASM connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asmService")]
        public virtual string AsmService { get; set; }

        /// <summary>Required. Hostname for the Oracle ASM connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Required. Input only. Password for the Oracle ASM connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Output only. Indicates whether a new password is included in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSet")]
        public virtual System.Nullable<bool> PasswordSet { get; set; }

        /// <summary>Required. Port for the Oracle ASM connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Optional. SSL configuration for the Oracle connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssl")]
        public virtual SslConfig Ssl { get; set; }

        /// <summary>Required. Username for the Oracle ASM connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration to use Oracle ASM to access the log files.</summary>
    public class OracleAsmLogFileAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies connection parameters required specifically for Oracle databases.</summary>
    public class OracleConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Database service for the Oracle connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseService")]
        public virtual string DatabaseService { get; set; }

        /// <summary>Forward SSH tunnel connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardSshConnectivity")]
        public virtual ForwardSshTunnelConnectivity ForwardSshConnectivity { get; set; }

        /// <summary>Required. The IP or hostname of the source Oracle database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Optional. Configuration for Oracle ASM connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleAsmConfig")]
        public virtual OracleAsmConfig OracleAsmConfig { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Database Migration Service will be using to connect to
        /// the database. This field is not returned on request, and the value is encrypted when stored in Database
        /// Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Output only. Indicates whether a new password is included in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSet")]
        public virtual System.Nullable<bool> PasswordSet { get; set; }

        /// <summary>Required. The network port of the source Oracle database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Private connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnectivity")]
        public virtual PrivateConnectivity PrivateConnectivity { get; set; }

        /// <summary>
        /// SSL configuration for the connection to the source Oracle database. * Only `SERVER_ONLY` configuration is
        /// supported for Oracle SSL. * SSL is supported for Oracle versions 12 and above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssl")]
        public virtual SslConfig Ssl { get; set; }

        /// <summary>Static Service IP connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticServiceIpConnectivity")]
        public virtual StaticServiceIpConnectivity StaticServiceIpConnectivity { get; set; }

        /// <summary>
        /// Required. The username that Database Migration Service will use to connect to the database. The value is
        /// encrypted when stored in Database Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Oracle as a source in a migration.</summary>
    public class OracleSourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use Binary Log Parser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryLogParser")]
        public virtual BinaryLogParser BinaryLogParser { get; set; }

        /// <summary>Optional. The schema change number (SCN) to start CDC data migration from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cdcStartPosition")]
        public virtual System.Nullable<long> CdcStartPosition { get; set; }

        /// <summary>Use LogMiner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logMiner")]
        public virtual LogMiner LogMiner { get; set; }

        /// <summary>
        /// Optional. Maximum number of connections Database Migration Service will open to the source for CDC phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConcurrentCdcConnections")]
        public virtual System.Nullable<int> MaxConcurrentCdcConnections { get; set; }

        /// <summary>
        /// Optional. Maximum number of connections Database Migration Service will open to the source for full dump
        /// phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConcurrentFullDumpConnections")]
        public virtual System.Nullable<int> MaxConcurrentFullDumpConnections { get; set; }

        /// <summary>Optional. Whether to skip full dump or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipFullDump")]
        public virtual System.Nullable<bool> SkipFullDump { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for heterogeneous **Oracle to Cloud SQL for PostgreSQL** and **Oracle to AlloyDB for PostgreSQL**
    /// migrations.
    /// </summary>
    public class OracleToPostgresConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration for Oracle source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleSourceConfig")]
        public virtual OracleSourceConfig OracleSourceConfig { get; set; }

        /// <summary>Optional. Configuration for Postgres destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postgresDestinationConfig")]
        public virtual PostgresDestinationConfig PostgresDestinationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Package's parent is a schema.</summary>
    public class PackageEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>
        /// The SQL code which creates the package body. If the package specification has cursors or subprograms, then
        /// the package body is mandatory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageBody")]
        public virtual string PackageBody { get; set; }

        /// <summary>The SQL code which creates the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageSqlCode")]
        public virtual string PackageSqlCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Performance configuration definition.</summary>
    public class PerformanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Initial dump parallelism level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dumpParallelLevel")]
        public virtual string DumpParallelLevel { get; set; }

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

    /// <summary>Issue position.</summary>
    public class Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Issue column number</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual System.Nullable<int> Column { get; set; }

        /// <summary>Issue length</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>Issue line number</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<int> Line { get; set; }

        /// <summary>Issue offset</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies connection parameters required specifically for PostgreSQL databases.</summary>
    public class PostgreSqlConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If the destination is an AlloyDB database, use this field to provide the AlloyDB cluster ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alloydbClusterId")]
        public virtual string AlloydbClusterId { get; set; }

        /// <summary>
        /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlId")]
        public virtual string CloudSqlId { get; set; }

        /// <summary>Optional. The name of the specific database within the host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Required. The IP or hostname of the source PostgreSQL database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Output only. If the source is a Cloud SQL database, this field indicates the network architecture it's
        /// associated with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkArchitecture")]
        public virtual string NetworkArchitecture { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Database Migration Service will be using to connect to
        /// the database. This field is not returned on request, and the value is encrypted when stored in Database
        /// Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Output only. Indicates If this connection profile password is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSet")]
        public virtual System.Nullable<bool> PasswordSet { get; set; }

        /// <summary>Required. The network port of the source PostgreSQL database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Private service connect connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateServiceConnectConnectivity")]
        public virtual PrivateServiceConnectConnectivity PrivateServiceConnectConnectivity { get; set; }

        /// <summary>SSL configuration for the destination to connect to the source database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssl")]
        public virtual SslConfig Ssl { get; set; }

        /// <summary>Static ip connectivity data (default, no additional details needed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIpConnectivity")]
        public virtual StaticIpConnectivity StaticIpConnectivity { get; set; }

        /// <summary>
        /// Required. The username that Database Migration Service will use to connect to the database. The value is
        /// encrypted when stored in Database Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Postgres as a destination in a migration.</summary>
    public class PostgresDestinationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Maximum number of connections Database Migration Service will open to the destination for data
        /// migration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConcurrentConnections")]
        public virtual System.Nullable<int> MaxConcurrentConnections { get; set; }

        /// <summary>Optional. Timeout for data migration transactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionTimeout")]
        public virtual object TransactionTimeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for the cluster's primary instance</summary>
    public class PrimaryInstanceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Database flags to pass to AlloyDB when DMS is creating the AlloyDB cluster and instances. See the AlloyDB
        /// documentation for how these can be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseFlags")]
        public virtual System.Collections.Generic.IDictionary<string, string> DatabaseFlags { get; set; }

        /// <summary>
        /// Required. The ID of the AlloyDB primary instance. The ID must satisfy the regex expression "[a-z0-9-]+".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Metadata related to instance level network configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNetworkConfig")]
        public virtual InstanceNetworkConfig InstanceNetworkConfig { get; set; }

        /// <summary>
        /// Labels for the AlloyDB primary instance created by DMS. An object containing a list of 'key', 'value' pairs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Configuration for the machines that host the underlying database engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineConfig")]
        public virtual MachineConfig MachineConfig { get; set; }

        /// <summary>Output only. All outbound public IP addresses configured for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outboundPublicIpAddresses")]
        public virtual System.Collections.Generic.IList<string> OutboundPublicIpAddresses { get; set; }

        /// <summary>
        /// Output only. The private IP address for the Instance. This is the connection endpoint for an end-user
        /// application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIp")]
        public virtual string PrivateIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The PrivateConnection resource is used to establish private connectivity with the customer's network.
    /// </summary>
    public class PrivateConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The create time of the resource.</summary>
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

        /// <summary>The private connection display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The error details in case of state FAILED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// The resource labels for private connections to use to annotate any related underlying resources such as
        /// Compute Engine VMs. An object containing a list of "key": "value" pairs. Example: `{ "name": "wrench",
        /// "mass": "1.3kg", "count": "3" }`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Zone Isolation compliance state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Zone Separation compliance state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The state of the private connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last update time of the resource.</summary>
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

        /// <summary>VPC peering configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcPeeringConfig")]
        public virtual VpcPeeringConfig VpcPeeringConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Private Connectivity.</summary>
    public class PrivateConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource name (URI) of the private connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnection")]
        public virtual string PrivateConnection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Private Service Connect
    /// connectivity](https://cloud.google.com/vpc/docs/private-service-connect#service-attachments)
    /// </summary>
    public class PrivateServiceConnectConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A service attachment that exposes a database, and has the following format:
        /// projects/{project}/regions/{region}/serviceAttachments/{service_attachment_name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachment")]
        public virtual string ServiceAttachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'PromoteMigrationJob' request.</summary>
    public class PromoteMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The object filter to apply to the migration job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsFilter")]
        public virtual MigrationJobObjectsConfig ObjectsFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'RestartMigrationJob' request.</summary>
    public class RestartMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The object filter to apply to the migration job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsFilter")]
        public virtual MigrationJobObjectsConfig ObjectsFilter { get; set; }

        /// <summary>Optional. If true, only failed objects will be restarted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restartFailedObjects")]
        public virtual System.Nullable<bool> RestartFailedObjects { get; set; }

        /// <summary>
        /// Optional. Restart the migration job without running prior configuration verification. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipValidation")]
        public virtual System.Nullable<bool> SkipValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'ResumeMigrationJob' request.</summary>
    public class ResumeMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Resume the migration job without running prior configuration verification. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipValidation")]
        public virtual System.Nullable<bool> SkipValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The details needed to configure a reverse SSH tunnel between the source and destination databases. These details
    /// will be used when calling the generateSshScript method (see
    /// https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs/generateSshScript)
    /// to produce the script that will help set up the reverse SSH tunnel, and to set up the VPC peering between the
    /// Cloud SQL private network and the VPC.
    /// </summary>
    public class ReverseSshConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vm")]
        public virtual string Vm { get; set; }

        /// <summary>
        /// Required. The IP of the virtual machine (Compute Engine) used as the bastion server for the SSH tunnel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmIp")]
        public virtual string VmIp { get; set; }

        /// <summary>
        /// Required. The forwarding port of the virtual machine (Compute Engine) used as the bastion server for the SSH
        /// tunnel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmPort")]
        public virtual System.Nullable<int> VmPort { get; set; }

        /// <summary>The name of the VPC to peer with the Cloud SQL private network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpc")]
        public virtual string Vpc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'RollbackConversionWorkspace' request.</summary>
    public class RollbackConversionWorkspaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This allows the data to change scale, for example if the source is 2 digits after the decimal point, specify
    /// round to scale value = 2. If for example the value needs to be converted to an integer, use round to scale value
    /// = 0.
    /// </summary>
    public class RoundToScale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Scale value to be used</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<int> Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a single rules file.</summary>
    public class RulesFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The text content of the rules that needs to be converted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesContent")]
        public virtual string RulesContent { get; set; }

        /// <summary>
        /// Required. The filename of the rules that needs to be converted. The filename is used mainly so that future
        /// logs of the import rules job contain it, and can therefore be searched by it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesSourceFilename")]
        public virtual string RulesSourceFilename { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Schema typically has no parent entity, but can have a parent entity DatabaseInstance (for database engines which
    /// support it). For some database engines, the terms schema and user can be used interchangeably when they refer to
    /// a namespace or a collection of other database entities. Can store additional information which is schema
    /// specific.
    /// </summary>
    public class SchemaEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'SearchBackgroundJobs' request.</summary>
    public class SearchBackgroundJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of conversion workspace mapping rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<BackgroundJobLogEntry> Jobs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'SeedConversionWorkspace' request.</summary>
    public class SeedConversionWorkspaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Should the conversion workspace be committed automatically after the seed operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCommit")]
        public virtual System.Nullable<bool> AutoCommit { get; set; }

        /// <summary>Optional. Fully qualified (Uri) name of the destination connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConnectionProfile")]
        public virtual string DestinationConnectionProfile { get; set; }

        /// <summary>Optional. Fully qualified (Uri) name of the source connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceConnectionProfile")]
        public virtual string SourceConnectionProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details regarding a Seed background job.</summary>
    public class SeedJobDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The connection profile which was used for the seed job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfile")]
        public virtual string ConnectionProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sequence's parent is a schema.</summary>
    public class SequenceEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates number of entries to cache / precreate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cache")]
        public virtual System.Nullable<long> Cache { get; set; }

        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Indicates whether the sequence value should cycle through.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycle")]
        public virtual System.Nullable<bool> Cycle { get; set; }

        /// <summary>Increment value for the sequence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("increment")]
        public virtual System.Nullable<long> Increment { get; set; }

        /// <summary>Maximum number for the sequence represented as bytes to accommodate large. numbers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual string MaxValue { get; set; }

        /// <summary>Minimum number for the sequence represented as bytes to accommodate large. numbers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual string MinValue { get; set; }

        /// <summary>Start number for the sequence represented as bytes to accommodate large. numbers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startValue")]
        public virtual string StartValue { get; set; }

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

    /// <summary>
    /// Options to configure rule type SetTablePrimaryKey. The rule is used to specify the columns and name to
    /// configure/alter the primary key of a table. The rule filter field can refer to one entity. The rule scope can be
    /// one of: Table.
    /// </summary>
    public class SetTablePrimaryKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name for the primary key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryKey")]
        public virtual string PrimaryKey { get; set; }

        /// <summary>Required. List of column names for the primary key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryKeyColumns")]
        public virtual System.Collections.Generic.IList<string> PrimaryKeyColumns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type SingleColumnChange. The rule is used to change the properties of a column. The
    /// rule filter field can refer to one entity. The rule scope can be one of: Column. When using this rule, if a
    /// field is not specified than the destination column's configuration will be the same as the one in the source
    /// column..
    /// </summary>
    public class SingleColumnChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Is the column of array type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("array")]
        public virtual System.Nullable<bool> Array { get; set; }

        /// <summary>Optional. The length of the array, only relevant if the column type is an array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayLength")]
        public virtual System.Nullable<int> ArrayLength { get; set; }

        /// <summary>Optional. Is the column auto-generated/identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoGenerated")]
        public virtual System.Nullable<bool> AutoGenerated { get; set; }

        /// <summary>Optional. Charset override - instead of table level charset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("charset")]
        public virtual string Charset { get; set; }

        /// <summary>Optional. Collation override - instead of table level collation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>Optional. Comment associated with the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Optional. Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Optional. Column data type name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// Optional. Column fractional seconds precision - e.g. 2 as in timestamp (2) - when relevant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fractionalSecondsPrecision")]
        public virtual System.Nullable<int> FractionalSecondsPrecision { get; set; }

        /// <summary>Optional. Column length - e.g. 50 as in varchar (50) - when relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>Optional. Is the column nullable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>Optional. Column precision - e.g. 8 as in double (8,2) - when relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<int> Precision { get; set; }

        /// <summary>Optional. Column scale - e.g. 2 as in double (8,2) - when relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<int> Scale { get; set; }

        /// <summary>Optional. Specifies the list of values allowed in the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setValues")]
        public virtual System.Collections.Generic.IList<string> SetValues { get; set; }

        /// <summary>Optional. Is the column a UDT (User-defined Type).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("udt")]
        public virtual System.Nullable<bool> Udt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type SingleEntityRename. The rule is used to rename an entity. The rule filter field
    /// can refer to only one entity. The rule scope can be one of: Database, Schema, Table, Column, Constraint, Index,
    /// View, Function, Stored Procedure, Materialized View, Sequence, UDT, Synonym
    /// </summary>
    public class SingleEntityRename : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new name of the destination entity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newName")]
        public virtual string NewName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type SinglePackageChange. The rule is used to alter the sql code for a package
    /// entities. The rule filter field can refer to one entity. The rule scope can be: Package
    /// </summary>
    public class SinglePackageChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Sql code for package body</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageBody")]
        public virtual string PackageBody { get; set; }

        /// <summary>Optional. Sql code for package description</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageDescription")]
        public virtual string PackageDescription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter for fixed point number data types such as NUMERIC/NUMBER</summary>
    public class SourceNumericFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Enum to set the option defining the datatypes numeric filter has to be applied to
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericFilterOption")]
        public virtual string NumericFilterOption { get; set; }

        /// <summary>
        /// Optional. The filter will match columns with precision smaller than or equal to this number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMaxPrecisionFilter")]
        public virtual System.Nullable<int> SourceMaxPrecisionFilter { get; set; }

        /// <summary>Optional. The filter will match columns with scale smaller than or equal to this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMaxScaleFilter")]
        public virtual System.Nullable<int> SourceMaxScaleFilter { get; set; }

        /// <summary>
        /// Optional. The filter will match columns with precision greater than or equal to this number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMinPrecisionFilter")]
        public virtual System.Nullable<int> SourceMinPrecisionFilter { get; set; }

        /// <summary>Optional. The filter will match columns with scale greater than or equal to this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMinScaleFilter")]
        public virtual System.Nullable<int> SourceMinScaleFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for a single migration job object.</summary>
    public class SourceObjectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The object identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectIdentifier")]
        public virtual SourceObjectIdentifier ObjectIdentifier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An identifier for the Migration Job Object.</summary>
    public class SourceObjectIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The database name. This will be required only if the object uses a database name as part of its
        /// unique identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Required. The type of the migration job object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of configurations for the source objects to be migrated.</summary>
    public class SourceObjectsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of the objects to be migrated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectConfigs")]
        public virtual System.Collections.Generic.IList<SourceObjectConfig> ObjectConfigs { get; set; }

        /// <summary>Optional. The objects selection type of the migration job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectsSelectionType")]
        public virtual string ObjectsSelectionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options to configure rule type SourceSqlChange. The rule is used to alter the sql code for database entities.
    /// The rule filter field can refer to one entity. The rule scope can be: StoredProcedure, Function, Trigger, View
    /// </summary>
    public class SourceSqlChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Sql code for source (stored procedure, function, trigger or view)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter for text-based data types like varchar.</summary>
    public class SourceTextFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The filter will match columns with length smaller than or equal to this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMaxLengthFilter")]
        public virtual System.Nullable<long> SourceMaxLengthFilter { get; set; }

        /// <summary>Optional. The filter will match columns with length greater than or equal to this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMinLengthFilter")]
        public virtual System.Nullable<long> SourceMinLengthFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An entry for an Access Control list.</summary>
    public class SqlAclEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// The time when this access control entry expires in [RFC 3339](https://tools.ietf.org/html/rfc3339) format,
        /// for example: `2012-11-15T16:19:00.094Z`.
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

        /// <summary>A label to identify this entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Input only. The time-to-leave of this access control entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The allowlisted value for the access control list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IP Management configuration.</summary>
    public class SqlIpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the allocated IP address range for the private IP Cloud SQL instance. This name refers
        /// to an already allocated IP range address. If set, the instance IP address will be created in the allocated
        /// range. Note that this IP address range can't be modified after the instance is created. If you change the
        /// VPC when configuring connectivity settings for the migration job, this field is not relevant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedIpRange")]
        public virtual string AllocatedIpRange { get; set; }

        /// <summary>
        /// The list of external networks that are allowed to connect to the instance using the IP. See
        /// https://en.wikipedia.org/wiki/CIDR_notation#CIDR_notation, also known as 'slash' notation (e.g.
        /// `192.168.100.0/24`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedNetworks")]
        public virtual System.Collections.Generic.IList<SqlAclEntry> AuthorizedNetworks { get; set; }

        /// <summary>Whether the instance should be assigned an IPv4 address or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIpv4")]
        public virtual System.Nullable<bool> EnableIpv4 { get; set; }

        /// <summary>
        /// The resource link for the VPC network from which the Cloud SQL instance is accessible for private IP. For
        /// example, `projects/myProject/global/networks/default`. This setting can be updated, but it cannot be removed
        /// after it is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateNetwork")]
        public virtual string PrivateNetwork { get; set; }

        /// <summary>Whether SSL connections over IP should be enforced or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireSsl")]
        public virtual System.Nullable<bool> RequireSsl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the backup details in Cloud Storage for homogeneous migration to Cloud SQL for SQL Server.
    /// </summary>
    public class SqlServerBackups : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Cloud Storage bucket that stores backups for all replicated databases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBucket")]
        public virtual string GcsBucket { get; set; }

        /// <summary>Optional. Cloud Storage path inside the bucket that stores backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPrefix")]
        public virtual string GcsPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies connection parameters required specifically for SQL Server databases.</summary>
    public class SqlServerConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The backup details in Cloud Storage for homogeneous migration to Cloud SQL for SQL Server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backups")]
        public virtual SqlServerBackups Backups { get; set; }

        /// <summary>
        /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlId")]
        public virtual string CloudSqlId { get; set; }

        /// <summary>Forward SSH tunnel connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardSshConnectivity")]
        public virtual ForwardSshTunnelConnectivity ForwardSshConnectivity { get; set; }

        /// <summary>Required. The IP or hostname of the source SQL Server database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Required. Input only. The password for the user that Database Migration Service will be using to connect to
        /// the database. This field is not returned on request, and the value is encrypted when stored in Database
        /// Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Output only. Indicates whether a new password is included in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSet")]
        public virtual System.Nullable<bool> PasswordSet { get; set; }

        /// <summary>Required. The network port of the source SQL Server database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Private connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnectivity")]
        public virtual PrivateConnectivity PrivateConnectivity { get; set; }

        /// <summary>Private Service Connect connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateServiceConnectConnectivity")]
        public virtual PrivateServiceConnectConnectivity PrivateServiceConnectConnectivity { get; set; }

        /// <summary>SSL configuration for the destination to connect to the source database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssl")]
        public virtual SslConfig Ssl { get; set; }

        /// <summary>Static IP connectivity data (default, no additional details needed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIpConnectivity")]
        public virtual StaticIpConnectivity StaticIpConnectivity { get; set; }

        /// <summary>
        /// Required. The username that Database Migration Service will use to connect to the database. The value is
        /// encrypted when stored in Database Migration Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the backup details for a single database in Cloud Storage for homogeneous migration to Cloud SQL for
    /// SQL Server.
    /// </summary>
    public class SqlServerDatabaseBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of a SQL Server database for which to define backup configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>
        /// Optional. Encryption settings for the database. Required if provided database backups are encrypted.
        /// Encryption settings include path to certificate, path to certificate private key, and key password.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionOptions")]
        public virtual SqlServerEncryptionOptions EncryptionOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encryption settings for the SQL Server database.</summary>
    public class SqlServerEncryptionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Path to the Certificate (.cer) in Cloud Storage, in the form `gs://bucketName/fileName`. The
        /// instance must have write permissions to the bucket and read access to the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certPath")]
        public virtual string CertPath { get; set; }

        /// <summary>Required. Input only. Password that encrypts the private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pvkPassword")]
        public virtual string PvkPassword { get; set; }

        /// <summary>
        /// Required. Path to the Certificate Private Key (.pvk) in Cloud Storage, in the form
        /// `gs://bucketName/fileName`. The instance must have write permissions to the bucket and read access to the
        /// file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pvkPath")]
        public virtual string PvkPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for homogeneous migration to Cloud SQL for SQL Server.</summary>
    public class SqlServerHomogeneousMigrationJobConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Pattern that describes the default backup naming strategy. The specified pattern should ensure
        /// lexicographical order of backups. The pattern must define one of the following capture group sets: Capture
        /// group set #1 yy/yyyy - year, 2 or 4 digits mm - month number, 1-12 dd - day of month, 1-31 hh - hour of day,
        /// 00-23 mi - minutes, 00-59 ss - seconds, 00-59 Example: For backup file TestDB_20230802_155400.trn, use
        /// pattern: (?.*)_backup_(?\d{4})(?\d{2})(?\d{2})_(?\d{2})(?\d{2})(?\d{2}).trn Capture group set #2 timestamp -
        /// unix timestamp Example: For backup file TestDB.1691448254.trn, use pattern: (?.*)\.(?\d*).trn or
        /// (?.*)\.(?\d*).trn
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupFilePattern")]
        public virtual string BackupFilePattern { get; set; }

        /// <summary>Required. Backup details per database in Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseBackups")]
        public virtual System.Collections.Generic.IList<SqlServerDatabaseBackup> DatabaseBackups { get; set; }

        /// <summary>Optional. Promote databases when ready.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promoteWhenReady")]
        public virtual System.Nullable<bool> PromoteWhenReady { get; set; }

        /// <summary>Optional. Enable differential backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useDiffBackup")]
        public virtual System.Nullable<bool> UseDiffBackup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'GenerateSshScript' request.</summary>
    public class SshScript : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ssh configuration script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SSL configuration information.</summary>
    public class SslConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Input only. The x509 PEM-encoded certificate of the CA that signed the source database server's
        /// certificate. The replica will use this certificate to verify it's connecting to the right host.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertificate")]
        public virtual string CaCertificate { get; set; }

        /// <summary>
        /// Input only. The x509 PEM-encoded certificate that will be used by the replica to authenticate against the
        /// source database server.If this field is used then the 'client_key' field is mandatory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>
        /// Input only. The unencrypted PKCS#1 or PKCS#8 PEM-encoded private key associated with the Client Certificate.
        /// If this field is used then the 'client_certificate' field is mandatory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>
        /// Optional. The ssl config type according to 'client_key', 'client_certificate' and 'ca_certificate'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'StartMigrationJob' request.</summary>
    public class StartMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Start the migration job without running prior configuration verification. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipValidation")]
        public virtual System.Nullable<bool> SkipValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The source database will allow incoming connections from the public IP of the destination database. You can
    /// retrieve the public IP of the Cloud SQL instance from the Cloud SQL console or using Cloud SQL APIs. No
    /// additional configuration is required.
    /// </summary>
    public class StaticIpConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Static IP address connectivity configured on service project.</summary>
    public class StaticServiceIpConnectivity : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for 'StopMigrationJob' request.</summary>
    public class StopMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stored procedure's parent is a schema.</summary>
    public class StoredProcedureEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The SQL code which creates the stored procedure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Synonym's parent is a schema.</summary>
    public class SynonymEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the entity for which the synonym is being created (the source).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceEntity")]
        public virtual string SourceEntity { get; set; }

        /// <summary>
        /// The type of the entity for which the synonym is being created (usually a table or a sequence).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Table's parent is a schema.</summary>
    public class TableEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Table columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<ColumnEntity> Columns { get; set; }

        /// <summary>Comment associated with the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Table constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual System.Collections.Generic.IList<ConstraintEntity> Constraints { get; set; }

        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Table indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indices")]
        public virtual System.Collections.Generic.IList<IndexEntity> Indices { get; set; }

        /// <summary>Table triggers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggers")]
        public virtual System.Collections.Generic.IList<TriggerEntity> Triggers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for 'GenerateTcpProxyScript' request.</summary>
    public class TcpProxyScript : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The TCP Proxy configuration script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

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

    /// <summary>Trigger is not used as an independent entity, it is retrieved as part of a Table entity.</summary>
    public class TriggerEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The SQL code which creates the trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>Indicates when the trigger fires, for example BEFORE STATEMENT, AFTER EACH ROW.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerType")]
        public virtual string TriggerType { get; set; }

        /// <summary>The DML, DDL, or database events that fire the trigger, for example INSERT, UPDATE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggeringEvents")]
        public virtual System.Collections.Generic.IList<string> TriggeringEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UDT's parent is a schema.</summary>
    public class UDTEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The SQL code which creates the udt body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("udtBody")]
        public virtual string UdtBody { get; set; }

        /// <summary>The SQL code which creates the udt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("udtSqlCode")]
        public virtual string UdtSqlCode { get; set; }

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

        /// <summary>Output only. Indicates if the initial_user.password field has been set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSet")]
        public virtual System.Nullable<bool> PasswordSet { get; set; }

        /// <summary>The database username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of values to filter by in ConditionalColumnSetValue</summary>
    public class ValueListFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Whether to ignore case when filtering by values. Defaults to false</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreCase")]
        public virtual System.Nullable<bool> IgnoreCase { get; set; }

        /// <summary>
        /// Required. Indicates whether the filter matches rows with values that are present in the list or those with
        /// values not present in it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuePresentList")]
        public virtual string ValuePresentList { get; set; }

        /// <summary>Required. The list to be used to filter by</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of data transformation during migration as part of the ConditionalColumnSetValue.</summary>
    public class ValueTransformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Applies a hash function on the data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyHash")]
        public virtual ApplyHash ApplyHash { get; set; }

        /// <summary>Optional. Set to max_value - if integer or numeric, will use int.maxvalue, etc</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignMaxValue")]
        public virtual Empty AssignMaxValue { get; set; }

        /// <summary>Optional. Set to min_value - if integer or numeric, will use int.minvalue, etc</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignMinValue")]
        public virtual Empty AssignMinValue { get; set; }

        /// <summary>Optional. Set to null</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignNull")]
        public virtual Empty AssignNull { get; set; }

        /// <summary>Optional. Set to a specific value (value is converted to fit the target data type)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignSpecificValue")]
        public virtual AssignSpecificValue AssignSpecificValue { get; set; }

        /// <summary>Optional. Filter on relation between source value and compare value of type double.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleComparison")]
        public virtual DoubleComparisonFilter DoubleComparison { get; set; }

        /// <summary>Optional. Filter on relation between source value and compare value of type integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intComparison")]
        public virtual IntComparisonFilter IntComparison { get; set; }

        /// <summary>Optional. Value is null</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isNull")]
        public virtual Empty IsNull { get; set; }

        /// <summary>Optional. Allows the data to change scale</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roundScale")]
        public virtual RoundToScale RoundScale { get; set; }

        /// <summary>Optional. Value is found in the specified list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueList")]
        public virtual ValueListFilter ValueList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'VerifyMigrationJob' request.</summary>
    public class VerifyMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The changed migration job parameters to verify. It will not update the migration job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationJob")]
        public virtual MigrationJob MigrationJob { get; set; }

        /// <summary>
        /// Optional. Field mask is used to specify the changed fields to be verified. It will not update the migration
        /// job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>View's parent is a schema.</summary>
    public class ViewEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>View constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual System.Collections.Generic.IList<ConstraintEntity> Constraints { get; set; }

        /// <summary>Custom engine specific features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The SQL code which creates the view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM creation configuration message</summary>
    public class VmCreationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The subnet name the vm needs to be created in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

        /// <summary>Required. VM instance machine type to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmMachineType")]
        public virtual string VmMachineType { get; set; }

        /// <summary>The Google Cloud Platform zone to create the VM in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmZone")]
        public virtual string VmZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM selection configuration message</summary>
    public class VmSelectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Google Cloud Platform zone the VM is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmZone")]
        public virtual string VmZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The VPC peering configuration is used to create VPC peering with the consumer's VPC.</summary>
    public class VpcPeeringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A free subnet for peering. (CIDR of /29)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

        /// <summary>Required. Fully qualified name of the VPC that Database Migration Service will peer to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcName")]
        public virtual string VpcName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The details of the VPC where the source database is located in Google Cloud. We will use this information to set
    /// up the VPC peering connection between Cloud SQL and this VPC.
    /// </summary>
    public class VpcPeeringConnectivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the VPC network to peer with the Cloud SQL private network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpc")]
        public virtual string Vpc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
