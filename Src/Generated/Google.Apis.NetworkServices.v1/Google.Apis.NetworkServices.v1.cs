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

namespace Google.Apis.NetworkServices.v1
{
    /// <summary>The NetworkServices Service.</summary>
    public class NetworkServicesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public NetworkServicesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public NetworkServicesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://networkservices.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://networkservices.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "networkservices";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Network Services API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Network Services API.</summary>
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

    /// <summary>A base abstract class for NetworkServices requests.</summary>
    public abstract class NetworkServicesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new NetworkServicesBaseServiceRequest instance.</summary>
        protected NetworkServicesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes NetworkServices parameter list.</summary>
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
                AuthzExtensions = new AuthzExtensionsResource(service);
                EdgeCacheKeysets = new EdgeCacheKeysetsResource(service);
                EdgeCacheOrigins = new EdgeCacheOriginsResource(service);
                EdgeCacheServices = new EdgeCacheServicesResource(service);
                EndpointPolicies = new EndpointPoliciesResource(service);
                Gateways = new GatewaysResource(service);
                GrpcRoutes = new GrpcRoutesResource(service);
                HttpRoutes = new HttpRoutesResource(service);
                LbRouteExtensions = new LbRouteExtensionsResource(service);
                LbTrafficExtensions = new LbTrafficExtensionsResource(service);
                Meshes = new MeshesResource(service);
                Operations = new OperationsResource(service);
                ServiceBindings = new ServiceBindingsResource(service);
                ServiceLbPolicies = new ServiceLbPoliciesResource(service);
                TcpRoutes = new TcpRoutesResource(service);
                TlsRoutes = new TlsRoutesResource(service);
                WasmPlugins = new WasmPluginsResource(service);
            }

            /// <summary>Gets the AuthzExtensions resource.</summary>
            public virtual AuthzExtensionsResource AuthzExtensions { get; }

            /// <summary>The "authzExtensions" collection of methods.</summary>
            public class AuthzExtensionsResource
            {
                private const string Resource = "authzExtensions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuthzExtensionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new `AuthzExtension` resource in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the `AuthzExtension` resource. Must be in the format
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.AuthzExtension body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new `AuthzExtension` resource in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.AuthzExtension body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the `AuthzExtension` resource. Must be in the format
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-provided ID of the `AuthzExtension` resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("authzExtensionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AuthzExtensionId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.AuthzExtension Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/authzExtensions";

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
                        RequestParameters.Add("authzExtensionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "authzExtensionId",
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

                /// <summary>Deletes the specified `AuthzExtension` resource.</summary>
                /// <param name="name">
                /// Required. The name of the `AuthzExtension` resource to delete. Must be in the format
                /// `projects/{project}/locations/{location}/authzExtensions/{authz_extension}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the specified `AuthzExtension` resource.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `AuthzExtension` resource to delete. Must be in the format
                    /// `projects/{project}/locations/{location}/authzExtensions/{authz_extension}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/authzExtensions/[^/]+$",
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

                /// <summary>Gets details of the specified `AuthzExtension` resource.</summary>
                /// <param name="name">
                /// Required. A name of the `AuthzExtension` resource to get. Must be in the format
                /// `projects/{project}/locations/{location}/authzExtensions/{authz_extension}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of the specified `AuthzExtension` resource.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.AuthzExtension>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the `AuthzExtension` resource to get. Must be in the format
                    /// `projects/{project}/locations/{location}/authzExtensions/{authz_extension}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/authzExtensions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `AuthzExtension` resources in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the `AuthzExtension` resources are listed. These
                /// values are specified in the following format: `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `AuthzExtension` resources in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListAuthzExtensionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the `AuthzExtension` resources are listed. These
                    /// values are specified in the following format: `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint about how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. The server might return fewer items than requested. If
                    /// unspecified, the server picks an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results that the server returns.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/authzExtensions";

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

                /// <summary>Updates the parameters of the specified `AuthzExtension` resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Identifier. Name of the `AuthzExtension` resource in the following format:
                /// `projects/{project}/locations/{location}/authzExtensions/{authz_extension}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.AuthzExtension body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of the specified `AuthzExtension` resource.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.AuthzExtension body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Identifier. Name of the `AuthzExtension` resource in the following format:
                    /// `projects/{project}/locations/{location}/authzExtensions/{authz_extension}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Used to specify the fields to be overwritten in the `AuthzExtension` resource by the
                    /// update. The fields specified in the `update_mask` are relative to the resource, not the full
                    /// request. A field is overwritten if it is in the mask. If the user does not specify a mask, then
                    /// all fields are overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.AuthzExtension Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/authzExtensions/[^/]+$",
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
            }

            /// <summary>Gets the EdgeCacheKeysets resource.</summary>
            public virtual EdgeCacheKeysetsResource EdgeCacheKeysets { get; }

            /// <summary>The "edgeCacheKeysets" collection of methods.</summary>
            public class EdgeCacheKeysetsResource
            {
                private const string Resource = "edgeCacheKeysets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EdgeCacheKeysetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
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
                public class GetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheKeysets/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheKeysets/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheKeysets/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the EdgeCacheOrigins resource.</summary>
            public virtual EdgeCacheOriginsResource EdgeCacheOrigins { get; }

            /// <summary>The "edgeCacheOrigins" collection of methods.</summary>
            public class EdgeCacheOriginsResource
            {
                private const string Resource = "edgeCacheOrigins";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EdgeCacheOriginsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
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
                public class GetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheOrigins/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheOrigins/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheOrigins/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the EdgeCacheServices resource.</summary>
            public virtual EdgeCacheServicesResource EdgeCacheServices { get; }

            /// <summary>The "edgeCacheServices" collection of methods.</summary>
            public class EdgeCacheServicesResource
            {
                private const string Resource = "edgeCacheServices";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EdgeCacheServicesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
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
                public class GetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheServices/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheServices/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.NetworkServices.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/edgeCacheServices/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the EndpointPolicies resource.</summary>
            public virtual EndpointPoliciesResource EndpointPolicies { get; }

            /// <summary>The "endpointPolicies" collection of methods.</summary>
            public class EndpointPoliciesResource
            {
                private const string Resource = "endpointPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EndpointPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new EndpointPolicy in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the EndpointPolicy. Must be in the format
                /// `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.EndpointPolicy body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new EndpointPolicy in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.EndpointPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the EndpointPolicy. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Short name of the EndpointPolicy resource to be created. E.g. "CustomECS".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endpointPolicyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EndpointPolicyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.EndpointPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/endpointPolicies";

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
                        RequestParameters.Add("endpointPolicyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endpointPolicyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single EndpointPolicy.</summary>
                /// <param name="name">
                /// Required. A name of the EndpointPolicy to delete. Must be in the format
                /// `projects/*/locations/global/endpointPolicies/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single EndpointPolicy.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the EndpointPolicy to delete. Must be in the format
                    /// `projects/*/locations/global/endpointPolicies/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single EndpointPolicy.</summary>
                /// <param name="name">
                /// Required. A name of the EndpointPolicy to get. Must be in the format
                /// `projects/*/locations/global/endpointPolicies/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single EndpointPolicy.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.EndpointPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the EndpointPolicy to get. Must be in the format
                    /// `projects/*/locations/global/endpointPolicies/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists EndpointPolicies in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the EndpointPolicies should be listed, specified in
                /// the format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists EndpointPolicies in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListEndpointPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the EndpointPolicies should be listed, specified
                    /// in the format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of EndpointPolicies to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListEndpointPoliciesResponse` Indicates that this is a
                    /// continuation of a prior `ListEndpointPolicies` call, and that the system should return the next
                    /// page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                    /// Otherwise if one of the locations is down or unreachable, the Aggregated List request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/endpointPolicies";

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

                /// <summary>Updates the parameters of a single EndpointPolicy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the EndpointPolicy resource. It matches pattern
                /// `projects/{project}/locations/global/endpointPolicies/{endpoint_policy}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.EndpointPolicy body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single EndpointPolicy.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.EndpointPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the EndpointPolicy resource. It matches pattern
                    /// `projects/{project}/locations/global/endpointPolicies/{endpoint_policy}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the EndpointPolicy
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.EndpointPolicy Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointPolicies/[^/]+$",
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

            /// <summary>Gets the Gateways resource.</summary>
            public virtual GatewaysResource Gateways { get; }

            /// <summary>The "gateways" collection of methods.</summary>
            public class GatewaysResource
            {
                private const string Resource = "gateways";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GatewaysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    RouteViews = new RouteViewsResource(service);
                }

                /// <summary>Gets the RouteViews resource.</summary>
                public virtual RouteViewsResource RouteViews { get; }

                /// <summary>The "routeViews" collection of methods.</summary>
                public class RouteViewsResource
                {
                    private const string Resource = "routeViews";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RouteViewsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Get a single RouteView of a Gateway.</summary>
                    /// <param name="name">
                    /// Required. Name of the GatewayRouteView resource. Formats:
                    /// projects/{project_number}/locations/{location}/gateways/{gateway_name}/routeViews/{route_view_name}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Get a single RouteView of a Gateway.</summary>
                    public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.GatewayRouteView>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the GatewayRouteView resource. Formats:
                        /// projects/{project_number}/locations/{location}/gateways/{gateway_name}/routeViews/{route_view_name}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+/routeViews/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists RouteViews</summary>
                    /// <param name="parent">
                    /// Required. The Gateway to which a Route is associated. Formats:
                    /// projects/{project_number}/locations/{location}/gateways/{gateway_name}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists RouteViews</summary>
                    public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListGatewayRouteViewsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Gateway to which a Route is associated. Formats:
                        /// projects/{project_number}/locations/{location}/gateways/{gateway_name}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Maximum number of GatewayRouteViews to return per call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The value returned by the last `ListGatewayRouteViewsResponse` Indicates that this is a
                        /// continuation of a prior `ListGatewayRouteViews` call, and that the system should return the
                        /// next page of data.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/routeViews";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
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

                /// <summary>Creates a new Gateway in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the Gateway. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.Gateway body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Gateway in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.Gateway body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the Gateway. Must be in the format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the Gateway resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("gatewayId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GatewayId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.Gateway Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/gateways";

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
                        RequestParameters.Add("gatewayId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "gatewayId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Gateway.</summary>
                /// <param name="name">
                /// Required. A name of the Gateway to delete. Must be in the format
                /// `projects/*/locations/*/gateways/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Gateway.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Gateway to delete. Must be in the format
                    /// `projects/*/locations/*/gateways/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Gateway.</summary>
                /// <param name="name">
                /// Required. A name of the Gateway to get. Must be in the format `projects/*/locations/*/gateways/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Gateway.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Gateway>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Gateway to get. Must be in the format
                    /// `projects/*/locations/*/gateways/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Gateways in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the Gateways should be listed, specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Gateways in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListGatewaysResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the Gateways should be listed, specified in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Gateways to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListGatewaysResponse` Indicates that this is a continuation of a
                    /// prior `ListGateways` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/gateways";

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

                /// <summary>Updates the parameters of a single Gateway.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the Gateway resource. It matches pattern `projects/*/locations/*/gateways/`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.Gateway body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Gateway.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.Gateway body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the Gateway resource. It matches pattern `projects/*/locations/*/gateways/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the Gateway resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.Gateway Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gateways/[^/]+$",
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

            /// <summary>Gets the GrpcRoutes resource.</summary>
            public virtual GrpcRoutesResource GrpcRoutes { get; }

            /// <summary>The "grpcRoutes" collection of methods.</summary>
            public class GrpcRoutesResource
            {
                private const string Resource = "grpcRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GrpcRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new GrpcRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the GrpcRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.GrpcRoute body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new GrpcRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.GrpcRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the GrpcRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the GrpcRoute resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("grpcRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GrpcRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.GrpcRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/grpcRoutes";

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
                        RequestParameters.Add("grpcRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "grpcRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single GrpcRoute.</summary>
                /// <param name="name">
                /// Required. A name of the GrpcRoute to delete. Must be in the format
                /// `projects/*/locations/global/grpcRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single GrpcRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the GrpcRoute to delete. Must be in the format
                    /// `projects/*/locations/global/grpcRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/grpcRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single GrpcRoute.</summary>
                /// <param name="name">
                /// Required. A name of the GrpcRoute to get. Must be in the format
                /// `projects/*/locations/global/grpcRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GrpcRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.GrpcRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the GrpcRoute to get. Must be in the format
                    /// `projects/*/locations/global/grpcRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/grpcRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists GrpcRoutes in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the GrpcRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists GrpcRoutes in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListGrpcRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the GrpcRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of GrpcRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListGrpcRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListGrpcRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                    /// Otherwise if one of the locations is down or unreachable, the Aggregated List request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/grpcRoutes";

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

                /// <summary>Updates the parameters of a single GrpcRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the GrpcRoute resource. It matches pattern
                /// `projects/*/locations/global/grpcRoutes/`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.GrpcRoute body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single GrpcRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.GrpcRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the GrpcRoute resource. It matches pattern
                    /// `projects/*/locations/global/grpcRoutes/`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the GrpcRoute resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.GrpcRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/grpcRoutes/[^/]+$",
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

            /// <summary>Gets the HttpRoutes resource.</summary>
            public virtual HttpRoutesResource HttpRoutes { get; }

            /// <summary>The "httpRoutes" collection of methods.</summary>
            public class HttpRoutesResource
            {
                private const string Resource = "httpRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public HttpRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new HttpRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the HttpRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.HttpRoute body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new HttpRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.HttpRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the HttpRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the HttpRoute resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("httpRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string HttpRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.HttpRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/httpRoutes";

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
                        RequestParameters.Add("httpRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "httpRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single HttpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the HttpRoute to delete. Must be in the format
                /// `projects/*/locations/global/httpRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single HttpRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the HttpRoute to delete. Must be in the format
                    /// `projects/*/locations/global/httpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/httpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single HttpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the HttpRoute to get. Must be in the format
                /// `projects/*/locations/global/httpRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single HttpRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.HttpRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the HttpRoute to get. Must be in the format
                    /// `projects/*/locations/global/httpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/httpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists HttpRoute in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the HttpRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists HttpRoute in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListHttpRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the HttpRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of HttpRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListHttpRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListHttpRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                    /// Otherwise if one of the locations is down or unreachable, the Aggregated List request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/httpRoutes";

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

                /// <summary>Updates the parameters of a single HttpRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the HttpRoute resource. It matches pattern
                /// `projects/*/locations/global/httpRoutes/http_route_name&amp;gt;`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.HttpRoute body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single HttpRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.HttpRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the HttpRoute resource. It matches pattern
                    /// `projects/*/locations/global/httpRoutes/http_route_name&amp;gt;`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the HttpRoute resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.HttpRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/httpRoutes/[^/]+$",
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

            /// <summary>Gets the LbRouteExtensions resource.</summary>
            public virtual LbRouteExtensionsResource LbRouteExtensions { get; }

            /// <summary>The "lbRouteExtensions" collection of methods.</summary>
            public class LbRouteExtensionsResource
            {
                private const string Resource = "lbRouteExtensions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LbRouteExtensionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new `LbRouteExtension` resource in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the `LbRouteExtension` resource. Must be in the format
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.LbRouteExtension body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new `LbRouteExtension` resource in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.LbRouteExtension body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the `LbRouteExtension` resource. Must be in the format
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-provided ID of the `LbRouteExtension` resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("lbRouteExtensionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LbRouteExtensionId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.LbRouteExtension Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/lbRouteExtensions";

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
                        RequestParameters.Add("lbRouteExtensionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "lbRouteExtensionId",
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

                /// <summary>Deletes the specified `LbRouteExtension` resource.</summary>
                /// <param name="name">
                /// Required. The name of the `LbRouteExtension` resource to delete. Must be in the format
                /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the specified `LbRouteExtension` resource.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `LbRouteExtension` resource to delete. Must be in the format
                    /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lbRouteExtensions/[^/]+$",
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

                /// <summary>Gets details of the specified `LbRouteExtension` resource.</summary>
                /// <param name="name">
                /// Required. A name of the `LbRouteExtension` resource to get. Must be in the format
                /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of the specified `LbRouteExtension` resource.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.LbRouteExtension>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the `LbRouteExtension` resource to get. Must be in the format
                    /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lbRouteExtensions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `LbRouteExtension` resources in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the `LbRouteExtension` resources are listed. These
                /// values are specified in the following format: `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `LbRouteExtension` resources in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListLbRouteExtensionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the `LbRouteExtension` resources are listed. These
                    /// values are specified in the following format: `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint about how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. The server might return fewer items than requested. If
                    /// unspecified, the server picks an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results that the server returns.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/lbRouteExtensions";

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

                /// <summary>Updates the parameters of the specified `LbRouteExtension` resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Identifier. Name of the `LbRouteExtension` resource in the following format:
                /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.LbRouteExtension body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of the specified `LbRouteExtension` resource.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.LbRouteExtension body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Identifier. Name of the `LbRouteExtension` resource in the following format:
                    /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Used to specify the fields to be overwritten in the `LbRouteExtension` resource by the
                    /// update. The fields specified in the `update_mask` are relative to the resource, not the full
                    /// request. A field is overwritten if it is in the mask. If the user does not specify a mask, then
                    /// all fields are overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.LbRouteExtension Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lbRouteExtensions/[^/]+$",
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
            }

            /// <summary>Gets the LbTrafficExtensions resource.</summary>
            public virtual LbTrafficExtensionsResource LbTrafficExtensions { get; }

            /// <summary>The "lbTrafficExtensions" collection of methods.</summary>
            public class LbTrafficExtensionsResource
            {
                private const string Resource = "lbTrafficExtensions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LbTrafficExtensionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new `LbTrafficExtension` resource in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the `LbTrafficExtension` resource. Must be in the format
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.LbTrafficExtension body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new `LbTrafficExtension` resource in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.LbTrafficExtension body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the `LbTrafficExtension` resource. Must be in the format
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. User-provided ID of the `LbTrafficExtension` resource to be created.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("lbTrafficExtensionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LbTrafficExtensionId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.LbTrafficExtension Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/lbTrafficExtensions";

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
                        RequestParameters.Add("lbTrafficExtensionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "lbTrafficExtensionId",
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

                /// <summary>Deletes the specified `LbTrafficExtension` resource.</summary>
                /// <param name="name">
                /// Required. The name of the `LbTrafficExtension` resource to delete. Must be in the format
                /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the specified `LbTrafficExtension` resource.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `LbTrafficExtension` resource to delete. Must be in the format
                    /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lbTrafficExtensions/[^/]+$",
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

                /// <summary>Gets details of the specified `LbTrafficExtension` resource.</summary>
                /// <param name="name">
                /// Required. A name of the `LbTrafficExtension` resource to get. Must be in the format
                /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of the specified `LbTrafficExtension` resource.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.LbTrafficExtension>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the `LbTrafficExtension` resource to get. Must be in the format
                    /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lbTrafficExtensions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `LbTrafficExtension` resources in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the `LbTrafficExtension` resources are listed. These
                /// values are specified in the following format: `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `LbTrafficExtension` resources in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListLbTrafficExtensionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the `LbTrafficExtension` resources are listed.
                    /// These values are specified in the following format: `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint about how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. The server might return fewer items than requested. If
                    /// unspecified, the server picks an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results that the server returns.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/lbTrafficExtensions";

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

                /// <summary>Updates the parameters of the specified `LbTrafficExtension` resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Identifier. Name of the `LbTrafficExtension` resource in the following format:
                /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.LbTrafficExtension body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of the specified `LbTrafficExtension` resource.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.LbTrafficExtension body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Identifier. Name of the `LbTrafficExtension` resource in the following format:
                    /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server can ignore the request if it has already been completed.
                    /// The server guarantees that for 60 minutes since the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server ignores the second request This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Used to specify the fields to be overwritten in the `LbTrafficExtension` resource by
                    /// the update. The fields specified in the `update_mask` are relative to the resource, not the full
                    /// request. A field is overwritten if it is in the mask. If the user does not specify a mask, then
                    /// all fields are overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.LbTrafficExtension Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/lbTrafficExtensions/[^/]+$",
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
            }

            /// <summary>Gets the Meshes resource.</summary>
            public virtual MeshesResource Meshes { get; }

            /// <summary>The "meshes" collection of methods.</summary>
            public class MeshesResource
            {
                private const string Resource = "meshes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MeshesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    RouteViews = new RouteViewsResource(service);
                }

                /// <summary>Gets the RouteViews resource.</summary>
                public virtual RouteViewsResource RouteViews { get; }

                /// <summary>The "routeViews" collection of methods.</summary>
                public class RouteViewsResource
                {
                    private const string Resource = "routeViews";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RouteViewsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Get a single RouteView of a Mesh.</summary>
                    /// <param name="name">
                    /// Required. Name of the MeshRouteView resource. Format:
                    /// projects/{project_number}/locations/{location}/meshes/{mesh_name}/routeViews/{route_view_name}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Get a single RouteView of a Mesh.</summary>
                    public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.MeshRouteView>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the MeshRouteView resource. Format:
                        /// projects/{project_number}/locations/{location}/meshes/{mesh_name}/routeViews/{route_view_name}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+/routeViews/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists RouteViews</summary>
                    /// <param name="parent">
                    /// Required. The Mesh to which a Route is associated. Format:
                    /// projects/{project_number}/locations/{location}/meshes/{mesh_name}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists RouteViews</summary>
                    public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListMeshRouteViewsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Mesh to which a Route is associated. Format:
                        /// projects/{project_number}/locations/{location}/meshes/{mesh_name}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Maximum number of MeshRouteViews to return per call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The value returned by the last `ListMeshRouteViewsResponse` Indicates that this is a
                        /// continuation of a prior `ListMeshRouteViews` call, and that the system should return the
                        /// next page of data.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/routeViews";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
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

                /// <summary>Creates a new Mesh in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the Mesh. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.Mesh body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Mesh in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.Mesh body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the Mesh. Must be in the format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the Mesh resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("meshId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string MeshId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.Mesh Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/meshes";

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
                        RequestParameters.Add("meshId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "meshId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Mesh.</summary>
                /// <param name="name">
                /// Required. A name of the Mesh to delete. Must be in the format
                /// `projects/*/locations/global/meshes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Mesh.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Mesh to delete. Must be in the format
                    /// `projects/*/locations/global/meshes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Mesh.</summary>
                /// <param name="name">
                /// Required. A name of the Mesh to get. Must be in the format `projects/*/locations/global/meshes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Mesh.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Mesh>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the Mesh to get. Must be in the format
                    /// `projects/*/locations/global/meshes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Meshes in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the Meshes should be listed, specified in the format
                /// `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Meshes in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListMeshesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the Meshes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Meshes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListMeshesResponse` Indicates that this is a continuation of a
                    /// prior `ListMeshes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                    /// Otherwise if one of the locations is down or unreachable, the Aggregated List request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/meshes";

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

                /// <summary>Updates the parameters of a single Mesh.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.Mesh body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Mesh.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.Mesh body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the Mesh resource by the
                    /// update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.Mesh Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/meshes/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.NetworkServices.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Empty>
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
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
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
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the ServiceBindings resource.</summary>
            public virtual ServiceBindingsResource ServiceBindings { get; }

            /// <summary>The "serviceBindings" collection of methods.</summary>
            public class ServiceBindingsResource
            {
                private const string Resource = "serviceBindings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServiceBindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new ServiceBinding in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the ServiceBinding. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.ServiceBinding body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new ServiceBinding in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.ServiceBinding body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the ServiceBinding. Must be in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the ServiceBinding resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceBindingId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceBindingId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.ServiceBinding Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/serviceBindings";

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
                        RequestParameters.Add("serviceBindingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceBindingId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single ServiceBinding.</summary>
                /// <param name="name">
                /// Required. A name of the ServiceBinding to delete. Must be in the format
                /// `projects/*/locations/*/serviceBindings/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single ServiceBinding.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the ServiceBinding to delete. Must be in the format
                    /// `projects/*/locations/*/serviceBindings/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single ServiceBinding.</summary>
                /// <param name="name">
                /// Required. A name of the ServiceBinding to get. Must be in the format
                /// `projects/*/locations/*/serviceBindings/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ServiceBinding.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ServiceBinding>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the ServiceBinding to get. Must be in the format
                    /// `projects/*/locations/*/serviceBindings/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists ServiceBinding in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the ServiceBindings should be listed, specified in the
                /// format `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists ServiceBinding in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListServiceBindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the ServiceBindings should be listed, specified in
                    /// the format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of ServiceBindings to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListServiceBindingsResponse` Indicates that this is a
                    /// continuation of a prior `ListRouters` call, and that the system should return the next page of
                    /// data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/serviceBindings";

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

                /// <summary>Updates the parameters of a single ServiceBinding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the ServiceBinding resource. It matches pattern
                /// `projects/*/locations/*/serviceBindings/`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.ServiceBinding body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single ServiceBinding.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.ServiceBinding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the ServiceBinding resource. It matches pattern
                    /// `projects/*/locations/*/serviceBindings/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the ServiceBinding
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.ServiceBinding Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceBindings/[^/]+$",
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

            /// <summary>Gets the ServiceLbPolicies resource.</summary>
            public virtual ServiceLbPoliciesResource ServiceLbPolicies { get; }

            /// <summary>The "serviceLbPolicies" collection of methods.</summary>
            public class ServiceLbPoliciesResource
            {
                private const string Resource = "serviceLbPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServiceLbPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new ServiceLbPolicy in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the ServiceLbPolicy. Must be in the format
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.ServiceLbPolicy body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new ServiceLbPolicy in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.ServiceLbPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the ServiceLbPolicy. Must be in the format
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Short name of the ServiceLbPolicy resource to be created. E.g. for resource name
                    /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`. the id is
                    /// value of {service_lb_policy_name}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceLbPolicyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceLbPolicyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.ServiceLbPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/serviceLbPolicies";

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
                        RequestParameters.Add("serviceLbPolicyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceLbPolicyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single ServiceLbPolicy.</summary>
                /// <param name="name">
                /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
                /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single ServiceLbPolicy.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the ServiceLbPolicy to delete. Must be in the format
                    /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceLbPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single ServiceLbPolicy.</summary>
                /// <param name="name">
                /// Required. A name of the ServiceLbPolicy to get. Must be in the format
                /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ServiceLbPolicy.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ServiceLbPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the ServiceLbPolicy to get. Must be in the format
                    /// `projects/{project}/locations/{location}/serviceLbPolicies/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceLbPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists ServiceLbPolicies in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the ServiceLbPolicies should be listed, specified in
                /// the format `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists ServiceLbPolicies in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListServiceLbPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the ServiceLbPolicies should be listed, specified
                    /// in the format `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of ServiceLbPolicies to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListServiceLbPoliciesResponse` Indicates that this is a
                    /// continuation of a prior `ListRouters` call, and that the system should return the next page of
                    /// data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/serviceLbPolicies";

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

                /// <summary>Updates the parameters of a single ServiceLbPolicy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the ServiceLbPolicy resource. It matches pattern
                /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.ServiceLbPolicy body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single ServiceLbPolicy.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.ServiceLbPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the ServiceLbPolicy resource. It matches pattern
                    /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the ServiceLbPolicy
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.ServiceLbPolicy Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/serviceLbPolicies/[^/]+$",
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

            /// <summary>Gets the TcpRoutes resource.</summary>
            public virtual TcpRoutesResource TcpRoutes { get; }

            /// <summary>The "tcpRoutes" collection of methods.</summary>
            public class TcpRoutesResource
            {
                private const string Resource = "tcpRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TcpRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new TcpRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the TcpRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.TcpRoute body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new TcpRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.TcpRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the TcpRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the TcpRoute resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tcpRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TcpRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.TcpRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/tcpRoutes";

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
                        RequestParameters.Add("tcpRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tcpRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single TcpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TcpRoute to delete. Must be in the format
                /// `projects/*/locations/global/tcpRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single TcpRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TcpRoute to delete. Must be in the format
                    /// `projects/*/locations/global/tcpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tcpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single TcpRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TcpRoute to get. Must be in the format
                /// `projects/*/locations/global/tcpRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single TcpRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.TcpRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TcpRoute to get. Must be in the format
                    /// `projects/*/locations/global/tcpRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tcpRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists TcpRoute in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the TcpRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists TcpRoute in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListTcpRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the TcpRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of TcpRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListTcpRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListTcpRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                    /// Otherwise if one of the locations is down or unreachable, the Aggregated List request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/tcpRoutes";

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

                /// <summary>Updates the parameters of a single TcpRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the TcpRoute resource. It matches pattern
                /// `projects/*/locations/global/tcpRoutes/tcp_route_name&amp;gt;`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.TcpRoute body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single TcpRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.TcpRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the TcpRoute resource. It matches pattern
                    /// `projects/*/locations/global/tcpRoutes/tcp_route_name&amp;gt;`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the TcpRoute resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.TcpRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tcpRoutes/[^/]+$",
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

            /// <summary>Gets the TlsRoutes resource.</summary>
            public virtual TlsRoutesResource TlsRoutes { get; }

            /// <summary>The "tlsRoutes" collection of methods.</summary>
            public class TlsRoutesResource
            {
                private const string Resource = "tlsRoutes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TlsRoutesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new TlsRoute in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the TlsRoute. Must be in the format `projects/*/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.TlsRoute body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new TlsRoute in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.TlsRoute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the TlsRoute. Must be in the format
                    /// `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Short name of the TlsRoute resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tlsRouteId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TlsRouteId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.TlsRoute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/tlsRoutes";

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
                        RequestParameters.Add("tlsRouteId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tlsRouteId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single TlsRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TlsRoute to delete. Must be in the format
                /// `projects/*/locations/global/tlsRoutes/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single TlsRoute.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TlsRoute to delete. Must be in the format
                    /// `projects/*/locations/global/tlsRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tlsRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single TlsRoute.</summary>
                /// <param name="name">
                /// Required. A name of the TlsRoute to get. Must be in the format
                /// `projects/*/locations/global/tlsRoutes/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single TlsRoute.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.TlsRoute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the TlsRoute to get. Must be in the format
                    /// `projects/*/locations/global/tlsRoutes/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tlsRoutes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists TlsRoute in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the TlsRoutes should be listed, specified in the
                /// format `projects/*/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists TlsRoute in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListTlsRoutesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the TlsRoutes should be listed, specified in the
                    /// format `projects/*/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of TlsRoutes to return per call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListTlsRoutesResponse` Indicates that this is a continuation of
                    /// a prior `ListTlsRoutes` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                    /// Otherwise if one of the locations is down or unreachable, the Aggregated List request will fail.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/tlsRoutes";

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

                /// <summary>Updates the parameters of a single TlsRoute.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the TlsRoute resource. It matches pattern
                /// `projects/*/locations/global/tlsRoutes/tls_route_name&amp;gt;`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.TlsRoute body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single TlsRoute.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.TlsRoute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the TlsRoute resource. It matches pattern
                    /// `projects/*/locations/global/tlsRoutes/tls_route_name&amp;gt;`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the TlsRoute resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.TlsRoute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/tlsRoutes/[^/]+$",
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

            /// <summary>Gets the WasmPlugins resource.</summary>
            public virtual WasmPluginsResource WasmPlugins { get; }

            /// <summary>The "wasmPlugins" collection of methods.</summary>
            public class WasmPluginsResource
            {
                private const string Resource = "wasmPlugins";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WasmPluginsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Versions = new VersionsResource(service);
                }

                /// <summary>Gets the Versions resource.</summary>
                public virtual VersionsResource Versions { get; }

                /// <summary>The "versions" collection of methods.</summary>
                public class VersionsResource
                {
                    private const string Resource = "versions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public VersionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new `WasmPluginVersion` resource in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource of the `WasmPluginVersion` resource. Must be in the format
                    /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.WasmPluginVersion body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new `WasmPluginVersion` resource in a given project and location.</summary>
                    public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.WasmPluginVersion body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource of the `WasmPluginVersion` resource. Must be in the format
                        /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. User-provided ID of the `WasmPluginVersion` resource to be created.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("wasmPluginVersionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WasmPluginVersionId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkServices.v1.Data.WasmPluginVersion Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/versions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/wasmPlugins/[^/]+$",
                            });
                            RequestParameters.Add("wasmPluginVersionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "wasmPluginVersionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified `WasmPluginVersion` resource.</summary>
                    /// <param name="name">
                    /// Required. A name of the `WasmPluginVersion` resource to delete. Must be in the format
                    /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified `WasmPluginVersion` resource.</summary>
                    public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A name of the `WasmPluginVersion` resource to delete. Must be in the format
                        /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/wasmPlugins/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of the specified `WasmPluginVersion` resource.</summary>
                    /// <param name="name">
                    /// Required. A name of the `WasmPluginVersion` resource to get. Must be in the format
                    /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified `WasmPluginVersion` resource.</summary>
                    public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.WasmPluginVersion>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. A name of the `WasmPluginVersion` resource to get. Must be in the format
                        /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/wasmPlugins/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists `WasmPluginVersion` resources in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The `WasmPlugin` resource whose `WasmPluginVersion`s are listed, specified in the
                    /// following format: `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists `WasmPluginVersion` resources in a given project and location.</summary>
                    public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListWasmPluginVersionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The `WasmPlugin` resource whose `WasmPluginVersion`s are listed, specified in the
                        /// following format: `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Maximum number of `WasmPluginVersion` resources to return per call. If not specified, at
                        /// most 50 `WasmPluginVersion` resources are returned. The maximum value is 1000; values above
                        /// 1000 are coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The value returned by the last `ListWasmPluginVersionsResponse` call. Indicates that this is
                        /// a continuation of a prior `ListWasmPluginVersions` call, and that the next page of data is
                        /// to be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/versions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/wasmPlugins/[^/]+$",
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

                /// <summary>Creates a new `WasmPlugin` resource in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the `WasmPlugin` resource. Must be in the format
                /// `projects/{project}/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkServices.v1.Data.WasmPlugin body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new `WasmPlugin` resource in a given project and location.</summary>
                public class CreateRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.WasmPlugin body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the `WasmPlugin` resource. Must be in the format
                    /// `projects/{project}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-provided ID of the `WasmPlugin` resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("wasmPluginId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WasmPluginId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.WasmPlugin Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/wasmPlugins";

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
                        RequestParameters.Add("wasmPluginId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "wasmPluginId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the specified `WasmPlugin` resource.</summary>
                /// <param name="name">
                /// Required. A name of the `WasmPlugin` resource to delete. Must be in the format
                /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the specified `WasmPlugin` resource.</summary>
                public class DeleteRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the `WasmPlugin` resource to delete. Must be in the format
                    /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/wasmPlugins/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of the specified `WasmPlugin` resource.</summary>
                /// <param name="name">
                /// Required. A name of the `WasmPlugin` resource to get. Must be in the format
                /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of the specified `WasmPlugin` resource.</summary>
                public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.WasmPlugin>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. A name of the `WasmPlugin` resource to get. Must be in the format
                    /// `projects/{project}/locations/global/wasmPlugins/{wasm_plugin}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Determines how much data must be returned in the response. See
                    /// [AIP-157](https://google.aip.dev/157).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Determines how much data must be returned in the response. See
                    /// [AIP-157](https://google.aip.dev/157).
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>Unspecified value. Do not use.</summary>
                        [Google.Apis.Util.StringValueAttribute("WASM_PLUGIN_VIEW_UNSPECIFIED")]
                        WASMPLUGINVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// If specified in the `GET` request for a `WasmPlugin` resource, the server's response
                        /// includes just the `WasmPlugin` resource.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("WASM_PLUGIN_VIEW_BASIC")]
                        WASMPLUGINVIEWBASIC = 1,

                        /// <summary>
                        /// If specified in the `GET` request for a `WasmPlugin` resource, the server's response
                        /// includes the `WasmPlugin` resource with all its versions.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("WASM_PLUGIN_VIEW_FULL")]
                        WASMPLUGINVIEWFULL = 2,
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/wasmPlugins/[^/]+$",
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

                /// <summary>Lists `WasmPlugin` resources in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The project and location from which the `WasmPlugin` resources are listed, specified in
                /// the following format: `projects/{project}/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists `WasmPlugin` resources in a given project and location.</summary>
                public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListWasmPluginsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which the `WasmPlugin` resources are listed, specified
                    /// in the following format: `projects/{project}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Maximum number of `WasmPlugin` resources to return per call. If not specified, at most 50
                    /// `WasmPlugin` resources are returned. The maximum value is 1000; values above 1000 are coerced to
                    /// 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListWasmPluginsResponse` call. Indicates that this is a
                    /// continuation of a prior `ListWasmPlugins` call, and that the next page of data is to be
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/wasmPlugins";

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

                /// <summary>Updates the parameters of the specified `WasmPlugin` resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the `WasmPlugin` resource in the following format:
                /// `projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkServices.v1.Data.WasmPlugin body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of the specified `WasmPlugin` resource.</summary>
                public class PatchRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkServices.v1.Data.WasmPlugin body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the `WasmPlugin` resource in the following format:
                    /// `projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Used to specify the fields to be overwritten in the `WasmPlugin` resource by the
                    /// update. The fields specified in the `update_mask` field are relative to the resource, not the
                    /// full request. An omitted `update_mask` field is treated as an implied `update_mask` field
                    /// equivalent to all fields that are populated (that have a non-empty value). The `update_mask`
                    /// field supports a special value `*`, which means that each field in the given `WasmPlugin`
                    /// resource (including the empty ones) replaces the current value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkServices.v1.Data.WasmPlugin Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/wasmPlugins/[^/]+$",
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.Location>
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
            public class ListRequest : NetworkServicesBaseServiceRequest<Google.Apis.NetworkServices.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.NetworkServices.v1.Data
{
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
    /// `AuthzExtension` is a resource that allows traffic forwarding to a callout backend service to make an
    /// authorization decision.
    /// </summary>
    public class AuthzExtension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The `:authority` header in the gRPC request sent from Envoy to the extension service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authority")]
        public virtual string Authority { get; set; }

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

        /// <summary>Optional. A human-readable description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Determines how the proxy behaves if the call to the extension fails or times out. When set to
        /// `TRUE`, request or response processing continues without error. Any subsequent extensions in the extension
        /// chain are also executed. When set to `FALSE` or the default setting of `FALSE` is used, one of the following
        /// happens: * If response headers have not been delivered to the downstream client, a generic 500 error is
        /// returned to the client. The error response can be tailored by configuring a custom error response in the
        /// load balancer. * If response headers have been delivered, then the HTTP stream to the downstream client is
        /// reset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failOpen")]
        public virtual System.Nullable<bool> FailOpen { get; set; }

        /// <summary>
        /// Optional. List of the HTTP headers to forward to the extension (from the client). If omitted, all headers
        /// are sent. Each element is a string indicating the header name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardHeaders")]
        public virtual System.Collections.Generic.IList<string> ForwardHeaders { get; set; }

        /// <summary>
        /// Optional. Set of labels associated with the `AuthzExtension` resource. The format must comply with [the
        /// requirements for labels](/compute/docs/labeling-resources#requirements) for Google Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. All backend services and forwarding rules referenced by this extension must share the same load
        /// balancing scheme. Supported values: `INTERNAL_MANAGED`, `EXTERNAL_MANAGED`. For more information, refer to
        /// [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancingScheme")]
        public virtual string LoadBalancingScheme { get; set; }

        /// <summary>
        /// Optional. The metadata provided here is included as part of the `metadata_context` (of type
        /// `google.protobuf.Struct`) in the `ProcessingRequest` message sent to the extension server. The metadata is
        /// available under the namespace `com.google.authz_extension.`. The following variables are supported in the
        /// metadata Struct: `{forwarding_rule_id}` - substituted with the forwarding rule's fully qualified resource
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Required. Identifier. Name of the `AuthzExtension` resource in the following format:
        /// `projects/{project}/locations/{location}/authzExtensions/{authz_extension}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The reference to the service that runs the extension. To configure a callout extension, `service`
        /// must be a fully-qualified reference to a [backend
        /// service](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices) in the format:
        /// `https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/backendServices/{backendService}`
        /// or `https://www.googleapis.com/compute/v1/projects/{project}/global/backendServices/{backendService}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Required. Specifies the timeout for each individual message on the stream. The timeout must be between
        /// 10-10000 milliseconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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
        /// Optional. The format of communication supported by the callout extension. If not specified, the default
        /// value `EXT_PROC_GRPC` is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wireFormat")]
        public virtual string WireFormat { get; set; }

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
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A definition of a matcher that selects endpoints to which the policies should be applied.</summary>
    public class EndpointMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The matcher is based on node metadata presented by xDS clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLabelMatcher")]
        public virtual EndpointMatcherMetadataLabelMatcher MetadataLabelMatcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The matcher that is based on node metadata presented by xDS clients.</summary>
    public class EndpointMatcherMetadataLabelMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies how matching should be done. Supported values are: MATCH_ANY: At least one of the Labels specified
        /// in the matcher should match the metadata presented by xDS client. MATCH_ALL: The metadata presented by the
        /// xDS client should contain all of the labels specified here. The selection is determined based on the best
        /// match. For example, suppose there are three EndpointPolicy resources P1, P2 and P3 and if P1 has a the
        /// matcher as MATCH_ANY , P2 has MATCH_ALL , and P3 has MATCH_ALL . If a client with label connects, the config
        /// from P1 will be selected. If a client with label connects, the config from P2 will be selected. If a client
        /// with label connects, the config from P3 will be selected. If there is more than one best match, (for
        /// example, if a config P4 with selector exists and if a client with label connects), pick up the one with
        /// older creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLabelMatchCriteria")]
        public virtual string MetadataLabelMatchCriteria { get; set; }

        /// <summary>
        /// The list of label value pairs that must match labels in the provided metadata based on filterMatchCriteria
        /// This list can have at most 64 entries. The list can be empty if the match criteria is MATCH_ANY, to specify
        /// a wildcard match (i.e this matches any client).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLabels")]
        public virtual System.Collections.Generic.IList<EndpointMatcherMetadataLabelMatcherMetadataLabels> MetadataLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a name-pair value for a single label.</summary>
    public class EndpointMatcherMetadataLabelMatcherMetadataLabels : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Label name presented as key in xDS Node Metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelName")]
        public virtual string LabelName { get; set; }

        /// <summary>
        /// Required. Label value presented as value corresponding to the above key, in xDS Node Metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelValue")]
        public virtual string LabelValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EndpointPolicy is a resource that helps apply desired configuration on the endpoints that match specific
    /// criteria. For example, this resource can be used to apply "authentication config" an all endpoints that serve on
    /// port 8080.
    /// </summary>
    public class EndpointPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This field specifies the URL of AuthorizationPolicy resource that applies authorization policies
        /// to the inbound traffic at the matched endpoints. Refer to Authorization. If this field is not specified,
        /// authorization is disabled(no authz checks) for this endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationPolicy")]
        public virtual string AuthorizationPolicy { get; set; }

        /// <summary>
        /// Optional. A URL referring to a ClientTlsPolicy resource. ClientTlsPolicy can be set to specify the
        /// authentication for traffic from the proxy to the actual endpoints. More specifically, it is applied to the
        /// outgoing traffic from the proxy to the endpoint. This is typically used for sidecar model where the proxy
        /// identifies itself as endpoint to the control plane, with the connection between sidecar and endpoint
        /// requiring authentication. If this field is not set, authentication is disabled(open). Applicable only when
        /// EndpointPolicyType is SIDECAR_PROXY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientTlsPolicy")]
        public virtual string ClientTlsPolicy { get; set; }

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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. A matcher that selects endpoints to which the policies should be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointMatcher")]
        public virtual EndpointMatcher EndpointMatcher { get; set; }

        /// <summary>Optional. Set of label tags associated with the EndpointPolicy resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the EndpointPolicy resource. It matches pattern
        /// `projects/{project}/locations/global/endpointPolicies/{endpoint_policy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. A URL referring to ServerTlsPolicy resource. ServerTlsPolicy is used to determine the
        /// authentication policy to be applied to terminate the inbound traffic at the identified backends. If this
        /// field is not set, authentication is disabled(open) for this endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverTlsPolicy")]
        public virtual string ServerTlsPolicy { get; set; }

        /// <summary>
        /// Optional. Port selector for the (matched) endpoints. If no port selector is provided, the matched config is
        /// applied to all ports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficPortSelector")]
        public virtual TrafficPortSelector TrafficPortSelector { get; set; }

        /// <summary>
        /// Required. The type of endpoint policy. This is primarily used to validate the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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
    /// A single extension chain wrapper that contains the match conditions and extensions to execute.
    /// </summary>
    public class ExtensionChain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A set of extensions to execute for the matching request. At least one extension is required. Up to
        /// 3 extensions can be defined for each extension chain for `LbTrafficExtension` resource. `LbRouteExtension`
        /// chains are limited to 1 extension per extension chain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<ExtensionChainExtension> Extensions { get; set; }

        /// <summary>Required. Conditions under which this chain is invoked for a request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchCondition")]
        public virtual ExtensionChainMatchCondition MatchCondition { get; set; }

        /// <summary>
        /// Required. The name for this extension chain. The name is logged as part of the HTTP request logs. The name
        /// must conform with RFC-1034, is restricted to lower-cased letters, numbers and hyphens, and can have a
        /// maximum length of 63 characters. Additionally, the first character must be a letter and the last a letter or
        /// a number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single extension in the chain to execute for the matching request.</summary>
    public class ExtensionChainExtension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The `:authority` header in the gRPC request sent from Envoy to the extension service. Required for
        /// Callout extensions. This field is not supported for plugin extensions. Setting it results in a validation
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authority")]
        public virtual string Authority { get; set; }

        /// <summary>
        /// Optional. Determines how the proxy behaves if the call to the extension fails or times out. When set to
        /// `TRUE`, request or response processing continues without error. Any subsequent extensions in the extension
        /// chain are also executed. When set to `FALSE` or the default setting of `FALSE` is used, one of the following
        /// happens: * If response headers have not been delivered to the downstream client, a generic 500 error is
        /// returned to the client. The error response can be tailored by configuring a custom error response in the
        /// load balancer. * If response headers have been delivered, then the HTTP stream to the downstream client is
        /// reset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failOpen")]
        public virtual System.Nullable<bool> FailOpen { get; set; }

        /// <summary>
        /// Optional. List of the HTTP headers to forward to the extension (from the client or backend). If omitted, all
        /// headers are sent. Each element is a string indicating the header name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardHeaders")]
        public virtual System.Collections.Generic.IList<string> ForwardHeaders { get; set; }

        /// <summary>
        /// Optional. The metadata provided here is included as part of the `metadata_context` (of type
        /// `google.protobuf.Struct`) in the `ProcessingRequest` message sent to the extension server. The metadata is
        /// available under the namespace `com.google....`. For example:
        /// `com.google.lb_traffic_extension.lbtrafficextension1.chain1.ext1`. The following variables are supported in
        /// the metadata: `{forwarding_rule_id}` - substituted with the forwarding rule's fully qualified resource name.
        /// This field must not be set for plugin extensions. Setting it results in a validation error. You can set
        /// metadata at either the resource level or the extension level. The extension level metadata is recommended
        /// because you can pass a different set of metadata through each extension to the backend. This field is
        /// subject to following limitations: * The total size of the metadata must be less than 1KiB. * The total
        /// number of keys in the metadata must be less than 16. * The length of each key must be less than 64
        /// characters. * The length of each value must be less than 1024 characters. * All values must be strings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Required. The name for this extension. The name is logged as part of the HTTP request logs. The name must
        /// conform with RFC-1034, is restricted to lower-cased letters, numbers and hyphens, and can have a maximum
        /// length of 63 characters. Additionally, the first character must be a letter and the last a letter or a
        /// number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The reference to the service that runs the extension. To configure a callout extension, `service`
        /// must be a fully-qualified reference to a [backend
        /// service](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices) in the format:
        /// `https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/backendServices/{backendService}`
        /// or `https://www.googleapis.com/compute/v1/projects/{project}/global/backendServices/{backendService}`. To
        /// configure a plugin extension, `service` must be a reference to a [`WasmPlugin`
        /// resource](https://cloud.google.com/service-extensions/docs/reference/rest/v1beta1/projects.locations.wasmPlugins)
        /// in the format: `projects/{project}/locations/{location}/wasmPlugins/{plugin}` or
        /// `//networkservices.googleapis.com/projects/{project}/locations/{location}/wasmPlugins/{wasmPlugin}`. Plugin
        /// extensions are currently supported for the `LbTrafficExtension` and the `LbRouteExtension` resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Optional. A set of events during request or response processing for which this extension is called. This
        /// field is required for the `LbTrafficExtension` resource. It is optional for the `LbRouteExtension` resource.
        /// If unspecified `REQUEST_HEADERS` event is assumed as supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedEvents")]
        public virtual System.Collections.Generic.IList<string> SupportedEvents { get; set; }

        /// <summary>
        /// Optional. Specifies the timeout for each individual message on the stream. The timeout must be between
        /// `10`-`10000` milliseconds. Required for callout extensions. This field is not supported for plugin
        /// extensions. Setting it results in a validation error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conditions under which this chain is invoked for a request.</summary>
    public class ExtensionChainMatchCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A Common Expression Language (CEL) expression that is used to match requests for which the
        /// extension chain is executed. For more information, see [CEL matcher language
        /// reference](https://cloud.google.com/service-extensions/docs/cel-matcher-language-reference).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("celExpression")]
        public virtual string CelExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Gateway represents the configuration for a proxy, typically a load balancer. It captures the ip:port over which
    /// the services are exposed by the proxy, along with any policy configurations. Routes have reference to to
    /// Gateways to dictate how requests should be routed by this Gateway.
    /// </summary>
    public class Gateway : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Zero or one IPv4 or IPv6 address on which the Gateway will receive the traffic. When no address is
        /// provided, an IP from the subnetwork is allocated This field only applies to gateways of type
        /// 'SECURE_WEB_GATEWAY'. Gateways of type 'OPEN_MESH' listen on 0.0.0.0 for IPv4 and :: for IPv6.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual System.Collections.Generic.IList<string> Addresses { get; set; }

        /// <summary>
        /// Optional. A fully-qualified Certificates URL reference. The proxy presents a Certificate (selected based on
        /// SNI) when establishing a TLS connection. This feature only applies to gateways of type 'SECURE_WEB_GATEWAY'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateUrls")]
        public virtual System.Collections.Generic.IList<string> CertificateUrls { get; set; }

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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Determines if envoy will insert internal debug headers into upstream requests. Other Envoy headers
        /// may still be injected. By default, envoy will not insert any debug headers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envoyHeaders")]
        public virtual string EnvoyHeaders { get; set; }

        /// <summary>
        /// Optional. A fully-qualified GatewaySecurityPolicy URL reference. Defines how a server should apply security
        /// policy to inbound (VM to Proxy) initiated connections. For example:
        /// `projects/*/locations/*/gatewaySecurityPolicies/swg-policy`. This policy is specific to gateways of type
        /// 'SECURE_WEB_GATEWAY'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewaySecurityPolicy")]
        public virtual string GatewaySecurityPolicy { get; set; }

        /// <summary>
        /// Optional. The IP Version that will be used by this gateway. Valid options are IPV4 or IPV6. Default is IPV4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipVersion")]
        public virtual string IpVersion { get; set; }

        /// <summary>Optional. Set of label tags associated with the Gateway resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the Gateway resource. It matches pattern `projects/*/locations/*/gateways/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The relative resource name identifying the VPC network that is using this configuration. For
        /// example: `projects/*/global/networks/network-1`. Currently, this field is specific to gateways of type
        /// 'SECURE_WEB_GATEWAY'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Required. One or more port numbers (1-65535), on which the Gateway will receive traffic. The proxy binds to
        /// the specified ports. Gateways of type 'SECURE_WEB_GATEWAY' are limited to 1 port. Gateways of type
        /// 'OPEN_MESH' listen on 0.0.0.0 for IPv4 and :: for IPv6 and support multiple ports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Ports { get; set; }

        /// <summary>
        /// Optional. The routing mode of the Gateway. This field is configurable only for gateways of type
        /// SECURE_WEB_GATEWAY. This field is required for gateways of type SECURE_WEB_GATEWAY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingMode")]
        public virtual string RoutingMode { get; set; }

        /// <summary>
        /// Optional. Scope determines how configuration across multiple Gateway instances are merged. The configuration
        /// for multiple Gateway instances with the same scope will be merged as presented as a single configuration to
        /// the proxy/load balancer. Max length 64 characters. Scope should start with a letter and can only have
        /// letters, numbers, hyphens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// Optional. A fully-qualified ServerTLSPolicy URL reference. Specifies how TLS traffic is terminated. If
        /// empty, TLS termination is disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverTlsPolicy")]
        public virtual string ServerTlsPolicy { get; set; }

        /// <summary>
        /// Optional. The relative resource name identifying the subnetwork in which this SWG is allocated. For example:
        /// `projects/*/regions/us-central1/subnetworks/network-1` Currently, this field is specific to gateways of type
        /// 'SECURE_WEB_GATEWAY".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// Immutable. The type of the customer managed gateway. This field is required. If unspecified, an error is
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>GatewayRouteView defines view-only resource for Routes to a Gateway</summary>
    public class GatewayRouteView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Identifier. Full path name of the GatewayRouteView resource. Format:
        /// projects/{project_number}/locations/{location}/gateways/{gateway_name}/routeViews/{route_view_name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The resource id for the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeId")]
        public virtual string RouteId { get; set; }

        /// <summary>Output only. Location where the route exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeLocation")]
        public virtual string RouteLocation { get; set; }

        /// <summary>Output only. Project number where the route exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeProjectNumber")]
        public virtual System.Nullable<long> RouteProjectNumber { get; set; }

        /// <summary>Output only. Type of the route: HttpRoute,GrpcRoute,TcpRoute, or TlsRoute</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeType")]
        public virtual string RouteType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GrpcRoute is the resource defining how gRPC traffic routed by a Mesh or Gateway resource is routed.
    /// </summary>
    public class GrpcRoute : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this GrpcRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>
        /// Required. Service hostnames with an optional port for which this route describes traffic. Format: [:]
        /// Hostname is the fully qualified domain name of a network host. This matches the RFC 1123 definition of a
        /// hostname with 2 notable exceptions: - IPs are not allowed. - A hostname may be prefixed with a wildcard
        /// label (`*.`). The wildcard label must appear by itself as the first label. Hostname can be "precise" which
        /// is a domain name without the terminating dot of a network host (e.g. `foo.example.com`) or "wildcard", which
        /// is a domain name prefixed with a single wildcard label (e.g. `*.example.com`). Note that as per RFC1035 and
        /// RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an
        /// alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateway must
        /// have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the
        /// configuration will be rejected. For example, while it is acceptable for routes for the hostnames
        /// `*.foo.bar.com` and `*.bar.com` to be associated with the same route, it is not possible to associate two
        /// routes both with `*.bar.com` or both with `bar.com`. If a port is specified, then gRPC clients must use the
        /// channel URI with the port to match this rule (i.e. "xds:///service:123"), otherwise they must supply the URI
        /// without a port (i.e. "xds:///service").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnames")]
        public virtual System.Collections.Generic.IList<string> Hostnames { get; set; }

        /// <summary>Optional. Set of label tags associated with the GrpcRoute resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this GrpcRoute is attached to, as one of the routing rules to
        /// route the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Identifier. Name of the GrpcRoute resource. It matches pattern `projects/*/locations/global/grpcRoutes/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. A list of detailed rules defining how to route traffic. Within a single GrpcRoute, the
        /// GrpcRoute.RouteAction associated with the first matching GrpcRoute.RouteRule will be executed. At least one
        /// rule must be supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GrpcRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>The destination to which traffic will be routed.</summary>
    public class GrpcRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The URL of a destination service to which to route traffic. Must refer to either a BackendService
        /// or ServiceDirectoryService.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Optional. Specifies the proportion of requests forwarded to the backend referenced by the serviceName field.
        /// This is computed as: - weight/Sum(weights in this destination list). For non-zero values, there may be some
        /// epsilon from the exact proportion defined here depending on the precision an implementation supports. If
        /// only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to
        /// that backend. If weights are specified for any one service name, they need to be specified for all of them.
        /// If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to destination
    /// service failure. As part of fault injection, when clients send requests to a destination, delays can be
    /// introduced on a percentage of requests before sending those requests to the destination service. Similarly
    /// requests from clients can be aborted by for a percentage of requests.
    /// </summary>
    public class GrpcRouteFaultInjectionPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specification for aborting to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abort")]
        public virtual GrpcRouteFaultInjectionPolicyAbort Abort { get; set; }

        /// <summary>The specification for injecting delay to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delay")]
        public virtual GrpcRouteFaultInjectionPolicyDelay Delay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are aborted as part of fault injection before being sent to a destination.
    /// </summary>
    public class GrpcRouteFaultInjectionPolicyAbort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpStatus")]
        public virtual System.Nullable<int> HttpStatus { get; set; }

        /// <summary>The percentage of traffic which will be aborted. The value must be between [0, 100]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are delayed as part of fault injection before being sent to a destination.
    /// </summary>
    public class GrpcRouteFaultInjectionPolicyDelay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specify a fixed delay before forwarding the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedDelay")]
        public virtual object FixedDelay { get; set; }

        /// <summary>
        /// The percentage of traffic on which delay will be injected. The value must be between [0, 100]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A match against a collection of headers.</summary>
    public class GrpcRouteHeaderMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The key of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Optional. Specifies how to match against the value of the header. If not specified, a default value of EXACT
        /// is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Required. The value of the header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a match against a method.</summary>
    public class GrpcRouteMethodMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies that matches are case sensitive. The default value is true. case_sensitive must not be
        /// used with a type of REGULAR_EXPRESSION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>Required. Name of the method to match against. If unspecified, will match all methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpcMethod")]
        public virtual string GrpcMethod { get; set; }

        /// <summary>Required. Name of the service to match against. If unspecified, will match all services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpcService")]
        public virtual string GrpcService { get; set; }

        /// <summary>
        /// Optional. Specifies how to match against the name. If not specified, a default value of "EXACT" is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specifications for retries. Specifies one or more conditions for which this retry rule applies. Valid values
    /// are:
    /// </summary>
    public class GrpcRouteRetryPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the allowed number of retries. This number must be &amp;gt; 0. If not specified, default to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numRetries")]
        public virtual System.Nullable<long> NumRetries { get; set; }

        /// <summary>
        /// - connect-failure: Router will retry on failures connecting to Backend Services, for example due to
        /// connection timeouts. - refused-stream: Router will retry if the backend service resets the stream with a
        /// REFUSED_STREAM error code. This reset type indicates that it is safe to retry. - cancelled: Router will
        /// retry if the gRPC status code in the response header is set to cancelled - deadline-exceeded: Router will
        /// retry if the gRPC status code in the response header is set to deadline-exceeded - resource-exhausted:
        /// Router will retry if the gRPC status code in the response header is set to resource-exhausted - unavailable:
        /// Router will retry if the gRPC status code in the response header is set to unavailable
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryConditions")]
        public virtual System.Collections.Generic.IList<string> RetryConditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to route matched traffic.</summary>
    public class GrpcRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The destination services to which traffic should be forwarded. If multiple destinations are
        /// specified, traffic will be split between Backend Service(s) according to the weight field of these
        /// destinations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<GrpcRouteDestination> Destinations { get; set; }

        /// <summary>
        /// Optional. The specification for fault injection introduced into traffic to test the resiliency of clients to
        /// destination service failure. As part of fault injection, when clients send requests to a destination, delays
        /// can be introduced on a percentage of requests before sending those requests to the destination service.
        /// Similarly requests from clients can be aborted by for a percentage of requests. timeout and retry_policy
        /// will be ignored by clients that are configured with a fault_injection_policy
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faultInjectionPolicy")]
        public virtual GrpcRouteFaultInjectionPolicy FaultInjectionPolicy { get; set; }

        /// <summary>
        /// Optional. Specifies the idle timeout for the selected route. The idle timeout is defined as the period in
        /// which there are no bytes sent or received on either the upstream or downstream connection. If not set, the
        /// default idle timeout is 1 hour. If set to 0s, the timeout will be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleTimeout")]
        public virtual object IdleTimeout { get; set; }

        /// <summary>Optional. Specifies the retry policy associated with this route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual GrpcRouteRetryPolicy RetryPolicy { get; set; }

        /// <summary>Optional. Specifies cookie-based stateful session affinity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statefulSessionAffinity")]
        public virtual GrpcRouteStatefulSessionAffinityPolicy StatefulSessionAffinity { get; set; }

        /// <summary>
        /// Optional. Specifies the timeout for selected route. Timeout is computed from the time the request has been
        /// fully processed (i.e. end of stream) up until the response has been completely processed. Timeout includes
        /// all retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Criteria for matching traffic. A RouteMatch will be considered to match when all supplied fields match.
    /// </summary>
    public class GrpcRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies a collection of headers to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<GrpcRouteHeaderMatch> Headers { get; set; }

        /// <summary>
        /// Optional. A gRPC method to match against. If this field is empty or omitted, will match all methods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual GrpcRouteMethodMatch Method { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes how to route traffic.</summary>
    public class GrpcRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A detailed rule defining how to route traffic. This field is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual GrpcRouteRouteAction Action { get; set; }

        /// <summary>
        /// Optional. Matches define conditions used for matching the rule against incoming gRPC requests. Each match is
        /// independent, i.e. this rule will be matched if ANY one of the matches is satisfied. If no matches field is
        /// specified, this rule will unconditionally match traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<GrpcRouteRouteMatch> Matches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for cookie-based stateful session affinity where the date plane supplies a “session cookie”
    /// with the name "GSSA" which encodes a specific destination host and each request containing that cookie will be
    /// directed to that host as long as the destination host remains up and healthy. The gRPC proxyless mesh library or
    /// sidecar proxy will manage the session cookie but the client application code is responsible for copying the
    /// cookie from each RPC in the session to the next.
    /// </summary>
    public class GrpcRouteStatefulSessionAffinityPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The cookie TTL value for the Set-Cookie header generated by the data plane. The lifetime of the
        /// cookie may be set to a value from 0 to 86400 seconds (24 hours) inclusive. Set this to 0s to use a session
        /// cookie and disable cookie expiration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieTtl")]
        public virtual object CookieTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// HttpRoute is the resource defining how HTTP traffic should be routed by a Mesh or Gateway resource.
    /// </summary>
    public class HttpRoute : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>
        /// Required. Hostnames define a set of hosts that should match against the HTTP host header to select a
        /// HttpRoute to process the request. Hostname is the fully qualified domain name of a network host, as defined
        /// by RFC 1123 with the exception that: - IPs are not allowed. - A hostname may be prefixed with a wildcard
        /// label (`*.`). The wildcard label must appear by itself as the first label. Hostname can be "precise" which
        /// is a domain name without the terminating dot of a network host (e.g. `foo.example.com`) or "wildcard", which
        /// is a domain name prefixed with a single wildcard label (e.g. `*.example.com`). Note that as per RFC1035 and
        /// RFC1123, a label must consist of lower case alphanumeric characters or '-', and must start and end with an
        /// alphanumeric character. No other punctuation is allowed. The routes associated with a Mesh or Gateways must
        /// have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the
        /// configuration will be rejected. For example, while it is acceptable for routes for the hostnames
        /// `*.foo.bar.com` and `*.bar.com` to be associated with the same Mesh (or Gateways under the same scope), it
        /// is not possible to associate two routes both with `*.bar.com` or both with `bar.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnames")]
        public virtual System.Collections.Generic.IList<string> Hostnames { get; set; }

        /// <summary>Optional. Set of label tags associated with the HttpRoute resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to
        /// route the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Identifier. Name of the HttpRoute resource. It matches pattern
        /// `projects/*/locations/global/httpRoutes/http_route_name&amp;gt;`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Rules that define how traffic is routed and handled. Rules will be matched sequentially based on
        /// the RouteMatch specified for the rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<HttpRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>The Specification for allowing client side cross-origin requests.</summary>
    public class HttpRouteCorsPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In response to a preflight request, setting this to true indicates that the actual request can include user
        /// credentials. This translates to the Access-Control-Allow-Credentials header. Default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCredentials")]
        public virtual System.Nullable<bool> AllowCredentials { get; set; }

        /// <summary>Specifies the content for Access-Control-Allow-Headers header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowHeaders")]
        public virtual System.Collections.Generic.IList<string> AllowHeaders { get; set; }

        /// <summary>Specifies the content for Access-Control-Allow-Methods header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMethods")]
        public virtual System.Collections.Generic.IList<string> AllowMethods { get; set; }

        /// <summary>
        /// Specifies the regular expression patterns that match allowed origins. For regular expression grammar, please
        /// see https://github.com/google/re2/wiki/Syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOriginRegexes")]
        public virtual System.Collections.Generic.IList<string> AllowOriginRegexes { get; set; }

        /// <summary>
        /// Specifies the list of origins that will be allowed to do CORS requests. An origin is allowed if it matches
        /// either an item in allow_origins or an item in allow_origin_regexes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOrigins")]
        public virtual System.Collections.Generic.IList<string> AllowOrigins { get; set; }

        /// <summary>
        /// If true, the CORS policy is disabled. The default value is false, which indicates that the CORS policy is in
        /// effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Specifies the content for Access-Control-Expose-Headers header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposeHeaders")]
        public virtual System.Collections.Generic.IList<string> ExposeHeaders { get; set; }

        /// <summary>
        /// Specifies how long result of a preflight request can be cached in seconds. This translates to the
        /// Access-Control-Max-Age header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAge")]
        public virtual string MaxAge { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifications of a destination to which the request should be routed to.</summary>
    public class HttpRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The specification for modifying the headers of a matching request prior to delivery of the request
        /// to the destination. If HeaderModifiers are set on both the Destination and the RouteAction, they will be
        /// merged. Conflicts between the two will not be resolved on the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestHeaderModifier")]
        public virtual HttpRouteHeaderModifier RequestHeaderModifier { get; set; }

        /// <summary>
        /// Optional. The specification for modifying the headers of a response prior to sending the response back to
        /// the client. If HeaderModifiers are set on both the Destination and the RouteAction, they will be merged.
        /// Conflicts between the two will not be resolved on the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseHeaderModifier")]
        public virtual HttpRouteHeaderModifier ResponseHeaderModifier { get; set; }

        /// <summary>The URL of a BackendService to route traffic to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is
        /// computed as: - weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon
        /// from the exact proportion defined here depending on the precision an implementation supports. If only one
        /// serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that
        /// backend. If weights are specified for any one service name, they need to be specified for all of them. If
        /// weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to destination
    /// service failure. As part of fault injection, when clients send requests to a destination, delays can be
    /// introduced by client proxy on a percentage of requests before sending those requests to the destination service.
    /// Similarly requests can be aborted by client proxy for a percentage of requests.
    /// </summary>
    public class HttpRouteFaultInjectionPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specification for aborting to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abort")]
        public virtual HttpRouteFaultInjectionPolicyAbort Abort { get; set; }

        /// <summary>The specification for injecting delay to client requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delay")]
        public virtual HttpRouteFaultInjectionPolicyDelay Delay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are aborted as part of fault injection before being sent to a destination.
    /// </summary>
    public class HttpRouteFaultInjectionPolicyAbort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpStatus")]
        public virtual System.Nullable<int> HttpStatus { get; set; }

        /// <summary>The percentage of traffic which will be aborted. The value must be between [0, 100]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of how client requests are delayed as part of fault injection before being sent to a destination.
    /// </summary>
    public class HttpRouteFaultInjectionPolicyDelay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specify a fixed delay before forwarding the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedDelay")]
        public virtual object FixedDelay { get; set; }

        /// <summary>
        /// The percentage of traffic on which delay will be injected. The value must be between [0, 100]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to select a route rule based on HTTP request headers.</summary>
    public class HttpRouteHeaderMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of the header should match exactly the content of exact_match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactMatch")]
        public virtual string ExactMatch { get; set; }

        /// <summary>The name of the HTTP header to match against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// If specified, the match result will be inverted before checking. Default value is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertMatch")]
        public virtual System.Nullable<bool> InvertMatch { get; set; }

        /// <summary>The value of the header must start with the contents of prefix_match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixMatch")]
        public virtual string PrefixMatch { get; set; }

        /// <summary>
        /// A header with header_name must exist. The match takes place whether or not the header has a value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentMatch")]
        public virtual System.Nullable<bool> PresentMatch { get; set; }

        /// <summary>If specified, the rule will match if the request header value is within the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeMatch")]
        public virtual HttpRouteHeaderMatchIntegerRange RangeMatch { get; set; }

        /// <summary>
        /// The value of the header must match the regular expression specified in regex_match. For regular expression
        /// grammar, please see: https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexMatch")]
        public virtual string RegexMatch { get; set; }

        /// <summary>The value of the header must end with the contents of suffix_match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffixMatch")]
        public virtual string SuffixMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an integer value range.</summary>
    public class HttpRouteHeaderMatchIntegerRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of the range (exclusive)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<int> End { get; set; }

        /// <summary>Start of the range (inclusive)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<int> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification for modifying HTTP header in HTTP request and HTTP response.</summary>
    public class HttpRouteHeaderModifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Add the headers with given map where key is the name of the header, value is the value of the header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("add")]
        public virtual System.Collections.Generic.IDictionary<string, string> Add { get; set; }

        /// <summary>Remove headers (matching by header names) specified in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remove")]
        public virtual System.Collections.Generic.IList<string> Remove { get; set; }

        /// <summary>
        /// Completely overwrite/replace the headers with given map where key is the name of the header, value is the
        /// value of the header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("set")]
        public virtual System.Collections.Generic.IDictionary<string, string> Set { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Static HTTP response object to be returned.</summary>
    public class HttpRouteHttpDirectResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Response body as bytes. Maximum body size is 4096B.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesBody")]
        public virtual string BytesBody { get; set; }

        /// <summary>Required. Status to return as part of HTTP Response. Must be a positive integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<int> Status { get; set; }

        /// <summary>Optional. Response body as a string. Maximum body length is 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringBody")]
        public virtual string StringBody { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifications to match a query parameter in the request.</summary>
    public class HttpRouteQueryParameterMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value of the query parameter must exactly match the contents of exact_match. Only one of exact_match,
        /// regex_match, or present_match must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exactMatch")]
        public virtual string ExactMatch { get; set; }

        /// <summary>
        /// Specifies that the QueryParameterMatcher matches if request contains query parameter, irrespective of
        /// whether the parameter has a value or not. Only one of exact_match, regex_match, or present_match must be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentMatch")]
        public virtual System.Nullable<bool> PresentMatch { get; set; }

        /// <summary>The name of the query parameter to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameter")]
        public virtual string QueryParameter { get; set; }

        /// <summary>
        /// The value of the query parameter must match the regular expression specified by regex_match. For regular
        /// expression grammar, please see https://github.com/google/re2/wiki/Syntax Only one of exact_match,
        /// regex_match, or present_match must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexMatch")]
        public virtual string RegexMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification for redirecting traffic.</summary>
    public class HttpRouteRedirect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The host that will be used in the redirect response instead of the one that was supplied in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostRedirect")]
        public virtual string HostRedirect { get; set; }

        /// <summary>
        /// If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of
        /// the redirected request will remain the same as that of the request. The default is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpsRedirect")]
        public virtual System.Nullable<bool> HttpsRedirect { get; set; }

        /// <summary>
        /// The path that will be used in the redirect response instead of the one that was supplied in the request.
        /// path_redirect can not be supplied together with prefix_redirect. Supply one alone or neither. If neither is
        /// supplied, the path of the original request will be used for the redirect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathRedirect")]
        public virtual string PathRedirect { get; set; }

        /// <summary>
        /// The port that will be used in the redirected request instead of the one that was supplied in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portRedirect")]
        public virtual System.Nullable<int> PortRedirect { get; set; }

        /// <summary>
        /// Indicates that during redirection, the matched prefix (or path) should be swapped with this value. This
        /// option allows URLs be dynamically created based on the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixRewrite")]
        public virtual string PrefixRewrite { get; set; }

        /// <summary>The HTTP Status code to use for the redirect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseCode")]
        public virtual string ResponseCode { get; set; }

        /// <summary>
        /// if set to true, any accompanying query portion of the original URL is removed prior to redirecting the
        /// request. If set to false, the query portion of the original URL is retained. The default is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stripQuery")]
        public virtual System.Nullable<bool> StripQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the policy on how requests are shadowed to a separate mirrored destination service. The proxy does not
    /// wait for responses from the shadow service. Prior to sending traffic to the shadow service, the host/authority
    /// header is suffixed with -shadow.
    /// </summary>
    public class HttpRouteRequestMirrorPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The destination the requests will be mirrored to. The weight of the destination will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual HttpRouteDestination Destination { get; set; }

        /// <summary>Optional. The percentage of requests to get mirrored to the desired destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mirrorPercent")]
        public virtual System.Nullable<float> MirrorPercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications for retries.</summary>
    public class HttpRouteRetryPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the allowed number of retries. This number must be &amp;gt; 0. If not specified, default to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numRetries")]
        public virtual System.Nullable<int> NumRetries { get; set; }

        /// <summary>Specifies a non-zero timeout per retry attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perTryTimeout")]
        public virtual object PerTryTimeout { get; set; }

        /// <summary>
        /// Specifies one or more conditions when this retry policy applies. Valid values are: 5xx: Proxy will attempt a
        /// retry if the destination service responds with any 5xx response code, of if the destination service does not
        /// respond at all, example: disconnect, reset, read timeout, connection failure and refused streams.
        /// gateway-error: Similar to 5xx, but only applies to response codes 502, 503, 504. reset: Proxy will attempt a
        /// retry if the destination service does not respond at all (disconnect/reset/read timeout) connect-failure:
        /// Proxy will retry on failures connecting to destination for example due to connection timeouts.
        /// retriable-4xx: Proxy will retry fro retriable 4xx response codes. Currently the only retriable error
        /// supported is 409. refused-stream: Proxy will retry if the destination resets the stream with a
        /// REFUSED_STREAM error code. This reset type indicates that it is safe to retry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryConditions")]
        public virtual System.Collections.Generic.IList<string> RetryConditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications for routing traffic and applying associated policies.</summary>
    public class HttpRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specification for allowing client side cross-origin requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corsPolicy")]
        public virtual HttpRouteCorsPolicy CorsPolicy { get; set; }

        /// <summary>The destination to which traffic should be forwarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<HttpRouteDestination> Destinations { get; set; }

        /// <summary>Optional. Static HTTP Response object to be returned regardless of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directResponse")]
        public virtual HttpRouteHttpDirectResponse DirectResponse { get; set; }

        /// <summary>
        /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend
        /// service failure. As part of fault injection, when clients send requests to a backend service, delays can be
        /// introduced on a percentage of requests before sending those requests to the backend service. Similarly
        /// requests from clients can be aborted for a percentage of requests. timeout and retry_policy will be ignored
        /// by clients that are configured with a fault_injection_policy
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faultInjectionPolicy")]
        public virtual HttpRouteFaultInjectionPolicy FaultInjectionPolicy { get; set; }

        /// <summary>
        /// Optional. Specifies the idle timeout for the selected route. The idle timeout is defined as the period in
        /// which there are no bytes sent or received on either the upstream or downstream connection. If not set, the
        /// default idle timeout is 1 hour. If set to 0s, the timeout will be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleTimeout")]
        public virtual object IdleTimeout { get; set; }

        /// <summary>If set, the request is directed as configured by this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirect")]
        public virtual HttpRouteRedirect Redirect { get; set; }

        /// <summary>
        /// The specification for modifying the headers of a matching request prior to delivery of the request to the
        /// destination. If HeaderModifiers are set on both the Destination and the RouteAction, they will be merged.
        /// Conflicts between the two will not be resolved on the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestHeaderModifier")]
        public virtual HttpRouteHeaderModifier RequestHeaderModifier { get; set; }

        /// <summary>
        /// Specifies the policy on how requests intended for the routes destination are shadowed to a separate mirrored
        /// destination. Proxy will not wait for the shadow destination to respond before returning the response. Prior
        /// to sending traffic to the shadow service, the host/authority header is suffixed with -shadow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMirrorPolicy")]
        public virtual HttpRouteRequestMirrorPolicy RequestMirrorPolicy { get; set; }

        /// <summary>
        /// The specification for modifying the headers of a response prior to sending the response back to the client.
        /// If HeaderModifiers are set on both the Destination and the RouteAction, they will be merged. Conflicts
        /// between the two will not be resolved on the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseHeaderModifier")]
        public virtual HttpRouteHeaderModifier ResponseHeaderModifier { get; set; }

        /// <summary>Specifies the retry policy associated with this route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual HttpRouteRetryPolicy RetryPolicy { get; set; }

        /// <summary>Optional. Specifies cookie-based stateful session affinity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statefulSessionAffinity")]
        public virtual HttpRouteStatefulSessionAffinityPolicy StatefulSessionAffinity { get; set; }

        /// <summary>
        /// Specifies the timeout for selected route. Timeout is computed from the time the request has been fully
        /// processed (i.e. end of stream) up until the response has been completely processed. Timeout includes all
        /// retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The specification for rewrite URL before forwarding requests to the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlRewrite")]
        public virtual HttpRouteURLRewrite UrlRewrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RouteMatch defines specifications used to match requests. If multiple match types are set, this RouteMatch will
    /// match if ALL type of matches are matched.
    /// </summary>
    public class HttpRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The HTTP request path value should exactly match this value. Only one of full_path_match, prefix_match, or
        /// regex_match should be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullPathMatch")]
        public virtual string FullPathMatch { get; set; }

        /// <summary>
        /// Specifies a list of HTTP request headers to match against. ALL of the supplied headers must be matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<HttpRouteHeaderMatch> Headers { get; set; }

        /// <summary>
        /// Specifies if prefix_match and full_path_match matches are case sensitive. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreCase")]
        public virtual System.Nullable<bool> IgnoreCase { get; set; }

        /// <summary>
        /// The HTTP request path value must begin with specified prefix_match. prefix_match must begin with a /. Only
        /// one of full_path_match, prefix_match, or regex_match should be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixMatch")]
        public virtual string PrefixMatch { get; set; }

        /// <summary>
        /// Specifies a list of query parameters to match against. ALL of the query parameters must be matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual System.Collections.Generic.IList<HttpRouteQueryParameterMatch> QueryParameters { get; set; }

        /// <summary>
        /// The HTTP request path value must satisfy the regular expression specified by regex_match after removing any
        /// query parameters and anchor supplied with the original URL. For regular expression grammar, please see
        /// https://github.com/google/re2/wiki/Syntax Only one of full_path_match, prefix_match, or regex_match should
        /// be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexMatch")]
        public virtual string RegexMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to match traffic and how to route traffic when traffic is matched.</summary>
    public class HttpRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed rule defining how to route matched traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual HttpRouteRouteAction Action { get; set; }

        /// <summary>
        /// A list of matches define conditions used for matching the rule against incoming HTTP requests. Each match is
        /// independent, i.e. this rule will be matched if ANY one of the matches is satisfied. If no matches field is
        /// specified, this rule will unconditionally match traffic. If a default rule is desired to be configured, add
        /// a rule with no matches specified to the end of the rules list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<HttpRouteRouteMatch> Matches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for cookie-based stateful session affinity where the date plane supplies a “session cookie”
    /// with the name "GSSA" which encodes a specific destination host and each request containing that cookie will be
    /// directed to that host as long as the destination host remains up and healthy. The gRPC proxyless mesh library or
    /// sidecar proxy will manage the session cookie but the client application code is responsible for copying the
    /// cookie from each RPC in the session to the next.
    /// </summary>
    public class HttpRouteStatefulSessionAffinityPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The cookie TTL value for the Set-Cookie header generated by the data plane. The lifetime of the
        /// cookie may be set to a value from 0 to 86400 seconds (24 hours) inclusive. Set this to 0s to use a session
        /// cookie and disable cookie expiration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieTtl")]
        public virtual object CookieTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification for modifying the URL of the request, prior to forwarding the request to the destination.
    /// </summary>
    public class HttpRouteURLRewrite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Prior to forwarding the request to the selected destination, the requests host header is replaced by this
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostRewrite")]
        public virtual string HostRewrite { get; set; }

        /// <summary>
        /// Prior to forwarding the request to the selected destination, the matching portion of the requests path is
        /// replaced by this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathPrefixRewrite")]
        public virtual string PathPrefixRewrite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `LbRouteExtension` is a resource that lets you control where traffic is routed to for a given request.
    /// </summary>
    public class LbRouteExtension : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A human-readable description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. A set of ordered extension chains that contain the match conditions and extensions to execute.
        /// Match conditions for each extension chain are evaluated in sequence for a given request. The first extension
        /// chain that has a condition that matches the request is executed. Any subsequent extension chains do not
        /// execute. Limited to 5 extension chains per resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensionChains")]
        public virtual System.Collections.Generic.IList<ExtensionChain> ExtensionChains { get; set; }

        /// <summary>
        /// Required. A list of references to the forwarding rules to which this service extension is attached. At least
        /// one forwarding rule is required. Only one `LbRouteExtension` resource can be associated with a forwarding
        /// rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRules")]
        public virtual System.Collections.Generic.IList<string> ForwardingRules { get; set; }

        /// <summary>
        /// Optional. Set of labels associated with the `LbRouteExtension` resource. The format must comply with [the
        /// requirements for labels](https://cloud.google.com/compute/docs/labeling-resources#requirements) for Google
        /// Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. All backend services and forwarding rules referenced by this extension must share the same load
        /// balancing scheme. Supported values: `INTERNAL_MANAGED`, `EXTERNAL_MANAGED`. For more information, refer to
        /// [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancingScheme")]
        public virtual string LoadBalancingScheme { get; set; }

        /// <summary>
        /// Optional. The metadata provided here is included as part of the `metadata_context` (of type
        /// `google.protobuf.Struct`) in the `ProcessingRequest` message sent to the extension server. The metadata
        /// applies to all extensions in all extensions chains in this resource. The metadata is available under the key
        /// `com.google.lb_route_extension.`. The following variables are supported in the metadata:
        /// `{forwarding_rule_id}` - substituted with the forwarding rule's fully qualified resource name. This field
        /// must not be set if at least one of the extension chains contains plugin extensions. Setting it results in a
        /// validation error. You can set metadata at either the resource level or the extension level. The extension
        /// level metadata is recommended because you can pass a different set of metadata through each extension to the
        /// backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Required. Identifier. Name of the `LbRouteExtension` resource in the following format:
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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
    /// `LbTrafficExtension` is a resource that lets the extension service modify the headers and payloads of both
    /// requests and responses without impacting the choice of backend services or any other security policies
    /// associated with the backend service.
    /// </summary>
    public class LbTrafficExtension : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A human-readable description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. A set of ordered extension chains that contain the match conditions and extensions to execute.
        /// Match conditions for each extension chain are evaluated in sequence for a given request. The first extension
        /// chain that has a condition that matches the request is executed. Any subsequent extension chains do not
        /// execute. Limited to 5 extension chains per resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensionChains")]
        public virtual System.Collections.Generic.IList<ExtensionChain> ExtensionChains { get; set; }

        /// <summary>
        /// Optional. A list of references to the forwarding rules to which this service extension is attached. At least
        /// one forwarding rule is required. Only one `LbTrafficExtension` resource can be associated with a forwarding
        /// rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRules")]
        public virtual System.Collections.Generic.IList<string> ForwardingRules { get; set; }

        /// <summary>
        /// Optional. Set of labels associated with the `LbTrafficExtension` resource. The format must comply with [the
        /// requirements for labels](https://cloud.google.com/compute/docs/labeling-resources#requirements) for Google
        /// Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. All backend services and forwarding rules referenced by this extension must share the same load
        /// balancing scheme. Supported values: `INTERNAL_MANAGED` and `EXTERNAL_MANAGED`. For more information, refer
        /// to [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancingScheme")]
        public virtual string LoadBalancingScheme { get; set; }

        /// <summary>
        /// Optional. The metadata provided here is included as part of the `metadata_context` (of type
        /// `google.protobuf.Struct`) in the `ProcessingRequest` message sent to the extension server. The metadata
        /// applies to all extensions in all extensions chains in this resource. The metadata is available under the key
        /// `com.google.lb_traffic_extension.`. The following variables are supported in the metadata:
        /// `{forwarding_rule_id}` - substituted with the forwarding rule's fully qualified resource name. This field
        /// must not be set if at least one of the extension chains contains plugin extensions. Setting it results in a
        /// validation error. You can set metadata at either the resource level or the extension level. The extension
        /// level metadata is recommended because you can pass a different set of metadata through each extension to the
        /// backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Required. Identifier. Name of the `LbTrafficExtension` resource in the following format:
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>Message for response to listing `AuthzExtension` resources.</summary>
    public class ListAuthzExtensionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of `AuthzExtension` resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authzExtensions")]
        public virtual System.Collections.Generic.IList<AuthzExtension> AuthzExtensions { get; set; }

        /// <summary>A token identifying a page of results that the server returns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListEndpointPolicies method.</summary>
    public class ListEndpointPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of EndpointPolicy resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointPolicies")]
        public virtual System.Collections.Generic.IList<EndpointPolicy> EndpointPolicies { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request opts into return_partial_success and reading across
        /// collections e.g. when attempting to list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListGatewayRouteViews method.</summary>
    public class ListGatewayRouteViewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GatewayRouteView resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayRouteViews")]
        public virtual System.Collections.Generic.IList<GatewayRouteView> GatewayRouteViews { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request attempts to list all resources across all supported
        /// locations, while some locations are temporarily unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListGateways method.</summary>
    public class ListGatewaysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Gateway resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<Gateway> Gateways { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListGrpcRoutes method.</summary>
    public class ListGrpcRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GrpcRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpcRoutes")]
        public virtual System.Collections.Generic.IList<GrpcRoute> GrpcRoutes { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request opts into return_partial_success and reading across
        /// collections e.g. when attempting to list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListHttpRoutes method.</summary>
    public class ListHttpRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of HttpRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRoutes")]
        public virtual System.Collections.Generic.IList<HttpRoute> HttpRoutes { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request opts into return_partial_success and reading across
        /// collections e.g. when attempting to list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing `LbRouteExtension` resources.</summary>
    public class ListLbRouteExtensionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of `LbRouteExtension` resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lbRouteExtensions")]
        public virtual System.Collections.Generic.IList<LbRouteExtension> LbRouteExtensions { get; set; }

        /// <summary>A token identifying a page of results that the server returns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing `LbTrafficExtension` resources.</summary>
    public class ListLbTrafficExtensionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of `LbTrafficExtension` resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lbTrafficExtensions")]
        public virtual System.Collections.Generic.IList<LbTrafficExtension> LbTrafficExtensions { get; set; }

        /// <summary>A token identifying a page of results that the server returns.</summary>
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

    /// <summary>Response returned by the ListMeshRouteViews method.</summary>
    public class ListMeshRouteViewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of MeshRouteView resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshRouteViews")]
        public virtual System.Collections.Generic.IList<MeshRouteView> MeshRouteViews { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request attempts to list all resources across all supported
        /// locations, while some locations are temporarily unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListMeshes method.</summary>
    public class ListMeshesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Mesh resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<Mesh> Meshes { get; set; }

        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request opts into `return_partial_success` and reading across
        /// collections e.g. when attempting to list all resources across all supported locations.
        /// </summary>
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

    /// <summary>Response returned by the ListServiceBindings method.</summary>
    public class ListServiceBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of ServiceBinding resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceBindings")]
        public virtual System.Collections.Generic.IList<ServiceBinding> ServiceBindings { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request attempts to list all resources across all supported
        /// locations, while some locations are temporarily unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListServiceLbPolicies method.</summary>
    public class ListServiceLbPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of ServiceLbPolicy resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLbPolicies")]
        public virtual System.Collections.Generic.IList<ServiceLbPolicy> ServiceLbPolicies { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request attempts to list all resources across all supported
        /// locations, while some locations are temporarily unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListTcpRoutes method.</summary>
    public class ListTcpRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of TcpRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpRoutes")]
        public virtual System.Collections.Generic.IList<TcpRoute> TcpRoutes { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request opts into return_partial_success and reading across
        /// collections e.g. when attempting to list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the ListTlsRoutes method.</summary>
    public class ListTlsRoutesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of TlsRoute resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsRoutes")]
        public virtual System.Collections.Generic.IList<TlsRoute> TlsRoutes { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request opts into return_partial_success and reading across
        /// collections e.g. when attempting to list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the `ListWasmPluginVersions` method.</summary>
    public class ListWasmPluginVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request attempts to list all resources across all supported
        /// locations, while some locations are temporarily unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of `WasmPluginVersion` resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wasmPluginVersions")]
        public virtual System.Collections.Generic.IList<WasmPluginVersion> WasmPluginVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response returned by the `ListWasmPlugins` method.</summary>
    public class ListWasmPluginsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there might be more results than those appearing in this response, then `next_page_token` is included. To
        /// get the next set of results, call this method again using the value of `next_page_token` as `page_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable resources. Populated when the request attempts to list all resources across all supported
        /// locations, while some locations are temporarily unavailable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of `WasmPlugin` resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wasmPlugins")]
        public virtual System.Collections.Generic.IList<WasmPlugin> WasmPlugins { get; set; }

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

    /// <summary>The configuration for Platform Telemetry logging for Eventarc Advanced resources.</summary>
    public class LoggingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The minimum severity of logs that will be sent to Stackdriver/Platform Telemetry. Logs at
        /// severitiy ≥ this value will be sent, unless it is NONE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logSeverity")]
        public virtual string LogSeverity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Mesh represents a logical configuration grouping for workload to workload communication within a service mesh.
    /// Routes that point to mesh dictate how requests are routed within this logical mesh boundary.
    /// </summary>
    public class Mesh : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Determines if envoy will insert internal debug headers into upstream requests. Other Envoy headers
        /// may still be injected. By default, envoy will not insert any debug headers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envoyHeaders")]
        public virtual string EnvoyHeaders { get; set; }

        /// <summary>
        /// Optional. If set to a valid TCP port (1-65535), instructs the SIDECAR proxy to listen on the specified port
        /// of localhost (127.0.0.1) address. The SIDECAR proxy will expect all traffic to be redirected to this port
        /// regardless of its actual ip:port destination. If unset, a port '15001' is used as the interception port.
        /// This is applicable only for sidecar proxy deployments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interceptionPort")]
        public virtual System.Nullable<int> InterceptionPort { get; set; }

        /// <summary>Optional. Set of label tags associated with the Mesh resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the Mesh resource. It matches pattern `projects/*/locations/global/meshes/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>MeshRouteView defines view-only resource for Routes to a Mesh</summary>
    public class MeshRouteView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Identifier. Full path name of the MeshRouteView resource. Format:
        /// projects/{project_number}/locations/{location}/meshes/{mesh_name}/routeViews/{route_view_name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The resource id for the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeId")]
        public virtual string RouteId { get; set; }

        /// <summary>Output only. Location where the route exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeLocation")]
        public virtual string RouteLocation { get; set; }

        /// <summary>Output only. Project number where the route exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeProjectNumber")]
        public virtual System.Nullable<long> RouteProjectNumber { get; set; }

        /// <summary>Output only. Type of the route: HttpRoute,GrpcRoute,TcpRoute, or TlsRoute</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeType")]
        public virtual string RouteType { get; set; }

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

    public class RetryFilterPerRouteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the crypto key to use for encrypting event data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyName")]
        public virtual string CryptoKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ServiceBinding can be used to: - Bind a Service Directory Service to be used in a BackendService resource. This
    /// feature will be deprecated soon. - Bind a Private Service Connect producer service to be used in consumer Cloud
    /// Service Mesh or Application Load Balancers. - Bind a Cloud Run service to be used in consumer Cloud Service Mesh
    /// or Application Load Balancers.
    /// </summary>
    public class ServiceBinding : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Set of label tags associated with the ServiceBinding resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the ServiceBinding resource. It matches pattern
        /// `projects/*/locations/*/serviceBindings/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The full Service Directory Service name of the format
        /// `projects/*/locations/*/namespaces/*/services/*`. This field is for Service Directory integration which will
        /// be deprecated soon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the Service Directory Service against which the ServiceBinding
        /// resource is validated. This is populated when the Service Binding resource is used in another resource (like
        /// Backend Service). This is of the UUID4 format. This field is for Service Directory integration which will be
        /// deprecated soon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
        public virtual string ServiceId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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
    /// ServiceLbPolicy holds global load balancing and traffic distribution configuration that can be applied to a
    /// BackendService.
    /// </summary>
    public class ServiceLbPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configuration to automatically move traffic away for unhealthy IG/NEG for the associated Backend
        /// Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCapacityDrain")]
        public virtual ServiceLbPolicyAutoCapacityDrain AutoCapacityDrain { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when this resource was created.</summary>
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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Configuration related to health based failover.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverConfig")]
        public virtual ServiceLbPolicyFailoverConfig FailoverConfig { get; set; }

        /// <summary>Optional. Set of label tags associated with the ServiceLbPolicy resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The type of load balancing algorithm to be used. The default behavior is WATERFALL_BY_REGION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancingAlgorithm")]
        public virtual string LoadBalancingAlgorithm { get; set; }

        /// <summary>
        /// Identifier. Name of the ServiceLbPolicy resource. It matches pattern
        /// `projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when this resource was last updated.</summary>
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
    /// Option to specify if an unhealthy IG/NEG should be considered for global load balancing and traffic routing.
    /// </summary>
    public class ServiceLbPolicyAutoCapacityDrain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set to 'True', an unhealthy IG/NEG will be set as drained. - An IG/NEG is considered unhealthy
        /// if less than 25% of the instances/endpoints in the IG/NEG are healthy. - This option will never result in
        /// draining more than 50% of the configured IGs/NEGs for the Backend Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enable")]
        public virtual System.Nullable<bool> Enable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Option to specify health based failover behavior. This is not related to Network load balancer FailoverPolicy.
    /// </summary>
    public class ServiceLbPolicyFailoverConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The percentage threshold that a load balancer will begin to send traffic to failover backends. If
        /// the percentage of endpoints in a MIG/NEG is smaller than this value, traffic would be sent to failover
        /// backends if possible. This field should be set to a value between 1 and 99. The default value is 50 for
        /// Global external HTTP(S) load balancer (classic) and Proxyless service mesh, and 70 for others.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failoverHealthThreshold")]
        public virtual System.Nullable<int> FailoverHealthThreshold { get; set; }

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
    /// TcpRoute is the resource defining how TCP traffic should be routed by a Mesh/Gateway resource.
    /// </summary>
    public class TcpRoute : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this TcpRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>Optional. Set of label tags associated with the TcpRoute resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this TcpRoute is attached to, as one of the routing rules to route
        /// the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Identifier. Name of the TcpRoute resource. It matches pattern
        /// `projects/*/locations/global/tcpRoutes/tcp_route_name&amp;gt;`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Rules that define how traffic is routed and handled. At least one RouteRule must be supplied. If
        /// there are multiple rules then the action taken will be the first rule to match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<TcpRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>The specifications for routing traffic and applying associated policies.</summary>
    public class TcpRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The destination services to which traffic should be forwarded. At least one destination service is
        /// required. Only one of route destination or original destination can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<TcpRouteRouteDestination> Destinations { get; set; }

        /// <summary>
        /// Optional. Specifies the idle timeout for the selected route. The idle timeout is defined as the period in
        /// which there are no bytes sent or received on either the upstream or downstream connection. If not set, the
        /// default idle timeout is 30 seconds. If set to 0s, the timeout will be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleTimeout")]
        public virtual object IdleTimeout { get; set; }

        /// <summary>
        /// Optional. If true, Router will use the destination IP and port of the original connection as the destination
        /// of the request. Default is false. Only one of route destinations or original destination can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalDestination")]
        public virtual System.Nullable<bool> OriginalDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe the destination for traffic to be routed to.</summary>
    public class TcpRouteRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The URL of a BackendService to route traffic to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Optional. Specifies the proportion of requests forwarded to the backend referenced by the serviceName field.
        /// This is computed as: - weight/Sum(weights in this destination list). For non-zero values, there may be some
        /// epsilon from the exact proportion defined here depending on the precision an implementation supports. If
        /// only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to
        /// that backend. If weights are specified for any one service name, they need to be specified for all of them.
        /// If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RouteMatch defines the predicate used to match requests to a given action. Multiple match types are "OR"ed for
    /// evaluation. If no routeMatch field is specified, this rule will unconditionally match traffic.
    /// </summary>
    public class TcpRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Must be specified in the CIDR range format. A CIDR range consists of an IP Address and a prefix
        /// length to construct the subnet mask. By default, the prefix length is 32 (i.e. matches a single IP address).
        /// Only IPV4 addresses are supported. Examples: "10.0.0.1" - matches against this exact IP address.
        /// "10.0.0.0/8" - matches against any IP address within the 10.0.0.0 subnet and 255.255.255.0 mask. "0.0.0.0/0"
        /// - matches against any IP address'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Required. Specifies the destination port to match against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual string Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to match traffic and how to route traffic when traffic is matched.</summary>
    public class TcpRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The detailed rule defining how to route matched traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual TcpRouteRouteAction Action { get; set; }

        /// <summary>
        /// Optional. RouteMatch defines the predicate used to match requests to a given action. Multiple match types
        /// are "OR"ed for evaluation. If no routeMatch field is specified, this rule will unconditionally match
        /// traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<TcpRouteRouteMatch> Matches { get; set; }

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

    /// <summary>TlsRoute defines how traffic should be routed based on SNI and other matching L3 attributes.</summary>
    public class TlsRoute : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Gateways defines a list of gateways this TlsRoute is attached to, as one of the routing rules to
        /// route the requests served by the gateway. Each gateway reference should match the pattern:
        /// `projects/*/locations/global/gateways/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateways")]
        public virtual System.Collections.Generic.IList<string> Gateways { get; set; }

        /// <summary>Optional. Set of label tags associated with the TlsRoute resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Meshes defines a list of meshes this TlsRoute is attached to, as one of the routing rules to route
        /// the requests served by the mesh. Each mesh reference should match the pattern:
        /// `projects/*/locations/global/meshes/` The attached Mesh should be of a type SIDECAR
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshes")]
        public virtual System.Collections.Generic.IList<string> Meshes { get; set; }

        /// <summary>
        /// Identifier. Name of the TlsRoute resource. It matches pattern
        /// `projects/*/locations/global/tlsRoutes/tls_route_name&amp;gt;`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Rules that define how traffic is routed and handled. At least one RouteRule must be supplied. If
        /// there are multiple rules then the action taken will be the first rule to match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<TlsRouteRouteRule> Rules { get; set; }

        /// <summary>Output only. Server-defined URL of this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>The specifications for routing traffic and applying associated policies.</summary>
    public class TlsRouteRouteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The destination services to which traffic should be forwarded. At least one destination service is
        /// required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<TlsRouteRouteDestination> Destinations { get; set; }

        /// <summary>
        /// Optional. Specifies the idle timeout for the selected route. The idle timeout is defined as the period in
        /// which there are no bytes sent or received on either the upstream or downstream connection. If not set, the
        /// default idle timeout is 1 hour. If set to 0s, the timeout will be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleTimeout")]
        public virtual object IdleTimeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describe the destination for traffic to be routed to.</summary>
    public class TlsRouteRouteDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The URL of a BackendService to route traffic to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// Optional. Specifies the proportion of requests forwarded to the backend referenced by the service_name
        /// field. This is computed as: - weight/Sum(weights in destinations) Weights in all destinations does not need
        /// to sum up to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RouteMatch defines the predicate used to match requests to a given action. Multiple match types are "AND"ed for
    /// evaluation.
    /// </summary>
    public class TlsRouteRouteMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. ALPN (Application-Layer Protocol Negotiation) to match against. Examples: "http/1.1", "h2". At
        /// least one of sni_host and alpn is required. Up to 5 alpns across all matches can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpn")]
        public virtual System.Collections.Generic.IList<string> Alpn { get; set; }

        /// <summary>
        /// Optional. SNI (server name indicator) to match against. SNI will be matched against all wildcard domains,
        /// i.e. `www.example.com` will be first matched against `www.example.com`, then `*.example.com`, then `*.com.`
        /// Partial wildcards are not supported, and values like *w.example.com are invalid. At least one of sni_host
        /// and alpn is required. Up to 100 sni hosts across all matches can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sniHost")]
        public virtual System.Collections.Generic.IList<string> SniHost { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to match traffic and how to route traffic when traffic is matched.</summary>
    public class TlsRouteRouteRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The detailed rule defining how to route matched traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual TlsRouteRouteAction Action { get; set; }

        /// <summary>
        /// Required. RouteMatch defines the predicate used to match requests to a given action. Multiple match types
        /// are "OR"ed for evaluation. Atleast one RouteMatch must be supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<TlsRouteRouteMatch> Matches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specification of a port-based selector.</summary>
    public class TrafficPortSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of ports. Can be port numbers or port range (example, [80-90] specifies all ports from 80
        /// to 90, including 80 and 90) or named ports or * to specify all ports. If the list is empty, all ports are
        /// selected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<string> Ports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`WasmPlugin` is a resource representing a service executing a customer-provided Wasm module.</summary>
    public class WasmPlugin : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A human-readable description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Set of labels associated with the `WasmPlugin` resource. The format must comply with [the
        /// following requirements](/compute/docs/labeling-resources#requirements).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Specifies the logging options for the activity performed by this plugin. If logging is enabled,
        /// plugin logs are exported to Cloud Logging. Note that the settings relate to the logs generated by using
        /// logging statements in your Wasm code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logConfig")]
        public virtual WasmPluginLogConfig LogConfig { get; set; }

        /// <summary>
        /// Optional. The ID of the `WasmPluginVersion` resource that is the currently serving one. The version referred
        /// to must be a child of this `WasmPlugin` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainVersionId")]
        public virtual string MainVersionId { get; set; }

        /// <summary>
        /// Identifier. Name of the `WasmPlugin` resource in the following format:
        /// `projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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
        /// Output only. List of all [extensions](https://cloud.google.com/service-extensions/docs/overview) that use
        /// this `WasmPlugin` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedBy")]
        public virtual System.Collections.Generic.IList<WasmPluginUsedBy> UsedBy { get; set; }

        /// <summary>
        /// Optional. All versions of this `WasmPlugin` resource in the key-value format. The key is the resource ID,
        /// and the value is the `VersionDetails` object. Lets you create or update a `WasmPlugin` resource and its
        /// versions in a single request. When the `main_version_id` field is not empty, it must point to one of the
        /// `VersionDetails` objects in the map. If provided in a `PATCH` request, the new versions replace the previous
        /// set. Any version omitted from the `versions` field is removed. Because the `WasmPluginVersion` resource is
        /// immutable, if a `WasmPluginVersion` resource with the same name already exists and differs, the request
        /// fails. Note: In a `GET` request, this field is populated only if the field `GetWasmPluginRequest.view` is
        /// set to `WASM_PLUGIN_VIEW_FULL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IDictionary<string, WasmPluginVersionDetails> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the logging options for the activity performed by this plugin. If logging is enabled, plugin logs are
    /// exported to Cloud Logging.
    /// </summary>
    public class WasmPluginLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specifies whether to enable logging for activity by this plugin. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enable")]
        public virtual System.Nullable<bool> Enable { get; set; }

        /// <summary>
        /// Non-empty default. Specificies the lowest level of the plugin logs that are exported to Cloud Logging. This
        /// setting relates to the logs generated by using logging statements in your Wasm code. This field is can be
        /// set only if logging is enabled for the plugin. If the field is not provided when logging is enabled, it is
        /// set to `INFO` by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLogLevel")]
        public virtual string MinLogLevel { get; set; }

        /// <summary>
        /// Non-empty default. Configures the sampling rate of activity logs, where `1.0` means all logged activity is
        /// reported and `0.0` means no activity is reported. A floating point value between `0.0` and `1.0` indicates
        /// that a percentage of log messages is stored. The default value when logging is enabled is `1.0`. The value
        /// of the field must be between `0` and `1` (inclusive). This field can be specified only if logging is enabled
        /// for this plugin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRate")]
        public virtual System.Nullable<float> SampleRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a resource that uses the `WasmPlugin` resource.</summary>
    public class WasmPluginUsedBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Full name of the resource https://google.aip.dev/122#full-resource-names, for example
        /// `//networkservices.googleapis.com/projects/{project}/locations/{location}/lbRouteExtensions/{extension}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single immutable version of a `WasmPlugin` resource. Defines the Wasm module used and optionally its runtime
    /// config.
    /// </summary>
    public class WasmPluginVersion : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A human-readable description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The resolved digest for the image specified in the `image` field. The digest is resolved during
        /// the creation of `WasmPluginVersion` resource. This field holds the digest value, regardless of whether a tag
        /// or digest was originally specified in the `image` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageDigest")]
        public virtual string ImageDigest { get; set; }

        /// <summary>
        /// Optional. URI of the container image containing the plugin, stored in the Artifact Registry. When a new
        /// `WasmPluginVersion` resource is created, the digest of the container image is saved in the `image_digest`
        /// field. When downloading an image, the digest value is used instead of an image tag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>Optional. Set of labels associated with the `WasmPluginVersion` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the `WasmPluginVersion` resource in the following format:
        /// `projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/ versions/{wasm_plugin_version}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Configuration for the plugin. The configuration is provided to the plugin at runtime through the
        /// `ON_CONFIGURE` callback. When a new `WasmPluginVersion` resource is created, the digest of the contents is
        /// saved in the `plugin_config_digest` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginConfigData")]
        public virtual string PluginConfigData { get; set; }

        /// <summary>
        /// Output only. This field holds the digest (usually checksum) value for the plugin configuration. The value is
        /// calculated based on the contents of `plugin_config_data` or the container image defined by the
        /// `plugin_config_uri` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginConfigDigest")]
        public virtual string PluginConfigDigest { get; set; }

        /// <summary>
        /// URI of the plugin configuration stored in the Artifact Registry. The configuration is provided to the plugin
        /// at runtime through the `ON_CONFIGURE` callback. The container image must contain only a single file with the
        /// name `plugin.config`. When a new `WasmPluginVersion` resource is created, the digest of the container image
        /// is saved in the `plugin_config_digest` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginConfigUri")]
        public virtual string PluginConfigUri { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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

    /// <summary>Details of a `WasmPluginVersion` resource to be inlined in the `WasmPlugin` resource.</summary>
    public class WasmPluginVersionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Optional. A human-readable description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The resolved digest for the image specified in `image`. The digest is resolved during the
        /// creation of a `WasmPluginVersion` resource. This field holds the digest value regardless of whether a tag or
        /// digest was originally specified in the `image` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageDigest")]
        public virtual string ImageDigest { get; set; }

        /// <summary>
        /// Optional. URI of the container image containing the Wasm module, stored in the Artifact Registry. The
        /// container image must contain only a single file with the name `plugin.wasm`. When a new `WasmPluginVersion`
        /// resource is created, the URI gets resolved to an image digest and saved in the `image_digest` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>Optional. Set of labels associated with the `WasmPluginVersion` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Configuration for the plugin. The configuration is provided to the plugin at runtime through the
        /// `ON_CONFIGURE` callback. When a new `WasmPluginVersion` version is created, the digest of the contents is
        /// saved in the `plugin_config_digest` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginConfigData")]
        public virtual string PluginConfigData { get; set; }

        /// <summary>
        /// Output only. This field holds the digest (usually checksum) value for the plugin configuration. The value is
        /// calculated based on the contents of the `plugin_config_data` field or the container image defined by the
        /// `plugin_config_uri` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginConfigDigest")]
        public virtual string PluginConfigDigest { get; set; }

        /// <summary>
        /// URI of the plugin configuration stored in the Artifact Registry. The configuration is provided to the plugin
        /// at runtime through the `ON_CONFIGURE` callback. The container image must contain only a single file with the
        /// name `plugin.config`. When a new `WasmPluginVersion` resource is created, the digest of the container image
        /// is saved in the `plugin_config_digest` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginConfigUri")]
        public virtual string PluginConfigUri { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the resource was updated.</summary>
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
}
