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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datamigration";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://datamigration.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://datamigration.googleapis.com/batch";

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
                /// <param name="parent">
                /// Required. The parent, which owns this collection of connection profiles.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.ConnectionProfile body, string parent)
                {
                    return new CreateRequest(service, body, parent);
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

                    /// <summary>Required. The parent, which owns this collection of connection profiles.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The connection profile identifier.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectionProfileId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectionProfileId { get; set; }

                    /// <summary>
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
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
                    return new DeleteRequest(service, name);
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
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
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
                    return new GetRequest(service, name);
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
                    return new GetIamPolicyRequest(service, resource);
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
                /// <param name="parent">
                /// Required. The parent, which owns this collection of connection profiles.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
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

                    /// <summary>Required. The parent, which owns this collection of connection profiles.</summary>
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
                    /// 1000; values above 1000 will be coerced to 1000.
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
                    return new PatchRequest(service, body, name);
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
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
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
                    /// Required. Field mask is used to specify the fields to be overwritten in the connection profile
                    /// resource by the update.
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
                    return new SetIamPolicyRequest(service, body, resource);
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
                    return new TestIamPermissionsRequest(service, body, resource);
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
                        return new ImportRequest(service, body, parent);
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
                }

                /// <summary>Apply draft tree onto a specific destination database</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the conversion workspace resource to apply draft to destination for. in the form
                /// of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual ApplyRequest Apply(Google.Apis.DatabaseMigrationService.v1.Data.ApplyConversionWorkspaceRequest body, string name)
                {
                    return new ApplyRequest(service, body, name);
                }

                /// <summary>Apply draft tree onto a specific destination database</summary>
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
                    /// Required. Name of the conversion workspace resource to apply draft to destination for. in the
                    /// form of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
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
                    return new CommitRequest(service, body, name);
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
                    return new ConvertRequest(service, body, name);
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
                /// Required. The parent, which owns this collection of conversion workspaces.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.ConversionWorkspace body, string parent)
                {
                    return new CreateRequest(service, body, parent);
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

                    /// <summary>Required. The parent, which owns this collection of conversion workspaces.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID of the conversion workspace to create.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspaceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConversionWorkspaceId { get; set; }

                    /// <summary>
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
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
                    return new DeleteRequest(service, name);
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
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
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
                /// Required. Name of the conversion workspace resource whose revisions are listed. in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual DescribeConversionWorkspaceRevisionsRequest DescribeConversionWorkspaceRevisions(string conversionWorkspace)
                {
                    return new DescribeConversionWorkspaceRevisionsRequest(service, conversionWorkspace);
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
                    /// Required. Name of the conversion workspace resource whose revisions are listed. in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspace", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ConversionWorkspace { get; private set; }

                    /// <summary>Optional. Optional filter to request a specific commit id</summary>
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
                /// Use this method to describe the database entities tree for a specific conversion workspace and a
                /// specific tree type. The DB Entities are not a resource like conversion workspace or mapping rule,
                /// and they can not be created, updated or deleted like one. Instead they are simple data objects
                /// describing the structure of the client database.
                /// </summary>
                /// <param name="conversionWorkspace">
                /// Required. Name of the conversion workspace resource whose DB entities are described in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual DescribeDatabaseEntitiesRequest DescribeDatabaseEntities(string conversionWorkspace)
                {
                    return new DescribeDatabaseEntitiesRequest(service, conversionWorkspace);
                }

                /// <summary>
                /// Use this method to describe the database entities tree for a specific conversion workspace and a
                /// specific tree type. The DB Entities are not a resource like conversion workspace or mapping rule,
                /// and they can not be created, updated or deleted like one. Instead they are simple data objects
                /// describing the structure of the client database.
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
                    /// Required. Name of the conversion workspace resource whose DB entities are described in the form
                    /// of: projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspace", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ConversionWorkspace { get; private set; }

                    /// <summary>
                    /// Request a specific commit id. If not specified, the entities from the latest commit are
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("commitId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CommitId { get; set; }

                    /// <summary>Filter the returned entities based on AIP-160 standard</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of entities to return. The service may return fewer than this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The nextPageToken value received in the previous call to
                    /// conversionWorkspace.describeDatabaseEntities, used in the subsequent request to retrieve the
                    /// next page of results. On first call this should be left blank. When paginating, all other
                    /// parameters provided to conversionWorkspace.describeDatabaseEntities must match the call that
                    /// provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>The tree to fetch</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tree", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TreeEnum> Tree { get; set; }

                    /// <summary>The tree to fetch</summary>
                    public enum TreeEnum
                    {
                        /// <summary>Unspecified tree type</summary>
                        [Google.Apis.Util.StringValueAttribute("DB_TREE_TYPE_UNSPECIFIED")]
                        DBTREETYPEUNSPECIFIED = 0,

                        /// <summary>The source database tree</summary>
                        [Google.Apis.Util.StringValueAttribute("SOURCE_TREE")]
                        SOURCETREE = 1,

                        /// <summary>The draft database tree</summary>
                        [Google.Apis.Util.StringValueAttribute("DRAFT_TREE")]
                        DRAFTTREE = 2,

                        /// <summary>The destination database tree</summary>
                        [Google.Apis.Util.StringValueAttribute("DESTINATION_TREE")]
                        DESTINATIONTREE = 3,
                    }

                    /// <summary>
                    /// Whether to retrieve the latest committed version of the entities or the latest version. This
                    /// field is ignored if a specific commit_id is specified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("uncommitted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Uncommitted { get; set; }

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
                    }
                }

                /// <summary>Gets details of a single conversion workspace.</summary>
                /// <param name="name">Required. Name of the conversion workspace resource to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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

                /// <summary>Lists conversion workspaces in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of conversion workspaces.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
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

                    /// <summary>Required. The parent, which owns this collection of conversion workspaces.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that filters conversion workspaces listed in the response. The expression
                    /// must specify the field name, a comparison operator, and the value that you want to use for
                    /// filtering. The value must be a string, a number, or a boolean. The comparison operator must be
                    /// either =, !=, &amp;gt;, or &amp;lt;. For example, list conversion workspaces created this year
                    /// by specifying **createTime %gt; 2020-01-01T00:00:00.000000000Z.** You can also filter nested
                    /// fields. For example, you could specify **source.version = "12.c.1"** to select all conversion
                    /// workspaces with source database version equal to 12.c.1
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of conversion workspaces to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 sets will be returned.
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
                    return new PatchRequest(service, body, name);
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
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the conversion workspace
                    /// resource by the update.
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

                /// <summary>Rollbacks a conversion workspace to the last committed spanshot.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the conversion workspace resource to rollback to.</param>
                public virtual RollbackRequest Rollback(Google.Apis.DatabaseMigrationService.v1.Data.RollbackConversionWorkspaceRequest body, string name)
                {
                    return new RollbackRequest(service, body, name);
                }

                /// <summary>Rollbacks a conversion workspace to the last committed spanshot.</summary>
                public class RollbackRequest : DatabaseMigrationServiceBaseServiceRequest<Google.Apis.DatabaseMigrationService.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Rollback request.</summary>
                    public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseMigrationService.v1.Data.RollbackConversionWorkspaceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the conversion workspace resource to rollback to.</summary>
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
                /// Use this method to search/list the background jobs for a specific conversion workspace. The
                /// background jobs are not a resource like conversion workspace or mapping rule, and they can not be
                /// created, updated or deleted like one. Instead they are a way to expose the data plane jobs log.
                /// </summary>
                /// <param name="conversionWorkspace">
                /// Required. Name of the conversion workspace resource whos jobs are listed. in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual SearchBackgroundJobsRequest SearchBackgroundJobs(string conversionWorkspace)
                {
                    return new SearchBackgroundJobsRequest(service, conversionWorkspace);
                }

                /// <summary>
                /// Use this method to search/list the background jobs for a specific conversion workspace. The
                /// background jobs are not a resource like conversion workspace or mapping rule, and they can not be
                /// created, updated or deleted like one. Instead they are a way to expose the data plane jobs log.
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
                    /// Required. Name of the conversion workspace resource whos jobs are listed. in the form of:
                    /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("conversionWorkspace", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ConversionWorkspace { get; private set; }

                    /// <summary>
                    /// Optional. If supplied, will only return jobs that completed until (not including) the given
                    /// timestamp.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("completedUntilTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CompletedUntilTime { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of jobs to return. The service may return fewer than this value. If
                    /// unspecified, at most 100 jobs will be returned. The maximum value is 100; values above 100 will
                    /// be coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("maxSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> MaxSize { get; set; }

                    /// <summary>Optional. Whether or not to return just the most recent job per job type</summary>
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
                /// Name of the conversion workspace resource to seed with new database structure. in the form of:
                /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
                /// </param>
                public virtual SeedRequest Seed(Google.Apis.DatabaseMigrationService.v1.Data.SeedConversionWorkspaceRequest body, string name)
                {
                    return new SeedRequest(service, body, name);
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
                    /// Name of the conversion workspace resource to seed with new database structure. in the form of:
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
                }

                /// <summary>Creates a new migration job in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent, which owns this collection of migration jobs.</param>
                public virtual CreateRequest Create(Google.Apis.DatabaseMigrationService.v1.Data.MigrationJob body, string parent)
                {
                    return new CreateRequest(service, body, parent);
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

                    /// <summary>Required. The parent, which owns this collection of migration jobs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID of the instance to create.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("migrationJobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string MigrationJobId { get; set; }

                    /// <summary>
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
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
                    return new DeleteRequest(service, name);
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
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
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

                /// <summary>Generate a SSH configuration script to configure the reverse SSH connectivity.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="migrationJob">Name of the migration job resource to generate the SSH script.</param>
                public virtual GenerateSshScriptRequest GenerateSshScript(Google.Apis.DatabaseMigrationService.v1.Data.GenerateSshScriptRequest body, string migrationJob)
                {
                    return new GenerateSshScriptRequest(service, body, migrationJob);
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

                /// <summary>Gets details of a single migration job.</summary>
                /// <param name="name">Required. Name of the migration job resource to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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
                    return new GetIamPolicyRequest(service, resource);
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
                /// <param name="parent">Required. The parent, which owns this collection of migrationJobs.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
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

                    /// <summary>Required. The parent, which owns this collection of migrationJobs.</summary>
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
                    /// 1000 will be coerced to 1000.
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
                    return new PatchRequest(service, body, name);
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
                    /// A unique id used to identify the request. If the server receives two requests with the same id,
                    /// then the second request will be ignored. It is recommended to always set this value to a UUID.
                    /// The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).
                    /// The maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the migration job
                    /// resource by the update.
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
                    return new PromoteRequest(service, body, name);
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
                    return new RestartRequest(service, body, name);
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
                    return new ResumeRequest(service, body, name);
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
                    return new SetIamPolicyRequest(service, body, resource);
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
                    return new StartRequest(service, body, name);
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
                    return new StopRequest(service, body, name);
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
                    return new TestIamPermissionsRequest(service, body, resource);
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
                    return new VerifyRequest(service, body, name);
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
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.DatabaseMigrationService.v1.Data.CancelOperationRequest body, string name)
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
                    return new DeleteRequest(service, name);
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
                    return new GetRequest(service, name);
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
                    return new CreateRequest(service, body, parent);
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
                    /// Optional. A unique id used to identify the request. If the server receives two requests with the
                    /// same id, then the second request will be ignored. It is recommended to always set this value to
                    /// a UUID. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens
                    /// (-). The maximum length is 40 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                    }
                }

                /// <summary>Deletes a single Database Migration Service private connection.</summary>
                /// <param name="name">Required. The name of the private connection to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
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
                    /// Optional. A unique id used to identify the request. If the server receives two requests with the
                    /// same id, then the second request will be ignored. It is recommended to always set this value to
                    /// a UUID. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens
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
                    return new GetRequest(service, name);
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

                /// <summary>Retrieves a list of private connections in a given project and location.</summary>
                /// <param name="parent">Required. The parent that owns the collection of private connections.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
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
                    /// that will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                return new ListRequest(service, name);
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
        /// <summary>Fully qualified (Uri) name of the destination connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfile")]
        public virtual string ConnectionProfile { get; set; }

        /// <summary>
        /// Filter which entities to apply. Leaving this field empty will apply all of the entities. Supports Google AIP
        /// 160 based filtering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

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

    /// <summary>Execution log of a background job.</summary>
    public class BackgroundJobLogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Job completion comment, such as how many entities were seeded, how many warnings were found during
        /// conversion and similar information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionComment")]
        public virtual string CompletionComment { get; set; }

        /// <summary>Job completion state, i.e. the final state after the job completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionState")]
        public virtual string CompletionState { get; set; }

        /// <summary>The timestamp when the background job was finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>The background job log entry id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Import rules job details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importRulesJobDetails")]
        public virtual ImportRulesJobDetails ImportRulesJobDetails { get; set; }

        /// <summary>The type of job that was executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>
        /// Whether the client requested the conversion workspace to be committed after a successful completion of the
        /// job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAutocommit")]
        public virtual System.Nullable<bool> RequestAutocommit { get; set; }

        /// <summary>Seed job details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seedJobDetails")]
        public virtual SeedJobDetails SeedJobDetails { get; set; }

        /// <summary>The timestamp when the background job was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

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
        /// represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
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
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
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

        /// <summary>The database engine type and version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

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
        /// <summary>Is the column of array type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("array")]
        public virtual System.Nullable<bool> Array { get; set; }

        /// <summary>If the column is array, of which length</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayLength")]
        public virtual System.Nullable<int> ArrayLength { get; set; }

        /// <summary>Is the column auto-generated/identity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoGenerated")]
        public virtual System.Nullable<bool> AutoGenerated { get; set; }

        /// <summary>Charset override - instead of table level charset</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("charset")]
        public virtual string Charset { get; set; }

        /// <summary>Collation override - instead of table level collation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collation")]
        public virtual string Collation { get; set; }

        /// <summary>Comment associated with the column</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Column data type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Default value of the column</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; }

        /// <summary>Column fractional second precision - used for timestamp based datatypes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fractionalSecondsPrecision")]
        public virtual System.Nullable<int> FractionalSecondsPrecision { get; set; }

        /// <summary>Column length - e.g. varchar (50)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>Column name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Is the column nullable</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>Column order in the table</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ordinalPosition")]
        public virtual System.Nullable<int> OrdinalPosition { get; set; }

        /// <summary>Column precision - when relevant</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precision")]
        public virtual System.Nullable<int> Precision { get; set; }

        /// <summary>Column scale - when relevant</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<int> Scale { get; set; }

        /// <summary>
        /// Specifies the list of values allowed in the column. List is empty if set values is not required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setValues")]
        public virtual System.Collections.Generic.IList<string> SetValues { get; set; }

        /// <summary>Is the column a UDT</summary>
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

    /// <summary>A connection profile definition.</summary>
    public class ConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An AlloyDB cluster connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alloydb")]
        public virtual AlloyDbConnectionProfile Alloydb { get; set; }

        /// <summary>A CloudSQL database connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudsql")]
        public virtual CloudSqlConnectionProfile Cloudsql { get; set; }

        /// <summary>
        /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC "Zulu" format, accurate
        /// to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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

        /// <summary>The current connection profile state (e.g. DRAFT, READY, or FAILED).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. A timestamp in RFC3339 UTC "Zulu" format,
        /// accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Constraint is not used as an independent entity, it is retrieved as part of another entity such as Table or
    /// View.
    /// </summary>
    public class ConstraintEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the table constraint</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Reference Columns which may be associated with the constraint. eg: if the constraint is a FOREIGN_KEY, this
        /// represents the list of full names of referenced columns by the foreign key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceColumns")]
        public virtual System.Collections.Generic.IList<string> ReferenceColumns { get; set; }

        /// <summary>
        /// Reference table which may be associated with the constraint. eg: if the constraint is a FOREIGN_KEY, this
        /// represents the list of full name of the referenced table by the foreign key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceTable")]
        public virtual string ReferenceTable { get; set; }

        /// <summary>
        /// Table columns used as part of the Constraint for e.g. primary key constraint should list the columns which
        /// constitutes the key
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
        /// Type of constraint - e.g. unique, primary key, foreign key (currently only primary key is supported)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The main conversion workspace resource entity.</summary>
    public class ConversionWorkspace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The timestamp when the workspace resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. The destination engine details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual DatabaseEngineInfo Destination { get; set; }

        /// <summary>The display name for the workspace</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// A generic list of settings for the workspace. The settings are database pair dependant and can indicate
        /// default behavior for the mapping rules engine or turn on or off specific features. Such examples can be:
        /// convert_foreign_key_to_interleave=true, skip_triggers=false, ignore_non_table_synonyms=true
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalSettings")]
        public virtual System.Collections.Generic.IDictionary<string, string> GlobalSettings { get; set; }

        /// <summary>
        /// Output only. Whether the workspace has uncommitted changes (changes which were made after the workspace was
        /// committed)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasUncommittedChanges")]
        public virtual System.Nullable<bool> HasUncommittedChanges { get; set; }

        /// <summary>Output only. The latest commit id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCommitId")]
        public virtual string LatestCommitId { get; set; }

        /// <summary>Output only. The timestamp when the workspace was committed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCommitTime")]
        public virtual object LatestCommitTime { get; set; }

        /// <summary>
        /// Full name of the workspace resource, in the form of:
        /// projects/{project}/locations/{location}/conversionWorkspaces/{conversion_workspace}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The source engine details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual DatabaseEngineInfo Source { get; set; }

        /// <summary>Output only. The timestamp when the workspace resource was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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
        /// <summary>Should the conversion workspace be committed automatically after the conversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCommit")]
        public virtual System.Nullable<bool> AutoCommit { get; set; }

        /// <summary>
        /// Filter the entities to convert. Leaving this field empty will convert all of the entities. Supports Google
        /// AIP-160 style filtering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The type and version of a source or destination DB.</summary>
    public class DatabaseEngineInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Engine Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>Required. Engine named version, for e.g. 12.c.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The base entity type for all the database related entities The message contains the entity name, the name of its
    /// parent, its type and the specific details per its type
    /// </summary>
    public class DatabaseEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Function</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseFunction")]
        public virtual FunctionEntity DatabaseFunction { get; set; }

        /// <summary>Package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databasePackage")]
        public virtual PackageEntity DatabasePackage { get; set; }

        /// <summary>The type of the database entity (table, view, index, ...).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>
        /// Details about entity mappings. For source tree entities, this holds the draft entities which were generated
        /// by the mapping rules. For draft tree entities, this holds the source entities which were converted to form
        /// the draft entity. Destination entities will have no mapping details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappings")]
        public virtual System.Collections.Generic.IList<EntityMapping> Mappings { get; set; }

        /// <summary>The full name of the parent entity (e.g. schema name).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentEntity")]
        public virtual string ParentEntity { get; set; }

        /// <summary>Schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual SchemaEntity Schema { get; set; }

        /// <summary>Sequence</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequence")]
        public virtual SequenceEntity Sequence { get; set; }

        /// <summary>The short name (e.g. table name) of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>Stored Procedure</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storedProcedure")]
        public virtual StoredProcedureEntity StoredProcedure { get; set; }

        /// <summary>Synonym</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonym")]
        public virtual SynonymEntity Synonym { get; set; }

        /// <summary>Table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual TableEntity Table { get; set; }

        /// <summary>The type of tree the entity belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tree")]
        public virtual string Tree { get; set; }

        /// <summary>View</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual ViewEntity View { get; set; }

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
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Details of the mappings of a database entity.</summary>
    public class EntityMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Target entity full name. The draft entity can also include a column, index or constraint using the same
        /// naming notation schema.table.column
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("draftEntity")]
        public virtual string DraftEntity { get; set; }

        /// <summary>
        /// Entity mapping log entries. Multiple rules can be effective and contribute changes to a converted entity
        /// such as, a rule can handle the entity name, another rule can handle an entity type. In addition, rules which
        /// did not change the entity are also logged along the with the reason preventing them to do so.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappingLog")]
        public virtual System.Collections.Generic.IList<EntityMappingLogEntry> MappingLog { get; set; }

        /// <summary>
        /// Source entity full name. The source entity can also be a column, index or constraint using the same naming
        /// notation schema.table.column
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceEntity")]
        public virtual string SourceEntity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single record of a rule which was used for a mapping.</summary>
    public class EntityMappingLogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappingComment")]
        public virtual string MappingComment { get; set; }

        /// <summary>Which rule caused it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>Rule revision id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleRevisionId")]
        public virtual string RuleRevisionId { get; set; }

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
        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The SQL code which creates the function</summary>
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

        /// <summary>The port that will be open on the bastion host</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmPort")]
        public virtual System.Nullable<int> VmPort { get; set; }

        /// <summary>The VM selection configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmSelectionConfig")]
        public virtual VmSelectionConfig VmSelectionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudClouddmsV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

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

    /// <summary>Request message for 'ImportMappingRules' request.</summary>
    public class ImportMappingRulesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Should the conversion workspace be committed automatically after the import operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCommit")]
        public virtual System.Nullable<bool> AutoCommit { get; set; }

        /// <summary>One or more rules files</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesFiles")]
        public virtual System.Collections.Generic.IList<RulesFile> RulesFiles { get; set; }

        /// <summary>The format of the rules content file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesFormat")]
        public virtual string RulesFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details regarding an Import Rules background job</summary>
    public class ImportRulesJobDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The requested file format</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileFormat")]
        public virtual string FileFormat { get; set; }

        /// <summary>File names used for the import rules job</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<string> Files { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Index is not used as an independent entity, it is retrieved as part of a Table entity.</summary>
    public class IndexEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the index</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Table columns used as part of the Index for e.g. B-TREE index should list the columns which constitutes the
        /// index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableColumns")]
        public virtual System.Collections.Generic.IList<string> TableColumns { get; set; }

        /// <summary>Type of index - e.g. B-TREE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>boolean value indicating whether the index is unique</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unique")]
        public virtual System.Nullable<bool> Unique { get; set; }

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
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
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
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
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

    /// <summary>Response message for 'ListMigrationJobs' request.</summary>
    public class ListMigrationJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of migration jobs objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrationJobs")]
        public virtual System.Collections.Generic.IList<MigrationJob> MigrationJobs { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
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
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
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

    /// <summary>MachineConfig describes the configuration of a machine.</summary>
    public class MachineConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of CPU's in the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCount")]
        public virtual System.Nullable<int> CpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Database Migration Service migration job object.</summary>
    public class MigrationJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conversion workspace used by the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionWorkspace")]
        public virtual ConversionWorkspaceInfo ConversionWorkspace { get; set; }

        /// <summary>
        /// Output only. The timestamp when the migration job resource was created. A timestamp in RFC3339 UTC "Zulu"
        /// format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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
        /// Output only. The duration of the migration job (in seconds). A duration in seconds with up to nine
        /// fractional digits, terminated by 's'. Example: "3.5s".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Output only. If the migration job is completed, the time when it was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

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

        /// <summary>Output only. The current migration job phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>The details needed to communicate to the source over Reverse SSH tunnel connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reverseSshConnectivity")]
        public virtual ReverseSshConnectivity ReverseSshConnectivity { get; set; }

        /// <summary>Required. The resource name (URI) of the source connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The database engine type and provider of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceDatabase")]
        public virtual DatabaseType SourceDatabase { get; set; }

        /// <summary>The current migration job state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>static ip connectivity data (default, no additional details needed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIpConnectivity")]
        public virtual StaticIpConnectivity StaticIpConnectivity { get; set; }

        /// <summary>Required. The migration job type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Output only. The timestamp when the migration job resource was last updated. A timestamp in RFC3339 UTC
        /// "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The details of the VPC network that the source database is located in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcPeeringConnectivity")]
        public virtual VpcPeeringConnectivity VpcPeeringConnectivity { get; set; }

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

    /// <summary>Package's parent is a schema.</summary>
    public class PackageEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>
        /// The SQL code which creates the package body. If the package specification has cursors or subprograms, then
        /// the package body is mandatory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageBody")]
        public virtual string PackageBody { get; set; }

        /// <summary>The SQL code which creates the package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageSqlCode")]
        public virtual string PackageSqlCode { get; set; }

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
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
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

    /// <summary>Specifies connection parameters required specifically for PostgreSQL databases.</summary>
    public class PostgreSqlConnectionProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlId")]
        public virtual string CloudSqlId { get; set; }

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

        /// <summary>
        /// Labels for the AlloyDB primary instance created by DMS. An object containing a list of 'key', 'value' pairs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Configuration for the machines that host the underlying database engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineConfig")]
        public virtual MachineConfig MachineConfig { get; set; }

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
        /// <summary>Output only. The create time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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

        /// <summary>The resource's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the Private Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The last update time of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>VPC Peering Config.</summary>
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
    /// Private Service Connect connectivity
    /// (https://cloud.google.com/vpc/docs/private-service-connect#benefits-services)
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
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'RestartMigrationJob' request.</summary>
    public class RestartMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'ResumeMigrationJob' request.</summary>
    public class ResumeMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Details of a single rules file</summary>
    public class RulesFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text content of the rules that needs to be converted</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesContent")]
        public virtual string RulesContent { get; set; }

        /// <summary>
        /// The filename of the rules that needs to be converted. This is used mainly so future logs of the import rules
        /// job will contain this detail and can therefore be searched by it later
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesSourceFilename")]
        public virtual string RulesSourceFilename { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Schema typically has no parent entity, but can have a parent entity DatabaseInstance (for database engines which
    /// supports it). For some database engines the term schema and user can be used interchangeably when they refer to
    /// a namespace or a collection of other database entities. Can store additional information which is schema
    /// specific.
    /// </summary>
    public class SchemaEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features</summary>
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

        /// <summary>Fully qualified (Uri) name of the destination connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConnectionProfile")]
        public virtual string DestinationConnectionProfile { get; set; }

        /// <summary>Fully qualified (Uri) name of the source connection profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceConnectionProfile")]
        public virtual string SourceConnectionProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details regarding a Seed background job</summary>
    public class SeedJobDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The connection profile which was used for the seed job</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionProfile")]
        public virtual string ConnectionProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sequence's parent is a schema.</summary>
    public class SequenceEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates number of entries to cache / precreate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cache")]
        public virtual System.Nullable<long> Cache { get; set; }

        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Indicates whether the sequence value should cycle through</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycle")]
        public virtual System.Nullable<bool> Cycle { get; set; }

        /// <summary>Increment value for the sequence</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("increment")]
        public virtual System.Nullable<long> Increment { get; set; }

        /// <summary>Maximum number for the sequence represented as bytes to accommodate large numbers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual string MaxValue { get; set; }

        /// <summary>Minimum number for the sequence represented as bytes to accommodate large numbers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual string MinValue { get; set; }

        /// <summary>Start number for the sequence represented as bytes to accommodate large numbers</summary>
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

    /// <summary>An entry for an Access Control list.</summary>
    public class SqlAclEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when this access control entry expires in [RFC 3339](https://tools.ietf.org/html/rfc3339) format,
        /// for example: `2012-11-15T16:19:00.094Z`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

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
        /// Output only. The ssl config type according to 'client_key', 'client_certificate' and 'ca_certificate'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'StartMigrationJob' request.</summary>
    public class StartMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The source database will allow incoming connections from the destination database's public IP. You can retrieve
    /// the Cloud SQL instance's public IP from the Cloud SQL console or using Cloud SQL APIs. No additional
    /// configuration is required.
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
        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The SQL code which creates the stored procedure</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Synonym's parent is a schema.</summary>
    public class SynonymEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the entity for which the synonym is being created (the source)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceEntity")]
        public virtual string SourceEntity { get; set; }

        /// <summary>
        /// The type of the entity for which the synonym is being created (usually a table or a sequence)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Table's parent is a schema.</summary>
    public class TableEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Table Columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<ColumnEntity> Columns { get; set; }

        /// <summary>Comment associated with the table</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Table Constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual System.Collections.Generic.IList<ConstraintEntity> Constraints { get; set; }

        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>Table Indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indices")]
        public virtual System.Collections.Generic.IList<IndexEntity> Indices { get; set; }

        /// <summary>Table triggers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggers")]
        public virtual System.Collections.Generic.IList<TriggerEntity> Triggers { get; set; }

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
        /// <summary>Custom engine specific features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFeatures")]
        public virtual System.Collections.Generic.IDictionary<string, object> CustomFeatures { get; set; }

        /// <summary>The name of the trigger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The SQL code which creates the trigger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlCode")]
        public virtual string SqlCode { get; set; }

        /// <summary>Indicates when the trigger fires, e.g. BEFORE STATEMENT, AFTER EACH ROW</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerType")]
        public virtual string TriggerType { get; set; }

        /// <summary>The DML, DDL, or database events that fires the trigger, e.g. INSERT, UPDATE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggeringEvents")]
        public virtual System.Collections.Generic.IList<string> TriggeringEvents { get; set; }

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

    /// <summary>Request message for 'VerifyMigrationJob' request.</summary>
    public class VerifyMigrationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>View's parent is a schema.</summary>
    public class ViewEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>View Constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraints")]
        public virtual System.Collections.Generic.IList<ConstraintEntity> Constraints { get; set; }

        /// <summary>Custom engine specific features</summary>
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

    /// <summary>The VPC Peering configuration is used to create VPC peering with the consumer's VPC.</summary>
    public class VpcPeeringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A free subnet for peering. (CIDR of /29)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

        /// <summary>Required. Fully qualified name of the VPC DMS will peer to.</summary>
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
