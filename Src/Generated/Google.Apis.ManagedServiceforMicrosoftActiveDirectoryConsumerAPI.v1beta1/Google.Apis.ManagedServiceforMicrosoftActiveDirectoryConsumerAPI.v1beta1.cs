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

namespace Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1
{
    /// <summary>The ManagedServiceforMicrosoftActiveDirectoryConsumerAPI Service.</summary>
    public class ManagedServiceforMicrosoftActiveDirectoryConsumerAPIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ManagedServiceforMicrosoftActiveDirectoryConsumerAPIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ManagedServiceforMicrosoftActiveDirectoryConsumerAPIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "managedidentities";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://managedidentities.googleapis.com/";
        #else
            "https://managedidentities.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://managedidentities.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>
        /// Available OAuth 2.0 scopes for use with the Managed Service for Microsoft Active Directory API.
        /// </summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Managed Service for Microsoft Active Directory API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for ManagedServiceforMicrosoftActiveDirectoryConsumerAPI requests.</summary>
    public abstract class ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>
        /// Constructs a new ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest instance.
        /// </summary>
        protected ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ManagedServiceforMicrosoftActiveDirectoryConsumerAPI parameter list.</summary>
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
                Global = new GlobalResource(service);
            }

            /// <summary>Gets the Global resource.</summary>
            public virtual GlobalResource Global { get; }

            /// <summary>The "global" collection of methods.</summary>
            public class GlobalResource
            {
                private const string Resource = "global";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GlobalResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Domains = new DomainsResource(service);
                    Operations = new OperationsResource(service);
                    Peerings = new PeeringsResource(service);
                }

                /// <summary>Gets the Domains resource.</summary>
                public virtual DomainsResource Domains { get; }

                /// <summary>The "domains" collection of methods.</summary>
                public class DomainsResource
                {
                    private const string Resource = "domains";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DomainsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Backups = new BackupsResource(service);
                        SqlIntegrations = new SqlIntegrationsResource(service);
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
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                        {
                            return new GetIamPolicyRequest(service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Policy>
                        {
                            /// <summary>Constructs a new GetIamPolicy request.</summary>
                            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                            {
                                Resource = resource;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being requested. See the operation
                            /// documentation for the appropriate value for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>
                            /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3.
                            /// Requests specifying an invalid value will be rejected. Requests for policies with any
                            /// conditional bindings must specify version 3. Policies without any conditional bindings
                            /// may specify any valid value or leave the field unset. To learn which resources support
                            /// conditions in their IAM policies, see the [IAM
                            /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+/backups/[^/]+$",
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

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        public class SetIamPolicyRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                            Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "setIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+/backups/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </param>
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                            Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "testIamPermissions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                                    Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+/backups/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Gets the SqlIntegrations resource.</summary>
                    public virtual SqlIntegrationsResource SqlIntegrations { get; }

                    /// <summary>The "sqlIntegrations" collection of methods.</summary>
                    public class SqlIntegrationsResource
                    {
                        private const string Resource = "sqlIntegrations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SqlIntegrationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Gets details of a single sqlIntegration.</summary>
                        /// <param name="name">
                        /// Required. SqlIntegration resource name using the form:
                        /// `projects/{project_id}/locations/global/domains/*/sqlIntegrations/{name}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets details of a single sqlIntegration.</summary>
                        public class GetRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SqlIntegration>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. SqlIntegration resource name using the form:
                            /// `projects/{project_id}/locations/global/domains/*/sqlIntegrations/{name}`
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
                                    Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+/sqlIntegrations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists SqlIntegrations in a given domain.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the SqlIntegrations using the form:
                        /// `projects/{project_id}/locations/global/domains/*`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists SqlIntegrations in a given domain.</summary>
                        public class ListRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ListSqlIntegrationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the SqlIntegrations using the form:
                            /// `projects/{project_id}/locations/global/domains/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Filter specifying constraints of a list operation. For example,
                            /// `SqlIntegration.name="sql"`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Specifies the ordering of results following syntax at
                            /// https://cloud.google.com/apis/design/design_patterns#sorting_order.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of items to return. If not specified, a default value of
                            /// 1000 will be used by the service. Regardless of the page_size value, the response may
                            /// include a partial list and a caller should only rely on response'ANIZATIONs
                            /// next_page_token to determine if there are more instances left to be queried.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. The next_page_token value returned from a previous List request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta1/{+parent}/sqlIntegrations";

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
                                    Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
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

                    /// <summary>Adds an AD trust to a domain.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource domain name, project name and location using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual AttachTrustRequest AttachTrust(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.AttachTrustRequest body, string name)
                    {
                        return new AttachTrustRequest(service, body, name);
                    }

                    /// <summary>Adds an AD trust to a domain.</summary>
                    public class AttachTrustRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new AttachTrust request.</summary>
                        public AttachTrustRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.AttachTrustRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource domain name, project name and location using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.AttachTrustRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "attachTrust";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:attachTrust";

                        /// <summary>Initializes AttachTrust parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Creates a Microsoft AD domain.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource project name and location using the form:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Domain body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a Microsoft AD domain.</summary>
                    public class CreateRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Domain body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource project name and location using the form:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. A domain name, e.g. mydomain.myorg.com, with the following restrictions: * Must
                        /// contain only lowercase letters, numbers, periods and hyphens. * Must start with a letter. *
                        /// Must contain between 2-64 characters. * Must end with a number or a letter. * Must not start
                        /// with period. * First segment length (mydomain form example above) shouldn't exceed 15 chars.
                        /// * The last segment cannot be fully numeric. * Must be unique within the customer project.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DomainName { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Domain Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/domains";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
                            });
                            RequestParameters.Add("domainName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "domainName",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a domain.</summary>
                    /// <param name="name">
                    /// Required. The domain resource name using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a domain.</summary>
                    public class DeleteRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The domain resource name using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
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
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Removes an AD trust.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource domain name, project name, and location using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual DetachTrustRequest DetachTrust(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.DetachTrustRequest body, string name)
                    {
                        return new DetachTrustRequest(service, body, name);
                    }

                    /// <summary>Removes an AD trust.</summary>
                    public class DetachTrustRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new DetachTrust request.</summary>
                        public DetachTrustRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.DetachTrustRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource domain name, project name, and location using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.DetachTrustRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "detachTrust";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:detachTrust";

                        /// <summary>Initializes DetachTrust parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets information about a domain.</summary>
                    /// <param name="name">
                    /// Required. The domain resource name using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets information about a domain.</summary>
                    public class GetRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Domain>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The domain resource name using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
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
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
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

                    /// <summary>Gets the domain ldaps settings.</summary>
                    /// <param name="name">
                    /// Required. The domain resource name using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual GetLdapssettingsRequest GetLdapssettings(string name)
                    {
                        return new GetLdapssettingsRequest(service, name);
                    }

                    /// <summary>Gets the domain ldaps settings.</summary>
                    public class GetLdapssettingsRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.LDAPSSettings>
                    {
                        /// <summary>Constructs a new GetLdapssettings request.</summary>
                        public GetLdapssettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The domain resource name using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getLdapssettings";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}/ldapssettings";

                        /// <summary>Initializes GetLdapssettings parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists domains in a project.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the domain location using the form:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists domains in a project.</summary>
                    public class ListRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ListDomainsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the domain location using the form:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. A filter specifying constraints of a list operation. For example,
                        /// `Domain.fqdn="mydomain.myorginization"`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specifies the ordering of results. See [Sorting
                        /// order](https://cloud.google.com/apis/design/design_patterns#sorting_order) for more
                        /// information.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If not specified, a default value of 1000
                        /// will be used. Regardless of the page_size value, the response may include a partial list.
                        /// Callers should rely on a response's next_page_token to determine if there are additional
                        /// results to list.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The `next_page_token` value returned from a previous ListDomainsRequest request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/domains";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
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

                    /// <summary>Updates the metadata and configuration of a domain.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The unique name of the domain using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Domain body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the metadata and configuration of a domain.</summary>
                    public class PatchRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Domain body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The unique name of the domain using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field. The
                        /// elements of the repeated paths field may only include fields from Domain: * `labels` *
                        /// `locations` * `authorized_networks` * `audit_logs_enabled`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Domain Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
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

                    /// <summary>Updates the DNS conditional forwarder.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource domain name, project name and location using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual ReconfigureTrustRequest ReconfigureTrust(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ReconfigureTrustRequest body, string name)
                    {
                        return new ReconfigureTrustRequest(service, body, name);
                    }

                    /// <summary>Updates the DNS conditional forwarder.</summary>
                    public class ReconfigureTrustRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new ReconfigureTrust request.</summary>
                        public ReconfigureTrustRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ReconfigureTrustRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource domain name, project name and location using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ReconfigureTrustRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "reconfigureTrust";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:reconfigureTrust";

                        /// <summary>Initializes ReconfigureTrust parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Resets a domain's administrator password.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The domain resource name using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual ResetAdminPasswordRequest ResetAdminPassword(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ResetAdminPasswordRequest body, string name)
                    {
                        return new ResetAdminPasswordRequest(service, body, name);
                    }

                    /// <summary>Resets a domain's administrator password.</summary>
                    public class ResetAdminPasswordRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ResetAdminPasswordResponse>
                    {
                        /// <summary>Constructs a new ResetAdminPassword request.</summary>
                        public ResetAdminPasswordRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ResetAdminPasswordRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The domain resource name using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ResetAdminPasswordRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "resetAdminPassword";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:resetAdminPassword";

                        /// <summary>Initializes ResetAdminPassword parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Patches a single ldaps settings.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The resource name of the LDAPS settings. Uses the form:
                    /// `projects/{project}/locations/{location}/domains/{domain}`.
                    /// </param>
                    public virtual UpdateLdapssettingsRequest UpdateLdapssettings(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.LDAPSSettings body, string name)
                    {
                        return new UpdateLdapssettingsRequest(service, body, name);
                    }

                    /// <summary>Patches a single ldaps settings.</summary>
                    public class UpdateLdapssettingsRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new UpdateLdapssettings request.</summary>
                        public UpdateLdapssettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.LDAPSSettings body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name of the LDAPS settings. Uses the form:
                        /// `projects/{project}/locations/{location}/domains/{domain}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field. For
                        /// the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.LDAPSSettings Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "updateLdapssettings";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}/ldapssettings";

                        /// <summary>Initializes UpdateLdapssettings parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
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
                    /// Validates a trust state, that the target domain is reachable, and that the target domain is able
                    /// to accept incoming trust requests.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource domain name, project name, and location using the form:
                    /// `projects/{project_id}/locations/global/domains/{domain_name}`
                    /// </param>
                    public virtual ValidateTrustRequest ValidateTrust(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ValidateTrustRequest body, string name)
                    {
                        return new ValidateTrustRequest(service, body, name);
                    }

                    /// <summary>
                    /// Validates a trust state, that the target domain is reachable, and that the target domain is able
                    /// to accept incoming trust requests.
                    /// </summary>
                    public class ValidateTrustRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new ValidateTrust request.</summary>
                        public ValidateTrustRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ValidateTrustRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource domain name, project name, and location using the form:
                        /// `projects/{project_id}/locations/global/domains/{domain_name}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ValidateTrustRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "validateTrust";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:validateTrust";

                        /// <summary>Initializes ValidateTrust parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/domains/[^/]+$",
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
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.CancelOperationRequest body, string name)
                    {
                        return new CancelRequest(service, body, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.CancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.CancelOperationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:cancel";

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
                                Pattern = @"^projects/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    public class DeleteRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Empty>
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
                                Pattern = @"^projects/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
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
                    public class GetRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
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
                                Pattern = @"^projects/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ListOperationsResponse>
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
                        public override string RestPath => "v1beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/global/operations$",
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

                /// <summary>Gets the Peerings resource.</summary>
                public virtual PeeringsResource Peerings { get; }

                /// <summary>The "peerings" collection of methods.</summary>
                public class PeeringsResource
                {
                    private const string Resource = "peerings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PeeringsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a Peering for Managed AD instance.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Resource project name and location using the form:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Peering body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a Peering for Managed AD instance.</summary>
                    public class CreateRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Peering body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource project name and location using the form:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. Peering Id, unique name to identify peering.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("peeringId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PeeringId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Peering Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/peerings";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
                            });
                            RequestParameters.Add("peeringId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "peeringId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes identified Peering.</summary>
                    /// <param name="name">
                    /// Required. Peering resource name using the form:
                    /// `projects/{project_id}/locations/global/peerings/{peering_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes identified Peering.</summary>
                    public class DeleteRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Peering resource name using the form:
                        /// `projects/{project_id}/locations/global/peerings/{peering_id}`
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
                                Pattern = @"^projects/[^/]+/locations/global/peerings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single Peering.</summary>
                    /// <param name="name">
                    /// Required. Peering resource name using the form:
                    /// `projects/{project_id}/locations/global/domains/{peering_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets details of a single Peering.</summary>
                    public class GetRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Peering>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Peering resource name using the form:
                        /// `projects/{project_id}/locations/global/domains/{peering_id}`
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
                                Pattern = @"^projects/[^/]+/locations/global/peerings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/global/peerings/[^/]+$",
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

                    /// <summary>Lists Peerings in a given project.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the domain location using the form:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists Peerings in a given project.</summary>
                    public class ListRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ListPeeringsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the domain location using the form:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter specifying constraints of a list operation. For example,
                        /// `peering.authoized_network ="/projects/myprojectid"`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specifies the ordering of results following syntax at
                        /// https://cloud.google.com/apis/design/design_patterns#sorting_order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If not specified, a default value of 1000
                        /// will be used by the service. Regardless of the page_size value, the response may include a
                        /// partial list and a caller should only rely on response's next_page_token to determine if
                        /// there are more instances left to be queried.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/peerings";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
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

                    /// <summary>Updates the labels for specified Peering.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Unique name of the peering in this scope including projects and location using the
                    /// form: `projects/{project_id}/locations/global/peerings/{peering_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Peering body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the labels for specified Peering.</summary>
                    public class PatchRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Peering body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Unique name of the peering in this scope including projects and location using
                        /// the form: `projects/{project_id}/locations/global/peerings/{peering_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field. The
                        /// elements of the repeated paths field may only include these fields from Peering: * `labels`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Peering Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/peerings/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/global/peerings/[^/]+$",
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/global/peerings/[^/]+$",
                            });
                        }
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
            public class GetRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.Location>
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
            public class ListRequest : ManagedServiceforMicrosoftActiveDirectoryConsumerAPIBaseServiceRequest<Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data.ListLocationsResponse>
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
                public override string RestPath => "v1beta1/{+name}/locations";

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
namespace Google.Apis.ManagedServiceforMicrosoftActiveDirectoryConsumerAPI.v1beta1.Data
{
    /// <summary>Request message for AttachTrust</summary>
    public class AttachTrustRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The domain trust resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trust")]
        public virtual Trust Trust { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Certificate used to configure LDAPS.</summary>
    public class Certificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The certificate expire time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The issuer of this certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuingCertificate")]
        public virtual Certificate IssuingCertificate { get; set; }

        /// <summary>The certificate subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The additional hostnames for the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectAlternativeName")]
        public virtual System.Collections.Generic.IList<string> SubjectAlternativeName { get; set; }

        /// <summary>The certificate thumbprint which uniquely identifies the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbprint")]
        public virtual string Thumbprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for daily operations.</summary>
    public class DailyCycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Duration of the time window, set by service producer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Time within the day to start the operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DenyMaintenancePeriod definition. Maintenance is forbidden within the deny period. The start_date must be less
    /// than the end_date.
    /// </summary>
    public class DenyMaintenancePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deny period end date. This can be: * A full date, with non-zero year, month and day values. * A month and
        /// day value, with a zero year. Allows recurring deny periods each year. Date matching this period will have to
        /// be before the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// Deny period start date. This can be: * A full date, with non-zero year, month and day values. * A month and
        /// day value, with a zero year. Allows recurring deny periods each year. Date matching this period will have to
        /// be the same or after the start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>
        /// Time in UTC when the Blackout period starts on start_date and ends on end_date. This can be: * Full time. *
        /// All zeros for 00:00:00 UTC
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual TimeOfDay Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DetachTrust</summary>
    public class DetachTrustRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The domain trust resource to removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trust")]
        public virtual Trust Trust { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If the domain is being changed, it will be placed into the UPDATING state, which indicates that the resource is
    /// being reconciled. At this point, Get will reflect an intermediate state. Represents a managed Microsoft Active
    /// Directory domain.
    /// </summary>
    public class Domain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of delegated administrator account used to perform Active Directory operations. If not
        /// specified, `setupadmin` will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admin")]
        public virtual string Admin { get; set; }

        /// <summary>
        /// Optional. Configuration for audit logs. True if audit logs are enabled, else false. Default is audit logs
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogsEnabled")]
        public virtual System.Nullable<bool> AuditLogsEnabled { get; set; }

        /// <summary>
        /// Optional. The full names of the Google Compute Engine
        /// [networks](/compute/docs/networks-and-firewalls#networks) the domain instance is connected to. Networks can
        /// be added using UpdateDomain. The domain is only available on networks listed in `authorized_networks`. If
        /// CIDR subnets overlap between networks, domain creation will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedNetworks")]
        public virtual System.Collections.Generic.IList<string> AuthorizedNetworks { get; set; }

        /// <summary>Output only. The time the instance was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The fully-qualified domain name of the exposed domain used by clients to connect to the
        /// service. Similar to what would be chosen for an Active Directory set up on an internal network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>Optional. Resource labels that can contain user-provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Locations where domain needs to be provisioned. regions e.g. us-west1 or us-east4 Service supports
        /// up to 4 locations at once. Each location will use a /26 block.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>
        /// Output only. The unique name of the domain using the form:
        /// `projects/{project_id}/locations/global/domains/{domain_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The CIDR range of internal addresses that are reserved for this domain. Reserved networks must be
        /// /24 or larger. Ranges must be unique and non-overlapping with existing subnets in
        /// [Domain].[authorized_networks].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedIpRange")]
        public virtual string ReservedIpRange { get; set; }

        /// <summary>Output only. The current state of this domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Additional information about the current status of this domain, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. The current trusts associated with the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trusts")]
        public virtual System.Collections.Generic.IList<Trust> Trusts { get; set; }

        /// <summary>Output only. The last update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudManagedidentitiesV1OpMetadata : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudManagedidentitiesV1alpha1OpMetadata : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudManagedidentitiesV1beta1OpMetadata : Google.Apis.Requests.IDirectResponseSchema
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

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSaasacceleratorManagementProvidersV1Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// consumer_defined_name is the name that is set by the consumer. On the other hand Name field represents
        /// system-assigned id of an instance so consumers are not necessarily aware of it. consumer_defined_name is
        /// used for notification/UI purposes for consumer to recognize their instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerDefinedName")]
        public virtual string ConsumerDefinedName { get; set; }

        /// <summary>Output only. Timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. Each label is a key-value pair, where both
        /// the key and the value are arbitrary strings provided by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Deprecated. The MaintenancePolicies that have been attached to the instance. The key must be of the type
        /// name of the oneof policy name defined in MaintenancePolicy, and the referenced policy must define the same
        /// policy type. For complete details of MaintenancePolicy, please refer to go/cloud-saas-mw-ug.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicyNames")]
        public virtual System.Collections.Generic.IDictionary<string, string> MaintenancePolicyNames { get; set; }

        /// <summary>
        /// The MaintenanceSchedule contains the scheduling information of published maintenance schedule with same key
        /// as software_versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSchedules")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSchedule> MaintenanceSchedules { get; set; }

        /// <summary>Optional. The MaintenanceSettings associated with instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSettings")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSettings MaintenanceSettings { get; set; }

        /// <summary>
        /// Unique name of the resource. It uses the form:
        /// `projects/{project_id|project_number}/locations/{location_id}/instances/{instance_id}` Note: Either
        /// project_id or project_number can be used, but keep it consistent with other APIs (e.g. RescheduleUpdate)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Custom string attributes used primarily to expose producer-specific information in monitoring
        /// dashboards. See go/get-instance-metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> ProducerMetadata { get; set; }

        /// <summary>
        /// Output only. The list of data plane resources provisioned for this instance, e.g. compute VMs. See
        /// go/get-instance-metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1ProvisionedResource> ProvisionedResources { get; set; }

        /// <summary>
        /// Link to the SLM instance template. Only populated when updating SLM instances via SSA's Actuation service
        /// adaptor. Service producers with custom control plane (e.g. Cloud SQL) doesn't need to populate this field.
        /// Instead they should use software_versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slmInstanceTemplate")]
        public virtual string SlmInstanceTemplate { get; set; }

        /// <summary>
        /// Output only. SLO metadata for instance classification in the Standardized dataplane SLO platform. See
        /// go/cloud-ssa-standard-slo for feature description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sloMetadata")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1SloMetadata SloMetadata { get; set; }

        /// <summary>
        /// Software versions that are used to deploy this instance. This can be mutated by rollout services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareVersions")]
        public virtual System.Collections.Generic.IDictionary<string, string> SoftwareVersions { get; set; }

        /// <summary>
        /// Output only. Current lifecycle state of the resource (e.g. if it's being created or ready to use).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ID of the associated GCP tenant project. See go/get-instance-metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectId")]
        public virtual string TenantProjectId { get; set; }

        /// <summary>Output only. Timestamp when the resource was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance schedule which is exposed to customer and potentially end user, indicating published upcoming future
    /// maintenance schedule
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field is deprecated, and will be always set to true since reschedule can happen multiple times now.
        /// This field should not be removed until all service producers remove this for their customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReschedule")]
        public virtual System.Nullable<bool> CanReschedule { get; set; }

        /// <summary>The scheduled end time for the maintenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The rollout management policy this maintenance schedule is associated with. When doing reschedule update
        /// request, the reschedule should be against this given policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutManagementPolicy")]
        public virtual string RolloutManagementPolicy { get; set; }

        /// <summary>
        /// schedule_deadline_time is the time deadline any schedule start time cannot go beyond, including reschedule.
        /// It's normally the initial schedule start time plus maintenance window length (1 day or 1 week). Maintenance
        /// cannot be scheduled to start beyond this deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleDeadlineTime")]
        public virtual object ScheduleDeadlineTime { get; set; }

        /// <summary>The scheduled start time for the maintenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance settings associated with instance. Allows service producers and end users to assign settings that
    /// controls maintenance on this instance.
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Exclude instance from maintenance. When true, rollout service will not attempt maintenance on the
        /// instance. Rollout service will include the instance in reported rollout progress as not attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclude")]
        public virtual System.Nullable<bool> Exclude { get; set; }

        /// <summary>Optional. If the update call is triggered from rollback, set the value as true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRollback")]
        public virtual System.Nullable<bool> IsRollback { get; set; }

        /// <summary>
        /// Optional. The MaintenancePolicies that have been attached to the instance. The key must be of the type name
        /// of the oneof policy name defined in MaintenancePolicy, and the embedded policy must define the same policy
        /// type. For complete details of MaintenancePolicy, please refer to go/cloud-saas-mw-ug. If only the name is
        /// needed (like in the deprecated Instance.maintenance_policy_names field) then only populate
        /// MaintenancePolicy.name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicies")]
        public virtual System.Collections.Generic.IDictionary<string, MaintenancePolicy> MaintenancePolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Node information for custom per-node SLO implementations. SSA does not support per-node SLO, but producers can
    /// populate per-node information in SloMetadata for custom precomputations. SSA Eligibility Exporter will emit
    /// per-node metric based on this information.
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1NodeSloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default node is eligible if instance is eligible. But individual node might be excluded from SLO by
        /// adding entry here. For semantic see SloMetadata.exclusions. If both instance and node level exclusions are
        /// present for time period, the node level's reason will be reported by Eligibility Exporter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1SloExclusion> Exclusions { get; set; }

        /// <summary>The location of the node, if different from instance location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The id of the node. This should be equal to SaasInstanceNode.node_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeId")]
        public virtual string NodeId { get; set; }

        /// <summary>
        /// If present, this will override eligibility for the node coming from instance or exclusions for specified
        /// SLIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSliEligibility")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1PerSliSloEligibility PerSliEligibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PerSliSloEligibility is a mapping from an SLI name to eligibility.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1PerSliSloEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An entry in the eligibilities map specifies an eligibility for a particular SLI for the given instance. The
        /// SLI key in the name must be a valid SLI name specified in the Eligibility Exporter binary flags otherwise an
        /// error will be emitted by Eligibility Exporter and the oncaller will be alerted. If an SLI has been defined
        /// in the binary flags but the eligibilities map does not contain it, the corresponding SLI time series will
        /// not be emitted by the Eligibility Exporter. This ensures a smooth rollout and compatibility between the data
        /// produced by different versions of the Eligibility Exporters. If eligibilities map contains a key for an SLI
        /// which has not been declared in the binary flags, there will be an error message emitted in the Eligibility
        /// Exporter log and the metric for the SLI in question will not be emitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibilities")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSaasacceleratorManagementProvidersV1SloEligibility> Eligibilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes provisioned dataplane resources.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1ProvisionedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type of the resource. This can be either a GCP resource or a custom one (e.g. another cloud provider's VM).
        /// For GCP compute resources use singular form of the names listed in GCP compute API documentation
        /// (https://cloud.google.com/compute/docs/reference/rest/v1/), prefixed with 'compute-', for example:
        /// 'compute-instance', 'compute-disk', 'compute-autoscaler'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>URL identifying the resource, e.g. "https://www.googleapis.com/compute/v1/projects/...)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SloEligibility is a tuple containing eligibility value: true if an instance is eligible for SLO calculation or
    /// false if it should be excluded from all SLO-related calculations along with a user-defined reason.
    /// </summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether an instance is eligible or ineligible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligible")]
        public virtual System.Nullable<bool> Eligible { get; set; }

        /// <summary>
        /// User-defined reason for the current value of instance eligibility. Usually, this can be directly mapped to
        /// the internal state. An empty reason is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SloExclusion represents an exclusion in SLI calculation applies to all SLOs.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloExclusion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Exclusion duration. No restrictions on the possible values. When an ongoing operation is taking longer than
        /// initially expected, an existing entry in the exclusion list can be updated by extending the duration. This
        /// is supported by the subsystem exporting eligibility data as long as such extension is committed at least 10
        /// minutes before the original exclusion expiration - otherwise it is possible that there will be "gaps" in the
        /// exclusion application in the exported timeseries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Human-readable reason for the exclusion. This should be a static string (e.g. "Disruptive update in
        /// progress") and should not contain dynamically generated data (e.g. instance name). Can be left empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// Name of an SLI that this exclusion applies to. Can be left empty, signaling that the instance should be
        /// excluded from all SLIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sliName")]
        public virtual string SliName { get; set; }

        /// <summary>Start time of the exclusion. No alignment (e.g. to a full minute) needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SloMetadata contains resources required for proper SLO classification of the instance.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of SLO exclusion windows. When multiple entries in the list match (matching the exclusion time-window
        /// against current time point) the exclusion reason used in the first matching entry will be published. It is
        /// not needed to include expired exclusion in this list, as only the currently applicable exclusions are taken
        /// into account by the eligibility exporting subsystem (the historical state of exclusions will be reflected in
        /// the historically produced timeseries regardless of the current state). This field can be used to mark the
        /// instance as temporary ineligible for the purpose of SLO calculation. For permanent instance SLO exclusion,
        /// use of custom instance eligibility is recommended. See 'eligibility' field below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1SloExclusion> Exclusions { get; set; }

        /// <summary>
        /// Optional. List of nodes. Some producers need to use per-node metadata to calculate SLO. This field allows
        /// such producers to publish per-node SLO meta data, which will be consumed by SSA Eligibility Exporter and
        /// published in the form of per node metric to Monarch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1NodeSloMetadata> Nodes { get; set; }

        /// <summary>Optional. Multiple per-instance SLI eligibilities which apply for individual SLIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSliEligibility")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1PerSliSloEligibility PerSliEligibility { get; set; }

        /// <summary>
        /// Name of the SLO tier the Instance belongs to. This name will be expected to match the tiers specified in the
        /// service SLO configuration. Field is mandatory and must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// LDAPSSettings represents the ldaps settings for domain resource. LDAP is the Lightweight Directory Access
    /// Protocol, defined in https://tools.ietf.org/html/rfc4511. The settings object configures LDAP over SSL/TLS,
    /// whether it is over port 636 or the StartTLS operation. If LDAPSSettings is being changed, it will be placed into
    /// the UPDATING state, which indicates that the resource is being reconciled. At this point, Get will reflect an
    /// intermediate state.
    /// </summary>
    public class LDAPSSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The certificate used to configure LDAPS. Certificates can be chained with a maximum length of
        /// 15.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual Certificate Certificate { get; set; }

        /// <summary>Input only. The password used to encrypt the uploaded pfx certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificatePassword")]
        public virtual string CertificatePassword { get; set; }

        /// <summary>
        /// Input only. The uploaded PKCS12-formatted certificate to configure LDAPS with. It will enable the domain
        /// controllers in this domain to accept LDAPS connections (either LDAP over SSL/TLS or the StartTLS operation).
        /// A valid certificate chain must form a valid x.509 certificate chain (or be comprised of a single self-signed
        /// certificate. It must be encrypted with either: 1) PBES2 + PBKDF2 + AES256 encryption and SHA256 PRF; or 2)
        /// pbeWithSHA1And3-KeyTripleDES-CBC Private key must be included for the leaf / single self-signed certificate.
        /// Note: For a fqdn your-example-domain.com, the wildcard fqdn is *.your-example-domain.com. Specifically the
        /// leaf certificate must have: - Either a blank subject or a subject with CN matching the wildcard fqdn. -
        /// Exactly two SANs - the fqdn and wildcard fqdn. - Encipherment and digital key signature key usages. - Server
        /// authentication extended key usage (OID=1.3.6.1.5.5.7.3.1) - Private key must be in one of the following
        /// formats: RSA, ECDSA, ED25519. - Private key must have appropriate key length: 2048 for RSA, 256 for ECDSA -
        /// Signature algorithm of the leaf certificate cannot be MD2, MD5 or SHA1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificatePfx")]
        public virtual string CertificatePfx { get; set; }

        /// <summary>
        /// The resource name of the LDAPS settings. Uses the form:
        /// `projects/{project}/locations/{location}/domains/{domain}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of this LDAPS settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Last update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDomains</summary>
    public class ListDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Managed Identities Service domains in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<Domain> Domains { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of locations that could not be reached.</summary>
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

    /// <summary>ListPeeringsResponse is the response message for ListPeerings method.</summary>
    public class ListPeeringsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of Managed Identities Service Peerings in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerings")]
        public virtual System.Collections.Generic.IList<Peering> Peerings { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListSqlIntegrationsResponse is the response message for ListSqlIntegrations method.</summary>
    public class ListSqlIntegrationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of SqlIntegrations of a domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlIntegrations")]
        public virtual System.Collections.Generic.IList<SqlIntegration> SqlIntegrations { get; set; }

        /// <summary>A list of locations that could not be reached.</summary>
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

    /// <summary>Defines policies to service maintenance events.</summary>
    public class MaintenancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. Description of what this policy is for. Create/Update methods return INVALID_ARGUMENT if the
        /// length is greater than 512.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. Each label is a key-value pair, where both
        /// the key and the value are arbitrary strings provided by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. MaintenancePolicy name using the form:
        /// `projects/{project_id}/locations/{location_id}/maintenancePolicies/{maintenance_policy_id}` where
        /// {project_id} refers to a GCP consumer project ID, {location_id} refers to a GCP region/zone,
        /// {maintenance_policy_id} must be 1-63 characters long and match the regular expression
        /// `[a-z0-9]([-a-z0-9]*[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The state of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Maintenance policy applicable to instance update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePolicy")]
        public virtual UpdatePolicy UpdatePolicy { get; set; }

        /// <summary>Output only. The time when the resource was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MaintenanceWindow definition.</summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daily cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyCycle")]
        public virtual DailyCycle DailyCycle { get; set; }

        /// <summary>Weekly cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyCycle")]
        public virtual WeeklyCycle WeeklyCycle { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

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

    /// <summary>Represents a Managed Microsoft Identities Peering.</summary>
    public class Peering : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The full names of the Google Compute Engine
        /// [networks](/compute/docs/networks-and-firewalls#networks) to which the instance is connected. Caller needs
        /// to make sure that CIDR subnets do not overlap between networks, else peering creation will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedNetwork")]
        public virtual string AuthorizedNetwork { get; set; }

        /// <summary>Output only. The time the instance was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Required. Full domain resource path for the Managed AD Domain involved in peering. The resource path should
        /// be in the form: `projects/{project_id}/locations/global/domains/{domain_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainResource")]
        public virtual string DomainResource { get; set; }

        /// <summary>Optional. Resource labels to represent user provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Unique name of the peering in this scope including projects and location using the form:
        /// `projects/{project_id}/locations/global/peerings/{peering_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of this Peering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Additional information about the current status of this peering, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Last update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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

    /// <summary>Request message for ReconfigureTrust</summary>
    public class ReconfigureTrustRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The target DNS server IP addresses to resolve the remote domain involved in the trust.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetDnsIpAddresses")]
        public virtual System.Collections.Generic.IList<string> TargetDnsIpAddresses { get; set; }

        /// <summary>
        /// Required. The fully-qualified target domain name which will be in trust with current domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetDomainName")]
        public virtual string TargetDomainName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ResetAdminPassword</summary>
    public class ResetAdminPasswordRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ResetAdminPassword</summary>
    public class ResetAdminPasswordResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A random password. See admin for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configure the schedule.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allows to define schedule that runs specified day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Output only. Duration of the time window, set by service producer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Time within the window to start the operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the Sql instance integrated with AD.</summary>
    public class SqlIntegration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time sql integration was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The unique name of the sql integration in the form of
        /// `projects/{project_id}/locations/global/domains/{domain_name}/sqlIntegrations/{sql_integration}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The full resource name of an integrated sql instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlInstance")]
        public virtual string SqlInstance { get; set; }

        /// <summary>Output only. The current state of the sql integration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The time sql integration was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a relationship between two domains. This allows a controller in one domain to authenticate a user in
    /// another domain.
    /// </summary>
    public class Trust : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the instance was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The last heartbeat time when the trust was known to be connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTrustHeartbeatTime")]
        public virtual object LastTrustHeartbeatTime { get; set; }

        /// <summary>
        /// The trust authentication type, which decides whether the trusted side has forest/domain wide access or
        /// selective access to an approved set of resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectiveAuthentication")]
        public virtual System.Nullable<bool> SelectiveAuthentication { get; set; }

        /// <summary>Output only. The current state of the trust.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional information about the current state of the trust, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDescription")]
        public virtual string StateDescription { get; set; }

        /// <summary>
        /// The target DNS server IP addresses which can resolve the remote domain involved in the trust.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetDnsIpAddresses")]
        public virtual System.Collections.Generic.IList<string> TargetDnsIpAddresses { get; set; }

        /// <summary>The fully qualified target domain name which will be in trust with the current domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetDomainName")]
        public virtual string TargetDomainName { get; set; }

        /// <summary>The trust direction, which decides if the current domain is trusted, trusting, or both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustDirection")]
        public virtual string TrustDirection { get; set; }

        /// <summary>
        /// Input only. The trust secret used for the handshake with the target domain. It will not be stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustHandshakeSecret")]
        public virtual string TrustHandshakeSecret { get; set; }

        /// <summary>The type of trust represented by the trust resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustType")]
        public virtual string TrustType { get; set; }

        /// <summary>Output only. The last update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maintenance policy applicable to instance updates.</summary>
    public class UpdatePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Relative scheduling channel applied to resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// Deny Maintenance Period that is applied to resource to indicate when maintenance is forbidden. User can
        /// specify zero or more non-overlapping deny periods. For V1, Maximum number of deny_maintenance_periods is
        /// expected to be one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyMaintenancePeriods")]
        public virtual System.Collections.Generic.IList<DenyMaintenancePeriod> DenyMaintenancePeriods { get; set; }

        /// <summary>Optional. Maintenance window that is applied to resources covered by this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("window")]
        public virtual MaintenanceWindow Window { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ValidateTrust</summary>
    public class ValidateTrustRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The domain trust to validate trust state for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trust")]
        public virtual Trust Trust { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for weekly operations.</summary>
    public class WeeklyCycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User can specify multiple windows in a week. Minimum of 1 window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual System.Collections.Generic.IList<Schedule> Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
