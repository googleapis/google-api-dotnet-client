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
            Organizations = new OrganizationsResource(this);
            Permissions = new PermissionsResource(this);
            Projects = new ProjectsResource(this);
            Roles = new RolesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "iam";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://iam.googleapis.com/";
        #else
            "https://iam.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://iam.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Identity and Access Management (IAM) API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Identity and Access Management (IAM) API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the IamPolicies resource.</summary>
        public virtual IamPoliciesResource IamPolicies { get; }

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
            return new LintPolicyRequest(service, body);
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
            return new QueryAuditableServicesRequest(service, body);
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
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
            /// format is described below: * [`projects.roles.create()`](/iam/reference/rest/v1/projects.roles/create):
            /// `projects/{PROJECT_ID}`. This method creates project-level [custom
            /// roles](/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [`organizations.roles.create()`](/iam/reference/rest/v1/organizations.roles/create):
            /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
            /// roles](/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.CreateRoleRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
                /// format is described below: *
                /// [`projects.roles.create()`](/iam/reference/rest/v1/projects.roles/create): `projects/{PROJECT_ID}`.
                /// This method creates project-level [custom roles](/iam/docs/understanding-custom-roles). Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [`organizations.roles.create()`](/iam/reference/rest/v1/organizations.roles/create):
                /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
                /// roles](/iam/docs/understanding-custom-roles). Example request URL:
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
            /// cannot bind a member to the custom role in an IAM Policy. * Existing bindings to the custom role are not
            /// changed, but they have no effect. * By default, the response from ListRoles does not include the custom
            /// role. You have 7 days to undelete the custom role. After 7 days, the following changes occur: * The
            /// custom role is permanently deleted and cannot be recovered. * If an IAM policy contains a binding to the
            /// custom role, the binding is permanently removed.
            /// </summary>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`projects.roles.delete()`](/iam/reference/rest/v1/projects.roles/delete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.delete()`](/iam/reference/rest/v1/organizations.roles/delete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a custom Role. When you delete a custom role, the following changes occur immediately: * You
            /// cannot bind a member to the custom role in an IAM Policy. * Existing bindings to the custom role are not
            /// changed, but they have no effect. * By default, the response from ListRoles does not include the custom
            /// role. You have 7 days to undelete the custom role. After 7 days, the following changes occur: * The
            /// custom role is permanently deleted and cannot be recovered. * If an IAM policy contains a binding to the
            /// custom role, the binding is permanently removed.
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: *
                /// [`projects.roles.delete()`](/iam/reference/rest/v1/projects.roles/delete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.delete()`](/iam/reference/rest/v1/organizations.roles/delete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
            /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`roles.get()`](/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This
            /// method returns results from all [predefined roles](/iam/docs/understanding-roles#predefined_roles) in
            /// Cloud IAM. Example request URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
            /// [`projects.roles.get()`](/iam/reference/rest/v1/projects.roles/get):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.get()`](/iam/reference/rest/v1/organizations.roles/get):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: * [`roles.get()`](/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`.
                /// This method returns results from all [predefined
                /// roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM. Example request URL:
                /// `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
                /// [`projects.roles.get()`](/iam/reference/rest/v1/projects.roles/get):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.get()`](/iam/reference/rest/v1/organizations.roles/get):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
            /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
            /// format is described below: * [`roles.list()`](/iam/reference/rest/v1/roles/list): An empty string. This
            /// method doesn't require a resource; it simply returns all [predefined
            /// roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM. Example request URL:
            /// `https://iam.googleapis.com/v1/roles` *
            /// [`projects.roles.list()`](/iam/reference/rest/v1/projects.roles/list): `projects/{PROJECT_ID}`. This
            /// method lists all project-level [custom roles](/iam/docs/understanding-custom-roles). Example request
            /// URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [`organizations.roles.list()`](/iam/reference/rest/v1/organizations.roles/list):
            /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
            /// roles](/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
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
                /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
                /// format is described below: * [`roles.list()`](/iam/reference/rest/v1/roles/list): An empty string.
                /// This method doesn't require a resource; it simply returns all [predefined
                /// roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM. Example request URL:
                /// `https://iam.googleapis.com/v1/roles` *
                /// [`projects.roles.list()`](/iam/reference/rest/v1/projects.roles/list): `projects/{PROJECT_ID}`. This
                /// method lists all project-level [custom roles](/iam/docs/understanding-custom-roles). Example request
                /// URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [`organizations.roles.list()`](/iam/reference/rest/v1/organizations.roles/list):
                /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
                /// roles](/iam/docs/understanding-custom-roles). Example request URL:
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
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.Role body, string name)
            {
                return new PatchRequest(service, body, name);
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: *
                /// [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`projects.roles.undelete()`](/iam/reference/rest/v1/projects.roles/undelete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.undelete()`](/iam/reference/rest/v1/organizations.roles/undelete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteRoleRequest body, string name)
            {
                return new UndeleteRequest(service, body, name);
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: *
                /// [`projects.roles.undelete()`](/iam/reference/rest/v1/projects.roles/undelete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.undelete()`](/iam/reference/rest/v1/organizations.roles/undelete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
        /// member has that permission on the resource.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryTestablePermissionsRequest QueryTestablePermissions(Google.Apis.Iam.v1.Data.QueryTestablePermissionsRequest body)
        {
            return new QueryTestablePermissionsRequest(service, body);
        }

        /// <summary>
        /// Lists every permission that you can test on a resource. A permission is testable if you can check whether a
        /// member has that permission on the resource.
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
                WorkloadIdentityPools = new WorkloadIdentityPoolsResource(service);
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
                    Operations = new OperationsResource(service);
                    Providers = new ProvidersResource(service);
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
                        return new GetRequest(service, name);
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
                            return new GetRequest(service, name);
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
                        return new CreateRequest(service, body, parent);
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
                        return new DeleteRequest(service, name);
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
                        return new GetRequest(service, name);
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
                        return new ListRequest(service, parent);
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
                        return new PatchRequest(service, body, name);
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
                        return new UndeleteRequest(service, body, name);
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
                    return new CreateRequest(service, body, parent);
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
                    return new DeleteRequest(service, name);
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
                    return new GetRequest(service, name);
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

                /// <summary>
                /// Lists all non-deleted WorkloadIdentityPools in a project. If `show_deleted` is set to `true`, then
                /// deleted pools are also listed.
                /// </summary>
                /// <param name="parent">Required. The parent resource to list pools for.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
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
                    return new PatchRequest(service, body, name);
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

                    /// <summary>Required. The list of fields update.</summary>
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

                /// <summary>
                /// Undeletes a WorkloadIdentityPool, as long as it was deleted fewer than 30 days ago.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the pool to undelete.</param>
                public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteWorkloadIdentityPoolRequest body, string name)
                {
                    return new UndeleteRequest(service, body, name);
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
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
            /// format is described below: * [`projects.roles.create()`](/iam/reference/rest/v1/projects.roles/create):
            /// `projects/{PROJECT_ID}`. This method creates project-level [custom
            /// roles](/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [`organizations.roles.create()`](/iam/reference/rest/v1/organizations.roles/create):
            /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
            /// roles](/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.CreateRoleRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
                /// format is described below: *
                /// [`projects.roles.create()`](/iam/reference/rest/v1/projects.roles/create): `projects/{PROJECT_ID}`.
                /// This method creates project-level [custom roles](/iam/docs/understanding-custom-roles). Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [`organizations.roles.create()`](/iam/reference/rest/v1/organizations.roles/create):
                /// `organizations/{ORGANIZATION_ID}`. This method creates organization-level [custom
                /// roles](/iam/docs/understanding-custom-roles). Example request URL:
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
            /// cannot bind a member to the custom role in an IAM Policy. * Existing bindings to the custom role are not
            /// changed, but they have no effect. * By default, the response from ListRoles does not include the custom
            /// role. You have 7 days to undelete the custom role. After 7 days, the following changes occur: * The
            /// custom role is permanently deleted and cannot be recovered. * If an IAM policy contains a binding to the
            /// custom role, the binding is permanently removed.
            /// </summary>
            /// <param name="name">
            /// The `name` parameter's value depends on the target resource for the request, namely
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`projects.roles.delete()`](/iam/reference/rest/v1/projects.roles/delete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.delete()`](/iam/reference/rest/v1/organizations.roles/delete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a custom Role. When you delete a custom role, the following changes occur immediately: * You
            /// cannot bind a member to the custom role in an IAM Policy. * Existing bindings to the custom role are not
            /// changed, but they have no effect. * By default, the response from ListRoles does not include the custom
            /// role. You have 7 days to undelete the custom role. After 7 days, the following changes occur: * The
            /// custom role is permanently deleted and cannot be recovered. * If an IAM policy contains a binding to the
            /// custom role, the binding is permanently removed.
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: *
                /// [`projects.roles.delete()`](/iam/reference/rest/v1/projects.roles/delete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.delete()`](/iam/reference/rest/v1/organizations.roles/delete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
            /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`roles.get()`](/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This
            /// method returns results from all [predefined roles](/iam/docs/understanding-roles#predefined_roles) in
            /// Cloud IAM. Example request URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
            /// [`projects.roles.get()`](/iam/reference/rest/v1/projects.roles/get):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.get()`](/iam/reference/rest/v1/organizations.roles/get):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: * [`roles.get()`](/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`.
                /// This method returns results from all [predefined
                /// roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM. Example request URL:
                /// `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
                /// [`projects.roles.get()`](/iam/reference/rest/v1/projects.roles/get):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.get()`](/iam/reference/rest/v1/organizations.roles/get):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
            /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
            /// format is described below: * [`roles.list()`](/iam/reference/rest/v1/roles/list): An empty string. This
            /// method doesn't require a resource; it simply returns all [predefined
            /// roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM. Example request URL:
            /// `https://iam.googleapis.com/v1/roles` *
            /// [`projects.roles.list()`](/iam/reference/rest/v1/projects.roles/list): `projects/{PROJECT_ID}`. This
            /// method lists all project-level [custom roles](/iam/docs/understanding-custom-roles). Example request
            /// URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [`organizations.roles.list()`](/iam/reference/rest/v1/organizations.roles/list):
            /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
            /// roles](/iam/docs/understanding-custom-roles). Example request URL:
            /// `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles` Note: Wildcard (*) values are
            /// invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
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
                /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
                /// format is described below: * [`roles.list()`](/iam/reference/rest/v1/roles/list): An empty string.
                /// This method doesn't require a resource; it simply returns all [predefined
                /// roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM. Example request URL:
                /// `https://iam.googleapis.com/v1/roles` *
                /// [`projects.roles.list()`](/iam/reference/rest/v1/projects.roles/list): `projects/{PROJECT_ID}`. This
                /// method lists all project-level [custom roles](/iam/docs/understanding-custom-roles). Example request
                /// URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
                /// [`organizations.roles.list()`](/iam/reference/rest/v1/organizations.roles/list):
                /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
                /// roles](/iam/docs/understanding-custom-roles). Example request URL:
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
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.Role body, string name)
            {
                return new PatchRequest(service, body, name);
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: *
                /// [`projects.roles.patch()`](/iam/reference/rest/v1/projects.roles/patch):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.patch()`](/iam/reference/rest/v1/organizations.roles/patch):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
            /// [`projects`](/iam/reference/rest/v1/projects.roles) or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`projects.roles.undelete()`](/iam/reference/rest/v1/projects.roles/undelete):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.undelete()`](/iam/reference/rest/v1/organizations.roles/undelete):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteRoleRequest body, string name)
            {
                return new UndeleteRequest(service, body, name);
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
                /// [`projects`](/iam/reference/rest/v1/projects.roles) or
                /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value
                /// format is described below: *
                /// [`projects.roles.undelete()`](/iam/reference/rest/v1/projects.roles/undelete):
                /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
                /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
                /// [`organizations.roles.undelete()`](/iam/reference/rest/v1/organizations.roles/undelete):
                /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes only [custom
                /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level.
                /// Example request URL:
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
                /// Required. The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
                /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                /// `unique_id` of the service account.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Iam.v1.Data.CreateServiceAccountKeyRequest body, string name)
                {
                    return new CreateRequest(service, body, name);
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
                    /// Required. The resource name of the service account in the following format:
                    /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID`
                    /// will infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                    /// `unique_id` of the service account.
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
                /// Required. The resource name of the service account key in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`. Using `-` as a wildcard for the
                /// `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the `email` address
                /// or the `unique_id` of the service account.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
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
                    /// Required. The resource name of the service account key in the following format:
                    /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`. Using `-` as a wildcard for the
                    /// `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the `email`
                    /// address or the `unique_id` of the service account.
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

                /// <summary>Gets a ServiceAccountKey.</summary>
                /// <param name="name">
                /// Required. The resource name of the service account key in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`. Using `-` as a wildcard for the
                /// `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the `email` address
                /// or the `unique_id` of the service account.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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
                    /// Required. The resource name of the service account key in the following format:
                    /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`. Using `-` as a wildcard for the
                    /// `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the `email`
                    /// address or the `unique_id` of the service account.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The output format of the public key requested. X509_PEM is the default output format.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("publicKeyType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<PublicKeyTypeEnum> PublicKeyType { get; set; }

                    /// <summary>
                    /// The output format of the public key requested. X509_PEM is the default output format.
                    /// </summary>
                    public enum PublicKeyTypeEnum
                    {
                        /// <summary>Unspecified. Returns nothing here.</summary>
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
                /// Required. The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID`,
                /// will infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                /// `unique_id` of the service account.
                /// </param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
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
                    /// Required. The resource name of the service account in the following format:
                    /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID`,
                    /// will infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                    /// `unique_id` of the service account.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Filters the types of keys the user wants to include in the list response. Duplicate key types
                    /// are not allowed. If no key type is provided, all keys are returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("keyTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<KeyTypesEnum> KeyTypes { get; set; }

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

                /// <summary>Creates a ServiceAccountKey, using a public key that you provide.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
                /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                /// `unique_id` of the service account.
                /// </param>
                public virtual UploadRequest Upload(Google.Apis.Iam.v1.Data.UploadServiceAccountKeyRequest body, string name)
                {
                    return new UploadRequest(service, body, name);
                }

                /// <summary>Creates a ServiceAccountKey, using a public key that you provide.</summary>
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
                    /// The resource name of the service account in the following format:
                    /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID`
                    /// will infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                    /// `unique_id` of the service account.
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
                return new CreateRequest(service, body, name);
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
            /// Required. The resource name of the service account in the following format:
            /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
            /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the `unique_id` of
            /// the service account.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
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
                /// Required. The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
                /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                /// `unique_id` of the service account.
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
            /// The resource name of the service account in the following format:
            /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
            /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the `unique_id` of
            /// the service account.
            /// </param>
            public virtual DisableRequest Disable(Google.Apis.Iam.v1.Data.DisableServiceAccountRequest body, string name)
            {
                return new DisableRequest(service, body, name);
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
                /// The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
                /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                /// `unique_id` of the service account.
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
            /// The resource name of the service account in the following format:
            /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
            /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the `unique_id` of
            /// the service account.
            /// </param>
            public virtual EnableRequest Enable(Google.Apis.Iam.v1.Data.EnableServiceAccountRequest body, string name)
            {
                return new EnableRequest(service, body, name);
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
                /// The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
                /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                /// `unique_id` of the service account.
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
            /// Required. The resource name of the service account in the following format:
            /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
            /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the `unique_id` of
            /// the service account.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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
                /// Required. The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID` will
                /// infer the project from the account. The `ACCOUNT` value can be the `email` address or the
                /// `unique_id` of the service account.
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
            /// Gets the IAM policy that is attached to a ServiceAccount. This IAM policy specifies which members have
            /// access to the service account. This method does not tell you whether the service account has been
            /// granted any roles on other resources. To check whether a service account has role grants on a resource,
            /// use the `getIamPolicy` method for that resource. For example, to view the role grants for a project,
            /// call the Resource Manager API's
            /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
            /// method.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(service, resource);
            }

            /// <summary>
            /// Gets the IAM policy that is attached to a ServiceAccount. This IAM policy specifies which members have
            /// access to the service account. This method does not tell you whether the service account has been
            /// granted any roles on other resources. To check whether a service account has role grants on a resource,
            /// use the `getIamPolicy` method for that resource. For example, to view the role grants for a project,
            /// call the Resource Manager API's
            /// [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
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
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>
                /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                /// specifying an invalid value will be rejected. Requests for policies with any conditional bindings
                /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                /// leave the field unset. To learn which resources support conditions in their IAM policies, see the
                /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
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
                return new ListRequest(service, name);
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
            /// it can cause response messages to contain misleading error codes. For example, if you try to get the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Iam.v1.Data.PatchServiceAccountRequest body, string name)
            {
                return new PatchRequest(service, body, name);
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
                /// get the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
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
            /// the service account. For example, you could grant a member the ability to impersonate the service
            /// account. This method does not enable the service account to access other resources. To grant roles to a
            /// service account on a resource, follow these steps: 1. Call the resource's `getIamPolicy` method to get
            /// its current IAM policy. 2. Edit the policy so that it binds the service account to an IAM role for the
            /// resource. 3. Call the resource's `setIamPolicy` method to update its IAM policy. For detailed
            /// instructions, see [Granting roles to a service account for specific
            /// resources](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Iam.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the IAM policy that is attached to a ServiceAccount. Use this method to grant or revoke access to
            /// the service account. For example, you could grant a member the ability to impersonate the service
            /// account. This method does not enable the service account to access other resources. To grant roles to a
            /// service account on a resource, follow these steps: 1. Call the resource's `getIamPolicy` method to get
            /// its current IAM policy. 2. Edit the policy so that it binds the service account to an IAM role for the
            /// resource. 3. Call the resource's `setIamPolicy` method to update its IAM policy. For detailed
            /// instructions, see [Granting roles to a service account for specific
            /// resources](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts).
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
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
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

            /// <summary>
            /// **Note:** This method is deprecated. Use the
            /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
            /// method in the IAM Service Account Credentials API instead. If you currently use this method, see the
            /// [migration guide](https://cloud.google.com/iam/help/credentials/migrate-api) for instructions. Signs a
            /// blob using the system-managed private key for a ServiceAccount.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Deprecated. [Migrate to Service Account Credentials
            /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The resource name of the service
            /// account in the following format: `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a
            /// wildcard for the `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
            /// `email` address or the `unique_id` of the service account.
            /// </param>
            public virtual SignBlobRequest SignBlob(Google.Apis.Iam.v1.Data.SignBlobRequest body, string name)
            {
                return new SignBlobRequest(service, body, name);
            }

            /// <summary>
            /// **Note:** This method is deprecated. Use the
            /// [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
            /// method in the IAM Service Account Credentials API instead. If you currently use this method, see the
            /// [migration guide](https://cloud.google.com/iam/help/credentials/migrate-api) for instructions. Signs a
            /// blob using the system-managed private key for a ServiceAccount.
            /// </summary>
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
                /// account in the following format: `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a
                /// wildcard for the `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be
                /// the `email` address or the `unique_id` of the service account.
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
            /// **Note:** This method is deprecated. Use the
            /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
            /// method in the IAM Service Account Credentials API instead. If you currently use this method, see the
            /// [migration guide](https://cloud.google.com/iam/help/credentials/migrate-api) for instructions. Signs a
            /// JSON Web Token (JWT) using the system-managed private key for a ServiceAccount.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Deprecated. [Migrate to Service Account Credentials
            /// API](https://cloud.google.com/iam/help/credentials/migrate-api). The resource name of the service
            /// account in the following format: `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a
            /// wildcard for the `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
            /// `email` address or the `unique_id` of the service account.
            /// </param>
            public virtual SignJwtRequest SignJwt(Google.Apis.Iam.v1.Data.SignJwtRequest body, string name)
            {
                return new SignJwtRequest(service, body, name);
            }

            /// <summary>
            /// **Note:** This method is deprecated. Use the
            /// [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
            /// method in the IAM Service Account Credentials API instead. If you currently use this method, see the
            /// [migration guide](https://cloud.google.com/iam/help/credentials/migrate-api) for instructions. Signs a
            /// JSON Web Token (JWT) using the system-managed private key for a ServiceAccount.
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
                /// account in the following format: `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a
                /// wildcard for the `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be
                /// the `email` address or the `unique_id` of the service account.
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
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Iam.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
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
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
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
            /// The resource name of the service account in the following format:
            /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_UNIQUE_ID}`. Using `-` as a wildcard for the
            /// `PROJECT_ID` will infer the project from the account.
            /// </param>
            public virtual UndeleteRequest Undelete(Google.Apis.Iam.v1.Data.UndeleteServiceAccountRequest body, string name)
            {
                return new UndeleteRequest(service, body, name);
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
                /// The resource name of the service account in the following format:
                /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_UNIQUE_ID}`. Using `-` as a wildcard for the
                /// `PROJECT_ID` will infer the project from the account.
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
            /// ServiceAccount. You can update only the `display_name` and `description` fields.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the service account. Use one of the following formats: *
            /// `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}` As an alternative, you can use the `-` wildcard
            /// character instead of the project ID: * `projects/-/serviceAccounts/{EMAIL_ADDRESS}` *
            /// `projects/-/serviceAccounts/{UNIQUE_ID}` When possible, avoid using the `-` wildcard character, because
            /// it can cause response messages to contain misleading error codes. For example, if you try to get the
            /// service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the response
            /// contains an HTTP `403 Forbidden` error instead of a `404 Not Found` error.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Iam.v1.Data.ServiceAccount body, string name)
            {
                return new UpdateRequest(service, body, name);
            }

            /// <summary>
            /// **Note:** We are in the process of deprecating this method. Use PatchServiceAccount instead. Updates a
            /// ServiceAccount. You can update only the `display_name` and `description` fields.
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
                /// get the service account `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
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
        /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
        /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format is
        /// described below: * [`roles.get()`](/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This method
        /// returns results from all [predefined roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM.
        /// Example request URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
        /// [`projects.roles.get()`](/iam/reference/rest/v1/projects.roles/get):
        /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
        /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example request
        /// URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
        /// [`organizations.roles.get()`](/iam/reference/rest/v1/organizations.roles/get):
        /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
        /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
        /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}` Note:
        /// Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
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
            /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `name` value format
            /// is described below: * [`roles.get()`](/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`. This
            /// method returns results from all [predefined roles](/iam/docs/understanding-roles#predefined_roles) in
            /// Cloud IAM. Example request URL: `https://iam.googleapis.com/v1/roles/{ROLE_NAME}` *
            /// [`projects.roles.get()`](/iam/reference/rest/v1/projects.roles/get):
            /// `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the project level. Example
            /// request URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}` *
            /// [`organizations.roles.get()`](/iam/reference/rest/v1/organizations.roles/get):
            /// `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only [custom
            /// roles](/iam/docs/understanding-custom-roles) that have been created at the organization level. Example
            /// request URL: `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            /// Note: Wildcard (*) values are invalid; you must specify a complete project ID or organization ID.
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
            return new ListRequest(service);
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
            /// [`roles`](/iam/reference/rest/v1/roles), [`projects`](/iam/reference/rest/v1/projects.roles), or
            /// [`organizations`](/iam/reference/rest/v1/organizations.roles). Each resource type's `parent` value
            /// format is described below: * [`roles.list()`](/iam/reference/rest/v1/roles/list): An empty string. This
            /// method doesn't require a resource; it simply returns all [predefined
            /// roles](/iam/docs/understanding-roles#predefined_roles) in Cloud IAM. Example request URL:
            /// `https://iam.googleapis.com/v1/roles` *
            /// [`projects.roles.list()`](/iam/reference/rest/v1/projects.roles/list): `projects/{PROJECT_ID}`. This
            /// method lists all project-level [custom roles](/iam/docs/understanding-custom-roles). Example request
            /// URL: `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles` *
            /// [`organizations.roles.list()`](/iam/reference/rest/v1/organizations.roles/list):
            /// `organizations/{ORGANIZATION_ID}`. This method lists all organization-level [custom
            /// roles](/iam/docs/understanding-custom-roles). Example request URL:
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
            return new QueryGrantableRolesRequest(service, body);
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
        /// Public name of the service. For example, the service name for Cloud IAM is 'iam.googleapis.com'.
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
        /// A single identity requesting access for a Cloud Platform resource. Follows the same format of
        /// Binding.members. Required
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

    /// <summary>The service account disable request.</summary>
    public class DisableServiceAccountRequest : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The request to lint a Cloud IAM policy object.</summary>
    public class LintPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>google.iam.v1.Binding.condition object to be linted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// The full resource name of the policy this lint request is about. The name follows the Google Cloud Platform
        /// (GCP) resource format. For example, a GCP project with ID `my-project` will be named
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`. The resource name is not used to read the
        /// policy instance from the Cloud IAM database. The candidate policy for lint has to be provided in the same
        /// request object.
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

    /// <summary>Represents an OpenId Connect 1.0 identity provider.</summary>
    public class Oidc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Acceptable values for the `aud` field (audience) in the OIDC token. Token exchange requests are rejected if
        /// the token audience does not match one of the configured values. Each audience may be at most 256 characters.
        /// A maximum of 10 audiences may be configured. If this list is empty, the OIDC token audience must be equal to
        /// the full canonical resource name of the WorkloadIdentityPoolProvider, with or without the HTTPS prefix. For
        /// example: ``` //iam.googleapis.com/projects//locations//workloadIdentityPools//providers/
        /// https://iam.googleapis.com/projects//locations//workloadIdentityPools//providers/ ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedAudiences")]
        public virtual System.Collections.Generic.IList<string> AllowedAudiences { get; set; }

        /// <summary>Required. The OIDC issuer URL. Must be an HTTPS endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerUri")]
        public virtual string IssuerUri { get; set; }

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
    /// The request for PatchServiceAccount. You can patch only the `display_name` and `description` fields. You must
    /// use the `update_mask` field to specify which of these fields you want to patch. Only the fields specified in the
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

        /// <summary>
        /// A brief description of what this Permission is used for. This permission can ONLY be used in predefined
        /// roles.
        /// </summary>
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
        /// Required. The full resource name to query from the list of grantable roles. The name follows the Google
        /// Cloud Platform resource format. For example, a Cloud Platform project with id `my-project` will be named
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Optional limit on the number of roles to include in the response. The default is 300, and the maximum is
        /// 1,000.
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
        /// The name of the role. When Role is used in CreateRole, the role name must not be set. When Role is used in
        /// output and other input such as UpdateRole, the role name is the complete path, e.g., roles/logging.viewer
        /// for predefined roles and organizations/{ORGANIZATION_ID}/roles/logging.viewer for custom roles.
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

    /// <summary>
    /// An IAM service account. A service account is an account for an application or a virtual machine (VM) instance,
    /// not a person. You can use a service account to call Google APIs. To learn more, read the [overview of service
    /// accounts](https://cloud.google.com/iam/help/service-accounts/overview). When you create a service account, you
    /// specify the project ID that owns the service account, as well as a name that must be unique within the project.
    /// IAM uses these values to create an email address that identifies the service account.
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
        /// can cause response messages to contain misleading error codes. For example, if you try to get the service
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

        /// <summary>The key can be used after this timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validAfterTime")]
        public virtual object ValidAfterTime { get; set; }

        /// <summary>
        /// The key can be used before this timestamp. For system-managed key pairs, this timestamp is the end time for
        /// the private key signing operation. The public key could still be used for verification for a few hours after
        /// this time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validBeforeTime")]
        public virtual object ValidBeforeTime { get; set; }

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
        /// that is not in the past and no more than 1 hour in the future. If the JWT Claims Set does not contain an
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
        /// A field that allows clients to upload their own public key. If set, use this public key data to create a
        /// service account key for given service account. Please note, the expected format for this field is X509_PEM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyData")]
        public virtual string PublicKeyData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a collection of external workload identities. You can define IAM policies to grant these identities
    /// access to Google Cloud resources.
    /// </summary>
    public class WorkloadIdentityPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A description of the pool. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use existing tokens to
        /// access resources. If the pool is re-enabled, existing tokens grant access again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>A display name for the pool. Cannot exceed 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The resource name of the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A configuration for an external identity provider.</summary>
    public class WorkloadIdentityPoolProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [A Common Expression Language](https://opensource.google/projects/cel) expression, in plain text, to
        /// restrict what otherwise valid authentication credentials issued by the provider should not be accepted. The
        /// expression must output a boolean representing whether to allow the federation. The following keywords may be
        /// referenced in the expressions: * `assertion`: JSON representing the authentication credential issued by the
        /// provider. * `google`: The Google attributes mapped from the assertion in the `attribute_mappings`. *
        /// `attribute`: The custom attributes mapped from the assertion in the `attribute_mappings`. The maximum length
        /// of the attribute condition expression is 4096 characters. If unspecified, all valid authentication
        /// credential are accepted. The following example shows how to only allow credentials with a mapped
        /// `google.groups` value of `admins`: ``` "'admins' in google.groups" ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeCondition")]
        public virtual string AttributeCondition { get; set; }

        /// <summary>
        /// Maps attributes from authentication credentials issued by an external identity provider to Google Cloud
        /// attributes, such as `subject` and `segment`. Each key must be a string specifying the Google Cloud IAM
        /// attribute to map to. The following keys are supported: * `google.subject`: The principal IAM is
        /// authenticating. You can reference this value in IAM bindings. This is also the subject that appears in Cloud
        /// Logging logs. Cannot exceed 127 characters. * `google.groups`: Groups the external identity belongs to. You
        /// can grant groups access to resources using an IAM `principalSet` binding; access applies to all members of
        /// the group. You can also provide custom attributes by specifying `attribute.{custom_attribute}`, where
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
        /// attribute mapping is defined, the following default mapping applies: ``` { "google.subject":"assertion.arn",
        /// "attribute.aws_role": "assertion.arn.contains('assumed-role')" " ?
        /// assertion.arn.extract('{account_arn}assumed-role/')" " + 'assumed-role/'" " +
        /// assertion.arn.extract('assumed-role/{role_name}/')" " : assertion.arn", } ``` If any custom attribute
        /// mappings are defined, they must include a mapping to the `google.subject` attribute. For OIDC providers, you
        /// must supply a custom mapping, which must include the `google.subject` attribute. For example, the following
        /// maps the `sub` claim of the incoming credential to the `subject` attribute on a Google token: ```
        /// {"google.subject": "assertion.sub"} ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> AttributeMapping { get; set; }

        /// <summary>An Amazon Web Services identity provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aws")]
        public virtual Aws Aws { get; set; }

        /// <summary>A description for the provider. Cannot exceed 256 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Whether the provider is disabled. You cannot use a disabled provider to exchange tokens. However, existing
        /// tokens still grant access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>A display name for the provider. Cannot exceed 32 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The resource name of the provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An OpenId Connect 1.0 identity provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidc")]
        public virtual Oidc Oidc { get; set; }

        /// <summary>Output only. The state of the provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
