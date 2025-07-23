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

namespace Google.Apis.Iam.v1
{
    /// <summary>The Iam Service.</summary>
    public class IamService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public IamService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public IamService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            IamPolicies = new IamPoliciesResource(this);
            Locations = new LocationsResource(this);
            Organizations = new OrganizationsResource(this);
            Permissions = new PermissionsResource(this);
            Projects = new ProjectsResource(this);
            Roles = new RolesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://iam.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://iam.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "iam";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Identity and Access Management (IAM) API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Identity and Access Management (IAM) API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the IamPolicies resource.</summary>
        public virtual IamPoliciesResource IamPolicies { get; }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Roles resource.</summary>
        public virtual RolesResource Roles { get; }
    }

    /// <summary>A base abstract class for Iam requests.</summary>
    public abstract class IamBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new IamBaseServiceRequest instance.</summary>
        protected IamBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Iam parameter list.</summary>
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

    /// <summary>The "iamPolicies" collection of methods.</summary>
    public class IamPoliciesResource
    {
        private const string Resource = "iamPolicies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public IamPoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Lints, or validates, an IAM policy. Currently checks the google.iam.v1.Binding.condition field, which
        /// contains a condition expression for a role binding. Successful calls to this method always return an HTTP
        /// `200 OK` status code, even if the linter detects an issue in the IAM policy.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual LintPolicyRequest LintPolicy(Google.Apis.Iam.v1.Data.LintPolicyRequest body)
        {
            return new LintPolicyRequest(this.service, body);
        }

        /// <summary>
        /// Lints, or validates, an IAM policy. Currently checks the google.iam.v1.Binding.condition field, which
        /// contains a condition expression for a role binding. Successful calls to this method always return an HTTP
        /// `200 OK` status code, even if the linter detects an issue in the IAM policy.
        /// </summary>
        public class LintPolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.LintPolicyResponse>
        {
            /// <summary>Constructs a new LintPolicy request.</summary>
            public LintPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.LintPolicyRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Iam.v1.Data.LintPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lintPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/iamPolicies:lintPolicy";

            /// <summary>Initializes LintPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Returns a list of services that allow you to opt into audit logs that are not generated by default. To learn
        /// more about audit logs, see the [Logging documentation](https://cloud.google.com/logging/docs/audit).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryAuditableServicesRequest QueryAuditableServices(Google.Apis.Iam.v1.Data.QueryAuditableServicesRequest body)
        {
            return new QueryAuditableServicesRequest(this.service, body);
        }

        /// <summary>
        /// Returns a list of services that allow you to opt into audit logs that are not generated by default. To learn
        /// more about audit logs, see the [Logging documentation](https://cloud.google.com/logging/docs/audit).
        /// </summary>
        public class QueryAuditableServicesRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.QueryAuditableServicesResponse>
        {
            /// <summary>Constructs a new QueryAuditableServices request.</summary>
            public QueryAuditableServicesRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.QueryAuditableServicesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Iam.v1.Data.QueryAuditableServicesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryAuditableServices";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/iamPolicies:queryAuditableServices";

            /// <summary>Initializes QueryAuditableServices parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

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
            WorkforcePools = new WorkforcePoolsResource(service);
        }

        /// <summary>Gets the WorkforcePools resource.</summary>
        public virtual WorkforcePoolsResource WorkforcePools { get; }

        /// <summary>The "workforcePools" collection of methods.</summary>
        public class WorkforcePoolsResource
        {
            private const string Resource = "workforcePools";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WorkforcePoolsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Operations = new OperationsResource(service);
                Providers = new ProvidersResource(service);
                Subjects = new SubjectsResource(service);
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
                public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+/operations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Providers resource.</summary>
            public virtual ProvidersResource Providers { get; }

            /// <summary>The "providers" collection of methods.</summary>
            public class ProvidersResource
            {
                private const string Resource = "providers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ProvidersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Keys = new KeysResource(service);
                    Operations = new OperationsResource(service);
                    ScimTenants = new ScimTenantsResource(service);
                }

                /// <summary>Gets the Keys resource.</summary>
                public virtual KeysResource Keys { get; }

                /// <summary>The "keys" collection of methods.</summary>
                public class KeysResource
                {
                    private const string Resource = "keys";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public KeysResource(Google.Apis.Services.IClientService service)
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
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        /// <param name="name">The name of the operation resource.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                    Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/keys/[^/]+/operations/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a new WorkforcePoolProviderKey in a WorkforcePoolProvider.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The provider to create this key in.</param>
                    public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkforcePoolProviderKey body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new WorkforcePoolProviderKey in a WorkforcePoolProvider.</summary>
                    public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePoolProviderKey body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The provider to create this key in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the key, which becomes the final component of the resource name.
                        /// This value must be 4-32 characters, and may contain the characters [a-z0-9-].
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("workforcePoolProviderKeyId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WorkforcePoolProviderKeyId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.WorkforcePoolProviderKey Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/keys";

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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
                            });
                            RequestParameters.Add("workforcePoolProviderKeyId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workforcePoolProviderKeyId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a WorkforcePoolProviderKey. You can undelete a key for 30 days. After 30 days, deletion
                    /// is permanent.
                    /// </summary>
                    /// <param name="name">Required. The name of the key to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a WorkforcePoolProviderKey. You can undelete a key for 30 days. After 30 days, deletion
                    /// is permanent.
                    /// </summary>
                    public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the key to delete.</summary>
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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/keys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a WorkforcePoolProviderKey.</summary>
                    /// <param name="name">Required. The name of the key to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a WorkforcePoolProviderKey.</summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderKey>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the key to retrieve.</summary>
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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/keys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkforcePoolProviderKeys in a WorkforcePoolProvider. If `show_deleted` is
                    /// set to `true`, then deleted keys are also listed.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The provider resource to list encryption keys for. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkforcePoolProviderKeys in a WorkforcePoolProvider. If `show_deleted` is
                    /// set to `true`, then deleted keys are also listed.
                    /// </summary>
                    public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkforcePoolProviderKeysResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The provider resource to list encryption keys for. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of keys to return. If unspecified, all keys are returned. The maximum
                        /// value is 10; values above 10 are truncated to 10.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListWorkforcePoolProviderKeys` call. Provide this to
                        /// retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Whether to return soft-deleted keys.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/keys";

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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
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

                    /// <summary>
                    /// Undeletes a WorkforcePoolProviderKey, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The name of the key to undelete.</param>
                    public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderKeyRequest body, string name)
                    {
                        return new UndeleteRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Undeletes a WorkforcePoolProviderKey, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Undelete request.</summary>
                        public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderKeyRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the key to undelete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderKeyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "undelete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:undelete";

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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/keys/[^/]+$",
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
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/operations/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the ScimTenants resource.</summary>
                public virtual ScimTenantsResource ScimTenants { get; }

                /// <summary>The "scimTenants" collection of methods.</summary>
                public class ScimTenantsResource
                {
                    private const string Resource = "scimTenants";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ScimTenantsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Tokens = new TokensResource(service);
                    }

                    /// <summary>Gets the Tokens resource.</summary>
                    public virtual TokensResource Tokens { get; }

                    /// <summary>The "tokens" collection of methods.</summary>
                    public class TokensResource
                    {
                        private const string Resource = "tokens";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TokensResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Creates a new WorkforcePoolProviderScimToken in a WorkforcePoolProviderScimTenant. You
                        /// cannot reuse the name of a deleted SCIM token until 30 days after deletion.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent tenant to create scim token. Format:
                        /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}'
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Creates a new WorkforcePoolProviderScimToken in a WorkforcePoolProviderScimTenant. You
                        /// cannot reuse the name of a deleted SCIM token until 30 days after deletion.
                        /// </summary>
                        public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent tenant to create scim token. Format:
                            /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}'
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the scim token, which becomes the final component of the
                            /// resource name. This value should be 4-32 characters and follow this pattern:
                            /// "([a-z]([a-z0-9\\-]{2,30}[a-z0-9]))"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("workforcePoolProviderScimTokenId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string WorkforcePoolProviderScimTokenId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tokens";

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
                                    Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+$",
                                });
                                RequestParameters.Add("workforcePoolProviderScimTokenId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "workforcePoolProviderScimTokenId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes a WorkforcePoolProviderScimToken. You can undelete a scim token for 30 days. After
                        /// 30 days, deletion is permanent. You cannot update deleted scim tokens. However, you can view
                        /// and list them.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the scim token to delete. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}/tokens/{token}`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>
                        /// Deletes a WorkforcePoolProviderScimToken. You can undelete a scim token for 30 days. After
                        /// 30 days, deletion is permanent. You cannot update deleted scim tokens. However, you can view
                        /// and list them.
                        /// </summary>
                        public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the scim token to delete. Format:
                            /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}/tokens/{token}`
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
                                    Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+/tokens/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets an individual WorkforcePoolProviderScimToken.</summary>
                        /// <param name="name">
                        /// Required. The name of the scim token to retrieve. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}/tokens/{token}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets an individual WorkforcePoolProviderScimToken.</summary>
                        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the scim token to retrieve. Format:
                            /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}/tokens/{token}`
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
                                    Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+/tokens/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists all non-deleted WorkforcePoolProviderScimTokenss in a WorkforcePoolProviderScimTenant.
                        /// If `show_deleted` is set to `true`, then deleted SCIM tokens are also listed.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent to list scim tokens. Format:
                        /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}'
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists all non-deleted WorkforcePoolProviderScimTokenss in a WorkforcePoolProviderScimTenant.
                        /// If `show_deleted` is set to `true`, then deleted SCIM tokens are also listed.
                        /// </summary>
                        public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkforcePoolProviderScimTokensResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent to list scim tokens. Format:
                            /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}'
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. The maximum number of scim tokens to return. If unspecified, at most 2 scim
                            /// tokens will be returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListWorkforcePoolProviderScimTokens`
                            /// call. Provide this to retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Optional. Whether to return soft-deleted scim tokens.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ShowDeleted { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tokens";

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
                                    Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+$",
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

                        /// <summary>Updates an existing WorkforcePoolProviderScimToken.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Identifier. The resource name of the SCIM Token. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/
                        /// {workforce_pool_provider}/scimTenants/{scim_tenant}/tokens/{token}`
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>Updates an existing WorkforcePoolProviderScimToken.</summary>
                        public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Identifier. The resource name of the SCIM Token. Format:
                            /// `locations/{location}/workforcePools/{workforce_pool}/providers/
                            /// {workforce_pool_provider}/scimTenants/{scim_tenant}/tokens/{token}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Optional. The list of fields to update.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken Body { get; set; }

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
                                    Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+/tokens/[^/]+$",
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
                        /// Undeletes a WorkforcePoolProviderScimToken, as long as it was deleted fewer than 30 days
                        /// ago.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The name of the scim token to undelete. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}/tokens/{token}`
                        /// </param>
                        public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderScimTokenRequest body, string name)
                        {
                            return new UndeleteRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Undeletes a WorkforcePoolProviderScimToken, as long as it was deleted fewer than 30 days
                        /// ago.
                        /// </summary>
                        public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimToken>
                        {
                            /// <summary>Constructs a new Undelete request.</summary>
                            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderScimTokenRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the scim token to undelete. Format:
                            /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}/tokens/{token}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderScimTokenRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "undelete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:undelete";

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
                                    Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+/tokens/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Creates a new WorkforcePoolProviderScimTenant in a WorkforcePoolProvider. You cannot reuse the
                    /// name of a deleted scim tenant until 30 days after deletion.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent to create scim tenant. Format:
                    /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}'
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new WorkforcePoolProviderScimTenant in a WorkforcePoolProvider. You cannot reuse the
                    /// name of a deleted scim tenant until 30 days after deletion.
                    /// </summary>
                    public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent to create scim tenant. Format:
                        /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}'
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the scim tenant, which becomes the final component of the
                        /// resource name. This value should be 4-32 characters, and may contain the characters
                        /// [a-z0-9-].
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("workforcePoolProviderScimTenantId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WorkforcePoolProviderScimTenantId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/scimTenants";

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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
                            });
                            RequestParameters.Add("workforcePoolProviderScimTenantId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workforcePoolProviderScimTenantId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a WorkforcePoolProviderScimTenant. You can undelete a scim tenant for 30 days. After 30
                    /// days, deletion is permanent. You cannot update deleted scim tenants. However, you can view and
                    /// list them.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the scim tenant to delete. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a WorkforcePoolProviderScimTenant. You can undelete a scim tenant for 30 days. After 30
                    /// days, deletion is permanent. You cannot update deleted scim tenants. However, you can view and
                    /// list them.
                    /// </summary>
                    public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the scim tenant to delete. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}`
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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an individual WorkforcePoolProviderScimTenant.</summary>
                    /// <param name="name">
                    /// Required. The name of the scim tenant to retrieve. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets an individual WorkforcePoolProviderScimTenant.</summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the scim tenant to retrieve. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}`
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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkforcePoolProviderScimTenants in a WorkforcePoolProvider. If
                    /// `show_deleted` is set to `true`, then deleted scim tenants are also listed.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent to list scim tenants. Format:
                    /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}'
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkforcePoolProviderScimTenants in a WorkforcePoolProvider. If
                    /// `show_deleted` is set to `true`, then deleted scim tenants are also listed.
                    /// </summary>
                    public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkforcePoolProviderScimTenantsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent to list scim tenants. Format:
                        /// 'locations/{location}/workforcePools/{workforce_pool}/providers/{provider}'
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of scim tenants to return. If unspecified, at most 1 scim
                        /// tenant will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListScimTenants` call. Provide this to
                        /// retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Optional. Whether to return soft-deleted scim tenants.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/scimTenants";

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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
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

                    /// <summary>Updates an existing WorkforcePoolProviderScimTenant.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the SCIM Tenant. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool}/providers/
                    /// {workforce_pool_provider}/scimTenants/{scim_tenant}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing WorkforcePoolProviderScimTenant.</summary>
                    public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the SCIM Tenant. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/
                        /// {workforce_pool_provider}/scimTenants/{scim_tenant}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant Body { get; set; }

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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+$",
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
                    /// Undeletes a WorkforcePoolProviderScimTenant, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the scim tenant to undelete. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}`
                    /// </param>
                    public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderScimTenantRequest body, string name)
                    {
                        return new UndeleteRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Undeletes a WorkforcePoolProviderScimTenant, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProviderScimTenant>
                    {
                        /// <summary>Constructs a new Undelete request.</summary>
                        public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderScimTenantRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the scim tenant to undelete. Format:
                        /// `locations/{location}/workforcePools/{workforce_pool}/providers/{provider}/scimTenants/{scim_tenant}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderScimTenantRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "undelete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:undelete";

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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+/scimTenants/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a new WorkforcePoolProvider in a WorkforcePool. You cannot reuse the name of a deleted
                /// provider until 30 days after deletion.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The pool to create this provider in. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkforcePoolProvider body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new WorkforcePoolProvider in a WorkforcePool. You cannot reuse the name of a deleted
                /// provider until 30 days after deletion.
                /// </summary>
                public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePoolProvider body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The pool to create this provider in. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID for the provider, which becomes the final component of the resource name. This
                    /// value must be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix `gcp-` is
                    /// reserved for use by Google, and may not be specified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("workforcePoolProviderId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WorkforcePoolProviderId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.WorkforcePoolProvider Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/providers";

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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
                        });
                        RequestParameters.Add("workforcePoolProviderId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "workforcePoolProviderId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a WorkforcePoolProvider. Deleting a provider does not revoke credentials that have already
                /// been issued; they continue to grant access. You can undelete a provider for 30 days. After 30 days,
                /// deletion is permanent. You cannot update deleted providers. However, you can view and list them.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the provider to delete. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a WorkforcePoolProvider. Deleting a provider does not revoke credentials that have already
                /// been issued; they continue to grant access. You can undelete a provider for 30 days. After 30 days,
                /// deletion is permanent. You cannot update deleted providers. However, you can view and list them.
                /// </summary>
                public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the provider to delete. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets an individual WorkforcePoolProvider.</summary>
                /// <param name="name">
                /// Required. The name of the provider to retrieve. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets an individual WorkforcePoolProvider.</summary>
                public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePoolProvider>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the provider to retrieve. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all non-deleted WorkforcePoolProviders in a WorkforcePool. If `show_deleted` is set to `true`,
                /// then deleted providers are also listed.
                /// </summary>
                /// <param name="parent">
                /// Required. The pool to list providers for. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all non-deleted WorkforcePoolProviders in a WorkforcePool. If `show_deleted` is set to `true`,
                /// then deleted providers are also listed.
                /// </summary>
                public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkforcePoolProvidersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The pool to list providers for. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of providers to return. If unspecified, at most 50 providers are returned.
                    /// The maximum value is 100; values above 100 are truncated to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListWorkforcePoolProviders` call. Provide this to
                    /// retrieve the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Whether to return soft-deleted providers.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/providers";

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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
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

                /// <summary>Updates an existing WorkforcePoolProvider.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the provider. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkforcePoolProvider body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing WorkforcePoolProvider.</summary>
                public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePoolProvider body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the provider. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.WorkforcePoolProvider Body { get; set; }

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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
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
                /// Undeletes a WorkforcePoolProvider, as long as it was deleted fewer than 30 days ago.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the provider to undelete. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderRequest body, string name)
                {
                    return new UndeleteRequest(this.service, body, name);
                }

                /// <summary>
                /// Undeletes a WorkforcePoolProvider, as long as it was deleted fewer than 30 days ago.
                /// </summary>
                public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the provider to undelete. Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolProviderRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:undelete";

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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+/providers/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Subjects resource.</summary>
            public virtual SubjectsResource Subjects { get; }

            /// <summary>The "subjects" collection of methods.</summary>
            public class SubjectsResource
            {
                private const string Resource = "subjects";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SubjectsResource(Google.Apis.Services.IClientService service)
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
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                Pattern = @"^locations/[^/]+/workforcePools/[^/]+/subjects/[^/]+/operations/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Deletes a WorkforcePoolSubject. Subject must not already be in a deleted state. A
                /// WorkforcePoolSubject is automatically created the first time an external credential is exchanged for
                /// a Google Cloud credential using a mapped `google.subject` attribute. There is no endpoint to
                /// manually create a WorkforcePoolSubject. For 30 days after a WorkforcePoolSubject is deleted, using
                /// the same `google.subject` attribute in token exchanges with Google Cloud STS fails. Call
                /// UndeleteWorkforcePoolSubject to undelete a WorkforcePoolSubject that has been deleted, within within
                /// 30 days of deleting it. After 30 days, the WorkforcePoolSubject is permanently deleted. At this
                /// point, a token exchange with Google Cloud STS that uses the same mapped `google.subject` attribute
                /// automatically creates a new WorkforcePoolSubject that is unrelated to the previously deleted
                /// WorkforcePoolSubject but has the same `google.subject` value.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the WorkforcePoolSubject. Special characters, like `/` and `:`, must
                /// be escaped, because all URLs need to conform to the "When to Escape and Unescape" section of
                /// [RFC3986](https://www.ietf.org/rfc/rfc2396.txt). Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}/subjects/{subject_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a WorkforcePoolSubject. Subject must not already be in a deleted state. A
                /// WorkforcePoolSubject is automatically created the first time an external credential is exchanged for
                /// a Google Cloud credential using a mapped `google.subject` attribute. There is no endpoint to
                /// manually create a WorkforcePoolSubject. For 30 days after a WorkforcePoolSubject is deleted, using
                /// the same `google.subject` attribute in token exchanges with Google Cloud STS fails. Call
                /// UndeleteWorkforcePoolSubject to undelete a WorkforcePoolSubject that has been deleted, within within
                /// 30 days of deleting it. After 30 days, the WorkforcePoolSubject is permanently deleted. At this
                /// point, a token exchange with Google Cloud STS that uses the same mapped `google.subject` attribute
                /// automatically creates a new WorkforcePoolSubject that is unrelated to the previously deleted
                /// WorkforcePoolSubject but has the same `google.subject` value.
                /// </summary>
                public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the WorkforcePoolSubject. Special characters, like `/` and `:`,
                    /// must be escaped, because all URLs need to conform to the "When to Escape and Unescape" section
                    /// of [RFC3986](https://www.ietf.org/rfc/rfc2396.txt). Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}/subjects/{subject_id}`
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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+/subjects/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Undeletes a WorkforcePoolSubject, as long as it was deleted fewer than 30 days ago.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the WorkforcePoolSubject. Special characters, like `/` and `:`, must
                /// be escaped, because all URLs need to conform to the "When to Escape and Unescape" section of
                /// [RFC3986](https://www.ietf.org/rfc/rfc2396.txt). Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}/subjects/{subject_id}`
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolSubjectRequest body, string name)
                {
                    return new UndeleteRequest(this.service, body, name);
                }

                /// <summary>
                /// Undeletes a WorkforcePoolSubject, as long as it was deleted fewer than 30 days ago.
                /// </summary>
                public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolSubjectRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the WorkforcePoolSubject. Special characters, like `/` and `:`,
                    /// must be escaped, because all URLs need to conform to the "When to Escape and Unescape" section
                    /// of [RFC3986](https://www.ietf.org/rfc/rfc2396.txt). Format:
                    /// `locations/{location}/workforcePools/{workforce_pool_id}/subjects/{subject_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolSubjectRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:undelete";

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
                            Pattern = @"^locations/[^/]+/workforcePools/[^/]+/subjects/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a new WorkforcePool. You cannot reuse the name of a deleted pool until 30 days after deletion.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="location">
            /// Optional. The location of the pool to create. Format: `locations/{location}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkforcePool body, string location)
            {
                return new CreateRequest(this.service, body, location);
            }

            /// <summary>
            /// Creates a new WorkforcePool. You cannot reuse the name of a deleted pool until 30 days after deletion.
            /// </summary>
            public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePool body, string location) : base(service)
                {
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Optional. The location of the pool to create. Format: `locations/{location}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>
                /// Optional. The ID to use for the pool, which becomes the final component of the resource name. The
                /// IDs must be a globally unique string of 6 to 63 lowercase letters, digits, or hyphens. It must start
                /// with a letter, and cannot have a trailing hyphen. The prefix `gcp-` is reserved for use by Google,
                /// and may not be specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("workforcePoolId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string WorkforcePoolId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.WorkforcePool Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}/workforcePools";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+$",
                    });
                    RequestParameters.Add("workforcePoolId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "workforcePoolId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a WorkforcePool. You cannot use a deleted WorkforcePool to exchange external credentials for
            /// Google Cloud credentials. However, deletion does not revoke credentials that have already been issued.
            /// Credentials issued for a deleted pool do not grant access to resources. If the pool is undeleted, and
            /// the credentials are not expired, they grant access again. You can undelete a pool for 30 days. After 30
            /// days, deletion is permanent. You cannot update deleted pools. However, you can view and list them.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the pool to delete. Format:
            /// `locations/{location}/workforcePools/{workforce_pool_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a WorkforcePool. You cannot use a deleted WorkforcePool to exchange external credentials for
            /// Google Cloud credentials. However, deletion does not revoke credentials that have already been issued.
            /// Credentials issued for a deleted pool do not grant access to resources. If the pool is undeleted, and
            /// the credentials are not expired, they grant access again. You can undelete a pool for 30 days. After 30
            /// days, deletion is permanent. You cannot update deleted pools. However, you can view and list them.
            /// </summary>
            public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the pool to delete. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}`
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
                        Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an individual WorkforcePool.</summary>
            /// <param name="name">
            /// Required. The name of the pool to retrieve. Format:
            /// `locations/{location}/workforcePools/{workforce_pool_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets an individual WorkforcePool.</summary>
            public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkforcePool>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the pool to retrieve. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}`
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
                        Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
                    });
                }
            }

            /// <summary>Gets IAM policies on a WorkforcePool.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Iam.v1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>Gets IAM policies on a WorkforcePool.</summary>
            public class GetIamPolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Iam.v1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

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
                        Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists all non-deleted WorkforcePools under the specified parent. If `show_deleted` is set to `true`,
            /// then deleted pools are also listed.
            /// </summary>
            /// <param name="location">The location of the pool. Format: `locations/{location}`.</param>
            public virtual ListRequest List(string location)
            {
                return new ListRequest(this.service, location);
            }

            /// <summary>
            /// Lists all non-deleted WorkforcePools under the specified parent. If `show_deleted` is set to `true`,
            /// then deleted pools are also listed.
            /// </summary>
            public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkforcePoolsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                {
                    Location = location;
                    InitParameters();
                }

                /// <summary>The location of the pool. Format: `locations/{location}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>
                /// The maximum number of pools to return. If unspecified, at most 50 pools will be returned. The
                /// maximum value is 1000; values above 1000 are truncated to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListWorkforcePools` call. Provide this to retrieve the
                /// subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Required. The parent resource to list pools for. Format: `organizations/{org-id}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Parent { get; set; }

                /// <summary>Whether to return soft-deleted pools.</summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}/workforcePools";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+$",
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

            /// <summary>Updates an existing WorkforcePool.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the pool. Format:
            /// `locations/{location}/workforcePools/{workforce_pool_id}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkforcePool body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates an existing WorkforcePool.</summary>
            public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkforcePool body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the pool. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.WorkforcePool Body { get; set; }

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
                        Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
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

            /// <summary>Sets IAM policies on a WorkforcePool.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Iam.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>Sets IAM policies on a WorkforcePool.</summary>
            public class SetIamPolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Iam.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the caller's permissions on the WorkforcePool. If the pool doesn't exist, this call returns an
            /// empty set of permissions. It doesn't return a `NOT_FOUND` error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Iam.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns the caller's permissions on the WorkforcePool. If the pool doesn't exist, this call returns an
            /// empty set of permissions. It doesn't return a `NOT_FOUND` error.
            /// </summary>
            public class TestIamPermissionsRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Iam.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
                    });
                }
            }

            /// <summary>Undeletes a WorkforcePool, as long as it was deleted fewer than 30 days ago.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the pool to undelete. Format:
            /// `locations/{location}/workforcePools/{workforce_pool_id}`
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolRequest body, string name)
            {
                return new UndeleteRequest(this.service, body, name);
            }

            /// <summary>Undeletes a WorkforcePool, as long as it was deleted fewer than 30 days ago.</summary>
            public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the pool to undelete. Format:
                /// `locations/{location}/workforcePools/{workforce_pool_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.UndeleteWorkforcePoolRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:undelete";

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
                        Pattern = @"^locations/[^/]+/workforcePools/[^/]+$",
                    });
                }
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
            Roles = new RolesResource(service);
        }

        /// <summary>Gets the Roles resource.</summary>
        public virtual RolesResource Roles { get; }

        /// <summary>The "roles" collection of methods.</summary>
        public class RolesResource
        {
            private const string Resource = "roles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RolesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new custom Role.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The `parent` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `parent` value format is described below: *
            /// [projects.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/create):
            /// `projects/{PROJECT_ID}`. This method creates project-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [organizations.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/create):
            /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.CreateRoleRequest body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a new custom Role.</summary>
            public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.CreateRoleRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The `parent` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `parent` value format is described below: *
                /// [projects.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/create):
                /// `projects/{PROJECT_ID}`. This method creates project-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [organizations.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/create):
                /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
                /// invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.CreateRoleRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/roles";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a custom Role. When you delete a custom role, the following changes occur immediately: * You
            /// cannot bind a principal to the custom role in an IAM Policy. * Existing bindings to the custom role are
            /// not changed, but they have no effect. * By default, the response from ListRoles does not include the
            /// custom role. A deleted custom role still counts toward the [custom role
            /// limit](https://cloud.google.com/iam/help/limits) until it is permanently deleted. You have 7 days to
            /// undelete the custom role. After 7 days, the following changes occur: * The custom role is permanently
            /// deleted and cannot be recovered. * If an IAM policy contains a binding to the custom role, the binding
            /// is permanently removed. * The custom role no longer counts toward your custom role limit.
            /// </summary>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [projects.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/delete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/delete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a custom Role. When you delete a custom role, the following changes occur immediately: * You
            /// cannot bind a principal to the custom role in an IAM Policy. * Existing bindings to the custom role are
            /// not changed, but they have no effect. * By default, the response from ListRoles does not include the
            /// custom role. A deleted custom role still counts toward the [custom role
            /// limit](https://cloud.google.com/iam/help/limits) until it is permanently deleted. You have 7 days to
            /// undelete the custom role. After 7 days, the following changes occur: * The custom role is permanently
            /// deleted and cannot be recovered. * If an IAM policy contains a binding to the custom role, the binding
            /// is permanently removed. * The custom role no longer counts toward your custom role limit.
            /// </summary>
            public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [projects.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/delete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/delete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Used to perform a consistent read-modify-write.</summary>
                [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Etag { get; set; }

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
                        Pattern = @"^organizations/[^/]+/roles/[^/]+$",
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

            /// <summary>Gets the definition of a Role.</summary>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This
            /// method returns results from all [predefined
            /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example request
            /// URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
            /// [projects.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/get):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/get):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the definition of a Role.</summary>
            public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`.
                /// This method returns results from all [predefined
                /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example
                /// request URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
                /// [projects.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/get):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/get):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
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
                        Pattern = @"^organizations/[^/]+/roles/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists every predefined Role that IAM supports, or every custom role that is defined for an organization
            /// or project.
            /// </summary>
            /// <param name="parent">
            /// The `parent` parameter's value depends on the target resource for the request, namely
            /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `parent` value format is described below: *
            /// [roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/roles/list): An empty string. This
            /// method doesn't require a resource; it simply returns all [predefined
            /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example request
            /// URL: `https://iam.googleapis.com/v1/roles` *
            /// [projects.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/list):
            /// `projects/{PROJECT_ID}`. This method lists all project-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [organizations.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/list):
            /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists every predefined Role that IAM supports, or every custom role that is defined for an organization
            /// or project.
            /// </summary>
            public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListRolesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The `parent` parameter's value depends on the target resource for the request, namely
                /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `parent` value format is described below: *
                /// [roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/roles/list): An empty string. This
                /// method doesn't require a resource; it simply returns all [predefined
                /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example
                /// request URL: `https://iam.googleapis.com/v1/roles` *
                /// [projects.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/list):
                /// `projects/{PROJECT_ID}`. This method lists all project-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [organizations.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/list):
                /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
                /// invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional limit on the number of roles to include in the response. The default is 300, and the
                /// maximum is 1,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional pagination token returned in an earlier ListRolesResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Include Roles that have been deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>
                /// Optional view for the returned Role objects. When `FULL` is specified, the `includedPermissions`
                /// field is returned, which includes a list of all permissions in the role. The default value is
                /// `BASIC`, which does not return the `includedPermissions` field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// Optional view for the returned Role objects. When `FULL` is specified, the `includedPermissions`
                /// field is returned, which includes a list of all permissions in the role. The default value is
                /// `BASIC`, which does not return the `includedPermissions` field.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>Omits the `included_permissions` field. This is the default value.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 0,

                    /// <summary>Returns all fields.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/roles";

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
                        Pattern = @"^organizations/[^/]+$",
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

            /// <summary>Updates the definition of a custom Role.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [projects.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/patch):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/patch):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.Role body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates the definition of a custom Role.</summary>
            public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.Role body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [projects.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/patch):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/patch):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>A mask describing which fields in the Role have changed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.Role Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/roles/[^/]+$",
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

            /// <summary>Undeletes a custom Role.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [projects.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/undelete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/undelete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteRoleRequest body, string name)
            {
                return new UndeleteRequest(this.service, body, name);
            }

            /// <summary>Undeletes a custom Role.</summary>
            public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteRoleRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [projects.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/undelete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/undelete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.UndeleteRoleRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:undelete";

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
                        Pattern = @"^organizations/[^/]+/roles/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "permissions" collection of methods.</summary>
    public class PermissionsResource
    {
        private const string Resource = "permissions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PermissionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Lists every permission that you can test on a resource. A permission is testable if you can check whether a
        /// principal has that permission on the resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryTestablePermissionsRequest QueryTestablePermissions(Google.Apis.Iam.v1.Data.QueryTestablePermissionsRequest body)
        {
            return new QueryTestablePermissionsRequest(this.service, body);
        }

        /// <summary>
        /// Lists every permission that you can test on a resource. A permission is testable if you can check whether a
        /// principal has that permission on the resource.
        /// </summary>
        public class QueryTestablePermissionsRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.QueryTestablePermissionsResponse>
        {
            /// <summary>Constructs a new QueryTestablePermissions request.</summary>
            public QueryTestablePermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.QueryTestablePermissionsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Iam.v1.Data.QueryTestablePermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryTestablePermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/permissions:queryTestablePermissions";

            /// <summary>Initializes QueryTestablePermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
            Locations = new LocationsResource(service);
            Roles = new RolesResource(service);
            ServiceAccounts = new ServiceAccountsResource(service);
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
                OauthClients = new OauthClientsResource(service);
                WorkloadIdentityPools = new WorkloadIdentityPoolsResource(service);
            }

            /// <summary>Gets the OauthClients resource.</summary>
            public virtual OauthClientsResource OauthClients { get; }

            /// <summary>The "oauthClients" collection of methods.</summary>
            public class OauthClientsResource
            {
                private const string Resource = "oauthClients";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OauthClientsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Credentials = new CredentialsResource(service);
                }

                /// <summary>Gets the Credentials resource.</summary>
                public virtual CredentialsResource Credentials { get; }

                /// <summary>The "credentials" collection of methods.</summary>
                public class CredentialsResource
                {
                    private const string Resource = "credentials";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CredentialsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new OauthClientCredential.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource to create the OauthClientCredential in.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.OauthClientCredential body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new OauthClientCredential.</summary>
                    public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClientCredential>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.OauthClientCredential body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource to create the OauthClientCredential in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the OauthClientCredential, which becomes the final component of
                        /// the resource name. This value should be 4-32 characters, and may contain the characters
                        /// [a-z0-9-]. The prefix `gcp-` is reserved for use by Google, and may not be specified.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("oauthClientCredentialId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OauthClientCredentialId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.OauthClientCredential Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/credentials";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+$",
                            });
                            RequestParameters.Add("oauthClientCredentialId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "oauthClientCredentialId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes an OauthClientCredential. Before deleting an OauthClientCredential, it should first be
                    /// disabled.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the OauthClientCredential to delete. Format:
                    /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes an OauthClientCredential. Before deleting an OauthClientCredential, it should first be
                    /// disabled.
                    /// </summary>
                    public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the OauthClientCredential to delete. Format:
                        /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+/credentials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an individual OauthClientCredential.</summary>
                    /// <param name="name">
                    /// Required. The name of the OauthClientCredential to retrieve. Format:
                    /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets an individual OauthClientCredential.</summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClientCredential>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the OauthClientCredential to retrieve. Format:
                        /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+/credentials/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all OauthClientCredentials in an OauthClient.</summary>
                    /// <param name="parent">Required. The parent to list OauthClientCredentials for.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all OauthClientCredentials in an OauthClient.</summary>
                    public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListOauthClientCredentialsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent to list OauthClientCredentials for.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/credentials";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Updates an existing OauthClientCredential.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Identifier. The resource name of the OauthClientCredential. Format:
                    /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.OauthClientCredential body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing OauthClientCredential.</summary>
                    public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClientCredential>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.OauthClientCredential body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Identifier. The resource name of the OauthClientCredential. Format:
                        /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.OauthClientCredential Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+/credentials/[^/]+$",
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

                /// <summary>
                /// Creates a new OauthClient. You cannot reuse the name of a deleted OauthClient until 30 days after
                /// deletion.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource to create the OauthClient in. The only supported location is `global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.OauthClient body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new OauthClient. You cannot reuse the name of a deleted OauthClient until 30 days after
                /// deletion.
                /// </summary>
                public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClient>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.OauthClient body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource to create the OauthClient in. The only supported location is
                    /// `global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the OauthClient, which becomes the final component of the resource
                    /// name. This value should be a string of 6 to 63 lowercase letters, digits, or hyphens. It must
                    /// start with a letter, and cannot have a trailing hyphen. The prefix `gcp-` is reserved for use by
                    /// Google, and may not be specified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("oauthClientId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OauthClientId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.OauthClient Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/oauthClients";

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
                        RequestParameters.Add("oauthClientId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "oauthClientId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes an OauthClient. You cannot use a deleted OauthClient. However, deletion does not revoke
                /// access tokens that have already been issued. They continue to grant access. Deletion does revoke
                /// refresh tokens that have already been issued. They cannot be used to renew an access token. If the
                /// OauthClient is undeleted, and the refresh tokens are not expired, they are valid for token exchange
                /// again. You can undelete an OauthClient for 30 days. After 30 days, deletion is permanent. You cannot
                /// update deleted OauthClients. However, you can view and list them.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the OauthClient to delete. Format:
                /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes an OauthClient. You cannot use a deleted OauthClient. However, deletion does not revoke
                /// access tokens that have already been issued. They continue to grant access. Deletion does revoke
                /// refresh tokens that have already been issued. They cannot be used to renew an access token. If the
                /// OauthClient is undeleted, and the refresh tokens are not expired, they are valid for token exchange
                /// again. You can undelete an OauthClient for 30 days. After 30 days, deletion is permanent. You cannot
                /// update deleted OauthClients. However, you can view and list them.
                /// </summary>
                public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClient>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the OauthClient to delete. Format:
                    /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets an individual OauthClient.</summary>
                /// <param name="name">
                /// Required. The name of the OauthClient to retrieve. Format:
                /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets an individual OauthClient.</summary>
                public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClient>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the OauthClient to retrieve. Format:
                    /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all non-deleted OauthClients in a project. If `show_deleted` is set to `true`, then deleted
                /// OauthClients are also listed.
                /// </summary>
                /// <param name="parent">Required. The parent to list OauthClients for.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all non-deleted OauthClients in a project. If `show_deleted` is set to `true`, then deleted
                /// OauthClients are also listed.
                /// </summary>
                public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListOauthClientsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent to list OauthClients for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of OauthClients to return. If unspecified, at most 50 OauthClients
                    /// will be returned. The maximum value is 100; values above 100 are truncated to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListOauthClients` call. Provide this to
                    /// retrieve the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Optional. Whether to return soft-deleted OauthClients.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/oauthClients";

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

                /// <summary>Updates an existing OauthClient.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. Identifier. The resource name of the OauthClient.
                /// Format:`projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.OauthClient body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing OauthClient.</summary>
                public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClient>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.OauthClient body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. Identifier. The resource name of the OauthClient.
                    /// Format:`projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.OauthClient Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+$",
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

                /// <summary>Undeletes an OauthClient, as long as it was deleted fewer than 30 days ago.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the OauthClient to undelete. Format:
                /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
                /// </param>
                public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteOauthClientRequest body, string name)
                {
                    return new UndeleteRequest(this.service, body, name);
                }

                /// <summary>Undeletes an OauthClient, as long as it was deleted fewer than 30 days ago.</summary>
                public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.OauthClient>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteOauthClientRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the OauthClient to undelete. Format:
                    /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.UndeleteOauthClientRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:undelete";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/oauthClients/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the WorkloadIdentityPools resource.</summary>
            public virtual WorkloadIdentityPoolsResource WorkloadIdentityPools { get; }

            /// <summary>The "workloadIdentityPools" collection of methods.</summary>
            public class WorkloadIdentityPoolsResource
            {
                private const string Resource = "workloadIdentityPools";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkloadIdentityPoolsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Namespaces = new NamespacesResource(service);
                    Operations = new OperationsResource(service);
                    Providers = new ProvidersResource(service);
                }

                /// <summary>Gets the Namespaces resource.</summary>
                public virtual NamespacesResource Namespaces { get; }

                /// <summary>The "namespaces" collection of methods.</summary>
                public class NamespacesResource
                {
                    private const string Resource = "namespaces";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public NamespacesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        ManagedIdentities = new ManagedIdentitiesResource(service);
                        Operations = new OperationsResource(service);
                    }

                    /// <summary>Gets the ManagedIdentities resource.</summary>
                    public virtual ManagedIdentitiesResource ManagedIdentities { get; }

                    /// <summary>The "managedIdentities" collection of methods.</summary>
                    public class ManagedIdentitiesResource
                    {
                        private const string Resource = "managedIdentities";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ManagedIdentitiesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Operations = new OperationsResource(service);
                            WorkloadSources = new WorkloadSourcesResource(service);
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
                            /// Gets the latest state of a long-running operation. Clients can use this method to poll
                            /// the operation result at intervals as recommended by the API service.
                            /// </summary>
                            /// <param name="name">The name of the operation resource.</param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(this.service, name);
                            }

                            /// <summary>
                            /// Gets the latest state of a long-running operation. Clients can use this method to poll
                            /// the operation result at intervals as recommended by the API service.
                            /// </summary>
                            public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+/operations/[^/]+$",
                                    });
                                }
                            }
                        }

                        /// <summary>Gets the WorkloadSources resource.</summary>
                        public virtual WorkloadSourcesResource WorkloadSources { get; }

                        /// <summary>The "workloadSources" collection of methods.</summary>
                        public class WorkloadSourcesResource
                        {
                            private const string Resource = "workloadSources";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public WorkloadSourcesResource(Google.Apis.Services.IClientService service)
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
                                /// Gets the latest state of a long-running operation. Clients can use this method to
                                /// poll the operation result at intervals as recommended by the API service.
                                /// </summary>
                                /// <param name="name">The name of the operation resource.</param>
                                public virtual GetRequest Get(string name)
                                {
                                    return new GetRequest(this.service, name);
                                }

                                /// <summary>
                                /// Gets the latest state of a long-running operation. Clients can use this method to
                                /// poll the operation result at intervals as recommended by the API service.
                                /// </summary>
                                public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+/workloadSources/[^/]+/operations/[^/]+$",
                                        });
                                    }
                                }
                            }
                        }

                        /// <summary>
                        /// Add an AttestationRule on a WorkloadIdentityPoolManagedIdentity. The total attestation rules
                        /// after addition must not exceed 50.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// Required. The resource name of the managed identity or namespace resource to add an
                        /// attestation rule to.
                        /// </param>
                        public virtual AddAttestationRuleRequest AddAttestationRule(Google.Apis.Iam.v1.Data.AddAttestationRuleRequest body, string resource)
                        {
                            return new AddAttestationRuleRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Add an AttestationRule on a WorkloadIdentityPoolManagedIdentity. The total attestation rules
                        /// after addition must not exceed 50.
                        /// </summary>
                        public class AddAttestationRuleRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new AddAttestationRule request.</summary>
                            public AddAttestationRuleRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.AddAttestationRuleRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the managed identity or namespace resource to add an
                            /// attestation rule to.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.AddAttestationRuleRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "addAttestationRule";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:addAttestationRule";

                            /// <summary>Initializes AddAttestationRule parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "resource",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Creates a new WorkloadIdentityPoolManagedIdentity in a WorkloadIdentityPoolNamespace.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource to create the manage identity in. The only supported location
                        /// is `global`.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkloadIdentityPoolManagedIdentity body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Creates a new WorkloadIdentityPoolManagedIdentity in a WorkloadIdentityPoolNamespace.
                        /// </summary>
                        public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPoolManagedIdentity body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource to create the manage identity in. The only supported
                            /// location is `global`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the managed identity. This value must: * contain at most 63
                            /// characters * contain only lowercase alphanumeric characters or `-` * start with an
                            /// alphanumeric character * end with an alphanumeric character The prefix "gcp-" will be
                            /// reserved for future uses.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("workloadIdentityPoolManagedIdentityId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string WorkloadIdentityPoolManagedIdentityId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.WorkloadIdentityPoolManagedIdentity Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/managedIdentities";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+$",
                                });
                                RequestParameters.Add("workloadIdentityPoolManagedIdentityId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "workloadIdentityPoolManagedIdentityId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes a WorkloadIdentityPoolManagedIdentity. You can undelete a managed identity for 30
                        /// days. After 30 days, deletion is permanent.
                        /// </summary>
                        /// <param name="name">Required. The name of the managed identity to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>
                        /// Deletes a WorkloadIdentityPoolManagedIdentity. You can undelete a managed identity for 30
                        /// days. After 30 days, deletion is permanent.
                        /// </summary>
                        public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the managed identity to delete.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets an individual WorkloadIdentityPoolManagedIdentity.</summary>
                        /// <param name="name">Required. The name of the managed identity to retrieve.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets an individual WorkloadIdentityPoolManagedIdentity.</summary>
                        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkloadIdentityPoolManagedIdentity>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the managed identity to retrieve.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists all non-deleted WorkloadIdentityPoolManagedIdentitys in a namespace. If `show_deleted`
                        /// is set to `true`, then deleted managed identities are also listed.
                        /// </summary>
                        /// <param name="parent">Required. The parent resource to list managed identities for.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists all non-deleted WorkloadIdentityPoolManagedIdentitys in a namespace. If `show_deleted`
                        /// is set to `true`, then deleted managed identities are also listed.
                        /// </summary>
                        public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkloadIdentityPoolManagedIdentitiesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. The parent resource to list managed identities for.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of managed identities to return. If unspecified, at most 50 managed
                            /// identities are returned. The maximum value is 1000; values above are 1000 truncated to
                            /// 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListWorkloadIdentityPoolManagedIdentities` call.
                            /// Provide this to retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Whether to return soft-deleted managed identities.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ShowDeleted { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/managedIdentities";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+$",
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

                        /// <summary>List all AttestationRule on a WorkloadIdentityPoolManagedIdentity.</summary>
                        /// <param name="resource">
                        /// Required. The resource name of the managed identity or namespace resource to list
                        /// attestation rules of.
                        /// </param>
                        public virtual ListAttestationRulesRequest ListAttestationRules(string resource)
                        {
                            return new ListAttestationRulesRequest(this.service, resource);
                        }

                        /// <summary>List all AttestationRule on a WorkloadIdentityPoolManagedIdentity.</summary>
                        public class ListAttestationRulesRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListAttestationRulesResponse>
                        {
                            /// <summary>Constructs a new ListAttestationRules request.</summary>
                            public ListAttestationRulesRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                            {
                                Resource = resource;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the managed identity or namespace resource to list
                            /// attestation rules of.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>
                            /// Optional. A query filter. Supports the following function: * `container_ids()`: Returns
                            /// only the AttestationRules under the specific container ids. The function expects a
                            /// comma-delimited list with only project numbers and must use the format `projects/`. For
                            /// example: `container_ids(projects/, projects/,...)`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of AttestationRules to return. If unspecified, at most 50
                            /// AttestationRules are returned. The maximum value is 100; values above 100 are truncated
                            /// to 100.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListWorkloadIdentityPoolProviderKeys`
                            /// call. Provide this to retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "listAttestationRules";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:listAttestationRules";

                            /// <summary>Initializes ListAttestationRules parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "resource",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
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

                        /// <summary>
                        /// Updates an existing WorkloadIdentityPoolManagedIdentity in a WorkloadIdentityPoolNamespace.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Output only. The resource name of the managed identity.</param>
                        public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkloadIdentityPoolManagedIdentity body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Updates an existing WorkloadIdentityPoolManagedIdentity in a WorkloadIdentityPoolNamespace.
                        /// </summary>
                        public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPoolManagedIdentity body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Output only. The resource name of the managed identity.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Required. The list of fields to update.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.WorkloadIdentityPoolManagedIdentity Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
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

                        /// <summary>Remove an AttestationRule on a WorkloadIdentityPoolManagedIdentity.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// Required. The resource name of the managed identity or namespace resource to remove an
                        /// attestation rule from.
                        /// </param>
                        public virtual RemoveAttestationRuleRequest RemoveAttestationRule(Google.Apis.Iam.v1.Data.RemoveAttestationRuleRequest body, string resource)
                        {
                            return new RemoveAttestationRuleRequest(this.service, body, resource);
                        }

                        /// <summary>Remove an AttestationRule on a WorkloadIdentityPoolManagedIdentity.</summary>
                        public class RemoveAttestationRuleRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new RemoveAttestationRule request.</summary>
                            public RemoveAttestationRuleRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.RemoveAttestationRuleRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the managed identity or namespace resource to remove an
                            /// attestation rule from.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.RemoveAttestationRuleRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "removeAttestationRule";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:removeAttestationRule";

                            /// <summary>Initializes RemoveAttestationRule parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "resource",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Set all AttestationRule on a WorkloadIdentityPoolManagedIdentity. A maximum of 50
                        /// AttestationRules can be set.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// Required. The resource name of the managed identity or namespace resource to add an
                        /// attestation rule to.
                        /// </param>
                        public virtual SetAttestationRulesRequest SetAttestationRules(Google.Apis.Iam.v1.Data.SetAttestationRulesRequest body, string resource)
                        {
                            return new SetAttestationRulesRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Set all AttestationRule on a WorkloadIdentityPoolManagedIdentity. A maximum of 50
                        /// AttestationRules can be set.
                        /// </summary>
                        public class SetAttestationRulesRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new SetAttestationRules request.</summary>
                            public SetAttestationRulesRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.SetAttestationRulesRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the managed identity or namespace resource to add an
                            /// attestation rule to.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.SetAttestationRulesRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "setAttestationRules";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+resource}:setAttestationRules";

                            /// <summary>Initializes SetAttestationRules parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "resource",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Undeletes a WorkloadIdentityPoolManagedIdentity, as long as it was deleted fewer than 30
                        /// days ago.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The name of the managed identity to undelete.</param>
                        public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolManagedIdentityRequest body, string name)
                        {
                            return new UndeleteRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Undeletes a WorkloadIdentityPoolManagedIdentity, as long as it was deleted fewer than 30
                        /// days ago.
                        /// </summary>
                        public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Undelete request.</summary>
                            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolManagedIdentityRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the managed identity to undelete.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolManagedIdentityRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "undelete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:undelete";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/managedIdentities/[^/]+$",
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
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        /// <param name="name">The name of the operation resource.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+/operations/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a new WorkloadIdentityPoolNamespace in a WorkloadIdentityPool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource to create the namespace in. The only supported location is
                    /// `global`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkloadIdentityPoolNamespace body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new WorkloadIdentityPoolNamespace in a WorkloadIdentityPool.</summary>
                    public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPoolNamespace body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource to create the namespace in. The only supported location is
                        /// `global`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the namespace. This value must: * contain at most 63 characters
                        /// * contain only lowercase alphanumeric characters or `-` * start with an alphanumeric
                        /// character * end with an alphanumeric character The prefix "gcp-" will be reserved for future
                        /// uses.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("workloadIdentityPoolNamespaceId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WorkloadIdentityPoolNamespaceId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.WorkloadIdentityPoolNamespace Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/namespaces";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                            });
                            RequestParameters.Add("workloadIdentityPoolNamespaceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workloadIdentityPoolNamespaceId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a WorkloadIdentityPoolNamespace. You can undelete a namespace for 30 days. After 30
                    /// days, deletion is permanent.
                    /// </summary>
                    /// <param name="name">Required. The name of the namespace to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a WorkloadIdentityPoolNamespace. You can undelete a namespace for 30 days. After 30
                    /// days, deletion is permanent.
                    /// </summary>
                    public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the namespace to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an individual WorkloadIdentityPoolNamespace.</summary>
                    /// <param name="name">Required. The name of the namespace to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets an individual WorkloadIdentityPoolNamespace.</summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkloadIdentityPoolNamespace>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the namespace to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkloadIdentityPoolNamespaces in a workload identity pool. If
                    /// `show_deleted` is set to `true`, then deleted namespaces are also listed.
                    /// </summary>
                    /// <param name="parent">Required. The parent resource to list namespaces for.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkloadIdentityPoolNamespaces in a workload identity pool. If
                    /// `show_deleted` is set to `true`, then deleted namespaces are also listed.
                    /// </summary>
                    public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkloadIdentityPoolNamespacesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource to list namespaces for.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of namespaces to return. If unspecified, at most 50 namespaces are
                        /// returned. The maximum value is 1000; values above are 1000 truncated to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListWorkloadIdentityPoolNamespaces` call. Provide
                        /// this to retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Whether to return soft-deleted namespaces.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/namespaces";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
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

                    /// <summary>Updates an existing WorkloadIdentityPoolNamespace in a WorkloadIdentityPool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Output only. The resource name of the namespace.</param>
                    public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkloadIdentityPoolNamespace body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing WorkloadIdentityPoolNamespace in a WorkloadIdentityPool.</summary>
                    public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPoolNamespace body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Output only. The resource name of the namespace.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.WorkloadIdentityPoolNamespace Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+$",
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
                    /// Undeletes a WorkloadIdentityPoolNamespace, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The name of the namespace to undelete.</param>
                    public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolNamespaceRequest body, string name)
                    {
                        return new UndeleteRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Undeletes a WorkloadIdentityPoolNamespace, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Undelete request.</summary>
                        public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolNamespaceRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the namespace to undelete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolNamespaceRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "undelete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:undelete";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/namespaces/[^/]+$",
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
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/operations/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Providers resource.</summary>
                public virtual ProvidersResource Providers { get; }

                /// <summary>The "providers" collection of methods.</summary>
                public class ProvidersResource
                {
                    private const string Resource = "providers";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ProvidersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Keys = new KeysResource(service);
                        Operations = new OperationsResource(service);
                    }

                    /// <summary>Gets the Keys resource.</summary>
                    public virtual KeysResource Keys { get; }

                    /// <summary>The "keys" collection of methods.</summary>
                    public class KeysResource
                    {
                        private const string Resource = "keys";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public KeysResource(Google.Apis.Services.IClientService service)
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
                            /// Gets the latest state of a long-running operation. Clients can use this method to poll
                            /// the operation result at intervals as recommended by the API service.
                            /// </summary>
                            /// <param name="name">The name of the operation resource.</param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(this.service, name);
                            }

                            /// <summary>
                            /// Gets the latest state of a long-running operation. Clients can use this method to poll
                            /// the operation result at intervals as recommended by the API service.
                            /// </summary>
                            public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+/keys/[^/]+/operations/[^/]+$",
                                    });
                                }
                            }
                        }

                        /// <summary>
                        /// Create a new WorkloadIdentityPoolProviderKey in a WorkloadIdentityPoolProvider.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The parent provider resource to create the key in.</param>
                        public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProviderKey body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Create a new WorkloadIdentityPoolProviderKey in a WorkloadIdentityPoolProvider.
                        /// </summary>
                        public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProviderKey body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The parent provider resource to create the key in.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the key, which becomes the final component of the resource
                            /// name. This value should be 4-32 characters, and may contain the characters [a-z0-9-].
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("workloadIdentityPoolProviderKeyId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string WorkloadIdentityPoolProviderKeyId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProviderKey Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/keys";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+$",
                                });
                                RequestParameters.Add("workloadIdentityPoolProviderKeyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "workloadIdentityPoolProviderKeyId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes an WorkloadIdentityPoolProviderKey. You can undelete a key for 30 days. After 30
                        /// days, deletion is permanent.
                        /// </summary>
                        /// <param name="name">Required. The name of the encryption key to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>
                        /// Deletes an WorkloadIdentityPoolProviderKey. You can undelete a key for 30 days. After 30
                        /// days, deletion is permanent.
                        /// </summary>
                        public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the encryption key to delete.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+/keys/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets an individual WorkloadIdentityPoolProviderKey.</summary>
                        /// <param name="name">Required. The name of the key to retrieve.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets an individual WorkloadIdentityPoolProviderKey.</summary>
                        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProviderKey>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the key to retrieve.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+/keys/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists all non-deleted WorkloadIdentityPoolProviderKeys in a project. If show_deleted is set
                        /// to `true`, then deleted pools are also listed.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent provider resource to list encryption keys for.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists all non-deleted WorkloadIdentityPoolProviderKeys in a project. If show_deleted is set
                        /// to `true`, then deleted pools are also listed.
                        /// </summary>
                        public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkloadIdentityPoolProviderKeysResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. The parent provider resource to list encryption keys for.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of keys to return. If unspecified, all keys are returned. The maximum
                            /// value is 10; values above 10 are truncated to 10.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListWorkloadIdentityPoolProviderKeys` call.
                            /// Provide this to retrieve the subsequent page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Whether to return soft deleted resources as well.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ShowDeleted { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/keys";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+$",
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

                        /// <summary>
                        /// Undeletes an WorkloadIdentityPoolProviderKey, as long as it was deleted fewer than 30 days
                        /// ago.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The name of the encryption key to undelete.</param>
                        public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolProviderKeyRequest body, string name)
                        {
                            return new UndeleteRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Undeletes an WorkloadIdentityPoolProviderKey, as long as it was deleted fewer than 30 days
                        /// ago.
                        /// </summary>
                        public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Undelete request.</summary>
                            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolProviderKeyRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the encryption key to undelete.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolProviderKeyRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "undelete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:undelete";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+/keys/[^/]+$",
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
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        /// <param name="name">The name of the operation resource.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+/operations/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Creates a new WorkloadIdentityPoolProvider in a WorkloadIdentityPool. You cannot reuse the name
                    /// of a deleted provider until 30 days after deletion.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The pool to create this provider in.</param>
                    public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProvider body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new WorkloadIdentityPoolProvider in a WorkloadIdentityPool. You cannot reuse the name
                    /// of a deleted provider until 30 days after deletion.
                    /// </summary>
                    public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProvider body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The pool to create this provider in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID for the provider, which becomes the final component of the resource name.
                        /// This value must be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
                        /// `gcp-` is reserved for use by Google, and may not be specified.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("workloadIdentityPoolProviderId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WorkloadIdentityPoolProviderId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProvider Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/providers";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                            });
                            RequestParameters.Add("workloadIdentityPoolProviderId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workloadIdentityPoolProviderId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a WorkloadIdentityPoolProvider. Deleting a provider does not revoke credentials that
                    /// have already been issued; they continue to grant access. You can undelete a provider for 30
                    /// days. After 30 days, deletion is permanent. You cannot update deleted providers. However, you
                    /// can view and list them.
                    /// </summary>
                    /// <param name="name">Required. The name of the provider to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a WorkloadIdentityPoolProvider. Deleting a provider does not revoke credentials that
                    /// have already been issued; they continue to grant access. You can undelete a provider for 30
                    /// days. After 30 days, deletion is permanent. You cannot update deleted providers. However, you
                    /// can view and list them.
                    /// </summary>
                    public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the provider to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an individual WorkloadIdentityPoolProvider.</summary>
                    /// <param name="name">Required. The name of the provider to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets an individual WorkloadIdentityPoolProvider.</summary>
                    public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProvider>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the provider to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkloadIdentityPoolProviders in a WorkloadIdentityPool. If `show_deleted`
                    /// is set to `true`, then deleted providers are also listed.
                    /// </summary>
                    /// <param name="parent">Required. The pool to list providers for.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists all non-deleted WorkloadIdentityPoolProviders in a WorkloadIdentityPool. If `show_deleted`
                    /// is set to `true`, then deleted providers are also listed.
                    /// </summary>
                    public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkloadIdentityPoolProvidersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The pool to list providers for.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of providers to return. If unspecified, at most 50 providers are
                        /// returned. The maximum value is 100; values above 100 are truncated to 100.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListWorkloadIdentityPoolProviders` call. Provide
                        /// this to retrieve the subsequent page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Whether to return soft-deleted providers.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/providers";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
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

                    /// <summary>Updates an existing WorkloadIdentityPoolProvider.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Output only. The resource name of the provider.</param>
                    public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProvider body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing WorkloadIdentityPoolProvider.</summary>
                    public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProvider body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Output only. The resource name of the provider.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.WorkloadIdentityPoolProvider Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+$",
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
                    /// Undeletes a WorkloadIdentityPoolProvider, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The name of the provider to undelete.</param>
                    public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolProviderRequest body, string name)
                    {
                        return new UndeleteRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Undeletes a WorkloadIdentityPoolProvider, as long as it was deleted fewer than 30 days ago.
                    /// </summary>
                    public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Undelete request.</summary>
                        public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolProviderRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the provider to undelete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolProviderRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "undelete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:undelete";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+/providers/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a new WorkloadIdentityPool. You cannot reuse the name of a deleted pool until 30 days after
                /// deletion.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource to create the pool in. The only supported location is `global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.WorkloadIdentityPool body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new WorkloadIdentityPool. You cannot reuse the name of a deleted pool until 30 days after
                /// deletion.
                /// </summary>
                public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPool body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource to create the pool in. The only supported location is `global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the pool, which becomes the final component of the resource name.
                    /// This value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
                    /// `gcp-` is reserved for use by Google, and may not be specified.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("workloadIdentityPoolId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WorkloadIdentityPoolId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.WorkloadIdentityPool Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/workloadIdentityPools";

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
                        RequestParameters.Add("workloadIdentityPoolId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "workloadIdentityPoolId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a WorkloadIdentityPool. You cannot use a deleted pool to exchange external credentials for
                /// Google Cloud credentials. However, deletion does not revoke credentials that have already been
                /// issued. Credentials issued for a deleted pool do not grant access to resources. If the pool is
                /// undeleted, and the credentials are not expired, they grant access again. You can undelete a pool for
                /// 30 days. After 30 days, deletion is permanent. You cannot update deleted pools. However, you can
                /// view and list them.
                /// </summary>
                /// <param name="name">Required. The name of the pool to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a WorkloadIdentityPool. You cannot use a deleted pool to exchange external credentials for
                /// Google Cloud credentials. However, deletion does not revoke credentials that have already been
                /// issued. Credentials issued for a deleted pool do not grant access to resources. If the pool is
                /// undeleted, and the credentials are not expired, they grant access again. You can undelete a pool for
                /// 30 days. After 30 days, deletion is permanent. You cannot update deleted pools. However, you can
                /// view and list them.
                /// </summary>
                public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the pool to delete.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets an individual WorkloadIdentityPool.</summary>
                /// <param name="name">Required. The name of the pool to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets an individual WorkloadIdentityPool.</summary>
                public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.WorkloadIdentityPool>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the pool to retrieve.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the IAM policy of a WorkloadIdentityPool.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.Iam.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Gets the IAM policy of a WorkloadIdentityPool.</summary>
                public class GetIamPolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Iam.v1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all non-deleted WorkloadIdentityPools in a project. If `show_deleted` is set to `true`, then
                /// deleted pools are also listed.
                /// </summary>
                /// <param name="parent">Required. The parent resource to list pools for.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all non-deleted WorkloadIdentityPools in a project. If `show_deleted` is set to `true`, then
                /// deleted pools are also listed.
                /// </summary>
                public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListWorkloadIdentityPoolsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource to list pools for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of pools to return. If unspecified, at most 50 pools are returned. The
                    /// maximum value is 1000; values above are 1000 truncated to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListWorkloadIdentityPools` call. Provide this to
                    /// retrieve the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Whether to return soft-deleted pools.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/workloadIdentityPools";

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

                /// <summary>Updates an existing WorkloadIdentityPool.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The resource name of the pool.</param>
                public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.WorkloadIdentityPool body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing WorkloadIdentityPool.</summary>
                public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.WorkloadIdentityPool body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The resource name of the pool.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.WorkloadIdentityPool Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
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

                /// <summary>Sets the IAM policies on a WorkloadIdentityPool</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Iam.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Sets the IAM policies on a WorkloadIdentityPool</summary>
                public class SetIamPolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Iam.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the caller's permissions on a WorkloadIdentityPool</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Iam.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>Returns the caller's permissions on a WorkloadIdentityPool</summary>
                public class TestIamPermissionsRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Iam.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Undeletes a WorkloadIdentityPool, as long as it was deleted fewer than 30 days ago.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the pool to undelete.</param>
                public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolRequest body, string name)
                {
                    return new UndeleteRequest(this.service, body, name);
                }

                /// <summary>
                /// Undeletes a WorkloadIdentityPool, as long as it was deleted fewer than 30 days ago.
                /// </summary>
                public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the pool to undelete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:undelete";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workloadIdentityPools/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>Gets the Roles resource.</summary>
        public virtual RolesResource Roles { get; }

        /// <summary>The "roles" collection of methods.</summary>
        public class RolesResource
        {
            private const string Resource = "roles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RolesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new custom Role.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// The `parent` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `parent` value format is described below: *
            /// [projects.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/create):
            /// `projects/{PROJECT_ID}`. This method creates project-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [organizations.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/create):
            /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.CreateRoleRequest body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a new custom Role.</summary>
            public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.CreateRoleRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The `parent` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `parent` value format is described below: *
                /// [projects.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/create):
                /// `projects/{PROJECT_ID}`. This method creates project-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [organizations.roles.create](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/create):
                /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
                /// invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.CreateRoleRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/roles";

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

            /// <summary>
            /// Deletes a custom Role. When you delete a custom role, the following changes occur immediately: * You
            /// cannot bind a principal to the custom role in an IAM Policy. * Existing bindings to the custom role are
            /// not changed, but they have no effect. * By default, the response from ListRoles does not include the
            /// custom role. A deleted custom role still counts toward the [custom role
            /// limit](https://cloud.google.com/iam/help/limits) until it is permanently deleted. You have 7 days to
            /// undelete the custom role. After 7 days, the following changes occur: * The custom role is permanently
            /// deleted and cannot be recovered. * If an IAM policy contains a binding to the custom role, the binding
            /// is permanently removed. * The custom role no longer counts toward your custom role limit.
            /// </summary>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [projects.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/delete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/delete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a custom Role. When you delete a custom role, the following changes occur immediately: * You
            /// cannot bind a principal to the custom role in an IAM Policy. * Existing bindings to the custom role are
            /// not changed, but they have no effect. * By default, the response from ListRoles does not include the
            /// custom role. A deleted custom role still counts toward the [custom role
            /// limit](https://cloud.google.com/iam/help/limits) until it is permanently deleted. You have 7 days to
            /// undelete the custom role. After 7 days, the following changes occur: * The custom role is permanently
            /// deleted and cannot be recovered. * If an IAM policy contains a binding to the custom role, the binding
            /// is permanently removed. * The custom role no longer counts toward your custom role limit.
            /// </summary>
            public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [projects.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/delete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.delete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/delete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Used to perform a consistent read-modify-write.</summary>
                [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Etag { get; set; }

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
                        Pattern = @"^projects/[^/]+/roles/[^/]+$",
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

            /// <summary>Gets the definition of a Role.</summary>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This
            /// method returns results from all [predefined
            /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example request
            /// URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
            /// [projects.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/get):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/get):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the definition of a Role.</summary>
            public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`.
                /// This method returns results from all [predefined
                /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example
                /// request URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
                /// [projects.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/get):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/get):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
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
                        Pattern = @"^projects/[^/]+/roles/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists every predefined Role that IAM supports, or every custom role that is defined for an organization
            /// or project.
            /// </summary>
            /// <param name="parent">
            /// The `parent` parameter's value depends on the target resource for the request, namely
            /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `parent` value format is described below: *
            /// [roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/roles/list): An empty string. This
            /// method doesn't require a resource; it simply returns all [predefined
            /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example request
            /// URL: `https://iam.googleapis.com/v1/roles` *
            /// [projects.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/list):
            /// `projects/{PROJECT_ID}`. This method lists all project-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [organizations.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/list):
            /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists every predefined Role that IAM supports, or every custom role that is defined for an organization
            /// or project.
            /// </summary>
            public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListRolesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The `parent` parameter's value depends on the target resource for the request, namely
                /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `parent` value format is described below: *
                /// [roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/roles/list): An empty string. This
                /// method doesn't require a resource; it simply returns all [predefined
                /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example
                /// request URL: `https://iam.googleapis.com/v1/roles` *
                /// [projects.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/list):
                /// `projects/{PROJECT_ID}`. This method lists all project-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [organizations.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/list):
                /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
                /// invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional limit on the number of roles to include in the response. The default is 300, and the
                /// maximum is 1,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional pagination token returned in an earlier ListRolesResponse.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Include Roles that have been deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>
                /// Optional view for the returned Role objects. When `FULL` is specified, the `includedPermissions`
                /// field is returned, which includes a list of all permissions in the role. The default value is
                /// `BASIC`, which does not return the `includedPermissions` field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// Optional view for the returned Role objects. When `FULL` is specified, the `includedPermissions`
                /// field is returned, which includes a list of all permissions in the role. The default value is
                /// `BASIC`, which does not return the `includedPermissions` field.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>Omits the `included_permissions` field. This is the default value.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 0,

                    /// <summary>Returns all fields.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/roles";

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

            /// <summary>Updates the definition of a custom Role.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [projects.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/patch):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/patch):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.Role body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates the definition of a custom Role.</summary>
            public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.Role body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [projects.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/patch):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.patch](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/patch):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>A mask describing which fields in the Role have changed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.Role Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/roles/[^/]+$",
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

            /// <summary>Undeletes a custom Role.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [projects.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/undelete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/undelete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteRoleRequest body, string name)
            {
                return new UndeleteRequest(this.service, body, name);
            }

            /// <summary>Undeletes a custom Role.</summary>
            public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteRoleRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The `name` parameter's value depends on the target resource for the request, namely
                /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles) or
                /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each
                /// resource type's `name` value format is described below: *
                /// [projects.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/undelete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// project level. Example request URL:
                /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [organizations.roles.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/undelete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
                /// organization level. Example request URL:
                /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
                /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.UndeleteRoleRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:undelete";

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
                        Pattern = @"^projects/[^/]+/roles/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the ServiceAccounts resource.</summary>
        public virtual ServiceAccountsResource ServiceAccounts { get; }

        /// <summary>The "serviceAccounts" collection of methods.</summary>
        public class ServiceAccountsResource
        {
            private const string Resource = "serviceAccounts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServiceAccountsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Keys = new KeysResource(service);
            }

            /// <summary>Gets the Keys resource.</summary>
            public virtual KeysResource Keys { get; }

            /// <summary>The "keys" collection of methods.</summary>
            public class KeysResource
            {
                private const string Resource = "keys";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public KeysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a ServiceAccountKey.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.CreateServiceAccountKeyRequest body, string name)
                {
                    return new CreateRequest(this.service, body, name);
                }

                /// <summary>Creates a ServiceAccountKey.</summary>
                public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ServiceAccountKey>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.CreateServiceAccountKeyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the service account. Use one of the following formats: *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-`
                    /// wildcard character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                    /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                    /// because it can cause response messages to contain misleading error codes. For example, if you
                    /// try to access the service account `projects/-/serviceAccounts/fake@example.com`, which does not
                    /// exist, the response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.CreateServiceAccountKeyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}/keys";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a ServiceAccountKey. Deleting a service account key does not revoke short-lived credentials
                /// that have been issued based on the service account key.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the service account key. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use the
                /// `-` wildcard character instead of the project ID: *
                /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-` wildcard
                /// character, because it can cause response messages to contain misleading error codes. For example, if
                /// you try to access the service account key
                /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a ServiceAccountKey. Deleting a service account key does not revoke short-lived credentials
                /// that have been issued based on the service account key.
                /// </summary>
                public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the service account key. Use one of the following formats: *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use
                    /// the `-` wildcard character instead of the project ID: *
                    /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-`
                    /// wildcard character, because it can cause response messages to contain misleading error codes.
                    /// For example, if you try to access the service account key
                    /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                    /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
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
                            Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+/keys/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Disable a ServiceAccountKey. A disabled service account key can be re-enabled with
                /// EnableServiceAccountKey.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the service account key. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use the
                /// `-` wildcard character instead of the project ID: *
                /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-` wildcard
                /// character, because it can cause response messages to contain misleading error codes. For example, if
                /// you try to access the service account key
                /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </param>
                public virtual DisableRequest Disable(Google.Apis.Iam.v1.Data.DisableServiceAccountKeyRequest body, string name)
                {
                    return new DisableRequest(this.service, body, name);
                }

                /// <summary>
                /// Disable a ServiceAccountKey. A disabled service account key can be re-enabled with
                /// EnableServiceAccountKey.
                /// </summary>
                public class DisableRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Disable request.</summary>
                    public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.DisableServiceAccountKeyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the service account key. Use one of the following formats: *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use
                    /// the `-` wildcard character instead of the project ID: *
                    /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-`
                    /// wildcard character, because it can cause response messages to contain misleading error codes.
                    /// For example, if you try to access the service account key
                    /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                    /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.DisableServiceAccountKeyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "disable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:disable";

                    /// <summary>Initializes Disable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+/keys/[^/]+$",
                        });
                    }
                }

                /// <summary>Enable a ServiceAccountKey.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the service account key. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use the
                /// `-` wildcard character instead of the project ID: *
                /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-` wildcard
                /// character, because it can cause response messages to contain misleading error codes. For example, if
                /// you try to access the service account key
                /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </param>
                public virtual EnableRequest Enable(Google.Apis.Iam.v1.Data.EnableServiceAccountKeyRequest body, string name)
                {
                    return new EnableRequest(this.service, body, name);
                }

                /// <summary>Enable a ServiceAccountKey.</summary>
                public class EnableRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Enable request.</summary>
                    public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.EnableServiceAccountKeyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the service account key. Use one of the following formats: *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use
                    /// the `-` wildcard character instead of the project ID: *
                    /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-`
                    /// wildcard character, because it can cause response messages to contain misleading error codes.
                    /// For example, if you try to access the service account key
                    /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                    /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.EnableServiceAccountKeyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:enable";

                    /// <summary>Initializes Enable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+/keys/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a ServiceAccountKey.</summary>
                /// <param name="name">
                /// Required. The resource name of the service account key. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use the
                /// `-` wildcard character instead of the project ID: *
                /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-` wildcard
                /// character, because it can cause response messages to contain misleading error codes. For example, if
                /// you try to access the service account key
                /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a ServiceAccountKey.</summary>
                public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ServiceAccountKey>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the service account key. Use one of the following formats: *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` As an alternative, you can use
                    /// the `-` wildcard character instead of the project ID: *
                    /// `projects/-/serviceAccounts/{EMAIL_ADDRESS}/keys/{KEY_ID}` *
                    /// `projects/-/serviceAccounts/{UNIQUE_ID}/keys/{KEY_ID}` When possible, avoid using the `-`
                    /// wildcard character, because it can cause response messages to contain misleading error codes.
                    /// For example, if you try to access the service account key
                    /// `projects/-/serviceAccounts/fake@example.com/keys/fake-key`, which does not exist, the response
                    /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The output format of the public key. The default is `TYPE_NONE`, which means that the
                    /// public key is not returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("publicKeyType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<PublicKeyTypeEnum> PublicKeyType { get; set; }

                    /// <summary>
                    /// Optional. The output format of the public key. The default is `TYPE_NONE`, which means that the
                    /// public key is not returned.
                    /// </summary>
                    public enum PublicKeyTypeEnum
                    {
                        /// <summary>Do not return the public key.</summary>
                        [Google.Apis.Util.StringValueAttribute("TYPE_NONE")]
                        TYPENONE = 0,

                        /// <summary>X509 PEM format.</summary>
                        [Google.Apis.Util.StringValueAttribute("TYPE_X509_PEM_FILE")]
                        TYPEX509PEMFILE = 1,

                        /// <summary>Raw public key.</summary>
                        [Google.Apis.Util.StringValueAttribute("TYPE_RAW_PUBLIC_KEY")]
                        TYPERAWPUBLICKEY = 2,
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
                            Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+/keys/[^/]+$",
                        });
                        RequestParameters.Add("publicKeyType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "publicKeyType",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists every ServiceAccountKey for a service account.</summary>
                /// <param name="name">
                /// Required. The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>Lists every ServiceAccountKey for a service account.</summary>
                public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListServiceAccountKeysResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the service account. Use one of the following formats: *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-`
                    /// wildcard character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                    /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                    /// because it can cause response messages to contain misleading error codes. For example, if you
                    /// try to access the service account `projects/-/serviceAccounts/fake@example.com`, which does not
                    /// exist, the response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Filters the types of keys the user wants to include in the list response. Duplicate key types
                    /// are not allowed. If no key type is provided, all keys are returned.
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or <see cref="KeyTypesList"/> to set
                    /// multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("keyTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<KeyTypesEnum> KeyTypes { get; set; }

                    /// <summary>
                    /// Filters the types of keys the user wants to include in the list response. Duplicate key types
                    /// are not allowed. If no key type is provided, all keys are returned.
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="KeyTypes"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("keyTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<KeyTypesEnum> KeyTypesList { get; set; }

                    /// <summary>
                    /// Filters the types of keys the user wants to include in the list response. Duplicate key types
                    /// are not allowed. If no key type is provided, all keys are returned.
                    /// </summary>
                    public enum KeyTypesEnum
                    {
                        /// <summary>
                        /// Unspecified key type. The presence of this in the message will immediately result in an
                        /// error.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("KEY_TYPE_UNSPECIFIED")]
                        KEYTYPEUNSPECIFIED = 0,

                        /// <summary>User-managed keys (managed and rotated by the user).</summary>
                        [Google.Apis.Util.StringValueAttribute("USER_MANAGED")]
                        USERMANAGED = 1,

                        /// <summary>System-managed keys (managed and rotated by Google).</summary>
                        [Google.Apis.Util.StringValueAttribute("SYSTEM_MANAGED")]
                        SYSTEMMANAGED = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}/keys";

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
                            Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                        });
                        RequestParameters.Add("keyTypes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "keyTypes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Uploads the public key portion of a key pair that you manage, and associates the public key with a
                /// ServiceAccount. After you upload the public key, you can use the private key from the key pair as a
                /// service account key.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the service account key. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </param>
                public virtual UploadRequest Upload(Google.Apis.Iam.v1.Data.UploadServiceAccountKeyRequest body, string name)
                {
                    return new UploadRequest(this.service, body, name);
                }

                /// <summary>
                /// Uploads the public key portion of a key pair that you manage, and associates the public key with a
                /// ServiceAccount. After you upload the public key, you can use the private key from the key pair as a
                /// service account key.
                /// </summary>
                public class UploadRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ServiceAccountKey>
                {
                    /// <summary>Constructs a new Upload request.</summary>
                    public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UploadServiceAccountKeyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the service account key. Use one of the following formats: *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                    /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-`
                    /// wildcard character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                    /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                    /// because it can cause response messages to contain misleading error codes. For example, if you
                    /// try to access the service account `projects/-/serviceAccounts/fake@example.com`, which does not
                    /// exist, the response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Iam.v1.Data.UploadServiceAccountKeyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "upload";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}/keys:upload";

                    /// <summary>Initializes Upload parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Creates a ServiceAccount.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the project associated with the service accounts, such as
            /// `projects/my-project-123`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.CreateServiceAccountRequest body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>Creates a ServiceAccount.</summary>
            public class CreateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ServiceAccount>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.CreateServiceAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project associated with the service accounts, such as
                /// `projects/my-project-123`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.CreateServiceAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/serviceAccounts";

                /// <summary>Initializes Create parameter list.</summary>
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
            /// Deletes a ServiceAccount. **Warning:** After you delete a service account, you might not be able to
            /// undelete it. If you know that you need to re-enable the service account in the future, use
            /// DisableServiceAccount instead. If you delete a service account, IAM permanently removes the service
            /// account 30 days later. Google Cloud cannot recover the service account after it is permanently removed,
            /// even if you file a support request. To help avoid unplanned outages, we recommend that you disable the
            /// service account before you delete it. Use DisableServiceAccount to disable the service account, then
            /// wait at least 24 hours and watch for unintended consequences. If there are no unintended consequences,
            /// you can delete the service account.
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a ServiceAccount. **Warning:** After you delete a service account, you might not be able to
            /// undelete it. If you know that you need to re-enable the service account in the future, use
            /// DisableServiceAccount instead. If you delete a service account, IAM permanently removes the service
            /// account 30 days later. Google Cloud cannot recover the service account after it is permanently removed,
            /// even if you file a support request. To help avoid unplanned outages, we recommend that you disable the
            /// service account before you delete it. Use DisableServiceAccount to disable the service account, then
            /// wait at least 24 hours and watch for unintended consequences. If there are no unintended consequences,
            /// you can delete the service account.
            /// </summary>
            public class DeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Disables a ServiceAccount immediately. If an application uses the service account to authenticate, that
            /// application can no longer call Google APIs or access Google Cloud resources. Existing access tokens for
            /// the service account are rejected, and requests for new access tokens will fail. To re-enable the service
            /// account, use EnableServiceAccount. After you re-enable the service account, its existing access tokens
            /// will be accepted, and you can request new access tokens. To help avoid unplanned outages, we recommend
            /// that you disable the service account before you delete it. Use this method to disable the service
            /// account, then wait at least 24 hours and watch for unintended consequences. If there are no unintended
            /// consequences, you can delete the service account with DeleteServiceAccount.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual DisableRequest Disable(Google.Apis.Iam.v1.Data.DisableServiceAccountRequest body, string name)
            {
                return new DisableRequest(this.service, body, name);
            }

            /// <summary>
            /// Disables a ServiceAccount immediately. If an application uses the service account to authenticate, that
            /// application can no longer call Google APIs or access Google Cloud resources. Existing access tokens for
            /// the service account are rejected, and requests for new access tokens will fail. To re-enable the service
            /// account, use EnableServiceAccount. After you re-enable the service account, its existing access tokens
            /// will be accepted, and you can request new access tokens. To help avoid unplanned outages, we recommend
            /// that you disable the service account before you delete it. Use this method to disable the service
            /// account, then wait at least 24 hours and watch for unintended consequences. If there are no unintended
            /// consequences, you can delete the service account with DeleteServiceAccount.
            /// </summary>
            public class DisableRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Empty>
            {
                /// <summary>Constructs a new Disable request.</summary>
                public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.DisableServiceAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.DisableServiceAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "disable";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:disable";

                /// <summary>Initializes Disable parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Enables a ServiceAccount that was disabled by DisableServiceAccount. If the service account is already
            /// enabled, then this method has no effect. If the service account was disabled by other means—for example,
            /// if Google disabled the service account because it was compromised—you cannot use this method to enable
            /// the service account.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual EnableRequest Enable(Google.Apis.Iam.v1.Data.EnableServiceAccountRequest body, string name)
            {
                return new EnableRequest(this.service, body, name);
            }

            /// <summary>
            /// Enables a ServiceAccount that was disabled by DisableServiceAccount. If the service account is already
            /// enabled, then this method has no effect. If the service account was disabled by other means—for example,
            /// if Google disabled the service account because it was compromised—you cannot use this method to enable
            /// the service account.
            /// </summary>
            public class EnableRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Empty>
            {
                /// <summary>Constructs a new Enable request.</summary>
                public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.EnableServiceAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.EnableServiceAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enable";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:enable";

                /// <summary>Initializes Enable parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a ServiceAccount.</summary>
            /// <param name="name">
            /// Required. The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a ServiceAccount.</summary>
            public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ServiceAccount>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the IAM policy that is attached to a ServiceAccount. This IAM policy specifies which principals
            /// have access to the service account. This method does not tell you whether the service account has been
            /// granted any roles on other resources. To check whether a service account has role grants on a resource,
            /// use the `getIamPolicy` method for that resource. For example, to view the role grants for a project,
            /// call the Resource Manager API's
            /// [projects.getIamPolicy](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
            /// method.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the IAM policy that is attached to a ServiceAccount. This IAM policy specifies which principals
            /// have access to the service account. This method does not tell you whether the service account has been
            /// granted any roles on other resources. To check whether a service account has role grants on a resource,
            /// use the `getIamPolicy` method for that resource. For example, to view the role grants for a project,
            /// call the Resource Manager API's
            /// [projects.getIamPolicy](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
            /// method.
            /// </summary>
            public class GetIamPolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Policy>
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
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
                /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
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

            /// <summary>Lists every ServiceAccount that belongs to a specific project.</summary>
            /// <param name="name">
            /// Required. The resource name of the project associated with the service accounts, such as
            /// `projects/my-project-123`.
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists every ServiceAccount that belongs to a specific project.</summary>
            public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListServiceAccountsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the project associated with the service accounts, such as
                /// `projects/my-project-123`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional limit on the number of service accounts to include in the response. Further accounts can
                /// subsequently be obtained by including the ListServiceAccountsResponse.next_page_token in a
                /// subsequent request. The default is 20, and the maximum is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional pagination token returned in an earlier ListServiceAccountsResponse.next_page_token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/serviceAccounts";

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

            /// <summary>Patches a ServiceAccount.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.PatchServiceAccountRequest body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Patches a ServiceAccount.</summary>
            public class PatchRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ServiceAccount>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.PatchServiceAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.PatchServiceAccountRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Sets the IAM policy that is attached to a ServiceAccount. Use this method to grant or revoke access to
            /// the service account. For example, you could grant a principal the ability to impersonate the service
            /// account. This method does not enable the service account to access other resources. To grant roles to a
            /// service account on a resource, follow these steps: 1. Call the resource's `getIamPolicy` method to get
            /// its current IAM policy. 2. Edit the policy so that it binds the service account to an IAM role for the
            /// resource. 3. Call the resource's `setIamPolicy` method to update its IAM policy. For detailed
            /// instructions, see [Manage access to project, folders, and
            /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
            /// or [Manage access to other resources](https://cloud.google.com/iam/help/access/manage-other-resources).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Iam.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the IAM policy that is attached to a ServiceAccount. Use this method to grant or revoke access to
            /// the service account. For example, you could grant a principal the ability to impersonate the service
            /// account. This method does not enable the service account to access other resources. To grant roles to a
            /// service account on a resource, follow these steps: 1. Call the resource's `getIamPolicy` method to get
            /// its current IAM policy. 2. Edit the policy so that it binds the service account to an IAM role for the
            /// resource. 3. Call the resource's `setIamPolicy` method to update its IAM policy. For detailed
            /// instructions, see [Manage access to project, folders, and
            /// organizations](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts)
            /// or [Manage access to other resources](https://cloud.google.com/iam/help/access/manage-other-resources).
            /// </summary>
            public class SetIamPolicyRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Iam.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary> Signs a blob using the system-managed private key for a ServiceAccount.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Deprecated. [Migrate to Service Account Credentials
            /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The resource name of the service
            /// account. Use one of the following formats: * `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual SignBlobRequest SignBlob(Google.Apis.Iam.v1.Data.SignBlobRequest body, string name)
            {
                return new SignBlobRequest(this.service, body, name);
            }

            /// <summary> Signs a blob using the system-managed private key for a ServiceAccount.</summary>
            public class SignBlobRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.SignBlobResponse>
            {
                /// <summary>Constructs a new SignBlob request.</summary>
                public SignBlobRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.SignBlobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Deprecated. [Migrate to Service Account Credentials
                /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The resource name of the service
                /// account. Use one of the following formats: * `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}`
                /// * `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-`
                /// wildcard character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.SignBlobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "signBlob";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:signBlob";

                /// <summary>Initializes SignBlob parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            ///  Signs a JSON Web Token (JWT) using the system-managed private key for a ServiceAccount.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Deprecated. [Migrate to Service Account Credentials
            /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The resource name of the service
            /// account. Use one of the following formats: * `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual SignJwtRequest SignJwt(Google.Apis.Iam.v1.Data.SignJwtRequest body, string name)
            {
                return new SignJwtRequest(this.service, body, name);
            }

            /// <summary>
            ///  Signs a JSON Web Token (JWT) using the system-managed private key for a ServiceAccount.
            /// </summary>
            public class SignJwtRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.SignJwtResponse>
            {
                /// <summary>Constructs a new SignJwt request.</summary>
                public SignJwtRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.SignJwtRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Deprecated. [Migrate to Service Account Credentials
                /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The resource name of the service
                /// account. Use one of the following formats: * `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}`
                /// * `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-`
                /// wildcard character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.SignJwtRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "signJwt";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:signJwt";

                /// <summary>Initializes SignJwt parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>Tests whether the caller has the specified permissions on a ServiceAccount.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Iam.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>Tests whether the caller has the specified permissions on a ServiceAccount.</summary>
            public class TestIamPermissionsRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Iam.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Restores a deleted ServiceAccount. **Important:** It is not always possible to restore a deleted service
            /// account. Use this method only as a last resort. After you delete a service account, IAM permanently
            /// removes the service account 30 days later. There is no way to restore a deleted service account that has
            /// been permanently removed.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteServiceAccountRequest body, string name)
            {
                return new UndeleteRequest(this.service, body, name);
            }

            /// <summary>
            /// Restores a deleted ServiceAccount. **Important:** It is not always possible to restore a deleted service
            /// account. Use this method only as a last resort. After you delete a service account, IAM permanently
            /// removes the service account 30 days later. There is no way to restore a deleted service account that has
            /// been permanently removed.
            /// </summary>
            public class UndeleteRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.UndeleteServiceAccountResponse>
            {
                /// <summary>Constructs a new Undelete request.</summary>
                public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.UndeleteServiceAccountRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.UndeleteServiceAccountRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "undelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:undelete";

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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// **Note:** We are in the process of deprecating this method. Use PatchServiceAccount instead. Updates a
            /// ServiceAccount. You can update only the `display_name` field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to access the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Iam.v1.Data.ServiceAccount body, string name)
            {
                return new UpdateRequest(this.service, body, name);
            }

            /// <summary>
            /// **Note:** We are in the process of deprecating this method. Use PatchServiceAccount instead. Updates a
            /// ServiceAccount. You can update only the `display_name` field.
            /// </summary>
            public class UpdateRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ServiceAccount>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.ServiceAccount body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the service account. Use one of the following formats: *
                /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
                /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
                /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character,
                /// because it can cause response messages to contain misleading error codes. For example, if you try to
                /// access the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
                /// response contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Iam.v1.Data.ServiceAccount Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "roles" collection of methods.</summary>
    public class RolesResource
    {
        private const string Resource = "roles";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RolesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the definition of a Role.</summary>
        /// <param name="name">
        /// The `name` parameter's value depends on the target resource for the request, namely
        /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
        /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
        /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
        /// type's `name` value format is described below: *
        /// [roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This method
        /// returns results from all [predefined
        /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example request URL:
        /// `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
        /// [projects.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/get):
        /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
        /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the project
        /// level. Example request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
        /// [organizations.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/get):
        /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
        /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
        /// organization level. Example request URL:
        /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard (*)
        /// values are invalid; you must specify a complete project ID or organization ID.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets the definition of a Role.</summary>
        public class GetRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.Role>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `name` value format is described below: *
            /// [roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This
            /// method returns results from all [predefined
            /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example request
            /// URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
            /// [projects.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/get):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// project level. Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [organizations.roles.get](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/get):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been created at the
            /// organization level. Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note: Wildcard
            /// (*) values are invalid; you must specify a complete project ID or organization ID.
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
                    Pattern = @"^roles/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists every predefined Role that IAM supports, or every custom role that is defined for an organization or
        /// project.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists every predefined Role that IAM supports, or every custom role that is defined for an organization or
        /// project.
        /// </summary>
        public class ListRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.ListRolesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional limit on the number of roles to include in the response. The default is 300, and the maximum is
            /// 1,000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional pagination token returned in an earlier ListRolesResponse.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// The `parent` parameter's value depends on the target resource for the request, namely
            /// [roles](https://cloud.google.com/iam/docs/reference/rest/v1/roles),
            /// [projects](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles), or
            /// [organizations](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles). Each resource
            /// type's `parent` value format is described below: *
            /// [roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/roles/list): An empty string. This
            /// method doesn't require a resource; it simply returns all [predefined
            /// roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in IAM. Example request
            /// URL: `https://iam.googleapis.com/v1/roles` *
            /// [projects.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/projects.roles/list):
            /// `projects/{PROJECT_ID}`. This method lists all project-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [organizations.roles.list](https://cloud.google.com/iam/docs/reference/rest/v1/organizations.roles/list):
            /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
            /// roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Include Roles that have been deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>
            /// Optional view for the returned Role objects. When `FULL` is specified, the `includedPermissions` field
            /// is returned, which includes a list of all permissions in the role. The default value is `BASIC`, which
            /// does not return the `includedPermissions` field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>
            /// Optional view for the returned Role objects. When `FULL` is specified, the `includedPermissions` field
            /// is returned, which includes a list of all permissions in the role. The default value is `BASIC`, which
            /// does not return the `includedPermissions` field.
            /// </summary>
            public enum ViewEnum
            {
                /// <summary>Omits the `included_permissions` field. This is the default value.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>Returns all fields.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/roles";

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
        /// Lists roles that can be granted on a Google Cloud resource. A role is grantable if the IAM policy for the
        /// resource can contain bindings to the role.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryGrantableRolesRequest QueryGrantableRoles(Google.Apis.Iam.v1.Data.QueryGrantableRolesRequest body)
        {
            return new QueryGrantableRolesRequest(this.service, body);
        }

        /// <summary>
        /// Lists roles that can be granted on a Google Cloud resource. A role is grantable if the IAM policy for the
        /// resource can contain bindings to the role.
        /// </summary>
        public class QueryGrantableRolesRequest : IamBaseServiceRequest<Google.Apis.Iam.v1.Data.QueryGrantableRolesResponse>
        {
            /// <summary>Constructs a new QueryGrantableRoles request.</summary>
            public QueryGrantableRolesRequest(Google.Apis.Services.IClientService service, Google.Apis.Iam.v1.Data.QueryGrantableRolesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Iam.v1.Data.QueryGrantableRolesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryGrantableRoles";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/roles:queryGrantableRoles";

            /// <summary>Initializes QueryGrantableRoles parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Iam.v1.Data
{
    /// <summary>Access related restrictions on the workforce pool.</summary>
    public class AccessRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. Services allowed for web sign-in with the workforce pool. If not set by default there
        /// are no restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedServices")]
        public virtual System.Collections.Generic.IList<ServiceConfig> AllowedServices { get; set; }

        /// <summary>
        /// Optional. Disable programmatic sign-in by disabling token issue via the Security Token API endpoint. See
        /// [Security Token Service API] (https://cloud.google.com/iam/docs/reference/sts/rest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableProgrammaticSignin")]
        public virtual System.Nullable<bool> DisableProgrammaticSignin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AddAttestationRule.</summary>
    public class AddAttestationRuleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attestation rule to be added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationRule")]
        public virtual AttestationRule AttestationRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Audit log information specific to Cloud IAM admin APIs. This message is serialized as an `Any` type in the
    /// `ServiceData` message of an `AuditLog` message.
    /// </summary>
    public class AdminAuditData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The permission_delta when when creating or updating a Role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionDelta")]
        public virtual PermissionDelta PermissionDelta { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines which workloads can receive an identity within a pool. When an AttestationRule is defined under a
    /// managed identity, matching workloads may receive that identity.
    /// </summary>
    public class AttestationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A single workload operating on Google Cloud. For example:
        /// `//compute.googleapis.com/projects/123/uid/zones/us-central1-a/instances/12345`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudResource")]
        public virtual string GoogleCloudResource { get; set; }

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
    /// Audit log information specific to Cloud IAM. This message is serialized as an `Any` type in the `ServiceData`
    /// message of an `AuditLog` message.
    /// </summary>
    public class AuditData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policy delta between the original policy and the newly set policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDelta")]
        public virtual PolicyDelta PolicyDelta { get; set; }

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

    /// <summary>Contains information about an auditable service.</summary>
    public class AuditableService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Public name of the service. For example, the service name for IAM is 'iam.googleapis.com'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Amazon Web Services identity provider.</summary>
    public class Aws : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The AWS account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

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

    /// <summary>
    /// One delta entry for Binding. Each individual change (only one member in each entry) to a binding will be a
    /// separate entry.
    /// </summary>
    public class BindingDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action that was performed on a Binding. Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The condition that is associated with this binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// A single identity requesting access for a Google Cloud resource. Follows the same format of Binding.members.
        /// Required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`. Required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to create a new role.</summary>
    public class CreateRoleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Role resource to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual Role Role { get; set; }

        /// <summary>
        /// The role ID to use for this role. A role ID may contain alphanumeric characters, underscores (`_`), and
        /// periods (`.`). It must contain a minimum of 3 characters and a maximum of 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleId")]
        public virtual string RoleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account key create request.</summary>
    public class CreateServiceAccountKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Which type of key and algorithm to use for the key. The default is currently a 2K RSA key. However this may
        /// change in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyAlgorithm")]
        public virtual string KeyAlgorithm { get; set; }

        /// <summary>
        /// The output format of the private key. The default value is `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the
        /// Google Credentials File format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyType")]
        public virtual string PrivateKeyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account create request.</summary>
    public class CreateServiceAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The account id that is used to generate the service account email address and a stable unique id.
        /// It is unique within a project, must be 6-30 characters long, and match the regular expression
        /// `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// The ServiceAccount resource to create. Currently, only the following values are user assignable:
        /// `display_name` and `description`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account key disable request.</summary>
    public class DisableServiceAccountKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Usable by internal google services only. An extended_status_message can be used to include
        /// additional information about the key, such as its private key data being exposed on a public repository like
        /// GitHub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedStatusMessage")]
        public virtual string ExtendedStatusMessage { get; set; }

        /// <summary>
        /// Optional. Describes the reason this key is being disabled. If unspecified, the default value of
        /// SERVICE_ACCOUNT_KEY_DISABLE_REASON_USER_INITIATED will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyDisableReason")]
        public virtual string ServiceAccountKeyDisableReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account disable request.</summary>
    public class DisableServiceAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>The service account key enable request.</summary>
    public class EnableServiceAccountKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account enable request.</summary>
    public class EnableServiceAccountRequest : Google.Apis.Requests.IDirectResponseSchema
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
    /// Extended status can store additional metadata. For example, for keys disabled due to their private key data
    /// being expoesed we may include a message with more information about the exposure.
    /// </summary>
    public class ExtendedStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key for this extended status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value for the extended status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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

    /// <summary>
    /// Represents the OAuth 2.0 client credential configuration for retrieving additional user attributes that are not
    /// present in the initial authentication credentials from the identity provider, e.g. groups. See
    /// https://datatracker.ietf.org/doc/html/rfc6749#section-4.4 for more details on client credentials grant flow.
    /// </summary>
    public class GoogleIamAdminV1WorkforcePoolProviderExtraAttributesOAuth2Client : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Represents the IdP and type of claims that should be fetched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributesType")]
        public virtual string AttributesType { get; set; }

        /// <summary>
        /// Required. The OAuth 2.0 client ID for retrieving extra attributes from the identity provider. Required to
        /// get the Access Token using client credentials grant flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Required. The OAuth 2.0 client secret for retrieving extra attributes from the identity provider. Required
        /// to get the Access Token using client credentials grant flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderOidcClientSecret ClientSecret { get; set; }

        /// <summary>
        /// Required. The OIDC identity provider's issuer URI. Must be a valid URI using the `https` scheme. Required to
        /// get the OIDC discovery document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerUri")]
        public virtual string IssuerUri { get; set; }

        /// <summary>Optional. Represents the parameters to control which claims are fetched from an IdP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderExtraAttributesOAuth2ClientQueryParameters QueryParameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the parameters to control which claims are fetched from an IdP.</summary>
    public class GoogleIamAdminV1WorkforcePoolProviderExtraAttributesOAuth2ClientQueryParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The filter used to request specific records from the IdP. By default, all of the groups that are
        /// associated with a user are fetched. For Microsoft Entra ID, you can add `$search` query parameters using
        /// [Keyword Query Language]
        /// (https://learn.microsoft.com/en-us/sharepoint/dev/general-development/keyword-query-language-kql-syntax-reference).
        /// To learn more about `$search` querying in Microsoft Entra ID, see [Use the `$search` query parameter]
        /// (https://learn.microsoft.com/en-us/graph/search-query-parameter). Additionally, Workforce Identity
        /// Federation automatically adds the following [`$filter` query parameters]
        /// (https://learn.microsoft.com/en-us/graph/filter-query-parameter), based on the value of `attributes_type`.
        /// Values passed to `filter` are converted to `$search` query parameters. Additional `$filter` query parameters
        /// cannot be added using this field. * `AZURE_AD_GROUPS_MAIL`: `mailEnabled` and `securityEnabled` filters are
        /// applied. * `AZURE_AD_GROUPS_ID`: `securityEnabled` filter is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an OpenId Connect 1.0 identity provider.</summary>
    public class GoogleIamAdminV1WorkforcePoolProviderOidc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The client ID. Must match the audience claim of the JWT issued by the identity provider.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Optional. The optional client secret. Required to enable Authorization Code flow for web sign-in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderOidcClientSecret ClientSecret { get; set; }

        /// <summary>Required. The OIDC issuer URI. Must be a valid URI using the `https` scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerUri")]
        public virtual string IssuerUri { get; set; }

        /// <summary>
        /// Optional. OIDC JWKs in JSON String format. For details on the definition of a JWK, see
        /// https://tools.ietf.org/html/rfc7517. If not set, the `jwks_uri` from the discovery document(fetched from the
        /// .well-known path of the `issuer_uri`) will be used. Currently, RSA and EC asymmetric keys are supported. The
        /// JWK must use following format and include only the following fields: { "keys": [ { "kty": "RSA/EC", "alg":
        /// "", "use": "sig", "kid": "", "n": "", "e": "", "x": "", "y": "", "crv": "" } ] }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwksJson")]
        public virtual string JwksJson { get; set; }

        /// <summary>
        /// Required. Configuration for web single sign-on for the OIDC provider. Here, web sign-in refers to console
        /// sign-in and gcloud sign-in through the browser.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webSsoConfig")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderOidcWebSsoConfig WebSsoConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a client secret configured for the OIDC provider.</summary>
    public class GoogleIamAdminV1WorkforcePoolProviderOidcClientSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of the client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderOidcClientSecretValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of the value of the client secret.</summary>
    public class GoogleIamAdminV1WorkforcePoolProviderOidcClientSecretValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Input only. The plain text of the client secret value. For security reasons, this field is only
        /// used for input and will never be populated in any response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plainText")]
        public virtual string PlainText { get; set; }

        /// <summary>Output only. A thumbprint to represent the current client secret value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbprint")]
        public virtual string Thumbprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for web single sign-on for the OIDC provider.</summary>
    public class GoogleIamAdminV1WorkforcePoolProviderOidcWebSsoConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional scopes to request for in the OIDC authentication request on top of scopes requested by
        /// default. By default, the `openid`, `profile` and `email` scopes that are supported by the identity provider
        /// are requested. Each additional scope may be at most 256 characters. A maximum of 10 additional scopes may be
        /// configured.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalScopes")]
        public virtual System.Collections.Generic.IList<string> AdditionalScopes { get; set; }

        /// <summary>
        /// Required. The behavior for how OIDC Claims are included in the `assertion` object used for attribute mapping
        /// and attribute condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assertionClaimsBehavior")]
        public virtual string AssertionClaimsBehavior { get; set; }

        /// <summary>
        /// Required. The Response Type to request for in the OIDC Authorization Request for web sign-in. The `CODE`
        /// Response Type is recommended to avoid the Implicit Flow, for security reasons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseType")]
        public virtual string ResponseType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a SAML identity provider.</summary>
    public class GoogleIamAdminV1WorkforcePoolProviderSaml : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. SAML Identity provider configuration metadata xml doc. The xml document should comply with [SAML
        /// 2.0 specification](https://docs.oasis-open.org/security/saml/v2.0/saml-metadata-2.0-os.pdf). The max size of
        /// the acceptable xml document will be bounded to 128k characters. The metadata xml document should satisfy the
        /// following constraints: 1) Must contain an Identity Provider Entity ID. 2) Must contain at least one
        /// non-expired signing key certificate. 3) For each signing key: a) Valid from should be no more than 7 days
        /// from now. b) Valid to should be no more than 25 years in the future. 4) Up to 3 IdP signing keys are allowed
        /// in the metadata xml. When updating the provider's metadata xml, at least one non-expired signing key must
        /// overlap with the existing metadata. This requirement is skipped if there are no non-expired signing keys
        /// present in the existing metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idpMetadataXml")]
        public virtual string IdpMetadataXml { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents configuration for generating mutual TLS (mTLS) certificates for the identities within this pool.
    /// </summary>
    public class InlineCertificateIssuanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A required mapping of a Google Cloud region to the CA pool resource located in that region. The CA
        /// pool is used for certificate issuance, adhering to the following constraints: * Key format: A supported
        /// cloud region name equivalent to the location identifier in the corresponding map entry's value. * Value
        /// format: A valid CA pool resource path format like:
        /// "projects/{project}/locations/{location}/caPools/{ca_pool}" * Region Matching: Workloads are ONLY issued
        /// certificates from CA pools within the same region. Also the CA pool region (in value) must match the
        /// workload's region (key).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caPools")]
        public virtual System.Collections.Generic.IDictionary<string, string> CaPools { get; set; }

        /// <summary>
        /// Optional. Key algorithm to use when generating the key pair. This key pair will be used to create the
        /// certificate. If not specified, this will default to ECDSA_P256.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyAlgorithm")]
        public virtual string KeyAlgorithm { get; set; }

        /// <summary>
        /// Optional. Lifetime of the workload certificates issued by the CA pool. Must be between 24 hours and 30 days.
        /// If not specified, this will be defaulted to 24 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetime")]
        public virtual object Lifetime { get; set; }

        /// <summary>
        /// Optional. Rotation window percentage, the percentage of remaining lifetime after which certificate rotation
        /// is initiated. Must be between 50 and 80. If no value is specified, rotation window percentage is defaulted
        /// to 50.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotationWindowPercentage")]
        public virtual System.Nullable<int> RotationWindowPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines configuration for extending trust to additional trust domains. By establishing trust with another
    /// domain, the current domain will recognize and accept certificates issued by entities within the trusted domains.
    /// Note that a trust domain automatically trusts itself, eliminating the need for explicit configuration.
    /// </summary>
    public class InlineTrustConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Maps specific trust domains (e.g., "example.com") to their corresponding TrustStore, which contain
        /// the trusted root certificates for that domain. There can be a maximum of 10 trust domain entries in this
        /// map. Note that a trust domain automatically trusts itself and don't need to be specified here. If however,
        /// this WorkloadIdentityPool's trust domain contains any trust anchors in the additional_trust_bundles map,
        /// those trust anchors will be *appended to* the trust bundle automatically derived from your
        /// InlineCertificateIssuanceConfig's ca_pools.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTrustBundles")]
        public virtual System.Collections.Generic.IDictionary<string, TrustStore> AdditionalTrustBundles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Intermediate CA certificates used for building the trust chain to trust anchor</summary>
    public class IntermediateCA : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM certificate of the PKI used for validation. Must only contain one ca certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificate")]
        public virtual string PemCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a public key data along with its format.</summary>
    public class KeyData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The format of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Output only. The key data. The format of the key is represented by the format field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Required. The specifications for the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keySpec")]
        public virtual string KeySpec { get; set; }

        private string _notAfterTimeRaw;

        private object _notAfterTime;

        /// <summary>
        /// Output only. Latest timestamp when this key is valid. Attempts to use this key after this time will fail.
        /// Only present if the key data represents a X.509 certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notAfterTime")]
        public virtual string NotAfterTimeRaw
        {
            get => _notAfterTimeRaw;
            set
            {
                _notAfterTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notAfterTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotAfterTimeDateTimeOffset instead.")]
        public virtual object NotAfterTime
        {
            get => _notAfterTime;
            set
            {
                _notAfterTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notAfterTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NotAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotAfterTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotAfterTimeRaw);
            set => NotAfterTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _notBeforeTimeRaw;

        private object _notBeforeTime;

        /// <summary>
        /// Output only. Earliest timestamp when this key is valid. Attempts to use this key before this time will fail.
        /// Only present if the key data represents a X.509 certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notBeforeTime")]
        public virtual string NotBeforeTimeRaw
        {
            get => _notBeforeTimeRaw;
            set
            {
                _notBeforeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notBeforeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotBeforeTimeDateTimeOffset instead.")]
        public virtual object NotBeforeTime
        {
            get => _notBeforeTime;
            set
            {
                _notBeforeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notBeforeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NotBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotBeforeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotBeforeTimeRaw);
            set => NotBeforeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to lint an IAM policy object.</summary>
    public class LintPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>google.iam.v1.Binding.condition object to be linted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// The full resource name of the policy this lint request is about. The name follows the Google Cloud format
        /// for full resource names. For example, a Google Cloud project with ID `my-project` will be named
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`. The resource name is not used to read a policy
        /// from IAM. Only the data in the request object is linted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response of a lint operation. An empty response indicates the operation was able to fully execute and no
    /// lint issue was found.
    /// </summary>
    public class LintPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of lint results sorted by `severity` in descending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lintResults")]
        public virtual System.Collections.Generic.IList<LintResult> LintResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured response of a single validation unit.</summary>
    public class LintResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human readable debug message associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugMessage")]
        public virtual string DebugMessage { get; set; }

        /// <summary>
        /// The name of the field for which this lint result is about. For nested messages `field_name` consists of
        /// names of the embedded fields separated by period character. The top-level qualifier is the input object to
        /// lint in the request. For example, the `field_name` value `condition.expression` identifies a lint result for
        /// the `expression` field of the provided condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>The validation unit level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>
        /// 0-based character position of problematic construct within the object identified by `field_name`. Currently,
        /// this is populated only for condition expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationOffset")]
        public virtual System.Nullable<int> LocationOffset { get; set; }

        /// <summary>The validation unit severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The validation unit name, for instance "lintValidationUnits/ConditionComplexityCheck".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationUnitName")]
        public virtual string ValidationUnitName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListAttestationRules.</summary>
    public class ListAttestationRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of AttestationRules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationRules")]
        public virtual System.Collections.Generic.IList<AttestationRule> AttestationRules { get; set; }

        /// <summary>
        /// Optional. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListOauthClientCredentials.</summary>
    public class ListOauthClientCredentialsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of OauthClientCredentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthClientCredentials")]
        public virtual System.Collections.Generic.IList<OauthClientCredential> OauthClientCredentials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListOauthClients.</summary>
    public class ListOauthClientsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of OauthClients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthClients")]
        public virtual System.Collections.Generic.IList<OauthClient> OauthClients { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response containing the roles defined under a resource.</summary>
    public class ListRolesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>To retrieve the next page of results, set `ListRolesRequest.page_token` to this value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Roles defined on this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account keys list response.</summary>
    public class ListServiceAccountKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The public keys for the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<ServiceAccountKey> Keys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account list response.</summary>
    public class ListServiceAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of matching service accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<ServiceAccount> Accounts { get; set; }

        /// <summary>
        /// To retrieve the next page of results, set ListServiceAccountsRequest.page_token to this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkforcePoolProviderKeys.</summary>
    public class ListWorkforcePoolProviderKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of WorkforcePoolProviderKeys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforcePoolProviderKeys")]
        public virtual System.Collections.Generic.IList<WorkforcePoolProviderKey> WorkforcePoolProviderKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkforcePoolProviderScimTenants.</summary>
    public class ListWorkforcePoolProviderScimTenantsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. A list of scim tenants.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforcePoolProviderScimTenants")]
        public virtual System.Collections.Generic.IList<WorkforcePoolProviderScimTenant> WorkforcePoolProviderScimTenants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkforcePoolProviderScimTokens.</summary>
    public class ListWorkforcePoolProviderScimTokensResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. A list of scim tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforcePoolProviderScimTokens")]
        public virtual System.Collections.Generic.IList<WorkforcePoolProviderScimToken> WorkforcePoolProviderScimTokens { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkforcePoolProviders.</summary>
    public class ListWorkforcePoolProvidersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforcePoolProviders")]
        public virtual System.Collections.Generic.IList<WorkforcePoolProvider> WorkforcePoolProviders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkforcePools.</summary>
    public class ListWorkforcePoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of pools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workforcePools")]
        public virtual System.Collections.Generic.IList<WorkforcePool> WorkforcePools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkloadIdentityPoolManagedIdentities.</summary>
    public class ListWorkloadIdentityPoolManagedIdentitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of managed identities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadIdentityPoolManagedIdentities")]
        public virtual System.Collections.Generic.IList<WorkloadIdentityPoolManagedIdentity> WorkloadIdentityPoolManagedIdentities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkloadIdentityPoolNamespaces.</summary>
    public class ListWorkloadIdentityPoolNamespacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of namespaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadIdentityPoolNamespaces")]
        public virtual System.Collections.Generic.IList<WorkloadIdentityPoolNamespace> WorkloadIdentityPoolNamespaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkloadIdentityPoolProviderKeys.</summary>
    public class ListWorkloadIdentityPoolProviderKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of WorkloadIdentityPoolProviderKey</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadIdentityPoolProviderKeys")]
        public virtual System.Collections.Generic.IList<WorkloadIdentityPoolProviderKey> WorkloadIdentityPoolProviderKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkloadIdentityPoolProviders.</summary>
    public class ListWorkloadIdentityPoolProvidersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadIdentityPoolProviders")]
        public virtual System.Collections.Generic.IList<WorkloadIdentityPoolProvider> WorkloadIdentityPoolProviders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkloadIdentityPools.</summary>
    public class ListWorkloadIdentityPoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of pools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadIdentityPools")]
        public virtual System.Collections.Generic.IList<WorkloadIdentityPool> WorkloadIdentityPools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an OauthClient. Used to access Google Cloud resources on behalf of a Workforce Identity Federation
    /// user by using OAuth 2.0 Protocol to obtain an access token from Google Cloud.
    /// </summary>
    public class OauthClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of OAuth grant types is allowed for the OauthClient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedGrantTypes")]
        public virtual System.Collections.Generic.IList<string> AllowedGrantTypes { get; set; }

        /// <summary>
        /// Required. The list of redirect uris that is allowed to redirect back when authorization process is
        /// completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedRedirectUris")]
        public virtual System.Collections.Generic.IList<string> AllowedRedirectUris { get; set; }

        /// <summary>
        /// Required. The list of scopes that the OauthClient is allowed to request during OAuth flows. The following
        /// scopes are supported: * `https://www.googleapis.com/auth/cloud-platform`: See, edit, configure, and delete
        /// your Google Cloud data and see the email address for your Google Account. * `openid`: The OAuth client can
        /// associate you with your personal information on Google Cloud. * `email`: The OAuth client can read a
        /// federated identity's email address. * `groups`: The OAuth client can read a federated identity's groups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedScopes")]
        public virtual System.Collections.Generic.IList<string> AllowedScopes { get; set; }

        /// <summary>Output only. The system-generated OauthClient id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Immutable. The type of OauthClient. Either public or private. For private clients, the client secret can be
        /// managed using the dedicated OauthClientCredential resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientType")]
        public virtual string ClientType { get; set; }

        /// <summary>Optional. A user-specified description of the OauthClient. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Whether the OauthClient is disabled. You cannot use a disabled OAuth client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Optional. A user-specified display name of the OauthClient. Cannot exceed 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the OauthClient will be permanently purged and cannot be recovered.
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
        /// Immutable. Identifier. The resource name of the OauthClient.
        /// Format:`projects/{project}/locations/{location}/oauthClients/{oauth_client}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the OauthClient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an OauthClientCredential. Used to authenticate an OauthClient while accessing Google Cloud resources
    /// on behalf of a user by using OAuth 2.0 Protocol.
    /// </summary>
    public class OauthClientCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The system-generated OAuth client secret. The client secret must be stored securely. If the
        /// client secret is leaked, you must delete and re-create the client credential. To learn more, see [OAuth
        /// client and credential security risks and
        /// mitigations](https://cloud.google.com/iam/docs/workforce-oauth-app#security)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>
        /// Optional. Whether the OauthClientCredential is disabled. You cannot use a disabled OauthClientCredential.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Optional. A user-specified display name of the OauthClientCredential. Cannot exceed 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Immutable. Identifier. The resource name of the OauthClientCredential. Format:
        /// `projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an OpenId Connect 1.0 identity provider.</summary>
    public class Oidc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Acceptable values for the `aud` field (audience) in the OIDC token. Token exchange requests are
        /// rejected if the token audience does not match one of the configured values. Each audience may be at most 256
        /// characters. A maximum of 10 audiences may be configured. If this list is empty, the OIDC token audience must
        /// be equal to the full canonical resource name of the WorkloadIdentityPoolProvider, with or without the HTTPS
        /// prefix. For example:
        /// ```
        /// //iam.googleapis.com/projects//locations//workloadIdentityPools//providers/
        /// https://iam.googleapis.com/projects//locations//workloadIdentityPools//providers/
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedAudiences")]
        public virtual System.Collections.Generic.IList<string> AllowedAudiences { get; set; }

        /// <summary>
        /// Required. The OIDC issuer URL. Must be an HTTPS endpoint. Per OpenID Connect Discovery 1.0 spec, the OIDC
        /// issuer URL is used to locate the provider's public keys (via `jwks_uri`) for verifying tokens like the OIDC
        /// ID token. These public key types must be 'EC' or 'RSA'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerUri")]
        public virtual string IssuerUri { get; set; }

        /// <summary>
        /// Optional. OIDC JWKs in JSON String format. For details on the definition of a JWK, see
        /// https://tools.ietf.org/html/rfc7517. If not set, the `jwks_uri` from the discovery document(fetched from the
        /// .well-known path of the `issuer_uri`) will be used. Currently, RSA and EC asymmetric keys are supported. The
        /// JWK must use following format and include only the following fields: { "keys": [ { "kty": "RSA/EC", "alg":
        /// "", "use": "sig", "kid": "", "n": "", "e": "", "x": "", "y": "", "crv": "" } ] }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwksJson")]
        public virtual string JwksJson { get; set; }

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

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

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

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud service that owns this namespace.</summary>
    public class OwnerService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The service agent principal subject, e.g.
        /// "serviceAccount:service-1234@gcp-sa-gkehub.iam.gserviceaccount.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The service account patch request. You can patch only the `display_name` and `description` fields. You must use
    /// the `update_mask` field to specify which of these fields you want to patch. Only the fields specified in the
    /// request are guaranteed to be returned in the response. Other fields may be empty in the response.
    /// </summary>
    public class PatchServiceAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A permission which can be included by a role.</summary>
    public class Permission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service API associated with the permission is not enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiDisabled")]
        public virtual System.Nullable<bool> ApiDisabled { get; set; }

        /// <summary>The current custom role support level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRolesSupportLevel")]
        public virtual string CustomRolesSupportLevel { get; set; }

        /// <summary>A brief description of what this Permission is used for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The name of this Permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("onlyInPredefinedRoles")]
        public virtual System.Nullable<bool> OnlyInPredefinedRoles { get; set; }

        /// <summary>
        /// The preferred name for this permission. If present, then this permission is an alias of, and equivalent to,
        /// the listed primary_permission.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryPermission")]
        public virtual string PrimaryPermission { get; set; }

        /// <summary>The current launch stage of the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>The title of this Permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A PermissionDelta message to record the added_permissions and removed_permissions inside a role.
    /// </summary>
    public class PermissionDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Added permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedPermissions")]
        public virtual System.Collections.Generic.IList<string> AddedPermissions { get; set; }

        /// <summary>Removed permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removedPermissions")]
        public virtual System.Collections.Generic.IList<string> RemovedPermissions { get; set; }

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

    /// <summary>The difference delta between two policies.</summary>
    public class PolicyDelta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The delta for Bindings between two policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindingDeltas")]
        public virtual System.Collections.Generic.IList<BindingDelta> BindingDeltas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to get the list of auditable services for a resource.</summary>
    public class QueryAuditableServicesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The full resource name to query from the list of auditable services. The name follows the Google
        /// Cloud Platform resource format. For example, a Cloud Platform project with id `my-project` will be named
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response containing a list of auditable services for a resource.</summary>
    public class QueryAuditableServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The auditable services for a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<AuditableService> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The grantable role query request.</summary>
    public class QueryGrantableRolesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Required. The full resource name to query from the list of grantable roles. The name follows the
        /// Google Cloud Platform resource format. For example, a Cloud Platform project with id `my-project` will be
        /// named `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Optional limit on the number of roles to include in the response. The default is 300, and the maximum is
        /// 2,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>Optional pagination token returned in an earlier QueryGrantableRolesResponse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The grantable role query response.</summary>
    public class QueryGrantableRolesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// To retrieve the next page of results, set `QueryGrantableRolesRequest.page_token` to this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of matching roles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to get permissions which can be tested on a resource.</summary>
    public class QueryTestablePermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The full resource name to query from the list of testable permissions. The name follows the Google
        /// Cloud Platform resource format. For example, a Cloud Platform project with id `my-project` will be named
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Optional limit on the number of permissions to include in the response. The default is 100, and the maximum
        /// is 1,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>Optional pagination token returned in an earlier QueryTestablePermissionsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response containing permissions which can be tested on a resource.</summary>
    public class QueryTestablePermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// To retrieve the next page of results, set `QueryTestableRolesRequest.page_token` to this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Permissions testable on the requested resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<Permission> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata returned by the CLH during resource state reconciliation.</summary>
    public class ReconciliationOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request message for RemoveAttestationRule.</summary>
    public class RemoveAttestationRuleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attestation rule to be removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationRule")]
        public virtual AttestationRule AttestationRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A role in the Identity and Access Management API.</summary>
    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The current deleted state of the role. This field is read only. It will be ignored in calls to CreateRole
        /// and UpdateRole.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>Optional. A human-readable description for the role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Used to perform a consistent read-modify-write.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The names of the permissions this role grants when bound in an IAM policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedPermissions")]
        public virtual System.Collections.Generic.IList<string> IncludedPermissions { get; set; }

        /// <summary>
        /// The name of the role. When `Role` is used in `CreateRole`, the role name must not be set. When `Role` is
        /// used in output and other input such as `UpdateRole`, the role name is the complete path. For example,
        /// `roles/logging.viewer` for predefined roles, `organizations/{ORGANIZATION_ID}/roles/myRole` for
        /// organization-level custom roles, and `projects/{PROJECT_ID}/roles/myRole` for project-level custom roles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The current launch stage of the role. If the `ALPHA` launch stage has been selected for a role, the `stage`
        /// field will not be included in the returned definition for the role.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>
        /// Optional. A human-readable title for the role. Typically this is limited to 100 UTF-8 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }
    }

    /// <summary>Represents an SAML 2.0 identity provider.</summary>
    public class Saml : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. SAML identity provider (IdP) configuration metadata XML doc. The XML document must comply with the
        /// [SAML 2.0 specification](https://docs.oasis-open.org/security/saml/v2.0/saml-metadata-2.0-os.pdf). The
        /// maximum size of an acceptable XML document is 128K characters. The SAML metadata XML document must satisfy
        /// the following constraints: * Must contain an IdP Entity ID. * Must contain at least one non-expired signing
        /// certificate. * For each signing certificate, the expiration must be: * From no more than 7 days in the
        /// future. * To no more than 25 years in the future. * Up to three IdP signing keys are allowed. When updating
        /// the provider's metadata XML, at least one non-expired signing key must overlap with the existing metadata.
        /// This requirement is skipped if there are no non-expired signing keys present in the existing metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idpMetadataXml")]
        public virtual string IdpMetadataXml { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An IAM service account. A service account is an account for an application or a virtual machine (VM) instance,
    /// not a person. You can use a service account to call Google APIs. To learn more, read the [overview of service
    /// accounts](https://cloud.google.com/iam/help/service-accounts/overview). When you create a service account, you
    /// specify the project ID that owns the service account, as well as a name that must be unique within the project.
    /// IAM uses these values to create an email address that identifies the service account. //
    /// </summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A user-specified, human-readable description of the service account. The maximum length is 256
        /// UTF-8 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Whether the service account is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Optional. A user-specified, human-readable name for the service account. The maximum length is 100 UTF-8
        /// bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The email address of the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Deprecated. Do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The resource name of the service account. Use one of the following formats: *
        /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
        /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
        /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
        /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because it
        /// can cause response messages to contain misleading error codes. For example, if you try to access the service
        /// account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response contains an HTTP
        /// `403 Forbidden` error instead of a `404 Not Found` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The OAuth 2.0 client ID for the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientId")]
        public virtual string Oauth2ClientId { get; set; }

        /// <summary>Output only. The ID of the project that owns the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Output only. The unique, stable numeric ID for the service account. Each service account retains its unique
        /// ID even if you delete the service account. For example, if you delete a service account, then create a new
        /// service account with the same name, the new service account has a different unique ID than the deleted
        /// service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueId")]
        public virtual string UniqueId { get; set; }
    }

    /// <summary>
    /// Represents a service account key. A service account has two sets of key-pairs: user-managed, and system-managed.
    /// User-managed key-pairs can be created and deleted by users. Users are responsible for rotating these keys
    /// periodically to ensure security of their service accounts. Users retain the private key of these key-pairs, and
    /// Google retains ONLY the public key. System-managed keys are automatically rotated by Google, and are used for
    /// signing for a maximum of two weeks. The rotation process is probabilistic, and usage of the new key will
    /// gradually ramp up and down over the key's lifetime. If you cache the public key set for a service account, we
    /// recommend that you update the cache every 15 minutes. User-managed keys can be added and removed at any time, so
    /// it is important to update the cache frequently. For Google-managed keys, Google will publish a key at least 6
    /// hours before it is first used for signing and will keep publishing it for at least 6 hours after it was last
    /// used for signing. Public keys for all service accounts are also published at the OAuth2 Service Account API.
    /// </summary>
    public class ServiceAccountKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. optional. If the key is disabled, it may have a DisableReason describing why it was disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableReason")]
        public virtual string DisableReason { get; set; }

        /// <summary>The key status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Output only. Extended Status provides permanent information about a service account key. For example, if
        /// this key was detected as exposed or compromised, that information will remain for the lifetime of the key in
        /// the extended_status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedStatus")]
        public virtual System.Collections.Generic.IList<ExtendedStatus> ExtendedStatus { get; set; }

        /// <summary>Specifies the algorithm (and possibly key size) for the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyAlgorithm")]
        public virtual string KeyAlgorithm { get; set; }

        /// <summary>The key origin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyOrigin")]
        public virtual string KeyOrigin { get; set; }

        /// <summary>The key type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>
        /// The resource name of the service account key in the following format
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The private key data. Only provided in `CreateServiceAccountKey` responses. Make sure to keep the private
        /// key data secure because it allows for the assertion of the service account identity. When base64 decoded,
        /// the private key data can be used to authenticate with Google API client libraries and with gcloud auth
        /// activate-service-account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyData")]
        public virtual string PrivateKeyData { get; set; }

        /// <summary>
        /// The output format for the private key. Only provided in `CreateServiceAccountKey` responses, not in
        /// `GetServiceAccountKey` or `ListServiceAccountKey` responses. Google never exposes system-managed private
        /// keys, and never retains user-managed private keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyType")]
        public virtual string PrivateKeyType { get; set; }

        /// <summary>The public key data. Only provided in `GetServiceAccountKey` responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyData")]
        public virtual string PublicKeyData { get; set; }

        private string _validAfterTimeRaw;

        private object _validAfterTime;

        /// <summary>The key can be used after this timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validAfterTime")]
        public virtual string ValidAfterTimeRaw
        {
            get => _validAfterTimeRaw;
            set
            {
                _validAfterTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _validAfterTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ValidAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ValidAfterTimeDateTimeOffset instead.")]
        public virtual object ValidAfterTime
        {
            get => _validAfterTime;
            set
            {
                _validAfterTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _validAfterTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ValidAfterTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ValidAfterTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ValidAfterTimeRaw);
            set => ValidAfterTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _validBeforeTimeRaw;

        private object _validBeforeTime;

        /// <summary>
        /// The key can be used before this timestamp. For system-managed key pairs, this timestamp is the end time for
        /// the private key signing operation. The public key could still be used for verification for a few hours after
        /// this time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validBeforeTime")]
        public virtual string ValidBeforeTimeRaw
        {
            get => _validBeforeTimeRaw;
            set
            {
                _validBeforeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _validBeforeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ValidBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ValidBeforeTimeDateTimeOffset instead.")]
        public virtual object ValidBeforeTime
        {
            get => _validBeforeTime;
            set
            {
                _validBeforeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _validBeforeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ValidBeforeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ValidBeforeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ValidBeforeTimeRaw);
            set => ValidBeforeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a service.</summary>
    public class ServiceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Domain name of the service. Example: console.cloud.google</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SetAttestationRules.</summary>
    public class SetAttestationRulesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attestation rules to be set. At most 50 attestation rules can be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationRules")]
        public virtual System.Collections.Generic.IList<AttestationRule> AttestationRules { get; set; }

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
    /// Deprecated. [Migrate to Service Account Credentials
    /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The service account sign blob request.
    /// </summary>
    public class SignBlobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The bytes to sign.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesToSign")]
        public virtual string BytesToSign { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated. [Migrate to Service Account Credentials
    /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The service account sign blob response.
    /// </summary>
    public class SignBlobResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The id of the key used to sign the blob.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>
        /// Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The signed blob.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated. [Migrate to Service Account Credentials
    /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The service account sign JWT request.
    /// </summary>
    public class SignJwtRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The JWT payload to sign. Must be a
        /// serialized JSON object that contains a JWT Claims Set. For example: `{"sub": "user@example.com", "iat":
        /// 313435}` If the JWT Claims Set contains an expiration time (`exp`) claim, it must be an integer timestamp
        /// that is not in the past and no more than 12 hours in the future. If the JWT Claims Set does not contain an
        /// expiration time (`exp`) claim, this claim is added automatically, with a timestamp that is 1 hour in the
        /// future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated. [Migrate to Service Account Credentials
    /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The service account sign JWT response.
    /// </summary>
    public class SignJwtResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The id of the key used to sign the JWT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>
        /// Deprecated. [Migrate to Service Account Credentials
        /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The signed JWT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedJwt")]
        public virtual string SignedJwt { get; set; }

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

    /// <summary>Represents a root of trust.</summary>
    public class TrustAnchor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// PEM certificate of the PKI used for validation. Must only contain one ca certificate(either root or
        /// intermediate cert).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificate")]
        public virtual string PemCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Trust store that contains trust anchors and optional intermediate CAs used in PKI to build a trust chain(trust
    /// hierarchy) and verify a client's identity.
    /// </summary>
    public class TrustStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Set of intermediate CA certificates used for building the trust chain to the trust anchor.
        /// Important: Intermediate CAs are only supported for X.509 federation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intermediateCas")]
        public virtual System.Collections.Generic.IList<IntermediateCA> IntermediateCas { get; set; }

        /// <summary>
        /// Required. List of trust anchors to be used while performing validation against a given TrustStore. The
        /// incoming end entity's certificate must be in the trust chain of one of the trust anchors here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustAnchors")]
        public virtual System.Collections.Generic.IList<TrustAnchor> TrustAnchors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteOauthClient.</summary>
    public class UndeleteOauthClientRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to undelete an existing role.</summary>
    public class UndeleteRoleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Used to perform a consistent read-modify-write.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account undelete request.</summary>
    public class UndeleteServiceAccountRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UndeleteServiceAccountResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata for the restored service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoredAccount")]
        public virtual ServiceAccount RestoredAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkforcePoolProviderKey.</summary>
    public class UndeleteWorkforcePoolProviderKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkforcePoolProvider.</summary>
    public class UndeleteWorkforcePoolProviderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkforcePoolProviderScimTenant.</summary>
    public class UndeleteWorkforcePoolProviderScimTenantRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkforcePoolProviderScimToken.</summary>
    public class UndeleteWorkforcePoolProviderScimTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkforcePool.</summary>
    public class UndeleteWorkforcePoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkforcePoolSubject.</summary>
    public class UndeleteWorkforcePoolSubjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkloadIdentityPoolManagedIdentity.</summary>
    public class UndeleteWorkloadIdentityPoolManagedIdentityRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkloadIdentityPoolNamespace.</summary>
    public class UndeleteWorkloadIdentityPoolNamespaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkloadIdentityPoolProviderKey.</summary>
    public class UndeleteWorkloadIdentityPoolProviderKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkloadIdentityPoolProvider.</summary>
    public class UndeleteWorkloadIdentityPoolProviderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UndeleteWorkloadIdentityPool.</summary>
    public class UndeleteWorkloadIdentityPoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The service account key upload request.</summary>
    public class UploadServiceAccountKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The public key to associate with the service account. Must be an RSA public key that is wrapped in an X.509
        /// v3 certificate. Include the first line, `-----BEGIN CERTIFICATE-----`, and the last line, `-----END
        /// CERTIFICATE-----`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyData")]
        public virtual string PublicKeyData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a collection of external workforces. Provides namespaces for federated users that can be referenced
    /// in IAM policies.
    /// </summary>
    public class WorkforcePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configure access restrictions on the workforce pool users. This is an optional field. If specified
        /// web sign-in can be restricted to given set of services or programmatic sign-in can be disabled for pool
        /// users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessRestrictions")]
        public virtual AccessRestrictions AccessRestrictions { get; set; }

        /// <summary>Optional. A user-specified description of the pool. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Disables the workforce pool. You cannot use a disabled pool to exchange tokens, or use existing
        /// tokens to access resources. If the pool is re-enabled, existing tokens grant access again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Optional. A user-specified display name of the pool in Google Cloud Console. Cannot exceed 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the workforce pool will be permanently purged and cannot be recovered.
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
        /// Identifier. The resource name of the pool. Format: `locations/{location}/workforcePools/{workforce_pool_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Immutable. The resource name of the parent. Format: `organizations/{org-id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Optional. Duration that the Google Cloud access tokens, console sign-in sessions, and `gcloud` sign-in
        /// sessions from this pool are valid. Must be greater than 15 minutes (900s) and less than 12 hours (43200s).
        /// If `session_duration` is not configured, minted credentials have a default duration of one hour (3600s). For
        /// SAML providers, the lifetime of the token is the minimum of the `session_duration` and the
        /// `SessionNotOnOrAfter` claim in the SAML assertion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionDuration")]
        public virtual object SessionDuration { get; set; }

        /// <summary>Output only. The state of the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A configuration for an external identity provider.</summary>
    public class WorkforcePoolProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A [Common Expression Language](https://opensource.google/projects/cel) expression, in plain text,
        /// to restrict what otherwise valid authentication credentials issued by the provider should not be accepted.
        /// The expression must output a boolean representing whether to allow the federation. The following keywords
        /// may be referenced in the expressions: * `assertion`: JSON representing the authentication credential issued
        /// by the provider. * `google`: The Google attributes mapped from the assertion in the `attribute_mappings`.
        /// `google.profile_photo`, `google.display_name` and `google.posix_username` are not supported. * `attribute`:
        /// The custom attributes mapped from the assertion in the `attribute_mappings`. The maximum length of the
        /// attribute condition expression is 4096 characters. If unspecified, all valid authentication credentials will
        /// be accepted. The following example shows how to only allow credentials with a mapped `google.groups` value
        /// of `admins`:
        /// ```
        /// "'admins' in google.groups"
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeCondition")]
        public virtual string AttributeCondition { get; set; }

        /// <summary>
        /// Required. Maps attributes from the authentication credentials issued by an external identity provider to
        /// Google Cloud attributes, such as `subject` and `segment`. Each key must be a string specifying the Google
        /// Cloud IAM attribute to map to. The following keys are supported: * `google.subject`: The principal IAM is
        /// authenticating. You can reference this value in IAM bindings. This is also the subject that appears in Cloud
        /// Logging logs. This is a required field and the mapped subject cannot exceed 127 bytes. * `google.groups`:
        /// Groups the authenticating user belongs to. You can grant groups access to resources using an IAM
        /// `principalSet` binding; access applies to all members of the group. * `google.display_name`: The name of the
        /// authenticated user. This is an optional field and the mapped display name cannot exceed 100 bytes. If not
        /// set, `google.subject` will be displayed instead. This attribute cannot be referenced in IAM bindings. *
        /// `google.profile_photo`: The URL that specifies the authenticated user's thumbnail photo. This is an optional
        /// field. When set, the image will be visible as the user's profile picture. If not set, a generic user icon
        /// will be displayed instead. This attribute cannot be referenced in IAM bindings. * `google.posix_username`:
        /// The Linux username used by OS Login. This is an optional field and the mapped POSIX username cannot exceed
        /// 32 characters, The key must match the regex "^a-zA-Z0-9._{0,31}$". This attribute cannot be referenced in
        /// IAM bindings. You can also provide custom attributes by specifying `attribute.{custom_attribute}`, where
        /// {custom_attribute} is the name of the custom attribute to be mapped. You can define a maximum of 50 custom
        /// attributes. The maximum length of a mapped attribute key is 100 characters, and the key may only contain the
        /// characters [a-z0-9_]. You can reference these attributes in IAM policies to define fine-grained access for a
        /// workforce pool to Google Cloud resources. For example: * `google.subject`:
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool}/subject/{value}` * `google.groups`:
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool}/group/{value}` *
        /// `attribute.{custom_attribute}`:
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool}/attribute.{custom_attribute}/{value}`
        /// Each value must be a [Common Expression Language] (https://opensource.google/projects/cel) function that
        /// maps an identity provider credential to the normalized attribute specified by the corresponding map key. You
        /// can use the `assertion` keyword in the expression to access a JSON representation of the authentication
        /// credential issued by the provider. The maximum length of an attribute mapping expression is 2048 characters.
        /// When evaluated, the total size of all mapped attributes must not exceed 4KB. For OIDC providers, you must
        /// supply a custom mapping that includes the `google.subject` attribute. For example, the following maps the
        /// `sub` claim of the incoming credential to the `subject` attribute on a Google token:
        /// ```
        /// {"google.subject":
        /// "assertion.sub"}
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> AttributeMapping { get; set; }

        /// <summary>Optional. A user-specified description of the provider. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. If true, populates additional debug information in Cloud Audit Logs for this provider. Logged
        /// attribute mappings and values can be found in `sts.googleapis.com` data access logs. Default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailedAuditLogging")]
        public virtual System.Nullable<bool> DetailedAuditLogging { get; set; }

        /// <summary>
        /// Optional. Disables the workforce pool provider. You cannot use a disabled provider to exchange tokens.
        /// However, existing tokens still grant access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Optional. A user-specified display name for the provider. Cannot exceed 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the workload pool provider will be permanently purged and cannot be recovered.
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
        /// Optional. The configuration for OAuth 2.0 client used to get the extended group memberships for user
        /// identities. Only the `AZURE_AD_GROUPS_ID` attribute type is supported. Extended groups supports a subset of
        /// Google Cloud services. When the user accesses these services, extended group memberships override the mapped
        /// `google.groups` attribute. Extended group memberships cannot be used in attribute mapping or attribute
        /// condition expressions. To keep extended group memberships up to date, extended groups are retrieved when the
        /// user signs in and at regular intervals during the user's active session. Each user identity in the workforce
        /// identity pool must map to a specific, unique Microsoft Entra ID user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedAttributesOauth2Client")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderExtraAttributesOAuth2Client ExtendedAttributesOauth2Client { get; set; }

        /// <summary>
        /// Optional. The configuration for OAuth 2.0 client used to get the additional user attributes. This should be
        /// used when users can't get the desired claims in authentication credentials. Currently this configuration is
        /// only supported with OIDC protocol.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraAttributesOauth2Client")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderExtraAttributesOAuth2Client ExtraAttributesOauth2Client { get; set; }

        /// <summary>
        /// Identifier. The resource name of the provider. Format:
        /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An OpenId Connect 1.0 identity provider configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidc")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderOidc Oidc { get; set; }

        /// <summary>A SAML identity provider configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saml")]
        public virtual GoogleIamAdminV1WorkforcePoolProviderSaml Saml { get; set; }

        /// <summary>Output only. The state of the provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a public key configuration for a Workforce Pool Provider. The key can be configured in your identity
    /// provider to encrypt SAML assertions. Google holds the corresponding private key, which it uses to decrypt
    /// encrypted tokens.
    /// </summary>
    public class WorkforcePoolProviderKey : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The time after which the key will be permanently deleted and cannot be recovered. Note that the
        /// key may get purged before this time if the total limit of keys per provider is exceeded.
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

        /// <summary>Immutable. Public half of the asymmetric key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyData")]
        public virtual KeyData KeyData { get; set; }

        /// <summary>
        /// Identifier. The resource name of the key. Format:
        /// `locations/{location}/workforcePools/{workforce_pool_id}/providers/{provider_id}/keys/{key_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The purpose of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("use")]
        public virtual string Use { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a scim tenant. Used for provisioning and managing identity data (such as Users and Groups) in
    /// cross-domain environments.
    /// </summary>
    public class WorkforcePoolProviderScimTenant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Represents the base URI as defined in [RFC 7644, Section
        /// 1.3](https://datatracker.ietf.org/doc/html/rfc7644#section-1.3). Clients must use this as the root address
        /// for managing resources under the tenant. Format: https://iamscim.googleapis.com/{version}/{tenant_id}/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUri")]
        public virtual string BaseUri { get; set; }

        /// <summary>Optional. Maps BYOID claims to SCIM claims.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claimMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> ClaimMapping { get; set; }

        /// <summary>
        /// Optional. The user-specified description of the scim tenant. Cannot exceed 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The user-specified display name of the scim tenant. Cannot exceed 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The resource name of the SCIM Tenant. Format:
        /// `locations/{location}/workforcePools/{workforce_pool}/providers/
        /// {workforce_pool_provider}/scimTenants/{scim_tenant}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _purgeTimeRaw;

        private object _purgeTime;

        /// <summary>Output only. The timestamp when the scim tenant is going to be purged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeTime")]
        public virtual string PurgeTimeRaw
        {
            get => _purgeTimeRaw;
            set
            {
                _purgeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _purgeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PurgeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PurgeTimeDateTimeOffset instead.")]
        public virtual object PurgeTime
        {
            get => _purgeTime;
            set
            {
                _purgeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _purgeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PurgeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PurgeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PurgeTimeRaw);
            set => PurgeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The state of the tenant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a token for the WorkforcePoolProviderScimTenant. Used for authenticating SCIM Provisioning requests.
    /// </summary>
    public class WorkforcePoolProviderScimToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The user-specified display name of the scim token. Cannot exceed 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The resource name of the SCIM Token. Format:
        /// `locations/{location}/workforcePools/{workforce_pool}/providers/
        /// {workforce_pool_provider}/scimTenants/{scim_tenant}/tokens/{token}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The token string. Provide this to the IdP for authentication. Will be set only during creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityToken")]
        public virtual string SecurityToken { get; set; }

        /// <summary>Output only. The state of the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a collection of workload identities. You can define IAM policies to grant these identities access to
    /// Google Cloud resources.
    /// </summary>
    public class WorkloadIdentityPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A description of the pool. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use existing
        /// tokens to access resources. If the pool is re-enabled, existing tokens grant access again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Optional. A display name for the pool. Cannot exceed 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the workload identity pool will be permanently purged and cannot be recovered.
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
        /// Optional. Defines the Certificate Authority (CA) pool resources and configurations required for issuance and
        /// rotation of mTLS workload certificates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineCertificateIssuanceConfig")]
        public virtual InlineCertificateIssuanceConfig InlineCertificateIssuanceConfig { get; set; }

        /// <summary>Optional. Represents config to add additional trusted trust domains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineTrustConfig")]
        public virtual InlineTrustConfig InlineTrustConfig { get; set; }

        /// <summary>Immutable. The mode the pool is operating in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Output only. The resource name of the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a managed identity for a workload identity pool namespace.</summary>
    public class WorkloadIdentityPoolManagedIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A description of the managed identity. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Whether the managed identity is disabled. If disabled, credentials may no longer be issued for the identity,
        /// however existing credentials will still be accepted until they expire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the managed identity will be permanently purged and cannot be recovered.
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

        /// <summary>Output only. The resource name of the managed identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the managed identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a namespace for a workload identity pool. Namespaces are used to segment identities within the pool.
    /// </summary>
    public class WorkloadIdentityPoolNamespace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A description of the namespace. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Whether the namespace is disabled. If disabled, credentials may no longer be issued for identities within
        /// this namespace, however existing credentials will still be accepted until they expire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the namespace will be permanently purged and cannot be recovered.
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

        /// <summary>Output only. The resource name of the namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The Google Cloud service that owns this namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerService")]
        public virtual OwnerService OwnerService { get; set; }

        /// <summary>Output only. The state of the namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for long-running WorkloadIdentityPool operations.</summary>
    public class WorkloadIdentityPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A configuration for an external identity provider.</summary>
    public class WorkloadIdentityPoolProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. [A Common Expression Language](https://opensource.google/projects/cel) expression, in plain text,
        /// to restrict what otherwise valid authentication credentials issued by the provider should not be accepted.
        /// The expression must output a boolean representing whether to allow the federation. The following keywords
        /// may be referenced in the expressions: * `assertion`: JSON representing the authentication credential issued
        /// by the provider. * `google`: The Google attributes mapped from the assertion in the `attribute_mappings`. *
        /// `attribute`: The custom attributes mapped from the assertion in the `attribute_mappings`. The maximum length
        /// of the attribute condition expression is 4096 characters. If unspecified, all valid authentication
        /// credential are accepted. The following example shows how to only allow credentials with a mapped
        /// `google.groups` value of `admins`:
        /// ```
        /// "'admins' in google.groups"
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeCondition")]
        public virtual string AttributeCondition { get; set; }

        /// <summary>
        /// Optional. Maps attributes from authentication credentials issued by an external identity provider to Google
        /// Cloud attributes, such as `subject` and `segment`. Each key must be a string specifying the Google Cloud IAM
        /// attribute to map to. The following keys are supported: * `google.subject`: The principal IAM is
        /// authenticating. You can reference this value in IAM bindings. This is also the subject that appears in Cloud
        /// Logging logs. Cannot exceed 127 bytes. * `google.groups`: Groups the external identity belongs to. You can
        /// grant groups access to resources using an IAM `principalSet` binding; access applies to all members of the
        /// group. You can also provide custom attributes by specifying `attribute.{custom_attribute}`, where
        /// `{custom_attribute}` is the name of the custom attribute to be mapped. You can define a maximum of 50 custom
        /// attributes. The maximum length of a mapped attribute key is 100 characters, and the key may only contain the
        /// characters [a-z0-9_]. You can reference these attributes in IAM policies to define fine-grained access for a
        /// workload to Google Cloud resources. For example: * `google.subject`:
        /// `principal://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/subject/{value}`
        /// * `google.groups`:
        /// `principalSet://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/group/{value}`
        /// * `attribute.{custom_attribute}`:
        /// `principalSet://iam.googleapis.com/projects/{project}/locations/{location}/workloadIdentityPools/{pool}/attribute.{custom_attribute}/{value}`
        /// Each value must be a [Common Expression Language] (https://opensource.google/projects/cel) function that
        /// maps an identity provider credential to the normalized attribute specified by the corresponding map key. You
        /// can use the `assertion` keyword in the expression to access a JSON representation of the authentication
        /// credential issued by the provider. The maximum length of an attribute mapping expression is 2048 characters.
        /// When evaluated, the total size of all mapped attributes must not exceed 8KB. For AWS providers, if no
        /// attribute mapping is defined, the following default mapping applies:
        /// ```
        /// { "google.subject":"assertion.arn",
        /// "attribute.aws_role": "assertion.arn.contains('assumed-role')" " ?
        /// assertion.arn.extract('{account_arn}assumed-role/')" " + 'assumed-role/'" " +
        /// assertion.arn.extract('assumed-role/{role_name}/')" " : assertion.arn", }
        /// ```
        /// If any custom attribute
        /// mappings are defined, they must include a mapping to the `google.subject` attribute. For OIDC providers, you
        /// must supply a custom mapping, which must include the `google.subject` attribute. For example, the following
        /// maps the `sub` claim of the incoming credential to the `subject` attribute on a Google token:
        /// ```
        /// {"google.subject": "assertion.sub"}
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> AttributeMapping { get; set; }

        /// <summary>An Amazon Web Services identity provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aws")]
        public virtual Aws Aws { get; set; }

        /// <summary>Optional. A description for the provider. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Whether the provider is disabled. You cannot use a disabled provider to exchange tokens. However,
        /// existing tokens still grant access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Optional. A display name for the provider. Cannot exceed 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the workload identity pool provider will be permanently purged and cannot be
        /// recovered.
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

        /// <summary>Output only. The resource name of the provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An OpenId Connect 1.0 identity provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidc")]
        public virtual Oidc Oidc { get; set; }

        /// <summary>An SAML 2.0 identity provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saml")]
        public virtual Saml Saml { get; set; }

        /// <summary>Output only. The state of the provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>An X.509-type identity provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x509")]
        public virtual X509 X509 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a public key configuration for your workload identity pool provider. The key can be configured in
    /// your identity provider to encrypt the SAML assertions. Google holds the corresponding private key which it uses
    /// to decrypt encrypted tokens.
    /// </summary>
    public class WorkloadIdentityPoolProviderKey : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time after which the key will be permanently purged and cannot be recovered. Note that the key
        /// may get purged before this timestamp if the total limit of keys per provider is crossed.
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

        /// <summary>Immutable. Public half of the asymmetric key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyData")]
        public virtual KeyData KeyData { get; set; }

        /// <summary>Output only. The resource name of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The purpose of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("use")]
        public virtual string Use { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An X.509-type identity provider represents a CA. It is trusted to assert a client identity if the client has a
    /// certificate that chains up to this CA.
    /// </summary>
    public class X509 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A TrustStore. Use this trust store as a wrapper to config the trust anchor and optional
        /// intermediate cas to help build the trust chain for the incoming end entity certificate. Follow the X.509
        /// guidelines to define those PEM encoded certs. Only one trust store is currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStore")]
        public virtual TrustStore TrustStore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
