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

namespace Google.Apis.APIhub.v1
{
    /// <summary>The APIhub Service.</summary>
    public class APIhubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public APIhubService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public APIhubService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://apihub.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://apihub.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "apihub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the API hub API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the API hub API.</summary>
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

    /// <summary>A base abstract class for APIhub requests.</summary>
    public abstract class APIhubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new APIhubBaseServiceRequest instance.</summary>
        protected APIhubBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes APIhub parameter list.</summary>
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
                ApiHubInstances = new ApiHubInstancesResource(service);
                Apis = new ApisResource(service);
                Attributes = new AttributesResource(service);
                Curations = new CurationsResource(service);
                Dependencies = new DependenciesResource(service);
                Deployments = new DeploymentsResource(service);
                ExternalApis = new ExternalApisResource(service);
                HostProjectRegistrations = new HostProjectRegistrationsResource(service);
                Operations = new OperationsResource(service);
                Plugins = new PluginsResource(service);
                RuntimeProjectAttachments = new RuntimeProjectAttachmentsResource(service);
            }

            /// <summary>Gets the ApiHubInstances resource.</summary>
            public virtual ApiHubInstancesResource ApiHubInstances { get; }

            /// <summary>The "apiHubInstances" collection of methods.</summary>
            public class ApiHubInstancesResource
            {
                private const string Resource = "apiHubInstances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ApiHubInstancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Provisions instance resources for the API Hub.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the Api Hub instance resource. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiHubInstance body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Provisions instance resources for the API Hub.</summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiHubInstance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the Api Hub instance resource. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Identifier to assign to the Api Hub instance. Must be unique within scope of the
                    /// parent resource. If the field is not provided, system generated id will be used. This value
                    /// should be 4-40 characters, and valid characters are `/a-z[0-9]-_/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiHubInstanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ApiHubInstanceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiHubInstance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apiHubInstances";

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
                        RequestParameters.Add("apiHubInstanceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "apiHubInstanceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the API hub instance.</summary>
                /// <param name="name">
                /// Required. The name of the Api Hub instance to delete. Format:
                /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the API hub instance.</summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Api Hub instance to delete. Format:
                    /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apiHubInstances/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single API Hub instance.</summary>
                /// <param name="name">
                /// Required. The name of the Api Hub instance to retrieve. Format:
                /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single API Hub instance.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiHubInstance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Api Hub instance to retrieve. Format:
                    /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apiHubInstances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Looks up an Api Hub instance in a given GCP project. There will always be only one Api Hub instance
                /// for a GCP project across all locations.
                /// </summary>
                /// <param name="parent">
                /// Required. There will always be only one Api Hub instance for a GCP project across all locations. The
                /// parent resource for the Api Hub instance resource. Format: `projects/{project}/locations/{location}`
                /// </param>
                public virtual LookupRequest Lookup(string parent)
                {
                    return new LookupRequest(this.service, parent);
                }

                /// <summary>
                /// Looks up an Api Hub instance in a given GCP project. There will always be only one Api Hub instance
                /// for a GCP project across all locations.
                /// </summary>
                public class LookupRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1LookupApiHubInstanceResponse>
                {
                    /// <summary>Constructs a new Lookup request.</summary>
                    public LookupRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. There will always be only one Api Hub instance for a GCP project across all locations.
                    /// The parent resource for the Api Hub instance resource. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "lookup";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apiHubInstances:lookup";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Apis resource.</summary>
            public virtual ApisResource Apis { get; }

            /// <summary>The "apis" collection of methods.</summary>
            public class ApisResource
            {
                private const string Resource = "apis";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ApisResource(Google.Apis.Services.IClientService service)
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
                        Definitions = new DefinitionsResource(service);
                        Operations = new OperationsResource(service);
                        Specs = new SpecsResource(service);
                    }

                    /// <summary>Gets the Definitions resource.</summary>
                    public virtual DefinitionsResource Definitions { get; }

                    /// <summary>The "definitions" collection of methods.</summary>
                    public class DefinitionsResource
                    {
                        private const string Resource = "definitions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public DefinitionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Get details about a definition in an API version.</summary>
                        /// <param name="name">
                        /// Required. The name of the definition to retrieve. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Get details about a definition in an API version.</summary>
                        public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Definition>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the definition to retrieve. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/definitions/[^/]+$",
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
                        /// Create an apiOperation in an API version. An apiOperation can be created only if the version
                        /// has no apiOperations which were created by parsing a spec.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource for the operation resource. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Create an apiOperation in an API version. An apiOperation can be created only if the version
                        /// has no apiOperations which were created by parsing a spec.
                        /// </summary>
                        public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource for the operation resource. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. The ID to use for the operation resource, which will become the final
                            /// component of the operation's resource name. This field is optional. * If provided, the
                            /// same will be used. The service will throw an error if the specified id is already used
                            /// by another operation resource in the API hub. * If not provided, a system generated id
                            /// will be used. This value should be 4-500 characters, overall resource name which will be
                            /// of format
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`,
                            /// its length is limited to 700 characters, and valid characters are /a-z[0-9]-_/.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("apiOperationId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string ApiOperationId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/operations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("apiOperationId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "apiOperationId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Delete an operation in an API version and we can delete only the operations created via
                        /// create API. If the operation was created by parsing the spec, then it can be deleted by
                        /// editing or deleting the spec.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the operation resource to delete. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>
                        /// Delete an operation in an API version and we can delete only the operations created via
                        /// create API. If the operation was created by parsing the spec, then it can be deleted by
                        /// editing or deleting the spec.
                        /// </summary>
                        public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the operation resource to delete. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Get details about a particular operation in API version.</summary>
                        /// <param name="name">
                        /// Required. The name of the operation to retrieve. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Get details about a particular operation in API version.</summary>
                        public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the operation to retrieve. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>List operations in an API version.</summary>
                        /// <param name="parent">
                        /// Required. The parent which owns this collection of operations i.e., the API version. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>List operations in an API version.</summary>
                        public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListApiOperationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent which owns this collection of operations i.e., the API version.
                            /// Format: `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. An expression that filters the list of ApiOperations. A filter expression
                            /// consists of a field name, a comparison operator, and a value for filtering. The value
                            /// must be a string or a boolean. The comparison operator must be one of: `&amp;lt;`,
                            /// `&amp;gt;` or `=`. Filters are not case sensitive. The following fields in the
                            /// `ApiOperation` are eligible for filtering: * `name` - The ApiOperation resource name.
                            /// Allowed comparison operators: `=`. * `details.http_operation.path.path` - The http
                            /// operation's complete path relative to server endpoint. Allowed comparison operators:
                            /// `=`. * `details.http_operation.method` - The http operation method type. Allowed
                            /// comparison operators: `=`. * `details.deprecated` - Indicates if the ApiOperation is
                            /// deprecated. Allowed values are True / False indicating the deprycation status of the
                            /// ApiOperation. Allowed comparison operators: `=`. * `create_time` - The time at which the
                            /// ApiOperation was created. The value should be in the
                            /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. Allowed comparison operators:
                            /// `&amp;gt;` and `&amp;lt;`. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.enum_values.values.id` - The allowed value id of
                            /// the user defined enum attribute associated with the Resource. Allowed comparison
                            /// operator is `:`. Here user-defined-attribute-enum-id is a placeholder that can be
                            /// replaced with any user defined enum attribute name. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.enum_values.values.display_name` - The allowed
                            /// value display name of the user defined enum attribute associated with the Resource.
                            /// Allowed comparison operator is `:`. Here user-defined-attribute-enum-display-name is a
                            /// placeholder that can be replaced with any user defined enum attribute enum name. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.string_values.values` - The allowed value of the
                            /// user defined string attribute associated with the Resource. Allowed comparison operator
                            /// is `:`. Here user-defined-attribute-string is a placeholder that can be replaced with
                            /// any user defined string attribute name. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.json_values.values` - The allowed value of the user
                            /// defined JSON attribute associated with the Resource. Allowed comparison operator is `:`.
                            /// Here user-defined-attribute-json is a placeholder that can be replaced with any user
                            /// defined JSON attribute name. Expressions are combined with either `AND` logic operator
                            /// or `OR` logical operator but not both of them together i.e. only one of the `AND` or
                            /// `OR` operator can be used throughout the filter string and both the operators cannot be
                            /// used together. No other logical operators are supported. At most three filter fields are
                            /// allowed in the filter string and if provided more than that then `INVALID_ARGUMENT`
                            /// error is returned by the API. Here are a few examples: * `details.deprecated = True` -
                            /// The ApiOperation is deprecated. * `details.http_operation.method = GET AND create_time
                            /// &amp;lt; \"2021-08-15T14:50:00Z\" AND create_time &amp;gt; \"2021-08-10T12:00:00Z\"` -
                            /// The method of the http operation of the ApiOperation is _GET_ and the spec was created
                            /// before _2021-08-15 14:50:00 UTC_ and after _2021-08-10 12:00:00 UTC_. *
                            /// `details.http_operation.method = GET OR details.http_operation.method = POST`. - The
                            /// http operation of the method of ApiOperation is _GET_ or _POST_. * `details.deprecated =
                            /// True AND attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/17650f90-4a29-4971-b3c0-d5532da3764b.string_values.values: test` - The filter
                            /// string specifies that the ApiOperation is deprecated and the value of the user defined
                            /// attribute of type string is _test_.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of operations to return. The service may return fewer than
                            /// this value. If unspecified, at most 50 operations will be returned. The maximum value is
                            /// 1000; values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListApiOperations` call. Provide this
                            /// to retrieve the subsequent page. When paginating, all other parameters (except
                            /// page_size) provided to `ListApiOperations` must match the call that provided the page
                            /// token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/operations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
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
                        /// Update an operation in an API version. The following fields in the ApiOperation resource can
                        /// be updated: * details.description * details.documentation * details.http_operation.path *
                        /// details.http_operation.method * details.deprecated * attributes The update_mask should be
                        /// used to specify the fields being updated. An operation can be updated only if the operation
                        /// was created via CreateApiOperation API. If the operation was created by parsing the spec,
                        /// then it can be edited by updating the spec.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Identifier. The name of the operation. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Update an operation in an API version. The following fields in the ApiOperation resource can
                        /// be updated: * details.description * details.documentation * details.http_operation.path *
                        /// details.http_operation.method * details.deprecated * attributes The update_mask should be
                        /// used to specify the fields being updated. An operation can be updated only if the operation
                        /// was created via CreateApiOperation API. If the operation was created by parsing the spec,
                        /// then it can be edited by updating the spec.
                        /// </summary>
                        public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Identifier. The name of the operation. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Required. The list of fields to update.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ApiOperation Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/operations/[^/]+$",
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

                    /// <summary>Gets the Specs resource.</summary>
                    public virtual SpecsResource Specs { get; }

                    /// <summary>The "specs" collection of methods.</summary>
                    public class SpecsResource
                    {
                        private const string Resource = "specs";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SpecsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Add a spec to an API version in the API hub. Multiple specs can be added to an API version.
                        /// Note, while adding a spec, at least one of `contents` or `source_uri` must be provided. If
                        /// `contents` is provided, then `spec_type` must also be provided. On adding a spec with
                        /// contents to the version, the operations present in it will be added to the version.Note that
                        /// the file contents in the spec should be of the same type as defined in the
                        /// `projects/{project}/locations/{location}/attributes/system-spec-type` attribute associated
                        /// with spec resource. Note that specs of various types can be uploaded, however parsing of
                        /// details is supported for OpenAPI spec currently. In order to access the information parsed
                        /// from the spec, use the GetSpec method. In order to access the raw contents for a particular
                        /// spec, use the GetSpecContents method. In order to access the operations parsed from the
                        /// spec, use the ListAPIOperations method.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource for Spec. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Add a spec to an API version in the API hub. Multiple specs can be added to an API version.
                        /// Note, while adding a spec, at least one of `contents` or `source_uri` must be provided. If
                        /// `contents` is provided, then `spec_type` must also be provided. On adding a spec with
                        /// contents to the version, the operations present in it will be added to the version.Note that
                        /// the file contents in the spec should be of the same type as defined in the
                        /// `projects/{project}/locations/{location}/attributes/system-spec-type` attribute associated
                        /// with spec resource. Note that specs of various types can be uploaded, however parsing of
                        /// details is supported for OpenAPI spec currently. In order to access the information parsed
                        /// from the spec, use the GetSpec method. In order to access the raw contents for a particular
                        /// spec, use the GetSpecContents method. In order to access the operations parsed from the
                        /// spec, use the ListAPIOperations method.
                        /// </summary>
                        public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource for Spec. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. The ID to use for the spec, which will become the final component of the
                            /// spec's resource name. This field is optional. * If provided, the same will be used. The
                            /// service will throw an error if the specified id is already used by another spec in the
                            /// API resource. * If not provided, a system generated id will be used. This value should
                            /// be 4-500 characters, overall resource name which will be of format
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`,
                            /// its length is limited to 1000 characters and valid characters are /a-z[0-9]-_/.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("specId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string SpecId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/specs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("specId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "specId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Delete a spec. Deleting a spec will also delete the associated operations from the version.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the spec to delete. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>
                        /// Delete a spec. Deleting a spec will also delete the associated operations from the version.
                        /// </summary>
                        public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec to delete. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Get details about the information parsed from a spec. Note that this method does not return
                        /// the raw spec contents. Use GetSpecContents method to retrieve the same.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the spec to retrieve. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>
                        /// Get details about the information parsed from a spec. Note that this method does not return
                        /// the raw spec contents. Use GetSpecContents method to retrieve the same.
                        /// </summary>
                        public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec to retrieve. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Get spec contents.</summary>
                        /// <param name="name">
                        /// Required. The name of the spec whose contents need to be retrieved. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                        /// </param>
                        public virtual GetContentsRequest GetContents(string name)
                        {
                            return new GetContentsRequest(this.service, name);
                        }

                        /// <summary>Get spec contents.</summary>
                        public class GetContentsRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1SpecContents>
                        {
                            /// <summary>Constructs a new GetContents request.</summary>
                            public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec whose contents need to be retrieved. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getContents";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:contents";

                            /// <summary>Initializes GetContents parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lints the requested spec and updates the corresponding API Spec with the lint response. This
                        /// lint response will be available in all subsequent Get and List Spec calls to Core service.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The name of the spec to be linted. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                        /// </param>
                        public virtual LintRequest Lint(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1LintSpecRequest body, string name)
                        {
                            return new LintRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Lints the requested spec and updates the corresponding API Spec with the lint response. This
                        /// lint response will be available in all subsequent Get and List Spec calls to Core service.
                        /// </summary>
                        public class LintRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Lint request.</summary>
                            public LintRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1LintSpecRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the spec to be linted. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1LintSpecRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "lint";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:lint";

                            /// <summary>Initializes Lint parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
                                });
                            }
                        }

                        /// <summary>List specs corresponding to a particular API resource.</summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of specs. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>List specs corresponding to a particular API resource.</summary>
                        public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListSpecsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of specs. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. An expression that filters the list of Specs. A filter expression consists of
                            /// a field name, a comparison operator, and a value for filtering. The value must be a
                            /// string. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`, `:` or `=`.
                            /// Filters are not case sensitive. The following fields in the `Spec` are eligible for
                            /// filtering: * `display_name` - The display name of the Spec. Allowed comparison
                            /// operators: `=`. * `create_time` - The time at which the Spec was created. The value
                            /// should be in the (RFC3339)[https://tools.ietf.org/html/rfc3339] format. Allowed
                            /// comparison operators: `&amp;gt;` and `&amp;lt;`. * `spec_type.enum_values.values.id` -
                            /// The allowed value id of the spec_type attribute associated with the Spec. Allowed
                            /// comparison operators: `:`. * `spec_type.enum_values.values.display_name` - The allowed
                            /// value display name of the spec_type attribute associated with the Spec. Allowed
                            /// comparison operators: `:`. * `lint_response.json_values.values` - The json value of the
                            /// lint_response attribute associated with the Spec. Allowed comparison operators: `:`. *
                            /// `mime_type` - The MIME type of the Spec. Allowed comparison operators: `=`. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.enum_values.values.id` - The allowed value id of
                            /// the user defined enum attribute associated with the Resource. Allowed comparison
                            /// operator is `:`. Here user-defined-attribute-enum-id is a placeholder that can be
                            /// replaced with any user defined enum attribute name. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.enum_values.values.display_name` - The allowed
                            /// value display name of the user defined enum attribute associated with the Resource.
                            /// Allowed comparison operator is `:`. Here user-defined-attribute-enum-display-name is a
                            /// placeholder that can be replaced with any user defined enum attribute enum name. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.string_values.values` - The allowed value of the
                            /// user defined string attribute associated with the Resource. Allowed comparison operator
                            /// is `:`. Here user-defined-attribute-string is a placeholder that can be replaced with
                            /// any user defined string attribute name. *
                            /// `attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/user-defined-attribute-id.json_values.values` - The allowed value of the user
                            /// defined JSON attribute associated with the Resource. Allowed comparison operator is `:`.
                            /// Here user-defined-attribute-json is a placeholder that can be replaced with any user
                            /// defined JSON attribute name. Expressions are combined with either `AND` logic operator
                            /// or `OR` logical operator but not both of them together i.e. only one of the `AND` or
                            /// `OR` operator can be used throughout the filter string and both the operators cannot be
                            /// used together. No other logical operators are supported. At most three filter fields are
                            /// allowed in the filter string and if provided more than that then `INVALID_ARGUMENT`
                            /// error is returned by the API. Here are a few examples: *
                            /// `spec_type.enum_values.values.id: rest-id` - The filter string specifies that the id of
                            /// the allowed value associated with the spec_type attribute is _rest-id_. *
                            /// `spec_type.enum_values.values.display_name: \"Rest Display Name\"` - The filter string
                            /// specifies that the display name of the allowed value associated with the spec_type
                            /// attribute is `Rest Display Name`. * `spec_type.enum_values.values.id: grpc-id AND
                            /// create_time &amp;lt; \"2021-08-15T14:50:00Z\" AND create_time &amp;gt;
                            /// \"2021-08-10T12:00:00Z\"` - The id of the allowed value associated with the spec_type
                            /// attribute is _grpc-id_ and the spec was created before _2021-08-15 14:50:00 UTC_ and
                            /// after _2021-08-10 12:00:00 UTC_. * `spec_type.enum_values.values.id: rest-id OR
                            /// spec_type.enum_values.values.id: grpc-id` - The id of the allowed value associated with
                            /// the spec_type attribute is _rest-id_ or _grpc-id_. * `spec_type.enum_values.values.id:
                            /// rest-id AND attributes.projects/test-project-id/locations/test-location-id/
                            /// attributes/17650f90-4a29-4971-b3c0-d5532da3764b.enum_values.values.id: test` - The
                            /// filter string specifies that the id of the allowed value associated with the spec_type
                            /// attribute is _rest-id_ and the id of the allowed value associated with the user defined
                            /// attribute of type enum is _test_.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of specs to return. The service may return fewer than this
                            /// value. If unspecified, at most 50 specs will be returned. The maximum value is 1000;
                            /// values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListSpecs` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListSpecs` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/specs";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
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
                        /// Update spec. The following fields in the spec can be updated: * display_name * source_uri *
                        /// lint_response * attributes * contents * spec_type In case of an OAS spec, updating spec
                        /// contents can lead to: 1. Creation, deletion and update of operations. 2. Creation, deletion
                        /// and update of definitions. 3. Update of other info parsed out from the new spec. In case of
                        /// contents or source_uri being present in update mask, spec_type must also be present. Also,
                        /// spec_type can not be present in update mask if contents or source_uri is not present. The
                        /// update_mask should be used to specify the fields being updated.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Identifier. The name of the spec. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Update spec. The following fields in the spec can be updated: * display_name * source_uri *
                        /// lint_response * attributes * contents * spec_type In case of an OAS spec, updating spec
                        /// contents can lead to: 1. Creation, deletion and update of operations. 2. Creation, deletion
                        /// and update of definitions. 3. Update of other info parsed out from the new spec. In case of
                        /// contents or source_uri being present in update mask, spec_type must also be present. Also,
                        /// spec_type can not be present in update mask if contents or source_uri is not present. The
                        /// update_mask should be used to specify the fields being updated.
                        /// </summary>
                        public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Identifier. The name of the spec. Format:
                            /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Required. The list of fields to update.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Spec Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+/specs/[^/]+$",
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

                    /// <summary>Create an API version for an API resource in the API hub.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource for API version. Format:
                    /// `projects/{project}/locations/{location}/apis/{api}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create an API version for an API resource in the API hub.</summary>
                    public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource for API version. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the API version, which will become the final component of the
                        /// version's resource name. This field is optional. * If provided, the same will be used. The
                        /// service will throw an error if the specified id is already used by another version in the
                        /// API resource. * If not provided, a system generated id will be used. This value should be
                        /// 4-500 characters, overall resource name which will be of format
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`, its length is
                        /// limited to 700 characters and valid characters are /a-z[0-9]-_/.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("versionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string VersionId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                            });
                            RequestParameters.Add("versionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "versionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Delete an API version. Version can only be deleted if all underlying specs, operations,
                    /// definitions and linked deployments are deleted.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the version to delete. Format:
                    /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Delete an API version. Version can only be deleted if all underlying specs, operations,
                    /// definitions and linked deployments are deleted.
                    /// </summary>
                    public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the version to delete. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set to true, any specs from this version will also be deleted. Otherwise, the
                        /// request will only work if the version has no specs.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Get details about the API version of an API resource. This will include information about the
                    /// specs and operations present in the API version as well as the deployments linked to it.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the API version to retrieve. Format:
                    /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Get details about the API version of an API resource. This will include information about the
                    /// specs and operations present in the API version as well as the deployments linked to it.
                    /// </summary>
                    public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the API version to retrieve. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List API versions of an API resource in the API hub.</summary>
                    /// <param name="parent">
                    /// Required. The parent which owns this collection of API versions i.e., the API resource Format:
                    /// `projects/{project}/locations/{location}/apis/{api}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List API versions of an API resource in the API hub.</summary>
                    public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListVersionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent which owns this collection of API versions i.e., the API resource
                        /// Format: `projects/{project}/locations/{location}/apis/{api}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. An expression that filters the list of Versions. A filter expression consists of a
                        /// field name, a comparison operator, and a value for filtering. The value must be a string, a
                        /// number, or a boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;` or `=`.
                        /// Filters are not case sensitive. The following fields in the `Version` are eligible for
                        /// filtering: * `display_name` - The display name of the Version. Allowed comparison operators:
                        /// `=`. * `create_time` - The time at which the Version was created. The value should be in the
                        /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. Allowed comparison operators:
                        /// `&amp;gt;` and `&amp;lt;`. * `lifecycle.enum_values.values.id` - The allowed value id of the
                        /// lifecycle attribute associated with the Version. Allowed comparison operators: `:`. *
                        /// `lifecycle.enum_values.values.display_name` - The allowed value display name of the
                        /// lifecycle attribute associated with the Version. Allowed comparison operators: `:`. *
                        /// `compliance.enum_values.values.id` - The allowed value id of the compliances attribute
                        /// associated with the Version. Allowed comparison operators: `:`. *
                        /// `compliance.enum_values.values.display_name` - The allowed value display name of the
                        /// compliances attribute associated with the Version. Allowed comparison operators: `:`. *
                        /// `accreditation.enum_values.values.id` - The allowed value id of the accreditations attribute
                        /// associated with the Version. Allowed comparison operators: `:`. *
                        /// `accreditation.enum_values.values.display_name` - The allowed value display name of the
                        /// accreditations attribute associated with the Version. Allowed comparison operators: `:`. *
                        /// `attributes.projects/test-project-id/locations/test-location-id/
                        /// attributes/user-defined-attribute-id.enum_values.values.id` - The allowed value id of the
                        /// user defined enum attribute associated with the Resource. Allowed comparison operator is
                        /// `:`. Here user-defined-attribute-enum-id is a placeholder that can be replaced with any user
                        /// defined enum attribute name. *
                        /// `attributes.projects/test-project-id/locations/test-location-id/
                        /// attributes/user-defined-attribute-id.enum_values.values.display_name` - The allowed value
                        /// display name of the user defined enum attribute associated with the Resource. Allowed
                        /// comparison operator is `:`. Here user-defined-attribute-enum-display-name is a placeholder
                        /// that can be replaced with any user defined enum attribute enum name. *
                        /// `attributes.projects/test-project-id/locations/test-location-id/
                        /// attributes/user-defined-attribute-id.string_values.values` - The allowed value of the user
                        /// defined string attribute associated with the Resource. Allowed comparison operator is `:`.
                        /// Here user-defined-attribute-string is a placeholder that can be replaced with any user
                        /// defined string attribute name. *
                        /// `attributes.projects/test-project-id/locations/test-location-id/
                        /// attributes/user-defined-attribute-id.json_values.values` - The allowed value of the user
                        /// defined JSON attribute associated with the Resource. Allowed comparison operator is `:`.
                        /// Here user-defined-attribute-json is a placeholder that can be replaced with any user defined
                        /// JSON attribute name. Expressions are combined with either `AND` logic operator or `OR`
                        /// logical operator but not both of them together i.e. only one of the `AND` or `OR` operator
                        /// can be used throughout the filter string and both the operators cannot be used together. No
                        /// other logical operators are supported. At most three filter fields are allowed in the filter
                        /// string and if provided more than that then `INVALID_ARGUMENT` error is returned by the API.
                        /// Here are a few examples: * `lifecycle.enum_values.values.id: preview-id` - The filter string
                        /// specifies that the id of the allowed value associated with the lifecycle attribute of the
                        /// Version is _preview-id_. * `lifecycle.enum_values.values.display_name: \"Preview Display
                        /// Name\"` - The filter string specifies that the display name of the allowed value associated
                        /// with the lifecycle attribute of the Version is `Preview Display Name`. *
                        /// `lifecycle.enum_values.values.id: preview-id AND create_time &amp;lt;
                        /// \"2021-08-15T14:50:00Z\" AND create_time &amp;gt; \"2021-08-10T12:00:00Z\"` - The id of the
                        /// allowed value associated with the lifecycle attribute of the Version is _preview-id_ and it
                        /// was created before _2021-08-15 14:50:00 UTC_ and after _2021-08-10 12:00:00 UTC_. *
                        /// `compliance.enum_values.values.id: gdpr-id OR compliance.enum_values.values.id: pci-dss-id`
                        /// - The id of the allowed value associated with the compliance attribute is _gdpr-id_ or
                        /// _pci-dss-id_. * `lifecycle.enum_values.values.id: preview-id AND
                        /// attributes.projects/test-project-id/locations/test-location-id/
                        /// attributes/17650f90-4a29-4971-b3c0-d5532da3764b.string_values.values: test` - The filter
                        /// string specifies that the id of the allowed value associated with the lifecycle attribute of
                        /// the Version is _preview-id_ and the value of the user defined attribute of type string is
                        /// _test_.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of versions to return. The service may return fewer than this
                        /// value. If unspecified, at most 50 versions will be returned. The maximum value is 1000;
                        /// values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListVersions` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters (except page_size)
                        /// provided to `ListVersions` must match the call that provided the page token.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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
                    /// Update API version. The following fields in the version can be updated currently: * display_name
                    /// * description * documentation * deployments * lifecycle * compliance * accreditation *
                    /// attributes The update_mask should be used to specify the fields being updated.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The name of the version. Format:
                    /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Update API version. The following fields in the version can be updated currently: * display_name
                    /// * description * documentation * deployments * lifecycle * compliance * accreditation *
                    /// attributes The update_mask should be used to specify the fields being updated.
                    /// </summary>
                    public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The name of the version. Format:
                        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Version Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+/versions/[^/]+$",
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
                /// Create an API resource in the API hub. Once an API resource is created, versions can be added to it.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the API resource. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create an API resource in the API hub. Once an API resource is created, versions can be added to it.
                /// </summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the API resource. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the API resource, which will become the final component of the API's
                    /// resource name. This field is optional. * If provided, the same will be used. The service will
                    /// throw an error if the specified id is already used by another API resource in the API hub. * If
                    /// not provided, a system generated id will be used. This value should be 4-500 characters, and
                    /// valid characters are /a-z[0-9]-_/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("apiId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ApiId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apis";

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
                        RequestParameters.Add("apiId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "apiId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Delete an API resource in the API hub. API can only be deleted if all underlying versions are
                /// deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the API resource to delete. Format:
                /// `projects/{project}/locations/{location}/apis/{api}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Delete an API resource in the API hub. API can only be deleted if all underlying versions are
                /// deleted.
                /// </summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the API resource to delete. Format:
                    /// `projects/{project}/locations/{location}/apis/{api}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, any versions from this API will also be deleted. Otherwise, the
                    /// request will only work if the API has no versions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get API resource details including the API versions contained in it.</summary>
                /// <param name="name">
                /// Required. The name of the API resource to retrieve. Format:
                /// `projects/{project}/locations/{location}/apis/{api}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get API resource details including the API versions contained in it.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the API resource to retrieve. Format:
                    /// `projects/{project}/locations/{location}/apis/{api}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
                        });
                    }
                }

                /// <summary>List API resources in the API hub.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of API resources. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List API resources in the API hub.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListApisResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of API resources. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of ApiResources. A filter expression consists of a
                    /// field name, a comparison operator, and a value for filtering. The value must be a string. The
                    /// comparison operator must be one of: `&amp;lt;`, `&amp;gt;`, `:` or `=`. Filters are not case
                    /// sensitive. The following fields in the `ApiResource` are eligible for filtering: * `owner.email`
                    /// - The email of the team which owns the ApiResource. Allowed comparison operators: `=`. *
                    /// `create_time` - The time at which the ApiResource was created. The value should be in the
                    /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. Allowed comparison operators: `&amp;gt;`
                    /// and `&amp;lt;`. * `display_name` - The display name of the ApiResource. Allowed comparison
                    /// operators: `=`. * `target_user.enum_values.values.id` - The allowed value id of the target users
                    /// attribute associated with the ApiResource. Allowed comparison operator is `:`. *
                    /// `target_user.enum_values.values.display_name` - The allowed value display name of the target
                    /// users attribute associated with the ApiResource. Allowed comparison operator is `:`. *
                    /// `team.enum_values.values.id` - The allowed value id of the team attribute associated with the
                    /// ApiResource. Allowed comparison operator is `:`. * `team.enum_values.values.display_name` - The
                    /// allowed value display name of the team attribute associated with the ApiResource. Allowed
                    /// comparison operator is `:`. * `business_unit.enum_values.values.id` - The allowed value id of
                    /// the business unit attribute associated with the ApiResource. Allowed comparison operator is `:`.
                    /// * `business_unit.enum_values.values.display_name` - The allowed value display name of the
                    /// business unit attribute associated with the ApiResource. Allowed comparison operator is `:`. *
                    /// `maturity_level.enum_values.values.id` - The allowed value id of the maturity level attribute
                    /// associated with the ApiResource. Allowed comparison operator is `:`. *
                    /// `maturity_level.enum_values.values.display_name` - The allowed value display name of the
                    /// maturity level attribute associated with the ApiResource. Allowed comparison operator is `:`. *
                    /// `api_style.enum_values.values.id` - The allowed value id of the api style attribute associated
                    /// with the ApiResource. Allowed comparison operator is `:`. *
                    /// `api_style.enum_values.values.display_name` - The allowed value display name of the api style
                    /// attribute associated with the ApiResource. Allowed comparison operator is `:`. *
                    /// `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.enum_values.values.id` - The allowed value id of the user
                    /// defined enum attribute associated with the Resource. Allowed comparison operator is `:`. Here
                    /// user-defined-attribute-enum-id is a placeholder that can be replaced with any user defined enum
                    /// attribute name. * `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.enum_values.values.display_name` - The allowed value
                    /// display name of the user defined enum attribute associated with the Resource. Allowed comparison
                    /// operator is `:`. Here user-defined-attribute-enum-display-name is a placeholder that can be
                    /// replaced with any user defined enum attribute enum name. *
                    /// `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.string_values.values` - The allowed value of the user
                    /// defined string attribute associated with the Resource. Allowed comparison operator is `:`. Here
                    /// user-defined-attribute-string is a placeholder that can be replaced with any user defined string
                    /// attribute name. * `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.json_values.values` - The allowed value of the user defined
                    /// JSON attribute associated with the Resource. Allowed comparison operator is `:`. Here
                    /// user-defined-attribute-json is a placeholder that can be replaced with any user defined JSON
                    /// attribute name. A filter function is also supported in the filter string. The filter function is
                    /// `id(name)`. The `id(name)` function returns the id of the resource name. For example, `id(name)
                    /// = \"api-1\"` is equivalent to `name =
                    /// \"projects/test-project-id/locations/test-location-id/apis/api-1\"` provided the parent is
                    /// `projects/test-project-id/locations/test-location-id`. Expressions are combined with either
                    /// `AND` logic operator or `OR` logical operator but not both of them together i.e. only one of the
                    /// `AND` or `OR` operator can be used throughout the filter string and both the operators cannot be
                    /// used together. No other logical operators are supported. At most three filter fields are allowed
                    /// in the filter string and if provided more than that then `INVALID_ARGUMENT` error is returned by
                    /// the API. Here are a few examples: * `owner.email = \"apihub@google.com\"` - - The owner team
                    /// email is _apihub@google.com_. * `owner.email = \"apihub@google.com\" AND create_time &amp;lt;
                    /// \"2021-08-15T14:50:00Z\" AND create_time &amp;gt; \"2021-08-10T12:00:00Z\"` - The owner team
                    /// email is _apihub@google.com_ and the api was created before _2021-08-15 14:50:00 UTC_ and after
                    /// _2021-08-10 12:00:00 UTC_. * `owner.email = \"apihub@google.com\" OR team.enum_values.values.id:
                    /// apihub-team-id` - The filter string specifies the APIs where the owner team email is
                    /// _apihub@google.com_ or the id of the allowed value associated with the team attribute is
                    /// _apihub-team-id_. * `owner.email = \"apihub@google.com\" OR
                    /// team.enum_values.values.display_name: ApiHub Team` - The filter string specifies the APIs where
                    /// the owner team email is _apihub@google.com_ or the display name of the allowed value associated
                    /// with the team attribute is `ApiHub Team`. * `owner.email = \"apihub@google.com\" AND
                    /// attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/17650f90-4a29-4971-b3c0-d5532da3764b.enum_values.values.id: test_enum_id AND
                    /// attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/1765\0f90-4a29-5431-b3d0-d5532da3764c.string_values.values: test_string_value` - The
                    /// filter string specifies the APIs where the owner team email is _apihub@google.com_ and the id of
                    /// the allowed value associated with the user defined attribute of type enum is _test_enum_id_ and
                    /// the value of the user defined attribute of type string is _test_..
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of API resources to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 Apis will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListApis` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters (except page_size) provided to `ListApis`
                    /// must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apis";

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

                /// <summary>
                /// Update an API resource in the API hub. The following fields in the API can be updated: *
                /// display_name * description * owner * documentation * target_user * team * business_unit *
                /// maturity_level * api_style * attributes The update_mask should be used to specify the fields being
                /// updated. Updating the owner field requires complete owner message and updates both owner and email
                /// fields.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the API resource in the API Hub. Format:
                /// `projects/{project}/locations/{location}/apis/{api}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Update an API resource in the API hub. The following fields in the API can be updated: *
                /// display_name * description * owner * documentation * target_user * team * business_unit *
                /// maturity_level * api_style * attributes The update_mask should be used to specify the fields being
                /// updated. Updating the owner field requires complete owner message and updates both owner and email
                /// fields.
                /// </summary>
                public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the API resource in the API Hub. Format:
                    /// `projects/{project}/locations/{location}/apis/{api}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Api Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apis/[^/]+$",
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

            /// <summary>Gets the Attributes resource.</summary>
            public virtual AttributesResource Attributes { get; }

            /// <summary>The "attributes" collection of methods.</summary>
            public class AttributesResource
            {
                private const string Resource = "attributes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AttributesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Create a user defined attribute. Certain pre defined attributes are already created by the API hub.
                /// These attributes will have type as `SYSTEM_DEFINED` and can be listed via ListAttributes method.
                /// Allowed values for the same can be updated via UpdateAttribute method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for Attribute. Format: `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create a user defined attribute. Certain pre defined attributes are already created by the API hub.
                /// These attributes will have type as `SYSTEM_DEFINED` and can be listed via ListAttributes method.
                /// Allowed values for the same can be updated via UpdateAttribute method.
                /// </summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for Attribute. Format: `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the attribute, which will become the final component of the
                    /// attribute's resource name. This field is optional. * If provided, the same will be used. The
                    /// service will throw an error if the specified id is already used by another attribute resource in
                    /// the API hub. * If not provided, a system generated id will be used. This value should be 4-500
                    /// characters, and valid characters are /a-z[0-9]-_/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("attributeId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AttributeId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/attributes";

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
                        RequestParameters.Add("attributeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "attributeId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Delete an attribute. Note: System defined attributes cannot be deleted. All associations of the
                /// attribute being deleted with any API hub resource will also get deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the attribute to delete. Format:
                /// `projects/{project}/locations/{location}/attributes/{attribute}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Delete an attribute. Note: System defined attributes cannot be deleted. All associations of the
                /// attribute being deleted with any API hub resource will also get deleted.
                /// </summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the attribute to delete. Format:
                    /// `projects/{project}/locations/{location}/attributes/{attribute}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/attributes/[^/]+$",
                        });
                    }
                }

                /// <summary>Get details about the attribute.</summary>
                /// <param name="name">
                /// Required. The name of the attribute to retrieve. Format:
                /// `projects/{project}/locations/{location}/attributes/{attribute}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get details about the attribute.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the attribute to retrieve. Format:
                    /// `projects/{project}/locations/{location}/attributes/{attribute}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/attributes/[^/]+$",
                        });
                    }
                }

                /// <summary>List all attributes.</summary>
                /// <param name="parent">
                /// Required. The parent resource for Attribute. Format: `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List all attributes.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListAttributesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for Attribute. Format: `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of Attributes. A filter expression consists of a
                    /// field name, a comparison operator, and a value for filtering. The value must be a string or a
                    /// boolean. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;` or `=`. Filters are not
                    /// case sensitive. The following fields in the `Attribute` are eligible for filtering: *
                    /// `display_name` - The display name of the Attribute. Allowed comparison operators: `=`. *
                    /// `definition_type` - The definition type of the attribute. Allowed comparison operators: `=`. *
                    /// `scope` - The scope of the attribute. Allowed comparison operators: `=`. * `data_type` - The
                    /// type of the data of the attribute. Allowed comparison operators: `=`. * `mandatory` - Denotes
                    /// whether the attribute is mandatory or not. Allowed comparison operators: `=`. * `create_time` -
                    /// The time at which the Attribute was created. The value should be in the
                    /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. Allowed comparison operators: `&amp;gt;`
                    /// and `&amp;lt;`. Expressions are combined with either `AND` logic operator or `OR` logical
                    /// operator but not both of them together i.e. only one of the `AND` or `OR` operator can be used
                    /// throughout the filter string and both the operators cannot be used together. No other logical
                    /// operators are supported. At most three filter fields are allowed in the filter string and if
                    /// provided more than that then `INVALID_ARGUMENT` error is returned by the API. Here are a few
                    /// examples: * `display_name = production` - - The display name of the attribute is _production_. *
                    /// `(display_name = production) AND (create_time &amp;lt; \"2021-08-15T14:50:00Z\") AND
                    /// (create_time &amp;gt; \"2021-08-10T12:00:00Z\")` - The display name of the attribute is
                    /// _production_ and the attribute was created before _2021-08-15 14:50:00 UTC_ and after
                    /// _2021-08-10 12:00:00 UTC_. * `display_name = production OR scope = api` - The attribute where
                    /// the display name is _production_ or the scope is _api_.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of attribute resources to return. The service may return fewer than
                    /// this value. If unspecified, at most 50 attributes will be returned. The maximum value is 1000;
                    /// values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListAttributes` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListAttributes` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/attributes";

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

                /// <summary>
                /// Update the attribute. The following fields in the Attribute resource can be updated: * display_name
                /// The display name can be updated for user defined attributes only. * description The description can
                /// be updated for user defined attributes only. * allowed_values To update the list of allowed values,
                /// clients need to use the fetched list of allowed values and add or remove values to or from the same
                /// list. The mutable allowed values can be updated for both user defined and System defined attributes.
                /// The immutable allowed values cannot be updated or deleted. The updated list of allowed values cannot
                /// be empty. If an allowed value that is already used by some resource's attribute is deleted, then the
                /// association between the resource and the attribute value will also be deleted. * cardinality The
                /// cardinality can be updated for user defined attributes only. Cardinality can only be increased
                /// during an update. The update_mask should be used to specify the fields being updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the attribute in the API Hub. Format:
                /// `projects/{project}/locations/{location}/attributes/{attribute}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Update the attribute. The following fields in the Attribute resource can be updated: * display_name
                /// The display name can be updated for user defined attributes only. * description The description can
                /// be updated for user defined attributes only. * allowed_values To update the list of allowed values,
                /// clients need to use the fetched list of allowed values and add or remove values to or from the same
                /// list. The mutable allowed values can be updated for both user defined and System defined attributes.
                /// The immutable allowed values cannot be updated or deleted. The updated list of allowed values cannot
                /// be empty. If an allowed value that is already used by some resource's attribute is deleted, then the
                /// association between the resource and the attribute value will also be deleted. * cardinality The
                /// cardinality can be updated for user defined attributes only. Cardinality can only be increased
                /// during an update. The update_mask should be used to specify the fields being updated.
                /// </summary>
                public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the attribute in the API Hub. Format:
                    /// `projects/{project}/locations/{location}/attributes/{attribute}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Attribute Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/attributes/[^/]+$",
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

            /// <summary>Gets the Curations resource.</summary>
            public virtual CurationsResource Curations { get; }

            /// <summary>The "curations" collection of methods.</summary>
            public class CurationsResource
            {
                private const string Resource = "curations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CurationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Create a curation resource in the API hub. Once a curation resource is created, plugin instances can
                /// start using it.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the curation resource. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create a curation resource in the API hub. Once a curation resource is created, plugin instances can
                /// start using it.
                /// </summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the curation resource. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the curation resource, which will become the final component of the
                    /// curations's resource name. This field is optional. * If provided, the same will be used. The
                    /// service will throw an error if the specified ID is already used by another curation resource in
                    /// the API hub. * If not provided, a system generated ID will be used. This value should be 4-500
                    /// characters, and valid characters are /a-z[0-9]-_/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("curationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CurationId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/curations";

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
                        RequestParameters.Add("curationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "curationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Delete a curation resource in the API hub. A curation can only be deleted if it's not being used by
                /// any plugin instance.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the curation resource to delete. Format:
                /// `projects/{project}/locations/{location}/curations/{curation}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Delete a curation resource in the API hub. A curation can only be deleted if it's not being used by
                /// any plugin instance.
                /// </summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the curation resource to delete. Format:
                    /// `projects/{project}/locations/{location}/curations/{curation}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/curations/[^/]+$",
                        });
                    }
                }

                /// <summary>Get curation resource details.</summary>
                /// <param name="name">
                /// Required. The name of the curation resource to retrieve. Format:
                /// `projects/{project}/locations/{location}/curations/{curation}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get curation resource details.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the curation resource to retrieve. Format:
                    /// `projects/{project}/locations/{location}/curations/{curation}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/curations/[^/]+$",
                        });
                    }
                }

                /// <summary>List curation resources in the API hub.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of curation resources. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List curation resources in the API hub.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListCurationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of curation resources. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of curation resources. A filter expression
                    /// consists of a field name, a comparison operator, and a value for filtering. The value must be a
                    /// string. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;`, `:` or `=`. Filters are
                    /// case insensitive. The following fields in the `curation resource` are eligible for filtering: *
                    /// `create_time` - The time at which the curation was created. The value should be in the
                    /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. Allowed comparison operators: `&amp;gt;`
                    /// and `&amp;lt;`. * `display_name` - The display name of the curation. Allowed comparison
                    /// operators: `=`. * `state` - The state of the curation. Allowed comparison operators: `=`.
                    /// Expressions are combined with either `AND` logic operator or `OR` logical operator but not both
                    /// of them together i.e. only one of the `AND` or `OR` operator can be used throughout the filter
                    /// string and both the operators cannot be used together. No other logical operators are supported.
                    /// At most three filter fields are allowed in the filter string and if provided more than that then
                    /// `INVALID_ARGUMENT` error is returned by the API. Here are a few examples: * `create_time
                    /// &amp;lt; \"2021-08-15T14:50:00Z\" AND create_time &amp;gt; \"2021-08-10T12:00:00Z\"` - The
                    /// curation resource was created before _2021-08-15 14:50:00 UTC_ and after _2021-08-10 12:00:00
                    /// UTC_.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of curation resources to return. The service may return fewer than
                    /// this value. If unspecified, at most 50 curations will be returned. The maximum value is 1000;
                    /// values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListCurations` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters (except page_size) provided to
                    /// `ListCurations` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/curations";

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

                /// <summary>
                /// Update a curation resource in the API hub. The following fields in the curation can be updated: *
                /// display_name * description The update_mask should be used to specify the fields being updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the curation. Format:
                /// `projects/{project}/locations/{location}/curations/{curation}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Update a curation resource in the API hub. The following fields in the curation can be updated: *
                /// display_name * description The update_mask should be used to specify the fields being updated.
                /// </summary>
                public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the curation. Format:
                    /// `projects/{project}/locations/{location}/curations/{curation}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Curation Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/curations/[^/]+$",
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

            /// <summary>Gets the Dependencies resource.</summary>
            public virtual DependenciesResource Dependencies { get; }

            /// <summary>The "dependencies" collection of methods.</summary>
            public class DependenciesResource
            {
                private const string Resource = "dependencies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DependenciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a dependency between two entities in the API hub.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the dependency resource. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a dependency between two entities in the API hub.</summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the dependency resource. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the dependency resource, which will become the final component of
                    /// the dependency's resource name. This field is optional. * If provided, the same will be used.
                    /// The service will throw an error if duplicate id is provided by the client. * If not provided, a
                    /// system generated id will be used. This value should be 4-500 characters, and valid characters
                    /// are `a-z[0-9]-_`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dependencyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DependencyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dependencies";

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
                        RequestParameters.Add("dependencyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dependencyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete the dependency resource.</summary>
                /// <param name="name">
                /// Required. The name of the dependency resource to delete. Format:
                /// `projects/{project}/locations/{location}/dependencies/{dependency}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete the dependency resource.</summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the dependency resource to delete. Format:
                    /// `projects/{project}/locations/{location}/dependencies/{dependency}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dependencies/[^/]+$",
                        });
                    }
                }

                /// <summary>Get details about a dependency resource in the API hub.</summary>
                /// <param name="name">
                /// Required. The name of the dependency resource to retrieve. Format:
                /// `projects/{project}/locations/{location}/dependencies/{dependency}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get details about a dependency resource in the API hub.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the dependency resource to retrieve. Format:
                    /// `projects/{project}/locations/{location}/dependencies/{dependency}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dependencies/[^/]+$",
                        });
                    }
                }

                /// <summary>List dependencies based on the provided filter and pagination parameters.</summary>
                /// <param name="parent">
                /// Required. The parent which owns this collection of dependency resources. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List dependencies based on the provided filter and pagination parameters.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListDependenciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent which owns this collection of dependency resources. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of Dependencies. A filter expression consists of a
                    /// field name, a comparison operator, and a value for filtering. The value must be a string.
                    /// Allowed comparison operator is `=`. Filters are not case sensitive. The following fields in the
                    /// `Dependency` are eligible for filtering: * `consumer.operation_resource_name` - The operation
                    /// resource name for the consumer entity involved in a dependency. Allowed comparison operators:
                    /// `=`. * `consumer.external_api_resource_name` - The external api resource name for the consumer
                    /// entity involved in a dependency. Allowed comparison operators: `=`. *
                    /// `supplier.operation_resource_name` - The operation resource name for the supplier entity
                    /// involved in a dependency. Allowed comparison operators: `=`. *
                    /// `supplier.external_api_resource_name` - The external api resource name for the supplier entity
                    /// involved in a dependency. Allowed comparison operators: `=`. Expressions are combined with
                    /// either `AND` logic operator or `OR` logical operator but not both of them together i.e. only one
                    /// of the `AND` or `OR` operator can be used throughout the filter string and both the operators
                    /// cannot be used together. No other logical operators are supported. At most three filter fields
                    /// are allowed in the filter string and if provided more than that then `INVALID_ARGUMENT` error is
                    /// returned by the API. For example, `consumer.operation_resource_name =
                    /// \"projects/p1/locations/global/apis/a1/versions/v1/operations/o1\" OR
                    /// supplier.operation_resource_name =
                    /// \"projects/p1/locations/global/apis/a1/versions/v1/operations/o1\"` - The dependencies with
                    /// either consumer or supplier operation resource name as
                    /// _projects/p1/locations/global/apis/a1/versions/v1/operations/o1_.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of dependency resources to return. The service may return fewer
                    /// than this value. If unspecified, at most 50 dependencies will be returned. The maximum value is
                    /// 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListDependencies` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListDependencies` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dependencies";

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

                /// <summary>
                /// Update a dependency based on the update_mask provided in the request. The following fields in the
                /// dependency can be updated: * description
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the dependency in the API Hub. Format:
                /// `projects/{project}/locations/{location}/dependencies/{dependency}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Update a dependency based on the update_mask provided in the request. The following fields in the
                /// dependency can be updated: * description
                /// </summary>
                public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the dependency in the API Hub. Format:
                    /// `projects/{project}/locations/{location}/dependencies/{dependency}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Dependency Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dependencies/[^/]+$",
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

            /// <summary>Gets the Deployments resource.</summary>
            public virtual DeploymentsResource Deployments { get; }

            /// <summary>The "deployments" collection of methods.</summary>
            public class DeploymentsResource
            {
                private const string Resource = "deployments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DeploymentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Create a deployment resource in the API hub. Once a deployment resource is created, it can be
                /// associated with API versions.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the deployment resource. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create a deployment resource in the API hub. Once a deployment resource is created, it can be
                /// associated with API versions.
                /// </summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the deployment resource. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the deployment resource, which will become the final component of
                    /// the deployment's resource name. This field is optional. * If provided, the same will be used.
                    /// The service will throw an error if the specified id is already used by another deployment
                    /// resource in the API hub. * If not provided, a system generated id will be used. This value
                    /// should be 4-500 characters, and valid characters are /a-z[0-9]-_/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("deploymentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DeploymentId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deployments";

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
                        RequestParameters.Add("deploymentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "deploymentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete a deployment resource in the API hub.</summary>
                /// <param name="name">
                /// Required. The name of the deployment resource to delete. Format:
                /// `projects/{project}/locations/{location}/deployments/{deployment}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a deployment resource in the API hub.</summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the deployment resource to delete. Format:
                    /// `projects/{project}/locations/{location}/deployments/{deployment}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Get details about a deployment and the API versions linked to it.</summary>
                /// <param name="name">
                /// Required. The name of the deployment resource to retrieve. Format:
                /// `projects/{project}/locations/{location}/deployments/{deployment}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get details about a deployment and the API versions linked to it.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the deployment resource to retrieve. Format:
                    /// `projects/{project}/locations/{location}/deployments/{deployment}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
                        });
                    }
                }

                /// <summary>List deployment resources in the API hub.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of deployment resources. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List deployment resources in the API hub.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListDeploymentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of deployment resources. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of Deployments. A filter expression consists of a
                    /// field name, a comparison operator, and a value for filtering. The value must be a string. The
                    /// comparison operator must be one of: `&amp;lt;`, `&amp;gt;` or `=`. Filters are not case
                    /// sensitive. The following fields in the `Deployments` are eligible for filtering: *
                    /// `display_name` - The display name of the Deployment. Allowed comparison operators: `=`. *
                    /// `create_time` - The time at which the Deployment was created. The value should be in the
                    /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. Allowed comparison operators: `&amp;gt;`
                    /// and `&amp;lt;`. * `resource_uri` - A URI to the deployment resource. Allowed comparison
                    /// operators: `=`. * `api_versions` - The API versions linked to this deployment. Allowed
                    /// comparison operators: `:`. * `deployment_type.enum_values.values.id` - The allowed value id of
                    /// the deployment_type attribute associated with the Deployment. Allowed comparison operators: `:`.
                    /// * `deployment_type.enum_values.values.display_name` - The allowed value display name of the
                    /// deployment_type attribute associated with the Deployment. Allowed comparison operators: `:`. *
                    /// `slo.string_values.values` -The allowed string value of the slo attribute associated with the
                    /// deployment. Allowed comparison operators: `:`. * `environment.enum_values.values.id` - The
                    /// allowed value id of the environment attribute associated with the deployment. Allowed comparison
                    /// operators: `:`. * `environment.enum_values.values.display_name` - The allowed value display name
                    /// of the environment attribute associated with the deployment. Allowed comparison operators: `:`.
                    /// * `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.enum_values.values.id` - The allowed value id of the user
                    /// defined enum attribute associated with the Resource. Allowed comparison operator is `:`. Here
                    /// user-defined-attribute-enum-id is a placeholder that can be replaced with any user defined enum
                    /// attribute name. * `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.enum_values.values.display_name` - The allowed value
                    /// display name of the user defined enum attribute associated with the Resource. Allowed comparison
                    /// operator is `:`. Here user-defined-attribute-enum-display-name is a placeholder that can be
                    /// replaced with any user defined enum attribute enum name. *
                    /// `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.string_values.values` - The allowed value of the user
                    /// defined string attribute associated with the Resource. Allowed comparison operator is `:`. Here
                    /// user-defined-attribute-string is a placeholder that can be replaced with any user defined string
                    /// attribute name. * `attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/user-defined-attribute-id.json_values.values` - The allowed value of the user defined
                    /// JSON attribute associated with the Resource. Allowed comparison operator is `:`. Here
                    /// user-defined-attribute-json is a placeholder that can be replaced with any user defined JSON
                    /// attribute name. A filter function is also supported in the filter string. The filter function is
                    /// `id(name)`. The `id(name)` function returns the id of the resource name. For example, `id(name)
                    /// = \"deployment-1\"` is equivalent to `name =
                    /// \"projects/test-project-id/locations/test-location-id/deployments/deployment-1\"` provided the
                    /// parent is `projects/test-project-id/locations/test-location-id`. Expressions are combined with
                    /// either `AND` logic operator or `OR` logical operator but not both of them together i.e. only one
                    /// of the `AND` or `OR` operator can be used throughout the filter string and both the operators
                    /// cannot be used together. No other logical operators are supported. At most three filter fields
                    /// are allowed in the filter string and if provided more than that then `INVALID_ARGUMENT` error is
                    /// returned by the API. Here are a few examples: * `environment.enum_values.values.id: staging-id`
                    /// - The allowed value id of the environment attribute associated with the Deployment is
                    /// _staging-id_. * `environment.enum_values.values.display_name: \"Staging Deployment\"` - The
                    /// allowed value display name of the environment attribute associated with the Deployment is
                    /// `Staging Deployment`. * `environment.enum_values.values.id: production-id AND create_time
                    /// &amp;lt; \"2021-08-15T14:50:00Z\" AND create_time &amp;gt; \"2021-08-10T12:00:00Z\"` - The
                    /// allowed value id of the environment attribute associated with the Deployment is _production-id_
                    /// and Deployment was created before _2021-08-15 14:50:00 UTC_ and after _2021-08-10 12:00:00 UTC_.
                    /// * `environment.enum_values.values.id: production-id OR slo.string_values.values: \"99.99%\"` -
                    /// The allowed value id of the environment attribute Deployment is _production-id_ or string value
                    /// of the slo attribute is _99.99%_. * `environment.enum_values.values.id: staging-id AND
                    /// attributes.projects/test-project-id/locations/test-location-id/
                    /// attributes/17650f90-4a29-4971-b3c0-d5532da3764b.string_values.values: test` - The filter string
                    /// specifies that the allowed value id of the environment attribute associated with the Deployment
                    /// is _staging-id_ and the value of the user defined attribute of type string is _test_.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of deployment resources to return. The service may return fewer
                    /// than this value. If unspecified, at most 50 deployments will be returned. The maximum value is
                    /// 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListDeployments` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters (except page_size) provided
                    /// to `ListDeployments` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deployments";

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

                /// <summary>
                /// Update a deployment resource in the API hub. The following fields in the deployment resource can be
                /// updated: * display_name * description * documentation * deployment_type * resource_uri * endpoints *
                /// slo * environment * attributes * source_project * source_environment * management_url * source_uri
                /// The update_mask should be used to specify the fields being updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the deployment. Format:
                /// `projects/{project}/locations/{location}/deployments/{deployment}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Update a deployment resource in the API hub. The following fields in the deployment resource can be
                /// updated: * display_name * description * documentation * deployment_type * resource_uri * endpoints *
                /// slo * environment * attributes * source_project * source_environment * management_url * source_uri
                /// The update_mask should be used to specify the fields being updated.
                /// </summary>
                public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the deployment. Format:
                    /// `projects/{project}/locations/{location}/deployments/{deployment}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Deployment Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployments/[^/]+$",
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

            /// <summary>Gets the ExternalApis resource.</summary>
            public virtual ExternalApisResource ExternalApis { get; }

            /// <summary>The "externalApis" collection of methods.</summary>
            public class ExternalApisResource
            {
                private const string Resource = "externalApis";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ExternalApisResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create an External API resource in the API hub.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the External API resource. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create an External API resource in the API hub.</summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the External API resource. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the External API resource, which will become the final component of
                    /// the External API's resource name. This field is optional. * If provided, the same will be used.
                    /// The service will throw an error if the specified id is already used by another External API
                    /// resource in the API hub. * If not provided, a system generated id will be used. This value
                    /// should be 4-500 characters, and valid characters are /a-z[0-9]-_/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("externalApiId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ExternalApiId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/externalApis";

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
                        RequestParameters.Add("externalApiId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "externalApiId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete an External API resource in the API hub.</summary>
                /// <param name="name">
                /// Required. The name of the External API resource to delete. Format:
                /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete an External API resource in the API hub.</summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the External API resource to delete. Format:
                    /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/externalApis/[^/]+$",
                        });
                    }
                }

                /// <summary>Get details about an External API resource in the API hub.</summary>
                /// <param name="name">
                /// Required. The name of the External API resource to retrieve. Format:
                /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get details about an External API resource in the API hub.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the External API resource to retrieve. Format:
                    /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/externalApis/[^/]+$",
                        });
                    }
                }

                /// <summary>List External API resources in the API hub.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of External API resources. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List External API resources in the API hub.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListExternalApisResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of External API resources. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of External API resources to return. The service may return fewer
                    /// than this value. If unspecified, at most 50 ExternalApis will be returned. The maximum value is
                    /// 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListExternalApis` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters (except page_size) provided
                    /// to `ListExternalApis` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/externalApis";

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
                /// Update an External API resource in the API hub. The following fields can be updated: * display_name
                /// * description * documentation * endpoints * paths The update_mask should be used to specify the
                /// fields being updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Format: `projects/{project}/locations/{location}/externalApi/{externalApi}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Update an External API resource in the API hub. The following fields can be updated: * display_name
                /// * description * documentation * endpoints * paths The update_mask should be used to specify the
                /// fields being updated.
                /// </summary>
                public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Format: `projects/{project}/locations/{location}/externalApi/{externalApi}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExternalApi Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/externalApis/[^/]+$",
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

            /// <summary>Gets the HostProjectRegistrations resource.</summary>
            public virtual HostProjectRegistrationsResource HostProjectRegistrations { get; }

            /// <summary>The "hostProjectRegistrations" collection of methods.</summary>
            public class HostProjectRegistrationsResource
            {
                private const string Resource = "hostProjectRegistrations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public HostProjectRegistrationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Create a host project registration. A Google cloud project can be registered as a host project if it
                /// is not attached as a runtime project to another host project. A project can be registered as a host
                /// project only once. Subsequent register calls for the same project will fail.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the host project. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1HostProjectRegistration body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create a host project registration. A Google cloud project can be registered as a host project if it
                /// is not attached as a runtime project to another host project. A project can be registered as a host
                /// project only once. Subsequent register calls for the same project will fail.
                /// </summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1HostProjectRegistration>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1HostProjectRegistration body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the host project. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the Host Project Registration, which will become the final component
                    /// of the host project registration's resource name. The ID must be the same as the Google cloud
                    /// project specified in the host_project_registration.gcp_project field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("hostProjectRegistrationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string HostProjectRegistrationId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1HostProjectRegistration Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/hostProjectRegistrations";

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
                        RequestParameters.Add("hostProjectRegistrationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "hostProjectRegistrationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get a host project registration.</summary>
                /// <param name="name">
                /// Required. Host project registration resource name.
                /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get a host project registration.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1HostProjectRegistration>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Host project registration resource name.
                    /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/hostProjectRegistrations/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists host project registrations.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of host projects. Format: `projects/*/locations/*`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists host project registrations.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListHostProjectRegistrationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of host projects. Format:
                    /// `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of HostProjectRegistrations. A filter expression
                    /// consists of a field name, a comparison operator, and a value for filtering. The value must be a
                    /// string. All standard operators as documented at https://google.aip.dev/160 are supported. The
                    /// following fields in the `HostProjectRegistration` are eligible for filtering: * `name` - The
                    /// name of the HostProjectRegistration. * `create_time` - The time at which the
                    /// HostProjectRegistration was created. The value should be in the
                    /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. * `gcp_project` - The Google cloud
                    /// project associated with the HostProjectRegistration.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of host project registrations to return. The service may return
                    /// fewer than this value. If unspecified, at most 50 host project registrations will be returned.
                    /// The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListHostProjectRegistrations` call. Provide
                    /// this to retrieve the subsequent page. When paginating, all other parameters (except page_size)
                    /// provided to `ListHostProjectRegistrations` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/hostProjectRegistrations";

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
                public virtual CancelRequest Cancel(Google.Apis.APIhub.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
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
                public class CancelRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
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
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
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
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningListOperationsResponse>
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

            /// <summary>Gets the Plugins resource.</summary>
            public virtual PluginsResource Plugins { get; }

            /// <summary>The "plugins" collection of methods.</summary>
            public class PluginsResource
            {
                private const string Resource = "plugins";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PluginsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Instances = new InstancesResource(service);
                    StyleGuide = new StyleGuideResource(service);
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
                    }

                    /// <summary>Creates a Plugin instance in the API hub.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent of the plugin instance resource. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a Plugin instance in the API hub.</summary>
                    public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent of the plugin instance resource. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the plugin instance, which will become the final component of
                        /// the plugin instance's resource name. This field is optional. * If provided, the same will be
                        /// used. The service will throw an error if the specified id is already used by another plugin
                        /// instance in the plugin resource. * If not provided, a system generated id will be used. This
                        /// value should be 4-63 characters, and valid characters are /a-z[0-9]-_/.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pluginInstanceId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PluginInstanceId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/instances";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+$",
                            });
                            RequestParameters.Add("pluginInstanceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pluginInstanceId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a plugin instance in the API hub.</summary>
                    /// <param name="name">
                    /// Required. The name of the plugin instance to delete. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a plugin instance in the API hub.</summary>
                    public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the plugin instance to delete. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/instances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Disables a plugin instance in the API hub.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the plugin instance to disable. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                    /// </param>
                    public virtual DisableActionRequest DisableAction(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1DisablePluginInstanceActionRequest body, string name)
                    {
                        return new DisableActionRequest(this.service, body, name);
                    }

                    /// <summary>Disables a plugin instance in the API hub.</summary>
                    public class DisableActionRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new DisableAction request.</summary>
                        public DisableActionRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1DisablePluginInstanceActionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the plugin instance to disable. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1DisablePluginInstanceActionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "disableAction";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:disableAction";

                        /// <summary>Initializes DisableAction parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/instances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Enables a plugin instance in the API hub.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the plugin instance to enable. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                    /// </param>
                    public virtual EnableActionRequest EnableAction(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1EnablePluginInstanceActionRequest body, string name)
                    {
                        return new EnableActionRequest(this.service, body, name);
                    }

                    /// <summary>Enables a plugin instance in the API hub.</summary>
                    public class EnableActionRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new EnableAction request.</summary>
                        public EnableActionRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1EnablePluginInstanceActionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the plugin instance to enable. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1EnablePluginInstanceActionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "enableAction";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:enableAction";

                        /// <summary>Initializes EnableAction parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/instances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Executes a plugin instance in the API hub.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the plugin instance to execute. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                    /// </param>
                    public virtual ExecuteActionRequest ExecuteAction(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExecutePluginInstanceActionRequest body, string name)
                    {
                        return new ExecuteActionRequest(this.service, body, name);
                    }

                    /// <summary>Executes a plugin instance in the API hub.</summary>
                    public class ExecuteActionRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new ExecuteAction request.</summary>
                        public ExecuteActionRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExecutePluginInstanceActionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the plugin instance to execute. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ExecutePluginInstanceActionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "executeAction";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:executeAction";

                        /// <summary>Initializes ExecuteAction parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/instances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Get an API Hub plugin instance.</summary>
                    /// <param name="name">
                    /// Required. The name of the plugin instance to retrieve. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Get an API Hub plugin instance.</summary>
                    public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the plugin instance to retrieve. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/instances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// List all the plugins in a given project and location. `-` can be used as wildcard value for
                    /// {plugin_id}
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent resource where this plugin will be created. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}`. To list plugin instances for
                    /// multiple plugins, use the - character instead of the plugin ID.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// List all the plugins in a given project and location. `-` can be used as wildcard value for
                    /// {plugin_id}
                    /// </summary>
                    public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListPluginInstancesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this plugin will be created. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}`. To list plugin instances for
                        /// multiple plugins, use the - character instead of the plugin ID.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. An expression that filters the list of plugin instances. A filter expression
                        /// consists of a field name, a comparison operator, and a value for filtering. The value must
                        /// be a string. The comparison operator must be one of: `&amp;lt;`, `&amp;gt;` or `=`. Filters
                        /// are not case sensitive. The following fields in the `PluginInstances` are eligible for
                        /// filtering: * `state` - The state of the Plugin Instance. Allowed comparison operators: `=`.
                        /// A filter function is also supported in the filter string. The filter function is `id(name)`.
                        /// The `id(name)` function returns the id of the resource name. For example, `id(name) =
                        /// \"plugin-instance-1\"` is equivalent to `name =
                        /// \"projects/test-project-id/locations/test-location-id/plugins/plugin-1/instances/plugin-instance-1\"`
                        /// provided the parent is
                        /// `projects/test-project-id/locations/test-location-id/plugins/plugin-1`. Expressions are
                        /// combined with either `AND` logic operator or `OR` logical operator but not both of them
                        /// together i.e. only one of the `AND` or `OR` operator can be used throughout the filter
                        /// string and both the operators cannot be used together. No other logical operators are
                        /// supported. At most three filter fields are allowed in the filter string and if provided more
                        /// than that then `INVALID_ARGUMENT` error is returned by the API. Here are a few examples: *
                        /// `state = ENABLED` - The plugin instance is in enabled state.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of hub plugins to return. The service may return fewer than
                        /// this value. If unspecified, at most 50 hub plugins will be returned. The maximum value is
                        /// 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListPluginInstances` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListPluginInstances` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/instances";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+$",
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
                    /// Updates a plugin instance in the API hub. The following fields in the plugin_instance can be
                    /// updated currently: * display_name * schedule_cron_expression The update_mask should be used to
                    /// specify the fields being updated. To update the auth_config and additional_config of the plugin
                    /// instance, use the ApplyPluginInstanceConfig method.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The unique name of the plugin instance resource. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates a plugin instance in the API hub. The following fields in the plugin_instance can be
                    /// updated currently: * display_name * schedule_cron_expression The update_mask should be used to
                    /// specify the fields being updated. To update the auth_config and additional_config of the plugin
                    /// instance, use the ApplyPluginInstanceConfig method.
                    /// </summary>
                    public class PatchRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The unique name of the plugin instance resource. Format:
                        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1PluginInstance Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/instances/[^/]+$",
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

                /// <summary>Gets the StyleGuide resource.</summary>
                public virtual StyleGuideResource StyleGuide { get; }

                /// <summary>The "styleGuide" collection of methods.</summary>
                public class StyleGuideResource
                {
                    private const string Resource = "styleGuide";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public StyleGuideResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Get the contents of the style guide.</summary>
                    /// <param name="name">
                    /// Required. The name of the StyleGuide whose contents need to be retrieved. There is exactly one
                    /// style guide resource per project per location. The expected format is
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
                    /// </param>
                    public virtual GetContentsRequest GetContents(string name)
                    {
                        return new GetContentsRequest(this.service, name);
                    }

                    /// <summary>Get the contents of the style guide.</summary>
                    public class GetContentsRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1StyleGuideContents>
                    {
                        /// <summary>Constructs a new GetContents request.</summary>
                        public GetContentsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the StyleGuide whose contents need to be retrieved. There is exactly
                        /// one style guide resource per project per location. The expected format is
                        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getContents";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:contents";

                        /// <summary>Initializes GetContents parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/styleGuide$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Create an API Hub plugin resource in the API hub. Once a plugin is created, it can be used to create
                /// plugin instances.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this plugin will be created. Format:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Plugin body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Create an API Hub plugin resource in the API hub. Once a plugin is created, it can be used to create
                /// plugin instances.
                /// </summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Plugin>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Plugin body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this plugin will be created. Format:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the Plugin resource, which will become the final component of the
                    /// Plugin's resource name. This field is optional. * If provided, the same will be used. The
                    /// service will throw an error if the specified id is already used by another Plugin resource in
                    /// the API hub instance. * If not provided, a system generated id will be used. This value should
                    /// be 4-63 characters, overall resource name which will be of format
                    /// `projects/{project}/locations/{location}/plugins/{plugin}`, its length is limited to 1000
                    /// characters and valid characters are /a-z[0-9]-_/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pluginId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PluginId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Plugin Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/plugins";

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
                        RequestParameters.Add("pluginId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pluginId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Delete a Plugin in API hub. Note, only user owned plugins can be deleted via this method.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the Plugin resource to delete. Format:
                /// `projects/{project}/locations/{location}/plugins/{plugin}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Delete a Plugin in API hub. Note, only user owned plugins can be deleted via this method.
                /// </summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Plugin resource to delete. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+$",
                        });
                    }
                }

                /// <summary>Disables a plugin. The `state` of the plugin after disabling is `DISABLED`</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the plugin to disable. Format:
                /// `projects/{project}/locations/{location}/plugins/{plugin}`.
                /// </param>
                public virtual DisableRequest Disable(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1DisablePluginRequest body, string name)
                {
                    return new DisableRequest(this.service, body, name);
                }

                /// <summary>Disables a plugin. The `state` of the plugin after disabling is `DISABLED`</summary>
                public class DisableRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Plugin>
                {
                    /// <summary>Constructs a new Disable request.</summary>
                    public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1DisablePluginRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the plugin to disable. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1DisablePluginRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+$",
                        });
                    }
                }

                /// <summary>Enables a plugin. The `state` of the plugin after enabling is `ENABLED`</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the plugin to enable. Format:
                /// `projects/{project}/locations/{location}/plugins/{plugin}`.
                /// </param>
                public virtual EnableRequest Enable(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1EnablePluginRequest body, string name)
                {
                    return new EnableRequest(this.service, body, name);
                }

                /// <summary>Enables a plugin. The `state` of the plugin after enabling is `ENABLED`</summary>
                public class EnableRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Plugin>
                {
                    /// <summary>Constructs a new Enable request.</summary>
                    public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1EnablePluginRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the plugin to enable. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1EnablePluginRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+$",
                        });
                    }
                }

                /// <summary>Get an API Hub plugin.</summary>
                /// <param name="name">
                /// Required. The name of the plugin to retrieve. Format:
                /// `projects/{project}/locations/{location}/plugins/{plugin}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get an API Hub plugin.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1Plugin>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the plugin to retrieve. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+$",
                        });
                    }
                }

                /// <summary>Get the style guide being used for linting.</summary>
                /// <param name="name">
                /// Required. The name of the spec to retrieve. Format:
                /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
                /// </param>
                public virtual GetStyleGuideRequest GetStyleGuide(string name)
                {
                    return new GetStyleGuideRequest(this.service, name);
                }

                /// <summary>Get the style guide being used for linting.</summary>
                public class GetStyleGuideRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1StyleGuide>
                {
                    /// <summary>Constructs a new GetStyleGuide request.</summary>
                    public GetStyleGuideRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the spec to retrieve. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getStyleGuide";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes GetStyleGuide parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/styleGuide$",
                        });
                    }
                }

                /// <summary>List all the plugins in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource where this plugin will be created. Format:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List all the plugins in a given project and location.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListPluginsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this plugin will be created. Format:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of plugins. A filter expression consists of a
                    /// field name, a comparison operator, and a value for filtering. The value must be a string. The
                    /// comparison operator must be one of: `&amp;lt;`, `&amp;gt;` or `=`. Filters are not case
                    /// sensitive. The following fields in the `Plugins` are eligible for filtering: * `plugin_category`
                    /// - The category of the Plugin. Allowed comparison operators: `=`. Expressions are combined with
                    /// either `AND` logic operator or `OR` logical operator but not both of them together i.e. only one
                    /// of the `AND` or `OR` operator can be used throughout the filter string and both the operators
                    /// cannot be used together. No other logical operators are supported. At most three filter fields
                    /// are allowed in the filter string and if provided more than that then `INVALID_ARGUMENT` error is
                    /// returned by the API. Here are a few examples: * `plugin_category = ON_RAMP` - The plugin is of
                    /// category on ramp.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of hub plugins to return. The service may return fewer than this
                    /// value. If unspecified, at most 50 hub plugins will be returned. The maximum value is 1000;
                    /// values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListPlugins` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters (except page_size) provided to
                    /// `ListPlugins` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/plugins";

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

                /// <summary>Update the styleGuide to be used for liniting in by API hub.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the style guide. Format:
                /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`
                /// </param>
                public virtual UpdateStyleGuideRequest UpdateStyleGuide(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1StyleGuide body, string name)
                {
                    return new UpdateStyleGuideRequest(this.service, body, name);
                }

                /// <summary>Update the styleGuide to be used for liniting in by API hub.</summary>
                public class UpdateStyleGuideRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1StyleGuide>
                {
                    /// <summary>Constructs a new UpdateStyleGuide request.</summary>
                    public UpdateStyleGuideRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1StyleGuide body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the style guide. Format:
                    /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1StyleGuide Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateStyleGuide";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateStyleGuide parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/plugins/[^/]+/styleGuide$",
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

            /// <summary>Gets the RuntimeProjectAttachments resource.</summary>
            public virtual RuntimeProjectAttachmentsResource RuntimeProjectAttachments { get; }

            /// <summary>The "runtimeProjectAttachments" collection of methods.</summary>
            public class RuntimeProjectAttachmentsResource
            {
                private const string Resource = "runtimeProjectAttachments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RuntimeProjectAttachmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Attaches a runtime project to the host project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource for the Runtime Project Attachment. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1RuntimeProjectAttachment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Attaches a runtime project to the host project.</summary>
                public class CreateRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1RuntimeProjectAttachment>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1RuntimeProjectAttachment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource for the Runtime Project Attachment. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the Runtime Project Attachment, which will become the final
                    /// component of the Runtime Project Attachment's name. The ID must be the same as the project ID of
                    /// the Google cloud project specified in the runtime_project_attachment.runtime_project field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("runtimeProjectAttachmentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RuntimeProjectAttachmentId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1RuntimeProjectAttachment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/runtimeProjectAttachments";

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
                        RequestParameters.Add("runtimeProjectAttachmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "runtimeProjectAttachmentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Delete a runtime project attachment in the API Hub. This call will detach the runtime project from
                /// the host project.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the Runtime Project Attachment to delete. Format:
                /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Delete a runtime project attachment in the API Hub. This call will detach the runtime project from
                /// the host project.
                /// </summary>
                public class DeleteRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Runtime Project Attachment to delete. Format:
                    /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimeProjectAttachments/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a runtime project attachment.</summary>
                /// <param name="name">
                /// Required. The name of the API resource to retrieve. Format:
                /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a runtime project attachment.</summary>
                public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1RuntimeProjectAttachment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the API resource to retrieve. Format:
                    /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimeProjectAttachments/[^/]+$",
                        });
                    }
                }

                /// <summary>List runtime projects attached to the host project.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of runtime project attachments. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List runtime projects attached to the host project.</summary>
                public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1ListRuntimeProjectAttachmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of runtime project attachments. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression that filters the list of RuntimeProjectAttachments. A filter expression
                    /// consists of a field name, a comparison operator, and a value for filtering. The value must be a
                    /// string. All standard operators as documented at https://google.aip.dev/160 are supported. The
                    /// following fields in the `RuntimeProjectAttachment` are eligible for filtering: * `name` - The
                    /// name of the RuntimeProjectAttachment. * `create_time` - The time at which the
                    /// RuntimeProjectAttachment was created. The value should be in the
                    /// (RFC3339)[https://tools.ietf.org/html/rfc3339] format. * `runtime_project` - The Google cloud
                    /// project associated with the RuntimeProjectAttachment.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of runtime project attachments to return. The service may return
                    /// fewer than this value. If unspecified, at most 50 runtime project attachments will be returned.
                    /// The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListRuntimeProjectAttachments` call. Provide
                    /// this to retrieve the subsequent page. When paginating, all other parameters (except page_size)
                    /// provided to `ListRuntimeProjectAttachments` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/runtimeProjectAttachments";

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

            /// <summary>Collect API data from a source and push it to Hub's collect layer.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="location">
            /// Required. The regional location of the API hub instance and its resources. Format:
            /// `projects/{project}/locations/{location}`
            /// </param>
            public virtual CollectApiDataRequest CollectApiData(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1CollectApiDataRequest body, string location)
            {
                return new CollectApiDataRequest(this.service, body, location);
            }

            /// <summary>Collect API data from a source and push it to Hub's collect layer.</summary>
            public class CollectApiDataRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new CollectApiData request.</summary>
                public CollectApiDataRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1CollectApiDataRequest body, string location) : base(service)
                {
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The regional location of the API hub instance and its resources. Format:
                /// `projects/{project}/locations/{location}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1CollectApiDataRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "collectApiData";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}:collectApiData";

                /// <summary>Initializes CollectApiData parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
            public class GetRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudLocationLocation>
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
            public class ListRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudLocationListLocationsResponse>
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

            /// <summary>
            /// Look up a runtime project attachment. This API can be called in the context of any project.
            /// </summary>
            /// <param name="name">
            /// Required. Runtime project ID to look up runtime project attachment for. Lookup happens across all
            /// regions. Expected format: `projects/{project}/locations/{location}`.
            /// </param>
            public virtual LookupRuntimeProjectAttachmentRequest LookupRuntimeProjectAttachment(string name)
            {
                return new LookupRuntimeProjectAttachmentRequest(this.service, name);
            }

            /// <summary>
            /// Look up a runtime project attachment. This API can be called in the context of any project.
            /// </summary>
            public class LookupRuntimeProjectAttachmentRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1LookupRuntimeProjectAttachmentResponse>
            {
                /// <summary>Constructs a new LookupRuntimeProjectAttachment request.</summary>
                public LookupRuntimeProjectAttachmentRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Runtime project ID to look up runtime project attachment for. Lookup happens across all
                /// regions. Expected format: `projects/{project}/locations/{location}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "lookupRuntimeProjectAttachment";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:lookupRuntimeProjectAttachment";

                /// <summary>Initializes LookupRuntimeProjectAttachment parameter list.</summary>
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

            /// <summary>Search across API-Hub resources.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="location">
            /// Required. The resource name of the location which will be of the type
            /// `projects/{project_id}/locations/{location_id}`. This field is used to identify the instance of API-Hub
            /// in which resources should be searched.
            /// </param>
            public virtual SearchResourcesRequest SearchResources(Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1SearchResourcesRequest body, string location)
            {
                return new SearchResourcesRequest(this.service, body, location);
            }

            /// <summary>Search across API-Hub resources.</summary>
            public class SearchResourcesRequest : APIhubBaseServiceRequest<Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1SearchResourcesResponse>
            {
                /// <summary>Constructs a new SearchResources request.</summary>
                public SearchResourcesRequest(Google.Apis.Services.IClientService service, Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1SearchResourcesRequest body, string location) : base(service)
                {
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the location which will be of the type
                /// `projects/{project_id}/locations/{location_id}`. This field is used to identify the instance of
                /// API-Hub in which resources should be searched.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.APIhub.v1.Data.GoogleCloudApihubV1SearchResourcesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "searchResources";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}:searchResources";

                /// <summary>Initializes SearchResources parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.APIhub.v1.Data
{
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

    /// <summary>The API metadata.</summary>
    public class GoogleCloudApihubV1APIMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The API resource to be pushed to Hub's collect layer. The ID of the API resource will be generated
        /// by Hub to ensure uniqueness across all APIs across systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("api")]
        public virtual GoogleCloudApihubV1Api Api { get; set; }

        private string _originalCreateTimeRaw;

        private object _originalCreateTime;

        /// <summary>Optional. Timestamp indicating when the API was created at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalCreateTime")]
        public virtual string OriginalCreateTimeRaw
        {
            get => _originalCreateTimeRaw;
            set
            {
                _originalCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalCreateTimeDateTimeOffset instead.")]
        public virtual object OriginalCreateTime
        {
            get => _originalCreateTime;
            set
            {
                _originalCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalCreateTimeRaw);
            set => OriginalCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The unique identifier of the API in the system where it was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalId")]
        public virtual string OriginalId { get; set; }

        private string _originalUpdateTimeRaw;

        private object _originalUpdateTime;

        /// <summary>Required. Timestamp indicating when the API was last updated at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalUpdateTime")]
        public virtual string OriginalUpdateTimeRaw
        {
            get => _originalUpdateTimeRaw;
            set
            {
                _originalUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalUpdateTimeDateTimeOffset instead.")]
        public virtual object OriginalUpdateTime
        {
            get => _originalUpdateTime;
            set
            {
                _originalUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalUpdateTimeRaw);
            set => OriginalUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The list of versions present in an API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1VersionMetadata> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details for the action to execute.</summary>
    public class GoogleCloudApihubV1ActionExecutionDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The action id of the plugin to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value that can be assigned to the attribute when the data type is enum.</summary>
    public class GoogleCloudApihubV1AllowedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The detailed description of the allowed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the allowed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. The ID of the allowed value. * If provided, the same will be used. The service will throw an error
        /// if the specified id is already used by another allowed value in the same attribute resource. * If not
        /// provided, a system generated id derived from the display name will be used. In this case, the service will
        /// handle conflict resolution by adding a system generated suffix in case of duplicates. This value should be
        /// 4-63 characters, and valid characters are /a-z-/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. When set to true, the allowed value cannot be updated or deleted by the user. It can only be true
        /// for System defined attributes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("immutable")]
        public virtual System.Nullable<bool> Immutable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An API resource in the API Hub.</summary>
    public class GoogleCloudApihubV1Api : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The api functional requirements associated with the API resource. Carinality is 1 for this
        /// attribute. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-api-functional-requirements` attribute. The value
        /// of the attribute should be a proper URI, and in case of Cloud Storage URI, it should point to a Cloud
        /// Storage object, not a directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiFunctionalRequirements")]
        public virtual GoogleCloudApihubV1AttributeValues ApiFunctionalRequirements { get; set; }

        /// <summary>
        /// Optional. The api requirement doc associated with the API resource. Carinality is 1 for this attribute. This
        /// maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-api-requirements` attribute. The value of the
        /// attribute should be a proper URI, and in case of Cloud Storage URI, it should point to a Cloud Storage
        /// object, not a directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiRequirements")]
        public virtual GoogleCloudApihubV1AttributeValues ApiRequirements { get; set; }

        /// <summary>
        /// Optional. The style of the API. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-api-style` attribute. The number of values for
        /// this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute
        /// API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiStyle")]
        public virtual GoogleCloudApihubV1AttributeValues ApiStyle { get; set; }

        /// <summary>
        /// Optional. The api technical requirements associated with the API resource. Carinality is 1 for this
        /// attribute. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-api-technical-requirements` attribute. The value
        /// of the attribute should be a proper URI, and in case of Cloud Storage URI, it should point to a Cloud
        /// Storage object, not a directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiTechnicalRequirements")]
        public virtual GoogleCloudApihubV1AttributeValues ApiTechnicalRequirements { get; set; }

        /// <summary>
        /// Optional. The list of user defined attributes associated with the API resource. The key is the attribute
        /// name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`. The value
        /// is the attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        /// <summary>
        /// Optional. The business unit owning the API. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-business-unit` attribute. The number of values
        /// for this attribute will be based on the cardinality of the attribute. The same can be retrieved via
        /// GetAttribute API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessUnit")]
        public virtual GoogleCloudApihubV1AttributeValues BusinessUnit { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the API resource was created.</summary>
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

        /// <summary>Optional. The description of the API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The documentation for the API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual GoogleCloudApihubV1Documentation Documentation { get; set; }

        /// <summary>Optional. Fingerprint of the API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>
        /// Optional. The maturity level of the API. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-maturity-level` attribute. The number of values
        /// for this attribute will be based on the cardinality of the attribute. The same can be retrieved via
        /// GetAttribute API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maturityLevel")]
        public virtual GoogleCloudApihubV1AttributeValues MaturityLevel { get; set; }

        /// <summary>
        /// Identifier. The name of the API resource in the API Hub. Format:
        /// `projects/{project}/locations/{location}/apis/{api}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Owner details for the API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual GoogleCloudApihubV1Owner Owner { get; set; }

        /// <summary>
        /// Optional. The selected version for an API resource. This can be used when special handling is needed on
        /// client side for particular version of the API. Format is
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedVersion")]
        public virtual string SelectedVersion { get; set; }

        /// <summary>Output only. The list of sources and metadata from the sources of the API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SourceMetadata> SourceMetadata { get; set; }

        /// <summary>
        /// Optional. The target users for the API. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-target-user` attribute. The number of values for
        /// this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute
        /// API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetUser")]
        public virtual GoogleCloudApihubV1AttributeValues TargetUser { get; set; }

        /// <summary>
        /// Optional. The team owning the API. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-team` attribute. The number of values for this
        /// attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API.
        /// All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("team")]
        public virtual GoogleCloudApihubV1AttributeValues Team { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the API resource was last updated.</summary>
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
        /// Output only. The list of versions present in an API resource. Note: An API resource can be associated with
        /// more than 1 version. Format is `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<string> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The API data to be collected.</summary>
    public class GoogleCloudApihubV1ApiData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of API metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMetadataList")]
        public virtual GoogleCloudApihubV1ApiMetadataList ApiMetadataList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ApiHubInstance represents the instance resources of the API Hub. Currently, only one ApiHub instance is
    /// allowed for each project.
    /// </summary>
    public class GoogleCloudApihubV1ApiHubInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Config of the ApiHub instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudApihubV1Config Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation timestamp.</summary>
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

        /// <summary>Optional. Description of the ApiHub instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Instance labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Format: `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The current state of the ApiHub instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Extra information about ApiHub instance state. Currently the message would be populated when
        /// state is `FAILED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMessage")]
        public virtual string StateMessage { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update timestamp.</summary>
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
    /// ApiHubResource is one of the resources such as Api, Operation, Deployment, Definition, Spec and Version
    /// resources stored in API-Hub.
    /// </summary>
    public class GoogleCloudApihubV1ApiHubResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This represents Api resource in search results. Only name, display_name, description and owner fields are
        /// populated in search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("api")]
        public virtual GoogleCloudApihubV1Api Api { get; set; }

        /// <summary>
        /// This represents Definition resource in search results. Only name field is populated in search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
        public virtual GoogleCloudApihubV1Definition Definition { get; set; }

        /// <summary>
        /// This represents Deployment resource in search results. Only name, display_name, description, deployment_type
        /// and api_versions fields are populated in search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual GoogleCloudApihubV1Deployment Deployment { get; set; }

        /// <summary>
        /// This represents ApiOperation resource in search results. Only name, description, spec and details fields are
        /// populated in search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual GoogleCloudApihubV1ApiOperation Operation { get; set; }

        /// <summary>
        /// This represents Spec resource in search results. Only name, display_name, description, spec_type and
        /// documentation fields are populated in search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleCloudApihubV1Spec Spec { get; set; }

        /// <summary>
        /// This represents Version resource in search results. Only name, display_name, description, lifecycle,
        /// compliance and accreditation fields are populated in search results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual GoogleCloudApihubV1Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for authentication with API key.</summary>
    public class GoogleCloudApihubV1ApiKeyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the SecretManager secret version resource storing the API key. Format:
        /// `projects/{project}/secrets/{secrete}/versions/{version}`. The `secretmanager.versions.access` permission
        /// should be granted to the service account accessing the secret.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKey")]
        public virtual GoogleCloudApihubV1Secret ApiKey { get; set; }

        /// <summary>Required. The location of the API key. The default value is QUERY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpElementLocation")]
        public virtual string HttpElementLocation { get; set; }

        /// <summary>
        /// Required. The parameter name of the API key. E.g. If the API request is "https://example.com/act?api_key=",
        /// "api_key" would be the parameter name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message to hold repeated API metadata.</summary>
    public class GoogleCloudApihubV1ApiMetadataList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of API metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1APIMetadata> ApiMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an operation contained in an API version in the API Hub. An operation is added/updated/deleted in an
    /// API version when a new spec is added or an existing spec is updated/deleted in a version. Currently, an
    /// operation will be created only corresponding to OpenAPI spec as parsing is supported for OpenAPI spec.
    /// Alternatively operations can be managed via create,update and delete APIs, creation of apiOperation can be
    /// possible only for version with no parsed operations and update/delete can be possible only for operations
    /// created via create API.
    /// </summary>
    public class GoogleCloudApihubV1ApiOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of user defined attributes associated with the API operation resource. The key is the
        /// attribute name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`.
        /// The value is the attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the operation was created.</summary>
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
        /// Optional. Operation details. Note: Even though this field is optional, it is required for CreateApiOperation
        /// API and we will fail the request if not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual GoogleCloudApihubV1OperationDetails Details { get; set; }

        /// <summary>
        /// Identifier. The name of the operation. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The list of sources and metadata from the sources of the API operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SourceMetadata> SourceMetadata { get; set; }

        /// <summary>
        /// Output only. The name of the spec will be of the format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}` Note:The name of the
        /// spec will be empty if the operation is created via CreateApiOperation API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual string Spec { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the operation was last updated.</summary>
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

    /// <summary>The details of the Application Integration endpoint to be triggered for curation.</summary>
    public class GoogleCloudApihubV1ApplicationIntegrationEndpointDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The API trigger ID of the Application Integration workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>
        /// Required. The endpoint URI should be a valid REST URI for triggering an Application Integration. Format:
        /// `https://integrations.googleapis.com/v1/{name=projects/*/locations/*/integrations/*}:execute` or
        /// `https://{location}-integrations.googleapis.com/v1/{name=projects/*/locations/*/integrations/*}:execute`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attribute in the API Hub. An attribute is a name value pair which can be attached to different resources in
    /// the API hub based on the scope of the attribute. Attributes can either be pre-defined by the API Hub or created
    /// by users.
    /// </summary>
    public class GoogleCloudApihubV1Attribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of allowed values when the attribute value is of type enum. This is required when the
        /// data_type of the attribute is ENUM. The maximum number of allowed values of an attribute will be 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1AllowedValue> AllowedValues { get; set; }

        /// <summary>
        /// Optional. The maximum number of values that the attribute can have when associated with an API Hub resource.
        /// Cardinality 1 would represent a single-valued attribute. It must not be less than 1 or greater than 20. If
        /// not specified, the cardinality would be set to 1 by default and represent a single-valued attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardinality")]
        public virtual System.Nullable<int> Cardinality { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the attribute was created.</summary>
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

        /// <summary>Required. The type of the data of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Output only. The definition type of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitionType")]
        public virtual string DefinitionType { get; set; }

        /// <summary>Optional. The description of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. When mandatory is true, the attribute is mandatory for the resource specified in the scope.
        /// Only System defined attributes can be mandatory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mandatory")]
        public virtual System.Nullable<bool> Mandatory { get; set; }

        /// <summary>
        /// Identifier. The name of the attribute in the API Hub. Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The scope of the attribute. It represents the resource in the API Hub to which the attribute can
        /// be linked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the attribute was last updated.</summary>
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

    /// <summary>The attribute values associated with resource.</summary>
    public class GoogleCloudApihubV1AttributeValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The name of the attribute. Format:
        /// projects/{project}/locations/{location}/attributes/{attribute}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>The attribute values associated with a resource in case attribute data type is enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValues")]
        public virtual GoogleCloudApihubV1EnumAttributeValues EnumValues { get; set; }

        /// <summary>The attribute values associated with a resource in case attribute data type is JSON.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonValues")]
        public virtual GoogleCloudApihubV1StringAttributeValues JsonValues { get; set; }

        /// <summary>The attribute values associated with a resource in case attribute data type is string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValues")]
        public virtual GoogleCloudApihubV1StringAttributeValues StringValues { get; set; }

        /// <summary>
        /// The attribute values associated with a resource in case attribute data type is URL, URI or IP, like
        /// gs://bucket-name/object-name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriValues")]
        public virtual GoogleCloudApihubV1StringAttributeValues UriValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthConfig represents the authentication information.</summary>
    public class GoogleCloudApihubV1AuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Api Key Config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyConfig")]
        public virtual GoogleCloudApihubV1ApiKeyConfig ApiKeyConfig { get; set; }

        /// <summary>Required. The authentication type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Google Service Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleServiceAccountConfig")]
        public virtual GoogleCloudApihubV1GoogleServiceAccountConfig GoogleServiceAccountConfig { get; set; }

        /// <summary>Oauth2.0 Client Credentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientCredentialsConfig")]
        public virtual GoogleCloudApihubV1Oauth2ClientCredentialsConfig Oauth2ClientCredentialsConfig { get; set; }

        /// <summary>User Password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPasswordConfig")]
        public virtual GoogleCloudApihubV1UserPasswordConfig UserPasswordConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthConfigTemplate represents the authentication template for a plugin.</summary>
    public class GoogleCloudApihubV1AuthConfigTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The service account of the plugin hosting service. This service account should be granted the
        /// required permissions on the Auth Config parameters provided while creating the plugin instances
        /// corresponding to this plugin. For example, if the plugin instance auth config requires a secret manager
        /// secret, the service account should be granted the secretmanager.versions.access permission on the
        /// corresponding secret, if the plugin instance auth config contains a service account, the service account
        /// should be granted the iam.serviceAccounts.getAccessToken permission on the corresponding service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual GoogleCloudApihubV1GoogleServiceAccountConfig ServiceAccount { get; set; }

        /// <summary>Required. The list of authentication types supported by the plugin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedAuthTypes")]
        public virtual System.Collections.Generic.IList<string> SupportedAuthTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The CollectApiData method's request.</summary>
    public class GoogleCloudApihubV1CollectApiDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The action ID to be used for collecting the API data. This should map to one of the action IDs
        /// specified in action configs in the plugin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>Required. The API data to be collected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiData")]
        public virtual GoogleCloudApihubV1ApiData ApiData { get; set; }

        /// <summary>Required. The type of collection. Applies to all entries in api_data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionType")]
        public virtual string CollectionType { get; set; }

        /// <summary>
        /// Required. The plugin instance collecting the API data. Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginInstance")]
        public virtual string PluginInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Available configurations to provision an ApiHub Instance.</summary>
    public class GoogleCloudApihubV1Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Customer Managed Encryption Key (CMEK) used for data encryption. The CMEK name should follow
        /// the format of `projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)`, where the location
        /// must match the instance location. If the CMEK is not provided, a GMEK will be created for the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cmekKeyName")]
        public virtual string CmekKeyName { get; set; }

        /// <summary>
        /// Optional. If true, the search will be disabled for the instance. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSearch")]
        public virtual System.Nullable<bool> DisableSearch { get; set; }

        /// <summary>
        /// Optional. Encryption type for the region. If the encryption type is CMEK, the cmek_key_name must be
        /// provided. If no encryption type is provided, GMEK will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>Optional. The name of the Vertex AI location where the data store is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertexLocation")]
        public virtual string VertexLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConfigTemplate represents the configuration template for a plugin.</summary>
    public class GoogleCloudApihubV1ConfigTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of additional configuration variables for the plugin's configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalConfigTemplate")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1ConfigVariableTemplate> AdditionalConfigTemplate { get; set; }

        /// <summary>Optional. The authentication template for the plugin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigTemplate")]
        public virtual GoogleCloudApihubV1AuthConfigTemplate AuthConfigTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConfigValueOption represents an option for a config variable of type enum or multi select.</summary>
    public class GoogleCloudApihubV1ConfigValueOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. Id of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ConfigVariable represents a additional configuration variable present in a PluginInstance Config or AuthConfig,
    /// based on a ConfigVariableTemplate.
    /// </summary>
    public class GoogleCloudApihubV1ConfigVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The config variable value in case of config variable of type boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Optional. The config variable value in case of config variable of type enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValue")]
        public virtual GoogleCloudApihubV1ConfigValueOption EnumValue { get; set; }

        /// <summary>Optional. The config variable value in case of config variable of type integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Output only. Key will be the id to uniquely identify the config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. The config variable value in case of config variable of type multi integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiIntValues")]
        public virtual GoogleCloudApihubV1MultiIntValues MultiIntValues { get; set; }

        /// <summary>Optional. The config variable value in case of config variable of type multi select.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiSelectValues")]
        public virtual GoogleCloudApihubV1MultiSelectValues MultiSelectValues { get; set; }

        /// <summary>Optional. The config variable value in case of config variable of type multi string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiStringValues")]
        public virtual GoogleCloudApihubV1MultiStringValues MultiStringValues { get; set; }

        /// <summary>Optional. The config variable value in case of config variable of type secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretValue")]
        public virtual GoogleCloudApihubV1Secret SecretValue { get; set; }

        /// <summary>Optional. The config variable value in case of config variable of type string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ConfigVariableTemplate represents a configuration variable template present in a Plugin Config.
    /// </summary>
    public class GoogleCloudApihubV1ConfigVariableTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Enum options. To be populated if `ValueType` is `ENUM`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumOptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1ConfigValueOption> EnumOptions { get; set; }

        /// <summary>Required. ID of the config variable. Must be unique within the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Multi select options. To be populated if `ValueType` is `MULTI_SELECT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiSelectOptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1ConfigValueOption> MultiSelectOptions { get; set; }

        /// <summary>
        /// Optional. Flag represents that this `ConfigVariable` must be provided for a PluginInstance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>
        /// Optional. Regular expression in RE2 syntax used for validating the `value` of a `ConfigVariable`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationRegex")]
        public virtual string ValidationRegex { get; set; }

        /// <summary>Required. Type of the parameter: string, int, bool etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A curation resource in the API Hub.</summary>
    public class GoogleCloudApihubV1Curation : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the curation was created.</summary>
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

        /// <summary>Optional. The description of the curation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the curation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The endpoint to be triggered for curation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual GoogleCloudApihubV1Endpoint Endpoint { get; set; }

        /// <summary>
        /// Output only. The error code of the last execution of the curation. The error code is populated only when the
        /// last execution state is failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecutionErrorCode")]
        public virtual string LastExecutionErrorCode { get; set; }

        /// <summary>
        /// Output only. Error message describing the failure, if any, during the last execution of the curation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecutionErrorMessage")]
        public virtual string LastExecutionErrorMessage { get; set; }

        /// <summary>Output only. The last execution state of the curation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecutionState")]
        public virtual string LastExecutionState { get; set; }

        /// <summary>
        /// Identifier. The name of the curation. Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The plugin instances and associated actions that are using the curation. Note: A particular
        /// curation could be used by multiple plugin instances or multiple actions in a plugin instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginInstanceActions")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1PluginInstanceActionID> PluginInstanceActions { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the curation was last updated.</summary>
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

    /// <summary>The curation information for this plugin instance.</summary>
    public class GoogleCloudApihubV1CurationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The curation type for this plugin instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curationType")]
        public virtual string CurationType { get; set; }

        /// <summary>Optional. Custom curation information for this plugin instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCuration")]
        public virtual GoogleCloudApihubV1CustomCuration CustomCuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom curation information for this plugin instance.</summary>
    public class GoogleCloudApihubV1CustomCuration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The unique name of the curation resource. This will be the name of the curation resource in the
        /// format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curation")]
        public virtual string Curation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a definition for example schema, request, response definitions contained in an API version. A
    /// definition is added/updated/deleted in an API version when a new spec is added or an existing spec is
    /// updated/deleted in a version. Currently, definition will be created only corresponding to OpenAPI spec as
    /// parsing is supported for OpenAPI spec. Also, within OpenAPI spec, only `schema` object is supported.
    /// </summary>
    public class GoogleCloudApihubV1Definition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of user defined attributes associated with the definition resource. The key is the
        /// attribute name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`.
        /// The value is the attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the definition was created.</summary>
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
        /// Identifier. The name of the definition. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The value of a schema definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual GoogleCloudApihubV1Schema Schema { get; set; }

        /// <summary>
        /// Output only. The name of the spec from where the definition was parsed. Format is
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual string Spec { get; set; }

        /// <summary>Output only. The type of the definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the definition was last updated.</summary>
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
    /// A dependency resource defined in the API hub describes a dependency directed from a consumer to a supplier
    /// entity. A dependency can be defined between two Operations or between an Operation and External API.
    /// </summary>
    public class GoogleCloudApihubV1Dependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of user defined attributes associated with the dependency resource. The key is the
        /// attribute name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`.
        /// The value is the attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        /// <summary>Required. Immutable. The entity acting as the consumer in the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumer")]
        public virtual GoogleCloudApihubV1DependencyEntityReference Consumer { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the dependency was created.</summary>
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

        /// <summary>Optional. Human readable description corresponding of the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Discovery mode of the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryMode")]
        public virtual string DiscoveryMode { get; set; }

        /// <summary>Output only. Error details of a dependency if the system has detected it internally.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDetail")]
        public virtual GoogleCloudApihubV1DependencyErrorDetail ErrorDetail { get; set; }

        /// <summary>
        /// Identifier. The name of the dependency in the API Hub. Format:
        /// `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. Immutable. The entity acting as the supplier in the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supplier")]
        public virtual GoogleCloudApihubV1DependencyEntityReference Supplier { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the dependency was last updated.</summary>
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

    /// <summary>Reference to an entity participating in a dependency.</summary>
    public class GoogleCloudApihubV1DependencyEntityReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Display name of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of an external API in the API Hub. Format:
        /// `projects/{project}/locations/{location}/externalApis/{external_api}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalApiResourceName")]
        public virtual string ExternalApiResourceName { get; set; }

        /// <summary>
        /// The resource name of an operation in the API Hub. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationResourceName")]
        public virtual string OperationResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details describing error condition of a dependency.</summary>
    public class GoogleCloudApihubV1DependencyErrorDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Error in the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        private string _errorTimeRaw;

        private object _errorTime;

        /// <summary>Optional. Timestamp at which the error was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorTime")]
        public virtual string ErrorTimeRaw
        {
            get => _errorTimeRaw;
            set
            {
                _errorTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _errorTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ErrorTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ErrorTimeDateTimeOffset instead.")]
        public virtual object ErrorTime
        {
            get => _errorTime;
            set
            {
                _errorTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _errorTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ErrorTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ErrorTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ErrorTimeRaw);
            set => ErrorTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the deployment where APIs are hosted. A deployment could represent an Apigee proxy, API gateway,
    /// other Google Cloud services or non-Google Cloud services as well. A deployment entity is a root level entity in
    /// the API hub and exists independent of any API.
    /// </summary>
    public class GoogleCloudApihubV1Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The API versions linked to this deployment. Note: A particular deployment could be linked to
        /// multiple different API versions (of same or different APIs).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersions")]
        public virtual System.Collections.Generic.IList<string> ApiVersions { get; set; }

        /// <summary>
        /// Optional. The list of user defined attributes associated with the deployment resource. The key is the
        /// attribute name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`.
        /// The value is the attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the deployment was created.</summary>
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
        /// Required. The type of deployment. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-deployment-type` attribute. The number of values
        /// for this attribute will be based on the cardinality of the attribute. The same can be retrieved via
        /// GetAttribute API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentType")]
        public virtual GoogleCloudApihubV1AttributeValues DeploymentType { get; set; }

        /// <summary>Optional. The description of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The documentation of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual GoogleCloudApihubV1Documentation Documentation { get; set; }

        /// <summary>
        /// Required. The endpoints at which this deployment resource is listening for API requests. This could be a
        /// list of complete URIs, hostnames or an IP addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<string> Endpoints { get; set; }

        /// <summary>
        /// Optional. The environment mapping to this deployment. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-environment` attribute. The number of values for
        /// this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute
        /// API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual GoogleCloudApihubV1AttributeValues Environment { get; set; }

        /// <summary>
        /// Optional. The uri where users can navigate to for the management of the deployment. This maps to the
        /// following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-management-url` The number of values for this
        /// attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementUrl")]
        public virtual GoogleCloudApihubV1AttributeValues ManagementUrl { get; set; }

        /// <summary>
        /// Identifier. The name of the deployment. Format:
        /// `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. A uri that uniquely identfies the deployment within a particular gateway. For example, if the
        /// runtime resource is of type APIGEE_PROXY, then this field will be a combination of org, proxy name and
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>
        /// Optional. The SLO for this deployment. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-slo` attribute. The number of values for this
        /// attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API.
        /// All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slo")]
        public virtual GoogleCloudApihubV1AttributeValues Slo { get; set; }

        /// <summary>
        /// Optional. The environment at source for the deployment. For example: prod, dev, staging, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceEnvironment")]
        public virtual string SourceEnvironment { get; set; }

        /// <summary>Output only. The list of sources and metadata from the sources of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SourceMetadata> SourceMetadata { get; set; }

        /// <summary>
        /// Optional. The project to which the deployment belongs. For GCP gateways, this will refer to the project
        /// identifier. For others like Edge/OPDK, this will refer to the org identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProject")]
        public virtual string SourceProject { get; set; }

        /// <summary>
        /// Optional. The uri where additional source specific information for this deployment can be found. This maps
        /// to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-source-uri` The number of values for this
        /// attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual GoogleCloudApihubV1AttributeValues SourceUri { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the deployment was last updated.</summary>
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

    /// <summary>The metadata associated with a deployment.</summary>
    public class GoogleCloudApihubV1DeploymentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The deployment resource to be pushed to Hub's collect layer. The ID of the deployment will be
        /// generated by Hub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual GoogleCloudApihubV1Deployment Deployment { get; set; }

        private string _originalCreateTimeRaw;

        private object _originalCreateTime;

        /// <summary>Optional. Timestamp indicating when the deployment was created at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalCreateTime")]
        public virtual string OriginalCreateTimeRaw
        {
            get => _originalCreateTimeRaw;
            set
            {
                _originalCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalCreateTimeDateTimeOffset instead.")]
        public virtual object OriginalCreateTime
        {
            get => _originalCreateTime;
            set
            {
                _originalCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalCreateTimeRaw);
            set => OriginalCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The unique identifier of the deployment in the system where it was originally created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalId")]
        public virtual string OriginalId { get; set; }

        private string _originalUpdateTimeRaw;

        private object _originalUpdateTime;

        /// <summary>Required. Timestamp indicating when the deployment was last updated at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalUpdateTime")]
        public virtual string OriginalUpdateTimeRaw
        {
            get => _originalUpdateTimeRaw;
            set
            {
                _originalUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalUpdateTimeDateTimeOffset instead.")]
        public virtual object OriginalUpdateTime
        {
            get => _originalUpdateTime;
            set
            {
                _originalUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalUpdateTimeRaw);
            set => OriginalUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The DisablePluginInstanceAction method's request.</summary>
    public class GoogleCloudApihubV1DisablePluginInstanceActionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The action id to disable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The DisablePlugin method's request.</summary>
    public class GoogleCloudApihubV1DisablePluginRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Documentation details.</summary>
    public class GoogleCloudApihubV1Documentation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The uri of the externally hosted documentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The EnablePluginInstanceAction method's request.</summary>
    public class GoogleCloudApihubV1EnablePluginInstanceActionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The action id to enable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The EnablePlugin method's request.</summary>
    public class GoogleCloudApihubV1EnablePluginRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The endpoint to be triggered for curation. The endpoint will be invoked with a request payload containing
    /// ApiMetadata. Response should contain curated data in the form of ApiMetadata.
    /// </summary>
    public class GoogleCloudApihubV1Endpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The details of the Application Integration endpoint to be triggered for curation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationIntegrationEndpointDetails")]
        public virtual GoogleCloudApihubV1ApplicationIntegrationEndpointDetails ApplicationIntegrationEndpointDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The attribute values of data type enum.</summary>
    public class GoogleCloudApihubV1EnumAttributeValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attribute values in case attribute data type is enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1AllowedValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ExecutePluginInstanceAction method's request.</summary>
    public class GoogleCloudApihubV1ExecutePluginInstanceActionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The execution details for the action to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionExecutionDetail")]
        public virtual GoogleCloudApihubV1ActionExecutionDetail ActionExecutionDetail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The execution status for the plugin instance.</summary>
    public class GoogleCloudApihubV1ExecutionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current state of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentExecutionState")]
        public virtual string CurrentExecutionState { get; set; }

        /// <summary>Output only. The last execution of the plugin instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecution")]
        public virtual GoogleCloudApihubV1LastExecution LastExecution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An external API represents an API being provided by external sources. This can be used to model third-party APIs
    /// and can be used to define dependencies.
    /// </summary>
    public class GoogleCloudApihubV1ExternalApi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of user defined attributes associated with the Version resource. The key is the attribute
        /// name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`. The value
        /// is the attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation timestamp.</summary>
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
        /// Optional. Description of the external API. Max length is 2000 characters (Unicode Code Points).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Display name of the external API. Max length is 63 characters (Unicode Code Points).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Documentation of the external API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual GoogleCloudApihubV1Documentation Documentation { get; set; }

        /// <summary>Optional. List of endpoints on which this API is accessible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<string> Endpoints { get; set; }

        /// <summary>Identifier. Format: `projects/{project}/locations/{location}/externalApi/{externalApi}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. List of paths served by this API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update timestamp.</summary>
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

    /// <summary>Config for Google service account authentication.</summary>
    public class GoogleCloudApihubV1GoogleServiceAccountConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The service account to be used for authenticating request. The
        /// `iam.serviceAccounts.getAccessToken` permission should be granted on this service account to the
        /// impersonator service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Host project registration refers to the registration of a Google cloud project with Api Hub as a host project.
    /// This is the project where Api Hub is provisioned. It acts as the consumer project for the Api Hub instance
    /// provisioned. Multiple runtime projects can be attached to the host project and these attachments define the
    /// scope of Api Hub.
    /// </summary>
    public class GoogleCloudApihubV1HostProjectRegistration : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the host project registration was created.</summary>
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
        /// Required. Immutable. Google cloud project name in the format: "projects/abc" or "projects/123". As input,
        /// project name with either project id or number are accepted. As output, this field will contain project
        /// number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpProject")]
        public virtual string GcpProject { get; set; }

        /// <summary>
        /// Identifier. The name of the host project registration. Format:
        /// "projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The information related to the service implemented by the plugin developer, used to invoke the plugin's
    /// functionality.
    /// </summary>
    public class GoogleCloudApihubV1HostingService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The URI of the service implemented by the plugin developer, used to invoke the plugin's
        /// functionality. This information is only required for user defined plugins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceUri")]
        public virtual string ServiceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The HTTP Operation.</summary>
    public class GoogleCloudApihubV1HttpOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Operation method Note: Even though this field is optional, it is required for CreateApiOperation
        /// API and we will fail the request if not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Optional. The path details for the Operation. Note: Even though this field is optional, it is required for
        /// CreateApiOperation API and we will fail the request if not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual GoogleCloudApihubV1Path Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Issue contains the details of a single issue found by the linter.</summary>
    public class GoogleCloudApihubV1Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Rule code unique to each rule defined in linter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Required. Human-readable message describing the issue found by the linter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Required. An array of strings indicating the location in the analyzed document where the rule was triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual System.Collections.Generic.IList<string> Path { get; set; }

        /// <summary>Required. Object describing where in the file the issue was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GoogleCloudApihubV1Range Range { get; set; }

        /// <summary>Required. Severity level of the rule violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of the last execution of the plugin instance.</summary>
    public class GoogleCloudApihubV1LastExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The last execution end time of the plugin instance.</summary>
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

        /// <summary>Output only. Error message describing the failure, if any, during the last execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Output only. The result of the last execution of the plugin instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The last execution start time of the plugin instance.</summary>
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

    /// <summary>LintResponse contains the response from the linter.</summary>
    public class GoogleCloudApihubV1LintResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Required. Timestamp when the linting response was generated.</summary>
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

        /// <summary>Optional. Array of issues found in the analyzed document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Issue> Issues { get; set; }

        /// <summary>Required. Name of the linter used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linter")]
        public virtual string Linter { get; set; }

        /// <summary>Required. Name of the linting application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Required. Lint state represents success or failure for linting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Summary of all issue types and counts for each severity level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SummaryEntry> Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The LintSpec method's request.</summary>
    public class GoogleCloudApihubV1LintSpecRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListApiOperations method's response.</summary>
    public class GoogleCloudApihubV1ListApiOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operations corresponding to an API version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiOperations")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1ApiOperation> ApiOperations { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListApis method's response.</summary>
    public class GoogleCloudApihubV1ListApisResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API resources present in the API hub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apis")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Api> Apis { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListAttributes method's response.</summary>
    public class GoogleCloudApihubV1ListAttributesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of all attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Attribute> Attributes { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListCurations method's response.</summary>
    public class GoogleCloudApihubV1ListCurationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The curation resources present in the API hub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curations")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Curation> Curations { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListDependencies method's response.</summary>
    public class GoogleCloudApihubV1ListDependenciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dependency resources present in the API hub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Dependency> Dependencies { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListDeployments method's response.</summary>
    public class GoogleCloudApihubV1ListDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployment resources present in the API hub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Deployment> Deployments { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListExternalApis method's response.</summary>
    public class GoogleCloudApihubV1ListExternalApisResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The External API resources present in the API hub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalApis")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1ExternalApi> ExternalApis { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListHostProjectRegistrations method's response.</summary>
    public class GoogleCloudApihubV1ListHostProjectRegistrationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of host project registrations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostProjectRegistrations")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1HostProjectRegistration> HostProjectRegistrations { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListPluginInstances method's response.</summary>
    public class GoogleCloudApihubV1ListPluginInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The plugin instances from the specified parent resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginInstances")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1PluginInstance> PluginInstances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListPlugins method's response.</summary>
    public class GoogleCloudApihubV1ListPluginsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The plugins from the specified parent resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plugins")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Plugin> Plugins { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListRuntimeProjectAttachments method's response.</summary>
    public class GoogleCloudApihubV1ListRuntimeProjectAttachmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of runtime project attachments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeProjectAttachments")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1RuntimeProjectAttachment> RuntimeProjectAttachments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListSpecs method's response.</summary>
    public class GoogleCloudApihubV1ListSpecsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The specs corresponding to an API Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specs")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Spec> Specs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListVersions method's response.</summary>
    public class GoogleCloudApihubV1ListVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The versions corresponding to an API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1Version> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The LookupApiHubInstance method's response.`</summary>
    public class GoogleCloudApihubV1LookupApiHubInstanceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API Hub instance for a project if it exists, empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiHubInstance")]
        public virtual GoogleCloudApihubV1ApiHubInstance ApiHubInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListRuntimeProjectAttachments method's response.</summary>
    public class GoogleCloudApihubV1LookupRuntimeProjectAttachmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Runtime project attachment for a project if exists, empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeProjectAttachment")]
        public virtual GoogleCloudApihubV1RuntimeProjectAttachment RuntimeProjectAttachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The config variable value of data type multi int.</summary>
    public class GoogleCloudApihubV1MultiIntValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The config variable value of data type multi int.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The config variable value of data type multi select.</summary>
    public class GoogleCloudApihubV1MultiSelectValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The config variable value of data type multi select.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1ConfigValueOption> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The config variable value of data type multi string.</summary>
    public class GoogleCloudApihubV1MultiStringValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The config variable value of data type multi string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 client credentials grant authentication. See
    /// https://tools.ietf.org/html/rfc6749#section-1.3.4 for more details.
    /// </summary>
    public class GoogleCloudApihubV1Oauth2ClientCredentialsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The client identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Required. Secret version reference containing the client secret. The `secretmanager.versions.access`
        /// permission should be granted to the service account accessing the secret.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual GoogleCloudApihubV1Secret ClientSecret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OpenApiSpecDetails contains the details parsed from an OpenAPI spec in addition to the fields mentioned in
    /// SpecDetails.
    /// </summary>
    public class GoogleCloudApihubV1OpenApiSpecDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The format of the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Output only. Owner details for the spec. This maps to `info.contact` in OpenAPI spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual GoogleCloudApihubV1Owner Owner { get; set; }

        /// <summary>Output only. The version in the spec. This maps to `info.version` in OpenAPI spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation details parsed from the spec.</summary>
    public class GoogleCloudApihubV1OperationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. For OpenAPI spec, this will be set if `operation.deprecated`is marked as `true` in the spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecated")]
        public virtual System.Nullable<bool> Deprecated { get; set; }

        /// <summary>
        /// Optional. Description of the operation behavior. For OpenAPI spec, this will map to `operation.description`
        /// in the spec, in case description is empty, `operation.summary` will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Additional external documentation for this operation. For OpenAPI spec, this will map to
        /// `operation.documentation` in the spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual GoogleCloudApihubV1Documentation Documentation { get; set; }

        /// <summary>The HTTP Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpOperation")]
        public virtual GoogleCloudApihubV1HttpOperation HttpOperation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudApihubV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
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

    /// <summary>Owner details.</summary>
    public class GoogleCloudApihubV1Owner : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the owner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The email of the owner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The path details derived from the spec.</summary>
    public class GoogleCloudApihubV1Path : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A short description for the path applicable to all operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Complete path relative to server endpoint. Note: Even though this field is optional, it is
        /// required for CreateApiOperation API and we will fail the request if not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A plugin resource in the API Hub.</summary>
    public class GoogleCloudApihubV1Plugin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The configuration of actions supported by the plugin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionsConfig")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1PluginActionConfig> ActionsConfig { get; set; }

        /// <summary>Optional. The configuration template for the plugin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configTemplate")]
        public virtual GoogleCloudApihubV1ConfigTemplate ConfigTemplate { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp indicating when the plugin was created.</summary>
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

        /// <summary>Optional. The plugin description. Max length is 2000 characters (Unicode code points).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The display name of the plugin. Max length is 50 characters (Unicode code points).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The documentation of the plugin, that explains how to set up and use the plugin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual GoogleCloudApihubV1Documentation Documentation { get; set; }

        /// <summary>Optional. The type of the gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayType")]
        public virtual string GatewayType { get; set; }

        /// <summary>
        /// Optional. This field is optional. It is used to notify the plugin hosting service for any lifecycle changes
        /// of the plugin instance and trigger execution of plugin instance actions in case of API hub managed actions.
        /// This field should be provided if the plugin instance lifecycle of the developed plugin needs to be managed
        /// from API hub. Also, in this case the plugin hosting service interface needs to be implemented. This field
        /// should not be provided if the plugin wants to manage plugin instance lifecycle events outside of hub
        /// interface and use plugin framework for only registering of plugin and plugin instances to capture the source
        /// of data into hub. Note, in this case the plugin hosting service interface is not required to be implemented.
        /// Also, the plugin instance lifecycle actions will be disabled from API hub's UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostingService")]
        public virtual GoogleCloudApihubV1HostingService HostingService { get; set; }

        /// <summary>
        /// Identifier. The name of the plugin. Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The type of the plugin, indicating whether it is 'SYSTEM_OWNED' or 'USER_OWNED'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownershipType")]
        public virtual string OwnershipType { get; set; }

        /// <summary>
        /// Optional. The category of the plugin, identifying its primary category or purpose. This field is required
        /// for all plugins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginCategory")]
        public virtual string PluginCategory { get; set; }

        /// <summary>
        /// Output only. Represents the state of the plugin. Note this field will not be set for plugins developed via
        /// plugin framework as the state will be managed at plugin instance level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. The type of the API. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-plugin-type` attribute. The number of allowed
        /// values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via
        /// GetAttribute API. All values should be from the list of allowed values defined for the attribute. Note this
        /// field is not required for plugins developed via plugin framework.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual GoogleCloudApihubV1AttributeValues Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp indicating when the plugin was last updated.</summary>
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

    /// <summary>PluginActionConfig represents the configuration of an action supported by a plugin.</summary>
    public class GoogleCloudApihubV1PluginActionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The description of the operation performed by the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. The id of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. The trigger mode supported by the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerMode")]
        public virtual string TriggerMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a plugin instance resource in the API Hub. A PluginInstance is a specific instance of a hub plugin
    /// with its own configuration, state, and execution details.
    /// </summary>
    public class GoogleCloudApihubV1PluginInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The action status for the plugin instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1PluginInstanceAction> Actions { get; set; }

        /// <summary>
        /// Optional. The additional information for this plugin instance corresponding to the additional config
        /// template of the plugin. This information will be sent to plugin hosting service on each call to plugin
        /// hosted service. The key will be the config_variable_template.display_name to uniquely identify the config
        /// variable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalConfig")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1ConfigVariable> AdditionalConfig { get; set; }

        /// <summary>Optional. The authentication information for this plugin instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual GoogleCloudApihubV1AuthConfig AuthConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp indicating when the plugin instance was created.</summary>
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

        /// <summary>Required. The display name for this plugin instance. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Error message describing the failure, if any, during Create, Delete or ApplyConfig operation
        /// corresponding to the plugin instance.This field will only be populated if the plugin instance is in the
        /// ERROR or FAILED state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Identifier. The unique name of the plugin instance resource. Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The source project id of the plugin instance. This will be the id of runtime project in case of
        /// gcp based plugins and org id in case of non gcp based plugins. This is a required field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProjectId")]
        public virtual string SourceProjectId { get; set; }

        /// <summary>
        /// Output only. The current state of the plugin instance (e.g., enabled, disabled, provisioning).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp indicating when the plugin instance was last updated.</summary>
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

    /// <summary>PluginInstanceAction represents an action which can be executed in the plugin instance.</summary>
    public class GoogleCloudApihubV1PluginInstanceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This should map to one of the action id specified in actions_config in the plugin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>
        /// Optional. This configuration should be provided if the plugin action is publishing data to API hub curate
        /// layer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curationConfig")]
        public virtual GoogleCloudApihubV1CurationConfig CurationConfig { get; set; }

        /// <summary>
        /// Optional. The execution information for the plugin instance action done corresponding to an API hub
        /// instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hubInstanceAction")]
        public virtual GoogleCloudApihubV1ExecutionStatus HubInstanceAction { get; set; }

        /// <summary>
        /// Output only. The configuration of resources created for a given plugin instance action. Note these will be
        /// returned only in case of Non-GCP plugins like OPDK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceConfig")]
        public virtual GoogleCloudApihubV1ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Optional. The schedule for this plugin instance action. This can only be set if the plugin supports
        /// API_HUB_SCHEDULE_TRIGGER mode for this action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleCronExpression")]
        public virtual string ScheduleCronExpression { get; set; }

        /// <summary>
        /// Optional. The time zone for the schedule cron expression. If not provided, UTC will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTimeZone")]
        public virtual string ScheduleTimeZone { get; set; }

        /// <summary>
        /// Optional. The service account used to publish data. Note, the service account will only be accepted for non
        /// GCP plugins like OPDK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. The current state of the plugin action in the plugin instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The plugin instance and associated action that is using the curation.</summary>
    public class GoogleCloudApihubV1PluginInstanceActionID : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The action ID that is using the curation. This should map to one of the action IDs specified in
        /// action configs in the plugin.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>
        /// Output only. Plugin instance that is using the curation. Format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginInstance")]
        public virtual string PluginInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PluginInstanceActionSource represents the plugin instance action source.</summary>
    public class GoogleCloudApihubV1PluginInstanceActionSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The id of the plugin instance action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual string ActionId { get; set; }

        /// <summary>
        /// Output only. The resource name of the source plugin instance. Format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginInstance")]
        public virtual string PluginInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Point within the file (line and character).</summary>
    public class GoogleCloudApihubV1Point : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Character position within the line (zero-indexed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("character")]
        public virtual System.Nullable<int> Character { get; set; }

        /// <summary>Required. Line number (zero-indexed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<int> Line { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Object describing where in the file the issue was found.</summary>
    public class GoogleCloudApihubV1Range : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. End of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual GoogleCloudApihubV1Point End { get; set; }

        /// <summary>Required. Start of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual GoogleCloudApihubV1Point Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of resources created for a given plugin instance action.</summary>
    public class GoogleCloudApihubV1ResourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The type of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>
        /// Output only. The pubsub topic to publish the data to. Format is projects/{project}/topics/{topic}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Runtime project attachment represents an attachment from the runtime project to the host project. Api Hub looks
    /// for deployments in the attached runtime projects and creates corresponding resources in Api Hub for the
    /// discovered deployments.
    /// </summary>
    public class GoogleCloudApihubV1RuntimeProjectAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Create time.</summary>
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
        /// Identifier. The resource name of a runtime project attachment. Format:
        /// "projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. Google cloud project name in the format: "projects/abc" or "projects/123". As input,
        /// project name with either project id or number are accepted. As output, this field will contain project
        /// number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeProject")]
        public virtual string RuntimeProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The schema details derived from the spec. Currently, this entity is supported for OpenAPI spec only. For OpenAPI
    /// spec, this maps to the schema defined in the `definitions` section for OpenAPI 2.0 version and in
    /// `components.schemas` section for OpenAPI 3.0 and 3.1 version.
    /// </summary>
    public class GoogleCloudApihubV1Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The display name of the schema. This will map to the name of the schema in the spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The raw value of the schema definition corresponding to the schema name in the spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawValue")]
        public virtual string RawValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The SearchResources method's request.</summary>
    public class GoogleCloudApihubV1SearchResourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An expression that filters the list of search results. A filter expression consists of a field
        /// name, a comparison operator, and a value for filtering. The value must be a string, a number, or a boolean.
        /// The comparison operator must be `=`. Filters are not case sensitive. The following field names are eligible
        /// for filtering: * `resource_type` - The type of resource in the search results. Must be one of the following:
        /// `Api`, `ApiOperation`, `Deployment`, `Definition`, `Spec` or `Version`. This field can only be specified
        /// once in the filter. Here are is an example: * `resource_type = Api` - The resource_type is _Api_.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. The maximum number of search results to return. The service may return fewer than this value. If
        /// unspecified at most 10 search results will be returned. If value is negative then `INVALID_ARGUMENT` error
        /// is returned. The maximum value is 25; values above 25 will be coerced to 25. While paginating, you can
        /// specify a new page size parameter for each page of search results to be listed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token, received from a previous SearchResources call. Specify this parameter to retrieve
        /// the next page of transactions. When paginating, you must specify the `page_token` parameter and all the
        /// other parameters except page_size should be specified with the same value which was used in the previous
        /// call. If the other fields are set with a different value than the previous call then `INVALID_ARGUMENT`
        /// error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. The free text search query. This query can contain keywords which could be related to any detail
        /// of the API-Hub resources such display names, descriptions, attributes etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the SearchResources method.</summary>
    public class GoogleCloudApihubV1SearchResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pass this token in the SearchResourcesRequest to continue to list results. If all results have been
        /// returned, this field is an empty string or not present in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// List of search results according to the filter and search query specified. The order of search results
        /// represents the ranking.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SearchResult> SearchResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the search results.</summary>
    public class GoogleCloudApihubV1SearchResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This represents the ApiHubResource. Note: Only selected fields of the resources are populated in response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudApihubV1ApiHubResource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secret provides a reference to entries in Secret Manager.</summary>
    public class GoogleCloudApihubV1Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the secret version in the format, format as:
        /// `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretVersion")]
        public virtual string SecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SourceMetadata represents the metadata for a resource at the source.</summary>
    public class GoogleCloudApihubV1SourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _originalResourceCreateTimeRaw;

        private object _originalResourceCreateTime;

        /// <summary>Output only. The time at which the resource was created at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalResourceCreateTime")]
        public virtual string OriginalResourceCreateTimeRaw
        {
            get => _originalResourceCreateTimeRaw;
            set
            {
                _originalResourceCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalResourceCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalResourceCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalResourceCreateTimeDateTimeOffset instead.")]
        public virtual object OriginalResourceCreateTime
        {
            get => _originalResourceCreateTime;
            set
            {
                _originalResourceCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalResourceCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalResourceCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalResourceCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalResourceCreateTimeRaw);
            set => OriginalResourceCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The unique identifier of the resource at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalResourceId")]
        public virtual string OriginalResourceId { get; set; }

        private string _originalResourceUpdateTimeRaw;

        private object _originalResourceUpdateTime;

        /// <summary>Output only. The time at which the resource was last updated at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalResourceUpdateTime")]
        public virtual string OriginalResourceUpdateTimeRaw
        {
            get => _originalResourceUpdateTimeRaw;
            set
            {
                _originalResourceUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalResourceUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalResourceUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalResourceUpdateTimeDateTimeOffset instead.")]
        public virtual object OriginalResourceUpdateTime
        {
            get => _originalResourceUpdateTime;
            set
            {
                _originalResourceUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalResourceUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalResourceUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalResourceUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalResourceUpdateTimeRaw);
            set => OriginalResourceUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The source of the resource is a plugin instance action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginInstanceActionSource")]
        public virtual GoogleCloudApihubV1PluginInstanceActionSource PluginInstanceActionSource { get; set; }

        /// <summary>Output only. The type of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a spec associated with an API version in the API Hub. Note that specs of various types can be
    /// uploaded, however parsing of details is supported for OpenAPI spec currently.
    /// </summary>
    public class GoogleCloudApihubV1Spec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of user defined attributes associated with the spec. The key is the attribute name. It
        /// will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`. The value is the
        /// attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        /// <summary>Optional. Input only. The contents of the uploaded spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual GoogleCloudApihubV1SpecContents Contents { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the spec was created.</summary>
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

        /// <summary>Output only. Details parsed from the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual GoogleCloudApihubV1SpecDetails Details { get; set; }

        /// <summary>Required. The display name of the spec. This can contain the file name of the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The documentation of the spec. For OpenAPI spec, this will be populated from `externalDocs` in
        /// OpenAPI spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual GoogleCloudApihubV1Documentation Documentation { get; set; }

        /// <summary>Optional. The lint response for the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lintResponse")]
        public virtual GoogleCloudApihubV1LintResponse LintResponse { get; set; }

        /// <summary>
        /// Identifier. The name of the spec. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Input only. Enum specifying the parsing mode for OpenAPI Specification (OAS) parsing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parsingMode")]
        public virtual string ParsingMode { get; set; }

        /// <summary>Output only. The list of sources and metadata from the sources of the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SourceMetadata> SourceMetadata { get; set; }

        /// <summary>
        /// Optional. The URI of the spec source in case file is uploaded from an external version control system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual string SourceUri { get; set; }

        /// <summary>
        /// Required. The type of spec. The value should be one of the allowed values defined for
        /// `projects/{project}/locations/{location}/attributes/system-spec-type` attribute. The number of values for
        /// this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute
        /// API. Note, this field is mandatory if content is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specType")]
        public virtual GoogleCloudApihubV1AttributeValues SpecType { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the spec was last updated.</summary>
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

    /// <summary>The spec contents.</summary>
    public class GoogleCloudApihubV1SpecContents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The contents of the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>
        /// Required. The mime type of the content for example application/json, application/yaml, application/wsdl etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SpecDetails contains the details parsed from supported spec types.</summary>
    public class GoogleCloudApihubV1SpecDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The description of the spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Additional details apart from `OperationDetails` parsed from an OpenAPI spec. The
        /// OperationDetails parsed from the spec can be obtained by using ListAPIOperations method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openApiSpecDetails")]
        public virtual GoogleCloudApihubV1OpenApiSpecDetails OpenApiSpecDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata associated with a spec of the API version.</summary>
    public class GoogleCloudApihubV1SpecMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _originalCreateTimeRaw;

        private object _originalCreateTime;

        /// <summary>Optional. Timestamp indicating when the spec was created at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalCreateTime")]
        public virtual string OriginalCreateTimeRaw
        {
            get => _originalCreateTimeRaw;
            set
            {
                _originalCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalCreateTimeDateTimeOffset instead.")]
        public virtual object OriginalCreateTime
        {
            get => _originalCreateTime;
            set
            {
                _originalCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalCreateTimeRaw);
            set => OriginalCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The unique identifier of the spec in the system where it was originally created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalId")]
        public virtual string OriginalId { get; set; }

        private string _originalUpdateTimeRaw;

        private object _originalUpdateTime;

        /// <summary>Required. Timestamp indicating when the spec was last updated at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalUpdateTime")]
        public virtual string OriginalUpdateTimeRaw
        {
            get => _originalUpdateTimeRaw;
            set
            {
                _originalUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalUpdateTimeDateTimeOffset instead.")]
        public virtual object OriginalUpdateTime
        {
            get => _originalUpdateTime;
            set
            {
                _originalUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalUpdateTimeRaw);
            set => OriginalUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. The spec resource to be pushed to Hub's collect layer. The ID of the spec will be generated by
        /// Hub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleCloudApihubV1Spec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The attribute values of data type string or JSON.</summary>
    public class GoogleCloudApihubV1StringAttributeValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attribute values in case attribute data type is string or JSON.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a singleton style guide resource to be used for linting Open API specs.</summary>
    public class GoogleCloudApihubV1StyleGuide : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Input only. The contents of the uploaded style guide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual GoogleCloudApihubV1StyleGuideContents Contents { get; set; }

        /// <summary>Required. Target linter for the style guide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linter")]
        public virtual string Linter { get; set; }

        /// <summary>
        /// Identifier. The name of the style guide. Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The style guide contents.</summary>
    public class GoogleCloudApihubV1StyleGuideContents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The contents of the style guide.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>Required. The mime type of the content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Count of issues with a given severity.</summary>
    public class GoogleCloudApihubV1SummaryEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Count of issues with the given severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>Required. Severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to support Username and Password Authentication.</summary>
    public class GoogleCloudApihubV1UserPasswordConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Secret version reference containing the password. The `secretmanager.versions.access` permission
        /// should be granted to the service account accessing the secret.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual GoogleCloudApihubV1Secret Password { get; set; }

        /// <summary>Required. Username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a version of the API resource in API hub. This is also referred to as the API version.
    /// </summary>
    public class GoogleCloudApihubV1Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The accreditations associated with the API version. This maps to the following system defined
        /// attribute: `projects/{project}/locations/{location}/attributes/system-accreditation` attribute. The number
        /// of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved
        /// via GetAttribute API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accreditation")]
        public virtual GoogleCloudApihubV1AttributeValues Accreditation { get; set; }

        /// <summary>
        /// Output only. The operations contained in the API version. These operations will be added to the version when
        /// a new spec is added or when an existing spec is updated. Format is
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiOperations")]
        public virtual System.Collections.Generic.IList<string> ApiOperations { get; set; }

        /// <summary>
        /// Optional. The list of user defined attributes associated with the Version resource. The key is the attribute
        /// name. It will be of the format: `projects/{project}/locations/{location}/attributes/{attribute}`. The value
        /// is the attribute values associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudApihubV1AttributeValues> Attributes { get; set; }

        /// <summary>
        /// Optional. The compliance associated with the API version. This maps to the following system defined
        /// attribute: `projects/{project}/locations/{location}/attributes/system-compliance` attribute. The number of
        /// values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via
        /// GetAttribute API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliance")]
        public virtual GoogleCloudApihubV1AttributeValues Compliance { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the version was created.</summary>
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
        /// Output only. The definitions contained in the API version. These definitions will be added to the version
        /// when a new spec is added or when an existing spec is updated. Format is
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definitions")]
        public virtual System.Collections.Generic.IList<string> Definitions { get; set; }

        /// <summary>
        /// Optional. The deployments linked to this API version. Note: A particular API version could be deployed to
        /// multiple deployments (for dev deployment, UAT deployment, etc) Format is
        /// `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<string> Deployments { get; set; }

        /// <summary>Optional. The description of the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The documentation of the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual GoogleCloudApihubV1Documentation Documentation { get; set; }

        /// <summary>
        /// Optional. The lifecycle of the API version. This maps to the following system defined attribute:
        /// `projects/{project}/locations/{location}/attributes/system-lifecycle` attribute. The number of values for
        /// this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute
        /// API. All values should be from the list of allowed values defined for the attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual GoogleCloudApihubV1AttributeValues Lifecycle { get; set; }

        /// <summary>
        /// Identifier. The name of the version. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The selected deployment for a Version resource. This can be used when special handling is needed
        /// on client side for a particular deployment linked to the version. Format is
        /// `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedDeployment")]
        public virtual string SelectedDeployment { get; set; }

        /// <summary>Output only. The list of sources and metadata from the sources of the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceMetadata")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SourceMetadata> SourceMetadata { get; set; }

        /// <summary>
        /// Output only. The specs associated with this version. Note that an API version can be associated with
        /// multiple specs. Format is
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specs")]
        public virtual System.Collections.Generic.IList<string> Specs { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the version was last updated.</summary>
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

    /// <summary>The metadata associated with a version of the API resource.</summary>
    public class GoogleCloudApihubV1VersionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The deployments linked to this API version. Note: A particular API version could be deployed to
        /// multiple deployments (for dev deployment, UAT deployment, etc.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1DeploymentMetadata> Deployments { get; set; }

        private string _originalCreateTimeRaw;

        private object _originalCreateTime;

        /// <summary>Optional. Timestamp indicating when the version was created at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalCreateTime")]
        public virtual string OriginalCreateTimeRaw
        {
            get => _originalCreateTimeRaw;
            set
            {
                _originalCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalCreateTimeDateTimeOffset instead.")]
        public virtual object OriginalCreateTime
        {
            get => _originalCreateTime;
            set
            {
                _originalCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalCreateTimeRaw);
            set => OriginalCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The unique identifier of the version in the system where it was originally created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalId")]
        public virtual string OriginalId { get; set; }

        private string _originalUpdateTimeRaw;

        private object _originalUpdateTime;

        /// <summary>Required. Timestamp indicating when the version was last updated at the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalUpdateTime")]
        public virtual string OriginalUpdateTimeRaw
        {
            get => _originalUpdateTimeRaw;
            set
            {
                _originalUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _originalUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OriginalUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OriginalUpdateTimeDateTimeOffset instead.")]
        public virtual object OriginalUpdateTime
        {
            get => _originalUpdateTime;
            set
            {
                _originalUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _originalUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OriginalUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OriginalUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OriginalUpdateTimeRaw);
            set => OriginalUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The specs associated with this version. Note that an API version can be associated with multiple
        /// specs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specs")]
        public virtual System.Collections.Generic.IList<GoogleCloudApihubV1SpecMetadata> Specs { get; set; }

        /// <summary>
        /// Required. Represents a version of the API resource in API hub. The ID of the version will be generated by
        /// Hub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual GoogleCloudApihubV1Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudCommonOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class GoogleCloudLocationListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
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
}
