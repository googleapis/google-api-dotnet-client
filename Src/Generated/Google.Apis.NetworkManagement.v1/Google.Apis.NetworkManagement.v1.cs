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

namespace Google.Apis.NetworkManagement.v1
{
    /// <summary>The NetworkManagement Service.</summary>
    public class NetworkManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public NetworkManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public NetworkManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "networkmanagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://networkmanagement.googleapis.com/";
        #else
            "https://networkmanagement.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://networkmanagement.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Network Management API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Network Management API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for NetworkManagement requests.</summary>
    public abstract class NetworkManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new NetworkManagementBaseServiceRequest instance.</summary>
        protected NetworkManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes NetworkManagement parameter list.</summary>
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
                    ConnectivityTests = new ConnectivityTestsResource(service);
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the ConnectivityTests resource.</summary>
                public virtual ConnectivityTestsResource ConnectivityTests { get; }

                /// <summary>The "connectivityTests" collection of methods.</summary>
                public class ConnectivityTestsResource
                {
                    private const string Resource = "connectivityTests";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConnectivityTestsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new Connectivity Test. After you create a test, the reachability analysis is performed
                    /// as part of the long running operation, which completes when the analysis completes. If the
                    /// endpoint specifications in `ConnectivityTest` are invalid (for example, containing non-existent
                    /// resources in the network, or you don't have read permissions to the network configurations of
                    /// listed projects), then the reachability result returns a value of `UNKNOWN`. If the endpoint
                    /// specifications in `ConnectivityTest` are incomplete, the reachability result returns a value of
                    /// AMBIGUOUS. For more information, see the Connectivity Test documentation.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource of the Connectivity Test to create:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.NetworkManagement.v1.Data.ConnectivityTest body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new Connectivity Test. After you create a test, the reachability analysis is performed
                    /// as part of the long running operation, which completes when the analysis completes. If the
                    /// endpoint specifications in `ConnectivityTest` are invalid (for example, containing non-existent
                    /// resources in the network, or you don't have read permissions to the network configurations of
                    /// listed projects), then the reachability result returns a value of `UNKNOWN`. If the endpoint
                    /// specifications in `ConnectivityTest` are incomplete, the reachability result returns a value of
                    /// AMBIGUOUS. For more information, see the Connectivity Test documentation.
                    /// </summary>
                    public class CreateRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1.Data.ConnectivityTest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource of the Connectivity Test to create:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The logical name of the Connectivity Test in your project with the following
                        /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with
                        /// a letter. * Must be between 1-40 characters. * Must end with a number or a letter. * Must be
                        /// unique within the customer project
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("testId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string TestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1.Data.ConnectivityTest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/connectivityTests";

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
                            RequestParameters.Add("testId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "testId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a specific `ConnectivityTest`.</summary>
                    /// <param name="name">
                    /// Required. Connectivity Test resource name using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a specific `ConnectivityTest`.</summary>
                    public class DeleteRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Connectivity Test resource name using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the details of a specific Connectivity Test.</summary>
                    /// <param name="name">
                    /// Required. `ConnectivityTest` resource name using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the details of a specific Connectivity Test.</summary>
                    public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.ConnectivityTest>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. `ConnectivityTest` resource name using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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
                    public class GetIamPolicyRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Policy>
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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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

                    /// <summary>Lists all Connectivity Tests owned by a project.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource of the Connectivity Tests:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all Connectivity Tests owned by a project.</summary>
                    public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.ListConnectivityTestsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource of the Connectivity Tests:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Lists the `ConnectivityTests` that match the filter expression. A filter expression filters
                        /// the resources listed in the response. The expression must be of the form ` ` where
                        /// operators: `&amp;lt;`, `&amp;gt;`, `&amp;lt;=`, `&amp;gt;=`, `!=`, `=`, `:` are supported
                        /// (colon `:` represents a HAS operator which is roughly synonymous with equality). can refer
                        /// to a proto or JSON field, or a synthetic field. Field names can be camelCase or snake_case.
                        /// Examples: - Filter by name: name =
                        /// "projects/proj-1/locations/global/connectivityTests/test-1 - Filter by labels: - Resources
                        /// that have a key called `foo` labels.foo:* - Resources that have a key called `foo` whose
                        /// value is `bar` labels.foo = bar
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field to use to sort the list.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>Number of `ConnectivityTests` to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token from an earlier query, as returned in `next_page_token`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/connectivityTests";

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

                    /// <summary>
                    /// Updates the configuration of an existing `ConnectivityTest`. After you update a test, the
                    /// reachability analysis is performed as part of the long running operation, which completes when
                    /// the analysis completes. The Reachability state in the test resource is updated with the new
                    /// result. If the endpoint specifications in `ConnectivityTest` are invalid (for example, they
                    /// contain non-existent resources in the network, or the user does not have read permissions to the
                    /// network configurations of listed projects), then the reachability result returns a value of
                    /// UNKNOWN. If the endpoint specifications in `ConnectivityTest` are incomplete, the reachability
                    /// result returns a value of `AMBIGUOUS`. See the documentation in `ConnectivityTest` for for more
                    /// details.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Unique name of the resource using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.NetworkManagement.v1.Data.ConnectivityTest body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates the configuration of an existing `ConnectivityTest`. After you update a test, the
                    /// reachability analysis is performed as part of the long running operation, which completes when
                    /// the analysis completes. The Reachability state in the test resource is updated with the new
                    /// result. If the endpoint specifications in `ConnectivityTest` are invalid (for example, they
                    /// contain non-existent resources in the network, or the user does not have read permissions to the
                    /// network configurations of listed projects), then the reachability result returns a value of
                    /// UNKNOWN. If the endpoint specifications in `ConnectivityTest` are incomplete, the reachability
                    /// result returns a value of `AMBIGUOUS`. See the documentation in `ConnectivityTest` for for more
                    /// details.
                    /// </summary>
                    public class PatchRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1.Data.ConnectivityTest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Unique name of the resource using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1.Data.ConnectivityTest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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
                    /// Rerun an existing `ConnectivityTest`. After the user triggers the rerun, the reachability
                    /// analysis is performed as part of the long running operation, which completes when the analysis
                    /// completes. Even though the test configuration remains the same, the reachability result may
                    /// change due to underlying network configuration changes. If the endpoint specifications in
                    /// `ConnectivityTest` become invalid (for example, specified resources are deleted in the network,
                    /// or you lost read permissions to the network configurations of listed projects), then the
                    /// reachability result returns a value of `UNKNOWN`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Connectivity Test resource name using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                    /// </param>
                    public virtual RerunRequest Rerun(Google.Apis.NetworkManagement.v1.Data.RerunConnectivityTestRequest body, string name)
                    {
                        return new RerunRequest(service, body, name);
                    }

                    /// <summary>
                    /// Rerun an existing `ConnectivityTest`. After the user triggers the rerun, the reachability
                    /// analysis is performed as part of the long running operation, which completes when the analysis
                    /// completes. Even though the test configuration remains the same, the reachability result may
                    /// change due to underlying network configuration changes. If the endpoint specifications in
                    /// `ConnectivityTest` become invalid (for example, specified resources are deleted in the network,
                    /// or you lost read permissions to the network configurations of listed projects), then the
                    /// reachability result returns a value of `UNKNOWN`.
                    /// </summary>
                    public class RerunRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Rerun request.</summary>
                        public RerunRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1.Data.RerunConnectivityTestRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Connectivity Test resource name using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1.Data.RerunConnectivityTestRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rerun";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:rerun";

                        /// <summary>Initializes Rerun parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkManagement.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.NetworkManagement.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkManagement.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.NetworkManagement.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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
                    public virtual CancelRequest Cancel(Google.Apis.NetworkManagement.v1.Data.CancelOperationRequest body, string name)
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
                    public class CancelRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1.Data.CancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1.Data.CancelOperationRequest Body { get; set; }

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
                    public class DeleteRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Empty>
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
                    public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Operation>
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
                    public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.Location>
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
            public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.NetworkManagement.v1.Data
{
    /// <summary>Details of the final state "abort" and associated resource.</summary>
    public class AbortInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Causes that the analysis is aborted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>URI of the resource that caused the abort.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

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

    /// <summary>For display only. Metadata associated with a Cloud SQL instance.</summary>
    public class CloudSQLInstanceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>External IP address of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>Internal IP address of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>URI of a Cloud SQL instance network or empty string if the instance does not have one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Region in which the Cloud SQL instance is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Connectivity Test for a network reachability analysis.</summary>
    public class ConnectivityTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the test was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The user-supplied description of the Connectivity Test. Maximum of 512 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Destination specification of the Connectivity Test. You can use a combination of destination IP
        /// address, Compute Engine VM instance, or VPC network to uniquely identify the destination location. Even if
        /// the destination IP address is not unique, the source IP location is unique. Usually, the analysis can infer
        /// the destination endpoint from route information. If the destination you specify is a VM instance and the
        /// instance has multiple network interfaces, then you must also specify either a destination IP address or VPC
        /// network to identify the destination interface. A reachability analysis proceeds even if the destination
        /// location is ambiguous. However, the result can include endpoints that you don't intend to test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual Endpoint Destination { get; set; }

        /// <summary>Output only. The display name of a Connectivity Test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource labels to represent user-provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Unique name of the resource using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>IP Protocol of the test. When not provided, "TCP" is assumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// Output only. The reachability details of this test from the latest run. The details are updated when
        /// creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reachabilityDetails")]
        public virtual ReachabilityDetails ReachabilityDetails { get; set; }

        /// <summary>
        /// Other projects that may be relevant for reachability analysis. This is applicable to scenarios where a test
        /// can cross project boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedProjects")]
        public virtual System.Collections.Generic.IList<string> RelatedProjects { get; set; }

        /// <summary>
        /// Required. Source specification of the Connectivity Test. You can use a combination of source IP address,
        /// virtual machine (VM) instance, or Compute Engine network to uniquely identify the source location. Examples:
        /// If the source IP address is an internal IP address within a Google Cloud Virtual Private Cloud (VPC)
        /// network, then you must also specify the VPC network. Otherwise, specify the VM instance, which already
        /// contains its internal IP address and VPC network information. If the source of the test is within an
        /// on-premises network, then you must provide the destination VPC network. If the source endpoint is a Compute
        /// Engine VM instance with multiple network interfaces, the instance itself is not sufficient to identify the
        /// endpoint. So, you must also specify the source IP address or VPC network. A reachability analysis proceeds
        /// even if the source location is ambiguous. However, the test result may include endpoints that you don't
        /// intend to test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Endpoint Source { get; set; }

        /// <summary>Output only. The time the test's configuration was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the final state "deliver" and associated resource.</summary>
    public class DeliverInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of the resource that the packet is delivered to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Target type where the packet is delivered to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the final state "drop" and associated resource.</summary>
    public class DropInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cause that the packet is dropped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>URI of the resource that caused the drop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

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

    /// <summary>Source or destination of the Connectivity Test.</summary>
    public class Endpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A [Cloud SQL](https://cloud.google.com/sql) instance URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstance")]
        public virtual string CloudSqlInstance { get; set; }

        /// <summary>
        /// A cluster URI for [Google Kubernetes Engine
        /// master](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeMasterCluster")]
        public virtual string GkeMasterCluster { get; set; }

        /// <summary>A Compute Engine instance URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>
        /// The IP address of the endpoint, which can be an external or internal IP. An IPv6 address is only allowed
        /// when the test's destination is a [global load balancer VIP](/load-balancing/docs/load-balancing-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>A Compute Engine network URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Type of the network where the endpoint is located. Applicable only to source endpoint, as destination
        /// network type can be inferred from the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkType")]
        public virtual string NetworkType { get; set; }

        /// <summary>The IP protocol port of the endpoint. Only applicable when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Project ID where the endpoint is located. The Project ID can be derived from the URI if you provide a VM
        /// instance or network URI. The following are two cases where you must provide the project ID: 1. Only the IP
        /// address is specified, and the IP address is within a GCP project. 2. When you are using Shared VPC and the
        /// IP address that you provide is from the service project. In this case, the network that the IP address
        /// resides in is defined in the host project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For display only. The specification of the endpoints for the test. EndpointInfo is derived from source and
    /// destination Endpoint and validated by the backend data plane model.
    /// </summary>
    public class EndpointInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        /// <summary>URI of the network where this packet is sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationNetworkUri")]
        public virtual string DestinationNetworkUri { get; set; }

        /// <summary>Destination port. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Source IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>URI of the network where this packet originates from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceNetworkUri")]
        public virtual string SourceNetworkUri { get; set; }

        /// <summary>Source port. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

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
    /// For display only. Metadata associated with a VPC firewall rule, an implied VPC firewall rule, or a hierarchical
    /// firewall policy rule.
    /// </summary>
    public class FirewallInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Possible values: ALLOW, DENY</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Possible values: INGRESS, EGRESS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>
        /// The display name of the VPC firewall rule. This field is not applicable to hierarchical firewall policy
        /// rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The firewall rule's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewallRuleType")]
        public virtual string FirewallRuleType { get; set; }

        /// <summary>
        /// The URI of the VPC network that the firewall rule is associated with. This field is not applicable to
        /// hierarchical firewall policy rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>
        /// The hierarchical firewall policy that this rule is associated with. This field is not applicable to VPC
        /// firewall rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>The priority of the firewall rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>The target service accounts specified by the firewall rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetServiceAccounts")]
        public virtual System.Collections.Generic.IList<string> TargetServiceAccounts { get; set; }

        /// <summary>
        /// The target tags defined by the VPC firewall rule. This field is not applicable to hierarchical firewall
        /// policy rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetTags")]
        public virtual System.Collections.Generic.IList<string> TargetTags { get; set; }

        /// <summary>
        /// The URI of the VPC firewall rule. This field is not applicable to implied firewall rules or hierarchical
        /// firewall policy rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the final state "forward" and associated resource.</summary>
    public class ForwardInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of the resource that the packet is forwarded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Target type where this packet is forwarded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine forwarding rule.</summary>
    public class ForwardingRuleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Compute Engine forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Port range defined in the forwarding rule that matches the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedPortRange")]
        public virtual string MatchedPortRange { get; set; }

        /// <summary>Protocol defined in the forwarding rule that matches the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedProtocol")]
        public virtual string MatchedProtocol { get; set; }

        /// <summary>Network URI. Only valid for Internal Load Balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Target type of the forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>URI of a Compute Engine forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>VIP of the forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vip")]
        public virtual string Vip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Google Kubernetes Engine (GKE) cluster master.</summary>
    public class GKEMasterInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of a GKE cluster network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterNetworkUri")]
        public virtual string ClusterNetworkUri { get; set; }

        /// <summary>URI of a GKE cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUri")]
        public virtual string ClusterUri { get; set; }

        /// <summary>External IP address of a GKE cluster master.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>Internal IP address of a GKE cluster master.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine instance.</summary>
    public class InstanceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>External IP address of the network interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>Name of the network interface of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interface")]
        public virtual string Interface__ { get; set; }

        /// <summary>Internal IP address of the network interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>Network tags configured on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>URI of a Compute Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Service account authorized for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>URI of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListConnectivityTests` method.</summary>
    public class ListConnectivityTestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page token to fetch the next set of Connectivity Tests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Connectivity Tests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ConnectivityTest> Resources { get; set; }

        /// <summary>Locations that could not be reached (when querying all locations with `-`).</summary>
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

    /// <summary>For display only. Metadata associated with a specific load balancer backend.</summary>
    public class LoadBalancerBackend : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Compute Engine instance or network endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>A list of firewall rule URIs allowing probes from health check IP ranges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckAllowingFirewallRules")]
        public virtual System.Collections.Generic.IList<string> HealthCheckAllowingFirewallRules { get; set; }

        /// <summary>A list of firewall rule URIs blocking probes from health check IP ranges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckBlockingFirewallRules")]
        public virtual System.Collections.Generic.IList<string> HealthCheckBlockingFirewallRules { get; set; }

        /// <summary>State of the health check firewall configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckFirewallState")]
        public virtual string HealthCheckFirewallState { get; set; }

        /// <summary>URI of a Compute Engine instance or network endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a load balancer.</summary>
    public class LoadBalancerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of load balancer's backend configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendType")]
        public virtual string BackendType { get; set; }

        /// <summary>Backend configuration URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendUri")]
        public virtual string BackendUri { get; set; }

        /// <summary>Information for the loadbalancer backends.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backends")]
        public virtual System.Collections.Generic.IList<LoadBalancerBackend> Backends { get; set; }

        /// <summary>URI of the health check for the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckUri")]
        public virtual string HealthCheckUri { get; set; }

        /// <summary>Type of the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerType")]
        public virtual string LoadBalancerType { get; set; }

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

    /// <summary>For display only. Metadata associated with a Compute Engine network.</summary>
    public class NetworkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Compute Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The IP range that matches the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedIpRange")]
        public virtual string MatchedIpRange { get; set; }

        /// <summary>URI of a Compute Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

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

    /// <summary>Metadata describing an Operation</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Specifies if cancellation was requested for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>
        /// Target of the operation - for example projects/project-1/locations/global/connectivityTests/test-1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

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

    /// <summary>Results of the configuration analysis from the last run of the test.</summary>
    public class ReachabilityDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of a failure or a cancellation of reachability analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The overall result of the test's configuration analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>
        /// Result may contain a list of traces if a test has multiple possible paths in the network, such as when
        /// destination endpoint is a load balancer with multiple backends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traces")]
        public virtual System.Collections.Generic.IList<Trace> Traces { get; set; }

        /// <summary>The time of the configuration analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyTime")]
        public virtual object VerifyTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `RerunConnectivityTest` method.</summary>
    public class RerunConnectivityTestRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine route.</summary>
    public class RouteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination IP range of the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destIpRange")]
        public virtual string DestIpRange { get; set; }

        /// <summary>Name of a Compute Engine route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Instance tags of the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceTags")]
        public virtual System.Collections.Generic.IList<string> InstanceTags { get; set; }

        /// <summary>URI of a Compute Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Next hop of the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextHop")]
        public virtual string NextHop { get; set; }

        /// <summary>Type of next hop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextHopType")]
        public virtual string NextHopType { get; set; }

        /// <summary>Priority of the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>Type of route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeType")]
        public virtual string RouteType { get; set; }

        /// <summary>
        /// URI of a Compute Engine route. Dynamic route from cloud router does not have a URI. Advertised route from
        /// Google Cloud VPC to on-premises network also does not have a URI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

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
    /// A simulated forwarding path is composed of multiple steps. Each step has a well-defined state and an associated
    /// configuration.
    /// </summary>
    public class Step : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display information of the final state "abort" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abort")]
        public virtual AbortInfo Abort { get; set; }

        /// <summary>This is a step that leads to the final state Drop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("causesDrop")]
        public virtual System.Nullable<bool> CausesDrop { get; set; }

        /// <summary>Display information of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstance")]
        public virtual CloudSQLInstanceInfo CloudSqlInstance { get; set; }

        /// <summary>Display information of the final state "deliver" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliver")]
        public virtual DeliverInfo Deliver { get; set; }

        /// <summary>A description of the step. Usually this is a summary of the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display information of the final state "drop" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drop")]
        public virtual DropInfo Drop { get; set; }

        /// <summary>
        /// Display information of the source and destination under analysis. The endpoint information in an
        /// intermediate state may differ with the initial input, as it might be modified by state like NAT, or
        /// Connection Proxy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual EndpointInfo Endpoint { get; set; }

        /// <summary>Display information of a Compute Engine firewall rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewall")]
        public virtual FirewallInfo Firewall { get; set; }

        /// <summary>Display information of the final state "forward" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forward")]
        public virtual ForwardInfo Forward { get; set; }

        /// <summary>Display information of a Compute Engine forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRule")]
        public virtual ForwardingRuleInfo ForwardingRule { get; set; }

        /// <summary>Display information of a Google Kubernetes Engine cluster master.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeMaster")]
        public virtual GKEMasterInfo GkeMaster { get; set; }

        /// <summary>Display information of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual InstanceInfo Instance { get; set; }

        /// <summary>Display information of the load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancer")]
        public virtual LoadBalancerInfo LoadBalancer { get; set; }

        /// <summary>Display information of a Google Cloud network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual NetworkInfo Network { get; set; }

        /// <summary>Project ID that contains the configuration this step is validating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Display information of a Compute Engine route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("route")]
        public virtual RouteInfo Route { get; set; }

        /// <summary>Each step is in one of the pre-defined states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Display information of a Compute Engine VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnGateway")]
        public virtual VpnGatewayInfo VpnGateway { get; set; }

        /// <summary>Display information of a Compute Engine VPN tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnTunnel")]
        public virtual VpnTunnelInfo VpnTunnel { get; set; }

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
    /// Trace represents one simulated packet forwarding path. * Each trace contains multiple ordered steps. * Each step
    /// is in a particular state with associated configuration. * State is categorized as final or non-final states. *
    /// Each final state has a reason associated. * Each trace must end with a final state (the last step). ```
    /// |---------------------Trace----------------------| Step1(State) Step2(State) --- StepN(State(final)) ```
    /// </summary>
    public class Trace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Derived from the source and destination endpoints definition specified by user request, and validated by the
        /// data plane model. If there are multiple traces starting from different source locations, then the
        /// endpoint_info may be different between traces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointInfo")]
        public virtual EndpointInfo EndpointInfo { get; set; }

        /// <summary>
        /// A trace of a test contains multiple steps from the initial state to the final state (delivered, dropped,
        /// forwarded, or aborted). The steps are ordered by the processing sequence within the simulated network state
        /// machine. It is critical to preserve the order of the steps and avoid reordering or sorting them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<Step> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine VPN gateway.</summary>
    public class VpnGatewayInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>IP address of the VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>URI of a Compute Engine network where the VPN gateway is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Name of a Google Cloud region where this VPN gateway is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// A VPN tunnel that is associated with this VPN gateway. There may be multiple VPN tunnels configured on a VPN
        /// gateway, and only the one relevant to the test is displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnTunnelUri")]
        public virtual string VpnTunnelUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine VPN tunnel.</summary>
    public class VpnTunnelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a VPN tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URI of a Compute Engine network where the VPN tunnel is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Name of a Google Cloud region where this VPN tunnel is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a VPN gateway at remote end of the tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteGateway")]
        public virtual string RemoteGateway { get; set; }

        /// <summary>Remote VPN gateway's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteGatewayIp")]
        public virtual string RemoteGatewayIp { get; set; }

        /// <summary>Type of the routing policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingType")]
        public virtual string RoutingType { get; set; }

        /// <summary>URI of the VPN gateway at local end of the tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceGateway")]
        public virtual string SourceGateway { get; set; }

        /// <summary>Local VPN gateway's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceGatewayIp")]
        public virtual string SourceGatewayIp { get; set; }

        /// <summary>URI of a VPN tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
