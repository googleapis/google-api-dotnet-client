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

namespace Google.Apis.GKEHub.v1
{
    /// <summary>The GKEHub Service.</summary>
    public class GKEHubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GKEHubService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GKEHubService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://gkehub.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://gkehub.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gkehub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the GKE Hub API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the GKE Hub API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for GKEHub requests.</summary>
    public abstract class GKEHubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GKEHubBaseServiceRequest instance.</summary>
        protected GKEHubBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GKEHub parameter list.</summary>
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
                Fleets = new FleetsResource(service);
            }

            /// <summary>Gets the Fleets resource.</summary>
            public virtual FleetsResource Fleets { get; }

            /// <summary>The "fleets" collection of methods.</summary>
            public class FleetsResource
            {
                private const string Resource = "fleets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FleetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Returns all fleets within an organization or a project that the caller has access to.
                /// </summary>
                /// <param name="parent">
                /// Required. The organization or project to list for Fleets under, in the format
                /// `organizations/*/locations/*` or `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Returns all fleets within an organization or a project that the caller has access to.
                /// </summary>
                public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListFleetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The organization or project to list for Fleets under, in the format
                    /// `organizations/*/locations/*` or `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of fleets to return. The service may return fewer than this value.
                    /// If unspecified, at most 200 fleets will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListFleets` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListFleets` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/fleets";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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
                Features = new FeaturesResource(service);
                Fleets = new FleetsResource(service);
                Memberships = new MembershipsResource(service);
                Operations = new OperationsResource(service);
                Scopes = new ScopesResource(service);
            }

            /// <summary>Gets the Features resource.</summary>
            public virtual FeaturesResource Features { get; }

            /// <summary>The "features" collection of methods.</summary>
            public class FeaturesResource
            {
                private const string Resource = "features";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FeaturesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Adds a new Feature.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Feature will be created. Specified in the
                /// format `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.Feature body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Adds a new Feature.</summary>
                public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Feature body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Feature will be created. Specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The ID of the feature to create.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("featureId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FeatureId { get; set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Feature Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/features";

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
                        RequestParameters.Add("featureId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "featureId",
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

                /// <summary>Removes a Feature.</summary>
                /// <param name="name">
                /// Required. The Feature resource name in the format `projects/*/locations/*/features/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Removes a Feature.</summary>
                public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Feature resource name in the format `projects/*/locations/*/features/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, the delete will ignore any outstanding resources for this Feature (that is,
                    /// `FeatureState.has_resources` is set to true). These resources will NOT be cleaned up or modified
                    /// in any way.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/features/[^/]+$",
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

                /// <summary>Gets details of a single Feature.</summary>
                /// <param name="name">
                /// Required. The Feature resource name in the format `projects/*/locations/*/features/*`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Feature.</summary>
                public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Feature>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Feature resource name in the format `projects/*/locations/*/features/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, the response will return partial results when some regions are
                    /// unreachable and the unreachable field in Feature proto will be populated. If set to false, the
                    /// request will fail when some regions are unreachable.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/features/[^/]+$",
                        });
                        RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnPartialSuccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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
                public class GetIamPolicyRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/features/[^/]+$",
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

                /// <summary>Lists Features in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Features will be listed. Specified in the
                /// format `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Features in a given project and location.</summary>
                public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListFeaturesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Features will be listed. Specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Lists Features that match the filter expression, following the syntax outlined in
                    /// https://google.aip.dev/160. Examples: - Feature with the name "servicemesh" in project
                    /// "foo-proj": name = "projects/foo-proj/locations/global/features/servicemesh" - Features that
                    /// have a label called `foo`: labels.foo:* - Features that have a label called `foo` whose value is
                    /// `bar`: labels.foo = bar
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// One or more fields to compare and use to sort the output. See
                    /// https://google.aip.dev/132#ordering.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// When requesting a 'page' of resources, `page_size` specifies number of resources to return. If
                    /// unspecified or set to 0, all resources will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token returned by previous call to `ListFeatures` which specifies the position in the list from
                    /// where to continue listing the resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the response will return partial results when some regions are
                    /// unreachable and the unreachable field in Feature proto will be populated. If set to false, the
                    /// request will fail when some regions are unreachable.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/features";

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
                        RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnPartialSuccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates an existing Feature.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The Feature resource name in the format `projects/*/locations/*/features/*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.Feature body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing Feature.</summary>
                public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Feature body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Feature resource name in the format `projects/*/locations/*/features/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A request ID to identify requests. Specify a unique request ID so that if you must retry your
                    /// request, the server will know to ignore the request if it has already been completed. The server
                    /// will guarantee that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Mask of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Feature Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/features/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/features/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/features/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Fleets resource.</summary>
            public virtual FleetsResource Fleets { get; }

            /// <summary>The "fleets" collection of methods.</summary>
            public class FleetsResource
            {
                private const string Resource = "fleets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FleetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a fleet.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Fleet will be created. Specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.Fleet body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a fleet.</summary>
                public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Fleet body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Fleet will be created. Specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Fleet Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/fleets";

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
                    }
                }

                /// <summary>Removes a Fleet. There must be no memberships remaining in the Fleet.</summary>
                /// <param name="name">
                /// Required. The Fleet resource name in the format `projects/*/locations/*/fleets/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Removes a Fleet. There must be no memberships remaining in the Fleet.</summary>
                public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Fleet resource name in the format `projects/*/locations/*/fleets/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/fleets/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the details of a fleet.</summary>
                /// <param name="name">
                /// Required. The Fleet resource name in the format `projects/*/locations/*/fleets/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the details of a fleet.</summary>
                public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Fleet>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Fleet resource name in the format `projects/*/locations/*/fleets/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/fleets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns all fleets within an organization or a project that the caller has access to.
                /// </summary>
                /// <param name="parent">
                /// Required. The organization or project to list for Fleets under, in the format
                /// `organizations/*/locations/*` or `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Returns all fleets within an organization or a project that the caller has access to.
                /// </summary>
                public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListFleetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The organization or project to list for Fleets under, in the format
                    /// `organizations/*/locations/*` or `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of fleets to return. The service may return fewer than this value.
                    /// If unspecified, at most 200 fleets will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListFleets` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListFleets` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/fleets";

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
                    }
                }

                /// <summary>Updates a fleet.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The full, unique resource name of this fleet in the format of
                /// `projects/{project}/locations/{location}/fleets/{fleet}`. Each Google Cloud project can have at most
                /// one fleet resource, named "default".
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.Fleet body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a fleet.</summary>
                public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Fleet body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The full, unique resource name of this fleet in the format of
                    /// `projects/{project}/locations/{location}/fleets/{fleet}`. Each Google Cloud project can have at
                    /// most one fleet resource, named "default".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The fields to be updated;</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Fleet Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/fleets/[^/]+$",
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

            /// <summary>Gets the Memberships resource.</summary>
            public virtual MembershipsResource Memberships { get; }

            /// <summary>The "memberships" collection of methods.</summary>
            public class MembershipsResource
            {
                private const string Resource = "memberships";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MembershipsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Bindings = new BindingsResource(service);
                    Rbacrolebindings = new RbacrolebindingsResource(service);
                }

                /// <summary>Gets the Bindings resource.</summary>
                public virtual BindingsResource Bindings { get; }

                /// <summary>The "bindings" collection of methods.</summary>
                public class BindingsResource
                {
                    private const string Resource = "bindings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BindingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a MembershipBinding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the MembershipBinding will be created.
                    /// Specified in the format `projects/*/locations/*/memberships/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.MembershipBinding body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a MembershipBinding.</summary>
                    public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.MembershipBinding body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the MembershipBinding will be created.
                        /// Specified in the format `projects/*/locations/*/memberships/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The ID to use for the MembershipBinding.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("membershipBindingId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string MembershipBindingId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.MembershipBinding Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/bindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
                            });
                            RequestParameters.Add("membershipBindingId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "membershipBindingId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a MembershipBinding.</summary>
                    /// <param name="name">
                    /// Required. The MembershipBinding resource name in the format
                    /// `projects/*/locations/*/memberships/*/bindings/*`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a MembershipBinding.</summary>
                    public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The MembershipBinding resource name in the format
                        /// `projects/*/locations/*/memberships/*/bindings/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/bindings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the details of a MembershipBinding.</summary>
                    /// <param name="name">
                    /// Required. The MembershipBinding resource name in the format
                    /// `projects/*/locations/*/memberships/*/bindings/*`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the details of a MembershipBinding.</summary>
                    public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.MembershipBinding>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The MembershipBinding resource name in the format
                        /// `projects/*/locations/*/memberships/*/bindings/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/bindings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists MembershipBindings.</summary>
                    /// <param name="parent">
                    /// Required. The parent Membership for which the MembershipBindings will be listed. Specified in
                    /// the format `projects/*/locations/*/memberships/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists MembershipBindings.</summary>
                    public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListMembershipBindingsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent Membership for which the MembershipBindings will be listed. Specified
                        /// in the format `projects/*/locations/*/memberships/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Lists MembershipBindings that match the filter expression, following the syntax
                        /// outlined in https://google.aip.dev/160.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources
                        /// to return. If unspecified or set to 0, all resources will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Token returned by previous call to `ListMembershipBindings` which specifies the
                        /// position in the list from where to continue listing the resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/bindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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

                    /// <summary>Updates a MembershipBinding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The resource name for the membershipbinding itself
                    /// `projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.MembershipBinding body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a MembershipBinding.</summary>
                    public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.MembershipBinding body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name for the membershipbinding itself
                        /// `projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.MembershipBinding Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/bindings/[^/]+$",
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

                /// <summary>Gets the Rbacrolebindings resource.</summary>
                public virtual RbacrolebindingsResource Rbacrolebindings { get; }

                /// <summary>The "rbacrolebindings" collection of methods.</summary>
                public class RbacrolebindingsResource
                {
                    private const string Resource = "rbacrolebindings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RbacrolebindingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a Membership RBACRoleBinding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the RBACRoleBinding will be created. Specified
                    /// in the format `projects/*/locations/*/memberships/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a Membership RBACRoleBinding.</summary>
                    public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the RBACRoleBinding will be created.
                        /// Specified in the format `projects/*/locations/*/memberships/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id` must be a valid RFC
                        /// 1123 compliant DNS label: 1. At most 63 characters in length 2. It must consist of lower
                        /// case alphanumeric characters or `-` 3. It must start and end with an alphanumeric character
                        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`, with a maximum length
                        /// of 63 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("rbacrolebindingId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RbacrolebindingId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.RBACRoleBinding Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/rbacrolebindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
                            });
                            RequestParameters.Add("rbacrolebindingId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "rbacrolebindingId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a Membership RBACRoleBinding.</summary>
                    /// <param name="name">
                    /// Required. The RBACRoleBinding resource name in the format
                    /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a Membership RBACRoleBinding.</summary>
                    public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The RBACRoleBinding resource name in the format
                        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/rbacrolebindings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Generates a YAML of the RBAC policies for the specified RoleBinding and its associated
                    /// impersonation resources.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the RBACRoleBinding will be created. Specified
                    /// in the format `projects/*/locations/*/memberships/*`.
                    /// </param>
                    public virtual GenerateMembershipRBACRoleBindingYAMLRequest GenerateMembershipRBACRoleBindingYAML(Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string parent)
                    {
                        return new GenerateMembershipRBACRoleBindingYAMLRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Generates a YAML of the RBAC policies for the specified RoleBinding and its associated
                    /// impersonation resources.
                    /// </summary>
                    public class GenerateMembershipRBACRoleBindingYAMLRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.GenerateMembershipRBACRoleBindingYAMLResponse>
                    {
                        /// <summary>Constructs a new GenerateMembershipRBACRoleBindingYAML request.</summary>
                        public GenerateMembershipRBACRoleBindingYAMLRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the RBACRoleBinding will be created.
                        /// Specified in the format `projects/*/locations/*/memberships/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id` must be a valid RFC
                        /// 1123 compliant DNS label: 1. At most 63 characters in length 2. It must consist of lower
                        /// case alphanumeric characters or `-` 3. It must start and end with an alphanumeric character
                        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`, with a maximum length
                        /// of 63 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("rbacrolebindingId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RbacrolebindingId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.RBACRoleBinding Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "generateMembershipRBACRoleBindingYAML";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/rbacrolebindings:generateMembershipRBACRoleBindingYAML";

                        /// <summary>Initializes GenerateMembershipRBACRoleBindingYAML parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
                            });
                            RequestParameters.Add("rbacrolebindingId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "rbacrolebindingId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Returns the details of a Membership RBACRoleBinding.</summary>
                    /// <param name="name">
                    /// Required. The RBACRoleBinding resource name in the format
                    /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the details of a Membership RBACRoleBinding.</summary>
                    public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.RBACRoleBinding>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The RBACRoleBinding resource name in the format
                        /// `projects/*/locations/*/memberships/*/rbacrolebindings/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/rbacrolebindings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all Membership RBACRoleBindings.</summary>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the Features will be listed. Specified in the
                    /// format `projects/*/locations/*/memberships/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all Membership RBACRoleBindings.</summary>
                    public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListMembershipRBACRoleBindingsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the Features will be listed. Specified in
                        /// the format `projects/*/locations/*/memberships/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources
                        /// to return. If unspecified or set to 0, all resources will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Token returned by previous call to `ListMembershipRBACRoleBindings` which
                        /// specifies the position in the list from where to continue listing the resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/rbacrolebindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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

                    /// <summary>Updates a Membership RBACRoleBinding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The resource name for the rbacrolebinding
                    /// `projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}` or
                    /// `projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a Membership RBACRoleBinding.</summary>
                    public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name for the rbacrolebinding
                        /// `projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}`
                        /// or
                        /// `projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.RBACRoleBinding Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+/rbacrolebindings/[^/]+$",
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
                /// Creates a new Membership. **This is currently only supported for GKE clusters on Google Cloud**. To
                /// register other clusters, follow the instructions at
                /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Memberships will be created. Specified in the
                /// format `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.Membership body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new Membership. **This is currently only supported for GKE clusters on Google Cloud**. To
                /// register other clusters, follow the instructions at
                /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
                /// </summary>
                public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Membership body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Memberships will be created. Specified in
                    /// the format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Client chosen ID for the membership. `membership_id` must be a valid RFC 1123
                    /// compliant DNS label: 1. At most 63 characters in length 2. It must consist of lower case
                    /// alphanumeric characters or `-` 3. It must start and end with an alphanumeric character Which can
                    /// be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`, with a maximum length of 63
                    /// characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("membershipId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string MembershipId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Membership Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/memberships";

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
                        RequestParameters.Add("membershipId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "membershipId",
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
                /// Removes a Membership. **This is currently only supported for GKE clusters on Google Cloud**. To
                /// unregister other clusters, follow the instructions at
                /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
                /// </summary>
                /// <param name="name">
                /// Required. The Membership resource name in the format `projects/*/locations/*/memberships/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Removes a Membership. **This is currently only supported for GKE clusters on Google Cloud**. To
                /// unregister other clusters, follow the instructions at
                /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
                /// </summary>
                public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Membership resource name in the format `projects/*/locations/*/memberships/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, any subresource from this Membership will also be deleted. Otherwise,
                    /// the request will only work if the Membership has no subresource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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
                /// Generates the manifest for deployment of the GKE connect agent. **This method is used internally by
                /// Google-provided libraries.** Most clients should not need to call this method directly.
                /// </summary>
                /// <param name="name">
                /// Required. The Membership resource name the Agent will associate with, in the format
                /// `projects/*/locations/*/memberships/*`.
                /// </param>
                public virtual GenerateConnectManifestRequest GenerateConnectManifest(string name)
                {
                    return new GenerateConnectManifestRequest(this.service, name);
                }

                /// <summary>
                /// Generates the manifest for deployment of the GKE connect agent. **This method is used internally by
                /// Google-provided libraries.** Most clients should not need to call this method directly.
                /// </summary>
                public class GenerateConnectManifestRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.GenerateConnectManifestResponse>
                {
                    /// <summary>Constructs a new GenerateConnectManifest request.</summary>
                    public GenerateConnectManifestRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Membership resource name the Agent will associate with, in the format
                    /// `projects/*/locations/*/memberships/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The image pull secret content for the registry, if not public.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("imagePullSecretContent", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ImagePullSecretContent { get; set; }

                    /// <summary>
                    /// Optional. If true, generate the resources for upgrade only. Some resources generated only for
                    /// installation (e.g. secrets) will be excluded.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("isUpgrade", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IsUpgrade { get; set; }

                    /// <summary>
                    /// Optional. Namespace for GKE Connect agent resources. Defaults to `gke-connect`. The Connect
                    /// Agent is authorized automatically when run in the default namespace. Otherwise, explicit
                    /// authorization must be granted with an additional IAM binding.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("namespace", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Namespace { get; set; }

                    /// <summary>
                    /// Optional. URI of a proxy if connectivity from the agent to gkeconnect.googleapis.com requires
                    /// the use of a proxy. Format must be in the form `http(s)://{proxy_address}`, depending on the
                    /// HTTP/HTTPS protocol supported by the proxy. This will direct the connect agent's outbound
                    /// traffic through a HTTP(S) proxy.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("proxy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Proxy { get; set; }

                    /// <summary>
                    /// Optional. The registry to fetch the connect agent image from. Defaults to gcr.io/gkeconnect.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registry", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Registry { get; set; }

                    /// <summary>
                    /// Optional. The Connect agent version to use. Defaults to the most current version.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Version { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateConnectManifest";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:generateConnectManifest";

                    /// <summary>Initializes GenerateConnectManifest parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
                        });
                        RequestParameters.Add("imagePullSecretContent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "imagePullSecretContent",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("isUpgrade", new Google.Apis.Discovery.Parameter
                        {
                            Name = "isUpgrade",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("namespace", new Google.Apis.Discovery.Parameter
                        {
                            Name = "namespace",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("proxy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "proxy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("registry", new Google.Apis.Discovery.Parameter
                        {
                            Name = "registry",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the details of a Membership.</summary>
                /// <param name="name">
                /// Required. The Membership resource name in the format `projects/*/locations/*/memberships/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a Membership.</summary>
                public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Membership>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Membership resource name in the format `projects/*/locations/*/memberships/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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
                public class GetIamPolicyRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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

                /// <summary>Lists Memberships in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Memberships will be listed. Specified in the
                /// format `projects/*/locations/*`. `projects/*/locations/-` list memberships in all the regions.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Memberships in a given project and location.</summary>
                public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListMembershipsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Memberships will be listed. Specified in
                    /// the format `projects/*/locations/*`. `projects/*/locations/-` list memberships in all the
                    /// regions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Lists Memberships that match the filter expression, following the syntax outlined in
                    /// https://google.aip.dev/160. Examples: - Name is `bar` in project `foo-proj` and location
                    /// `global`: name = "projects/foo-proj/locations/global/membership/bar" - Memberships that have a
                    /// label called `foo`: labels.foo:* - Memberships that have a label called `foo` whose value is
                    /// `bar`: labels.foo = bar - Memberships in the CREATING state: state = CREATING
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. One or more fields to compare and use to sort the output. See
                    /// https://google.aip.dev/132#ordering.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources to
                    /// return. If unspecified or set to 0, all resources will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Token returned by previous call to `ListMemberships` which specifies the position in
                    /// the list from where to continue listing the resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/memberships";

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

                /// <summary>Updates an existing Membership.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The Membership resource name in the format `projects/*/locations/*/memberships/*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.Membership body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing Membership.</summary>
                public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Membership body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Membership resource name in the format `projects/*/locations/*/memberships/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes after the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. Mask of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Membership Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/memberships/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.GKEHub.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Empty>
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
                public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
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
                public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the Scopes resource.</summary>
            public virtual ScopesResource Scopes { get; }

            /// <summary>The "scopes" collection of methods.</summary>
            public class ScopesResource
            {
                private const string Resource = "scopes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ScopesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Namespaces = new NamespacesResource(service);
                    Rbacrolebindings = new RbacrolebindingsResource(service);
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
                    }

                    /// <summary>Creates a fleet namespace.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the Namespace will be created. Specified in
                    /// the format `projects/*/locations/*/scopes/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.Namespace body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a fleet namespace.</summary>
                    public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Namespace body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the Namespace will be created. Specified
                        /// in the format `projects/*/locations/*/scopes/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Client chosen ID for the Namespace. `namespace_id` must be a valid RFC 1123
                        /// compliant DNS label: 1. At most 63 characters in length 2. It must consist of lower case
                        /// alphanumeric characters or `-` 3. It must start and end with an alphanumeric character Which
                        /// can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`, with a maximum length of 63
                        /// characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("scopeNamespaceId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ScopeNamespaceId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.Namespace Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
                            });
                            RequestParameters.Add("scopeNamespaceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "scopeNamespaceId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a fleet namespace.</summary>
                    /// <param name="name">
                    /// Required. The Namespace resource name in the format
                    /// `projects/*/locations/*/scopes/*/namespaces/*`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a fleet namespace.</summary>
                    public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Namespace resource name in the format
                        /// `projects/*/locations/*/scopes/*/namespaces/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+/namespaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the details of a fleet namespace.</summary>
                    /// <param name="name">
                    /// Required. The Namespace resource name in the format
                    /// `projects/*/locations/*/scopes/*/namespaces/*`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the details of a fleet namespace.</summary>
                    public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Namespace>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Namespace resource name in the format
                        /// `projects/*/locations/*/scopes/*/namespaces/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+/namespaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists fleet namespaces.</summary>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the Features will be listed. Specified in the
                    /// format `projects/*/locations/*/scopes/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists fleet namespaces.</summary>
                    public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListScopeNamespacesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the Features will be listed. Specified in
                        /// the format `projects/*/locations/*/scopes/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources
                        /// to return. If unspecified or set to 0, all resources will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Token returned by previous call to `ListFeatures` which specifies the position in
                        /// the list from where to continue listing the resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
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

                    /// <summary>Updates a fleet namespace.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The resource name for the namespace
                    /// `projects/{project}/locations/{location}/namespaces/{namespace}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.Namespace body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a fleet namespace.</summary>
                    public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Namespace body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name for the namespace
                        /// `projects/{project}/locations/{location}/namespaces/{namespace}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.Namespace Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+/namespaces/[^/]+$",
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

                /// <summary>Gets the Rbacrolebindings resource.</summary>
                public virtual RbacrolebindingsResource Rbacrolebindings { get; }

                /// <summary>The "rbacrolebindings" collection of methods.</summary>
                public class RbacrolebindingsResource
                {
                    private const string Resource = "rbacrolebindings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RbacrolebindingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a Scope RBACRoleBinding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the RBACRoleBinding will be created. Specified
                    /// in the format `projects/*/locations/*/scopes/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a Scope RBACRoleBinding.</summary>
                    public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the RBACRoleBinding will be created.
                        /// Specified in the format `projects/*/locations/*/scopes/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Client chosen ID for the RBACRoleBinding. `rbacrolebinding_id` must be a valid RFC
                        /// 1123 compliant DNS label: 1. At most 63 characters in length 2. It must consist of lower
                        /// case alphanumeric characters or `-` 3. It must start and end with an alphanumeric character
                        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`, with a maximum length
                        /// of 63 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("rbacrolebindingId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RbacrolebindingId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.RBACRoleBinding Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/rbacrolebindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
                            });
                            RequestParameters.Add("rbacrolebindingId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "rbacrolebindingId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a Scope RBACRoleBinding.</summary>
                    /// <param name="name">
                    /// Required. The RBACRoleBinding resource name in the format
                    /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a Scope RBACRoleBinding.</summary>
                    public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The RBACRoleBinding resource name in the format
                        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+/rbacrolebindings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the details of a Scope RBACRoleBinding.</summary>
                    /// <param name="name">
                    /// Required. The RBACRoleBinding resource name in the format
                    /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the details of a Scope RBACRoleBinding.</summary>
                    public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.RBACRoleBinding>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The RBACRoleBinding resource name in the format
                        /// `projects/*/locations/*/scopes/*/rbacrolebindings/*`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+/rbacrolebindings/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all Scope RBACRoleBindings.</summary>
                    /// <param name="parent">
                    /// Required. The parent (project and location) where the Features will be listed. Specified in the
                    /// format `projects/*/locations/*/scopes/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all Scope RBACRoleBindings.</summary>
                    public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListScopeRBACRoleBindingsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent (project and location) where the Features will be listed. Specified in
                        /// the format `projects/*/locations/*/scopes/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources
                        /// to return. If unspecified or set to 0, all resources will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Token returned by previous call to `ListScopeRBACRoleBindings` which specifies the
                        /// position in the list from where to continue listing the resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/rbacrolebindings";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
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

                    /// <summary>Updates a Scope RBACRoleBinding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The resource name for the rbacrolebinding
                    /// `projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}` or
                    /// `projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a Scope RBACRoleBinding.</summary>
                    public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.RBACRoleBinding body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name for the rbacrolebinding
                        /// `projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}`
                        /// or
                        /// `projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEHub.v1.Data.RBACRoleBinding Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+/rbacrolebindings/[^/]+$",
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

                /// <summary>Creates a Scope.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Scope will be created. Specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEHub.v1.Data.Scope body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a Scope.</summary>
                public class CreateRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Scope body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Scope will be created. Specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Client chosen ID for the Scope. `scope_id` must be a ????</summary>
                    [Google.Apis.Util.RequestParameterAttribute("scopeId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ScopeId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Scope Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/scopes";

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
                        RequestParameters.Add("scopeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scopeId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a Scope.</summary>
                /// <param name="name">
                /// Required. The Scope resource name in the format `projects/*/locations/*/scopes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a Scope.</summary>
                public class DeleteRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Scope resource name in the format `projects/*/locations/*/scopes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the details of a Scope.</summary>
                /// <param name="name">
                /// Required. The Scope resource name in the format `projects/*/locations/*/scopes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the details of a Scope.</summary>
                public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Scope>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Scope resource name in the format `projects/*/locations/*/scopes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
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
                public class GetIamPolicyRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
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

                /// <summary>Lists Scopes.</summary>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Scope will be listed. Specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Scopes.</summary>
                public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListScopesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Scope will be listed. Specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources to
                    /// return. If unspecified or set to 0, all resources will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Token returned by previous call to `ListScopes` which specifies the position in the
                    /// list from where to continue listing the resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/scopes";

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
                    }
                }

                /// <summary>
                /// Lists Memberships bound to a Scope. The response includes relevant Memberships from all regions.
                /// </summary>
                /// <param name="scopeName">
                /// Required. Name of the Scope, in the format `projects/*/locations/global/scopes/*`, to which the
                /// Memberships are bound.
                /// </param>
                public virtual ListMembershipsRequest ListMemberships(string scopeName)
                {
                    return new ListMembershipsRequest(this.service, scopeName);
                }

                /// <summary>
                /// Lists Memberships bound to a Scope. The response includes relevant Memberships from all regions.
                /// </summary>
                public class ListMembershipsRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListBoundMembershipsResponse>
                {
                    /// <summary>Constructs a new ListMemberships request.</summary>
                    public ListMembershipsRequest(Google.Apis.Services.IClientService service, string scopeName) : base(service)
                    {
                        ScopeName = scopeName;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the Scope, in the format `projects/*/locations/global/scopes/*`, to which the
                    /// Memberships are bound.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("scopeName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ScopeName { get; private set; }

                    /// <summary>
                    /// Optional. Lists Memberships that match the filter expression, following the syntax outlined in
                    /// https://google.aip.dev/160. Currently, filtering can be done only based on Memberships's `name`,
                    /// `labels`, `create_time`, `update_time`, and `unique_id`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources to
                    /// return. If unspecified or set to 0, all resources will be returned. Pagination is currently not
                    /// supported; therefore, setting this field does not have any impact for now.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Token returned by previous call to `ListBoundMemberships` which specifies the position
                    /// in the list from where to continue listing the resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listMemberships";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+scopeName}:listMemberships";

                    /// <summary>Initializes ListMemberships parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("scopeName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scopeName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
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

                /// <summary>Lists permitted Scopes.</summary>
                /// <param name="parent">
                /// Required. The parent (project and location) where the Scope will be listed. Specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListPermittedRequest ListPermitted(string parent)
                {
                    return new ListPermittedRequest(this.service, parent);
                }

                /// <summary>Lists permitted Scopes.</summary>
                public class ListPermittedRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListPermittedScopesResponse>
                {
                    /// <summary>Constructs a new ListPermitted request.</summary>
                    public ListPermittedRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent (project and location) where the Scope will be listed. Specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. When requesting a 'page' of resources, `page_size` specifies number of resources to
                    /// return. If unspecified or set to 0, all resources will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Token returned by previous call to `ListPermittedScopes` which specifies the position
                    /// in the list from where to continue listing the resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listPermitted";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/scopes:listPermitted";

                    /// <summary>Initializes ListPermitted parameter list.</summary>
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
                    }
                }

                /// <summary>Updates a scopes.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name for the scope `projects/{project}/locations/{location}/scopes/{scope}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GKEHub.v1.Data.Scope body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a scopes.</summary>
                public class PatchRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.Scope body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name for the scope `projects/{project}/locations/{location}/scopes/{scope}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEHub.v1.Data.Scope Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.GKEHub.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.GKEHub.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/scopes/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.Location>
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
            public class ListRequest : GKEHubBaseServiceRequest<Google.Apis.GKEHub.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.GKEHub.v1.Data
{
    /// <summary>Spec for App Dev Experience Feature.</summary>
    public class AppDevExperienceFeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State for App Dev Exp Feature.</summary>
    public class AppDevExperienceFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of subcomponent that detects configured Service Mesh resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkingInstallSucceeded")]
        public virtual Status NetworkingInstallSucceeded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ApplianceCluster contains information specific to GDC Edge Appliance Clusters.</summary>
    public class ApplianceCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Self-link of the Google Cloud resource for the Appliance Cluster. For example:
        /// //transferappliance.googleapis.com/projects/my-project/locations/us-west1-a/appliances/my-appliance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLink")]
        public virtual string ResourceLink { get; set; }

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

    /// <summary>
    /// Authority encodes how Google will recognize identities from this Membership. See the workload identity
    /// documentation for more details: https://cloud.google.com/kubernetes-engine/docs/how-to/workload-identity
    /// </summary>
    public class Authority : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. An identity provider that reflects the `issuer` in the workload identity pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityProvider")]
        public virtual string IdentityProvider { get; set; }

        /// <summary>
        /// Optional. A JSON Web Token (JWT) issuer URI. `issuer` must start with `https://` and be a valid URL with
        /// length &amp;lt;2000 characters, it must use `location` rather than `zone` for GKE clusters. If set, then
        /// Google will allow valid OIDC tokens from this issuer to authenticate within the workload_identity_pool. OIDC
        /// discovery will be performed on this URI to validate tokens from the issuer. Clearing `issuer` disables
        /// Workload Identity. `issuer` cannot be directly modified; it must be cleared (and Workload Identity disabled)
        /// before using a new issuer (and re-enabling Workload Identity).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>
        /// Optional. OIDC verification keys for this Membership in JWKS format (RFC 7517). When this field is set, OIDC
        /// discovery will NOT be performed on `issuer`, and instead OIDC tokens will be validated using this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcJwks")]
        public virtual string OidcJwks { get; set; }

        /// <summary>
        /// Optional. Output only. The identity provider for the scope-tenancy workload identity pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeTenancyIdentityProvider")]
        public virtual string ScopeTenancyIdentityProvider { get; set; }

        /// <summary>
        /// Optional. Output only. The name of the scope-tenancy workload identity pool. This pool is set in the
        /// fleet-level feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeTenancyWorkloadIdentityPool")]
        public virtual string ScopeTenancyWorkloadIdentityPool { get; set; }

        /// <summary>
        /// Output only. The name of the workload identity pool in which `issuer` will be recognized. There is a single
        /// Workload Identity Pool per Hub that is shared between all Memberships that belong to that Hub. For a Hub
        /// hosted in {PROJECT_ID}, the workload pool format is `{PROJECT_ID}.hub.id.goog`, although this is subject to
        /// change in newer versions of this API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadIdentityPool")]
        public virtual string WorkloadIdentityPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BinaryAuthorizationConfig defines the fleet level configuration of binary authorization feature.
    /// </summary>
    public class BinaryAuthorizationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Mode of operation for binauthz policy evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMode")]
        public virtual string EvaluationMode { get; set; }

        /// <summary>Optional. Binauthz policies that apply to this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyBindings")]
        public virtual System.Collections.Generic.IList<PolicyBinding> PolicyBindings { get; set; }

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

    /// <summary>**ClusterUpgrade**: The configuration for the fleet-level ClusterUpgrade feature.</summary>
    public class ClusterUpgradeFleetSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow users to override some properties of each GKE upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeUpgradeOverrides")]
        public virtual System.Collections.Generic.IList<ClusterUpgradeGKEUpgradeOverride> GkeUpgradeOverrides { get; set; }

        /// <summary>Required. Post conditions to evaluate to mark an upgrade COMPLETE. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postConditions")]
        public virtual ClusterUpgradePostConditions PostConditions { get; set; }

        /// <summary>
        /// This fleet consumes upgrades that have COMPLETE status code in the upstream fleets. See UpgradeStatus.Code
        /// for code definitions. The fleet name should be either fleet project number or id. This is defined as
        /// repeated for future proof reasons. Initial implementation will enforce at most one upstream fleet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upstreamFleets")]
        public virtual System.Collections.Generic.IList<string> UpstreamFleets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**ClusterUpgrade**: The state for the fleet-level ClusterUpgrade feature.</summary>
    public class ClusterUpgradeFleetState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This fleets whose upstream_fleets contain the current fleet. The fleet name should be either fleet project
        /// number or id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downstreamFleets")]
        public virtual System.Collections.Generic.IList<string> DownstreamFleets { get; set; }

        /// <summary>Feature state for GKE clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeState")]
        public virtual ClusterUpgradeGKEUpgradeFeatureState GkeState { get; set; }

        /// <summary>
        /// A list of memberships ignored by the feature. For example, manually upgraded clusters can be ignored if they
        /// are newer than the default versions of its release channel. The membership resource is in the format:
        /// `projects/{p}/locations/{l}/membership/{m}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignored")]
        public virtual System.Collections.Generic.IDictionary<string, ClusterUpgradeIgnoredMembership> Ignored { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GKEUpgrade represents a GKE provided upgrade, e.g., control plane upgrade.</summary>
    public class ClusterUpgradeGKEUpgrade : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the upgrade, e.g., "k8s_control_plane". It should be a valid upgrade name. It must not exceet 99
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Version of the upgrade, e.g., "1.22.1-gke.100". It should be a valid version. It must not exceet 99
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GKEUpgradeFeatureCondition describes the condition of the feature for GKE clusters at a certain point of time.
    /// </summary>
    public class ClusterUpgradeGKEUpgradeFeatureCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reason why the feature is in this status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Type of the condition, for example, "ready".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Last timestamp the condition was updated.</summary>
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

    /// <summary>GKEUpgradeFeatureState contains feature states for GKE clusters in the scope.</summary>
    public class ClusterUpgradeGKEUpgradeFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current conditions of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<ClusterUpgradeGKEUpgradeFeatureCondition> Conditions { get; set; }

        /// <summary>Upgrade state. It will eventually replace `state`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeState")]
        public virtual System.Collections.Generic.IList<ClusterUpgradeGKEUpgradeState> UpgradeState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Properties of a GKE upgrade that can be overridden by the user. For example, a user can skip soaking by
    /// overriding the soaking to 0.
    /// </summary>
    public class ClusterUpgradeGKEUpgradeOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Post conditions to override for the specified upgrade (name + version). Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postConditions")]
        public virtual ClusterUpgradePostConditions PostConditions { get; set; }

        /// <summary>Required. Which upgrade to override. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrade")]
        public virtual ClusterUpgradeGKEUpgrade Upgrade { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GKEUpgradeState is a GKEUpgrade and its state at the scope and fleet level.</summary>
    public class ClusterUpgradeGKEUpgradeState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of GKE clusters in each status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Stats { get; set; }

        /// <summary>Status of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ClusterUpgradeUpgradeStatus Status { get; set; }

        /// <summary>Which upgrade to track the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrade")]
        public virtual ClusterUpgradeGKEUpgrade Upgrade { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// IgnoredMembership represents a membership ignored by the feature. A membership can be ignored because it was
    /// manually upgraded to a newer version than RC default.
    /// </summary>
    public class ClusterUpgradeIgnoredMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _ignoredTimeRaw;

        private object _ignoredTime;

        /// <summary>Time when the membership was first set to ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoredTime")]
        public virtual string IgnoredTimeRaw
        {
            get => _ignoredTimeRaw;
            set
            {
                _ignoredTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _ignoredTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="IgnoredTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IgnoredTimeDateTimeOffset instead.")]
        public virtual object IgnoredTime
        {
            get => _ignoredTime;
            set
            {
                _ignoredTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _ignoredTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="IgnoredTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? IgnoredTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IgnoredTimeRaw);
            set => IgnoredTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Reason why the membership is ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ScopeGKEUpgradeState is a GKEUpgrade and its state per-membership.</summary>
    public class ClusterUpgradeMembershipGKEUpgradeState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ClusterUpgradeUpgradeStatus Status { get; set; }

        /// <summary>Which upgrade to track the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrade")]
        public virtual ClusterUpgradeGKEUpgrade Upgrade { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per-membership state for this feature.</summary>
    public class ClusterUpgradeMembershipState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether this membership is ignored by the feature. For example, manually upgraded clusters can be ignored if
        /// they are newer than the default versions of its release channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignored")]
        public virtual ClusterUpgradeIgnoredMembership Ignored { get; set; }

        /// <summary>Actual upgrade state against desired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrades")]
        public virtual System.Collections.Generic.IList<ClusterUpgradeMembershipGKEUpgradeState> Upgrades { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Post conditional checks after an upgrade has been applied on all eligible clusters.</summary>
    public class ClusterUpgradePostConditions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Amount of time to "soak" after a rollout has been finished before marking it COMPLETE. Cannot
        /// exceed 30 days. Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("soaking")]
        public virtual object Soaking { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UpgradeStatus provides status information for each upgrade.</summary>
    public class ClusterUpgradeUpgradeStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status code of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Reason for this status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Last timestamp the status was updated.</summary>
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

    /// <summary>CommonFeatureSpec contains Fleet-wide configuration information</summary>
    public class CommonFeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Appdevexperience specific spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appdevexperience")]
        public virtual AppDevExperienceFeatureSpec Appdevexperience { get; set; }

        /// <summary>ClusterUpgrade (fleet-based) feature spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterupgrade")]
        public virtual ClusterUpgradeFleetSpec Clusterupgrade { get; set; }

        /// <summary>DataplaneV2 feature spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplanev2")]
        public virtual DataplaneV2FeatureSpec Dataplanev2 { get; set; }

        /// <summary>FleetObservability feature spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetobservability")]
        public virtual FleetObservabilityFeatureSpec Fleetobservability { get; set; }

        /// <summary>Multicluster Ingress-specific spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiclusteringress")]
        public virtual MultiClusterIngressFeatureSpec Multiclusteringress { get; set; }

        /// <summary>RBAC Role Binding Actuation feature spec</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacrolebindingactuation")]
        public virtual RBACRoleBindingActuationFeatureSpec Rbacrolebindingactuation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CommonFeatureState contains Fleet-wide Feature status information.</summary>
    public class CommonFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Appdevexperience specific state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appdevexperience")]
        public virtual AppDevExperienceFeatureState Appdevexperience { get; set; }

        /// <summary>ClusterUpgrade fleet-level state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterupgrade")]
        public virtual ClusterUpgradeFleetState Clusterupgrade { get; set; }

        /// <summary>FleetObservability feature state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetobservability")]
        public virtual FleetObservabilityFeatureState Fleetobservability { get; set; }

        /// <summary>RBAC Role Binding Actuation feature state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacrolebindingactuation")]
        public virtual RBACRoleBindingActuationFeatureState Rbacrolebindingactuation { get; set; }

        /// <summary>Output only. The "running state" of the Feature in this Fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual FeatureState State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CommonFleetDefaultMemberConfigSpec contains default configuration information for memberships of a fleet
    /// </summary>
    public class CommonFleetDefaultMemberConfigSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Config Management-specific spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configmanagement")]
        public virtual ConfigManagementMembershipSpec Configmanagement { get; set; }

        /// <summary>Identity Service-specific spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityservice")]
        public virtual IdentityServiceMembershipSpec Identityservice { get; set; }

        /// <summary>Anthos Service Mesh-specific spec</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mesh")]
        public virtual ServiceMeshMembershipSpec Mesh { get; set; }

        /// <summary>Policy Controller spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policycontroller")]
        public virtual PolicyControllerMembershipSpec Policycontroller { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CompliancePostureConfig defines the settings needed to enable/disable features for the Compliance Posture.
    /// </summary>
    public class CompliancePostureConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of enabled compliance standards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStandards")]
        public virtual System.Collections.Generic.IList<ComplianceStandard> ComplianceStandards { get; set; }

        /// <summary>Defines the enablement mode for Compliance Posture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ComplianceStandard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the compliance standard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Config Sync</summary>
    public class ConfigManagementConfigSync : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration for deployment overrides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentOverrides")]
        public virtual System.Collections.Generic.IList<ConfigManagementDeploymentOverride> DeploymentOverrides { get; set; }

        /// <summary>
        /// Optional. Enables the installation of ConfigSync. If set to true, ConfigSync resources will be created and
        /// the other ConfigSync fields will be applied if exist. If set to false, all other ConfigSync fields will be
        /// ignored, ConfigSync resources will be deleted. If omitted, ConfigSync resources will be managed depends on
        /// the presence of the git or oci field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Optional. Git repo configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("git")]
        public virtual ConfigManagementGitConfig Git { get; set; }

        /// <summary>
        /// Optional. The Email of the Google Cloud Service Account (GSA) used for exporting Config Sync metrics to
        /// Cloud Monitoring and Cloud Monarch when Workload Identity is enabled. The GSA should have the Monitoring
        /// Metric Writer (roles/monitoring.metricWriter) IAM role. The Kubernetes ServiceAccount `default` in the
        /// namespace `config-management-monitoring` should be bound to the GSA. Deprecated: If Workload Identity
        /// Federation for GKE is enabled, Google Cloud Service Account is no longer needed for exporting Config Sync
        /// metrics:
        /// https://cloud.google.com/kubernetes-engine/enterprise/config-sync/docs/how-to/monitor-config-sync-cloud-monitoring#custom-monitoring.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricsGcpServiceAccountEmail")]
        public virtual string MetricsGcpServiceAccountEmail { get; set; }

        /// <summary>Optional. OCI repo configuration for the cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oci")]
        public virtual ConfigManagementOciConfig Oci { get; set; }

        /// <summary>
        /// Optional. Set to true to enable the Config Sync admission webhook to prevent drifts. If set to `false`,
        /// disables the Config Sync admission webhook and does not prevent drifts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preventDrift")]
        public virtual System.Nullable<bool> PreventDrift { get; set; }

        /// <summary>
        /// Optional. Specifies whether the Config Sync Repo is in "hierarchical" or "unstructured" mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFormat")]
        public virtual string SourceFormat { get; set; }

        /// <summary>Optional. Set to true to stop syncing configs for a single cluster. Default to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopSyncing")]
        public virtual System.Nullable<bool> StopSyncing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The state of ConfigSync's deployment on a cluster</summary>
    public class ConfigManagementConfigSyncDeploymentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deployment state of admission-webhook</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admissionWebhook")]
        public virtual string AdmissionWebhook { get; set; }

        /// <summary>Deployment state of the git-sync pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSync")]
        public virtual string GitSync { get; set; }

        /// <summary>Deployment state of the importer pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importer")]
        public virtual string Importer { get; set; }

        /// <summary>Deployment state of the monitor pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitor")]
        public virtual string Monitor { get; set; }

        /// <summary>Deployment state of otel-collector</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otelCollector")]
        public virtual string OtelCollector { get; set; }

        /// <summary>Deployment state of reconciler-manager pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconcilerManager")]
        public virtual string ReconcilerManager { get; set; }

        /// <summary>Deployment state of resource-group-controller-manager</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupControllerManager")]
        public virtual string ResourceGroupControllerManager { get; set; }

        /// <summary>Deployment state of root-reconciler</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootReconciler")]
        public virtual string RootReconciler { get; set; }

        /// <summary>Deployment state of the syncer pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncer")]
        public virtual string Syncer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Errors pertaining to the installation of Config Sync</summary>
    public class ConfigManagementConfigSyncError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A string representing the user facing error message</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State information for ConfigSync</summary>
    public class ConfigManagementConfigSyncState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether syncing resources to the cluster is stopped at the cluster level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterLevelStopSyncingState")]
        public virtual string ClusterLevelStopSyncingState { get; set; }

        /// <summary>Output only. The number of RootSync and RepoSync CRs in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crCount")]
        public virtual System.Nullable<int> CrCount { get; set; }

        /// <summary>
        /// Output only. Information about the deployment of ConfigSync, including the version of the various Pods
        /// deployed
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentState")]
        public virtual ConfigManagementConfigSyncDeploymentState DeploymentState { get; set; }

        /// <summary>Output only. Errors pertaining to the installation of Config Sync.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ConfigManagementConfigSyncError> Errors { get; set; }

        /// <summary>Output only. The state of the Reposync CRD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reposyncCrd")]
        public virtual string ReposyncCrd { get; set; }

        /// <summary>Output only. The state of the RootSync CRD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootsyncCrd")]
        public virtual string RootsyncCrd { get; set; }

        /// <summary>Output only. The state of CS This field summarizes the other fields in this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The state of ConfigSync's process to sync configs to a cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncState")]
        public virtual ConfigManagementSyncState SyncState { get; set; }

        /// <summary>Output only. The version of ConfigSync deployed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ConfigManagementConfigSyncVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specific versioning information pertaining to ConfigSync's Pods</summary>
    public class ConfigManagementConfigSyncVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Version of the deployed admission-webhook pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admissionWebhook")]
        public virtual string AdmissionWebhook { get; set; }

        /// <summary>Version of the deployed git-sync pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSync")]
        public virtual string GitSync { get; set; }

        /// <summary>Version of the deployed importer pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importer")]
        public virtual string Importer { get; set; }

        /// <summary>Version of the deployed monitor pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitor")]
        public virtual string Monitor { get; set; }

        /// <summary>Version of the deployed otel-collector pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otelCollector")]
        public virtual string OtelCollector { get; set; }

        /// <summary>Version of the deployed reconciler-manager pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconcilerManager")]
        public virtual string ReconcilerManager { get; set; }

        /// <summary>Version of the deployed resource-group-controller-manager pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupControllerManager")]
        public virtual string ResourceGroupControllerManager { get; set; }

        /// <summary>Version of the deployed reconciler container in root-reconciler pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootReconciler")]
        public virtual string RootReconciler { get; set; }

        /// <summary>Version of the deployed syncer pod</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncer")]
        public virtual string Syncer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a container override.</summary>
    public class ConfigManagementContainerOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerName")]
        public virtual string ContainerName { get; set; }

        /// <summary>Optional. The cpu limit of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuLimit")]
        public virtual string CpuLimit { get; set; }

        /// <summary>Optional. The cpu request of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuRequest")]
        public virtual string CpuRequest { get; set; }

        /// <summary>Optional. The memory limit of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryLimit")]
        public virtual string MemoryLimit { get; set; }

        /// <summary>Optional. The memory request of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryRequest")]
        public virtual string MemoryRequest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a deployment override.</summary>
    public class ConfigManagementDeploymentOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The containers of the deployment resource to be overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<ConfigManagementContainerOverride> Containers { get; set; }

        /// <summary>Required. The name of the deployment resource to be overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentName")]
        public virtual string DeploymentName { get; set; }

        /// <summary>Required. The namespace of the deployment resource to be overridden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentNamespace")]
        public virtual string DeploymentNamespace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model for a config file in the git repo with an associated Sync error</summary>
    public class ConfigManagementErrorResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Group/version/kind of the resource that is causing an error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGvk")]
        public virtual ConfigManagementGroupVersionKind ResourceGvk { get; set; }

        /// <summary>Metadata name of the resource that is causing an error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Namespace of the resource that is causing an error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNamespace")]
        public virtual string ResourceNamespace { get; set; }

        /// <summary>Path in the git repo of the erroneous config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePath")]
        public virtual string SourcePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State of Policy Controller installation.</summary>
    public class ConfigManagementGatekeeperDeploymentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of gatekeeper-audit deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatekeeperAudit")]
        public virtual string GatekeeperAudit { get; set; }

        /// <summary>Status of gatekeeper-controller-manager pod.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatekeeperControllerManagerState")]
        public virtual string GatekeeperControllerManagerState { get; set; }

        /// <summary>Status of the pod serving the mutation webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatekeeperMutation")]
        public virtual string GatekeeperMutation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Git repo configuration for a single cluster.</summary>
    public class ConfigManagementGitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Google Cloud Service Account Email used for auth when secret_type is gcpServiceAccount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccountEmail")]
        public virtual string GcpServiceAccountEmail { get; set; }

        /// <summary>Optional. URL for the HTTPS proxy to be used when communicating with the Git repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpsProxy")]
        public virtual string HttpsProxy { get; set; }

        /// <summary>
        /// Optional. The path within the Git repository that represents the top level of the repo to sync. Default: the
        /// root directory of the repository.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDir")]
        public virtual string PolicyDir { get; set; }

        /// <summary>
        /// Required. Type of secret configured for access to the Git repo. Must be one of ssh, cookiefile, gcenode,
        /// token, gcpserviceaccount, githubapp or none. The validation of this is case-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretType")]
        public virtual string SecretType { get; set; }

        /// <summary>Optional. The branch of the repository to sync from. Default: master.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncBranch")]
        public virtual string SyncBranch { get; set; }

        /// <summary>Required. The URL of the Git repository to use as the source of truth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncRepo")]
        public virtual string SyncRepo { get; set; }

        /// <summary>Optional. Git revision (tag or hash) to check out. Default HEAD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncRev")]
        public virtual string SyncRev { get; set; }

        /// <summary>Optional. Period in seconds between consecutive syncs. Default: 15.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncWaitSecs")]
        public virtual System.Nullable<long> SyncWaitSecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kubernetes object's GVK</summary>
    public class ConfigManagementGroupVersionKind : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Kubernetes Group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Kubernetes Kind</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Kubernetes Version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Hierarchy Controller</summary>
    public class ConfigManagementHierarchyControllerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether hierarchical resource quota is enabled in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHierarchicalResourceQuota")]
        public virtual System.Nullable<bool> EnableHierarchicalResourceQuota { get; set; }

        /// <summary>Whether pod tree labels are enabled in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePodTreeLabels")]
        public virtual System.Nullable<bool> EnablePodTreeLabels { get; set; }

        /// <summary>Whether Hierarchy Controller is enabled in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deployment state for Hierarchy Controller</summary>
    public class ConfigManagementHierarchyControllerDeploymentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployment state for Hierarchy Controller extension (e.g. v0.7.0-hc.1)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extension")]
        public virtual string Extension { get; set; }

        /// <summary>The deployment state for open source HNC (e.g. v0.7.0-hc.0)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hnc")]
        public virtual string Hnc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State for Hierarchy Controller</summary>
    public class ConfigManagementHierarchyControllerState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployment state for Hierarchy Controller</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual ConfigManagementHierarchyControllerDeploymentState State { get; set; }

        /// <summary>The version for Hierarchy Controller</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ConfigManagementHierarchyControllerVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Version for Hierarchy Controller</summary>
    public class ConfigManagementHierarchyControllerVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Version for Hierarchy Controller extension</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extension")]
        public virtual string Extension { get; set; }

        /// <summary>Version for open source HNC</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hnc")]
        public virtual string Hnc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Errors pertaining to the installation of ACM</summary>
    public class ConfigManagementInstallError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A string representing the user facing error message</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **Anthos Config Management**: Configuration for a single cluster. Intended to parallel the ConfigManagement CR.
    /// </summary>
    public class ConfigManagementMembershipSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The user-specified cluster name used by Config Sync cluster-name-selector annotation or
        /// ClusterSelector, for applying configs to only a subset of clusters. Omit this field if the cluster's fleet
        /// membership name is used by Config Sync cluster-name-selector annotation or ClusterSelector. Set this field
        /// if a name different from the cluster's fleet membership name is used by Config Sync cluster-name-selector
        /// annotation or ClusterSelector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>Optional. Config Sync configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSync")]
        public virtual ConfigManagementConfigSync ConfigSync { get; set; }

        /// <summary>
        /// Optional. Hierarchy Controller configuration for the cluster. Deprecated: Configuring Hierarchy Controller
        /// through the configmanagement feature is no longer recommended. Use
        /// https://github.com/kubernetes-sigs/hierarchical-namespaces instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchyController")]
        public virtual ConfigManagementHierarchyControllerConfig HierarchyController { get; set; }

        /// <summary>Optional. Enables automatic Feature management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual string Management { get; set; }

        /// <summary>
        /// Optional. Policy Controller configuration for the cluster. Deprecated: Configuring Policy Controller through
        /// the configmanagement feature is no longer recommended. Use the policycontroller feature instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyController")]
        public virtual ConfigManagementPolicyController PolicyController { get; set; }

        /// <summary>Optional. Version of ACM installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Anthos Config Management**: State for a single cluster.</summary>
    public class ConfigManagementMembershipState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This field is set to the `cluster_name` field of the Membership Spec if it is not empty.
        /// Otherwise, it is set to the cluster's fleet membership name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Output only. Current sync status</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSyncState")]
        public virtual ConfigManagementConfigSyncState ConfigSyncState { get; set; }

        /// <summary>Output only. Hierarchy Controller status</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchyControllerState")]
        public virtual ConfigManagementHierarchyControllerState HierarchyControllerState { get; set; }

        /// <summary>
        /// Output only. Membership configuration in the cluster. This represents the actual state in the cluster, while
        /// the MembershipSpec in the FeatureSpec represents the intended state
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipSpec")]
        public virtual ConfigManagementMembershipSpec MembershipSpec { get; set; }

        /// <summary>Output only. Current install status of ACM's Operator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorState")]
        public virtual ConfigManagementOperatorState OperatorState { get; set; }

        /// <summary>Output only. PolicyController status</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyControllerState")]
        public virtual ConfigManagementPolicyControllerState PolicyControllerState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OCI repo configuration for a single cluster</summary>
    public class ConfigManagementOciConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Google Cloud Service Account Email used for auth when secret_type is gcpServiceAccount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpServiceAccountEmail")]
        public virtual string GcpServiceAccountEmail { get; set; }

        /// <summary>
        /// Optional. The absolute path of the directory that contains the local resources. Default: the root directory
        /// of the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDir")]
        public virtual string PolicyDir { get; set; }

        /// <summary>
        /// Required. Type of secret configured for access to the OCI repo. Must be one of gcenode, gcpserviceaccount,
        /// k8sserviceaccount or none. The validation of this is case-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretType")]
        public virtual string SecretType { get; set; }

        /// <summary>
        /// Required. The OCI image repository URL for the package to sync from. e.g.
        /// `LOCATION-docker.pkg.dev/PROJECT_ID/REPOSITORY_NAME/PACKAGE_NAME`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncRepo")]
        public virtual string SyncRepo { get; set; }

        /// <summary>Optional. Period in seconds between consecutive syncs. Default: 15.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncWaitSecs")]
        public virtual System.Nullable<long> SyncWaitSecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State information for an ACM's Operator</summary>
    public class ConfigManagementOperatorState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of the Operator's deployment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentState")]
        public virtual string DeploymentState { get; set; }

        /// <summary>Install errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ConfigManagementInstallError> Errors { get; set; }

        /// <summary>The semenatic version number of the operator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Policy Controller</summary>
    public class ConfigManagementPolicyController : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit
        /// functionality altogether.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditIntervalSeconds")]
        public virtual System.Nullable<long> AuditIntervalSeconds { get; set; }

        /// <summary>
        /// Enables the installation of Policy Controller. If false, the rest of PolicyController fields take no effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently
        /// exist on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptableNamespaces")]
        public virtual System.Collections.Generic.IList<string> ExemptableNamespaces { get; set; }

        /// <summary>Logs all denies and dry run failures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logDeniesEnabled")]
        public virtual System.Nullable<bool> LogDeniesEnabled { get; set; }

        /// <summary>Monitoring specifies the configuration of monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoring")]
        public virtual ConfigManagementPolicyControllerMonitoring Monitoring { get; set; }

        /// <summary>
        /// Enable or disable mutation in policy controller. If true, mutation CRDs, webhook and controller deployment
        /// will be deployed to the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationEnabled")]
        public virtual System.Nullable<bool> MutationEnabled { get; set; }

        /// <summary>
        /// Enables the ability to use Constraint Templates that reference to objects other than the object currently
        /// being evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referentialRulesEnabled")]
        public virtual System.Nullable<bool> ReferentialRulesEnabled { get; set; }

        /// <summary>Installs the default template library along with Policy Controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateLibraryInstalled")]
        public virtual System.Nullable<bool> TemplateLibraryInstalled { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last time this membership spec was updated.</summary>
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

    /// <summary>State for the migration of PolicyController from ACM -&gt; PoCo Hub.</summary>
    public class ConfigManagementPolicyControllerMigration : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _copyTimeRaw;

        private object _copyTime;

        /// <summary>Last time this membership spec was copied to PoCo feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyTime")]
        public virtual string CopyTimeRaw
        {
            get => _copyTimeRaw;
            set
            {
                _copyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _copyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CopyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CopyTimeDateTimeOffset instead.")]
        public virtual object CopyTime
        {
            get => _copyTime;
            set
            {
                _copyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _copyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CopyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CopyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CopyTimeRaw);
            set => CopyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Stage of the migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PolicyControllerMonitoring specifies the backends Policy Controller should export metrics to. For example, to
    /// specify metrics should be exported to Cloud Monitoring and Prometheus, specify backends: ["cloudmonitoring",
    /// "prometheus"]
    /// </summary>
    public class ConfigManagementPolicyControllerMonitoring : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the list of backends Policy Controller will export to. An empty list would effectively disable
        /// metrics export.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backends")]
        public virtual System.Collections.Generic.IList<string> Backends { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State for PolicyControllerState.</summary>
    public class ConfigManagementPolicyControllerState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state about the policy controller installation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentState")]
        public virtual ConfigManagementGatekeeperDeploymentState DeploymentState { get; set; }

        /// <summary>Record state of ACM -&gt; PoCo Hub migration for this feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migration")]
        public virtual ConfigManagementPolicyControllerMigration Migration { get; set; }

        /// <summary>The version of Gatekeeper Policy Controller deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ConfigManagementPolicyControllerVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The build version of Gatekeeper Policy Controller is using.</summary>
    public class ConfigManagementPolicyControllerVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The gatekeeper image tag that is composed of ACM version, git tag, build number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An ACM created error representing a problem syncing configurations</summary>
    public class ConfigManagementSyncError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An ACM defined error code</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A description of the error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>A list of config(s) associated with the error, if any</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorResources")]
        public virtual System.Collections.Generic.IList<ConfigManagementErrorResource> ErrorResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State indicating an ACM's progress syncing configurations to a cluster</summary>
    public class ConfigManagementSyncState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sync status code</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// A list of errors resulting from problematic configs. This list will be truncated after 100 errors, although
        /// it is unlikely for that many errors to simultaneously exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ConfigManagementSyncError> Errors { get; set; }

        /// <summary>Token indicating the state of the importer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importToken")]
        public virtual string ImportToken { get; set; }

        /// <summary>
        /// Deprecated: use last_sync_time instead. Timestamp of when ACM last successfully synced the repo The time
        /// format is specified in https://golang.org/pkg/time/#Time.String
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSync")]
        public virtual string LastSync { get; set; }

        private string _lastSyncTimeRaw;

        private object _lastSyncTime;

        /// <summary>Timestamp type of when ACM last successfully synced the repo</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual string LastSyncTimeRaw
        {
            get => _lastSyncTimeRaw;
            set
            {
                _lastSyncTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSyncTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastSyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSyncTimeDateTimeOffset instead.")]
        public virtual object LastSyncTime
        {
            get => _lastSyncTime;
            set
            {
                _lastSyncTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSyncTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastSyncTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSyncTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSyncTimeRaw);
            set => LastSyncTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Token indicating the state of the repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceToken")]
        public virtual string SourceToken { get; set; }

        /// <summary>Token indicating the state of the syncer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncToken")]
        public virtual string SyncToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConnectAgentResource represents a Kubernetes resource manifest for Connect Agent deployment.</summary>
    public class ConnectAgentResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>YAML manifest of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; }

        /// <summary>Kubernetes type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual TypeMeta Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Dataplane V2**: Spec</summary>
    public class DataplaneV2FeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable dataplane-v2 based encryption for multiple clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableEncryption")]
        public virtual System.Nullable<bool> EnableEncryption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DefaultClusterConfig describes the default cluster configurations to be applied to all clusters born-in-fleet.
    /// </summary>
    public class DefaultClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Enable/Disable binary authorization features for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorizationConfig")]
        public virtual BinaryAuthorizationConfig BinaryAuthorizationConfig { get; set; }

        /// <summary>
        /// Optional. Enable/Disable Compliance Posture features for the cluster. Note that on UpdateFleet, only full
        /// replacement of this field is allowed. Users are not allowed for partial updates through field mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliancePostureConfig")]
        public virtual CompliancePostureConfig CompliancePostureConfig { get; set; }

        /// <summary>Enable/Disable Security Posture features for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPostureConfig")]
        public virtual SecurityPostureConfig SecurityPostureConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EdgeCluster contains information specific to Google Edge Clusters.</summary>
    public class EdgeCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Self-link of the Google Cloud resource for the Edge Cluster. For example:
        /// //edgecontainer.googleapis.com/projects/my-project/locations/us-west1-a/clusters/my-cluster
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLink")]
        public virtual string ResourceLink { get; set; }

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

    /// <summary>Feature represents the settings and status of any Fleet Feature.</summary>
    public class Feature : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the Feature resource was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the Feature resource was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Feature configuration applicable to all memberships of the fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetDefaultMemberConfig")]
        public virtual CommonFleetDefaultMemberConfigSpec FleetDefaultMemberConfig { get; set; }

        /// <summary>Labels for this Feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Membership-specific configuration for this Feature. If this Feature does not support any
        /// per-Membership configuration, this field may be unused. The keys indicate which Membership the configuration
        /// is for, in the form: `projects/{p}/locations/{l}/memberships/{m}` Where {p} is the project, {l} is a valid
        /// location and {m} is a valid Membership in this project at that location. {p} WILL match the Feature's
        /// project. {p} will always be returned as the project number, but the project ID is also accepted during
        /// input. If the same Membership is specified in the map twice (using the project ID form, and the project
        /// number form), exactly ONE of the entries will be saved, with no guarantees as to which. For this reason, it
        /// is recommended the same format be used for all entries when mutating a Feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipSpecs")]
        public virtual System.Collections.Generic.IDictionary<string, MembershipFeatureSpec> MembershipSpecs { get; set; }

        /// <summary>
        /// Output only. Membership-specific Feature status. If this Feature does report any per-Membership status, this
        /// field may be unused. The keys indicate which Membership the state is for, in the form:
        /// `projects/{p}/locations/{l}/memberships/{m}` Where {p} is the project number, {l} is a valid location and
        /// {m} is a valid Membership in this project at that location. {p} MUST match the Feature's project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipStates")]
        public virtual System.Collections.Generic.IDictionary<string, MembershipFeatureState> MembershipStates { get; set; }

        /// <summary>
        /// Output only. The full, unique name of this Feature resource in the format
        /// `projects/*/locations/*/features/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the Feature resource itself.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceState")]
        public virtual FeatureResourceState ResourceState { get; set; }

        /// <summary>
        /// Optional. Scope-specific configuration for this Feature. If this Feature does not support any per-Scope
        /// configuration, this field may be unused. The keys indicate which Scope the configuration is for, in the
        /// form: `projects/{p}/locations/global/scopes/{s}` Where {p} is the project, {s} is a valid Scope in this
        /// project. {p} WILL match the Feature's project. {p} will always be returned as the project number, but the
        /// project ID is also accepted during input. If the same Scope is specified in the map twice (using the project
        /// ID form, and the project number form), exactly ONE of the entries will be saved, with no guarantees as to
        /// which. For this reason, it is recommended the same format be used for all entries when mutating a Feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeSpecs")]
        public virtual System.Collections.Generic.IDictionary<string, ScopeFeatureSpec> ScopeSpecs { get; set; }

        /// <summary>
        /// Output only. Scope-specific Feature status. If this Feature does report any per-Scope status, this field may
        /// be unused. The keys indicate which Scope the state is for, in the form:
        /// `projects/{p}/locations/global/scopes/{s}` Where {p} is the project, {s} is a valid Scope in this project.
        /// {p} WILL match the Feature's project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeStates")]
        public virtual System.Collections.Generic.IDictionary<string, ScopeFeatureState> ScopeStates { get; set; }

        /// <summary>
        /// Optional. Fleet-wide Feature configuration. If this Feature does not support any Fleet-wide configuration,
        /// this field may be unused.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual CommonFeatureSpec Spec { get; set; }

        /// <summary>Output only. The Fleet-wide Feature state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual CommonFeatureState State { get; set; }

        /// <summary>Output only. List of locations that could not be reached while fetching this feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the Feature resource was last updated.</summary>
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
    /// FeatureResourceState describes the state of a Feature *resource* in the GkeHub API. See `FeatureState` for the
    /// "running state" of the Feature in the Fleet and across Memberships.
    /// </summary>
    public class FeatureResourceState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current state of the Feature resource in the Hub API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// FeatureState describes the high-level state of a Feature. It may be used to describe a Feature's state at the
    /// environ-level, or per-membershop, depending on the context.
    /// </summary>
    public class FeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The high-level, machine-readable status of this Feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A human-readable description of the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time this status and any related Feature-specific details were updated.</summary>
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

    /// <summary>Fleet contains the Fleet-wide metadata and configuration.</summary>
    public class Fleet : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the Fleet was created.</summary>
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

        /// <summary>Optional. The default cluster configurations to apply across the fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultClusterConfig")]
        public virtual DefaultClusterConfig DefaultClusterConfig { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the Fleet was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. A user-assigned display name of the Fleet. When present, it must be between 4 to 30 characters.
        /// Allowed characters are: lowercase and uppercase letters, numbers, hyphen, single-quote, double-quote, space,
        /// and exclamation point. Example: `Production Fleet`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Labels for this Fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The full, unique resource name of this fleet in the format of
        /// `projects/{project}/locations/{location}/fleets/{fleet}`. Each Google Cloud project can have at most one
        /// fleet resource, named "default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the namespace resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual FleetLifecycleState State { get; set; }

        /// <summary>
        /// Output only. Google-generated UUID for this resource. This is unique across all Fleet resources. If a Fleet
        /// resource is deleted and another resource with the same name is created, it gets a different uid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the Fleet was last updated.</summary>
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

    /// <summary>FleetLifecycleState describes the state of a Fleet resource.</summary>
    public class FleetLifecycleState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the Fleet resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All error details of the fleet observability feature.</summary>
    public class FleetObservabilityFeatureError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The code of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A human-readable description of the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Fleet Observability**: The Hub-wide input for the FleetObservability feature.</summary>
    public class FleetObservabilityFeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specified if fleet logging feature is enabled for the entire fleet. If UNSPECIFIED, fleet logging feature is
        /// disabled for the entire fleet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingConfig")]
        public virtual FleetObservabilityLoggingConfig LoggingConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**FleetObservability**: Hub-wide Feature for FleetObservability feature. state.</summary>
    public class FleetObservabilityFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The feature state of default logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual FleetObservabilityFleetObservabilityLoggingState Logging { get; set; }

        /// <summary>The feature state of fleet monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoring")]
        public virtual FleetObservabilityFleetObservabilityMonitoringState Monitoring { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Base state for fleet observability feature.</summary>
    public class FleetObservabilityFleetObservabilityBaseFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The high-level, machine-readable status of this Feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Errors after reconciling the monitoring and logging feature if the code is not OK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<FleetObservabilityFeatureError> Errors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Feature state for logging feature.</summary>
    public class FleetObservabilityFleetObservabilityLoggingState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base feature state of fleet default log.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLog")]
        public virtual FleetObservabilityFleetObservabilityBaseFeatureState DefaultLog { get; set; }

        /// <summary>The base feature state of fleet scope log.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeLog")]
        public virtual FleetObservabilityFleetObservabilityBaseFeatureState ScopeLog { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Feature state for monitoring feature.</summary>
    public class FleetObservabilityFleetObservabilityMonitoringState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base feature state of fleet monitoring feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual FleetObservabilityFleetObservabilityBaseFeatureState State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LoggingConfig defines the configuration for different types of logs.</summary>
    public class FleetObservabilityLoggingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specified if applying the default routing config to logs not specified in other configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultConfig")]
        public virtual FleetObservabilityRoutingConfig DefaultConfig { get; set; }

        /// <summary>Specified if applying the routing config to all logs for all fleet scopes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetScopeLogsConfig")]
        public virtual FleetObservabilityRoutingConfig FleetScopeLogsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**FleetObservability**: The membership-specific input for FleetObservability feature.</summary>
    public class FleetObservabilityMembershipSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**FleetObservability**: Membership-specific Feature state for fleetobservability.</summary>
    public class FleetObservabilityMembershipState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RoutingConfig configures the behaviour of fleet logging feature.</summary>
    public class FleetObservabilityRoutingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>mode configures the logs routing mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GenerateConnectManifestResponse contains manifest information for installing/upgrading a Connect agent.
    /// </summary>
    public class GenerateConnectManifestResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ordered list of Kubernetes resources that need to be applied to the cluster for GKE Connect agent
        /// installation/upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual System.Collections.Generic.IList<ConnectAgentResource> Manifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for GenerateRBACRoleBindingYAML.</summary>
    public class GenerateMembershipRBACRoleBindingYAMLResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>a yaml text blob including the RBAC policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleBindingsYaml")]
        public virtual string RoleBindingsYaml { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GkeCluster contains information specific to GKE clusters.</summary>
    public class GkeCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If cluster_missing is set then it denotes that the GKE cluster no longer exists in the GKE
        /// Control Plane.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterMissing")]
        public virtual System.Nullable<bool> ClusterMissing { get; set; }

        /// <summary>
        /// Immutable. Self-link of the Google Cloud resource for the GKE cluster. For example:
        /// //container.googleapis.com/projects/my-project/locations/us-west1-a/clusters/my-cluster Zonal clusters are
        /// also supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLink")]
        public virtual string ResourceLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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
    /// Configuration of an auth method for a member/cluster. Only one authentication method (e.g., OIDC and LDAP) can
    /// be set per AuthMethod.
    /// </summary>
    public class IdentityServiceAuthMethod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AzureAD specific Configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureadConfig")]
        public virtual IdentityServiceAzureADConfig AzureadConfig { get; set; }

        /// <summary>GoogleConfig specific configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleConfig")]
        public virtual IdentityServiceGoogleConfig GoogleConfig { get; set; }

        /// <summary>LDAP specific configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ldapConfig")]
        public virtual IdentityServiceLdapConfig LdapConfig { get; set; }

        /// <summary>Identifier for auth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>OIDC specific configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcConfig")]
        public virtual IdentityServiceOidcConfig OidcConfig { get; set; }

        /// <summary>Proxy server address to use for auth method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxy")]
        public virtual string Proxy { get; set; }

        /// <summary>SAML specific configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samlConfig")]
        public virtual IdentityServiceSamlConfig SamlConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the AzureAD Auth flow.</summary>
    public class IdentityServiceAzureADConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ID for the registered client application that makes authentication requests to the Azure AD identity
        /// provider.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Input only. Unencrypted AzureAD client secret will be passed to the GKE Hub CLH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>Output only. Encrypted AzureAD client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedClientSecret")]
        public virtual string EncryptedClientSecret { get; set; }

        /// <summary>Optional. Format of the AzureAD groups that the client wants for auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupFormat")]
        public virtual string GroupFormat { get; set; }

        /// <summary>The redirect URL that kubectl uses for authorization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubectlRedirectUri")]
        public virtual string KubectlRedirectUri { get; set; }

        /// <summary>
        /// Kind of Azure AD account to be authenticated. Supported values are or for accounts belonging to a specific
        /// tenant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual string Tenant { get; set; }

        /// <summary>Optional. Claim in the AzureAD ID Token that holds the user details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userClaim")]
        public virtual string UserClaim { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for the AIS diagnostic interface.</summary>
    public class IdentityServiceDiagnosticInterface : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines whether to enable the diagnostic interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// Determines the expiration time of the diagnostic interface enablement. When reached, requests to the
        /// interface would be automatically rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the Google Plugin Auth flow.</summary>
    public class IdentityServiceGoogleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disable automatic configuration of Google Plugin on supported platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disable")]
        public virtual System.Nullable<bool> Disable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the properties for locating and authenticating groups in the directory.</summary>
    public class IdentityServiceGroupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the subtree in the LDAP directory to search for group entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseDn")]
        public virtual string BaseDn { get; set; }

        /// <summary>
        /// Optional. Optional filter to be used when searching for groups a user belongs to. This can be used to
        /// explicitly match only certain groups in order to reduce the amount of groups returned for each user. This
        /// defaults to "(objectClass=Group)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. The identifying name of each group a user belongs to. For example, if this is set to
        /// "distinguishedName" then RBACs and other group expectations should be written as full DNs. This defaults to
        /// "distinguishedName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idAttribute")]
        public virtual string IdAttribute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds non-protocol-related configuration options.</summary>
    public class IdentityServiceIdentityServiceOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration options for the AIS diagnostic interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticInterface")]
        public virtual IdentityServiceDiagnosticInterface DiagnosticInterface { get; set; }

        /// <summary>Determines the lifespan of STS tokens issued by Anthos Identity Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionDuration")]
        public virtual object SessionDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the LDAP Auth flow.</summary>
    public class IdentityServiceLdapConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Contains the properties for locating and authenticating groups in the directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual IdentityServiceGroupConfig Group { get; set; }

        /// <summary>Required. Server settings for the external LDAP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("server")]
        public virtual IdentityServiceServerConfig Server { get; set; }

        /// <summary>
        /// Required. Contains the credentials of the service account which is authorized to perform the LDAP search in
        /// the directory. The credentials can be supplied by the combination of the DN and password or the client
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual IdentityServiceServiceAccountConfig ServiceAccount { get; set; }

        /// <summary>Required. Defines where users exist in the LDAP directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual IdentityServiceUserConfig User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Anthos Identity Service**: Configuration for a single Membership.</summary>
    public class IdentityServiceMembershipSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A member may support multiple auth methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authMethods")]
        public virtual System.Collections.Generic.IList<IdentityServiceAuthMethod> AuthMethods { get; set; }

        /// <summary>Optional. non-protocol-related configuration options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityServiceOptions")]
        public virtual IdentityServiceIdentityServiceOptions IdentityServiceOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Anthos Identity Service**: State for a single Membership.</summary>
    public class IdentityServiceMembershipState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Installed AIS version. This is the AIS version installed on this member. The values makes sense iff state is
        /// OK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedVersion")]
        public virtual string InstalledVersion { get; set; }

        /// <summary>Last reconciled membership configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberConfig")]
        public virtual IdentityServiceMembershipSpec MemberConfig { get; set; }

        /// <summary>Deployment state on this member</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for OIDC Auth flow.</summary>
    public class IdentityServiceOidcConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PEM-encoded CA for OIDC provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateAuthorityData")]
        public virtual string CertificateAuthorityData { get; set; }

        /// <summary>ID for OIDC client application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Input only. Unencrypted OIDC client secret will be passed to the GKE Hub CLH.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>
        /// Flag to denote if reverse proxy is used to connect to auth provider. This flag should be set to true when
        /// provider is not reachable by Google Cloud Console.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployCloudConsoleProxy")]
        public virtual System.Nullable<bool> DeployCloudConsoleProxy { get; set; }

        /// <summary>Enable access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAccessToken")]
        public virtual System.Nullable<bool> EnableAccessToken { get; set; }

        /// <summary>Output only. Encrypted OIDC Client secret</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedClientSecret")]
        public virtual string EncryptedClientSecret { get; set; }

        /// <summary>Comma-separated list of key-value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraParams")]
        public virtual string ExtraParams { get; set; }

        /// <summary>Prefix to prepend to group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupPrefix")]
        public virtual string GroupPrefix { get; set; }

        /// <summary>Claim in OIDC ID token that holds group information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupsClaim")]
        public virtual string GroupsClaim { get; set; }

        /// <summary>
        /// URI for the OIDC provider. This should point to the level below .well-known/openid-configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuerUri")]
        public virtual string IssuerUri { get; set; }

        /// <summary>Registered redirect uri to redirect users going through OAuth flow using kubectl plugin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubectlRedirectUri")]
        public virtual string KubectlRedirectUri { get; set; }

        /// <summary>Comma-separated list of identifiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual string Scopes { get; set; }

        /// <summary>Claim in OIDC ID token that holds username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userClaim")]
        public virtual string UserClaim { get; set; }

        /// <summary>Prefix to prepend to user name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPrefix")]
        public virtual string UserPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the SAML Auth flow.</summary>
    public class IdentityServiceSamlConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The mapping of additional user attributes like nickname, birthday and address etc.. `key` is the
        /// name of this additional attribute. `value` is a string presenting as CEL(common expression language, go/cel)
        /// used for getting the value from the resources. Take nickname as an example, in this case, `key` is
        /// "attribute.nickname" and `value` is "assertion.nickname".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> AttributeMapping { get; set; }

        /// <summary>Optional. Prefix to prepend to group name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupPrefix")]
        public virtual string GroupPrefix { get; set; }

        /// <summary>
        /// Optional. The SAML attribute to read groups from. This value is expected to be a string and will be passed
        /// along as-is (with the option of being prefixed by the `group_prefix`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupsAttribute")]
        public virtual string GroupsAttribute { get; set; }

        /// <summary>Required. The list of IdP certificates to validate the SAML response against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityProviderCertificates")]
        public virtual System.Collections.Generic.IList<string> IdentityProviderCertificates { get; set; }

        /// <summary>Required. The entity ID of the SAML IdP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityProviderId")]
        public virtual string IdentityProviderId { get; set; }

        /// <summary>Required. The URI where the SAML IdP exposes the SSO service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityProviderSsoUri")]
        public virtual string IdentityProviderSsoUri { get; set; }

        /// <summary>
        /// Optional. The SAML attribute to read username from. If unspecified, the username will be read from the
        /// NameID element of the assertion in SAML response. This value is expected to be a string and will be passed
        /// along as-is (with the option of being prefixed by the `user_prefix`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAttribute")]
        public virtual string UserAttribute { get; set; }

        /// <summary>Optional. Prefix to prepend to user name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPrefix")]
        public virtual string UserPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Server settings for the external LDAP server.</summary>
    public class IdentityServiceServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Contains a Base64 encoded, PEM formatted certificate authority certificate for the LDAP server.
        /// This must be provided for the "ldaps" and "startTLS" connections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateAuthorityData")]
        public virtual string CertificateAuthorityData { get; set; }

        /// <summary>
        /// Optional. Defines the connection type to communicate with the LDAP server. If `starttls` or `ldaps` is
        /// specified, the certificate_authority_data should not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>
        /// Required. Defines the hostname or IP of the LDAP server. Port is optional and will default to 389, if
        /// unspecified. For example, "ldap.server.example" or "10.10.10.10:389".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the credentials of the service account which is authorized to perform the LDAP search in the directory.
    /// The credentials can be supplied by the combination of the DN and password or the client certificate.
    /// </summary>
    public class IdentityServiceServiceAccountConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Credentials for basic auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleBindCredentials")]
        public virtual IdentityServiceSimpleBindCredentials SimpleBindCredentials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The structure holds the LDAP simple binding credential.</summary>
    public class IdentityServiceSimpleBindCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The distinguished name(DN) of the service account object/user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dn")]
        public virtual string Dn { get; set; }

        /// <summary>Output only. The encrypted password of the service account object/user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedPassword")]
        public virtual string EncryptedPassword { get; set; }

        /// <summary>Required. Input only. The password of the service account object/user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines where users exist in the LDAP directory.</summary>
    public class IdentityServiceUserConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the subtree in the LDAP directory to search for user entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseDn")]
        public virtual string BaseDn { get; set; }

        /// <summary>
        /// Optional. Filter to apply when searching for the user. This can be used to further restrict the user
        /// accounts which are allowed to login. This defaults to "(objectClass=User)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. Determines which attribute to use as the user's identity after they are authenticated. This is
        /// distinct from the loginAttribute field to allow users to login with a username, but then have their actual
        /// identifier be an email address or full Distinguished Name (DN). For example, setting loginAttribute to
        /// "sAMAccountName" and identifierAttribute to "userPrincipalName" would allow a user to login as "bsmith", but
        /// actual RBAC policies for the user would be written as "bsmith@example.com". Using "userPrincipalName" is
        /// recommended since this will be unique for each user. This defaults to "userPrincipalName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idAttribute")]
        public virtual string IdAttribute { get; set; }

        /// <summary>
        /// Optional. The name of the attribute which matches against the input username. This is used to find the user
        /// in the LDAP database e.g. "(=)" and is combined with the optional filter field. This defaults to
        /// "userPrincipalName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginAttribute")]
        public virtual string LoginAttribute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// KubernetesMetadata provides informational metadata for Memberships representing Kubernetes clusters.
    /// </summary>
    public class KubernetesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Kubernetes API server version string as reported by `/version`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesApiServerVersion")]
        public virtual string KubernetesApiServerVersion { get; set; }

        /// <summary>
        /// Output only. The total memory capacity as reported by the sum of all Kubernetes nodes resources, defined in
        /// MB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMb")]
        public virtual System.Nullable<int> MemoryMb { get; set; }

        /// <summary>Output only. Node count as reported by Kubernetes nodes resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>
        /// Output only. Node providerID as reported by the first node in the list of nodes on the Kubernetes endpoint.
        /// On Kubernetes platforms that support zero-node clusters (like GKE-on-GCP), the node_count will be zero and
        /// the node_provider_id will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeProviderId")]
        public virtual string NodeProviderId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The time at which these details were last updated. This update_time is different from the
        /// Membership-level update_time since EndpointDetails are updated internally for API consumers.
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

        /// <summary>Output only. vCPU count as reported by Kubernetes nodes resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcpuCount")]
        public virtual System.Nullable<int> VcpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// KubernetesResource contains the YAML manifests and configuration for Membership Kubernetes resources in the
    /// cluster. After CreateMembership or UpdateMembership, these resources should be re-applied in the cluster.
    /// </summary>
    public class KubernetesResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Kubernetes resources for installing the GKE Connect agent This field is only populated in
        /// the Membership returned from a successful long-running operation from CreateMembership or UpdateMembership.
        /// It is not populated during normal GetMembership or ListMemberships requests. To get the resource manifest
        /// after the initial registration, the caller should make a UpdateMembership call with an empty field mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectResources")]
        public virtual System.Collections.Generic.IList<ResourceManifest> ConnectResources { get; set; }

        /// <summary>
        /// Input only. The YAML representation of the Membership CR. This field is ignored for GKE clusters where Hub
        /// can read the CR directly. Callers should provide the CR that is currently present in the cluster during
        /// CreateMembership or UpdateMembership, or leave this field empty if none exists. The CR manifest is used to
        /// validate the cluster has not been registered with another Membership.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipCrManifest")]
        public virtual string MembershipCrManifest { get; set; }

        /// <summary>
        /// Output only. Additional Kubernetes resources that need to be applied to the cluster after Membership
        /// creation, and after every update. This field is only populated in the Membership returned from a successful
        /// long-running operation from CreateMembership or UpdateMembership. It is not populated during normal
        /// GetMembership or ListMemberships requests. To get the resource manifest after the initial registration, the
        /// caller should make a UpdateMembership call with an empty field mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipResources")]
        public virtual System.Collections.Generic.IList<ResourceManifest> MembershipResources { get; set; }

        /// <summary>Optional. Options for Kubernetes resource generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceOptions")]
        public virtual ResourceOptions ResourceOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of Memberships bound to a Scope.</summary>
    public class ListBoundMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Memberships bound to the given Scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; }

        /// <summary>
        /// A token to request the next page of resources from the `ListBoundMemberships` method. The value of an empty
        /// string means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of locations that could not be reached while fetching this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `GkeHub.ListFeatures` method.</summary>
    public class ListFeaturesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the `ListFeatures` method. The value of an empty string
        /// means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of matching Features</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Feature> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `GkeHub.ListFleetsResponse` method.</summary>
    public class ListFleetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of matching fleets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleets")]
        public virtual System.Collections.Generic.IList<Fleet> Fleets { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages. The token is only valid for 1h.
        /// </summary>
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

    /// <summary>List of MembershipBindings.</summary>
    public class ListMembershipBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of membership_bindings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipBindings")]
        public virtual System.Collections.Generic.IList<MembershipBinding> MembershipBindings { get; set; }

        /// <summary>
        /// A token to request the next page of resources from the `ListMembershipBindings` method. The value of an
        /// empty string means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of locations that could not be reached while fetching this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of Membership RBACRoleBindings.</summary>
    public class ListMembershipRBACRoleBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the `ListMembershipRBACRoleBindings` method. The value of
        /// an empty string means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Membership RBACRoleBindings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacrolebindings")]
        public virtual System.Collections.Generic.IList<RBACRoleBinding> Rbacrolebindings { get; set; }

        /// <summary>List of locations that could not be reached while fetching this list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `GkeHub.ListMemberships` method.</summary>
    public class ListMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the `ListMemberships` method. The value of an empty
        /// string means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of matching Memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Membership> Resources { get; set; }

        /// <summary>List of locations that could not be reached while fetching this list.</summary>
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

    /// <summary>List of permitted Scopes.</summary>
    public class ListPermittedScopesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the `ListPermittedScopes` method. The value of an empty
        /// string means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of permitted Scopes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<Scope> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of fleet namespaces.</summary>
    public class ListScopeNamespacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the `ListNamespaces` method. The value of an empty string
        /// means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of fleet namespaces</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeNamespaces")]
        public virtual System.Collections.Generic.IList<Namespace> ScopeNamespaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of Scope RBACRoleBindings.</summary>
    public class ListScopeRBACRoleBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the `ListScopeRBACRoleBindings` method. The value of an
        /// empty string means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Scope RBACRoleBindings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbacrolebindings")]
        public virtual System.Collections.Generic.IList<RBACRoleBinding> Rbacrolebindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of Scopes.</summary>
    public class ListScopesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to request the next page of resources from the `ListScopes` method. The value of an empty string
        /// means that there are no more resources to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Scopes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<Scope> Scopes { get; set; }

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

    /// <summary>Membership contains information about a member cluster.</summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. How to identify workloads from this Membership. See the documentation on Workload Identity for
        /// more details: https://cloud.google.com/kubernetes-engine/docs/how-to/workload-identity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authority")]
        public virtual Authority Authority { get; set; }

        /// <summary>Output only. The tier of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterTier")]
        public virtual string ClusterTier { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the Membership was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the Membership was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Description of this membership, limited to 63 characters. Must match the regex: `a-zA-Z0-9*`
        /// This field is present for legacy purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Endpoint information to reach this member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual MembershipEndpoint Endpoint { get; set; }

        /// <summary>
        /// Optional. An externally-generated and managed ID for this Membership. This ID may be modified after
        /// creation, but this is not recommended. The ID must match the regex: `a-zA-Z0-9*` If this Membership
        /// represents a Kubernetes cluster, this value should be set to the UID of the `kube-system` namespace object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalId")]
        public virtual string ExternalId { get; set; }

        /// <summary>
        /// Optional. Labels for this membership. These labels are not leveraged by multi-cluster features, instead, we
        /// prefer cluster labels, which can be set on GKE cluster or other cluster types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        private string _lastConnectionTimeRaw;

        private object _lastConnectionTime;

        /// <summary>
        /// Output only. For clusters using Connect, the timestamp of the most recent connection established with Google
        /// Cloud. This time is updated every several minutes, not continuously. For clusters that do not use GKE
        /// Connect, or that have never connected successfully, this field will be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastConnectionTime")]
        public virtual string LastConnectionTimeRaw
        {
            get => _lastConnectionTimeRaw;
            set
            {
                _lastConnectionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastConnectionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastConnectionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastConnectionTimeDateTimeOffset instead.")]
        public virtual object LastConnectionTime
        {
            get => _lastConnectionTime;
            set
            {
                _lastConnectionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastConnectionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastConnectionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastConnectionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastConnectionTimeRaw);
            set => LastConnectionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The monitoring config information for this membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoringConfig")]
        public virtual MonitoringConfig MonitoringConfig { get; set; }

        /// <summary>
        /// Output only. The full, unique name of this Membership resource in the format
        /// `projects/*/locations/*/memberships/{membership_id}`, set during creation. `membership_id` must be a valid
        /// RFC 1123 compliant DNS label: 1. At most 63 characters in length 2. It must consist of lower case
        /// alphanumeric characters or `-` 3. It must start and end with an alphanumeric character Which can be
        /// expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`, with a maximum length of 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the Membership resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual MembershipState State { get; set; }

        /// <summary>
        /// Output only. Google-generated UUID for this resource. This is unique across all Membership resources. If a
        /// Membership resource is deleted and another resource with the same name is created, it gets a different
        /// unique_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueId")]
        public virtual string UniqueId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the Membership was last updated.</summary>
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
    /// MembershipBinding is a subresource of a Membership, representing what Fleet Scopes (or other, future Fleet
    /// resources) a Membership is bound to.
    /// </summary>
    public class MembershipBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the membership binding was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the membership binding was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Labels for this MembershipBinding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource name for the membershipbinding itself
        /// `projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A Scope resource name in the format `projects/*/locations/*/scopes/*`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Output only. State of the membership binding resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual MembershipBindingLifecycleState State { get; set; }

        /// <summary>
        /// Output only. Google-generated UUID for this resource. This is unique across all membershipbinding resources.
        /// If a membershipbinding resource is deleted and another resource with the same name is created, it gets a
        /// different uid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the membership binding was last updated.</summary>
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

    /// <summary>MembershipBindingLifecycleState describes the state of a Binding resource.</summary>
    public class MembershipBindingLifecycleState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the MembershipBinding resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MembershipEndpoint contains information needed to contact a Kubernetes API, endpoint and any additional
    /// Kubernetes metadata.
    /// </summary>
    public class MembershipEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specific information for a GDC Edge Appliance cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applianceCluster")]
        public virtual ApplianceCluster ApplianceCluster { get; set; }

        /// <summary>Optional. Specific information for a Google Edge cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edgeCluster")]
        public virtual EdgeCluster EdgeCluster { get; set; }

        /// <summary>Optional. Specific information for a GKE-on-GCP cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeCluster")]
        public virtual GkeCluster GkeCluster { get; set; }

        /// <summary>
        /// Output only. Whether the lifecycle of this membership is managed by a google cluster platform service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleManaged")]
        public virtual System.Nullable<bool> GoogleManaged { get; set; }

        /// <summary>Output only. Useful Kubernetes-specific metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesMetadata")]
        public virtual KubernetesMetadata KubernetesMetadata { get; set; }

        /// <summary>
        /// Optional. The in-cluster Kubernetes Resources that should be applied for a correctly registered cluster, in
        /// the steady state. These resources: * Ensure that the cluster is exclusively registered to one and only one
        /// Hub Membership. * Propagate Workload Pool Information available in the Membership Authority field. * Ensure
        /// proper initial configuration of default Hub Features.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesResource")]
        public virtual KubernetesResource KubernetesResource { get; set; }

        /// <summary>Optional. Specific information for a GKE Multi-Cloud cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiCloudCluster")]
        public virtual MultiCloudCluster MultiCloudCluster { get; set; }

        /// <summary>
        /// Optional. Specific information for a GKE On-Prem cluster. An onprem user-cluster who has no resourceLink is
        /// not allowed to use this field, it should have a nil "type" instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onPremCluster")]
        public virtual OnPremCluster OnPremCluster { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MembershipFeatureSpec contains configuration information for a single Membership.</summary>
    public class MembershipFeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Config Management-specific spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configmanagement")]
        public virtual ConfigManagementMembershipSpec Configmanagement { get; set; }

        /// <summary>Fleet observability membership spec</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetobservability")]
        public virtual FleetObservabilityMembershipSpec Fleetobservability { get; set; }

        /// <summary>Identity Service-specific spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityservice")]
        public virtual IdentityServiceMembershipSpec Identityservice { get; set; }

        /// <summary>Anthos Service Mesh-specific spec</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mesh")]
        public virtual ServiceMeshMembershipSpec Mesh { get; set; }

        /// <summary>
        /// Whether this per-Membership spec was inherited from a fleet-level default. This field can be updated by
        /// users by either overriding a Membership config (updated to USER implicitly) or setting to FLEET explicitly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual Origin Origin { get; set; }

        /// <summary>Policy Controller spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policycontroller")]
        public virtual PolicyControllerMembershipSpec Policycontroller { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MembershipFeatureState contains Feature status information for a single Membership.</summary>
    public class MembershipFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Appdevexperience specific state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appdevexperience")]
        public virtual AppDevExperienceFeatureState Appdevexperience { get; set; }

        /// <summary>ClusterUpgrade state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterupgrade")]
        public virtual ClusterUpgradeMembershipState Clusterupgrade { get; set; }

        /// <summary>Config Management-specific state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configmanagement")]
        public virtual ConfigManagementMembershipState Configmanagement { get; set; }

        /// <summary>Fleet observability membership state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetobservability")]
        public virtual FleetObservabilityMembershipState Fleetobservability { get; set; }

        /// <summary>Identity Service-specific state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityservice")]
        public virtual IdentityServiceMembershipState Identityservice { get; set; }

        /// <summary>Policycontroller-specific state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policycontroller")]
        public virtual PolicyControllerMembershipState Policycontroller { get; set; }

        /// <summary>Service Mesh-specific state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicemesh")]
        public virtual ServiceMeshMembershipState Servicemesh { get; set; }

        /// <summary>The high-level state of this Feature for a single membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual FeatureState State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MembershipState describes the state of a Membership resource.</summary>
    public class MembershipState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the Membership resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MonitoringConfig informs Fleet-based applications/services/UIs how the metrics for the underlying cluster is
    /// reported to cloud monitoring services. It can be set from empty to non-empty, but can't be mutated directly to
    /// prevent accidentally breaking the constinousty of metrics.
    /// </summary>
    public class MonitoringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cluster name used to report metrics. For Anthos on VMWare/Baremetal/MultiCloud clusters, it would
        /// be in format {cluster_type}/{cluster_name}, e.g., "awsClusters/cluster_1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>
        /// Optional. For GKE and Multicloud clusters, this is the UUID of the cluster resource. For VMWare and
        /// Baremetal clusters, this is the kube-system UID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterHash")]
        public virtual string ClusterHash { get; set; }

        /// <summary>
        /// Optional. Kubernetes system metrics, if available, are written to this prefix. This defaults to
        /// kubernetes.io for GKE, and kubernetes.io/anthos for Anthos eventually. Noted: Anthos MultiCloud will have
        /// kubernetes.io prefix today but will migration to be under kubernetes.io/anthos.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesMetricsPrefix")]
        public virtual string KubernetesMetricsPrefix { get; set; }

        /// <summary>Optional. Location used to report Metrics</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Optional. Project used to report Metrics</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MultiCloudCluster contains information specific to GKE Multi-Cloud clusters.</summary>
    public class MultiCloudCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If cluster_missing is set then it denotes that API(gkemulticloud.googleapis.com) resource for
        /// this GKE Multi-Cloud cluster no longer exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterMissing")]
        public virtual System.Nullable<bool> ClusterMissing { get; set; }

        /// <summary>
        /// Immutable. Self-link of the Google Cloud resource for the GKE Multi-Cloud cluster. For example:
        /// //gkemulticloud.googleapis.com/projects/my-project/locations/us-west1-a/awsClusters/my-cluster
        /// //gkemulticloud.googleapis.com/projects/my-project/locations/us-west1-a/azureClusters/my-cluster
        /// //gkemulticloud.googleapis.com/projects/my-project/locations/us-west1-a/attachedClusters/my-cluster
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLink")]
        public virtual string ResourceLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Multi-cluster Ingress**: The configuration for the MultiClusterIngress feature.</summary>
    public class MultiClusterIngressFeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Fully-qualified Membership name which hosts the MultiClusterIngress CRD. Example:
        /// `projects/foo-proj/locations/global/memberships/bar`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMembership")]
        public virtual string ConfigMembership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Namespace represents a namespace across the Fleet</summary>
    public class Namespace : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the namespace was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the namespace was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Labels for this Namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource name for the namespace `projects/{project}/locations/{location}/namespaces/{namespace}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Namespace-level cluster namespace labels. These labels are applied to the related namespace of the
        /// member clusters bound to the parent Scope. Scope-level labels (`namespace_labels` in the Fleet Scope
        /// resource) take precedence over Namespace-level labels if they share a key. Keys and values must be
        /// Kubernetes-conformant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> NamespaceLabels { get; set; }

        /// <summary>Required. Scope associated with the namespace</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Output only. State of the namespace resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual NamespaceLifecycleState State { get; set; }

        /// <summary>
        /// Output only. Google-generated UUID for this resource. This is unique across all namespace resources. If a
        /// namespace resource is deleted and another resource with the same name is created, it gets a different uid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the namespace was last updated.</summary>
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

    /// <summary>NamespaceLifecycleState describes the state of a Namespace resource.</summary>
    public class NamespaceLifecycleState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the Namespace resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OnPremCluster contains information specific to GKE On-Prem clusters.</summary>
    public class OnPremCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. Whether the cluster is an admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminCluster")]
        public virtual System.Nullable<bool> AdminCluster { get; set; }

        /// <summary>
        /// Output only. If cluster_missing is set then it denotes that API(gkeonprem.googleapis.com) resource for this
        /// GKE On-Prem cluster no longer exists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterMissing")]
        public virtual System.Nullable<bool> ClusterMissing { get; set; }

        /// <summary>Immutable. The on prem cluster's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterType")]
        public virtual string ClusterType { get; set; }

        /// <summary>
        /// Immutable. Self-link of the Google Cloud resource for the GKE On-Prem cluster. For example:
        /// //gkeonprem.googleapis.com/projects/my-project/locations/us-west1-a/vmwareClusters/my-cluster
        /// //gkeonprem.googleapis.com/projects/my-project/locations/us-west1-a/bareMetalClusters/my-cluster
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLink")]
        public virtual string ResourceLink { get; set; }

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
        public virtual GoogleRpcStatus Error { get; set; }

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
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to `Code.CANCELLED`.
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

    /// <summary>Origin defines where this MembershipFeatureSpec originated from.</summary>
    public class Origin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type specifies which type of origin is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>Binauthz policy that applies to this cluster.</summary>
    public class PolicyBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative resource name of the binauthz platform policy to audit. GKE platform policies have the
        /// following format: `projects/{project_number}/platforms/gke/policies/{policy_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BundleInstallSpec is the specification configuration for a single managed bundle.</summary>
    public class PolicyControllerBundleInstallSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of namespaces to be exempted from the bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedNamespaces")]
        public virtual System.Collections.Generic.IList<string> ExemptedNamespaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Policy Controller</summary>
    public class PolicyControllerHubConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit
        /// functionality altogether.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditIntervalSeconds")]
        public virtual System.Nullable<long> AuditIntervalSeconds { get; set; }

        /// <summary>
        /// The maximum number of audit violations to be stored in a constraint. If not set, the internal default
        /// (currently 20) will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraintViolationLimit")]
        public virtual System.Nullable<long> ConstraintViolationLimit { get; set; }

        /// <summary>Map of deployment configs to deployments ("admission", "audit", "mutation').</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerPolicyControllerDeploymentConfig> DeploymentConfigs { get; set; }

        /// <summary>
        /// The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently
        /// exist on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptableNamespaces")]
        public virtual System.Collections.Generic.IList<string> ExemptableNamespaces { get; set; }

        /// <summary>
        /// The install_spec represents the intended state specified by the latest request that mutated install_spec in
        /// the feature spec, not the lifecycle state of the feature observed by the Hub feature controller that is
        /// reported in the feature state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installSpec")]
        public virtual string InstallSpec { get; set; }

        /// <summary>Logs all denies and dry run failures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logDeniesEnabled")]
        public virtual System.Nullable<bool> LogDeniesEnabled { get; set; }

        /// <summary>Monitoring specifies the configuration of monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoring")]
        public virtual PolicyControllerMonitoringConfig Monitoring { get; set; }

        /// <summary>Enables the ability to mutate resources using Policy Controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationEnabled")]
        public virtual System.Nullable<bool> MutationEnabled { get; set; }

        /// <summary>Specifies the desired policy content on the cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyContent")]
        public virtual PolicyControllerPolicyContentSpec PolicyContent { get; set; }

        /// <summary>
        /// Enables the ability to use Constraint Templates that reference to objects other than the object currently
        /// being evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referentialRulesEnabled")]
        public virtual System.Nullable<bool> ReferentialRulesEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **Policy Controller**: Configuration for a single cluster. Intended to parallel the PolicyController CR.
    /// </summary>
    public class PolicyControllerMembershipSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policy Controller configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyControllerHubConfig")]
        public virtual PolicyControllerHubConfig PolicyControllerHubConfig { get; set; }

        /// <summary>Version of Policy Controller installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Policy Controller**: State for a single cluster.</summary>
    public class PolicyControllerMembershipState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Currently these include (also serving as map keys): 1. "admission" 2. "audit" 3. "mutation"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentStates")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerOnClusterState> ComponentStates { get; set; }

        /// <summary>The overall content state observed by the Hub Feature controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyContentState")]
        public virtual PolicyControllerPolicyContentState PolicyContentState { get; set; }

        /// <summary>The overall Policy Controller lifecycle state observed by the Hub Feature controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MonitoringConfig specifies the backends Policy Controller should export metrics to. For example, to specify
    /// metrics should be exported to Cloud Monitoring and Prometheus, specify backends: ["cloudmonitoring",
    /// "prometheus"]
    /// </summary>
    public class PolicyControllerMonitoringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the list of backends Policy Controller will export to. An empty list would effectively disable
        /// metrics export.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backends")]
        public virtual System.Collections.Generic.IList<string> Backends { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OnClusterState represents the state of a sub-component of Policy Controller.</summary>
    public class PolicyControllerOnClusterState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Surface potential errors or information logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>The lifecycle state of this component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PolicyContentSpec defines the user's desired content configuration on the cluster.</summary>
    public class PolicyControllerPolicyContentSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// map of bundle name to BundleInstallSpec. The bundle name maps to the `bundleName` key in the
        /// `policycontroller.gke.io/constraintData` annotation on a constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundles")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerBundleInstallSpec> Bundles { get; set; }

        /// <summary>Configures the installation of the Template Library.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateLibrary")]
        public virtual PolicyControllerTemplateLibraryConfig TemplateLibrary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The state of the policy controller policy content</summary>
    public class PolicyControllerPolicyContentState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of the any bundles included in the chosen version of the manifest</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleStates")]
        public virtual System.Collections.Generic.IDictionary<string, PolicyControllerOnClusterState> BundleStates { get; set; }

        /// <summary>
        /// The state of the referential data sync configuration. This could represent the state of either the syncSet
        /// object(s) or the config object, depending on the version of PoCo configured by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referentialSyncConfigState")]
        public virtual PolicyControllerOnClusterState ReferentialSyncConfigState { get; set; }

        /// <summary>The state of the template library</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateLibraryState")]
        public virtual PolicyControllerOnClusterState TemplateLibraryState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deployment-specific configuration.</summary>
    public class PolicyControllerPolicyControllerDeploymentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Container resource requirements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerResources")]
        public virtual PolicyControllerResourceRequirements ContainerResources { get; set; }

        /// <summary>Pod affinity configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAffinity")]
        public virtual string PodAffinity { get; set; }

        /// <summary>Pod anti-affinity enablement. Deprecated: use `pod_affinity` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAntiAffinity")]
        public virtual System.Nullable<bool> PodAntiAffinity { get; set; }

        /// <summary>Pod tolerations of node taints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podTolerations")]
        public virtual System.Collections.Generic.IList<PolicyControllerToleration> PodTolerations { get; set; }

        /// <summary>Pod replica count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaCount")]
        public virtual System.Nullable<long> ReplicaCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceList contains container resource requirements.</summary>
    public class PolicyControllerResourceList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CPU requirement expressed in Kubernetes resource units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual string Cpu { get; set; }

        /// <summary>Memory requirement expressed in Kubernetes resource units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual string Memory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    public class PolicyControllerResourceRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed for use by the running container.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual PolicyControllerResourceList Limits { get; set; }

        /// <summary>
        /// Requests describes the amount of compute resources reserved for the container by the kube-scheduler.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual PolicyControllerResourceList Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The config specifying which default library templates to install.</summary>
    public class PolicyControllerTemplateLibraryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configures the manner in which the template library is installed on the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installation")]
        public virtual string Installation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Toleration of a node taint.</summary>
    public class PolicyControllerToleration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Matches a taint effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effect")]
        public virtual string Effect { get; set; }

        /// <summary>Matches a taint key (not necessarily unique).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Matches a taint operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>Matches a taint value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RBACRoleBinding represents a rbacrolebinding across the Fleet</summary>
    public class RBACRoleBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the rbacrolebinding was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the rbacrolebinding was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>group is the group, as seen by the kubernetes cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Optional. Labels for this RBACRolebinding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource name for the rbacrolebinding
        /// `projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}` or
        /// `projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Role to bind to the principal</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual Role Role { get; set; }

        /// <summary>Output only. State of the rbacrolebinding resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual RBACRoleBindingLifecycleState State { get; set; }

        /// <summary>
        /// Output only. Google-generated UUID for this resource. This is unique across all rbacrolebinding resources.
        /// If a rbacrolebinding resource is deleted and another resource with the same name is created, it gets a
        /// different uid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the rbacrolebinding was last updated.</summary>
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

        /// <summary>
        /// user is the name of the user as seen by the kubernetes cluster, example "alice" or "alice@domain.tld"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**RBAC RoleBinding Actuation**: The Hub-wide input for the RBACRoleBindingActuation feature.</summary>
    public class RBACRoleBindingActuationFeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of allowed custom roles (ClusterRoles). If a ClusterRole is not part of this list, it cannot be
        /// used in a Scope RBACRoleBinding. If a ClusterRole in this list is in use, it cannot be removed from the
        /// list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedCustomRoles")]
        public virtual System.Collections.Generic.IList<string> AllowedCustomRoles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**RBAC RoleBinding Actuation**: An empty state left as an example Hub-wide Feature state.</summary>
    public class RBACRoleBindingActuationFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RBACRoleBindingLifecycleState describes the state of a RbacRoleBinding resource.</summary>
    public class RBACRoleBindingLifecycleState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the rbacrolebinding resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceManifest represents a single Kubernetes resource to be applied to the cluster.</summary>
    public class ResourceManifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the resource provided in the manifest is `cluster_scoped`. If unset, the manifest is
        /// assumed to be namespace scoped. This field is used for REST mapping when applying the resource in a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterScoped")]
        public virtual System.Nullable<bool> ClusterScoped { get; set; }

        /// <summary>Output only. YAML manifest of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceOptions represent options for Kubernetes resource generation.</summary>
    public class ResourceOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Connect agent version to use for connect_resources. Defaults to the latest GKE Connect
        /// version. The version must be a currently supported version, obsolete versions will be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectVersion")]
        public virtual string ConnectVersion { get; set; }

        /// <summary>
        /// Optional. Major version of the Kubernetes cluster. This is only used to determine which version to use for
        /// the CustomResourceDefinition resources, `apiextensions/v1beta1` or`apiextensions/v1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("k8sVersion")]
        public virtual string K8sVersion { get; set; }

        /// <summary>
        /// Optional. Use `apiextensions/v1beta1` instead of `apiextensions/v1` for CustomResourceDefinition resources.
        /// This option should be set for clusters with Kubernetes apiserver versions &amp;lt;1.16.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v1beta1Crd")]
        public virtual System.Nullable<bool> V1beta1Crd { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Role is the type for Kubernetes roles</summary>
    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. custom_role is the name of a custom KubernetesClusterRole to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRole")]
        public virtual string CustomRole { get; set; }

        /// <summary>predefined_role is the Kubernetes default role to use</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedRole")]
        public virtual string PredefinedRole { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Scope represents a Scope in a Fleet.</summary>
    public class Scope : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. When the scope was created.</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. When the scope was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Labels for this Scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The resource name for the scope `projects/{project}/locations/{location}/scopes/{scope}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Scope-level cluster namespace labels. For the member clusters bound to the Scope, these labels are
        /// applied to each namespace under the Scope. Scope-level labels take precedence over Namespace-level labels
        /// (`namespace_labels` in the Fleet Namespace resource) if they share a key. Keys and values must be
        /// Kubernetes-conformant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> NamespaceLabels { get; set; }

        /// <summary>Output only. State of the scope resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual ScopeLifecycleState State { get; set; }

        /// <summary>
        /// Output only. Google-generated UUID for this resource. This is unique across all scope resources. If a scope
        /// resource is deleted and another resource with the same name is created, it gets a different uid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. When the scope was last updated.</summary>
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

    /// <summary>ScopeFeatureSpec contains feature specs for a fleet scope.</summary>
    public class ScopeFeatureSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ScopeFeatureState contains Scope-wide Feature status information.</summary>
    public class ScopeFeatureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The "running state" of the Feature in this Scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual FeatureState State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ScopeLifecycleState describes the state of a Scope resource.</summary>
    public class ScopeLifecycleState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the scope resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SecurityPostureConfig defines the flags needed to enable/disable features for the Security Posture API.
    /// </summary>
    public class SecurityPostureConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sets which mode to use for Security Posture features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Sets which mode to use for vulnerability scanning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilityMode")]
        public virtual string VulnerabilityMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Condition being reported.</summary>
    public class ServiceMeshCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unique identifier of the condition which describes the condition recognizable to the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>A short summary about the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>Links contains actionable information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationLink")]
        public virtual string DocumentationLink { get; set; }

        /// <summary>Severity level of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of control plane management.</summary>
    public class ServiceMeshControlPlaneManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explanation of state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<ServiceMeshStatusDetails> Details { get; set; }

        /// <summary>Output only. Implementation of managed control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("implementation")]
        public virtual string Implementation { get; set; }

        /// <summary>LifecycleState of control plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of data plane management. Only reported per-member.</summary>
    public class ServiceMeshDataPlaneManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explanation of the status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<ServiceMeshStatusDetails> Details { get; set; }

        /// <summary>Lifecycle status of data plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>**Service Mesh**: Spec for a single Membership for the servicemesh feature</summary>
    public class ServiceMeshMembershipSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies the API that will be used for configuring the mesh workloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configApi")]
        public virtual string ConfigApi { get; set; }

        /// <summary>Deprecated: use `management` instead Enables automatic control plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlane")]
        public virtual string ControlPlane { get; set; }

        /// <summary>Optional. Enables automatic Service Mesh management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual string Management { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// **Service Mesh**: State for a single Membership, as analyzed by the Service Mesh Hub Controller.
    /// </summary>
    public class ServiceMeshMembershipState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of conditions reported for this membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<ServiceMeshCondition> Conditions { get; set; }

        /// <summary>Output only. Status of control plane management</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneManagement")]
        public virtual ServiceMeshControlPlaneManagement ControlPlaneManagement { get; set; }

        /// <summary>Output only. Status of data plane management.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPlaneManagement")]
        public virtual ServiceMeshDataPlaneManagement DataPlaneManagement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured and human-readable details for a status.</summary>
    public class ServiceMeshStatusDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A machine-readable code that further describes a broad status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Human-readable explanation of code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

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

    /// <summary>Status specifies state for the subcomponent.</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Code specifies AppDevExperienceFeature's subcomponent ready state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Description is populated if Code is Failed, explaining why it has failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

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
    /// TypeMeta is the type information needed for content unmarshalling of Kubernetes resources in the manifest.
    /// </summary>
    public class TypeMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>APIVersion of the resource (e.g. v1).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Kind of the resource (e.g. Deployment).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
