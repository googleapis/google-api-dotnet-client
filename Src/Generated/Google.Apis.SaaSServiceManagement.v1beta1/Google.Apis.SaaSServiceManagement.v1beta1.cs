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

namespace Google.Apis.SaaSServiceManagement.v1beta1
{
    /// <summary>The SaaSServiceManagement Service.</summary>
    public class SaaSServiceManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SaaSServiceManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SaaSServiceManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://saasservicemgmt.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://saasservicemgmt.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "saasservicemgmt";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the SaaS Runtime API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the SaaS Runtime API.</summary>
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

    /// <summary>A base abstract class for SaaSServiceManagement requests.</summary>
    public abstract class SaaSServiceManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SaaSServiceManagementBaseServiceRequest instance.</summary>
        protected SaaSServiceManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SaaSServiceManagement parameter list.</summary>
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
                Releases = new ReleasesResource(service);
                RolloutKinds = new RolloutKindsResource(service);
                Rollouts = new RolloutsResource(service);
                Saas = new SaasResource(service);
                Tenants = new TenantsResource(service);
                UnitKinds = new UnitKindsResource(service);
                UnitOperations = new UnitOperationsResource(service);
                Units = new UnitsResource(service);
            }

            /// <summary>Gets the Releases resource.</summary>
            public virtual ReleasesResource Releases { get; }

            /// <summary>The "releases" collection of methods.</summary>
            public class ReleasesResource
            {
                private const string Resource = "releases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReleasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new release.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the release.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.Release body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new release.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Release>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Release body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the release.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID value for the new release.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("releaseId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReleaseId { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Release Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/releases";

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
                        RequestParameters.Add("releaseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "releaseId",
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

                /// <summary>Delete a single release.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single release.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the release. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the release. The Any wildcard (`*`) requires that the resource must
                    /// already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/releases/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single release.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single release.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Release>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/releases/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of releases.</summary>
                /// <param name="parent">Required. The parent of the release.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of releases.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListReleasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the release.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of releases to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/releases";

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

                /// <summary>Update a single release.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/releases/{release}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.Release body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single release.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Release>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Release body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/releases/{release}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the Release resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields in the Release will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Release Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/releases/[^/]+$",
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
            }

            /// <summary>Gets the RolloutKinds resource.</summary>
            public virtual RolloutKindsResource RolloutKinds { get; }

            /// <summary>The "rolloutKinds" collection of methods.</summary>
            public class RolloutKindsResource
            {
                private const string Resource = "rolloutKinds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RolloutKindsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new rollout kind.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the rollout kind.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new rollout kind.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the rollout kind.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The ID value for the new rollout kind.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("rolloutKindId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RolloutKindId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/rolloutKinds";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("rolloutKindId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "rolloutKindId",
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

                /// <summary>Delete a single rollout kind.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single rollout kind.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the rollout kind. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the rollout kind. The Any wildcard (`*`) requires that the resource
                    /// must already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/rolloutKinds/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single rollout kind.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single rollout kind.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/rolloutKinds/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of rollout kinds.</summary>
                /// <param name="parent">Required. The parent of the rollout kind.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of rollout kinds.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListRolloutKindsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the rollout kind.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of rollout kinds to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/rolloutKinds";

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

                /// <summary>Update a single rollout kind.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single rollout kind.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the RolloutKind resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields in the RolloutKind will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.RolloutKind Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/rolloutKinds/[^/]+$",
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
            }

            /// <summary>Gets the Rollouts resource.</summary>
            public virtual RolloutsResource Rollouts { get; }

            /// <summary>The "rollouts" collection of methods.</summary>
            public class RolloutsResource
            {
                private const string Resource = "rollouts";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RolloutsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new rollout.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the rollout.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new rollout.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the rollout.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The ID value for the new rollout.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("rolloutId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RolloutId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/rollouts";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("rolloutId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "rolloutId",
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

                /// <summary>Delete a single rollout.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single rollout.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the rollout. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the rollout. The Any wildcard (`*`) requires that the resource must
                    /// already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/rollouts/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single rollout.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single rollout.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/rollouts/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of rollouts.</summary>
                /// <param name="parent">Required. The parent of the rollout.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of rollouts.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListRolloutsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the rollout.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of rollouts to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/rollouts";

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

                /// <summary>Update a single rollout.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/rollout/{rollout_id}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single rollout.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/rollout/{rollout_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the Rollout resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields in the Rollout will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Rollout Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/rollouts/[^/]+$",
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
            }

            /// <summary>Gets the Saas resource.</summary>
            public virtual SaasResource Saas { get; }

            /// <summary>The "saas" collection of methods.</summary>
            public class SaasResource
            {
                private const string Resource = "saas";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SaasResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new saas.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the saas.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new saas.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the saas.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The ID value for the new saas.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("saasId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string SaasId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/saas";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("saasId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "saasId",
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

                /// <summary>Delete a single saas.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single saas.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the saas. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the saas. The Any wildcard (`*`) requires that the resource must
                    /// already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/saas/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single saas.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single saas.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/saas/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of saas.</summary>
                /// <param name="parent">Required. The parent of the saas.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of saas.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListSaasResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the saas.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of saas to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/saas";

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

                /// <summary>Update a single saas.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/saas/{saas}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single saas.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/saas/{saas}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the Saas resource by the update.
                    /// The fields specified in the update_mask are relative to the resource, not the full request. A
                    /// field will be overwritten if it is in the mask. If the user does not provide a mask then all
                    /// fields in the Saas will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Saas Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/saas/[^/]+$",
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
            }

            /// <summary>Gets the Tenants resource.</summary>
            public virtual TenantsResource Tenants { get; }

            /// <summary>The "tenants" collection of methods.</summary>
            public class TenantsResource
            {
                private const string Resource = "tenants";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TenantsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new tenant.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the tenant.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new tenant.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the tenant.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The ID value for the new tenant.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tenantId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TenantId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/tenants";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("tenantId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tenantId",
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

                /// <summary>Delete a single tenant.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single tenant.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the tenant. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the tenant. The Any wildcard (`*`) requires that the resource must
                    /// already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tenants/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single tenant.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single tenant.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tenants/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of tenants.</summary>
                /// <param name="parent">Required. The parent of the tenant.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of tenants.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListTenantsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the tenant.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of tenants to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/tenants";

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

                /// <summary>Update a single tenant.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/tenants/{tenant}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single tenant.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/tenants/{tenant}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the Tenant resource by the update.
                    /// The fields specified in the update_mask are relative to the resource, not the full request. A
                    /// field will be overwritten if it is in the mask. If the user does not provide a mask then all
                    /// fields in the Tenant will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Tenant Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tenants/[^/]+$",
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
            }

            /// <summary>Gets the UnitKinds resource.</summary>
            public virtual UnitKindsResource UnitKinds { get; }

            /// <summary>The "unitKinds" collection of methods.</summary>
            public class UnitKindsResource
            {
                private const string Resource = "unitKinds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UnitKindsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new unit kind.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the unit kind.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new unit kind.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the unit kind.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The ID value for the new unit kind.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("unitKindId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UnitKindId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/unitKinds";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("unitKindId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "unitKindId",
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

                /// <summary>Delete a single unit kind.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single unit kind.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the unit kind. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the unit kind. The Any wildcard (`*`) requires that the resource
                    /// must already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/unitKinds/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single unit kind.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single unit kind.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/unitKinds/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of unit kinds.</summary>
                /// <param name="parent">Required. The parent of the unit kind.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of unit kinds.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListUnitKindsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the unit kind.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of unit kinds to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/unitKinds";

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

                /// <summary>Update a single unit kind.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/unitKinds/{unitKind}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single unit kind.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/unitKinds/{unitKind}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the UnitKind resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields in the UnitKind will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitKind Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/unitKinds/[^/]+$",
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
            }

            /// <summary>Gets the UnitOperations resource.</summary>
            public virtual UnitOperationsResource UnitOperations { get; }

            /// <summary>The "unitOperations" collection of methods.</summary>
            public class UnitOperationsResource
            {
                private const string Resource = "unitOperations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UnitOperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new unit operation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the unit operation.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new unit operation.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the unit operation.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The ID value for the new unit operation.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("unitOperationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UnitOperationId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/unitOperations";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("unitOperationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "unitOperationId",
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

                /// <summary>Delete a single unit operation.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single unit operation.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the unit operation. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the unit operation. The Any wildcard (`*`) requires that the
                    /// resource must already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/unitOperations/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single unit operation.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single unit operation.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/unitOperations/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of unit operations.</summary>
                /// <param name="parent">Required. The parent of the unit operation.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of unit operations.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListUnitOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the unit operation.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of unit operations to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/unitOperations";

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

                /// <summary>Update a single unit operation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/unitOperations/{unitOperation}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single unit operation.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/unitOperations/{unitOperation}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the UnitOperation resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields in the UnitOperation will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.UnitOperation Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/unitOperations/[^/]+$",
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
            }

            /// <summary>Gets the Units resource.</summary>
            public virtual UnitsResource Units { get; }

            /// <summary>The "units" collection of methods.</summary>
            public class UnitsResource
            {
                private const string Resource = "units";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UnitsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a new unit.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent of the unit.</param>
                public virtual CreateRequest Create(Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new unit.</summary>
                public class CreateRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the unit.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. The ID value for the new unit.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("unitId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UnitId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/units";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("unitId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "unitId",
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

                /// <summary>Delete a single unit.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a single unit.</summary>
                public class DeleteRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The etag known to the client for the expected state of the unit. This is used with
                    /// state-changing methods to prevent accidental overwrites when multiple user agents might be
                    /// acting in parallel on the same resource. An etag wildcard provide optimistic concurrency based
                    /// on the expected existence of the unit. The Any wildcard (`*`) requires that the resource must
                    /// already exists, and the Not Any wildcard (`!*`) requires that it must not.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/units/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Retrieve a single unit.</summary>
                /// <param name="name">Required. The resource name of the resource within a service.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a single unit.</summary>
                public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the resource within a service.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/units/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a collection of units.</summary>
                /// <param name="parent">Required. The parent of the unit.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Retrieve a collection of units.</summary>
                public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListUnitsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent of the unit.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter the list as specified in https://google.aip.dev/160.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order results as specified in https://google.aip.dev/132.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of units to send per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token: If the next_page_token from a previous response is provided, this request will
                    /// send the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/units";

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

                /// <summary>Update a single unit.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                /// "projects/{project}/locations/{location}/units/{unit}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update a single unit.</summary>
                public class PatchRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
                    /// "projects/{project}/locations/{location}/units/{unit}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server will know to ignore the request if it has already been completed.
                    /// The server will guarantee that for at least 60 minutes since the first request. For example,
                    /// consider a situation where you make an initial request and the request times out. If you make
                    /// the request again with the same request ID, the server can check if original operation with the
                    /// same request ID was received, and if so, will ignore the second request. This prevents clients
                    /// from accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Field mask is used to specify the fields to be overwritten in the Unit resource by the update.
                    /// The fields specified in the update_mask are relative to the resource, not the full request. A
                    /// field will be overwritten if it is in the mask. If the user does not provide a mask then all
                    /// fields in the Unit will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If "validate_only" is set to true, the service will try to validate that this request would
                    /// succeed, but will not actually make changes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SaaSServiceManagement.v1beta1.Data.Unit Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/units/[^/]+$",
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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.GoogleCloudLocationLocation>
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
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : SaaSServiceManagementBaseServiceRequest<Google.Apis.SaaSServiceManagement.v1beta1.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
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
namespace Google.Apis.SaaSServiceManagement.v1beta1.Data
{
    /// <summary>
    /// Represents the aggregation of a set of population of like records by a certain group. For example, a collection
    /// of unit counts can be aggregated and grouped by their state.
    /// </summary>
    public class Aggregate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Number of records in the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>Required. Group by which to aggregate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Blueprints are OCI Images that contain all of the artifacts needed to provision a unit. Metadata such as, type
    /// of the engine used to actuate the blueprint (e.g. terraform, helm etc) and version will come from the image
    /// manifest. If the hostname is omitted, it will be assumed to be the regional path to Artifact Registry (eg.
    /// us-east1-docker.pkg.dev).
    /// </summary>
    public class Blueprint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Type of the engine used to actuate the blueprint. e.g. terraform, helm etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>
        /// Optional. Immutable. URI to a blueprint used by the Unit (required unless unitKind or release is set).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>Output only. Version metadata if present on the blueprint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dependency represent a single dependency with another unit kind by alias.</summary>
    public class Dependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. An alias for the dependency. Used for input variable mapping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>Required. Immutable. The unit kind of the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitKind")]
        public virtual string UnitKind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprovision is the unit operation that deprovision the underlying resources represented by a Unit. Can only
    /// execute if the Unit is currently provisioned.
    /// </summary>
    public class Deprovision : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// The configuration for error budget. If the number of failed units exceeds max(allowed_count, allowed_ratio *
    /// total_units), the rollout will be paused.
    /// </summary>
    public class ErrorBudget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum number of failed units allowed in a location without pausing the rollout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedCount")]
        public virtual System.Nullable<int> AllowedCount { get; set; }

        /// <summary>
        /// Optional. The maximum percentage of units allowed to fail (0, 100] within a location without pausing the
        /// rollout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedPercentage")]
        public virtual System.Nullable<int> AllowedPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output variables whose values will be passed on to dependencies</summary>
    public class FromMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Alias of the dependency that the outputVariable will pass its value to</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependency")]
        public virtual string Dependency { get; set; }

        /// <summary>Required. Name of the outputVariable on the dependency</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputVariable")]
        public virtual string OutputVariable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a Google Cloud location.</summary>
    public class GoogleCloudLocationLocation : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<GoogleCloudLocationLocation> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListReleases method.</summary>
    public class ListReleasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListReleases call to list the next page. If
        /// empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting releases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releases")]
        public virtual System.Collections.Generic.IList<Release> Releases { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListRolloutKinds method.</summary>
    public class ListRolloutKindsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListRolloutKinds call to list the next page.
        /// If empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting rollout kinds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutKinds")]
        public virtual System.Collections.Generic.IList<RolloutKind> RolloutKinds { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListRollouts method.</summary>
    public class ListRolloutsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListRollouts call to list the next page. If
        /// empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting rollouts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollouts")]
        public virtual System.Collections.Generic.IList<Rollout> Rollouts { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListSaas method.</summary>
    public class ListSaasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListSaas call to list the next page. If
        /// empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting saas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saas")]
        public virtual System.Collections.Generic.IList<Saas> Saas { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListTenants method.</summary>
    public class ListTenantsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListTenants call to list the next page. If
        /// empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting tenants.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenants")]
        public virtual System.Collections.Generic.IList<Tenant> Tenants { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListUnitKinds method.</summary>
    public class ListUnitKindsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListUnitKinds call to list the next page. If
        /// empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting unit kinds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitKinds")]
        public virtual System.Collections.Generic.IList<UnitKind> UnitKinds { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListUnitOperations method.</summary>
    public class ListUnitOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListUnitOperations call to list the next
        /// page. If empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting unit operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitOperations")]
        public virtual System.Collections.Generic.IList<UnitOperation> UnitOperations { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response structure for the ListUnits method.</summary>
    public class ListUnitsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the next page token can be provided to a subsequent ListUnits call to list the next page. If
        /// empty, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting units.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Collections.Generic.IList<Unit> Units { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location information that the service is available in.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name of location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Captures requested directives for performing future maintenance on the unit. This includes a request for the
    /// unit to skip maintenance for a period of time and remain pinned to its current release as well as controls for
    /// postponing maintenance scheduled in future.
    /// </summary>
    public class MaintenanceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _pinnedUntilTimeRaw;

        private object _pinnedUntilTime;

        /// <summary>
        /// Optional. If present, it fixes the release on the unit until the given time; i.e. changes to the release
        /// field will be rejected. Rollouts should and will also respect this by not requesting an upgrade in the first
        /// place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pinnedUntilTime")]
        public virtual string PinnedUntilTimeRaw
        {
            get => _pinnedUntilTimeRaw;
            set
            {
                _pinnedUntilTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _pinnedUntilTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PinnedUntilTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PinnedUntilTimeDateTimeOffset instead.")]
        public virtual object PinnedUntilTime
        {
            get => _pinnedUntilTime;
            set
            {
                _pinnedUntilTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _pinnedUntilTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="PinnedUntilTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PinnedUntilTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PinnedUntilTimeRaw);
            set => PinnedUntilTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provision is the unit operation that provision the underlying resources represented by a Unit. Can only execute
    /// if the Unit is not currently provisioned.
    /// </summary>
    public class Provision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Set of input variables. Maximum 100. (optional)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariables")]
        public virtual System.Collections.Generic.IList<UnitVariable> InputVariables { get; set; }

        /// <summary>Optional. Reference to the Release object to use for the Unit. (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A new version to be propagated and deployed to units. This includes pointers to packaged blueprints for
    /// actuation (e.g Helm or Terraform configuration packages) via artifact registry.
    /// </summary>
    public class Release : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional. Blueprints are OCI Images that contain all of the artifacts needed to provision a unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blueprint")]
        public virtual Blueprint Blueprint { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. Mapping of input variables to default values. Maximum 100</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariableDefaults")]
        public virtual System.Collections.Generic.IList<UnitVariable> InputVariableDefaults { get; set; }

        /// <summary>
        /// Optional. Output only. List of input variables declared on the blueprint and can be present with their
        /// values on the unit spec
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariables")]
        public virtual System.Collections.Generic.IList<UnitVariable> InputVariables { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/releases/{release}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Output only. List of output variables declared on the blueprint and can be present with their
        /// values on the unit status
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputVariables")]
        public virtual System.Collections.Generic.IList<UnitVariable> OutputVariables { get; set; }

        /// <summary>Optional. Set of requirements to be fulfilled on the Unit when using this Release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseRequirements")]
        public virtual ReleaseRequirements ReleaseRequirements { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        /// Required. Immutable. Reference to the UnitKind this Release corresponds to (required and immutable once
        /// created).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitKind")]
        public virtual string UnitKind { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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
    }

    /// <summary>Set of requirements to be fulfilled on the Unit when using this Release.</summary>
    public class ReleaseRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of releases from which a unit can be upgraded to this one (optional). If left empty no
        /// constraints will be applied. When provided, unit upgrade requests to this release will check and enforce
        /// this constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeableFromReleases")]
        public virtual System.Collections.Generic.IList<string> UpgradeableFromReleases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single rollout execution and its results</summary>
    public class Rollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional. Requested change to the execution of this rollout. Default RolloutControl.action is
        /// ROLLOUT_ACTION_RUN meaning the rollout will be executed to completion while progressing through all natural
        /// Rollout States (such as RUNNING -&amp;gt; SUCCEEDED or RUNNING -&amp;gt; FAILED). Requests can only be made
        /// when the Rollout is in a non-terminal state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("control")]
        public virtual RolloutControl Control { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>
        /// Optional. Output only. The time when the rollout finished execution (regardless of success, failure, or
        /// cancellation). Will be empty if the rollout hasn't finished yet. Once set, the rollout is in terminal state
        /// and all the results are final.
        /// </summary>
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
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/rollout/{rollout_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Output only. The direct parent rollout that this rollout is stemming from. The resource name (full
        /// URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/rollouts/{rollout_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentRollout")]
        public virtual string ParentRollout { get; set; }

        /// <summary>
        /// Optional. Immutable. Name of the Release that gets rolled out to target Units. Required if no other type of
        /// release is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>
        /// Optional. Immutable. Name of the RolloutKind this rollout is stemming from and adhering to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutKind")]
        public virtual string RolloutKind { get; set; }

        /// <summary>
        /// Optional. The strategy used for executing this Rollout. This strategy will override whatever strategy is
        /// specified in the RolloutType. If not specified on creation, the strategy from RolloutType will be used.
        /// There are two supported values strategies which are used to control - "Google.Cloud.Simple.AllAtOnce" -
        /// "Google.Cloud.Simple.OneLocationAtATime" A rollout with one of these simple strategies will rollout across
        /// all locations defined in the targeted UnitKind's Saas Locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutOrchestrationStrategy")]
        public virtual string RolloutOrchestrationStrategy { get; set; }

        /// <summary>
        /// Optional. Output only. The root rollout that this rollout is stemming from. The resource name (full URI of
        /// the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/rollouts/{rollout_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootRollout")]
        public virtual string RootRollout { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Output only. The time when the rollout started executing. Will be empty if the rollout hasn't
        /// started yet.
        /// </summary>
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

        /// <summary>Output only. Current state of the rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Human readable message indicating details about the last state transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _stateTransitionTimeRaw;

        private object _stateTransitionTime;

        /// <summary>Optional. Output only. The time when the rollout transitioned into its current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTransitionTime")]
        public virtual string StateTransitionTimeRaw
        {
            get => _stateTransitionTimeRaw;
            set
            {
                _stateTransitionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _stateTransitionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StateTransitionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StateTransitionTimeDateTimeOffset instead.")]
        public virtual object StateTransitionTime
        {
            get => _stateTransitionTime;
            set
            {
                _stateTransitionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _stateTransitionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="StateTransitionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StateTransitionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StateTransitionTimeRaw);
            set => StateTransitionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Output only. Details about the progress of the rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual RolloutStats Stats { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        /// Optional. CEL(https://github.com/google/cel-spec) formatted filter string against Unit. The filter will be
        /// applied to determine the eligible unit population. This filter can only reduce, but not expand the scope of
        /// the rollout. If not provided, the unit_filter from the RolloutType will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitFilter")]
        public virtual string UnitFilter { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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
    }

    /// <summary>
    /// RolloutControl provides a way to request a change to the execution of a Rollout by pausing or canceling it.
    /// </summary>
    public class RolloutControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Action to be performed on the Rollout. The default behavior is to run the rollout until it
        /// naturally reaches a terminal state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// Optional. Parameters for the RUN action. It is an error to specify this if the RolloutAction is not set to
        /// RUN. By default, the rollout will retry failed operations when resumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runParams")]
        public virtual RunRolloutActionParams RunParams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that describes various settings of Rollout execution. Includes built-in policies across GCP and GDC,
    /// and customizable policies.
    /// </summary>
    public class RolloutKind : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>
        /// Optional. The configuration for error budget. If the number of failed units exceeds max(allowed_count,
        /// allowed_ratio * total_units), the rollout will be paused. If not set, all units will be attempted to be
        /// updated regardless of the number of failures encountered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorBudget")]
        public virtual ErrorBudget ErrorBudget { get; set; }

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The strategy used for executing a Rollout. This is a required field. There are two supported
        /// values strategies which are used to control - "Google.Cloud.Simple.AllAtOnce" -
        /// "Google.Cloud.Simple.OneLocationAtATime" A rollout with one of these simple strategies will rollout across
        /// all locations defined in the associated UnitKind's Saas Locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutOrchestrationStrategy")]
        public virtual string RolloutOrchestrationStrategy { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        /// Optional. CEL(https://github.com/google/cel-spec) formatted filter string against Unit. The filter will be
        /// applied to determine the eligible unit population. This filter can only reduce, but not expand the scope of
        /// the rollout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitFilter")]
        public virtual string UnitFilter { get; set; }

        /// <summary>
        /// Required. Immutable. UnitKind that this rollout kind corresponds to. Rollouts stemming from this rollout
        /// kind will target the units of this unit kind. In other words, this defines the population of target units to
        /// be upgraded by rollouts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitKind")]
        public virtual string UnitKind { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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

        /// <summary>
        /// Optional. The config for updating the unit kind. By default, the unit kind will be updated on the rollout
        /// start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateUnitKindStrategy")]
        public virtual string UpdateUnitKindStrategy { get; set; }
    }

    /// <summary>RolloutStats contains information about the progress of a rollout.</summary>
    public class RolloutStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. A breakdown of the progress of operations triggered by the rollout. Provides a count of
        /// Operations by their state. This can be used to determine the number of units which have been updated, or are
        /// scheduled to be updated. There will be at most one entry per group. Possible values for operation groups
        /// are: - "SCHEDULED" - "PENDING" - "RUNNING" - "SUCCEEDED" - "FAILED" - "CANCELLED"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationsByState")]
        public virtual System.Collections.Generic.IList<Aggregate> OperationsByState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters for the RUN action controlling the behavior of the rollout when it is resumed from a PAUSED state.
    /// </summary>
    public class RunRolloutActionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. If true, the rollout will retry failed operations when resumed. This is applicable only the
        /// current state of the Rollout is PAUSED and the requested action is RUN.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryFailedOperations")]
        public virtual System.Nullable<bool> RetryFailedOperations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Saas is a representation of a SaaS service managed by the Producer.</summary>
    public class Saas : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. List of locations that the service is available in. Rollout refers to the list to generate a
        /// rollout plan.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/saas/{saas}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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
    }

    /// <summary>A time specification to schedule the maintenance.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Start of operation. If not set, will be set to the start of the next window. (optional)
        /// </summary>
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

    /// <summary>
    /// Tenant represents the service producer side of an instance of the service created based on a request from a
    /// consumer. In a typical scenario a Tenant has a one-to-one mapping with a resource given out to a service
    /// consumer. Example: tenant: name: "projects/svc1/locations/loc/tenants/inst-068afff8" consumer_resource:
    /// "projects/gshoe/locations/loc/shoes/black-shoe"
    /// </summary>
    public class Tenant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional. Immutable. A reference to the consumer resource this SaaS Tenant is representing. The relationship
        /// with a consumer resource can be used by SaaS Runtime for retrieving consumer-defined settings and policies
        /// such as maintenance policies (using Unified Maintenance Policy API).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerResource")]
        public virtual string ConsumerResource { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/tenants/{tenant}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. A reference to the Saas that defines the product (managed service) that the producer
        /// wants to manage with SaaS Runtime. Part of the SaaS Runtime common data model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saas")]
        public virtual string Saas { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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
    }

    /// <summary>Input variables whose values will be passed on to dependencies</summary>
    public class ToMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Alias of the dependency that the inputVariable will pass its value to</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependency")]
        public virtual string Dependency { get; set; }

        /// <summary>Optional. Tells SaaS Runtime if this mapping should be used during lookup or not</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreForLookup")]
        public virtual System.Nullable<bool> IgnoreForLookup { get; set; }

        /// <summary>Required. Name of the inputVariable on the dependency</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariable")]
        public virtual string InputVariable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A unit of deployment that has its lifecycle via a CRUD API using an actuation engine under the hood (e.g. based
    /// on Terraform, Helm or a custom implementation provided by a service producer). A building block of a SaaS
    /// Tenant.
    /// </summary>
    public class Unit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional. Output only. A set of conditions which indicate the various conditions this resource can have.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<UnitCondition> Conditions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>Optional. Output only. Set of dependencies for this unit. Maximum 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<UnitDependency> Dependencies { get; set; }

        /// <summary>
        /// Optional. Output only. List of Units that depend on this unit. Unit can only be deprovisioned if this list
        /// is empty. Maximum 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependents")]
        public virtual System.Collections.Generic.IList<UnitDependency> Dependents { get; set; }

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. Output only. Indicates the current input variables deployed by the unit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariables")]
        public virtual System.Collections.Generic.IList<UnitVariable> InputVariables { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Captures requested directives for performing future maintenance on the unit. This includes a
        /// request for the unit to skip maintenance for a period of time and remain pinned to its current release as
        /// well as controls for postponing maintenance scheduled in future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenance")]
        public virtual MaintenanceSettings Maintenance { get; set; }

        /// <summary>
        /// Optional. Immutable. Indicates whether the Unit life cycle is controlled by the user or by the system.
        /// Immutable once created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementMode")]
        public virtual string ManagementMode { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/units/{unit}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Output only. List of concurrent UnitOperations that are operating on this Unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ongoingOperations")]
        public virtual System.Collections.Generic.IList<string> OngoingOperations { get; set; }

        /// <summary>
        /// Optional. Output only. Set of key/value pairs corresponding to output variables from execution of actuation
        /// templates. The variables are declared in actuation configs (e.g in helm chart or terraform) and the values
        /// are fetched and returned by the actuation engine upon completion of execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputVariables")]
        public virtual System.Collections.Generic.IList<UnitVariable> OutputVariables { get; set; }

        /// <summary>
        /// Optional. Output only. List of pending (wait to be executed) UnitOperations for this unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingOperations")]
        public virtual System.Collections.Generic.IList<string> PendingOperations { get; set; }

        /// <summary>Optional. Output only. The current Release object for this Unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>Optional. Output only. List of scheduled UnitOperations for this unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledOperations")]
        public virtual System.Collections.Generic.IList<string> ScheduledOperations { get; set; }

        /// <summary>
        /// Optional. Output only. Current lifecycle state of the resource (e.g. if it's being created or ready to use).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _systemCleanupAtRaw;

        private object _systemCleanupAt;

        /// <summary>
        /// Optional. Output only. If set, indicates the time when the system will start removing the unit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemCleanupAt")]
        public virtual string SystemCleanupAtRaw
        {
            get => _systemCleanupAtRaw;
            set
            {
                _systemCleanupAt = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _systemCleanupAtRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SystemCleanupAtRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SystemCleanupAtDateTimeOffset instead.")]
        public virtual object SystemCleanupAt
        {
            get => _systemCleanupAt;
            set
            {
                _systemCleanupAtRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _systemCleanupAt = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SystemCleanupAtRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SystemCleanupAtDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SystemCleanupAtRaw);
            set => SystemCleanupAtRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Output only. Indicates the system managed state of the unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemManagedState")]
        public virtual string SystemManagedState { get; set; }

        /// <summary>
        /// Optional. Reference to the Saas Tenant resource this unit belongs to. This for example informs the
        /// maintenance policies to use for scheduling future updates on a unit. (optional and immutable once created)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual string Tenant { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Optional. Reference to the UnitKind this Unit belongs to. Immutable once set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitKind")]
        public virtual string UnitKind { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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
    }

    /// <summary>
    /// UnitCondition describes the status of an Unit. UnitCondition is individual components that contribute to an
    /// overall state.
    /// </summary>
    public class UnitCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastTransitionTimeRaw;

        private object _lastTransitionTime;

        /// <summary>Required. Last time the condition transited from one status to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransitionTime")]
        public virtual string LastTransitionTimeRaw
        {
            get => _lastTransitionTimeRaw;
            set
            {
                _lastTransitionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastTransitionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastTransitionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastTransitionTimeDateTimeOffset instead.")]
        public virtual object LastTransitionTime
        {
            get => _lastTransitionTime;
            set
            {
                _lastTransitionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastTransitionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastTransitionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastTransitionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastTransitionTimeRaw);
            set => LastTransitionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Human readable message indicating details about the last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Required. Brief reason for the condition's last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Required. Status of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Required. Type of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of dependencies for this unit. Maximum 10.</summary>
    public class UnitDependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Alias for the name of the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>Output only. A reference to the Unit object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a Unit. Units belonging to the same UnitKind are managed together; for example they follow the
    /// same release model (blueprints, versions etc.) and are typically rolled out together.
    /// </summary>
    public class UnitKind : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        /// <summary>
        /// Optional. A reference to the Release object to use as default for creating new units of this UnitKind
        /// (optional). If not specified, a new unit must explicitly reference which release to use for its creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultRelease")]
        public virtual string DefaultRelease { get; set; }

        /// <summary>
        /// Optional. Immutable. List of other unit kinds that this release will depend on. Dependencies will be
        /// automatically provisioned if not found. Maximum 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<Dependency> Dependencies { get; set; }

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. List of inputVariables for this release that will either be retrieved from a dependency’s
        /// outputVariables, or will be passed on to a dependency’s inputVariables. Maximum 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariableMappings")]
        public virtual System.Collections.Generic.IList<VariableMapping> InputVariableMappings { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/unitKinds/{unitKind}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. List of outputVariables for this unit kind will be passed to this unit's outputVariables. Maximum
        /// 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputVariableMappings")]
        public virtual System.Collections.Generic.IList<VariableMapping> OutputVariableMappings { get; set; }

        /// <summary>
        /// Required. Immutable. A reference to the Saas that defines the product (managed service) that the producer
        /// wants to manage with SaaS Runtime. Part of the SaaS Runtime common data model. Immutable once set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saas")]
        public virtual string Saas { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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
    }

    /// <summary>
    /// UnitOperation encapsulates the intent of changing/interacting with the service component represented by the
    /// specific Unit. Multiple UnitOperations can be created (requested) and scheduled in the future, however only one
    /// will be allowed to execute at a time (that can change in the future for non-mutating operations). UnitOperations
    /// allow different actors interacting with the same unit to focus only on the change they have requested. This is a
    /// base object that contains the common fields in all unit operations. Next: 19
    /// </summary>
    public class UnitOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Annotations is an unstructured key-value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional. When true, attempt to cancel the operation. Cancellation may fail if the operation is already
        /// executing. (Optional)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancel")]
        public virtual System.Nullable<bool> Cancel { get; set; }

        /// <summary>
        /// Optional. Output only. A set of conditions which indicate the various conditions this resource can have.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<UnitOperationCondition> Conditions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the resource was created.</summary>
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

        [Newtonsoft.Json.JsonPropertyAttribute("deprovision")]
        public virtual Deprovision Deprovision { get; set; }

        /// <summary>
        /// Optional. Output only. The engine state for on-going deployment engine operation(s). This field is opaque
        /// for external usage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineState")]
        public virtual string EngineState { get; set; }

        /// <summary>Optional. Output only. UnitOperationErrorCategory describe the error category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCategory")]
        public virtual string ErrorCategory { get; set; }

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. The labels on the resource, which can be used for categorization. similar to Kubernetes resource
        /// labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name (full URI of the resource) following the standard naming scheme:
        /// "projects/{project}/locations/{location}/unitOperations/{unitOperation}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Reference to parent resource: UnitOperation. If an operation needs to create other operations as
        /// part of its workflow, each of the child operations should have this field set to the parent. This can be
        /// used for tracing. (Optional)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentUnitOperation")]
        public virtual string ParentUnitOperation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("provision")]
        public virtual Provision Provision { get; set; }

        /// <summary>
        /// Optional. Specifies which rollout created this Unit Operation. This cannot be modified and is used for
        /// filtering purposes only. If a dependent unit and unit operation are created as part of another unit
        /// operation, they will use the same rolloutId.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>Optional. When to schedule this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual Schedule Schedule { get; set; }

        /// <summary>
        /// Optional. Output only. UnitOperationState describes the current state of the unit operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the resource. UID is unique in the time and space for this resource
        /// within the scope of the service. It is typically generated by the server on successful creation of a
        /// resource and must not be changed. UID is used to uniquely identify resources with resource name reuses. This
        /// should be a UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Required. Immutable. The Unit a given UnitOperation will act upon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
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

        [Newtonsoft.Json.JsonPropertyAttribute("upgrade")]
        public virtual Upgrade Upgrade { get; set; }
    }

    /// <summary>
    /// UnitOperationCondition describes the status of an Unit Operation. UnitOperationCondition is individual
    /// components that contribute to an overall state.
    /// </summary>
    public class UnitOperationCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastTransitionTimeRaw;

        private object _lastTransitionTime;

        /// <summary>Required. Last time the condition transited from one status to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransitionTime")]
        public virtual string LastTransitionTimeRaw
        {
            get => _lastTransitionTimeRaw;
            set
            {
                _lastTransitionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastTransitionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastTransitionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastTransitionTimeDateTimeOffset instead.")]
        public virtual object LastTransitionTime
        {
            get => _lastTransitionTime;
            set
            {
                _lastTransitionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastTransitionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastTransitionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastTransitionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastTransitionTimeRaw);
            set => LastTransitionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Human readable message indicating details about the last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Required. Brief reason for the condition's last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Required. Status of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Required. Type of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UnitVariable describes a parameter for a Unit.</summary>
    public class UnitVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. Name of a supported variable type. Supported types are string, int, bool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Optional. String encoded value for the variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>Required. Immutable. Name of the variable from actuation configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Upgrade is the unit operation that upgrades a provisioned unit, which may also include the underlying resources
    /// represented by a Unit. Can only execute if the Unit is currently provisioned.
    /// </summary>
    public class Upgrade : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Set of input variables. Maximum 100. (optional)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariables")]
        public virtual System.Collections.Generic.IList<UnitVariable> InputVariables { get; set; }

        /// <summary>Optional. Reference to the Release object to use for the Unit. (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mapping of input variables to their respective output variable for depedenencies</summary>
    public class VariableMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Output variables which will get their values from dependencies</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("from")]
        public virtual FromMapping From { get; set; }

        /// <summary>Optional. Input variables whose values will be passed on to dependencies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("to")]
        public virtual ToMapping To { get; set; }

        /// <summary>Required. name of the variable</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual string Variable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
